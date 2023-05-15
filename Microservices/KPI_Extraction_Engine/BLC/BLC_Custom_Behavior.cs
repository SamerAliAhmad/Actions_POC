using System;
using System.Linq;
using SmartrTools;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;
using MongoDB.Driver;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System.Drawing;
using MongoDB.Driver.Linq;
using System.Threading;
using MongoDB.Bson;
using System.Configuration;
using System.Collections.Concurrent;
using Microsoft.VisualBasic.FileIO;
using System.Globalization;

namespace BLC
{
    public partial class BLC
    {
        #region Ticket
        #region Resolve_Ticket
        public Dictionary<string, string> Resolve_Ticket(string i_Input)
        {
            #region Declaration And Initialization Section.
            string oTicket_PlainText = string.Empty;
            Enum_BR_Codes oException_Message = Enum_BR_Codes.BR_0002; // Invalid Ticket as Default Message
            Dictionary<string, string> oList_Ticket_Parsed_Element = new Dictionary<string, string>();
            #endregion
            #region PreEvent_General
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Resolve_Ticket", i_Input, false);
            }
            #endregion
            #region Body Section.
            if (!string.IsNullOrEmpty(i_Input))
            {
                try
                {
                    oTicket_PlainText = Crypto.Decrypt(i_Input);

                    if (!string.IsNullOrEmpty(oTicket_PlainText))
                    {
                        var oList_Ticket_Element = oTicket_PlainText.Split(Global.Ticket_Separator, StringSplitOptions.RemoveEmptyEntries).Where(element => element.Contains(":"));

                        foreach (var oTicket_Element in oList_Ticket_Element)
                        {
                            var oList_Ticket_Element_Key_Value = oTicket_Element.Split(":", 2);
                            oList_Ticket_Parsed_Element.Add(oList_Ticket_Element_Key_Value[0], oList_Ticket_Element_Key_Value[1]);
                        }
                        if ((DateTime.Now - DateTime.Parse(oList_Ticket_Parsed_Element["START_DATE"])).TotalMinutes > double.Parse(oList_Ticket_Parsed_Element["SESSION_PERIOD"]))
                        {
                            oException_Message = Enum_BR_Codes.ER_0003; // Session Expired
                            throw new BLC_Exception(Get_Message_Content(oException_Message));
                        }
                    }
                }
                catch
                {
                    throw new BLC_Exception(Get_Message_Content(oException_Message));
                }
            }
            else
            {
                oList_Ticket_Parsed_Element.Add(Global.User_ID, "1");
                oList_Ticket_Parsed_Element.Add(Global.Owner_ID, "1");
            }
            #endregion
            #region PostEvent_General
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Resolve_Ticket", i_Input, false);
            }
            #endregion
            #region Return Section.
            return oList_Ticket_Parsed_Element;
            #endregion
        }
        #endregion
        #region Is_Valid_Ticket
        public bool Is_Valid_Ticket(string i_Input)
        {
            #region Declaration And Initialization Section.
            bool is_valid_ticket = false;
            #endregion
            #region PreEvent_General
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Is_Valid_Ticket", i_Input, false);
            }
            #endregion
            #region Body Section.
            try
            {
                var oTicket_Parts = Resolve_Ticket(i_Input);
                var current_date_str = Tools.GetDateString(DateTime.Today);

                if (oTicket_Parts[Global.Start_Date] == current_date_str) // Session Started In Different Day.
                {
                    var minutes_elapsed_since_midnight = (long?)(DateTime.Now - DateTime.Today).TotalMinutes;
                    if (minutes_elapsed_since_midnight <= Convert.ToInt32(oTicket_Parts[Global.Start_Minute]) + Convert.ToInt32(oTicket_Parts[Global.Session_Period]))
                    {
                        is_valid_ticket = true;
                    }
                }
            }
            catch
            {
                is_valid_ticket = false;
            }
            #endregion
            #region PostEvent_General
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Is_Valid_Ticket", i_Input, false);
            }
            #endregion
            #region Return Section.
            return is_valid_ticket;
            #endregion
        }
        #endregion
        #endregion

        #region Utils
        #region Get_Week_Of_Year
        public int Get_Week_Of_Year(Params_Get_Week_Of_Year i_Params_Get_Week_Of_Year)
        {
            DateTime time = new DateTime((int)i_Params_Get_Week_Of_Year.YEAR, (int)i_Params_Get_Week_Of_Year.MONTH, (int)i_Params_Get_Week_Of_Year.DAY);
            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(time);
            if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
            {
                time = time.AddDays(3);
            }
            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }
        #endregion
        #endregion

        #region Telus API
        #region Get_Visitor_Data
        public Visitor_Data Get_Visitor_Data(Params_Get_Visitor_Data i_Params_Get_Visitor_Data)
        {
            #region Get Data Source

            Data_source oData_source = new Data_source();
            var get_data_source = Task.Run(() =>
            {
                List<Data_source> oList_Data_source = Get_Data_source_By_OWNER_ID(new Params_Get_Data_source_By_OWNER_ID()
                {
                    OWNER_ID = oBLC_Initializer.Owner_ID
                });
                if (oList_Data_source != null && oList_Data_source.Count > 0)
                {
                    oData_source = oList_Data_source.Find(oData_source => oData_source.NAME == "Telus");
                    if (oData_source != null)
                    {
                        oData_source.API_URL = oData_source.API_URL + "/product/insightsRequest/v1/count/unique";
                    }
                }
                else
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Data Source List")); // %1 Does not Exist
                }
            });

            #endregion

            #region Get Job Type Setup Category

            Setup oSetup_Unique = new Setup();
            var get_job_setup = Task.Run(() =>
            {
                Setup_category oSetup_category = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
                {
                    SETUP_CATEGORY_NAME = "Job Type",
                    OWNER_ID = oBLC_Initializer.Owner_ID
                });
                if (oSetup_category != null)
                {
                    if (oSetup_category.List_Setup != null && oSetup_category.List_Setup.Count > 0)
                    {
                        oSetup_Unique = oSetup_category.List_Setup.Find(oSetup => oSetup.VALUE == "Unique");
                    }
                    else
                    {
                        throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Job Type Setup list")); // %1 Does not Exist
                    }
                }
                else
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Job Type Setup Category")); // %1 Does not Exist
                }
            });

            #endregion

            #region Get Telus Request ID

            string Telus_Request_Id = string.Empty;
            var get_telus_request_id = Task.Run(() =>
            {
                Service_Mesh.Default_settings oDefault_settings = this._service_mesh.Get_Default_settings_By_OWNER_ID(new Service_Mesh.Params_Get_Default_settings_By_OWNER_ID()
                {
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                }).i_Result?.FirstOrDefault();
                if (oDefault_settings != null)
                {
                    Telus_Request_Id = oDefault_settings.TELUS_REQUEST_ID;
                }
                else
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Default Settings")); // %1 Does not Exist
                }
            });

            #endregion

            #region Get Telus Customer ID

            string Telus_Customer_Id = string.Empty;
            var get_telus_customer_id = Task.Run(() =>
            {
                Telus_Customer_Id = this._service_mesh.Get_Secret(new Service_Mesh.Params_Get_Secret()
                {
                    Secret_Id = Global.Telus_Customer_Id
                }).i_Result;

                if (Telus_Customer_Id == null)
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Telus Customer ID")); // %1 Does not Exist
                }
            });

            #endregion

            Task.WaitAll(get_data_source, get_job_setup, get_telus_customer_id, get_telus_request_id);

            #region Get Job

            #region Fill Params

            if (i_Params_Get_Visitor_Data.ENUM_TIMESPAN == null)
            {
                i_Params_Get_Visitor_Data.ENUM_TIMESPAN = Enum_Timespan.X_HOURLY_COLLECTION;
            }
            if (i_Params_Get_Visitor_Data.END_DATE == null)
            {
                i_Params_Get_Visitor_Data.END_DATE = DateTime.Now;
            }
            else if (i_Params_Get_Visitor_Data.END_DATE > DateTime.Now)
            {
                i_Params_Get_Visitor_Data.END_DATE = DateTime.Now;
            }
            if (i_Params_Get_Visitor_Data.START_DATE == null)
            {
                switch (i_Params_Get_Visitor_Data.ENUM_TIMESPAN)
                {
                    case Enum_Timespan.X_HOURLY_COLLECTION:
                        i_Params_Get_Visitor_Data.START_DATE = i_Params_Get_Visitor_Data.END_DATE.Value.AddDays(-1);
                        break;
                    case Enum_Timespan.X_DAILY_COLLECTION:
                        i_Params_Get_Visitor_Data.START_DATE = i_Params_Get_Visitor_Data.END_DATE.Value.AddDays(-30);
                        break;
                    case Enum_Timespan.X_WEEKLY_COLLECTION:
                        i_Params_Get_Visitor_Data.START_DATE = i_Params_Get_Visitor_Data.END_DATE.Value.AddMonths(-3);
                        break;
                    case Enum_Timespan.X_MONTHLY_COLLECTION:
                        i_Params_Get_Visitor_Data.START_DATE = i_Params_Get_Visitor_Data.END_DATE.Value.AddYears(-1);
                        break;
                }
            }
            if (i_Params_Get_Visitor_Data.DWELL_BUCKET_TIME == null)
            {
                switch (i_Params_Get_Visitor_Data.ENUM_TIMESPAN)
                {
                    case Enum_Timespan.X_HOURLY_COLLECTION:
                        i_Params_Get_Visitor_Data.DWELL_BUCKET_TIME = 60;
                        break;
                    case Enum_Timespan.X_DAILY_COLLECTION:
                        i_Params_Get_Visitor_Data.DWELL_BUCKET_TIME = 60 * 24;
                        break;
                    case Enum_Timespan.X_WEEKLY_COLLECTION:
                        i_Params_Get_Visitor_Data.DWELL_BUCKET_TIME = 60 * 24 * 7;
                        break;
                    case Enum_Timespan.X_MONTHLY_COLLECTION:
                        i_Params_Get_Visitor_Data.DWELL_BUCKET_TIME = 60 * 24 * 30;
                        break;
                }
            }

            if (i_Params_Get_Visitor_Data.AUTH_TOKEN == null)
            {
                i_Params_Get_Visitor_Data.AUTH_TOKEN = Get_Telus_Auth_Token();
            }

            #endregion

            Job oJob = Get_Jobs_By_Where(new Params_Get_Jobs_By_Where()
            {
                REQUEST_SETUP_ID_LIST = new List<long?>() { oSetup_Unique.SETUP_ID },
                DWELL_TIME_BUCKET_LIST = new List<int?>() { i_Params_Get_Visitor_Data.DWELL_BUCKET_TIME },
                END_DATE = i_Params_Get_Visitor_Data.END_DATE,
                START_DATE = i_Params_Get_Visitor_Data.START_DATE,
                MAX_DWELL_TIME_LIST = new List<int?>() { i_Params_Get_Visitor_Data.MAX_DWELL_TIME_IN_MINUTES ?? oData_source.MAX_DWELL_TIME_IN_MINUTES },
                MIN_DWELL_TIME_LIST = new List<int?>() { i_Params_Get_Visitor_Data.MIN_DWELL_TIME_IN_MINUTES ?? oData_source.MIN_DWELL_TIME_IN_MINUTES },
                SITE_ID_LIST = i_Params_Get_Visitor_Data.SITE_LIST.Select(site => site.SITE_ID).ToList(),
                IS_EXCLUDE_NON_WORKERS = i_Params_Get_Visitor_Data.IS_EXCLUDE_NON_WORKERS,
            }).FirstOrDefault();

            #endregion

            string jobId = oJob?.JOB_REQUEST_ID;

            if (oJob == null || oJob == default)
            {
                #region Get New Job From Telus Data Source

                List<string> exclusion_types = new List<string>();
                if (i_Params_Get_Visitor_Data.IS_EXCLUDE_NON_WORKERS == true)
                {
                    exclusion_types.Add("non-workers");
                }

                string url = oData_source.API_URL;
                var client = new RestClient(url);
                var request = new RestRequest(url, Method.Post);
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("authorization", $"Bearer {i_Params_Get_Visitor_Data.AUTH_TOKEN}");
                request.AddHeader("customerId", Telus_Customer_Id);
                request.AddJsonBody(new
                {
                    input_geoid = new
                    {
                        requestId = Telus_Request_Id,
                        study_zone = i_Params_Get_Visitor_Data.SITE_LIST.Select(site => site.STUDY_ZONE_NAME).ToList(),
                    },
                    start_time = i_Params_Get_Visitor_Data.START_DATE.Value.ToString("s"),
                    end_time = i_Params_Get_Visitor_Data.END_DATE.Value.ToString("s"),
                    estimation_only = false,
                    time_bucket_size = i_Params_Get_Visitor_Data.DWELL_BUCKET_TIME,
                    max_dwell_time = i_Params_Get_Visitor_Data.MAX_DWELL_TIME_IN_MINUTES ?? oData_source.MAX_DWELL_TIME_IN_MINUTES,
                    min_dwell_time = i_Params_Get_Visitor_Data.MIN_DWELL_TIME_IN_MINUTES ?? oData_source.MIN_DWELL_TIME_IN_MINUTES,
                    exclusion_types = exclusion_types,
                });
                RestResponse response = client.Execute(request);
                if (response.StatusCode == 0)
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0034)); // This feature is currently unavailable
                }
                jobId = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(response.Content).jobId;

                if (jobId != null && jobId != default)
                {
                    oJob = new Job()
                    {
                        JOB_ID = null,
                        JOB_REQUEST_ID = jobId,
                        REQUEST_SETUP_ID = oSetup_Unique.SETUP_ID,
                        END_DATE = i_Params_Get_Visitor_Data.END_DATE,
                        START_DATE = i_Params_Get_Visitor_Data.START_DATE,
                        DWELL_TIME_BUCKET = i_Params_Get_Visitor_Data.DWELL_BUCKET_TIME,
                        MAX_DWELL_TIME = i_Params_Get_Visitor_Data.MAX_DWELL_TIME_IN_MINUTES ?? oData_source.MAX_DWELL_TIME_IN_MINUTES,
                        MIN_DWELL_TIME = i_Params_Get_Visitor_Data.MIN_DWELL_TIME_IN_MINUTES ?? oData_source.MIN_DWELL_TIME_IN_MINUTES,
                        IS_EXCLUDE_NON_WORKERS = i_Params_Get_Visitor_Data.IS_EXCLUDE_NON_WORKERS,
                        SITE_ID_LIST = i_Params_Get_Visitor_Data.SITE_LIST.Select(site => site.SITE_ID).ToList()
                    };

                    Edit_Job_List(new Params_Edit_Job_List()
                    {
                        List_Job = new List<Job>() { oJob },
                    });
                }

                #endregion
            }

            try
            {
                if (jobId == null || jobId == "")
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0038)); // Invalid Credentials or Connection Url
                }

                #region Execute Request

                string url = oData_source.API_URL + "/" + jobId;
                var client = new RestClient(url);
                var request = new RestRequest(url, Method.Get);
                request.AddHeader("authorization", $"Bearer {i_Params_Get_Visitor_Data.AUTH_TOKEN}");
                request.AddHeader("customerId", Telus_Customer_Id);
                request.AddParameter("Content-Type", "text/plain");
                Visitor_Data_Api_Response oVisitor_Data_Api_Response = new Visitor_Data_Api_Response();
                RestResponse response = client.Execute(request);

                #endregion

                oVisitor_Data_Api_Response = Visitor_Data_Api_Response.FromJson(response.Content);
                if (oVisitor_Data_Api_Response.Status == "PROCESSING")
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0043)); // Request is being processed, try again later
                }
                else if (oVisitor_Data_Api_Response.Status == "ERROR")
                {
                    Delete_Job(new Params_Delete_Job()
                    {
                        JOB_REQUEST_ID = jobId
                    });
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0048)); // Request resulting in error, jobId has been deleted, try again
                }

                #region Fill Visitor Data

                Visitor_Data oVisitor_Data = new Visitor_Data()
                {
                    STATUS = oVisitor_Data_Api_Response.Status,
                    REQUEST_ID = oVisitor_Data_Api_Response.RequestId,
                    LIST_STUDY_ZONE = oVisitor_Data_Api_Response.StudyZones.Select(study_zone => new Study_zone()
                    {
                        INPUT_GEOID = study_zone.InputGeoid,
                        List_Bucket = study_zone.Buckets.Select(bucket => new Bucket()
                        {
                            TIMEFRAME_BUCKET = bucket.TimeframeBucket.UtcDateTime,
                            COUNT = bucket.Count,
                        }).ToList(),
                    }).ToList(),
                };

                #endregion

                return oVisitor_Data;
            }
            catch (Exception ex)
            {
                throw new BLC_Exception(ex.Message); // Invalid Credentials or Connection Url
            }
        }
        #endregion
        #region Get_Demographic_Data
        public Demographic_Data Get_Demographic_Data(Params_Get_Demographic_Data i_Params_Get_Demographic_Data)
        {
            #region Get Data Source

            Data_source oData_source = new Data_source();
            var get_data_source = Task.Run(() =>
            {
                List<Data_source> oList_Data_source = Get_Data_source_By_OWNER_ID(new Params_Get_Data_source_By_OWNER_ID()
                {
                    OWNER_ID = oBLC_Initializer.Owner_ID
                });
                if (oList_Data_source != null && oList_Data_source.Count > 0)
                {
                    oData_source = oList_Data_source.Find(oData_source => oData_source.NAME == "Telus");
                    if (oData_source != null)
                    {
                        oData_source.API_URL = oData_source.API_URL + "/product/insightsRequest/v1/count/demographic";
                    }
                }
                else
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Data Source List")); // %1 Does not Exist
                }
            });

            #endregion

            #region Get Job Type Setup Category

            Setup oSetup_Demographic = new Setup();
            var get_job_setup = Task.Run(() =>
            {
                Setup_category oSetup_category = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
                {
                    SETUP_CATEGORY_NAME = "Job Type",
                    OWNER_ID = oBLC_Initializer.Owner_ID
                });
                if (oSetup_category != null)
                {
                    if (oSetup_category.List_Setup != null && oSetup_category.List_Setup.Count > 0)
                    {
                        oSetup_Demographic = oSetup_category.List_Setup.Find(oSetup => oSetup.VALUE == "Demographic");
                    }
                    else
                    {
                        throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Job Type Setup list")); // %1 Does not Exist
                    }
                }
                else
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Job Type Setup Category")); // %1 Does not Exist
                }
            });

            #endregion

            #region Get Telus Request ID

            string Telus_Request_Id = string.Empty;
            var get_telus_request_id = Task.Run(() =>
            {
                Service_Mesh.Default_settings oDefault_settings = this._service_mesh.Get_Default_settings_By_OWNER_ID(new Service_Mesh.Params_Get_Default_settings_By_OWNER_ID()
                {
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                }).i_Result?.FirstOrDefault();
                if (oDefault_settings != null)
                {
                    Telus_Request_Id = oDefault_settings.TELUS_REQUEST_ID;
                }
                else
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Default Settings")); // %1 Does not Exist
                }
            });

            #endregion

            #region Get Telus Customer ID

            string Telus_Customer_Id = string.Empty;
            var get_telus_customer_id = Task.Run(() =>
            {
                Telus_Customer_Id = this._service_mesh.Get_Secret(new Service_Mesh.Params_Get_Secret()
                {
                    Secret_Id = Global.Telus_Customer_Id
                }).i_Result;

                if (Telus_Customer_Id == null)
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Telus Customer ID")); // %1 Does not Exist
                }
            });

            #endregion

            Task.WaitAll(get_data_source, get_job_setup, get_telus_customer_id, get_telus_request_id);

            #region Get Job

            #region Fill Params

            if (i_Params_Get_Demographic_Data.ENUM_TIMESPAN == null)
            {
                i_Params_Get_Demographic_Data.ENUM_TIMESPAN = Enum_Timespan.X_HOURLY_COLLECTION;
            }
            if (i_Params_Get_Demographic_Data.END_DATE == null)
            {
                i_Params_Get_Demographic_Data.END_DATE = DateTime.Now;
            }
            else if (i_Params_Get_Demographic_Data.END_DATE > DateTime.Now)
            {
                i_Params_Get_Demographic_Data.END_DATE = DateTime.Now;
            }
            if (i_Params_Get_Demographic_Data.START_DATE == null)
            {
                switch (i_Params_Get_Demographic_Data.ENUM_TIMESPAN)
                {
                    case Enum_Timespan.X_HOURLY_COLLECTION:
                        i_Params_Get_Demographic_Data.START_DATE = i_Params_Get_Demographic_Data.END_DATE.Value.AddDays(-1);
                        break;
                    case Enum_Timespan.X_DAILY_COLLECTION:
                        i_Params_Get_Demographic_Data.START_DATE = i_Params_Get_Demographic_Data.END_DATE.Value.AddDays(-30);
                        break;
                    case Enum_Timespan.X_WEEKLY_COLLECTION:
                        i_Params_Get_Demographic_Data.START_DATE = i_Params_Get_Demographic_Data.END_DATE.Value.AddMonths(-3);
                        break;
                    case Enum_Timespan.X_MONTHLY_COLLECTION:
                        i_Params_Get_Demographic_Data.START_DATE = i_Params_Get_Demographic_Data.END_DATE.Value.AddYears(-1);
                        break;
                }
            }

            if (i_Params_Get_Demographic_Data.AUTH_TOKEN == null)
            {
                i_Params_Get_Demographic_Data.AUTH_TOKEN = Get_Telus_Auth_Token();
            }

            #endregion

            Job oJob = Get_Jobs_By_Where(new Params_Get_Jobs_By_Where()
            {
                REQUEST_SETUP_ID_LIST = new List<long?>() { oSetup_Demographic.SETUP_ID },
                END_DATE = i_Params_Get_Demographic_Data.END_DATE,
                START_DATE = i_Params_Get_Demographic_Data.START_DATE,
                MAX_DWELL_TIME_LIST = new List<int?>() { i_Params_Get_Demographic_Data.MAX_DWELL_TIME_IN_MINUTES ?? oData_source.MAX_DWELL_TIME_IN_MINUTES },
                MIN_DWELL_TIME_LIST = new List<int?>() { i_Params_Get_Demographic_Data.MIN_DWELL_TIME_IN_MINUTES ?? oData_source.MIN_DWELL_TIME_IN_MINUTES },
                SITE_ID_LIST = i_Params_Get_Demographic_Data.SITE_LIST.Select(site => site.SITE_ID).ToList()
            }).FirstOrDefault();

            #endregion

            string jobId = oJob?.JOB_REQUEST_ID;

            if (oJob == null || oJob == default)
            {
                #region Get New Job From Telus Data Source

                string url = oData_source.API_URL;
                var client = new RestClient(url);
                var request = new RestRequest(url, Method.Post);
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("authorization", $"Bearer {i_Params_Get_Demographic_Data.AUTH_TOKEN}");
                request.AddHeader("customerId", Telus_Customer_Id);
                request.AddJsonBody(new
                {
                    input_geoid = new
                    {
                        requestId = Telus_Request_Id,
                        study_zone = i_Params_Get_Demographic_Data.SITE_LIST.Select(site => site.STUDY_ZONE_NAME).ToList(),
                    },
                    start_time = i_Params_Get_Demographic_Data.START_DATE.Value.ToString("s"),
                    end_time = i_Params_Get_Demographic_Data.END_DATE.Value.ToString("s"),
                    estimation_only = false,
                    max_dwell_time = i_Params_Get_Demographic_Data.MAX_DWELL_TIME_IN_MINUTES ?? oData_source.MAX_DWELL_TIME_IN_MINUTES,
                    min_dwell_time = i_Params_Get_Demographic_Data.MIN_DWELL_TIME_IN_MINUTES ?? oData_source.MIN_DWELL_TIME_IN_MINUTES,
                });
                RestResponse response = client.Execute(request);
                if (response.StatusCode == 0)
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0034)); // This feature is currently unavailable
                }
                jobId = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(response.Content).jobId;

                if (jobId != null && jobId != default)
                {
                    oJob = new Job()
                    {
                        JOB_ID = null,
                        JOB_REQUEST_ID = jobId,
                        END_DATE = i_Params_Get_Demographic_Data.END_DATE,
                        START_DATE = i_Params_Get_Demographic_Data.START_DATE,
                        MAX_DWELL_TIME = i_Params_Get_Demographic_Data.MAX_DWELL_TIME_IN_MINUTES ?? oData_source.MAX_DWELL_TIME_IN_MINUTES,
                        MIN_DWELL_TIME = i_Params_Get_Demographic_Data.MIN_DWELL_TIME_IN_MINUTES ?? oData_source.MIN_DWELL_TIME_IN_MINUTES,
                        SITE_ID_LIST = i_Params_Get_Demographic_Data.SITE_LIST.Select(site => site.SITE_ID).ToList(),
                        REQUEST_SETUP_ID = oSetup_Demographic.SETUP_ID,
                    };

                    Edit_Job_List(new Params_Edit_Job_List()
                    {
                        List_Job = new List<Job>() { oJob },
                    });
                }

                #endregion
            }

            try
            {
                if (jobId == null || jobId == "")
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0038)); // Invalid Credentials or Connection Url
                }

                #region Execute Request

                string url = oData_source.API_URL + "/" + jobId;
                var client = new RestClient(url);
                var request = new RestRequest(url, Method.Get);
                request.AddHeader("authorization", $"Bearer {i_Params_Get_Demographic_Data.AUTH_TOKEN}");
                request.AddHeader("customerId", Telus_Customer_Id);
                request.AddParameter("Content-Type", "text/plain");
                Demographic_Data_Api_Response oDemographic_Data_Api_Response = new Demographic_Data_Api_Response();
                RestResponse response = client.Execute(request);

                #endregion

                oDemographic_Data_Api_Response = Demographic_Data_Api_Response.FromJson(response.Content);
                if (oDemographic_Data_Api_Response.Status == "PROCESSING")
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0043)); // Request is being processed, try again later
                }
                else if (oDemographic_Data_Api_Response.Status == "ERROR")
                {
                    Delete_Job(new Params_Delete_Job()
                    {
                        JOB_REQUEST_ID = jobId
                    });
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0048)); // Request resulting in error, jobId has been deleted, try again
                }

                #region Fill Demographic Data

                Demographic_Data oDemographic_Data = new Demographic_Data()
                {
                    STATUS = oDemographic_Data_Api_Response.Status,
                    REQUEST_ID = oDemographic_Data_Api_Response.RequestId,
                    LIST_STUDY_ZONE = oDemographic_Data_Api_Response.StudyZones.Select(study_zone => new Study_zone()
                    {
                        INPUT_GEOID = study_zone.InputGeoid,
                        LIST_TOPIC = study_zone.Topics.Select(topic => new Topic()
                        {
                            TOPIC = topic.Topic,
                            LIST_CHARACTERISTIC = topic.Characteristics.Select(characteristic => new Characteristic()
                            {
                                CHARACTERISTIC = characteristic.Characteristic,
                                PERCENTAGE = characteristic.Percentage
                            }).ToList(),
                        }).ToList(),
                    }).ToList(),
                };

                #endregion

                return oDemographic_Data;
            }
            catch (Exception ex)
            {
                throw new BLC_Exception(ex.Message); // Invalid Credentials or Connection Url
            }
        }
        #endregion
        #region Get_Visitor_Activity_Data
        public Visitor_Activity Get_Visitor_Activity_Data(Params_Get_Visitor_Activity_Data i_Params_Get_Visitor_Activity_Data)
        {
            #region Get Data Source

            Data_source oData_source = new Data_source();
            var get_data_source = Task.Run(() =>
            {
                List<Data_source> oList_Data_source = Get_Data_source_By_OWNER_ID(new Params_Get_Data_source_By_OWNER_ID()
                {
                    OWNER_ID = oBLC_Initializer.Owner_ID
                });
                if (oList_Data_source != null && oList_Data_source.Count > 0)
                {
                    oData_source = oList_Data_source.Find(oData_source => oData_source.NAME == "Telus");
                    if (oData_source != null)
                    {
                        oData_source.API_URL = oData_source.API_URL + "/product/insightsRequest/v1/count/destination";
                    }
                }
                else
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Data Source List")); // %1 Does not Exist
                }
            });

            #endregion

            #region Get Job Type Setup Category

            Setup oSetup_Destination = new Setup();
            var get_job_setup = Task.Run(() =>
            {
                Setup_category oSetup_category = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
                {
                    SETUP_CATEGORY_NAME = "Job Type",
                    OWNER_ID = oBLC_Initializer.Owner_ID
                });
                if (oSetup_category != null)
                {
                    if (oSetup_category.List_Setup != null && oSetup_category.List_Setup.Count > 0)
                    {
                        oSetup_Destination = oSetup_category.List_Setup.Find(oSetup => oSetup.VALUE == "Destination");
                    }
                    else
                    {
                        throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Job Type Setup list")); // %1 Does not Exist
                    }
                }
                else
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Job Type Setup Category")); // %1 Does not Exist
                }
            });

            #endregion

            #region Get Telus Request ID

            string Telus_Request_Id = string.Empty;
            var get_telus_request_id = Task.Run(() =>
            {
                Service_Mesh.Default_settings oDefault_settings = this._service_mesh.Get_Default_settings_By_OWNER_ID(new Service_Mesh.Params_Get_Default_settings_By_OWNER_ID()
                {
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                }).i_Result.FirstOrDefault();
                if (oDefault_settings != null)
                {
                    Telus_Request_Id = oDefault_settings.TELUS_REQUEST_ID;
                }
                else
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Default Settings")); // %1 Does not Exist
                }
            });

            #endregion

            #region Get Telus Customer ID

            string Telus_Customer_Id = string.Empty;
            var get_telus_customer_id = Task.Run(() =>
            {
                Telus_Customer_Id = this._service_mesh.Get_Secret(new Service_Mesh.Params_Get_Secret()
                {
                    Secret_Id = Global.Telus_Customer_Id
                }).i_Result;

                if (Telus_Customer_Id == null)
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Telus Customer ID")); // %1 Does not Exist
                }
            });

            #endregion

            Task.WaitAll(get_data_source, get_job_setup, get_telus_customer_id, get_telus_request_id);

            #region Get Job

            #region Fill Params

            if (i_Params_Get_Visitor_Activity_Data.ENUM_TIMESPAN == null)
            {
                i_Params_Get_Visitor_Activity_Data.ENUM_TIMESPAN = Enum_Timespan.X_HOURLY_COLLECTION;
            }
            if (i_Params_Get_Visitor_Activity_Data.END_DATE == null)
            {
                i_Params_Get_Visitor_Activity_Data.END_DATE = DateTime.Now;
            }
            else if (i_Params_Get_Visitor_Activity_Data.END_DATE > DateTime.Now)
            {
                i_Params_Get_Visitor_Activity_Data.END_DATE = DateTime.Now;
            }
            if (i_Params_Get_Visitor_Activity_Data.START_DATE == null)
            {
                switch (i_Params_Get_Visitor_Activity_Data.ENUM_TIMESPAN)
                {
                    case Enum_Timespan.X_HOURLY_COLLECTION:
                        i_Params_Get_Visitor_Activity_Data.START_DATE = i_Params_Get_Visitor_Activity_Data.END_DATE.Value.AddDays(-1);
                        break;
                    case Enum_Timespan.X_DAILY_COLLECTION:
                        i_Params_Get_Visitor_Activity_Data.START_DATE = i_Params_Get_Visitor_Activity_Data.END_DATE.Value.AddDays(-30);
                        break;
                    case Enum_Timespan.X_WEEKLY_COLLECTION:
                        i_Params_Get_Visitor_Activity_Data.START_DATE = i_Params_Get_Visitor_Activity_Data.END_DATE.Value.AddMonths(-3);
                        break;
                    case Enum_Timespan.X_MONTHLY_COLLECTION:
                        i_Params_Get_Visitor_Activity_Data.START_DATE = i_Params_Get_Visitor_Activity_Data.END_DATE.Value.AddYears(-1);
                        break;
                }
            }
            if (i_Params_Get_Visitor_Activity_Data.DWELL_BUCKET_TIME == null)
            {
                switch (i_Params_Get_Visitor_Activity_Data.ENUM_TIMESPAN)
                {
                    case Enum_Timespan.X_HOURLY_COLLECTION:
                        i_Params_Get_Visitor_Activity_Data.DWELL_BUCKET_TIME = 60;
                        break;
                    case Enum_Timespan.X_DAILY_COLLECTION:
                        i_Params_Get_Visitor_Activity_Data.DWELL_BUCKET_TIME = 60 * 24;
                        break;
                    case Enum_Timespan.X_WEEKLY_COLLECTION:
                        i_Params_Get_Visitor_Activity_Data.DWELL_BUCKET_TIME = 60 * 24 * 7;
                        break;
                    case Enum_Timespan.X_MONTHLY_COLLECTION:
                        i_Params_Get_Visitor_Activity_Data.DWELL_BUCKET_TIME = 60 * 24 * 30;
                        break;
                }
            }

            if (i_Params_Get_Visitor_Activity_Data.AUTH_TOKEN == null)
            {
                i_Params_Get_Visitor_Activity_Data.AUTH_TOKEN = Get_Telus_Auth_Token();
            }

            #endregion

            Job oJob = Get_Jobs_By_Where(new Params_Get_Jobs_By_Where()
            {
                REQUEST_SETUP_ID_LIST = new List<long?>() { oSetup_Destination.SETUP_ID },
                DWELL_TIME_BUCKET_LIST = new List<int?>() { i_Params_Get_Visitor_Activity_Data.DWELL_BUCKET_TIME },
                END_DATE = i_Params_Get_Visitor_Activity_Data.END_DATE,
                START_DATE = i_Params_Get_Visitor_Activity_Data.START_DATE,
                MAX_DWELL_TIME_LIST = new List<int?>() { i_Params_Get_Visitor_Activity_Data.MAX_DWELL_TIME_IN_MINUTES ?? oData_source.MAX_DWELL_TIME_IN_MINUTES },
                MIN_DWELL_TIME_LIST = new List<int?>() { i_Params_Get_Visitor_Activity_Data.MIN_DWELL_TIME_IN_MINUTES ?? oData_source.MIN_DWELL_TIME_IN_MINUTES },
                SITE_ID_LIST = i_Params_Get_Visitor_Activity_Data.SITE_LIST.Select(site => site.SITE_ID).ToList(),
            }).FirstOrDefault();

            #endregion

            string jobId = oJob?.JOB_REQUEST_ID;

            if (oJob == null || oJob == default)
            {
                #region Get New Job From Telus Data Source

                List<Service_Mesh.Ext_study_zone> oList_Ext_study_zone = this._service_mesh.Get_Ext_study_zone_By_OWNER_ID(new Service_Mesh.Params_Get_Ext_study_zone_By_OWNER_ID()
                {
                    OWNER_ID = this.oBLC_Initializer.Owner_ID,
                }).i_Result;
                string url = oData_source.API_URL;
                var client = new RestClient(url);
                var request = new RestRequest(url, Method.Post);
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("authorization", $"Bearer {i_Params_Get_Visitor_Activity_Data.AUTH_TOKEN}");
                request.AddHeader("customerId", Telus_Customer_Id);
                request.AddJsonBody(new
                {
                    input_geoid = new
                    {
                        requestId = Telus_Request_Id,
                        study_zone = oList_Ext_study_zone.Select(ext_study_zone => ext_study_zone.STUDY_ZONE_NAME).ToList(),
                    },
                    output_geoid = new
                    {
                        requestId = Telus_Request_Id,
                        study_zone = i_Params_Get_Visitor_Activity_Data.SITE_LIST.Select(site => site.STUDY_ZONE_NAME).ToList(),
                    },
                    start_time = i_Params_Get_Visitor_Activity_Data.START_DATE.Value.ToString("s"),
                    end_time = i_Params_Get_Visitor_Activity_Data.END_DATE.Value.ToString("s"),
                    estimation_only = false,
                    time_bucket_size = i_Params_Get_Visitor_Activity_Data.DWELL_BUCKET_TIME,
                    max_dwell_time = i_Params_Get_Visitor_Activity_Data.MAX_DWELL_TIME_IN_MINUTES ?? oData_source.MAX_DWELL_TIME_IN_MINUTES,
                    min_dwell_time = i_Params_Get_Visitor_Activity_Data.MIN_DWELL_TIME_IN_MINUTES ?? oData_source.MIN_DWELL_TIME_IN_MINUTES,
                });
                RestResponse response = client.Execute(request);
                if (response.StatusCode == 0)
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0034)); // This feature is currently unavailable
                }
                jobId = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(response.Content).jobId;

                if (jobId != null && jobId != default)
                {
                    oJob = new Job()
                    {
                        JOB_ID = null,
                        JOB_REQUEST_ID = jobId,
                        REQUEST_SETUP_ID = oSetup_Destination.SETUP_ID,
                        END_DATE = i_Params_Get_Visitor_Activity_Data.END_DATE,
                        START_DATE = i_Params_Get_Visitor_Activity_Data.START_DATE,
                        DWELL_TIME_BUCKET = i_Params_Get_Visitor_Activity_Data.DWELL_BUCKET_TIME,
                        MAX_DWELL_TIME = i_Params_Get_Visitor_Activity_Data.MAX_DWELL_TIME_IN_MINUTES ?? oData_source.MAX_DWELL_TIME_IN_MINUTES,
                        MIN_DWELL_TIME = i_Params_Get_Visitor_Activity_Data.MIN_DWELL_TIME_IN_MINUTES ?? oData_source.MIN_DWELL_TIME_IN_MINUTES,
                        SITE_ID_LIST = i_Params_Get_Visitor_Activity_Data.SITE_LIST.Select(site => site.SITE_ID).ToList()
                    };

                    Edit_Job_List(new Params_Edit_Job_List()
                    {
                        List_Job = new List<Job>() { oJob },
                    });
                }

                #endregion
            }

            try
            {
                if (jobId == null || jobId == "")
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0038)); // Invalid Credentials or Connection Url
                }

                #region Execute Request

                string url = oData_source.API_URL + "/" + jobId;
                var client = new RestClient(url);
                var request = new RestRequest(url, Method.Get);
                request.AddHeader("authorization", $"Bearer {i_Params_Get_Visitor_Activity_Data.AUTH_TOKEN}");
                request.AddHeader("customerId", Telus_Customer_Id);
                request.AddParameter("Content-Type", "text/plain");
                Visitor_Activity_Api_Response oVisitor_Activity_Api_Response = new Visitor_Activity_Api_Response();
                RestResponse response = client.Execute(request);

                #endregion

                oVisitor_Activity_Api_Response = Visitor_Activity_Api_Response.FromJson(response.Content);
                if (oVisitor_Activity_Api_Response.Status == "PROCESSING")
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0043)); // Request is being processed, try again later
                }
                else if (oVisitor_Activity_Api_Response.Status == "ERROR")
                {
                    Delete_Job(new Params_Delete_Job()
                    {
                        JOB_REQUEST_ID = jobId
                    });
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0048)); // Request resulting in error, jobId has been deleted, try again
                }

                #region Fill Visitor Activity

                Visitor_Activity oVisitor_Activity = new Visitor_Activity()
                {
                    STATUS = oVisitor_Activity_Api_Response.Status,
                    REQUEST_ID = oVisitor_Activity_Api_Response.RequestId,
                    LIST_STUDY_ZONE = oVisitor_Activity_Api_Response.StudyZones.Select(study_zone => new Study_zone()
                    {
                        INPUT_GEOID = study_zone.InputGeoid,
                        List_Bucket = study_zone.Buckets.Select(bucket => new Bucket()
                        {
                            TIMEFRAME_BUCKET = bucket.TimeframeBucket.UtcDateTime,
                            LIST_OUTPUT = bucket.Outputs.Select(output => new Output()
                            {
                                COUNT = output.Count,
                                OUTPUT_GEOID = output.OutputGeoid,
                                REQUEST_ID = output.RequestId,
                            }).ToList(),
                        }).ToList(),
                    }).ToList(),
                };

                #endregion

                return oVisitor_Activity;
            }
            catch (Exception ex)
            {
                throw new BLC_Exception(ex.Message); // Invalid Credentials or Connection Url
            }
        }
        #endregion
        #region Get_Telus_Auth_Token
        public string Get_Telus_Auth_Token()
        {
            string url = "https://apigw-pr.telus.com/token";
            var client = new RestClient(url);
            var request = new RestRequest(url, Method.Post);

            string grant_type = OpenIdConnectGrantTypes.ClientCredentials;
            string scope = string.Empty;
            string client_id = string.Empty;
            string client_secret = string.Empty;

            var get_scope = Task.Run(() =>
            {
                scope = this._service_mesh.Get_Secret(new Service_Mesh.Params_Get_Secret()
                {
                    Secret_Id = Global.Telus_Scope
                }).i_Result;
            });
            var get_client_id = Task.Run(() =>
            {
                client_id = this._service_mesh.Get_Secret(new Service_Mesh.Params_Get_Secret()
                {
                    Secret_Id = Global.Telus_Client_Id
                }).i_Result;
            });
            var get_client_secret = Task.Run(() =>
            {
                client_secret = this._service_mesh.Get_Secret(new Service_Mesh.Params_Get_Secret()
                {
                    Secret_Id = Global.Telus_Client_Secret
                }).i_Result;
            });

            Task.WaitAll(get_client_id, get_client_secret, get_scope);

            request.AddParameter("scope", scope);
            request.AddParameter("client_id", client_id);
            request.AddParameter("grant_type", grant_type);
            request.AddParameter("client_secret", client_secret);
            RestResponse response = client.Execute(request);
            var ACCESS_TOKEN = Newtonsoft.Json.JsonConvert.DeserializeObject<Telus_Api_Auth_Token>(response.Content)?.ACCESS_TOKEN;
            return ACCESS_TOKEN;
        }
        #endregion
        #endregion

        #region Google Places API
        #region Get_place_coordinates
        public Location Get_place_coordinates(Params_Get_place_coordinates i_Params_Get_place_coordinates)
        {
            #region Get Google_Places_API_Key

            if (i_Params_Get_place_coordinates.GOOGLE_MAP_API_TOKEN == null)
            {
                List<Default_settings> oList_Default_settings = Props.Copy_Prop_Values_From_Api_Response<List<Default_settings>>(this._service_mesh.Get_Default_settings_By_OWNER_ID(new Service_Mesh.Params_Get_Default_settings_By_OWNER_ID()
                {
                    OWNER_ID = oBLC_Initializer.Owner_ID
                }).i_Result
                );
                Default_settings oDefault_settings = new Default_settings();
                if (oList_Default_settings != null && oList_Default_settings.Count > 0)
                {
                    oDefault_settings = oList_Default_settings.FirstOrDefault();
                    i_Params_Get_place_coordinates.GOOGLE_MAP_API_TOKEN = oDefault_settings.GOOGLE_MAP_API_TOKEN;
                }
                else
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Default Settings")); // %1 Does not Exist
                }

                if (i_Params_Get_place_coordinates.GOOGLE_MAP_API_TOKEN == "" || i_Params_Get_place_coordinates.GOOGLE_MAP_API_TOKEN == null)
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046)); // Google API Token not found
                }
            }

            #endregion

            #region Get Data Source

            List<Data_source> oList_Data_source = Get_Data_source_By_OWNER_ID(new Params_Get_Data_source_By_OWNER_ID()
            {
                OWNER_ID = oBLC_Initializer.Owner_ID
            });
            Data_source oData_source = new Data_source();
            if (oList_Data_source != null && oList_Data_source.Count > 0)
            {
                oData_source = oList_Data_source.Find(oData_source => oData_source.NAME == "Google Places");
                if (oData_source != null)
                {
                    oData_source.API_URL = oData_source.API_URL + "/maps/api/place/findplacefromtext/json";
                }
                else
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Google Places Data Source")); // %1 Does not Exist
                }
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Data Source List")); // %1 Does not Exist
            }

            #endregion

            #region Execute Request

            string url = oData_source.API_URL;
            var client = new RestClient(url);
            var request = new RestRequest(url, Method.Get);
            request.AddQueryParameter("key", i_Params_Get_place_coordinates.GOOGLE_MAP_API_TOKEN);
            request.AddQueryParameter("input", i_Params_Get_place_coordinates.LOCATION_STRING);
            request.AddQueryParameter("inputtype", "textquery");
            request.AddQueryParameter("fields", "geometry");
            RestResponse response = client.Execute(request);

            #endregion

            if (response.StatusCode == 0)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0034)); // This feature is currently unavailable
            }
            dynamic dynamic_response = Newtonsoft.Json.JsonConvert.DeserializeObject(response.Content);
            try
            {
                return new Location()
                {
                    type = "Point",
                    coordinates = new List<decimal?>() { (decimal?)dynamic_response.candidates[0].geometry.location.lng, (decimal?)dynamic_response.candidates[0].geometry.location.lat },
                };
            }
            catch
            {
                return null;
            }
        }
        #endregion
        #region GetLocations
        public Tuple<double, double>[] GetLocations(double centerLatitude, double centerLongitude, double radius, int numberOfLocations)
        {
            double increment = Math.PI * (3 - Math.Sqrt(5));
            var locations = new Tuple<double, double>[numberOfLocations];

            for (int i = 0; i < numberOfLocations; i++)
            {
                double angle = i * increment;
                double distance = radius * Math.Sqrt(i / (double)numberOfLocations);
                double x = distance * Math.Cos(angle);
                double y = distance * Math.Sin(angle);

                double newLatitude = centerLatitude + y / 111111; // 1 degree latitude is approx. 111111 meters
                double newLongitude = centerLongitude + x / (111111 * Math.Cos(centerLatitude)); // 1 degree longitude is approx. 111111 meters * cos(latitude)

                locations[i] = Tuple.Create(newLatitude, newLongitude);
            }

            return locations;
        }
        #endregion
        #region Grid Polygon
        public List<Tuple<double, double>> DistributePoints(List<Tuple<double, double>> boundaryPoints, int numberOfPoints)
        {
            // Calculate bounding box
            double minLatitude = double.MaxValue;
            double maxLatitude = double.MinValue;
            double minLongitude = double.MaxValue;
            double maxLongitude = double.MinValue;

            foreach (var point in boundaryPoints)
            {
                minLatitude = Math.Min(minLatitude, point.Item1);
                maxLatitude = Math.Max(maxLatitude, point.Item1);
                minLongitude = Math.Min(minLongitude, point.Item2);
                maxLongitude = Math.Max(maxLongitude, point.Item2);
            }

            double areaWidth = maxLongitude - minLongitude;
            double areaHeight = maxLatitude - minLatitude;

            // Calculate minimum distance based on area size and number of points
            double approximateArea = areaWidth * areaHeight;
            double averageAreaPerPoint = approximateArea / numberOfPoints;
            double minimumDistance = Math.Sqrt(averageAreaPerPoint);

            int gridCellsX = (int)Math.Sqrt(numberOfPoints);
            int gridCellsY = (int)Math.Ceiling((double)numberOfPoints / gridCellsX);

            double cellWidth = areaWidth / gridCellsX;
            double cellHeight = areaHeight / gridCellsY;

            var candidateLocations = new List<Tuple<double, double>>();

            for (int i = 0; i < gridCellsX; i++)
            {
                for (int j = 0; j < gridCellsY; j++)
                {
                    double offsetX = minLongitude + (cellWidth * i) + (cellWidth / 2);
                    double offsetY = minLatitude + (cellHeight * j) + (cellHeight / 2);

                    candidateLocations.Add(Tuple.Create(offsetY, offsetX));
                }
            }

            var finalLocations = new List<Tuple<double, double>>();

            foreach (var location in candidateLocations)
            {
                if (IsPointInPolygon(boundaryPoints, location) && !IsTooCloseToOtherPoints(finalLocations, location, minimumDistance))
                {
                    finalLocations.Add(location);
                }
            }

            return finalLocations;
        }

        public static bool IsPointInPolygon(List<Tuple<double, double>> polygon, Tuple<double, double> point)
        {
            // Ray casting algorithm
            int intersectCount = 0;
            for (int i = 0; i < polygon.Count; i++)
            {
                int j = (i + 1) % polygon.Count;

                if (((polygon[i].Item2 > point.Item2) != (polygon[j].Item2 > point.Item2)) &&
                    (point.Item1 < (polygon[j].Item1 - polygon[i].Item1) * (point.Item2 - polygon[i].Item2) / (polygon[j].Item2 - polygon[i].Item2) + polygon[i].Item1))
                {
                    intersectCount++;
                }
            }

            return intersectCount % 2 == 1;
        }

        public static bool IsTooCloseToOtherPoints(List<Tuple<double, double>> points, Tuple<double, double> point, double minimumDistance)
        {
            foreach (var otherPoint in points)
            {
                double distance = HaversineDistance(point.Item1, point.Item2, otherPoint.Item1, otherPoint.Item2);
                if (distance < minimumDistance)
                {
                    return true;
                }
            }

            return false;
        }

        public static double HaversineDistance(double lat1, double lon1, double lat2, double lon2)
        {
            double earthRadius = 6371e3; // Earth's mean radius in meters

            double dLat = ToRadians(lat2 - lat1);
            double dLon = ToRadians(lon2 - lon1);
            double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                       Math.Cos(ToRadians(lat1)) * Math.Cos(ToRadians(lat2)) *
                       Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            double distance = earthRadius * c;

            return distance;
        }

        public static double ToRadians(double degrees)
        {
            return degrees * (Math.PI / 180);
        }
        #endregion
        #region Centroidal Voronoi Tessellation

        public List<Tuple<double, double>> CentroidalVoronoiTessellation(List<Tuple<double, double>> boundaryPoints, int numberOfPoints, int iterations = 100)
        {
            // Generate initial points within the bounding box
            List<Tuple<double, double>> points = GenerateRandomPoints(boundaryPoints, numberOfPoints);

            // Perform Lloyd's relaxation
            for (int i = 0; i < iterations; i++)
            {
                // Assign points to Voronoi regions
                var regions = AssignPointsToRegions(points, boundaryPoints);

                // Calculate new centroids of Voronoi regions
                List<Tuple<double, double>> newCentroids = new List<Tuple<double, double>>();

                foreach (var region in regions)
                {
                    double centroidX = 0;
                    double centroidY = 0;
                    int count = 0;

                    foreach (var point in region)
                    {
                        centroidX += point.Item1;
                        centroidY += point.Item2;
                        count++;
                    }

                    if (count > 0)
                    {
                        centroidX /= count;
                        centroidY /= count;
                        newCentroids.Add(Tuple.Create(centroidX, centroidY));
                    }
                }

                // Replace points with new centroids
                points = newCentroids;
            }

            return points;
        }

        private static List<Tuple<double, double>> GenerateRandomPoints(List<Tuple<double, double>> boundaryPoints, int numberOfPoints)
        {
            List<Tuple<double, double>> randomPoints = new List<Tuple<double, double>>();

            // Calculate bounding box
            double minLatitude = double.MaxValue;
            double maxLatitude = double.MinValue;
            double minLongitude = double.MaxValue;
            double maxLongitude = double.MinValue;

            foreach (var point in boundaryPoints)
            {
                minLatitude = Math.Min(minLatitude, point.Item1);
                maxLatitude = Math.Max(maxLatitude, point.Item1);
                minLongitude = Math.Min(minLongitude, point.Item2);
                maxLongitude = Math.Max(maxLongitude, point.Item2);
            }

            // Generate random points within the bounding box
            Random random = new Random();
            while (randomPoints.Count < numberOfPoints)
            {
                double latitude = minLatitude + (maxLatitude - minLatitude) * random.NextDouble();
                double longitude = minLongitude + (maxLongitude - minLongitude) * random.NextDouble();
                var point = Tuple.Create(latitude, longitude);

                if (IsPointInPolygon(boundaryPoints, point))
                {
                    randomPoints.Add(point);
                }
            }

            return randomPoints;
        }

        private static List<List<Tuple<double, double>>> AssignPointsToRegions(List<Tuple<double, double>> points, List<Tuple<double, double>> boundaryPoints)
        {
            // Calculate bounding box
            double minLatitude = double.MaxValue;
            double maxLatitude = double.MinValue;
            double minLongitude = double.MaxValue;
            double maxLongitude = double.MinValue;

            foreach (var point in boundaryPoints)
            {
                minLatitude = Math.Min(minLatitude, point.Item1);
                maxLatitude = Math.Max(maxLatitude, point.Item1);
                minLongitude = Math.Min(minLongitude, point.Item2);
                maxLongitude = Math.Max(maxLongitude, point.Item2);
            }

            List<List<Tuple<double, double>>> regions = new List<List<Tuple<double, double>>>();

            for (int i = 0; i < points.Count; i++)
            {
                regions.Add(new List<Tuple<double, double>>());
            }

            double stepSize = 0.0006; // Adjust the step size for better granularity

            for (double latitude = minLatitude; latitude <= maxLatitude; latitude += stepSize)
            {
                for (double longitude = minLongitude; longitude <= maxLongitude; longitude += stepSize)
                {
                    var point = Tuple.Create(latitude, longitude);
                    if (IsPointInPolygon(boundaryPoints, point))
                    {
                        int closestCentroidIndex = FindClosestCentroidIndex(point, points);
                        regions[closestCentroidIndex].Add(point);
                    }
                }
            }

            return regions;
        }


        private static int FindClosestCentroidIndex(Tuple<double, double> point, List<Tuple<double, double>> centroids)
        {
            int closestCentroidIndex = -1;
            double minDistance = double.MaxValue;

            for (int i = 0; i < centroids.Count; i++)
            {
                double distance = HaversineDistance(point.Item1, point.Item2, centroids[i].Item1, centroids[i].Item2);

                if (distance < minDistance)
                {
                    minDistance = distance;
                    closestCentroidIndex = i;
                }
            }

            return closestCentroidIndex;
        }


        #endregion
        #endregion

        #region Jobs
        #region Delete_Job
        public void Delete_Job(Params_Delete_Job i_Params_Delete_Job)
        {
            this._MongoDb.Delete_Job(
                END_DATE: i_Params_Delete_Job.END_DATE,
                START_DATE: i_Params_Delete_Job.START_DATE,
                JOB_ID_LIST: i_Params_Delete_Job.JOB_ID_LIST,
                SITE_ID_LIST: i_Params_Delete_Job.SITE_ID_LIST,
                JOB_REQUEST_ID: i_Params_Delete_Job.JOB_REQUEST_ID,
                MIN_DWELL_TIME_LIST: i_Params_Delete_Job.MIN_DWELL_TIME_LIST,
                MAX_DWELL_TIME_LIST: i_Params_Delete_Job.MAX_DWELL_TIME_LIST,
                IS_EXCLUDE_NON_WORKERS: i_Params_Delete_Job.IS_EXCLUDE_NON_WORKERS,
                DWELL_TIME_BUCKET_LIST: i_Params_Delete_Job.DWELL_TIME_BUCKET_LIST,
                REQUEST_SETUP_ID_LIST: i_Params_Delete_Job.REQUEST_SETUP_ID_LIST
            );
        }
        #endregion
        #region Edit_Job_List
        public void Edit_Job_List(Params_Edit_Job_List i_Params_Edit_Job_List)
        {
            this._MongoDb.Edit_Job_List(Props.Copy_Prop_Values_From_Api_Response<List<DALC.Job>>(i_Params_Edit_Job_List.List_Job));
        }
        #endregion
        #region Get_Jobs_By_Where
        public List<Job> Get_Jobs_By_Where(Params_Get_Jobs_By_Where i_Params_Get_Jobs_By_Where)
        {
            return Props.Copy_Prop_Values_From_Api_Response<List<Job>>(
                this._MongoDb.Get_Jobs_By_Where(
                    END_DATE: i_Params_Get_Jobs_By_Where.END_DATE,
                    START_DATE: i_Params_Get_Jobs_By_Where.START_DATE,
                    JOB_ID_LIST: i_Params_Get_Jobs_By_Where.JOB_ID_LIST,
                    SITE_ID_LIST: i_Params_Get_Jobs_By_Where.SITE_ID_LIST,
                    JOB_REQUEST_ID: i_Params_Get_Jobs_By_Where.JOB_REQUEST_ID,
                    MIN_DWELL_TIME_LIST: i_Params_Get_Jobs_By_Where.MIN_DWELL_TIME_LIST,
                    MAX_DWELL_TIME_LIST: i_Params_Get_Jobs_By_Where.MAX_DWELL_TIME_LIST,
                    IS_EXCLUDE_NON_WORKERS: i_Params_Get_Jobs_By_Where.IS_EXCLUDE_NON_WORKERS,
                    DWELL_TIME_BUCKET_LIST: i_Params_Get_Jobs_By_Where.DWELL_TIME_BUCKET_LIST,
                    REQUEST_SETUP_ID_LIST: i_Params_Get_Jobs_By_Where.REQUEST_SETUP_ID_LIST
                )
            );
        }
        #endregion
        #endregion

        #region Niche_categories
        #region Delete_Niche_categories
        public void Delete_Niche_categories(Params_Delete_Niche_categories i_Params_Delete_Niche_categories)
        {
            this._MongoDb.Delete_Niche_categories(
                BUSINESS_NICHE_LIST: i_Params_Delete_Niche_categories.BUSINESS_NICHE_LIST,
                NICHE_CATEGORIES_ID_LIST: i_Params_Delete_Niche_categories.NICHE_CATEGORIES_ID_LIST
            );
        }
        #endregion
        #region Edit_Niche_categories_List
        public void Edit_Niche_categories_List(Params_Edit_Niche_categories_List i_Params_Edit_Niche_categories_List)
        {
            this._MongoDb.Edit_Niche_categories_List(Props.Copy_Prop_Values_From_Api_Response<List<DALC.Niche_categories>>(i_Params_Edit_Niche_categories_List.List_Niche_categories));
        }
        #endregion
        #region Get_Niche_categories_By_Where
        public List<Niche_categories> Get_Niche_categories_By_Where(Params_Get_Niche_categories_By_Where i_Params_Get_Niche_categories_By_Where)
        {
            return Props.Copy_Prop_Values_From_Api_Response<List<Niche_categories>>(
                this._MongoDb.Get_Niche_categories_By_Where(
                BUSINESS_NICHE_LIST: i_Params_Get_Niche_categories_By_Where.BUSINESS_NICHE_LIST,
                NICHE_CATEGORIES_ID_LIST: i_Params_Get_Niche_categories_By_Where.NICHE_CATEGORIES_ID_LIST
                )
            );
        }
        #endregion
        #endregion

        #region Businesses, Bylaw Complaints & Public Events
        #region Is_Point_In_Polygon
        public static bool Is_Point_In_Polygon(PointF[] polygon, PointF testPoint)
        {
            bool result = false;
            int j = polygon.Length - 1;
            for (int i = 0; i < polygon.Length; i++)
            {
                if (polygon[i].Y < testPoint.Y && polygon[j].Y >= testPoint.Y || polygon[j].Y < testPoint.Y && polygon[i].Y >= testPoint.Y)
                {
                    if (polygon[i].X + (testPoint.Y - polygon[i].Y) / (polygon[j].Y - polygon[i].Y) * (polygon[j].X - polygon[i].X) < testPoint.X)
                    {
                        result = !result;
                    }
                }
                j = i;
            }
            return result;
        }
        #endregion
        #region Get_And_Fill_Businesses_From_Api
        public void Get_And_Fill_Businesses_From_Api()
        {
            #region Get Data Source

            List<Data_source> oList_Data_source = Get_Data_source_By_OWNER_ID(new Params_Get_Data_source_By_OWNER_ID()
            {
                OWNER_ID = oBLC_Initializer.Owner_ID
            });
            Data_source oData_source = new Data_source();
            if (oList_Data_source != null && oList_Data_source.Count > 0)
            {
                oData_source = oList_Data_source.Find(oData_source => oData_source.NAME == "Google Places");
                if (oData_source != null)
                {
                    oData_source.API_URL = oData_source.API_URL + "/maps/api/place/nearbysearch/json";
                }
                else
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Google Places Data Source")); // %1 Does not Exist
                }
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Data Source List")); // %1 Does not Exist
            }

            #endregion

            #region Get Data Level Setup Category

            Setup_category oSetup_category = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
            {
                SETUP_CATEGORY_NAME = "Data Level",
                OWNER_ID = oBLC_Initializer.Owner_ID
            });
            Setup oSetup_Site = new Setup();
            if (oSetup_category != null)
            {
                if (oSetup_category.List_Setup != null && oSetup_category.List_Setup.Count > 0)
                {
                    oSetup_Site = oSetup_category.List_Setup.Find(oSetup => oSetup.VALUE == "Site");
                    if (oSetup_Site == null)
                    {
                        throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Setup Site")); // %1 Does not Exist
                    }
                }
                else
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Data Level Setup list")); // %1 Does not Exist
                }
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Data Level Setup Category")); // %1 Does not Exist
            }

            #endregion

            #region Get Organization Data Source Kpi ID

            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_Adv(new Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID()
            {
                DATA_SOURCE_ID = oData_source.DATA_SOURCE_ID
            });
            Organization_data_source_kpi oBusinesses_By_Category_Organization_data_source_kpi = new Organization_data_source_kpi();
            Organization_data_source_kpi oBusinesses_Vacancy_Organization_data_source_kpi = new Organization_data_source_kpi();
            if (oList_Organization_data_source_kpi != null && oList_Organization_data_source_kpi.Count > 0)
            {
                oBusinesses_By_Category_Organization_data_source_kpi = oList_Organization_data_source_kpi.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.NAME == "Businesses By Category");
                if (oBusinesses_By_Category_Organization_data_source_kpi == null)
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Businesses By Category Kpi")); // %1 Does not Exist
                }
                oBusinesses_Vacancy_Organization_data_source_kpi = oList_Organization_data_source_kpi.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.NAME == "Businesses Vacancy");
                if (oBusinesses_Vacancy_Organization_data_source_kpi == null)
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Businesses Vacancy Kpi")); // %1 Does not Exist
                }
                oList_Organization_data_source_kpi = null;
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Edmonton Organization Data Source Kpi List")); // %1 Does not Exist
            }

            #endregion

            #region Get Google_Places_API_Key

            string Google_Places_API_Key = "";

            List<Default_settings> oList_Default_settings = Props.Copy_Prop_Values_From_Api_Response<List<Default_settings>>(this._service_mesh.Get_Default_settings_By_OWNER_ID(new Service_Mesh.Params_Get_Default_settings_By_OWNER_ID()
            {
                OWNER_ID = oBLC_Initializer.Owner_ID
            }).i_Result
            );
            Default_settings oDefault_settings = new Default_settings();
            if (oList_Default_settings != null && oList_Default_settings.Count > 0)
            {
                oDefault_settings = oList_Default_settings.FirstOrDefault();
                Google_Places_API_Key = oDefault_settings.GOOGLE_MAP_API_TOKEN;
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Default Settings")); // %1 Does not Exist
            }

            if (Google_Places_API_Key == "" || Google_Places_API_Key == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046)); // Google API Token not found
            }

            #endregion

            #region Execute Request

            string url = oData_source.API_URL;
            var client = new RestClient(url);

            #region Get Edmonton District

            District oDistrict = Get_District_By_OWNER_ID(new Params_Get_District_By_OWNER_ID()
            {
                OWNER_ID = oBLC_Initializer.Owner_ID
            }).Where(district => district.NAME == "Edmonton Main").FirstOrDefault();

            List<BsonDocument> oList_BsonDocument = Get_District_geojson();

            #endregion

            #region Declaration & Initialization

            var array = new BsonArray();
            var coordinatesArray = new BsonArray();
            var oBsonDocument = new BsonDocument();
            List<Tuple<double, double>> boundaryPoints = new List<Tuple<double, double>>();
            var oConcurrentBag_Business_Api_Response = new ConcurrentBag<Business_Api_Response>();

            #endregion

            #region Execute Request For oDistrict

            oBsonDocument = oList_BsonDocument.Find(oBsonDocument => oBsonDocument["id"].AsInt32 == oDistrict.DISTRICT_ID);
            if (oBsonDocument != null)
            {
                array = oBsonDocument["geometry"]["coordinates"].AsBsonArray;
                coordinatesArray = array.First().AsBsonArray;
                foreach (BsonValue coordinate in coordinatesArray)
                {
                    var longitude = coordinate[0].AsDouble;
                    var latitude = coordinate[1].AsDouble;

                    boundaryPoints.Add(new Tuple<double, double>(latitude, longitude));
                }
                int numberOfPoints = 220;
                var locations = CentroidalVoronoiTessellation(boundaryPoints, numberOfPoints);

                Parallel.ForEach(locations, location =>
                {
                    var request = new RestRequest(url, Method.Get);
                    request.AddParameter("key", Google_Places_API_Key);
                    request.AddParameter("location", location.Item1 + "," + location.Item2);
                    request.AddParameter("type", "business");
                    request.AddParameter("rankby", "distance");

                    var response = client.Execute(request);
                    if (response.Content != null)
                    {
                        var result2 = JsonConvert.DeserializeObject<Google_Places_Api_Response>(response.Content);

                        foreach (var oBusiness_Api_Response in result2.Results)
                        {
                            oConcurrentBag_Business_Api_Response.Add(oBusiness_Api_Response);
                        }
                        for (var i = 0; i < 2; i++)
                        {
                            if (result2.NEXT_PAGE_TOKEN != null)
                            {
                                Thread.Sleep(2000);
                                request = new RestRequest(url, Method.Get);
                                request.AddParameter("key", Google_Places_API_Key);
                                request.AddParameter("location", location.Item1 + "," + location.Item2);
                                request.AddParameter("type", "business");
                                request.AddParameter("rankby", "distance");
                                request.AddParameter("pagetoken", result2.NEXT_PAGE_TOKEN);
                                response = new RestResponse();
                                response = client.Execute(request);
                                result2 = new Google_Places_Api_Response();
                                result2 = JsonConvert.DeserializeObject<Google_Places_Api_Response>(response.Content);
                                foreach (var oBusiness_Api_Response in result2.Results)
                                {
                                    oConcurrentBag_Business_Api_Response.Add(oBusiness_Api_Response);
                                }
                            }
                        }
                    }
                });

                numberOfPoints = 30;
                locations = CentroidalVoronoiTessellation(boundaryPoints, numberOfPoints);

                Parallel.ForEach(locations, location =>
                {
                    var request = new RestRequest(url, Method.Get);
                    request.AddParameter("key", Google_Places_API_Key);
                    request.AddParameter("location", location.Item1 + "," + location.Item2);
                    request.AddParameter("type", "business");
                    request.AddParameter("rankby", "distance");
                    request.AddParameter("keyword", "permanently closed");

                    var response = client.Execute(request);
                    if (response.Content != null)
                    {
                        var result2 = JsonConvert.DeserializeObject<Google_Places_Api_Response>(response.Content);

                        foreach (var oBusiness_Api_Response in result2.Results)
                        {
                            oConcurrentBag_Business_Api_Response.Add(oBusiness_Api_Response);
                        }
                        for (var i = 0; i < 2; i++)
                        {
                            if (result2.NEXT_PAGE_TOKEN != null)
                            {
                                Thread.Sleep(2000);
                                request = new RestRequest(url, Method.Get);
                                request.AddParameter("key", Google_Places_API_Key);
                                request.AddParameter("location", location.Item1 + "," + location.Item2);
                                request.AddParameter("type", "business");
                                request.AddParameter("rankby", "distance");
                                request.AddParameter("keyword", "permanently closed");
                                request.AddParameter("pagetoken", result2.NEXT_PAGE_TOKEN);
                                response = new RestResponse();
                                response = client.Execute(request);
                                result2 = new Google_Places_Api_Response();
                                result2 = JsonConvert.DeserializeObject<Google_Places_Api_Response>(response.Content);
                                foreach (var oBusiness_Api_Response in result2.Results)
                                {
                                    oConcurrentBag_Business_Api_Response.Add(oBusiness_Api_Response);
                                }
                            }
                        }
                    }
                });
            }

            var oList_Business_Api_Response = oConcurrentBag_Business_Api_Response.DistinctBy(business_api_response => business_api_response.PLACE_ID);
            oConcurrentBag_Business_Api_Response = null;

            #endregion

            #endregion

            #region Fill List

            List<GeoData> oList_Collection_GeoData = Get_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID(new Params_Get_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID()
            {
                ORGANIZATION_DATA_SOURCE_KPI_ID = oBusinesses_By_Category_Organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                LEVEL_SETUP_ID = oSetup_Site.SETUP_ID,
                LIST_LEVEL_ID = null
            });

            List<GeoData> oList_GeoData = new List<GeoData>();

            foreach (var business in oList_Business_Api_Response)
            {
                var oGeoData_Check = oList_Collection_GeoData.Find(oGeoData => oGeoData.DATA_LIST.Find(oData => oData.NAME == "PLACE_ID").VALUE == business.PLACE_ID.ToString());
                var oGeoData = oGeoData_Check ?? new GeoData();

                var oList_DATA = new List<Data>()
                    {
                        new Data()
                        {
                            NAME = "BUSINESS_STATUS", TYPE = "string",
                            VALUE = business.BUSINESS_STATUS
                        },
                        new Data()
                        {
                            NAME = "COMPOUND_CODE", TYPE = "string",
                            VALUE = business.Plus_Code?.COMPOUND_CODE
                        },
                        new Data()
                        {
                            NAME = "GLOBAL_CODE", TYPE = "string",
                            VALUE = business.Plus_Code?.GLOBAL_CODE
                        },
                        new Data()
                        {
                            NAME = "ICON", TYPE = "string",
                            VALUE = business.ICON
                        },
                        new Data()
                        {
                            NAME = "ICON_BACKGROUND_COLOR", TYPE = "string",
                            VALUE = business.ICON_BACKGROUND_COLOR
                        },
                        new Data()
                        {
                            NAME = "ICON_MASK_BASE_URI", TYPE = "string",
                            VALUE = business.ICON_MASK_BASE_URI
                        },
                        new Data()
                        {
                            NAME = "LIST_BUSINESS_CATEGORY", TYPE = "List<string>",
                            VALUE = Newtonsoft.Json.JsonConvert.SerializeObject(business.Types)
                        },
                        new Data()
                        {
                            NAME = "NAME", TYPE = "string",
                            VALUE = business.NAME
                        },
                        new Data()
                        {
                            NAME = "OPEN_NOW", TYPE = "bool",
                            VALUE = business.Opening_Hours?.OPEN_NOW.ToString()
                        },
                        new Data()
                        {
                            NAME = "PLACE_ID", TYPE = "string",
                            VALUE = business.PLACE_ID
                        },
                        new Data()
                        {
                            NAME = "PRICE_LEVEL", TYPE = "long?",
                            VALUE = business.PRICE_LEVEL.ToString()
                        },
                        new Data()
                        {
                            NAME = "RATING", TYPE = "decimal?",
                            VALUE = business.RATING.ToString()
                        },
                        new Data()
                        {
                            NAME = "REFERENCE", TYPE = "string",
                            VALUE = business.REFERENCE
                        },
                        new Data()
                        {
                            NAME = "SCOPE", TYPE = "string",
                            VALUE = business.SCOPE
                        },
                        new Data()
                        {
                            NAME = "USER_RATINGS_TOTAL", TYPE = "long?",
                            VALUE = business.USER_RATINGS_TOTAL.ToString()
                        },
                        new Data()
                        {
                            NAME = "VICINITY", TYPE = "string",
                            VALUE = business.VICINITY
                        },
                    };
                oGeoData.GEODATA_ID = oGeoData.GEODATA_ID;
                oGeoData.ORGANIZATION_DATA_SOURCE_KPI_ID = null;
                oGeoData.LEVEL_ID = oGeoData.LEVEL_ID;
                oGeoData.LEVEL_SETUP_ID = oGeoData.LEVEL_SETUP_ID;
                oGeoData.DATE_START = null;
                oGeoData.DATE_END = null;
                oGeoData.DATA_LIST = oList_DATA;
                oGeoData.Location = new Location()
                {
                    coordinates = new List<decimal?>() { business.Geometry?.Location?.LNG, business.Geometry?.Location?.LAT },
                    type = "Point"
                };
                oList_GeoData.Add(oGeoData);
            }
            oList_Business_Api_Response = null;
            oList_Collection_GeoData = null;

            #endregion

            #region Assign Business Niche

            oList_GeoData = Set_Business_Niche(new Params_Set_Business_Niche()
            {
                LIST_GEODATA = oList_GeoData
            });

            #endregion

            #region Assign Levels & Remove Unnecessary Businesses

            oList_GeoData = Assign_Site_IDs_In_GeoData_List(new Params_Assign_Site_IDs_In_GeoData_List()
            {
                List_GeoData = oList_GeoData
            });
            oList_GeoData.RemoveAll(oGeoData => oGeoData.LEVEL_ID == null);

            #endregion

            #region Send Data

            if (oList_GeoData.Count > 0)
            {
                Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List(new Params_Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List()
                {
                    LIST_ORGANIZATION_DATA_SOURCE_KPI_ID = new List<int?>() { oBusinesses_By_Category_Organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID, oBusinesses_Vacancy_Organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID }
                });

                oList_GeoData.ForEach(oGeoData =>
                {
                    oGeoData.ORGANIZATION_DATA_SOURCE_KPI_ID = oBusinesses_By_Category_Organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID;
                });
                Edit_GeoData_List(new Params_Edit_GeoData_List()
                {
                    List_GeoData = oList_GeoData,
                });
                oList_GeoData.ForEach(oGeoData =>
                {
                    oGeoData.ORGANIZATION_DATA_SOURCE_KPI_ID = oBusinesses_Vacancy_Organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID;
                });
                Edit_GeoData_List(new Params_Edit_GeoData_List()
                {
                    List_GeoData = oList_GeoData,
                });

                oList_GeoData = Assign_Area_IDs_In_GeoData_List(new Params_Assign_Area_IDs_In_GeoData_List()
                {
                    List_GeoData = oList_GeoData
                });
                oList_GeoData.ForEach(oGeoData =>
                {
                    oGeoData.ORGANIZATION_DATA_SOURCE_KPI_ID = oBusinesses_By_Category_Organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID;
                });
                Edit_GeoData_List(new Params_Edit_GeoData_List()
                {
                    List_GeoData = oList_GeoData,
                });
                oList_GeoData.ForEach(oGeoData =>
                {
                    oGeoData.ORGANIZATION_DATA_SOURCE_KPI_ID = oBusinesses_Vacancy_Organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID;
                });
                Edit_GeoData_List(new Params_Edit_GeoData_List()
                {
                    List_GeoData = oList_GeoData,
                });

                oList_GeoData = Assign_District_IDs_In_GeoData_List(new Params_Assign_District_IDs_In_GeoData_List()
                {
                    List_GeoData = oList_GeoData
                });
                oList_GeoData.ForEach(oGeoData =>
                {
                    oGeoData.ORGANIZATION_DATA_SOURCE_KPI_ID = oBusinesses_By_Category_Organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID;
                });
                Edit_GeoData_List(new Params_Edit_GeoData_List()
                {
                    List_GeoData = oList_GeoData,
                });

                oList_GeoData.ForEach(oGeoData =>
                {
                    oGeoData.ORGANIZATION_DATA_SOURCE_KPI_ID = oBusinesses_Vacancy_Organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID;
                });
                Edit_GeoData_List(new Params_Edit_GeoData_List()
                {
                    List_GeoData = oList_GeoData,
                });
            }

            #endregion
        }
        #endregion
        #region Generate_Business_Count_And_Vancant_Business_Count
        public void Generate_Business_Count_And_Vacant_Business_Count(Params_Generate_Business_Count_And_Vacant_Business_Count i_Params_Generate_Business_Count_And_Vacant_Business_Count)
        {
            #region Declaration & Initialization

            long? Site_Setup_ID = 0;
            List<District_kpi_data> oList_District_kpi_data = new List<District_kpi_data>();
            List<Area_kpi_data> oList_Area_kpi_data = new List<Area_kpi_data>();
            List<Site_kpi_data> oList_Site_kpi_data = new List<Site_kpi_data>();
            DateTime currentDate = new DateTime(i_Params_Generate_Business_Count_And_Vacant_Business_Count.YEAR, i_Params_Generate_Business_Count_And_Vacant_Business_Count.MONTH, i_Params_Generate_Business_Count_And_Vacant_Business_Count.DAY);

            #endregion

            #region Get Setup

            List<Setup> oList_Data_Level_Setup = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
            {
                SETUP_CATEGORY_NAME = "Data Level",
                OWNER_ID = this.oBLC_Initializer.Owner_ID
            }).List_Setup;
            if (oList_Data_Level_Setup != null && oList_Data_Level_Setup.Count > 0)
            {
                Site_Setup_ID = oList_Data_Level_Setup.Find(setup => setup.VALUE == "Site").SETUP_ID;
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0045).Replace("%1", "Data Level")); // Data Level Setup Not Found
            }

            #endregion

            #region Get Organization_data_source_kpi

            var oList_Kpi = Get_Kpi_By_OWNER_ID(new Params_Get_Kpi_By_OWNER_ID()
            {
                OWNER_ID = oBLC_Initializer.Owner_ID
            });
            oList_Kpi.RemoveAll(oKpi => oKpi.NAME != "Businesses By Category" && oKpi.NAME != "Business Count" && oKpi.NAME != "Vacant Business Count");
            var oList_Organization_Data_Source_Kpi = Get_Organization_data_source_kpi_By_KPI_ID_List_Adv(new Params_Get_Organization_data_source_kpi_By_KPI_ID_List()
            {
                KPI_ID_LIST = oList_Kpi.Select(oKpi => oKpi.KPI_ID)
            });
            var Businesses_By_Category_ID = oList_Organization_Data_Source_Kpi.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.NAME == "Businesses By Category").ORGANIZATION_DATA_SOURCE_KPI_ID;
            var Business_Count_ID = oList_Organization_Data_Source_Kpi.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.NAME == "Business Count").ORGANIZATION_DATA_SOURCE_KPI_ID;
            var Vacant_Business_Count_ID = oList_Organization_Data_Source_Kpi.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.NAME == "Vacant Business Count").ORGANIZATION_DATA_SOURCE_KPI_ID;

            #endregion

            #region Get Site, Area & District

            District oDistrict = Get_District_By_OWNER_ID(new Params_Get_District_By_OWNER_ID()
            {
                OWNER_ID = oBLC_Initializer.Owner_ID
            }).Where(district => district.NAME == "Edmonton Main").FirstOrDefault();

            List<Area> oList_Area = Get_Area_By_DISTRICT_ID_Adv(new Params_Get_Area_By_DISTRICT_ID()
            {
                DISTRICT_ID = oDistrict.DISTRICT_ID,
            });

            List<Site> oList_Site = Get_Site_By_DISTRICT_ID_Adv(new Params_Get_Site_By_DISTRICT_ID()
            {
                DISTRICT_ID = oDistrict.DISTRICT_ID,
            });

            #endregion

            #region Get Business By Site

            List<Service_Mesh.Business> oList_Business = Props.Copy_Prop_Values_From_Api_Response<List<Service_Mesh.Business>>(this._service_mesh.Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID(new Service_Mesh.Params_Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID()
            {
                LIST_LEVEL_ID = null,
                LEVEL_SETUP_ID = Site_Setup_ID,
                ORGANIZATION_DATA_SOURCE_KPI_ID = Businesses_By_Category_ID
            }).i_Result);

            #endregion

            #region Fill List
            if (oList_Business.Count > 0)
            {

                #region Fill Site List

                var group_Business_List = oList_Business.GroupBy(oBusiness => oBusiness.LEVEL_ID);
                foreach (var oSite in oList_Site)
                {
                    var selected_Business_List = group_Business_List.FirstOrDefault(oBusiness => oBusiness.Key == oSite.SITE_ID);

                    var operational_business_count = selected_Business_List != null ? selected_Business_List.Where(oBusiness => oBusiness.BUSINESS_STATUS == "OPERATIONAL").Count() : 0;
                    var vacant_business_count = selected_Business_List != null ? selected_Business_List.Where(oBusiness => oBusiness.BUSINESS_STATUS != "OPERATIONAL").Count() : 0;

                    oList_Site_kpi_data.Add(new Site_kpi_data()
                    {
                        RECORD_DATE = currentDate,
                        VALUE = operational_business_count,
                        VALUE_PER_SQM = null,
                        VALUE_NAME = currentDate.ToShortDateString(),
                        SITE_METADATA = new Site_metadata()
                        {
                            CATEGORY = "Severity Type:0,Incident Category Type:0,EXT_STUDY_ZONE_ID:0",
                            SITE_ID = (long)oSite.SITE_ID,
                            ORGANIZATION_DATA_SOURCE_KPI_ID = (int)Business_Count_ID
                        }
                    });
                    oList_Site_kpi_data.Add(new Site_kpi_data()
                    {
                        RECORD_DATE = currentDate,
                        VALUE = vacant_business_count,
                        VALUE_PER_SQM = null,
                        VALUE_NAME = currentDate.ToShortDateString(),
                        SITE_METADATA = new Site_metadata()
                        {
                            CATEGORY = "Severity Type:0,Incident Category Type:0,EXT_STUDY_ZONE_ID:0",
                            SITE_ID = (long)oSite.SITE_ID,
                            ORGANIZATION_DATA_SOURCE_KPI_ID = (int)Vacant_Business_Count_ID
                        }
                    });
                }

                #endregion

                #region Fill Area List

                foreach (var oArea in oList_Area)
                {
                    var List_Site_ID = oList_Site.Where(oSite => oSite.AREA_ID == oArea.AREA_ID).Select(oSite => oSite.SITE_ID);
                    var selected_Site_kpi_data = oList_Site_kpi_data.Where(oSite_kpi_data => List_Site_ID.Any(Site_ID => Site_ID == oSite_kpi_data.SITE_METADATA.SITE_ID));

                    int operational_business_count = 0;
                    int vacant_business_count = 0;

                    foreach (var oSite_kpi_data in selected_Site_kpi_data)
                    {
                        if (oSite_kpi_data.SITE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID == Business_Count_ID)
                        {
                            operational_business_count = operational_business_count + (int)oSite_kpi_data.VALUE;
                        }
                        else
                        {
                            vacant_business_count = vacant_business_count + (int)oSite_kpi_data.VALUE;
                        }
                    }

                    oList_Area_kpi_data.Add(new Area_kpi_data()
                    {
                        RECORD_DATE = currentDate,
                        VALUE = operational_business_count,
                        VALUE_PER_SQM = null,
                        VALUE_NAME = currentDate.ToShortDateString(),
                        AREA_METADATA = new Area_metadata()
                        {
                            CATEGORY = "Severity Type:0,Incident Category Type:0,EXT_STUDY_ZONE_ID:0",
                            AREA_ID = (int)oArea.AREA_ID,
                            ORGANIZATION_DATA_SOURCE_KPI_ID = (int)Business_Count_ID
                        }
                    });

                    oList_Area_kpi_data.Add(new Area_kpi_data()
                    {
                        RECORD_DATE = currentDate,
                        VALUE = vacant_business_count,
                        VALUE_PER_SQM = null,
                        VALUE_NAME = currentDate.ToShortDateString(),
                        AREA_METADATA = new Area_metadata()
                        {
                            CATEGORY = "Severity Type:0,Incident Category Type:0,EXT_STUDY_ZONE_ID:0",
                            AREA_ID = (int)oArea.AREA_ID,
                            ORGANIZATION_DATA_SOURCE_KPI_ID = (int)Vacant_Business_Count_ID
                        }
                    });
                }

                #endregion

                #region Fill District

                List<District> oList_District = new List<District>() { oDistrict };

                foreach (var _District in oList_District)
                {
                    var List_Area_ID = oList_Area.Where(oArea => oArea.DISTRICT_ID == _District.DISTRICT_ID).Select(oArea => oArea.AREA_ID);
                    var selected_Area_kpi_data = oList_Area_kpi_data.Where(oArea_kpi_data => List_Area_ID.Any(Area_ID => Area_ID == oArea_kpi_data.AREA_METADATA.AREA_ID));

                    int operational_business_count = 0;
                    int vacant_business_count = 0;

                    foreach (var oArea_kpi_data in selected_Area_kpi_data)
                    {
                        if (oArea_kpi_data.AREA_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID == Business_Count_ID)
                        {
                            operational_business_count = operational_business_count + (int)oArea_kpi_data.VALUE;
                        }
                        else
                        {
                            vacant_business_count = vacant_business_count + (int)oArea_kpi_data.VALUE;
                        }
                    }

                    oList_District_kpi_data.Add(new District_kpi_data()
                    {
                        RECORD_DATE = currentDate,
                        VALUE = operational_business_count,
                        VALUE_PER_SQM = null,
                        VALUE_NAME = currentDate.ToShortDateString(),
                        DISTRICT_METADATA = new District_metadata()
                        {
                            CATEGORY = "Severity Type:0,Incident Category Type:0,EXT_STUDY_ZONE_ID:0",
                            DISTRICT_ID = (int)_District.DISTRICT_ID,
                            ORGANIZATION_DATA_SOURCE_KPI_ID = (int)Business_Count_ID
                        }
                    });

                    oList_District_kpi_data.Add(new District_kpi_data()
                    {
                        RECORD_DATE = currentDate,
                        VALUE = vacant_business_count,
                        VALUE_PER_SQM = null,
                        VALUE_NAME = currentDate.ToShortDateString(),
                        DISTRICT_METADATA = new District_metadata()
                        {
                            CATEGORY = "Severity Type:0,Incident Category Type:0,EXT_STUDY_ZONE_ID:0",
                            DISTRICT_ID = (int)_District.DISTRICT_ID,
                            ORGANIZATION_DATA_SOURCE_KPI_ID = (int)Vacant_Business_Count_ID
                        }
                    });
                }
                #endregion
            }

            #endregion

            #region Send Data

            try
            {
                if (oList_Site_kpi_data.Count > 0)
                {
                    Edit_Site_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN(new Params_Edit_Site_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN()
                    {
                        LIST_SITE_KPI_DATA = oList_Site_kpi_data,
                        LIST_ORGANIZATION_DATA_SOURCE_KPI_ID = new List<int?>() { Business_Count_ID, Vacant_Business_Count_ID },
                        RECORD_DATE = currentDate,
                        ENUM_TIMESPAN = Enum_Timespan.X_DAILY_COLLECTION
                    });
                }
            }
            catch (Exception ex)
            {
                throw new BLC_Exception(ex.Message);
            }

            try
            {
                if (oList_Area_kpi_data.Count > 0)
                {
                    Edit_Area_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN(new Params_Edit_Area_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN()
                    {
                        LIST_AREA_KPI_DATA = oList_Area_kpi_data,
                        LIST_ORGANIZATION_DATA_SOURCE_KPI_ID = new List<int?>() { Business_Count_ID, Vacant_Business_Count_ID },
                        RECORD_DATE = currentDate,
                        ENUM_TIMESPAN = Enum_Timespan.X_DAILY_COLLECTION
                    });
                }
            }
            catch (Exception ex)
            {
                throw new BLC_Exception(ex.Message);
            }

            try
            {
                if (oList_District_kpi_data.Count > 0)
                {
                    Edit_District_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN(new Params_Edit_District_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN()
                    {
                        LIST_DISTRICT_KPI_DATA = oList_District_kpi_data,
                        LIST_ORGANIZATION_DATA_SOURCE_KPI_ID = new List<int?>() { Business_Count_ID, Vacant_Business_Count_ID },
                        RECORD_DATE = currentDate,
                        ENUM_TIMESPAN = Enum_Timespan.X_DAILY_COLLECTION
                    });
                }
            }
            catch (Exception ex)
            {
                throw new BLC_Exception(ex.Message);
            }

            #endregion
        }
        #endregion
        #region Set_Business_Niche
        public List<GeoData> Set_Business_Niche(Params_Set_Business_Niche i_Params_Set_Business_Niche)
        {
            // Define the categories for each niche
            List<Niche_categories> oList_Niche_categories = Get_Niche_categories_By_Where(new Params_Get_Niche_categories_By_Where());

            // Define the default niche
            string defaultNiche = "Miscellaneous";

            // Set the BUSINESS_NICHE for each Business based on its categories
            foreach (GeoData oGeoData in i_Params_Set_Business_Niche.LIST_GEODATA)
            {
                string Business_Category_String = oGeoData.DATA_LIST.Find(oData => oData.NAME == "LIST_BUSINESS_CATEGORY").VALUE;
                List<string> LIST_BUSINESS_CATEGORY = Newtonsoft.Json.JsonConvert.DeserializeObject<List<string>>(Business_Category_String);

                // Find the niche with the most categories that match the Business's categories
                string businessNiche = oList_Niche_categories
                    .Where(niche_categories => niche_categories.CATEGORY_LIST.Intersect(LIST_BUSINESS_CATEGORY).Count() > 0) // check if there are any common categories
                    .OrderByDescending(niche_categories => niche_categories.CATEGORY_LIST.Intersect(LIST_BUSINESS_CATEGORY).Count())
                    .FirstOrDefault()?
                    .BUSINESS_NICHE;

                // Set the BUSINESS_NICHE to the found niche or the default niche
                Data oData = new Data()
                {
                    NAME = "BUSINESS_NICHE",
                    TYPE = "string",
                    VALUE = businessNiche ?? defaultNiche
                };

                oGeoData.DATA_LIST.Add(oData);
            }

            return i_Params_Set_Business_Niche.LIST_GEODATA;
        }
        #endregion
        #region Get_And_Fill_Bylaw_complaints_From_Api
        public void Get_And_Fill_Bylaw_complaints_From_Api(Params_Get_And_Fill_Bylaw_complaints_From_Api i_Params_Get_And_Fill_Bylaw_complaints_From_Api)
        {
            #region Get Data Source

            List<Data_source> oList_Data_source = Get_Data_source_By_OWNER_ID(new Params_Get_Data_source_By_OWNER_ID()
            {
                OWNER_ID = oBLC_Initializer.Owner_ID
            });
            Data_source oData_source = new Data_source();
            if (oList_Data_source != null && oList_Data_source.Count > 0)
            {
                oData_source = oList_Data_source.Find(oData_source => oData_source.NAME == "Edmonton");
                if (oData_source != null)
                {
                    oData_source.API_URL = oData_source.API_URL + "/resource/ypje-j649.json";
                }
                else
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Edmonton Data Source")); // %1 Does not Exist
                }
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Data Source List")); // %1 Does not Exist
            }

            #endregion

            #region Get Organization Data Source Kpi ID

            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_Adv(new Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID()
            {
                DATA_SOURCE_ID = oData_source.DATA_SOURCE_ID
            });
            Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
            if (oList_Organization_data_source_kpi != null && oList_Organization_data_source_kpi.Count > 0)
            {
                oOrganization_data_source_kpi = oList_Organization_data_source_kpi.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.NAME == "Bylaw Complaints");
                if (oOrganization_data_source_kpi == null)
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Bylaw Complaints Kpi")); // %1 Does not Exist
                }
                oList_Organization_data_source_kpi = null;
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Edmonton Organization Data Source Kpi List")); // %1 Does not Exist
            }

            #endregion

            #region Get Secret

            string edmonton_api_key = this._service_mesh.Get_Secret(new Service_Mesh.Params_Get_Secret()
            {
                Secret_Id = Global.Edmonton_Api_Key
            }).i_Result;

            #endregion

            #region Execute Request

            string url = oData_source.API_URL;
            var client = new RestClient(url);
            var request = new RestRequest(url, Method.Get);
            request.AddHeader("Content-Type", "application/json");
            request.AddQueryParameter("$$app_token", edmonton_api_key);
            request.AddQueryParameter("$limit", 5000000);
            if (i_Params_Get_And_Fill_Bylaw_complaints_From_Api.DATE_CREATED_START_DATE != null)
            {
                request.AddQueryParameter("$where", $"date_created >= '{i_Params_Get_And_Fill_Bylaw_complaints_From_Api.DATE_CREATED_START_DATE.Value.ToString("s")}'");
            }
            RestResponse response = client.Execute(request);
            if (response.StatusCode == 0)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0034)); // This feature is currently unavailable
            }
            var bylaw_complaints = Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<dynamic>>(response.Content);

            #endregion

            #region Fill List

            List<GeoData> oList_GeoData = new List<GeoData>();

            foreach (var bylaw_complaint in bylaw_complaints)
            {
                if (bylaw_complaint.location != null)
                {
                    DateTime oCreated_date = bylaw_complaint.date_created;
                    try
                    {
                        oCreated_date = DateTime.SpecifyKind(oCreated_date, DateTimeKind.Utc);
                    }
                    catch (Exception ex)
                    {
                        throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0053).Replace("%1", ex.Message));
                    }
                    var oList_DATA = new List<Data>()
                    {
                        new Data()
                        {
                            NAME = "ROW_ID",
                            TYPE = "string",
                            VALUE = bylaw_complaint.row_id
                        },
                        new Data()
                        {
                            NAME = "YEAR",
                            TYPE = "string",
                            VALUE = bylaw_complaint.year
                        },
                        new Data()
                        {
                            NAME = "MONTH",
                            TYPE = "string",
                            VALUE = bylaw_complaint.month
                        },
                        new Data()
                        {
                            NAME = "COMPLAINT_CATEGORY",
                            TYPE = "string",
                            VALUE = bylaw_complaint.complaint_category
                        },
                        new Data()
                        {
                            NAME = "TYPE_OF_COMPLAINT",
                            TYPE = "string",
                            VALUE = bylaw_complaint.type_of_complaint
                        },
                        new Data()
                        {
                            NAME = "WAS_CANNABIS_INVOLVED",
                            TYPE = "string",
                            VALUE = bylaw_complaint.was_cannabis_involved
                        },
                        new Data()
                        {
                            NAME = "OFFICER_INITIATED",
                            TYPE = "string",
                            VALUE = bylaw_complaint.officer_initiated
                        },
                        new Data()
                        {
                            NAME = "INFRACTION_STATUS",
                            TYPE = "string",
                            VALUE = bylaw_complaint.infraction_status
                        },
                        new Data()
                        {
                            NAME = "NEIGHBOURHOOD_ID",
                            TYPE = "string",
                            VALUE = bylaw_complaint.neighbourhood_id
                        },
                        new Data()
                        {
                            NAME = "NEIGHBOURHOOD",
                            TYPE = "string",
                            VALUE = bylaw_complaint.neighbourhood
                        },
                        new Data()
                        {
                            NAME = "FULL_NAME_OF_STREET",
                            TYPE = "string",
                            VALUE = bylaw_complaint.full_name_of_street
                        },
                        new Data()
                        {
                            NAME = "COUNT",
                            TYPE = "string",
                            VALUE = bylaw_complaint.count
                        }
                    };
                    oList_GeoData.Add(new GeoData()
                    {
                        GEODATA_ID = null,
                        LEVEL_SETUP_ID = null,
                        LEVEL_ID = null,
                        DATE_START = oCreated_date,
                        DATE_END = null,
                        ORGANIZATION_DATA_SOURCE_KPI_ID = oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                        Location = bylaw_complaint.location != null ? new Location()
                        {
                            coordinates = new List<decimal?>() { (decimal?)bylaw_complaint.location.longitude, (decimal?)bylaw_complaint.location.latitude },
                            type = "Point"
                        } : null,
                        DATA_LIST = oList_DATA
                    });
                }
            }

            bylaw_complaints = null;

            #endregion

            #region Assign Levels & Remove Unnecessary Bylaw Complaints

            oList_GeoData = Assign_Site_IDs_In_GeoData_List(new Params_Assign_Site_IDs_In_GeoData_List()
            {
                List_GeoData = oList_GeoData
            });
            oList_GeoData.RemoveAll(oGeoData => oGeoData.LEVEL_ID == null);

            #endregion

            #region Send Data

            if (oList_GeoData.Count > 0)
            {
                #region Get First Date

                DateTime Start_Date = oList_GeoData.Min(oGeoData => oGeoData.DATE_START.Value.Date);

                #endregion

                Edit_GeoData_List(new Params_Edit_GeoData_List()
                {
                    List_GeoData = oList_GeoData,
                });
                #region Calculate & Save Alerts

                Task.Run(() =>
                {
                    #region Get First Date

                    var oFirst_GeoData_Date = new DateTime(Start_Date.Year, Start_Date.Month, Start_Date.Day, Start_Date.Hour, Start_Date.Minute, Start_Date.Second);

                    #endregion

                    #region Declaration & Initialization

                    long? Site_Setup_ID = 0;
                    List<Site> oList_Site = new List<Site>();
                    List<Alert> oList_Alert = new List<Alert>();
                    List<Alert_settings> oList_Alert_settings = new List<Alert_settings>();

                    #endregion

                    #region Get Site Setup

                    var get_site_setup = Task.Run(() =>
                    {
                        List<Setup> oList_Data_Level_Setup = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
                        {
                            SETUP_CATEGORY_NAME = "Data Level",
                            OWNER_ID = this.oBLC_Initializer.Owner_ID
                        }).List_Setup;
                        if (oList_Data_Level_Setup != null && oList_Data_Level_Setup.Count > 0)
                        {
                            Site_Setup_ID = oList_Data_Level_Setup.Find(setup => setup.VALUE == "Site").SETUP_ID;
                        }
                        else
                        {
                            throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0045).Replace("%1", "Data Level")); // Data Level Setup Not Found
                        }
                    });


                    #endregion

                    #region Get Alert Settings

                    var get_alert_settings = Task.Run(() =>
                    {
                        oList_Alert_settings = Props.Copy_Prop_Values_From_Api_Response<List<Alert_settings>>(
                        this._service_mesh.Get_Alert_settings_By_OWNER_ID_Adv(new Service_Mesh.Params_Get_Alert_settings_By_OWNER_ID()
                        {
                            OWNER_ID = this.oBLC_Initializer.Owner_ID
                        }).i_Result.Where(alert_settings => alert_settings.IS_ACTIVE == true && alert_settings.KPI_ID == oOrganization_data_source_kpi.Kpi.KPI_ID)
                    );
                    });

                    #endregion

                    #region Get Site List

                    var get_site_list = Task.Run(() =>
                    {
                        oList_Site = Get_Site_By_OWNER_ID(new Params_Get_Site_By_OWNER_ID()
                        {
                            OWNER_ID = this.oBLC_Initializer.Owner_ID
                        });
                    });

                    #endregion

                    Task.WaitAll(get_site_setup, get_alert_settings, get_site_list);

                    #region Get New GeoData List

                    List<GeoData> oList_New_GeoData = Get_GeoData_By_Where(new Params_Get_GeoData_By_Where()
                    {
                        START_DATE = oFirst_GeoData_Date,
                        LEVEL_SETUP_ID = Site_Setup_ID,
                        LIST_LEVEL_ID = null,
                        ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = new List<int?>() { oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID },
                    });

                    #endregion

                    #region Fill List

                    while (oFirst_GeoData_Date < DateTime.Now.Date)
                    {
                        var oList_Old_GeoData = oList_New_GeoData.Where(oGeoData => oGeoData.DATE_START >= oFirst_GeoData_Date.AddDays(-7) && oGeoData.DATE_START < oFirst_GeoData_Date).ToList();
                        var oList_Current_GeoData = oList_New_GeoData.Where(oGeoData => oGeoData.DATE_START.Value.Date == oFirst_GeoData_Date).ToList();

                        decimal oOld_Site_GeoData_Count;
                        decimal oCurrent_Site_GeoData_Count;

                        var oList_Level_id_with_percent = new List<Level_id_with_percent>();

                        foreach (var oSite in oList_Site)
                        {
                            oOld_Site_GeoData_Count = oList_Old_GeoData.Count(oGeoData => oGeoData.LEVEL_ID == oSite.SITE_ID);
                            oCurrent_Site_GeoData_Count = oList_Current_GeoData.Count(oGeoData => oGeoData.LEVEL_ID == oSite.SITE_ID);
                            if (oCurrent_Site_GeoData_Count == 0 && oOld_Site_GeoData_Count == 0)
                            {
                                oList_Level_id_with_percent.Add(new Level_id_with_percent()
                                {
                                    VALUE = oCurrent_Site_GeoData_Count,
                                    LEVEL_ID = oSite.SITE_ID,
                                    Site = oSite,
                                    PERCENT_INCREASE = 0,
                                });
                            }
                            else
                            {
                                decimal oOld_Site_GeoData_Average = (decimal)oOld_Site_GeoData_Count / 7;
                                oList_Level_id_with_percent.Add(new Level_id_with_percent()
                                {
                                    VALUE = oCurrent_Site_GeoData_Count,
                                    LEVEL_ID = oSite.SITE_ID,
                                    Site = oSite,
                                    PERCENT_INCREASE = Math.Round(oOld_Site_GeoData_Count == 0 ? 100 : ((oCurrent_Site_GeoData_Count - oOld_Site_GeoData_Average) / oOld_Site_GeoData_Average) * 100, 2),
                                });
                            }
                        };
                        foreach (var alert_settings in oList_Alert_settings)
                        {
                            foreach (var level_id_with_percent_increase in oList_Level_id_with_percent)
                            {
                                bool isEdit = false;

                                switch (alert_settings.Value_type_setup.VALUE)
                                {
                                    case "Tolerance":
                                        switch (alert_settings.Operation_setup.VALUE)
                                        {
                                            case "Spike":
                                                if (level_id_with_percent_increase.PERCENT_INCREASE >= alert_settings.VALUE)
                                                {
                                                    isEdit = true;
                                                }
                                                break;
                                            case "Drop":
                                                if (level_id_with_percent_increase.PERCENT_INCREASE <= -alert_settings.VALUE)
                                                {
                                                    isEdit = true;
                                                }
                                                break;
                                        }
                                        break;
                                    case "Threshold":
                                        switch (alert_settings.Operation_setup.VALUE)
                                        {
                                            case "Spike":
                                                if (level_id_with_percent_increase.VALUE >= alert_settings.VALUE)
                                                {
                                                    isEdit = true;
                                                }
                                                break;
                                            case "Drop":
                                                if (level_id_with_percent_increase.VALUE <= -alert_settings.VALUE)
                                                {
                                                    isEdit = true;
                                                }
                                                break;
                                        }
                                        break;
                                }
                                if (isEdit)
                                {
                                    oList_Alert.Add(new Alert()
                                    {
                                        USER_ID = alert_settings.USER_ID,
                                        LEVEL_ID = level_id_with_percent_increase.LEVEL_ID,
                                        ORGANIZATION_DATA_SOURCE_KPI_ID = oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                        LEVEL_SETUP_ID = Site_Setup_ID,
                                        RECORD_DATE = oFirst_GeoData_Date,
                                        IS_ACKNOWLEDGED = false,
                                        ALERT_VALUE = Math.Abs(level_id_with_percent_increase.PERCENT_INCREASE.Value),
                                        VALUE_PASSED = alert_settings.VALUE,
                                        VALUE_TYPE_SETUP_ID = alert_settings.Value_type_setup.SETUP_ID,
                                        OPERATION_TYPE_SETUP_ID = alert_settings.Operation_setup.SETUP_ID
                                    });
                                }
                            };
                        };
                        oFirst_GeoData_Date = oFirst_GeoData_Date.AddDays(1);
                    }

                    #endregion

                    #region Check If Old Data Exists

                    List<Alert> oList_Old_Alert = Get_Alerts_By_Where(new Params_Get_Alerts_By_Where()
                    {
                        START_DATE = oFirst_GeoData_Date,
                        LEVEL_SETUP_ID = Site_Setup_ID,
                        ORGANIZATION_DATA_SOURCE_KPI_ID = oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID

                    });

                    foreach (var alert in oList_Old_Alert)
                    {
                        if (oList_Alert.Any(oAlert => oAlert.RECORD_DATE.Value.Date == alert.RECORD_DATE.Value.Date))
                        {
                            var oCommon_Alert = oList_Alert.Find(oAlert => oAlert.RECORD_DATE.Value.Date == alert.RECORD_DATE.Value.Date && oAlert.LEVEL_ID == alert.LEVEL_ID && oAlert.LEVEL_SETUP_ID == alert.LEVEL_SETUP_ID);
                            if (oCommon_Alert != null)
                            {
                                oCommon_Alert.ALERT_ID = alert.ALERT_ID;
                            }
                        }
                    };

                    oList_Old_Alert = null;

                    #endregion

                    #region Send Data

                    Edit_Alert_List(new Params_Edit_Alert_List()
                    {
                        List_Alert = oList_Alert,
                    });

                    #endregion
                });

                #endregion

                oList_GeoData = Assign_Area_IDs_In_GeoData_List(new Params_Assign_Area_IDs_In_GeoData_List()
                {
                    List_GeoData = oList_GeoData
                });
                Edit_GeoData_List(new Params_Edit_GeoData_List()
                {
                    List_GeoData = oList_GeoData,
                });
                #region Calculate & Save Alerts

                Task.Run(() =>
                {
                    #region Get First Date

                    var oFirst_GeoData_Date = new DateTime(Start_Date.Year, Start_Date.Month, Start_Date.Day, Start_Date.Hour, Start_Date.Minute, Start_Date.Second);

                    #endregion

                    #region Declaration & Initialization

                    long? Area_Setup_ID = 0;
                    List<Area> oList_Area = new List<Area>();
                    List<Alert> oList_Alert = new List<Alert>();
                    List<Alert_settings> oList_Alert_settings = new List<Alert_settings>();

                    #endregion

                    #region Get Area Setup

                    var get_area_setup = Task.Run(() =>
                    {
                        List<Setup> oList_Data_Level_Setup = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
                        {
                            SETUP_CATEGORY_NAME = "Data Level",
                            OWNER_ID = this.oBLC_Initializer.Owner_ID
                        }).List_Setup;
                        if (oList_Data_Level_Setup != null && oList_Data_Level_Setup.Count > 0)
                        {
                            Area_Setup_ID = oList_Data_Level_Setup.Find(setup => setup.VALUE == "Area").SETUP_ID;
                        }
                        else
                        {
                            throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0045).Replace("%1", "Data Level")); // Data Level Setup Not Found
                        }
                    });


                    #endregion

                    #region Get Alert Settings

                    var get_alert_settings = Task.Run(() =>
                    {
                        oList_Alert_settings = Props.Copy_Prop_Values_From_Api_Response<List<Alert_settings>>(
                        this._service_mesh.Get_Alert_settings_By_OWNER_ID_Adv(new Service_Mesh.Params_Get_Alert_settings_By_OWNER_ID()
                        {
                            OWNER_ID = this.oBLC_Initializer.Owner_ID
                        }).i_Result.Where(alert_settings => alert_settings.IS_ACTIVE == true && alert_settings.KPI_ID == oOrganization_data_source_kpi.Kpi.KPI_ID)
                    );
                    });

                    #endregion

                    #region Get Area List

                    var get_area_list = Task.Run(() =>
                    {
                        oList_Area = Get_Area_By_OWNER_ID(new Params_Get_Area_By_OWNER_ID()
                        {
                            OWNER_ID = this.oBLC_Initializer.Owner_ID
                        });
                    });

                    #endregion

                    Task.WaitAll(get_area_setup, get_alert_settings, get_area_list);

                    #region Get New GeoData List

                    List<GeoData> oList_New_GeoData = Get_GeoData_By_Where(new Params_Get_GeoData_By_Where()
                    {
                        START_DATE = oFirst_GeoData_Date,
                        LEVEL_SETUP_ID = Area_Setup_ID,
                        LIST_LEVEL_ID = null,
                        ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = new List<int?>() { oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID },
                    });

                    #endregion

                    #region Fill List

                    while (oFirst_GeoData_Date < DateTime.Now.Date)
                    {
                        var oList_Old_GeoData = oList_New_GeoData.Where(oGeoData => oGeoData.DATE_START >= oFirst_GeoData_Date.AddDays(-7) && oGeoData.DATE_START < oFirst_GeoData_Date).ToList();
                        var oList_Current_GeoData = oList_New_GeoData.Where(oGeoData => oGeoData.DATE_START.Value.Date == oFirst_GeoData_Date).ToList();

                        decimal oOld_Area_GeoData_Count;
                        decimal oCurrent_Area_GeoData_Count;

                        var oList_Level_id_with_percent = new List<Level_id_with_percent>();

                        foreach (var oArea in oList_Area)
                        {
                            oOld_Area_GeoData_Count = oList_Old_GeoData.Count(oGeoData => oGeoData.LEVEL_ID == oArea.AREA_ID);
                            oCurrent_Area_GeoData_Count = oList_Current_GeoData.Count(oGeoData => oGeoData.LEVEL_ID == oArea.AREA_ID);
                            if (oCurrent_Area_GeoData_Count == 0 && oOld_Area_GeoData_Count == 0)
                            {
                                oList_Level_id_with_percent.Add(new Level_id_with_percent()
                                {
                                    VALUE = oCurrent_Area_GeoData_Count,
                                    LEVEL_ID = oArea.AREA_ID,
                                    Area = oArea,
                                    PERCENT_INCREASE = 0,
                                });
                            }
                            else
                            {
                                decimal oOld_Area_GeoData_Average = (decimal)oOld_Area_GeoData_Count / 7;
                                oList_Level_id_with_percent.Add(new Level_id_with_percent()
                                {
                                    VALUE = oCurrent_Area_GeoData_Count,
                                    LEVEL_ID = oArea.AREA_ID,
                                    Area = oArea,
                                    PERCENT_INCREASE = Math.Round(oOld_Area_GeoData_Count == 0 ? 100 : ((oCurrent_Area_GeoData_Count - oOld_Area_GeoData_Average) / oOld_Area_GeoData_Average) * 100, 2),
                                });
                            }
                        }
                        foreach (var alert_settings in oList_Alert_settings)
                        {
                            foreach (var level_id_with_percent_increase in oList_Level_id_with_percent)
                            {
                                bool isEdit = false;

                                switch (alert_settings.Value_type_setup.VALUE)
                                {
                                    case "Tolerance":
                                        switch (alert_settings.Operation_setup.VALUE)
                                        {
                                            case "Spike":
                                                if (level_id_with_percent_increase.PERCENT_INCREASE >= alert_settings.VALUE)
                                                {
                                                    isEdit = true;
                                                }
                                                break;
                                            case "Drop":
                                                if (level_id_with_percent_increase.PERCENT_INCREASE <= -alert_settings.VALUE)
                                                {
                                                    isEdit = true;
                                                }
                                                break;
                                        }
                                        break;
                                    case "Threshold":
                                        switch (alert_settings.Operation_setup.VALUE)
                                        {
                                            case "Spike":
                                                if (level_id_with_percent_increase.VALUE >= alert_settings.VALUE)
                                                {
                                                    isEdit = true;
                                                }
                                                break;
                                            case "Drop":
                                                if (level_id_with_percent_increase.VALUE <= -alert_settings.VALUE)
                                                {
                                                    isEdit = true;
                                                }
                                                break;
                                        }
                                        break;
                                }
                                if (isEdit)
                                {
                                    oList_Alert.Add(new Alert()
                                    {
                                        USER_ID = alert_settings.USER_ID,
                                        LEVEL_ID = level_id_with_percent_increase.LEVEL_ID,
                                        ORGANIZATION_DATA_SOURCE_KPI_ID = oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                        LEVEL_SETUP_ID = Area_Setup_ID,
                                        RECORD_DATE = oFirst_GeoData_Date,
                                        IS_ACKNOWLEDGED = false,
                                        ALERT_VALUE = Math.Abs(level_id_with_percent_increase.PERCENT_INCREASE.Value),
                                        VALUE_PASSED = alert_settings.VALUE,
                                        VALUE_TYPE_SETUP_ID = alert_settings.Value_type_setup.SETUP_ID,
                                        OPERATION_TYPE_SETUP_ID = alert_settings.Operation_setup.SETUP_ID
                                    });
                                }
                            }
                        }
                        oFirst_GeoData_Date = oFirst_GeoData_Date.AddDays(1);
                    }

                    #endregion

                    #region Check If Old Data Exists

                    List<Alert> oList_Old_Alert = Get_Alerts_By_Where(new Params_Get_Alerts_By_Where()
                    {
                        START_DATE = oFirst_GeoData_Date,
                        LEVEL_SETUP_ID = Area_Setup_ID,
                        ORGANIZATION_DATA_SOURCE_KPI_ID = oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID

                    });

                    foreach (var alert in oList_Old_Alert)
                    {
                        if (oList_Alert.Any(oAlert => oAlert.RECORD_DATE.Value.Date == alert.RECORD_DATE.Value.Date))
                        {
                            var oCommon_Alert = oList_Alert.Find(oAlert => oAlert.RECORD_DATE.Value.Date == alert.RECORD_DATE.Value.Date && oAlert.LEVEL_ID == alert.LEVEL_ID && oAlert.LEVEL_SETUP_ID == alert.LEVEL_SETUP_ID);
                            if (oCommon_Alert != null)
                            {
                                oCommon_Alert.ALERT_ID = alert.ALERT_ID;
                            }
                        }
                    };

                    #endregion

                    #region Send Data

                    Edit_Alert_List(new Params_Edit_Alert_List()
                    {
                        List_Alert = oList_Alert,
                    });

                    #endregion
                });

                #endregion

                oList_GeoData = Assign_District_IDs_In_GeoData_List(new Params_Assign_District_IDs_In_GeoData_List()
                {
                    List_GeoData = oList_GeoData
                });
                Edit_GeoData_List(new Params_Edit_GeoData_List()
                {
                    List_GeoData = oList_GeoData,
                });
                #region Calculate & Save Alerts

                Task.Run(() =>
                {
                    #region Get First Date

                    var oFirst_GeoData_Date = new DateTime(Start_Date.Year, Start_Date.Month, Start_Date.Day, Start_Date.Hour, Start_Date.Minute, Start_Date.Second);

                    #endregion

                    #region Declaration & Initialization

                    long? District_Setup_ID = 0;
                    List<District> oList_District = new List<District>();
                    List<Alert> oList_Alert = new List<Alert>();
                    List<Alert_settings> oList_Alert_settings = new List<Alert_settings>();

                    #endregion

                    #region Get District Setup

                    var get_district_setup = Task.Run(() =>
                    {
                        List<Setup> oList_Data_Level_Setup = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
                        {
                            SETUP_CATEGORY_NAME = "Data Level",
                            OWNER_ID = this.oBLC_Initializer.Owner_ID
                        }).List_Setup;
                        if (oList_Data_Level_Setup != null && oList_Data_Level_Setup.Count > 0)
                        {
                            District_Setup_ID = oList_Data_Level_Setup.Find(setup => setup.VALUE == "District").SETUP_ID;
                        }
                        else
                        {
                            throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0045).Replace("%1", "Data Level")); // Data Level Setup Not Found
                        }
                    });


                    #endregion

                    #region Get Alert Settings

                    var get_alert_settings = Task.Run(() =>
                    {
                        oList_Alert_settings = Props.Copy_Prop_Values_From_Api_Response<List<Alert_settings>>(
                        this._service_mesh.Get_Alert_settings_By_OWNER_ID_Adv(new Service_Mesh.Params_Get_Alert_settings_By_OWNER_ID()
                        {
                            OWNER_ID = this.oBLC_Initializer.Owner_ID
                        }).i_Result.Where(alert_settings => alert_settings.IS_ACTIVE == true && alert_settings.KPI_ID == oOrganization_data_source_kpi.Kpi.KPI_ID)
                    );
                    });

                    #endregion

                    #region Get District List

                    var get_district_list = Task.Run(() =>
                    {
                        oList_District = Get_District_By_OWNER_ID(new Params_Get_District_By_OWNER_ID()
                        {
                            OWNER_ID = this.oBLC_Initializer.Owner_ID
                        });
                    });

                    #endregion

                    Task.WaitAll(get_district_setup, get_alert_settings, get_district_list);

                    #region Get New GeoData List

                    List<GeoData> oList_New_GeoData = Get_GeoData_By_Where(new Params_Get_GeoData_By_Where()
                    {
                        START_DATE = oFirst_GeoData_Date,
                        LEVEL_SETUP_ID = District_Setup_ID,
                        LIST_LEVEL_ID = null,
                        ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = new List<int?>() { oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID },
                    });

                    #endregion

                    #region Fill List

                    while (oFirst_GeoData_Date < DateTime.Now.Date)
                    {
                        var oList_Old_GeoData = oList_New_GeoData.Where(oGeoData => oGeoData.DATE_START >= oFirst_GeoData_Date.AddDays(-7) && oGeoData.DATE_START < oFirst_GeoData_Date).ToList();
                        var oList_Current_GeoData = oList_New_GeoData.Where(oGeoData => oGeoData.DATE_START.Value.Date == oFirst_GeoData_Date).ToList();

                        decimal oOld_District_GeoData_Count;
                        decimal oCurrent_District_GeoData_Count;

                        var oList_Level_id_with_percent = new List<Level_id_with_percent>();

                        foreach (var oDistrict in oList_District)
                        {
                            oOld_District_GeoData_Count = oList_Old_GeoData.Count(oGeoData => oGeoData.LEVEL_ID == oDistrict.DISTRICT_ID);
                            oCurrent_District_GeoData_Count = oList_Current_GeoData.Count(oGeoData => oGeoData.LEVEL_ID == oDistrict.DISTRICT_ID);
                            if (oCurrent_District_GeoData_Count == 0 && oOld_District_GeoData_Count == 0)
                            {
                                oList_Level_id_with_percent.Add(new Level_id_with_percent()
                                {
                                    VALUE = oCurrent_District_GeoData_Count,
                                    LEVEL_ID = oDistrict.DISTRICT_ID,
                                    District = oDistrict,
                                    PERCENT_INCREASE = 0,
                                });
                            }
                            else
                            {
                                decimal oOld_District_GeoData_Average = (decimal)oOld_District_GeoData_Count / 7;
                                oList_Level_id_with_percent.Add(new Level_id_with_percent()
                                {
                                    VALUE = oCurrent_District_GeoData_Count,
                                    LEVEL_ID = oDistrict.DISTRICT_ID,
                                    District = oDistrict,
                                    PERCENT_INCREASE = Math.Round(oOld_District_GeoData_Count == 0 ? 100 : ((oCurrent_District_GeoData_Count - oOld_District_GeoData_Average) / oOld_District_GeoData_Average) * 100, 2),
                                });
                            }
                        };
                        foreach (var alert_settings in oList_Alert_settings)
                        {
                            foreach (var level_id_with_percent_increase in oList_Level_id_with_percent)
                            {
                                bool isEdit = false;

                                switch (alert_settings.Value_type_setup.VALUE)
                                {
                                    case "Tolerance":
                                        switch (alert_settings.Operation_setup.VALUE)
                                        {
                                            case "Spike":
                                                if (level_id_with_percent_increase.PERCENT_INCREASE >= alert_settings.VALUE)
                                                {
                                                    isEdit = true;
                                                }
                                                break;
                                            case "Drop":
                                                if (level_id_with_percent_increase.PERCENT_INCREASE <= -alert_settings.VALUE)
                                                {
                                                    isEdit = true;
                                                }
                                                break;
                                        }
                                        break;
                                    case "Threshold":
                                        switch (alert_settings.Operation_setup.VALUE)
                                        {
                                            case "Spike":
                                                if (level_id_with_percent_increase.VALUE >= alert_settings.VALUE)
                                                {
                                                    isEdit = true;
                                                }
                                                break;
                                            case "Drop":
                                                if (level_id_with_percent_increase.VALUE <= -alert_settings.VALUE)
                                                {
                                                    isEdit = true;
                                                }
                                                break;
                                        }
                                        break;
                                }
                                if (isEdit)
                                {
                                    oList_Alert.Add(new Alert()
                                    {
                                        USER_ID = alert_settings.USER_ID,
                                        LEVEL_ID = level_id_with_percent_increase.LEVEL_ID,
                                        ORGANIZATION_DATA_SOURCE_KPI_ID = oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                        LEVEL_SETUP_ID = District_Setup_ID,
                                        RECORD_DATE = oFirst_GeoData_Date,
                                        IS_ACKNOWLEDGED = false,
                                        ALERT_VALUE = Math.Abs(level_id_with_percent_increase.PERCENT_INCREASE.Value),
                                        VALUE_PASSED = alert_settings.VALUE,
                                        VALUE_TYPE_SETUP_ID = alert_settings.Value_type_setup.SETUP_ID,
                                        OPERATION_TYPE_SETUP_ID = alert_settings.Operation_setup.SETUP_ID
                                    });
                                }
                            };
                        };
                        oFirst_GeoData_Date = oFirst_GeoData_Date.AddDays(1);
                    }

                    #endregion

                    #region Check If Old Data Exists

                    List<Alert> oList_Old_Alert = Get_Alerts_By_Where(new Params_Get_Alerts_By_Where()
                    {
                        START_DATE = oFirst_GeoData_Date,
                        LEVEL_SETUP_ID = District_Setup_ID,
                        ORGANIZATION_DATA_SOURCE_KPI_ID = oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID

                    }).Where(alert => oList_Alert.Any(oAlert => oAlert.RECORD_DATE.Value.Date == alert.RECORD_DATE.Value.Date)).ToList();

                    oList_Old_Alert.ForEach(alert =>
                    {
                        Alert oCommon_Alert = oList_Alert.Find(oAlert => oAlert.RECORD_DATE.Value.Date == alert.RECORD_DATE.Value.Date && oAlert.LEVEL_ID == alert.LEVEL_ID && oAlert.LEVEL_SETUP_ID == alert.LEVEL_SETUP_ID);
                        if (oCommon_Alert != null)
                        {
                            oCommon_Alert.ALERT_ID = alert.ALERT_ID;
                        }
                    });

                    #endregion

                    #region Send Data

                    Edit_Alert_List(new Params_Edit_Alert_List()
                    {
                        List_Alert = oList_Alert,
                    });

                    #endregion
                });

                #endregion
            }

            #endregion
        }
        #endregion
        #region Get_And_Fill_Public_events_From_Api
        public void Get_And_Fill_Public_events_From_Api(Params_Get_And_Fill_Public_events_From_Api i_Params_Get_And_Fill_Public_events_From_Api)
        {
            #region Get Data Source

            List<Data_source> oList_Data_source = Get_Data_source_By_OWNER_ID(new Params_Get_Data_source_By_OWNER_ID()
            {
                OWNER_ID = oBLC_Initializer.Owner_ID
            });
            Data_source oData_source = new Data_source();
            if (oList_Data_source != null && oList_Data_source.Count > 0)
            {
                oData_source = oList_Data_source.Find(oData_source => oData_source.NAME == "Edmonton");
                if (oData_source != null)
                {
                    oData_source.API_URL = oData_source.API_URL + "/resource/64u3-c7bh.json";
                }
                else
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Edmonton Data Source")); // %1 Does not Exist
                }
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Data Source List")); // %1 Does not Exist
            }

            #endregion

            #region Get Data Level Setup Category

            Setup_category oSetup_category = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
            {
                SETUP_CATEGORY_NAME = "Data Level",
                OWNER_ID = oBLC_Initializer.Owner_ID
            });
            Setup oSetup_Site = new Setup();
            if (oSetup_category != null)
            {
                if (oSetup_category.List_Setup != null && oSetup_category.List_Setup.Count > 0)
                {
                    oSetup_Site = oSetup_category.List_Setup.Find(oSetup => oSetup.VALUE == "Site");
                    if (oSetup_Site == null)
                    {
                        throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Setup Site")); // %1 Does not Exist
                    }
                }
                else
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Data Level Setup list")); // %1 Does not Exist
                }
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Data Level Setup Category")); // %1 Does not Exist
            }

            #endregion

            #region Get Organization Data Source Kpi ID

            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_Adv(new Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID()
            {
                DATA_SOURCE_ID = oData_source.DATA_SOURCE_ID
            });
            Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
            if (oList_Organization_data_source_kpi != null && oList_Organization_data_source_kpi.Count > 0)
            {
                oOrganization_data_source_kpi = oList_Organization_data_source_kpi.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.NAME == "Public Events");
                if (oOrganization_data_source_kpi == null)
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Public Events Kpi")); // %1 Does not Exist
                }
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Edmonton Organization Data Source Kpi List")); // %1 Does not Exist
            }

            #endregion

            #region Get Secret

            string edmonton_api_key = this._service_mesh.Get_Secret(new Service_Mesh.Params_Get_Secret()
            {
                Secret_Id = Global.Edmonton_Api_Key
            }).i_Result;

            #endregion

            #region Execute Request

            string url = oData_source.API_URL;
            var client = new RestClient(url);
            var request = new RestRequest(url, Method.Get);
            request.AddHeader("Content-Type", "application/json");
            request.AddQueryParameter("$$app_token", edmonton_api_key);
            request.AddQueryParameter("$limit", 5000000);
            if (i_Params_Get_And_Fill_Public_events_From_Api.DATE_CREATED_START_DATE != null)
            {
                request.AddQueryParameter("$where", $"begins >= '{i_Params_Get_And_Fill_Public_events_From_Api.DATE_CREATED_START_DATE.Value.ToString("s")}'");
            }
            RestResponse response = client.Execute(request);
            if (response.StatusCode == 0)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0034)); // This feature is currently unavailable
            }
            var public_events = Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<dynamic>>(response.Content);

            #endregion

            #region Fill List

            List<GeoData> oList_Collection_GeoData = Get_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID(new Params_Get_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID()
            {
                ORGANIZATION_DATA_SOURCE_KPI_ID = oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                LEVEL_SETUP_ID = oSetup_Site.SETUP_ID,
                LIST_LEVEL_ID = null
            });
            List<GeoData> oList_GeoData = new List<GeoData>();
            foreach (var public_event in public_events)
            {
                DateTime oStart_date = public_event.begins;
                DateTime oEnd_date = public_event.ends;
                try
                {
                    oStart_date = DateTime.SpecifyKind(oStart_date, DateTimeKind.Utc);
                    oEnd_date = DateTime.SpecifyKind(oEnd_date, DateTimeKind.Utc);
                }
                catch (Exception ex)
                {
                    throw new Exception("Failed to Assign Dates: " + ex.Message);
                }

                var oGeoData_Check = oList_Collection_GeoData.Find(oGeoData => oGeoData.DATA_LIST.Find(oData => oData.NAME == "EVENT_EXTERNAL_ID").VALUE == public_event.event_id.ToString());

                var oGeoData = oGeoData_Check ?? new GeoData();

                var oList_DATA = new List<Data>()
                {
                    new Data()
                    {
                        NAME = "TITLE",
                        TYPE = "string",
                        VALUE = public_event.title
                    },
                    new Data()
                    {
                        NAME = "DATE_AND_TIME",
                        TYPE = "string",
                        VALUE = public_event.date_and_time
                    },
                    new Data()
                    {
                        NAME = "CITY_OR_TOWN",
                        TYPE = "string",
                        VALUE = public_event.city_or_town
                    },
                    new Data()
                    {
                        NAME = "NEIGHBOURHOOD_ID",
                        TYPE = "string",
                        VALUE = public_event.neighbourhood_id
                    },
                    new Data()
                    {
                        NAME = "NEIGHBOURHOOD",
                        TYPE = "string",
                        VALUE = public_event.neighbourhood
                    },
                    new Data()
                    {
                        NAME = "WHERE",
                        TYPE = "string",
                        VALUE = public_event.where
                    },
                    new Data()
                    {
                        NAME = "COST",
                        TYPE = "string",
                        VALUE = public_event.cost
                    },
                    new Data()
                    {
                        NAME = "EVENT_CATEGORY",
                        TYPE = "string",
                        VALUE = public_event.event_category
                    },
                    new Data()
                    {
                        NAME = "EVENT_TYPE",
                        TYPE = "string",
                        VALUE = public_event.event_type
                    },
                    new Data()
                    {
                        NAME = "EVENT_URL",
                        TYPE = "string",
                        VALUE = public_event.event_link
                        ?.url},
                    new Data()
                    {
                        NAME = "EVENT_VENUE",
                        TYPE = "string",
                        VALUE = public_event.event_venue
                    },
                    new Data()
                    {
                        NAME = "EVENT_EXTERNAL_ID",
                        TYPE = "string",
                        VALUE = public_event.event_id
                    },
                    new Data()
                    {
                        NAME = "WHERE_TO_PURCHASE_TICKETS",
                        TYPE = "string",
                        VALUE = public_event.where_to_purchase_tickets
                    },
                    new Data()
                    {
                        NAME = "TICKETS_PHONE",
                        TYPE = "string",
                        VALUE = public_event.tickets_phone
                    },
                    new Data()
                    {
                        NAME = "CATEGORY_CALENDAR",
                        TYPE = "string",
                        VALUE = public_event.category_calendar
                    },
                    new Data()
                    {
                        NAME = "WEB_LINK",
                        TYPE = "string",
                        VALUE = public_event.web_link
                        ?.url},
                    new Data()
                    {
                        NAME = "PUBLIC_ENGAGEMENT_CATEGORY",
                        TYPE = "string",
                        VALUE = public_event.public_engagement_category
                    },
                    new Data()
                    {
                        NAME = "SHORT_DESCRIPTION",
                        TYPE = "string",
                        VALUE = public_event.short_description
                    },
                    new Data()
                    {
                        NAME = "PROJECT_NAME",
                        TYPE = "string",
                        VALUE = public_event.project_name
                    },
                    new Data()
                    {
                        NAME = "ADDITIONAL_INFORMATION",
                        TYPE = "string",
                        VALUE = public_event.additional_information
                    },
                    new Data()
                    {
                        NAME = "NOTES_1",
                        TYPE = "string",
                        VALUE = public_event.notes_1
                    },
                    new Data()
                    {
                        NAME = "NOTES_2",
                        TYPE = "string",
                        VALUE = public_event.notes_2
                    }
                };
                oGeoData.GEODATA_ID = oGeoData.GEODATA_ID;
                oGeoData.ORGANIZATION_DATA_SOURCE_KPI_ID = oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID;
                oGeoData.LEVEL_ID = oGeoData.LEVEL_ID;
                oGeoData.LEVEL_SETUP_ID = oGeoData.LEVEL_SETUP_ID;
                oGeoData.Location = oGeoData.Location;
                oGeoData.DATE_START = oStart_date;
                oGeoData.DATE_END = oEnd_date;
                oGeoData.DATA_LIST = oList_DATA;

                oList_GeoData.Add(oGeoData);
            };

            public_events = null;

            #endregion

            #region Assign Location

            string GOOGLE_MAP_API_TOKEN = string.Empty;
            List<Default_settings> oList_Default_settings = Props.Copy_Prop_Values_From_Api_Response<List<Default_settings>>(this._service_mesh.Get_Default_settings_By_OWNER_ID(new Service_Mesh.Params_Get_Default_settings_By_OWNER_ID()
            {
                OWNER_ID = oBLC_Initializer.Owner_ID
            }).i_Result
            );
            Default_settings oDefault_settings = new Default_settings();
            if (oList_Default_settings != null && oList_Default_settings.Count > 0)
            {
                oDefault_settings = oList_Default_settings.FirstOrDefault();
                GOOGLE_MAP_API_TOKEN = oDefault_settings.GOOGLE_MAP_API_TOKEN;
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Default Settings")); // %1 Does not Exist
            }

            if (GOOGLE_MAP_API_TOKEN == "" || GOOGLE_MAP_API_TOKEN == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046)); // Google API Token not found
            }

            var _List_GeoData = new List<GeoData>();
            int index = 0;
            foreach (var geodata in oList_GeoData)
            {
                if (geodata.Location == null)
                {
                    string WHERE = geodata.DATA_LIST.Find(data => data.NAME == "WHERE").VALUE;

                    geodata.Location = Get_place_coordinates(new Params_Get_place_coordinates()
                    {
                        LOCATION_STRING = WHERE,
                        GOOGLE_MAP_API_TOKEN = GOOGLE_MAP_API_TOKEN,
                    });
                    if (index % 100 == 0)
                    {
                        Thread.Sleep(1000);
                    }
                    if (geodata.Location != null)
                    {
                        _List_GeoData.Add(geodata);
                    }
                    index++;
                }
            }
            oList_GeoData = null;

            #endregion

            #region Assign Levels & Remove Unnecessary Public Events

            _List_GeoData = Assign_Site_IDs_In_GeoData_List(new Params_Assign_Site_IDs_In_GeoData_List()
            {
                List_GeoData = _List_GeoData
            });
            _List_GeoData.RemoveAll(oGeoData => oGeoData.LEVEL_ID == null);

            #endregion

            #region Send Data

            if (_List_GeoData.Count > 0)
            {
                Edit_GeoData_List(new Params_Edit_GeoData_List()
                {
                    List_GeoData = _List_GeoData,
                });

                _List_GeoData = Assign_Area_IDs_In_GeoData_List(new Params_Assign_Area_IDs_In_GeoData_List()
                {
                    List_GeoData = _List_GeoData
                });
                Edit_GeoData_List(new Params_Edit_GeoData_List()
                {
                    List_GeoData = _List_GeoData,
                });

                _List_GeoData = Assign_District_IDs_In_GeoData_List(new Params_Assign_District_IDs_In_GeoData_List()
                {
                    List_GeoData = _List_GeoData
                });
                Edit_GeoData_List(new Params_Edit_GeoData_List()
                {
                    List_GeoData = _List_GeoData,
                });
                _List_GeoData = null;
            }

            #endregion
        }
        #endregion
        #endregion

        #region Assign_Site_IDs_In_GeoData_List
        public List<GeoData> Assign_Site_IDs_In_GeoData_List(Params_Assign_Site_IDs_In_GeoData_List i_Params_Assign_Site_IDs_In_GeoData_List)
        {

            #region Get Site GeoJson

            District oDistrict = Get_District_By_OWNER_ID(new Params_Get_District_By_OWNER_ID()
            {
                OWNER_ID = oBLC_Initializer.Owner_ID
            }).Where(district => district.NAME == "Edmonton Main").FirstOrDefault();

            List<Site> oList_Site = Get_Site_By_DISTRICT_ID(new Params_Get_Site_By_DISTRICT_ID()
            {
                DISTRICT_ID = oDistrict.DISTRICT_ID,
            });

            List<BsonDocument> oList_BsonDocument = this._MongoDb.Get_Site_geojson_By_SITE_ID_List
                (
                    oList_Site.Select(oSite => oSite.SITE_ID).ToList()
                );

            #endregion

            #region Get Data Level Setup Category

            Setup_category oSetup_category = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
            {
                SETUP_CATEGORY_NAME = "Data Level",
                OWNER_ID = oBLC_Initializer.Owner_ID
            });
            Setup oSetup_Site = new Setup();
            if (oSetup_category != null)
            {
                if (oSetup_category.List_Setup != null && oSetup_category.List_Setup.Count > 0)
                {
                    oSetup_Site = oSetup_category.List_Setup.Find(oSetup => oSetup.VALUE == "Site");
                    if (oSetup_Site == null)
                    {
                        throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Setup Site")); // %1 Does not Exist
                    }
                }
                else
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Data Level Setup list")); // %1 Does not Exist
                }
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Data Level Setup Category")); // %1 Does not Exist
            }

            #endregion

            #region Assign GeoData to Sites

            Parallel.ForEach(i_Params_Assign_Site_IDs_In_GeoData_List.List_GeoData, geodata =>
            {
                PointF oPointF = new PointF((float)geodata.Location.coordinates[0], (float)geodata.Location.coordinates[1]);

                Site oSite = oList_Site.Find(oSite =>
                {
                    BsonDocument oBsonDocument = oList_BsonDocument.Find(oBsonDocument => oBsonDocument["id"].AsInt32 == (int)oSite.SITE_ID);
                    BsonArray oArray_Coordinates = oBsonDocument["geometry"]["coordinates"][0].AsBsonArray;
                    PointF[] oArray_PointF = oArray_Coordinates.Select(oCoordinates =>
                    {
                        return new PointF()
                        {
                            X = (float)oCoordinates[0].AsDouble,
                            Y = (float)oCoordinates[1].AsDouble
                        };
                    }).ToArray();

                    bool isPoint_In_Site = Is_Point_In_Polygon(oArray_PointF, oPointF);

                    return isPoint_In_Site;
                });

                if (oSite != null)
                {
                    geodata.LEVEL_ID = oSite.SITE_ID;
                    geodata.LEVEL_SETUP_ID = oSetup_Site.SETUP_ID;
                }
            });

            #endregion

            return i_Params_Assign_Site_IDs_In_GeoData_List.List_GeoData;
        }
        #endregion
        #region Assign_Area_IDs_In_GeoData_List
        public List<GeoData> Assign_Area_IDs_In_GeoData_List(Params_Assign_Area_IDs_In_GeoData_List i_Params_Assign_Area_IDs_In_GeoData_List)
        {
            #region Get Area GeoJson

            District oDistrict = Get_District_By_OWNER_ID(new Params_Get_District_By_OWNER_ID()
            {
                OWNER_ID = oBLC_Initializer.Owner_ID
            }).Where(district => district.NAME == "Edmonton Main").FirstOrDefault();

            List<Area> oList_Area = Get_Area_By_DISTRICT_ID(new Params_Get_Area_By_DISTRICT_ID()
            {
                DISTRICT_ID = oDistrict.DISTRICT_ID,
            });

            List<BsonDocument> oList_BsonDocument = this._MongoDb.Get_Area_geojson_By_AREA_ID_List
                (
                    oList_Area.Select(oArea => oArea.AREA_ID).ToList()
                );

            #endregion

            #region Get Data Level Setup Category

            Setup_category oSetup_category = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
            {
                SETUP_CATEGORY_NAME = "Data Level",
                OWNER_ID = oBLC_Initializer.Owner_ID
            });
            Setup oSetup_Area = new Setup();
            if (oSetup_category != null)
            {
                if (oSetup_category.List_Setup != null && oSetup_category.List_Setup.Count > 0)
                {
                    oSetup_Area = oSetup_category.List_Setup.Find(oSetup => oSetup.VALUE == "Area");
                    if (oSetup_Area == null)
                    {
                        throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Setup Area")); // %1 Does not Exist
                    }
                }
                else
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Data Level Setup list")); // %1 Does not Exist
                }
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Data Level Setup Category")); // %1 Does not Exist
            }

            #endregion

            #region Assign GeoData to Sites

            Parallel.ForEach(i_Params_Assign_Area_IDs_In_GeoData_List.List_GeoData, geodata =>
            {
                PointF oPointF = new PointF((float)geodata.Location.coordinates[0], (float)geodata.Location.coordinates[1]);

                Area oArea = oList_Area.Find(oArea =>
                {
                    BsonDocument oBsonDocument = oList_BsonDocument.Find(oBsonDocument => oBsonDocument["id"].AsInt32 == (int)oArea.AREA_ID);
                    BsonArray oArray_Coordinates = oBsonDocument["geometry"]["coordinates"][0].AsBsonArray;
                    PointF[] oArray_PointF = oArray_Coordinates.Select(oCoordinates =>
                    {
                        return new PointF()
                        {
                            X = (float)oCoordinates[0].AsDouble,
                            Y = (float)oCoordinates[1].AsDouble
                        };
                    }).ToArray();

                    bool isPoint_In_Area = Is_Point_In_Polygon(oArray_PointF, oPointF);

                    return isPoint_In_Area;
                });

                if (oArea != null)
                {
                    geodata.LEVEL_ID = oArea.AREA_ID;
                    geodata.LEVEL_SETUP_ID = oSetup_Area.SETUP_ID;
                }
            });

            #endregion

            return i_Params_Assign_Area_IDs_In_GeoData_List.List_GeoData;
        }
        #endregion
        #region Assign_District_IDs_In_GeoData_List
        public List<GeoData> Assign_District_IDs_In_GeoData_List(Params_Assign_District_IDs_In_GeoData_List i_Params_Assign_District_IDs_In_GeoData_List)
        {
            #region Get District GeoJson

            District oDistrict = Get_District_By_OWNER_ID(new Params_Get_District_By_OWNER_ID()
            {
                OWNER_ID = oBLC_Initializer.Owner_ID
            }).Where(district => district.NAME == "Edmonton Main").FirstOrDefault();

            List<BsonDocument> oList_BsonDocument = this._MongoDb.Get_District_geojson_By_DISTRICT_ID_List
            (
                new List<long?>() { oDistrict.DISTRICT_ID }
            );

            #endregion

            #region Get Data Level Setup Category

            Setup_category oSetup_category = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
            {
                SETUP_CATEGORY_NAME = "Data Level",
                OWNER_ID = oBLC_Initializer.Owner_ID
            });
            Setup oSetup_District = new Setup();
            if (oSetup_category != null)
            {
                if (oSetup_category.List_Setup != null && oSetup_category.List_Setup.Count > 0)
                {
                    oSetup_District = oSetup_category.List_Setup.Find(oSetup => oSetup.VALUE == "District");
                    if (oSetup_District == null)
                    {
                        throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Setup District")); // %1 Does not Exist
                    }
                }
                else
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Data Level Setup list")); // %1 Does not Exist
                }
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Data Level Setup Category")); // %1 Does not Exist
            }

            #endregion

            #region Assign GeoData to Sites

            Parallel.ForEach(i_Params_Assign_District_IDs_In_GeoData_List.List_GeoData, geodata =>
            {
                PointF oPointF = new PointF((float)geodata.Location.coordinates[0], (float)geodata.Location.coordinates[1]);

                BsonDocument oBsonDocument = oList_BsonDocument.Find(oBsonDocument => oBsonDocument["id"].AsInt32 == (int)oDistrict.DISTRICT_ID);
                BsonArray oArray_Coordinates = oBsonDocument["geometry"]["coordinates"][0].AsBsonArray;
                PointF[] oArray_PointF = oArray_Coordinates.Select(oCoordinates =>
                {
                    return new PointF()
                    {
                        X = (float)oCoordinates[0].AsDouble,
                        Y = (float)oCoordinates[1].AsDouble
                    };
                }).ToArray();

                bool isPoint_In_District = Is_Point_In_Polygon(oArray_PointF, oPointF);

                if (isPoint_In_District)
                {
                    geodata.LEVEL_ID = oDistrict.DISTRICT_ID;
                    geodata.LEVEL_SETUP_ID = oSetup_District.SETUP_ID;
                }
            });

            #endregion

            return i_Params_Assign_District_IDs_In_GeoData_List.List_GeoData;
        }
        #endregion

        #region GeoData
        #region Get_GeoData_By_Where
        public List<GeoData> Get_GeoData_By_Where(Params_Get_GeoData_By_Where i_Params_Get_GeoData_By_Where)
        {
            List<GeoData> oList_GeoData = null;

            IEnumerable<DALC.GeoData> oList_DBEntry = _MongoDb.Get_GeoData_By_Where(
                    START_DATE: i_Params_Get_GeoData_By_Where.START_DATE,
                    ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: i_Params_Get_GeoData_By_Where.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST,
                    LIST_LEVEL_ID: i_Params_Get_GeoData_By_Where.LIST_LEVEL_ID,
                    LEVEL_SETUP_ID: i_Params_Get_GeoData_By_Where.LEVEL_SETUP_ID
                );

            if (oList_DBEntry != null)
            {
                oList_GeoData = new List<GeoData>();
                oList_GeoData = Props.Copy_Prop_Values_From_Api_Response<List<GeoData>>(oList_DBEntry);
            }

            return oList_GeoData;
        }
        #endregion
        #region Get_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID
        public List<GeoData> Get_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID(Params_Get_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID i_Params_Get_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID)
        {
            List<GeoData> oList_GeoData = null;

            IEnumerable<DALC.GeoData> oList_DBEntry = _MongoDb.Get_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID(
                i_Params_Get_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID.ORGANIZATION_DATA_SOURCE_KPI_ID,
                i_Params_Get_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID.LIST_LEVEL_ID,
                i_Params_Get_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID.LEVEL_SETUP_ID
               );
            if (oList_DBEntry != null)
            {
                oList_GeoData = new List<GeoData>();
                oList_GeoData = Props.Copy_Prop_Values_From_Api_Response<List<GeoData>>(oList_DBEntry);
            }

            return oList_GeoData;
        }
        #endregion
        #region Edit_GeoData_List
        public void Edit_GeoData_List(Params_Edit_GeoData_List i_Params_Edit_GeoData_List)
        {
            if (i_Params_Edit_GeoData_List.List_GeoData != null && i_Params_Edit_GeoData_List.List_GeoData.Count > 0)
            {
                List<DALC.GeoData> oList_GeoData = new List<DALC.GeoData>();
                foreach (var geodata in i_Params_Edit_GeoData_List.List_GeoData)
                {
                    List<DALC.Data> oList_DATA = new List<DALC.Data>();
                    foreach (var data in geodata.DATA_LIST)
                    {
                        DALC.Data oDATA = new DALC.Data();
                        oDATA.NAME = data.NAME;
                        oDATA.TYPE = data.TYPE;
                        oDATA.VALUE = data.VALUE;
                        oList_DATA.Add(oDATA);
                    }
                    DALC.GeoData oGeoData = new DALC.GeoData()
                    {
                        GEODATA_ID = geodata.GEODATA_ID,
                        ORGANIZATION_DATA_SOURCE_KPI_ID = (int)geodata.ORGANIZATION_DATA_SOURCE_KPI_ID,
                        LEVEL_ID = geodata.LEVEL_ID,
                        LEVEL_SETUP_ID = geodata.LEVEL_SETUP_ID,
                        DATE_START = geodata.DATE_START == null ? geodata.DATE_START : new DateTime((int)geodata.DATE_START?.Year, (int)geodata.DATE_START?.Month, (int)geodata.DATE_START?.Day, (int)geodata.DATE_START?.Hour, (int)geodata.DATE_START?.Minute, (int)geodata.DATE_START?.Second, DateTimeKind.Utc),
                        DATE_END = geodata.DATE_END == null ? geodata.DATE_END : new DateTime((int)geodata.DATE_END?.Year, (int)geodata.DATE_END?.Month, (int)geodata.DATE_END?.Day, (int)geodata.DATE_END?.Hour, (int)geodata.DATE_END?.Minute, (int)geodata.DATE_END?.Second, DateTimeKind.Utc),
                        Location = new DALC.Location()
                        {
                            type = geodata.Location.type,
                            coordinates = geodata.Location.coordinates,
                        },
                        DATA_LIST = oList_DATA
                    };
                    oList_GeoData.Add(oGeoData);
                }
                this._MongoDb.Edit_GeoData_List(oList_GeoData);
            }
        }
        #endregion
        #region Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List
        public void Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List(Params_Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List i_Params_Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List)
        {
            this._MongoDb.Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List(
                LIST_ORGANIZATION_DATA_SOURCE_KPI_ID: i_Params_Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List.LIST_ORGANIZATION_DATA_SOURCE_KPI_ID
            );
        }
        #endregion
        #endregion
        #region District
        #region Generate_District_Hourly_Indexes
        public void Generate_District_Hourly_Indexes(Params_Generate_District_Hourly_Indexes i_Params_Generate_District_Hourly_Indexes)
        {
            if (i_Params_Generate_District_Hourly_Indexes != null)
            {
                #region setup

                if (i_Params_Generate_District_Hourly_Indexes.LIST_ORGANIZATION_DATA_SOURCE_KPI == null || i_Params_Generate_District_Hourly_Indexes.LIST_ORGANIZATION_DATA_SOURCE_KPI.Count == 0)
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
                }

                DateTime CurrentDate = new DateTime(i_Params_Generate_District_Hourly_Indexes.YEAR, i_Params_Generate_District_Hourly_Indexes.MONTH, i_Params_Generate_District_Hourly_Indexes.DAY, 0, 0, 0);
                List<Setup_category> oList_Setup_category = Get_Setup_category_By_OWNER_ID(new Params_Get_Setup_category_By_OWNER_ID()
                {
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                });
                List<Setup> oList_Severity_Type_Setup = oList_Setup_category.First(oSetup_category => oSetup_category.SETUP_CATEGORY_NAME == "Severity Type").List_Setup;
                List<District> oList_District = Get_District_By_OWNER_ID(new Params_Get_District_By_OWNER_ID()
                {
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                });
                List<Area> oList_Area = Get_Area_By_OWNER_ID(new Params_Get_Area_By_OWNER_ID()
                {
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                });
                foreach (var district in oList_District)
                {
                    district.List_Area = oList_Area.Where(area => area.DISTRICT_ID == district.DISTRICT_ID).ToList();
                };

                List<District_kpi_data> oList_District_kpi_data = new List<District_kpi_data>();

                #endregion

                #region fill list

                i_Params_Generate_District_Hourly_Indexes.LIST_ORGANIZATION_DATA_SOURCE_KPI.ForEach(oOrganization_data_source_kpi =>
                {
                    if (oOrganization_data_source_kpi.Kpi.SETUP_CATEGORY_ID != null)
                    {
                        oOrganization_data_source_kpi.Kpi.Setup_category = oList_Setup_category.Find(setup_category => setup_category.SETUP_CATEGORY_ID == oOrganization_data_source_kpi.Kpi.SETUP_CATEGORY_ID);
                        foreach (var district in oList_District)
                        {
                            oOrganization_data_source_kpi.Kpi.Setup_category.List_Setup.ForEach(setup =>
                            {
                                if (oOrganization_data_source_kpi.Kpi.IS_BY_SEVERITY)
                                {
                                    foreach (var severity in oList_Severity_Type_Setup)
                                    {
                                        decimal randomValue = (decimal)(oOrganization_data_source_kpi.Kpi.IS_DECIMAL_VALUE ? Tools.Get_Random_Decimal() * (oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE - oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE) + oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE : Tools.Get_Random_Number((int)oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE, (int)oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE + 1));
                                        string Severity_Type = "Severity Type:" + severity.SETUP_ID.ToString();
                                        string Incident_Category_Type = "Incident Category Type:" + setup.SETUP_ID.ToString();
                                        string CATEGORY = Severity_Type + "," + Incident_Category_Type + ",EXT_STUDY_ZONE_ID:0";
                                        oList_District_kpi_data.Add(new District_kpi_data()
                                        {
                                            VALUE = randomValue,
                                            VALUE_PER_SQM = randomValue / district.AREA,
                                            RECORD_DATE = new DateTime(i_Params_Generate_District_Hourly_Indexes.YEAR, i_Params_Generate_District_Hourly_Indexes.MONTH, i_Params_Generate_District_Hourly_Indexes.DAY, i_Params_Generate_District_Hourly_Indexes.HOUR, 0, 0),
                                            VALUE_NAME = oOrganization_data_source_kpi.Kpi.IS_TRENDLINE ? new DateTime(i_Params_Generate_District_Hourly_Indexes.YEAR, i_Params_Generate_District_Hourly_Indexes.MONTH, i_Params_Generate_District_Hourly_Indexes.DAY, i_Params_Generate_District_Hourly_Indexes.HOUR, 0, 0).ToString() : setup.VALUE,
                                            DISTRICT_METADATA = new District_metadata()
                                            {
                                                DISTRICT_ID = (int)district.DISTRICT_ID,
                                                ORGANIZATION_DATA_SOURCE_KPI_ID = (int)oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                CATEGORY = CATEGORY,
                                            },
                                        });
                                    }
                                }
                                else
                                {
                                    decimal randomValue = (decimal)(oOrganization_data_source_kpi.Kpi.IS_DECIMAL_VALUE ? Tools.Get_Random_Decimal() * (oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE - oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE) + oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE : Tools.Get_Random_Number((int)oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE, (int)oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE + 1));
                                    string Incident_Category_Type = "Incident Category Type:" + setup.SETUP_ID.ToString();
                                    string CATEGORY = "Severity Type:0," + Incident_Category_Type + ",EXT_STUDY_ZONE_ID:0";
                                    oList_District_kpi_data.Add(new District_kpi_data()
                                    {
                                        VALUE = randomValue,
                                        VALUE_PER_SQM = randomValue / district.AREA,
                                        RECORD_DATE = new DateTime(i_Params_Generate_District_Hourly_Indexes.YEAR, i_Params_Generate_District_Hourly_Indexes.MONTH, i_Params_Generate_District_Hourly_Indexes.DAY, i_Params_Generate_District_Hourly_Indexes.HOUR, 0, 0),
                                        VALUE_NAME = oOrganization_data_source_kpi.Kpi.IS_TRENDLINE ? new DateTime(i_Params_Generate_District_Hourly_Indexes.YEAR, i_Params_Generate_District_Hourly_Indexes.MONTH, i_Params_Generate_District_Hourly_Indexes.DAY, i_Params_Generate_District_Hourly_Indexes.HOUR, 0, 0).ToString() : setup.VALUE,
                                        DISTRICT_METADATA = new District_metadata()
                                        {
                                            DISTRICT_ID = (int)district.DISTRICT_ID,
                                            ORGANIZATION_DATA_SOURCE_KPI_ID = (int)oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                            CATEGORY = CATEGORY,
                                        },
                                    });
                                }
                            });
                        };
                    }
                    else
                    {
                        foreach (var district in oList_District)
                        {
                            if (oOrganization_data_source_kpi.Kpi.IS_BY_SEVERITY)
                            {
                                foreach (var severity in oList_Severity_Type_Setup)
                                {
                                    decimal randomValue = (decimal)(oOrganization_data_source_kpi.Kpi.IS_DECIMAL_VALUE ? Tools.Get_Random_Decimal() * (oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE - oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE) + oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE : Tools.Get_Random_Number((int)oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE, (int)oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE + 1));
                                    string Severity_Type = "Severity Type:" + severity.SETUP_ID.ToString();
                                    string CATEGORY = Severity_Type + ",Incident Category Type:0,EXT_STUDY_ZONE_ID:0";
                                    oList_District_kpi_data.Add(new District_kpi_data()
                                    {
                                        VALUE = randomValue,
                                        VALUE_PER_SQM = randomValue / district.AREA,
                                        RECORD_DATE = new DateTime(i_Params_Generate_District_Hourly_Indexes.YEAR, i_Params_Generate_District_Hourly_Indexes.MONTH, i_Params_Generate_District_Hourly_Indexes.DAY, i_Params_Generate_District_Hourly_Indexes.HOUR, 0, 0),
                                        VALUE_NAME = new DateTime(i_Params_Generate_District_Hourly_Indexes.YEAR, i_Params_Generate_District_Hourly_Indexes.MONTH, i_Params_Generate_District_Hourly_Indexes.DAY, i_Params_Generate_District_Hourly_Indexes.HOUR, 0, 0).ToString(),
                                        DISTRICT_METADATA = new District_metadata()
                                        {
                                            DISTRICT_ID = (int)district.DISTRICT_ID,
                                            ORGANIZATION_DATA_SOURCE_KPI_ID = (int)oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                            CATEGORY = CATEGORY,
                                        },
                                    });
                                };
                            }
                            else
                            {
                                decimal randomValue = (decimal)(oOrganization_data_source_kpi.Kpi.IS_DECIMAL_VALUE ? Tools.Get_Random_Decimal() * (oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE - oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE) + oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE : Tools.Get_Random_Number((int)oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE, (int)oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE + 1));
                                oList_District_kpi_data.Add(new District_kpi_data()
                                {
                                    VALUE = randomValue,
                                    VALUE_PER_SQM = randomValue / district.AREA,
                                    RECORD_DATE = new DateTime(i_Params_Generate_District_Hourly_Indexes.YEAR, i_Params_Generate_District_Hourly_Indexes.MONTH, i_Params_Generate_District_Hourly_Indexes.DAY, i_Params_Generate_District_Hourly_Indexes.HOUR, 0, 0),
                                    VALUE_NAME = new DateTime(i_Params_Generate_District_Hourly_Indexes.YEAR, i_Params_Generate_District_Hourly_Indexes.MONTH, i_Params_Generate_District_Hourly_Indexes.DAY, i_Params_Generate_District_Hourly_Indexes.HOUR, 0, 0).ToString(),
                                    DISTRICT_METADATA = new District_metadata()
                                    {
                                        DISTRICT_ID = (int)district.DISTRICT_ID,
                                        ORGANIZATION_DATA_SOURCE_KPI_ID = (int)oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                        CATEGORY = "Severity Type:0,Incident Category Type:0,EXT_STUDY_ZONE_ID:0",
                                    },
                                }); ;
                            }
                        };
                    }
                });

                #endregion

                #region send data
                if (oList_District_kpi_data?.Count > 0)
                {
                    try
                    {
                        Edit_District_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN(new Params_Edit_District_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN()
                        {
                            LIST_DISTRICT_KPI_DATA = oList_District_kpi_data,
                            LIST_ORGANIZATION_DATA_SOURCE_KPI_ID = i_Params_Generate_District_Hourly_Indexes.LIST_ORGANIZATION_DATA_SOURCE_KPI.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList(),
                            RECORD_DATE = CurrentDate,
                            ENUM_TIMESPAN = Enum_Timespan.X_HOURLY_COLLECTION
                        });
                    }
                    catch (Exception ex)
                    {
                        throw new BLC_Exception(ex.Message);
                    }
                }
                #endregion
            }
        }
        #endregion
        #region Generate_District_Demographic_Data
        public void Generate_District_Demographic_Data(Params_Generate_District_Demographic_Data i_Params_Generate_District_Demographic_Data)
        {
            if (i_Params_Generate_District_Demographic_Data != null)
            {
                #region setup
                DateTime CurrentDate = new DateTime(i_Params_Generate_District_Demographic_Data.YEAR, i_Params_Generate_District_Demographic_Data.MONTH, i_Params_Generate_District_Demographic_Data.DAY, 0, 0, 0);
                List<Setup_category> oList_Setup_category = Get_Setup_category_By_OWNER_ID(new Params_Get_Setup_category_By_OWNER_ID()
                {
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                });
                List<Setup> oList_Severity_Type_Setup = oList_Setup_category.First(oSetup_category => oSetup_category.SETUP_CATEGORY_NAME == "Severity Type").List_Setup;
                List<District> oList_District = Get_District_By_OWNER_ID(new Params_Get_District_By_OWNER_ID()
                {
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                });
                List<Area> oList_Area = Props.Copy_Prop_Values_From_Api_Response<List<Area>>(
                    this._service_mesh.Get_Area_By_OWNER_ID(new Service_Mesh.Params_Get_Area_By_OWNER_ID()
                    {
                        OWNER_ID = this.oBLC_Initializer.Owner_ID
                    }).i_Result
                );
                foreach (var district in oList_District)
                {
                    district.List_Area = oList_Area.Where(area => area.DISTRICT_ID == district.DISTRICT_ID).ToList();
                }
                List<Area_kpi_data> oList_Area_kpi_data = Props.Copy_Prop_Values_From_Api_Response<List<Area_kpi_data>>(
                    _MongoDb.Get_Area_Kpi_Data_By_Where(
                           START_DATE: CurrentDate,
                           END_DATE: CurrentDate.AddSeconds(1),
                           ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: Service_Mesh.Global.oList_Demographics_ORGANIZATION_DATA_SOURCE_KPI_ID,
                           AREA_ID_LIST: null,
                           ENUM_TIMESPAN: (DALC.Enum_Timespan)Enum_Timespan.X_DAILY_COLLECTION
                    ));
                List<District_kpi_data> oList_District_kpi_data = new List<District_kpi_data>();
                #endregion

                #region Demographics

                #region setup
                List<string> oList_Topic = oList_Area_kpi_data.GroupBy(area_kpi_data => new
                {
                    area_kpi_data.VALUE_NAME,
                    area_kpi_data.AREA_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID,
                }).Select(area_kpi_data => area_kpi_data.Key.VALUE_NAME).Distinct().ToList();
                #endregion

                #region fill list
                Random rand = new Random();
                foreach (var topic in oList_Topic)
                {
                    foreach (var district in oList_District)
                    {
                        var oList_Area_kpi_data_To_Use = oList_Area_kpi_data.Where(area_kpi_data => area_kpi_data.VALUE_NAME == topic && district.List_Area.Any(area => area.AREA_ID == area_kpi_data.AREA_METADATA.AREA_ID));
                        if (oList_Area_kpi_data_To_Use != null && oList_Area_kpi_data_To_Use.Count() > 0)
                        {
                            List<int?> oList_Kpi_ID_To_Use = Service_Mesh.Global.oList_Demographics_ORGANIZATION_DATA_SOURCE_KPI_ID;
                            oList_Kpi_ID_To_Use.ForEach(ORGANIZATION_DATA_SOURCE_KPI_ID =>
                            {
                                decimal value = oList_Area_kpi_data_To_Use.Where(area_kpi_data => area_kpi_data.AREA_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID == ORGANIZATION_DATA_SOURCE_KPI_ID).Average(area_kpi_data => area_kpi_data.VALUE);
                                oList_District_kpi_data.Add(new District_kpi_data()
                                {
                                    VALUE = value,
                                    VALUE_PER_SQM = null,
                                    RECORD_DATE = CurrentDate,
                                    VALUE_NAME = topic,
                                    DISTRICT_METADATA = new District_metadata()
                                    {
                                        DISTRICT_ID = (int)district.DISTRICT_ID,
                                        ORGANIZATION_DATA_SOURCE_KPI_ID = (int)ORGANIZATION_DATA_SOURCE_KPI_ID,
                                        CATEGORY = "Severity Type:0,Incident Category Type:0,EXT_STUDY_ZONE_ID:0",
                                    },
                                });
                            });
                        }
                    };
                };
                #endregion

                #endregion

                #region send data
                if (oList_District_kpi_data?.Count > 0)
                {
                    try
                    {
                        Edit_District_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN(new Params_Edit_District_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN()
                        {
                            LIST_DISTRICT_KPI_DATA = oList_District_kpi_data,
                            LIST_ORGANIZATION_DATA_SOURCE_KPI_ID = Service_Mesh.Global.oList_Demographics_ORGANIZATION_DATA_SOURCE_KPI_ID,
                            RECORD_DATE = CurrentDate,
                            ENUM_TIMESPAN = Enum_Timespan.X_DAILY_COLLECTION
                        });
                    }
                    catch (Exception ex)
                    {
                        throw new BLC_Exception(ex.Message);
                    }
                }
                #endregion
            }
        }
        #endregion
        #region Generate_District_Dwell_Time
        public void Generate_District_Dwell_Time(Params_Generate_District_Dwell_Time i_Params_Generate_District_Dwell_Time)
        {
            if (i_Params_Generate_District_Dwell_Time != null)
            {
                #region setup

                DateTime CurrentDate = new DateTime(i_Params_Generate_District_Dwell_Time.YEAR, i_Params_Generate_District_Dwell_Time.MONTH, i_Params_Generate_District_Dwell_Time.DAY, 0, 0, 0);
                List<Setup_category> oList_Setup_category = Get_Setup_category_By_OWNER_ID(new Params_Get_Setup_category_By_OWNER_ID()
                {
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                });
                List<Setup> oList_Severity_Type_Setup = oList_Setup_category.First(oSetup_category => oSetup_category.SETUP_CATEGORY_NAME == "Severity Type").List_Setup;
                List<District> oList_District = Get_District_By_OWNER_ID(new Params_Get_District_By_OWNER_ID()
                {
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                });
                List<Area> oList_Area = Props.Copy_Prop_Values_From_Api_Response<List<Area>>(
                    this._service_mesh.Get_Area_By_OWNER_ID(new Service_Mesh.Params_Get_Area_By_OWNER_ID()
                    {
                        OWNER_ID = this.oBLC_Initializer.Owner_ID
                    }).i_Result
                );
                foreach (var district in oList_District)
                {
                    district.List_Area = oList_Area.Where(area => area.DISTRICT_ID == district.DISTRICT_ID).ToList();
                }
                List<District_kpi_data> oList_District_kpi_data = new List<District_kpi_data>();

                #endregion

                #region Dwell Time

                #region setup
                List<string> oList_Dwell_time = ConfigurationManager.AppSettings["LIST_DWELL_TIME"].Split(",").ToList();
                List<Area_kpi_data> oList_Area_kpi_data_dwell_time = Props.Copy_Prop_Values_From_Api_Response<List<Area_kpi_data>>(_MongoDb.Get_Area_Kpi_Data_By_Where(
                       START_DATE: CurrentDate,
                       END_DATE: CurrentDate.AddSeconds(1),
                       ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: new List<int?>() { Service_Mesh.Global.oDwell_time_ORGANIZATION_DATA_SOURCE_KPI_ID },
                       AREA_ID_LIST: null,
                       ENUM_TIMESPAN: (DALC.Enum_Timespan)Enum_Timespan.X_DAILY_COLLECTION
                   ));

                #endregion

                #region fill list
                foreach (var district in oList_District)
                {
                    foreach (var dwell_time in oList_Dwell_time)
                    {
                        oList_District_kpi_data.Add(new District_kpi_data()
                        {
                            VALUE = (decimal)oList_Area_kpi_data_dwell_time.Where(area_kpi_data => area_kpi_data.VALUE_NAME == dwell_time && district.List_Area.Any(district => district.AREA_ID == area_kpi_data.AREA_METADATA.AREA_ID)).Sum(area_kpi_data => area_kpi_data.VALUE),
                            VALUE_PER_SQM = oList_Area_kpi_data_dwell_time.Where(area_kpi_data => area_kpi_data.VALUE_NAME == dwell_time && district.List_Area.Any(district => district.AREA_ID == area_kpi_data.AREA_METADATA.AREA_ID)).Sum(area_kpi_data => area_kpi_data.VALUE) / district.AREA,
                            RECORD_DATE = CurrentDate,
                            VALUE_NAME = dwell_time,
                            DISTRICT_METADATA = new District_metadata()
                            {
                                ORGANIZATION_DATA_SOURCE_KPI_ID = Service_Mesh.Global.oDwell_time_ORGANIZATION_DATA_SOURCE_KPI_ID,
                                DISTRICT_ID = (int)district.DISTRICT_ID,
                                CATEGORY = "Severity Type:0,Incident Category Type:0,EXT_STUDY_ZONE_ID:0",
                            },
                        });
                    };
                };
                #endregion

                #endregion

                #region send data
                if (oList_District_kpi_data?.Count > 0)
                {
                    try
                    {
                        Edit_District_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN(new Params_Edit_District_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN()
                        {
                            LIST_DISTRICT_KPI_DATA = oList_District_kpi_data,
                            LIST_ORGANIZATION_DATA_SOURCE_KPI_ID = new List<int?>() { Service_Mesh.Global.oDwell_time_ORGANIZATION_DATA_SOURCE_KPI_ID },
                            RECORD_DATE = CurrentDate,
                            ENUM_TIMESPAN = Enum_Timespan.X_DAILY_COLLECTION
                        });
                    }
                    catch (Exception ex)
                    {
                        throw new BLC_Exception(ex.Message);
                    }
                }
                #endregion
            }
        }
        #endregion
        #region Edit_District_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN
        public void Edit_District_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN(Params_Edit_District_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN i_Params_Edit_District_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN)
        {
            List<District_kpi_data> oList_District_kpi_data = Props.Copy_Prop_Values_From_Api_Response<List<District_kpi_data>>(this._MongoDb.Get_District_Kpi_Data_By_Where(
                START_DATE: i_Params_Edit_District_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN.RECORD_DATE,
                END_DATE: i_Params_Edit_District_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN.RECORD_DATE.Value.AddSeconds(1),
                ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: i_Params_Edit_District_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN.LIST_ORGANIZATION_DATA_SOURCE_KPI_ID,
                ENUM_TIMESPAN: (DALC.Enum_Timespan)i_Params_Edit_District_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN.ENUM_TIMESPAN,
                DISTRICT_ID_LIST: null
            ));

            if (oList_District_kpi_data?.Count > 0)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0044).Replace("%1", "District").Replace("%2", i_Params_Edit_District_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN.RECORD_DATE.ToString())); // Data for %1 on date %2 already exists
            }

            Insert_District_Kpi_Data_List(new Params_Insert_District_Kpi_Data_List()
            {
                DISTRICT_KPI_DATA_LIST = i_Params_Edit_District_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN.LIST_DISTRICT_KPI_DATA,
                ENUM_TIMESPAN = i_Params_Edit_District_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN.ENUM_TIMESPAN
            });
        }
        #endregion
        #region Insert_District_Kpi_Data_List
        public void Insert_District_Kpi_Data_List(Params_Insert_District_Kpi_Data_List i_Params_Insert_District_Kpi_Data_List)
        {
            List<DALC.District_kpi_data> oList_District_kpi_data = null;
            if (i_Params_Insert_District_Kpi_Data_List.DISTRICT_KPI_DATA_LIST != null && i_Params_Insert_District_Kpi_Data_List.DISTRICT_KPI_DATA_LIST.Count() > 0)
            {
                oList_District_kpi_data = new List<DALC.District_kpi_data>();
                foreach (var district_kpi_data in i_Params_Insert_District_Kpi_Data_List.DISTRICT_KPI_DATA_LIST)
                {
                    DALC.District_kpi_data oDistrict_kpi_data = new DALC.District_kpi_data()
                    {
                        RECORD_DATE = new DateTime(district_kpi_data.RECORD_DATE.Year, district_kpi_data.RECORD_DATE.Month, district_kpi_data.RECORD_DATE.Day, district_kpi_data.RECORD_DATE.Hour, district_kpi_data.RECORD_DATE.Minute, district_kpi_data.RECORD_DATE.Second, DateTimeKind.Utc),
                        VALUE = district_kpi_data.VALUE,
                        VALUE_NAME = district_kpi_data.VALUE_NAME,
                        VALUE_PER_SQM = district_kpi_data.VALUE_PER_SQM,
                        DISTRICT_METADATA = new DALC.District_metadata()
                        {
                            DISTRICT_ID = district_kpi_data.DISTRICT_METADATA.DISTRICT_ID,
                            CATEGORY = district_kpi_data.DISTRICT_METADATA.CATEGORY,
                            ORGANIZATION_DATA_SOURCE_KPI_ID = district_kpi_data.DISTRICT_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID,
                        },
                    };
                    oList_District_kpi_data.Add(oDistrict_kpi_data);
                }
                this._MongoDb.Insert_District_Kpi_Data_List(oList_District_kpi_data, (DALC.Enum_Timespan)i_Params_Insert_District_Kpi_Data_List.ENUM_TIMESPAN);
            }
        }
        #endregion
        #region Delete_District_Kpi_Data
        public void Delete_District_Kpi_Data_By_Where(Params_Delete_District_Kpi_Data_By_Where i_Params_Delete_District_Kpi_Data_By_Where)
        {
            if (i_Params_Delete_District_Kpi_Data_By_Where != null)
            {
                this._MongoDb.Delete_District_Kpi_Data_By_Where(i_Params_Delete_District_Kpi_Data_By_Where.DISTRICT_ID_LIST, i_Params_Delete_District_Kpi_Data_By_Where.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, (DALC.Enum_Timespan)i_Params_Delete_District_Kpi_Data_By_Where.ENUM_TIMESPAN);
            }
        }
        #endregion
        #region Generate_Or_Compute_District_Hourly_Data
        public void Generate_Or_Compute_District_Hourly_Data(Params_Generate_Or_Compute_District_Hourly_Data i_Params_Generate_Or_Compute_District_Hourly_Data)
        {
            var generate_district_hourly_Task = Task.Run(() =>
            {
                try
                {
                    Generate_District_Hourly_Indexes(new Params_Generate_District_Hourly_Indexes()
                    {
                        DAY = i_Params_Generate_Or_Compute_District_Hourly_Data.DAY,
                        HOUR = i_Params_Generate_Or_Compute_District_Hourly_Data.HOUR,
                        MONTH = i_Params_Generate_Or_Compute_District_Hourly_Data.MONTH,
                        YEAR = i_Params_Generate_Or_Compute_District_Hourly_Data.YEAR,
                        LIST_ORGANIZATION_DATA_SOURCE_KPI = i_Params_Generate_Or_Compute_District_Hourly_Data.LIST_ORGANIZATION_DATA_SOURCE_KPI.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.Min_data_level_setup.VALUE == "District").ToList(),
                    });
                }
                catch { }
            });
            var compute_district_hourly_Task = Task.Run(() =>
            {
                try
                {
                    this._service_mesh.Compute_District_Kpi_Data_Hourly(new Service_Mesh.Params_Compute_District_Kpi_Data_Hourly()
                    {
                        DAY = i_Params_Generate_Or_Compute_District_Hourly_Data.DAY,
                        HOUR = i_Params_Generate_Or_Compute_District_Hourly_Data.HOUR,
                        MONTH = i_Params_Generate_Or_Compute_District_Hourly_Data.MONTH,
                        YEAR = i_Params_Generate_Or_Compute_District_Hourly_Data.YEAR,
                        LIST_ORGANIZATION_DATA_SOURCE_KPI = Props.Copy_Prop_Values_From_Api_Response<List<Service_Mesh.Organization_data_source_kpi>>(i_Params_Generate_Or_Compute_District_Hourly_Data.LIST_ORGANIZATION_DATA_SOURCE_KPI.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.Min_data_level_setup.VALUE != "District").ToList()),
                    });
                }
                catch { }
            });
            Task.WaitAll(generate_district_hourly_Task);
        }
        #endregion
        #endregion
        #region Area
        #region Generate_Area_Hourly_Indexes
        public void Generate_Area_Hourly_Indexes(Params_Generate_Area_Hourly_Indexes i_Params_Generate_Area_Hourly_Indexes)
        {
            #region setup
            if (i_Params_Generate_Area_Hourly_Indexes.LIST_ORGANIZATION_DATA_SOURCE_KPI == null || i_Params_Generate_Area_Hourly_Indexes.LIST_ORGANIZATION_DATA_SOURCE_KPI.Count == 0)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }
            DateTime CurrentDate = new DateTime(i_Params_Generate_Area_Hourly_Indexes.YEAR, i_Params_Generate_Area_Hourly_Indexes.MONTH, i_Params_Generate_Area_Hourly_Indexes.DAY, 0, 0, 0);
            List<Setup_category> oList_Setup_category = Get_Setup_category_By_OWNER_ID(new Params_Get_Setup_category_By_OWNER_ID()
            {
                OWNER_ID = this.oBLC_Initializer.Owner_ID
            });
            List<Area> oList_Area = Get_Area_By_OWNER_ID(new Params_Get_Area_By_OWNER_ID()
            {
                OWNER_ID = this.oBLC_Initializer.Owner_ID
            });
            List<Site> oList_Site = Get_Site_By_OWNER_ID(new Params_Get_Site_By_OWNER_ID()
            {
                OWNER_ID = this.oBLC_Initializer.Owner_ID
            });
            foreach (var area in oList_Area)
            {
                area.List_Site = oList_Site.Where(site => site.AREA_ID == area.AREA_ID).ToList();
            };

            List<Area_kpi_data> oList_Area_kpi_data = new List<Area_kpi_data>();
            List<Setup> oList_Severity_Type_Setup = oList_Setup_category.First(oSetup_category => oSetup_category.SETUP_CATEGORY_NAME == "Severity Type").List_Setup;
            #endregion
            #region fill list
            foreach (var oOrganization_data_source_kpi in i_Params_Generate_Area_Hourly_Indexes.LIST_ORGANIZATION_DATA_SOURCE_KPI)
            {
                if (oOrganization_data_source_kpi.Kpi.SETUP_CATEGORY_ID != null)
                {
                    oOrganization_data_source_kpi.Kpi.Setup_category = oList_Setup_category.Find(setup_category => setup_category.SETUP_CATEGORY_ID == oOrganization_data_source_kpi.Kpi.SETUP_CATEGORY_ID);
                    foreach (var area in oList_Area)
                    {
                        foreach (var setup in oOrganization_data_source_kpi.Kpi.Setup_category.List_Setup)
                        {
                            if (oOrganization_data_source_kpi.Kpi.IS_BY_SEVERITY)
                            {
                                foreach (var severity in oList_Severity_Type_Setup)
                                {
                                    decimal randomValue = (decimal)(oOrganization_data_source_kpi.Kpi.IS_DECIMAL_VALUE ? Tools.Get_Random_Decimal() * (oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE - oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE) + oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE : Tools.Get_Random_Number((int)oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE, (int)oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE + 1));
                                    string Severity_Type = "Severity Type:" + severity.SETUP_ID.ToString();
                                    string Incident_Category_Type = "Incident Category Type:" + setup.SETUP_ID.ToString();
                                    string CATEGORY = Severity_Type + "," + Incident_Category_Type + ",EXT_STUDY_ZONE_ID:0";
                                    oList_Area_kpi_data.Add(new Area_kpi_data()
                                    {
                                        VALUE = randomValue,
                                        VALUE_PER_SQM = randomValue / area.AREA,
                                        RECORD_DATE = new DateTime(i_Params_Generate_Area_Hourly_Indexes.YEAR, i_Params_Generate_Area_Hourly_Indexes.MONTH, i_Params_Generate_Area_Hourly_Indexes.DAY, i_Params_Generate_Area_Hourly_Indexes.HOUR, 0, 0),
                                        VALUE_NAME = oOrganization_data_source_kpi.Kpi.IS_TRENDLINE ? new DateTime(i_Params_Generate_Area_Hourly_Indexes.YEAR, i_Params_Generate_Area_Hourly_Indexes.MONTH, i_Params_Generate_Area_Hourly_Indexes.DAY, i_Params_Generate_Area_Hourly_Indexes.HOUR, 0, 0).ToString() : setup.VALUE,
                                        AREA_METADATA = new Area_metadata()
                                        {
                                            ORGANIZATION_DATA_SOURCE_KPI_ID = (int)oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                            AREA_ID = (int)area.AREA_ID,
                                            CATEGORY = CATEGORY
                                        },
                                    });
                                };
                            }
                            else
                            {
                                decimal randomValue = (decimal)(oOrganization_data_source_kpi.Kpi.IS_DECIMAL_VALUE ? Tools.Get_Random_Decimal() * (oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE - oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE) + oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE : Tools.Get_Random_Number((int)oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE, (int)oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE + 1));
                                string Incident_Category_Type = "Incident Category Type:" + setup.SETUP_ID.ToString();
                                string CATEGORY = "Severity Type:0," + Incident_Category_Type + ",EXT_STUDY_ZONE_ID:0";
                                oList_Area_kpi_data.Add(new Area_kpi_data()
                                {
                                    VALUE = randomValue,
                                    VALUE_PER_SQM = randomValue / area.AREA,
                                    RECORD_DATE = new DateTime(i_Params_Generate_Area_Hourly_Indexes.YEAR, i_Params_Generate_Area_Hourly_Indexes.MONTH, i_Params_Generate_Area_Hourly_Indexes.DAY, i_Params_Generate_Area_Hourly_Indexes.HOUR, 0, 0),
                                    VALUE_NAME = oOrganization_data_source_kpi.Kpi.IS_TRENDLINE ? new DateTime(i_Params_Generate_Area_Hourly_Indexes.YEAR, i_Params_Generate_Area_Hourly_Indexes.MONTH, i_Params_Generate_Area_Hourly_Indexes.DAY, i_Params_Generate_Area_Hourly_Indexes.HOUR, 0, 0).ToString() : setup.VALUE,
                                    AREA_METADATA = new Area_metadata()
                                    {
                                        ORGANIZATION_DATA_SOURCE_KPI_ID = (int)oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                        AREA_ID = (int)area.AREA_ID,
                                        CATEGORY = CATEGORY
                                    },
                                });
                            }
                        };
                    };
                }
                else
                {
                    foreach (var area in oList_Area)
                    {
                        if (oOrganization_data_source_kpi.Kpi.IS_BY_SEVERITY)
                        {
                            foreach (var severity in oList_Severity_Type_Setup)
                            {
                                decimal randomValue = (decimal)(oOrganization_data_source_kpi.Kpi.IS_DECIMAL_VALUE ? Tools.Get_Random_Decimal() * (oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE - oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE) + oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE : Tools.Get_Random_Number((int)oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE, (int)oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE + 1));
                                string Severity_Type = "Severity Type:" + severity.SETUP_ID.ToString();
                                string CATEGORY = Severity_Type + ",Incident Category Type:0,EXT_STUDY_ZONE_ID:0";
                                oList_Area_kpi_data.Add(new Area_kpi_data()
                                {
                                    VALUE = randomValue,
                                    VALUE_PER_SQM = randomValue / area.AREA,
                                    RECORD_DATE = new DateTime(i_Params_Generate_Area_Hourly_Indexes.YEAR, i_Params_Generate_Area_Hourly_Indexes.MONTH, i_Params_Generate_Area_Hourly_Indexes.DAY, i_Params_Generate_Area_Hourly_Indexes.HOUR, 0, 0),
                                    VALUE_NAME = new DateTime(i_Params_Generate_Area_Hourly_Indexes.YEAR, i_Params_Generate_Area_Hourly_Indexes.MONTH, i_Params_Generate_Area_Hourly_Indexes.DAY, i_Params_Generate_Area_Hourly_Indexes.HOUR, 0, 0).ToString(),
                                    AREA_METADATA = new Area_metadata()
                                    {
                                        ORGANIZATION_DATA_SOURCE_KPI_ID = (int)oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                        AREA_ID = (int)area.AREA_ID,
                                        CATEGORY = CATEGORY
                                    },
                                });
                            };
                        }
                        else
                        {
                            decimal randomValue = (decimal)(oOrganization_data_source_kpi.Kpi.IS_DECIMAL_VALUE ? Tools.Get_Random_Decimal() * (oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE - oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE) + oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE : Tools.Get_Random_Number((int)oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE, (int)oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE + 1));
                            oList_Area_kpi_data.Add(new Area_kpi_data()
                            {
                                VALUE = randomValue,
                                VALUE_PER_SQM = randomValue / area.AREA,
                                RECORD_DATE = new DateTime(i_Params_Generate_Area_Hourly_Indexes.YEAR, i_Params_Generate_Area_Hourly_Indexes.MONTH, i_Params_Generate_Area_Hourly_Indexes.DAY, i_Params_Generate_Area_Hourly_Indexes.HOUR, 0, 0),
                                VALUE_NAME = new DateTime(i_Params_Generate_Area_Hourly_Indexes.YEAR, i_Params_Generate_Area_Hourly_Indexes.MONTH, i_Params_Generate_Area_Hourly_Indexes.DAY, i_Params_Generate_Area_Hourly_Indexes.HOUR, 0, 0).ToString(),
                                AREA_METADATA = new Area_metadata()
                                {
                                    ORGANIZATION_DATA_SOURCE_KPI_ID = (int)oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                    AREA_ID = (int)area.AREA_ID,
                                    CATEGORY = "Severity Type:0,Incident Category Type:0,EXT_STUDY_ZONE_ID:0",
                                },
                            });
                        }
                    };
                }
            };
            #endregion
            #region send data
            if (oList_Area_kpi_data?.Count > 0)
            {
                try
                {
                    Edit_Area_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN(new Params_Edit_Area_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN()
                    {
                        LIST_AREA_KPI_DATA = oList_Area_kpi_data,
                        LIST_ORGANIZATION_DATA_SOURCE_KPI_ID = i_Params_Generate_Area_Hourly_Indexes.LIST_ORGANIZATION_DATA_SOURCE_KPI.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList(),
                        RECORD_DATE = CurrentDate,
                        ENUM_TIMESPAN = Enum_Timespan.X_HOURLY_COLLECTION
                    });
                }
                catch (Exception ex)
                {
                    throw new BLC_Exception(ex.Message);
                }
            }
            #endregion
        }
        #endregion
        #region Generate_Area_Dwell_Time
        public void Generate_Area_Dwell_Time(Params_Generate_Area_Dwell_Time i_Params_Generate_Area_Dwell_Time)
        {
            #region setup
            DateTime CurrentDate = new DateTime(i_Params_Generate_Area_Dwell_Time.YEAR, i_Params_Generate_Area_Dwell_Time.MONTH, i_Params_Generate_Area_Dwell_Time.DAY, 0, 0, 0);
            List<Setup_category> oList_Setup_category = Get_Setup_category_By_OWNER_ID(new Params_Get_Setup_category_By_OWNER_ID()
            {
                OWNER_ID = this.oBLC_Initializer.Owner_ID
            });
            List<Area> oList_Area = Get_Area_By_OWNER_ID(new Params_Get_Area_By_OWNER_ID()
            {
                OWNER_ID = this.oBLC_Initializer.Owner_ID
            });
            List<Site> oList_Site = Props.Copy_Prop_Values_From_Api_Response<List<Site>>(
                this._service_mesh.Get_Site_By_OWNER_ID(new Service_Mesh.Params_Get_Site_By_OWNER_ID()
                {
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                }).i_Result
            );
            foreach (var area in oList_Area)
            {
                area.List_Site = oList_Site.Where(site => site.AREA_ID == area.AREA_ID).ToList();
            };

            List<Area_kpi_data> oList_Area_kpi_data = new List<Area_kpi_data>();
            #endregion

            #region dwell time

            #region setup
            List<string> oList_Dwell_time = ConfigurationManager.AppSettings["LIST_DWELL_TIME"].Split(",").ToList();
            List<Site_kpi_data> oList_Site_kpi_data_dwell_time = Props.Copy_Prop_Values_From_Api_Response<List<Site_kpi_data>>(_MongoDb.Get_Site_Kpi_Data_By_Where(
                   START_DATE: CurrentDate,
                   END_DATE: CurrentDate.AddSeconds(1),
                   ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: new List<int?>() { Service_Mesh.Global.oDwell_time_ORGANIZATION_DATA_SOURCE_KPI_ID },
                   SITE_ID_LIST: null,
                   ENUM_TIMESPAN: (DALC.Enum_Timespan)Enum_Timespan.X_DAILY_COLLECTION
               ));

            #endregion

            #region fill list
            foreach (var area in oList_Area)
            {
                foreach (var dwell_time in oList_Dwell_time)
                {
                    oList_Area_kpi_data.Add(new Area_kpi_data()
                    {
                        VALUE = (decimal)oList_Site_kpi_data_dwell_time.Where(site_kpi_data => site_kpi_data.VALUE_NAME == dwell_time && area.List_Site.Any(site => site.SITE_ID == site_kpi_data.SITE_METADATA.SITE_ID)).Sum(site_kpi_data => site_kpi_data.VALUE),
                        VALUE_PER_SQM = oList_Site_kpi_data_dwell_time.Where(site_kpi_data => site_kpi_data.VALUE_NAME == dwell_time && area.List_Site.Any(site => site.SITE_ID == site_kpi_data.SITE_METADATA.SITE_ID)).Sum(site_kpi_data => site_kpi_data.VALUE) / area.AREA,
                        RECORD_DATE = CurrentDate,
                        VALUE_NAME = dwell_time,
                        AREA_METADATA = new Area_metadata()
                        {
                            ORGANIZATION_DATA_SOURCE_KPI_ID = Service_Mesh.Global.oDwell_time_ORGANIZATION_DATA_SOURCE_KPI_ID,
                            AREA_ID = (int)area.AREA_ID,
                            CATEGORY = "Severity Type:0,Incident Category Type:0,EXT_STUDY_ZONE_ID:0",
                        },
                    });
                };
            };
            #endregion

            #endregion

            #region send data
            if (oList_Area_kpi_data?.Count > 0)
            {
                try
                {
                    Edit_Area_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN(new Params_Edit_Area_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN()
                    {
                        LIST_AREA_KPI_DATA = oList_Area_kpi_data,
                        LIST_ORGANIZATION_DATA_SOURCE_KPI_ID = new List<int?>() { Service_Mesh.Global.oDwell_time_ORGANIZATION_DATA_SOURCE_KPI_ID },
                        RECORD_DATE = CurrentDate,
                        ENUM_TIMESPAN = Enum_Timespan.X_DAILY_COLLECTION
                    });
                }
                catch (Exception ex)
                {
                    throw new BLC_Exception(ex.Message);
                }
            }
            #endregion
        }
        #endregion
        #region Generate_Area_Demographic_Data
        public void Generate_Area_Demographic_Data(Params_Generate_Area_Demographic_Data i_Params_Generate_Area_Demographic_Data)
        {
            #region setup
            DateTime CurrentDate = new DateTime(i_Params_Generate_Area_Demographic_Data.YEAR, i_Params_Generate_Area_Demographic_Data.MONTH, i_Params_Generate_Area_Demographic_Data.DAY, 0, 0, 0);
            List<Setup_category> oList_Setup_category = Get_Setup_category_By_OWNER_ID(new Params_Get_Setup_category_By_OWNER_ID()
            {
                OWNER_ID = this.oBLC_Initializer.Owner_ID
            });
            List<Area> oList_Area = Get_Area_By_OWNER_ID(new Params_Get_Area_By_OWNER_ID()
            {
                OWNER_ID = this.oBLC_Initializer.Owner_ID
            });
            List<Site> oList_Site = Props.Copy_Prop_Values_From_Api_Response<List<Site>>(
                this._service_mesh.Get_Site_By_OWNER_ID(new Service_Mesh.Params_Get_Site_By_OWNER_ID()
                {
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                }).i_Result
            );
            foreach (var area in oList_Area)
            {
                area.List_Site = oList_Site.Where(site => site.AREA_ID == area.AREA_ID).ToList();
            };

            List<Area_kpi_data> oList_Area_kpi_data = new List<Area_kpi_data>();
            #endregion

            #region demographic data

            #region setup
            List<Site_kpi_data> oList_Site_kpi_data_demographic = Props.Copy_Prop_Values_From_Api_Response<List<Site_kpi_data>>(_MongoDb.Get_Site_Kpi_Data_By_Where(
                   START_DATE: CurrentDate,
                   END_DATE: CurrentDate.AddSeconds(1),
                   ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: Service_Mesh.Global.oList_Demographics_ORGANIZATION_DATA_SOURCE_KPI_ID,
                   SITE_ID_LIST: null,
                   ENUM_TIMESPAN: (DALC.Enum_Timespan)Enum_Timespan.X_DAILY_COLLECTION
               ));

            List<string> oList_Topic = oList_Site_kpi_data_demographic.GroupBy(site_kpi_data => new
            {
                site_kpi_data.VALUE_NAME,
                site_kpi_data.SITE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID,
            }).Select(site_kpi_data => site_kpi_data.Key.VALUE_NAME).Distinct().ToList();
            #endregion

            #region fill list
            foreach (var topic in oList_Topic)
            {
                foreach (var area in oList_Area)
                {
                    List<Site_kpi_data> oList_Site_kpi_data_demographic_to_use = oList_Site_kpi_data_demographic.Where(site_kpi_data => site_kpi_data.VALUE_NAME == topic && area.List_Site.Any(site => site.SITE_ID == site_kpi_data.SITE_METADATA.SITE_ID)).ToList();
                    List<int> oList_Kpi_ID_To_Use = oList_Site_kpi_data_demographic_to_use.Select(site_kpi_data => site_kpi_data.SITE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID).Distinct().ToList();
                    oList_Kpi_ID_To_Use.ForEach(ORGANIZATION_DATA_SOURCE_KPI_ID =>
                    {
                        decimal value = oList_Site_kpi_data_demographic_to_use.Where(site_kpi_data => site_kpi_data.SITE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID == ORGANIZATION_DATA_SOURCE_KPI_ID).Average(site_kpi_data => site_kpi_data.VALUE);
                        oList_Area_kpi_data.Add(new Area_kpi_data()
                        {
                            VALUE = value,
                            VALUE_PER_SQM = 0,
                            RECORD_DATE = CurrentDate,
                            VALUE_NAME = topic,
                            AREA_METADATA = new Area_metadata()
                            {
                                ORGANIZATION_DATA_SOURCE_KPI_ID = ORGANIZATION_DATA_SOURCE_KPI_ID,
                                AREA_ID = (int)area.AREA_ID,
                                CATEGORY = "Severity Type:0,Incident Category Type:0,EXT_STUDY_ZONE_ID:0",

                            },
                        });
                    });
                };
            };
            #endregion

            #endregion

            #region send data
            if (oList_Area_kpi_data?.Count > 0)
            {
                try
                {
                    Edit_Area_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN(new Params_Edit_Area_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN()
                    {
                        LIST_AREA_KPI_DATA = oList_Area_kpi_data,
                        LIST_ORGANIZATION_DATA_SOURCE_KPI_ID = Service_Mesh.Global.oList_Demographics_ORGANIZATION_DATA_SOURCE_KPI_ID,
                        RECORD_DATE = CurrentDate,
                        ENUM_TIMESPAN = Enum_Timespan.X_DAILY_COLLECTION
                    });
                }
                catch (Exception ex)
                {
                    throw new BLC_Exception(ex.Message);
                }
            }
            #endregion
        }
        #endregion
        #region Generate_Or_Compute_Area_Hourly_Data
        public void Generate_Or_Compute_Area_Hourly_Data(Params_Generate_Or_Compute_Area_Hourly_Data i_Params_Generate_Or_Compute_Area_Hourly_Data)
        {
            var generate_area_hourly_Task = Task.Run(() =>
            {
                try
                {
                    Generate_Area_Hourly_Indexes(new Params_Generate_Area_Hourly_Indexes()
                    {
                        DAY = i_Params_Generate_Or_Compute_Area_Hourly_Data.DAY,
                        HOUR = i_Params_Generate_Or_Compute_Area_Hourly_Data.HOUR,
                        MONTH = i_Params_Generate_Or_Compute_Area_Hourly_Data.MONTH,
                        YEAR = i_Params_Generate_Or_Compute_Area_Hourly_Data.YEAR,
                        LIST_ORGANIZATION_DATA_SOURCE_KPI = i_Params_Generate_Or_Compute_Area_Hourly_Data.LIST_ORGANIZATION_DATA_SOURCE_KPI.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.Min_data_level_setup.VALUE == "Area").ToList(),
                    });
                }
                catch { }
            });
            var compute_area_hourly_Task = Task.Run(() =>
            {
                try
                {
                    this._service_mesh.Compute_Area_Kpi_Data_Hourly(new Service_Mesh.Params_Compute_Area_Kpi_Data_Hourly()
                    {
                        DAY = i_Params_Generate_Or_Compute_Area_Hourly_Data.DAY,
                        HOUR = i_Params_Generate_Or_Compute_Area_Hourly_Data.HOUR,
                        MONTH = i_Params_Generate_Or_Compute_Area_Hourly_Data.MONTH,
                        YEAR = i_Params_Generate_Or_Compute_Area_Hourly_Data.YEAR,
                        LIST_ORGANIZATION_DATA_SOURCE_KPI = Props.Copy_Prop_Values_From_Api_Response<List<Service_Mesh.Organization_data_source_kpi>>(i_Params_Generate_Or_Compute_Area_Hourly_Data.LIST_ORGANIZATION_DATA_SOURCE_KPI.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.Min_data_level_setup.VALUE != "Area").ToList()),
                    });
                }
                catch { }
            });
            Task.WaitAll(generate_area_hourly_Task, compute_area_hourly_Task);
        }
        #endregion
        #region Edit_Area_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN
        public void Edit_Area_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN(Params_Edit_Area_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN i_Params_Edit_Area_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN)
        {
            List<Area_kpi_data> oList_Area_kpi_data = Props.Copy_Prop_Values_From_Api_Response<List<Area_kpi_data>>(this._MongoDb.Get_Area_Kpi_Data_By_Where(
                START_DATE: i_Params_Edit_Area_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN.RECORD_DATE,
                END_DATE: i_Params_Edit_Area_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN.RECORD_DATE.Value.AddSeconds(1),
                ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: i_Params_Edit_Area_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN.LIST_ORGANIZATION_DATA_SOURCE_KPI_ID,
                ENUM_TIMESPAN: (DALC.Enum_Timespan)i_Params_Edit_Area_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN.ENUM_TIMESPAN,
                AREA_ID_LIST: null
            ));

            if (oList_Area_kpi_data?.Count > 0)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0044).Replace("%1", "Area").Replace("%2", i_Params_Edit_Area_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN.RECORD_DATE.ToString())); // Data for %1 on date %2 already exists
            }

            Insert_Area_Kpi_Data_List(new Params_Insert_Area_Kpi_Data_List()
            {
                AREA_KPI_DATA_LIST = i_Params_Edit_Area_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN.LIST_AREA_KPI_DATA,
                ENUM_TIMESPAN = i_Params_Edit_Area_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN.ENUM_TIMESPAN
            });
        }
        #endregion
        #region Insert_Area_Kpi_Data_List
        public void Insert_Area_Kpi_Data_List(Params_Insert_Area_Kpi_Data_List i_Params_Insert_Area_Kpi_Data_List)
        {
            List<DALC.Area_kpi_data> oList_Area_kpi_data = null;
            if (i_Params_Insert_Area_Kpi_Data_List.AREA_KPI_DATA_LIST != null && i_Params_Insert_Area_Kpi_Data_List.AREA_KPI_DATA_LIST.Count() > 0)
            {
                oList_Area_kpi_data = new List<DALC.Area_kpi_data>();
                foreach (var area_kpi_data in i_Params_Insert_Area_Kpi_Data_List.AREA_KPI_DATA_LIST)
                {
                    DALC.Area_kpi_data oArea_kpi_data = new DALC.Area_kpi_data()
                    {
                        RECORD_DATE = new DateTime(area_kpi_data.RECORD_DATE.Year, area_kpi_data.RECORD_DATE.Month, area_kpi_data.RECORD_DATE.Day, area_kpi_data.RECORD_DATE.Hour, area_kpi_data.RECORD_DATE.Minute, area_kpi_data.RECORD_DATE.Second, DateTimeKind.Utc),
                        VALUE = area_kpi_data.VALUE,
                        VALUE_NAME = area_kpi_data.VALUE_NAME,
                        VALUE_PER_SQM = area_kpi_data.VALUE_PER_SQM,
                        AREA_METADATA = new DALC.Area_metadata()
                        {
                            AREA_ID = area_kpi_data.AREA_METADATA.AREA_ID,
                            CATEGORY = area_kpi_data.AREA_METADATA.CATEGORY,
                            ORGANIZATION_DATA_SOURCE_KPI_ID = area_kpi_data.AREA_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID,
                        },
                    };
                    oList_Area_kpi_data.Add(oArea_kpi_data);
                }
                this._MongoDb.Insert_Area_Kpi_Data_List(oList_Area_kpi_data, (DALC.Enum_Timespan)i_Params_Insert_Area_Kpi_Data_List.ENUM_TIMESPAN);
            }
        }
        #endregion
        #region Delete_Area_Kpi_Data_By_Where
        public void Delete_Area_Kpi_Data_By_Where(Delete_Area_Kpi_Data_By_Where i_Delete_Area_Kpi_Data_By_Where)
        {
            if (i_Delete_Area_Kpi_Data_By_Where != null)
            {
                this._MongoDb.Delete_Area_Kpi_Data_By_Where(i_Delete_Area_Kpi_Data_By_Where.AREA_ID_LIST, i_Delete_Area_Kpi_Data_By_Where.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, (DALC.Enum_Timespan)i_Delete_Area_Kpi_Data_By_Where.ENUM_TIMESPAN);
            }
        }
        #endregion
        #endregion
        #region Site
        #region Generate_Site_Visitor_Data_And_Dwell_Time
        public void Generate_Site_Visitor_Data_And_Dwell_Time(Params_Generate_Site_Visitor_Data_And_Dwell_Time i_Params_Generate_Site_Visitor_Data_And_Dwell_Time)
        {
            #region Declaration & Initialization

            List<Site_kpi_data> oList_Site_Visitor_kpi_data = new List<Site_kpi_data>();
            List<Site_kpi_data> oList_Site_Dwell_Time_1_kpi_data = new List<Site_kpi_data>();
            List<Site_kpi_data> oList_Site_Dwell_Time_2_kpi_data = new List<Site_kpi_data>();
            List<Site_kpi_data> oList_Site_Dwell_Time_3_kpi_data = new List<Site_kpi_data>();
            List<Site_kpi_data> oList_Site_Dwell_Time_4_kpi_data = new List<Site_kpi_data>();
            List<Site> oList_Site = Get_Site_By_OWNER_ID(new Params_Get_Site_By_OWNER_ID()
            {
                OWNER_ID = this.oBLC_Initializer.Owner_ID
            });
            DateTime currentTime = i_Params_Generate_Site_Visitor_Data_And_Dwell_Time.START_TIME;

            #endregion

            #region Visitor Data

            foreach (var study_zone in i_Params_Generate_Site_Visitor_Data_And_Dwell_Time.Visitor_Data.LIST_STUDY_ZONE)
            {
                Site oSite = i_Params_Generate_Site_Visitor_Data_And_Dwell_Time.List_Site.Find(site => site.STUDY_ZONE_NAME == study_zone.INPUT_GEOID);
                foreach (var bucket in study_zone.List_Bucket)
                {
                    oList_Site_Visitor_kpi_data.Add(new Site_kpi_data()
                    {
                        RECORD_DATE = new DateTime(bucket.TIMEFRAME_BUCKET.Value.Year, bucket.TIMEFRAME_BUCKET.Value.Month, bucket.TIMEFRAME_BUCKET.Value.Day, bucket.TIMEFRAME_BUCKET.Value.Hour, 0, 0),
                        VALUE = (decimal)bucket.COUNT,
                        VALUE_NAME = bucket.TIMEFRAME_BUCKET.ToString(),
                        VALUE_PER_SQM = bucket.COUNT / oSite.AREA,
                        SITE_METADATA = new Site_metadata()
                        {
                            ORGANIZATION_DATA_SOURCE_KPI_ID = Service_Mesh.Global.oNumber_of_visitors_ORGANIZATION_DATA_SOURCE_KPI_ID,
                            SITE_ID = (int)oSite.SITE_ID,
                            CATEGORY = "Severity Type:0,Incident Category Type:0,EXT_STUDY_ZONE_ID:0"
                        }
                    });
                };
            };
            while (currentTime < i_Params_Generate_Site_Visitor_Data_And_Dwell_Time.START_TIME.AddDays(1))
            {
                var oList_Sites_To_Use = oList_Site.Where(site => !oList_Site_Visitor_kpi_data.Any(site_kpi_data => site_kpi_data.VALUE_NAME == currentTime.ToString() &&
                                                                  site_kpi_data.SITE_METADATA.SITE_ID == site.SITE_ID))
                                                    .ToList();
                foreach (var site in oList_Sites_To_Use)
                {
                    oList_Site_Visitor_kpi_data.Add(new Site_kpi_data()
                    {
                        RECORD_DATE = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, currentTime.Hour, 0, 0),
                        VALUE = 0,
                        VALUE_NAME = currentTime.ToString(),
                        VALUE_PER_SQM = 0,
                        SITE_METADATA = new Site_metadata()
                        {
                            ORGANIZATION_DATA_SOURCE_KPI_ID = Service_Mesh.Global.oNumber_of_visitors_ORGANIZATION_DATA_SOURCE_KPI_ID,
                            SITE_ID = (int)site.SITE_ID,
                            CATEGORY = "Severity Type:0,Incident Category Type:0,EXT_STUDY_ZONE_ID:0"
                        }
                    });
                };
                currentTime = currentTime.AddHours(1);
            }
            oList_Site_Visitor_kpi_data = oList_Site_Visitor_kpi_data.OrderBy(site_kpi_data => site_kpi_data.RECORD_DATE).ToList();

            #endregion

            #region Dwell Time

            List<string> oList_Dwell_time = ConfigurationManager.AppSettings["LIST_DWELL_TIME"].Split(",").ToList();
            currentTime = i_Params_Generate_Site_Visitor_Data_And_Dwell_Time.START_TIME;
            foreach (var study_zone in i_Params_Generate_Site_Visitor_Data_And_Dwell_Time.Dwell_Time_1.LIST_STUDY_ZONE)
            {
                Site oSite = i_Params_Generate_Site_Visitor_Data_And_Dwell_Time.List_Site.Find(site => site.STUDY_ZONE_NAME == study_zone.INPUT_GEOID);
                foreach (var bucket in study_zone.List_Bucket)
                {
                    oList_Site_Dwell_Time_1_kpi_data.Add(new Site_kpi_data()
                    {
                        RECORD_DATE = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 0, 0, 0),
                        VALUE = (decimal)bucket.COUNT,
                        VALUE_NAME = oList_Dwell_time[0],
                        VALUE_PER_SQM = bucket.COUNT / oSite.AREA,
                        SITE_METADATA = new Site_metadata()
                        {
                            ORGANIZATION_DATA_SOURCE_KPI_ID = Service_Mesh.Global.oDwell_time_ORGANIZATION_DATA_SOURCE_KPI_ID,
                            SITE_ID = (int)oSite.SITE_ID,
                            CATEGORY = "Severity Type:0,Incident Category Type:0,EXT_STUDY_ZONE_ID:0"
                        }
                    });
                };
            };
            var oList_Site_To_Use = oList_Site.Where(site => !oList_Site_Dwell_Time_1_kpi_data.Any(site_kpi_data => site_kpi_data.SITE_METADATA.SITE_ID == site.SITE_ID));
            foreach (var site in oList_Site_To_Use)
            {
                oList_Site_Dwell_Time_1_kpi_data.Add(new Site_kpi_data()
                {
                    RECORD_DATE = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 0, 0, 0),
                    VALUE = 0,
                    VALUE_NAME = oList_Dwell_time[0],
                    VALUE_PER_SQM = 0,
                    SITE_METADATA = new Site_metadata()
                    {
                        ORGANIZATION_DATA_SOURCE_KPI_ID = Service_Mesh.Global.oDwell_time_ORGANIZATION_DATA_SOURCE_KPI_ID,
                        SITE_ID = (int)site.SITE_ID,
                        CATEGORY = "Severity Type:0,Incident Category Type:0,EXT_STUDY_ZONE_ID:0"
                    }
                });
            };
            foreach (var study_zone in i_Params_Generate_Site_Visitor_Data_And_Dwell_Time.Dwell_Time_2.LIST_STUDY_ZONE)
            {
                Site oSite = i_Params_Generate_Site_Visitor_Data_And_Dwell_Time.List_Site.Find(site => site.STUDY_ZONE_NAME == study_zone.INPUT_GEOID);
                study_zone.List_Bucket.ForEach(bucket =>
                {
                    oList_Site_Dwell_Time_2_kpi_data.Add(new Site_kpi_data()
                    {
                        RECORD_DATE = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 0, 0, 0),
                        VALUE = (decimal)bucket.COUNT,
                        VALUE_NAME = oList_Dwell_time[1],
                        VALUE_PER_SQM = bucket.COUNT / oSite.AREA,
                        SITE_METADATA = new Site_metadata()
                        {
                            ORGANIZATION_DATA_SOURCE_KPI_ID = Service_Mesh.Global.oDwell_time_ORGANIZATION_DATA_SOURCE_KPI_ID,
                            SITE_ID = (int)oSite.SITE_ID,
                            CATEGORY = "Severity Type:0,Incident Category Type:0,EXT_STUDY_ZONE_ID:0"
                        }
                    });
                });
            };
            oList_Site_To_Use = new List<Site>();
            oList_Site_To_Use = oList_Site.Where(site => !oList_Site_Dwell_Time_2_kpi_data.Any(site_kpi_data => site_kpi_data.SITE_METADATA.SITE_ID == site.SITE_ID));
            foreach (var site in oList_Site_To_Use)
            {
                oList_Site_Dwell_Time_2_kpi_data.Add(new Site_kpi_data()
                {
                    RECORD_DATE = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 0, 0, 0),
                    VALUE = 0,
                    VALUE_NAME = oList_Dwell_time[1],
                    VALUE_PER_SQM = 0,
                    SITE_METADATA = new Site_metadata()
                    {
                        ORGANIZATION_DATA_SOURCE_KPI_ID = Service_Mesh.Global.oDwell_time_ORGANIZATION_DATA_SOURCE_KPI_ID,
                        SITE_ID = (int)site.SITE_ID,
                        CATEGORY = "Severity Type:0,Incident Category Type:0,EXT_STUDY_ZONE_ID:0"
                    }
                });
            };
            foreach (var study_zone in i_Params_Generate_Site_Visitor_Data_And_Dwell_Time.Dwell_Time_3.LIST_STUDY_ZONE)
            {
                Site oSite = i_Params_Generate_Site_Visitor_Data_And_Dwell_Time.List_Site.Find(site => site.STUDY_ZONE_NAME == study_zone.INPUT_GEOID);

                foreach (var bucket in study_zone.List_Bucket)
                {
                    oList_Site_Dwell_Time_3_kpi_data.Add(new Site_kpi_data()
                    {
                        RECORD_DATE = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 0, 0, 0),
                        VALUE = (decimal)bucket.COUNT,
                        VALUE_NAME = oList_Dwell_time[2],
                        VALUE_PER_SQM = bucket.COUNT / oSite.AREA,
                        SITE_METADATA = new Site_metadata()
                        {
                            ORGANIZATION_DATA_SOURCE_KPI_ID = Service_Mesh.Global.oDwell_time_ORGANIZATION_DATA_SOURCE_KPI_ID,
                            SITE_ID = (int)oSite.SITE_ID,
                            CATEGORY = "Severity Type:0,Incident Category Type:0,EXT_STUDY_ZONE_ID:0"
                        }
                    });
                };
            };
            oList_Site_To_Use = new List<Site>();
            oList_Site_To_Use = oList_Site.Where(site => !oList_Site_Dwell_Time_3_kpi_data.Any(site_kpi_data => site_kpi_data.SITE_METADATA.SITE_ID == site.SITE_ID));
            foreach (var site in oList_Site_To_Use)
            {
                oList_Site_Dwell_Time_3_kpi_data.Add(new Site_kpi_data()
                {
                    RECORD_DATE = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 0, 0, 0),
                    VALUE = 0,
                    VALUE_NAME = oList_Dwell_time[2],
                    VALUE_PER_SQM = 0,
                    SITE_METADATA = new Site_metadata()
                    {
                        ORGANIZATION_DATA_SOURCE_KPI_ID = Service_Mesh.Global.oDwell_time_ORGANIZATION_DATA_SOURCE_KPI_ID,
                        SITE_ID = (int)site.SITE_ID,
                        CATEGORY = "Severity Type:0,Incident Category Type:0,EXT_STUDY_ZONE_ID:0"
                    }
                });
            };
            foreach (var study_zone in i_Params_Generate_Site_Visitor_Data_And_Dwell_Time.Dwell_Time_4.LIST_STUDY_ZONE)
            {
                Site oSite = i_Params_Generate_Site_Visitor_Data_And_Dwell_Time.List_Site.Find(site => site.STUDY_ZONE_NAME == study_zone.INPUT_GEOID);
                foreach (var bucket in study_zone.List_Bucket)
                {
                    oList_Site_Dwell_Time_4_kpi_data.Add(new Site_kpi_data()
                    {
                        RECORD_DATE = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 0, 0, 0),
                        VALUE = (decimal)bucket.COUNT,
                        VALUE_NAME = oList_Dwell_time[3],
                        VALUE_PER_SQM = bucket.COUNT / oSite.AREA,
                        SITE_METADATA = new Site_metadata()
                        {
                            ORGANIZATION_DATA_SOURCE_KPI_ID = Service_Mesh.Global.oDwell_time_ORGANIZATION_DATA_SOURCE_KPI_ID,
                            SITE_ID = (int)oSite.SITE_ID,
                            CATEGORY = "Severity Type:0,Incident Category Type:0,EXT_STUDY_ZONE_ID:0"
                        }
                    });
                };
            };
            oList_Site_To_Use = new List<Site>();
            oList_Site_To_Use = oList_Site.Where(site => !oList_Site_Dwell_Time_4_kpi_data.Any(site_kpi_data => site_kpi_data.SITE_METADATA.SITE_ID == site.SITE_ID));
            foreach (var site in oList_Site_To_Use)
            {
                oList_Site_Dwell_Time_4_kpi_data.Add(new Site_kpi_data()
                {
                    RECORD_DATE = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 0, 0, 0),
                    VALUE = 0,
                    VALUE_NAME = oList_Dwell_time[3],
                    VALUE_PER_SQM = 0,
                    SITE_METADATA = new Site_metadata()
                    {
                        ORGANIZATION_DATA_SOURCE_KPI_ID = Service_Mesh.Global.oDwell_time_ORGANIZATION_DATA_SOURCE_KPI_ID,
                        SITE_ID = (int)site.SITE_ID,
                        CATEGORY = "Severity Type:0,Incident Category Type:0,EXT_STUDY_ZONE_ID:0"
                    }
                });
            };

            #endregion

            #region Send Data

            List<Site_kpi_data> oList_Site_kpi_data_To_Save = oList_Site_Dwell_Time_1_kpi_data.Concat(oList_Site_Dwell_Time_2_kpi_data).Concat(oList_Site_Dwell_Time_3_kpi_data).Concat(oList_Site_Dwell_Time_4_kpi_data).ToList();
            if (oList_Site_kpi_data_To_Save?.Count > 0)
            {
                try
                {
                    Edit_Site_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN(new Params_Edit_Site_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN()
                    {
                        LIST_SITE_KPI_DATA = oList_Site_kpi_data_To_Save,
                        LIST_ORGANIZATION_DATA_SOURCE_KPI_ID = new List<int?>() { Service_Mesh.Global.oDwell_time_ORGANIZATION_DATA_SOURCE_KPI_ID },
                        RECORD_DATE = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 0, 0, 0),
                        ENUM_TIMESPAN = Enum_Timespan.X_DAILY_COLLECTION
                    });

                    Edit_Site_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN(new Params_Edit_Site_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN()
                    {
                        LIST_SITE_KPI_DATA = oList_Site_Visitor_kpi_data,
                        LIST_ORGANIZATION_DATA_SOURCE_KPI_ID = new List<int?>() { Service_Mesh.Global.oNumber_of_visitors_ORGANIZATION_DATA_SOURCE_KPI_ID },
                        RECORD_DATE = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 0, 0, 0),
                        ENUM_TIMESPAN = Enum_Timespan.X_HOURLY_COLLECTION
                    });
                }
                catch (Exception ex)
                {
                    throw new BLC_Exception(ex.Message);
                }
            }

            #endregion

        }
        #endregion
        #region Generate_Visitor_Activity_Data
        public void Generate_Visitor_Activity_Data(Params_Generate_Visitor_Activity_Data i_Params_Generate_Visitor_Activity_Data)
        {
            #region Setup
            List<Site_kpi_data> oList_Site_kpi_data = new List<Site_kpi_data>();
            List<Area_kpi_data> oList_Area_kpi_data = new List<Area_kpi_data>();
            List<District_kpi_data> oList_District_kpi_data = new List<District_kpi_data>();
            List<Ext_study_zone> oList_Ext_study_zone = Get_Ext_study_zone_By_OWNER_ID(new Params_Get_Ext_study_zone_By_OWNER_ID()
            {
                OWNER_ID = this.oBLC_Initializer.Owner_ID
            });

            DateTime currentTime = i_Params_Generate_Visitor_Activity_Data.START_TIME;
            #endregion

            #region Fill List
            foreach (var study_zone in i_Params_Generate_Visitor_Activity_Data.Visitor_Activity.LIST_STUDY_ZONE)
            {
                Ext_study_zone oExt_study_zone = oList_Ext_study_zone.Find(ext_study_zone => ext_study_zone.STUDY_ZONE_NAME == study_zone.INPUT_GEOID);
                foreach (var bucket in study_zone.List_Bucket)
                {
                    foreach (var output in bucket.LIST_OUTPUT)
                    {
                        Site oSite = i_Params_Generate_Visitor_Activity_Data.List_Site.Find(site => site.STUDY_ZONE_NAME == output.OUTPUT_GEOID);
                        string CATEGORY = "Severity Type:0,Incident Category Type:0,EXT_STUDY_ZONE_ID:" + oExt_study_zone.EXT_STUDY_ZONE_ID.ToString();
                        oList_Site_kpi_data.Add(new Site_kpi_data()
                        {
                            RECORD_DATE = new DateTime(bucket.TIMEFRAME_BUCKET.Value.Year, bucket.TIMEFRAME_BUCKET.Value.Month, bucket.TIMEFRAME_BUCKET.Value.Day, 0, 0, 0),
                            VALUE = (int)output.COUNT,
                            SITE_METADATA = new Site_metadata()
                            {
                                SITE_ID = (int)oSite.SITE_ID,
                                ORGANIZATION_DATA_SOURCE_KPI_ID = Service_Mesh.Global.oVisitor_activity_ORGANIZATION_DATA_SOURCE_KPI_ID,
                                CATEGORY = CATEGORY
                            }
                        });
                    };
                };
            };
            oList_Site_kpi_data = oList_Site_kpi_data.OrderBy(oSite_kpi_data => oSite_kpi_data.RECORD_DATE).ToList();

            List<long?> List_AREA_ID = i_Params_Generate_Visitor_Activity_Data.List_Site.Select(site => site.AREA_ID).Distinct().ToList();
            List<long?> List_DISTRICT_ID = i_Params_Generate_Visitor_Activity_Data.List_Site.Select(site => site.DISTRICT_ID).Distinct().ToList();
            var fill_area_kpi_data = Task.Run(() =>
            {
                foreach (var area_id in List_AREA_ID)
                {
                    var oList_Site = i_Params_Generate_Visitor_Activity_Data.List_Site.Where(site => site.AREA_ID == area_id);
                    List<Site_kpi_data> oList_Site_kpi_data_For_Area = oList_Site_kpi_data.Where(site_kpi_data => oList_Site.Any(site => site.SITE_ID == site_kpi_data.SITE_METADATA.SITE_ID)).ToList();
                    if (oList_Site_kpi_data_For_Area.Count > 0)
                    {
                        oList_Area_kpi_data.AddRange(oList_Site_kpi_data_For_Area.GroupBy(site_kpi_data => site_kpi_data.SITE_METADATA.CATEGORY)
                        .Select(site_kpi_data_group => new Area_kpi_data()
                        {
                            AREA_METADATA = new Area_metadata()
                            {
                                AREA_ID = area_id.Value,
                                CATEGORY = site_kpi_data_group.Key,
                                ORGANIZATION_DATA_SOURCE_KPI_ID = Service_Mesh.Global.oVisitor_activity_ORGANIZATION_DATA_SOURCE_KPI_ID,
                            },
                            RECORD_DATE = site_kpi_data_group.FirstOrDefault().RECORD_DATE,
                            VALUE = site_kpi_data_group.Sum(site_kpi_data => site_kpi_data.VALUE),
                        }));
                    }
                };
            });
            var fill_district_kpi_data = Task.Run(() =>
            {
                foreach (var district_id in List_DISTRICT_ID)
                {
                    var oList_Site = i_Params_Generate_Visitor_Activity_Data.List_Site.Where(site => site.DISTRICT_ID == district_id);
                    List<Site_kpi_data> oList_Site_kpi_data_For_District = oList_Site_kpi_data.Where(site_kpi_data => oList_Site.Any(site => site.SITE_ID == site_kpi_data.SITE_METADATA.SITE_ID)).ToList();
                    if (oList_Site_kpi_data_For_District.Count > 0)
                    {
                        oList_District_kpi_data.AddRange(oList_Site_kpi_data_For_District.GroupBy(site_kpi_data => site_kpi_data.SITE_METADATA.CATEGORY)
                        .Select(site_kpi_data_group => new District_kpi_data()
                        {
                            DISTRICT_METADATA = new District_metadata()
                            {
                                DISTRICT_ID = district_id.Value,
                                CATEGORY = site_kpi_data_group.Key,
                                ORGANIZATION_DATA_SOURCE_KPI_ID = Service_Mesh.Global.oVisitor_activity_ORGANIZATION_DATA_SOURCE_KPI_ID,
                            },
                            RECORD_DATE = site_kpi_data_group.FirstOrDefault().RECORD_DATE,
                            VALUE = site_kpi_data_group.Sum(site_kpi_data => site_kpi_data.VALUE),
                        }));
                    }
                };
            });
            Task.WaitAll(fill_area_kpi_data, fill_district_kpi_data);
            #endregion

            #region Send Data
            var edit_site_kpi_data = Task.Run(() =>
            {
                if (oList_Site_kpi_data?.Count > 0)
                {
                    try
                    {
                        Edit_Site_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN(new Params_Edit_Site_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN()
                        {
                            LIST_SITE_KPI_DATA = oList_Site_kpi_data,
                            LIST_ORGANIZATION_DATA_SOURCE_KPI_ID = new List<int?>() { Service_Mesh.Global.oVisitor_activity_ORGANIZATION_DATA_SOURCE_KPI_ID },
                            RECORD_DATE = currentTime,
                            ENUM_TIMESPAN = Enum_Timespan.X_DAILY_COLLECTION
                        });
                    }
                    catch (Exception ex)
                    {
                        throw new BLC_Exception(ex.Message);
                    }
                }
            });

            var edit_area_kpi_data = Task.Run(() =>
            {
                if (oList_Area_kpi_data?.Count > 0)
                {
                    try
                    {
                        Edit_Area_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN(new Params_Edit_Area_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN()
                        {
                            LIST_AREA_KPI_DATA = oList_Area_kpi_data,
                            LIST_ORGANIZATION_DATA_SOURCE_KPI_ID = new List<int?>() { Service_Mesh.Global.oVisitor_activity_ORGANIZATION_DATA_SOURCE_KPI_ID },
                            RECORD_DATE = currentTime,
                            ENUM_TIMESPAN = Enum_Timespan.X_DAILY_COLLECTION
                        });
                    }
                    catch (Exception ex)
                    {
                        throw new BLC_Exception(ex.Message);
                    }
                }
            });

            var edit_district_kpi_data = Task.Run(() =>
            {
                if (oList_District_kpi_data?.Count > 0)
                {
                    try
                    {
                        Edit_District_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN(new Params_Edit_District_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN()
                        {
                            LIST_DISTRICT_KPI_DATA = oList_District_kpi_data,
                            LIST_ORGANIZATION_DATA_SOURCE_KPI_ID = new List<int?>() { Service_Mesh.Global.oVisitor_activity_ORGANIZATION_DATA_SOURCE_KPI_ID },
                            RECORD_DATE = currentTime,
                            ENUM_TIMESPAN = Enum_Timespan.X_DAILY_COLLECTION
                        });
                    }
                    catch (Exception ex)
                    {
                        throw new BLC_Exception(ex.Message);
                    }
                }
            });
            Task.WaitAll(edit_site_kpi_data, edit_area_kpi_data, edit_district_kpi_data);
            #endregion
        }
        #endregion
        #region Generate_Worker_Data
        public void Generate_Worker_Data(Params_Generate_Worker_Data i_Params_Generate_Worker_Data)
        {
            #region Setup
            List<Site_kpi_data> oList_Site_Visitor_kpi_data = new List<Site_kpi_data>();
            List<Site> oList_Site = Get_Site_By_OWNER_ID(new Params_Get_Site_By_OWNER_ID()
            {
                OWNER_ID = this.oBLC_Initializer.Owner_ID
            });
            DateTime currentTime = i_Params_Generate_Worker_Data.START_TIME;
            #endregion

            #region Fill List
            foreach (var study_zone in i_Params_Generate_Worker_Data.Visitor_Data.LIST_STUDY_ZONE)
            {
                Site oSite = i_Params_Generate_Worker_Data.List_Site.Find(site => site.STUDY_ZONE_NAME == study_zone.INPUT_GEOID);
                foreach (var bucket in study_zone.List_Bucket)
                {
                    oList_Site_Visitor_kpi_data.Add(new Site_kpi_data()
                    {
                        RECORD_DATE = new DateTime(bucket.TIMEFRAME_BUCKET.Value.Year, bucket.TIMEFRAME_BUCKET.Value.Month, bucket.TIMEFRAME_BUCKET.Value.Day, bucket.TIMEFRAME_BUCKET.Value.Hour, 0, 0),
                        VALUE = (decimal)bucket.COUNT,
                        VALUE_NAME = bucket.TIMEFRAME_BUCKET.ToString(),
                        VALUE_PER_SQM = bucket.COUNT / oSite.AREA,
                        SITE_METADATA = new Site_metadata()
                        {
                            ORGANIZATION_DATA_SOURCE_KPI_ID = Service_Mesh.Global.oNumber_of_workers_ORGANIZATION_DATA_SOURCE_KPI_ID,
                            SITE_ID = (int)oSite.SITE_ID,
                            CATEGORY = "Severity Type:0,Incident Category Type:0,EXT_STUDY_ZONE_ID:0",
                        }
                    });
                };
            };
            while (currentTime < i_Params_Generate_Worker_Data.START_TIME.AddDays(1))
            {
                var oList_Site_To_Use = oList_Site.Where(site => !oList_Site_Visitor_kpi_data.Any(site_kpi_data => site_kpi_data.VALUE_NAME == currentTime.ToString() && site_kpi_data.SITE_METADATA.SITE_ID == site.SITE_ID));
                foreach (var site in oList_Site_To_Use)
                {
                    oList_Site_Visitor_kpi_data.Add(new Site_kpi_data()
                    {
                        RECORD_DATE = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, currentTime.Hour, 0, 0),
                        VALUE = 0,
                        VALUE_NAME = currentTime.ToString(),
                        VALUE_PER_SQM = 0,
                        SITE_METADATA = new Site_metadata()
                        {
                            ORGANIZATION_DATA_SOURCE_KPI_ID = Service_Mesh.Global.oNumber_of_workers_ORGANIZATION_DATA_SOURCE_KPI_ID,
                            SITE_ID = (int)site.SITE_ID,
                            CATEGORY = "Severity Type:0,Incident Category Type:0,EXT_STUDY_ZONE_ID:0",
                        }
                    });
                };
                currentTime = currentTime.AddHours(1);
            }
            oList_Site_Visitor_kpi_data = oList_Site_Visitor_kpi_data.OrderBy(site_kpi_data => site_kpi_data.RECORD_DATE).ToList();
            #endregion

            #region Send Data
            if (oList_Site_Visitor_kpi_data?.Count > 0)
            {
                try
                {
                    Edit_Site_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN(new Params_Edit_Site_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN()
                    {
                        LIST_SITE_KPI_DATA = oList_Site_Visitor_kpi_data,
                        LIST_ORGANIZATION_DATA_SOURCE_KPI_ID = new List<int?>() { Service_Mesh.Global.oNumber_of_workers_ORGANIZATION_DATA_SOURCE_KPI_ID },
                        RECORD_DATE = currentTime,
                        ENUM_TIMESPAN = Enum_Timespan.X_HOURLY_COLLECTION
                    });
                }
                catch (Exception ex)
                {
                    throw new BLC_Exception(ex.Message);
                }
            }
            #endregion
        }
        #endregion
        #region Generate_Site_Demographic_Data
        public void Generate_Site_Demographic_Data(Params_Generate_Site_Demographic_Data i_Params_Generate_Site_Demographic_Data)
        {
            #region Setup
            List<Site_kpi_data> oList_site_demographic_data_kpi_data = new List<Site_kpi_data>();

            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = Get_Organization_data_source_kpi_By_OWNER_ID_Adv(new Params_Get_Organization_data_source_kpi_By_OWNER_ID()
            {
                OWNER_ID = this.oBLC_Initializer.Owner_ID
            });
            DateTime currentTime = i_Params_Generate_Site_Demographic_Data.START_TIME;
            #endregion

            #region Fill List
            foreach (var study_zone in i_Params_Generate_Site_Demographic_Data.Demographic_Data.LIST_STUDY_ZONE)
            {
                Site oSite = i_Params_Generate_Site_Demographic_Data.List_Site.Find(site => site.STUDY_ZONE_NAME == study_zone.INPUT_GEOID);
                foreach (var topic in study_zone.LIST_TOPIC)
                {
                    foreach (var characteristic in topic.LIST_CHARACTERISTIC)
                    {
                        oList_site_demographic_data_kpi_data.Add(new Site_kpi_data()
                        {
                            RECORD_DATE = i_Params_Generate_Site_Demographic_Data.START_TIME,
                            VALUE = (int)characteristic.PERCENTAGE,
                            VALUE_NAME = characteristic.CHARACTERISTIC,
                            VALUE_PER_SQM = 0,
                            SITE_METADATA = new Site_metadata()
                            {
                                ORGANIZATION_DATA_SOURCE_KPI_ID = (int)oList_Organization_data_source_kpi.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.NAME == topic.TOPIC)?.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                SITE_ID = (int)oSite.SITE_ID,
                                CATEGORY = "Severity Type:0,Incident Category Type:0,EXT_STUDY_ZONE_ID:0"
                            }
                        });
                    };
                };
            };
            #endregion

            #region Send Data
            if (oList_site_demographic_data_kpi_data?.Count > 0)
            {
                try
                {
                    Edit_Site_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN(new Params_Edit_Site_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN()
                    {
                        LIST_SITE_KPI_DATA = oList_site_demographic_data_kpi_data,
                        LIST_ORGANIZATION_DATA_SOURCE_KPI_ID = Service_Mesh.Global.oList_Demographics_ORGANIZATION_DATA_SOURCE_KPI_ID,
                        RECORD_DATE = i_Params_Generate_Site_Demographic_Data.START_TIME,
                        ENUM_TIMESPAN = Enum_Timespan.X_DAILY_COLLECTION
                    });
                }
                catch (Exception ex)
                {
                    throw new BLC_Exception(ex.Message);
                }
            }
            #endregion
        }
        #endregion
        #region Generate_Or_Compute_Site_Hourly_Data
        public void Generate_Or_Compute_Site_Hourly_Data(Params_Generate_Or_Compute_Site_Hourly_Data i_Params_Generate_Or_Compute_Site_Hourly_Data)
        {
            var generate_site_hourly_Task = Task.Run(() =>
            {
                try
                {
                    Generate_Site_Hourly_Indexes(new Params_Generate_Site_Hourly_Indexes()
                    {
                        DAY = i_Params_Generate_Or_Compute_Site_Hourly_Data.DAY,
                        HOUR = i_Params_Generate_Or_Compute_Site_Hourly_Data.HOUR,
                        MONTH = i_Params_Generate_Or_Compute_Site_Hourly_Data.MONTH,
                        YEAR = i_Params_Generate_Or_Compute_Site_Hourly_Data.YEAR,
                        LIST_ORGANIZATION_DATA_SOURCE_KPI = i_Params_Generate_Or_Compute_Site_Hourly_Data.LIST_ORGANIZATION_DATA_SOURCE_KPI.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.Min_data_level_setup.VALUE == "Site").ToList(),
                    });
                }
                catch { }
            });
            var compute_site_hourly_Task = Task.Run(() =>
            {
                try
                {
                    this._service_mesh.Compute_Site_Kpi_Data_Hourly(new Service_Mesh.Params_Compute_Site_Kpi_Data_Hourly()
                    {
                        DAY = i_Params_Generate_Or_Compute_Site_Hourly_Data.DAY,
                        HOUR = i_Params_Generate_Or_Compute_Site_Hourly_Data.HOUR,
                        MONTH = i_Params_Generate_Or_Compute_Site_Hourly_Data.MONTH,
                        YEAR = i_Params_Generate_Or_Compute_Site_Hourly_Data.YEAR,
                        LIST_ORGANIZATION_DATA_SOURCE_KPI = Props.Copy_Prop_Values_From_Api_Response<List<Service_Mesh.Organization_data_source_kpi>>(i_Params_Generate_Or_Compute_Site_Hourly_Data.LIST_ORGANIZATION_DATA_SOURCE_KPI.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.Min_data_level_setup.VALUE != "Site").ToList()),
                    });
                }
                catch { }
            });
            Task.WaitAll(generate_site_hourly_Task, compute_site_hourly_Task);
        }
        #endregion
        #region Generate_Site_Hourly_Indexes
        public void Generate_Site_Hourly_Indexes(Params_Generate_Site_Hourly_Indexes i_Params_Generate_Site_Hourly_Indexes)
        {
            #region setup
            if (i_Params_Generate_Site_Hourly_Indexes.LIST_ORGANIZATION_DATA_SOURCE_KPI == null || i_Params_Generate_Site_Hourly_Indexes.LIST_ORGANIZATION_DATA_SOURCE_KPI.Count == 0)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }
            DateTime CurrentDate = new DateTime(i_Params_Generate_Site_Hourly_Indexes.YEAR, i_Params_Generate_Site_Hourly_Indexes.MONTH, i_Params_Generate_Site_Hourly_Indexes.DAY, i_Params_Generate_Site_Hourly_Indexes.HOUR, 0, 0);
            List<Setup_category> oList_Setup_category = Get_Setup_category_By_OWNER_ID(new Params_Get_Setup_category_By_OWNER_ID()
            {
                OWNER_ID = this.oBLC_Initializer.Owner_ID
            });
            List<Setup> oList_Severity_Type_Setup = oList_Setup_category.First(oSetup_category => oSetup_category.SETUP_CATEGORY_NAME == "Severity Type").List_Setup;
            List<Site> oList_Site = Get_Site_By_OWNER_ID(new Params_Get_Site_By_OWNER_ID()
            {
                OWNER_ID = this.oBLC_Initializer.Owner_ID
            });

            List<Site_kpi_data> oList_Site_kpi_data = new List<Site_kpi_data>();
            #endregion

            #region fill list
            foreach (var oOrganization_data_source_kpi in i_Params_Generate_Site_Hourly_Indexes.LIST_ORGANIZATION_DATA_SOURCE_KPI)
            {
                if (oOrganization_data_source_kpi.Kpi.SETUP_CATEGORY_ID != null)
                {
                    oOrganization_data_source_kpi.Kpi.Setup_category = oList_Setup_category.Find(setup_category => setup_category.SETUP_CATEGORY_ID == oOrganization_data_source_kpi.Kpi.SETUP_CATEGORY_ID);
                    foreach (var site in oList_Site)
                    {
                        oOrganization_data_source_kpi.Kpi.Setup_category.List_Setup.ForEach(setup =>
                        {
                            if (oOrganization_data_source_kpi.Kpi.IS_BY_SEVERITY)
                            {
                                foreach (var severity in oList_Severity_Type_Setup)
                                {
                                    decimal randomValue = (decimal)(oOrganization_data_source_kpi.Kpi.IS_DECIMAL_VALUE ? Tools.Get_Random_Decimal() * (oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE - oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE) + oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE : Tools.Get_Random_Number((int)oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE, (int)oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE + 1));
                                    string Severity_Type = "Severity Type:" + severity.SETUP_ID.ToString();
                                    string Incident_Category_Type = "Incident Category Type:" + setup.SETUP_ID.ToString();
                                    string CATEGORY = Severity_Type + "," + Incident_Category_Type + ",EXT_STUDY_ZONE_ID:0";
                                    oList_Site_kpi_data.Add(new Site_kpi_data()
                                    {
                                        VALUE = randomValue,
                                        VALUE_PER_SQM = randomValue / site.AREA,
                                        RECORD_DATE = CurrentDate,
                                        VALUE_NAME = oOrganization_data_source_kpi.Kpi.IS_TRENDLINE ? CurrentDate.ToString() : setup.VALUE,
                                        SITE_METADATA = new Site_metadata()
                                        {
                                            ORGANIZATION_DATA_SOURCE_KPI_ID = (int)oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                            SITE_ID = (int)site.SITE_ID,
                                            CATEGORY = CATEGORY
                                        },
                                    });
                                };
                            }
                            else
                            {
                                decimal randomValue = (decimal)(oOrganization_data_source_kpi.Kpi.IS_DECIMAL_VALUE ? Tools.Get_Random_Decimal() * (oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE - oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE) + oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE : Tools.Get_Random_Number((int)oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE, (int)oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE + 1));
                                string Incident_Category_Type = "Incident Category Type:" + setup.SETUP_ID.ToString();
                                string CATEGORY = "Severity Type:0," + Incident_Category_Type + ",EXT_STUDY_ZONE_ID:0";
                                oList_Site_kpi_data.Add(new Site_kpi_data()
                                {
                                    VALUE = randomValue,
                                    VALUE_PER_SQM = randomValue / site.AREA,
                                    RECORD_DATE = CurrentDate,
                                    VALUE_NAME = oOrganization_data_source_kpi.Kpi.IS_TRENDLINE ? CurrentDate.ToString() : setup.VALUE,
                                    SITE_METADATA = new Site_metadata()
                                    {
                                        ORGANIZATION_DATA_SOURCE_KPI_ID = (int)oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                        SITE_ID = (int)site.SITE_ID,
                                        CATEGORY = CATEGORY
                                    },
                                });
                            }
                        });
                    };
                }
                else
                {
                    foreach (var site in oList_Site)
                    {
                        if (oOrganization_data_source_kpi.Kpi.IS_BY_SEVERITY)
                        {
                            foreach (var severity in oList_Severity_Type_Setup)
                            {
                                decimal randomValue = (decimal)(oOrganization_data_source_kpi.Kpi.IS_DECIMAL_VALUE ? Tools.Get_Random_Decimal() * (oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE - oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE) + oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE : Tools.Get_Random_Number((int)oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE, (int)oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE + 1));
                                string Severity_Type = "Severity Type:" + severity.SETUP_ID.ToString();
                                string CATEGORY = Severity_Type + ",Incident Category Type:0,EXT_STUDY_ZONE_ID:0";
                                oList_Site_kpi_data.Add(new Site_kpi_data()
                                {
                                    VALUE = randomValue,
                                    VALUE_PER_SQM = randomValue / site.AREA,
                                    RECORD_DATE = CurrentDate,
                                    VALUE_NAME = CurrentDate.ToString(),
                                    SITE_METADATA = new Site_metadata()
                                    {
                                        ORGANIZATION_DATA_SOURCE_KPI_ID = (int)oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                        SITE_ID = (int)site.SITE_ID,
                                        CATEGORY = CATEGORY
                                    },
                                });
                            };
                        }
                        else
                        {
                            decimal randomValue = (decimal)(oOrganization_data_source_kpi.Kpi.IS_DECIMAL_VALUE ? Tools.Get_Random_Decimal() * (oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE - oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE) + oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE : Tools.Get_Random_Number((int)oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE, (int)oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE + 1));
                            oList_Site_kpi_data.Add(new Site_kpi_data()
                            {
                                VALUE = randomValue,
                                VALUE_PER_SQM = randomValue / site.AREA,
                                RECORD_DATE = CurrentDate,
                                VALUE_NAME = CurrentDate.ToString(),
                                SITE_METADATA = new Site_metadata()
                                {
                                    ORGANIZATION_DATA_SOURCE_KPI_ID = (int)oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                    SITE_ID = (int)site.SITE_ID,
                                    CATEGORY = "Severity Type:0,Incident Category Type:0,EXT_STUDY_ZONE_ID:0",
                                },
                            });
                        }
                    };
                }
            };
            #endregion

            #region send data
            if (oList_Site_kpi_data?.Count > 0)
            {
                try
                {
                    Edit_Site_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN(new Params_Edit_Site_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN()
                    {
                        LIST_SITE_KPI_DATA = oList_Site_kpi_data,
                        LIST_ORGANIZATION_DATA_SOURCE_KPI_ID = i_Params_Generate_Site_Hourly_Indexes.LIST_ORGANIZATION_DATA_SOURCE_KPI.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList(),
                        RECORD_DATE = CurrentDate,
                        ENUM_TIMESPAN = Enum_Timespan.X_HOURLY_COLLECTION
                    });
                }
                catch (Exception ex)
                {
                    throw new BLC_Exception(ex.Message);
                }
            }
            #endregion
        }
        #endregion
        #region Edit_Site_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN
        public void Edit_Site_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN(Params_Edit_Site_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN i_Params_Edit_Site_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN)
        {
            List<Site_kpi_data> oList_Site_kpi_data = Props.Copy_Prop_Values_From_Api_Response<List<Site_kpi_data>>(this._MongoDb.Get_Site_Kpi_Data_By_Where(
                START_DATE: i_Params_Edit_Site_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN.RECORD_DATE,
                END_DATE: i_Params_Edit_Site_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN.RECORD_DATE.Value.AddSeconds(1),
                ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: i_Params_Edit_Site_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN.LIST_ORGANIZATION_DATA_SOURCE_KPI_ID,
                ENUM_TIMESPAN: (DALC.Enum_Timespan)i_Params_Edit_Site_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN.ENUM_TIMESPAN,
                SITE_ID_LIST: null
            ));

            if (oList_Site_kpi_data?.Count > 0)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0044).Replace("%1", "Site").Replace("%2", i_Params_Edit_Site_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN.RECORD_DATE.ToString())); // Data for %1 on date %2 already exists
            }

            Insert_Site_Kpi_Data_List(new Params_Insert_Site_Kpi_Data_List()
            {
                SITE_KPI_DATA_LIST = i_Params_Edit_Site_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN.LIST_SITE_KPI_DATA,
                ENUM_TIMESPAN = i_Params_Edit_Site_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN.ENUM_TIMESPAN
            });
        }
        #endregion
        #region Insert_Site_Kpi_Data_List
        public void Insert_Site_Kpi_Data_List(Params_Insert_Site_Kpi_Data_List i_Params_Insert_Site_Kpi_Data_List)
        {
            List<DALC.Site_kpi_data> oList_Site_kpi_data = null;
            if (i_Params_Insert_Site_Kpi_Data_List.SITE_KPI_DATA_LIST != null && i_Params_Insert_Site_Kpi_Data_List.SITE_KPI_DATA_LIST.Count() > 0)
            {
                oList_Site_kpi_data = new List<DALC.Site_kpi_data>();
                foreach (var site_kpi_data in i_Params_Insert_Site_Kpi_Data_List.SITE_KPI_DATA_LIST)
                {
                    DALC.Site_kpi_data oSite_kpi_data = new DALC.Site_kpi_data()
                    {
                        RECORD_DATE = new DateTime(site_kpi_data.RECORD_DATE.Year, site_kpi_data.RECORD_DATE.Month, site_kpi_data.RECORD_DATE.Day, site_kpi_data.RECORD_DATE.Hour, site_kpi_data.RECORD_DATE.Minute, site_kpi_data.RECORD_DATE.Second, DateTimeKind.Utc),
                        VALUE = site_kpi_data.VALUE,
                        VALUE_NAME = site_kpi_data.VALUE_NAME,
                        VALUE_PER_SQM = site_kpi_data.VALUE_PER_SQM,
                        SITE_METADATA = new DALC.Site_metadata()
                        {
                            SITE_ID = site_kpi_data.SITE_METADATA.SITE_ID,
                            CATEGORY = site_kpi_data.SITE_METADATA.CATEGORY,
                            ORGANIZATION_DATA_SOURCE_KPI_ID = site_kpi_data.SITE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID,
                        },
                    };
                    oList_Site_kpi_data.Add(oSite_kpi_data);
                }
                this._MongoDb.Insert_Site_Kpi_Data_List(oList_Site_kpi_data, (DALC.Enum_Timespan)i_Params_Insert_Site_Kpi_Data_List.ENUM_TIMESPAN);
            }
        }
        #endregion
        #region Delete_Site_Kpi_Data_By_Where
        public void Delete_Site_Kpi_Data_By_Where(Params_Delete_Site_Kpi_Data_By_Where i_Params_Delete_Site_Kpi_Data_By_Where)
        {
            this._MongoDb.Delete_Site_Kpi_Data_By_Where
            (
                SITE_ID_LIST: i_Params_Delete_Site_Kpi_Data_By_Where.SITE_ID_LIST,
                ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: i_Params_Delete_Site_Kpi_Data_By_Where.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST,
                ENUM_TIMESPAN: (DALC.Enum_Timespan)i_Params_Delete_Site_Kpi_Data_By_Where.ENUM_TIMESPAN
            );
        }
        #endregion
        #endregion
        #region Entity
        #region Generate_Entity_Hourly_Indexes
        public void Generate_Entity_Hourly_Indexes(Params_Generate_Entity_Hourly_Indexes i_Params_Generate_Entity_Hourly_Indexes)
        {
            #region setup
            if (i_Params_Generate_Entity_Hourly_Indexes.LIST_ORGANIZATION_DATA_SOURCE_KPI == null || i_Params_Generate_Entity_Hourly_Indexes.LIST_ORGANIZATION_DATA_SOURCE_KPI.Count == 0)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }
            DateTime CurrentDate = new DateTime(i_Params_Generate_Entity_Hourly_Indexes.YEAR, i_Params_Generate_Entity_Hourly_Indexes.MONTH, i_Params_Generate_Entity_Hourly_Indexes.DAY, i_Params_Generate_Entity_Hourly_Indexes.HOUR, 0, 0);
            List<Setup_category> oList_Setup_category = Get_Setup_category_By_OWNER_ID(new Params_Get_Setup_category_By_OWNER_ID()
            {
                OWNER_ID = this.oBLC_Initializer.Owner_ID
            });
            List<Setup> oList_Severity_Type_Setup = oList_Setup_category.First(oSetup_category => oSetup_category.SETUP_CATEGORY_NAME == "Severity Type").List_Setup;
            List<Entity> oList_Entity = Get_Entity_By_OWNER_ID(new Params_Get_Entity_By_OWNER_ID()
            {
                OWNER_ID = this.oBLC_Initializer.Owner_ID
            });
            if (i_Params_Generate_Entity_Hourly_Indexes.LIST_ORGANIZATION_DATA_SOURCE_KPI == null)
            {
                i_Params_Generate_Entity_Hourly_Indexes.LIST_ORGANIZATION_DATA_SOURCE_KPI = Get_Organization_data_source_kpi_By_OWNER_ID_Adv(new Params_Get_Organization_data_source_kpi_By_OWNER_ID()
                {
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                });
                i_Params_Generate_Entity_Hourly_Indexes.LIST_ORGANIZATION_DATA_SOURCE_KPI = i_Params_Generate_Entity_Hourly_Indexes.LIST_ORGANIZATION_DATA_SOURCE_KPI.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.Min_data_level_setup.DISPLAY_ORDER <= 2 && oOrganization_data_source_kpi.Kpi.Max_data_level_setup.DISPLAY_ORDER >= 2).ToList();
            }

            List<Entity_kpi_data> oList_Entity_kpi_data = new List<Entity_kpi_data>();
            #endregion

            #region fill list
            foreach (var oOrganization_data_source_kpi in i_Params_Generate_Entity_Hourly_Indexes.LIST_ORGANIZATION_DATA_SOURCE_KPI)
            {
                if (oOrganization_data_source_kpi.Kpi.SETUP_CATEGORY_ID != null)
                {
                    oOrganization_data_source_kpi.Kpi.Setup_category = oList_Setup_category.Find(setup_category => setup_category.SETUP_CATEGORY_ID == oOrganization_data_source_kpi.Kpi.SETUP_CATEGORY_ID);
                    foreach (var entity in oList_Entity)
                    {
                        oOrganization_data_source_kpi.Kpi.Setup_category.List_Setup.ForEach(setup =>
                        {
                            if (oOrganization_data_source_kpi.Kpi.IS_BY_SEVERITY)
                            {
                                foreach (var severity in oList_Severity_Type_Setup)
                                {
                                    decimal randomValue = (decimal)(oOrganization_data_source_kpi.Kpi.IS_DECIMAL_VALUE ? Tools.Get_Random_Decimal() * (oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE - oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE) + oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE : Tools.Get_Random_Number((int)oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE, (int)oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE + 1));
                                    string Severity_Type = "Severity Type:" + severity.SETUP_ID.ToString();
                                    string Incident_Category_Type = "Incident Category Type:" + setup.SETUP_ID.ToString();
                                    string CATEGORY = Severity_Type + "," + Incident_Category_Type + ",EXT_STUDY_ZONE_ID:0";
                                    oList_Entity_kpi_data.Add(new Entity_kpi_data()
                                    {
                                        VALUE = randomValue,
                                        VALUE_PER_SQM = randomValue / entity.AREA,
                                        RECORD_DATE = CurrentDate,
                                        VALUE_NAME = oOrganization_data_source_kpi.Kpi.IS_TRENDLINE ? CurrentDate.ToString() : setup.VALUE,
                                        ENTITY_METADATA = new Entity_metadata()
                                        {
                                            ORGANIZATION_DATA_SOURCE_KPI_ID = (int)oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                            ENTITY_ID = (int)entity.ENTITY_ID,
                                            CATEGORY = CATEGORY
                                        },
                                    });
                                };
                            }
                            else
                            {
                                decimal randomValue = (decimal)(oOrganization_data_source_kpi.Kpi.IS_DECIMAL_VALUE ? Tools.Get_Random_Decimal() * (oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE - oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE) + oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE : Tools.Get_Random_Number((int)oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE, (int)oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE + 1));
                                string Incident_Category_Type = "Incident Category Type:" + setup.SETUP_ID.ToString();
                                string CATEGORY = "Severity Type:0," + Incident_Category_Type + ",EXT_STUDY_ZONE_ID:0";
                                oList_Entity_kpi_data.Add(new Entity_kpi_data()
                                {
                                    VALUE = randomValue,
                                    VALUE_PER_SQM = randomValue / entity.AREA,
                                    RECORD_DATE = CurrentDate,
                                    VALUE_NAME = oOrganization_data_source_kpi.Kpi.IS_TRENDLINE ? CurrentDate.ToString() : setup.VALUE,
                                    ENTITY_METADATA = new Entity_metadata()
                                    {
                                        ORGANIZATION_DATA_SOURCE_KPI_ID = (int)oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                        ENTITY_ID = (int)entity.ENTITY_ID,
                                        CATEGORY = CATEGORY
                                    },
                                });
                            }
                        });
                    };
                }
                else
                {
                    foreach (var entity in oList_Entity)
                    {
                        if (oOrganization_data_source_kpi.Kpi.IS_BY_SEVERITY)
                        {
                            foreach (var severity in oList_Severity_Type_Setup)
                            {
                                decimal randomValue = (decimal)(oOrganization_data_source_kpi.Kpi.IS_DECIMAL_VALUE ? Tools.Get_Random_Decimal() * (oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE - oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE) + oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE : Tools.Get_Random_Number((int)oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE, (int)oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE + 1));
                                string Severity_Type = "Severity Type:" + severity.SETUP_ID.ToString();
                                string CATEGORY = Severity_Type + ",Incident Category Type:0,EXT_STUDY_ZONE_ID:0";
                                oList_Entity_kpi_data.Add(new Entity_kpi_data()
                                {
                                    VALUE = randomValue,
                                    VALUE_PER_SQM = randomValue / entity.AREA,
                                    RECORD_DATE = CurrentDate,
                                    VALUE_NAME = CurrentDate.ToString(),
                                    ENTITY_METADATA = new Entity_metadata()
                                    {
                                        ORGANIZATION_DATA_SOURCE_KPI_ID = (int)oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                        ENTITY_ID = (int)entity.ENTITY_ID,
                                        CATEGORY = CATEGORY
                                    },
                                });
                            };
                        }
                        else
                        {
                            decimal randomValue = (decimal)(oOrganization_data_source_kpi.Kpi.IS_DECIMAL_VALUE ? Tools.Get_Random_Decimal() * (oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE - oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE) + oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE : Tools.Get_Random_Number((int)oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE, (int)oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE + 1));
                            oList_Entity_kpi_data.Add(new Entity_kpi_data()
                            {
                                VALUE = randomValue,
                                VALUE_PER_SQM = randomValue / entity.AREA,
                                RECORD_DATE = CurrentDate,
                                VALUE_NAME = CurrentDate.ToString(),
                                ENTITY_METADATA = new Entity_metadata()
                                {
                                    ORGANIZATION_DATA_SOURCE_KPI_ID = (int)oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                    ENTITY_ID = (int)entity.ENTITY_ID,
                                    CATEGORY = "Severity Type:0,Incident Category Type:0,EXT_STUDY_ZONE_ID:0",
                                },
                            });
                        }
                    };
                }
            };
            #endregion

            #region send data
            if (oList_Entity_kpi_data?.Count > 0)
            {
                try
                {
                    Edit_Entity_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN(new Params_Edit_Entity_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN()
                    {
                        LIST_ENTITY_KPI_DATA = oList_Entity_kpi_data,
                        LIST_ORGANIZATION_DATA_SOURCE_KPI_ID = i_Params_Generate_Entity_Hourly_Indexes.LIST_ORGANIZATION_DATA_SOURCE_KPI.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList(),
                        RECORD_DATE = CurrentDate,
                        ENUM_TIMESPAN = Enum_Timespan.X_HOURLY_COLLECTION
                    });
                }
                catch (Exception ex)
                {
                    throw new BLC_Exception(ex.Message);
                }
            }
            #endregion
        }
        #endregion
        #region Generate_Or_Compute_Entity_Hourly_Data
        public void Generate_Or_Compute_Entity_Hourly_Data(Params_Generate_Or_Compute_Entity_Hourly_Data i_Params_Generate_Or_Compute_Entity_Hourly_Data)
        {
            var generate_entity_hourly_Task = Task.Run(() =>
            {
                try
                {
                    Generate_Entity_Hourly_Indexes(new Params_Generate_Entity_Hourly_Indexes()
                    {
                        DAY = i_Params_Generate_Or_Compute_Entity_Hourly_Data.DAY,
                        HOUR = i_Params_Generate_Or_Compute_Entity_Hourly_Data.HOUR,
                        MONTH = i_Params_Generate_Or_Compute_Entity_Hourly_Data.MONTH,
                        YEAR = i_Params_Generate_Or_Compute_Entity_Hourly_Data.YEAR,
                        LIST_ORGANIZATION_DATA_SOURCE_KPI = i_Params_Generate_Or_Compute_Entity_Hourly_Data.LIST_ORGANIZATION_DATA_SOURCE_KPI.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.Min_data_level_setup.VALUE == "Entity").ToList(),
                    });
                }
                catch { }
            });
            var compute_entity_hourly_Task = Task.Run(() =>
            {
                try
                {
                    this._service_mesh.Compute_Entity_Kpi_Data_Hourly(new Service_Mesh.Params_Compute_Entity_Kpi_Data_Hourly()
                    {
                        DAY = i_Params_Generate_Or_Compute_Entity_Hourly_Data.DAY,
                        HOUR = i_Params_Generate_Or_Compute_Entity_Hourly_Data.HOUR,
                        MONTH = i_Params_Generate_Or_Compute_Entity_Hourly_Data.MONTH,
                        YEAR = i_Params_Generate_Or_Compute_Entity_Hourly_Data.YEAR,
                        LIST_ORGANIZATION_DATA_SOURCE_KPI = Props.Copy_Prop_Values_From_Api_Response<List<Service_Mesh.Organization_data_source_kpi>>(i_Params_Generate_Or_Compute_Entity_Hourly_Data.LIST_ORGANIZATION_DATA_SOURCE_KPI.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.Min_data_level_setup.VALUE != "Entity").ToList()),
                    });
                }
                catch { }
            });
            Task.WaitAll(generate_entity_hourly_Task, compute_entity_hourly_Task);
        }
        #endregion
        #region Edit_Entity_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN
        public void Edit_Entity_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN(Params_Edit_Entity_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN i_Params_Edit_Entity_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN)
        {
            List<Entity_kpi_data> oList_Entity_kpi_data = Props.Copy_Prop_Values_From_Api_Response<List<Entity_kpi_data>>(this._MongoDb.Get_Entity_Kpi_Data_By_Where(
                START_DATE: i_Params_Edit_Entity_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN.RECORD_DATE,
                END_DATE: i_Params_Edit_Entity_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN.RECORD_DATE.Value.AddSeconds(1),
                ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: i_Params_Edit_Entity_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN.LIST_ORGANIZATION_DATA_SOURCE_KPI_ID,
                ENUM_TIMESPAN: (DALC.Enum_Timespan)i_Params_Edit_Entity_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN.ENUM_TIMESPAN,
                ENTITY_ID_LIST: null
            ));

            if (oList_Entity_kpi_data?.Count > 0)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0044).Replace("%1", "Entity").Replace("%2", i_Params_Edit_Entity_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN.RECORD_DATE.ToString())); // Data for %1 on date %2 already exists
            }

            Insert_Entity_Kpi_Data_List(new Params_Insert_Entity_Kpi_Data_List()
            {
                ENTITY_KPI_DATA_LIST = i_Params_Edit_Entity_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN.LIST_ENTITY_KPI_DATA,
                ENUM_TIMESPAN = i_Params_Edit_Entity_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN.ENUM_TIMESPAN
            });
        }
        #endregion
        #region Insert_Entity_Kpi_Data_List
        public void Insert_Entity_Kpi_Data_List(Params_Insert_Entity_Kpi_Data_List i_Params_Insert_Entity_Kpi_Data_List)
        {
            List<DALC.Entity_kpi_data> oList_Entity_kpi_data = null;
            if (i_Params_Insert_Entity_Kpi_Data_List.ENTITY_KPI_DATA_LIST != null && i_Params_Insert_Entity_Kpi_Data_List.ENTITY_KPI_DATA_LIST.Count() > 0)
            {
                oList_Entity_kpi_data = new List<DALC.Entity_kpi_data>();
                foreach (var entity_kpi_data in i_Params_Insert_Entity_Kpi_Data_List.ENTITY_KPI_DATA_LIST)
                {
                    DALC.Entity_kpi_data oEntity_kpi_data = new DALC.Entity_kpi_data()
                    {
                        RECORD_DATE = new DateTime(entity_kpi_data.RECORD_DATE.Year, entity_kpi_data.RECORD_DATE.Month, entity_kpi_data.RECORD_DATE.Day, entity_kpi_data.RECORD_DATE.Hour, entity_kpi_data.RECORD_DATE.Minute, entity_kpi_data.RECORD_DATE.Second, DateTimeKind.Utc),
                        VALUE = entity_kpi_data.VALUE,
                        VALUE_NAME = entity_kpi_data.VALUE_NAME,
                        VALUE_PER_SQM = entity_kpi_data.VALUE_PER_SQM,
                        ENTITY_METADATA = new DALC.Entity_metadata()
                        {
                            ENTITY_ID = entity_kpi_data.ENTITY_METADATA.ENTITY_ID,
                            CATEGORY = entity_kpi_data.ENTITY_METADATA.CATEGORY,
                            ORGANIZATION_DATA_SOURCE_KPI_ID = entity_kpi_data.ENTITY_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID,
                        },
                    };
                    oList_Entity_kpi_data.Add(oEntity_kpi_data);
                }
                this._MongoDb.Insert_Entity_Kpi_Data_List(oList_Entity_kpi_data, (DALC.Enum_Timespan)i_Params_Insert_Entity_Kpi_Data_List.ENUM_TIMESPAN);
            }
        }
        #endregion
        #region Delete_Entity_Kpi_Data_By_Where
        public void Delete_Entity_Kpi_Data_By_Where(Params_Delete_Entity_Kpi_Data_By_Where i_Params_Delete_Entity_Kpi_Data_By_Where)
        {
            this._MongoDb.Delete_Entity_Kpi_Data_By_Where(
                ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: i_Params_Delete_Entity_Kpi_Data_By_Where.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST,
                ENTITY_ID_LIST: i_Params_Delete_Entity_Kpi_Data_By_Where.ENTITY_ID_LIST,
                ENUM_TIMESPAN: (DALC.Enum_Timespan)i_Params_Delete_Entity_Kpi_Data_By_Where.ENUM_TIMESPAN
            );
        }
        #endregion
        #endregion
        #region Floor
        #region Generate_Floor_Hourly_Indexes
        public void Generate_Floor_Hourly_Indexes(Params_Generate_Floor_Hourly_Indexes i_Params_Generate_Floor_Hourly_Indexes)
        {
            if (i_Params_Generate_Floor_Hourly_Indexes != null)
            {
                #region setup
                if (i_Params_Generate_Floor_Hourly_Indexes.LIST_ORGANIZATION_DATA_SOURCE_KPI == null || i_Params_Generate_Floor_Hourly_Indexes.LIST_ORGANIZATION_DATA_SOURCE_KPI.Count == 0)
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
                }
                DateTime CurrentDate = new DateTime(i_Params_Generate_Floor_Hourly_Indexes.YEAR, i_Params_Generate_Floor_Hourly_Indexes.MONTH, i_Params_Generate_Floor_Hourly_Indexes.DAY, i_Params_Generate_Floor_Hourly_Indexes.HOUR, 0, 0);
                List<Setup_category> oList_Setup_category = Get_Setup_category_By_OWNER_ID(new Params_Get_Setup_category_By_OWNER_ID()
                {
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                });
                List<Setup> oList_Severity_Type_Setup = oList_Setup_category.First(oSetup_category => oSetup_category.SETUP_CATEGORY_NAME == "Severity Type").List_Setup;
                List<Floor> oList_Floor = Get_Floor_By_OWNER_ID(new Params_Get_Floor_By_OWNER_ID()
                {
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                });
                if (i_Params_Generate_Floor_Hourly_Indexes.LIST_ORGANIZATION_DATA_SOURCE_KPI == null)
                {
                    i_Params_Generate_Floor_Hourly_Indexes.LIST_ORGANIZATION_DATA_SOURCE_KPI = Get_Organization_data_source_kpi_By_OWNER_ID_Adv(new Params_Get_Organization_data_source_kpi_By_OWNER_ID()
                    {
                        OWNER_ID = this.oBLC_Initializer.Owner_ID
                    });

                    i_Params_Generate_Floor_Hourly_Indexes.LIST_ORGANIZATION_DATA_SOURCE_KPI = i_Params_Generate_Floor_Hourly_Indexes.LIST_ORGANIZATION_DATA_SOURCE_KPI.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.Min_data_level_setup.DISPLAY_ORDER <= 1 && oOrganization_data_source_kpi.Kpi.Max_data_level_setup.DISPLAY_ORDER >= 1).ToList();
                }
                List<Floor_kpi_data> oList_Floor_kpi_data = new List<Floor_kpi_data>();
                #endregion

                #region fill list
                foreach (var oOrganization_data_source_kpi in i_Params_Generate_Floor_Hourly_Indexes.LIST_ORGANIZATION_DATA_SOURCE_KPI)
                {
                    if (oOrganization_data_source_kpi.Kpi.SETUP_CATEGORY_ID != null)
                    {
                        oOrganization_data_source_kpi.Kpi.Setup_category = oList_Setup_category.Find(setup_category => setup_category.SETUP_CATEGORY_ID == oOrganization_data_source_kpi.Kpi.SETUP_CATEGORY_ID);
                        foreach (var floor in oList_Floor)
                        {
                            oOrganization_data_source_kpi.Kpi.Setup_category.List_Setup.ForEach(setup =>
                            {
                                if (oOrganization_data_source_kpi.Kpi.IS_BY_SEVERITY)
                                {
                                    foreach (var severity in oList_Severity_Type_Setup)
                                    {
                                        decimal randomValue = (decimal)(oOrganization_data_source_kpi.Kpi.IS_DECIMAL_VALUE ? Tools.Get_Random_Decimal() * (oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE - oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE) + oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE : Tools.Get_Random_Number((int)oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE, (int)oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE + 1));
                                        string Severity_Type = "Severity Type:" + severity.SETUP_ID.ToString();
                                        string Incident_Category_Type = "Incident Category Type:" + setup.SETUP_ID.ToString();
                                        string CATEGORY = Severity_Type + "," + Incident_Category_Type + ",EXT_STUDY_ZONE_ID:0";
                                        oList_Floor_kpi_data.Add(new Floor_kpi_data()
                                        {
                                            VALUE = randomValue,
                                            VALUE_PER_SQM = randomValue / floor.AREA,
                                            RECORD_DATE = CurrentDate,
                                            VALUE_NAME = oOrganization_data_source_kpi.Kpi.IS_TRENDLINE ? CurrentDate.ToString() : setup.VALUE,
                                            FLOOR_METADATA = new Floor_metadata()
                                            {
                                                ORGANIZATION_DATA_SOURCE_KPI_ID = (int)oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                FLOOR_ID = (int)floor.FLOOR_ID,
                                                CATEGORY = CATEGORY
                                            },
                                        });
                                    };
                                }
                                else
                                {
                                    decimal randomValue = (decimal)(oOrganization_data_source_kpi.Kpi.IS_DECIMAL_VALUE ? Tools.Get_Random_Decimal() * (oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE - oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE) + oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE : Tools.Get_Random_Number((int)oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE, (int)oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE + 1));
                                    string Incident_Category_Type = "Incident Category Type:" + setup.SETUP_ID.ToString();
                                    string CATEGORY = "Severity Type:0," + Incident_Category_Type + ",EXT_STUDY_ZONE_ID:0";
                                    oList_Floor_kpi_data.Add(new Floor_kpi_data()
                                    {
                                        VALUE = randomValue,
                                        VALUE_PER_SQM = randomValue / floor.AREA,
                                        RECORD_DATE = CurrentDate,
                                        VALUE_NAME = oOrganization_data_source_kpi.Kpi.IS_TRENDLINE ? CurrentDate.ToString() : setup.VALUE,
                                        FLOOR_METADATA = new Floor_metadata()
                                        {
                                            ORGANIZATION_DATA_SOURCE_KPI_ID = (int)oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                            FLOOR_ID = (int)floor.FLOOR_ID,
                                            CATEGORY = CATEGORY
                                        },
                                    });
                                }
                            });
                        };
                    }
                    else
                    {
                        foreach (var floor in oList_Floor)
                        {
                            if (oOrganization_data_source_kpi.Kpi.IS_BY_SEVERITY)
                            {
                                foreach (var severity in oList_Severity_Type_Setup)
                                {
                                    decimal randomValue = (decimal)(oOrganization_data_source_kpi.Kpi.IS_DECIMAL_VALUE ? Tools.Get_Random_Decimal() * (oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE - oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE) + oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE : Tools.Get_Random_Number((int)oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE, (int)oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE + 1));
                                    string Severity_Type = "Severity Type:" + severity.SETUP_ID.ToString();
                                    string CATEGORY = Severity_Type + ",Incident Category Type:0,EXT_STUDY_ZONE_ID:0";
                                    oList_Floor_kpi_data.Add(new Floor_kpi_data()
                                    {
                                        VALUE = randomValue,
                                        VALUE_PER_SQM = randomValue / floor.AREA,
                                        RECORD_DATE = CurrentDate,
                                        VALUE_NAME = CurrentDate.ToString(),
                                        FLOOR_METADATA = new Floor_metadata()
                                        {
                                            ORGANIZATION_DATA_SOURCE_KPI_ID = (int)oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                            FLOOR_ID = (int)floor.FLOOR_ID,
                                            CATEGORY = CATEGORY
                                        },
                                    });
                                };
                            }
                            else
                            {
                                decimal randomValue = (decimal)(oOrganization_data_source_kpi.Kpi.IS_DECIMAL_VALUE ? Tools.Get_Random_Decimal() * (oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE - oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE) + oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE : Tools.Get_Random_Number((int)oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE, (int)oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE + 1));
                                oList_Floor_kpi_data.Add(new Floor_kpi_data()
                                {
                                    VALUE = randomValue,
                                    VALUE_PER_SQM = randomValue / floor.AREA,
                                    RECORD_DATE = CurrentDate,
                                    VALUE_NAME = CurrentDate.ToString(),
                                    FLOOR_METADATA = new Floor_metadata()
                                    {
                                        ORGANIZATION_DATA_SOURCE_KPI_ID = (int)oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                        FLOOR_ID = (int)floor.FLOOR_ID,
                                        CATEGORY = "Severity Type:0,Incident Category Type:0,EXT_STUDY_ZONE_ID:0",
                                    },
                                });
                            }
                        };
                    }
                };
                #endregion

                #region send data
                if (oList_Floor_kpi_data?.Count > 0)
                {
                    try
                    {
                        Edit_Floor_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN(new Params_Edit_Floor_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN()
                        {
                            LIST_FLOOR_KPI_DATA = oList_Floor_kpi_data,
                            LIST_ORGANIZATION_DATA_SOURCE_KPI_ID = i_Params_Generate_Floor_Hourly_Indexes.LIST_ORGANIZATION_DATA_SOURCE_KPI.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList(),
                            RECORD_DATE = CurrentDate,
                            ENUM_TIMESPAN = Enum_Timespan.X_HOURLY_COLLECTION
                        });
                    }
                    catch (Exception ex)
                    {
                        throw new BLC_Exception(ex.Message);
                    }
                }
                #endregion
            }
        }
        #endregion
        #region Generate_Or_Compute_Floor_Hourly_Data
        public void Generate_Or_Compute_Floor_Hourly_Data(Params_Generate_Or_Compute_Floor_Hourly_Data i_Params_Generate_Or_Compute_Floor_Hourly_Data)
        {
            var generate_floor_hourly_Task = Task.Run(() =>
            {
                try
                {
                    Generate_Floor_Hourly_Indexes(new Params_Generate_Floor_Hourly_Indexes()
                    {
                        DAY = i_Params_Generate_Or_Compute_Floor_Hourly_Data.DAY,
                        HOUR = i_Params_Generate_Or_Compute_Floor_Hourly_Data.HOUR,
                        MONTH = i_Params_Generate_Or_Compute_Floor_Hourly_Data.MONTH,
                        YEAR = i_Params_Generate_Or_Compute_Floor_Hourly_Data.YEAR,
                        LIST_ORGANIZATION_DATA_SOURCE_KPI = i_Params_Generate_Or_Compute_Floor_Hourly_Data.LIST_ORGANIZATION_DATA_SOURCE_KPI.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.Min_data_level_setup.VALUE == "Floor").ToList(),
                    });
                }
                catch { }
            });
            var compute_floor_hourly_Task = Task.Run(() =>
            {
                try
                {
                    this._service_mesh.Compute_Floor_Kpi_Data_Hourly(new Service_Mesh.Params_Compute_Floor_Kpi_Data_Hourly()
                    {
                        DAY = i_Params_Generate_Or_Compute_Floor_Hourly_Data.DAY,
                        HOUR = i_Params_Generate_Or_Compute_Floor_Hourly_Data.HOUR,
                        MONTH = i_Params_Generate_Or_Compute_Floor_Hourly_Data.MONTH,
                        YEAR = i_Params_Generate_Or_Compute_Floor_Hourly_Data.YEAR,
                        LIST_ORGANIZATION_DATA_SOURCE_KPI = Props.Copy_Prop_Values_From_Api_Response<List<Service_Mesh.Organization_data_source_kpi>>(i_Params_Generate_Or_Compute_Floor_Hourly_Data.LIST_ORGANIZATION_DATA_SOURCE_KPI.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.Min_data_level_setup.VALUE != "Floor").ToList()),
                    });
                }
                catch { }
            });
            Task.WaitAll(generate_floor_hourly_Task, compute_floor_hourly_Task);
        }
        #endregion
        #region Edit_Floor_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN
        public void Edit_Floor_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN(Params_Edit_Floor_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN i_Params_Edit_Floor_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN)
        {
            List<Floor_kpi_data> oList_Floor_kpi_data = Props.Copy_Prop_Values_From_Api_Response<List<Floor_kpi_data>>(this._MongoDb.Get_Floor_Kpi_Data_By_Where(
                START_DATE: i_Params_Edit_Floor_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN.RECORD_DATE,
                END_DATE: i_Params_Edit_Floor_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN.RECORD_DATE.Value.AddSeconds(1),
                ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: i_Params_Edit_Floor_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN.LIST_ORGANIZATION_DATA_SOURCE_KPI_ID,
                ENUM_TIMESPAN: (DALC.Enum_Timespan)i_Params_Edit_Floor_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN.ENUM_TIMESPAN,
                FLOOR_ID_LIST: null
            ));

            if (oList_Floor_kpi_data?.Count > 0)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0044).Replace("%1", "Floor").Replace("%2", i_Params_Edit_Floor_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN.RECORD_DATE.ToString())); // Data for %1 on date %2 already exists
            }

            Insert_Floor_Kpi_Data_List(new Params_Insert_Floor_Kpi_Data_List()
            {
                FLOOR_KPI_DATA_LIST = i_Params_Edit_Floor_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN.LIST_FLOOR_KPI_DATA,
                ENUM_TIMESPAN = i_Params_Edit_Floor_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN.ENUM_TIMESPAN
            });
        }
        #endregion
        #region Insert_Floor_Kpi_Data_List
        public void Insert_Floor_Kpi_Data_List(Params_Insert_Floor_Kpi_Data_List i_Params_Insert_Floor_Kpi_Data_List)
        {
            List<DALC.Floor_kpi_data> oList_Floor_kpi_data = null;
            if (i_Params_Insert_Floor_Kpi_Data_List.FLOOR_KPI_DATA_LIST != null && i_Params_Insert_Floor_Kpi_Data_List.FLOOR_KPI_DATA_LIST.Count() > 0)
            {
                oList_Floor_kpi_data = new List<DALC.Floor_kpi_data>();
                foreach (var floor_kpi_data in i_Params_Insert_Floor_Kpi_Data_List.FLOOR_KPI_DATA_LIST)
                {
                    DALC.Floor_kpi_data oFloor_kpi_data = new DALC.Floor_kpi_data()
                    {
                        RECORD_DATE = new DateTime(floor_kpi_data.RECORD_DATE.Year, floor_kpi_data.RECORD_DATE.Month, floor_kpi_data.RECORD_DATE.Day, floor_kpi_data.RECORD_DATE.Hour, floor_kpi_data.RECORD_DATE.Minute, floor_kpi_data.RECORD_DATE.Second, DateTimeKind.Utc),
                        VALUE = floor_kpi_data.VALUE,
                        VALUE_NAME = floor_kpi_data.VALUE_NAME,
                        VALUE_PER_SQM = floor_kpi_data.VALUE_PER_SQM,
                        FLOOR_METADATA = new DALC.Floor_metadata()
                        {
                            FLOOR_ID = floor_kpi_data.FLOOR_METADATA.FLOOR_ID,
                            CATEGORY = floor_kpi_data.FLOOR_METADATA.CATEGORY,
                            ORGANIZATION_DATA_SOURCE_KPI_ID = floor_kpi_data.FLOOR_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID,
                        },
                    };
                    oList_Floor_kpi_data.Add(oFloor_kpi_data);
                }
                this._MongoDb.Insert_Floor_Kpi_Data_List(oList_Floor_kpi_data, (DALC.Enum_Timespan)i_Params_Insert_Floor_Kpi_Data_List.ENUM_TIMESPAN);
            }
        }
        #endregion
        #region Delete_Floor_Kpi_Data_By_Where
        public void Delete_Floor_Kpi_Data_By_Where(Params_Delete_Floor_Kpi_Data_By_Where i_Params_Delete_Floor_Kpi_Data_By_Where)
        {
            this._MongoDb.Delete_Floor_Kpi_Data_By_Where
            (
                FLOOR_ID_LIST: i_Params_Delete_Floor_Kpi_Data_By_Where.FLOOR_ID_LIST,
                ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: i_Params_Delete_Floor_Kpi_Data_By_Where.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST,
                ENUM_TIMESPAN: (DALC.Enum_Timespan)i_Params_Delete_Floor_Kpi_Data_By_Where.ENUM_TIMESPAN
            );
        }
        #endregion
        #endregion
        #region Space
        #region Generate_Space_Hourly_Indexes
        public void Generate_Space_Hourly_Indexes(Params_Generate_Space_Hourly_Indexes i_Params_Generate_Space_Hourly_Indexes)
        {
            if (i_Params_Generate_Space_Hourly_Indexes != null)
            {
                #region setup
                if (i_Params_Generate_Space_Hourly_Indexes.LIST_ORGANIZATION_DATA_SOURCE_KPI == null || i_Params_Generate_Space_Hourly_Indexes.LIST_ORGANIZATION_DATA_SOURCE_KPI.Count == 0)
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
                }
                DateTime CurrentDate = new DateTime(i_Params_Generate_Space_Hourly_Indexes.YEAR, i_Params_Generate_Space_Hourly_Indexes.MONTH, i_Params_Generate_Space_Hourly_Indexes.DAY, i_Params_Generate_Space_Hourly_Indexes.HOUR, 0, 0);
                List<Setup_category> oList_Setup_category = Get_Setup_category_By_OWNER_ID(new Params_Get_Setup_category_By_OWNER_ID()
                {
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                });
                List<Setup> oList_Severity_Type_Setup = oList_Setup_category.First(oSetup_category => oSetup_category.SETUP_CATEGORY_NAME == "Severity Type").List_Setup;
                List<Space> oList_Space = Get_Space_By_OWNER_ID(new Params_Get_Space_By_OWNER_ID()
                {
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                });
                List<Space_kpi_data> oList_Space_kpi_data = new List<Space_kpi_data>();
                if (i_Params_Generate_Space_Hourly_Indexes.LIST_ORGANIZATION_DATA_SOURCE_KPI == null)
                {
                    i_Params_Generate_Space_Hourly_Indexes.LIST_ORGANIZATION_DATA_SOURCE_KPI = Get_Organization_data_source_kpi_By_OWNER_ID_Adv(new Params_Get_Organization_data_source_kpi_By_OWNER_ID()
                    {
                        OWNER_ID = this.oBLC_Initializer.Owner_ID
                    });

                    i_Params_Generate_Space_Hourly_Indexes.LIST_ORGANIZATION_DATA_SOURCE_KPI = i_Params_Generate_Space_Hourly_Indexes.LIST_ORGANIZATION_DATA_SOURCE_KPI.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.Min_data_level_setup.DISPLAY_ORDER <= 0 && oOrganization_data_source_kpi.Kpi.Max_data_level_setup.DISPLAY_ORDER >= 0).ToList();
                }
                #endregion
                #region fill list
                foreach (var oOrganization_data_source_kpi in i_Params_Generate_Space_Hourly_Indexes.LIST_ORGANIZATION_DATA_SOURCE_KPI)
                {
                    if (oOrganization_data_source_kpi.Kpi.SETUP_CATEGORY_ID != null)
                    {
                        oOrganization_data_source_kpi.Kpi.Setup_category = oList_Setup_category.Find(setup_category => setup_category.SETUP_CATEGORY_ID == oOrganization_data_source_kpi.Kpi.SETUP_CATEGORY_ID);
                        foreach (var space in oList_Space)
                        {

                            foreach (var setup in oOrganization_data_source_kpi.Kpi.Setup_category.List_Setup)
                            {
                                if (oOrganization_data_source_kpi.Kpi.IS_BY_SEVERITY)
                                {
                                    foreach (var severity in oList_Severity_Type_Setup)
                                    {
                                        decimal randomValue = (decimal)(oOrganization_data_source_kpi.Kpi.IS_DECIMAL_VALUE ? Tools.Get_Random_Decimal() * (oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE - oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE) + oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE : Tools.Get_Random_Number((int)oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE, (int)oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE + 1));
                                        string Severity_Type = "Severity Type:" + severity.SETUP_ID.ToString();
                                        string Incident_Category_Type = "Incident Category Type:" + setup.SETUP_ID.ToString();
                                        string CATEGORY = Severity_Type + "," + Incident_Category_Type + ",EXT_STUDY_ZONE_ID:0";
                                        oList_Space_kpi_data.Add(new Space_kpi_data()
                                        {
                                            VALUE = randomValue,
                                            VALUE_PER_SQM = randomValue / space.AREA,
                                            RECORD_DATE = CurrentDate,
                                            VALUE_NAME = oOrganization_data_source_kpi.Kpi.IS_TRENDLINE ? CurrentDate.ToString() : setup.VALUE,
                                            SPACE_METADATA = new Space_metadata()
                                            {
                                                SPACE_ID = (long)space.SPACE_ID,
                                                FLOOR_ID = (long)space.FLOOR_ID,
                                                ORGANIZATION_DATA_SOURCE_KPI_ID = (int)oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                CATEGORY = CATEGORY,
                                            },
                                        });
                                    };
                                }
                                else
                                {
                                    decimal randomValue = (decimal)(oOrganization_data_source_kpi.Kpi.IS_DECIMAL_VALUE ? Tools.Get_Random_Decimal() * (oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE - oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE) + oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE : Tools.Get_Random_Number((int)oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE, (int)oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE + 1));
                                    string Incident_Category_Type = "Incident Category Type:" + setup.SETUP_ID.ToString();
                                    string CATEGORY = "Severity Type:0," + Incident_Category_Type + ",EXT_STUDY_ZONE_ID:0";
                                    oList_Space_kpi_data.Add(new Space_kpi_data()
                                    {
                                        VALUE = randomValue,
                                        VALUE_PER_SQM = randomValue / space.AREA,
                                        RECORD_DATE = CurrentDate,
                                        VALUE_NAME = oOrganization_data_source_kpi.Kpi.IS_TRENDLINE ? CurrentDate.ToString() : setup.VALUE,
                                        SPACE_METADATA = new Space_metadata()
                                        {
                                            SPACE_ID = (long)space.SPACE_ID,
                                            FLOOR_ID = (long)space.FLOOR_ID,
                                            ORGANIZATION_DATA_SOURCE_KPI_ID = (int)oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                            CATEGORY = CATEGORY,
                                        },
                                    });
                                }
                            };
                        };
                    }
                    else
                    {
                        foreach (var space in oList_Space)
                        {
                            if (oOrganization_data_source_kpi.Kpi.IS_BY_SEVERITY)
                            {
                                foreach (var severity in oList_Severity_Type_Setup)
                                {
                                    decimal randomValue = (decimal)(oOrganization_data_source_kpi.Kpi.IS_DECIMAL_VALUE ? Tools.Get_Random_Decimal() * (oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE - oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE) + oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE : Tools.Get_Random_Number((int)oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE, (int)oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE + 1));
                                    string Severity_Type = "Severity Type:" + severity.SETUP_ID.ToString();
                                    string CATEGORY = Severity_Type + ",Incident Category Type:0,EXT_STUDY_ZONE_ID:0";
                                    oList_Space_kpi_data.Add(new Space_kpi_data()
                                    {
                                        VALUE = randomValue,
                                        VALUE_PER_SQM = randomValue / space.AREA,
                                        RECORD_DATE = CurrentDate,
                                        VALUE_NAME = CurrentDate.ToString(),
                                        SPACE_METADATA = new Space_metadata()
                                        {
                                            SPACE_ID = (long)space.SPACE_ID,
                                            FLOOR_ID = (long)space.FLOOR_ID,
                                            ORGANIZATION_DATA_SOURCE_KPI_ID = (int)oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                            CATEGORY = CATEGORY,
                                        },
                                    });
                                };
                            }
                            else
                            {
                                decimal randomValue = (decimal)(oOrganization_data_source_kpi.Kpi.IS_DECIMAL_VALUE ? Tools.Get_Random_Decimal() * (oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE - oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE) + oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE : Tools.Get_Random_Number((int)oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE, (int)oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE + 1));
                                oList_Space_kpi_data.Add(new Space_kpi_data()
                                {
                                    VALUE = randomValue,
                                    VALUE_PER_SQM = randomValue / space.AREA,
                                    RECORD_DATE = CurrentDate,
                                    VALUE_NAME = CurrentDate.ToString(),
                                    SPACE_METADATA = new Space_metadata()
                                    {
                                        SPACE_ID = (long)space.SPACE_ID,
                                        FLOOR_ID = (long)space.FLOOR_ID,
                                        ORGANIZATION_DATA_SOURCE_KPI_ID = (int)oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                        CATEGORY = "Severity Type:0,Incident Category Type:0,EXT_STUDY_ZONE_ID:0",
                                    },
                                }); ;
                            }
                        };
                    }
                };
                #endregion
                #region send data
                if (oList_Space_kpi_data?.Count > 0)
                {
                    try
                    {
                        Edit_Space_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN(new Params_Edit_Space_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN()
                        {
                            LIST_SPACE_KPI_DATA = oList_Space_kpi_data,
                            LIST_ORGANIZATION_DATA_SOURCE_KPI_ID = i_Params_Generate_Space_Hourly_Indexes.LIST_ORGANIZATION_DATA_SOURCE_KPI.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList(),
                            RECORD_DATE = CurrentDate,
                            ENUM_TIMESPAN = Enum_Timespan.X_HOURLY_COLLECTION
                        });
                    }
                    catch (Exception ex)
                    {
                        throw new BLC_Exception(ex.Message);
                    }
                }
                #endregion
            }
        }
        #endregion
        #region Edit_Space_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN
        public void Edit_Space_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN(Params_Edit_Space_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN i_Params_Edit_Space_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN)
        {
            List<Space_kpi_data> oList_Space_kpi_data = Props.Copy_Prop_Values_From_Api_Response<List<Space_kpi_data>>(this._MongoDb.Get_Space_Kpi_Data_By_Where(
                START_DATE: i_Params_Edit_Space_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN.RECORD_DATE,
                END_DATE: i_Params_Edit_Space_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN.RECORD_DATE.Value.AddSeconds(1),
                ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: i_Params_Edit_Space_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN.LIST_ORGANIZATION_DATA_SOURCE_KPI_ID,
                ENUM_TIMESPAN: (DALC.Enum_Timespan)i_Params_Edit_Space_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN.ENUM_TIMESPAN,
                SPACE_ID_LIST: null
            ));

            if (oList_Space_kpi_data?.Count > 0)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0044).Replace("%1", "Space").Replace("%2", i_Params_Edit_Space_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN.RECORD_DATE.ToString())); // Data for %1 on date %2 already exists
            }

            Insert_Space_Kpi_Data_List(new Params_Insert_Space_Kpi_Data_List()
            {
                SPACE_KPI_DATA_LIST = i_Params_Edit_Space_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN.LIST_SPACE_KPI_DATA,
                ENUM_TIMESPAN = i_Params_Edit_Space_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN.ENUM_TIMESPAN
            });
        }
        #endregion
        #region Insert_Space_Kpi_Data_List
        public void Insert_Space_Kpi_Data_List(Params_Insert_Space_Kpi_Data_List i_Params_Insert_Space_Kpi_Data_List)
        {
            List<DALC.Space_kpi_data> oList_Space_kpi_data = null;
            if (i_Params_Insert_Space_Kpi_Data_List.SPACE_KPI_DATA_LIST != null && i_Params_Insert_Space_Kpi_Data_List.SPACE_KPI_DATA_LIST.Count() > 0)
            {
                oList_Space_kpi_data = new List<DALC.Space_kpi_data>();
                foreach (var space_kpi_data in i_Params_Insert_Space_Kpi_Data_List.SPACE_KPI_DATA_LIST)
                {
                    DALC.Space_kpi_data oSpace_kpi_data = new DALC.Space_kpi_data()
                    {
                        RECORD_DATE = new DateTime(space_kpi_data.RECORD_DATE.Year, space_kpi_data.RECORD_DATE.Month, space_kpi_data.RECORD_DATE.Day, space_kpi_data.RECORD_DATE.Hour, space_kpi_data.RECORD_DATE.Minute, space_kpi_data.RECORD_DATE.Second, DateTimeKind.Utc),
                        VALUE = space_kpi_data.VALUE,
                        VALUE_NAME = space_kpi_data.VALUE_NAME,
                        VALUE_PER_SQM = space_kpi_data.VALUE_PER_SQM,
                        SPACE_METADATA = new DALC.Space_metadata()
                        {
                            SPACE_ID = space_kpi_data.SPACE_METADATA.SPACE_ID,
                            FLOOR_ID = space_kpi_data.SPACE_METADATA.FLOOR_ID,
                            CATEGORY = space_kpi_data.SPACE_METADATA.CATEGORY,
                            ORGANIZATION_DATA_SOURCE_KPI_ID = space_kpi_data.SPACE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID,
                        },
                    };
                    oList_Space_kpi_data.Add(oSpace_kpi_data);
                }
                this._MongoDb.Insert_Space_Kpi_Data_List(oList_Space_kpi_data, (DALC.Enum_Timespan)i_Params_Insert_Space_Kpi_Data_List.ENUM_TIMESPAN);
            }
        }
        #endregion
        #region Delete_Space_Kpi_Data_By_Where
        public void Delete_Space_Kpi_Data_By_Where(Params_Delete_Space_Kpi_Data_By_Where i_Params_Delete_Space_Kpi_Data_By_Where)
        {
            this._MongoDb.Delete_Space_Kpi_Data_By_Where
            (
                SPACE_ID_LIST: i_Params_Delete_Space_Kpi_Data_By_Where.SPACE_ID_LIST,
                ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: i_Params_Delete_Space_Kpi_Data_By_Where.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST,
                ENUM_TIMESPAN: (DALC.Enum_Timespan)i_Params_Delete_Space_Kpi_Data_By_Where.ENUM_TIMESPAN
            );
        }
        #endregion
        #endregion

        #region Alerts
        #region Delete_Alert
        public void Delete_Alert(Params_Delete_Alert i_Params_Delete_Alert)
        {
            this._MongoDb.Delete_Alert(
                END_DATE: i_Params_Delete_Alert.END_DATE,
                START_DATE: i_Params_Delete_Alert.START_DATE,
                ALERT_ID_LIST: i_Params_Delete_Alert.ALERT_ID_LIST,
                USER_ID_LIST: i_Params_Delete_Alert.USER_ID_LIST,
                IS_ACKNOWLEDGED: i_Params_Delete_Alert.IS_ACKNOWLEDGED,
                LEVEL_SETUP_ID: i_Params_Delete_Alert.LEVEL_SETUP_ID,
                ORGANIZATION_DATA_SOURCE_KPI_ID: i_Params_Delete_Alert.ORGANIZATION_DATA_SOURCE_KPI_ID
            );
        }
        #endregion
        #region Edit_Alert_List
        public void Edit_Alert_List(Params_Edit_Alert_List i_Params_Edit_Alert_List)
        {
            if (i_Params_Edit_Alert_List.List_Alert != null && i_Params_Edit_Alert_List.List_Alert.Count > 0)
            {
                List<DALC.Alert> oList_Alert = new List<DALC.Alert>();
                foreach (var alert in i_Params_Edit_Alert_List.List_Alert)
                {
                    oList_Alert.Add(new DALC.Alert()
                    {
                        ALERT_ID = alert.ALERT_ID,
                        RECORD_DATE = alert.RECORD_DATE == null ? alert.RECORD_DATE : new DateTime((int)alert.RECORD_DATE?.Year, (int)alert.RECORD_DATE?.Month, (int)alert.RECORD_DATE?.Day, (int)alert.RECORD_DATE?.Hour, (int)alert.RECORD_DATE?.Minute, (int)alert.RECORD_DATE?.Second, DateTimeKind.Utc),
                        USER_ID = alert.USER_ID,
                        ALERT_VALUE = alert.ALERT_VALUE,
                        VALUE_PASSED = alert.VALUE_PASSED,
                        VALUE_TYPE_SETUP_ID = alert.VALUE_TYPE_SETUP_ID,
                        OPERATION_TYPE_SETUP_ID = alert.OPERATION_TYPE_SETUP_ID,
                        ORGANIZATION_DATA_SOURCE_KPI_ID = alert.ORGANIZATION_DATA_SOURCE_KPI_ID,
                        LEVEL_SETUP_ID = alert.LEVEL_SETUP_ID,
                        LEVEL_ID = alert.LEVEL_ID,
                        IS_ACKNOWLEDGED = alert.IS_ACKNOWLEDGED
                    });
                }
                this._MongoDb.Edit_Alert_List(oList_Alert);
            }
        }
        #endregion
        #region Get_Alerts_By_Where
        public List<Alert> Get_Alerts_By_Where(Params_Get_Alerts_By_Where i_Params_Get_Alerts_By_Where)
        {
            return Props.Copy_Prop_Values_From_Api_Response<List<Alert>>(
                this._MongoDb.Get_Alerts_By_Where(
                    END_DATE: i_Params_Get_Alerts_By_Where.END_DATE,
                    START_DATE: i_Params_Get_Alerts_By_Where.START_DATE,
                    ALERT_ID_LIST: i_Params_Get_Alerts_By_Where.ALERT_ID_LIST,
                    USER_ID_LIST: i_Params_Get_Alerts_By_Where.USER_ID_LIST,
                    IS_ACKNOWLEDGED: i_Params_Get_Alerts_By_Where.IS_ACKNOWLEDGED,
                    ORGANIZATION_DATA_SOURCE_KPI_ID: i_Params_Get_Alerts_By_Where.ORGANIZATION_DATA_SOURCE_KPI_ID,
                    LEVEL_SETUP_ID: i_Params_Get_Alerts_By_Where.LEVEL_SETUP_ID,
                    LEVEL_ID_LIST: i_Params_Get_Alerts_By_Where.LEVEL_ID_LIST
                )
            );
        }
        #endregion
        #endregion

        #region GeoJson
        #region Get_District_geojson
        public List<BsonDocument> Get_District_geojson()
        {
            List<string> oList_District_geojson = new List<string>();

            List<BsonDocument> oList_BsonDocument = _MongoDb.Get_District_geojson();

            return oList_BsonDocument;
        }
        #endregion
        #region Get_Area_geojson
        public List<BsonDocument> Get_Area_geojson()
        {
            List<string> oList_Area_geojson = new List<string>();

            List<BsonDocument> oList_BsonDocument = _MongoDb.Get_Area_geojson();

            return oList_BsonDocument;
        }
        #endregion
        #endregion

        #region Extract_Kpi_Data_From_CSV

        public string Extract_Kpi_Data_From_CSV(Params_Extract_Kpi_Data_From_CSV i_Params_Extract_Kpi_Data_From_CSV)
        {
            string Result = "Data Added Successfully";

            if (i_Params_Extract_Kpi_Data_From_CSV.LEVEL_SETUP_ID != null && i_Params_Extract_Kpi_Data_From_CSV.ORGANIZATION_ID != null && i_Params_Extract_Kpi_Data_From_CSV.FILE_NAME != null)
            {
                #region Declaration & Initialization

                long? Site_Setup_ID = 0;
                long? Area_Setup_ID = 0;
                long? District_Setup_ID = 0;
                List<Site> oList_Site = new List<Site>();
                List<Area> oList_Area = new List<Area>();
                List<District> oList_District = new List<District>();
                List<string[]> oList_Data = new List<string[]>();
                List<Organization_data_source_kpi> oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                string File_Path = i_Params_Extract_Kpi_Data_From_CSV.FILE_NAME;

                #endregion

                #region Get Level Setup

                var get_setup = Task.Run(() =>
                {
                    List<Setup> oList_Data_Level_Setup = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
                    {
                        SETUP_CATEGORY_NAME = "Data Level",
                        OWNER_ID = this.oBLC_Initializer.Owner_ID
                    }).List_Setup;
                    if (oList_Data_Level_Setup != null && oList_Data_Level_Setup.Count > 0)
                    {
                        Site_Setup_ID = oList_Data_Level_Setup.Find(setup => setup.VALUE == "Site").SETUP_ID;
                        Area_Setup_ID = oList_Data_Level_Setup.Find(setup => setup.VALUE == "Area").SETUP_ID;
                        District_Setup_ID = oList_Data_Level_Setup.Find(setup => setup.VALUE == "District").SETUP_ID;
                    }
                    else
                    {
                        throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0045).Replace("%1", "Data Level")); // Data Level Setup Not Found
                    }
                });

                #endregion

                #region Get Organization_Data_Source_Kpi

                var get_organization_data_source_kpi = Task.Run(() =>
                {
                    oList_Organization_data_source_kpi = Get_Organization_data_source_kpi_By_ORGANIZATION_ID_Adv(new Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID()
                    {
                        ORGANIZATION_ID = i_Params_Extract_Kpi_Data_From_CSV.ORGANIZATION_ID
                    });
                    if (oList_Organization_data_source_kpi == null || oList_Organization_data_source_kpi.Count == 0)
                    {
                        throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Organization Data Source Kpi")); // Organization Data Source Kpi Does Not Exist!
                    }
                });

                #endregion

                Task.WaitAll(get_setup, get_organization_data_source_kpi);

                #region Get Level List

                if (i_Params_Extract_Kpi_Data_From_CSV.LEVEL_SETUP_ID == Site_Setup_ID)
                {
                    oList_Site = Get_Site_By_OWNER_ID(new Params_Get_Site_By_OWNER_ID()
                    {
                        OWNER_ID = oBLC_Initializer.Owner_ID
                    });
                    if (oList_Site == null || oList_Site.Count == 0)
                    {
                        throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Site List")); // Site List Does Not Exist!
                    }
                }
                else if (i_Params_Extract_Kpi_Data_From_CSV.LEVEL_SETUP_ID == Area_Setup_ID)
                {
                    oList_Area = Get_Area_By_OWNER_ID(new Params_Get_Area_By_OWNER_ID()
                    {
                        OWNER_ID = oBLC_Initializer.Owner_ID
                    });
                    if (oList_Area == null || oList_Area.Count == 0)
                    {
                        throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Area List")); // Area List Does Not Exist!
                    }
                }
                else if (i_Params_Extract_Kpi_Data_From_CSV.LEVEL_SETUP_ID == District_Setup_ID)
                {
                    oList_District = Get_District_By_OWNER_ID(new Params_Get_District_By_OWNER_ID()
                    {
                        OWNER_ID = oBLC_Initializer.Owner_ID
                    });
                    if (oList_District == null || oList_District.Count == 0)
                    {
                        throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "District List")); // District List Does Not Exist!
                    }
                }

                #endregion

                #region Parse CSV

                try
                {
                    using (TextFieldParser parser = new TextFieldParser(File_Path))
                    {
                        parser.Delimiters = new string[] { "," };
                        parser.TextFieldType = FieldType.Delimited;
                        parser.HasFieldsEnclosedInQuotes = true;
                        bool isHeaderRow = true;
                        while (!parser.EndOfData)
                        {
                            string[] fields = parser.ReadFields();

                            if (isHeaderRow)
                            {
                                oList_Data.Add(fields);
                                isHeaderRow = false;
                            }
                            else
                            {
                                oList_Data.Add(fields);
                            }
                        }
                    }
                }
                catch
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0058)); // Error in parsing the CSV file.
                }


                #endregion

                #region Fill Data

                #region Declarartion & Initialization

                List<Site_kpi_data> oList_Site_kpi_data_Daily = new List<Site_kpi_data>();
                List<Site_kpi_data> oList_Site_kpi_data_Weekly = new List<Site_kpi_data>();
                List<Site_kpi_data> oList_Site_kpi_data_Monthly = new List<Site_kpi_data>();
                List<Area_kpi_data> oList_Area_kpi_data_Daily = new List<Area_kpi_data>();
                List<Area_kpi_data> oList_Area_kpi_data_Weekly = new List<Area_kpi_data>();
                List<Area_kpi_data> oList_Area_kpi_data_Monthly = new List<Area_kpi_data>();
                List<District_kpi_data> oList_District_kpi_data_Daily = new List<District_kpi_data>();
                List<District_kpi_data> oList_District_kpi_data_Weekly = new List<District_kpi_data>();
                List<District_kpi_data> oList_District_kpi_data_Monthly = new List<District_kpi_data>();
                List<int?> oList_Organization_data_source_kpi_ID = new List<int?>();

                #endregion

                if (i_Params_Extract_Kpi_Data_From_CSV.LEVEL_SETUP_ID == Site_Setup_ID)
                {
                    #region Declarartion & Initialization

                    var oSite = new Site();
                    var oOrganization_data_source_kpi = new Organization_data_source_kpi();

                    #endregion

                    #region Fill Site Daily Data

                    for (int i = 1; i < oList_Data.Count; i++)
                    {
                        oSite = oList_Site.Find(oSite => oSite.NAME == oList_Data[i][6]);
                        if (oSite != null)
                        {
                            var oDateTime = DateTime.ParseExact(oList_Data[i][0], "M/d/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal | DateTimeStyles.AdjustToUniversal);
                            for (int j = 7; j < oList_Data[i].Length; j++)
                            {
                                string Kpi_Name = oList_Data[0][j];
                                oOrganization_data_source_kpi = oList_Organization_data_source_kpi.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.NAME == Kpi_Name);
                                if (oOrganization_data_source_kpi != null)
                                {
                                    oList_Organization_data_source_kpi_ID.Add(oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID);
                                    decimal Value = 0;
                                    string Value_String = oList_Data[i][j] == "None" ? "0" : oList_Data[i][j];
                                    if (decimal.TryParse(Value_String, out Value))
                                    {
                                        oList_Site_kpi_data_Daily.Add(new Site_kpi_data()
                                        {
                                            RECORD_DATE = oDateTime,
                                            VALUE = Value,
                                            VALUE_NAME = oDateTime.ToShortDateString(),
                                            VALUE_PER_SQM = Value / oSite.AREA,
                                            SITE_METADATA = new Site_metadata()
                                            {
                                                SITE_ID = (long)oSite.SITE_ID,
                                                CATEGORY = "Severity Type:0,Incident Category Type:0,EXT_STUDY_ZONE_ID:0",
                                                ORGANIZATION_DATA_SOURCE_KPI_ID = (int)oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID
                                            }
                                        });
                                    }
                                    else
                                    {
                                        throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0058)); // Error in parsing the CSV file.
                                    }
                                }
                                else
                                {
                                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0058)); // Error in parsing the CSV file.
                                }
                            }
                        }
                        else
                        {
                            //throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0058)); // Error in parsing the CSV file.
                            Console.WriteLine(oList_Data[i][6] + " Does Not Exist!");
                        }
                    }

                    #endregion

                    #region Fill Site Weekly Data

                    foreach (var oSite_kpi_data in oList_Site_kpi_data_Daily)
                    {
                        if (oSite_kpi_data.RECORD_DATE.DayOfWeek == DayOfWeek.Monday)
                        {
                            var oList_Site_kpi_data_To_Use = oList_Site_kpi_data_Daily.Where(_Site_kpi_data => _Site_kpi_data.RECORD_DATE >= oSite_kpi_data.RECORD_DATE &&
                                                                                                                _Site_kpi_data.RECORD_DATE < oSite_kpi_data.RECORD_DATE.AddDays(7) &&
                                                                                                                _Site_kpi_data.SITE_METADATA.SITE_ID == oSite_kpi_data.SITE_METADATA.SITE_ID &&
                                                                                                                _Site_kpi_data.SITE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID == oSite_kpi_data.SITE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID
                                                                                                                );
                            if (oList_Site_kpi_data_To_Use != null && oList_Site_kpi_data_To_Use.Count() > 0)
                            {
                                oList_Site_kpi_data_Weekly.Add(new Site_kpi_data()
                                {
                                    RECORD_DATE = oSite_kpi_data.RECORD_DATE,
                                    VALUE = oList_Site_kpi_data_To_Use.Average(oSite_kpi_data => oSite_kpi_data.VALUE),
                                    VALUE_NAME = oSite_kpi_data.RECORD_DATE.Year + " Week " + Get_Week_Of_Year(new Params_Get_Week_Of_Year()
                                    {
                                        DAY = oSite_kpi_data.RECORD_DATE.Day,
                                        YEAR = oSite_kpi_data.RECORD_DATE.Year,
                                        MONTH = oSite_kpi_data.RECORD_DATE.Month,
                                    }),
                                    VALUE_PER_SQM = oList_Site_kpi_data_To_Use.Average(oSite_kpi_data => oSite_kpi_data.VALUE_PER_SQM),
                                    SITE_METADATA = new Site_metadata()
                                    {
                                        SITE_ID = oSite_kpi_data.SITE_METADATA.SITE_ID,
                                        CATEGORY = oSite_kpi_data.SITE_METADATA.CATEGORY,
                                        ORGANIZATION_DATA_SOURCE_KPI_ID = oSite_kpi_data.SITE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID
                                    }
                                });
                            }
                        }
                    }

                    #endregion

                    #region Fill Site Monthly Data

                    foreach (var oSite_kpi_data in oList_Site_kpi_data_Daily)
                    {
                        if (oSite_kpi_data.RECORD_DATE.Day == 1)
                        {
                            var oList_Site_kpi_data_To_Use = oList_Site_kpi_data_Daily.Where(_Site_kpi_data => _Site_kpi_data.RECORD_DATE >= oSite_kpi_data.RECORD_DATE &&
                                                                                                                _Site_kpi_data.RECORD_DATE < oSite_kpi_data.RECORD_DATE.AddMonths(1) &&
                                                                                                                _Site_kpi_data.SITE_METADATA.SITE_ID == oSite_kpi_data.SITE_METADATA.SITE_ID &&
                                                                                                                _Site_kpi_data.SITE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID == oSite_kpi_data.SITE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID
                                                                                                                );
                            if (oList_Site_kpi_data_To_Use != null && oList_Site_kpi_data_To_Use.Count() > 0)
                            {
                                oList_Site_kpi_data_Monthly.Add(new Site_kpi_data()
                                {
                                    RECORD_DATE = oSite_kpi_data.RECORD_DATE,
                                    VALUE = oList_Site_kpi_data_To_Use.Average(oSite_kpi_data => oSite_kpi_data.VALUE),
                                    VALUE_NAME = oSite_kpi_data.RECORD_DATE.Month + "/" + oSite_kpi_data.RECORD_DATE.Year,
                                    VALUE_PER_SQM = oList_Site_kpi_data_To_Use.Average(oSite_kpi_data => oSite_kpi_data.VALUE_PER_SQM),
                                    SITE_METADATA = new Site_metadata()
                                    {
                                        SITE_ID = oSite_kpi_data.SITE_METADATA.SITE_ID,
                                        CATEGORY = oSite_kpi_data.SITE_METADATA.CATEGORY,
                                        ORGANIZATION_DATA_SOURCE_KPI_ID = oSite_kpi_data.SITE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID
                                    }
                                });
                            }
                        }
                    }

                    #endregion
                }
                else if (i_Params_Extract_Kpi_Data_From_CSV.LEVEL_SETUP_ID == Area_Setup_ID)
                {
                    #region Declarartion & Initialization

                    var oArea = new Area();
                    var oOrganization_data_source_kpi = new Organization_data_source_kpi();

                    #endregion

                    #region Fill Area Daily Data

                    for (int i = 1; i < oList_Data.Count; i++)
                    {
                        oArea = oList_Area.Find(oArea => oArea.NAME == oList_Data[i][6]);
                        if (oArea != null)
                        {
                            var oDateTime = DateTime.ParseExact(oList_Data[i][0], "M/d/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal | DateTimeStyles.AdjustToUniversal);
                            for (int j = 7; j < oList_Data[i].Length; j++)
                            {
                                string Kpi_Name = oList_Data[0][j];
                                oOrganization_data_source_kpi = oList_Organization_data_source_kpi.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.NAME == Kpi_Name);
                                if (oOrganization_data_source_kpi != null)
                                {
                                    oList_Organization_data_source_kpi_ID.Add(oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID);
                                    decimal Value = 0;
                                    string Value_String = oList_Data[i][j] == "None" ? "0" : oList_Data[i][j];
                                    if (decimal.TryParse(Value_String, out Value))
                                    {
                                        oList_Area_kpi_data_Daily.Add(new Area_kpi_data()
                                        {
                                            RECORD_DATE = oDateTime,
                                            VALUE = Value,
                                            VALUE_NAME = oDateTime.ToShortDateString(),
                                            VALUE_PER_SQM = Value / oArea.AREA,
                                            AREA_METADATA = new Area_metadata()
                                            {
                                                AREA_ID = (long)oArea.AREA_ID,
                                                CATEGORY = "Severity Type:0,Incident Category Type:0,EXT_STUDY_ZONE_ID:0",
                                                ORGANIZATION_DATA_SOURCE_KPI_ID = (int)oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID
                                            }
                                        });
                                    }
                                    else
                                    {
                                        throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0058)); // Error in parsing the CSV file.
                                    }
                                }
                                else
                                {
                                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0058)); // Error in parsing the CSV file.
                                }
                            }
                        }
                        else
                        {
                            //throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0058)); // Error in parsing the CSV file.
                            Console.WriteLine(oList_Data[i][6] + " Does Not Exist!");
                        }
                    }

                    #endregion

                    #region Fill Area Weekly Data

                    foreach (var oArea_kpi_data in oList_Area_kpi_data_Daily)
                    {
                        if (oArea_kpi_data.RECORD_DATE.DayOfWeek == DayOfWeek.Monday)
                        {
                            var oList_Area_kpi_data_To_Use = oList_Area_kpi_data_Daily.Where(_Area_kpi_data => _Area_kpi_data.RECORD_DATE >= oArea_kpi_data.RECORD_DATE &&
                                                                                                                _Area_kpi_data.RECORD_DATE < oArea_kpi_data.RECORD_DATE.AddDays(7) &&
                                                                                                                _Area_kpi_data.AREA_METADATA.AREA_ID == oArea_kpi_data.AREA_METADATA.AREA_ID &&
                                                                                                                _Area_kpi_data.AREA_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID == oArea_kpi_data.AREA_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID
                                                                                                                );
                            if (oList_Area_kpi_data_To_Use != null && oList_Area_kpi_data_To_Use.Count() > 0)
                            {
                                oList_Area_kpi_data_Weekly.Add(new Area_kpi_data()
                                {
                                    RECORD_DATE = oArea_kpi_data.RECORD_DATE,
                                    VALUE = oList_Area_kpi_data_To_Use.Average(oArea_kpi_data => oArea_kpi_data.VALUE),
                                    VALUE_NAME = oArea_kpi_data.RECORD_DATE.Year + " Week " + Get_Week_Of_Year(new Params_Get_Week_Of_Year()
                                    {
                                        DAY = oArea_kpi_data.RECORD_DATE.Day,
                                        YEAR = oArea_kpi_data.RECORD_DATE.Year,
                                        MONTH = oArea_kpi_data.RECORD_DATE.Month,
                                    }),
                                    VALUE_PER_SQM = oList_Area_kpi_data_To_Use.Average(oArea_kpi_data => oArea_kpi_data.VALUE_PER_SQM),
                                    AREA_METADATA = new Area_metadata()
                                    {
                                        AREA_ID = oArea_kpi_data.AREA_METADATA.AREA_ID,
                                        CATEGORY = oArea_kpi_data.AREA_METADATA.CATEGORY,
                                        ORGANIZATION_DATA_SOURCE_KPI_ID = oArea_kpi_data.AREA_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID
                                    }
                                });
                            }
                        }
                    }

                    #endregion

                    #region Fill Area Monthly Data

                    foreach (var oArea_kpi_data in oList_Area_kpi_data_Daily)
                    {
                        if (oArea_kpi_data.RECORD_DATE.Day == 1)
                        {
                            var oList_Area_kpi_data_To_Use = oList_Area_kpi_data_Daily.Where(_Area_kpi_data => _Area_kpi_data.RECORD_DATE >= oArea_kpi_data.RECORD_DATE &&
                                                                                                                _Area_kpi_data.RECORD_DATE < oArea_kpi_data.RECORD_DATE.AddMonths(1) &&
                                                                                                                _Area_kpi_data.AREA_METADATA.AREA_ID == oArea_kpi_data.AREA_METADATA.AREA_ID &&
                                                                                                                _Area_kpi_data.AREA_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID == oArea_kpi_data.AREA_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID
                                                                                                                );
                            if (oList_Area_kpi_data_To_Use != null && oList_Area_kpi_data_To_Use.Count() > 0)
                            {
                                oList_Area_kpi_data_Monthly.Add(new Area_kpi_data()
                                {
                                    RECORD_DATE = oArea_kpi_data.RECORD_DATE,
                                    VALUE = oList_Area_kpi_data_To_Use.Average(oArea_kpi_data => oArea_kpi_data.VALUE),
                                    VALUE_NAME = oArea_kpi_data.RECORD_DATE.Month + "/" + oArea_kpi_data.RECORD_DATE.Year,
                                    VALUE_PER_SQM = oList_Area_kpi_data_To_Use.Average(oArea_kpi_data => oArea_kpi_data.VALUE_PER_SQM),
                                    AREA_METADATA = new Area_metadata()
                                    {
                                        AREA_ID = oArea_kpi_data.AREA_METADATA.AREA_ID,
                                        CATEGORY = oArea_kpi_data.AREA_METADATA.CATEGORY,
                                        ORGANIZATION_DATA_SOURCE_KPI_ID = oArea_kpi_data.AREA_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID
                                    }
                                });
                            }
                        }
                    }

                    #endregion
                }
                else if (i_Params_Extract_Kpi_Data_From_CSV.LEVEL_SETUP_ID == District_Setup_ID)
                {
                    #region Declarartion & Initialization

                    var oDistrict = new District();
                    var oOrganization_data_source_kpi = new Organization_data_source_kpi();

                    #endregion

                    #region Fill District Daily Data

                    for (int i = 1; i < oList_Data.Count; i++)
                    {
                        oDistrict = oList_District.Find(oDistrict => oDistrict.NAME == oList_Data[i][6]);
                        if (oDistrict != null)
                        {
                            var oDateTime = DateTime.ParseExact(oList_Data[i][0], "M/d/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal | DateTimeStyles.AdjustToUniversal);
                            for (int j = 7; j < oList_Data[i].Length; j++)
                            {
                                string Kpi_Name = oList_Data[0][j];
                                oOrganization_data_source_kpi = oList_Organization_data_source_kpi.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.NAME == Kpi_Name);
                                if (oOrganization_data_source_kpi != null)
                                {
                                    oList_Organization_data_source_kpi_ID.Add(oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID);
                                    decimal Value = 0;
                                    string Value_String = oList_Data[i][j] == "None" ? "0" : oList_Data[i][j];
                                    if (decimal.TryParse(Value_String, out Value))
                                    {
                                        oList_District_kpi_data_Daily.Add(new District_kpi_data()
                                        {
                                            RECORD_DATE = oDateTime,
                                            VALUE = Value,
                                            VALUE_NAME = oDateTime.ToShortDateString(),
                                            VALUE_PER_SQM = Value / oDistrict.AREA,
                                            DISTRICT_METADATA = new District_metadata()
                                            {
                                                DISTRICT_ID = (long)oDistrict.DISTRICT_ID,
                                                CATEGORY = "Severity Type:0,Incident Category Type:0,EXT_STUDY_ZONE_ID:0",
                                                ORGANIZATION_DATA_SOURCE_KPI_ID = (int)oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID
                                            }
                                        });
                                    }
                                    else
                                    {
                                        throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0058)); // Error in parsing the CSV file.
                                    }
                                }
                                else
                                {
                                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0058)); // Error in parsing the CSV file.
                                }
                            }
                        }
                        else
                        {
                            //throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0058)); // Error in parsing the CSV file.
                            Console.WriteLine(oList_Data[i][6] + " Does Not Exist!");
                        }
                    }

                    #endregion

                    #region Fill District Weekly Data

                    foreach (var oDistrict_kpi_data in oList_District_kpi_data_Daily)
                    {
                        if (oDistrict_kpi_data.RECORD_DATE.DayOfWeek == DayOfWeek.Monday)
                        {
                            var oList_District_kpi_data_To_Use = oList_District_kpi_data_Daily.Where(_District_kpi_data => _District_kpi_data.RECORD_DATE >= oDistrict_kpi_data.RECORD_DATE &&
                                                                                                                _District_kpi_data.RECORD_DATE < oDistrict_kpi_data.RECORD_DATE.AddDays(7) &&
                                                                                                                _District_kpi_data.DISTRICT_METADATA.DISTRICT_ID == oDistrict_kpi_data.DISTRICT_METADATA.DISTRICT_ID &&
                                                                                                                _District_kpi_data.DISTRICT_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID == oDistrict_kpi_data.DISTRICT_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID
                                                                                                                );
                            if (oList_District_kpi_data_To_Use != null && oList_District_kpi_data_To_Use.Count() > 0)
                            {
                                oList_District_kpi_data_Weekly.Add(new District_kpi_data()
                                {
                                    RECORD_DATE = oDistrict_kpi_data.RECORD_DATE,
                                    VALUE = oList_District_kpi_data_To_Use.Average(oDistrict_kpi_data => oDistrict_kpi_data.VALUE),
                                    VALUE_NAME = oDistrict_kpi_data.RECORD_DATE.Year + " Week " + Get_Week_Of_Year(new Params_Get_Week_Of_Year()
                                    {
                                        DAY = oDistrict_kpi_data.RECORD_DATE.Day,
                                        YEAR = oDistrict_kpi_data.RECORD_DATE.Year,
                                        MONTH = oDistrict_kpi_data.RECORD_DATE.Month,
                                    }),
                                    VALUE_PER_SQM = oList_District_kpi_data_To_Use.Average(oDistrict_kpi_data => oDistrict_kpi_data.VALUE_PER_SQM),
                                    DISTRICT_METADATA = new District_metadata()
                                    {
                                        DISTRICT_ID = oDistrict_kpi_data.DISTRICT_METADATA.DISTRICT_ID,
                                        CATEGORY = oDistrict_kpi_data.DISTRICT_METADATA.CATEGORY,
                                        ORGANIZATION_DATA_SOURCE_KPI_ID = oDistrict_kpi_data.DISTRICT_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID
                                    }
                                });
                            }
                        }
                    }

                    #endregion

                    #region Fill District Monthly Data

                    foreach (var oDistrict_kpi_data in oList_District_kpi_data_Daily)
                    {
                        if (oDistrict_kpi_data.RECORD_DATE.Day == 1)
                        {
                            var oList_District_kpi_data_To_Use = oList_District_kpi_data_Daily.Where(_District_kpi_data => _District_kpi_data.RECORD_DATE >= oDistrict_kpi_data.RECORD_DATE &&
                                                                                                                _District_kpi_data.RECORD_DATE < oDistrict_kpi_data.RECORD_DATE.AddMonths(1) &&
                                                                                                                _District_kpi_data.DISTRICT_METADATA.DISTRICT_ID == oDistrict_kpi_data.DISTRICT_METADATA.DISTRICT_ID &&
                                                                                                                _District_kpi_data.DISTRICT_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID == oDistrict_kpi_data.DISTRICT_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID
                                                                                                                );
                            if (oList_District_kpi_data_To_Use != null && oList_District_kpi_data_To_Use.Count() > 0)
                            {
                                oList_District_kpi_data_Monthly.Add(new District_kpi_data()
                                {
                                    RECORD_DATE = oDistrict_kpi_data.RECORD_DATE,
                                    VALUE = oList_District_kpi_data_To_Use.Average(oDistrict_kpi_data => oDistrict_kpi_data.VALUE),
                                    VALUE_NAME = oDistrict_kpi_data.RECORD_DATE.Month + "/" + oDistrict_kpi_data.RECORD_DATE.Year,
                                    VALUE_PER_SQM = oList_District_kpi_data_To_Use.Average(oDistrict_kpi_data => oDistrict_kpi_data.VALUE_PER_SQM),
                                    DISTRICT_METADATA = new District_metadata()
                                    {
                                        DISTRICT_ID = oDistrict_kpi_data.DISTRICT_METADATA.DISTRICT_ID,
                                        CATEGORY = oDistrict_kpi_data.DISTRICT_METADATA.CATEGORY,
                                        ORGANIZATION_DATA_SOURCE_KPI_ID = oDistrict_kpi_data.DISTRICT_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID
                                    }
                                });
                            }
                        }
                    }

                    #endregion
                }

                #endregion

                #region Send Data

                if (i_Params_Extract_Kpi_Data_From_CSV.LEVEL_SETUP_ID == Site_Setup_ID)
                {
                    #region Insert Daily

                    if (oList_Site_kpi_data_Daily?.Count > 0)
                    {
                        var Start_Date = oList_Site_kpi_data_Daily.MinBy(oSite_kpi_data => oSite_kpi_data.RECORD_DATE).RECORD_DATE;
                        var End_Date = oList_Site_kpi_data_Daily.MaxBy(oSite_kpi_data => oSite_kpi_data.RECORD_DATE).RECORD_DATE.AddSeconds(1);

                        List<Site_kpi_data> oList_Site_kpi_data = Props.Copy_Prop_Values_From_Api_Response<List<Site_kpi_data>>(this._MongoDb.Get_Site_Kpi_Data_By_Where(
                            START_DATE: Start_Date,
                            END_DATE: End_Date,
                            ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: oList_Organization_data_source_kpi_ID,
                            ENUM_TIMESPAN: DALC.Enum_Timespan.X_DAILY_COLLECTION,
                            SITE_ID_LIST: null
                        ));

                        if (oList_Site_kpi_data?.Count > 0)
                        {
                            throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0044).Replace("%1", "Site").Replace("%2", Start_Date.ToString())); // Data for %1 on date %2 already exists
                        }

                        Insert_Site_Kpi_Data_List(new Params_Insert_Site_Kpi_Data_List()
                        {
                            SITE_KPI_DATA_LIST = oList_Site_kpi_data_Daily,
                            ENUM_TIMESPAN = Enum_Timespan.X_DAILY_COLLECTION
                        });
                    }

                    #endregion

                    #region Insert Weekly

                    if (oList_Site_kpi_data_Weekly?.Count > 0)
                    {
                        var Start_Date = oList_Site_kpi_data_Weekly.MinBy(oSite_kpi_data => oSite_kpi_data.RECORD_DATE).RECORD_DATE;
                        var End_Date = oList_Site_kpi_data_Weekly.MaxBy(oSite_kpi_data => oSite_kpi_data.RECORD_DATE).RECORD_DATE.AddSeconds(1);

                        List<Site_kpi_data> oList_Site_kpi_data = Props.Copy_Prop_Values_From_Api_Response<List<Site_kpi_data>>(this._MongoDb.Get_Site_Kpi_Data_By_Where(
                            START_DATE: Start_Date,
                            END_DATE: End_Date,
                            ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: oList_Organization_data_source_kpi_ID,
                            ENUM_TIMESPAN: DALC.Enum_Timespan.X_WEEKLY_COLLECTION,
                            SITE_ID_LIST: null
                        ));

                        if (oList_Site_kpi_data?.Count > 0)
                        {
                            throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0044).Replace("%1", "Site").Replace("%2", Start_Date.ToString())); // Data for %1 on date %2 already exists
                        }

                        Insert_Site_Kpi_Data_List(new Params_Insert_Site_Kpi_Data_List()
                        {
                            SITE_KPI_DATA_LIST = oList_Site_kpi_data_Weekly,
                            ENUM_TIMESPAN = Enum_Timespan.X_WEEKLY_COLLECTION
                        });
                    }

                    #endregion

                    #region Insert Monthly

                    if (oList_Site_kpi_data_Monthly?.Count > 0)
                    {
                        var Start_Date = oList_Site_kpi_data_Monthly.MinBy(oSite_kpi_data => oSite_kpi_data.RECORD_DATE).RECORD_DATE;
                        var End_Date = oList_Site_kpi_data_Monthly.MaxBy(oSite_kpi_data => oSite_kpi_data.RECORD_DATE).RECORD_DATE.AddSeconds(1);

                        List<Site_kpi_data> oList_Site_kpi_data = Props.Copy_Prop_Values_From_Api_Response<List<Site_kpi_data>>(this._MongoDb.Get_Site_Kpi_Data_By_Where(
                            START_DATE: Start_Date,
                            END_DATE: End_Date,
                            ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: oList_Organization_data_source_kpi_ID,
                            ENUM_TIMESPAN: DALC.Enum_Timespan.X_MONTHLY_COLLECTION,
                            SITE_ID_LIST: null
                        ));

                        if (oList_Site_kpi_data?.Count > 0)
                        {
                            throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0044).Replace("%1", "Site").Replace("%2", Start_Date.ToString())); // Data for %1 on date %2 already exists
                        }

                        Insert_Site_Kpi_Data_List(new Params_Insert_Site_Kpi_Data_List()
                        {
                            SITE_KPI_DATA_LIST = oList_Site_kpi_data_Monthly,
                            ENUM_TIMESPAN = Enum_Timespan.X_MONTHLY_COLLECTION
                        });
                    }

                    #endregion
                }
                else if (i_Params_Extract_Kpi_Data_From_CSV.LEVEL_SETUP_ID == Area_Setup_ID)
                {
                    #region Insert Daily

                    if (oList_Area_kpi_data_Daily?.Count > 0)
                    {
                        var Start_Date = oList_Area_kpi_data_Daily.MinBy(oArea_kpi_data => oArea_kpi_data.RECORD_DATE).RECORD_DATE;
                        var End_Date = oList_Area_kpi_data_Daily.MaxBy(oArea_kpi_data => oArea_kpi_data.RECORD_DATE).RECORD_DATE.AddSeconds(1);

                        List<Area_kpi_data> oList_Area_kpi_data = Props.Copy_Prop_Values_From_Api_Response<List<Area_kpi_data>>(this._MongoDb.Get_Area_Kpi_Data_By_Where(
                            START_DATE: Start_Date,
                            END_DATE: End_Date,
                            ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: oList_Organization_data_source_kpi_ID,
                            ENUM_TIMESPAN: DALC.Enum_Timespan.X_DAILY_COLLECTION,
                            AREA_ID_LIST: null
                        ));

                        if (oList_Area_kpi_data?.Count > 0)
                        {
                            throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0044).Replace("%1", "Area").Replace("%2", Start_Date.ToString())); // Data for %1 on date %2 already exists
                        }

                        Insert_Area_Kpi_Data_List(new Params_Insert_Area_Kpi_Data_List()
                        {
                            AREA_KPI_DATA_LIST = oList_Area_kpi_data_Daily,
                            ENUM_TIMESPAN = Enum_Timespan.X_DAILY_COLLECTION
                        });
                    }

                    #endregion

                    #region Insert Weekly

                    if (oList_Area_kpi_data_Weekly?.Count > 0)
                    {
                        var Start_Date = oList_Area_kpi_data_Weekly.MinBy(oArea_kpi_data => oArea_kpi_data.RECORD_DATE).RECORD_DATE;
                        var End_Date = oList_Area_kpi_data_Weekly.MaxBy(oArea_kpi_data => oArea_kpi_data.RECORD_DATE).RECORD_DATE.AddSeconds(1);

                        List<Area_kpi_data> oList_Area_kpi_data = Props.Copy_Prop_Values_From_Api_Response<List<Area_kpi_data>>(this._MongoDb.Get_Area_Kpi_Data_By_Where(
                            START_DATE: Start_Date,
                            END_DATE: End_Date,
                            ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: oList_Organization_data_source_kpi_ID,
                            ENUM_TIMESPAN: DALC.Enum_Timespan.X_WEEKLY_COLLECTION,
                            AREA_ID_LIST: null
                        ));

                        if (oList_Area_kpi_data?.Count > 0)
                        {
                            throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0044).Replace("%1", "Area").Replace("%2", Start_Date.ToString())); // Data for %1 on date %2 already exists
                        }

                        Insert_Area_Kpi_Data_List(new Params_Insert_Area_Kpi_Data_List()
                        {
                            AREA_KPI_DATA_LIST = oList_Area_kpi_data_Weekly,
                            ENUM_TIMESPAN = Enum_Timespan.X_WEEKLY_COLLECTION
                        });
                    }

                    #endregion

                    #region Insert Monthly

                    if (oList_Area_kpi_data_Monthly?.Count > 0)
                    {
                        var Start_Date = oList_Area_kpi_data_Monthly.MinBy(oArea_kpi_data => oArea_kpi_data.RECORD_DATE).RECORD_DATE;
                        var End_Date = oList_Area_kpi_data_Monthly.MaxBy(oArea_kpi_data => oArea_kpi_data.RECORD_DATE).RECORD_DATE.AddSeconds(1);

                        List<Area_kpi_data> oList_Area_kpi_data = Props.Copy_Prop_Values_From_Api_Response<List<Area_kpi_data>>(this._MongoDb.Get_Area_Kpi_Data_By_Where(
                            START_DATE: Start_Date,
                            END_DATE: End_Date,
                            ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: oList_Organization_data_source_kpi_ID,
                            ENUM_TIMESPAN: DALC.Enum_Timespan.X_MONTHLY_COLLECTION,
                            AREA_ID_LIST: null
                        ));

                        if (oList_Area_kpi_data?.Count > 0)
                        {
                            throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0044).Replace("%1", "Area").Replace("%2", Start_Date.ToString())); // Data for %1 on date %2 already exists
                        }

                        Insert_Area_Kpi_Data_List(new Params_Insert_Area_Kpi_Data_List()
                        {
                            AREA_KPI_DATA_LIST = oList_Area_kpi_data_Monthly,
                            ENUM_TIMESPAN = Enum_Timespan.X_MONTHLY_COLLECTION
                        });
                    }

                    #endregion
                }
                else if (i_Params_Extract_Kpi_Data_From_CSV.LEVEL_SETUP_ID == District_Setup_ID)
                {
                    #region Insert Daily

                    if (oList_District_kpi_data_Daily?.Count > 0)
                    {
                        var Start_Date = oList_District_kpi_data_Daily.MinBy(oDistrict_kpi_data => oDistrict_kpi_data.RECORD_DATE).RECORD_DATE;
                        var End_Date = oList_District_kpi_data_Daily.MaxBy(oDistrict_kpi_data => oDistrict_kpi_data.RECORD_DATE).RECORD_DATE.AddSeconds(1);

                        List<District_kpi_data> oList_District_kpi_data = Props.Copy_Prop_Values_From_Api_Response<List<District_kpi_data>>(this._MongoDb.Get_District_Kpi_Data_By_Where(
                            START_DATE: Start_Date,
                            END_DATE: End_Date,
                            ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: oList_Organization_data_source_kpi_ID,
                            ENUM_TIMESPAN: DALC.Enum_Timespan.X_DAILY_COLLECTION,
                            DISTRICT_ID_LIST: null
                        ));

                        if (oList_District_kpi_data?.Count > 0)
                        {
                            throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0044).Replace("%1", "District").Replace("%2", Start_Date.ToString())); // Data for %1 on date %2 already exists
                        }

                        Insert_District_Kpi_Data_List(new Params_Insert_District_Kpi_Data_List()
                        {
                            DISTRICT_KPI_DATA_LIST = oList_District_kpi_data_Daily,
                            ENUM_TIMESPAN = Enum_Timespan.X_DAILY_COLLECTION
                        });
                    }

                    #endregion

                    #region Insert Weekly

                    if (oList_District_kpi_data_Weekly?.Count > 0)
                    {
                        var Start_Date = oList_District_kpi_data_Weekly.MinBy(oDistrict_kpi_data => oDistrict_kpi_data.RECORD_DATE).RECORD_DATE;
                        var End_Date = oList_District_kpi_data_Weekly.MaxBy(oDistrict_kpi_data => oDistrict_kpi_data.RECORD_DATE).RECORD_DATE.AddSeconds(1);

                        List<District_kpi_data> oList_District_kpi_data = Props.Copy_Prop_Values_From_Api_Response<List<District_kpi_data>>(this._MongoDb.Get_District_Kpi_Data_By_Where(
                            START_DATE: Start_Date,
                            END_DATE: End_Date,
                            ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: oList_Organization_data_source_kpi_ID,
                            ENUM_TIMESPAN: DALC.Enum_Timespan.X_WEEKLY_COLLECTION,
                            DISTRICT_ID_LIST: null
                        ));

                        if (oList_District_kpi_data?.Count > 0)
                        {
                            throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0044).Replace("%1", "District").Replace("%2", Start_Date.ToString())); // Data for %1 on date %2 already exists
                        }

                        Insert_District_Kpi_Data_List(new Params_Insert_District_Kpi_Data_List()
                        {
                            DISTRICT_KPI_DATA_LIST = oList_District_kpi_data_Weekly,
                            ENUM_TIMESPAN = Enum_Timespan.X_WEEKLY_COLLECTION
                        });
                    }

                    #endregion

                    #region Insert Monthly

                    if (oList_District_kpi_data_Monthly?.Count > 0)
                    {
                        var Start_Date = oList_District_kpi_data_Monthly.MinBy(oDistrict_kpi_data => oDistrict_kpi_data.RECORD_DATE).RECORD_DATE;
                        var End_Date = oList_District_kpi_data_Monthly.MaxBy(oDistrict_kpi_data => oDistrict_kpi_data.RECORD_DATE).RECORD_DATE.AddSeconds(1);

                        List<District_kpi_data> oList_District_kpi_data = Props.Copy_Prop_Values_From_Api_Response<List<District_kpi_data>>(this._MongoDb.Get_District_Kpi_Data_By_Where(
                            START_DATE: Start_Date,
                            END_DATE: End_Date,
                            ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: oList_Organization_data_source_kpi_ID,
                            ENUM_TIMESPAN: DALC.Enum_Timespan.X_MONTHLY_COLLECTION,
                            DISTRICT_ID_LIST: null
                        ));

                        if (oList_District_kpi_data?.Count > 0)
                        {
                            throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0044).Replace("%1", "District").Replace("%2", Start_Date.ToString())); // Data for %1 on date %2 already exists
                        }

                        Insert_District_Kpi_Data_List(new Params_Insert_District_Kpi_Data_List()
                        {
                            DISTRICT_KPI_DATA_LIST = oList_District_kpi_data_Monthly,
                            ENUM_TIMESPAN = Enum_Timespan.X_MONTHLY_COLLECTION
                        });
                    }

                    #endregion
                }

                #endregion
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }

            return Result;
        }
        #endregion
    }
}
