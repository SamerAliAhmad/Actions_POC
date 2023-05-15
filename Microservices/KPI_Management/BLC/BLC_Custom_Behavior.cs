using System;
using System.Linq;
using SmartrTools;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using Newtonsoft.Json;
using RestSharp;
using MongoDB.Driver.Linq;
using System.Text.RegularExpressions;

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
        #region GeoData
        #region Get_GeoData_By_GEODATA_ID
        public List<GeoData> Get_GeoData_By_GEODATA_ID(Params_Get_GeoData_By_GEODATA_ID i_Params_Get_GeoData_By_GEODATA_ID)
        {
            return Props.Copy_Prop_Values_From_Api_Response<List<GeoData>>(
                this._MongoDb.Get_GeoData_By_GEODATA_ID(
                    GEODATA_ID: i_Params_Get_GeoData_By_GEODATA_ID.GEODATA_ID
                )
            );
        }
        #endregion
        #region Get_GeoData_By_GEODATA_ID_List
        public List<GeoData> Get_GeoData_By_GEODATA_ID_List(Params_Get_GeoData_By_GEODATA_ID_List i_Params_Get_GeoData_By_GEODATA_ID_List)
        {
            return Props.Copy_Prop_Values_From_Api_Response<List<GeoData>>(
                this._MongoDb.Get_GeoData_By_GEODATA_ID_List(
                    GEODATA_ID_LIST: i_Params_Get_GeoData_By_GEODATA_ID_List.GEODATA_ID_LIST
                )
            );
        }
        #endregion
        #region Get_Latest_GeoData_Aggregate_By_KPI
        public GeoData Get_Latest_GeoData_By_KPI(Params_Get_Latest_GeoData_By_KPI i_Params_Get_Latest_GeoData_By_KPI)
        {
            return Props.Copy_Prop_Values_From_Api_Response<GeoData>(this._MongoDb.Get_Latest_GeoData_Aggregate_By_KPI(
                    ORGANIZATION_DATA_SOURCE_KPI_ID: i_Params_Get_Latest_GeoData_By_KPI.ORGANIZATION_DATA_SOURCE_KPI_ID
                )
            );
        }
        #endregion
        #region Delete_GeoData_By_GEODATA_ID_List
        public void Delete_GeoData_By_GEODATA_ID_List(Params_Delete_GeoData_By_GEODATA_ID_List i_Params_Delete_GeoData_By_GEODATA_ID_List)
        {
            this._MongoDb.Delete_GeoData_By_GEODATA_ID_List(
                GEODATA_ID_LIST: i_Params_Delete_GeoData_By_GEODATA_ID_List.GEODATA_ID_LIST
            );
        }
        #endregion
        #region Get_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID
        public List<GeoData> Get_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID(Params_Get_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID i_Params_Get_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID)
        {
            List<GeoData> oList_GeoData = null;

            List<DALC.GeoData> oList_DBEntry = _MongoDb.Get_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID(
                i_Params_Get_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID.ORGANIZATION_DATA_SOURCE_KPI_ID
               );
            if (oList_DBEntry != null)
            {
                oList_GeoData = new List<GeoData>();
                if (oList_DBEntry.Count > 0)
                {
                    oList_GeoData = Props.Copy_Prop_Values_From_Api_Response<List<GeoData>>(oList_DBEntry);
                }
            }

            return oList_GeoData;
        }
        #endregion
        #endregion
        #region District
        #region Compute_District_Kpi_Data_Hourly
        public void Compute_District_Kpi_Data_Hourly(Params_Compute_District_Kpi_Data_Hourly i_Params_Compute_District_Kpi_Data_Hourly)
        {
            #region setup
            DateTime CurrentDate = new DateTime(i_Params_Compute_District_Kpi_Data_Hourly.YEAR, i_Params_Compute_District_Kpi_Data_Hourly.MONTH, i_Params_Compute_District_Kpi_Data_Hourly.DAY, i_Params_Compute_District_Kpi_Data_Hourly.HOUR, 0, 0);

            List<District> oList_District = new List<District>();
            List<Area> oList_Area = new List<Area>();
            List<Area_kpi_data> oList_Area_kpi_data = new List<Area_kpi_data>();

            List<Setup_category> oList_Setup_category = Get_Setup_category_By_OWNER_ID(new Params_Get_Setup_category_By_OWNER_ID()
            {
                OWNER_ID = this.oBLC_Initializer.Owner_ID
            });
            List<Setup> oList_Severity_Type_Setup = oList_Setup_category.First(oSetup_category => oSetup_category.SETUP_CATEGORY_NAME == "Severity Type").List_Setup;

            var get_area_kpi_data = Task.Run(() =>
            {
                oList_Area_kpi_data = Props.Copy_Prop_Values_From_Api_Response<List<Area_kpi_data>>(_MongoDb.Get_Area_Kpi_Data_By_Where(
                    START_DATE: CurrentDate,
                    END_DATE: CurrentDate.AddSeconds(1),
                    ENUM_TIMESPAN: DALC.Enum_Timespan.X_HOURLY_COLLECTION,
                    ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: i_Params_Compute_District_Kpi_Data_Hourly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList(),
                    AREA_ID_LIST: null
                ));
            });
            var get_districts = Task.Run(() =>
            {
                oList_District = Get_District_By_OWNER_ID(new Params_Get_District_By_OWNER_ID()
                {
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                });
            });
            var get_areas = Task.Run(() =>
            {
                oList_Area = this.Get_Area_By_OWNER_ID(new Params_Get_Area_By_OWNER_ID()
                {
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                }
                );
            });
            Task.WaitAll(get_area_kpi_data, get_districts, get_areas);

            oList_District = oList_District.Select(district =>
            {
                district.List_Area = oList_Area.Where(area => area.DISTRICT_ID == district.DISTRICT_ID).ToList();
                return district;
            }).ToList();

            List<District_kpi_data> oList_District_kpi_data = new List<District_kpi_data>();
            #endregion
            #region fill list
            foreach (var oOrganization_data_source_kpi in i_Params_Compute_District_Kpi_Data_Hourly.LIST_ORGANIZATION_DATA_SOURCE_KPI)
            {
                if (oOrganization_data_source_kpi.Kpi.SETUP_CATEGORY_ID != null)
                {
                    oOrganization_data_source_kpi.Kpi.Setup_category = oList_Setup_category.Find(setup_category => setup_category.SETUP_CATEGORY_ID == oOrganization_data_source_kpi.Kpi.SETUP_CATEGORY_ID);
                    foreach (var oDistrict in oList_District)
                    {
                        List<Area_kpi_data> oList_Area_kpi_data_To_Use = oList_Area_kpi_data.Where(area_kpi_data => oDistrict.List_Area.Any(area => area.AREA_ID == area_kpi_data.AREA_METADATA.AREA_ID) && area_kpi_data.AREA_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID == oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();
                        foreach (var oSetup in oOrganization_data_source_kpi.Kpi.Setup_category.List_Setup)
                        {
                            if (oOrganization_data_source_kpi.Kpi.IS_BY_SEVERITY)
                            {
                                foreach (var oSeverity_Setup in oList_Severity_Type_Setup)
                                {
                                    string Severity_Type = "Severity Type:" + oSeverity_Setup.SETUP_ID.ToString();
                                    string Incident_Category_Type = "Incident Category Type:" + oSetup.SETUP_ID.ToString();
                                    string CATEGORY = Severity_Type + "," + Incident_Category_Type + ",EXT_STUDY_ZONE_ID:0";
                                    List<Area_kpi_data> oList_Area_kpi_data_To_Use2 = oList_Area_kpi_data_To_Use.Where(area_kpi_data => area_kpi_data.AREA_METADATA.CATEGORY == CATEGORY).ToList();
                                    if (oList_Area_kpi_data_To_Use2.Count > 0)
                                    {
                                        oList_District_kpi_data.Add(new District_kpi_data()
                                        {
                                            DISTRICT_METADATA = new District_metadata()
                                            {
                                                DISTRICT_ID = (int)oDistrict.DISTRICT_ID,
                                                ORGANIZATION_DATA_SOURCE_KPI_ID = (int)oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                CATEGORY = CATEGORY,
                                            },
                                            VALUE_NAME = oList_Area_kpi_data_To_Use2.First().VALUE_NAME,
                                            RECORD_DATE = oList_Area_kpi_data_To_Use2.First().RECORD_DATE,
                                            VALUE_PER_SQM = oList_Area_kpi_data_To_Use2.Sum(area_kpi_data => area_kpi_data.VALUE_PER_SQM),
                                            VALUE = oOrganization_data_source_kpi.Kpi.IS_ADDITIVE_DATA ? (decimal)oList_Area_kpi_data_To_Use2.Sum(area_kpi_data => area_kpi_data.VALUE) : (decimal)oList_Area_kpi_data_To_Use2.Average(area_kpi_data => area_kpi_data.VALUE),
                                        });
                                    }
                                }
                            }
                            else
                            {
                                string Incident_Category_Type = "Incident Category Type:" + oSetup.SETUP_ID.ToString();
                                string CATEGORY = "Severity Type:0," + Incident_Category_Type + ",EXT_STUDY_ZONE_ID:0";
                                List<Area_kpi_data> oList_Area_kpi_data_To_Use2 = oList_Area_kpi_data_To_Use.Where(area_kpi_data => area_kpi_data.AREA_METADATA.CATEGORY == CATEGORY).ToList();
                                if (oList_Area_kpi_data_To_Use2.Count > 0)
                                {
                                    oList_District_kpi_data.Add(new District_kpi_data()
                                    {
                                        DISTRICT_METADATA = new District_metadata()
                                        {
                                            DISTRICT_ID = (int)oDistrict.DISTRICT_ID,
                                            ORGANIZATION_DATA_SOURCE_KPI_ID = (int)oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                            CATEGORY = CATEGORY,
                                        },
                                        VALUE_NAME = oList_Area_kpi_data_To_Use2.First().VALUE_NAME,
                                        RECORD_DATE = oList_Area_kpi_data_To_Use2.First().RECORD_DATE,
                                        VALUE_PER_SQM = oList_Area_kpi_data_To_Use2.Sum(area_kpi_data => area_kpi_data.VALUE_PER_SQM),
                                        VALUE = oOrganization_data_source_kpi.Kpi.IS_ADDITIVE_DATA ? (decimal)oList_Area_kpi_data_To_Use2.Sum(area_kpi_data => area_kpi_data.VALUE) : (decimal)oList_Area_kpi_data_To_Use2.Average(area_kpi_data => area_kpi_data.VALUE),
                                    });
                                }
                            }
                        }
                    }
                }
                else
                {
                    foreach (var oDistrict in oList_District)
                    {
                        if (oOrganization_data_source_kpi.Kpi.IS_BY_SEVERITY)
                        {
                            foreach (var oSeverity_Setup in oList_Severity_Type_Setup)
                            {
                                string Severity_Type = "Severity Type:" + oSeverity_Setup.SETUP_ID.ToString();
                                string CATEGORY = Severity_Type + ",Incident Category Type:0,EXT_STUDY_ZONE_ID:0";
                                List<Area_kpi_data> oList_Area_kpi_data_To_Use = oList_Area_kpi_data.Where(area_kpi_data => oDistrict.List_Area.Any(area => area.AREA_ID == area_kpi_data.AREA_METADATA.AREA_ID) && area_kpi_data.AREA_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID == oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID && area_kpi_data.AREA_METADATA.CATEGORY == CATEGORY).ToList();
                                if (oList_Area_kpi_data_To_Use.Count > 0)
                                {
                                    oList_District_kpi_data.Add(new District_kpi_data()
                                    {
                                        DISTRICT_METADATA = new District_metadata()
                                        {
                                            DISTRICT_ID = (int)oDistrict.DISTRICT_ID,
                                            ORGANIZATION_DATA_SOURCE_KPI_ID = (int)oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                            CATEGORY = CATEGORY,
                                        },
                                        VALUE_NAME = oList_Area_kpi_data_To_Use.First().VALUE_NAME,
                                        RECORD_DATE = oList_Area_kpi_data_To_Use.First().RECORD_DATE,
                                        VALUE_PER_SQM = oList_Area_kpi_data_To_Use.Average(area_kpi_data => area_kpi_data.VALUE_PER_SQM),
                                        VALUE = oOrganization_data_source_kpi.Kpi.IS_ADDITIVE_DATA ? (decimal)oList_Area_kpi_data_To_Use.Sum(area_kpi_data => area_kpi_data.VALUE) : (decimal)oList_Area_kpi_data_To_Use.Average(area_kpi_data => area_kpi_data.VALUE),
                                    });
                                }
                            }
                        }
                        else
                        {
                            string CATEGORY = "Severity Type:0,Incident Category Type:0,EXT_STUDY_ZONE_ID:0";
                            List<Area_kpi_data> oList_Area_kpi_data_To_Use = oList_Area_kpi_data.Where(area_kpi_data => oDistrict.List_Area.Any(area => area.AREA_ID == area_kpi_data.AREA_METADATA.AREA_ID) && area_kpi_data.AREA_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID == oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();
                            if (oList_Area_kpi_data_To_Use.Count > 0)
                            {
                                oList_District_kpi_data.Add(new District_kpi_data()
                                {
                                    DISTRICT_METADATA = new District_metadata()
                                    {
                                        DISTRICT_ID = (int)oDistrict.DISTRICT_ID,
                                        ORGANIZATION_DATA_SOURCE_KPI_ID = (int)oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                        CATEGORY = CATEGORY,
                                    },
                                    VALUE_NAME = oList_Area_kpi_data_To_Use.First().VALUE_NAME,
                                    RECORD_DATE = oList_Area_kpi_data_To_Use.First().RECORD_DATE,
                                    VALUE_PER_SQM = oList_Area_kpi_data_To_Use.Average(area_kpi_data => area_kpi_data.VALUE_PER_SQM),
                                    VALUE = oOrganization_data_source_kpi.Kpi.IS_ADDITIVE_DATA ? (decimal)oList_Area_kpi_data_To_Use.Sum(area_kpi_data => area_kpi_data.VALUE) : (decimal)oList_Area_kpi_data_To_Use.Average(area_kpi_data => area_kpi_data.VALUE),
                                });
                            }
                        }
                    }
                }
            }
            #endregion
            #region send data
            if (oList_District_kpi_data?.Count() > 0)
            {
                try
                {
                    Edit_District_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN(new Params_Edit_District_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN()
                    {
                        LIST_DISTRICT_KPI_DATA = oList_District_kpi_data,
                        LIST_ORGANIZATION_DATA_SOURCE_KPI_ID = i_Params_Compute_District_Kpi_Data_Hourly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList(),
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
        #region Compute_District_Kpi_Data_Daily
        public void Compute_District_Kpi_Data_Daily(Params_Compute_District_Kpi_Data_Daily i_Params_Compute_District_Kpi_Data_Daily)
        {
            if (i_Params_Compute_District_Kpi_Data_Daily != null)
            {
                if (i_Params_Compute_District_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI != null && i_Params_Compute_District_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Count() > 0)
                {
                    DateTime CurrentDate = new DateTime(i_Params_Compute_District_Kpi_Data_Daily.YEAR, i_Params_Compute_District_Kpi_Data_Daily.MONTH, i_Params_Compute_District_Kpi_Data_Daily.DAY);
                    DateTime StartDate = CurrentDate.AddDays(-1);
                    List<Organization_data_source_kpi> oList_Organization_data_source_kpi_Trendline = i_Params_Compute_District_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.IS_TRENDLINE == true).ToList();
                    List<Organization_data_source_kpi> oList_Organization_data_source_kpi_Non_Trendline = i_Params_Compute_District_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.IS_TRENDLINE == false).ToList();
                    List<int?> List_Organization_data_source_kpi_ID = i_Params_Compute_District_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();
                    List<District_kpi_data> oList_District_kpi_data = Props.Copy_Prop_Values_From_Api_Response<List<District_kpi_data>>(_MongoDb.Get_District_Kpi_Data_By_Where(
                        START_DATE: StartDate,
                        END_DATE: CurrentDate,
                        ENUM_TIMESPAN: DALC.Enum_Timespan.X_HOURLY_COLLECTION,
                        ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: List_Organization_data_source_kpi_ID,
                        DISTRICT_ID_LIST: null
                    ));

                    List<District_kpi_data> oList_District_kpi_data_To_Save = new List<District_kpi_data>();

                    if (oList_District_kpi_data != null && oList_District_kpi_data.Count > 0)
                    {
                        #region Calculate Trendline Data

                        if (oList_Organization_data_source_kpi_Trendline != null && oList_Organization_data_source_kpi_Trendline.Count > 0)
                        {
                            List<District_kpi_data> oList_District_kpi_data_Trendline = oList_District_kpi_data.Where(oDistrict_kpi => oList_Organization_data_source_kpi_Trendline.Any(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == oDistrict_kpi.DISTRICT_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID)).ToList();

                            if (oList_District_kpi_data_Trendline != null && oList_District_kpi_data_Trendline.Count > 0)
                            {
                                List<District_kpi_data> oList_District_kpi_data_Trendline_To_Save = oList_District_kpi_data_Trendline
                                                   .GroupBy(district_kpi_data => new
                                                   {
                                                       district_kpi_data.DISTRICT_METADATA.DISTRICT_ID,
                                                       district_kpi_data.DISTRICT_METADATA.CATEGORY,
                                                       district_kpi_data.DISTRICT_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                   })
                                                   .Select(district_kpi_data => new District_kpi_data()
                                                   {
                                                       DISTRICT_METADATA = new District_metadata()
                                                       {
                                                           DISTRICT_ID = district_kpi_data.Key.DISTRICT_ID,
                                                           CATEGORY = district_kpi_data.Key.CATEGORY,
                                                           ORGANIZATION_DATA_SOURCE_KPI_ID = district_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                       },
                                                       RECORD_DATE = StartDate,
                                                       VALUE_PER_SQM = i_Params_Compute_District_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == district_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? district_kpi_data.Average(index => index.VALUE_PER_SQM) : district_kpi_data.Sum(index => index.VALUE_PER_SQM),
                                                       VALUE_NAME = i_Params_Compute_District_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == district_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? StartDate.ToShortDateString() : district_kpi_data.First().VALUE_NAME,
                                                       VALUE = i_Params_Compute_District_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == district_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_ADDITIVE_DATA ? district_kpi_data.Sum(index => index.VALUE) : district_kpi_data.Average(index => index.VALUE),
                                                   }).ToList();

                                oList_District_kpi_data_To_Save = oList_District_kpi_data_To_Save.Concat(oList_District_kpi_data_Trendline_To_Save).ToList();
                            }
                        }

                        #endregion

                        #region Calculate Non Trendline Data

                        if (oList_Organization_data_source_kpi_Non_Trendline != null && oList_Organization_data_source_kpi_Non_Trendline.Count > 0)
                        {
                            List<District_kpi_data> oList_District_kpi_data_Non_Trendline = oList_District_kpi_data.Where(oDistrict_kpi => oList_Organization_data_source_kpi_Non_Trendline.Any(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == oDistrict_kpi.DISTRICT_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID)).ToList();

                            if (oList_District_kpi_data_Non_Trendline != null && oList_District_kpi_data_Non_Trendline.Count > 0)
                            {
                                List<District_kpi_data> oList_District_kpi_data_Non_Trendline_To_Save = oList_District_kpi_data_Non_Trendline
                                                   .GroupBy(district_kpi_data => new
                                                   {
                                                       district_kpi_data.DISTRICT_METADATA.DISTRICT_ID,
                                                       district_kpi_data.DISTRICT_METADATA.CATEGORY,
                                                       district_kpi_data.DISTRICT_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                       district_kpi_data.VALUE_NAME
                                                   })
                                                   .Select(district_kpi_data => new District_kpi_data()
                                                   {
                                                       DISTRICT_METADATA = new District_metadata()
                                                       {
                                                           DISTRICT_ID = district_kpi_data.Key.DISTRICT_ID,
                                                           CATEGORY = district_kpi_data.Key.CATEGORY,
                                                           ORGANIZATION_DATA_SOURCE_KPI_ID = district_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                       },
                                                       RECORD_DATE = StartDate,
                                                       VALUE_PER_SQM = i_Params_Compute_District_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == district_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? district_kpi_data.Average(index => index.VALUE_PER_SQM) : district_kpi_data.Sum(index => index.VALUE_PER_SQM),
                                                       VALUE_NAME = i_Params_Compute_District_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == district_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? StartDate.ToShortDateString() : district_kpi_data.First().VALUE_NAME,
                                                       VALUE = i_Params_Compute_District_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == district_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_ADDITIVE_DATA ? district_kpi_data.Sum(index => index.VALUE) : district_kpi_data.Average(index => index.VALUE),
                                                   }).ToList();

                                oList_District_kpi_data_To_Save = oList_District_kpi_data_To_Save.Concat(oList_District_kpi_data_Non_Trendline_To_Save).ToList();
                            }
                        }

                        #endregion

                        if (oList_District_kpi_data_To_Save != null && oList_District_kpi_data_To_Save.Count > 0)
                        {
                            try
                            {
                                Edit_District_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN(new Params_Edit_District_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN()
                                {
                                    LIST_DISTRICT_KPI_DATA = oList_District_kpi_data_To_Save,
                                    LIST_ORGANIZATION_DATA_SOURCE_KPI_ID = i_Params_Compute_District_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList(),
                                    RECORD_DATE = StartDate,
                                    ENUM_TIMESPAN = Enum_Timespan.X_DAILY_COLLECTION
                                });
                            }
                            catch (Exception ex)
                            {
                                throw new BLC_Exception(ex.Message);
                            }

                            #region Calculate & Save Alerts

                            Task.Run(() =>
                            {
                                DateTime currentDate = new DateTime(i_Params_Compute_District_Kpi_Data_Daily.YEAR, i_Params_Compute_District_Kpi_Data_Daily.MONTH, i_Params_Compute_District_Kpi_Data_Daily.DAY);
                                if (currentDate.DayOfWeek == DayOfWeek.Monday)
                                {
                                    #region Declaration & Initialization

                                    long? District_Setup_ID = 0;
                                    List<District> oList_District = new List<District>();
                                    List<Alert> oList_Alert = new List<Alert>();
                                    List<Alert_settings> oList_Alert_settings = new List<Alert_settings>();
                                    List<Level_id_with_percent> oList_Level_id_with_percent = new List<Level_id_with_percent>();

                                    #endregion

                                    #region Get District Setup

                                    var get_site_setup = Task.Run(() =>
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

                                    #region Get District List

                                    var get_district_list = Task.Run(() =>
                                    {
                                        oList_District = Get_District_By_OWNER_ID(new Params_Get_District_By_OWNER_ID()
                                        {
                                            OWNER_ID = this.oBLC_Initializer.Owner_ID
                                        });
                                    });

                                    #endregion

                                    #region Get Alert_Settings

                                    var get_alert_settings = Task.Run(() =>
                                    {
                                        oList_Alert_settings = Props.Copy_Prop_Values_From_Api_Response<List<Alert_settings>>(
                                        this._service_mesh.Get_Alert_settings_By_OWNER_ID_Adv(new Service_Mesh.Params_Get_Alert_settings_By_OWNER_ID()
                                        {
                                            OWNER_ID = this.oBLC_Initializer.Owner_ID
                                        }).i_Result
                                    );
                                    });

                                    #endregion

                                    Task.WaitAll(get_site_setup, get_district_list, get_alert_settings);

                                    #region Get District_kpi_data

                                    List<Organization_data_source_kpi> oList_Organization_data_source_kpi_with_alerts = i_Params_Compute_District_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.HAS_ALERTS).ToList();

                                    List<District_kpi_data> oList_Old_District_kpi_data = Get_District_Kpi_Data_By_Where(new Params_Get_District_Kpi_Data_By_Where()
                                    {
                                        END_DATE = currentDate,
                                        START_DATE = currentDate.AddDays(-7),
                                        ENUM_TIMESPAN = Enum_Timespan.X_DAILY_COLLECTION,
                                        DISTRICT_ID_LIST = oList_District.Select(oDistrict => oDistrict.DISTRICT_ID).ToList(),
                                        ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = oList_Organization_data_source_kpi_with_alerts.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList()
                                    });

                                    List<District_kpi_data> oList_District_kpi_data_with_alerts = oList_District_kpi_data_To_Save.Where(oDistrict_kpi_data => oList_Organization_data_source_kpi_with_alerts.Any(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == oDistrict_kpi_data.DISTRICT_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID)).ToList();

                                    #endregion

                                    #region Fill Data

                                    oList_Organization_data_source_kpi_with_alerts.ForEach(oOrganization_data_source_kpi =>
                                    {
                                        oList_District_kpi_data_with_alerts.Where(oDistrict_kpi_data => oDistrict_kpi_data.DISTRICT_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID == oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList().ForEach(oDistrict_kpi_data =>
                                        {
                                            District_kpi_data oOld_District_kpi_data = oList_Old_District_kpi_data.Find(oDistrict_kpi_data => oDistrict_kpi_data.DISTRICT_METADATA.DISTRICT_ID == oDistrict_kpi_data.DISTRICT_METADATA.DISTRICT_ID);
                                            if (oDistrict_kpi_data.VALUE == 0 && oOld_District_kpi_data.VALUE == 0)
                                            {
                                                oList_Level_id_with_percent.Add(new Level_id_with_percent()
                                                {
                                                    VALUE = oDistrict_kpi_data.VALUE,
                                                    LEVEL_ID = oDistrict_kpi_data.DISTRICT_METADATA.DISTRICT_ID,
                                                    District = oList_District.Find(site => site.DISTRICT_ID == oDistrict_kpi_data.DISTRICT_METADATA.DISTRICT_ID),
                                                    PERCENT_INCREASE = 0,
                                                });
                                            }
                                            else
                                            {
                                                oList_Level_id_with_percent.Add(new Level_id_with_percent()
                                                {
                                                    VALUE = oDistrict_kpi_data.VALUE,
                                                    LEVEL_ID = oDistrict_kpi_data.DISTRICT_METADATA.DISTRICT_ID,
                                                    District = oList_District.Find(site => site.DISTRICT_ID == oDistrict_kpi_data.DISTRICT_METADATA.DISTRICT_ID),
                                                    PERCENT_INCREASE = Math.Round((oOld_District_kpi_data.VALUE == 0 ? 100 : ((oDistrict_kpi_data.VALUE - oOld_District_kpi_data.VALUE) / oOld_District_kpi_data.VALUE) * 100), 2),
                                                });
                                            }
                                        });
                                        oList_Alert_settings.ForEach(alert_settings =>
                                        {
                                            oList_Level_id_with_percent.ForEach(level_id_with_percent_increase =>
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
                                                    Alert oAlert = new Alert();
                                                    oAlert.USER_ID = alert_settings.USER_ID;
                                                    oAlert.LEVEL_ID = level_id_with_percent_increase.LEVEL_ID;
                                                    oAlert.ORGANIZATION_DATA_SOURCE_KPI_ID = oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID;
                                                    oAlert.LEVEL_SETUP_ID = District_Setup_ID;
                                                    oAlert.RECORD_DATE = currentDate;
                                                    oAlert.IS_ACKNOWLEDGED = false;
                                                    oAlert.ALERT_VALUE = Math.Abs(level_id_with_percent_increase.PERCENT_INCREASE.Value);
                                                    oAlert.VALUE_PASSED = alert_settings.VALUE;
                                                    oAlert.VALUE_TYPE_SETUP_ID = alert_settings.Value_type_setup.SETUP_ID;
                                                    oAlert.OPERATION_TYPE_SETUP_ID = alert_settings.Operation_setup.SETUP_ID;
                                                    oList_Alert.Add(oAlert);
                                                }
                                            });
                                        });
                                    });

                                    #endregion

                                    #region Edit Alert List

                                    Edit_Alert_List(new Params_Edit_Alert_List()
                                    {
                                        List_Alert = Props.Copy_Prop_Values_From_Api_Response<List<Alert>>(oList_Alert),
                                    });

                                    #endregion
                                }
                            });

                            #endregion

                        }
                    }
                }
            }
        }
        #endregion
        #region Compute_District_Kpi_Data_Weekly
        public void Compute_District_Kpi_Data_Weekly(Params_Compute_District_Kpi_Data_Weekly i_Params_Compute_District_Kpi_Data_Weekly)
        {
            if (i_Params_Compute_District_Kpi_Data_Weekly != null)
            {
                if (i_Params_Compute_District_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI != null && i_Params_Compute_District_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Count() > 0)
                {
                    DateTime CurrentDate = new DateTime(i_Params_Compute_District_Kpi_Data_Weekly.YEAR, i_Params_Compute_District_Kpi_Data_Weekly.MONTH, i_Params_Compute_District_Kpi_Data_Weekly.DAY);
                    DateTime StartDate = CurrentDate.AddDays(-7);
                    List<Organization_data_source_kpi> oList_Organization_data_source_kpi_Trendline = i_Params_Compute_District_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.IS_TRENDLINE == true).ToList();
                    List<Organization_data_source_kpi> oList_Organization_data_source_kpi_Non_Trendline = i_Params_Compute_District_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.IS_TRENDLINE == false).ToList();
                    List<int?> List_Organization_data_source_kpi_ID = i_Params_Compute_District_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();
                    List<District_kpi_data> oList_District_kpi_data = Props.Copy_Prop_Values_From_Api_Response<List<District_kpi_data>>(_MongoDb.Get_District_Kpi_Data_By_Where(
                        START_DATE: StartDate,
                        END_DATE: CurrentDate,
                        ENUM_TIMESPAN: DALC.Enum_Timespan.X_DAILY_COLLECTION,
                        ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: List_Organization_data_source_kpi_ID,
                        DISTRICT_ID_LIST: null
                    ));
                    List<District_kpi_data> oList_District_kpi_data_To_Save = new List<District_kpi_data>();

                    if (oList_District_kpi_data != null && oList_District_kpi_data.Count > 0)
                    {
                        #region Calculate Trendline Data

                        if (oList_Organization_data_source_kpi_Trendline != null && oList_Organization_data_source_kpi_Trendline.Count > 0)
                        {
                            List<District_kpi_data> oList_District_kpi_data_Trendline = oList_District_kpi_data.Where(oDistrict_kpi => oList_Organization_data_source_kpi_Trendline.Any(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == oDistrict_kpi.DISTRICT_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID)).ToList();

                            if (oList_District_kpi_data_Trendline != null && oList_District_kpi_data_Trendline.Count > 0)
                            {
                                List<District_kpi_data> oList_District_kpi_data_Trendline_To_Save = oList_District_kpi_data_Trendline
                                                   .GroupBy(district_kpi_data => new
                                                   {
                                                       district_kpi_data.DISTRICT_METADATA.DISTRICT_ID,
                                                       district_kpi_data.DISTRICT_METADATA.CATEGORY,
                                                       district_kpi_data.DISTRICT_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                   })
                                                   .Select(district_kpi_data => new District_kpi_data()
                                                   {
                                                       DISTRICT_METADATA = new District_metadata()
                                                       {
                                                           DISTRICT_ID = district_kpi_data.Key.DISTRICT_ID,
                                                           CATEGORY = district_kpi_data.Key.CATEGORY,
                                                           ORGANIZATION_DATA_SOURCE_KPI_ID = district_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                       },
                                                       RECORD_DATE = StartDate,
                                                       VALUE_PER_SQM = i_Params_Compute_District_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == district_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? district_kpi_data.Average(index => index.VALUE_PER_SQM) : district_kpi_data.Sum(index => index.VALUE_PER_SQM),
                                                       VALUE_NAME = i_Params_Compute_District_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == district_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? i_Params_Compute_District_Kpi_Data_Weekly.YEAR + " Week " + Get_Week_Of_Year(new Params_Get_Week_Of_Year()
                                                       {
                                                           DAY = StartDate.Day,
                                                           YEAR = StartDate.Year,
                                                           MONTH = StartDate.Month,
                                                       }) : district_kpi_data.First().VALUE_NAME,
                                                       VALUE = i_Params_Compute_District_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == district_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_ADDITIVE_DATA ? district_kpi_data.Sum(index => index.VALUE) : district_kpi_data.Average(index => index.VALUE),
                                                   }).ToList();
                                oList_District_kpi_data_To_Save = oList_District_kpi_data_To_Save.Concat(oList_District_kpi_data_Trendline_To_Save).ToList();
                            }
                        }

                        #endregion

                        #region Calculate Non Trendline Data

                        if (oList_Organization_data_source_kpi_Non_Trendline != null && oList_Organization_data_source_kpi_Non_Trendline.Count > 0)
                        {
                            List<District_kpi_data> oList_District_kpi_data_Non_Trendline = oList_District_kpi_data.Where(oDistrict_kpi => oList_Organization_data_source_kpi_Non_Trendline.Any(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == oDistrict_kpi.DISTRICT_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID)).ToList();

                            if (oList_District_kpi_data_Non_Trendline != null && oList_District_kpi_data_Non_Trendline.Count > 0)
                            {
                                List<District_kpi_data> oList_District_kpi_data_Non_Trendline_To_Save = oList_District_kpi_data_Non_Trendline
                                                   .GroupBy(district_kpi_data => new
                                                   {
                                                       district_kpi_data.DISTRICT_METADATA.DISTRICT_ID,
                                                       district_kpi_data.DISTRICT_METADATA.CATEGORY,
                                                       district_kpi_data.DISTRICT_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                       district_kpi_data.VALUE_NAME
                                                   })
                                                   .Select(district_kpi_data => new District_kpi_data()
                                                   {
                                                       DISTRICT_METADATA = new District_metadata()
                                                       {
                                                           DISTRICT_ID = district_kpi_data.Key.DISTRICT_ID,
                                                           CATEGORY = district_kpi_data.Key.CATEGORY,
                                                           ORGANIZATION_DATA_SOURCE_KPI_ID = district_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                       },
                                                       RECORD_DATE = StartDate,
                                                       VALUE_PER_SQM = i_Params_Compute_District_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == district_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? district_kpi_data.Average(index => index.VALUE_PER_SQM) : district_kpi_data.Sum(index => index.VALUE_PER_SQM),
                                                       VALUE_NAME = i_Params_Compute_District_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == district_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? StartDate.Year + " Week " + Get_Week_Of_Year(new Params_Get_Week_Of_Year()
                                                       {
                                                           DAY = StartDate.Day,
                                                           YEAR = i_Params_Compute_District_Kpi_Data_Weekly.YEAR,
                                                           MONTH = StartDate.Month,
                                                       }) : district_kpi_data.First().VALUE_NAME,
                                                       VALUE = i_Params_Compute_District_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == district_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_ADDITIVE_DATA ? district_kpi_data.Sum(index => index.VALUE) : district_kpi_data.Average(index => index.VALUE),
                                                   }).ToList();

                                oList_District_kpi_data_To_Save = oList_District_kpi_data_To_Save.Concat(oList_District_kpi_data_Non_Trendline_To_Save).ToList();
                            }
                        }

                        #endregion

                        if (oList_District_kpi_data_To_Save?.Count > 0)
                        {
                            try
                            {
                                Edit_District_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN(new Params_Edit_District_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN()
                                {
                                    LIST_DISTRICT_KPI_DATA = oList_District_kpi_data_To_Save,
                                    LIST_ORGANIZATION_DATA_SOURCE_KPI_ID = i_Params_Compute_District_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList(),
                                    RECORD_DATE = StartDate,
                                    ENUM_TIMESPAN = Enum_Timespan.X_WEEKLY_COLLECTION
                                });
                            }
                            catch (Exception ex)
                            {
                                throw new BLC_Exception(ex.Message);
                            }
                        }
                    }
                }
            }
        }
        #endregion
        #region Compute_District_Kpi_Data_Monthly
        public void Compute_District_Kpi_Data_Monthly(Params_Compute_District_Kpi_Data_Monthly i_Params_Compute_District_Kpi_Data_Monthly)
        {
            if (i_Params_Compute_District_Kpi_Data_Monthly != null)
            {
                if (i_Params_Compute_District_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI != null && i_Params_Compute_District_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Count() > 0)
                {
                    DateTime CurrentDate = new DateTime(i_Params_Compute_District_Kpi_Data_Monthly.YEAR, i_Params_Compute_District_Kpi_Data_Monthly.MONTH, 1);
                    DateTime StartDate = CurrentDate.AddMonths(-1);
                    List<Organization_data_source_kpi> oList_Organization_data_source_kpi_Trendline = i_Params_Compute_District_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.IS_TRENDLINE == true).ToList();
                    List<Organization_data_source_kpi> oList_Organization_data_source_kpi_Non_Trendline = i_Params_Compute_District_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.IS_TRENDLINE == false).ToList();
                    List<int?> List_Organization_data_source_kpi_ID = i_Params_Compute_District_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();
                    List<District_kpi_data> oList_District_kpi_data = Props.Copy_Prop_Values_From_Api_Response<List<District_kpi_data>>(_MongoDb.Get_District_Kpi_Data_By_Where(
                        START_DATE: StartDate,
                        END_DATE: CurrentDate,
                        ENUM_TIMESPAN: DALC.Enum_Timespan.X_DAILY_COLLECTION,
                        ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: List_Organization_data_source_kpi_ID,
                        DISTRICT_ID_LIST: null
                    ));
                    List<District_kpi_data> oList_District_kpi_data_To_Save = new List<District_kpi_data>();

                    if (oList_District_kpi_data != null && oList_District_kpi_data.Count > 0)
                    {
                        #region Calculate Trendline Data

                        if (oList_Organization_data_source_kpi_Trendline != null && oList_Organization_data_source_kpi_Trendline.Count > 0)
                        {
                            List<District_kpi_data> oList_District_kpi_data_Trendline = oList_District_kpi_data.Where(oDistrict_kpi => oList_Organization_data_source_kpi_Trendline.Any(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == oDistrict_kpi.DISTRICT_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID)).ToList();

                            if (oList_District_kpi_data_Trendline != null && oList_District_kpi_data_Trendline.Count > 0)
                            {
                                List<District_kpi_data> oList_District_kpi_data_Trendline_To_Save = oList_District_kpi_data_Trendline
                                                   .GroupBy(district_kpi_data => new
                                                   {
                                                       district_kpi_data.DISTRICT_METADATA.DISTRICT_ID,
                                                       district_kpi_data.DISTRICT_METADATA.CATEGORY,
                                                       district_kpi_data.DISTRICT_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                   })
                                                   .Select(district_kpi_data => new District_kpi_data()
                                                   {
                                                       DISTRICT_METADATA = new District_metadata()
                                                       {
                                                           DISTRICT_ID = district_kpi_data.Key.DISTRICT_ID,
                                                           CATEGORY = district_kpi_data.Key.CATEGORY,
                                                           ORGANIZATION_DATA_SOURCE_KPI_ID = district_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                       },
                                                       RECORD_DATE = StartDate,
                                                       VALUE_PER_SQM = i_Params_Compute_District_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == district_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? district_kpi_data.Average(index => index.VALUE_PER_SQM) : district_kpi_data.Sum(index => index.VALUE_PER_SQM),
                                                       VALUE_NAME = i_Params_Compute_District_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == district_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? StartDate.Month + "/" + StartDate.Year : district_kpi_data.First().VALUE_NAME,
                                                       VALUE = i_Params_Compute_District_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == district_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_ADDITIVE_DATA ? district_kpi_data.Sum(index => index.VALUE) : district_kpi_data.Average(index => index.VALUE),
                                                   }).ToList();
                                oList_District_kpi_data_To_Save = oList_District_kpi_data_To_Save.Concat(oList_District_kpi_data_Trendline_To_Save).ToList();
                            }
                        }

                        #endregion

                        #region Calculate Non Trendline Data

                        if (oList_Organization_data_source_kpi_Non_Trendline != null && oList_Organization_data_source_kpi_Non_Trendline.Count > 0)
                        {
                            List<District_kpi_data> oList_District_kpi_data_Non_Trendline = oList_District_kpi_data.Where(oDistrict_kpi => oList_Organization_data_source_kpi_Non_Trendline.Any(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == oDistrict_kpi.DISTRICT_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID)).ToList();

                            if (oList_District_kpi_data_Non_Trendline != null && oList_District_kpi_data_Non_Trendline.Count > 0)
                            {
                                List<District_kpi_data> oList_District_kpi_data_Non_Trendline_To_Save = oList_District_kpi_data_Non_Trendline
                                                   .GroupBy(district_kpi_data => new
                                                   {
                                                       district_kpi_data.DISTRICT_METADATA.DISTRICT_ID,
                                                       district_kpi_data.DISTRICT_METADATA.CATEGORY,
                                                       district_kpi_data.DISTRICT_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                       district_kpi_data.VALUE_NAME
                                                   })
                                                   .Select(district_kpi_data => new District_kpi_data()
                                                   {
                                                       DISTRICT_METADATA = new District_metadata()
                                                       {
                                                           DISTRICT_ID = district_kpi_data.Key.DISTRICT_ID,
                                                           CATEGORY = district_kpi_data.Key.CATEGORY,
                                                           ORGANIZATION_DATA_SOURCE_KPI_ID = district_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                       },
                                                       RECORD_DATE = StartDate,
                                                       VALUE_PER_SQM = i_Params_Compute_District_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == district_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? district_kpi_data.Average(index => index.VALUE_PER_SQM) : district_kpi_data.Sum(index => index.VALUE_PER_SQM),
                                                       VALUE_NAME = i_Params_Compute_District_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == district_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? StartDate.Month + "/" + StartDate.Year : district_kpi_data.First().VALUE_NAME,
                                                       VALUE = i_Params_Compute_District_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == district_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_ADDITIVE_DATA ? district_kpi_data.Sum(index => index.VALUE) : district_kpi_data.Average(index => index.VALUE),
                                                   }).ToList();

                                oList_District_kpi_data_To_Save = oList_District_kpi_data_To_Save.Concat(oList_District_kpi_data_Non_Trendline_To_Save).ToList();
                            }
                        }

                        #endregion

                        if (oList_District_kpi_data_To_Save?.Count > 0)
                        {
                            try
                            {
                                Edit_District_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN(new Params_Edit_District_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN()
                                {
                                    LIST_DISTRICT_KPI_DATA = oList_District_kpi_data_To_Save,
                                    LIST_ORGANIZATION_DATA_SOURCE_KPI_ID = i_Params_Compute_District_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList(),
                                    RECORD_DATE = StartDate,
                                    ENUM_TIMESPAN = Enum_Timespan.X_MONTHLY_COLLECTION
                                });
                            }
                            catch (Exception ex)
                            {
                                throw new BLC_Exception(ex.Message);
                            }
                        }
                    }
                }
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
        #endregion
        #region Area
        #region Compute_Area_Kpi_Data_Hourly
        public void Compute_Area_Kpi_Data_Hourly(Params_Compute_Area_Kpi_Data_Hourly i_Params_Compute_Area_Kpi_Data_Hourly)
        {
            #region setup
            DateTime CurrentDate = new DateTime(i_Params_Compute_Area_Kpi_Data_Hourly.YEAR, i_Params_Compute_Area_Kpi_Data_Hourly.MONTH, i_Params_Compute_Area_Kpi_Data_Hourly.DAY, i_Params_Compute_Area_Kpi_Data_Hourly.HOUR, 0, 0);

            List<Area> oList_Area = new List<Area>();
            List<Site> oList_Site = new List<Site>();
            List<Site_kpi_data> oList_Site_kpi_data = new List<Site_kpi_data>();

            List<Setup_category> oList_Setup_category = Get_Setup_category_By_OWNER_ID(new Params_Get_Setup_category_By_OWNER_ID()
            {
                OWNER_ID = this.oBLC_Initializer.Owner_ID
            });
            List<Setup> oList_Severity_Type_Setup = oList_Setup_category.First(oSetup_category => oSetup_category.SETUP_CATEGORY_NAME == "Severity Type").List_Setup;

            var get_site_kpi_data = Task.Run(() =>
            {
                oList_Site_kpi_data = Props.Copy_Prop_Values_From_Api_Response<List<Site_kpi_data>>(_MongoDb.Get_Site_Kpi_Data_By_Where(
                    START_DATE: CurrentDate,
                    END_DATE: CurrentDate.AddSeconds(1),
                    ENUM_TIMESPAN: DALC.Enum_Timespan.X_HOURLY_COLLECTION,
                    ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: i_Params_Compute_Area_Kpi_Data_Hourly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList(),
                    SITE_ID_LIST: null
                ));
            });
            var get_areas = Task.Run(() =>
            {
                oList_Area = Get_Area_By_OWNER_ID(new Params_Get_Area_By_OWNER_ID()
                {
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                });
            });
            var get_sites = Task.Run(() =>
            {
                oList_Site = this.Get_Site_By_OWNER_ID(new Params_Get_Site_By_OWNER_ID()
                {
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                }
                );
            });
            Task.WaitAll(get_site_kpi_data, get_areas, get_sites);

            oList_Area = oList_Area.Select(area =>
            {
                area.List_Site = oList_Site.Where(site => site.AREA_ID == area.AREA_ID).ToList();
                return area;
            }).ToList();

            List<Area_kpi_data> oList_Area_kpi_data = new List<Area_kpi_data>();
            #endregion
            #region fill list
            foreach (var oOrganization_data_source_kpi in i_Params_Compute_Area_Kpi_Data_Hourly.LIST_ORGANIZATION_DATA_SOURCE_KPI)
            {
                if (oOrganization_data_source_kpi.Kpi.SETUP_CATEGORY_ID != null)
                {
                    oOrganization_data_source_kpi.Kpi.Setup_category = oList_Setup_category.Find(setup_category => setup_category.SETUP_CATEGORY_ID == oOrganization_data_source_kpi.Kpi.SETUP_CATEGORY_ID);
                    foreach (var oArea in oList_Area)
                    {
                        List<Site_kpi_data> oList_Site_kpi_data_To_Use = oList_Site_kpi_data.Where(site_kpi_data => oArea.List_Site.Any(site => site.SITE_ID == site_kpi_data.SITE_METADATA.SITE_ID) && site_kpi_data.SITE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID == oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();
                        foreach (var oSetup in oOrganization_data_source_kpi.Kpi.Setup_category.List_Setup)
                        {
                            if (oOrganization_data_source_kpi.Kpi.IS_BY_SEVERITY)
                            {
                                foreach (var oSeverity_Setup in oList_Severity_Type_Setup)
                                {
                                    string Severity_Type = "Severity Type:" + oSeverity_Setup.SETUP_ID.ToString();
                                    string Incident_Category_Type = "Incident Category Type:" + oSetup.SETUP_ID.ToString();
                                    string CATEGORY = Severity_Type + "," + Incident_Category_Type + ",EXT_STUDY_ZONE_ID:0";
                                    List<Site_kpi_data> oList_Site_kpi_data_To_Use2 = oList_Site_kpi_data_To_Use.Where(site_kpi_data => site_kpi_data.SITE_METADATA.CATEGORY == CATEGORY).ToList();
                                    if (oList_Site_kpi_data_To_Use2.Count > 0)
                                    {
                                        oList_Area_kpi_data.Add(new Area_kpi_data()
                                        {
                                            AREA_METADATA = new Area_metadata()
                                            {
                                                ORGANIZATION_DATA_SOURCE_KPI_ID = (int)oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                AREA_ID = (int)oArea.AREA_ID,
                                                CATEGORY = CATEGORY
                                            },
                                            VALUE_NAME = oList_Site_kpi_data_To_Use2.First().VALUE_NAME,
                                            RECORD_DATE = oList_Site_kpi_data_To_Use2.First().RECORD_DATE,
                                            VALUE_PER_SQM = oList_Site_kpi_data_To_Use2.Sum(site_kpi_data => site_kpi_data.VALUE_PER_SQM),
                                            VALUE = (oOrganization_data_source_kpi.Kpi.IS_ADDITIVE_DATA ? oList_Site_kpi_data_To_Use2.Sum(site_kpi_data => site_kpi_data.VALUE) : oList_Site_kpi_data_To_Use2.Average(site_kpi_data => site_kpi_data.VALUE)),
                                        });
                                    }
                                }
                            }
                            else
                            {
                                string Incident_Category_Type = "Incident Category Type:" + oSetup.SETUP_ID.ToString();
                                string CATEGORY = "Severity Type:0," + Incident_Category_Type + ",EXT_STUDY_ZONE_ID:0";
                                List<Site_kpi_data> oList_Site_kpi_data_To_Use2 = oList_Site_kpi_data_To_Use.Where(site_kpi_data => site_kpi_data.SITE_METADATA.CATEGORY == CATEGORY).ToList();
                                if (oList_Site_kpi_data_To_Use2.Count > 0)
                                {
                                    oList_Area_kpi_data.Add(new Area_kpi_data()
                                    {
                                        AREA_METADATA = new Area_metadata()
                                        {
                                            ORGANIZATION_DATA_SOURCE_KPI_ID = (int)oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                            AREA_ID = (int)oArea.AREA_ID,
                                            CATEGORY = CATEGORY
                                        },
                                        VALUE_NAME = oList_Site_kpi_data_To_Use2.First().VALUE_NAME,
                                        RECORD_DATE = oList_Site_kpi_data_To_Use2.First().RECORD_DATE,
                                        VALUE_PER_SQM = oList_Site_kpi_data_To_Use2.Sum(site_kpi_data => site_kpi_data.VALUE_PER_SQM),
                                        VALUE = (oOrganization_data_source_kpi.Kpi.IS_ADDITIVE_DATA ? oList_Site_kpi_data_To_Use2.Sum(site_kpi_data => site_kpi_data.VALUE) : oList_Site_kpi_data_To_Use2.Average(site_kpi_data => site_kpi_data.VALUE)),
                                    });
                                }
                            }
                        }
                    }
                }
                else
                {
                    foreach (var oArea in oList_Area)
                    {
                        if (oOrganization_data_source_kpi.Kpi.IS_BY_SEVERITY)
                        {
                            foreach (var oSeverity_Setup in oList_Severity_Type_Setup)
                            {
                                string Severity_Type = "Severity Type:" + oSeverity_Setup.SETUP_ID.ToString();
                                string CATEGORY = Severity_Type + ",Incident Category Type:0,EXT_STUDY_ZONE_ID:0";
                                List<Site_kpi_data> oList_Site_kpi_data_To_Use = oList_Site_kpi_data.Where(site_kpi_data => oArea.List_Site.Any(site => site.SITE_ID == site_kpi_data.SITE_METADATA.SITE_ID) && site_kpi_data.SITE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID == oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();
                                if (oList_Site_kpi_data_To_Use.Count > 0)
                                {
                                    oList_Area_kpi_data.Add(new Area_kpi_data()
                                    {
                                        AREA_METADATA = new Area_metadata()
                                        {
                                            ORGANIZATION_DATA_SOURCE_KPI_ID = (int)oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                            AREA_ID = (int)oArea.AREA_ID,
                                            CATEGORY = CATEGORY
                                        },
                                        VALUE_NAME = oList_Site_kpi_data_To_Use.First().VALUE_NAME,
                                        RECORD_DATE = oList_Site_kpi_data_To_Use.First().RECORD_DATE,
                                        VALUE_PER_SQM = oList_Site_kpi_data_To_Use.Average(site_kpi_data => site_kpi_data.VALUE_PER_SQM),
                                        VALUE = (oOrganization_data_source_kpi.Kpi.IS_ADDITIVE_DATA ? oList_Site_kpi_data_To_Use.Sum(site_kpi_data => site_kpi_data.VALUE) : oList_Site_kpi_data_To_Use.Average(site_kpi_data => site_kpi_data.VALUE)),
                                    });
                                }
                            }
                        }
                        else
                        {
                            string CATEGORY = "Severity Type:0,Incident Category Type:0,EXT_STUDY_ZONE_ID:0";
                            List<Site_kpi_data> oList_Site_kpi_data_To_Use = oList_Site_kpi_data.Where(site_kpi_data => oArea.List_Site.Any(site => site.SITE_ID == site_kpi_data.SITE_METADATA.SITE_ID) && site_kpi_data.SITE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID == oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();
                            if (oList_Site_kpi_data_To_Use.Count > 0)
                            {
                                oList_Area_kpi_data.Add(new Area_kpi_data()
                                {
                                    AREA_METADATA = new Area_metadata()
                                    {
                                        ORGANIZATION_DATA_SOURCE_KPI_ID = (int)oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                        AREA_ID = (int)oArea.AREA_ID,
                                        CATEGORY = CATEGORY,
                                    },
                                    VALUE_NAME = oList_Site_kpi_data_To_Use.First().VALUE_NAME,
                                    RECORD_DATE = (DateTime)oList_Site_kpi_data_To_Use.First().RECORD_DATE,
                                    VALUE_PER_SQM = oList_Site_kpi_data_To_Use.Average(site_kpi_data => site_kpi_data.VALUE_PER_SQM),
                                    VALUE = (oOrganization_data_source_kpi.Kpi.IS_ADDITIVE_DATA ? oList_Site_kpi_data_To_Use.Sum(site_kpi_data => site_kpi_data.VALUE) : oList_Site_kpi_data_To_Use.Average(site_kpi_data => site_kpi_data.VALUE)),
                                });
                            }
                        }
                    }
                }
            }
            #endregion
            #region send data
            if (oList_Area_kpi_data?.Count > 0)
            {
                try
                {
                    Edit_Area_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN(new Params_Edit_Area_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN()
                    {
                        LIST_AREA_KPI_DATA = oList_Area_kpi_data,
                        LIST_ORGANIZATION_DATA_SOURCE_KPI_ID = i_Params_Compute_Area_Kpi_Data_Hourly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList(),
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
        #region Compute_Area_Kpi_Data_Daily
        public void Compute_Area_Kpi_Data_Daily(Params_Compute_Area_Kpi_Data_Daily i_Params_Compute_Area_Kpi_Data_Daily)
        {
            if (i_Params_Compute_Area_Kpi_Data_Daily != null)
            {
                if (i_Params_Compute_Area_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI != null && i_Params_Compute_Area_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Count() > 0)
                {
                    DateTime CurrentDate = new DateTime(i_Params_Compute_Area_Kpi_Data_Daily.YEAR, i_Params_Compute_Area_Kpi_Data_Daily.MONTH, i_Params_Compute_Area_Kpi_Data_Daily.DAY);
                    DateTime StartDate = CurrentDate.AddDays(-1);
                    List<Organization_data_source_kpi> oList_Organization_data_source_kpi_Trendline = i_Params_Compute_Area_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.IS_TRENDLINE == true).ToList();
                    List<Organization_data_source_kpi> oList_Organization_data_source_kpi_Non_Trendline = i_Params_Compute_Area_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.IS_TRENDLINE == false).ToList();
                    List<int?> List_Organization_data_source_kpi_ID = i_Params_Compute_Area_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();
                    List<Area_kpi_data> oList_Area_kpi_data = Props.Copy_Prop_Values_From_Api_Response<List<Area_kpi_data>>(_MongoDb.Get_Area_Kpi_Data_By_Where(
                        START_DATE: StartDate,
                        END_DATE: CurrentDate,
                        ENUM_TIMESPAN: DALC.Enum_Timespan.X_HOURLY_COLLECTION,
                        ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: List_Organization_data_source_kpi_ID,
                        AREA_ID_LIST: null
                    ));
                    List<Area_kpi_data> oList_Area_kpi_data_To_Save = new List<Area_kpi_data>();

                    if (oList_Area_kpi_data != null && oList_Area_kpi_data.Count > 0)
                    {
                        #region Calculate Trendline Data

                        if (oList_Organization_data_source_kpi_Trendline != null && oList_Organization_data_source_kpi_Trendline.Count > 0)
                        {
                            List<Area_kpi_data> oList_Area_kpi_data_Trendline = oList_Area_kpi_data.Where(oArea_kpi => oList_Organization_data_source_kpi_Trendline.Any(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == oArea_kpi.AREA_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID)).ToList();

                            if (oList_Area_kpi_data_Trendline != null && oList_Area_kpi_data_Trendline.Count > 0)
                            {
                                List<Area_kpi_data> oList_Area_kpi_data_Trendline_To_Save = oList_Area_kpi_data_Trendline
                                                   .GroupBy(area_kpi_data => new
                                                   {
                                                       area_kpi_data.AREA_METADATA.AREA_ID,
                                                       area_kpi_data.AREA_METADATA.CATEGORY,
                                                       area_kpi_data.AREA_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                   })
                                                   .Select(area_kpi_data => new Area_kpi_data()
                                                   {
                                                       AREA_METADATA = new Area_metadata()
                                                       {
                                                           AREA_ID = area_kpi_data.Key.AREA_ID,
                                                           CATEGORY = area_kpi_data.Key.CATEGORY,
                                                           ORGANIZATION_DATA_SOURCE_KPI_ID = area_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                       },
                                                       RECORD_DATE = StartDate,
                                                       VALUE_PER_SQM = i_Params_Compute_Area_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == area_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? area_kpi_data.Average(index => index.VALUE_PER_SQM) : area_kpi_data.Sum(index => index.VALUE_PER_SQM),
                                                       VALUE_NAME = i_Params_Compute_Area_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == area_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? StartDate.ToShortDateString() : area_kpi_data.First().VALUE_NAME,
                                                       VALUE = i_Params_Compute_Area_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == area_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_ADDITIVE_DATA ? area_kpi_data.Sum(index => index.VALUE) : area_kpi_data.Average(index => index.VALUE),
                                                   }).ToList();

                                oList_Area_kpi_data_To_Save = oList_Area_kpi_data_To_Save.Concat(oList_Area_kpi_data_Trendline_To_Save).ToList();
                            }
                        }

                        #endregion

                        #region Calculate Non Trendline Data

                        if (oList_Organization_data_source_kpi_Non_Trendline != null && oList_Organization_data_source_kpi_Non_Trendline.Count > 0)
                        {
                            List<Area_kpi_data> oList_Area_kpi_data_Non_Trendline = oList_Area_kpi_data.Where(oArea_kpi => oList_Organization_data_source_kpi_Non_Trendline.Any(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == oArea_kpi.AREA_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID)).ToList();

                            if (oList_Area_kpi_data_Non_Trendline != null && oList_Area_kpi_data_Non_Trendline.Count > 0)
                            {
                                List<Area_kpi_data> oList_Area_kpi_data_Non_Trendline_To_Save = oList_Area_kpi_data_Non_Trendline
                                                   .GroupBy(area_kpi_data => new
                                                   {
                                                       area_kpi_data.AREA_METADATA.AREA_ID,
                                                       area_kpi_data.AREA_METADATA.CATEGORY,
                                                       area_kpi_data.AREA_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                       area_kpi_data.VALUE_NAME
                                                   })
                                                   .Select(area_kpi_data => new Area_kpi_data()
                                                   {
                                                       AREA_METADATA = new Area_metadata()
                                                       {
                                                           AREA_ID = area_kpi_data.Key.AREA_ID,
                                                           CATEGORY = area_kpi_data.Key.CATEGORY,
                                                           ORGANIZATION_DATA_SOURCE_KPI_ID = area_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                       },
                                                       RECORD_DATE = StartDate,
                                                       VALUE_PER_SQM = i_Params_Compute_Area_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == area_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? area_kpi_data.Average(index => index.VALUE_PER_SQM) : area_kpi_data.Sum(index => index.VALUE_PER_SQM),
                                                       VALUE_NAME = i_Params_Compute_Area_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == area_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? StartDate.ToShortDateString() : area_kpi_data.First().VALUE_NAME,
                                                       VALUE = i_Params_Compute_Area_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == area_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_ADDITIVE_DATA ? area_kpi_data.Sum(index => index.VALUE) : area_kpi_data.Average(index => index.VALUE),
                                                   }).ToList();

                                oList_Area_kpi_data_To_Save = oList_Area_kpi_data_To_Save.Concat(oList_Area_kpi_data_Non_Trendline_To_Save).ToList();
                            }
                        }

                        #endregion

                        if (oList_Area_kpi_data_To_Save?.Count > 0)
                        {
                            try
                            {
                                Edit_Area_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN(new Params_Edit_Area_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN()
                                {
                                    LIST_AREA_KPI_DATA = oList_Area_kpi_data_To_Save,
                                    LIST_ORGANIZATION_DATA_SOURCE_KPI_ID = i_Params_Compute_Area_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList(),
                                    RECORD_DATE = StartDate,
                                    ENUM_TIMESPAN = Enum_Timespan.X_DAILY_COLLECTION
                                });
                            }
                            catch (Exception ex)
                            {
                                throw new BLC_Exception(ex.Message);
                            }

                            #region Calculate & Save Alerts

                            Task.Run(() =>
                            {
                                DateTime currentDate = new DateTime(i_Params_Compute_Area_Kpi_Data_Daily.YEAR, i_Params_Compute_Area_Kpi_Data_Daily.MONTH, i_Params_Compute_Area_Kpi_Data_Daily.DAY);
                                if (currentDate.DayOfWeek == DayOfWeek.Monday)
                                {
                                    #region Declaration & Initialization

                                    long? Area_Setup_ID = 0;
                                    List<Area> oList_Area = new List<Area>();
                                    List<Alert> oList_Alert = new List<Alert>();
                                    List<Alert_settings> oList_Alert_settings = new List<Alert_settings>();
                                    List<Level_id_with_percent> oList_Level_id_with_percent = new List<Level_id_with_percent>();

                                    #endregion

                                    #region Get Area Setup

                                    var get_site_setup = Task.Run(() =>
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

                                    #region Get Area List

                                    var get_area_list = Task.Run(() =>
                                    {
                                        oList_Area = Get_Area_By_OWNER_ID(new Params_Get_Area_By_OWNER_ID()
                                        {
                                            OWNER_ID = this.oBLC_Initializer.Owner_ID
                                        });
                                    });

                                    #endregion

                                    #region Get Alert_Settings

                                    var get_alert_settings = Task.Run(() =>
                                    {
                                        oList_Alert_settings = Props.Copy_Prop_Values_From_Api_Response<List<Alert_settings>>(
                                        this._service_mesh.Get_Alert_settings_By_OWNER_ID_Adv(new Service_Mesh.Params_Get_Alert_settings_By_OWNER_ID()
                                        {
                                            OWNER_ID = this.oBLC_Initializer.Owner_ID
                                        }).i_Result
                                    );
                                    });

                                    #endregion

                                    Task.WaitAll(get_site_setup, get_area_list, get_alert_settings);

                                    #region Get Area_kpi_data

                                    List<Organization_data_source_kpi> oList_Organization_data_source_kpi_with_alerts = i_Params_Compute_Area_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.HAS_ALERTS).ToList();

                                    List<Area_kpi_data> oList_Old_Area_kpi_data = Get_Area_Kpi_Data_By_Where(new Params_Get_Area_Kpi_Data_By_Where()
                                    {
                                        END_DATE = currentDate,
                                        START_DATE = currentDate.AddDays(-7),
                                        ENUM_TIMESPAN = Enum_Timespan.X_DAILY_COLLECTION,
                                        AREA_ID_LIST = oList_Area.Select(oArea => oArea.AREA_ID).ToList(),
                                        ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = oList_Organization_data_source_kpi_with_alerts.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList()
                                    });

                                    List<Area_kpi_data> oList_Area_kpi_data_with_alerts = oList_Area_kpi_data_To_Save.Where(oArea_kpi_data => oList_Organization_data_source_kpi_with_alerts.Any(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == oArea_kpi_data.AREA_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID)).ToList();

                                    #endregion

                                    #region Fill Data

                                    oList_Organization_data_source_kpi_with_alerts.ForEach(oOrganization_data_source_kpi =>
                                    {
                                        oList_Area_kpi_data_with_alerts.Where(oArea_kpi_data => oArea_kpi_data.AREA_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID == oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList().ForEach(oArea_kpi_data =>
                                        {
                                            Area_kpi_data oOld_Area_kpi_data = oList_Old_Area_kpi_data.Find(oArea_kpi_data => oArea_kpi_data.AREA_METADATA.AREA_ID == oArea_kpi_data.AREA_METADATA.AREA_ID);
                                            if (oArea_kpi_data.VALUE == 0 && oOld_Area_kpi_data.VALUE == 0)
                                            {
                                                oList_Level_id_with_percent.Add(new Level_id_with_percent()
                                                {
                                                    VALUE = oArea_kpi_data.VALUE,
                                                    LEVEL_ID = oArea_kpi_data.AREA_METADATA.AREA_ID,
                                                    Area = oList_Area.Find(site => site.AREA_ID == oArea_kpi_data.AREA_METADATA.AREA_ID),
                                                    PERCENT_INCREASE = 0,
                                                });
                                            }
                                            else
                                            {
                                                oList_Level_id_with_percent.Add(new Level_id_with_percent()
                                                {
                                                    VALUE = oArea_kpi_data.VALUE,
                                                    LEVEL_ID = oArea_kpi_data.AREA_METADATA.AREA_ID,
                                                    Area = oList_Area.Find(site => site.AREA_ID == oArea_kpi_data.AREA_METADATA.AREA_ID),
                                                    PERCENT_INCREASE = Math.Round((oOld_Area_kpi_data.VALUE == 0 ? 100 : ((oArea_kpi_data.VALUE - oOld_Area_kpi_data.VALUE) / oOld_Area_kpi_data.VALUE) * 100), 2),
                                                });
                                            }
                                        });
                                        oList_Alert_settings.ForEach(alert_settings =>
                                        {
                                            oList_Level_id_with_percent.ForEach(level_id_with_percent_increase =>
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
                                                    Alert oAlert = new Alert();
                                                    oAlert.USER_ID = alert_settings.USER_ID;
                                                    oAlert.LEVEL_ID = level_id_with_percent_increase.LEVEL_ID;
                                                    oAlert.ORGANIZATION_DATA_SOURCE_KPI_ID = oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID;
                                                    oAlert.LEVEL_SETUP_ID = Area_Setup_ID;
                                                    oAlert.RECORD_DATE = currentDate;
                                                    oAlert.IS_ACKNOWLEDGED = false;
                                                    oAlert.ALERT_VALUE = Math.Abs(level_id_with_percent_increase.PERCENT_INCREASE.Value);
                                                    oAlert.VALUE_PASSED = alert_settings.VALUE;
                                                    oAlert.VALUE_TYPE_SETUP_ID = alert_settings.Value_type_setup.SETUP_ID;
                                                    oAlert.OPERATION_TYPE_SETUP_ID = alert_settings.Operation_setup.SETUP_ID;
                                                    oList_Alert.Add(oAlert);
                                                }
                                            });
                                        });
                                    });

                                    #endregion

                                    #region Edit Alert List

                                    Edit_Alert_List(new Params_Edit_Alert_List()
                                    {
                                        List_Alert = Props.Copy_Prop_Values_From_Api_Response<List<Alert>>(oList_Alert),
                                    });

                                    #endregion
                                }
                            });

                            #endregion

                        }
                    }
                }
            }
        }
        #endregion
        #region Compute_Area_Kpi_Data_Weekly
        public void Compute_Area_Kpi_Data_Weekly(Params_Compute_Area_Kpi_Data_Weekly i_Params_Compute_Area_Kpi_Data_Weekly)
        {
            if (i_Params_Compute_Area_Kpi_Data_Weekly != null)
            {
                if (i_Params_Compute_Area_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI != null && i_Params_Compute_Area_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Count() > 0)
                {
                    DateTime CurrentDate = new DateTime(i_Params_Compute_Area_Kpi_Data_Weekly.YEAR, i_Params_Compute_Area_Kpi_Data_Weekly.MONTH, i_Params_Compute_Area_Kpi_Data_Weekly.DAY);
                    DateTime StartDate = CurrentDate.AddDays(-7);
                    List<Organization_data_source_kpi> oList_Organization_data_source_kpi_Trendline = i_Params_Compute_Area_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.IS_TRENDLINE == true).ToList();
                    List<Organization_data_source_kpi> oList_Organization_data_source_kpi_Non_Trendline = i_Params_Compute_Area_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.IS_TRENDLINE == false).ToList();
                    List<int?> List_Organization_data_source_kpi_ID = i_Params_Compute_Area_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();
                    List<Area_kpi_data> oList_Area_kpi_data = Props.Copy_Prop_Values_From_Api_Response<List<Area_kpi_data>>(_MongoDb.Get_Area_Kpi_Data_By_Where(
                        START_DATE: StartDate,
                        END_DATE: CurrentDate,
                        ENUM_TIMESPAN: DALC.Enum_Timespan.X_DAILY_COLLECTION,
                        ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: List_Organization_data_source_kpi_ID,
                        AREA_ID_LIST: null
                    ));
                    List<Area_kpi_data> oList_Area_kpi_data_To_Save = new List<Area_kpi_data>();

                    if (oList_Area_kpi_data != null && oList_Area_kpi_data.Count > 0)
                    {
                        #region Calculate Trendline Data

                        if (oList_Organization_data_source_kpi_Trendline != null && oList_Organization_data_source_kpi_Trendline.Count > 0)
                        {
                            List<Area_kpi_data> oList_Area_kpi_data_Trendline = oList_Area_kpi_data.Where(oArea_kpi => oList_Organization_data_source_kpi_Trendline.Any(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == oArea_kpi.AREA_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID)).ToList();

                            if (oList_Area_kpi_data_Trendline != null && oList_Area_kpi_data_Trendline.Count > 0)
                            {
                                List<Area_kpi_data> oList_Area_kpi_data_Trendline_To_Save = oList_Area_kpi_data_Trendline
                                                   .GroupBy(area_kpi_data => new
                                                   {
                                                       area_kpi_data.AREA_METADATA.AREA_ID,
                                                       area_kpi_data.AREA_METADATA.CATEGORY,
                                                       area_kpi_data.AREA_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                   })
                                                   .Select(area_kpi_data => new Area_kpi_data()
                                                   {
                                                       AREA_METADATA = new Area_metadata()
                                                       {
                                                           AREA_ID = area_kpi_data.Key.AREA_ID,
                                                           CATEGORY = area_kpi_data.Key.CATEGORY,
                                                           ORGANIZATION_DATA_SOURCE_KPI_ID = area_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                       },
                                                       RECORD_DATE = StartDate,
                                                       VALUE_PER_SQM = i_Params_Compute_Area_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == area_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? area_kpi_data.Average(index => index.VALUE_PER_SQM) : area_kpi_data.Sum(index => index.VALUE_PER_SQM),
                                                       VALUE_NAME = i_Params_Compute_Area_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == area_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? i_Params_Compute_Area_Kpi_Data_Weekly.YEAR + " Week " + Get_Week_Of_Year(new Params_Get_Week_Of_Year()
                                                       {
                                                           DAY = StartDate.Day,
                                                           YEAR = StartDate.Year,
                                                           MONTH = StartDate.Month,
                                                       }) : area_kpi_data.First().VALUE_NAME,
                                                       VALUE = i_Params_Compute_Area_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == area_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_ADDITIVE_DATA ? area_kpi_data.Sum(index => index.VALUE) : area_kpi_data.Average(index => index.VALUE),
                                                   }).ToList();
                                oList_Area_kpi_data_To_Save = oList_Area_kpi_data_To_Save.Concat(oList_Area_kpi_data_Trendline_To_Save).ToList();
                            }
                        }

                        #endregion

                        #region Calculate Non Trendline Data

                        if (oList_Organization_data_source_kpi_Non_Trendline != null && oList_Organization_data_source_kpi_Non_Trendline.Count > 0)
                        {
                            List<Area_kpi_data> oList_Area_kpi_data_Non_Trendline = oList_Area_kpi_data.Where(oArea_kpi => oList_Organization_data_source_kpi_Non_Trendline.Any(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == oArea_kpi.AREA_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID)).ToList();

                            if (oList_Area_kpi_data_Non_Trendline != null && oList_Area_kpi_data_Non_Trendline.Count > 0)
                            {
                                List<Area_kpi_data> oList_Area_kpi_data_Non_Trendline_To_Save = oList_Area_kpi_data_Non_Trendline
                                                   .GroupBy(area_kpi_data => new
                                                   {
                                                       area_kpi_data.AREA_METADATA.AREA_ID,
                                                       area_kpi_data.AREA_METADATA.CATEGORY,
                                                       area_kpi_data.AREA_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                       area_kpi_data.VALUE_NAME
                                                   })
                                                   .Select(area_kpi_data => new Area_kpi_data()
                                                   {
                                                       AREA_METADATA = new Area_metadata()
                                                       {
                                                           AREA_ID = area_kpi_data.Key.AREA_ID,
                                                           CATEGORY = area_kpi_data.Key.CATEGORY,
                                                           ORGANIZATION_DATA_SOURCE_KPI_ID = area_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                       },
                                                       RECORD_DATE = StartDate,
                                                       VALUE_PER_SQM = i_Params_Compute_Area_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == area_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? area_kpi_data.Average(index => index.VALUE_PER_SQM) : area_kpi_data.Sum(index => index.VALUE_PER_SQM),
                                                       VALUE_NAME = i_Params_Compute_Area_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == area_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? i_Params_Compute_Area_Kpi_Data_Weekly.YEAR + " Week " + Get_Week_Of_Year(new Params_Get_Week_Of_Year()
                                                       {
                                                           DAY = StartDate.Day,
                                                           YEAR = StartDate.Year,
                                                           MONTH = StartDate.Month,
                                                       }) : area_kpi_data.First().VALUE_NAME,
                                                       VALUE = i_Params_Compute_Area_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == area_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_ADDITIVE_DATA ? area_kpi_data.Sum(index => index.VALUE) : area_kpi_data.Average(index => index.VALUE),
                                                   }).ToList();

                                oList_Area_kpi_data_To_Save = oList_Area_kpi_data_To_Save.Concat(oList_Area_kpi_data_Non_Trendline_To_Save).ToList();
                            }
                        }

                        #endregion

                        if (oList_Area_kpi_data_To_Save?.Count > 0)
                        {
                            try
                            {
                                Edit_Area_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN(new Params_Edit_Area_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN()
                                {
                                    LIST_AREA_KPI_DATA = oList_Area_kpi_data_To_Save,
                                    LIST_ORGANIZATION_DATA_SOURCE_KPI_ID = i_Params_Compute_Area_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList(),
                                    RECORD_DATE = StartDate,
                                    ENUM_TIMESPAN = Enum_Timespan.X_WEEKLY_COLLECTION
                                });
                            }
                            catch (Exception ex)
                            {
                                throw new BLC_Exception(ex.Message);
                            }
                        }
                    }
                }
            }
        }
        #endregion
        #region Compute_Area_Kpi_Data_Monthly
        public void Compute_Area_Kpi_Data_Monthly(Params_Compute_Area_Kpi_Data_Monthly i_Params_Compute_Area_Kpi_Data_Monthly)
        {
            if (i_Params_Compute_Area_Kpi_Data_Monthly != null)
            {
                if (i_Params_Compute_Area_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI != null && i_Params_Compute_Area_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Count() > 0)
                {
                    DateTime CurrentDate = new DateTime(i_Params_Compute_Area_Kpi_Data_Monthly.YEAR, i_Params_Compute_Area_Kpi_Data_Monthly.MONTH, 1);
                    DateTime StartDate = CurrentDate.AddMonths(-1);
                    List<Organization_data_source_kpi> oList_Organization_data_source_kpi_Trendline = i_Params_Compute_Area_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.IS_TRENDLINE == true).ToList();
                    List<Organization_data_source_kpi> oList_Organization_data_source_kpi_Non_Trendline = i_Params_Compute_Area_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.IS_TRENDLINE == false).ToList();
                    List<int?> List_Organization_data_source_kpi_ID = i_Params_Compute_Area_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();
                    List<Area_kpi_data> oList_Area_kpi_data = Props.Copy_Prop_Values_From_Api_Response<List<Area_kpi_data>>(_MongoDb.Get_Area_Kpi_Data_By_Where(
                        START_DATE: StartDate,
                        END_DATE: CurrentDate,
                        ENUM_TIMESPAN: DALC.Enum_Timespan.X_DAILY_COLLECTION,
                        ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: List_Organization_data_source_kpi_ID,
                        AREA_ID_LIST: null
                    ));
                    List<Area_kpi_data> oList_Area_kpi_data_To_Save = new List<Area_kpi_data>();

                    if (oList_Area_kpi_data != null && oList_Area_kpi_data.Count > 0)
                    {
                        #region Calculate Trendline Data

                        if (oList_Organization_data_source_kpi_Trendline != null && oList_Organization_data_source_kpi_Trendline.Count > 0)
                        {
                            List<Area_kpi_data> oList_Area_kpi_data_Trendline = oList_Area_kpi_data.Where(oArea_kpi => oList_Organization_data_source_kpi_Trendline.Any(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == oArea_kpi.AREA_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID)).ToList();

                            if (oList_Area_kpi_data_Trendline != null && oList_Area_kpi_data_Trendline.Count > 0)
                            {
                                List<Area_kpi_data> oList_Area_kpi_data_Trendline_To_Save = oList_Area_kpi_data_Trendline
                                                   .GroupBy(area_kpi_data => new
                                                   {
                                                       area_kpi_data.AREA_METADATA.AREA_ID,
                                                       area_kpi_data.AREA_METADATA.CATEGORY,
                                                       area_kpi_data.AREA_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                   })
                                                   .Select(area_kpi_data => new Area_kpi_data()
                                                   {
                                                       AREA_METADATA = new Area_metadata()
                                                       {
                                                           AREA_ID = area_kpi_data.Key.AREA_ID,
                                                           CATEGORY = area_kpi_data.Key.CATEGORY,
                                                           ORGANIZATION_DATA_SOURCE_KPI_ID = area_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                       },
                                                       RECORD_DATE = StartDate,
                                                       VALUE_PER_SQM = i_Params_Compute_Area_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == area_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? area_kpi_data.Average(index => index.VALUE_PER_SQM) : area_kpi_data.Sum(index => index.VALUE_PER_SQM),
                                                       VALUE_NAME = i_Params_Compute_Area_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == area_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? StartDate.Month + "/" + StartDate.Year : area_kpi_data.First().VALUE_NAME,
                                                       VALUE = i_Params_Compute_Area_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == area_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_ADDITIVE_DATA ? area_kpi_data.Sum(index => index.VALUE) : area_kpi_data.Average(index => index.VALUE),
                                                   }).ToList();
                                oList_Area_kpi_data_To_Save = oList_Area_kpi_data_To_Save.Concat(oList_Area_kpi_data_Trendline_To_Save).ToList();
                            }
                        }

                        #endregion

                        #region Calculate Non Trendline Data

                        if (oList_Organization_data_source_kpi_Non_Trendline != null && oList_Organization_data_source_kpi_Non_Trendline.Count > 0)
                        {
                            List<Area_kpi_data> oList_Area_kpi_data_Non_Trendline = oList_Area_kpi_data.Where(oArea_kpi => oList_Organization_data_source_kpi_Non_Trendline.Any(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == oArea_kpi.AREA_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID)).ToList();

                            if (oList_Area_kpi_data_Non_Trendline != null && oList_Area_kpi_data_Non_Trendline.Count > 0)
                            {
                                List<Area_kpi_data> oList_Area_kpi_data_Non_Trendline_To_Save = oList_Area_kpi_data_Non_Trendline
                                                   .GroupBy(area_kpi_data => new
                                                   {
                                                       area_kpi_data.AREA_METADATA.AREA_ID,
                                                       area_kpi_data.AREA_METADATA.CATEGORY,
                                                       area_kpi_data.AREA_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                       area_kpi_data.VALUE_NAME
                                                   })
                                                   .Select(area_kpi_data => new Area_kpi_data()
                                                   {
                                                       AREA_METADATA = new Area_metadata()
                                                       {
                                                           AREA_ID = area_kpi_data.Key.AREA_ID,
                                                           CATEGORY = area_kpi_data.Key.CATEGORY,
                                                           ORGANIZATION_DATA_SOURCE_KPI_ID = area_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                       },
                                                       RECORD_DATE = StartDate,
                                                       VALUE_PER_SQM = i_Params_Compute_Area_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == area_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? area_kpi_data.Average(index => index.VALUE_PER_SQM) : area_kpi_data.Sum(index => index.VALUE_PER_SQM),
                                                       VALUE_NAME = i_Params_Compute_Area_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == area_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? StartDate.Month + "/" + StartDate.Year : area_kpi_data.First().VALUE_NAME,
                                                       VALUE = i_Params_Compute_Area_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == area_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_ADDITIVE_DATA ? area_kpi_data.Sum(index => index.VALUE) : area_kpi_data.Average(index => index.VALUE),
                                                   }).ToList();

                                oList_Area_kpi_data_To_Save = oList_Area_kpi_data_To_Save.Concat(oList_Area_kpi_data_Non_Trendline_To_Save).ToList();
                            }
                        }

                        #endregion

                        if (oList_Area_kpi_data_To_Save?.Count > 0)
                        {
                            try
                            {
                                Edit_Area_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN(new Params_Edit_Area_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN()
                                {
                                    LIST_AREA_KPI_DATA = oList_Area_kpi_data_To_Save,
                                    LIST_ORGANIZATION_DATA_SOURCE_KPI_ID = i_Params_Compute_Area_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList(),
                                    RECORD_DATE = StartDate,
                                    ENUM_TIMESPAN = Enum_Timespan.X_MONTHLY_COLLECTION
                                });
                            }
                            catch (Exception ex)
                            {
                                throw new BLC_Exception(ex.Message);
                            }
                        }
                    }
                }
            }
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
        public void Delete_Area_Kpi_Data_By_Where(Params_Delete_Area_Kpi_Data_By_Where i_Params_Delete_Area_Kpi_Data_By_Where)
        {
            if (i_Params_Delete_Area_Kpi_Data_By_Where != null)
            {
                this._MongoDb.Delete_Area_Kpi_Data_By_Where(i_Params_Delete_Area_Kpi_Data_By_Where.AREA_ID_LIST, i_Params_Delete_Area_Kpi_Data_By_Where.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, (DALC.Enum_Timespan)i_Params_Delete_Area_Kpi_Data_By_Where.ENUM_TIMESPAN);
            }
        }
        #endregion
        #endregion
        #region Site
        #region Compute_Site_Kpi_Data_Hourly
        public void Compute_Site_Kpi_Data_Hourly(Params_Compute_Site_Kpi_Data_Hourly i_Params_Compute_Site_Kpi_Data_Hourly)
        {
            #region setup
            DateTime CurrentDate = new DateTime(i_Params_Compute_Site_Kpi_Data_Hourly.YEAR, i_Params_Compute_Site_Kpi_Data_Hourly.MONTH, i_Params_Compute_Site_Kpi_Data_Hourly.DAY, i_Params_Compute_Site_Kpi_Data_Hourly.HOUR, 0, 0);

            List<Site> oList_Site = new List<Site>();
            List<Entity> oList_Entity = new List<Entity>();
            List<Entity_kpi_data> oList_Entity_kpi_data = new List<Entity_kpi_data>();

            List<Setup_category> oList_Setup_category = Get_Setup_category_By_OWNER_ID(new Params_Get_Setup_category_By_OWNER_ID()
            {
                OWNER_ID = this.oBLC_Initializer.Owner_ID
            });
            List<Setup> oList_Severity_Type_Setup = oList_Setup_category.First(oSetup_category => oSetup_category.SETUP_CATEGORY_NAME == "Severity Type").List_Setup;

            var get_entity_kpi_data = Task.Run(() =>
            {
                oList_Entity_kpi_data = Props.Copy_Prop_Values_From_Api_Response<List<Entity_kpi_data>>(_MongoDb.Get_Entity_Kpi_Data_By_Where(
                    START_DATE: CurrentDate,
                    END_DATE: CurrentDate.AddSeconds(1),
                    ENUM_TIMESPAN: DALC.Enum_Timespan.X_HOURLY_COLLECTION,
                    ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: i_Params_Compute_Site_Kpi_Data_Hourly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList(),
                    ENTITY_ID_LIST: null
                ));
            });
            var get_sites = Task.Run(() =>
            {
                oList_Site = Get_Site_By_OWNER_ID(new Params_Get_Site_By_OWNER_ID()
                {
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                });
            });
            var get_entities = Task.Run(() =>
            {
                oList_Entity = this.Get_Entity_By_OWNER_ID(new Params_Get_Entity_By_OWNER_ID()
                {
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                });
            });
            Task.WaitAll(get_entity_kpi_data, get_sites, get_entities);

            oList_Site = oList_Site.Select(site =>
            {
                site.List_Entity = oList_Entity.Where(entity => entity.SITE_ID == site.SITE_ID).ToList();
                return site;
            }).ToList();

            List<Site_kpi_data> oList_Site_kpi_data = new List<Site_kpi_data>();
            #endregion
            #region fill list
            i_Params_Compute_Site_Kpi_Data_Hourly.LIST_ORGANIZATION_DATA_SOURCE_KPI.ForEach(oOrganization_data_source_kpi =>
            {
                if (oOrganization_data_source_kpi.Kpi.SETUP_CATEGORY_ID != null)
                {
                    oOrganization_data_source_kpi.Kpi.Setup_category = oList_Setup_category.Find(setup_category => setup_category.SETUP_CATEGORY_ID == oOrganization_data_source_kpi.Kpi.SETUP_CATEGORY_ID);
                    oList_Site.ForEach(site =>
                    {
                        List<Entity_kpi_data> oList_Entity_kpi_data_To_Use = oList_Entity_kpi_data.Where(entity_kpi_data => site.List_Entity.Any(entity => entity.ENTITY_ID == entity_kpi_data.ENTITY_METADATA.ENTITY_ID) && entity_kpi_data.ENTITY_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID == oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();
                        oOrganization_data_source_kpi.Kpi.Setup_category.List_Setup.ForEach(setup =>
                        {
                            if (oOrganization_data_source_kpi.Kpi.IS_BY_SEVERITY)
                            {
                                oList_Severity_Type_Setup.ForEach(severity =>
                                {
                                    string Severity_Type = "Severity Type:" + severity.SETUP_ID.ToString();
                                    string Incident_Category_Type = "Incident Category Type:" + setup.SETUP_ID.ToString();
                                    string CATEGORY = Severity_Type + "," + Incident_Category_Type + ",EXT_STUDY_ZONE_ID:0";
                                    List<Entity_kpi_data> oList_Entity_kpi_data_To_Use2 = oList_Entity_kpi_data_To_Use.Where(entity_kpi_data => entity_kpi_data.ENTITY_METADATA.CATEGORY == CATEGORY).ToList();
                                    if (oList_Entity_kpi_data_To_Use2.Count > 0)
                                    {
                                        oList_Site_kpi_data.Add(new Site_kpi_data()
                                        {
                                            SITE_METADATA = new Site_metadata()
                                            {
                                                ORGANIZATION_DATA_SOURCE_KPI_ID = (int)oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                SITE_ID = (int)site.SITE_ID,
                                                CATEGORY = CATEGORY
                                            },
                                            VALUE_NAME = oList_Entity_kpi_data_To_Use2.First().VALUE_NAME,
                                            RECORD_DATE = oList_Entity_kpi_data_To_Use2.First().RECORD_DATE,
                                            VALUE_PER_SQM = oList_Entity_kpi_data_To_Use2.Sum(entity_kpi_data => entity_kpi_data.VALUE_PER_SQM),
                                            VALUE = (oOrganization_data_source_kpi.Kpi.IS_ADDITIVE_DATA ? oList_Entity_kpi_data_To_Use2.Sum(entity_kpi_data => entity_kpi_data.VALUE) : oList_Entity_kpi_data_To_Use2.Average(entity_kpi_data => entity_kpi_data.VALUE)),
                                        });
                                    }
                                    else
                                    {
                                        decimal randomValue = (decimal)(oOrganization_data_source_kpi.Kpi.IS_DECIMAL_VALUE ? Tools.Get_Random_Decimal() * (oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE - oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE) + oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE : Tools.Get_Random_Number((int)oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE, (int)oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE + 1));
                                        oList_Site_kpi_data.Add(new Site_kpi_data()
                                        {
                                            VALUE = randomValue,
                                            VALUE_PER_SQM = randomValue / site.AREA,
                                            RECORD_DATE = new DateTime(i_Params_Compute_Site_Kpi_Data_Hourly.YEAR, i_Params_Compute_Site_Kpi_Data_Hourly.MONTH, i_Params_Compute_Site_Kpi_Data_Hourly.DAY, i_Params_Compute_Site_Kpi_Data_Hourly.HOUR, 0, 0),
                                            VALUE_NAME = oOrganization_data_source_kpi.Kpi.IS_TRENDLINE ? new DateTime(i_Params_Compute_Site_Kpi_Data_Hourly.YEAR, i_Params_Compute_Site_Kpi_Data_Hourly.MONTH, i_Params_Compute_Site_Kpi_Data_Hourly.DAY, i_Params_Compute_Site_Kpi_Data_Hourly.HOUR, 0, 0).ToString() : setup.VALUE,
                                            SITE_METADATA = new Site_metadata()
                                            {
                                                ORGANIZATION_DATA_SOURCE_KPI_ID = (int)oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                SITE_ID = (int)site.SITE_ID,
                                                CATEGORY = CATEGORY
                                            },
                                        });
                                    }
                                });
                            }
                            else
                            {
                                string Incident_Category_Type = "Incident Category Type:" + setup.SETUP_ID.ToString();
                                string CATEGORY = "Severity Type:0," + Incident_Category_Type + ",EXT_STUDY_ZONE_ID:0";
                                List<Entity_kpi_data> oList_Entity_kpi_data_To_Use2 = oList_Entity_kpi_data_To_Use.Where(entity_kpi_data => entity_kpi_data.ENTITY_METADATA.CATEGORY == CATEGORY).ToList();
                                if (oList_Entity_kpi_data_To_Use2.Count > 0)
                                {
                                    oList_Site_kpi_data.Add(new Site_kpi_data()
                                    {
                                        SITE_METADATA = new Site_metadata()
                                        {
                                            ORGANIZATION_DATA_SOURCE_KPI_ID = (int)oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                            SITE_ID = (int)site.SITE_ID,
                                            CATEGORY = CATEGORY
                                        },
                                        VALUE_NAME = oList_Entity_kpi_data_To_Use2.First().VALUE_NAME,
                                        RECORD_DATE = oList_Entity_kpi_data_To_Use2.First().RECORD_DATE,
                                        VALUE_PER_SQM = oList_Entity_kpi_data_To_Use2.Sum(entity_kpi_data => entity_kpi_data.VALUE_PER_SQM),
                                        VALUE = (oOrganization_data_source_kpi.Kpi.IS_ADDITIVE_DATA ? oList_Entity_kpi_data_To_Use2.Sum(entity_kpi_data => entity_kpi_data.VALUE) : oList_Entity_kpi_data_To_Use2.Average(entity_kpi_data => entity_kpi_data.VALUE)),
                                    });
                                }
                                else
                                {
                                    decimal randomValue = (decimal)(oOrganization_data_source_kpi.Kpi.IS_DECIMAL_VALUE ? Tools.Get_Random_Decimal() * (oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE - oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE) + oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE : Tools.Get_Random_Number((int)oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE, (int)oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE + 1));
                                    oList_Site_kpi_data.Add(new Site_kpi_data()
                                    {
                                        VALUE = randomValue,
                                        VALUE_PER_SQM = randomValue / site.AREA,
                                        RECORD_DATE = new DateTime(i_Params_Compute_Site_Kpi_Data_Hourly.YEAR, i_Params_Compute_Site_Kpi_Data_Hourly.MONTH, i_Params_Compute_Site_Kpi_Data_Hourly.DAY, i_Params_Compute_Site_Kpi_Data_Hourly.HOUR, 0, 0),
                                        VALUE_NAME = oOrganization_data_source_kpi.Kpi.IS_TRENDLINE ? new DateTime(i_Params_Compute_Site_Kpi_Data_Hourly.YEAR, i_Params_Compute_Site_Kpi_Data_Hourly.MONTH, i_Params_Compute_Site_Kpi_Data_Hourly.DAY, i_Params_Compute_Site_Kpi_Data_Hourly.HOUR, 0, 0).ToString() : setup.VALUE,
                                        SITE_METADATA = new Site_metadata()
                                        {
                                            ORGANIZATION_DATA_SOURCE_KPI_ID = (int)oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                            SITE_ID = (int)site.SITE_ID,
                                            CATEGORY = CATEGORY
                                        },
                                    });
                                }
                            }
                        });
                    });
                }
                else
                {
                    oList_Site.ForEach(site =>
                    {
                        if (oOrganization_data_source_kpi.Kpi.IS_BY_SEVERITY)
                        {
                            oList_Severity_Type_Setup.ForEach(severity =>
                            {
                                string Severity_Type = "Severity Type:" + severity.SETUP_ID.ToString();
                                string CATEGORY = Severity_Type + ",Incident Category Type:0,EXT_STUDY_ZONE_ID:0";
                                List<Entity_kpi_data> oList_Entity_kpi_data_To_Use = oList_Entity_kpi_data.Where(entity_kpi_data => site.List_Entity.Any(entity => entity.ENTITY_ID == entity_kpi_data.ENTITY_METADATA.ENTITY_ID) && entity_kpi_data.ENTITY_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID == oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID && entity_kpi_data.ENTITY_METADATA.CATEGORY == CATEGORY).ToList();
                                if (oList_Entity_kpi_data_To_Use.Count > 0)
                                {
                                    oList_Site_kpi_data.Add(new Site_kpi_data()
                                    {
                                        SITE_METADATA = new Site_metadata()
                                        {
                                            ORGANIZATION_DATA_SOURCE_KPI_ID = (int)oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                            SITE_ID = (int)site.SITE_ID,
                                            CATEGORY = CATEGORY
                                        },
                                        VALUE_NAME = oList_Entity_kpi_data_To_Use.First().VALUE_NAME,
                                        RECORD_DATE = (DateTime)oList_Entity_kpi_data_To_Use.First().RECORD_DATE,
                                        VALUE_PER_SQM = oList_Entity_kpi_data_To_Use.Average(entity_kpi_data => entity_kpi_data.VALUE_PER_SQM),
                                        VALUE = (oOrganization_data_source_kpi.Kpi.IS_ADDITIVE_DATA ? oList_Entity_kpi_data_To_Use.Sum(entity_kpi_data => entity_kpi_data.VALUE) : oList_Entity_kpi_data_To_Use.Average(entity_kpi_data => entity_kpi_data.VALUE)),
                                    });
                                }
                                else
                                {
                                    decimal randomValue = (decimal)(oOrganization_data_source_kpi.Kpi.IS_DECIMAL_VALUE ? Tools.Get_Random_Decimal() * (oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE - oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE) + oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE : Tools.Get_Random_Number((int)oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE, (int)oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE + 1));
                                    oList_Site_kpi_data.Add(new Site_kpi_data()
                                    {
                                        VALUE = randomValue,
                                        VALUE_PER_SQM = randomValue / site.AREA,
                                        RECORD_DATE = new DateTime(i_Params_Compute_Site_Kpi_Data_Hourly.YEAR, i_Params_Compute_Site_Kpi_Data_Hourly.MONTH, i_Params_Compute_Site_Kpi_Data_Hourly.DAY, i_Params_Compute_Site_Kpi_Data_Hourly.HOUR, 0, 0),
                                        VALUE_NAME = new DateTime(i_Params_Compute_Site_Kpi_Data_Hourly.YEAR, i_Params_Compute_Site_Kpi_Data_Hourly.MONTH, i_Params_Compute_Site_Kpi_Data_Hourly.DAY, i_Params_Compute_Site_Kpi_Data_Hourly.HOUR, 0, 0).ToString(),
                                        SITE_METADATA = new Site_metadata()
                                        {
                                            ORGANIZATION_DATA_SOURCE_KPI_ID = (int)oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                            SITE_ID = (int)site.SITE_ID,
                                            CATEGORY = CATEGORY
                                        },
                                    });
                                }
                            });
                        }
                        else
                        {
                            string CATEGORY = "Severity Type:0,Incident Category Type:0,EXT_STUDY_ZONE_ID:0";
                            List<Entity_kpi_data> oList_Entity_kpi_data_To_Use = oList_Entity_kpi_data.Where(entity_kpi_data => site.List_Entity.Any(entity => entity.ENTITY_ID == entity_kpi_data.ENTITY_METADATA.ENTITY_ID) && entity_kpi_data.ENTITY_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID == oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID && entity_kpi_data.ENTITY_METADATA.CATEGORY == CATEGORY).ToList();
                            if (oList_Entity_kpi_data_To_Use.Count > 0)
                            {
                                oList_Site_kpi_data.Add(new Site_kpi_data()
                                {
                                    SITE_METADATA = new Site_metadata()
                                    {
                                        ORGANIZATION_DATA_SOURCE_KPI_ID = (int)oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                        SITE_ID = (int)site.SITE_ID,
                                        CATEGORY = CATEGORY
                                    },
                                    VALUE_NAME = oList_Entity_kpi_data_To_Use.First().VALUE_NAME,
                                    RECORD_DATE = oList_Entity_kpi_data_To_Use.First().RECORD_DATE,
                                    VALUE_PER_SQM = oList_Entity_kpi_data_To_Use.Average(entity_kpi_data => entity_kpi_data.VALUE_PER_SQM),
                                    VALUE = (oOrganization_data_source_kpi.Kpi.IS_ADDITIVE_DATA ? oList_Entity_kpi_data_To_Use.Sum(entity_kpi_data => entity_kpi_data.VALUE) : oList_Entity_kpi_data_To_Use.Average(entity_kpi_data => entity_kpi_data.VALUE)),
                                });
                            }
                            else
                            {
                                if (oOrganization_data_source_kpi.Kpi.IS_ADDITIVE_DATA)
                                {
                                    decimal randomValue = (decimal)(oOrganization_data_source_kpi.Kpi.IS_DECIMAL_VALUE ? Tools.Get_Random_Decimal() * (oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE - oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE) + oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE : Tools.Get_Random_Number((int)oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE, (int)oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE + 1));
                                    oList_Site_kpi_data.Add(new Site_kpi_data()
                                    {
                                        VALUE = randomValue,
                                        VALUE_PER_SQM = randomValue / site.AREA,
                                        RECORD_DATE = new DateTime(i_Params_Compute_Site_Kpi_Data_Hourly.YEAR, i_Params_Compute_Site_Kpi_Data_Hourly.MONTH, i_Params_Compute_Site_Kpi_Data_Hourly.DAY, i_Params_Compute_Site_Kpi_Data_Hourly.HOUR, 0, 0),
                                        VALUE_NAME = new DateTime(i_Params_Compute_Site_Kpi_Data_Hourly.YEAR, i_Params_Compute_Site_Kpi_Data_Hourly.MONTH, i_Params_Compute_Site_Kpi_Data_Hourly.DAY, i_Params_Compute_Site_Kpi_Data_Hourly.HOUR, 0, 0).ToString(),
                                        SITE_METADATA = new Site_metadata()
                                        {
                                            ORGANIZATION_DATA_SOURCE_KPI_ID = (int)oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                            SITE_ID = (int)site.SITE_ID,
                                            CATEGORY = CATEGORY
                                        },
                                    });
                                }
                            }
                        }
                    });
                }
            });
            #endregion
            #region send data
            if (oList_Site_kpi_data?.Count > 0)
            {
                try
                {
                    Edit_Site_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN(new Params_Edit_Site_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN()
                    {
                        LIST_SITE_KPI_DATA = oList_Site_kpi_data,
                        LIST_ORGANIZATION_DATA_SOURCE_KPI_ID = i_Params_Compute_Site_Kpi_Data_Hourly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList(),
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
        #region Compute_Site_Kpi_Data_Daily
        public void Compute_Site_Kpi_Data_Daily(Params_Compute_Site_Kpi_Data_Daily i_Params_Compute_Site_Kpi_Data_Daily)
        {
            if (i_Params_Compute_Site_Kpi_Data_Daily != null)
            {
                if (i_Params_Compute_Site_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI != null && i_Params_Compute_Site_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Count() > 0)
                {
                    DateTime CurrentDate = new DateTime(i_Params_Compute_Site_Kpi_Data_Daily.YEAR, i_Params_Compute_Site_Kpi_Data_Daily.MONTH, i_Params_Compute_Site_Kpi_Data_Daily.DAY);
                    DateTime StartDate = CurrentDate.AddDays(-1);
                    List<Organization_data_source_kpi> oList_Organization_data_source_kpi_Trendline = i_Params_Compute_Site_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.IS_TRENDLINE == true).ToList();
                    List<Organization_data_source_kpi> oList_Organization_data_source_kpi_Non_Trendline = i_Params_Compute_Site_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.IS_TRENDLINE == false).ToList();
                    List<int?> List_Organization_data_source_kpi_ID = i_Params_Compute_Site_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();
                    List<Site_kpi_data> oList_Site_kpi_data = Props.Copy_Prop_Values_From_Api_Response<List<Site_kpi_data>>(_MongoDb.Get_Site_Kpi_Data_By_Where(
                        START_DATE: StartDate,
                        END_DATE: CurrentDate,
                        ENUM_TIMESPAN: DALC.Enum_Timespan.X_HOURLY_COLLECTION,
                        ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: List_Organization_data_source_kpi_ID,
                        SITE_ID_LIST: null
                    ));
                    List<Site_kpi_data> oList_Site_kpi_data_To_Save = new List<Site_kpi_data>();

                    if (oList_Site_kpi_data != null && oList_Site_kpi_data.Count > 0)
                    {
                        #region Calculate Trendline Data

                        if (oList_Organization_data_source_kpi_Trendline != null && oList_Organization_data_source_kpi_Trendline.Count > 0)
                        {
                            List<Site_kpi_data> oList_Site_kpi_data_Trendline = oList_Site_kpi_data.Where(oSite_kpi => oList_Organization_data_source_kpi_Trendline.Any(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == oSite_kpi.SITE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID)).ToList();

                            if (oList_Site_kpi_data_Trendline != null && oList_Site_kpi_data_Trendline.Count > 0)
                            {
                                List<Site_kpi_data> oList_Site_kpi_data_Trendline_To_Save = oList_Site_kpi_data_Trendline
                                                   .GroupBy(site_kpi_data => new
                                                   {
                                                       site_kpi_data.SITE_METADATA.SITE_ID,
                                                       site_kpi_data.SITE_METADATA.CATEGORY,
                                                       site_kpi_data.SITE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                   })
                                                   .Select(site_kpi_data => new Site_kpi_data()
                                                   {
                                                       SITE_METADATA = new Site_metadata()
                                                       {
                                                           SITE_ID = site_kpi_data.Key.SITE_ID,
                                                           CATEGORY = site_kpi_data.Key.CATEGORY,
                                                           ORGANIZATION_DATA_SOURCE_KPI_ID = site_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                       },
                                                       RECORD_DATE = StartDate,
                                                       VALUE_PER_SQM = i_Params_Compute_Site_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == site_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? site_kpi_data.Average(index => index.VALUE_PER_SQM) : site_kpi_data.Sum(index => index.VALUE_PER_SQM),
                                                       VALUE_NAME = i_Params_Compute_Site_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == site_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? StartDate.ToShortDateString() : site_kpi_data.First().VALUE_NAME,
                                                       VALUE = i_Params_Compute_Site_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == site_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_ADDITIVE_DATA ? site_kpi_data.Sum(index => index.VALUE) : site_kpi_data.Average(index => index.VALUE),
                                                   }).ToList();

                                oList_Site_kpi_data_To_Save = oList_Site_kpi_data_To_Save.Concat(oList_Site_kpi_data_Trendline_To_Save).ToList();
                            }
                        }

                        #endregion

                        #region Calculate Non Trendline Data

                        if (oList_Organization_data_source_kpi_Non_Trendline != null && oList_Organization_data_source_kpi_Non_Trendline.Count > 0)
                        {
                            List<Site_kpi_data> oList_Site_kpi_data_Non_Trendline = oList_Site_kpi_data.Where(oSite_kpi => oList_Organization_data_source_kpi_Non_Trendline.Any(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == oSite_kpi.SITE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID)).ToList();

                            if (oList_Site_kpi_data_Non_Trendline != null && oList_Site_kpi_data_Non_Trendline.Count > 0)
                            {
                                List<Site_kpi_data> oList_Site_kpi_data_Non_Trendline_To_Save = oList_Site_kpi_data_Non_Trendline
                                                   .GroupBy(site_kpi_data => new
                                                   {
                                                       site_kpi_data.SITE_METADATA.SITE_ID,
                                                       site_kpi_data.SITE_METADATA.CATEGORY,
                                                       site_kpi_data.SITE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                       site_kpi_data.VALUE_NAME
                                                   })
                                                   .Select(site_kpi_data => new Site_kpi_data()
                                                   {
                                                       SITE_METADATA = new Site_metadata()
                                                       {
                                                           SITE_ID = site_kpi_data.Key.SITE_ID,
                                                           CATEGORY = site_kpi_data.Key.CATEGORY,
                                                           ORGANIZATION_DATA_SOURCE_KPI_ID = site_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                       },
                                                       RECORD_DATE = StartDate,
                                                       VALUE_PER_SQM = i_Params_Compute_Site_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == site_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? site_kpi_data.Average(index => index.VALUE_PER_SQM) : site_kpi_data.Sum(index => index.VALUE_PER_SQM),
                                                       VALUE_NAME = i_Params_Compute_Site_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == site_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? StartDate.ToShortDateString() : site_kpi_data.First().VALUE_NAME,
                                                       VALUE = i_Params_Compute_Site_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == site_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_ADDITIVE_DATA ? site_kpi_data.Sum(index => index.VALUE) : site_kpi_data.Average(index => index.VALUE),
                                                   }).ToList();

                                oList_Site_kpi_data_To_Save = oList_Site_kpi_data_To_Save.Concat(oList_Site_kpi_data_Non_Trendline_To_Save).ToList();
                            }
                        }

                        #endregion

                        if (oList_Site_kpi_data_To_Save?.Count > 0)
                        {
                            try
                            {
                                Edit_Site_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN(new Params_Edit_Site_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN()
                                {
                                    LIST_SITE_KPI_DATA = oList_Site_kpi_data_To_Save,
                                    LIST_ORGANIZATION_DATA_SOURCE_KPI_ID = i_Params_Compute_Site_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList(),
                                    RECORD_DATE = StartDate,
                                    ENUM_TIMESPAN = Enum_Timespan.X_DAILY_COLLECTION
                                });
                            }
                            catch (Exception ex)
                            {
                                throw new BLC_Exception(ex.Message);
                            }

                            #region Calculate & Save Alerts

                            Task.Run(() =>
                            {
                                DateTime currentDate = new DateTime(i_Params_Compute_Site_Kpi_Data_Daily.YEAR, i_Params_Compute_Site_Kpi_Data_Daily.MONTH, i_Params_Compute_Site_Kpi_Data_Daily.DAY);
                                if (currentDate.DayOfWeek == DayOfWeek.Monday)
                                {
                                    #region Declaration & Initialization

                                    long? Site_Setup_ID = 0;
                                    List<Site> oList_Site = new List<Site>();
                                    List<Alert> oList_Alert = new List<Alert>();
                                    List<Alert_settings> oList_Alert_settings = new List<Alert_settings>();
                                    List<Level_id_with_percent> oList_Level_id_with_percent = new List<Level_id_with_percent>();

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

                                    #region Get Site List

                                    var get_site_list = Task.Run(() =>
                                    {
                                        oList_Site = Get_Site_By_OWNER_ID(new Params_Get_Site_By_OWNER_ID()
                                        {
                                            OWNER_ID = this.oBLC_Initializer.Owner_ID
                                        });
                                    });

                                    #endregion

                                    #region Get Alert_Settings

                                    var get_alert_settings = Task.Run(() =>
                                    {
                                        oList_Alert_settings = Props.Copy_Prop_Values_From_Api_Response<List<Alert_settings>>(
                                        this._service_mesh.Get_Alert_settings_By_OWNER_ID_Adv(new Service_Mesh.Params_Get_Alert_settings_By_OWNER_ID()
                                        {
                                            OWNER_ID = this.oBLC_Initializer.Owner_ID
                                        }).i_Result
                                    );
                                    });

                                    #endregion

                                    Task.WaitAll(get_site_setup, get_site_list, get_alert_settings);

                                    #region Get Site_kpi_data

                                    List<Organization_data_source_kpi> oList_Organization_data_source_kpi_with_alerts = i_Params_Compute_Site_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.HAS_ALERTS).ToList();

                                    List<Site_kpi_data> oList_Old_Site_kpi_data = Get_Site_Kpi_Data_By_Where(new Params_Get_Site_Kpi_Data_By_Where()
                                    {
                                        END_DATE = currentDate,
                                        START_DATE = currentDate.AddDays(-7),
                                        ENUM_TIMESPAN = Enum_Timespan.X_DAILY_COLLECTION,
                                        SITE_ID_LIST = oList_Site.Select(oSite => oSite.SITE_ID).ToList(),
                                        ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = oList_Organization_data_source_kpi_with_alerts.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList()
                                    });

                                    List<Site_kpi_data> oList_Site_kpi_data_with_alerts = oList_Site_kpi_data_To_Save.Where(oSite_kpi_data => oList_Organization_data_source_kpi_with_alerts.Any(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == oSite_kpi_data.SITE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID)).ToList();

                                    #endregion

                                    #region Fill Data

                                    oList_Organization_data_source_kpi_with_alerts.ForEach(oOrganization_data_source_kpi =>
                                    {
                                        oList_Site_kpi_data_with_alerts.Where(oSite_kpi_data => oSite_kpi_data.SITE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID == oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList().ForEach(oSite_kpi_data =>
                                        {
                                            Site_kpi_data oOld_Site_kpi_data = oList_Old_Site_kpi_data.Find(oSite_kpi_data => oSite_kpi_data.SITE_METADATA.SITE_ID == oSite_kpi_data.SITE_METADATA.SITE_ID);
                                            if (oSite_kpi_data.VALUE == 0 && oOld_Site_kpi_data.VALUE == 0)
                                            {
                                                oList_Level_id_with_percent.Add(new Level_id_with_percent()
                                                {
                                                    VALUE = oSite_kpi_data.VALUE,
                                                    LEVEL_ID = oSite_kpi_data.SITE_METADATA.SITE_ID,
                                                    Site = oList_Site.Find(site => site.SITE_ID == oSite_kpi_data.SITE_METADATA.SITE_ID),
                                                    PERCENT_INCREASE = 0,
                                                });
                                            }
                                            else
                                            {
                                                oList_Level_id_with_percent.Add(new Level_id_with_percent()
                                                {
                                                    VALUE = oSite_kpi_data.VALUE,
                                                    LEVEL_ID = oSite_kpi_data.SITE_METADATA.SITE_ID,
                                                    Site = oList_Site.Find(site => site.SITE_ID == oSite_kpi_data.SITE_METADATA.SITE_ID),
                                                    PERCENT_INCREASE = Math.Round((oOld_Site_kpi_data.VALUE == 0 ? 100 : ((oSite_kpi_data.VALUE - oOld_Site_kpi_data.VALUE) / oOld_Site_kpi_data.VALUE) * 100), 2),
                                                });
                                            }
                                        });
                                        oList_Alert_settings.ForEach(alert_settings =>
                                        {
                                            oList_Level_id_with_percent.ForEach(level_id_with_percent_increase =>
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
                                                    Alert oAlert = new Alert();
                                                    oAlert.USER_ID = alert_settings.USER_ID;
                                                    oAlert.LEVEL_ID = level_id_with_percent_increase.LEVEL_ID;
                                                    oAlert.ORGANIZATION_DATA_SOURCE_KPI_ID = oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID;
                                                    oAlert.LEVEL_SETUP_ID = Site_Setup_ID;
                                                    oAlert.RECORD_DATE = currentDate;
                                                    oAlert.IS_ACKNOWLEDGED = false;
                                                    oAlert.ALERT_VALUE = Math.Abs(level_id_with_percent_increase.PERCENT_INCREASE.Value);
                                                    oAlert.VALUE_PASSED = alert_settings.VALUE;
                                                    oAlert.VALUE_TYPE_SETUP_ID = alert_settings.Value_type_setup.SETUP_ID;
                                                    oAlert.OPERATION_TYPE_SETUP_ID = alert_settings.Operation_setup.SETUP_ID;
                                                    oList_Alert.Add(oAlert);
                                                }
                                            });
                                        });
                                    });

                                    #endregion

                                    #region Edit Alert List

                                    Edit_Alert_List(new Params_Edit_Alert_List()
                                    {
                                        List_Alert = Props.Copy_Prop_Values_From_Api_Response<List<Alert>>(oList_Alert),
                                    });

                                    #endregion
                                }
                            });

                            #endregion
                        }
                    }
                }
            }
        }
        #endregion
        #region Compute_Site_Kpi_Data_Weekly
        public void Compute_Site_Kpi_Data_Weekly(Params_Compute_Site_Kpi_Data_Weekly i_Params_Compute_Site_Kpi_Data_Weekly)
        {
            if (i_Params_Compute_Site_Kpi_Data_Weekly != null)
            {
                if (i_Params_Compute_Site_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI != null && i_Params_Compute_Site_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Count() > 0)
                {
                    DateTime CurrentDate = new DateTime(i_Params_Compute_Site_Kpi_Data_Weekly.YEAR, i_Params_Compute_Site_Kpi_Data_Weekly.MONTH, i_Params_Compute_Site_Kpi_Data_Weekly.DAY);
                    DateTime StartDate = CurrentDate.AddDays(-7);
                    List<Organization_data_source_kpi> oList_Organization_data_source_kpi_Trendline = i_Params_Compute_Site_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.IS_TRENDLINE == true).ToList();
                    List<Organization_data_source_kpi> oList_Organization_data_source_kpi_Non_Trendline = i_Params_Compute_Site_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.IS_TRENDLINE == false).ToList();
                    List<int?> List_Organization_data_source_kpi_ID = i_Params_Compute_Site_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Select(kpi => kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();
                    List<Site_kpi_data> oList_Site_kpi_data = Props.Copy_Prop_Values_From_Api_Response<List<Site_kpi_data>>(_MongoDb.Get_Site_Kpi_Data_By_Where(
                        START_DATE: StartDate,
                        END_DATE: CurrentDate,
                        ENUM_TIMESPAN: DALC.Enum_Timespan.X_DAILY_COLLECTION,
                        ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: List_Organization_data_source_kpi_ID,
                        SITE_ID_LIST: null
                    ));
                    List<Site_kpi_data> oList_Site_kpi_data_To_Save = new List<Site_kpi_data>();

                    if (oList_Site_kpi_data != null && oList_Site_kpi_data.Count > 0)
                    {
                        #region Calculate Trendline Data

                        if (oList_Organization_data_source_kpi_Trendline != null && oList_Organization_data_source_kpi_Trendline.Count > 0)
                        {
                            List<Site_kpi_data> oList_Site_kpi_data_Trendline = oList_Site_kpi_data.Where(oSite_kpi => oList_Organization_data_source_kpi_Trendline.Any(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == oSite_kpi.SITE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID)).ToList();

                            if (oList_Site_kpi_data_Trendline != null && oList_Site_kpi_data_Trendline.Count > 0)
                            {
                                List<Site_kpi_data> oList_Site_kpi_data_Trendline_To_Save = oList_Site_kpi_data_Trendline
                                                   .GroupBy(site_kpi_data => new
                                                   {
                                                       site_kpi_data.SITE_METADATA.SITE_ID,
                                                       site_kpi_data.SITE_METADATA.CATEGORY,
                                                       site_kpi_data.SITE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                   })
                                                   .Select(site_kpi_data => new Site_kpi_data()
                                                   {
                                                       SITE_METADATA = new Site_metadata()
                                                       {
                                                           SITE_ID = site_kpi_data.Key.SITE_ID,
                                                           CATEGORY = site_kpi_data.Key.CATEGORY,
                                                           ORGANIZATION_DATA_SOURCE_KPI_ID = site_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                       },
                                                       RECORD_DATE = StartDate,
                                                       VALUE_PER_SQM = i_Params_Compute_Site_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == site_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? site_kpi_data.Average(index => index.VALUE_PER_SQM) : site_kpi_data.Sum(index => index.VALUE_PER_SQM),
                                                       VALUE_NAME = i_Params_Compute_Site_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == site_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? i_Params_Compute_Site_Kpi_Data_Weekly.YEAR + " Week " + Get_Week_Of_Year(new Params_Get_Week_Of_Year()
                                                       {
                                                           DAY = StartDate.Day,
                                                           YEAR = StartDate.Year,
                                                           MONTH = StartDate.Month,
                                                       }) : site_kpi_data.First().VALUE_NAME,
                                                       VALUE = i_Params_Compute_Site_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == site_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_ADDITIVE_DATA ? site_kpi_data.Sum(index => index.VALUE) : site_kpi_data.Average(index => index.VALUE),
                                                   }).ToList();
                                oList_Site_kpi_data_To_Save = oList_Site_kpi_data_To_Save.Concat(oList_Site_kpi_data_Trendline_To_Save).ToList();
                            }
                        }

                        #endregion

                        #region Calculate Non Trendline Data

                        if (oList_Organization_data_source_kpi_Non_Trendline != null && oList_Organization_data_source_kpi_Non_Trendline.Count > 0)
                        {
                            List<Site_kpi_data> oList_Site_kpi_data_Non_Trendline = oList_Site_kpi_data.Where(oSite_kpi => oList_Organization_data_source_kpi_Non_Trendline.Any(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == oSite_kpi.SITE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID)).ToList();

                            if (oList_Site_kpi_data_Non_Trendline != null && oList_Site_kpi_data_Non_Trendline.Count > 0)
                            {
                                List<Site_kpi_data> oList_Site_kpi_data_Non_Trendline_To_Save = oList_Site_kpi_data_Non_Trendline
                                                   .GroupBy(site_kpi_data => new
                                                   {
                                                       site_kpi_data.SITE_METADATA.SITE_ID,
                                                       site_kpi_data.SITE_METADATA.CATEGORY,
                                                       site_kpi_data.SITE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                       site_kpi_data.VALUE_NAME
                                                   })
                                                   .Select(site_kpi_data => new Site_kpi_data()
                                                   {
                                                       SITE_METADATA = new Site_metadata()
                                                       {
                                                           SITE_ID = site_kpi_data.Key.SITE_ID,
                                                           CATEGORY = site_kpi_data.Key.CATEGORY,
                                                           ORGANIZATION_DATA_SOURCE_KPI_ID = site_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                       },
                                                       RECORD_DATE = StartDate,
                                                       VALUE_PER_SQM = i_Params_Compute_Site_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == site_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? site_kpi_data.Average(index => index.VALUE_PER_SQM) : site_kpi_data.Sum(index => index.VALUE_PER_SQM),
                                                       VALUE_NAME = i_Params_Compute_Site_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == site_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? i_Params_Compute_Site_Kpi_Data_Weekly.YEAR + " Week " + Get_Week_Of_Year(new Params_Get_Week_Of_Year()
                                                       {
                                                           DAY = StartDate.Day,
                                                           YEAR = StartDate.Year,
                                                           MONTH = StartDate.Month,
                                                       }) : site_kpi_data.First().VALUE_NAME,
                                                       VALUE = i_Params_Compute_Site_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == site_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_ADDITIVE_DATA ? site_kpi_data.Sum(index => index.VALUE) : site_kpi_data.Average(index => index.VALUE),
                                                   }).ToList();

                                oList_Site_kpi_data_To_Save = oList_Site_kpi_data_To_Save.Concat(oList_Site_kpi_data_Non_Trendline_To_Save).ToList();
                            }
                        }

                        #endregion

                        if (oList_Site_kpi_data_To_Save?.Count > 0)
                        {
                            try
                            {
                                Edit_Site_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN(new Params_Edit_Site_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN()
                                {
                                    LIST_SITE_KPI_DATA = oList_Site_kpi_data_To_Save,
                                    LIST_ORGANIZATION_DATA_SOURCE_KPI_ID = i_Params_Compute_Site_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList(),
                                    RECORD_DATE = StartDate,
                                    ENUM_TIMESPAN = Enum_Timespan.X_WEEKLY_COLLECTION
                                });
                            }
                            catch (Exception ex)
                            {
                                throw new BLC_Exception(ex.Message);
                            }
                        }
                    }
                }
            }
        }
        #endregion
        #region Compute_Site_Kpi_Data_Monthly
        public void Compute_Site_Kpi_Data_Monthly(Params_Compute_Site_Kpi_Data_Monthly i_Params_Compute_Site_Kpi_Data_Monthly)
        {
            if (i_Params_Compute_Site_Kpi_Data_Monthly != null)
            {
                if (i_Params_Compute_Site_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI != null && i_Params_Compute_Site_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Count() > 0)
                {
                    DateTime CurrentDate = new DateTime(i_Params_Compute_Site_Kpi_Data_Monthly.YEAR, i_Params_Compute_Site_Kpi_Data_Monthly.MONTH, 1);
                    DateTime StartDate = CurrentDate.AddMonths(-1);
                    List<Organization_data_source_kpi> oList_Organization_data_source_kpi_Trendline = i_Params_Compute_Site_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.IS_TRENDLINE == true).ToList();
                    List<Organization_data_source_kpi> oList_Organization_data_source_kpi_Non_Trendline = i_Params_Compute_Site_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.IS_TRENDLINE == false).ToList();
                    List<int?> List_Organization_data_source_kpi_ID = i_Params_Compute_Site_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Select(kpi => kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();
                    List<Site_kpi_data> oList_Site_kpi_data = Props.Copy_Prop_Values_From_Api_Response<List<Site_kpi_data>>(_MongoDb.Get_Site_Kpi_Data_By_Where(
                        START_DATE: StartDate,
                        END_DATE: CurrentDate,
                        ENUM_TIMESPAN: DALC.Enum_Timespan.X_DAILY_COLLECTION,
                        ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: List_Organization_data_source_kpi_ID,
                        SITE_ID_LIST: null
                    ));
                    List<Site_kpi_data> oList_Site_kpi_data_To_Save = new List<Site_kpi_data>();

                    if (oList_Site_kpi_data != null && oList_Site_kpi_data.Count > 0)
                    {
                        #region Calculate Trendline Data

                        if (oList_Organization_data_source_kpi_Trendline != null && oList_Organization_data_source_kpi_Trendline.Count > 0)
                        {
                            List<Site_kpi_data> oList_Site_kpi_data_Trendline = oList_Site_kpi_data.Where(oSite_kpi => oList_Organization_data_source_kpi_Trendline.Any(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == oSite_kpi.SITE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID)).ToList();

                            if (oList_Site_kpi_data_Trendline != null && oList_Site_kpi_data_Trendline.Count > 0)
                            {
                                List<Site_kpi_data> oList_Site_kpi_data_Trendline_To_Save = oList_Site_kpi_data_Trendline
                                                   .GroupBy(site_kpi_data => new
                                                   {
                                                       site_kpi_data.SITE_METADATA.SITE_ID,
                                                       site_kpi_data.SITE_METADATA.CATEGORY,
                                                       site_kpi_data.SITE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                   })
                                                   .Select(site_kpi_data => new Site_kpi_data()
                                                   {
                                                       SITE_METADATA = new Site_metadata()
                                                       {
                                                           SITE_ID = site_kpi_data.Key.SITE_ID,
                                                           CATEGORY = site_kpi_data.Key.CATEGORY,
                                                           ORGANIZATION_DATA_SOURCE_KPI_ID = site_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                       },
                                                       RECORD_DATE = StartDate,
                                                       VALUE_PER_SQM = i_Params_Compute_Site_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == site_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? site_kpi_data.Average(index => index.VALUE_PER_SQM) : site_kpi_data.Sum(index => index.VALUE_PER_SQM),
                                                       VALUE_NAME = i_Params_Compute_Site_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == site_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? StartDate.Month + "/" + StartDate.Year : site_kpi_data.First().VALUE_NAME,
                                                       VALUE = i_Params_Compute_Site_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == site_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_ADDITIVE_DATA ? site_kpi_data.Sum(index => index.VALUE) : site_kpi_data.Average(index => index.VALUE),
                                                   }).ToList();
                                oList_Site_kpi_data_To_Save = oList_Site_kpi_data_To_Save.Concat(oList_Site_kpi_data_Trendline_To_Save).ToList();
                            }
                        }

                        #endregion

                        #region Calculate Non Trendline Data

                        if (oList_Organization_data_source_kpi_Non_Trendline != null && oList_Organization_data_source_kpi_Non_Trendline.Count > 0)
                        {
                            List<Site_kpi_data> oList_Site_kpi_data_Non_Trendline = oList_Site_kpi_data.Where(oSite_kpi => oList_Organization_data_source_kpi_Non_Trendline.Any(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == oSite_kpi.SITE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID)).ToList();

                            if (oList_Site_kpi_data_Non_Trendline != null && oList_Site_kpi_data_Non_Trendline.Count > 0)
                            {
                                List<Site_kpi_data> oList_Site_kpi_data_Non_Trendline_To_Save = oList_Site_kpi_data_Non_Trendline
                                                   .GroupBy(site_kpi_data => new
                                                   {
                                                       site_kpi_data.SITE_METADATA.SITE_ID,
                                                       site_kpi_data.SITE_METADATA.CATEGORY,
                                                       site_kpi_data.SITE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                       site_kpi_data.VALUE_NAME
                                                   })
                                                   .Select(site_kpi_data => new Site_kpi_data()
                                                   {
                                                       SITE_METADATA = new Site_metadata()
                                                       {
                                                           SITE_ID = site_kpi_data.Key.SITE_ID,
                                                           CATEGORY = site_kpi_data.Key.CATEGORY,
                                                           ORGANIZATION_DATA_SOURCE_KPI_ID = site_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                       },
                                                       RECORD_DATE = StartDate,
                                                       VALUE_PER_SQM = i_Params_Compute_Site_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == site_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? site_kpi_data.Average(index => index.VALUE_PER_SQM) : site_kpi_data.Sum(index => index.VALUE_PER_SQM),
                                                       VALUE_NAME = i_Params_Compute_Site_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == site_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? StartDate.Month + "/" + StartDate.Year : site_kpi_data.First().VALUE_NAME,
                                                       VALUE = i_Params_Compute_Site_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == site_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_ADDITIVE_DATA ? site_kpi_data.Sum(index => index.VALUE) : site_kpi_data.Average(index => index.VALUE),
                                                   }).ToList();

                                oList_Site_kpi_data_To_Save = oList_Site_kpi_data_To_Save.Concat(oList_Site_kpi_data_Non_Trendline_To_Save).ToList();
                            }
                        }

                        #endregion

                        if (oList_Site_kpi_data_To_Save?.Count > 0)
                        {
                            try
                            {
                                Edit_Site_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN(new Params_Edit_Site_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN()
                                {
                                    LIST_SITE_KPI_DATA = oList_Site_kpi_data_To_Save,
                                    LIST_ORGANIZATION_DATA_SOURCE_KPI_ID = i_Params_Compute_Site_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList(),
                                    RECORD_DATE = StartDate,
                                    ENUM_TIMESPAN = Enum_Timespan.X_MONTHLY_COLLECTION
                                });
                            }
                            catch (Exception ex)
                            {
                                throw new BLC_Exception(ex.Message);
                            }
                        }
                    }
                }
            }
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
        #region Get_Entity_Incidents
        public Entity_Incidents Get_Entity_Incidents(Params_Get_Entity_Incidents i_Params_Get_Entity_Incidents)
        {
            if (i_Params_Get_Entity_Incidents.START_ROW == null || i_Params_Get_Entity_Incidents.START_ROW < 0)
            {
                i_Params_Get_Entity_Incidents.START_ROW = 0;
            }
            if (i_Params_Get_Entity_Incidents.END_ROW == null)
            {
                i_Params_Get_Entity_Incidents.END_ROW = 1000;
            }
            if (i_Params_Get_Entity_Incidents.START_DATE == null)
            {
                i_Params_Get_Entity_Incidents.START_DATE = DateTime.Now.AddYears(-100).ToString();
            }
            if (i_Params_Get_Entity_Incidents.END_DATE == null)
            {
                i_Params_Get_Entity_Incidents.END_DATE = DateTime.Now.ToString();
            }
            Entity_Incidents oEntity_Incidents = new Entity_Incidents();
            var get_fire_alarm_incident_with_count = Task.Run(() =>
            {
                oEntity_Incidents.LIST_FIRE_ALARM_INCIDENT_WITH_COUNT = new Incident_With_Count()
                {
                    List_Incident = new List<Incident>(),
                    COUNT = 0
                };
                Setup oSetup = i_Params_Get_Entity_Incidents.CATEGORY_SETUP_LIST.Where(category => category.VALUE == "Fire Alarm").FirstOrDefault();
                if (oSetup != null && oSetup != default)
                {
                    oEntity_Incidents.LIST_FIRE_ALARM_INCIDENT_WITH_COUNT = Props.Copy_Prop_Values_From_Api_Response<Incident_With_Count>(
                        this._service_mesh.Get_Incidents_By_Where_Sorted_With_Pagination(new Service_Mesh.Params_Get_Incidents_By_Where_Sorted_With_Pagination()
                        {
                            DIMENSION_ORDER_LIST = new List<int?>() { 2 },
                            END_ROW = i_Params_Get_Entity_Incidents.END_ROW,
                            START_ROW = i_Params_Get_Entity_Incidents.START_ROW,
                            ENTITY_ID_LIST = new List<long?>() { i_Params_Get_Entity_Incidents.ENTITY_ID },
                            INCIDENT_CATEGORY_SETUP_ID_LIST = new List<long?>() { i_Params_Get_Entity_Incidents.CATEGORY_SETUP_LIST.Where(category => category.VALUE == "Fire Alarm").FirstOrDefault().SETUP_ID }
                        }).i_Result
                    );
                }
            });
            var get_abandoned_object_incident_with_count = Task.Run(() =>
            {
                oEntity_Incidents.LIST_ABANDONED_OBJECT_INCIDENT_WITH_COUNT = new Incident_With_Count()
                {
                    List_Incident = new List<Incident>(),
                    COUNT = 0
                };
                Setup oSetup = i_Params_Get_Entity_Incidents.CATEGORY_SETUP_LIST.Where(category => category.VALUE == "Abandoned Object").FirstOrDefault();
                if (oSetup != null && oSetup != default)
                {
                    oEntity_Incidents.LIST_ABANDONED_OBJECT_INCIDENT_WITH_COUNT = Props.Copy_Prop_Values_From_Api_Response<Incident_With_Count>(
                        this._service_mesh.Get_Incidents_By_Where_Sorted_With_Pagination(new Service_Mesh.Params_Get_Incidents_By_Where_Sorted_With_Pagination()
                        {
                            DIMENSION_ORDER_LIST = new List<int?>() { 2 },
                            END_ROW = i_Params_Get_Entity_Incidents.END_ROW,
                            START_ROW = i_Params_Get_Entity_Incidents.START_ROW,
                            ENTITY_ID_LIST = new List<long?>() { i_Params_Get_Entity_Incidents.ENTITY_ID },
                            INCIDENT_CATEGORY_SETUP_ID_LIST = new List<long?>() { i_Params_Get_Entity_Incidents.CATEGORY_SETUP_LIST.Where(category => category.VALUE == "Abandoned Object").FirstOrDefault().SETUP_ID }
                        }).i_Result
                    );
                }
            });
            var get_access_control_incident_with_count = Task.Run(() =>
            {
                oEntity_Incidents.LIST_ACCESS_CONTROL_INCIDENT_WITH_COUNT = new Incident_With_Count()
                {
                    List_Incident = new List<Incident>(),
                    COUNT = 0
                };
                Setup oSetup = i_Params_Get_Entity_Incidents.CATEGORY_SETUP_LIST.Where(category => category.VALUE == "Access Control").FirstOrDefault();
                if (oSetup != null && oSetup != default)
                {
                    oEntity_Incidents.LIST_ACCESS_CONTROL_INCIDENT_WITH_COUNT = Props.Copy_Prop_Values_From_Api_Response<Incident_With_Count>(
                        this._service_mesh.Get_Incidents_By_Where_Sorted_With_Pagination(new Service_Mesh.Params_Get_Incidents_By_Where_Sorted_With_Pagination()
                        {
                            DIMENSION_ORDER_LIST = new List<int?>() { 2 },
                            END_ROW = i_Params_Get_Entity_Incidents.END_ROW,
                            START_ROW = i_Params_Get_Entity_Incidents.START_ROW,
                            ENTITY_ID_LIST = new List<long?>() { i_Params_Get_Entity_Incidents.ENTITY_ID },
                            INCIDENT_CATEGORY_SETUP_ID_LIST = new List<long?>() { i_Params_Get_Entity_Incidents.CATEGORY_SETUP_LIST.Where(category => category.VALUE == "Access Control").FirstOrDefault().SETUP_ID }
                        }).i_Result
                    );
                }
            });
            var get_suspicious_behavior_incident_with_count = Task.Run(() =>
            {
                oEntity_Incidents.LIST_SUSPICIOUS_BEHAVIOR_INCIDENT_WITH_COUNT = new Incident_With_Count()
                {
                    List_Incident = new List<Incident>(),
                    COUNT = 0
                };
                Setup oSetup = i_Params_Get_Entity_Incidents.CATEGORY_SETUP_LIST.Where(category => category.VALUE == "Suspicious Behavior").FirstOrDefault();
                if (oSetup != null && oSetup != default)
                {
                    oEntity_Incidents.LIST_SUSPICIOUS_BEHAVIOR_INCIDENT_WITH_COUNT = Props.Copy_Prop_Values_From_Api_Response<Incident_With_Count>(
                        this._service_mesh.Get_Incidents_By_Where_Sorted_With_Pagination(new Service_Mesh.Params_Get_Incidents_By_Where_Sorted_With_Pagination()
                        {
                            DIMENSION_ORDER_LIST = new List<int?>() { 2 },
                            END_ROW = i_Params_Get_Entity_Incidents.END_ROW,
                            START_ROW = i_Params_Get_Entity_Incidents.START_ROW,
                            ENTITY_ID_LIST = new List<long?>() { i_Params_Get_Entity_Incidents.ENTITY_ID },
                            INCIDENT_CATEGORY_SETUP_ID_LIST = new List<long?>() { i_Params_Get_Entity_Incidents.CATEGORY_SETUP_LIST.Where(category => category.VALUE == "Suspicious Behavior").FirstOrDefault().SETUP_ID }
                        }).i_Result
                    );
                }
            });
            var get_blacklisted_face_incident_with_count = Task.Run(() =>
            {
                oEntity_Incidents.LIST_BLACKLISTED_FACE_INCIDENT_WITH_COUNT = new Incident_With_Count()
                {
                    List_Incident = new List<Incident>(),
                    COUNT = 0
                };
                Setup oSetup = i_Params_Get_Entity_Incidents.CATEGORY_SETUP_LIST.Where(category => category.VALUE == "Blacklisted Person").FirstOrDefault();
                if (oSetup != null && oSetup != default)
                {
                    oEntity_Incidents.LIST_BLACKLISTED_FACE_INCIDENT_WITH_COUNT = Props.Copy_Prop_Values_From_Api_Response<Incident_With_Count>(
                        this._service_mesh.Get_Incidents_By_Where_Sorted_With_Pagination(new Service_Mesh.Params_Get_Incidents_By_Where_Sorted_With_Pagination()
                        {
                            DIMENSION_ORDER_LIST = new List<int?>() { 2 },
                            END_ROW = i_Params_Get_Entity_Incidents.END_ROW,
                            START_ROW = i_Params_Get_Entity_Incidents.START_ROW,
                            ENTITY_ID_LIST = new List<long?>() { i_Params_Get_Entity_Incidents.ENTITY_ID },
                            INCIDENT_CATEGORY_SETUP_ID_LIST = new List<long?>() { i_Params_Get_Entity_Incidents.CATEGORY_SETUP_LIST.Where(category => category.VALUE == "Blacklisted Person").FirstOrDefault().SETUP_ID }
                        }).i_Result
                    );
                }
            });
            var get_blacklisted_license_plate_incident_with_count = Task.Run(() =>
            {
                oEntity_Incidents.LIST_BLACKLISTED_LICENSE_PLATE_INCIDENT_WITH_COUNT = new Incident_With_Count()
                {
                    List_Incident = new List<Incident>(),
                    COUNT = 0
                };
                Setup oSetup = i_Params_Get_Entity_Incidents.CATEGORY_SETUP_LIST.Where(category => category.VALUE == "Blacklisted Plate").FirstOrDefault();
                if (oSetup != null && oSetup != default)
                {
                    oEntity_Incidents.LIST_BLACKLISTED_LICENSE_PLATE_INCIDENT_WITH_COUNT = Props.Copy_Prop_Values_From_Api_Response<Incident_With_Count>(
                        this._service_mesh.Get_Incidents_By_Where_Sorted_With_Pagination(new Service_Mesh.Params_Get_Incidents_By_Where_Sorted_With_Pagination()
                        {
                            DIMENSION_ORDER_LIST = new List<int?>() { 2 },
                            END_ROW = i_Params_Get_Entity_Incidents.END_ROW,
                            START_ROW = i_Params_Get_Entity_Incidents.START_ROW,
                            ENTITY_ID_LIST = new List<long?>() { i_Params_Get_Entity_Incidents.ENTITY_ID },
                            INCIDENT_CATEGORY_SETUP_ID_LIST = new List<long?>() { i_Params_Get_Entity_Incidents.CATEGORY_SETUP_LIST.Where(category => category.VALUE == "Blacklisted Plate").FirstOrDefault().SETUP_ID }
                        }).i_Result
                    );
                }
            });
            Task.WaitAll(get_fire_alarm_incident_with_count, get_abandoned_object_incident_with_count, get_access_control_incident_with_count, get_suspicious_behavior_incident_with_count, get_blacklisted_face_incident_with_count, get_blacklisted_license_plate_incident_with_count);

            return oEntity_Incidents;
        }
        #endregion
        #region Get_Incidents_Types_With_Count
        public List<Incident_Type_With_Count> Get_Incidents_By_ENTITY_ID_DIMENSION_ORDER(Params_Get_Incidents_By_ENTITY_ID_DIMENSION_ORDER i_Params_Get_Incidents_By_ENTITY_ID_DIMENSION_ORDER)
        {
            List<Setup> oList_Setup = new List<Setup>();
            List<Incident> oLIST_INCIDENT = new List<Incident>();

            var get_setups = Task.Run(() =>
            {
                oList_Setup = Get_Setup_By_OWNER_ID(new Params_Get_Setup_By_OWNER_ID()
                {
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                });
            });
            var get_incidents = Task.Run(() =>
            {
                oLIST_INCIDENT = Props.Copy_Prop_Values_From_Api_Response<List<Incident>>(
                    this._service_mesh.Get_Incidents_By_Where(new Service_Mesh.Params_Get_Incidents_By_Where()
                    {
                        ENTITY_ID_LIST = new List<long?>()
                        {
                            i_Params_Get_Incidents_By_ENTITY_ID_DIMENSION_ORDER.ENTITY_ID
                        },
                        DIMENSION_ORDER_LIST = new List<int?>()
                        {
                            i_Params_Get_Incidents_By_ENTITY_ID_DIMENSION_ORDER.DIMENSION_ORDER
                        },
                    }).i_Result
                );
            });
            Task.WaitAll(get_setups, get_incidents);

            switch (i_Params_Get_Incidents_By_ENTITY_ID_DIMENSION_ORDER.DIMENSION_ORDER)
            {
                case 1:
                    return oLIST_INCIDENT.GroupBy(incident => incident.SUSTAINABILITY_INCIDENT.CATEGORY_SETUP_ID)
                            .Select(incident =>
                            {
                                return new Incident_Type_With_Count()
                                {
                                    COUNT = incident.Count(),
                                    INCIDENT_NAME = oList_Setup.Find(setup => setup.SETUP_ID == incident.First().SUSTAINABILITY_INCIDENT.CATEGORY_SETUP_ID).VALUE,
                                };
                            }).ToList();
                case 2:
                    return oLIST_INCIDENT.GroupBy(incident => incident.SECURITY_INCIDENT.CATEGORY_SETUP_ID)
                            .Select(incident =>
                            {
                                return new Incident_Type_With_Count()
                                {
                                    COUNT = incident.Count(),
                                    INCIDENT_NAME = oList_Setup.Find(setup => setup.SETUP_ID == incident.First().SECURITY_INCIDENT.CATEGORY_SETUP_ID).VALUE,
                                };
                            }).ToList();
                case 3:
                    return oLIST_INCIDENT.GroupBy(incident => incident.MOBILITY_INCIDENT.CATEGORY_SETUP_ID)
                            .Select(incident =>
                            {
                                return new Incident_Type_With_Count()
                                {
                                    COUNT = incident.Count(),
                                    INCIDENT_NAME = oList_Setup.Find(setup => setup.SETUP_ID == incident.First().MOBILITY_INCIDENT.CATEGORY_SETUP_ID).VALUE,
                                };
                            }).ToList();
                case 4:
                    return oLIST_INCIDENT.GroupBy(incident => incident.LIVING_INCIDENT.CATEGORY_SETUP_ID)
                            .Select(incident =>
                            {
                                return new Incident_Type_With_Count()
                                {
                                    COUNT = incident.Count(),
                                    INCIDENT_NAME = oList_Setup.Find(setup => setup.SETUP_ID == incident.First().LIVING_INCIDENT.CATEGORY_SETUP_ID).VALUE,
                                };
                            }).ToList();
                default:
                    return new List<Incident_Type_With_Count>();
            }
        }
        #endregion
        #region Compute_Entity_Kpi_Data_Hourly
        public void Compute_Entity_Kpi_Data_Hourly(Params_Compute_Entity_Kpi_Data_Hourly i_Params_Compute_Entity_Kpi_Data_Hourly)
        {
            #region setup
            List<Floor> oList_Floor = new List<Floor>();
            List<Entity> oList_Entity = new List<Entity>();
            List<Floor_kpi_data> oList_Floor_kpi_data = new List<Floor_kpi_data>();

            List<Setup_category> oList_Setup_category = Get_Setup_category_By_OWNER_ID(new Params_Get_Setup_category_By_OWNER_ID()
            {
                OWNER_ID = this.oBLC_Initializer.Owner_ID
            });
            List<Setup> oList_Severity_Type_Setup = oList_Setup_category.First(oSetup_category => oSetup_category.SETUP_CATEGORY_NAME == "Severity Type").List_Setup;

            DateTime CurrentDate = new DateTime(i_Params_Compute_Entity_Kpi_Data_Hourly.YEAR, i_Params_Compute_Entity_Kpi_Data_Hourly.MONTH, i_Params_Compute_Entity_Kpi_Data_Hourly.DAY, i_Params_Compute_Entity_Kpi_Data_Hourly.HOUR, 0, 0);

            var get_floor_kpi_data = Task.Run(() =>
            {
                oList_Floor_kpi_data = Props.Copy_Prop_Values_From_Api_Response<List<Floor_kpi_data>>(_MongoDb.Get_Floor_Kpi_Data_By_Where(
                    START_DATE: CurrentDate,
                    END_DATE: CurrentDate.AddSeconds(1),
                    ENUM_TIMESPAN: DALC.Enum_Timespan.X_HOURLY_COLLECTION,
                    ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: i_Params_Compute_Entity_Kpi_Data_Hourly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList(),
                    FLOOR_ID_LIST: null
                ));
            });
            var get_entity = Task.Run(() =>
            {
                oList_Entity = Get_Entity_By_OWNER_ID(new Params_Get_Entity_By_OWNER_ID()
                {
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                });
            });
            var get_floor = Task.Run(() =>
            {
                oList_Floor = this.Get_Floor_By_OWNER_ID(new Params_Get_Floor_By_OWNER_ID()
                {
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                }
                );
            });
            Task.WaitAll(get_floor, get_entity, get_floor_kpi_data);

            oList_Entity = oList_Entity.Select(entity =>
            {
                entity.List_Floor = oList_Floor.Where(floor => floor.ENTITY_ID == entity.ENTITY_ID).ToList();
                return entity;
            }).ToList();

            List<Entity_kpi_data> oList_Entity_kpi_data = new List<Entity_kpi_data>();
            #endregion
            #region fill list
            foreach (var oOrganization_data_source_kpi in i_Params_Compute_Entity_Kpi_Data_Hourly.LIST_ORGANIZATION_DATA_SOURCE_KPI)
            {
                if (oOrganization_data_source_kpi.Kpi.SETUP_CATEGORY_ID != null)
                {
                    oOrganization_data_source_kpi.Kpi.Setup_category = oList_Setup_category.Find(setup_category => setup_category.SETUP_CATEGORY_ID == oOrganization_data_source_kpi.Kpi.SETUP_CATEGORY_ID);
                    foreach (var oEntity in oList_Entity)
                    {
                        List<Floor_kpi_data> oList_Floor_kpi_data_To_Use = oList_Floor_kpi_data.Where(floor_kpi_data => oEntity.List_Floor.Any(floor => floor.FLOOR_ID == floor_kpi_data.FLOOR_METADATA.FLOOR_ID) && floor_kpi_data.FLOOR_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID == oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();
                        foreach (var oSetup in oOrganization_data_source_kpi.Kpi.Setup_category.List_Setup)
                        {
                            if (oOrganization_data_source_kpi.Kpi.IS_BY_SEVERITY)
                            {
                                foreach (var oSeverity_Setup in oList_Severity_Type_Setup)
                                {
                                    string Severity_Type = "Severity Type:" + oSeverity_Setup.SETUP_ID.ToString();
                                    string Incident_Category_Type = "Incident Category Type:" + oSetup.SETUP_ID.ToString();
                                    string CATEGORY = Severity_Type + "," + Incident_Category_Type + ",EXT_STUDY_ZONE_ID:0";
                                    List<Floor_kpi_data> oList_Floor_kpi_data_To_Use2 = oList_Floor_kpi_data_To_Use.Where(floor_kpi_data => floor_kpi_data.FLOOR_METADATA.CATEGORY == CATEGORY).ToList();
                                    if (oList_Floor_kpi_data_To_Use2.Count > 0)
                                    {
                                        oList_Entity_kpi_data.Add(new Entity_kpi_data()
                                        {
                                            ENTITY_METADATA = new Entity_metadata()
                                            {
                                                ORGANIZATION_DATA_SOURCE_KPI_ID = (int)oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                ENTITY_ID = (int)oEntity.ENTITY_ID,
                                                CATEGORY = CATEGORY
                                            },
                                            VALUE_NAME = oList_Floor_kpi_data_To_Use2.First().VALUE_NAME,
                                            RECORD_DATE = oList_Floor_kpi_data_To_Use2.First().RECORD_DATE,
                                            VALUE_PER_SQM = oList_Floor_kpi_data_To_Use2.Sum(floor_kpi_data => floor_kpi_data.VALUE_PER_SQM),
                                            VALUE = (oOrganization_data_source_kpi.Kpi.IS_ADDITIVE_DATA ? oList_Floor_kpi_data_To_Use2.Sum(floor_kpi_data => floor_kpi_data.VALUE) : oList_Floor_kpi_data_To_Use2.Average(floor_kpi_data => floor_kpi_data.VALUE)),
                                        });
                                    }
                                }
                            }
                            else
                            {
                                string Incident_Category_Type = "Incident Category Type:" + oSetup.SETUP_ID.ToString();
                                string CATEGORY = "Severity Type:0," + Incident_Category_Type + ",EXT_STUDY_ZONE_ID:0";
                                List<Floor_kpi_data> oList_Floor_kpi_data_To_Use2 = oList_Floor_kpi_data_To_Use.Where(floor_kpi_data => floor_kpi_data.FLOOR_METADATA.CATEGORY == CATEGORY).ToList();
                                if (oList_Floor_kpi_data_To_Use2.Count > 0)
                                {
                                    oList_Entity_kpi_data.Add(new Entity_kpi_data()
                                    {
                                        ENTITY_METADATA = new Entity_metadata()
                                        {
                                            ORGANIZATION_DATA_SOURCE_KPI_ID = (int)oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                            ENTITY_ID = (int)oEntity.ENTITY_ID,
                                            CATEGORY = CATEGORY
                                        },
                                        VALUE_NAME = oList_Floor_kpi_data_To_Use2.First().VALUE_NAME,
                                        RECORD_DATE = oList_Floor_kpi_data_To_Use2.First().RECORD_DATE,
                                        VALUE_PER_SQM = oList_Floor_kpi_data_To_Use2.Sum(floor_kpi_data => floor_kpi_data.VALUE_PER_SQM),
                                        VALUE = (oOrganization_data_source_kpi.Kpi.IS_ADDITIVE_DATA ? oList_Floor_kpi_data_To_Use2.Sum(floor_kpi_data => floor_kpi_data.VALUE) : oList_Floor_kpi_data_To_Use2.Average(floor_kpi_data => floor_kpi_data.VALUE)),
                                    });
                                }
                            }
                        }
                    }
                }
                else
                {
                    foreach (var oEntity in oList_Entity)
                    {
                        if (oOrganization_data_source_kpi.Kpi.IS_BY_SEVERITY)
                        {
                            foreach (var oSeverity_Setup in oList_Severity_Type_Setup)
                            {
                                string Severity_Type = "Severity Type:" + oSeverity_Setup.SETUP_ID.ToString();
                                string CATEGORY = Severity_Type + ",Incident Category Type:0,EXT_STUDY_ZONE_ID:0";
                                List<Floor_kpi_data> oList_Floor_kpi_data_To_Use = oList_Floor_kpi_data.Where(floor_kpi_data => oEntity.List_Floor.Any(floor => floor.FLOOR_ID == floor_kpi_data.FLOOR_METADATA.FLOOR_ID) && floor_kpi_data.FLOOR_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID == oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID && floor_kpi_data.FLOOR_METADATA.CATEGORY == CATEGORY).ToList();
                                if (oList_Floor_kpi_data_To_Use.Count > 0)
                                {
                                    oList_Entity_kpi_data.Add(new Entity_kpi_data()
                                    {
                                        ENTITY_METADATA = new Entity_metadata()
                                        {
                                            ORGANIZATION_DATA_SOURCE_KPI_ID = (int)oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                            ENTITY_ID = (int)oEntity.ENTITY_ID,
                                            CATEGORY = CATEGORY
                                        },
                                        VALUE_NAME = oList_Floor_kpi_data_To_Use.First().VALUE_NAME,
                                        RECORD_DATE = oList_Floor_kpi_data_To_Use.First().RECORD_DATE,
                                        VALUE_PER_SQM = oList_Floor_kpi_data_To_Use.Average(floor_kpi_data => floor_kpi_data.VALUE_PER_SQM),
                                        VALUE = (oOrganization_data_source_kpi.Kpi.IS_ADDITIVE_DATA ? oList_Floor_kpi_data_To_Use.Sum(floor_kpi_data => floor_kpi_data.VALUE) : oList_Floor_kpi_data_To_Use.Average(floor_kpi_data => floor_kpi_data.VALUE)),
                                    });
                                }
                            }
                        }
                        else
                        {
                            string CATEGORY = "Severity Type:0,Incident Category Type:0,EXT_STUDY_ZONE_ID:0";
                            List<Floor_kpi_data> oList_Floor_kpi_data_To_Use = oList_Floor_kpi_data.Where(floor_kpi_data => oEntity.List_Floor.Any(floor => floor.FLOOR_ID == floor_kpi_data.FLOOR_METADATA.FLOOR_ID) && floor_kpi_data.FLOOR_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID == oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID && floor_kpi_data.FLOOR_METADATA.CATEGORY == CATEGORY).ToList();
                            if (oList_Floor_kpi_data_To_Use.Count > 0)
                            {
                                oList_Entity_kpi_data.Add(new Entity_kpi_data()
                                {
                                    ENTITY_METADATA = new Entity_metadata()
                                    {
                                        ORGANIZATION_DATA_SOURCE_KPI_ID = (int)oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                        ENTITY_ID = (int)oEntity.ENTITY_ID,
                                        CATEGORY = CATEGORY
                                    },
                                    VALUE_NAME = oList_Floor_kpi_data_To_Use.First().VALUE_NAME,
                                    RECORD_DATE = oList_Floor_kpi_data_To_Use.First().RECORD_DATE,
                                    VALUE_PER_SQM = oList_Floor_kpi_data_To_Use.Average(floor_kpi_data => floor_kpi_data.VALUE_PER_SQM),
                                    VALUE = (oOrganization_data_source_kpi.Kpi.IS_ADDITIVE_DATA ? oList_Floor_kpi_data_To_Use.Sum(floor_kpi_data => floor_kpi_data.VALUE) : oList_Floor_kpi_data_To_Use.Average(floor_kpi_data => floor_kpi_data.VALUE)),
                                });
                            }
                        }
                    }
                }
            }
            #endregion
            #region send data
            if (oList_Entity_kpi_data?.Count > 0)
            {
                try
                {
                    Edit_Entity_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN(new Params_Edit_Entity_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN()
                    {
                        LIST_ENTITY_KPI_DATA = oList_Entity_kpi_data,
                        LIST_ORGANIZATION_DATA_SOURCE_KPI_ID = i_Params_Compute_Entity_Kpi_Data_Hourly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList(),
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
        #region Compute_Entity_Kpi_Data_Daily
        public void Compute_Entity_Kpi_Data_Daily(Params_Compute_Entity_Kpi_Data_Daily i_Params_Compute_Entity_Kpi_Data_Daily)
        {
            if (i_Params_Compute_Entity_Kpi_Data_Daily != null)
            {
                if (i_Params_Compute_Entity_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI != null && i_Params_Compute_Entity_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Count() > 0)
                {
                    DateTime CurrentDate = new DateTime(i_Params_Compute_Entity_Kpi_Data_Daily.YEAR, i_Params_Compute_Entity_Kpi_Data_Daily.MONTH, i_Params_Compute_Entity_Kpi_Data_Daily.DAY);
                    DateTime StartDate = CurrentDate.AddDays(-1);
                    List<Organization_data_source_kpi> oList_Organization_data_source_kpi_Trendline = i_Params_Compute_Entity_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.IS_TRENDLINE == true).ToList();
                    List<Organization_data_source_kpi> oList_Organization_data_source_kpi_Non_Trendline = i_Params_Compute_Entity_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.IS_TRENDLINE == false).ToList();
                    List<int?> List_Organization_data_source_kpi_ID = i_Params_Compute_Entity_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();
                    List<Entity_kpi_data> oList_Entity_kpi_data = Props.Copy_Prop_Values_From_Api_Response<List<Entity_kpi_data>>(_MongoDb.Get_Entity_Kpi_Data_By_Where(
                        START_DATE: StartDate,
                        END_DATE: CurrentDate,
                        ENUM_TIMESPAN: DALC.Enum_Timespan.X_HOURLY_COLLECTION,
                        ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: List_Organization_data_source_kpi_ID,
                        ENTITY_ID_LIST: null
                    ));
                    List<Entity_kpi_data> oList_Entity_kpi_data_To_Save = new List<Entity_kpi_data>();

                    if (oList_Entity_kpi_data != null && oList_Entity_kpi_data.Count > 0)
                    {
                        #region Calculate Trendline Data

                        if (oList_Organization_data_source_kpi_Trendline != null && oList_Organization_data_source_kpi_Trendline.Count > 0)
                        {
                            List<Entity_kpi_data> oList_Entity_kpi_data_Trendline = oList_Entity_kpi_data.Where(oEntity_kpi => oList_Organization_data_source_kpi_Trendline.Any(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == oEntity_kpi.ENTITY_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID)).ToList();

                            if (oList_Entity_kpi_data_Trendline != null && oList_Entity_kpi_data_Trendline.Count > 0)
                            {
                                List<Entity_kpi_data> oList_Entity_kpi_data_Trendline_To_Save = oList_Entity_kpi_data_Trendline
                                                   .GroupBy(entity_kpi_data => new
                                                   {
                                                       entity_kpi_data.ENTITY_METADATA.ENTITY_ID,
                                                       entity_kpi_data.ENTITY_METADATA.CATEGORY,
                                                       entity_kpi_data.ENTITY_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                   })
                                                   .Select(entity_kpi_data => new Entity_kpi_data()
                                                   {
                                                       ENTITY_METADATA = new Entity_metadata()
                                                       {
                                                           ENTITY_ID = entity_kpi_data.Key.ENTITY_ID,
                                                           CATEGORY = entity_kpi_data.Key.CATEGORY,
                                                           ORGANIZATION_DATA_SOURCE_KPI_ID = entity_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                       },
                                                       RECORD_DATE = StartDate,
                                                       VALUE_PER_SQM = i_Params_Compute_Entity_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == entity_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? entity_kpi_data.Average(index => index.VALUE_PER_SQM) : entity_kpi_data.Sum(index => index.VALUE_PER_SQM),
                                                       VALUE_NAME = i_Params_Compute_Entity_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == entity_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? StartDate.ToShortDateString() : entity_kpi_data.First().VALUE_NAME,
                                                       VALUE = i_Params_Compute_Entity_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == entity_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_ADDITIVE_DATA ? entity_kpi_data.Sum(index => index.VALUE) : entity_kpi_data.Average(index => index.VALUE),
                                                   }).ToList();

                                oList_Entity_kpi_data_To_Save = oList_Entity_kpi_data_To_Save.Concat(oList_Entity_kpi_data_Trendline_To_Save).ToList();
                            }
                        }

                        #endregion

                        #region Calculate Non Trendline Data

                        if (oList_Organization_data_source_kpi_Non_Trendline != null && oList_Organization_data_source_kpi_Non_Trendline.Count > 0)
                        {
                            List<Entity_kpi_data> oList_Entity_kpi_data_Non_Trendline = oList_Entity_kpi_data.Where(oEntity_kpi => oList_Organization_data_source_kpi_Non_Trendline.Any(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == oEntity_kpi.ENTITY_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID)).ToList();

                            if (oList_Entity_kpi_data_Non_Trendline != null && oList_Entity_kpi_data_Non_Trendline.Count > 0)
                            {
                                List<Entity_kpi_data> oList_Entity_kpi_data_Non_Trendline_To_Save = oList_Entity_kpi_data_Non_Trendline
                                                   .GroupBy(entity_kpi_data => new
                                                   {
                                                       entity_kpi_data.ENTITY_METADATA.ENTITY_ID,
                                                       entity_kpi_data.ENTITY_METADATA.CATEGORY,
                                                       entity_kpi_data.ENTITY_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                       entity_kpi_data.VALUE_NAME
                                                   })
                                                   .Select(entity_kpi_data => new Entity_kpi_data()
                                                   {
                                                       ENTITY_METADATA = new Entity_metadata()
                                                       {
                                                           ENTITY_ID = entity_kpi_data.Key.ENTITY_ID,
                                                           CATEGORY = entity_kpi_data.Key.CATEGORY,
                                                           ORGANIZATION_DATA_SOURCE_KPI_ID = entity_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                       },
                                                       RECORD_DATE = StartDate,
                                                       VALUE_PER_SQM = i_Params_Compute_Entity_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == entity_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? entity_kpi_data.Average(index => index.VALUE_PER_SQM) : entity_kpi_data.Sum(index => index.VALUE_PER_SQM),
                                                       VALUE_NAME = i_Params_Compute_Entity_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == entity_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? StartDate.ToShortDateString() : entity_kpi_data.First().VALUE_NAME,
                                                       VALUE = i_Params_Compute_Entity_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == entity_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_ADDITIVE_DATA ? entity_kpi_data.Sum(index => index.VALUE) : entity_kpi_data.Average(index => index.VALUE),
                                                   }).ToList();

                                oList_Entity_kpi_data_To_Save = oList_Entity_kpi_data_To_Save.Concat(oList_Entity_kpi_data_Non_Trendline_To_Save).ToList();
                            }
                        }

                        #endregion

                        if (oList_Entity_kpi_data_To_Save?.Count > 0)
                        {
                            try
                            {
                                Edit_Entity_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN(new Params_Edit_Entity_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN()
                                {
                                    LIST_ENTITY_KPI_DATA = oList_Entity_kpi_data_To_Save,
                                    LIST_ORGANIZATION_DATA_SOURCE_KPI_ID = i_Params_Compute_Entity_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList(),
                                    RECORD_DATE = StartDate,
                                    ENUM_TIMESPAN = Enum_Timespan.X_DAILY_COLLECTION
                                });
                            }
                            catch (Exception ex)
                            {
                                throw new BLC_Exception(ex.Message);
                            }
                        }
                    }
                }
            }
        }
        #endregion
        #region Compute_Entity_Kpi_Data_Weekly
        public void Compute_Entity_Kpi_Data_Weekly(Params_Compute_Entity_Kpi_Data_Weekly i_Params_Compute_Entity_Kpi_Data_Weekly)
        {
            if (i_Params_Compute_Entity_Kpi_Data_Weekly != null)
            {
                if (i_Params_Compute_Entity_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI != null && i_Params_Compute_Entity_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Count() > 0)
                {
                    DateTime CurrentDate = new DateTime(i_Params_Compute_Entity_Kpi_Data_Weekly.YEAR, i_Params_Compute_Entity_Kpi_Data_Weekly.MONTH, i_Params_Compute_Entity_Kpi_Data_Weekly.DAY);
                    DateTime StartDate = CurrentDate.AddDays(-7);
                    List<Organization_data_source_kpi> oList_Organization_data_source_kpi_Trendline = i_Params_Compute_Entity_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.IS_TRENDLINE == true).ToList();
                    List<Organization_data_source_kpi> oList_Organization_data_source_kpi_Non_Trendline = i_Params_Compute_Entity_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.IS_TRENDLINE == false).ToList();
                    List<int?> List_Organization_data_source_kpi_ID = i_Params_Compute_Entity_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();
                    List<Entity_kpi_data> oList_Entity_kpi_data = Props.Copy_Prop_Values_From_Api_Response<List<Entity_kpi_data>>(_MongoDb.Get_Entity_Kpi_Data_By_Where(
                        START_DATE: StartDate,
                        END_DATE: CurrentDate,
                        ENUM_TIMESPAN: DALC.Enum_Timespan.X_DAILY_COLLECTION,
                        ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: List_Organization_data_source_kpi_ID,
                        ENTITY_ID_LIST: null
                    ));
                    List<Entity_kpi_data> oList_Entity_kpi_data_To_Save = new List<Entity_kpi_data>();

                    if (oList_Entity_kpi_data != null && oList_Entity_kpi_data.Count > 0)
                    {
                        #region Calculate Trendline Data

                        if (oList_Organization_data_source_kpi_Trendline != null && oList_Organization_data_source_kpi_Trendline.Count > 0)
                        {
                            List<Entity_kpi_data> oList_Entity_kpi_data_Trendline = oList_Entity_kpi_data.Where(oEntity_kpi => oList_Organization_data_source_kpi_Trendline.Any(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == oEntity_kpi.ENTITY_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID)).ToList();

                            if (oList_Entity_kpi_data_Trendline != null && oList_Entity_kpi_data_Trendline.Count > 0)
                            {
                                List<Entity_kpi_data> oList_Entity_kpi_data_Trendline_To_Save = oList_Entity_kpi_data_Trendline
                                                   .GroupBy(entity_kpi_data => new
                                                   {
                                                       entity_kpi_data.ENTITY_METADATA.ENTITY_ID,
                                                       entity_kpi_data.ENTITY_METADATA.CATEGORY,
                                                       entity_kpi_data.ENTITY_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                   })
                                                   .Select(entity_kpi_data => new Entity_kpi_data()
                                                   {
                                                       ENTITY_METADATA = new Entity_metadata()
                                                       {
                                                           ENTITY_ID = entity_kpi_data.Key.ENTITY_ID,
                                                           CATEGORY = entity_kpi_data.Key.CATEGORY,
                                                           ORGANIZATION_DATA_SOURCE_KPI_ID = entity_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                       },
                                                       RECORD_DATE = StartDate,
                                                       VALUE_PER_SQM = i_Params_Compute_Entity_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == entity_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? entity_kpi_data.Average(index => index.VALUE_PER_SQM) : entity_kpi_data.Sum(index => index.VALUE_PER_SQM),
                                                       VALUE_NAME = i_Params_Compute_Entity_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == entity_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? i_Params_Compute_Entity_Kpi_Data_Weekly.YEAR + " Week " + Get_Week_Of_Year(new Params_Get_Week_Of_Year()
                                                       {
                                                           DAY = StartDate.Day,
                                                           YEAR = StartDate.Year,
                                                           MONTH = StartDate.Month,
                                                       }) : entity_kpi_data.First().VALUE_NAME,
                                                       VALUE = i_Params_Compute_Entity_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == entity_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_ADDITIVE_DATA ? entity_kpi_data.Sum(index => index.VALUE) : entity_kpi_data.Average(index => index.VALUE),
                                                   }).ToList();
                                oList_Entity_kpi_data_To_Save = oList_Entity_kpi_data_To_Save.Concat(oList_Entity_kpi_data_Trendline_To_Save).ToList();
                            }
                        }

                        #endregion

                        #region Calculate Non Trendline Data

                        if (oList_Organization_data_source_kpi_Non_Trendline != null && oList_Organization_data_source_kpi_Non_Trendline.Count > 0)
                        {
                            List<Entity_kpi_data> oList_Entity_kpi_data_Non_Trendline = oList_Entity_kpi_data.Where(oEntity_kpi => oList_Organization_data_source_kpi_Non_Trendline.Any(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == oEntity_kpi.ENTITY_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID)).ToList();

                            if (oList_Entity_kpi_data_Non_Trendline != null && oList_Entity_kpi_data_Non_Trendline.Count > 0)
                            {
                                List<Entity_kpi_data> oList_Entity_kpi_data_Non_Trendline_To_Save = oList_Entity_kpi_data_Non_Trendline
                                                   .GroupBy(entity_kpi_data => new
                                                   {
                                                       entity_kpi_data.ENTITY_METADATA.ENTITY_ID,
                                                       entity_kpi_data.ENTITY_METADATA.CATEGORY,
                                                       entity_kpi_data.ENTITY_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                       entity_kpi_data.VALUE_NAME
                                                   })
                                                   .Select(entity_kpi_data => new Entity_kpi_data()
                                                   {
                                                       ENTITY_METADATA = new Entity_metadata()
                                                       {
                                                           ENTITY_ID = entity_kpi_data.Key.ENTITY_ID,
                                                           CATEGORY = entity_kpi_data.Key.CATEGORY,
                                                           ORGANIZATION_DATA_SOURCE_KPI_ID = entity_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                       },
                                                       RECORD_DATE = StartDate,
                                                       VALUE_PER_SQM = i_Params_Compute_Entity_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == entity_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? entity_kpi_data.Average(index => index.VALUE_PER_SQM) : entity_kpi_data.Sum(index => index.VALUE_PER_SQM),
                                                       VALUE_NAME = i_Params_Compute_Entity_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == entity_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? i_Params_Compute_Entity_Kpi_Data_Weekly.YEAR + " Week " + Get_Week_Of_Year(new Params_Get_Week_Of_Year()
                                                       {
                                                           DAY = StartDate.Day,
                                                           YEAR = StartDate.Year,
                                                           MONTH = StartDate.Month,
                                                       }) : entity_kpi_data.First().VALUE_NAME,
                                                       VALUE = i_Params_Compute_Entity_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == entity_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_ADDITIVE_DATA ? entity_kpi_data.Sum(index => index.VALUE) : entity_kpi_data.Average(index => index.VALUE),
                                                   }).ToList();

                                oList_Entity_kpi_data_To_Save = oList_Entity_kpi_data_To_Save.Concat(oList_Entity_kpi_data_Non_Trendline_To_Save).ToList();
                            }
                        }

                        #endregion

                        if (oList_Entity_kpi_data_To_Save?.Count > 0)
                        {
                            try
                            {
                                Edit_Entity_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN(new Params_Edit_Entity_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN()
                                {
                                    LIST_ENTITY_KPI_DATA = oList_Entity_kpi_data_To_Save,
                                    LIST_ORGANIZATION_DATA_SOURCE_KPI_ID = i_Params_Compute_Entity_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList(),
                                    RECORD_DATE = StartDate,
                                    ENUM_TIMESPAN = Enum_Timespan.X_WEEKLY_COLLECTION
                                });
                            }
                            catch (Exception ex)
                            {
                                throw new BLC_Exception(ex.Message);
                            }
                        }
                    }
                }
            }
        }
        #endregion
        #region Compute_Entity_Kpi_Data_Monthly
        public void Compute_Entity_Kpi_Data_Monthly(Params_Compute_Entity_Kpi_Data_Monthly i_Params_Compute_Entity_Kpi_Data_Monthly)
        {
            if (i_Params_Compute_Entity_Kpi_Data_Monthly != null)
            {
                if (i_Params_Compute_Entity_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI != null && i_Params_Compute_Entity_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Count() > 0)
                {
                    DateTime CurrentDate = new DateTime(i_Params_Compute_Entity_Kpi_Data_Monthly.YEAR, i_Params_Compute_Entity_Kpi_Data_Monthly.MONTH, 1);
                    DateTime StartDate = CurrentDate.AddMonths(-1);
                    List<Organization_data_source_kpi> oList_Organization_data_source_kpi_Trendline = i_Params_Compute_Entity_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.IS_TRENDLINE == true).ToList();
                    List<Organization_data_source_kpi> oList_Organization_data_source_kpi_Non_Trendline = i_Params_Compute_Entity_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.IS_TRENDLINE == false).ToList();
                    List<int?> List_Organization_data_source_kpi_ID = i_Params_Compute_Entity_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();
                    List<Entity_kpi_data> oList_Entity_kpi_data = Props.Copy_Prop_Values_From_Api_Response<List<Entity_kpi_data>>(_MongoDb.Get_Entity_Kpi_Data_By_Where(
                        START_DATE: StartDate,
                        END_DATE: CurrentDate,
                        ENUM_TIMESPAN: DALC.Enum_Timespan.X_DAILY_COLLECTION,
                        ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: List_Organization_data_source_kpi_ID,
                        ENTITY_ID_LIST: null
                    ));
                    List<Entity_kpi_data> oList_Entity_kpi_data_To_Save = new List<Entity_kpi_data>();

                    if (oList_Entity_kpi_data != null && oList_Entity_kpi_data.Count > 0)
                    {
                        #region Calculate Trendline Data

                        if (oList_Organization_data_source_kpi_Trendline != null && oList_Organization_data_source_kpi_Trendline.Count > 0)
                        {
                            List<Entity_kpi_data> oList_Entity_kpi_data_Trendline = oList_Entity_kpi_data.Where(oEntity_kpi => oList_Organization_data_source_kpi_Trendline.Any(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == oEntity_kpi.ENTITY_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID)).ToList();

                            if (oList_Entity_kpi_data_Trendline != null && oList_Entity_kpi_data_Trendline.Count > 0)
                            {
                                List<Entity_kpi_data> oList_Entity_kpi_data_Trendline_To_Save = oList_Entity_kpi_data_Trendline
                                                   .GroupBy(eneity_kpi_data => new
                                                   {
                                                       eneity_kpi_data.ENTITY_METADATA.ENTITY_ID,
                                                       eneity_kpi_data.ENTITY_METADATA.CATEGORY,
                                                       eneity_kpi_data.ENTITY_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                   })
                                                   .Select(eneity_kpi_data => new Entity_kpi_data()
                                                   {
                                                       ENTITY_METADATA = new Entity_metadata()
                                                       {
                                                           ENTITY_ID = eneity_kpi_data.Key.ENTITY_ID,
                                                           CATEGORY = eneity_kpi_data.Key.CATEGORY,
                                                           ORGANIZATION_DATA_SOURCE_KPI_ID = eneity_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                       },
                                                       RECORD_DATE = StartDate,
                                                       VALUE_PER_SQM = i_Params_Compute_Entity_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == eneity_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? eneity_kpi_data.Average(index => index.VALUE_PER_SQM) : eneity_kpi_data.Sum(index => index.VALUE_PER_SQM),
                                                       VALUE_NAME = i_Params_Compute_Entity_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == eneity_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? StartDate + "/" + StartDate.Year : eneity_kpi_data.First().VALUE_NAME,
                                                       VALUE = i_Params_Compute_Entity_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == eneity_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_ADDITIVE_DATA ? eneity_kpi_data.Sum(index => index.VALUE) : eneity_kpi_data.Average(index => index.VALUE),
                                                   }).ToList();
                                oList_Entity_kpi_data_To_Save = oList_Entity_kpi_data_To_Save.Concat(oList_Entity_kpi_data_Trendline_To_Save).ToList();
                            }
                        }

                        #endregion

                        #region Calculate Non Trendline Data

                        if (oList_Organization_data_source_kpi_Non_Trendline != null && oList_Organization_data_source_kpi_Non_Trendline.Count > 0)
                        {
                            List<Entity_kpi_data> oList_Entity_kpi_data_Non_Trendline = oList_Entity_kpi_data.Where(oEntity_kpi => oList_Organization_data_source_kpi_Non_Trendline.Any(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == oEntity_kpi.ENTITY_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID)).ToList();

                            if (oList_Entity_kpi_data_Non_Trendline != null && oList_Entity_kpi_data_Non_Trendline.Count > 0)
                            {
                                List<Entity_kpi_data> oList_Entity_kpi_data_Non_Trendline_To_Save = oList_Entity_kpi_data_Non_Trendline
                                                   .GroupBy(eneity_kpi_data => new
                                                   {
                                                       eneity_kpi_data.ENTITY_METADATA.ENTITY_ID,
                                                       eneity_kpi_data.ENTITY_METADATA.CATEGORY,
                                                       eneity_kpi_data.ENTITY_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                       eneity_kpi_data.VALUE_NAME
                                                   })
                                                   .Select(eneity_kpi_data => new Entity_kpi_data()
                                                   {
                                                       ENTITY_METADATA = new Entity_metadata()
                                                       {
                                                           ENTITY_ID = eneity_kpi_data.Key.ENTITY_ID,
                                                           CATEGORY = eneity_kpi_data.Key.CATEGORY,
                                                           ORGANIZATION_DATA_SOURCE_KPI_ID = eneity_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                       },
                                                       RECORD_DATE = StartDate,
                                                       VALUE_PER_SQM = i_Params_Compute_Entity_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == eneity_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? eneity_kpi_data.Average(index => index.VALUE_PER_SQM) : eneity_kpi_data.Sum(index => index.VALUE_PER_SQM),
                                                       VALUE_NAME = i_Params_Compute_Entity_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == eneity_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? StartDate + "/" + StartDate.Year : eneity_kpi_data.First().VALUE_NAME,
                                                       VALUE = i_Params_Compute_Entity_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == eneity_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_ADDITIVE_DATA ? eneity_kpi_data.Sum(index => index.VALUE) : eneity_kpi_data.Average(index => index.VALUE),
                                                   }).ToList();

                                oList_Entity_kpi_data_To_Save = oList_Entity_kpi_data_To_Save.Concat(oList_Entity_kpi_data_Non_Trendline_To_Save).ToList();
                            }
                        }

                        #endregion

                        if (oList_Entity_kpi_data_To_Save?.Count > 0)
                        {
                            try
                            {
                                Edit_Entity_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN(new Params_Edit_Entity_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN()
                                {
                                    LIST_ENTITY_KPI_DATA = oList_Entity_kpi_data_To_Save,
                                    LIST_ORGANIZATION_DATA_SOURCE_KPI_ID = i_Params_Compute_Entity_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList(),
                                    RECORD_DATE = StartDate,
                                    ENUM_TIMESPAN = Enum_Timespan.X_MONTHLY_COLLECTION
                                });

                            }
                            catch (Exception ex)
                            {
                                throw new BLC_Exception(ex.Message);
                            }
                        }
                    }
                }
            }
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
        #region Compute_Floor_Kpi_Data_Hourly
        public void Compute_Floor_Kpi_Data_Hourly(Params_Compute_Floor_Kpi_Data_Hourly i_Params_Compute_Floor_Kpi_Data_Hourly)
        {
            DateTime CurrentDate = new DateTime(i_Params_Compute_Floor_Kpi_Data_Hourly.YEAR, i_Params_Compute_Floor_Kpi_Data_Hourly.MONTH, i_Params_Compute_Floor_Kpi_Data_Hourly.DAY, i_Params_Compute_Floor_Kpi_Data_Hourly.HOUR, 0, 0);

            List<Floor_kpi_data> oList_Floor_kpi_data = Get_Floor_Kpi_Data_By_Where(new Params_Get_Floor_Kpi_Data_By_Where()
            {
                START_DATE = CurrentDate,
                END_DATE = CurrentDate.AddSeconds(1),
                FLOOR_ID_LIST = null,
                ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = i_Params_Compute_Floor_Kpi_Data_Hourly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList(),
                ENUM_TIMESPAN = Enum_Timespan.X_HOURLY_COLLECTION
            });

            if (oList_Floor_kpi_data?.Count > 0)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0044).Replace("%1", "Floor").Replace("%2", CurrentDate.ToString())); // Data for %1 on date %2 already exists
            }

            var averaged_kpis = Task.Run(() =>
            {
                List<Organization_data_source_kpi> oList_Organization_data_source_kpi = i_Params_Compute_Floor_Kpi_Data_Hourly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Where(oOrganization_data_source_kpi => !oOrganization_data_source_kpi.Kpi.IS_ADDITIVE_DATA).ToList();
                if (oList_Organization_data_source_kpi.Count > 0)
                {
                    this._MongoDb.Compute_Averaged_Floor_Indexes(
                        START_DATE: CurrentDate,
                        END_DATE: CurrentDate.AddSeconds(1),
                        ENUM_TIMESPAN: DALC.Enum_Timespan.X_HOURLY_COLLECTION,
                        ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: oList_Organization_data_source_kpi.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList()
                    );
                }
            });
            var additive_kpis = Task.Run(() =>
            {
                List<Organization_data_source_kpi> oList_Organization_data_source_kpi = i_Params_Compute_Floor_Kpi_Data_Hourly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.IS_ADDITIVE_DATA).ToList();
                if (oList_Organization_data_source_kpi.Count > 0)
                {
                    this._MongoDb.Compute_Additive_Floor_Indexes(
                        START_DATE: CurrentDate,
                        END_DATE: CurrentDate.AddSeconds(1),
                        ENUM_TIMESPAN: DALC.Enum_Timespan.X_HOURLY_COLLECTION,
                        ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: oList_Organization_data_source_kpi.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList()
                    );
                }
            });

            Task.WaitAll(additive_kpis, averaged_kpis);
        }
        #endregion
        #region Compute_Floor_Kpi_Data_Daily
        public void Compute_Floor_Kpi_Data_Daily(Params_Compute_Floor_Kpi_Data_Daily i_Params_Compute_Floor_Kpi_Data_Daily)
        {
            if (i_Params_Compute_Floor_Kpi_Data_Daily != null)
            {
                if (i_Params_Compute_Floor_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI != null && i_Params_Compute_Floor_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Count() > 0)
                {
                    DateTime CurrentDate = new DateTime(i_Params_Compute_Floor_Kpi_Data_Daily.YEAR, i_Params_Compute_Floor_Kpi_Data_Daily.MONTH, i_Params_Compute_Floor_Kpi_Data_Daily.DAY);
                    DateTime StartDate = CurrentDate.AddDays(-1);
                    List<Organization_data_source_kpi> oList_Organization_data_source_kpi_Trendline = i_Params_Compute_Floor_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.IS_TRENDLINE == true).ToList();
                    List<Organization_data_source_kpi> oList_Organization_data_source_kpi_Non_Trendline = i_Params_Compute_Floor_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.IS_TRENDLINE == false).ToList();
                    List<int?> List_Organization_data_source_kpi_ID = i_Params_Compute_Floor_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();
                    List<Floor_kpi_data> oList_Floor_kpi_data = Props.Copy_Prop_Values_From_Api_Response<List<Floor_kpi_data>>(_MongoDb.Get_Floor_Kpi_Data_By_Where(
                        START_DATE: StartDate,
                        END_DATE: CurrentDate,
                        ENUM_TIMESPAN: DALC.Enum_Timespan.X_HOURLY_COLLECTION,
                        ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: List_Organization_data_source_kpi_ID,
                        FLOOR_ID_LIST: null
                    ));
                    List<Floor_kpi_data> oList_Floor_kpi_data_To_Save = new List<Floor_kpi_data>();

                    if (oList_Floor_kpi_data != null && oList_Floor_kpi_data.Count > 0)
                    {
                        #region Calculate Trendline Data

                        if (oList_Organization_data_source_kpi_Trendline != null && oList_Organization_data_source_kpi_Trendline.Count > 0)
                        {
                            List<Floor_kpi_data> oList_Floor_kpi_data_Trendline = oList_Floor_kpi_data.Where(oFloor_kpi => oList_Organization_data_source_kpi_Trendline.Any(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == oFloor_kpi.FLOOR_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID)).ToList();

                            if (oList_Floor_kpi_data_Trendline != null && oList_Floor_kpi_data_Trendline.Count > 0)
                            {
                                List<Floor_kpi_data> oList_Floor_kpi_data_Trendline_To_Save = oList_Floor_kpi_data_Trendline
                                                   .GroupBy(floor_kpi_data => new
                                                   {
                                                       floor_kpi_data.FLOOR_METADATA.FLOOR_ID,
                                                       floor_kpi_data.FLOOR_METADATA.CATEGORY,
                                                       floor_kpi_data.FLOOR_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                   })
                                                   .Select(floor_kpi_data => new Floor_kpi_data()
                                                   {
                                                       FLOOR_METADATA = new Floor_metadata()
                                                       {
                                                           FLOOR_ID = floor_kpi_data.Key.FLOOR_ID,
                                                           CATEGORY = floor_kpi_data.Key.CATEGORY,
                                                           ORGANIZATION_DATA_SOURCE_KPI_ID = floor_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                       },
                                                       RECORD_DATE = StartDate,
                                                       VALUE_PER_SQM = i_Params_Compute_Floor_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == floor_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? floor_kpi_data.Average(index => index.VALUE_PER_SQM) : floor_kpi_data.Sum(index => index.VALUE_PER_SQM),
                                                       VALUE_NAME = i_Params_Compute_Floor_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == floor_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? StartDate.ToShortDateString() : floor_kpi_data.First().VALUE_NAME,
                                                       VALUE = i_Params_Compute_Floor_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == floor_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_ADDITIVE_DATA ? floor_kpi_data.Sum(index => index.VALUE) : floor_kpi_data.Average(index => index.VALUE),
                                                   }).ToList();

                                oList_Floor_kpi_data_To_Save = oList_Floor_kpi_data_To_Save.Concat(oList_Floor_kpi_data_Trendline_To_Save).ToList();
                            }
                        }

                        #endregion

                        #region Calculate Non Trendline Data

                        if (oList_Organization_data_source_kpi_Non_Trendline != null && oList_Organization_data_source_kpi_Non_Trendline.Count > 0)
                        {
                            List<Floor_kpi_data> oList_Floor_kpi_data_Non_Trendline = oList_Floor_kpi_data.Where(oFloor_kpi => oList_Organization_data_source_kpi_Non_Trendline.Any(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == oFloor_kpi.FLOOR_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID)).ToList();

                            if (oList_Floor_kpi_data_Non_Trendline != null && oList_Floor_kpi_data_Non_Trendline.Count > 0)
                            {
                                List<Floor_kpi_data> oList_Floor_kpi_data_Non_Trendline_To_Save = oList_Floor_kpi_data_Non_Trendline
                                                   .GroupBy(floor_kpi_data => new
                                                   {
                                                       floor_kpi_data.FLOOR_METADATA.FLOOR_ID,
                                                       floor_kpi_data.FLOOR_METADATA.CATEGORY,
                                                       floor_kpi_data.FLOOR_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                       floor_kpi_data.VALUE_NAME
                                                   })
                                                   .Select(floor_kpi_data => new Floor_kpi_data()
                                                   {
                                                       FLOOR_METADATA = new Floor_metadata()
                                                       {
                                                           FLOOR_ID = floor_kpi_data.Key.FLOOR_ID,
                                                           CATEGORY = floor_kpi_data.Key.CATEGORY,
                                                           ORGANIZATION_DATA_SOURCE_KPI_ID = floor_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                       },
                                                       RECORD_DATE = StartDate,
                                                       VALUE_PER_SQM = i_Params_Compute_Floor_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == floor_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? floor_kpi_data.Average(index => index.VALUE_PER_SQM) : floor_kpi_data.Sum(index => index.VALUE_PER_SQM),
                                                       VALUE_NAME = i_Params_Compute_Floor_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == floor_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? StartDate.ToShortDateString() : floor_kpi_data.First().VALUE_NAME,
                                                       VALUE = i_Params_Compute_Floor_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == floor_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_ADDITIVE_DATA ? floor_kpi_data.Sum(index => index.VALUE) : floor_kpi_data.Average(index => index.VALUE),
                                                   }).ToList();

                                oList_Floor_kpi_data_To_Save = oList_Floor_kpi_data_To_Save.Concat(oList_Floor_kpi_data_Non_Trendline_To_Save).ToList();
                            }
                        }

                        #endregion

                        if (oList_Floor_kpi_data_To_Save?.Count > 0)
                        {
                            try
                            {
                                Edit_Floor_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN(new Params_Edit_Floor_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN()
                                {
                                    LIST_FLOOR_KPI_DATA = oList_Floor_kpi_data_To_Save,
                                    LIST_ORGANIZATION_DATA_SOURCE_KPI_ID = i_Params_Compute_Floor_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList(),
                                    RECORD_DATE = StartDate,
                                    ENUM_TIMESPAN = Enum_Timespan.X_DAILY_COLLECTION
                                });
                            }
                            catch (Exception ex)
                            {
                                throw new BLC_Exception(ex.Message);
                            }
                        }
                    }
                }
            }
        }
        #endregion
        #region Compute_Floor_Kpi_Data_Weekly
        public void Compute_Floor_Kpi_Data_Weekly(Params_Compute_Floor_Kpi_Data_Weekly i_Params_Compute_Floor_Kpi_Data_Weekly)
        {
            if (i_Params_Compute_Floor_Kpi_Data_Weekly != null)
            {
                if (i_Params_Compute_Floor_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI != null && i_Params_Compute_Floor_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Count() > 0)
                {
                    DateTime CurrentDate = new DateTime(i_Params_Compute_Floor_Kpi_Data_Weekly.YEAR, i_Params_Compute_Floor_Kpi_Data_Weekly.MONTH, i_Params_Compute_Floor_Kpi_Data_Weekly.DAY);
                    DateTime StartDate = CurrentDate.AddDays(-7);
                    List<Organization_data_source_kpi> oList_Organization_data_source_kpi_Trendline = i_Params_Compute_Floor_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.IS_TRENDLINE == true).ToList();
                    List<Organization_data_source_kpi> oList_Organization_data_source_kpi_Non_Trendline = i_Params_Compute_Floor_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.IS_TRENDLINE == false).ToList();
                    List<int?> List_Organization_data_source_kpi_ID = i_Params_Compute_Floor_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();
                    List<Floor_kpi_data> oList_Floor_kpi_data = Props.Copy_Prop_Values_From_Api_Response<List<Floor_kpi_data>>(_MongoDb.Get_Floor_Kpi_Data_By_Where(
                        START_DATE: StartDate,
                        END_DATE: CurrentDate,
                        ENUM_TIMESPAN: DALC.Enum_Timespan.X_DAILY_COLLECTION,
                        ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: List_Organization_data_source_kpi_ID,
                        FLOOR_ID_LIST: null
                    ));
                    List<Floor_kpi_data> oList_Floor_kpi_data_To_Save = new List<Floor_kpi_data>();

                    if (oList_Floor_kpi_data != null && oList_Floor_kpi_data.Count > 0)
                    {
                        #region Calculate Trendline Data

                        if (oList_Organization_data_source_kpi_Trendline != null && oList_Organization_data_source_kpi_Trendline.Count > 0)
                        {
                            List<Floor_kpi_data> oList_Floor_kpi_data_Trendline = oList_Floor_kpi_data.Where(oFloor_kpi => oList_Organization_data_source_kpi_Trendline.Any(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == oFloor_kpi.FLOOR_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID)).ToList();

                            if (oList_Floor_kpi_data_Trendline != null && oList_Floor_kpi_data_Trendline.Count > 0)
                            {
                                List<Floor_kpi_data> oList_Floor_kpi_data_Trendline_To_Save = oList_Floor_kpi_data_Trendline
                                                   .GroupBy(floor_kpi_data => new
                                                   {
                                                       floor_kpi_data.FLOOR_METADATA.FLOOR_ID,
                                                       floor_kpi_data.FLOOR_METADATA.CATEGORY,
                                                       floor_kpi_data.FLOOR_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                   })
                                                   .Select(floor_kpi_data => new Floor_kpi_data()
                                                   {
                                                       FLOOR_METADATA = new Floor_metadata()
                                                       {
                                                           FLOOR_ID = floor_kpi_data.Key.FLOOR_ID,
                                                           CATEGORY = floor_kpi_data.Key.CATEGORY,
                                                           ORGANIZATION_DATA_SOURCE_KPI_ID = floor_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                       },
                                                       RECORD_DATE = StartDate,
                                                       VALUE_PER_SQM = i_Params_Compute_Floor_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == floor_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? floor_kpi_data.Average(index => index.VALUE_PER_SQM) : floor_kpi_data.Sum(index => index.VALUE_PER_SQM),
                                                       VALUE_NAME = i_Params_Compute_Floor_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == floor_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? StartDate.Year + " Week " + Get_Week_Of_Year(new Params_Get_Week_Of_Year()
                                                       {
                                                           DAY = StartDate.Day,
                                                           YEAR = StartDate.Year,
                                                           MONTH = StartDate.Month,
                                                       }) : floor_kpi_data.First().VALUE_NAME,
                                                       VALUE = i_Params_Compute_Floor_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == floor_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_ADDITIVE_DATA ? floor_kpi_data.Sum(index => index.VALUE) : floor_kpi_data.Average(index => index.VALUE),
                                                   }).ToList();
                                oList_Floor_kpi_data_To_Save = oList_Floor_kpi_data_To_Save.Concat(oList_Floor_kpi_data_Trendline_To_Save).ToList();
                            }
                        }

                        #endregion

                        #region Calculate Non Trendline Data

                        if (oList_Organization_data_source_kpi_Non_Trendline != null && oList_Organization_data_source_kpi_Non_Trendline.Count > 0)
                        {
                            List<Floor_kpi_data> oList_Floor_kpi_data_Non_Trendline = oList_Floor_kpi_data.Where(oFloor_kpi => oList_Organization_data_source_kpi_Non_Trendline.Any(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == oFloor_kpi.FLOOR_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID)).ToList();

                            if (oList_Floor_kpi_data_Non_Trendline != null && oList_Floor_kpi_data_Non_Trendline.Count > 0)
                            {
                                List<Floor_kpi_data> oList_Floor_kpi_data_Non_Trendline_To_Save = oList_Floor_kpi_data_Non_Trendline
                                                   .GroupBy(floor_kpi_data => new
                                                   {
                                                       floor_kpi_data.FLOOR_METADATA.FLOOR_ID,
                                                       floor_kpi_data.FLOOR_METADATA.CATEGORY,
                                                       floor_kpi_data.FLOOR_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                       floor_kpi_data.VALUE_NAME
                                                   })
                                                   .Select(floor_kpi_data => new Floor_kpi_data()
                                                   {
                                                       FLOOR_METADATA = new Floor_metadata()
                                                       {
                                                           FLOOR_ID = floor_kpi_data.Key.FLOOR_ID,
                                                           CATEGORY = floor_kpi_data.Key.CATEGORY,
                                                           ORGANIZATION_DATA_SOURCE_KPI_ID = floor_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                       },
                                                       RECORD_DATE = StartDate,
                                                       VALUE_PER_SQM = i_Params_Compute_Floor_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == floor_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? floor_kpi_data.Average(index => index.VALUE_PER_SQM) : floor_kpi_data.Sum(index => index.VALUE_PER_SQM),
                                                       VALUE_NAME = i_Params_Compute_Floor_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == floor_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? StartDate.Year + " Week " + Get_Week_Of_Year(new Params_Get_Week_Of_Year()
                                                       {
                                                           DAY = StartDate.Day,
                                                           YEAR = StartDate.Year,
                                                           MONTH = StartDate.Month,
                                                       }) : floor_kpi_data.First().VALUE_NAME,
                                                       VALUE = i_Params_Compute_Floor_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == floor_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_ADDITIVE_DATA ? floor_kpi_data.Sum(index => index.VALUE) : floor_kpi_data.Average(index => index.VALUE),
                                                   }).ToList();

                                oList_Floor_kpi_data_To_Save = oList_Floor_kpi_data_To_Save.Concat(oList_Floor_kpi_data_Non_Trendline_To_Save).ToList();
                            }
                        }

                        #endregion

                        if (oList_Floor_kpi_data_To_Save?.Count > 0)
                        {
                            try
                            {
                                Edit_Floor_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN(new Params_Edit_Floor_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN()
                                {
                                    LIST_FLOOR_KPI_DATA = oList_Floor_kpi_data_To_Save,
                                    LIST_ORGANIZATION_DATA_SOURCE_KPI_ID = i_Params_Compute_Floor_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList(),
                                    RECORD_DATE = StartDate,
                                    ENUM_TIMESPAN = Enum_Timespan.X_WEEKLY_COLLECTION
                                });
                            }
                            catch (Exception ex)
                            {
                                throw new BLC_Exception(ex.Message);
                            }
                        }
                    }
                }
            }
        }
        #endregion
        #region Compute_Floor_Kpi_Data_Monthly
        public void Compute_Floor_Kpi_Data_Monthly(Params_Compute_Floor_Kpi_Data_Monthly i_Params_Compute_Floor_Kpi_Data_Monthly)
        {
            if (i_Params_Compute_Floor_Kpi_Data_Monthly != null)
            {
                if (i_Params_Compute_Floor_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI != null && i_Params_Compute_Floor_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Count() > 0)
                {
                    DateTime CurrentDate = new DateTime(i_Params_Compute_Floor_Kpi_Data_Monthly.YEAR, i_Params_Compute_Floor_Kpi_Data_Monthly.MONTH, 1);
                    DateTime StartDate = CurrentDate.AddMonths(-1);
                    List<Organization_data_source_kpi> oList_Organization_data_source_kpi_Trendline = i_Params_Compute_Floor_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.IS_TRENDLINE == true).ToList();
                    List<Organization_data_source_kpi> oList_Organization_data_source_kpi_Non_Trendline = i_Params_Compute_Floor_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.IS_TRENDLINE == false).ToList();
                    List<int?> List_Organization_data_source_kpi_ID = i_Params_Compute_Floor_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();
                    List<Floor_kpi_data> oList_Floor_kpi_data = Props.Copy_Prop_Values_From_Api_Response<List<Floor_kpi_data>>(_MongoDb.Get_Floor_Kpi_Data_By_Where(
                        START_DATE: StartDate,
                        END_DATE: CurrentDate,
                        ENUM_TIMESPAN: DALC.Enum_Timespan.X_DAILY_COLLECTION,
                        ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: List_Organization_data_source_kpi_ID,
                        FLOOR_ID_LIST: null
                    ));
                    List<Floor_kpi_data> oList_Floor_kpi_data_To_Save = new List<Floor_kpi_data>();

                    if (oList_Floor_kpi_data != null && oList_Floor_kpi_data.Count > 0)
                    {
                        #region Calculate Trendline Data

                        if (oList_Organization_data_source_kpi_Trendline != null && oList_Organization_data_source_kpi_Trendline.Count > 0)
                        {
                            List<Floor_kpi_data> oList_Floor_kpi_data_Trendline = oList_Floor_kpi_data.Where(oFloor_kpi => oList_Organization_data_source_kpi_Trendline.Any(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == oFloor_kpi.FLOOR_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID)).ToList();

                            if (oList_Floor_kpi_data_Trendline != null && oList_Floor_kpi_data_Trendline.Count > 0)
                            {
                                List<Floor_kpi_data> oList_Floor_kpi_data_Trendline_To_Save = oList_Floor_kpi_data_Trendline
                                                   .GroupBy(floor_kpi_data => new
                                                   {
                                                       floor_kpi_data.FLOOR_METADATA.FLOOR_ID,
                                                       floor_kpi_data.FLOOR_METADATA.CATEGORY,
                                                       floor_kpi_data.FLOOR_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                   })
                                                   .Select(floor_kpi_data => new Floor_kpi_data()
                                                   {
                                                       FLOOR_METADATA = new Floor_metadata()
                                                       {
                                                           FLOOR_ID = floor_kpi_data.Key.FLOOR_ID,
                                                           CATEGORY = floor_kpi_data.Key.CATEGORY,
                                                           ORGANIZATION_DATA_SOURCE_KPI_ID = floor_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                       },
                                                       RECORD_DATE = StartDate,
                                                       VALUE_PER_SQM = i_Params_Compute_Floor_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == floor_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? floor_kpi_data.Average(index => index.VALUE_PER_SQM) : floor_kpi_data.Sum(index => index.VALUE_PER_SQM),
                                                       VALUE_NAME = i_Params_Compute_Floor_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == floor_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? StartDate.Month + "/" + StartDate.Year : floor_kpi_data.MaxBy(oFloor_kpi_data => oFloor_kpi_data.RECORD_DATE).VALUE_NAME,
                                                       VALUE = i_Params_Compute_Floor_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == floor_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_ADDITIVE_DATA ? floor_kpi_data.Sum(index => index.VALUE) : floor_kpi_data.Average(index => index.VALUE),
                                                   }).ToList();
                                oList_Floor_kpi_data_To_Save = oList_Floor_kpi_data_To_Save.Concat(oList_Floor_kpi_data_Trendline_To_Save).ToList();
                            }
                        }

                        #endregion

                        #region Calculate Non Trendline Data

                        if (oList_Organization_data_source_kpi_Non_Trendline != null && oList_Organization_data_source_kpi_Non_Trendline.Count > 0)
                        {
                            List<Floor_kpi_data> oList_Floor_kpi_data_Non_Trendline = oList_Floor_kpi_data.Where(oFloor_kpi => oList_Organization_data_source_kpi_Non_Trendline.Any(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == oFloor_kpi.FLOOR_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID)).ToList();

                            if (oList_Floor_kpi_data_Non_Trendline != null && oList_Floor_kpi_data_Non_Trendline.Count > 0)
                            {
                                List<Floor_kpi_data> oList_Floor_kpi_data_Non_Trendline_To_Save = oList_Floor_kpi_data_Non_Trendline
                                                   .GroupBy(floor_kpi_data => new
                                                   {
                                                       floor_kpi_data.FLOOR_METADATA.FLOOR_ID,
                                                       floor_kpi_data.FLOOR_METADATA.CATEGORY,
                                                       floor_kpi_data.FLOOR_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                       floor_kpi_data.VALUE_NAME
                                                   })
                                                   .Select(floor_kpi_data => new Floor_kpi_data()
                                                   {
                                                       FLOOR_METADATA = new Floor_metadata()
                                                       {
                                                           FLOOR_ID = floor_kpi_data.Key.FLOOR_ID,
                                                           CATEGORY = floor_kpi_data.Key.CATEGORY,
                                                           ORGANIZATION_DATA_SOURCE_KPI_ID = floor_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                       },
                                                       RECORD_DATE = StartDate,
                                                       VALUE_PER_SQM = i_Params_Compute_Floor_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == floor_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? floor_kpi_data.Average(index => index.VALUE_PER_SQM) : floor_kpi_data.Sum(index => index.VALUE_PER_SQM),
                                                       VALUE_NAME = i_Params_Compute_Floor_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == floor_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? StartDate.Month + "/" + StartDate.Year : floor_kpi_data.MaxBy(oFloor_kpi_data => oFloor_kpi_data.RECORD_DATE).VALUE_NAME,
                                                       VALUE = i_Params_Compute_Floor_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == floor_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_ADDITIVE_DATA ? floor_kpi_data.Sum(index => index.VALUE) : floor_kpi_data.Average(index => index.VALUE),
                                                   }).ToList();

                                oList_Floor_kpi_data_To_Save = oList_Floor_kpi_data_To_Save.Concat(oList_Floor_kpi_data_Non_Trendline_To_Save).ToList();
                            }
                        }

                        #endregion

                        if (oList_Floor_kpi_data_To_Save?.Count > 0)
                        {
                            try
                            {
                                Edit_Floor_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN(new Params_Edit_Floor_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN()
                                {
                                    LIST_FLOOR_KPI_DATA = oList_Floor_kpi_data_To_Save,
                                    LIST_ORGANIZATION_DATA_SOURCE_KPI_ID = i_Params_Compute_Floor_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList(),
                                    RECORD_DATE = StartDate,
                                    ENUM_TIMESPAN = Enum_Timespan.X_MONTHLY_COLLECTION
                                });
                            }
                            catch (Exception ex)
                            {
                                throw new BLC_Exception(ex.Message);
                            }
                        }
                    }
                }
            }
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
        #region Get_Space_Kpi_Data_By_Where
        public List<Space_kpi_data> Get_Space_Kpi_Data_By_Where(Params_Get_Space_Kpi_Data_By_Where i_Params_Get_Space_Kpi_Data_By_Where)
        {
            return Props.Copy_Prop_Values_From_Api_Response<List<Space_kpi_data>>(
                this._MongoDb.Get_Space_Kpi_Data_By_Where
                (
                    END_DATE: i_Params_Get_Space_Kpi_Data_By_Where.END_DATE,
                    START_DATE: i_Params_Get_Space_Kpi_Data_By_Where.START_DATE,
                    ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: i_Params_Get_Space_Kpi_Data_By_Where.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST,
                    SPACE_ID_LIST: i_Params_Get_Space_Kpi_Data_By_Where.SPACE_ID_LIST,
                    ENUM_TIMESPAN: (DALC.Enum_Timespan)i_Params_Get_Space_Kpi_Data_By_Where.ENUM_TIMESPAN
                )
            );
        }
        #endregion
        #region Compute_Space_Kpi_Data_Daily
        public void Compute_Space_Kpi_Data_Daily(Params_Compute_Space_Kpi_Data_Daily i_Params_Compute_Space_Kpi_Data_Daily)
        {
            if (i_Params_Compute_Space_Kpi_Data_Daily != null)
            {
                if (i_Params_Compute_Space_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI != null && i_Params_Compute_Space_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Count() > 0)
                {
                    DateTime CurrentDate = new DateTime(i_Params_Compute_Space_Kpi_Data_Daily.YEAR, i_Params_Compute_Space_Kpi_Data_Daily.MONTH, i_Params_Compute_Space_Kpi_Data_Daily.DAY);
                    DateTime StartDate = CurrentDate.AddDays(-1);
                    List<Organization_data_source_kpi> oList_Organization_data_source_kpi_Trendline = i_Params_Compute_Space_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.IS_TRENDLINE == true).ToList();
                    List<Organization_data_source_kpi> oList_Organization_data_source_kpi_Non_Trendline = i_Params_Compute_Space_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.IS_TRENDLINE == false).ToList();
                    List<int?> List_Organization_data_source_kpi_ID = i_Params_Compute_Space_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();
                    List<Space_kpi_data> oList_Space_kpi_data = Props.Copy_Prop_Values_From_Api_Response<List<Space_kpi_data>>(_MongoDb.Get_Space_Kpi_Data_By_Where(
                        START_DATE: StartDate,
                        END_DATE: CurrentDate,
                        ENUM_TIMESPAN: DALC.Enum_Timespan.X_HOURLY_COLLECTION,
                        ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: List_Organization_data_source_kpi_ID,
                        SPACE_ID_LIST: null
                    ));
                    List<Space_kpi_data> oList_Space_kpi_data_To_Save = new List<Space_kpi_data>();

                    if (oList_Space_kpi_data != null && oList_Space_kpi_data.Count > 0)
                    {
                        #region Calculate Trendline Data

                        if (oList_Organization_data_source_kpi_Trendline != null && oList_Organization_data_source_kpi_Trendline.Count > 0)
                        {
                            List<Space_kpi_data> oList_Space_kpi_data_Trendline = oList_Space_kpi_data.Where(oSpace_kpi => oList_Organization_data_source_kpi_Trendline.Any(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == oSpace_kpi.SPACE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID)).ToList();

                            if (oList_Space_kpi_data_Trendline != null && oList_Space_kpi_data_Trendline.Count > 0)
                            {
                                List<Space_kpi_data> oList_Space_kpi_data_Trendline_To_Save = oList_Space_kpi_data_Trendline
                                                   .GroupBy(space_kpi_data => new
                                                   {
                                                       space_kpi_data.SPACE_METADATA.SPACE_ID,
                                                       space_kpi_data.SPACE_METADATA.CATEGORY,
                                                       space_kpi_data.SPACE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                   })
                                                   .Select(space_kpi_data => new Space_kpi_data()
                                                   {
                                                       SPACE_METADATA = new Space_metadata()
                                                       {
                                                           SPACE_ID = space_kpi_data.Key.SPACE_ID,
                                                           CATEGORY = space_kpi_data.Key.CATEGORY,
                                                           ORGANIZATION_DATA_SOURCE_KPI_ID = space_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                       },
                                                       RECORD_DATE = StartDate,
                                                       VALUE_PER_SQM = i_Params_Compute_Space_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == space_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? space_kpi_data.Average(index => index.VALUE_PER_SQM) : space_kpi_data.Sum(index => index.VALUE_PER_SQM),
                                                       VALUE_NAME = i_Params_Compute_Space_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == space_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? StartDate.ToShortDateString() : space_kpi_data.First().VALUE_NAME,
                                                       VALUE = i_Params_Compute_Space_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == space_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_ADDITIVE_DATA ? space_kpi_data.Sum(index => index.VALUE) : space_kpi_data.Average(index => index.VALUE),
                                                   }).ToList();

                                oList_Space_kpi_data_To_Save = oList_Space_kpi_data_To_Save.Concat(oList_Space_kpi_data_Trendline_To_Save).ToList();
                            }
                        }

                        #endregion

                        #region Calculate Non Trendline Data

                        if (oList_Organization_data_source_kpi_Non_Trendline != null && oList_Organization_data_source_kpi_Non_Trendline.Count > 0)
                        {
                            List<Space_kpi_data> oList_Space_kpi_data_Non_Trendline = oList_Space_kpi_data.Where(oSpace_kpi => oList_Organization_data_source_kpi_Non_Trendline.Any(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == oSpace_kpi.SPACE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID)).ToList();

                            if (oList_Space_kpi_data_Non_Trendline != null && oList_Space_kpi_data_Non_Trendline.Count > 0)
                            {
                                List<Space_kpi_data> oList_Space_kpi_data_Non_Trendline_To_Save = oList_Space_kpi_data_Non_Trendline
                                                   .GroupBy(space_kpi_data => new
                                                   {
                                                       space_kpi_data.SPACE_METADATA.SPACE_ID,
                                                       space_kpi_data.SPACE_METADATA.CATEGORY,
                                                       space_kpi_data.SPACE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                       space_kpi_data.VALUE_NAME
                                                   })
                                                   .Select(space_kpi_data => new Space_kpi_data()
                                                   {
                                                       SPACE_METADATA = new Space_metadata()
                                                       {
                                                           SPACE_ID = space_kpi_data.Key.SPACE_ID,
                                                           CATEGORY = space_kpi_data.Key.CATEGORY,
                                                           ORGANIZATION_DATA_SOURCE_KPI_ID = space_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                       },
                                                       RECORD_DATE = StartDate,
                                                       VALUE_PER_SQM = i_Params_Compute_Space_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == space_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? space_kpi_data.Average(index => index.VALUE_PER_SQM) : space_kpi_data.Sum(index => index.VALUE_PER_SQM),
                                                       VALUE_NAME = i_Params_Compute_Space_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == space_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? StartDate.ToShortDateString() : space_kpi_data.First().VALUE_NAME,
                                                       VALUE = i_Params_Compute_Space_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == space_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_ADDITIVE_DATA ? space_kpi_data.Sum(index => index.VALUE) : space_kpi_data.Average(index => index.VALUE),
                                                   }).ToList();

                                oList_Space_kpi_data_To_Save = oList_Space_kpi_data_To_Save.Concat(oList_Space_kpi_data_Non_Trendline_To_Save).ToList();
                            }
                        }

                        #endregion

                        if (oList_Space_kpi_data_To_Save?.Count > 0)
                        {
                            try
                            {
                                Edit_Space_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN(new Params_Edit_Space_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN()
                                {
                                    LIST_SPACE_KPI_DATA = oList_Space_kpi_data,
                                    LIST_ORGANIZATION_DATA_SOURCE_KPI_ID = i_Params_Compute_Space_Kpi_Data_Daily.LIST_ORGANIZATION_DATA_SOURCE_KPI.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList(),
                                    RECORD_DATE = StartDate,
                                    ENUM_TIMESPAN = Enum_Timespan.X_DAILY_COLLECTION
                                });
                            }
                            catch (Exception ex)
                            {
                                throw new BLC_Exception(ex.Message);
                            }
                        }
                    }
                }
            }
        }
        #endregion
        #region Compute_Space_Kpi_Data_Weekly
        public void Compute_Space_Kpi_Data_Weekly(Params_Compute_Space_Kpi_Data_Weekly i_Params_Compute_Space_Kpi_Data_Weekly)
        {
            if (i_Params_Compute_Space_Kpi_Data_Weekly != null)
            {
                if (i_Params_Compute_Space_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI != null && i_Params_Compute_Space_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Count() > 0)
                {
                    DateTime CurrentDate = new DateTime(i_Params_Compute_Space_Kpi_Data_Weekly.YEAR, i_Params_Compute_Space_Kpi_Data_Weekly.MONTH, i_Params_Compute_Space_Kpi_Data_Weekly.DAY);
                    DateTime StartDate = CurrentDate.AddDays(-7);
                    List<Organization_data_source_kpi> oList_Organization_data_source_kpi_Trendline = i_Params_Compute_Space_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.IS_TRENDLINE == true).ToList();
                    List<Organization_data_source_kpi> oList_Organization_data_source_kpi_Non_Trendline = i_Params_Compute_Space_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.IS_TRENDLINE == false).ToList();
                    List<int?> oList_Kpi = i_Params_Compute_Space_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();
                    List<Space_kpi_data> oList_Space_kpi_data = Get_Space_Kpi_Data_By_Where(new Params_Get_Space_Kpi_Data_By_Where()
                    {
                        START_DATE = StartDate,
                        END_DATE = CurrentDate,
                        ENUM_TIMESPAN = Enum_Timespan.X_DAILY_COLLECTION,
                        ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = oList_Kpi,
                    });
                    List<Space_kpi_data> oList_Space_kpi_data_To_Save = new List<Space_kpi_data>();

                    if (oList_Space_kpi_data != null && oList_Space_kpi_data.Count > 0)
                    {
                        #region Calculate Trendline Data

                        if (oList_Organization_data_source_kpi_Trendline != null && oList_Organization_data_source_kpi_Trendline.Count > 0)
                        {
                            List<Space_kpi_data> oList_Space_kpi_data_Trendline = oList_Space_kpi_data.Where(oSpace_kpi => oList_Organization_data_source_kpi_Trendline.Any(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == oSpace_kpi.SPACE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID)).ToList();

                            if (oList_Space_kpi_data_Trendline != null && oList_Space_kpi_data_Trendline.Count > 0)
                            {
                                List<Space_kpi_data> oList_Space_kpi_data_Trendline_To_Save = oList_Space_kpi_data_Trendline
                                                   .GroupBy(space_kpi_data => new
                                                   {
                                                       space_kpi_data.SPACE_METADATA.SPACE_ID,
                                                       space_kpi_data.SPACE_METADATA.CATEGORY,
                                                       space_kpi_data.SPACE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                   })
                                                   .Select(space_kpi_data => new Space_kpi_data()
                                                   {
                                                       SPACE_METADATA = new Space_metadata()
                                                       {
                                                           SPACE_ID = space_kpi_data.Key.SPACE_ID,
                                                           CATEGORY = space_kpi_data.Key.CATEGORY,
                                                           ORGANIZATION_DATA_SOURCE_KPI_ID = space_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                       },
                                                       RECORD_DATE = StartDate,
                                                       VALUE_PER_SQM = i_Params_Compute_Space_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == space_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? space_kpi_data.Average(index => index.VALUE_PER_SQM) : space_kpi_data.Sum(index => index.VALUE_PER_SQM),
                                                       VALUE_NAME = i_Params_Compute_Space_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == space_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? i_Params_Compute_Space_Kpi_Data_Weekly.YEAR + " Week " + Get_Week_Of_Year(new Params_Get_Week_Of_Year()
                                                       {
                                                           DAY = StartDate.Day,
                                                           YEAR = StartDate.Year,
                                                           MONTH = StartDate.Month,
                                                       }) : space_kpi_data.First().VALUE_NAME,
                                                       VALUE = i_Params_Compute_Space_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == space_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_ADDITIVE_DATA ? space_kpi_data.Sum(index => index.VALUE) : space_kpi_data.Average(index => index.VALUE),
                                                   }).ToList();
                                oList_Space_kpi_data_To_Save = oList_Space_kpi_data_To_Save.Concat(oList_Space_kpi_data_Trendline_To_Save).ToList();
                            }
                        }

                        #endregion

                        #region Calculate Non Trendline Data

                        if (oList_Organization_data_source_kpi_Non_Trendline != null && oList_Organization_data_source_kpi_Non_Trendline.Count > 0)
                        {
                            List<Space_kpi_data> oList_Space_kpi_data_Non_Trendline = oList_Space_kpi_data.Where(oSpace_kpi => oList_Organization_data_source_kpi_Non_Trendline.Any(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == oSpace_kpi.SPACE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID)).ToList();

                            if (oList_Space_kpi_data_Non_Trendline != null && oList_Space_kpi_data_Non_Trendline.Count > 0)
                            {
                                List<Space_kpi_data> oList_Space_kpi_data_Non_Trendline_To_Save = oList_Space_kpi_data_Non_Trendline
                                                   .GroupBy(space_kpi_data => new
                                                   {
                                                       space_kpi_data.SPACE_METADATA.SPACE_ID,
                                                       space_kpi_data.SPACE_METADATA.CATEGORY,
                                                       space_kpi_data.SPACE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                       space_kpi_data.VALUE_NAME
                                                   })
                                                   .Select(space_kpi_data => new Space_kpi_data()
                                                   {
                                                       SPACE_METADATA = new Space_metadata()
                                                       {
                                                           SPACE_ID = space_kpi_data.Key.SPACE_ID,
                                                           CATEGORY = space_kpi_data.Key.CATEGORY,
                                                           ORGANIZATION_DATA_SOURCE_KPI_ID = space_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                       },
                                                       RECORD_DATE = StartDate,
                                                       VALUE_PER_SQM = i_Params_Compute_Space_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == space_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? space_kpi_data.Average(index => index.VALUE_PER_SQM) : space_kpi_data.Sum(index => index.VALUE_PER_SQM),
                                                       VALUE_NAME = i_Params_Compute_Space_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == space_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? i_Params_Compute_Space_Kpi_Data_Weekly.YEAR + " Week " + Get_Week_Of_Year(new Params_Get_Week_Of_Year()
                                                       {
                                                           DAY = StartDate.Day,
                                                           YEAR = StartDate.Year,
                                                           MONTH = StartDate.Month,
                                                       }) : space_kpi_data.First().VALUE_NAME,
                                                       VALUE = i_Params_Compute_Space_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == space_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_ADDITIVE_DATA ? space_kpi_data.Sum(index => index.VALUE) : space_kpi_data.Average(index => index.VALUE),
                                                   }).ToList();

                                oList_Space_kpi_data_To_Save = oList_Space_kpi_data_To_Save.Concat(oList_Space_kpi_data_Non_Trendline_To_Save).ToList();
                            }
                        }

                        #endregion

                        if (oList_Space_kpi_data_To_Save?.Count > 0)
                        {
                            try
                            {
                                Edit_Space_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN(new Params_Edit_Space_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN()
                                {
                                    LIST_SPACE_KPI_DATA = oList_Space_kpi_data,
                                    LIST_ORGANIZATION_DATA_SOURCE_KPI_ID = i_Params_Compute_Space_Kpi_Data_Weekly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList(),
                                    RECORD_DATE = StartDate,
                                    ENUM_TIMESPAN = Enum_Timespan.X_WEEKLY_COLLECTION
                                });
                            }
                            catch (Exception ex)
                            {
                                throw new BLC_Exception(ex.Message);
                            }
                        }
                    }
                }
            }
        }
        #endregion
        #region Compute_Space_Kpi_Data_Monthly
        public void Compute_Space_Kpi_Data_Monthly(Params_Compute_Space_Kpi_Data_Monthly i_Params_Compute_Space_Kpi_Data_Monthly)
        {
            if (i_Params_Compute_Space_Kpi_Data_Monthly != null)
            {
                if (i_Params_Compute_Space_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI != null && i_Params_Compute_Space_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Count() > 0)
                {
                    DateTime CurrentDate = new DateTime(i_Params_Compute_Space_Kpi_Data_Monthly.YEAR, i_Params_Compute_Space_Kpi_Data_Monthly.MONTH, 1);
                    DateTime StartDate = CurrentDate.AddMonths(-1);
                    List<Organization_data_source_kpi> oList_Organization_data_source_kpi_Trendline = i_Params_Compute_Space_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.IS_TRENDLINE == true).ToList();
                    List<Organization_data_source_kpi> oList_Organization_data_source_kpi_Non_Trendline = i_Params_Compute_Space_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.IS_TRENDLINE == false).ToList();
                    List<int?> oList_Kpi = i_Params_Compute_Space_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();
                    List<Space_kpi_data> oList_Space_kpi_data = Get_Space_Kpi_Data_By_Where(new Params_Get_Space_Kpi_Data_By_Where()
                    {
                        START_DATE = StartDate,
                        END_DATE = CurrentDate,
                        ENUM_TIMESPAN = Enum_Timespan.X_DAILY_COLLECTION,
                        ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = oList_Kpi,
                    });
                    List<Space_kpi_data> oList_Space_kpi_data_To_Save = new List<Space_kpi_data>();

                    if (oList_Space_kpi_data != null && oList_Space_kpi_data.Count > 0)
                    {
                        #region Calculate Trendline Data

                        if (oList_Organization_data_source_kpi_Trendline != null && oList_Organization_data_source_kpi_Trendline.Count > 0)
                        {
                            List<Space_kpi_data> oList_Space_kpi_data_Trendline = oList_Space_kpi_data.Where(oSpace_kpi => oList_Organization_data_source_kpi_Trendline.Any(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == oSpace_kpi.SPACE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID)).ToList();

                            if (oList_Space_kpi_data_Trendline != null && oList_Space_kpi_data_Trendline.Count > 0)
                            {
                                List<Space_kpi_data> oList_Space_kpi_data_Trendline_To_Save = oList_Space_kpi_data_Trendline
                                                   .GroupBy(space_kpi_data => new
                                                   {
                                                       space_kpi_data.SPACE_METADATA.SPACE_ID,
                                                       space_kpi_data.SPACE_METADATA.CATEGORY,
                                                       space_kpi_data.SPACE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                   })
                                                   .Select(space_kpi_data => new Space_kpi_data()
                                                   {
                                                       SPACE_METADATA = new Space_metadata()
                                                       {
                                                           SPACE_ID = space_kpi_data.Key.SPACE_ID,
                                                           CATEGORY = space_kpi_data.Key.CATEGORY,
                                                           ORGANIZATION_DATA_SOURCE_KPI_ID = space_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                       },
                                                       RECORD_DATE = StartDate,
                                                       VALUE_PER_SQM = i_Params_Compute_Space_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == space_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? space_kpi_data.Average(index => index.VALUE_PER_SQM) : space_kpi_data.Sum(index => index.VALUE_PER_SQM),
                                                       VALUE_NAME = i_Params_Compute_Space_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == space_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? StartDate.Month + "/" + StartDate.Year : space_kpi_data.First().VALUE_NAME,
                                                       VALUE = i_Params_Compute_Space_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == space_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_ADDITIVE_DATA ? space_kpi_data.Sum(index => index.VALUE) : space_kpi_data.Average(index => index.VALUE),
                                                   }).ToList();
                                oList_Space_kpi_data_To_Save = oList_Space_kpi_data_To_Save.Concat(oList_Space_kpi_data_Trendline_To_Save).ToList();
                            }
                        }

                        #endregion

                        #region Calculate Non Trendline Data

                        if (oList_Organization_data_source_kpi_Non_Trendline != null && oList_Organization_data_source_kpi_Non_Trendline.Count > 0)
                        {
                            List<Space_kpi_data> oList_Space_kpi_data_Non_Trendline = oList_Space_kpi_data.Where(oSpace_kpi => oList_Organization_data_source_kpi_Non_Trendline.Any(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == oSpace_kpi.SPACE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID)).ToList();

                            if (oList_Space_kpi_data_Non_Trendline != null && oList_Space_kpi_data_Non_Trendline.Count > 0)
                            {
                                List<Space_kpi_data> oList_Space_kpi_data_Non_Trendline_To_Save = oList_Space_kpi_data_Non_Trendline
                                                   .GroupBy(space_kpi_data => new
                                                   {
                                                       space_kpi_data.SPACE_METADATA.SPACE_ID,
                                                       space_kpi_data.SPACE_METADATA.CATEGORY,
                                                       space_kpi_data.SPACE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                       space_kpi_data.VALUE_NAME
                                                   })
                                                   .Select(space_kpi_data => new Space_kpi_data()
                                                   {
                                                       SPACE_METADATA = new Space_metadata()
                                                       {
                                                           SPACE_ID = space_kpi_data.Key.SPACE_ID,
                                                           CATEGORY = space_kpi_data.Key.CATEGORY,
                                                           ORGANIZATION_DATA_SOURCE_KPI_ID = space_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                       },
                                                       RECORD_DATE = StartDate,
                                                       VALUE_PER_SQM = i_Params_Compute_Space_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == space_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? space_kpi_data.Average(index => index.VALUE_PER_SQM) : space_kpi_data.Sum(index => index.VALUE_PER_SQM),
                                                       VALUE_NAME = i_Params_Compute_Space_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == space_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_TRENDLINE ? StartDate.Month + "/" + StartDate.Year : space_kpi_data.First().VALUE_NAME,
                                                       VALUE = i_Params_Compute_Space_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == space_kpi_data.Key.ORGANIZATION_DATA_SOURCE_KPI_ID).Kpi.IS_ADDITIVE_DATA ? space_kpi_data.Sum(index => index.VALUE) : space_kpi_data.Average(index => index.VALUE),
                                                   }).ToList();

                                oList_Space_kpi_data_To_Save = oList_Space_kpi_data_To_Save.Concat(oList_Space_kpi_data_Non_Trendline_To_Save).ToList();
                            }
                        }

                        #endregion

                        if (oList_Space_kpi_data_To_Save?.Count > 0)
                        {
                            try
                            {
                                Edit_Space_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN(new Params_Edit_Space_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN()
                                {
                                    LIST_SPACE_KPI_DATA = oList_Space_kpi_data,
                                    LIST_ORGANIZATION_DATA_SOURCE_KPI_ID = i_Params_Compute_Space_Kpi_Data_Monthly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList(),
                                    RECORD_DATE = StartDate,
                                    ENUM_TIMESPAN = Enum_Timespan.X_MONTHLY_COLLECTION
                                });
                            }
                            catch (Exception ex)
                            {
                                throw new BLC_Exception(ex.Message);
                            }
                        }
                    }
                }
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
                    ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: i_Params_Get_Alerts_By_Where.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST,
                    LEVEL_SETUP_ID: i_Params_Get_Alerts_By_Where.LEVEL_SETUP_ID,
                    LEVEL_ID_LIST: i_Params_Get_Alerts_By_Where.LEVEL_ID_LIST
                )
            );
        }
        #endregion
        #region Get_Alerts_By_Where_Count
        public long? Get_Alerts_By_Where_Count(Params_Get_Alerts_By_Where_Count i_Params_Get_Alerts_By_Where_Count)
        {
            return this._MongoDb.Get_Alerts_By_Where_Count(
                END_DATE: i_Params_Get_Alerts_By_Where_Count.END_DATE,
                START_DATE: i_Params_Get_Alerts_By_Where_Count.START_DATE,
                ALERT_ID_LIST: i_Params_Get_Alerts_By_Where_Count.ALERT_ID_LIST,
                USER_ID_LIST: i_Params_Get_Alerts_By_Where_Count.USER_ID_LIST,
                IS_ACKNOWLEDGED: i_Params_Get_Alerts_By_Where_Count.IS_ACKNOWLEDGED,
                LEVEL_SETUP_ID: i_Params_Get_Alerts_By_Where_Count.LEVEL_SETUP_ID,
                LEVEL_ID_LIST: i_Params_Get_Alerts_By_Where_Count.LEVEL_ID_LIST,
                ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: i_Params_Get_Alerts_By_Where_Count.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST
            );
        }
        #endregion
        #region Get_Alerts_For_Levels
        public List<Alert> Get_Alerts_For_Levels(Params_Get_Alerts_For_Levels i_Params_Get_Alerts_For_Levels)
        {
            List<Alert> oList_Alert = new List<Alert>();

            #region Declaration & Initialization

            long? District_Setup_ID = 0;
            long? Area_Setup_ID = 0;
            long? Site_Setup_ID = 0;
            List<Alert> oList_District_Alert = new List<Alert>();
            List<Alert> oList_Area_Alert = new List<Alert>();
            List<Alert> oList_Site_Alert = new List<Alert>();

            #endregion

            #region Get Level Setup

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

            #endregion

            #region Get Alerts

            var get_district_alerts = Task.Run(() =>
            {
                oList_District_Alert = Get_Alerts_By_Where(new Params_Get_Alerts_By_Where()
                {
                    START_DATE = i_Params_Get_Alerts_For_Levels.START_DATE,
                    END_DATE = i_Params_Get_Alerts_For_Levels.END_DATE,
                    USER_ID_LIST = i_Params_Get_Alerts_For_Levels.USER_ID_LIST,
                    ALERT_ID_LIST = i_Params_Get_Alerts_For_Levels.ALERT_ID_LIST,
                    IS_ACKNOWLEDGED = i_Params_Get_Alerts_For_Levels.IS_ACKNOWLEDGED,
                    ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = i_Params_Get_Alerts_For_Levels.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST,
                    LEVEL_SETUP_ID = District_Setup_ID,
                    LEVEL_ID_LIST = i_Params_Get_Alerts_For_Levels.DISTRICT_ID_LIST,
                });
            });

            var get_area_alerts = Task.Run(() =>
            {
                oList_Area_Alert = Get_Alerts_By_Where(new Params_Get_Alerts_By_Where()
                {
                    START_DATE = i_Params_Get_Alerts_For_Levels.START_DATE,
                    END_DATE = i_Params_Get_Alerts_For_Levels.END_DATE,
                    USER_ID_LIST = i_Params_Get_Alerts_For_Levels.USER_ID_LIST,
                    ALERT_ID_LIST = i_Params_Get_Alerts_For_Levels.ALERT_ID_LIST,
                    IS_ACKNOWLEDGED = i_Params_Get_Alerts_For_Levels.IS_ACKNOWLEDGED,
                    ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = i_Params_Get_Alerts_For_Levels.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST,
                    LEVEL_SETUP_ID = Area_Setup_ID,
                    LEVEL_ID_LIST = i_Params_Get_Alerts_For_Levels.AREA_ID_LIST,
                });
            });

            var get_site_alerts = Task.Run(() =>
            {
                oList_Site_Alert = Get_Alerts_By_Where(new Params_Get_Alerts_By_Where()
                {
                    START_DATE = i_Params_Get_Alerts_For_Levels.START_DATE,
                    END_DATE = i_Params_Get_Alerts_For_Levels.END_DATE,
                    USER_ID_LIST = i_Params_Get_Alerts_For_Levels.USER_ID_LIST,
                    ALERT_ID_LIST = i_Params_Get_Alerts_For_Levels.ALERT_ID_LIST,
                    IS_ACKNOWLEDGED = i_Params_Get_Alerts_For_Levels.IS_ACKNOWLEDGED,
                    ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = i_Params_Get_Alerts_For_Levels.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST,
                    LEVEL_SETUP_ID = Site_Setup_ID,
                    LEVEL_ID_LIST = i_Params_Get_Alerts_For_Levels.SITE_ID_LIST,
                });
            });

            Task.WaitAll(get_district_alerts, get_area_alerts, get_site_alerts);

            #endregion

            #region Fill List

            oList_Alert = oList_Alert.Concat(oList_District_Alert)
                                    .Concat(oList_Area_Alert)
                                    .Concat(oList_Site_Alert)
                                    .ToList();

            #endregion

            return oList_Alert;
        }
        #endregion
        #region Get_Alerts_Count_For_Levels
        public long? Get_Alerts_Count_For_Levels(Params_Get_Alerts_Count_For_Levels i_Params_Get_Alerts_Count_For_Levels)
        {
            long? Alert_Count = 0;

            #region Declaration & Initialization

            long? District_Setup_ID = 0;
            long? Area_Setup_ID = 0;
            long? Site_Setup_ID = 0;
            long? District_Alert_Count = 0;
            long? Area_Alert_Count = 0;
            long? Site_Alert_Count = 0;

            #endregion

            #region Get Level Setup

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

            #endregion

            #region Get Alerts

            var get_district_alerts = Task.Run(() =>
            {
                District_Alert_Count = Get_Alerts_By_Where_Count(new Params_Get_Alerts_By_Where_Count()
                {
                    START_DATE = i_Params_Get_Alerts_Count_For_Levels.START_DATE,
                    END_DATE = i_Params_Get_Alerts_Count_For_Levels.END_DATE,
                    USER_ID_LIST = i_Params_Get_Alerts_Count_For_Levels.USER_ID_LIST,
                    ALERT_ID_LIST = i_Params_Get_Alerts_Count_For_Levels.ALERT_ID_LIST,
                    IS_ACKNOWLEDGED = i_Params_Get_Alerts_Count_For_Levels.IS_ACKNOWLEDGED,
                    LEVEL_SETUP_ID = District_Setup_ID,
                    LEVEL_ID_LIST = i_Params_Get_Alerts_Count_For_Levels.DISTRICT_ID_LIST,
                    ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = i_Params_Get_Alerts_Count_For_Levels.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST,
                });
            });

            var get_area_alerts = Task.Run(() =>
            {
                Area_Alert_Count = Get_Alerts_By_Where_Count(new Params_Get_Alerts_By_Where_Count()
                {
                    START_DATE = i_Params_Get_Alerts_Count_For_Levels.START_DATE,
                    END_DATE = i_Params_Get_Alerts_Count_For_Levels.END_DATE,
                    USER_ID_LIST = i_Params_Get_Alerts_Count_For_Levels.USER_ID_LIST,
                    ALERT_ID_LIST = i_Params_Get_Alerts_Count_For_Levels.ALERT_ID_LIST,
                    IS_ACKNOWLEDGED = i_Params_Get_Alerts_Count_For_Levels.IS_ACKNOWLEDGED,
                    LEVEL_SETUP_ID = Area_Setup_ID,
                    LEVEL_ID_LIST = i_Params_Get_Alerts_Count_For_Levels.AREA_ID_LIST,
                    ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = i_Params_Get_Alerts_Count_For_Levels.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST,
                });
            });

            var get_site_alerts = Task.Run(() =>
            {
                Site_Alert_Count = Get_Alerts_By_Where_Count(new Params_Get_Alerts_By_Where_Count()
                {
                    START_DATE = i_Params_Get_Alerts_Count_For_Levels.START_DATE,
                    END_DATE = i_Params_Get_Alerts_Count_For_Levels.END_DATE,
                    USER_ID_LIST = i_Params_Get_Alerts_Count_For_Levels.USER_ID_LIST,
                    ALERT_ID_LIST = i_Params_Get_Alerts_Count_For_Levels.ALERT_ID_LIST,
                    IS_ACKNOWLEDGED = i_Params_Get_Alerts_Count_For_Levels.IS_ACKNOWLEDGED,
                    LEVEL_SETUP_ID = Site_Setup_ID,
                    LEVEL_ID_LIST = i_Params_Get_Alerts_Count_For_Levels.SITE_ID_LIST,
                    ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = i_Params_Get_Alerts_Count_For_Levels.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST,
                });
            });

            Task.WaitAll(get_district_alerts, get_area_alerts, get_site_alerts);

            #endregion

            #region Fill List

            Alert_Count = District_Alert_Count + Area_Alert_Count + Site_Alert_Count;

            #endregion

            return Alert_Count;
        }
        #endregion
        #endregion

        #region Get_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID_List
        public string Get_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID_List(Params_Get_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID_List i_Params_Get_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID_List)
        {
            string GEOJSON_SRC = "";

            if (i_Params_Get_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID_List != null && i_Params_Get_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID_List.EXT_STUDY_ZONE_ID_LIST != null && i_Params_Get_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID_List.EXT_STUDY_ZONE_ID_LIST.Count() > 0)
            {
                List<BsonDocument> oList_BsonDocument = _MongoDb.Get_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID_List(i_Params_Get_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID_List.EXT_STUDY_ZONE_ID_LIST);
                if (oList_BsonDocument != null && oList_BsonDocument.Count > 0)
                {
                    GEOJSON_SRC = string.Join(",", oList_BsonDocument);
                }
                GEOJSON_SRC = "{\"type\": \"FeatureCollection\",\"features\": [" + GEOJSON_SRC + "]}";
            }

            return GEOJSON_SRC;
        }
        #endregion

        #region Get_Kpi_chart_configuration
        public List<Kpi_chart_configuration> Get_Kpi_chart_configuration()
        {
            List<Kpi_chart_configuration> oList_Kpi_chart_configuration = null;

            IEnumerable<DALC.Kpi_chart_configuration> oList_DBEntry = _MongoDb.Get_Kpi_chart_configuration();
            if (oList_DBEntry != null)
            {
                oList_Kpi_chart_configuration = new List<Kpi_chart_configuration>();
                if (oList_DBEntry.Count() > 0)
                {
                    oList_Kpi_chart_configuration = Props.Copy_Prop_Values_From_Api_Response<List<Kpi_chart_configuration>>(oList_DBEntry);
                }
            }

            return oList_Kpi_chart_configuration;
        }
        #endregion
        #region Edit_Kpi_chart_configuration
        public void Edit_Kpi_chart_configuration(Kpi_chart_configuration i_Kpi_chart_configuration)
        {
            DALC.Kpi_chart_configuration oKpi_chart_configuration = Props.Copy_Prop_Values_From_Api_Response<DALC.Kpi_chart_configuration>(i_Kpi_chart_configuration);

            i_Kpi_chart_configuration.KPI_CHART_CONFIGURATION_ID = _MongoDb.Edit_Kpi_chart_configuration
            (
                oKpi_chart_configuration
            );
        }
        #endregion

        #region Get_GeoData_By_Where
        public List<GeoData> Get_GeoData_By_Where(Params_Get_GeoData_By_Where i_Params_Get_GeoData_By_Where)
        {
            List<GeoData> oList_GeoData = null;

            IEnumerable<DALC.GeoData> oList_DBEntry = _MongoDb.Get_GeoData_By_Where(
                    START_DATE: i_Params_Get_GeoData_By_Where.START_DATE,
                    END_DATE: i_Params_Get_GeoData_By_Where.END_DATE,
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
        #region Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID
        public List<Business> Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID(Params_Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID i_Params_Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID)
        {
            List<Business> oList_Business = null;

            IEnumerable<DALC.GeoData> oList_DBEntry = _MongoDb.Get_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID(
                i_Params_Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID.ORGANIZATION_DATA_SOURCE_KPI_ID,
                i_Params_Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID.LIST_LEVEL_ID,
                i_Params_Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID.LEVEL_SETUP_ID
               );
            if (oList_DBEntry != null)
            {
                oList_Business = new List<Business>();
                Business oBusiness;

                foreach (DALC.GeoData oGeoData in oList_DBEntry)
                {
                    oBusiness = new Business();
                    oBusiness.Location = new Location();
                    oBusiness.LEVEL_ID = oGeoData.LEVEL_ID;
                    oBusiness.LEVEL_SETUP_ID = oGeoData.LEVEL_SETUP_ID;
                    foreach (DALC.Data oData in oGeoData.DATA_LIST)
                    {
                        if (oData.VALUE == "BsonNull")
                        {
                            continue;
                        }
                        switch (oData.NAME)
                        {
                            case "LIST_BUSINESS_CATEGORY":
                                oBusiness.LIST_BUSINESS_CATEGORY = JsonConvert.DeserializeObject<List<string>>(oData.VALUE);
                                break;
                            case "BUSINESS_NICHE":
                                oBusiness.BUSINESS_NICHE = oData.VALUE;
                                break;
                            case "BUSINESS_STATUS":
                                oBusiness.BUSINESS_STATUS = oData.VALUE;
                                break;
                        }
                    }
                    oList_Business.Add(oBusiness);
                }
            }
            return oList_Business;
        }
        #endregion
        #region Get_Businesses_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID
        public List<Business> Get_Businesses_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID(Params_Get_Businesses_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID i_Params_Get_Businesses_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID)
        {
            List<Business> oList_Business = null;

            IEnumerable<DALC.GeoData> oList_DBEntry = _MongoDb.Get_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID(
                i_Params_Get_Businesses_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID.ORGANIZATION_DATA_SOURCE_KPI_ID,
                i_Params_Get_Businesses_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID.LIST_LEVEL_ID,
                i_Params_Get_Businesses_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID.LEVEL_SETUP_ID
               );
            if (oList_DBEntry != null)
            {
                oList_Business = new List<Business>();
                foreach (DALC.GeoData oGeoData in oList_DBEntry)
                {
                    Business oBusiness = new Business();
                    oBusiness.Location = new Location();
                    oBusiness.BUSINESS_ID = oGeoData.GEODATA_ID;
                    oBusiness.LEVEL_ID = oGeoData.LEVEL_ID;
                    oBusiness.LEVEL_SETUP_ID = oGeoData.LEVEL_SETUP_ID;
                    oBusiness.Location = Props.Copy_Prop_Values_From_Api_Response<Location>(oGeoData.Location);
                    foreach (DALC.Data oData in oGeoData.DATA_LIST)
                    {
                        if (oData.VALUE == "BsonNull")
                        {
                            continue;
                        }
                        switch (oData.NAME)
                        {
                            case "ICON":
                                oBusiness.ICON = oData.VALUE;
                                break;
                            case "ICON_BACKGROUND_COLOR":
                                oBusiness.ICON_BACKGROUND_COLOR = oData.VALUE;
                                break;
                            case "ICON_MASK_BASE_URI":
                                oBusiness.ICON_MASK_BASE_URI = oData.VALUE;
                                break;
                            case "NAME":
                                oBusiness.NAME = oData.VALUE;
                                break;
                            case "PLACE_ID":
                                oBusiness.PLACE_ID = oData.VALUE;
                                break;
                            case "REFERENCE":
                                oBusiness.REFERENCE = oData.VALUE;
                                break;
                            case "SCOPE":
                                oBusiness.SCOPE = oData.VALUE;
                                break;
                            case "LIST_BUSINESS_CATEGORY":
                                oBusiness.LIST_BUSINESS_CATEGORY = JsonConvert.DeserializeObject<List<string>>(oData.VALUE);
                                break;
                            case "BUSINESS_NICHE":
                                oBusiness.BUSINESS_NICHE = oData.VALUE;
                                break;
                            case "VICINITY":
                                oBusiness.VICINITY = oData.VALUE;
                                break;
                            case "BUSINESS_STATUS":
                                oBusiness.BUSINESS_STATUS = oData.VALUE;
                                break;
                            case "RATING":
                                decimal parsed_rating;
                                if (decimal.TryParse(oData.VALUE, out parsed_rating))
                                {
                                    oBusiness.RATING = parsed_rating;
                                }
                                else
                                {
                                    oBusiness.RATING = null;
                                }
                                break;
                            case "USER_RATINGS_TOTAL":
                                long parsed_user_rating_total;
                                if (long.TryParse(oData.VALUE, out parsed_user_rating_total))
                                {
                                    oBusiness.USER_RATINGS_TOTAL = parsed_user_rating_total;
                                }
                                else
                                {
                                    oBusiness.USER_RATINGS_TOTAL = null;
                                }
                                break;
                            case "OPEN_NOW":
                                bool parsed_open_now;
                                if (bool.TryParse(oData.VALUE, out parsed_open_now))
                                {
                                    oBusiness.OPEN_NOW = parsed_open_now;
                                }
                                else
                                {
                                    oBusiness.OPEN_NOW = null;
                                }
                                break;
                            case "PRICE_LEVEL":
                                long parsed_price_level;
                                if (long.TryParse(oData.VALUE, out parsed_price_level))
                                {
                                    oBusiness.PRICE_LEVEL = parsed_price_level;
                                }
                                else
                                {
                                    oBusiness.PRICE_LEVEL = null;
                                }
                                break;
                            case "COMPOUND_CODE":
                                oBusiness.COMPOUND_CODE = oData.VALUE;
                                break;
                            case "GLOBAL_CODE":
                                oBusiness.GLOBAL_CODE = oData.VALUE;
                                break;
                        }
                    }
                    oList_Business.Add(oBusiness);
                }
            }
            return oList_Business;
        }
        #endregion
        #region Get_Bylaw_Complaint_By_Where
        public List<Bylaw_Complaint> Get_Bylaw_Complaint_By_Where(Params_Get_Bylaw_Complaint_By_Where i_Params_Get_Bylaw_Complaint_By_Where)
        {
            List<Bylaw_Complaint> oList_Bylaw_Complaint = null;

            IEnumerable<DALC.GeoData> oList_DBEntry = _MongoDb.Get_GeoData_By_Where(
                    START_DATE: i_Params_Get_Bylaw_Complaint_By_Where.START_DATE,
                    END_DATE: i_Params_Get_Bylaw_Complaint_By_Where.END_DATE,
                    ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: i_Params_Get_Bylaw_Complaint_By_Where.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST,
                    LIST_LEVEL_ID: i_Params_Get_Bylaw_Complaint_By_Where.LIST_LEVEL_ID,
                    LEVEL_SETUP_ID: i_Params_Get_Bylaw_Complaint_By_Where.LEVEL_SETUP_ID
                );
            if (oList_DBEntry != null)
            {
                oList_Bylaw_Complaint = new List<Bylaw_Complaint>();
                Bylaw_Complaint oBylaw_Complaint;

                foreach (DALC.GeoData oGeoData in oList_DBEntry)
                {
                    oBylaw_Complaint = new Bylaw_Complaint();
                    oBylaw_Complaint.DATE_CREATED = new DateTime();
                    oBylaw_Complaint.Location = new Location();
                    oBylaw_Complaint.BYLAW_COMPLAINT_ID = oGeoData.GEODATA_ID;
                    oBylaw_Complaint.LEVEL_ID = oGeoData.LEVEL_ID;
                    oBylaw_Complaint.LEVEL_SETUP_ID = oGeoData.LEVEL_SETUP_ID;
                    oBylaw_Complaint.DATE_CREATED = oGeoData.DATE_START;
                    oBylaw_Complaint.Location = Props.Copy_Prop_Values_From_Api_Response<Location>(oGeoData.Location);
                    foreach (DALC.Data oData in oGeoData.DATA_LIST)
                    {
                        if (oData.VALUE == "BsonNull")
                        {
                            continue;
                        }
                        switch (oData.NAME)
                        {
                            case "ROW_ID":
                                oBylaw_Complaint.ROW_ID = oData.VALUE;
                                break;
                            case "YEAR":
                                oBylaw_Complaint.YEAR = oData.VALUE;
                                break;
                            case "MONTH":
                                oBylaw_Complaint.MONTH = oData.VALUE;
                                break;
                            case "COMPLAINT_CATEGORY":
                                oBylaw_Complaint.COMPLAINT_CATEGORY = oData.VALUE;
                                break;
                            case "TYPE_OF_COMPLAINT":
                                oBylaw_Complaint.TYPE_OF_COMPLAINT = oData.VALUE;
                                break;
                            case "WAS_CANNABIS_INVOLVED":
                                oBylaw_Complaint.WAS_CANNABIS_INVOLVED = oData.VALUE;
                                break;
                            case "OFFICER_INITIATED":
                                oBylaw_Complaint.OFFICER_INITIATED = oData.VALUE;
                                break;
                            case "INFRACTION_STATUS":
                                oBylaw_Complaint.INFRACTION_STATUS = oData.VALUE;
                                break;
                            case "NEIGHBOURHOOD_ID":
                                oBylaw_Complaint.NEIGHBOURHOOD_ID = oData.VALUE;
                                break;
                            case "NEIGHBOURHOOD":
                                oBylaw_Complaint.NEIGHBOURHOOD = oData.VALUE;
                                break;
                            case "FULL_NAME_OF_STREET":
                                oBylaw_Complaint.FULL_NAME_OF_STREET = oData.VALUE;
                                break;
                            case "COUNT":
                                oBylaw_Complaint.COUNT = oData.VALUE;
                                break;
                        }
                    }
                    oList_Bylaw_Complaint.Add(oBylaw_Complaint);
                }
            }
            return oList_Bylaw_Complaint;
        }
        #endregion
        #region Get_Public_Event_By_Where
        public List<Public_Event> Get_Public_Event_By_Where(Params_Get_Public_Event_By_Where i_Params_Get_Public_Event_By_Where)
        {
            List<Public_Event> oList_Public_Event = null;

            IEnumerable<DALC.GeoData> oList_DBEntry = _MongoDb.Get_GeoData_By_Where(
                    START_DATE: i_Params_Get_Public_Event_By_Where.START_DATE,
                    END_DATE: i_Params_Get_Public_Event_By_Where.END_DATE,
                    ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: i_Params_Get_Public_Event_By_Where.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST,
                    LIST_LEVEL_ID: i_Params_Get_Public_Event_By_Where.LIST_LEVEL_ID,
                    LEVEL_SETUP_ID: i_Params_Get_Public_Event_By_Where.LEVEL_SETUP_ID
                );
            if (oList_DBEntry != null)
            {
                oList_Public_Event = new List<Public_Event>();
                Public_Event oPublic_Event;

                foreach (DALC.GeoData oGeoData in oList_DBEntry)
                {
                    oPublic_Event = new Public_Event();
                    oPublic_Event.START_TIME = new DateTime();
                    oPublic_Event.END_TIME = new DateTime();
                    oPublic_Event.Location = new Location();
                    oPublic_Event.PUBLIC_EVENT_ID = oGeoData.GEODATA_ID;
                    oPublic_Event.LEVEL_ID = oGeoData.LEVEL_ID;
                    oPublic_Event.LEVEL_SETUP_ID = oGeoData.LEVEL_SETUP_ID;
                    oPublic_Event.START_TIME = oGeoData.DATE_START;
                    oPublic_Event.END_TIME = oGeoData.DATE_END;
                    oPublic_Event.Location = Props.Copy_Prop_Values_From_Api_Response<Location>(oGeoData.Location);
                    foreach (DALC.Data oData in oGeoData.DATA_LIST)
                    {
                        if (oData.VALUE == "BsonNull")
                        {
                            continue;
                        }
                        switch (oData.NAME)
                        {
                            case "TITLE":
                                oPublic_Event.TITLE = oData.VALUE;
                                break;
                            case "DATE_AND_TIME":
                                oPublic_Event.DATE_AND_TIME = oData.VALUE;
                                break;
                            case "CITY_OR_TOWN":
                                oPublic_Event.CITY_OR_TOWN = oData.VALUE;
                                break;
                            case "NEIGHBOURHOOD_ID":
                                oPublic_Event.NEIGHBOURHOOD_ID = oData.VALUE;
                                break;
                            case "WHERE":
                                oPublic_Event.WHERE = oData.VALUE;
                                break;
                            case "COST":
                                oPublic_Event.COST = oData.VALUE;
                                break;
                            case "EVENT_TYPE":
                                oPublic_Event.EVENT_TYPE = oData.VALUE;
                                break;
                            case "EVENT_URL":
                                oPublic_Event.EVENT_URL = oData.VALUE;
                                break;
                            case "EVENT_VENUE":
                                oPublic_Event.EVENT_VENUE = oData.VALUE;
                                break;
                            case "EVENT_EXTERNAL_ID":
                                oPublic_Event.EVENT_EXTERNAL_ID = oData.VALUE;
                                break;
                            case "WHERE_TO_PURCHASE_TICKETS":
                                oPublic_Event.WHERE_TO_PURCHASE_TICKETS = oData.VALUE;
                                break;
                            case "TICKETS_PHONE":
                                oPublic_Event.TICKETS_PHONE = oData.VALUE;
                                break;
                            case "CATEGORY_CALENDAR":
                                oPublic_Event.CATEGORY_CALENDAR = oData.VALUE;
                                break;
                            case "WEB_LINK":
                                oPublic_Event.WEB_LINK = oData.VALUE;
                                break;
                            case "PUBLIC_ENGAGEMENT_CATEGORY":
                                oPublic_Event.PUBLIC_ENGAGEMENT_CATEGORY = oData.VALUE;
                                break;
                            case "SHORT_DESCRIPTION":
                                oPublic_Event.SHORT_DESCRIPTION = oData.VALUE;
                                break;
                            case "PROJECT_NAME":
                                oPublic_Event.PROJECT_NAME = oData.VALUE;
                                break;
                            case "ADDITIONAL_INFORMATION":
                                oPublic_Event.ADDITIONAL_INFORMATION = oData.VALUE;
                                break;
                            case "NOTES_1":
                                oPublic_Event.NOTES_1 = oData.VALUE;
                                break;
                            case "NOTES_2":
                                oPublic_Event.NOTES_2 = oData.VALUE;
                                break;
                        }
                    }
                    oList_Public_Event.Add(oPublic_Event);
                }
            }
            return oList_Public_Event;
        }
        #endregion
        #region Get_District_Kpi_Data_By_Where
        public List<District_kpi_data> Get_District_Kpi_Data_By_Where(Params_Get_District_Kpi_Data_By_Where i_Params_Get_District_Kpi_Data_By_Where)
        {
            List<District_kpi_data> oList_District_kpi_data = null;

            List<DALC.District_kpi_data> oList_DBEntry = _MongoDb.Get_District_Kpi_Data_By_Where(
                    START_DATE: i_Params_Get_District_Kpi_Data_By_Where.START_DATE,
                    END_DATE: i_Params_Get_District_Kpi_Data_By_Where.END_DATE,
                    ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: i_Params_Get_District_Kpi_Data_By_Where.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST,
                    DISTRICT_ID_LIST: i_Params_Get_District_Kpi_Data_By_Where.DISTRICT_ID_LIST,
                    ENUM_TIMESPAN: (DALC.Enum_Timespan)i_Params_Get_District_Kpi_Data_By_Where.ENUM_TIMESPAN
                );
            if (oList_DBEntry != null)
            {
                oList_District_kpi_data = new List<District_kpi_data>();
                foreach (var oDBEntry in oList_DBEntry)
                {
                    District_kpi_data oDistrict_kpi_data = new District_kpi_data();
                    District_metadata oDistrict_metadata = new District_metadata();
                    Props.Copy_Prop_Values(oDBEntry, oDistrict_kpi_data);
                    Props.Copy_Prop_Values(oDBEntry.DISTRICT_METADATA, oDistrict_metadata);
                    oDistrict_kpi_data.DISTRICT_METADATA = oDistrict_metadata;
                    oList_District_kpi_data.Add(oDistrict_kpi_data);
                }
            }
            return oList_District_kpi_data;
        }
        #endregion
        #region Get_District_Kpi_Data_Aggregate_Sum
        public List<District_kpi_data> Get_District_Kpi_Data_Aggregate_Sum(Params_Get_District_Kpi_Data_Aggregate_Sum i_Params_Get_District_Kpi_Data_Aggregate_Sum)
        {
            List<District_kpi_data> oList_District_kpi_data = null;

            List<DALC.District_kpi_data> oList_DBEntry = _MongoDb.Get_District_Kpi_Data_Aggregate_Sum(
                    START_DATE: i_Params_Get_District_Kpi_Data_Aggregate_Sum.START_DATE,
                    END_DATE: i_Params_Get_District_Kpi_Data_Aggregate_Sum.END_DATE,
                    ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: i_Params_Get_District_Kpi_Data_Aggregate_Sum.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST,
                    DISTRICT_ID_LIST: i_Params_Get_District_Kpi_Data_Aggregate_Sum.DISTRICT_ID_LIST,
                    ENUM_TIMESPAN: (DALC.Enum_Timespan)i_Params_Get_District_Kpi_Data_Aggregate_Sum.ENUM_TIMESPAN
                );
            if (oList_DBEntry != null)
            {
                oList_District_kpi_data = new List<District_kpi_data>();
                foreach (var oDBEntry in oList_DBEntry)
                {
                    District_kpi_data oDistrict_kpi_data = new District_kpi_data();
                    District_metadata oDistrict_metadata = new District_metadata();
                    Props.Copy_Prop_Values(oDBEntry, oDistrict_kpi_data);
                    Props.Copy_Prop_Values(oDBEntry.DISTRICT_METADATA, oDistrict_metadata);
                    oDistrict_kpi_data.DISTRICT_METADATA = oDistrict_metadata;
                    oList_District_kpi_data.Add(oDistrict_kpi_data);
                }
            }
            return oList_District_kpi_data;
        }
        #endregion
        #region Get_Area_Kpi_Data_By_Where
        public List<Area_kpi_data> Get_Area_Kpi_Data_By_Where(Params_Get_Area_Kpi_Data_By_Where i_Params_Get_Area_Kpi_Data_By_Where)
        {
            List<Area_kpi_data> oList_Area_kpi_data = null;

            List<DALC.Area_kpi_data> oList_DBEntry = _MongoDb.Get_Area_Kpi_Data_By_Where(
                    START_DATE: i_Params_Get_Area_Kpi_Data_By_Where.START_DATE,
                    END_DATE: i_Params_Get_Area_Kpi_Data_By_Where.END_DATE,
                    ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: i_Params_Get_Area_Kpi_Data_By_Where.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST,
                    AREA_ID_LIST: i_Params_Get_Area_Kpi_Data_By_Where.AREA_ID_LIST,
                    ENUM_TIMESPAN: (DALC.Enum_Timespan)i_Params_Get_Area_Kpi_Data_By_Where.ENUM_TIMESPAN
                );
            if (oList_DBEntry != null)
            {
                oList_Area_kpi_data = new List<Area_kpi_data>();
                foreach (var oDBEntry in oList_DBEntry)
                {
                    Area_kpi_data oArea_kpi_data = new Area_kpi_data();
                    Area_metadata oArea_metadata = new Area_metadata();
                    Props.Copy_Prop_Values(oDBEntry, oArea_kpi_data);
                    Props.Copy_Prop_Values(oDBEntry.AREA_METADATA, oArea_metadata);
                    oArea_kpi_data.AREA_METADATA = oArea_metadata;
                    oList_Area_kpi_data.Add(oArea_kpi_data);
                }
            }
            return oList_Area_kpi_data;
        }
        #endregion
        #region Get_Area_Kpi_Data_Aggregate_Sum
        public List<Area_kpi_data> Get_Area_Kpi_Data_Aggregate_Sum(Params_Get_Area_Kpi_Data_Aggregate_Sum i_Params_Get_Area_Kpi_Data_Aggregate_Sum)
        {
            List<Area_kpi_data> oList_Area_kpi_data = null;

            List<DALC.Area_kpi_data> oList_DBEntry = _MongoDb.Get_Area_Kpi_Data_Aggregate_Sum(
                    START_DATE: i_Params_Get_Area_Kpi_Data_Aggregate_Sum.START_DATE,
                    END_DATE: i_Params_Get_Area_Kpi_Data_Aggregate_Sum.END_DATE,
                    ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: i_Params_Get_Area_Kpi_Data_Aggregate_Sum.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST,
                    AREA_ID_LIST: i_Params_Get_Area_Kpi_Data_Aggregate_Sum.AREA_ID_LIST,
                    ENUM_TIMESPAN: (DALC.Enum_Timespan)i_Params_Get_Area_Kpi_Data_Aggregate_Sum.ENUM_TIMESPAN
                );
            if (oList_DBEntry != null)
            {
                oList_Area_kpi_data = new List<Area_kpi_data>();
                foreach (var oDBEntry in oList_DBEntry)
                {
                    Area_kpi_data oArea_kpi_data = new Area_kpi_data();
                    Area_metadata oArea_metadata = new Area_metadata();
                    Props.Copy_Prop_Values(oDBEntry, oArea_kpi_data);
                    Props.Copy_Prop_Values(oDBEntry.AREA_METADATA, oArea_metadata);
                    oArea_kpi_data.AREA_METADATA = oArea_metadata;
                    oList_Area_kpi_data.Add(oArea_kpi_data);
                }
            }
            return oList_Area_kpi_data;
        }
        #endregion
        #region Get_Site_Kpi_Data_By_Where
        public List<Site_kpi_data> Get_Site_Kpi_Data_By_Where(Params_Get_Site_Kpi_Data_By_Where i_Params_Get_Site_Kpi_Data_By_Where)
        {
            List<Site_kpi_data> oList_Site_kpi_data = null;

            List<DALC.Site_kpi_data> oList_DBEntry = _MongoDb.Get_Site_Kpi_Data_By_Where(
                    START_DATE: i_Params_Get_Site_Kpi_Data_By_Where.START_DATE,
                    END_DATE: i_Params_Get_Site_Kpi_Data_By_Where.END_DATE,
                    ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: i_Params_Get_Site_Kpi_Data_By_Where.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST,
                    SITE_ID_LIST: i_Params_Get_Site_Kpi_Data_By_Where.SITE_ID_LIST,
                    ENUM_TIMESPAN: (DALC.Enum_Timespan)i_Params_Get_Site_Kpi_Data_By_Where.ENUM_TIMESPAN
                );
            if (oList_DBEntry != null)
            {
                oList_Site_kpi_data = new List<Site_kpi_data>();
                foreach (var oDBEntry in oList_DBEntry)
                {
                    Site_kpi_data oSite_kpi_data = new Site_kpi_data();
                    Site_metadata oSite_metadata = new Site_metadata();
                    Props.Copy_Prop_Values(oDBEntry, oSite_kpi_data);
                    Props.Copy_Prop_Values(oDBEntry.SITE_METADATA, oSite_metadata);
                    oSite_kpi_data.SITE_METADATA = oSite_metadata;
                    oList_Site_kpi_data.Add(oSite_kpi_data);
                }
            }
            return oList_Site_kpi_data;
        }
        #endregion
        #region Get_Site_Kpi_Data_Aggregate_Sum
        public List<Site_kpi_data> Get_Site_Kpi_Data_Aggregate_Sum(Params_Get_Site_Kpi_Data_Aggregate_Sum i_Params_Get_Site_Kpi_Data_Aggregate_Sum)
        {
            List<Site_kpi_data> oList_Site_kpi_data = null;

            List<DALC.Site_kpi_data> oList_DBEntry = _MongoDb.Get_Site_Kpi_Data_Aggregate_Sum(
                    START_DATE: i_Params_Get_Site_Kpi_Data_Aggregate_Sum.START_DATE,
                    END_DATE: i_Params_Get_Site_Kpi_Data_Aggregate_Sum.END_DATE,
                    ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: i_Params_Get_Site_Kpi_Data_Aggregate_Sum.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST,
                    SITE_ID_LIST: i_Params_Get_Site_Kpi_Data_Aggregate_Sum.SITE_ID_LIST,
                    ENUM_TIMESPAN: (DALC.Enum_Timespan)i_Params_Get_Site_Kpi_Data_Aggregate_Sum.ENUM_TIMESPAN
                );
            if (oList_DBEntry != null)
            {
                oList_Site_kpi_data = new List<Site_kpi_data>();
                foreach (var oDBEntry in oList_DBEntry)
                {
                    Site_kpi_data oSite_kpi_data = new Site_kpi_data();
                    Site_metadata oSite_metadata = new Site_metadata();
                    Props.Copy_Prop_Values(oDBEntry, oSite_kpi_data);
                    Props.Copy_Prop_Values(oDBEntry.SITE_METADATA, oSite_metadata);
                    oSite_kpi_data.SITE_METADATA = oSite_metadata;
                    oList_Site_kpi_data.Add(oSite_kpi_data);
                }
            }
            return oList_Site_kpi_data;
        }
        #endregion
        #region Get_Entity_Kpi_Data_By_Where
        public List<Entity_kpi_data> Get_Entity_Kpi_Data_By_Where(Params_Get_Entity_Kpi_Data_By_Where i_Params_Get_Entity_Kpi_Data_By_Where)
        {
            List<Entity_kpi_data> oList_Entity_kpi_data = null;

            List<DALC.Entity_kpi_data> oList_DBEntry = _MongoDb.Get_Entity_Kpi_Data_By_Where(
                    START_DATE: i_Params_Get_Entity_Kpi_Data_By_Where.START_DATE,
                    END_DATE: i_Params_Get_Entity_Kpi_Data_By_Where.END_DATE,
                    ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: i_Params_Get_Entity_Kpi_Data_By_Where.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST,
                    ENTITY_ID_LIST: i_Params_Get_Entity_Kpi_Data_By_Where.ENTITY_ID_LIST,
                    ENUM_TIMESPAN: (DALC.Enum_Timespan)i_Params_Get_Entity_Kpi_Data_By_Where.ENUM_TIMESPAN
                );
            if (oList_DBEntry != null)
            {
                oList_Entity_kpi_data = new List<Entity_kpi_data>();
                foreach (var oDBEntry in oList_DBEntry)
                {
                    Entity_kpi_data oEntity_kpi_data = new Entity_kpi_data();
                    Entity_metadata oEntity_metadata = new Entity_metadata();
                    Props.Copy_Prop_Values(oDBEntry, oEntity_kpi_data);
                    Props.Copy_Prop_Values(oDBEntry.ENTITY_METADATA, oEntity_metadata);
                    oEntity_kpi_data.ENTITY_METADATA = oEntity_metadata;
                    oList_Entity_kpi_data.Add(oEntity_kpi_data);
                }
            }
            return oList_Entity_kpi_data;
        }
        #endregion
        #region Get_Entity_Kpi_Data_Aggregate_Sum
        public List<Entity_kpi_data> Get_Entity_Kpi_Data_Aggregate_Sum(Params_Get_Entity_Kpi_Data_Aggregate_Sum i_Params_Get_Entity_Kpi_Data_Aggregate_Sum)
        {
            List<Entity_kpi_data> oList_Entity_kpi_data = null;

            List<DALC.Entity_kpi_data> oList_DBEntry = _MongoDb.Get_Entity_Kpi_Data_Aggregate_Sum(
                    START_DATE: i_Params_Get_Entity_Kpi_Data_Aggregate_Sum.START_DATE,
                    END_DATE: i_Params_Get_Entity_Kpi_Data_Aggregate_Sum.END_DATE,
                    ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: i_Params_Get_Entity_Kpi_Data_Aggregate_Sum.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST,
                    ENTITY_ID_LIST: i_Params_Get_Entity_Kpi_Data_Aggregate_Sum.ENTITY_ID_LIST,
                    ENUM_TIMESPAN: (DALC.Enum_Timespan)i_Params_Get_Entity_Kpi_Data_Aggregate_Sum.ENUM_TIMESPAN
                );
            if (oList_DBEntry != null)
            {
                oList_Entity_kpi_data = new List<Entity_kpi_data>();
                foreach (var oDBEntry in oList_DBEntry)
                {
                    Entity_kpi_data oEntity_kpi_data = new Entity_kpi_data();
                    Entity_metadata oEntity_metadata = new Entity_metadata();
                    Props.Copy_Prop_Values(oDBEntry, oEntity_kpi_data);
                    Props.Copy_Prop_Values(oDBEntry.ENTITY_METADATA, oEntity_metadata);
                    oEntity_kpi_data.ENTITY_METADATA = oEntity_metadata;
                    oList_Entity_kpi_data.Add(oEntity_kpi_data);
                }
            }
            return oList_Entity_kpi_data;
        }
        #endregion
        #region Get_Floor_Kpi_Data_By_Where
        public List<Floor_kpi_data> Get_Floor_Kpi_Data_By_Where(Params_Get_Floor_Kpi_Data_By_Where i_Params_Get_Floor_Kpi_Data_By_Where)
        {
            List<Floor_kpi_data> oList_Floor_kpi_data = null;

            List<DALC.Floor_kpi_data> oList_DBEntry = _MongoDb.Get_Floor_Kpi_Data_By_Where(
                    START_DATE: i_Params_Get_Floor_Kpi_Data_By_Where.START_DATE,
                    END_DATE: i_Params_Get_Floor_Kpi_Data_By_Where.END_DATE,
                    ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: i_Params_Get_Floor_Kpi_Data_By_Where.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST,
                    FLOOR_ID_LIST: i_Params_Get_Floor_Kpi_Data_By_Where.FLOOR_ID_LIST,
                    ENUM_TIMESPAN: (DALC.Enum_Timespan)i_Params_Get_Floor_Kpi_Data_By_Where.ENUM_TIMESPAN
                );
            if (oList_DBEntry != null)
            {
                oList_Floor_kpi_data = new List<Floor_kpi_data>();
                foreach (var oDBEntry in oList_DBEntry)
                {
                    Floor_kpi_data oFloor_kpi_data = new Floor_kpi_data();
                    Floor_metadata oFloor_metadata = new Floor_metadata();
                    Props.Copy_Prop_Values(oDBEntry, oFloor_kpi_data);
                    Props.Copy_Prop_Values(oDBEntry.FLOOR_METADATA, oFloor_metadata);
                    oFloor_kpi_data.FLOOR_METADATA = oFloor_metadata;
                    oList_Floor_kpi_data.Add(oFloor_kpi_data);
                }
            }
            return oList_Floor_kpi_data;
        }
        #endregion
        #region Get_Floor_Kpi_Data_Aggregate_Sum
        public List<Floor_kpi_data> Get_Floor_Kpi_Data_Aggregate_Sum(Params_Get_Floor_Kpi_Data_Aggregate_Sum i_Params_Get_Floor_Kpi_Data_Aggregate_Sum)
        {
            List<Floor_kpi_data> oList_Floor_kpi_data = null;

            List<DALC.Floor_kpi_data> oList_DBEntry = _MongoDb.Get_Floor_Kpi_Data_Aggregate_Sum(
                    START_DATE: i_Params_Get_Floor_Kpi_Data_Aggregate_Sum.START_DATE,
                    END_DATE: i_Params_Get_Floor_Kpi_Data_Aggregate_Sum.END_DATE,
                    ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: i_Params_Get_Floor_Kpi_Data_Aggregate_Sum.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST,
                    FLOOR_ID_LIST: i_Params_Get_Floor_Kpi_Data_Aggregate_Sum.FLOOR_ID_LIST,
                    ENUM_TIMESPAN: (DALC.Enum_Timespan)i_Params_Get_Floor_Kpi_Data_Aggregate_Sum.ENUM_TIMESPAN
                );
            if (oList_DBEntry != null)
            {
                oList_Floor_kpi_data = new List<Floor_kpi_data>();
                foreach (var oDBEntry in oList_DBEntry)
                {
                    Floor_kpi_data oFloor_kpi_data = new Floor_kpi_data();
                    Floor_metadata oFloor_metadata = new Floor_metadata();
                    Props.Copy_Prop_Values(oDBEntry, oFloor_kpi_data);
                    Props.Copy_Prop_Values(oDBEntry.FLOOR_METADATA, oFloor_metadata);
                    oFloor_kpi_data.FLOOR_METADATA = oFloor_metadata;
                    oList_Floor_kpi_data.Add(oFloor_kpi_data);
                }
            }
            return oList_Floor_kpi_data;
        }
        #endregion

        #region Get_Site_Kpi_Dialog_Data
        public List<Site_Kpi_Dialog_Data> Get_Site_Kpi_Dialog_Data(Params_Get_Site_Kpi_Dialog_Data i_Params_Get_Site_Kpi_Dialog_Data)
        {
            List<Site_Kpi_Dialog_Data> oList_Site_Kpi_Dialog_Data = new List<Site_Kpi_Dialog_Data>();

            if (i_Params_Get_Site_Kpi_Dialog_Data.ENUM_TIMESPAN != null && i_Params_Get_Site_Kpi_Dialog_Data.START_DATE != null && i_Params_Get_Site_Kpi_Dialog_Data.END_DATE != null)
            {

                if (i_Params_Get_Site_Kpi_Dialog_Data.LIST_SITE_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID == null || i_Params_Get_Site_Kpi_Dialog_Data.LIST_SITE_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID.Count == 0)
                {
                    return oList_Site_Kpi_Dialog_Data;
                }

                #region General Data

                #region Declaration & Initialization

                long? Trendline_Setup_ID = 0;
                long? Not_Trendline_Setup_ID = 0;
                long? Geodata_Setup_ID = 0;
                long? Site_Setup_ID = 0;
                long? Area_Setup_ID = 0;
                long? District_Setup_ID = 0;
                Site oSite = new Site();

                #endregion

                #region Get Setups & Site

                var get_kpi_type = Task.Run(() =>
                {
                    List<Setup> oKpi_Type_Setup = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
                    {
                        SETUP_CATEGORY_NAME = "Kpi Type",
                        OWNER_ID = this.oBLC_Initializer.Owner_ID
                    }).List_Setup;
                    foreach (Setup oSetup in oKpi_Type_Setup)
                    {
                        switch (oSetup.VALUE)
                        {
                            case "Trendline":
                                Trendline_Setup_ID = oSetup.SETUP_ID;
                                break;
                            case "Not Trendline":
                                Not_Trendline_Setup_ID = oSetup.SETUP_ID;
                                break;
                            case "Geo Data":
                                Geodata_Setup_ID = oSetup.SETUP_ID;
                                break;
                        }
                    }
                });

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
                        Area_Setup_ID = oList_Data_Level_Setup.Find(setup => setup.VALUE == "Area").SETUP_ID;
                        District_Setup_ID = oList_Data_Level_Setup.Find(setup => setup.VALUE == "District").SETUP_ID;
                    }
                    else
                    {
                        throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0045).Replace("%1", "Data Level")); // Data Level Setup Not Found
                    }
                });

                var get_site = Task.Run(() =>
                {
                    oSite = Get_Site_By_SITE_ID_Adv(new Params_Get_Site_By_SITE_ID()
                    {
                        SITE_ID = i_Params_Get_Site_Kpi_Dialog_Data.SITE_ID
                    });
                });

                Task.WaitAll(get_kpi_type, get_site_setup, get_site);

                #endregion

                #endregion

                #region Get Organization_Data_Source_Kpi

                #region Declaration & Initialization

                List<Organization_data_source_kpi> oList_District_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                List<Organization_data_source_kpi> oList_Area_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                List<Organization_data_source_kpi> oList_Site_Organization_data_source_kpi = new List<Organization_data_source_kpi>();

                #endregion

                #region Get Organization_Data_Source_Kpi

                var get_district_kpi = Task.Run(() =>
                {
                    if (i_Params_Get_Site_Kpi_Dialog_Data.LIST_DISTRICT_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID != null && i_Params_Get_Site_Kpi_Dialog_Data.LIST_DISTRICT_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID.Count > 0)
                    {
                        oList_District_Organization_data_source_kpi = Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv(new Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List()
                        {
                            ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = i_Params_Get_Site_Kpi_Dialog_Data.LIST_DISTRICT_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID
                        });
                        if (i_Params_Get_Site_Kpi_Dialog_Data.DIMENSION_ID != null && oList_District_Organization_data_source_kpi != null && oList_District_Organization_data_source_kpi.Count > 0)
                        {
                            oList_District_Organization_data_source_kpi.RemoveAll(oDistrict_Organization_data_source_kpi => i_Params_Get_Site_Kpi_Dialog_Data.DIMENSION_ID != oDistrict_Organization_data_source_kpi.Kpi.DIMENSION_ID);
                        }
                    }
                });

                var get_area_kpi = Task.Run(() =>
                {
                    if (i_Params_Get_Site_Kpi_Dialog_Data.LIST_AREA_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID != null && i_Params_Get_Site_Kpi_Dialog_Data.LIST_AREA_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID.Count > 0)
                    {
                        oList_Area_Organization_data_source_kpi = Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv(new Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List()
                        {
                            ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = i_Params_Get_Site_Kpi_Dialog_Data.LIST_AREA_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID
                        });
                        if (i_Params_Get_Site_Kpi_Dialog_Data.DIMENSION_ID != null && oList_Area_Organization_data_source_kpi != null && oList_Area_Organization_data_source_kpi.Count > 0)
                        {
                            oList_Area_Organization_data_source_kpi.RemoveAll(oArea_Organization_data_source_kpi => i_Params_Get_Site_Kpi_Dialog_Data.DIMENSION_ID != oArea_Organization_data_source_kpi.Kpi.DIMENSION_ID);
                        }
                    }
                });

                var get_site_kpi = Task.Run(() =>
                {
                    if (i_Params_Get_Site_Kpi_Dialog_Data.LIST_SITE_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID != null && i_Params_Get_Site_Kpi_Dialog_Data.LIST_SITE_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID.Count > 0)
                    {
                        oList_Site_Organization_data_source_kpi = Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv(new Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List()
                        {
                            ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = i_Params_Get_Site_Kpi_Dialog_Data.LIST_SITE_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID
                        });
                        if (i_Params_Get_Site_Kpi_Dialog_Data.DIMENSION_ID != null && oList_Site_Organization_data_source_kpi != null && oList_Site_Organization_data_source_kpi.Count > 0)
                        {
                            oList_Site_Organization_data_source_kpi.RemoveAll(oSite_Organization_data_source_kpi => i_Params_Get_Site_Kpi_Dialog_Data.DIMENSION_ID != oSite_Organization_data_source_kpi.Kpi.DIMENSION_ID);
                        }
                    }
                });

                Task.WaitAll(get_district_kpi, get_area_kpi, get_site_kpi);

                #endregion

                #endregion

                #region Group Organization_Data_Source_Kpi

                #region Declaration & Initialization

                List<int?> oList_District_Trendline_Organization_data_source_kpi_ID = new List<int?>();
                List<int?> oList_District_Not_Trendline_Organization_data_source_kpi_ID = new List<int?>();
                List<int?> oList_District_Geodata_Organization_data_source_kpi_ID = new List<int?>();
                List<int?> oList_Area_Trendline_Organization_data_source_kpi_ID = new List<int?>();
                List<int?> oList_Area_Not_Trendline_Organization_data_source_kpi_ID = new List<int?>();
                List<int?> oList_Area_Geodata_Organization_data_source_kpi_ID = new List<int?>();
                List<int?> oList_Site_Trendline_Organization_data_source_kpi_ID = new List<int?>();
                List<int?> oList_Site_Not_Trendline_Organization_data_source_kpi_ID = new List<int?>();
                List<int?> oList_Site_Geodata_Organization_data_source_kpi_ID = new List<int?>();


                #endregion

                #region Organization_Data_Source_Kpi

                var group_district_organization_data_source_kpi = Task.Run(() =>
                {
                    if (oList_District_Organization_data_source_kpi != null && oList_District_Organization_data_source_kpi.Count > 0)
                    {
                        foreach (Organization_data_source_kpi oOrganization_data_source_kpi in oList_District_Organization_data_source_kpi)
                        {
                            if (oOrganization_data_source_kpi.Kpi.KPI_TYPE_SETUP_ID == Trendline_Setup_ID)
                            {
                                oList_District_Trendline_Organization_data_source_kpi_ID.Add(oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID);
                            }
                            else if (oOrganization_data_source_kpi.Kpi.KPI_TYPE_SETUP_ID == Not_Trendline_Setup_ID)
                            {
                                oList_District_Not_Trendline_Organization_data_source_kpi_ID.Add(oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID);
                            }
                            else if (oOrganization_data_source_kpi.Kpi.KPI_TYPE_SETUP_ID == Geodata_Setup_ID)
                            {
                                oList_District_Geodata_Organization_data_source_kpi_ID.Add(oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID);
                            }

                        }
                    }
                });

                var group_area_organization_data_source_kpi = Task.Run(() =>
                {
                    if (oList_Area_Organization_data_source_kpi != null && oList_Area_Organization_data_source_kpi.Count > 0)
                    {
                        foreach (Organization_data_source_kpi oOrganization_data_source_kpi in oList_Area_Organization_data_source_kpi)
                        {
                            if (oOrganization_data_source_kpi.Kpi.KPI_TYPE_SETUP_ID == Trendline_Setup_ID)
                            {
                                oList_Area_Trendline_Organization_data_source_kpi_ID.Add(oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID);
                            }
                            else if (oOrganization_data_source_kpi.Kpi.KPI_TYPE_SETUP_ID == Not_Trendline_Setup_ID)
                            {
                                oList_Area_Not_Trendline_Organization_data_source_kpi_ID.Add(oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID);
                            }
                            else if (oOrganization_data_source_kpi.Kpi.KPI_TYPE_SETUP_ID == Geodata_Setup_ID)
                            {
                                oList_Area_Geodata_Organization_data_source_kpi_ID.Add(oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID);
                            }

                        }
                    }
                });

                var group_site_organization_data_source_kpi = Task.Run(() =>
                {
                    if (oList_Site_Organization_data_source_kpi != null && oList_Site_Organization_data_source_kpi.Count > 0)
                    {
                        foreach (Organization_data_source_kpi oOrganization_data_source_kpi in oList_Site_Organization_data_source_kpi)
                        {
                            if (oOrganization_data_source_kpi.Kpi.KPI_TYPE_SETUP_ID == Trendline_Setup_ID)
                            {
                                oList_Site_Trendline_Organization_data_source_kpi_ID.Add(oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID);
                            }
                            else if (oOrganization_data_source_kpi.Kpi.KPI_TYPE_SETUP_ID == Not_Trendline_Setup_ID)
                            {
                                oList_Site_Not_Trendline_Organization_data_source_kpi_ID.Add(oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID);
                            }
                            else if (oOrganization_data_source_kpi.Kpi.KPI_TYPE_SETUP_ID == Geodata_Setup_ID)
                            {
                                oList_Site_Geodata_Organization_data_source_kpi_ID.Add(oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID);
                            }

                        }
                    }
                });

                Task.WaitAll(group_district_organization_data_source_kpi, group_area_organization_data_source_kpi, group_site_organization_data_source_kpi);

                #endregion

                #endregion

                #region Get Kpi_Data

                #region Declaration & Initialization

                List<District_kpi_data> oList_Trendline_District_kpi_data = new List<District_kpi_data>();
                List<District_kpi_data> oList_Not_Trendline_District_kpi_data = new List<District_kpi_data>();
                List<GeoData> oList_District_GeoData = new List<GeoData>();
                List<Area_kpi_data> oList_Trendline_Area_kpi_data = new List<Area_kpi_data>();
                List<Area_kpi_data> oList_Not_Trendline_Area_kpi_data = new List<Area_kpi_data>();
                List<GeoData> oList_Area_GeoData = new List<GeoData>();
                List<Site_kpi_data> oList_Trendline_Site_kpi_data = new List<Site_kpi_data>();
                List<Site_kpi_data> oList_Not_Trendline_Site_kpi_data = new List<Site_kpi_data>();
                List<GeoData> oList_Site_GeoData_Bylaw_Complaint = new List<GeoData>();
                List<Business> oList_Site_Business_Count = new List<Business>();
                List<Business> oList_Site_Business_Vacancy = new List<Business>();

                #endregion

                #region Kpi_data

                var get_trendline_district_kpi_data = Task.Run(() =>
                {
                    if (oList_District_Trendline_Organization_data_source_kpi_ID != null && oList_District_Trendline_Organization_data_source_kpi_ID.Count > 0)
                    {
                        oList_Trendline_District_kpi_data = Get_District_Kpi_Data_By_Where(new Params_Get_District_Kpi_Data_By_Where()
                        {
                            DISTRICT_ID_LIST = new List<long?>() { i_Params_Get_Site_Kpi_Dialog_Data.DISTRICT_ID },
                            ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = oList_District_Trendline_Organization_data_source_kpi_ID,
                            ENUM_TIMESPAN = i_Params_Get_Site_Kpi_Dialog_Data.ENUM_TIMESPAN,
                            START_DATE = i_Params_Get_Site_Kpi_Dialog_Data.START_DATE,
                            END_DATE = i_Params_Get_Site_Kpi_Dialog_Data.END_DATE
                        });
                    }
                });
                var get_not_trendline_district_kpi_data = Task.Run(() =>
                {
                    if (oList_District_Not_Trendline_Organization_data_source_kpi_ID != null && oList_District_Not_Trendline_Organization_data_source_kpi_ID.Count > 0)
                    {
                        oList_Not_Trendline_District_kpi_data = Get_District_Kpi_Data_Aggregate_Sum(new Params_Get_District_Kpi_Data_Aggregate_Sum()
                        {
                            DISTRICT_ID_LIST = new List<long?>() { i_Params_Get_Site_Kpi_Dialog_Data.DISTRICT_ID },
                            ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = oList_District_Not_Trendline_Organization_data_source_kpi_ID,
                            ENUM_TIMESPAN = i_Params_Get_Site_Kpi_Dialog_Data.ENUM_TIMESPAN,
                            START_DATE = i_Params_Get_Site_Kpi_Dialog_Data.START_DATE,
                            END_DATE = i_Params_Get_Site_Kpi_Dialog_Data.END_DATE
                        });
                    }
                });
                var get_trendline_area_kpi_data = Task.Run(() =>
                {
                    if (oList_Area_Trendline_Organization_data_source_kpi_ID != null && oList_Area_Trendline_Organization_data_source_kpi_ID.Count > 0)
                    {
                        oList_Trendline_Area_kpi_data = Get_Area_Kpi_Data_By_Where(new Params_Get_Area_Kpi_Data_By_Where()
                        {
                            AREA_ID_LIST = new List<long?>() { i_Params_Get_Site_Kpi_Dialog_Data.AREA_ID },
                            ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = oList_Area_Trendline_Organization_data_source_kpi_ID,
                            ENUM_TIMESPAN = i_Params_Get_Site_Kpi_Dialog_Data.ENUM_TIMESPAN,
                            START_DATE = i_Params_Get_Site_Kpi_Dialog_Data.START_DATE,
                            END_DATE = i_Params_Get_Site_Kpi_Dialog_Data.END_DATE
                        });
                    }
                });
                var get_not_trendline_area_kpi_data = Task.Run(() =>
                {
                    if (oList_Area_Not_Trendline_Organization_data_source_kpi_ID != null && oList_Area_Not_Trendline_Organization_data_source_kpi_ID.Count > 0)
                    {
                        oList_Not_Trendline_Area_kpi_data = Get_Area_Kpi_Data_Aggregate_Sum(new Params_Get_Area_Kpi_Data_Aggregate_Sum()
                        {
                            AREA_ID_LIST = new List<long?>() { i_Params_Get_Site_Kpi_Dialog_Data.AREA_ID },
                            ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = oList_Area_Not_Trendline_Organization_data_source_kpi_ID,
                            ENUM_TIMESPAN = i_Params_Get_Site_Kpi_Dialog_Data.ENUM_TIMESPAN,
                            START_DATE = i_Params_Get_Site_Kpi_Dialog_Data.START_DATE,
                            END_DATE = i_Params_Get_Site_Kpi_Dialog_Data.END_DATE
                        });
                    }
                });
                var get_trendline_site_kpi_data = Task.Run(() =>
                {
                    if (oList_Site_Trendline_Organization_data_source_kpi_ID != null && oList_Site_Trendline_Organization_data_source_kpi_ID.Count > 0)
                    {
                        oList_Trendline_Site_kpi_data = Get_Site_Kpi_Data_By_Where(new Params_Get_Site_Kpi_Data_By_Where()
                        {
                            SITE_ID_LIST = new List<long?>() { i_Params_Get_Site_Kpi_Dialog_Data.SITE_ID },
                            ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = oList_Site_Trendline_Organization_data_source_kpi_ID,
                            ENUM_TIMESPAN = i_Params_Get_Site_Kpi_Dialog_Data.ENUM_TIMESPAN,
                            START_DATE = i_Params_Get_Site_Kpi_Dialog_Data.START_DATE,
                            END_DATE = i_Params_Get_Site_Kpi_Dialog_Data.END_DATE
                        });
                    }
                });
                var get_not_trendline_site_kpi_data = Task.Run(() =>
                {
                    if (oList_Site_Not_Trendline_Organization_data_source_kpi_ID != null && oList_Site_Not_Trendline_Organization_data_source_kpi_ID.Count > 0)
                    {
                        oList_Not_Trendline_Site_kpi_data = Get_Site_Kpi_Data_Aggregate_Sum(new Params_Get_Site_Kpi_Data_Aggregate_Sum()
                        {
                            SITE_ID_LIST = new List<long?>() { i_Params_Get_Site_Kpi_Dialog_Data.SITE_ID },
                            ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = oList_Site_Not_Trendline_Organization_data_source_kpi_ID,
                            ENUM_TIMESPAN = i_Params_Get_Site_Kpi_Dialog_Data.ENUM_TIMESPAN,
                            START_DATE = i_Params_Get_Site_Kpi_Dialog_Data.START_DATE,
                            END_DATE = i_Params_Get_Site_Kpi_Dialog_Data.END_DATE
                        });
                    }
                });
                var get_site_geodata_bylaw_complaints = Task.Run(() =>
                {
                    Organization_data_source_kpi oOrganization_data_source_kpi = oList_Site_Organization_data_source_kpi.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.NAME == "Bylaw Complaints");
                    if (oOrganization_data_source_kpi != null)
                    {
                        int? Bylaw_Complaints_Organization_Data_source_Kpi_ID = oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID;
                        oList_Site_GeoData_Bylaw_Complaint = Get_GeoData_By_Where(new Params_Get_GeoData_By_Where()
                        {
                            LIST_LEVEL_ID = new List<long?>() { i_Params_Get_Site_Kpi_Dialog_Data.SITE_ID },
                            LEVEL_SETUP_ID = Site_Setup_ID,
                            ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = new List<int?> { Bylaw_Complaints_Organization_Data_source_Kpi_ID },
                            START_DATE = i_Params_Get_Site_Kpi_Dialog_Data.START_DATE
                        });
                    }

                });
                var get_area_geodata_business_count = Task.Run(() =>
                {
                    Organization_data_source_kpi oOrganization_data_source_kpi = oList_Site_Organization_data_source_kpi.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.NAME == "Businesses By Category");
                    if (oOrganization_data_source_kpi != null)
                    {
                        int? Businesses_Organization_Data_source_Kpi_ID = oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID;
                        oList_Site_Business_Count = Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID(new Params_Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID()
                        {
                            ORGANIZATION_DATA_SOURCE_KPI_ID = Businesses_Organization_Data_source_Kpi_ID,
                            LIST_LEVEL_ID = new List<long?>() { i_Params_Get_Site_Kpi_Dialog_Data.SITE_ID },
                            LEVEL_SETUP_ID = Site_Setup_ID
                        });
                    }
                });
                var get_area_geodata_business_vacancy = Task.Run(() =>
                {
                    Organization_data_source_kpi oOrganization_data_source_kpi = oList_Site_Organization_data_source_kpi.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.NAME == "Businesses Vacancy");
                    if (oOrganization_data_source_kpi != null)
                    {
                        int? Businesses_Organization_Data_source_Kpi_ID = oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID;
                        oList_Site_Business_Vacancy = Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID(new Params_Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID()
                        {
                            ORGANIZATION_DATA_SOURCE_KPI_ID = Businesses_Organization_Data_source_Kpi_ID,
                            LIST_LEVEL_ID = new List<long?>() { i_Params_Get_Site_Kpi_Dialog_Data.SITE_ID },
                            LEVEL_SETUP_ID = Site_Setup_ID
                        });
                    }
                });

                Task.WaitAll(get_trendline_district_kpi_data, get_not_trendline_district_kpi_data,
                            get_trendline_area_kpi_data, get_not_trendline_area_kpi_data,
                            get_trendline_site_kpi_data, get_not_trendline_site_kpi_data,
                            get_site_geodata_bylaw_complaints, get_area_geodata_business_count, get_area_geodata_business_vacancy);

                #endregion

                #endregion

                #region Fill List_Site_Kpi_Dialog_Data

                #region Declaration & Initialization

                Site_Kpi_Dialog_Data oSite_Kpi_Dialog_Data;

                #endregion

                #region List_Site_Kpi_Dialog_Data

                if (oList_Site_Organization_data_source_kpi != null && oList_Site_Organization_data_source_kpi.Count > 0)
                {

                    foreach (Organization_data_source_kpi oOrganization_data_source_kpi in oList_Site_Organization_data_source_kpi)
                    {
                        oSite_Kpi_Dialog_Data = new Site_Kpi_Dialog_Data();
                        oSite_Kpi_Dialog_Data.ORGANIZATION_DATA_SOURCE_KPI_ID = oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID;
                        oSite_Kpi_Dialog_Data.KPI_ID = oOrganization_data_source_kpi.KPI_ID;
                        if (oOrganization_data_source_kpi.Kpi.NAME != "Businesses By Category" && oOrganization_data_source_kpi.Kpi.NAME != "Businesses Vacancy")
                        {
                            oSite_Kpi_Dialog_Data.TITLE = oOrganization_data_source_kpi.Kpi.NAME + " From " + i_Params_Get_Site_Kpi_Dialog_Data.START_DATE.ToString() + " Till " + i_Params_Get_Site_Kpi_Dialog_Data.END_DATE.ToString();
                        }
                        else
                        {
                            oSite_Kpi_Dialog_Data.TITLE = oOrganization_data_source_kpi.Kpi.NAME;
                        }

                        #region Fill Kpi_Data

                        oSite_Kpi_Dialog_Data.KPI_DATA = new Data_point();
                        if (oOrganization_data_source_kpi.Kpi.KPI_TYPE_SETUP_ID == Trendline_Setup_ID)
                        {
                            #region Trendline

                            oSite_Kpi_Dialog_Data.KPI_DATA.LIST_LABEL = new List<string>();
                            oSite_Kpi_Dialog_Data.KPI_DATA.LIST_DATASET = new List<Dataset>();

                            if (oList_Trendline_Site_kpi_data != null & oList_Trendline_Site_kpi_data.Count > 0)
                            {
                                List<Site_kpi_data> oList_Site_kpi_data = oList_Trendline_Site_kpi_data.Where(oSite_kpi_data => oSite_kpi_data.SITE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID == oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();
                                List<Area_kpi_data> oList_Area_kpi_data = oList_Trendline_Area_kpi_data.Where(oArea_kpi_data => oArea_kpi_data.AREA_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID == oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();
                                List<District_kpi_data> oList_District_kpi_data = oList_Trendline_District_kpi_data.Where(oDistrict_kpi_data => oDistrict_kpi_data.DISTRICT_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID == oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();

                                if (oList_Site_kpi_data != null && oList_Site_kpi_data.Count > 0)
                                {
                                    List<decimal?> List_Point_Site = new List<decimal?>();
                                    List<decimal?> List_Point_Area = new List<decimal?>();
                                    List<decimal?> List_Point_District = new List<decimal?>();

                                    foreach (Site_kpi_data oSite_kpi_data in oList_Site_kpi_data)
                                    {
                                        if (i_Params_Get_Site_Kpi_Dialog_Data.ENUM_TIMESPAN == Enum_Timespan.X_DAILY_COLLECTION)
                                        {
                                            oSite_Kpi_Dialog_Data.KPI_DATA.LIST_LABEL.Add(oSite_kpi_data.RECORD_DATE.ToShortDateString());
                                        }
                                        else
                                        {
                                            oSite_Kpi_Dialog_Data.KPI_DATA.LIST_LABEL.Add(oSite_kpi_data.VALUE_NAME);
                                        }
                                        List_Point_Site.Add((decimal?)oSite_kpi_data.VALUE);
                                        if (oList_Area_kpi_data != null && oList_Area_kpi_data.Count > 0)
                                        {
                                            Area_kpi_data oArea_kpi_data = oList_Area_kpi_data.Find(oArea_kpi_data => oArea_kpi_data.VALUE_NAME == oSite_kpi_data.VALUE_NAME);
                                            decimal? point = null;
                                            if (oArea_kpi_data != null)
                                            {
                                                point = oArea_kpi_data.VALUE;
                                            }
                                            List_Point_Area.Add(point);
                                        }
                                        if (oList_District_kpi_data != null && oList_District_kpi_data.Count > 0)
                                        {
                                            District_kpi_data oDistrict_kpi_data = oList_District_kpi_data.Find(oDistrict_kpi_data => oDistrict_kpi_data.VALUE_NAME == oSite_kpi_data.VALUE_NAME);
                                            decimal? point = null;
                                            if (oDistrict_kpi_data != null)
                                            {
                                                point = oDistrict_kpi_data.VALUE;
                                            }
                                            List_Point_District.Add(point);
                                        }
                                    }

                                    oSite_Kpi_Dialog_Data.KPI_DATA.LIST_DATASET.Add(new Dataset() { LABEL = oSite.NAME, LIST_POINT = List_Point_Site, DATA_LEVEL_SETUP_ID = Site_Setup_ID });
                                    if (List_Point_Area != null && List_Point_Area.Count > 0)
                                    {
                                        oSite_Kpi_Dialog_Data.KPI_DATA.LIST_DATASET.Add(new Dataset() { LABEL = oSite.Area.NAME, LIST_POINT = List_Point_Area, DATA_LEVEL_SETUP_ID = Area_Setup_ID });
                                    }
                                    if (List_Point_District != null && List_Point_District.Count > 0)
                                    {
                                        oSite_Kpi_Dialog_Data.KPI_DATA.LIST_DATASET.Add(new Dataset() { LABEL = oSite.District.NAME, LIST_POINT = List_Point_District, DATA_LEVEL_SETUP_ID = District_Setup_ID });
                                    }
                                }
                            }

                            #endregion
                        }
                        else if (oOrganization_data_source_kpi.Kpi.KPI_TYPE_SETUP_ID == Not_Trendline_Setup_ID)
                        {
                            #region Not Trendline

                            oSite_Kpi_Dialog_Data.KPI_DATA.LIST_LABEL = new List<string>();
                            oSite_Kpi_Dialog_Data.KPI_DATA.LIST_DATASET = new List<Dataset>();

                            if (oList_Not_Trendline_Site_kpi_data != null & oList_Not_Trendline_Site_kpi_data.Count > 0)
                            {
                                List<Site_kpi_data> oList_Site_kpi_data = oList_Not_Trendline_Site_kpi_data.Where(oSite_kpi_data => oSite_kpi_data.SITE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID == oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();
                                if (oList_Site_kpi_data != null && oList_Site_kpi_data.Count > 0)
                                {
                                    #region Order Site_kpi_data

                                    oList_Site_kpi_data = oList_Site_kpi_data.OrderBy(oSite_kpi_data =>
                                    {
                                        if (oSite_kpi_data.VALUE_NAME == null)
                                        {
                                            return int.MaxValue;
                                        }
                                        int num;
                                        if (int.TryParse(Regex.Match(oSite_kpi_data.VALUE_NAME, @"\d+").Value, out num))
                                        {
                                            return num;
                                        }
                                        else if (oSite_kpi_data.VALUE_NAME.ToLower().Contains("under"))
                                        {
                                            return -1;
                                        }
                                        else if (oSite_kpi_data.VALUE_NAME.ToLower().Contains("over"))
                                        {
                                            return int.MaxValue;
                                        }
                                        else
                                        {
                                            return int.MaxValue;
                                        }
                                    }).ToList();

                                    #endregion

                                    if (oOrganization_data_source_kpi.Kpi.NAME != "Visitor Origins")
                                    {
                                        #region Not Visitor Origins

                                        List<Area_kpi_data> oList_Area_kpi_data = oList_Not_Trendline_Area_kpi_data.Where(oArea_kpi_data => oArea_kpi_data.AREA_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID == oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();
                                        List<District_kpi_data> oList_District_kpi_data = oList_Not_Trendline_District_kpi_data.Where(oDistrict_kpi_data => oDistrict_kpi_data.DISTRICT_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID == oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();

                                        List<decimal?> List_Point_Site = new List<decimal?>();
                                        List<decimal?> List_Point_Area = new List<decimal?>();
                                        List<decimal?> List_Point_District = new List<decimal?>();

                                        foreach (Site_kpi_data oSite_kpi_data in oList_Site_kpi_data)
                                        {
                                            oSite_Kpi_Dialog_Data.KPI_DATA.LIST_LABEL.Add(oSite_kpi_data.VALUE_NAME);
                                            List_Point_Site.Add((decimal?)oSite_kpi_data.VALUE);
                                            if (oList_Area_kpi_data != null && oList_Area_kpi_data.Count > 0)
                                            {
                                                Area_kpi_data oArea_kpi_data = oList_Area_kpi_data.Find(oArea_kpi_data => oArea_kpi_data.VALUE_NAME == oSite_kpi_data.VALUE_NAME);
                                                decimal? point = null;
                                                if (oArea_kpi_data != null)
                                                {
                                                    point = oArea_kpi_data.VALUE;
                                                }
                                                List_Point_Area.Add(point);
                                            }
                                            if (oList_District_kpi_data != null && oList_District_kpi_data.Count > 0)
                                            {
                                                District_kpi_data oDistrict_kpi_data = oList_District_kpi_data.Find(oDistrict_kpi_data => oDistrict_kpi_data.VALUE_NAME == oSite_kpi_data.VALUE_NAME);
                                                decimal? point = null;
                                                if (oDistrict_kpi_data != null)
                                                {
                                                    point = oDistrict_kpi_data.VALUE;
                                                }
                                                List_Point_District.Add(point);
                                            }
                                        }

                                        oSite_Kpi_Dialog_Data.KPI_DATA.LIST_DATASET.Add(new Dataset() { LABEL = oSite.NAME, LIST_POINT = List_Point_Site, DATA_LEVEL_SETUP_ID = Site_Setup_ID });
                                        if (List_Point_Area != null && List_Point_Area.Count > 0)
                                        {
                                            oSite_Kpi_Dialog_Data.KPI_DATA.LIST_DATASET.Add(new Dataset() { LABEL = oSite.Area.NAME, LIST_POINT = List_Point_Area, DATA_LEVEL_SETUP_ID = Area_Setup_ID });
                                        }
                                        if (List_Point_District != null && List_Point_District.Count > 0)
                                        {
                                            oSite_Kpi_Dialog_Data.KPI_DATA.LIST_DATASET.Add(new Dataset() { LABEL = oSite.District.NAME, LIST_POINT = List_Point_District, DATA_LEVEL_SETUP_ID = District_Setup_ID });
                                        }

                                        #endregion
                                    }
                                    else if (oOrganization_data_source_kpi.Kpi.NAME == "Visitor Origins")
                                    {
                                        #region Visitor Origins

                                        List<int?> List_Ext_Study_Zone_ID = oList_Site_kpi_data.Where(oSite_kpi_data => !string.IsNullOrEmpty(oSite_kpi_data.SITE_METADATA.CATEGORY))
                                                                                               .Select(oSite_kpi_data =>
                                                                                               {
                                                                                                   string[] parts = oSite_kpi_data.SITE_METADATA.CATEGORY.Split(',');
                                                                                                   var values = oSite_kpi_data.SITE_METADATA.CATEGORY.Split(',')
                                                                                                               .Select(category => category.Split(':'))
                                                                                                               .ToDictionary(category => category[0], category => int.Parse(category[1]));
                                                                                                   int EXT_STUDY_ZONE_ID;
                                                                                                   bool isExist_EXT_STUDY_ZONE_ID = values.TryGetValue("EXT_STUDY_ZONE_ID", out EXT_STUDY_ZONE_ID);
                                                                                                   return (int?)EXT_STUDY_ZONE_ID;
                                                                                               }).ToList();
                                        List<Ext_study_zone> oList_Ext_study_zone = Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID_List(new Params_Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID_List()
                                        {
                                            EXT_STUDY_ZONE_ID_LIST = List_Ext_Study_Zone_ID
                                        });
                                        oSite_Kpi_Dialog_Data.KPI_DATA.LIST_LABEL = new List<string>();
                                        oSite_Kpi_Dialog_Data.KPI_DATA.LIST_LABEL = oList_Site_kpi_data.Select(oSite_kpi_data =>
                                        {
                                            string[] parts = oSite_kpi_data.SITE_METADATA.CATEGORY.Split(',');
                                            var values = parts.Select(category => category.Split(':'))
                                                        .ToDictionary(category => category[0], category => int.Parse(category[1]));
                                            int EXT_STUDY_ZONE_ID;
                                            bool isExist_EXT_STUDY_ZONE_ID = values.TryGetValue("EXT_STUDY_ZONE_ID", out EXT_STUDY_ZONE_ID);
                                            if (isExist_EXT_STUDY_ZONE_ID && EXT_STUDY_ZONE_ID != 0)
                                            {
                                                Ext_study_zone oExt_study_zone = oList_Ext_study_zone.Find(oExt_study_zone => oExt_study_zone.EXT_STUDY_ZONE_ID == EXT_STUDY_ZONE_ID);
                                                if (oExt_study_zone != null)
                                                {
                                                    string Label = oExt_study_zone.NAME;
                                                    return Label;
                                                }
                                                else
                                                {
                                                    return null;
                                                }
                                            }
                                            else
                                            {
                                                return null;
                                            }

                                        }).Where(Label => Label != null).ToList();
                                        List<decimal?> List_Point = oList_Site_kpi_data.Select(oSite_kpi_data => (decimal?)oSite_kpi_data.VALUE).ToList();
                                        oSite_Kpi_Dialog_Data.KPI_DATA.LIST_DATASET = new List<Dataset>();
                                        oSite_Kpi_Dialog_Data.KPI_DATA.LIST_DATASET.Add(new Dataset() { LABEL = oSite.NAME, LIST_POINT = List_Point, DATA_LEVEL_SETUP_ID = Site_Setup_ID });

                                        #endregion
                                    }
                                }
                            }

                            #endregion
                        }
                        else if (oOrganization_data_source_kpi.Kpi.KPI_TYPE_SETUP_ID == Geodata_Setup_ID)
                        {
                            if (oOrganization_data_source_kpi.Kpi.NAME == "Bylaw Complaints")
                            {
                                #region Bylaw Complaints

                                var grouped_GeoData_byLaw_Complaint = oList_Site_GeoData_Bylaw_Complaint.SelectMany(oGeoData => oGeoData.DATA_LIST
                                               .Where(oData => oData.NAME == "COMPLAINT_CATEGORY")
                                               .Select(oData => new { GeoData = oGeoData, DataValue = oData.VALUE }))
                                               .GroupBy(oData => oData.DataValue)
                                               .Select(GeoData => new { Key = GeoData.Key, GeoDataList = GeoData.Select(x => x.GeoData).ToList() });

                                oSite_Kpi_Dialog_Data.KPI_DATA = new Data_point();
                                oSite_Kpi_Dialog_Data.KPI_DATA.LIST_DATASET = new List<Dataset>();
                                oSite_Kpi_Dialog_Data.KPI_DATA.LIST_LABEL = new List<string>();
                                List<decimal?> List_Point = new List<decimal?>();

                                foreach (var oGeoData_byLaw_Complaint in grouped_GeoData_byLaw_Complaint)
                                {
                                    oSite_Kpi_Dialog_Data.KPI_DATA.LIST_LABEL.Add(oGeoData_byLaw_Complaint.Key);
                                    List_Point.Add(oGeoData_byLaw_Complaint.GeoDataList.Count);
                                }

                                oSite_Kpi_Dialog_Data.KPI_DATA.LIST_DATASET.Add(new Dataset()
                                {
                                    LABEL = oSite.NAME,
                                    LIST_POINT = List_Point,
                                    DATA_LEVEL_SETUP_ID = Site_Setup_ID
                                });

                                #endregion
                            }
                            else if (oOrganization_data_source_kpi.Kpi.NAME == "Businesses By Category")
                            {
                                #region Businesses By Category

                                oSite_Kpi_Dialog_Data.KPI_DATA = new Data_point();
                                oSite_Kpi_Dialog_Data.KPI_DATA.LIST_DATASET = new List<Dataset>();
                                oSite_Kpi_Dialog_Data.KPI_DATA.LIST_LABEL = new List<string>();
                                List<decimal?> List_Point = new List<decimal?>();

                                oSite_Kpi_Dialog_Data.KPI_DATA.LIST_LABEL = oList_Site_Business_Count.SelectMany(oBusiness => oBusiness.LIST_BUSINESS_CATEGORY).Distinct().ToList();

                                foreach (string Business_Category in oSite_Kpi_Dialog_Data.KPI_DATA.LIST_LABEL)
                                {
                                    decimal? Point = oList_Site_Business_Count.Count(oBusiness => oBusiness.LIST_BUSINESS_CATEGORY.Contains(Business_Category));
                                    List_Point.Add(Point);
                                }

                                oSite_Kpi_Dialog_Data.KPI_DATA.LIST_DATASET.Add(new Dataset()
                                {
                                    LABEL = oSite.NAME,
                                    LIST_POINT = List_Point,
                                    DATA_LEVEL_SETUP_ID = Site_Setup_ID
                                });

                                #endregion
                            }
                            else if (oOrganization_data_source_kpi.Kpi.NAME == "Businesses Vacancy")
                            {
                                #region Business Vacancy

                                oSite_Kpi_Dialog_Data.KPI_DATA = new Data_point();
                                oSite_Kpi_Dialog_Data.KPI_DATA.LIST_DATASET = new List<Dataset>();
                                oSite_Kpi_Dialog_Data.KPI_DATA.LIST_LABEL = new List<string>();

                                IEnumerable<string> List_Business_Niche = oList_Site_Business_Vacancy.Select(oBusiness => oBusiness.BUSINESS_NICHE).Distinct();
                                IEnumerable<string> List_Business_Status = oList_Site_Business_Vacancy.Select(oBusiness => oBusiness.BUSINESS_STATUS).Distinct();

                                Dataset oDataset;

                                foreach (string Business_Status in List_Business_Status)
                                {
                                    if (Business_Status != null)
                                    {
                                        oDataset = new Dataset();
                                        oDataset.LABEL = Business_Status;
                                        oDataset.LIST_POINT = new List<decimal?>();
                                        oDataset.DATA_LEVEL_SETUP_ID = Site_Setup_ID;

                                        foreach (string Business_Niche in List_Business_Niche)
                                        {
                                            decimal? point = oList_Site_Business_Vacancy.Count(oBusiness => oBusiness.BUSINESS_STATUS == Business_Status && oBusiness.BUSINESS_NICHE == Business_Niche);
                                            oDataset.LIST_POINT.Add(point);
                                        }

                                        oSite_Kpi_Dialog_Data.KPI_DATA.LIST_DATASET.Add(oDataset);
                                    }
                                }

                                oSite_Kpi_Dialog_Data.KPI_DATA.LIST_LABEL = List_Business_Niche.ToList();

                                #endregion
                            }
                        }

                        oList_Site_Kpi_Dialog_Data.Add(oSite_Kpi_Dialog_Data);

                        #endregion

                    }
                }

                #endregion

                #endregion

                return oList_Site_Kpi_Dialog_Data;
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }
        }
        #endregion
        #region Get_Area_Kpi_Dialog_Data
        public List<Area_Kpi_Dialog_Data> Get_Area_Kpi_Dialog_Data(Params_Get_Area_Kpi_Dialog_Data i_Params_Get_Area_Kpi_Dialog_Data)
        {
            List<Area_Kpi_Dialog_Data> oList_Area_Kpi_Dialog_Data = new List<Area_Kpi_Dialog_Data>();

            if (i_Params_Get_Area_Kpi_Dialog_Data.ENUM_TIMESPAN != null && i_Params_Get_Area_Kpi_Dialog_Data.START_DATE != null && i_Params_Get_Area_Kpi_Dialog_Data.END_DATE != null)
            {

                if (i_Params_Get_Area_Kpi_Dialog_Data.LIST_AREA_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID == null || i_Params_Get_Area_Kpi_Dialog_Data.LIST_AREA_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID.Count == 0)
                {
                    return oList_Area_Kpi_Dialog_Data;
                }

                #region General Data

                #region Declaration & Initialization

                long? Trendline_Setup_ID = 0;
                long? Not_Trendline_Setup_ID = 0;
                long? Geodata_Setup_ID = 0;
                long? Area_Setup_ID = 0;
                long? District_Setup_ID = 0;
                Area oArea = new Area();

                #endregion

                #region Get Setups & Area

                var get_kpi_type = Task.Run(() =>
                {
                    List<Setup> oKpi_Type_Setup = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
                    {
                        SETUP_CATEGORY_NAME = "Kpi Type",
                        OWNER_ID = this.oBLC_Initializer.Owner_ID
                    }).List_Setup;
                    foreach (Setup oSetup in oKpi_Type_Setup)
                    {
                        switch (oSetup.VALUE)
                        {
                            case "Trendline":
                                Trendline_Setup_ID = oSetup.SETUP_ID;
                                break;
                            case "Not Trendline":
                                Not_Trendline_Setup_ID = oSetup.SETUP_ID;
                                break;
                            case "Geo Data":
                                Geodata_Setup_ID = oSetup.SETUP_ID;
                                break;
                        }
                    }
                });

                var get_site_setup = Task.Run(() =>
                {
                    List<Setup> oList_Data_Level_Setup = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
                    {
                        SETUP_CATEGORY_NAME = "Data Level",
                        OWNER_ID = this.oBLC_Initializer.Owner_ID
                    }).List_Setup;
                    if (oList_Data_Level_Setup != null && oList_Data_Level_Setup.Count > 0)
                    {
                        Area_Setup_ID = oList_Data_Level_Setup.Find(setup => setup.VALUE == "Area").SETUP_ID;
                        District_Setup_ID = oList_Data_Level_Setup.Find(setup => setup.VALUE == "District").SETUP_ID;
                    }
                    else
                    {
                        throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0045).Replace("%1", "Data Level")); // Data Level Setup Not Found
                    }
                });

                var get_area = Task.Run(() =>
                {
                    oArea = Get_Area_By_AREA_ID_Adv(new Params_Get_Area_By_AREA_ID()
                    {
                        AREA_ID = i_Params_Get_Area_Kpi_Dialog_Data.AREA_ID
                    });
                });

                Task.WaitAll(get_kpi_type, get_site_setup, get_area);

                #endregion

                #endregion

                #region Get Organization_Data_Source_Kpi

                #region Declaration & Initialization

                List<Organization_data_source_kpi> oList_District_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                List<Organization_data_source_kpi> oList_Area_Organization_data_source_kpi = new List<Organization_data_source_kpi>();

                #endregion

                #region Get Organization_Data_Source_Kpi

                var get_district_kpi = Task.Run(() =>
                {
                    if (i_Params_Get_Area_Kpi_Dialog_Data.LIST_DISTRICT_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID != null && i_Params_Get_Area_Kpi_Dialog_Data.LIST_DISTRICT_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID.Count > 0)
                    {
                        oList_District_Organization_data_source_kpi = Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv(new Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List()
                        {
                            ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = i_Params_Get_Area_Kpi_Dialog_Data.LIST_DISTRICT_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID
                        });
                        if (i_Params_Get_Area_Kpi_Dialog_Data.DIMENSION_ID != null && oList_District_Organization_data_source_kpi != null && oList_District_Organization_data_source_kpi.Count > 0)
                        {
                            oList_District_Organization_data_source_kpi.RemoveAll(oDistrict_Organization_data_source_kpi => i_Params_Get_Area_Kpi_Dialog_Data.DIMENSION_ID != oDistrict_Organization_data_source_kpi.Kpi.DIMENSION_ID);
                        }
                    }
                });

                var get_area_kpi = Task.Run(() =>
                {
                    if (i_Params_Get_Area_Kpi_Dialog_Data.LIST_AREA_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID != null && i_Params_Get_Area_Kpi_Dialog_Data.LIST_AREA_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID.Count > 0)
                    {
                        oList_Area_Organization_data_source_kpi = Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv(new Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List()
                        {
                            ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = i_Params_Get_Area_Kpi_Dialog_Data.LIST_AREA_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID
                        });
                        if (i_Params_Get_Area_Kpi_Dialog_Data.DIMENSION_ID != null && oList_Area_Organization_data_source_kpi != null && oList_Area_Organization_data_source_kpi.Count > 0)
                        {
                            oList_Area_Organization_data_source_kpi.RemoveAll(oArea_Organization_data_source_kpi => i_Params_Get_Area_Kpi_Dialog_Data.DIMENSION_ID != oArea_Organization_data_source_kpi.Kpi.DIMENSION_ID);
                        }
                    }
                });

                Task.WaitAll(get_district_kpi, get_area_kpi);

                #endregion

                #endregion

                #region Group Organization_Data_Source_Kpi

                #region Declaration & Initialization

                List<int?> oList_District_Trendline_Organization_data_source_kpi_ID = new List<int?>();
                List<int?> oList_District_Not_Trendline_Organization_data_source_kpi_ID = new List<int?>();
                List<int?> oList_District_Geodata_Organization_data_source_kpi_ID = new List<int?>();
                List<int?> oList_Area_Trendline_Organization_data_source_kpi_ID = new List<int?>();
                List<int?> oList_Area_Not_Trendline_Organization_data_source_kpi_ID = new List<int?>();
                List<int?> oList_Area_Geodata_Organization_data_source_kpi_ID = new List<int?>();


                #endregion

                #region Organization_Data_Source_Kpi

                var group_district_organization_data_source_kpi = Task.Run(() =>
                {
                    if (oList_District_Organization_data_source_kpi != null && oList_District_Organization_data_source_kpi.Count > 0)
                    {
                        foreach (Organization_data_source_kpi oOrganization_data_source_kpi in oList_District_Organization_data_source_kpi)
                        {
                            if (oOrganization_data_source_kpi.Kpi.KPI_TYPE_SETUP_ID == Trendline_Setup_ID)
                            {
                                oList_District_Trendline_Organization_data_source_kpi_ID.Add(oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID);
                            }
                            else if (oOrganization_data_source_kpi.Kpi.KPI_TYPE_SETUP_ID == Not_Trendline_Setup_ID)
                            {
                                oList_District_Not_Trendline_Organization_data_source_kpi_ID.Add(oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID);
                            }
                            else if (oOrganization_data_source_kpi.Kpi.KPI_TYPE_SETUP_ID == Geodata_Setup_ID)
                            {
                                oList_District_Geodata_Organization_data_source_kpi_ID.Add(oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID);
                            }

                        }
                    }
                });

                var group_area_organization_data_source_kpi = Task.Run(() =>
                {
                    if (oList_Area_Organization_data_source_kpi != null && oList_Area_Organization_data_source_kpi.Count > 0)
                    {
                        foreach (Organization_data_source_kpi oOrganization_data_source_kpi in oList_Area_Organization_data_source_kpi)
                        {
                            if (oOrganization_data_source_kpi.Kpi.KPI_TYPE_SETUP_ID == Trendline_Setup_ID)
                            {
                                oList_Area_Trendline_Organization_data_source_kpi_ID.Add(oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID);
                            }
                            else if (oOrganization_data_source_kpi.Kpi.KPI_TYPE_SETUP_ID == Not_Trendline_Setup_ID)
                            {
                                oList_Area_Not_Trendline_Organization_data_source_kpi_ID.Add(oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID);
                            }
                            else if (oOrganization_data_source_kpi.Kpi.KPI_TYPE_SETUP_ID == Geodata_Setup_ID)
                            {
                                oList_Area_Geodata_Organization_data_source_kpi_ID.Add(oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID);
                            }

                        }
                    }
                });

                Task.WaitAll(group_district_organization_data_source_kpi, group_area_organization_data_source_kpi);

                #endregion

                #endregion

                #region Get Kpi_Data

                #region Declaration & Initialization

                List<District_kpi_data> oList_Trendline_District_kpi_data = new List<District_kpi_data>();
                List<District_kpi_data> oList_Not_Trendline_District_kpi_data = new List<District_kpi_data>();
                List<Area_kpi_data> oList_Trendline_Area_kpi_data = new List<Area_kpi_data>();
                List<Area_kpi_data> oList_Not_Trendline_Area_kpi_data = new List<Area_kpi_data>();
                List<GeoData> oList_Area_GeoData_Bylaw_Complaint = new List<GeoData>();
                List<Business> oList_Area_Business_Count = new List<Business>();
                List<Business> oList_Area_Business_Vacancy = new List<Business>();

                #endregion

                #region Kpi_data

                var get_trendline_district_kpi_data = Task.Run(() =>
                {
                    if (oList_District_Trendline_Organization_data_source_kpi_ID != null && oList_District_Trendline_Organization_data_source_kpi_ID.Count > 0)
                    {
                        oList_Trendline_District_kpi_data = Get_District_Kpi_Data_By_Where(new Params_Get_District_Kpi_Data_By_Where()
                        {
                            DISTRICT_ID_LIST = new List<long?>() { i_Params_Get_Area_Kpi_Dialog_Data.DISTRICT_ID },
                            ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = oList_District_Trendline_Organization_data_source_kpi_ID,
                            ENUM_TIMESPAN = i_Params_Get_Area_Kpi_Dialog_Data.ENUM_TIMESPAN,
                            START_DATE = i_Params_Get_Area_Kpi_Dialog_Data.START_DATE,
                            END_DATE = i_Params_Get_Area_Kpi_Dialog_Data.END_DATE
                        });
                    }
                });
                var get_not_trendline_district_kpi_data = Task.Run(() =>
                {
                    if (oList_District_Not_Trendline_Organization_data_source_kpi_ID != null && oList_District_Not_Trendline_Organization_data_source_kpi_ID.Count > 0)
                    {
                        oList_Not_Trendline_District_kpi_data = Get_District_Kpi_Data_Aggregate_Sum(new Params_Get_District_Kpi_Data_Aggregate_Sum()
                        {
                            DISTRICT_ID_LIST = new List<long?>() { i_Params_Get_Area_Kpi_Dialog_Data.DISTRICT_ID },
                            ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = oList_District_Not_Trendline_Organization_data_source_kpi_ID,
                            ENUM_TIMESPAN = i_Params_Get_Area_Kpi_Dialog_Data.ENUM_TIMESPAN,
                            START_DATE = i_Params_Get_Area_Kpi_Dialog_Data.START_DATE,
                            END_DATE = i_Params_Get_Area_Kpi_Dialog_Data.END_DATE
                        });
                    }
                });
                var get_trendline_area_kpi_data = Task.Run(() =>
                {
                    if (oList_Area_Trendline_Organization_data_source_kpi_ID != null && oList_Area_Trendline_Organization_data_source_kpi_ID.Count > 0)
                    {
                        oList_Trendline_Area_kpi_data = Get_Area_Kpi_Data_By_Where(new Params_Get_Area_Kpi_Data_By_Where()
                        {
                            AREA_ID_LIST = new List<long?>() { i_Params_Get_Area_Kpi_Dialog_Data.AREA_ID },
                            ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = oList_Area_Trendline_Organization_data_source_kpi_ID,
                            ENUM_TIMESPAN = i_Params_Get_Area_Kpi_Dialog_Data.ENUM_TIMESPAN,
                            START_DATE = i_Params_Get_Area_Kpi_Dialog_Data.START_DATE,
                            END_DATE = i_Params_Get_Area_Kpi_Dialog_Data.END_DATE
                        });
                    }
                });
                var get_not_trendline_area_kpi_data = Task.Run(() =>
                {
                    if (oList_Area_Not_Trendline_Organization_data_source_kpi_ID != null && oList_Area_Not_Trendline_Organization_data_source_kpi_ID.Count > 0)
                    {
                        oList_Not_Trendline_Area_kpi_data = Get_Area_Kpi_Data_Aggregate_Sum(new Params_Get_Area_Kpi_Data_Aggregate_Sum()
                        {
                            AREA_ID_LIST = new List<long?>() { i_Params_Get_Area_Kpi_Dialog_Data.AREA_ID },
                            ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = oList_Area_Not_Trendline_Organization_data_source_kpi_ID,
                            ENUM_TIMESPAN = i_Params_Get_Area_Kpi_Dialog_Data.ENUM_TIMESPAN,
                            START_DATE = i_Params_Get_Area_Kpi_Dialog_Data.START_DATE,
                            END_DATE = i_Params_Get_Area_Kpi_Dialog_Data.END_DATE
                        });
                    }
                });
                var get_area_geodata_bylaw_complaints = Task.Run(() =>
                {
                    Organization_data_source_kpi oOrganization_data_source_kpi = oList_Area_Organization_data_source_kpi.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.NAME == "Bylaw Complaints");
                    if (oOrganization_data_source_kpi != null)
                    {
                        int? Bylaw_Complaints_Organization_Data_source_Kpi_ID = oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID;
                        oList_Area_GeoData_Bylaw_Complaint = Get_GeoData_By_Where(new Params_Get_GeoData_By_Where()
                        {
                            LIST_LEVEL_ID = new List<long?>() { i_Params_Get_Area_Kpi_Dialog_Data.AREA_ID },
                            LEVEL_SETUP_ID = Area_Setup_ID,
                            ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = new List<int?> { Bylaw_Complaints_Organization_Data_source_Kpi_ID },
                            START_DATE = i_Params_Get_Area_Kpi_Dialog_Data.START_DATE
                        });
                    }

                });
                var get_area_geodata_business_count = Task.Run(() =>
                {
                    Organization_data_source_kpi oOrganization_data_source_kpi = oList_Area_Organization_data_source_kpi.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.NAME == "Businesses By Category");
                    if (oOrganization_data_source_kpi != null)
                    {
                        int? Businesses_Organization_Data_source_Kpi_ID = oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID;
                        oList_Area_Business_Count = Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID(new Params_Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID()
                        {
                            ORGANIZATION_DATA_SOURCE_KPI_ID = Businesses_Organization_Data_source_Kpi_ID,
                            LIST_LEVEL_ID = new List<long?>() { i_Params_Get_Area_Kpi_Dialog_Data.AREA_ID },
                            LEVEL_SETUP_ID = Area_Setup_ID
                        });
                    }
                });
                var get_area_geodata_business_vacancy = Task.Run(() =>
                {
                    Organization_data_source_kpi oOrganization_data_source_kpi = oList_Area_Organization_data_source_kpi.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.NAME == "Businesses Vacancy");
                    if (oOrganization_data_source_kpi != null)
                    {
                        int? Businesses_Organization_Data_source_Kpi_ID = oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID;
                        oList_Area_Business_Vacancy = Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID(new Params_Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID()
                        {
                            ORGANIZATION_DATA_SOURCE_KPI_ID = Businesses_Organization_Data_source_Kpi_ID,
                            LIST_LEVEL_ID = new List<long?>() { i_Params_Get_Area_Kpi_Dialog_Data.AREA_ID },
                            LEVEL_SETUP_ID = Area_Setup_ID
                        });
                    }
                });

                Task.WaitAll(get_trendline_district_kpi_data, get_not_trendline_district_kpi_data,
                            get_trendline_area_kpi_data, get_not_trendline_area_kpi_data,
                            get_area_geodata_bylaw_complaints, get_area_geodata_business_count, get_area_geodata_business_vacancy);

                #endregion

                #endregion

                #region Fill List_Area_Kpi_Dialog_Data

                #region Declaration & Initialization

                Area_Kpi_Dialog_Data oArea_Kpi_Dialog_Data;

                #endregion

                #region List_Area_Kpi_Dialog_Data

                if (oList_Area_Organization_data_source_kpi != null && oList_Area_Organization_data_source_kpi.Count > 0)
                {

                    foreach (Organization_data_source_kpi oOrganization_data_source_kpi in oList_Area_Organization_data_source_kpi)
                    {
                        oArea_Kpi_Dialog_Data = new Area_Kpi_Dialog_Data();
                        oArea_Kpi_Dialog_Data.ORGANIZATION_DATA_SOURCE_KPI_ID = oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID;
                        oArea_Kpi_Dialog_Data.KPI_ID = oOrganization_data_source_kpi.KPI_ID;
                        if (oOrganization_data_source_kpi.Kpi.NAME != "Businesses By Category" && oOrganization_data_source_kpi.Kpi.NAME != "Businesses Vacancy")
                        {
                            oArea_Kpi_Dialog_Data.TITLE = oOrganization_data_source_kpi.Kpi.NAME + " From " + i_Params_Get_Area_Kpi_Dialog_Data.START_DATE.ToString() + " Till " + i_Params_Get_Area_Kpi_Dialog_Data.END_DATE.ToString();
                        }
                        else
                        {
                            oArea_Kpi_Dialog_Data.TITLE = oOrganization_data_source_kpi.Kpi.NAME;
                        }

                        #region Fill Kpi_Data

                        oArea_Kpi_Dialog_Data.KPI_DATA = new Data_point();

                        if (oOrganization_data_source_kpi.Kpi.KPI_TYPE_SETUP_ID == Trendline_Setup_ID)
                        {
                            #region Trendline

                            oArea_Kpi_Dialog_Data.KPI_DATA.LIST_LABEL = new List<string>();
                            oArea_Kpi_Dialog_Data.KPI_DATA.LIST_DATASET = new List<Dataset>();

                            if (oList_Trendline_Area_kpi_data != null & oList_Trendline_Area_kpi_data.Count > 0)
                            {
                                List<Area_kpi_data> oList_Area_kpi_data = oList_Trendline_Area_kpi_data.Where(oArea_kpi_data => oArea_kpi_data.AREA_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID == oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();
                                List<District_kpi_data> oList_District_kpi_data = oList_Trendline_District_kpi_data.Where(oDistrict_kpi_data => oDistrict_kpi_data.DISTRICT_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID == oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();
                                if (oList_Area_kpi_data != null && oList_Area_kpi_data.Count > 0)
                                {
                                    List<decimal?> List_Point_Area = new List<decimal?>();
                                    List<decimal?> List_Point_District = new List<decimal?>();

                                    foreach (Area_kpi_data oArea_kpi_data in oList_Area_kpi_data)
                                    {
                                        if (i_Params_Get_Area_Kpi_Dialog_Data.ENUM_TIMESPAN == Enum_Timespan.X_DAILY_COLLECTION)
                                        {
                                            oArea_Kpi_Dialog_Data.KPI_DATA.LIST_LABEL.Add(oArea_kpi_data.RECORD_DATE.ToShortDateString());
                                        }
                                        else
                                        {
                                            oArea_Kpi_Dialog_Data.KPI_DATA.LIST_LABEL.Add(oArea_kpi_data.VALUE_NAME);
                                        }
                                        List_Point_Area.Add((decimal?)oArea_kpi_data.VALUE);
                                        if (oList_District_kpi_data != null && oList_District_kpi_data.Count > 0)
                                        {
                                            District_kpi_data oDistrict_kpi_data = oList_District_kpi_data.First(oDistrict_kpi_data => oDistrict_kpi_data.VALUE_NAME == oArea_kpi_data.VALUE_NAME);
                                            decimal? point = null;
                                            if (oDistrict_kpi_data != null)
                                            {
                                                point = oDistrict_kpi_data.VALUE;
                                            }
                                            List_Point_District.Add(point);
                                        }
                                    }

                                    oArea_Kpi_Dialog_Data.KPI_DATA.LIST_DATASET.Add(new Dataset() { LABEL = oArea.NAME, LIST_POINT = List_Point_Area, DATA_LEVEL_SETUP_ID = Area_Setup_ID });
                                    if (List_Point_District != null && List_Point_District.Count > 0)
                                    {
                                        oArea_Kpi_Dialog_Data.KPI_DATA.LIST_DATASET.Add(new Dataset() { LABEL = oArea.District.NAME, LIST_POINT = List_Point_District, DATA_LEVEL_SETUP_ID = District_Setup_ID });
                                    }
                                }
                            }

                            #endregion
                        }
                        else if (oOrganization_data_source_kpi.Kpi.KPI_TYPE_SETUP_ID == Not_Trendline_Setup_ID)
                        {
                            #region Not Trendline

                            oArea_Kpi_Dialog_Data.KPI_DATA.LIST_LABEL = new List<string>();
                            oArea_Kpi_Dialog_Data.KPI_DATA.LIST_DATASET = new List<Dataset>();

                            if (oList_Not_Trendline_Area_kpi_data != null & oList_Not_Trendline_Area_kpi_data.Count > 0)
                            {
                                List<Area_kpi_data> oList_Area_kpi_data = oList_Not_Trendline_Area_kpi_data.Where(oArea_kpi_data => oArea_kpi_data.AREA_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID == oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();
                                if (oList_Area_kpi_data != null && oList_Area_kpi_data.Count > 0)
                                {
                                    #region Order Area_kpi_data

                                    oList_Area_kpi_data = oList_Area_kpi_data.OrderBy(oArea_kpi_data =>
                                    {
                                        if (oArea_kpi_data.VALUE_NAME == null)
                                        {
                                            return int.MaxValue;
                                        }
                                        int num;
                                        if (int.TryParse(Regex.Match(oArea_kpi_data.VALUE_NAME, @"\d+").Value, out num))
                                        {
                                            return num;
                                        }
                                        else if (oArea_kpi_data.VALUE_NAME.ToLower().Contains("under"))
                                        {
                                            return -1;
                                        }
                                        else if (oArea_kpi_data.VALUE_NAME.ToLower().Contains("over"))
                                        {
                                            return int.MaxValue;
                                        }
                                        else
                                        {
                                            return int.MaxValue;
                                        }
                                    }).ToList();

                                    #endregion

                                    if (oOrganization_data_source_kpi.Kpi.NAME != "Visitor Origins")
                                    {
                                        #region Not Visitor Origins

                                        List<District_kpi_data> oList_District_kpi_data = oList_Not_Trendline_District_kpi_data.Where(oDistrict_kpi_data => oDistrict_kpi_data.DISTRICT_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID == oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();

                                        List<decimal?> List_Point_Area = new List<decimal?>();
                                        List<decimal?> List_Point_District = new List<decimal?>();

                                        foreach (Area_kpi_data oArea_kpi_data in oList_Area_kpi_data)
                                        {
                                            oArea_Kpi_Dialog_Data.KPI_DATA.LIST_LABEL.Add(oArea_kpi_data.VALUE_NAME);
                                            List_Point_Area.Add((decimal?)oArea_kpi_data.VALUE);
                                            if (oList_District_kpi_data != null && oList_District_kpi_data.Count > 0)
                                            {
                                                District_kpi_data oDistrict_kpi_data = oList_District_kpi_data.Find(oDistrict_kpi_data => oDistrict_kpi_data.VALUE_NAME == oArea_kpi_data.VALUE_NAME);
                                                decimal? point = null;
                                                if (oDistrict_kpi_data != null)
                                                {
                                                    point = oDistrict_kpi_data.VALUE;
                                                }
                                                List_Point_District.Add(point);
                                            }
                                        }

                                        oArea_Kpi_Dialog_Data.KPI_DATA.LIST_DATASET.Add(new Dataset() { LABEL = oArea.NAME, LIST_POINT = List_Point_Area, DATA_LEVEL_SETUP_ID = Area_Setup_ID });
                                        if (List_Point_District != null && List_Point_District.Count > 0)
                                        {
                                            oArea_Kpi_Dialog_Data.KPI_DATA.LIST_DATASET.Add(new Dataset() { LABEL = oArea.District.NAME, LIST_POINT = List_Point_District, DATA_LEVEL_SETUP_ID = District_Setup_ID });
                                        }

                                        #endregion
                                    }
                                    else if (oOrganization_data_source_kpi.Kpi.NAME == "Visitor Origins")
                                    {
                                        #region Visitor Origins

                                        List<int?> List_Ext_Study_Zone_ID = oList_Area_kpi_data.Where(oArea_kpi_data => !string.IsNullOrEmpty(oArea_kpi_data.AREA_METADATA.CATEGORY))
                                                                                              .Select(oArea_kpi_data =>
                                                                                              {
                                                                                                  string[] parts = oArea_kpi_data.AREA_METADATA.CATEGORY.Split(',');
                                                                                                  var values = oArea_kpi_data.AREA_METADATA.CATEGORY.Split(',')
                                                                                                              .Select(category => category.Split(':'))
                                                                                                              .ToDictionary(category => category[0], category => int.Parse(category[1]));
                                                                                                  int EXT_STUDY_ZONE_ID;
                                                                                                  bool isExist_EXT_STUDY_ZONE_ID = values.TryGetValue("EXT_STUDY_ZONE_ID", out EXT_STUDY_ZONE_ID);
                                                                                                  return (int?)EXT_STUDY_ZONE_ID;
                                                                                              }).ToList();
                                        List<Ext_study_zone> oList_Ext_study_zone = Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID_List(new Params_Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID_List()
                                        {
                                            EXT_STUDY_ZONE_ID_LIST = List_Ext_Study_Zone_ID
                                        });
                                        oArea_Kpi_Dialog_Data.KPI_DATA.LIST_LABEL = new List<string>();
                                        oArea_Kpi_Dialog_Data.KPI_DATA.LIST_LABEL = oList_Area_kpi_data.Select(oArea_kpi_data =>
                                        {
                                            string[] parts = oArea_kpi_data.AREA_METADATA.CATEGORY.Split(',');
                                            var values = parts.Select(category => category.Split(':'))
                                                        .ToDictionary(category => category[0], category => int.Parse(category[1]));
                                            int EXT_STUDY_ZONE_ID;
                                            bool isExist_EXT_STUDY_ZONE_ID = values.TryGetValue("EXT_STUDY_ZONE_ID", out EXT_STUDY_ZONE_ID);
                                            if (isExist_EXT_STUDY_ZONE_ID && EXT_STUDY_ZONE_ID != 0)
                                            {
                                                Ext_study_zone oExt_study_zone = oList_Ext_study_zone.Find(oExt_study_zone => oExt_study_zone.EXT_STUDY_ZONE_ID == EXT_STUDY_ZONE_ID);
                                                if (oExt_study_zone != null)
                                                {
                                                    string Label = oExt_study_zone.NAME;
                                                    return Label;
                                                }
                                                else
                                                {
                                                    return null;
                                                }
                                            }
                                            else
                                            {
                                                return null;
                                            }

                                        }).Where(Label => Label != null).ToList();
                                        List<decimal?> List_Point = oList_Area_kpi_data.Select(oArea_kpi_data => (decimal?)oArea_kpi_data.VALUE).ToList();
                                        oArea_Kpi_Dialog_Data.KPI_DATA.LIST_DATASET = new List<Dataset>();
                                        oArea_Kpi_Dialog_Data.KPI_DATA.LIST_DATASET.Add(new Dataset() { LABEL = oArea.NAME, LIST_POINT = List_Point, DATA_LEVEL_SETUP_ID = Area_Setup_ID });

                                        #endregion
                                    }
                                }
                            }

                            #endregion
                        }
                        else if (oOrganization_data_source_kpi.Kpi.KPI_TYPE_SETUP_ID == Geodata_Setup_ID)
                        {
                            if (oOrganization_data_source_kpi.Kpi.NAME == "Bylaw Complaints")
                            {
                                #region Bylaw Complaints

                                var grouped_GeoData_byLaw_Complaint = oList_Area_GeoData_Bylaw_Complaint.SelectMany(oGeoData => oGeoData.DATA_LIST
                                               .Where(oData => oData.NAME == "COMPLAINT_CATEGORY")
                                               .Select(oData => new { GeoData = oGeoData, DataValue = oData.VALUE }))
                                               .GroupBy(oData => oData.DataValue)
                                               .Select(GeoData => new { Key = GeoData.Key, GeoDataList = GeoData.Select(x => x.GeoData).ToList() });

                                oArea_Kpi_Dialog_Data.KPI_DATA = new Data_point();
                                oArea_Kpi_Dialog_Data.KPI_DATA.LIST_DATASET = new List<Dataset>();
                                oArea_Kpi_Dialog_Data.KPI_DATA.LIST_LABEL = new List<string>();
                                List<Decimal?> List_Point = new List<Decimal?>();

                                foreach (var oGeoData_byLaw_Complaint in grouped_GeoData_byLaw_Complaint)
                                {
                                    oArea_Kpi_Dialog_Data.KPI_DATA.LIST_LABEL.Add(oGeoData_byLaw_Complaint.Key);
                                    List_Point.Add(oGeoData_byLaw_Complaint.GeoDataList.Count);
                                }

                                oArea_Kpi_Dialog_Data.KPI_DATA.LIST_DATASET.Add(new Dataset()
                                {
                                    LABEL = oArea.NAME,
                                    LIST_POINT = List_Point,
                                    DATA_LEVEL_SETUP_ID = Area_Setup_ID
                                });

                                #endregion
                            }
                            else if (oOrganization_data_source_kpi.Kpi.NAME == "Businesses By Category")
                            {
                                #region Businesses By Category

                                oArea_Kpi_Dialog_Data.KPI_DATA = new Data_point();
                                oArea_Kpi_Dialog_Data.KPI_DATA.LIST_DATASET = new List<Dataset>();
                                oArea_Kpi_Dialog_Data.KPI_DATA.LIST_LABEL = new List<string>();
                                List<decimal?> List_Point = new List<decimal?>();

                                oArea_Kpi_Dialog_Data.KPI_DATA.LIST_LABEL = oList_Area_Business_Count.SelectMany(oBusiness => oBusiness.LIST_BUSINESS_CATEGORY).Distinct().ToList();

                                foreach (string Business_Category in oArea_Kpi_Dialog_Data.KPI_DATA.LIST_LABEL)
                                {
                                    decimal? Point = oList_Area_Business_Count.Count(oBusiness => oBusiness.LIST_BUSINESS_CATEGORY.Contains(Business_Category));
                                    List_Point.Add(Point);
                                }

                                oArea_Kpi_Dialog_Data.KPI_DATA.LIST_DATASET.Add(new Dataset()
                                {
                                    LABEL = oArea.NAME,
                                    LIST_POINT = List_Point,
                                    DATA_LEVEL_SETUP_ID = Area_Setup_ID
                                });

                                #endregion
                            }
                            else if (oOrganization_data_source_kpi.Kpi.NAME == "Businesses Vacancy")
                            {
                                #region Business Vacancy

                                oArea_Kpi_Dialog_Data.KPI_DATA = new Data_point();
                                oArea_Kpi_Dialog_Data.KPI_DATA.LIST_DATASET = new List<Dataset>();
                                oArea_Kpi_Dialog_Data.KPI_DATA.LIST_LABEL = new List<string>();

                                IEnumerable<string> List_Business_Niche = oList_Area_Business_Vacancy.Select(oBusiness => oBusiness.BUSINESS_NICHE).Distinct();
                                IEnumerable<string> List_Business_Status = oList_Area_Business_Vacancy.Select(oBusiness => oBusiness.BUSINESS_STATUS).Distinct();

                                Dataset oDataset;

                                foreach (string Business_Status in List_Business_Status)
                                {
                                    if (Business_Status != null)
                                    {
                                        oDataset = new Dataset();
                                        oDataset.LABEL = Business_Status;
                                        oDataset.LIST_POINT = new List<decimal?>();
                                        oDataset.DATA_LEVEL_SETUP_ID = Area_Setup_ID;

                                        foreach (string Business_Niche in List_Business_Niche)
                                        {
                                            decimal? point = oList_Area_Business_Vacancy.Count(oBusiness => oBusiness.BUSINESS_STATUS == Business_Status && oBusiness.BUSINESS_NICHE == Business_Niche);
                                            oDataset.LIST_POINT.Add(point);
                                        }

                                        oArea_Kpi_Dialog_Data.KPI_DATA.LIST_DATASET.Add(oDataset);
                                    }
                                }

                                oArea_Kpi_Dialog_Data.KPI_DATA.LIST_LABEL = List_Business_Niche.ToList();

                                #endregion
                            }
                        }

                        #endregion

                        oList_Area_Kpi_Dialog_Data.Add(oArea_Kpi_Dialog_Data);
                    }
                }

                #endregion

                #endregion

                return oList_Area_Kpi_Dialog_Data;
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }
        }
        #endregion
        #region Get_District_Kpi_Dialog_Data
        public List<District_Kpi_Dialog_Data> Get_District_Kpi_Dialog_Data(Params_Get_District_Kpi_Dialog_Data i_Params_Get_District_Kpi_Dialog_Data)
        {
            List<District_Kpi_Dialog_Data> oList_District_Kpi_Dialog_Data = new List<District_Kpi_Dialog_Data>();

            if (i_Params_Get_District_Kpi_Dialog_Data.ENUM_TIMESPAN != null && i_Params_Get_District_Kpi_Dialog_Data.START_DATE != null && i_Params_Get_District_Kpi_Dialog_Data.END_DATE != null)
            {

                if (i_Params_Get_District_Kpi_Dialog_Data.LIST_DISTRICT_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID == null || i_Params_Get_District_Kpi_Dialog_Data.LIST_DISTRICT_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID.Count == 0)
                {
                    return oList_District_Kpi_Dialog_Data;
                }

                #region General Data

                #region Declaration & Initialization

                long? Trendline_Setup_ID = 0;
                long? Not_Trendline_Setup_ID = 0;
                long? Geodata_Setup_ID = 0;
                long? District_Setup_ID = 0;
                District oDistrict = new District();

                #endregion

                #region Get Setups & District

                var get_kpi_type = Task.Run(() =>
                {
                    List<Setup> oKpi_Type_Setup = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
                    {
                        SETUP_CATEGORY_NAME = "Kpi Type",
                        OWNER_ID = this.oBLC_Initializer.Owner_ID
                    }).List_Setup;
                    foreach (Setup oSetup in oKpi_Type_Setup)
                    {
                        switch (oSetup.VALUE)
                        {
                            case "Trendline":
                                Trendline_Setup_ID = oSetup.SETUP_ID;
                                break;
                            case "Not Trendline":
                                Not_Trendline_Setup_ID = oSetup.SETUP_ID;
                                break;
                            case "Geo Data":
                                Geodata_Setup_ID = oSetup.SETUP_ID;
                                break;
                        }
                    }
                });

                var get_site_setup = Task.Run(() =>
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

                var get_district = Task.Run(() =>
                {
                    oDistrict = Get_District_By_DISTRICT_ID_Adv(new Params_Get_District_By_DISTRICT_ID()
                    {
                        DISTRICT_ID = i_Params_Get_District_Kpi_Dialog_Data.DISTRICT_ID
                    });
                });

                Task.WaitAll(get_kpi_type, get_site_setup, get_district);

                #endregion

                #endregion

                #region Get Organization_Data_Source_Kpi

                #region Declaration & Initialization

                List<Organization_data_source_kpi> oList_District_Organization_data_source_kpi = new List<Organization_data_source_kpi>();

                #endregion

                #region Get Organization_Data_Source_Kpi

                if (i_Params_Get_District_Kpi_Dialog_Data.LIST_DISTRICT_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID != null && i_Params_Get_District_Kpi_Dialog_Data.LIST_DISTRICT_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID.Count > 0)
                {
                    oList_District_Organization_data_source_kpi = Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv(new Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List()
                    {
                        ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = i_Params_Get_District_Kpi_Dialog_Data.LIST_DISTRICT_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID
                    });
                    if (i_Params_Get_District_Kpi_Dialog_Data.DIMENSION_ID != null && oList_District_Organization_data_source_kpi != null && oList_District_Organization_data_source_kpi.Count > 0)
                    {
                        oList_District_Organization_data_source_kpi.RemoveAll(oDistrict_Organization_data_source_kpi => i_Params_Get_District_Kpi_Dialog_Data.DIMENSION_ID != oDistrict_Organization_data_source_kpi.Kpi.DIMENSION_ID);
                    }
                }

                #endregion

                #endregion

                #region Group Organization_Data_Source_Kpi

                #region Declaration & Initialization

                List<int?> oList_District_Trendline_Organization_data_source_kpi_ID = new List<int?>();
                List<int?> oList_District_Not_Trendline_Organization_data_source_kpi_ID = new List<int?>();
                List<int?> oList_District_Geodata_Organization_data_source_kpi_ID = new List<int?>();

                #endregion

                #region Organization_Data_Source_Kpi

                var group_district_organization_data_source_kpi = Task.Run(() =>
                {
                    if (oList_District_Organization_data_source_kpi != null && oList_District_Organization_data_source_kpi.Count > 0)
                    {
                        foreach (Organization_data_source_kpi oOrganization_data_source_kpi in oList_District_Organization_data_source_kpi)
                        {
                            if (oOrganization_data_source_kpi.Kpi.KPI_TYPE_SETUP_ID == Trendline_Setup_ID)
                            {
                                oList_District_Trendline_Organization_data_source_kpi_ID.Add(oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID);
                            }
                            else if (oOrganization_data_source_kpi.Kpi.KPI_TYPE_SETUP_ID == Not_Trendline_Setup_ID)
                            {
                                oList_District_Not_Trendline_Organization_data_source_kpi_ID.Add(oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID);
                            }
                            else if (oOrganization_data_source_kpi.Kpi.KPI_TYPE_SETUP_ID == Geodata_Setup_ID)
                            {
                                oList_District_Geodata_Organization_data_source_kpi_ID.Add(oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID);
                            }

                        }
                    }
                });

                Task.WaitAll(group_district_organization_data_source_kpi);

                #endregion

                #endregion

                #region Get Kpi_Data

                #region Declaration & Initialization

                List<District_kpi_data> oList_Trendline_District_kpi_data = new List<District_kpi_data>();
                List<District_kpi_data> oList_Not_Trendline_District_kpi_data = new List<District_kpi_data>();
                List<GeoData> oList_District_GeoData_Bylaw_Complaint = new List<GeoData>();
                List<Business> oList_District_Business_Count = new List<Business>();
                List<Business> oList_District_Business_Vacancy = new List<Business>();

                #endregion

                #region Kpi_data

                var get_trendline_district_kpi_data = Task.Run(() =>
                {
                    if (oList_District_Trendline_Organization_data_source_kpi_ID != null && oList_District_Trendline_Organization_data_source_kpi_ID.Count > 0)
                    {
                        oList_Trendline_District_kpi_data = Get_District_Kpi_Data_By_Where(new Params_Get_District_Kpi_Data_By_Where()
                        {
                            DISTRICT_ID_LIST = new List<long?>() { i_Params_Get_District_Kpi_Dialog_Data.DISTRICT_ID },
                            ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = oList_District_Trendline_Organization_data_source_kpi_ID,
                            ENUM_TIMESPAN = i_Params_Get_District_Kpi_Dialog_Data.ENUM_TIMESPAN,
                            START_DATE = i_Params_Get_District_Kpi_Dialog_Data.START_DATE,
                            END_DATE = i_Params_Get_District_Kpi_Dialog_Data.END_DATE
                        });
                    }
                });
                var get_not_trendline_district_kpi_data = Task.Run(() =>
                {
                    if (oList_District_Not_Trendline_Organization_data_source_kpi_ID != null && oList_District_Not_Trendline_Organization_data_source_kpi_ID.Count > 0)
                    {
                        oList_Not_Trendline_District_kpi_data = Get_District_Kpi_Data_Aggregate_Sum(new Params_Get_District_Kpi_Data_Aggregate_Sum()
                        {
                            DISTRICT_ID_LIST = new List<long?>() { i_Params_Get_District_Kpi_Dialog_Data.DISTRICT_ID },
                            ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = oList_District_Not_Trendline_Organization_data_source_kpi_ID,
                            ENUM_TIMESPAN = i_Params_Get_District_Kpi_Dialog_Data.ENUM_TIMESPAN,
                            START_DATE = i_Params_Get_District_Kpi_Dialog_Data.START_DATE,
                            END_DATE = i_Params_Get_District_Kpi_Dialog_Data.END_DATE
                        });
                    }
                });
                var get_district_geodata_bylaw_complaints = Task.Run(() =>
                {
                    Organization_data_source_kpi oOrganization_data_source_kpi = oList_District_Organization_data_source_kpi.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.NAME == "Bylaw Complaints");
                    if (oOrganization_data_source_kpi != null)
                    {
                        int? Bylaw_Complaints_Organization_Data_source_Kpi_ID = oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID;
                        oList_District_GeoData_Bylaw_Complaint = Get_GeoData_By_Where(new Params_Get_GeoData_By_Where()
                        {
                            LIST_LEVEL_ID = new List<long?>() { i_Params_Get_District_Kpi_Dialog_Data.DISTRICT_ID },
                            LEVEL_SETUP_ID = District_Setup_ID,
                            ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = new List<int?> { Bylaw_Complaints_Organization_Data_source_Kpi_ID },
                            START_DATE = i_Params_Get_District_Kpi_Dialog_Data.START_DATE
                        });
                    }

                });
                var get_district_geodata_business_count = Task.Run(() =>
                {
                    Organization_data_source_kpi oOrganization_data_source_kpi = oList_District_Organization_data_source_kpi.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.NAME == "Businesses By Category");
                    if (oOrganization_data_source_kpi != null)
                    {
                        int? Businesses_Organization_Data_source_Kpi_ID = oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID;
                        oList_District_Business_Count = Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID(new Params_Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID()
                        {
                            ORGANIZATION_DATA_SOURCE_KPI_ID = Businesses_Organization_Data_source_Kpi_ID,
                            LIST_LEVEL_ID = new List<long?>() { i_Params_Get_District_Kpi_Dialog_Data.DISTRICT_ID },
                            LEVEL_SETUP_ID = District_Setup_ID
                        });
                    }
                });
                var get_district_geodata_business_vacancy = Task.Run(() =>
                {
                    Organization_data_source_kpi oOrganization_data_source_kpi = oList_District_Organization_data_source_kpi.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.NAME == "Businesses Vacancy");
                    if (oOrganization_data_source_kpi != null)
                    {
                        int? Businesses_Organization_Data_source_Kpi_ID = oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID;
                        oList_District_Business_Vacancy = Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID(new Params_Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID()
                        {
                            ORGANIZATION_DATA_SOURCE_KPI_ID = Businesses_Organization_Data_source_Kpi_ID,
                            LIST_LEVEL_ID = new List<long?>() { i_Params_Get_District_Kpi_Dialog_Data.DISTRICT_ID },
                            LEVEL_SETUP_ID = District_Setup_ID
                        });
                    }
                });

                Task.WaitAll(get_trendline_district_kpi_data, get_not_trendline_district_kpi_data,
                            get_district_geodata_bylaw_complaints, get_district_geodata_business_count, get_district_geodata_business_vacancy);

                #endregion

                #endregion

                #region Fill List_District_Kpi_Dialog_Data

                #region Declaration & Initialization

                District_Kpi_Dialog_Data oDistrict_Kpi_Dialog_Data;

                #endregion

                #region List_District_Kpi_Dialog_Data

                if (oList_District_Organization_data_source_kpi != null && oList_District_Organization_data_source_kpi.Count > 0)
                {

                    foreach (Organization_data_source_kpi oOrganization_data_source_kpi in oList_District_Organization_data_source_kpi)
                    {
                        oDistrict_Kpi_Dialog_Data = new District_Kpi_Dialog_Data();
                        oDistrict_Kpi_Dialog_Data.ORGANIZATION_DATA_SOURCE_KPI_ID = oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID;
                        oDistrict_Kpi_Dialog_Data.KPI_ID = oOrganization_data_source_kpi.KPI_ID;
                        if (oOrganization_data_source_kpi.Kpi.NAME != "Businesses By Category" && oOrganization_data_source_kpi.Kpi.NAME != "Businesses Vacancy")
                        {
                            oDistrict_Kpi_Dialog_Data.TITLE = oOrganization_data_source_kpi.Kpi.NAME + " From " + i_Params_Get_District_Kpi_Dialog_Data.START_DATE.ToString() + " Till " + i_Params_Get_District_Kpi_Dialog_Data.END_DATE.ToString();
                        }
                        else
                        {
                            oDistrict_Kpi_Dialog_Data.TITLE = oOrganization_data_source_kpi.Kpi.NAME;
                        }

                        #region Fill Kpi_Data

                        oDistrict_Kpi_Dialog_Data.KPI_DATA = new Data_point();

                        if (oOrganization_data_source_kpi.Kpi.KPI_TYPE_SETUP_ID == Trendline_Setup_ID)
                        {
                            #region Trendline

                            oDistrict_Kpi_Dialog_Data.KPI_DATA.LIST_LABEL = new List<string>();
                            oDistrict_Kpi_Dialog_Data.KPI_DATA.LIST_DATASET = new List<Dataset>();

                            if (oList_Trendline_District_kpi_data != null & oList_Trendline_District_kpi_data.Count > 0)
                            {
                                List<District_kpi_data> oList_District_kpi_data = oList_Trendline_District_kpi_data.Where(oDistrict_kpi_data => oDistrict_kpi_data.DISTRICT_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID == oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();
                                if (oList_District_kpi_data != null && oList_District_kpi_data.Count > 0)
                                {
                                    List<decimal?> List_Point_District = new List<decimal?>();

                                    foreach (District_kpi_data oDistrict_kpi_data in oList_District_kpi_data)
                                    {
                                        if (i_Params_Get_District_Kpi_Dialog_Data.ENUM_TIMESPAN == Enum_Timespan.X_DAILY_COLLECTION)
                                        {
                                            oDistrict_Kpi_Dialog_Data.KPI_DATA.LIST_LABEL.Add(oDistrict_kpi_data.RECORD_DATE.ToShortDateString());
                                        }
                                        else
                                        {
                                            oDistrict_Kpi_Dialog_Data.KPI_DATA.LIST_LABEL.Add(oDistrict_kpi_data.VALUE_NAME);
                                        }
                                        List_Point_District.Add((decimal?)oDistrict_kpi_data.VALUE);
                                    }

                                    oDistrict_Kpi_Dialog_Data.KPI_DATA.LIST_DATASET.Add(new Dataset() { LABEL = oDistrict.NAME, LIST_POINT = List_Point_District, DATA_LEVEL_SETUP_ID = District_Setup_ID });
                                }
                            }

                            #endregion
                        }
                        else if (oOrganization_data_source_kpi.Kpi.KPI_TYPE_SETUP_ID == Not_Trendline_Setup_ID)
                        {
                            #region Not Trendline

                            oDistrict_Kpi_Dialog_Data.KPI_DATA.LIST_LABEL = new List<string>();
                            oDistrict_Kpi_Dialog_Data.KPI_DATA.LIST_DATASET = new List<Dataset>();

                            if (oList_Not_Trendline_District_kpi_data != null & oList_Not_Trendline_District_kpi_data.Count > 0)
                            {
                                List<District_kpi_data> oList_District_kpi_data = oList_Not_Trendline_District_kpi_data.Where(oDistrict_kpi_data => oDistrict_kpi_data.DISTRICT_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID == oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();
                                if (oList_District_kpi_data != null && oList_District_kpi_data.Count > 0)
                                {
                                    #region Order District_kpi_data

                                    oList_District_kpi_data = oList_District_kpi_data.OrderBy(oDistrict_kpi_data =>
                                    {
                                        if (oDistrict_kpi_data.VALUE_NAME == null)
                                        {
                                            return int.MaxValue;
                                        }
                                        int num;
                                        if (int.TryParse(Regex.Match(oDistrict_kpi_data.VALUE_NAME, @"\d+").Value, out num))
                                        {
                                            return num;
                                        }
                                        else if (oDistrict_kpi_data.VALUE_NAME.ToLower().Contains("under"))
                                        {
                                            return -1;
                                        }
                                        else if (oDistrict_kpi_data.VALUE_NAME.ToLower().Contains("over"))
                                        {
                                            return int.MaxValue;
                                        }
                                        else
                                        {
                                            return int.MaxValue;
                                        }
                                    }).ToList();

                                    #endregion

                                    if (oOrganization_data_source_kpi.Kpi.NAME != "Visitor Origins")
                                    {
                                        #region Not Visitor Origins

                                        List<decimal?> List_Point_District = new List<decimal?>();

                                        foreach (District_kpi_data oDistrict_kpi_data in oList_District_kpi_data)
                                        {
                                            oDistrict_Kpi_Dialog_Data.KPI_DATA.LIST_LABEL.Add(oDistrict_kpi_data.VALUE_NAME);
                                            List_Point_District.Add((decimal?)oDistrict_kpi_data.VALUE);
                                        }

                                        oDistrict_Kpi_Dialog_Data.KPI_DATA.LIST_DATASET.Add(new Dataset() { LABEL = oDistrict.NAME, LIST_POINT = List_Point_District, DATA_LEVEL_SETUP_ID = District_Setup_ID });

                                        #endregion
                                    }
                                    else if (oOrganization_data_source_kpi.Kpi.NAME == "Visitor Origins")
                                    {
                                        #region Visitor Origins
                                        List<int?> List_Ext_Study_Zone_ID = oList_District_kpi_data.Where(oDistrict_kpi_data => !string.IsNullOrEmpty(oDistrict_kpi_data.DISTRICT_METADATA.CATEGORY))
                                                                                              .Select(oDistrict_kpi_data =>
                                                                                              {
                                                                                                  string[] parts = oDistrict_kpi_data.DISTRICT_METADATA.CATEGORY.Split(',');
                                                                                                  var values = oDistrict_kpi_data.DISTRICT_METADATA.CATEGORY.Split(',')
                                                                                                              .Select(category => category.Split(':'))
                                                                                                              .ToDictionary(category => category[0], category => int.Parse(category[1]));
                                                                                                  int EXT_STUDY_ZONE_ID;
                                                                                                  bool isExist_EXT_STUDY_ZONE_ID = values.TryGetValue("EXT_STUDY_ZONE_ID", out EXT_STUDY_ZONE_ID);
                                                                                                  return (int?)EXT_STUDY_ZONE_ID;
                                                                                              }).ToList();
                                        List<Ext_study_zone> oList_Ext_study_zone = Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID_List(new Params_Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID_List()
                                        {
                                            EXT_STUDY_ZONE_ID_LIST = List_Ext_Study_Zone_ID
                                        });
                                        oDistrict_Kpi_Dialog_Data.KPI_DATA.LIST_LABEL = new List<string>();
                                        oDistrict_Kpi_Dialog_Data.KPI_DATA.LIST_LABEL = oList_District_kpi_data.Select(oDistrict_kpi_data =>
                                        {
                                            if (oDistrict_kpi_data.DISTRICT_METADATA.CATEGORY == null)
                                            {
                                                return null;
                                            }
                                            string[] parts = oDistrict_kpi_data.DISTRICT_METADATA.CATEGORY.Split(',');
                                            var values = parts.Select(category => category.Split(':'))
                                                            .ToDictionary(category => category[0], category => int.Parse(category[1]));
                                            int EXT_STUDY_ZONE_ID;
                                            bool isExist_EXT_STUDY_ZONE_ID = values.TryGetValue("EXT_STUDY_ZONE_ID", out EXT_STUDY_ZONE_ID);
                                            if (isExist_EXT_STUDY_ZONE_ID && EXT_STUDY_ZONE_ID != 0)
                                            {
                                                Ext_study_zone oExt_study_zone = oList_Ext_study_zone.Find(oExt_study_zone => oExt_study_zone.EXT_STUDY_ZONE_ID == EXT_STUDY_ZONE_ID);
                                                if (oExt_study_zone != null)
                                                {
                                                    string Label = oExt_study_zone.NAME;
                                                    return Label;
                                                }
                                                else
                                                {
                                                    return null;
                                                }
                                            }
                                            else
                                            {
                                                return null;
                                            }

                                        }).Where(Label => Label != null).ToList();
                                        List<decimal?> List_Point = new List<decimal?>();
                                        if (oDistrict_Kpi_Dialog_Data.KPI_DATA.LIST_LABEL != null && oDistrict_Kpi_Dialog_Data.KPI_DATA.LIST_LABEL.Count > 0)
                                        {
                                            List_Point = oList_District_kpi_data.Select(oDistrict_kpi_data => (decimal?)oDistrict_kpi_data.VALUE).ToList();
                                        }
                                        oDistrict_Kpi_Dialog_Data.KPI_DATA.LIST_DATASET = new List<Dataset>();
                                        oDistrict_Kpi_Dialog_Data.KPI_DATA.LIST_DATASET.Add(new Dataset() { LABEL = oDistrict.NAME, LIST_POINT = List_Point, DATA_LEVEL_SETUP_ID = District_Setup_ID });

                                        #endregion
                                    }
                                }
                            }

                            #endregion
                        }
                        else if (oOrganization_data_source_kpi.Kpi.KPI_TYPE_SETUP_ID == Geodata_Setup_ID)
                        {
                            if (oOrganization_data_source_kpi.Kpi.NAME == "Bylaw Complaints")
                            {
                                #region Bylaw Complaints

                                var grouped_GeoData_byLaw_Complaint = oList_District_GeoData_Bylaw_Complaint.SelectMany(oGeoData => oGeoData.DATA_LIST
                                               .Where(oData => oData.NAME == "COMPLAINT_CATEGORY")
                                               .Select(oData => new { GeoData = oGeoData, DataValue = oData.VALUE }))
                                               .GroupBy(oData => oData.DataValue)
                                               .Select(GeoData => new { Key = GeoData.Key, GeoDataList = GeoData.Select(x => x.GeoData).ToList() });

                                oDistrict_Kpi_Dialog_Data.KPI_DATA = new Data_point();
                                oDistrict_Kpi_Dialog_Data.KPI_DATA.LIST_DATASET = new List<Dataset>();
                                oDistrict_Kpi_Dialog_Data.KPI_DATA.LIST_LABEL = new List<string>();
                                List<Decimal?> List_Point = new List<Decimal?>();

                                foreach (var oGeoData_byLaw_Complaint in grouped_GeoData_byLaw_Complaint)
                                {
                                    oDistrict_Kpi_Dialog_Data.KPI_DATA.LIST_LABEL.Add(oGeoData_byLaw_Complaint.Key);
                                    List_Point.Add(oGeoData_byLaw_Complaint.GeoDataList.Count);
                                }

                                oDistrict_Kpi_Dialog_Data.KPI_DATA.LIST_DATASET.Add(new Dataset()
                                {
                                    LABEL = oDistrict.NAME,
                                    LIST_POINT = List_Point,
                                    DATA_LEVEL_SETUP_ID = District_Setup_ID
                                });

                                #endregion
                            }
                            else if (oOrganization_data_source_kpi.Kpi.NAME == "Businesses By Category")
                            {
                                #region Businesses By Category

                                oDistrict_Kpi_Dialog_Data.KPI_DATA = new Data_point();
                                oDistrict_Kpi_Dialog_Data.KPI_DATA.LIST_DATASET = new List<Dataset>();
                                oDistrict_Kpi_Dialog_Data.KPI_DATA.LIST_LABEL = new List<string>();
                                List<decimal?> List_Point = new List<decimal?>();

                                oDistrict_Kpi_Dialog_Data.KPI_DATA.LIST_LABEL = oList_District_Business_Count.SelectMany(oBusiness => oBusiness.LIST_BUSINESS_CATEGORY).Distinct().ToList();

                                foreach (string Business_Category in oDistrict_Kpi_Dialog_Data.KPI_DATA.LIST_LABEL)
                                {
                                    decimal? Point = oList_District_Business_Count.Count(oBusiness => oBusiness.LIST_BUSINESS_CATEGORY.Contains(Business_Category));
                                    List_Point.Add(Point);
                                }

                                oDistrict_Kpi_Dialog_Data.KPI_DATA.LIST_DATASET.Add(new Dataset()
                                {
                                    LABEL = oDistrict.NAME,
                                    LIST_POINT = List_Point,
                                    DATA_LEVEL_SETUP_ID = District_Setup_ID
                                });

                                #endregion
                            }
                            else if (oOrganization_data_source_kpi.Kpi.NAME == "Businesses Vacancy")
                            {
                                #region Business Vacancy

                                oDistrict_Kpi_Dialog_Data.KPI_DATA = new Data_point();
                                oDistrict_Kpi_Dialog_Data.KPI_DATA.LIST_DATASET = new List<Dataset>();
                                oDistrict_Kpi_Dialog_Data.KPI_DATA.LIST_LABEL = new List<string>();

                                IEnumerable<string> List_Business_Niche = oList_District_Business_Vacancy.Select(oBusiness => oBusiness.BUSINESS_NICHE).Distinct();
                                IEnumerable<string> List_Business_Status = oList_District_Business_Vacancy.Select(oBusiness => oBusiness.BUSINESS_STATUS).Distinct();

                                Dataset oDataset;

                                foreach (string Business_Status in List_Business_Status)
                                {
                                    if (Business_Status != null)
                                    {
                                        oDataset = new Dataset();
                                        oDataset.LABEL = Business_Status;
                                        oDataset.LIST_POINT = new List<decimal?>();
                                        oDataset.DATA_LEVEL_SETUP_ID = District_Setup_ID;

                                        foreach (string Business_Niche in List_Business_Niche)
                                        {
                                            decimal? point = oList_District_Business_Vacancy.Count(oBusiness => oBusiness.BUSINESS_STATUS == Business_Status && oBusiness.BUSINESS_NICHE == Business_Niche);
                                            oDataset.LIST_POINT.Add(point);
                                        }

                                        oDistrict_Kpi_Dialog_Data.KPI_DATA.LIST_DATASET.Add(oDataset);
                                    }
                                }

                                oDistrict_Kpi_Dialog_Data.KPI_DATA.LIST_LABEL = List_Business_Niche.ToList();

                                #endregion
                            }
                        }

                        #endregion

                        oList_District_Kpi_Dialog_Data.Add(oDistrict_Kpi_Dialog_Data);
                    }
                }

                #endregion

                #endregion

                return oList_District_Kpi_Dialog_Data;
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }
        }
        #endregion
        #region Get_Entity_Kpi_Dialog_Data
        public List<Entity_Kpi_Dialog_Data> Get_Entity_Kpi_Dialog_Data(Params_Get_Entity_Kpi_Dialog_Data i_Params_Get_Entity_Kpi_Dialog_Data)
        {
            List<Entity_Kpi_Dialog_Data> oList_Entity_Kpi_Dialog_Data = new List<Entity_Kpi_Dialog_Data>();

            if (i_Params_Get_Entity_Kpi_Dialog_Data.ENUM_TIMESPAN != null && i_Params_Get_Entity_Kpi_Dialog_Data.START_DATE != null && i_Params_Get_Entity_Kpi_Dialog_Data.END_DATE != null)
            {

                if (i_Params_Get_Entity_Kpi_Dialog_Data.LIST_ENTITY_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID == null || i_Params_Get_Entity_Kpi_Dialog_Data.LIST_ENTITY_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID.Count == 0)
                {
                    return oList_Entity_Kpi_Dialog_Data;
                }

                #region General Data

                #region Declaration & Initialization

                long? Trendline_Setup_ID = 0;
                long? Not_Trendline_Setup_ID = 0;
                long? Entity_Setup_ID = 0;
                Entity oEntity = new Entity();

                #endregion

                #region Get Setups & Entity

                var get_kpi_type = Task.Run(() =>
                {
                    List<Setup> oKpi_Type_Setup = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
                    {
                        SETUP_CATEGORY_NAME = "Kpi Type",
                        OWNER_ID = this.oBLC_Initializer.Owner_ID
                    }).List_Setup;
                    foreach (Setup oSetup in oKpi_Type_Setup)
                    {
                        switch (oSetup.VALUE)
                        {
                            case "Trendline":
                                Trendline_Setup_ID = oSetup.SETUP_ID;
                                break;
                            case "Not Trendline":
                                Not_Trendline_Setup_ID = oSetup.SETUP_ID;
                                break;
                        }
                    }
                });

                var get_entity_setup = Task.Run(() =>
                {
                    List<Setup> oList_Data_Level_Setup = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
                    {
                        SETUP_CATEGORY_NAME = "Data Level",
                        OWNER_ID = this.oBLC_Initializer.Owner_ID
                    }).List_Setup;
                    if (oList_Data_Level_Setup != null && oList_Data_Level_Setup.Count > 0)
                    {
                        Entity_Setup_ID = oList_Data_Level_Setup.Find(setup => setup.VALUE == "Entity").SETUP_ID;
                    }
                    else
                    {
                        throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0045).Replace("%1", "Data Level")); // Data Level Setup Not Found
                    }
                });

                var get_entity = Task.Run(() =>
                {
                    oEntity = Get_Entity_By_ENTITY_ID_Adv(new Params_Get_Entity_By_ENTITY_ID()
                    {
                        ENTITY_ID = i_Params_Get_Entity_Kpi_Dialog_Data.ENTITY_ID
                    });
                });

                Task.WaitAll(get_kpi_type, get_entity_setup, get_entity);

                #endregion

                #endregion

                #region Fill Dimension_index

                if (i_Params_Get_Entity_Kpi_Dialog_Data.DIMENSION_ID != null)
                {
                    #region Declaration & Initialization

                    List<Dimension_index> oList_Dimension_index_Entity = new List<Dimension_index>();
                    Dimension oDimension = new Dimension();

                    #endregion

                    #region Get Dimension_index List

                    var get_entity_dmension_index = Task.Run(() =>
                    {
                        oList_Dimension_index_Entity = Props.Copy_Prop_Values_From_Api_Response<List<Dimension_index>>(
                            this._service_mesh.Get_Dimension_index_By_Where(new Service_Mesh.Params_Get_Dimension_index_By_Where()
                            {
                                LIST_LEVEL_ID = new List<long?>() { oEntity.ENTITY_ID },
                                LEVEL_SETUP_ID = Entity_Setup_ID,
                                LIST_DIMENSION_ID = new List<int?>() { i_Params_Get_Entity_Kpi_Dialog_Data.DIMENSION_ID },
                                START_DATE = (DateTime)i_Params_Get_Entity_Kpi_Dialog_Data.START_DATE,
                                END_DATE = (DateTime)i_Params_Get_Entity_Kpi_Dialog_Data.END_DATE,
                                ENUM_TIMESPAN = (Service_Mesh.Enum_Timespan)i_Params_Get_Entity_Kpi_Dialog_Data.ENUM_TIMESPAN

                            }).i_Result
                        );
                    });
                    var get_dimension = Task.Run(() =>
                    {
                        oDimension = Props.Copy_Prop_Values_From_Api_Response<Dimension>(this._service_mesh.Get_Dimension_By_DIMENSION_ID(new Service_Mesh.Params_Get_Dimension_By_DIMENSION_ID()
                        {
                            DIMENSION_ID = i_Params_Get_Entity_Kpi_Dialog_Data.DIMENSION_ID
                        }).i_Result);
                    });

                    Task.WaitAll(get_entity_dmension_index, get_dimension);

                    #endregion

                    #region Add Dimension Index

                    Entity_Kpi_Dialog_Data _Entity_Kpi_Dialog_Data = new Entity_Kpi_Dialog_Data();
                    _Entity_Kpi_Dialog_Data.TITLE = oDimension.NAME.Split(" ")[1] + " Index (%)";
                    _Entity_Kpi_Dialog_Data.KPI_ID = oDimension.DIMENSION_ID;
                    _Entity_Kpi_Dialog_Data.ORGANIZATION_DATA_SOURCE_KPI_ID = 0;
                    _Entity_Kpi_Dialog_Data.LIST_KPI_DATA = new List<Entity_Data_point>();

                    if (oList_Dimension_index_Entity != null && oList_Dimension_index_Entity.Count > 0)
                    {

                        Entity_Data_point oEntity_Data_point = new Entity_Data_point();
                        oEntity_Data_point.LIST_LABEL = new List<string>();
                        oEntity_Data_point.LIST_DATASET = new List<Dataset>();

                        #region Assign Setup_IDs

                        oEntity_Data_point.SEVERITY_TYPE_SETUP_ID = 0;
                        oEntity_Data_point.INCIDENT_CATEGORY_SETUP_ID = 0;

                        #endregion

                        #region Fill Labels & Points

                        List<decimal?> List_Point_Entity = new List<decimal?>();

                        foreach (Dimension_index oDimension_index_Entity in oList_Dimension_index_Entity)
                        {
                            oEntity_Data_point.LIST_LABEL.Add(oDimension_index_Entity.RECORD_DATE.ToString("dd/MM/yyyy"));
                            List_Point_Entity.Add(oDimension_index_Entity.VALUE);

                        }

                        #endregion

                        #region Add Dimension_index to List_Entity_Kpi_Data

                        oEntity_Data_point.LIST_DATASET.Add(new Dataset() { LABEL = oEntity.NAME, LIST_POINT = List_Point_Entity, DATA_LEVEL_SETUP_ID = Entity_Setup_ID });

                        _Entity_Kpi_Dialog_Data.LIST_KPI_DATA.Add(oEntity_Data_point);

                        #endregion
                    }

                    oList_Entity_Kpi_Dialog_Data.Add(_Entity_Kpi_Dialog_Data);

                    #endregion
                }

                #endregion

                #region Get Organization_Data_Source_Kpi

                #region Declaration & Initialization

                List<Organization_data_source_kpi> oList_Entity_Organization_data_source_kpi = new List<Organization_data_source_kpi>();

                #endregion

                #region Get Organization_Data_Source_Kpi

                if (i_Params_Get_Entity_Kpi_Dialog_Data.LIST_ENTITY_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID != null && i_Params_Get_Entity_Kpi_Dialog_Data.LIST_ENTITY_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID.Count > 0)
                {
                    oList_Entity_Organization_data_source_kpi = Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv(new Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List()
                    {
                        ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = i_Params_Get_Entity_Kpi_Dialog_Data.LIST_ENTITY_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID
                    });
                    if (i_Params_Get_Entity_Kpi_Dialog_Data.DIMENSION_ID != null && oList_Entity_Organization_data_source_kpi != null && oList_Entity_Organization_data_source_kpi.Count > 0)
                    {
                        oList_Entity_Organization_data_source_kpi.RemoveAll(oEntity_Organization_data_source_kpi => i_Params_Get_Entity_Kpi_Dialog_Data.DIMENSION_ID != oEntity_Organization_data_source_kpi.Kpi.DIMENSION_ID);
                    }
                }

                #endregion

                #endregion

                #region Group Organization_Data_Source_Kpi

                #region Declaration & Initialization

                List<int?> oList_Entity_Trendline_Organization_data_source_kpi_ID = new List<int?>();
                List<int?> oList_Entity_Not_Trendline_Organization_data_source_kpi_ID = new List<int?>();


                #endregion

                #region Organization_Data_Source_Kpi

                if (oList_Entity_Organization_data_source_kpi != null && oList_Entity_Organization_data_source_kpi.Count > 0)
                {
                    foreach (Organization_data_source_kpi oOrganization_data_source_kpi in oList_Entity_Organization_data_source_kpi)
                    {
                        if (oOrganization_data_source_kpi.Kpi.KPI_TYPE_SETUP_ID == Trendline_Setup_ID)
                        {
                            oList_Entity_Trendline_Organization_data_source_kpi_ID.Add(oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID);
                        }
                        else if (oOrganization_data_source_kpi.Kpi.KPI_TYPE_SETUP_ID == Not_Trendline_Setup_ID)
                        {
                            oList_Entity_Not_Trendline_Organization_data_source_kpi_ID.Add(oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID);
                        }

                    }
                }

                #endregion

                #endregion

                #region Get Kpi_Data

                #region Declaration & Initialization

                List<Entity_kpi_data> oList_Trendline_Entity_kpi_data = new List<Entity_kpi_data>();
                List<Entity_kpi_data> oList_Not_Trendline_Entity_kpi_data = new List<Entity_kpi_data>();

                #endregion

                #region Kpi_data


                var get_trendline_entity_kpi_data = Task.Run(() =>
                {
                    if (oList_Entity_Trendline_Organization_data_source_kpi_ID != null && oList_Entity_Trendline_Organization_data_source_kpi_ID.Count > 0)
                    {
                        oList_Trendline_Entity_kpi_data = Get_Entity_Kpi_Data_By_Where(new Params_Get_Entity_Kpi_Data_By_Where()
                        {
                            ENTITY_ID_LIST = new List<long?>() { oEntity.ENTITY_ID },
                            ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = oList_Entity_Trendline_Organization_data_source_kpi_ID,
                            ENUM_TIMESPAN = i_Params_Get_Entity_Kpi_Dialog_Data.ENUM_TIMESPAN,
                            START_DATE = i_Params_Get_Entity_Kpi_Dialog_Data.START_DATE,
                            END_DATE = i_Params_Get_Entity_Kpi_Dialog_Data.END_DATE
                        });
                    }
                });
                var get_not_trendline_entity_kpi_data = Task.Run(() =>
                {
                    if (oList_Entity_Not_Trendline_Organization_data_source_kpi_ID != null && oList_Entity_Not_Trendline_Organization_data_source_kpi_ID.Count > 0)
                    {
                        oList_Not_Trendline_Entity_kpi_data = Get_Entity_Kpi_Data_Aggregate_Sum(new Params_Get_Entity_Kpi_Data_Aggregate_Sum()
                        {
                            ENTITY_ID_LIST = new List<long?>() { oEntity.ENTITY_ID },
                            ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = oList_Entity_Not_Trendline_Organization_data_source_kpi_ID,
                            ENUM_TIMESPAN = i_Params_Get_Entity_Kpi_Dialog_Data.ENUM_TIMESPAN,
                            START_DATE = i_Params_Get_Entity_Kpi_Dialog_Data.START_DATE,
                            END_DATE = i_Params_Get_Entity_Kpi_Dialog_Data.END_DATE
                        });
                    }
                });

                Task.WaitAll(get_trendline_entity_kpi_data, get_not_trendline_entity_kpi_data);

                #endregion

                #endregion

                #region Fill List_Entity_Kpi_Dialog_Data

                #region Declaration & Initialization

                Entity_Kpi_Dialog_Data oEntity_Kpi_Dialog_Data;

                #endregion

                #region List_Entity_Kpi_Dialog_Data

                if (oList_Entity_Organization_data_source_kpi != null && oList_Entity_Organization_data_source_kpi.Count > 0)
                {

                    foreach (Organization_data_source_kpi oOrganization_data_source_kpi in oList_Entity_Organization_data_source_kpi)
                    {
                        oEntity_Kpi_Dialog_Data = new Entity_Kpi_Dialog_Data();
                        oEntity_Kpi_Dialog_Data.ORGANIZATION_DATA_SOURCE_KPI_ID = oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID;
                        oEntity_Kpi_Dialog_Data.KPI_ID = oOrganization_data_source_kpi.KPI_ID;
                        oEntity_Kpi_Dialog_Data.TITLE = oOrganization_data_source_kpi.Kpi.NAME + " (" + oOrganization_data_source_kpi.Kpi.UNIT + ")";


                        oEntity_Kpi_Dialog_Data.LIST_KPI_DATA = new List<Entity_Data_point>();
                        if (oOrganization_data_source_kpi.Kpi.KPI_TYPE_SETUP_ID == Trendline_Setup_ID)
                        {
                            #region Trendline

                            if (oList_Trendline_Entity_kpi_data != null & oList_Trendline_Entity_kpi_data.Count > 0)
                            {
                                List<Entity_kpi_data> oList_Entity_kpi_data = oList_Trendline_Entity_kpi_data.Where(oEntity_kpi_data => oEntity_kpi_data.ENTITY_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID == oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();

                                if (oList_Entity_kpi_data != null && oList_Entity_kpi_data.Count > 0)
                                {
                                    var Group_Entity_kpi_data = oList_Entity_kpi_data.GroupBy(oEntity_kpi_data => oEntity_kpi_data.ENTITY_METADATA.CATEGORY);
                                    foreach (var oEntity_kpi_data_Group in Group_Entity_kpi_data)
                                    {
                                        Entity_Data_point oEntity_Data_point = new Entity_Data_point();
                                        oEntity_Data_point.LIST_LABEL = new List<string>();
                                        oEntity_Data_point.LIST_DATASET = new List<Dataset>();

                                        #region Extract Categories

                                        #region Declaration & Initialization

                                        string String_SEVERITY_TYPE_SETUP_ID;
                                        string String_INCIDENT_CATEGORY_SETUP_ID;
                                        long SEVERITY_TYPE_SETUP_ID = 0;
                                        long INCIDENT_CATEGORY_SETUP_ID = 0;

                                        #endregion

                                        #region Extraction

                                        string CATEGORY = oEntity_kpi_data_Group.Key;
                                        string[] parts = CATEGORY.Split(',');
                                        var values = parts.Select(category => category.Split(':'))
                                                    .ToDictionary(category => category[0], category => category[1]);


                                        bool isExist_SEVERITY_TYPE_SETUP_ID = values.TryGetValue("Severity Type", out String_SEVERITY_TYPE_SETUP_ID);
                                        bool isExist_INCIDENT_CATEGORY_SETUP_ID = values.TryGetValue("Incident Category Type", out String_INCIDENT_CATEGORY_SETUP_ID);

                                        if (isExist_SEVERITY_TYPE_SETUP_ID)
                                        {
                                            long.TryParse(String_SEVERITY_TYPE_SETUP_ID, out SEVERITY_TYPE_SETUP_ID);
                                        }
                                        if (isExist_INCIDENT_CATEGORY_SETUP_ID)
                                        {
                                            long.TryParse(String_INCIDENT_CATEGORY_SETUP_ID, out INCIDENT_CATEGORY_SETUP_ID);
                                        }

                                        #endregion

                                        #endregion

                                        #region Assign Setup_IDs

                                        oEntity_Data_point.SEVERITY_TYPE_SETUP_ID = SEVERITY_TYPE_SETUP_ID;
                                        oEntity_Data_point.INCIDENT_CATEGORY_SETUP_ID = INCIDENT_CATEGORY_SETUP_ID;

                                        #endregion

                                        #region Fill Labels & Points

                                        List<decimal?> List_Point_Entity = new List<decimal?>();

                                        List<Entity_kpi_data> _List_Entity_kpi_data = oEntity_kpi_data_Group.Select(oEntity_kpi_data => oEntity_kpi_data).ToList();



                                        foreach (Entity_kpi_data oEntity_kpi_data in _List_Entity_kpi_data)
                                        {
                                            if (oEntity_kpi_data.VALUE_NAME != null)
                                            {
                                                if (i_Params_Get_Entity_Kpi_Dialog_Data.ENUM_TIMESPAN == Enum_Timespan.X_DAILY_COLLECTION)
                                                {
                                                    oEntity_Data_point.LIST_LABEL.Add(oEntity_kpi_data.RECORD_DATE.ToShortDateString());
                                                }
                                                else
                                                {
                                                    oEntity_Data_point.LIST_LABEL.Add(oEntity_kpi_data.VALUE_NAME);
                                                }
                                            }
                                            List_Point_Entity.Add((decimal?)oEntity_kpi_data.VALUE);
                                        }

                                        #endregion

                                        #region Add Entity_Data_point to List_Entity_Data_point

                                        oEntity_Data_point.LIST_DATASET.Add(new Dataset() { LABEL = oEntity.NAME, LIST_POINT = List_Point_Entity, DATA_LEVEL_SETUP_ID = Entity_Setup_ID });

                                        oEntity_Kpi_Dialog_Data.LIST_KPI_DATA.Add(oEntity_Data_point);

                                        #endregion
                                    }
                                }
                            }

                            #endregion
                        }
                        else if (oOrganization_data_source_kpi.Kpi.KPI_TYPE_SETUP_ID == Not_Trendline_Setup_ID)
                        {
                            #region Not Trendline

                            if (oList_Not_Trendline_Entity_kpi_data != null & oList_Not_Trendline_Entity_kpi_data.Count > 0)
                            {
                                List<Entity_kpi_data> oList_Entity_kpi_data = oList_Trendline_Entity_kpi_data.Where(oEntity_kpi_data => oEntity_kpi_data.ENTITY_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID == oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();

                                if (oList_Entity_kpi_data != null && oList_Entity_kpi_data.Count > 0)
                                {
                                    var Group_Entity_kpi_data = oList_Entity_kpi_data.GroupBy(oEntity_kpi_data => oEntity_kpi_data.ENTITY_METADATA.CATEGORY);
                                    foreach (var oEntity_kpi_data_Group in Group_Entity_kpi_data)
                                    {
                                        Entity_Data_point oEntity_Data_point = new Entity_Data_point();
                                        oEntity_Data_point.LIST_LABEL = new List<string>();
                                        oEntity_Data_point.LIST_DATASET = new List<Dataset>();

                                        #region Extract Categories

                                        #region Declaration & Initialization

                                        string String_SEVERITY_TYPE_SETUP_ID;
                                        string String_INCIDENT_CATEGORY_SETUP_ID;
                                        long SEVERITY_TYPE_SETUP_ID = 0;
                                        long INCIDENT_CATEGORY_SETUP_ID = 0;

                                        #endregion

                                        #region Extraction

                                        string CATEGORY = oEntity_kpi_data_Group.Key;
                                        string[] parts = CATEGORY.Split(',');
                                        var values = parts.Select(category => category.Split(':'))
                                                    .ToDictionary(category => category[0], category => category[1]);


                                        bool isExist_SEVERITY_TYPE_SETUP_ID = values.TryGetValue("Severity Type", out String_SEVERITY_TYPE_SETUP_ID);
                                        bool isExist_INCIDENT_CATEGORY_SETUP_ID = values.TryGetValue("Incident Category Type", out String_INCIDENT_CATEGORY_SETUP_ID);

                                        if (isExist_SEVERITY_TYPE_SETUP_ID)
                                        {
                                            long.TryParse(String_SEVERITY_TYPE_SETUP_ID, out SEVERITY_TYPE_SETUP_ID);
                                        }
                                        if (isExist_INCIDENT_CATEGORY_SETUP_ID)
                                        {
                                            long.TryParse(String_INCIDENT_CATEGORY_SETUP_ID, out INCIDENT_CATEGORY_SETUP_ID);
                                        }

                                        #endregion

                                        #endregion

                                        #region Assign Setup_IDs

                                        oEntity_Data_point.SEVERITY_TYPE_SETUP_ID = SEVERITY_TYPE_SETUP_ID;
                                        oEntity_Data_point.INCIDENT_CATEGORY_SETUP_ID = INCIDENT_CATEGORY_SETUP_ID;

                                        #endregion

                                        #region Fill Labels & Points

                                        List<decimal?> List_Point_Entity = new List<decimal?>();

                                        List<Entity_kpi_data> _List_Entity_kpi_data = oEntity_kpi_data_Group.Select(oEntity_kpi_data => oEntity_kpi_data).ToList();

                                        oEntity_Data_point.LIST_LABEL = new List<string>();

                                        foreach (Entity_kpi_data oEntity_kpi_data in _List_Entity_kpi_data)
                                        {
                                            if (oEntity_kpi_data.VALUE_NAME != null)
                                            {
                                                oEntity_Data_point.LIST_LABEL.Add(oEntity_kpi_data.VALUE_NAME);
                                            }
                                            List_Point_Entity.Add((decimal?)oEntity_kpi_data.VALUE);
                                        }

                                        #endregion

                                        #region Add Entity_Data_point to List_Entity_Data_point

                                        oEntity_Data_point.LIST_DATASET.Add(new Dataset() { LABEL = oEntity.NAME, LIST_POINT = List_Point_Entity, DATA_LEVEL_SETUP_ID = Entity_Setup_ID });

                                        oEntity_Kpi_Dialog_Data.LIST_KPI_DATA.Add(oEntity_Data_point);

                                        #endregion
                                    }
                                }
                            }

                            #endregion
                        }

                        oList_Entity_Kpi_Dialog_Data.Add(oEntity_Kpi_Dialog_Data);

                    }
                }

                #endregion

                #endregion


                return oList_Entity_Kpi_Dialog_Data;
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }
        }
        #endregion
        #region Get_Floor_Kpi_Dialog_Data
        public List<Floor_Kpi_Dialog_Data> Get_Floor_Kpi_Dialog_Data(Params_Get_Floor_Kpi_Dialog_Data i_Params_Get_Floor_Kpi_Dialog_Data)
        {
            List<Floor_Kpi_Dialog_Data> oList_Floor_Kpi_Dialog_Data = new List<Floor_Kpi_Dialog_Data>();

            if (i_Params_Get_Floor_Kpi_Dialog_Data.DIMENSION_ID != null && i_Params_Get_Floor_Kpi_Dialog_Data.ENUM_TIMESPAN != null && i_Params_Get_Floor_Kpi_Dialog_Data.START_DATE != null && i_Params_Get_Floor_Kpi_Dialog_Data.END_DATE != null)
            {

                if (i_Params_Get_Floor_Kpi_Dialog_Data.LIST_ENTITY_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID == null || i_Params_Get_Floor_Kpi_Dialog_Data.LIST_ENTITY_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID.Count == 0)
                {
                    return oList_Floor_Kpi_Dialog_Data;
                }

                #region General Data

                #region Declaration & Initialization

                long? Trendline_Setup_ID = 0;
                long? Not_Trendline_Setup_ID = 0;
                long? Floor_Setup_ID = 0;
                long? Entity_Setup_ID = 0;
                long? Site_Setup_ID = 0;
                Floor oFloor = new Floor();
                Site oSite = new Site();

                #endregion

                #region Get Setups, Floor & Site

                var get_kpi_type = Task.Run(() =>
                {
                    List<Setup> oKpi_Type_Setup = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
                    {
                        SETUP_CATEGORY_NAME = "Kpi Type",
                        OWNER_ID = this.oBLC_Initializer.Owner_ID
                    }).List_Setup;
                    foreach (Setup oSetup in oKpi_Type_Setup)
                    {
                        switch (oSetup.VALUE)
                        {
                            case "Trendline":
                                Trendline_Setup_ID = oSetup.SETUP_ID;
                                break;
                            case "Not Trendline":
                                Not_Trendline_Setup_ID = oSetup.SETUP_ID;
                                break;
                        }
                    }
                });

                var get_floor_setup = Task.Run(() =>
                {
                    List<Setup> oList_Data_Level_Setup = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
                    {
                        SETUP_CATEGORY_NAME = "Data Level",
                        OWNER_ID = this.oBLC_Initializer.Owner_ID
                    }).List_Setup;
                    if (oList_Data_Level_Setup != null && oList_Data_Level_Setup.Count > 0)
                    {
                        Floor_Setup_ID = oList_Data_Level_Setup.Find(setup => setup.VALUE == "Floor").SETUP_ID;
                        Entity_Setup_ID = oList_Data_Level_Setup.Find(setup => setup.VALUE == "Entity").SETUP_ID;
                        Site_Setup_ID = oList_Data_Level_Setup.Find(setup => setup.VALUE == "Site").SETUP_ID;
                    }
                    else
                    {
                        throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0045).Replace("%1", "Data Level")); // Data Level Setup Not Found
                    }
                });

                var get_floor = Task.Run(() =>
                {
                    oFloor = Get_Floor_By_FLOOR_ID_Adv(new Params_Get_Floor_By_FLOOR_ID()
                    {
                        FLOOR_ID = i_Params_Get_Floor_Kpi_Dialog_Data.FLOOR_ID
                    });
                });

                var get_site = Task.Run(() =>
                {
                    if (i_Params_Get_Floor_Kpi_Dialog_Data.SITE_ID != null)
                    {
                        oSite = Get_Site_By_SITE_ID(new Params_Get_Site_By_SITE_ID()
                        {
                            SITE_ID = i_Params_Get_Floor_Kpi_Dialog_Data.SITE_ID
                        });
                    }
                });

                Task.WaitAll(get_kpi_type, get_floor_setup, get_floor);

                #endregion

                #endregion

                #region Fill Dimension_index

                #region Declaration & Initialization

                List<Dimension_index> oList_Dimension_index_Floor = new List<Dimension_index>();
                List<Dimension_index> oList_Dimension_index_Entity = new List<Dimension_index>();
                List<Dimension_index> oList_Dimension_index_Site = new List<Dimension_index>();
                Dimension oDimension = new Dimension();

                #endregion

                #region Get Dimension_index List

                var get_floor_dmension_index = Task.Run(() =>
                {
                    oList_Dimension_index_Floor = Props.Copy_Prop_Values_From_Api_Response<List<Dimension_index>>(
                        this._service_mesh.Get_Dimension_index_By_Where(new Service_Mesh.Params_Get_Dimension_index_By_Where()
                        {
                            LIST_LEVEL_ID = new List<long?>() { oFloor.FLOOR_ID },
                            LEVEL_SETUP_ID = Floor_Setup_ID,
                            LIST_DIMENSION_ID = new List<int?>() { i_Params_Get_Floor_Kpi_Dialog_Data.DIMENSION_ID },
                            START_DATE = (DateTime)i_Params_Get_Floor_Kpi_Dialog_Data.START_DATE,
                            END_DATE = (DateTime)i_Params_Get_Floor_Kpi_Dialog_Data.END_DATE,
                            ENUM_TIMESPAN = (Service_Mesh.Enum_Timespan)i_Params_Get_Floor_Kpi_Dialog_Data.ENUM_TIMESPAN
                        }).i_Result
                    );
                });

                var get_entity_dmension_index = Task.Run(() =>
                {
                    oList_Dimension_index_Entity = Props.Copy_Prop_Values_From_Api_Response<List<Dimension_index>>(
                        this._service_mesh.Get_Dimension_index_By_Where(new Service_Mesh.Params_Get_Dimension_index_By_Where()
                        {
                            LIST_LEVEL_ID = new List<long?>() { oFloor.ENTITY_ID },
                            LEVEL_SETUP_ID = Entity_Setup_ID,
                            LIST_DIMENSION_ID = new List<int?>() { i_Params_Get_Floor_Kpi_Dialog_Data.DIMENSION_ID },
                            START_DATE = (DateTime)i_Params_Get_Floor_Kpi_Dialog_Data.START_DATE,
                            END_DATE = (DateTime)i_Params_Get_Floor_Kpi_Dialog_Data.END_DATE,
                            ENUM_TIMESPAN = (Service_Mesh.Enum_Timespan)i_Params_Get_Floor_Kpi_Dialog_Data.ENUM_TIMESPAN

                        }).i_Result
                    );
                });

                var get_site_dmension_index = Task.Run(() =>
                {
                    if (i_Params_Get_Floor_Kpi_Dialog_Data.SITE_ID != null)
                    {
                        oList_Dimension_index_Site = Props.Copy_Prop_Values_From_Api_Response<List<Dimension_index>>(
                        this._service_mesh.Get_Dimension_index_By_Where(new Service_Mesh.Params_Get_Dimension_index_By_Where()
                        {
                            LIST_LEVEL_ID = new List<long?>() { i_Params_Get_Floor_Kpi_Dialog_Data.SITE_ID },
                            LEVEL_SETUP_ID = Site_Setup_ID,
                            LIST_DIMENSION_ID = new List<int?>() { i_Params_Get_Floor_Kpi_Dialog_Data.DIMENSION_ID },
                            START_DATE = (DateTime)i_Params_Get_Floor_Kpi_Dialog_Data.START_DATE,
                            END_DATE = (DateTime)i_Params_Get_Floor_Kpi_Dialog_Data.END_DATE,
                            ENUM_TIMESPAN = (Service_Mesh.Enum_Timespan)i_Params_Get_Floor_Kpi_Dialog_Data.ENUM_TIMESPAN
                        }).i_Result);
                    }
                });

                var get_dimension = Task.Run(() =>
                {
                    oDimension = Props.Copy_Prop_Values_From_Api_Response<Dimension>(this._service_mesh.Get_Dimension_By_DIMENSION_ID(new Service_Mesh.Params_Get_Dimension_By_DIMENSION_ID()
                    {
                        DIMENSION_ID = i_Params_Get_Floor_Kpi_Dialog_Data.DIMENSION_ID
                    }).i_Result);
                });

                Task.WaitAll(get_floor_dmension_index, get_entity_dmension_index, get_site_dmension_index, get_dimension);

                #endregion

                #region Add Dimension Index

                Floor_Kpi_Dialog_Data _Floor_Kpi_Dialog_Data = new Floor_Kpi_Dialog_Data();
                _Floor_Kpi_Dialog_Data.TITLE = oDimension.NAME.Split(" ")[1] + " Index (%)";
                _Floor_Kpi_Dialog_Data.KPI_ID = oDimension.DIMENSION_ID;
                _Floor_Kpi_Dialog_Data.ORGANIZATION_DATA_SOURCE_KPI_ID = 0;
                _Floor_Kpi_Dialog_Data.LIST_KPI_DATA = new List<Floor_Data_point>();

                if (oList_Dimension_index_Floor != null && oList_Dimension_index_Floor.Count > 0)
                {

                    Floor_Data_point oFloor_Data_point = new Floor_Data_point();
                    oFloor_Data_point.LIST_LABEL = new List<string>();
                    oFloor_Data_point.LIST_DATASET = new List<Dataset>();

                    #region Assign Setup_IDs

                    oFloor_Data_point.SEVERITY_TYPE_SETUP_ID = 0;
                    oFloor_Data_point.INCIDENT_CATEGORY_SETUP_ID = 0;

                    #endregion

                    #region Fill Labels & Points

                    List<decimal?> List_Point_Floor = new List<decimal?>();
                    List<decimal?> List_Point_Entity = new List<decimal?>();
                    List<decimal?> List_Point_Site = new List<decimal?>();

                    foreach (Dimension_index oDimension_index_Floor in oList_Dimension_index_Floor)
                    {
                        oFloor_Data_point.LIST_LABEL.Add(oDimension_index_Floor.RECORD_DATE.ToString("dd/MM/yyyy"));
                        List_Point_Floor.Add(oDimension_index_Floor.VALUE);

                    }
                    if (oList_Dimension_index_Floor != null && oList_Dimension_index_Floor.Count > 0)
                    {
                        if (oList_Dimension_index_Entity != null && oList_Dimension_index_Entity.Count > 0)
                        {
                            List_Point_Entity = oList_Dimension_index_Entity.Select(oDimension_index => (decimal?)oDimension_index.VALUE).ToList();
                        }

                        if (oList_Dimension_index_Site != null && oList_Dimension_index_Site.Count > 0)
                        {
                            List_Point_Site = oList_Dimension_index_Site.Select(oDimension_index => (decimal?)oDimension_index.VALUE).ToList();
                        }
                    }

                    #endregion

                    #region Add Dimension_index to List_Floor_Kpi_Data

                    oFloor_Data_point.LIST_DATASET.Add(new Dataset() { LABEL = oFloor.NAME, LIST_POINT = List_Point_Floor, DATA_LEVEL_SETUP_ID = Floor_Setup_ID });
                    if (List_Point_Entity != null && List_Point_Entity.Count > 0)
                    {
                        oFloor_Data_point.LIST_DATASET.Add(new Dataset() { LABEL = oFloor.Entity.NAME, LIST_POINT = List_Point_Entity, DATA_LEVEL_SETUP_ID = Entity_Setup_ID });
                    }
                    if (List_Point_Site != null && List_Point_Site.Count > 0)
                    {
                        oFloor_Data_point.LIST_DATASET.Add(new Dataset() { LABEL = oSite.NAME, LIST_POINT = List_Point_Site, DATA_LEVEL_SETUP_ID = Site_Setup_ID });
                    }

                    _Floor_Kpi_Dialog_Data.LIST_KPI_DATA.Add(oFloor_Data_point);

                    #endregion
                }

                oList_Floor_Kpi_Dialog_Data.Add(_Floor_Kpi_Dialog_Data);

                #endregion

                #endregion

                #region Get Organization_Data_Source_Kpi

                #region Declaration & Initialization

                List<Organization_data_source_kpi> oList_Entity_Organization_data_source_kpi = new List<Organization_data_source_kpi>();

                #endregion

                #region Get Organization_Data_Source_Kpi

                if (i_Params_Get_Floor_Kpi_Dialog_Data.LIST_ENTITY_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID != null && i_Params_Get_Floor_Kpi_Dialog_Data.LIST_ENTITY_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID.Count > 0)
                {
                    oList_Entity_Organization_data_source_kpi = Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv(new Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List()
                    {
                        ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = i_Params_Get_Floor_Kpi_Dialog_Data.LIST_ENTITY_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID
                    });
                    if (i_Params_Get_Floor_Kpi_Dialog_Data.DIMENSION_ID != null && oList_Entity_Organization_data_source_kpi != null && oList_Entity_Organization_data_source_kpi.Count > 0)
                    {
                        oList_Entity_Organization_data_source_kpi.RemoveAll(oEntity_Organization_data_source_kpi => i_Params_Get_Floor_Kpi_Dialog_Data.DIMENSION_ID != oEntity_Organization_data_source_kpi.Kpi.DIMENSION_ID);
                    }
                }

                #endregion

                #endregion

                #region Group Organization_Data_Source_Kpi

                #region Declaration & Initialization

                List<int?> oList_Entity_Trendline_Organization_data_source_kpi_ID = new List<int?>();
                List<int?> oList_Entity_Not_Trendline_Organization_data_source_kpi_ID = new List<int?>();


                #endregion

                #region Organization_Data_Source_Kpi

                if (oList_Entity_Organization_data_source_kpi != null && oList_Entity_Organization_data_source_kpi.Count > 0)
                {
                    foreach (Organization_data_source_kpi oOrganization_data_source_kpi in oList_Entity_Organization_data_source_kpi)
                    {
                        if (oOrganization_data_source_kpi.Kpi.KPI_TYPE_SETUP_ID == Trendline_Setup_ID)
                        {
                            oList_Entity_Trendline_Organization_data_source_kpi_ID.Add(oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID);
                        }
                        else if (oOrganization_data_source_kpi.Kpi.KPI_TYPE_SETUP_ID == Not_Trendline_Setup_ID)
                        {
                            oList_Entity_Not_Trendline_Organization_data_source_kpi_ID.Add(oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID);
                        }

                    }
                }

                #endregion

                #endregion

                #region Get Kpi_Data

                #region Declaration & Initialization

                List<Site_kpi_data> oList_Trendline_Site_kpi_data = new List<Site_kpi_data>();
                List<Site_kpi_data> oList_Not_Trendline_Site_kpi_data = new List<Site_kpi_data>();
                List<Entity_kpi_data> oList_Trendline_Entity_kpi_data = new List<Entity_kpi_data>();
                List<Entity_kpi_data> oList_Not_Trendline_Entity_kpi_data = new List<Entity_kpi_data>();
                List<Floor_kpi_data> oList_Trendline_Floor_kpi_data = new List<Floor_kpi_data>();
                List<Floor_kpi_data> oList_Not_Trendline_Floor_kpi_data = new List<Floor_kpi_data>();

                #endregion

                #region Kpi_data

                var get_trendline_site_kpi_data = Task.Run(() =>
                {
                    if (i_Params_Get_Floor_Kpi_Dialog_Data.SITE_ID != null)
                    {
                        if (oList_Entity_Trendline_Organization_data_source_kpi_ID != null && oList_Entity_Trendline_Organization_data_source_kpi_ID.Count > 0)
                        {
                            oList_Trendline_Site_kpi_data = Get_Site_Kpi_Data_By_Where(new Params_Get_Site_Kpi_Data_By_Where()
                            {
                                SITE_ID_LIST = new List<long?>() { oFloor.Entity.SITE_ID },
                                ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = oList_Entity_Trendline_Organization_data_source_kpi_ID,
                                ENUM_TIMESPAN = i_Params_Get_Floor_Kpi_Dialog_Data.ENUM_TIMESPAN,
                                START_DATE = i_Params_Get_Floor_Kpi_Dialog_Data.START_DATE,
                                END_DATE = i_Params_Get_Floor_Kpi_Dialog_Data.END_DATE
                            });
                        }
                    }
                });
                var get_not_trendline_site_kpi_data = Task.Run(() =>
                {
                    if (i_Params_Get_Floor_Kpi_Dialog_Data.SITE_ID != null)
                    {
                        if (oList_Entity_Not_Trendline_Organization_data_source_kpi_ID != null && oList_Entity_Not_Trendline_Organization_data_source_kpi_ID.Count > 0)
                        {
                            oList_Not_Trendline_Site_kpi_data = Get_Site_Kpi_Data_Aggregate_Sum(new Params_Get_Site_Kpi_Data_Aggregate_Sum()
                            {
                                SITE_ID_LIST = new List<long?>() { oFloor.Entity.SITE_ID },
                                ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = oList_Entity_Not_Trendline_Organization_data_source_kpi_ID,
                                ENUM_TIMESPAN = i_Params_Get_Floor_Kpi_Dialog_Data.ENUM_TIMESPAN,
                                START_DATE = i_Params_Get_Floor_Kpi_Dialog_Data.START_DATE,
                                END_DATE = i_Params_Get_Floor_Kpi_Dialog_Data.END_DATE
                            });
                        }
                    }
                });
                var get_trendline_entity_kpi_data = Task.Run(() =>
                {
                    if (oList_Entity_Trendline_Organization_data_source_kpi_ID != null && oList_Entity_Trendline_Organization_data_source_kpi_ID.Count > 0)
                    {
                        oList_Trendline_Entity_kpi_data = Get_Entity_Kpi_Data_By_Where(new Params_Get_Entity_Kpi_Data_By_Where()
                        {
                            ENTITY_ID_LIST = new List<long?>() { oFloor.ENTITY_ID },
                            ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = oList_Entity_Trendline_Organization_data_source_kpi_ID,
                            ENUM_TIMESPAN = i_Params_Get_Floor_Kpi_Dialog_Data.ENUM_TIMESPAN,
                            START_DATE = i_Params_Get_Floor_Kpi_Dialog_Data.START_DATE,
                            END_DATE = i_Params_Get_Floor_Kpi_Dialog_Data.END_DATE
                        });
                    }
                });
                var get_not_trendline_entity_kpi_data = Task.Run(() =>
                {
                    if (oList_Entity_Not_Trendline_Organization_data_source_kpi_ID != null && oList_Entity_Not_Trendline_Organization_data_source_kpi_ID.Count > 0)
                    {
                        oList_Not_Trendline_Entity_kpi_data = Get_Entity_Kpi_Data_Aggregate_Sum(new Params_Get_Entity_Kpi_Data_Aggregate_Sum()
                        {
                            ENTITY_ID_LIST = new List<long?>() { oFloor.ENTITY_ID },
                            ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = oList_Entity_Not_Trendline_Organization_data_source_kpi_ID,
                            ENUM_TIMESPAN = i_Params_Get_Floor_Kpi_Dialog_Data.ENUM_TIMESPAN,
                            START_DATE = i_Params_Get_Floor_Kpi_Dialog_Data.START_DATE,
                            END_DATE = i_Params_Get_Floor_Kpi_Dialog_Data.END_DATE
                        });
                    }
                });
                var get_trendline_floor_kpi_data = Task.Run(() =>
                {
                    if (oList_Entity_Trendline_Organization_data_source_kpi_ID != null && oList_Entity_Trendline_Organization_data_source_kpi_ID.Count > 0)
                    {
                        oList_Trendline_Floor_kpi_data = Get_Floor_Kpi_Data_By_Where(new Params_Get_Floor_Kpi_Data_By_Where()
                        {
                            FLOOR_ID_LIST = new List<long?>() { i_Params_Get_Floor_Kpi_Dialog_Data.FLOOR_ID },
                            ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = oList_Entity_Trendline_Organization_data_source_kpi_ID,
                            ENUM_TIMESPAN = i_Params_Get_Floor_Kpi_Dialog_Data.ENUM_TIMESPAN,
                            START_DATE = i_Params_Get_Floor_Kpi_Dialog_Data.START_DATE,
                            END_DATE = i_Params_Get_Floor_Kpi_Dialog_Data.END_DATE
                        });
                    }
                });
                var get_not_trendline_floor_kpi_data = Task.Run(() =>
                {
                    if (oList_Entity_Not_Trendline_Organization_data_source_kpi_ID != null && oList_Entity_Not_Trendline_Organization_data_source_kpi_ID.Count > 0)
                    {
                        oList_Not_Trendline_Floor_kpi_data = Get_Floor_Kpi_Data_Aggregate_Sum(new Params_Get_Floor_Kpi_Data_Aggregate_Sum()
                        {
                            FLOOR_ID_LIST = new List<long?>() { i_Params_Get_Floor_Kpi_Dialog_Data.FLOOR_ID },
                            ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = oList_Entity_Not_Trendline_Organization_data_source_kpi_ID,
                            ENUM_TIMESPAN = i_Params_Get_Floor_Kpi_Dialog_Data.ENUM_TIMESPAN,
                            START_DATE = i_Params_Get_Floor_Kpi_Dialog_Data.START_DATE,
                            END_DATE = i_Params_Get_Floor_Kpi_Dialog_Data.END_DATE
                        });
                    }
                });

                Task.WaitAll(get_trendline_site_kpi_data, get_not_trendline_site_kpi_data,
                            get_trendline_entity_kpi_data, get_not_trendline_entity_kpi_data,
                            get_trendline_floor_kpi_data, get_not_trendline_floor_kpi_data);

                #endregion

                #endregion

                #region Fill List_Floor_Kpi_Dialog_Data

                #region Declaration & Initialization

                Floor_Kpi_Dialog_Data oFloor_Kpi_Dialog_Data;

                #endregion

                #region List_Floor_Kpi_Dialog_Data

                if (oList_Entity_Organization_data_source_kpi != null && oList_Entity_Organization_data_source_kpi.Count > 0)
                {

                    foreach (Organization_data_source_kpi oOrganization_data_source_kpi in oList_Entity_Organization_data_source_kpi)
                    {
                        oFloor_Kpi_Dialog_Data = new Floor_Kpi_Dialog_Data();
                        oFloor_Kpi_Dialog_Data.ORGANIZATION_DATA_SOURCE_KPI_ID = oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID;
                        oFloor_Kpi_Dialog_Data.KPI_ID = oOrganization_data_source_kpi.KPI_ID;
                        oFloor_Kpi_Dialog_Data.TITLE = oOrganization_data_source_kpi.Kpi.NAME + " (" + oOrganization_data_source_kpi.Kpi.UNIT + ")";


                        oFloor_Kpi_Dialog_Data.LIST_KPI_DATA = new List<Floor_Data_point>();
                        if (oOrganization_data_source_kpi.Kpi.KPI_TYPE_SETUP_ID == Trendline_Setup_ID)
                        {
                            #region Trendline

                            if (oList_Trendline_Floor_kpi_data != null & oList_Trendline_Floor_kpi_data.Count > 0)
                            {
                                List<Floor_kpi_data> oList_Floor_kpi_data = oList_Trendline_Floor_kpi_data.Where(oFloor_kpi_data => oFloor_kpi_data.FLOOR_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID == oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();
                                List<Entity_kpi_data> oList_Entity_kpi_data = oList_Trendline_Entity_kpi_data.Where(oEntity_kpi_data => oEntity_kpi_data.ENTITY_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID == oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();
                                List<Site_kpi_data> oList_Site_kpi_data = new List<Site_kpi_data>();
                                if (oList_Trendline_Site_kpi_data != null && oList_Trendline_Site_kpi_data.Count > 0)
                                {
                                    oList_Site_kpi_data = oList_Trendline_Site_kpi_data.Where(oSite_kpi_data => oSite_kpi_data.SITE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID == oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();
                                }

                                if (oList_Floor_kpi_data != null && oList_Floor_kpi_data.Count > 0)
                                {
                                    var Group_Floor_kpi_data = oList_Floor_kpi_data.GroupBy(oFloor_kpi_data => oFloor_kpi_data.FLOOR_METADATA.CATEGORY);
                                    foreach (var oFloor_kpi_data_Group in Group_Floor_kpi_data)
                                    {
                                        Floor_Data_point oFloor_Data_point = new Floor_Data_point();
                                        oFloor_Data_point.LIST_LABEL = new List<string>();
                                        oFloor_Data_point.LIST_DATASET = new List<Dataset>();

                                        #region Extract Categories

                                        #region Declaration & Initialization

                                        string String_SEVERITY_TYPE_SETUP_ID;
                                        string String_INCIDENT_CATEGORY_SETUP_ID;
                                        long SEVERITY_TYPE_SETUP_ID = 0;
                                        long INCIDENT_CATEGORY_SETUP_ID = 0;

                                        #endregion

                                        #region Extraction

                                        string CATEGORY = oFloor_kpi_data_Group.Key;
                                        string[] parts = CATEGORY.Split(',');
                                        var values = parts.Select(category => category.Split(':'))
                                                    .ToDictionary(category => category[0], category => category[1]);


                                        bool isExist_SEVERITY_TYPE_SETUP_ID = values.TryGetValue("Severity Type", out String_SEVERITY_TYPE_SETUP_ID);
                                        bool isExist_INCIDENT_CATEGORY_SETUP_ID = values.TryGetValue("Incident Category Type", out String_INCIDENT_CATEGORY_SETUP_ID);

                                        if (isExist_SEVERITY_TYPE_SETUP_ID)
                                        {
                                            long.TryParse(String_SEVERITY_TYPE_SETUP_ID, out SEVERITY_TYPE_SETUP_ID);
                                        }
                                        if (isExist_INCIDENT_CATEGORY_SETUP_ID)
                                        {
                                            long.TryParse(String_INCIDENT_CATEGORY_SETUP_ID, out INCIDENT_CATEGORY_SETUP_ID);
                                        }

                                        #endregion

                                        #endregion

                                        #region Assign Setup_IDs

                                        oFloor_Data_point.SEVERITY_TYPE_SETUP_ID = SEVERITY_TYPE_SETUP_ID;
                                        oFloor_Data_point.INCIDENT_CATEGORY_SETUP_ID = INCIDENT_CATEGORY_SETUP_ID;

                                        #endregion

                                        #region Fill Labels & Points

                                        List<decimal?> List_Point_Floor = new List<decimal?>();
                                        List<decimal?> List_Point_Entity = new List<decimal?>();
                                        List<decimal?> List_Point_Site = new List<decimal?>();

                                        List<Floor_kpi_data> _List_Floor_kpi_data = oFloor_kpi_data_Group.Select(oFloor_kpi_data => oFloor_kpi_data).ToList();



                                        foreach (Floor_kpi_data oFloor_kpi_data in _List_Floor_kpi_data)
                                        {
                                            if (oFloor_kpi_data.VALUE_NAME != null)
                                            {
                                                if (i_Params_Get_Floor_Kpi_Dialog_Data.ENUM_TIMESPAN == Enum_Timespan.X_DAILY_COLLECTION)
                                                {
                                                    oFloor_Data_point.LIST_LABEL.Add(oFloor_kpi_data.RECORD_DATE.ToShortDateString());
                                                }
                                                else
                                                {
                                                    oFloor_Data_point.LIST_LABEL.Add(oFloor_kpi_data.VALUE_NAME);
                                                }
                                            }
                                            List_Point_Floor.Add((decimal?)oFloor_kpi_data.VALUE);

                                            if (oList_Entity_kpi_data != null && oList_Entity_kpi_data.Count > 0)
                                            {
                                                Entity_kpi_data oEntity_kpi_data = oList_Entity_kpi_data.Find(oEntity_kpi_data => oEntity_kpi_data.VALUE_NAME == oFloor_kpi_data.VALUE_NAME && oEntity_kpi_data.ENTITY_METADATA.CATEGORY == oFloor_kpi_data.FLOOR_METADATA.CATEGORY);
                                                decimal? point = null;
                                                if (oEntity_kpi_data != null)
                                                {
                                                    point = oEntity_kpi_data.VALUE;
                                                }
                                                List_Point_Entity.Add(point);
                                            }

                                            if (oList_Site_kpi_data != null && oList_Site_kpi_data.Count > 0)
                                            {
                                                Site_kpi_data oSite_kpi_data = oList_Site_kpi_data.Find(oSite_kpi_data => oSite_kpi_data.VALUE_NAME == oFloor_kpi_data.VALUE_NAME && oSite_kpi_data.SITE_METADATA.CATEGORY == oFloor_kpi_data.FLOOR_METADATA.CATEGORY);
                                                decimal? point = null;
                                                if (oSite_kpi_data != null)
                                                {
                                                    point = oSite_kpi_data.VALUE;
                                                }
                                                List_Point_Site.Add(point);
                                            }
                                        }

                                        #endregion

                                        #region Add Floor_Data_point to List_Floor_Data_point

                                        oFloor_Data_point.LIST_DATASET.Add(new Dataset() { LABEL = oFloor.NAME, LIST_POINT = List_Point_Floor, DATA_LEVEL_SETUP_ID = Floor_Setup_ID });
                                        if (List_Point_Entity != null && List_Point_Entity.Count > 0)
                                        {
                                            oFloor_Data_point.LIST_DATASET.Add(new Dataset() { LABEL = oFloor.Entity.NAME, LIST_POINT = List_Point_Entity, DATA_LEVEL_SETUP_ID = Entity_Setup_ID });
                                        }
                                        if (List_Point_Site != null && List_Point_Site.Count > 0)
                                        {
                                            oFloor_Data_point.LIST_DATASET.Add(new Dataset() { LABEL = oSite.NAME, LIST_POINT = List_Point_Site, DATA_LEVEL_SETUP_ID = Site_Setup_ID });
                                        }

                                        oFloor_Kpi_Dialog_Data.LIST_KPI_DATA.Add(oFloor_Data_point);

                                        #endregion
                                    }
                                }
                            }

                            #endregion
                        }
                        else if (oOrganization_data_source_kpi.Kpi.KPI_TYPE_SETUP_ID == Not_Trendline_Setup_ID)
                        {
                            #region Not Trendline

                            if (oList_Not_Trendline_Floor_kpi_data != null & oList_Not_Trendline_Floor_kpi_data.Count > 0)
                            {
                                List<Floor_kpi_data> oList_Floor_kpi_data = oList_Trendline_Floor_kpi_data.Where(oFloor_kpi_data => oFloor_kpi_data.FLOOR_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID == oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();
                                List<Entity_kpi_data> oList_Entity_kpi_data = oList_Trendline_Entity_kpi_data.Where(oEntity_kpi_data => oEntity_kpi_data.ENTITY_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID == oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();
                                List<Site_kpi_data> oList_Site_kpi_data = new List<Site_kpi_data>();
                                if (oList_Trendline_Site_kpi_data != null && oList_Trendline_Site_kpi_data.Count > 0)
                                {
                                    oList_Site_kpi_data = oList_Trendline_Site_kpi_data.Where(oSite_kpi_data => oSite_kpi_data.SITE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID == oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();
                                }

                                if (oList_Floor_kpi_data != null && oList_Floor_kpi_data.Count > 0)
                                {
                                    var Group_Floor_kpi_data = oList_Floor_kpi_data.GroupBy(oFloor_kpi_data => oFloor_kpi_data.FLOOR_METADATA.CATEGORY);
                                    foreach (var oFloor_kpi_data_Group in Group_Floor_kpi_data)
                                    {
                                        Floor_Data_point oFloor_Data_point = new Floor_Data_point();
                                        oFloor_Data_point.LIST_LABEL = new List<string>();
                                        oFloor_Data_point.LIST_DATASET = new List<Dataset>();

                                        #region Extract Categories

                                        #region Declaration & Initialization

                                        string String_SEVERITY_TYPE_SETUP_ID;
                                        string String_INCIDENT_CATEGORY_SETUP_ID;
                                        long SEVERITY_TYPE_SETUP_ID = 0;
                                        long INCIDENT_CATEGORY_SETUP_ID = 0;

                                        #endregion

                                        #region Extraction

                                        string CATEGORY = oFloor_kpi_data_Group.Key;
                                        string[] parts = CATEGORY.Split(',');
                                        var values = parts.Select(category => category.Split(':'))
                                                    .ToDictionary(category => category[0], category => category[1]);


                                        bool isExist_SEVERITY_TYPE_SETUP_ID = values.TryGetValue("Severity Type", out String_SEVERITY_TYPE_SETUP_ID);
                                        bool isExist_INCIDENT_CATEGORY_SETUP_ID = values.TryGetValue("Incident Category Type", out String_INCIDENT_CATEGORY_SETUP_ID);

                                        if (isExist_SEVERITY_TYPE_SETUP_ID)
                                        {
                                            long.TryParse(String_SEVERITY_TYPE_SETUP_ID, out SEVERITY_TYPE_SETUP_ID);
                                        }
                                        if (isExist_INCIDENT_CATEGORY_SETUP_ID)
                                        {
                                            long.TryParse(String_INCIDENT_CATEGORY_SETUP_ID, out INCIDENT_CATEGORY_SETUP_ID);
                                        }

                                        #endregion

                                        #endregion

                                        #region Assign Setup_IDs

                                        oFloor_Data_point.SEVERITY_TYPE_SETUP_ID = SEVERITY_TYPE_SETUP_ID;
                                        oFloor_Data_point.INCIDENT_CATEGORY_SETUP_ID = INCIDENT_CATEGORY_SETUP_ID;

                                        #endregion

                                        #region Fill Labels & Points

                                        List<decimal?> List_Point_Floor = new List<decimal?>();
                                        List<decimal?> List_Point_Entity = new List<decimal?>();
                                        List<decimal?> List_Point_Site = new List<decimal?>();

                                        List<Floor_kpi_data> _List_Floor_kpi_data = oFloor_kpi_data_Group.Select(oFloor_kpi_data => oFloor_kpi_data).ToList();

                                        oFloor_Data_point.LIST_LABEL = new List<string>();

                                        foreach (Floor_kpi_data oFloor_kpi_data in _List_Floor_kpi_data)
                                        {
                                            if (oFloor_kpi_data.VALUE_NAME != null)
                                            {
                                                oFloor_Data_point.LIST_LABEL.Add(oFloor_kpi_data.VALUE_NAME);
                                            }
                                            List_Point_Floor.Add((decimal?)oFloor_kpi_data.VALUE);

                                            if (oList_Entity_kpi_data != null && oList_Entity_kpi_data.Count > 0)
                                            {
                                                Entity_kpi_data oEntity_kpi_data = oList_Entity_kpi_data.Find(oEntity_kpi_data => oEntity_kpi_data.VALUE_NAME == oFloor_kpi_data.VALUE_NAME && oEntity_kpi_data.ENTITY_METADATA.CATEGORY == oFloor_kpi_data.FLOOR_METADATA.CATEGORY);
                                                decimal? point = null;
                                                if (oEntity_kpi_data != null)
                                                {
                                                    point = oEntity_kpi_data.VALUE;
                                                }
                                                List_Point_Entity.Add(point);
                                            }

                                            if (oList_Site_kpi_data != null && oList_Site_kpi_data.Count > 0)
                                            {
                                                Site_kpi_data oSite_kpi_data = oList_Site_kpi_data.Find(oSite_kpi_data => oSite_kpi_data.VALUE_NAME == oFloor_kpi_data.VALUE_NAME && oSite_kpi_data.SITE_METADATA.CATEGORY == oFloor_kpi_data.FLOOR_METADATA.CATEGORY);
                                                decimal? point = null;
                                                if (oSite_kpi_data != null)
                                                {
                                                    point = oSite_kpi_data.VALUE;
                                                }
                                                List_Point_Site.Add(point);
                                            }
                                        }

                                        #endregion

                                        #region Add Floor_Data_point to List_Floor_Data_point

                                        oFloor_Data_point.LIST_DATASET.Add(new Dataset() { LABEL = oFloor.NAME, LIST_POINT = List_Point_Floor, DATA_LEVEL_SETUP_ID = Floor_Setup_ID });
                                        if (List_Point_Entity != null && List_Point_Entity.Count > 0)
                                        {
                                            oFloor_Data_point.LIST_DATASET.Add(new Dataset() { LABEL = oFloor.Entity.NAME, LIST_POINT = List_Point_Entity, DATA_LEVEL_SETUP_ID = Entity_Setup_ID });
                                        }
                                        if (List_Point_Site != null && List_Point_Site.Count > 0)
                                        {
                                            oFloor_Data_point.LIST_DATASET.Add(new Dataset() { LABEL = oFloor.Entity.Site.NAME, LIST_POINT = List_Point_Site, DATA_LEVEL_SETUP_ID = Site_Setup_ID });
                                        }

                                        oFloor_Kpi_Dialog_Data.LIST_KPI_DATA.Add(oFloor_Data_point);

                                        #endregion
                                    }
                                }
                            }

                            #endregion
                        }

                        oList_Floor_Kpi_Dialog_Data.Add(oFloor_Kpi_Dialog_Data);

                    }
                }

                #endregion

                #endregion

                var get_wifi_signals = Task.Run(() =>
                {
                    oList_Floor_Kpi_Dialog_Data[0].WIFI_SIGNAL_LIST = Get_Latest_Wifi_signals(new Params_Get_Latest_Wifi_signals()
                    {
                        FLOOR_ID = i_Params_Get_Floor_Kpi_Dialog_Data.FLOOR_ID,
                        NUMBER_OF_POINTS = 7,
                    });
                    if (oList_Floor_Kpi_Dialog_Data[0].WIFI_SIGNAL_LIST == null)
                    {
                        oList_Floor_Kpi_Dialog_Data[0].WIFI_SIGNAL_LIST = new List<Wifi_signal>();
                    }
                });
                var get_wifi_signal_alerts = Task.Run(() =>
                {
                    oList_Floor_Kpi_Dialog_Data[0].WIFI_SIGNAL_ALERT_LIST = Get_Latest_Wifi_signal_alerts(new Params_Get_Latest_Wifi_signal_alerts()
                    {
                        FLOOR_ID = i_Params_Get_Floor_Kpi_Dialog_Data.FLOOR_ID,
                        NUMBER_OF_POINTS = 1,
                    });
                    if (oList_Floor_Kpi_Dialog_Data[0].WIFI_SIGNAL_ALERT_LIST == null)
                    {
                        oList_Floor_Kpi_Dialog_Data[0].WIFI_SIGNAL_ALERT_LIST = new List<Wifi_signal_alert>();
                    }
                });
                Task.WaitAll(get_wifi_signals, get_wifi_signal_alerts);

                return oList_Floor_Kpi_Dialog_Data;
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }
        }
        #endregion
        #region Get_Intersection_Kpi_Dialog_Data
        public List<Entity_Kpi_Dialog_Data> Get_Intersection_Kpi_Dialog_Data(Params_Get_Intersection_Kpi_Dialog_Data i_Params_Get_Intersection_Kpi_Dialog_Data)
        {
            List<Entity_Kpi_Dialog_Data> oList_Entity_Kpi_Dialog_Data = new List<Entity_Kpi_Dialog_Data>();

            if (i_Params_Get_Intersection_Kpi_Dialog_Data.DIMENSION_ID != null && i_Params_Get_Intersection_Kpi_Dialog_Data.ENUM_TIMESPAN != null && i_Params_Get_Intersection_Kpi_Dialog_Data.START_DATE != null && i_Params_Get_Intersection_Kpi_Dialog_Data.END_DATE != null)
            {
                if (i_Params_Get_Intersection_Kpi_Dialog_Data.LIST_ENTITY_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID == null || i_Params_Get_Intersection_Kpi_Dialog_Data.LIST_ENTITY_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID.Count == 0)
                {
                    return oList_Entity_Kpi_Dialog_Data;
                }

                #region General Data

                #region Declaration & Initialization

                long? Trendline_Setup_ID = 0;
                long? Not_Trendline_Setup_ID = 0;
                long? Entity_Setup_ID = 0;
                long? Site_Setup_ID = 0;
                Entity oEntity = new Entity();

                #endregion

                #region Get Setups & Floor

                var get_kpi_type = Task.Run(() =>
                {
                    List<Setup> oKpi_Type_Setup = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
                    {
                        SETUP_CATEGORY_NAME = "Kpi Type",
                        OWNER_ID = this.oBLC_Initializer.Owner_ID
                    }).List_Setup;
                    foreach (Setup oSetup in oKpi_Type_Setup)
                    {
                        switch (oSetup.VALUE)
                        {
                            case "Trendline":
                                Trendline_Setup_ID = oSetup.SETUP_ID;
                                break;
                            case "Not Trendline":
                                Not_Trendline_Setup_ID = oSetup.SETUP_ID;
                                break;
                        }
                    }
                });

                var get_entity_setup = Task.Run(() =>
                {
                    List<Setup> oList_Data_Level_Setup = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
                    {
                        SETUP_CATEGORY_NAME = "Data Level",
                        OWNER_ID = this.oBLC_Initializer.Owner_ID
                    }).List_Setup;
                    if (oList_Data_Level_Setup != null && oList_Data_Level_Setup.Count > 0)
                    {
                        Entity_Setup_ID = oList_Data_Level_Setup.Find(setup => setup.VALUE == "Entity").SETUP_ID;
                        Site_Setup_ID = oList_Data_Level_Setup.Find(setup => setup.VALUE == "Site").SETUP_ID;
                    }
                    else
                    {
                        throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0045).Replace("%1", "Data Level")); // Data Level Setup Not Found
                    }
                });

                var get_entity = Task.Run(() =>
                {
                    oEntity = Get_Entity_By_ENTITY_ID_Adv(new Params_Get_Entity_By_ENTITY_ID()
                    {
                        ENTITY_ID = i_Params_Get_Intersection_Kpi_Dialog_Data.ENTITY_ID
                    });
                });

                Task.WaitAll(get_kpi_type, get_entity_setup, get_entity);

                #endregion

                #endregion

                #region Fill Dimension_index

                #region Declaration & Initialization

                List<Dimension_index> oList_Dimension_index_Entity = new List<Dimension_index>();
                List<Dimension_index> oList_Dimension_index_Site = new List<Dimension_index>();
                Dimension oDimension = new Dimension();

                #endregion

                #region Get Dimension_index List

                var get_entity_dmension_index = Task.Run(() =>
                {
                    oList_Dimension_index_Entity = Props.Copy_Prop_Values_From_Api_Response<List<Dimension_index>>(
                        this._service_mesh.Get_Dimension_index_By_Where(new Service_Mesh.Params_Get_Dimension_index_By_Where()
                        {
                            LIST_LEVEL_ID = new List<long?>() { oEntity.ENTITY_ID },
                            LEVEL_SETUP_ID = Entity_Setup_ID,
                            LIST_DIMENSION_ID = new List<int?>() { i_Params_Get_Intersection_Kpi_Dialog_Data.DIMENSION_ID },
                            START_DATE = (DateTime)i_Params_Get_Intersection_Kpi_Dialog_Data.START_DATE,
                            END_DATE = (DateTime)i_Params_Get_Intersection_Kpi_Dialog_Data.END_DATE,
                            ENUM_TIMESPAN = (Service_Mesh.Enum_Timespan)i_Params_Get_Intersection_Kpi_Dialog_Data.ENUM_TIMESPAN

                        }).i_Result
                    );
                });

                var get_site_dmension_index = Task.Run(() =>
                {
                    oList_Dimension_index_Site = Props.Copy_Prop_Values_From_Api_Response<List<Dimension_index>>(
                        this._service_mesh.Get_Dimension_index_By_Where(new Service_Mesh.Params_Get_Dimension_index_By_Where()
                        {
                            LIST_LEVEL_ID = new List<long?>() { oEntity.SITE_ID },
                            LEVEL_SETUP_ID = Site_Setup_ID,
                            LIST_DIMENSION_ID = new List<int?>() { i_Params_Get_Intersection_Kpi_Dialog_Data.DIMENSION_ID },
                            START_DATE = (DateTime)i_Params_Get_Intersection_Kpi_Dialog_Data.START_DATE,
                            END_DATE = (DateTime)i_Params_Get_Intersection_Kpi_Dialog_Data.END_DATE,
                            ENUM_TIMESPAN = (Service_Mesh.Enum_Timespan)i_Params_Get_Intersection_Kpi_Dialog_Data.ENUM_TIMESPAN
                        }).i_Result
                    );
                });

                var get_dimension = Task.Run(() =>
                {
                    oDimension = Props.Copy_Prop_Values_From_Api_Response<Dimension>(this._service_mesh.Get_Dimension_By_DIMENSION_ID(new Service_Mesh.Params_Get_Dimension_By_DIMENSION_ID()
                    {
                        DIMENSION_ID = i_Params_Get_Intersection_Kpi_Dialog_Data.DIMENSION_ID
                    }).i_Result);
                });

                Task.WaitAll(get_entity_dmension_index, get_site_dmension_index, get_dimension);

                #endregion

                #region Add Dimension Index

                Entity_Kpi_Dialog_Data _Entity_Kpi_Dialog_Data = new Entity_Kpi_Dialog_Data();
                _Entity_Kpi_Dialog_Data.TITLE = oDimension.NAME.Split(" ")[1] + " Index (%)";
                _Entity_Kpi_Dialog_Data.KPI_ID = oDimension.DIMENSION_ID;
                _Entity_Kpi_Dialog_Data.ORGANIZATION_DATA_SOURCE_KPI_ID = 0;
                _Entity_Kpi_Dialog_Data.LIST_KPI_DATA = new List<Entity_Data_point>();

                if (oList_Dimension_index_Entity != null && oList_Dimension_index_Entity.Count > 0)
                {

                    Entity_Data_point oEntity_Data_point = new Entity_Data_point();
                    oEntity_Data_point.LIST_LABEL = new List<string>();
                    oEntity_Data_point.LIST_DATASET = new List<Dataset>();

                    #region Assign Setup_IDs

                    oEntity_Data_point.SEVERITY_TYPE_SETUP_ID = 0;
                    oEntity_Data_point.INCIDENT_CATEGORY_SETUP_ID = 0;

                    #endregion

                    #region Fill Labels & Points

                    List<decimal?> List_Point_Entity = new List<decimal?>();
                    List<decimal?> List_Point_Site = new List<decimal?>();

                    foreach (Dimension_index oDimension_index_Entity in oList_Dimension_index_Entity)
                    {
                        oEntity_Data_point.LIST_LABEL.Add(oDimension_index_Entity.RECORD_DATE.ToString("dd/MM/yyyy"));
                        List_Point_Entity.Add(oDimension_index_Entity.VALUE);

                    }
                    if (oList_Dimension_index_Entity != null && oList_Dimension_index_Entity.Count > 0)
                    {
                        if (oList_Dimension_index_Site != null && oList_Dimension_index_Site.Count > 0)
                        {
                            List_Point_Site = oList_Dimension_index_Site.Select(oDimension_index => (decimal?)oDimension_index.VALUE).ToList();
                        }
                    }

                    #endregion

                    #region Add Dimension_index to List_Entity_Kpi_Data

                    oEntity_Data_point.LIST_DATASET.Add(new Dataset() { LABEL = oEntity.NAME, LIST_POINT = List_Point_Entity, DATA_LEVEL_SETUP_ID = Entity_Setup_ID });
                    if (List_Point_Site != null && List_Point_Site.Count > 0)
                    {
                        oEntity_Data_point.LIST_DATASET.Add(new Dataset() { LABEL = oEntity.Site.NAME, LIST_POINT = List_Point_Site, DATA_LEVEL_SETUP_ID = Site_Setup_ID });
                    }

                    _Entity_Kpi_Dialog_Data.LIST_KPI_DATA.Add(oEntity_Data_point);

                    #endregion
                }

                oList_Entity_Kpi_Dialog_Data.Add(_Entity_Kpi_Dialog_Data);

                #endregion

                #endregion

                #region Get Organization_Data_Source_Kpi

                #region Declaration & Initialization

                List<Organization_data_source_kpi> oList_Entity_Organization_data_source_kpi = new List<Organization_data_source_kpi>();

                #endregion

                #region Get Organization_Data_Source_Kpi

                if (i_Params_Get_Intersection_Kpi_Dialog_Data.LIST_ENTITY_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID != null && i_Params_Get_Intersection_Kpi_Dialog_Data.LIST_ENTITY_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID.Count > 0)
                {
                    oList_Entity_Organization_data_source_kpi = Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv(new Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List()
                    {
                        ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = i_Params_Get_Intersection_Kpi_Dialog_Data.LIST_ENTITY_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID
                    });
                    if (i_Params_Get_Intersection_Kpi_Dialog_Data.DIMENSION_ID != null && oList_Entity_Organization_data_source_kpi != null && oList_Entity_Organization_data_source_kpi.Count > 0)
                    {
                        oList_Entity_Organization_data_source_kpi.RemoveAll(oEntity_Organization_data_source_kpi => i_Params_Get_Intersection_Kpi_Dialog_Data.DIMENSION_ID != oEntity_Organization_data_source_kpi.Kpi.DIMENSION_ID);
                    }
                }

                #endregion

                #endregion

                #region Group Organization_Data_Source_Kpi

                #region Declaration & Initialization

                List<int?> oList_Entity_Trendline_Organization_data_source_kpi_ID = new List<int?>();
                List<int?> oList_Entity_Not_Trendline_Organization_data_source_kpi_ID = new List<int?>();

                #endregion

                #region Organization_Data_Source_Kpi

                if (oList_Entity_Organization_data_source_kpi != null && oList_Entity_Organization_data_source_kpi.Count > 0)
                {
                    foreach (Organization_data_source_kpi oOrganization_data_source_kpi in oList_Entity_Organization_data_source_kpi)
                    {
                        if (oOrganization_data_source_kpi.Kpi.KPI_TYPE_SETUP_ID == Trendline_Setup_ID)
                        {
                            oList_Entity_Trendline_Organization_data_source_kpi_ID.Add(oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID);
                        }
                        else if (oOrganization_data_source_kpi.Kpi.KPI_TYPE_SETUP_ID == Not_Trendline_Setup_ID)
                        {
                            oList_Entity_Not_Trendline_Organization_data_source_kpi_ID.Add(oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID);
                        }

                    }
                }

                #endregion

                #endregion

                #region Get Kpi_Data

                #region Declaration & Initialization

                List<Site_kpi_data> oList_Trendline_Site_kpi_data = new List<Site_kpi_data>();
                List<Site_kpi_data> oList_Not_Trendline_Site_kpi_data = new List<Site_kpi_data>();
                List<Entity_kpi_data> oList_Trendline_Entity_kpi_data = new List<Entity_kpi_data>();
                List<Entity_kpi_data> oList_Not_Trendline_Entity_kpi_data = new List<Entity_kpi_data>();

                #endregion

                #region Kpi_data

                var get_trendline_site_kpi_data = Task.Run(() =>
                {
                    if (oList_Entity_Trendline_Organization_data_source_kpi_ID != null && oList_Entity_Trendline_Organization_data_source_kpi_ID.Count > 0)
                    {
                        oList_Trendline_Site_kpi_data = Get_Site_Kpi_Data_By_Where(new Params_Get_Site_Kpi_Data_By_Where()
                        {
                            SITE_ID_LIST = new List<long?>() { oEntity.SITE_ID },
                            ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = oList_Entity_Trendline_Organization_data_source_kpi_ID,
                            ENUM_TIMESPAN = i_Params_Get_Intersection_Kpi_Dialog_Data.ENUM_TIMESPAN,
                            START_DATE = i_Params_Get_Intersection_Kpi_Dialog_Data.START_DATE,
                            END_DATE = i_Params_Get_Intersection_Kpi_Dialog_Data.END_DATE
                        });
                    }
                });
                var get_not_trendline_site_kpi_data = Task.Run(() =>
                {
                    if (oList_Entity_Not_Trendline_Organization_data_source_kpi_ID != null && oList_Entity_Not_Trendline_Organization_data_source_kpi_ID.Count > 0)
                    {
                        oList_Not_Trendline_Site_kpi_data = Get_Site_Kpi_Data_Aggregate_Sum(new Params_Get_Site_Kpi_Data_Aggregate_Sum()
                        {
                            SITE_ID_LIST = new List<long?>() { oEntity.SITE_ID },
                            ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = oList_Entity_Not_Trendline_Organization_data_source_kpi_ID,
                            ENUM_TIMESPAN = i_Params_Get_Intersection_Kpi_Dialog_Data.ENUM_TIMESPAN,
                            START_DATE = i_Params_Get_Intersection_Kpi_Dialog_Data.START_DATE,
                            END_DATE = i_Params_Get_Intersection_Kpi_Dialog_Data.END_DATE
                        });
                    }
                });
                var get_trendline_entity_kpi_data = Task.Run(() =>
                {
                    if (oList_Entity_Trendline_Organization_data_source_kpi_ID != null && oList_Entity_Trendline_Organization_data_source_kpi_ID.Count > 0)
                    {
                        oList_Trendline_Entity_kpi_data = Get_Entity_Kpi_Data_By_Where(new Params_Get_Entity_Kpi_Data_By_Where()
                        {
                            ENTITY_ID_LIST = new List<long?>() { oEntity.ENTITY_ID },
                            ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = oList_Entity_Trendline_Organization_data_source_kpi_ID,
                            ENUM_TIMESPAN = i_Params_Get_Intersection_Kpi_Dialog_Data.ENUM_TIMESPAN,
                            START_DATE = i_Params_Get_Intersection_Kpi_Dialog_Data.START_DATE,
                            END_DATE = i_Params_Get_Intersection_Kpi_Dialog_Data.END_DATE
                        });
                    }
                });
                var get_not_trendline_entity_kpi_data = Task.Run(() =>
                {
                    if (oList_Entity_Not_Trendline_Organization_data_source_kpi_ID != null && oList_Entity_Not_Trendline_Organization_data_source_kpi_ID.Count > 0)
                    {
                        oList_Not_Trendline_Entity_kpi_data = Get_Entity_Kpi_Data_Aggregate_Sum(new Params_Get_Entity_Kpi_Data_Aggregate_Sum()
                        {
                            ENTITY_ID_LIST = new List<long?>() { oEntity.ENTITY_ID },
                            ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = oList_Entity_Not_Trendline_Organization_data_source_kpi_ID,
                            ENUM_TIMESPAN = i_Params_Get_Intersection_Kpi_Dialog_Data.ENUM_TIMESPAN,
                            START_DATE = i_Params_Get_Intersection_Kpi_Dialog_Data.START_DATE,
                            END_DATE = i_Params_Get_Intersection_Kpi_Dialog_Data.END_DATE
                        });
                    }
                });

                Task.WaitAll(get_trendline_site_kpi_data, get_not_trendline_site_kpi_data,
                            get_trendline_entity_kpi_data, get_not_trendline_entity_kpi_data);

                #endregion

                #endregion

                #region Fill List_Entity_Kpi_Dialog_Data

                #region Declaration & Initialization

                Entity_Kpi_Dialog_Data oEntity_Kpi_Dialog_Data;

                #endregion

                #region List_Entity_Kpi_Dialog_Data

                if (oList_Entity_Organization_data_source_kpi != null && oList_Entity_Organization_data_source_kpi.Count > 0)
                {

                    foreach (Organization_data_source_kpi oOrganization_data_source_kpi in oList_Entity_Organization_data_source_kpi)
                    {
                        oEntity_Kpi_Dialog_Data = new Entity_Kpi_Dialog_Data();
                        oEntity_Kpi_Dialog_Data.ORGANIZATION_DATA_SOURCE_KPI_ID = oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID;
                        oEntity_Kpi_Dialog_Data.KPI_ID = oOrganization_data_source_kpi.KPI_ID;
                        oEntity_Kpi_Dialog_Data.TITLE = oOrganization_data_source_kpi.Kpi.NAME + " (" + oOrganization_data_source_kpi.Kpi.UNIT + ")";


                        oEntity_Kpi_Dialog_Data.LIST_KPI_DATA = new List<Entity_Data_point>();
                        if (oOrganization_data_source_kpi.Kpi.KPI_TYPE_SETUP_ID == Trendline_Setup_ID)
                        {
                            #region Trendline

                            if (oList_Trendline_Entity_kpi_data != null & oList_Trendline_Entity_kpi_data.Count > 0)
                            {
                                List<Entity_kpi_data> oList_Entity_kpi_data = oList_Trendline_Entity_kpi_data.Where(oEntity_kpi_data => oEntity_kpi_data.ENTITY_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID == oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();
                                List<Site_kpi_data> oList_Site_kpi_data = oList_Trendline_Site_kpi_data.Where(oSite_kpi_data => oSite_kpi_data.SITE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID == oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();

                                if (oList_Entity_kpi_data != null && oList_Entity_kpi_data.Count > 0)
                                {
                                    var Group_Entity_kpi_data = oList_Entity_kpi_data.GroupBy(oEntity_kpi_data => oEntity_kpi_data.ENTITY_METADATA.CATEGORY);
                                    foreach (var oEntity_kpi_data_Group in Group_Entity_kpi_data)
                                    {
                                        Entity_Data_point oEntity_Data_point = new Entity_Data_point();
                                        oEntity_Data_point.LIST_LABEL = new List<string>();
                                        oEntity_Data_point.LIST_DATASET = new List<Dataset>();

                                        #region Extract Categories

                                        #region Declaration & Initialization

                                        string String_SEVERITY_TYPE_SETUP_ID;
                                        string String_INCIDENT_CATEGORY_SETUP_ID;
                                        long SEVERITY_TYPE_SETUP_ID = 0;
                                        long INCIDENT_CATEGORY_SETUP_ID = 0;

                                        #endregion

                                        #region Extraction

                                        string CATEGORY = oEntity_kpi_data_Group.Key;
                                        string[] parts = CATEGORY.Split(',');
                                        var values = parts.Select(category => category.Split(':'))
                                                    .ToDictionary(category => category[0], category => category[1]);


                                        bool isExist_SEVERITY_TYPE_SETUP_ID = values.TryGetValue("Severity Type", out String_SEVERITY_TYPE_SETUP_ID);
                                        bool isExist_INCIDENT_CATEGORY_SETUP_ID = values.TryGetValue("Incident Category Type", out String_INCIDENT_CATEGORY_SETUP_ID);

                                        if (isExist_SEVERITY_TYPE_SETUP_ID)
                                        {
                                            long.TryParse(String_SEVERITY_TYPE_SETUP_ID, out SEVERITY_TYPE_SETUP_ID);
                                        }
                                        if (isExist_INCIDENT_CATEGORY_SETUP_ID)
                                        {
                                            long.TryParse(String_INCIDENT_CATEGORY_SETUP_ID, out INCIDENT_CATEGORY_SETUP_ID);
                                        }

                                        #endregion

                                        #endregion

                                        #region Assign Setup_IDs

                                        oEntity_Data_point.SEVERITY_TYPE_SETUP_ID = SEVERITY_TYPE_SETUP_ID;
                                        oEntity_Data_point.INCIDENT_CATEGORY_SETUP_ID = INCIDENT_CATEGORY_SETUP_ID;

                                        #endregion

                                        #region Fill Labels & Points

                                        List<decimal?> List_Point_Entity = new List<decimal?>();
                                        List<decimal?> List_Point_Site = new List<decimal?>();

                                        List<Entity_kpi_data> _List_Entity_kpi_data = oEntity_kpi_data_Group.Select(oEntity_kpi_data => oEntity_kpi_data).ToList();



                                        foreach (Entity_kpi_data oEntity_kpi_data in _List_Entity_kpi_data)
                                        {
                                            if (oEntity_kpi_data.VALUE_NAME != null)
                                            {
                                                if (i_Params_Get_Intersection_Kpi_Dialog_Data.ENUM_TIMESPAN == Enum_Timespan.X_DAILY_COLLECTION)
                                                {
                                                    oEntity_Data_point.LIST_LABEL.Add(oEntity_kpi_data.RECORD_DATE.ToShortDateString());
                                                }
                                                else
                                                {
                                                    oEntity_Data_point.LIST_LABEL.Add(oEntity_kpi_data.VALUE_NAME);
                                                }
                                            }
                                            List_Point_Entity.Add((decimal?)oEntity_kpi_data.VALUE);

                                            if (oList_Site_kpi_data != null && oList_Site_kpi_data.Count > 0)
                                            {
                                                Site_kpi_data oSite_kpi_data = oList_Site_kpi_data.Find(oSite_kpi_data => oSite_kpi_data.VALUE_NAME == oEntity_kpi_data.VALUE_NAME && oSite_kpi_data.SITE_METADATA.CATEGORY == oEntity_kpi_data.ENTITY_METADATA.CATEGORY);
                                                decimal? point = null;
                                                if (oSite_kpi_data != null)
                                                {
                                                    point = oSite_kpi_data.VALUE;
                                                }
                                                List_Point_Site.Add(point);
                                            }
                                        }

                                        #endregion

                                        #region Add Entity_Data_point to List_Entity_Data_point

                                        oEntity_Data_point.LIST_DATASET.Add(new Dataset() { LABEL = oEntity.NAME, LIST_POINT = List_Point_Entity, DATA_LEVEL_SETUP_ID = Entity_Setup_ID });
                                        if (List_Point_Site != null && List_Point_Site.Count > 0)
                                        {
                                            oEntity_Data_point.LIST_DATASET.Add(new Dataset() { LABEL = oEntity.Site.NAME, LIST_POINT = List_Point_Site, DATA_LEVEL_SETUP_ID = Site_Setup_ID });
                                        }

                                        oEntity_Kpi_Dialog_Data.LIST_KPI_DATA.Add(oEntity_Data_point);

                                        #endregion
                                    }
                                }
                            }

                            #endregion
                        }
                        else if (oOrganization_data_source_kpi.Kpi.KPI_TYPE_SETUP_ID == Not_Trendline_Setup_ID)
                        {
                            #region Not Trendline

                            if (oList_Not_Trendline_Entity_kpi_data != null & oList_Not_Trendline_Entity_kpi_data.Count > 0)
                            {
                                List<Entity_kpi_data> oList_Entity_kpi_data = oList_Trendline_Entity_kpi_data.Where(oEntity_kpi_data => oEntity_kpi_data.ENTITY_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID == oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();
                                List<Site_kpi_data> oList_Site_kpi_data = oList_Trendline_Site_kpi_data.Where(oSite_kpi_data => oSite_kpi_data.SITE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID == oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();

                                if (oList_Entity_kpi_data != null && oList_Entity_kpi_data.Count > 0)
                                {
                                    var Group_Entity_kpi_data = oList_Entity_kpi_data.GroupBy(oEntity_kpi_data => oEntity_kpi_data.ENTITY_METADATA.CATEGORY);
                                    foreach (var oEntity_kpi_data_Group in Group_Entity_kpi_data)
                                    {
                                        Entity_Data_point oEntity_Data_point = new Entity_Data_point();
                                        oEntity_Data_point.LIST_LABEL = new List<string>();
                                        oEntity_Data_point.LIST_DATASET = new List<Dataset>();

                                        #region Extract Categories

                                        #region Declaration & Initialization

                                        string String_SEVERITY_TYPE_SETUP_ID;
                                        string String_INCIDENT_CATEGORY_SETUP_ID;
                                        long SEVERITY_TYPE_SETUP_ID = 0;
                                        long INCIDENT_CATEGORY_SETUP_ID = 0;

                                        #endregion

                                        #region Extraction

                                        string CATEGORY = oEntity_kpi_data_Group.Key;
                                        string[] parts = CATEGORY.Split(',');
                                        var values = parts.Select(category => category.Split(':'))
                                                    .ToDictionary(category => category[0], category => category[1]);


                                        bool isExist_SEVERITY_TYPE_SETUP_ID = values.TryGetValue("Severity Type", out String_SEVERITY_TYPE_SETUP_ID);
                                        bool isExist_INCIDENT_CATEGORY_SETUP_ID = values.TryGetValue("Incident Category Type", out String_INCIDENT_CATEGORY_SETUP_ID);

                                        if (isExist_SEVERITY_TYPE_SETUP_ID)
                                        {
                                            long.TryParse(String_SEVERITY_TYPE_SETUP_ID, out SEVERITY_TYPE_SETUP_ID);
                                        }
                                        if (isExist_INCIDENT_CATEGORY_SETUP_ID)
                                        {
                                            long.TryParse(String_INCIDENT_CATEGORY_SETUP_ID, out INCIDENT_CATEGORY_SETUP_ID);
                                        }

                                        #endregion

                                        #endregion

                                        #region Assign Setup_IDs

                                        oEntity_Data_point.SEVERITY_TYPE_SETUP_ID = SEVERITY_TYPE_SETUP_ID;
                                        oEntity_Data_point.INCIDENT_CATEGORY_SETUP_ID = INCIDENT_CATEGORY_SETUP_ID;

                                        #endregion

                                        #region Fill Labels & Points

                                        List<decimal?> List_Point_Entity = new List<decimal?>();
                                        List<decimal?> List_Point_Site = new List<decimal?>();

                                        List<Entity_kpi_data> _List_Entity_kpi_data = oEntity_kpi_data_Group.Select(oEntity_kpi_data => oEntity_kpi_data).ToList();

                                        oEntity_Data_point.LIST_LABEL = new List<string>();

                                        foreach (Entity_kpi_data oEntity_kpi_data in _List_Entity_kpi_data)
                                        {
                                            if (oEntity_kpi_data.VALUE_NAME != null)
                                            {
                                                oEntity_Data_point.LIST_LABEL.Add(oEntity_kpi_data.VALUE_NAME);
                                            }
                                            List_Point_Entity.Add((decimal?)oEntity_kpi_data.VALUE);

                                            if (oList_Site_kpi_data != null && oList_Site_kpi_data.Count > 0)
                                            {
                                                Site_kpi_data oSite_kpi_data = oList_Site_kpi_data.Find(oSite_kpi_data => oSite_kpi_data.VALUE_NAME == oEntity_kpi_data.VALUE_NAME && oSite_kpi_data.SITE_METADATA.CATEGORY == oEntity_kpi_data.ENTITY_METADATA.CATEGORY);
                                                decimal? point = null;
                                                if (oSite_kpi_data != null)
                                                {
                                                    point = oSite_kpi_data.VALUE;
                                                }
                                                List_Point_Site.Add(point);
                                            }
                                        }

                                        #endregion

                                        #region Add Entity_Data_point to List_Entity_Data_point

                                        oEntity_Data_point.LIST_DATASET.Add(new Dataset() { LABEL = oEntity.NAME, LIST_POINT = List_Point_Entity, DATA_LEVEL_SETUP_ID = Entity_Setup_ID });
                                        if (List_Point_Site != null && List_Point_Site.Count > 0)
                                        {
                                            oEntity_Data_point.LIST_DATASET.Add(new Dataset() { LABEL = oEntity.Site.NAME, LIST_POINT = List_Point_Site, DATA_LEVEL_SETUP_ID = Site_Setup_ID });
                                        }

                                        oEntity_Kpi_Dialog_Data.LIST_KPI_DATA.Add(oEntity_Data_point);

                                        #endregion
                                    }
                                }
                            }

                            #endregion
                        }

                        oList_Entity_Kpi_Dialog_Data.Add(oEntity_Kpi_Dialog_Data);

                    }
                }

                #endregion

                #endregion


                return oList_Entity_Kpi_Dialog_Data;
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }
        }
        #endregion

        #region Get_Bylaw_Complaint_List
        public List<Bylaw_Complaint> Get_Bylaw_Complaint_List(Params_Get_Bylaw_Complaint_List i_Params_Get_Bylaw_Complaint_List)
        {
            List<Bylaw_Complaint> oList_Bylaw_Complaint = new List<Bylaw_Complaint>();

            if (i_Params_Get_Bylaw_Complaint_List.LIST_LEVEL_ID != null && i_Params_Get_Bylaw_Complaint_List.LIST_LEVEL_ID.Count > 0 && i_Params_Get_Bylaw_Complaint_List.LEVEL_SETUP_ID != null &&
                i_Params_Get_Bylaw_Complaint_List.ORGANIZATION_ID != null && i_Params_Get_Bylaw_Complaint_List.START_DATE != null)
            {

                List<Setup> oKpi_Type_Setup = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
                {
                    SETUP_CATEGORY_NAME = "Kpi Type",
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                }).List_Setup;
                if (oKpi_Type_Setup != null && oKpi_Type_Setup.Count > 0)
                {
                    Setup oGeodata_Setup = oKpi_Type_Setup.Find(oSetup => oSetup.VALUE == "Geo Data");
                    if (oGeodata_Setup != null)
                    {
                        List<Kpi> oList_Kpi = Get_Kpi_By_KPI_TYPE_SETUP_ID(new Params_Get_Kpi_By_KPI_TYPE_SETUP_ID() { KPI_TYPE_SETUP_ID = oGeodata_Setup.SETUP_ID });
                        if (oList_Kpi != null && oList_Kpi.Count > 0)
                        {
                            Kpi oBylaw_Complaints_Kpi = oList_Kpi.Find(oKpi => oKpi.NAME == "Bylaw Complaints");
                            if (oBylaw_Complaints_Kpi != null)
                            {
                                List<Organization_data_source_kpi> oList_Organization_data_source_kpi = Get_Organization_data_source_kpi_By_KPI_ID(new Params_Get_Organization_data_source_kpi_By_KPI_ID() { KPI_ID = oBylaw_Complaints_Kpi.KPI_ID });
                                if (oList_Organization_data_source_kpi != null && oList_Organization_data_source_kpi.Count > 0)
                                {
                                    Organization_data_source_kpi oBylaw_Complaints_Organization_data_source_kpi = oList_Organization_data_source_kpi.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_ID == i_Params_Get_Bylaw_Complaint_List.ORGANIZATION_ID);
                                    if (oBylaw_Complaints_Organization_data_source_kpi != null)
                                    {
                                        oList_Bylaw_Complaint = Get_Bylaw_Complaint_By_Where(new Params_Get_Bylaw_Complaint_By_Where()
                                        {
                                            LIST_LEVEL_ID = i_Params_Get_Bylaw_Complaint_List.LIST_LEVEL_ID,
                                            LEVEL_SETUP_ID = i_Params_Get_Bylaw_Complaint_List.LEVEL_SETUP_ID,
                                            START_DATE = i_Params_Get_Bylaw_Complaint_List.START_DATE,
                                            ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = new List<int?> { oBylaw_Complaints_Organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID }
                                        });
                                    }
                                    else
                                    {
                                        throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Bylaw Complaint")); // %1 Does not Exist
                                    }
                                }
                                else
                                {
                                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Bylaw Complaint Organization Data Source Kpi List")); // %1 Does not Exist
                                }
                            }
                            else
                            {
                                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Bylaw Complaint")); // %1 Does not Exist
                            }
                        }
                        else
                        {
                            throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Kpi List")); // %1 Does not Exist
                        }
                    }
                    else
                    {
                        throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0045).Replace("%1", "Geo Data")); // %1 Setup Not Found
                    }
                }
                else
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0045).Replace("%1", "Kpi Type Setup List")); // %1 Does not Exist
                }
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }

            return oList_Bylaw_Complaint;
        }
        #endregion
        #region Get_Business_List
        public List<Business> Get_Business_List(Params_Get_Business_List i_Params_Get_Business_List)
        {
            List<Business> oList_Business = new List<Business>();

            if (i_Params_Get_Business_List.LIST_LEVEL_ID != null && i_Params_Get_Business_List.LIST_LEVEL_ID.Count > 0 &&
                i_Params_Get_Business_List.LEVEL_SETUP_ID != null && i_Params_Get_Business_List.ORGANIZATION_ID != null)
            {

                List<Setup> oKpi_Type_Setup = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
                {
                    SETUP_CATEGORY_NAME = "Kpi Type",
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                }).List_Setup;
                if (oKpi_Type_Setup != null && oKpi_Type_Setup.Count > 0)
                {
                    Setup oGeodata_Setup = oKpi_Type_Setup.Find(oSetup => oSetup.VALUE == "Geo Data");
                    if (oGeodata_Setup != null)
                    {
                        List<Kpi> oList_Kpi = Get_Kpi_By_KPI_TYPE_SETUP_ID(new Params_Get_Kpi_By_KPI_TYPE_SETUP_ID() { KPI_TYPE_SETUP_ID = oGeodata_Setup.SETUP_ID });
                        if (oList_Kpi != null && oList_Kpi.Count > 0)
                        {
                            Kpi oBusinesss_Kpi = oList_Kpi.Find(oKpi => oKpi.NAME == "Businesses By Category");
                            if (oBusinesss_Kpi != null)
                            {
                                List<Organization_data_source_kpi> oList_Organization_data_source_kpi = Get_Organization_data_source_kpi_By_KPI_ID(new Params_Get_Organization_data_source_kpi_By_KPI_ID() { KPI_ID = oBusinesss_Kpi.KPI_ID });
                                if (oList_Organization_data_source_kpi != null && oList_Organization_data_source_kpi.Count > 0)
                                {
                                    Organization_data_source_kpi oBusinesss_Organization_data_source_kpi = oList_Organization_data_source_kpi.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_ID == i_Params_Get_Business_List.ORGANIZATION_ID);
                                    if (oBusinesss_Organization_data_source_kpi != null)
                                    {
                                        oList_Business = Get_Businesses_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID(new Params_Get_Businesses_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID()
                                        {
                                            ORGANIZATION_DATA_SOURCE_KPI_ID = oBusinesss_Organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                            LIST_LEVEL_ID = i_Params_Get_Business_List.LIST_LEVEL_ID,
                                            LEVEL_SETUP_ID = i_Params_Get_Business_List.LEVEL_SETUP_ID
                                        });
                                    }
                                }
                                else
                                {
                                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Businesses By Category Organization Data Source Kpi List")); // %1 Does not Exist
                                }
                            }
                            else
                            {
                                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Businesses By Category")); // %1 Does not Exist
                            }
                        }
                        else
                        {
                            throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Kpi List")); // %1 Does not Exist
                        }
                    }
                    else
                    {
                        throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Geo Data")); // %1 Setup Not Found
                    }
                }
                else
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Kpi Type Setup List")); // %1 Does not Exist
                }
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }

            return oList_Business;
        }
        #endregion
        #region Get_Public_Event_List
        public List<Public_Event> Get_Public_Event_List(Params_Get_Public_Event_List i_Params_Get_Public_Event_List)
        {
            List<Public_Event> oList_Public_Event = new List<Public_Event>();

            if (i_Params_Get_Public_Event_List.LIST_LEVEL_ID != null && i_Params_Get_Public_Event_List.LIST_LEVEL_ID.Count > 0 &&
                i_Params_Get_Public_Event_List.LEVEL_SETUP_ID != null && i_Params_Get_Public_Event_List.START_DATE != null)
            {

                List<Setup> oKpi_Type_Setup = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
                {
                    SETUP_CATEGORY_NAME = "Kpi Type",
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                }).List_Setup;
                if (oKpi_Type_Setup != null && oKpi_Type_Setup.Count > 0)
                {
                    Setup oGeodata_Setup = oKpi_Type_Setup.Find(oSetup => oSetup.VALUE == "Geo Data");
                    if (oGeodata_Setup != null)
                    {
                        List<Kpi> oList_Kpi = Get_Kpi_By_KPI_TYPE_SETUP_ID(new Params_Get_Kpi_By_KPI_TYPE_SETUP_ID() { KPI_TYPE_SETUP_ID = oGeodata_Setup.SETUP_ID });
                        if (oList_Kpi != null && oList_Kpi.Count > 0)
                        {
                            Kpi oPublic_Events_Kpi = oList_Kpi.Find(oKpi => oKpi.NAME == "Public Events");
                            if (oPublic_Events_Kpi != null)
                            {
                                List<Organization_data_source_kpi> oList_Organization_data_source_kpi = Get_Organization_data_source_kpi_By_KPI_ID(new Params_Get_Organization_data_source_kpi_By_KPI_ID() { KPI_ID = oPublic_Events_Kpi.KPI_ID });
                                if (oList_Organization_data_source_kpi != null && oList_Organization_data_source_kpi.Count > 0)
                                {
                                    Organization_data_source_kpi oPublic_Events_Organization_data_source_kpi = oList_Organization_data_source_kpi.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_ID == i_Params_Get_Public_Event_List.ORGANIZATION_ID);
                                    if (oPublic_Events_Organization_data_source_kpi != null)
                                    {
                                        oList_Public_Event = Get_Public_Event_By_Where(new Params_Get_Public_Event_By_Where()
                                        {
                                            LIST_LEVEL_ID = i_Params_Get_Public_Event_List.LIST_LEVEL_ID,
                                            LEVEL_SETUP_ID = i_Params_Get_Public_Event_List.LEVEL_SETUP_ID,
                                            START_DATE = i_Params_Get_Public_Event_List.START_DATE,
                                            ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = new List<int?> { oPublic_Events_Organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID }
                                        });
                                    }
                                }
                                else
                                {
                                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Public Event Organization Data Source Kpi List")); // %1 Does not Exist
                                }
                            }
                            else
                            {
                                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Public Event")); // %1 Does not Exist
                            }
                        }
                        else
                        {
                            throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Kpi List")); // %1 Does not Exist
                        }
                    }
                    else
                    {
                        throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0045).Replace("%1", "Geo Data")); // %1 Setup Not Found
                    }
                }
                else
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Kpi Type Setup List")); // %1 Does not Exist
                }
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }

            return oList_Public_Event;
        }
        #endregion

        #region Get_Visitor_Origins
        public Visitor_Origins Get_Visitor_Origins(Params_Get_Visitor_Origins i_Params_Get_Visitor_Origins)
        {
            Visitor_Origins oVisitor_Origins = new Visitor_Origins();

            if (i_Params_Get_Visitor_Origins.LEVEL_ID != null && i_Params_Get_Visitor_Origins.ORGANIZATION_ID != null && i_Params_Get_Visitor_Origins.ENUM_TIMESPAN != null &&
                i_Params_Get_Visitor_Origins.LEVEL_SETUP_ID != null && i_Params_Get_Visitor_Origins.START_DATE != null && i_Params_Get_Visitor_Origins.END_DATE != null)
            {

                #region General Data

                #region Declaration & Initialization

                long? Not_Trendline_Setup_ID = 0;
                long? Area_Setup_ID = 0;
                long? Site_Setup_ID = 0;
                Organization_data_source_kpi oVisior_Origins_Organization_data_source_kpi = new Organization_data_source_kpi();

                #endregion

                #region Get Setups

                var get_visior_origins_organization_data_source_kpi = Task.Run(() =>
                {
                    List<Setup> oKpi_Type_Setup = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
                    {
                        SETUP_CATEGORY_NAME = "Kpi Type",
                        OWNER_ID = this.oBLC_Initializer.Owner_ID
                    }).List_Setup;
                    if (oKpi_Type_Setup != null && oKpi_Type_Setup.Count > 0)
                    {
                        Not_Trendline_Setup_ID = oKpi_Type_Setup.Find(oSetup => oSetup.VALUE == "Not Trendline").SETUP_ID;

                        List<Kpi> oList_Kpi = Get_Kpi_By_KPI_TYPE_SETUP_ID(new Params_Get_Kpi_By_KPI_TYPE_SETUP_ID() { KPI_TYPE_SETUP_ID = Not_Trendline_Setup_ID });
                        Kpi oVisitor_Origins_Kpi = oList_Kpi.Find(oKpi => oKpi.NAME == "Visitor Origins");

                        List<Organization_data_source_kpi> oList_Organization_data_source_kpi = Get_Organization_data_source_kpi_By_KPI_ID(new Params_Get_Organization_data_source_kpi_By_KPI_ID() { KPI_ID = oVisitor_Origins_Kpi.KPI_ID });
                        oVisior_Origins_Organization_data_source_kpi = oList_Organization_data_source_kpi.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_ID == i_Params_Get_Visitor_Origins.ORGANIZATION_ID);
                    }
                    else
                    {
                        throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0045).Replace("%1", "Data Level")); // Data Level Setup Not Found
                    }
                });

                var get_data_level_setup = Task.Run(() =>
                {
                    List<Setup> oList_Data_Level_Setup = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
                    {
                        SETUP_CATEGORY_NAME = "Data Level",
                        OWNER_ID = this.oBLC_Initializer.Owner_ID
                    }).List_Setup;
                    if (oList_Data_Level_Setup != null && oList_Data_Level_Setup.Count > 0)
                    {
                        Area_Setup_ID = oList_Data_Level_Setup.Find(setup => setup.VALUE == "Area").SETUP_ID;
                        Site_Setup_ID = oList_Data_Level_Setup.Find(setup => setup.VALUE == "Site").SETUP_ID;
                    }
                    else
                    {
                        throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0045).Replace("%1", "Data Level")); // Data Level Setup Not Found
                    }
                });

                Task.WaitAll(get_visior_origins_organization_data_source_kpi, get_data_level_setup);

                #endregion

                #endregion

                if (i_Params_Get_Visitor_Origins.LEVEL_SETUP_ID == Site_Setup_ID)
                {
                    #region Get Visitor_Origins For Site

                    List<Site_kpi_data> oList_Site_kpi_data = Get_Site_Kpi_Data_Aggregate_Sum(new Params_Get_Site_Kpi_Data_Aggregate_Sum()
                    {
                        SITE_ID_LIST = new List<long?>() { i_Params_Get_Visitor_Origins.LEVEL_ID },
                        ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = new List<int?>() { oVisior_Origins_Organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID },
                        ENUM_TIMESPAN = i_Params_Get_Visitor_Origins.ENUM_TIMESPAN,
                        START_DATE = i_Params_Get_Visitor_Origins.START_DATE,
                        END_DATE = i_Params_Get_Visitor_Origins.END_DATE
                    });
                    List<int?> List_Ext_Study_Zone_ID = oList_Site_kpi_data.Where(oSite_kpi_data => !string.IsNullOrEmpty(oSite_kpi_data.SITE_METADATA.CATEGORY))
                                                                           .Select(oSite_kpi_data =>
                                                                           {
                                                                               string[] parts = oSite_kpi_data.SITE_METADATA.CATEGORY.Split(',');
                                                                               var values = oSite_kpi_data.SITE_METADATA.CATEGORY.Split(',')
                                                                                           .Select(category => category.Split(':'))
                                                                                           .ToDictionary(category => category[0], category => int.Parse(category[1]));
                                                                               int EXT_STUDY_ZONE_ID;
                                                                               bool isExist_EXT_STUDY_ZONE_ID = values.TryGetValue("EXT_STUDY_ZONE_ID", out EXT_STUDY_ZONE_ID);
                                                                               return (int?)EXT_STUDY_ZONE_ID;
                                                                           }).ToList();
                    var get_ext_study_zone_geojson = Task.Run(() =>
                    {
                        oVisitor_Origins.GEOJSON = Get_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID_List(new Params_Get_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID_List()
                        {
                            EXT_STUDY_ZONE_ID_LIST = List_Ext_Study_Zone_ID
                        });
                    });
                    var get_ext_study_zone = Task.Run(() =>
                    {
                        List<Ext_study_zone> oList_Ext_study_zone = Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID_List(new Params_Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID_List()
                        {
                            EXT_STUDY_ZONE_ID_LIST = List_Ext_Study_Zone_ID
                        });

                        oVisitor_Origins.LIST_EXT_STUDY_ZONE_WITH_COUNT = new List<Ext_study_zone_With_Count>();

                        foreach (Site_kpi_data oSite_kpi_data in oList_Site_kpi_data)
                        {
                            string[] parts = oSite_kpi_data.SITE_METADATA.CATEGORY.Split(',');
                            var values = oSite_kpi_data.SITE_METADATA.CATEGORY.Split(',')
                                        .Select(category => category.Split(':'))
                                        .ToDictionary(category => category[0], category => int.Parse(category[1]));
                            int EXT_STUDY_ZONE_ID;
                            bool isExist_EXT_STUDY_ZONE_ID = values.TryGetValue("EXT_STUDY_ZONE_ID", out EXT_STUDY_ZONE_ID);

                            Ext_study_zone oExt_study_zone = oList_Ext_study_zone.Find(oExt_study_zone => oExt_study_zone.EXT_STUDY_ZONE_ID == EXT_STUDY_ZONE_ID);

                            oVisitor_Origins.LIST_EXT_STUDY_ZONE_WITH_COUNT.Add(new Ext_study_zone_With_Count()
                            {
                                EXT_STUDY_ZONE = oExt_study_zone,
                                COUNT = oSite_kpi_data.VALUE
                            });
                        }
                    });
                    Task.WaitAll(get_ext_study_zone_geojson, get_ext_study_zone);

                    #endregion
                }
                else if (i_Params_Get_Visitor_Origins.LEVEL_SETUP_ID == Area_Setup_ID)
                {
                    #region Get Visitor_Origins For Area

                    List<Area_kpi_data> oList_Area_kpi_data = Get_Area_Kpi_Data_Aggregate_Sum(new Params_Get_Area_Kpi_Data_Aggregate_Sum()
                    {
                        AREA_ID_LIST = new List<long?>() { i_Params_Get_Visitor_Origins.LEVEL_ID },
                        ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = new List<int?>() { oVisior_Origins_Organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID },
                        ENUM_TIMESPAN = i_Params_Get_Visitor_Origins.ENUM_TIMESPAN,
                        START_DATE = i_Params_Get_Visitor_Origins.START_DATE,
                        END_DATE = i_Params_Get_Visitor_Origins.END_DATE
                    });
                    List<int?> List_Ext_Study_Zone_ID = oList_Area_kpi_data.Where(oArea_kpi_data => !string.IsNullOrEmpty(oArea_kpi_data.AREA_METADATA.CATEGORY))
                                                                           .Select(oArea_kpi_data =>
                                                                           {
                                                                               string[] parts = oArea_kpi_data.AREA_METADATA.CATEGORY.Split(',');
                                                                               var values = oArea_kpi_data.AREA_METADATA.CATEGORY.Split(',')
                                                                                           .Select(category => category.Split(':'))
                                                                                           .ToDictionary(category => category[0], category => int.Parse(category[1]));
                                                                               int EXT_STUDY_ZONE_ID;
                                                                               bool isExist_EXT_STUDY_ZONE_ID = values.TryGetValue("EXT_STUDY_ZONE_ID", out EXT_STUDY_ZONE_ID);
                                                                               return (int?)EXT_STUDY_ZONE_ID;
                                                                           }).ToList();
                    var get_ext_study_zone_geojson = Task.Run(() =>
                    {
                        oVisitor_Origins.GEOJSON = Get_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID_List(new Params_Get_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID_List()
                        {
                            EXT_STUDY_ZONE_ID_LIST = List_Ext_Study_Zone_ID
                        });
                    });
                    var get_ext_study_zone = Task.Run(() =>
                    {
                        List<Ext_study_zone> oList_Ext_study_zone = Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID_List(new Params_Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID_List()
                        {
                            EXT_STUDY_ZONE_ID_LIST = List_Ext_Study_Zone_ID
                        });

                        oVisitor_Origins.LIST_EXT_STUDY_ZONE_WITH_COUNT = new List<Ext_study_zone_With_Count>();

                        foreach (Area_kpi_data oArea_kpi_data in oList_Area_kpi_data)
                        {
                            string[] parts = oArea_kpi_data.AREA_METADATA.CATEGORY.Split(',');
                            var values = oArea_kpi_data.AREA_METADATA.CATEGORY.Split(',')
                                        .Select(category => category.Split(':'))
                                        .ToDictionary(category => category[0], category => int.Parse(category[1]));
                            int EXT_STUDY_ZONE_ID;
                            bool isExist_EXT_STUDY_ZONE_ID = values.TryGetValue("EXT_STUDY_ZONE_ID", out EXT_STUDY_ZONE_ID);

                            Ext_study_zone oExt_study_zone = oList_Ext_study_zone.Find(oExt_study_zone => oExt_study_zone.EXT_STUDY_ZONE_ID == EXT_STUDY_ZONE_ID);

                            oVisitor_Origins.LIST_EXT_STUDY_ZONE_WITH_COUNT.Add(new Ext_study_zone_With_Count()
                            {
                                EXT_STUDY_ZONE = oExt_study_zone,
                                COUNT = oArea_kpi_data.VALUE
                            });
                        }
                    });
                    Task.WaitAll(get_ext_study_zone_geojson, get_ext_study_zone);

                    #endregion
                }
                else
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
                }
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }
            return oVisitor_Origins;
        }
        #endregion
        #region Get_Latest_Visitor_Count_By_Where
        public List<Visitor_Count_By_Level> Get_Latest_Visitor_Count_By_Where(Params_Get_Latest_Visitor_Count_By_Where i_Params_Get_Latest_Visitor_Count_By_Where)
        {
            List<Visitor_Count_By_Level> oList_Visitor_Count_By_Level = null;

            if (i_Params_Get_Latest_Visitor_Count_By_Where.ORGANIZATION_ID != null && i_Params_Get_Latest_Visitor_Count_By_Where.ENUM_TIMESPAN != null &&
                i_Params_Get_Latest_Visitor_Count_By_Where.LEVEL_SETUP_ID != null && i_Params_Get_Latest_Visitor_Count_By_Where.LIST_LEVEL_ID != null && i_Params_Get_Latest_Visitor_Count_By_Where.LIST_LEVEL_ID.Count > 0)
            {
                #region Declaration & Initialization

                long? Area_Setup_ID = 0;
                long? Site_Setup_ID = 0;
                long? Trendline_Setup_ID = 0;
                Organization_data_source_kpi oVisior_Count_Organization_data_source_kpi = new Organization_data_source_kpi();
                #endregion

                #region Get Level_Setup

                var get_visior_count_organization_data_source_kpi = Task.Run(() =>
                {
                    List<Setup> oKpi_Type_Setup = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
                    {
                        SETUP_CATEGORY_NAME = "Kpi Type",
                        OWNER_ID = this.oBLC_Initializer.Owner_ID
                    }).List_Setup;
                    if (oKpi_Type_Setup != null && oKpi_Type_Setup.Count > 0)
                    {
                        Trendline_Setup_ID = oKpi_Type_Setup.Find(oSetup => oSetup.VALUE == "Trendline").SETUP_ID;

                        List<Kpi> oList_Kpi = Get_Kpi_By_KPI_TYPE_SETUP_ID(new Params_Get_Kpi_By_KPI_TYPE_SETUP_ID() { KPI_TYPE_SETUP_ID = Trendline_Setup_ID });
                        Kpi oVisitor_Origins_Kpi = oList_Kpi.Find(oKpi => oKpi.NAME == "Number of Visitors");

                        List<Organization_data_source_kpi> oList_Organization_data_source_kpi = Get_Organization_data_source_kpi_By_KPI_ID(new Params_Get_Organization_data_source_kpi_By_KPI_ID() { KPI_ID = oVisitor_Origins_Kpi.KPI_ID });
                        oVisior_Count_Organization_data_source_kpi = oList_Organization_data_source_kpi.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_ID == i_Params_Get_Latest_Visitor_Count_By_Where.ORGANIZATION_ID);
                    }
                    else
                    {
                        throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0045).Replace("%1", "Data Level")); // Data Level Setup Not Found
                    }
                });

                var get_data_level_setup = Task.Run(() =>
                {
                    List<Setup> oList_Data_Level_Setup = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
                    {
                        SETUP_CATEGORY_NAME = "Data Level",
                        OWNER_ID = this.oBLC_Initializer.Owner_ID
                    }).List_Setup;
                    if (oList_Data_Level_Setup != null && oList_Data_Level_Setup.Count > 0)
                    {
                        Area_Setup_ID = oList_Data_Level_Setup.FirstOrDefault(setup => setup.VALUE == "Area").SETUP_ID;
                        Site_Setup_ID = oList_Data_Level_Setup.FirstOrDefault(setup => setup.VALUE == "Site").SETUP_ID;
                    }
                    else
                    {
                        throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0045).Replace("%1", "Data Level")); // Data Level Setup Not Found
                    }
                });

                Task.WaitAll(get_visior_count_organization_data_source_kpi, get_data_level_setup);

                #endregion

                if (i_Params_Get_Latest_Visitor_Count_By_Where.LEVEL_SETUP_ID == Area_Setup_ID)
                {
                    #region Get_Visitor_Count_By_Area

                    List<DALC.Area_kpi_data> oList_DBEntry = this._MongoDb.Get_Latest_Area_Kpi_Data_By_Where
                        (
                            ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: new List<int?>() { oVisior_Count_Organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID },
                            AREA_ID_LIST: i_Params_Get_Latest_Visitor_Count_By_Where.LIST_LEVEL_ID,
                            ENUM_TIMESPAN: (DALC.Enum_Timespan)i_Params_Get_Latest_Visitor_Count_By_Where.ENUM_TIMESPAN
                        );
                    if (oList_DBEntry != null)
                    {
                        oList_Visitor_Count_By_Level = new List<Visitor_Count_By_Level>();

                        if (oList_DBEntry.Count > 0)
                        {
                            List<Area_kpi_data> oList_Area_kpi_data = Props.Copy_Prop_Values_From_Api_Response<List<Area_kpi_data>>(oList_DBEntry);

                            var Grouped_Area_kpi_data = oList_Area_kpi_data.GroupBy(oArea_kpi_data => oArea_kpi_data.AREA_METADATA.AREA_ID);

                            Visitor_Count_By_Level oVisitor_Count_By_Level;

                            foreach (var oArea_kpi_data_group in Grouped_Area_kpi_data)
                            {
                                oVisitor_Count_By_Level = new Visitor_Count_By_Level();
                                oVisitor_Count_By_Level.LEVEL_ID = oArea_kpi_data_group.Key;
                                oVisitor_Count_By_Level.VISITOR_COUNT = oArea_kpi_data_group.Select(oArea_kpi_data => oArea_kpi_data.VALUE).FirstOrDefault();

                                oList_Visitor_Count_By_Level.Add(oVisitor_Count_By_Level);
                            }
                        }
                    }

                    #endregion
                }
                else if (i_Params_Get_Latest_Visitor_Count_By_Where.LEVEL_SETUP_ID == Site_Setup_ID)
                {
                    #region Get_Visitor_Count_By_Site

                    List<DALC.Site_kpi_data> oList_DBEntry = this._MongoDb.Get_Latest_Site_Kpi_Data_By_Where
                        (
                            ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: new List<int?>() { oVisior_Count_Organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID },
                            SITE_ID_LIST: i_Params_Get_Latest_Visitor_Count_By_Where.LIST_LEVEL_ID,
                            ENUM_TIMESPAN: (DALC.Enum_Timespan)i_Params_Get_Latest_Visitor_Count_By_Where.ENUM_TIMESPAN
                        );
                    if (oList_DBEntry != null)
                    {
                        oList_Visitor_Count_By_Level = new List<Visitor_Count_By_Level>();

                        if (oList_DBEntry.Count > 0)
                        {
                            List<Site_kpi_data> oList_Site_kpi_data = Props.Copy_Prop_Values_From_Api_Response<List<Site_kpi_data>>(oList_DBEntry);

                            var Grouped_Site_kpi_data = oList_Site_kpi_data.GroupBy(oSite_kpi_data => oSite_kpi_data.SITE_METADATA.SITE_ID);

                            Visitor_Count_By_Level oVisitor_Count_By_Level;

                            foreach (var oSite_kpi_data_group in Grouped_Site_kpi_data)
                            {
                                oVisitor_Count_By_Level = new Visitor_Count_By_Level();
                                oVisitor_Count_By_Level.LEVEL_ID = oSite_kpi_data_group.Key;
                                oVisitor_Count_By_Level.VISITOR_COUNT = oSite_kpi_data_group.Select(oSite_kpi_data => oSite_kpi_data.VALUE).FirstOrDefault();

                                oList_Visitor_Count_By_Level.Add(oVisitor_Count_By_Level);
                            }
                        }
                    }

                    #endregion
                }
                else
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
                }
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }

            return oList_Visitor_Count_By_Level;
        }
        #endregion
        #region Get_Latest_Organization_data_source_kpi_By_Where
        public List<Organization_data_source_kpi_By_Level> Get_Latest_Organization_data_source_kpi_By_Where(Params_Get_Latest_Organization_data_source_kpi_By_Where i_Params_Get_Latest_Organization_data_source_kpi_By_Where)
        {
            List<Organization_data_source_kpi_By_Level> oList_Organization_data_source_kpi_By_Level = null;

            if (i_Params_Get_Latest_Organization_data_source_kpi_By_Where.ORGANIZATION_DATA_SOURCE_KPI_ID != null && i_Params_Get_Latest_Organization_data_source_kpi_By_Where.ENUM_TIMESPAN != null &&
                i_Params_Get_Latest_Organization_data_source_kpi_By_Where.LEVEL_SETUP_ID != null && i_Params_Get_Latest_Organization_data_source_kpi_By_Where.LIST_LEVEL_ID != null && i_Params_Get_Latest_Organization_data_source_kpi_By_Where.LIST_LEVEL_ID.Count > 0)
            {
                #region Declaration & Initialization

                long? Area_Setup_ID = 0;
                long? Site_Setup_ID = 0;
                Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();

                #endregion

                #region Get Level_Setup & Organization_data_source_kpi

                var get_organization_data_source_kpi = Task.Run(() =>
                {
                    oOrganization_data_source_kpi = Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv(new Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID()
                    {
                        ORGANIZATION_DATA_SOURCE_KPI_ID = i_Params_Get_Latest_Organization_data_source_kpi_By_Where.ORGANIZATION_DATA_SOURCE_KPI_ID
                    });
                    if (oOrganization_data_source_kpi == null)
                    {
                        throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Organization Data Source Kpi")); // Organization Data Source Kpi Does Not Exist!
                    }
                });

                var get_data_level_setup = Task.Run(() =>
                {
                    List<Setup> oList_Data_Level_Setup = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
                    {
                        SETUP_CATEGORY_NAME = "Data Level",
                        OWNER_ID = this.oBLC_Initializer.Owner_ID
                    }).List_Setup;
                    if (oList_Data_Level_Setup != null && oList_Data_Level_Setup.Count > 0)
                    {
                        Area_Setup_ID = oList_Data_Level_Setup.FirstOrDefault(setup => setup.VALUE == "Area").SETUP_ID;
                        Site_Setup_ID = oList_Data_Level_Setup.FirstOrDefault(setup => setup.VALUE == "Site").SETUP_ID;
                    }
                    else
                    {
                        throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0045).Replace("%1", "Data Level")); // Data Level Setup Not Found
                    }
                });

                Task.WaitAll(get_organization_data_source_kpi, get_data_level_setup);

                #endregion

                if (i_Params_Get_Latest_Organization_data_source_kpi_By_Where.LEVEL_SETUP_ID == Area_Setup_ID)
                {
                    #region Get_Organization_data_source_kpi_By_Area

                    List<DALC.Area_kpi_data> oList_DBEntry = this._MongoDb.Get_Latest_Area_Kpi_Data_By_Where
                        (
                            ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: new List<int?>() { oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID },
                            AREA_ID_LIST: i_Params_Get_Latest_Organization_data_source_kpi_By_Where.LIST_LEVEL_ID,
                            ENUM_TIMESPAN: (DALC.Enum_Timespan)i_Params_Get_Latest_Organization_data_source_kpi_By_Where.ENUM_TIMESPAN
                        );
                    if (oList_DBEntry != null)
                    {
                        oList_Organization_data_source_kpi_By_Level = new List<Organization_data_source_kpi_By_Level>();

                        if (oList_DBEntry.Count > 0)
                        {
                            List<Area_kpi_data> oList_Area_kpi_data = Props.Copy_Prop_Values_From_Api_Response<List<Area_kpi_data>>(oList_DBEntry);

                            var Grouped_Area_kpi_data = oList_Area_kpi_data.GroupBy(oArea_kpi_data => oArea_kpi_data.AREA_METADATA.AREA_ID);

                            Organization_data_source_kpi_By_Level oOrganization_data_source_kpi_By_Level;

                            foreach (var oArea_kpi_data_group in Grouped_Area_kpi_data)
                            {
                                oOrganization_data_source_kpi_By_Level = new Organization_data_source_kpi_By_Level();
                                oOrganization_data_source_kpi_By_Level.LEVEL_ID = oArea_kpi_data_group.Key;
                                oOrganization_data_source_kpi_By_Level.VALUE = oArea_kpi_data_group.Select(oArea_kpi_data => oArea_kpi_data.VALUE).FirstOrDefault();

                                oList_Organization_data_source_kpi_By_Level.Add(oOrganization_data_source_kpi_By_Level);
                            }
                        }
                    }

                    #endregion
                }
                else if (i_Params_Get_Latest_Organization_data_source_kpi_By_Where.LEVEL_SETUP_ID == Site_Setup_ID)
                {
                    #region Get_Organization_data_source_kpi_By_Site

                    List<DALC.Site_kpi_data> oList_DBEntry = this._MongoDb.Get_Latest_Site_Kpi_Data_By_Where
                        (
                            ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: new List<int?>() { oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID },
                            SITE_ID_LIST: i_Params_Get_Latest_Organization_data_source_kpi_By_Where.LIST_LEVEL_ID,
                            ENUM_TIMESPAN: (DALC.Enum_Timespan)i_Params_Get_Latest_Organization_data_source_kpi_By_Where.ENUM_TIMESPAN
                        );
                    if (oList_DBEntry != null)
                    {
                        oList_Organization_data_source_kpi_By_Level = new List<Organization_data_source_kpi_By_Level>();

                        if (oList_DBEntry.Count > 0)
                        {
                            List<Site_kpi_data> oList_Site_kpi_data = Props.Copy_Prop_Values_From_Api_Response<List<Site_kpi_data>>(oList_DBEntry);

                            var Grouped_Site_kpi_data = oList_Site_kpi_data.GroupBy(oSite_kpi_data => oSite_kpi_data.SITE_METADATA.SITE_ID);

                            Organization_data_source_kpi_By_Level oOrganization_data_source_kpi_By_Level;

                            foreach (var oSite_kpi_data_group in Grouped_Site_kpi_data)
                            {
                                oOrganization_data_source_kpi_By_Level = new Organization_data_source_kpi_By_Level();
                                oOrganization_data_source_kpi_By_Level.LEVEL_ID = oSite_kpi_data_group.Key;
                                oOrganization_data_source_kpi_By_Level.VALUE = oSite_kpi_data_group.Select(oSite_kpi_data => oSite_kpi_data.VALUE).FirstOrDefault();

                                oList_Organization_data_source_kpi_By_Level.Add(oOrganization_data_source_kpi_By_Level);
                            }
                        }
                    }

                    #endregion
                }
                else
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
                }
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }

            return oList_Organization_data_source_kpi_By_Level;
        }
        #endregion

        #region Get_Business_Trendline
        public List<Kpi_Value_By_Date> Get_Business_Trendline(Params_Get_Business_Trendline i_Params_Get_Business_Trendline)
        {
            List<Kpi_Value_By_Date> oList_Kpi_Value_By_Date = new List<Kpi_Value_By_Date>();

            if (i_Params_Get_Business_Trendline.ENUM_TIMESPAN != null && i_Params_Get_Business_Trendline.START_DATE != null && i_Params_Get_Business_Trendline.END_DATE != null &&
                i_Params_Get_Business_Trendline.LEVEL_SETUP_ID != null && i_Params_Get_Business_Trendline.LIST_LEVEL_ID != null & i_Params_Get_Business_Trendline.LIST_LEVEL_ID.Count > 0)
            {
                #region Get List_Business

                List<Business> oList_Business = Get_Business_List(new Params_Get_Business_List()
                {
                    LEVEL_SETUP_ID = i_Params_Get_Business_Trendline.LEVEL_SETUP_ID,
                    LIST_LEVEL_ID = i_Params_Get_Business_Trendline.LIST_LEVEL_ID,
                    ORGANIZATION_ID = i_Params_Get_Business_Trendline.ORGANIZATION_ID
                });

                #endregion

                #region Fill Data

                DateTime StartDate = i_Params_Get_Business_Trendline.START_DATE.Value;
                switch (i_Params_Get_Business_Trendline.ENUM_TIMESPAN)
                {
                    case Enum_Timespan.X_HOURLY_COLLECTION:
                        if (StartDate.Minute > 0 || StartDate.Second > 0)
                        {
                            StartDate = StartDate.AddHours(1);
                            StartDate = new DateTime(StartDate.Year, StartDate.Month, StartDate.Day, StartDate.Hour, 0, 0, DateTimeKind.Utc);
                        }
                        for (DateTime date = StartDate; date <= i_Params_Get_Business_Trendline.END_DATE.Value; date = date.AddHours(1))
                        {
                            oList_Kpi_Value_By_Date.Add(new Kpi_Value_By_Date()
                            {
                                RECORD_DATE = new DateTime(date.Year, date.Month, date.Day, date.Hour, 0, 0, DateTimeKind.Utc),
                                VALUE = oList_Business.Count
                            });
                        }
                        break;
                    case Enum_Timespan.X_DAILY_COLLECTION:
                        if (StartDate.Hour > 0 || StartDate.Minute > 0 || StartDate.Second > 0)
                        {
                            StartDate = StartDate.AddDays(1);
                            StartDate = new DateTime(StartDate.Year, StartDate.Month, StartDate.Day, 0, 0, 0, DateTimeKind.Utc);
                        }
                        for (DateTime date = StartDate; date <= i_Params_Get_Business_Trendline.END_DATE.Value.Date; date = date.AddDays(1))
                        {
                            oList_Kpi_Value_By_Date.Add(new Kpi_Value_By_Date()
                            {
                                RECORD_DATE = new DateTime(date.Year, date.Month, date.Day, date.Hour, 0, 0, DateTimeKind.Utc),
                                VALUE = oList_Business.Count
                            });
                        }
                        break;
                    case Enum_Timespan.X_WEEKLY_COLLECTION:
                        if (StartDate.Hour > 0 || StartDate.Minute > 0 || StartDate.Second > 0)
                        {
                            StartDate = new DateTime(StartDate.Year, StartDate.Month, StartDate.Day, 0, 0, 0, DateTimeKind.Utc);
                            while (StartDate.DayOfWeek != DayOfWeek.Monday)
                            {
                                StartDate = StartDate.AddDays(1);
                            }
                        }
                        for (DateTime date = StartDate; date <= i_Params_Get_Business_Trendline.END_DATE.Value.Date; date = date.AddDays(7))
                        {
                            oList_Kpi_Value_By_Date.Add(new Kpi_Value_By_Date()
                            {
                                RECORD_DATE = new DateTime(date.Year, date.Month, date.Day, date.Hour, 0, 0, DateTimeKind.Utc),
                                VALUE = oList_Business.Count
                            });
                        }
                        break;
                    case Enum_Timespan.X_MONTHLY_COLLECTION:
                        if (StartDate.Day > 1 || StartDate.Hour > 0 || StartDate.Minute > 0 || StartDate.Second > 0)
                        {
                            StartDate = StartDate.AddMonths(1);
                            StartDate = new DateTime(StartDate.Year, StartDate.Month, 1, 0, 0, 0, DateTimeKind.Utc);
                        }
                        for (DateTime date = StartDate; date <= i_Params_Get_Business_Trendline.END_DATE.Value.Date; date = date.AddMonths(1))
                        {
                            oList_Kpi_Value_By_Date.Add(new Kpi_Value_By_Date()
                            {
                                RECORD_DATE = new DateTime(date.Year, date.Month, date.Day, date.Hour, 0, 0, DateTimeKind.Utc),
                                VALUE = oList_Business.Count
                            });
                        }
                        break;
                }

                #endregion
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }

            return oList_Kpi_Value_By_Date;
        }
        #endregion
        #region Get_Bylaw_Complaints_Trendline
        public List<Kpi_Value_By_Date> Get_Bylaw_Complaints_Trendline(Params_Get_Bylaw_Complaints_Trendline i_Params_Get_Bylaw_Complaints_Trendline)
        {
            List<Kpi_Value_By_Date> oList_Kpi_Value_By_Date = new List<Kpi_Value_By_Date>();

            if (i_Params_Get_Bylaw_Complaints_Trendline.ENUM_TIMESPAN != null && i_Params_Get_Bylaw_Complaints_Trendline.START_DATE != null && i_Params_Get_Bylaw_Complaints_Trendline.END_DATE != null &&
                i_Params_Get_Bylaw_Complaints_Trendline.LEVEL_SETUP_ID != null && i_Params_Get_Bylaw_Complaints_Trendline.LIST_LEVEL_ID != null & i_Params_Get_Bylaw_Complaints_Trendline.LIST_LEVEL_ID.Count > 0)
            {
                #region General

                Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();

                List<Organization_data_source_kpi> oList_Organization_data_source_kpi = Get_Organization_data_source_kpi_By_ORGANIZATION_ID_Adv(new Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID()
                {
                    ORGANIZATION_ID = i_Params_Get_Bylaw_Complaints_Trendline.ORGANIZATION_ID
                });
                if (oList_Organization_data_source_kpi != null && oList_Organization_data_source_kpi.Count > 0)
                {
                    oOrganization_data_source_kpi = oList_Organization_data_source_kpi.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.NAME == "Bylaw Complaints");
                }

                #endregion

                #region Get List_Bylaw_Complaints

                List<Bylaw_Complaint> oList_Bylaw_Complaints = new List<Bylaw_Complaint>();

                if (oOrganization_data_source_kpi != null)
                {
                    oList_Bylaw_Complaints = Get_Bylaw_Complaint_By_Where(new Params_Get_Bylaw_Complaint_By_Where()
                    {
                        LEVEL_SETUP_ID = i_Params_Get_Bylaw_Complaints_Trendline.LEVEL_SETUP_ID,
                        LIST_LEVEL_ID = i_Params_Get_Bylaw_Complaints_Trendline.LIST_LEVEL_ID,
                        ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = new List<int?> { oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID },
                        START_DATE = i_Params_Get_Bylaw_Complaints_Trendline.START_DATE,
                        END_DATE = i_Params_Get_Bylaw_Complaints_Trendline.END_DATE
                    });
                }


                #endregion

                #region Fill Data

                if (oList_Bylaw_Complaints != null && oList_Bylaw_Complaints.Count > 0)
                {
                    DateTime StartDate = i_Params_Get_Bylaw_Complaints_Trendline.START_DATE.Value;
                    switch (i_Params_Get_Bylaw_Complaints_Trendline.ENUM_TIMESPAN)
                    {
                        case Enum_Timespan.X_HOURLY_COLLECTION:
                            if (StartDate.Minute > 0 || StartDate.Second > 0)
                            {
                                StartDate = StartDate.AddHours(1);
                                StartDate = new DateTime(StartDate.Year, StartDate.Month, StartDate.Day, StartDate.Hour, 0, 0, DateTimeKind.Utc);
                            }
                            for (DateTime date = StartDate; date <= i_Params_Get_Bylaw_Complaints_Trendline.END_DATE.Value; date = date.AddHours(1))
                            {
                                oList_Kpi_Value_By_Date.Add(new Kpi_Value_By_Date()
                                {
                                    RECORD_DATE = new DateTime(date.Year, date.Month, date.Day, date.Hour, 0, 0, DateTimeKind.Utc),
                                    VALUE = oList_Bylaw_Complaints.Where(oBylaw_Complaint => oBylaw_Complaint.DATE_CREATED.Value.Date == date.Date).Count()
                                });
                            }
                            break;
                        case Enum_Timespan.X_DAILY_COLLECTION:
                            if (StartDate.Hour > 0 || StartDate.Minute > 0 || StartDate.Second > 0)
                            {
                                StartDate = StartDate.AddDays(1);
                                StartDate = new DateTime(StartDate.Year, StartDate.Month, StartDate.Day, 0, 0, 0, DateTimeKind.Utc);
                            }
                            for (DateTime date = StartDate; date <= i_Params_Get_Bylaw_Complaints_Trendline.END_DATE.Value.Date; date = date.AddDays(1))
                            {
                                oList_Kpi_Value_By_Date.Add(new Kpi_Value_By_Date()
                                {
                                    RECORD_DATE = new DateTime(date.Year, date.Month, date.Day, date.Hour, 0, 0, DateTimeKind.Utc),
                                    VALUE = oList_Bylaw_Complaints.Where(oBylaw_Complaint => oBylaw_Complaint.DATE_CREATED.Value.Date == date.Date).Count()
                                });
                            }
                            break;
                        case Enum_Timespan.X_WEEKLY_COLLECTION:
                            if (StartDate.Hour > 0 || StartDate.Minute > 0 || StartDate.Second > 0)
                            {
                                StartDate = new DateTime(StartDate.Year, StartDate.Month, StartDate.Day, 0, 0, 0, DateTimeKind.Utc);
                                while (StartDate.DayOfWeek != DayOfWeek.Monday)
                                {
                                    StartDate = StartDate.AddDays(1);
                                }
                            }
                            for (DateTime date = StartDate; date <= i_Params_Get_Bylaw_Complaints_Trendline.END_DATE.Value.Date; date = date.AddDays(7))
                            {
                                oList_Kpi_Value_By_Date.Add(new Kpi_Value_By_Date()
                                {
                                    RECORD_DATE = new DateTime(date.Year, date.Month, date.Day, date.Hour, 0, 0, DateTimeKind.Utc),
                                    VALUE = oList_Bylaw_Complaints.Where(oBylaw_Complaint => oBylaw_Complaint.DATE_CREATED.Value.Date == date.Date).Count()
                                });
                            }
                            break;
                        case Enum_Timespan.X_MONTHLY_COLLECTION:
                            if (StartDate.Day > 1 || StartDate.Hour > 0 || StartDate.Minute > 0 || StartDate.Second > 0)
                            {
                                StartDate = StartDate.AddMonths(1);
                                StartDate = new DateTime(StartDate.Year, StartDate.Month, 1, 0, 0, 0, DateTimeKind.Utc);
                            }
                            for (DateTime date = StartDate; date <= i_Params_Get_Bylaw_Complaints_Trendline.END_DATE.Value.Date; date = date.AddMonths(1))
                            {
                                oList_Kpi_Value_By_Date.Add(new Kpi_Value_By_Date()
                                {
                                    RECORD_DATE = new DateTime(date.Year, date.Month, date.Day, date.Hour, 0, 0, DateTimeKind.Utc),
                                    VALUE = oList_Bylaw_Complaints.Where(oBylaw_Complaint => oBylaw_Complaint.DATE_CREATED.Value.Date == date.Date).Count()
                                });
                            }
                            break;
                    }
                }

                #endregion
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }

            return oList_Kpi_Value_By_Date;
        }
        #endregion
        #region Get_Public_Events_Trendline
        public List<Kpi_Value_By_Date> Get_Public_Events_Trendline(Params_Get_Public_Events_Trendline i_Params_Get_Public_Events_Trendline)
        {
            List<Kpi_Value_By_Date> oList_Kpi_Value_By_Date = new List<Kpi_Value_By_Date>();

            if (i_Params_Get_Public_Events_Trendline.ENUM_TIMESPAN != null && i_Params_Get_Public_Events_Trendline.START_DATE != null && i_Params_Get_Public_Events_Trendline.END_DATE != null &&
                i_Params_Get_Public_Events_Trendline.LEVEL_SETUP_ID != null && i_Params_Get_Public_Events_Trendline.LIST_LEVEL_ID != null & i_Params_Get_Public_Events_Trendline.LIST_LEVEL_ID.Count > 0)
            {
                #region General

                Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();

                List<Organization_data_source_kpi> oList_Organization_data_source_kpi = Get_Organization_data_source_kpi_By_ORGANIZATION_ID_Adv(new Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID()
                {
                    ORGANIZATION_ID = i_Params_Get_Public_Events_Trendline.ORGANIZATION_ID
                });
                if (oList_Organization_data_source_kpi != null && oList_Organization_data_source_kpi.Count > 0)
                {
                    oOrganization_data_source_kpi = oList_Organization_data_source_kpi.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.NAME == "Public Events");
                }

                #endregion

                #region Get List_Public_Events

                List<Public_Event> oList_Public_Events = new List<Public_Event>();

                if (oOrganization_data_source_kpi != null)
                {
                    oList_Public_Events = Get_Public_Event_By_Where(new Params_Get_Public_Event_By_Where()
                    {
                        LEVEL_SETUP_ID = i_Params_Get_Public_Events_Trendline.LEVEL_SETUP_ID,
                        LIST_LEVEL_ID = i_Params_Get_Public_Events_Trendline.LIST_LEVEL_ID,
                        ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = new List<int?> { oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID },
                        START_DATE = i_Params_Get_Public_Events_Trendline.START_DATE,
                        END_DATE = i_Params_Get_Public_Events_Trendline.END_DATE
                    });
                }


                #endregion

                #region Fill Data

                if (oList_Public_Events != null && oList_Public_Events.Count > 0)
                {
                    DateTime StartDate = i_Params_Get_Public_Events_Trendline.START_DATE.Value;
                    switch (i_Params_Get_Public_Events_Trendline.ENUM_TIMESPAN)
                    {
                        case Enum_Timespan.X_HOURLY_COLLECTION:
                            if (StartDate.Minute > 0 || StartDate.Second > 0)
                            {
                                StartDate = StartDate.AddHours(1);
                                StartDate = new DateTime(StartDate.Year, StartDate.Month, StartDate.Day, StartDate.Hour, 0, 0, DateTimeKind.Utc);
                            }
                            for (DateTime date = StartDate; date <= i_Params_Get_Public_Events_Trendline.END_DATE.Value; date = date.AddHours(1))
                            {
                                oList_Kpi_Value_By_Date.Add(new Kpi_Value_By_Date()
                                {
                                    RECORD_DATE = new DateTime(date.Year, date.Month, date.Day, date.Hour, 0, 0, DateTimeKind.Utc),
                                    VALUE = oList_Public_Events.Where(oPublic_event => oPublic_event.START_TIME.Value.Date <= date.Date && oPublic_event.END_TIME.Value.Date >= date.Date).Count()
                                });
                            }
                            break;
                        case Enum_Timespan.X_DAILY_COLLECTION:
                            if (StartDate.Hour > 0 || StartDate.Minute > 0 || StartDate.Second > 0)
                            {
                                StartDate = StartDate.AddDays(1);
                                StartDate = new DateTime(StartDate.Year, StartDate.Month, StartDate.Day, 0, 0, 0, DateTimeKind.Utc);
                            }
                            for (DateTime date = StartDate; date <= i_Params_Get_Public_Events_Trendline.END_DATE.Value.Date; date = date.AddDays(1))
                            {
                                oList_Kpi_Value_By_Date.Add(new Kpi_Value_By_Date()
                                {
                                    RECORD_DATE = new DateTime(date.Year, date.Month, date.Day, date.Hour, 0, 0, DateTimeKind.Utc),
                                    VALUE = oList_Public_Events.Where(oPublic_event => oPublic_event.START_TIME.Value.Date <= date.Date && oPublic_event.END_TIME.Value.Date >= date.Date).Count()
                                });
                            }
                            break;
                        case Enum_Timespan.X_WEEKLY_COLLECTION:
                            if (StartDate.Hour > 0 || StartDate.Minute > 0 || StartDate.Second > 0)
                            {
                                StartDate = new DateTime(StartDate.Year, StartDate.Month, StartDate.Day, 0, 0, 0, DateTimeKind.Utc);
                                while (StartDate.DayOfWeek != DayOfWeek.Monday)
                                {
                                    StartDate = StartDate.AddDays(1);
                                }
                            }
                            for (DateTime date = StartDate; date <= i_Params_Get_Public_Events_Trendline.END_DATE.Value.Date; date = date.AddDays(7))
                            {
                                oList_Kpi_Value_By_Date.Add(new Kpi_Value_By_Date()
                                {
                                    RECORD_DATE = new DateTime(date.Year, date.Month, date.Day, date.Hour, 0, 0, DateTimeKind.Utc),
                                    VALUE = oList_Public_Events.Where(oPublic_event => oPublic_event.START_TIME.Value.Date <= date.Date && oPublic_event.END_TIME.Value.Date >= date.Date).Count()
                                });
                            }
                            break;
                        case Enum_Timespan.X_MONTHLY_COLLECTION:
                            if (StartDate.Day > 1 || StartDate.Hour > 0 || StartDate.Minute > 0 || StartDate.Second > 0)
                            {
                                StartDate = StartDate.AddMonths(1);
                                StartDate = new DateTime(StartDate.Year, StartDate.Month, 1, 0, 0, 0, DateTimeKind.Utc);
                            }
                            for (DateTime date = StartDate; date <= i_Params_Get_Public_Events_Trendline.END_DATE.Value.Date; date = date.AddMonths(1))
                            {
                                oList_Kpi_Value_By_Date.Add(new Kpi_Value_By_Date()
                                {
                                    RECORD_DATE = new DateTime(date.Year, date.Month, date.Day, date.Hour, 0, 0, DateTimeKind.Utc),
                                    VALUE = oList_Public_Events.Where(oPublic_event => oPublic_event.START_TIME.Value.Date <= date.Date && oPublic_event.END_TIME.Value.Date >= date.Date).Count()
                                });
                            }
                            break;
                    }
                }

                #endregion
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }

            return oList_Kpi_Value_By_Date;
        }
        #endregion

        #region Get_Organization_Data_Access
        public Organization_Data_Access Get_Organization_Data_Access(Params_Get_Organization_Data_Access i_Params_Get_Organization_Data_Access)
        {
            Organization_Data_Access oOrganization_Data_Access = new Organization_Data_Access();

            if (i_Params_Get_Organization_Data_Access.ORGANIZATION_ID != null)
            {
                #region Declaration & Initialization

                oOrganization_Data_Access.LIST_ORGANIZATION_DATA_SOURCE_KPI = new List<Organization_data_source_kpi>();
                oOrganization_Data_Access.LIST_DISTRICT = new List<District>();
                oOrganization_Data_Access.LIST_DISTRICT_KPI = new List<District_kpi>();
                oOrganization_Data_Access.LIST_AREA = new List<Area>();
                oOrganization_Data_Access.LIST_AREA_KPI = new List<Area_kpi>();
                oOrganization_Data_Access.LIST_SITE = new List<Site>();
                oOrganization_Data_Access.LIST_SITE_KPI = new List<Site_kpi>();
                oOrganization_Data_Access.LIST_ENTITY = new List<Entity>();
                oOrganization_Data_Access.LIST_ENTITY_KPI = new List<Entity_kpi>();

                #endregion

                #region Get Orgnization data source kpi

                oOrganization_Data_Access.LIST_ORGANIZATION_DATA_SOURCE_KPI = Get_Organization_data_source_kpi_By_ORGANIZATION_ID_Adv(new Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID()
                {
                    ORGANIZATION_ID = i_Params_Get_Organization_Data_Access.ORGANIZATION_ID
                });

                #endregion

                if (oOrganization_Data_Access.LIST_ORGANIZATION_DATA_SOURCE_KPI != null && oOrganization_Data_Access.LIST_ORGANIZATION_DATA_SOURCE_KPI.Count > 0)
                {
                    #region Get District Info

                    var get_district_info = Task.Run(() =>
                    {

                        oOrganization_Data_Access.LIST_DISTRICT_KPI = Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List(new Params_Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List()
                        {
                            ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = oOrganization_Data_Access.LIST_ORGANIZATION_DATA_SOURCE_KPI.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList()
                        });

                        if (oOrganization_Data_Access.LIST_DISTRICT_KPI != null && oOrganization_Data_Access.LIST_DISTRICT_KPI.Count > 0)
                        {
                            List<long?> List_District_ID = oOrganization_Data_Access.LIST_DISTRICT_KPI.DistinctBy(oDistrict_kpi => oDistrict_kpi.DISTRICT_ID).Select(oDistrict_kpi => oDistrict_kpi.DISTRICT_ID).ToList();
                            oOrganization_Data_Access.LIST_DISTRICT = Get_District_By_DISTRICT_ID_List(new Params_Get_District_By_DISTRICT_ID_List()
                            {
                                DISTRICT_ID_LIST = List_District_ID
                            });
                        }
                    });

                    #endregion

                    #region Get Area Info

                    var get_area_info = Task.Run(() =>
                    {

                        oOrganization_Data_Access.LIST_AREA_KPI = Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List(new Params_Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List()
                        {
                            ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = oOrganization_Data_Access.LIST_ORGANIZATION_DATA_SOURCE_KPI.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList()
                        });

                        if (oOrganization_Data_Access.LIST_AREA_KPI != null && oOrganization_Data_Access.LIST_AREA_KPI.Count > 0)
                        {
                            List<long?> List_Area_ID = oOrganization_Data_Access.LIST_AREA_KPI.DistinctBy(oArea_kpi => oArea_kpi.AREA_ID).Select(oArea_kpi => oArea_kpi.AREA_ID).ToList();
                            oOrganization_Data_Access.LIST_AREA = Get_Area_By_AREA_ID_List(new Params_Get_Area_By_AREA_ID_List()
                            {
                                AREA_ID_LIST = List_Area_ID
                            });
                        }
                    });

                    #endregion

                    #region Get Site Info

                    var get_site_info = Task.Run(() =>
                    {

                        oOrganization_Data_Access.LIST_SITE_KPI = Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List(new Params_Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List()
                        {
                            ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = oOrganization_Data_Access.LIST_ORGANIZATION_DATA_SOURCE_KPI.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList()
                        });

                        if (oOrganization_Data_Access.LIST_SITE_KPI != null && oOrganization_Data_Access.LIST_SITE_KPI.Count > 0)
                        {
                            List<long?> List_Site_ID = oOrganization_Data_Access.LIST_SITE_KPI.DistinctBy(oSite_kpi => oSite_kpi.SITE_ID).Select(oSite_kpi => oSite_kpi.SITE_ID).ToList();
                            oOrganization_Data_Access.LIST_SITE = Get_Site_By_SITE_ID_List(new Params_Get_Site_By_SITE_ID_List()
                            {
                                SITE_ID_LIST = List_Site_ID
                            });
                        }
                    });

                    #endregion

                    #region Get Entity Info

                    var get_entity_info = Task.Run(() =>
                    {

                        oOrganization_Data_Access.LIST_ENTITY_KPI = Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List(new Params_Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List()
                        {
                            ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = oOrganization_Data_Access.LIST_ORGANIZATION_DATA_SOURCE_KPI.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList()
                        });

                        if (oOrganization_Data_Access.LIST_ENTITY_KPI != null && oOrganization_Data_Access.LIST_ENTITY_KPI.Count > 0)
                        {
                            List<long?> List_Entity_ID = oOrganization_Data_Access.LIST_ENTITY_KPI.DistinctBy(oEntity_kpi => oEntity_kpi.ENTITY_ID).Select(oEntity_kpi => oEntity_kpi.ENTITY_ID).ToList();
                            oOrganization_Data_Access.LIST_ENTITY = Get_Entity_By_ENTITY_ID_List(new Params_Get_Entity_By_ENTITY_ID_List()
                            {
                                ENTITY_ID_LIST = List_Entity_ID
                            });
                        }
                    });

                    #endregion

                    Task.WaitAll(get_district_info, get_area_info, get_site_info, get_entity_info);
                }
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }

            return oOrganization_Data_Access;
        }
        #endregion
        #region Edit_Organization_Data_Access
        public Params_Edit_Organization_Data_Access Edit_Organization_Data_Access(Params_Edit_Organization_Data_Access i_Params_Edit_Organization_Data_Access)
        {
            if (i_Params_Edit_Organization_Data_Access.Selected_Level_Setup.VALUE == "District")
            {
                #region Edit District Kpi With Children

                long? District_ID = 0;
                if (i_Params_Edit_Organization_Data_Access.List_To_Edit_District_kpi != null && i_Params_Edit_Organization_Data_Access.List_To_Edit_District_kpi.Count > 0)
                {
                    District_ID = i_Params_Edit_Organization_Data_Access.List_To_Edit_District_kpi[0].DISTRICT_ID;
                }
                else if (i_Params_Edit_Organization_Data_Access.List_To_Delete_District_kpi != null && i_Params_Edit_Organization_Data_Access.List_To_Delete_District_kpi.Count > 0)
                {
                    District_ID = i_Params_Edit_Organization_Data_Access.List_To_Delete_District_kpi[0].DISTRICT_ID;
                }
                List<int?> List_Organization_data_source_kpi_ID_To_Edit = i_Params_Edit_Organization_Data_Access.List_To_Edit_District_kpi.Select(oDistrict_kpi => oDistrict_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();
                List<int?> List_Organization_data_source_kpi_ID_To_Delete = i_Params_Edit_Organization_Data_Access.List_To_Delete_District_kpi.Select(oDistrict_kpi => oDistrict_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();

                #region Edit District_kpi

                var edit_district = Task.Run(() =>
                {
                    List<long?> List_To_Delete = new List<long?>();
                    if (i_Params_Edit_Organization_Data_Access.List_To_Delete_District_kpi != null && i_Params_Edit_Organization_Data_Access.List_To_Delete_District_kpi.Count > 0)
                    {
                        List_To_Delete = i_Params_Edit_Organization_Data_Access.List_To_Delete_District_kpi.Select(oDistrict_kpi => oDistrict_kpi.DISTRICT_KPI_ID).ToList();
                    }
                    Edit_District_kpi_List(new Params_Edit_District_kpi_List()
                    {
                        List_To_Edit = i_Params_Edit_Organization_Data_Access.List_To_Edit_District_kpi,
                        List_To_Delete = List_To_Delete
                    });
                });

                #endregion

                #region Edit Area_kpi

                var edit_area = Task.Run(() =>
                {
                    i_Params_Edit_Organization_Data_Access.List_To_Edit_Area_kpi = new List<Area_kpi>();
                    i_Params_Edit_Organization_Data_Access.List_To_Delete_Area_kpi = new List<Area_kpi>();

                    List<Area> oList_Area = new List<Area>();
                    if (District_ID != 0)
                    {
                        oList_Area = Get_Area_By_DISTRICT_ID(new Params_Get_Area_By_DISTRICT_ID() { DISTRICT_ID = District_ID });
                    }
                    if (oList_Area != null && oList_Area.Count > 0)
                    {
                        List<Area_kpi> oList_Area_kpi = Get_Area_kpi_By_AREA_ID_List(new Params_Get_Area_kpi_By_AREA_ID_List() { AREA_ID_LIST = oList_Area.Select(oArea => oArea.AREA_ID).ToList() });
                        if (oList_Area_kpi != null && oList_Area_kpi.Count > 0)
                        {
                            oList_Area_kpi = oList_Area_kpi.Where(oArea_kpi => List_Organization_data_source_kpi_ID_To_Edit.Any(Organization_data_source_kpi_ID => Organization_data_source_kpi_ID == oArea_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID) ||
                                                                                List_Organization_data_source_kpi_ID_To_Delete.Any(Organization_data_source_kpi_ID => Organization_data_source_kpi_ID == oArea_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID)).ToList();
                        }

                        oList_Area.ForEach(oArea =>
                        {
                            List<Area_kpi> _List_Area_kpi = new List<Area_kpi>();
                            if (oList_Area_kpi != null && oList_Area_kpi.Count > 0)
                            {
                                _List_Area_kpi = oList_Area_kpi.Where(oArea_kpi => oArea_kpi.AREA_ID == oArea.AREA_ID).ToList();
                            }
                            List_Organization_data_source_kpi_ID_To_Edit.ForEach(Organization_data_source_kpi_ID =>
                            {
                                if (_List_Area_kpi.Count == 0 || !_List_Area_kpi.Any(oArea_kpi => oArea_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == Organization_data_source_kpi_ID))
                                {
                                    i_Params_Edit_Organization_Data_Access.List_To_Edit_Area_kpi.Add(new Area_kpi()
                                    {
                                        AREA_KPI_ID = -1,
                                        AREA_ID = oArea.AREA_ID,
                                        ORGANIZATION_DATA_SOURCE_KPI_ID = Organization_data_source_kpi_ID
                                    });
                                }
                            });
                            List_Organization_data_source_kpi_ID_To_Delete.ForEach(Organization_data_source_kpi_ID =>
                            {
                                if (_List_Area_kpi.Count > 0 && _List_Area_kpi.Any(oArea_kpi => oArea_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == Organization_data_source_kpi_ID))
                                {
                                    Area_kpi oArea_kpi = _List_Area_kpi.Find(oArea_kpi => oArea_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == Organization_data_source_kpi_ID);
                                    i_Params_Edit_Organization_Data_Access.List_To_Delete_Area_kpi.Add(oArea_kpi);
                                }
                            });
                        });

                        List<long?> List_To_Delete = new List<long?>();
                        if (i_Params_Edit_Organization_Data_Access.List_To_Delete_Area_kpi != null && i_Params_Edit_Organization_Data_Access.List_To_Delete_Area_kpi.Count > 0)
                        {
                            List_To_Delete = i_Params_Edit_Organization_Data_Access.List_To_Delete_Area_kpi.Select(oArea_kpi => oArea_kpi.AREA_KPI_ID).ToList();
                        }
                        Edit_Area_kpi_List(new Params_Edit_Area_kpi_List()
                        {
                            List_To_Edit = i_Params_Edit_Organization_Data_Access.List_To_Edit_Area_kpi,
                            List_To_Delete = List_To_Delete
                        });
                    }
                });

                #endregion

                #region Edit Site_kpi

                var edit_site = Task.Run(() =>
                {
                    i_Params_Edit_Organization_Data_Access.List_To_Edit_Site_kpi = new List<Site_kpi>();
                    i_Params_Edit_Organization_Data_Access.List_To_Delete_Site_kpi = new List<Site_kpi>();

                    List<Site> oList_Site = new List<Site>();
                    if (District_ID != 0)
                    {
                        oList_Site = Get_Site_By_DISTRICT_ID(new Params_Get_Site_By_DISTRICT_ID() { DISTRICT_ID = District_ID });
                    }
                    if (oList_Site != null && oList_Site.Count > 0)
                    {
                        List<Site_kpi> oList_Site_kpi = Get_Site_kpi_By_SITE_ID_List(new Params_Get_Site_kpi_By_SITE_ID_List() { SITE_ID_LIST = oList_Site.Select(oSite => oSite.SITE_ID).ToList() });
                        if (oList_Site_kpi != null && oList_Site_kpi.Count > 0)
                        {
                            oList_Site_kpi = oList_Site_kpi.Where(oSite_kpi => List_Organization_data_source_kpi_ID_To_Edit.Any(Organization_data_source_kpi_ID => Organization_data_source_kpi_ID == oSite_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID) ||
                                                                                List_Organization_data_source_kpi_ID_To_Delete.Any(Organization_data_source_kpi_ID => Organization_data_source_kpi_ID == oSite_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID)).ToList();
                        }

                        oList_Site.ForEach(oSite =>
                        {
                            List<Site_kpi> _List_Site_kpi = new List<Site_kpi>();
                            if (oList_Site_kpi != null && oList_Site_kpi.Count > 0)
                            {
                                _List_Site_kpi = oList_Site_kpi.Where(oSite_kpi => oSite_kpi.SITE_ID == oSite.SITE_ID).ToList();
                            }
                            List_Organization_data_source_kpi_ID_To_Edit.ForEach(Organization_data_source_kpi_ID =>
                            {
                                if (_List_Site_kpi.Count == 0 || !_List_Site_kpi.Any(oSite_kpi => oSite_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == Organization_data_source_kpi_ID))
                                {
                                    i_Params_Edit_Organization_Data_Access.List_To_Edit_Site_kpi.Add(new Site_kpi()
                                    {
                                        SITE_KPI_ID = -1,
                                        SITE_ID = oSite.SITE_ID,
                                        ORGANIZATION_DATA_SOURCE_KPI_ID = Organization_data_source_kpi_ID
                                    });
                                }
                            });
                            List_Organization_data_source_kpi_ID_To_Delete.ForEach(Organization_data_source_kpi_ID =>
                            {
                                if (_List_Site_kpi.Count > 0 && _List_Site_kpi.Any(oSite_kpi => oSite_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == Organization_data_source_kpi_ID))
                                {
                                    Site_kpi oSite_kpi = _List_Site_kpi.Find(oSite_kpi => oSite_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == Organization_data_source_kpi_ID);
                                    i_Params_Edit_Organization_Data_Access.List_To_Delete_Site_kpi.Add(oSite_kpi);
                                }
                            });
                        });

                        List<long?> List_To_Delete = new List<long?>();
                        if (i_Params_Edit_Organization_Data_Access.List_To_Delete_Site_kpi != null && i_Params_Edit_Organization_Data_Access.List_To_Delete_Site_kpi.Count > 0)
                        {
                            List_To_Delete = i_Params_Edit_Organization_Data_Access.List_To_Delete_Site_kpi.Select(oSite_kpi => oSite_kpi.SITE_KPI_ID).ToList();
                        }
                        Edit_Site_kpi_List(new Params_Edit_Site_kpi_List()
                        {
                            List_To_Edit = i_Params_Edit_Organization_Data_Access.List_To_Edit_Site_kpi,
                            List_To_Delete = List_To_Delete
                        });
                    }
                });

                #endregion

                #region Edit Entity_kpi

                var edit_entity = Task.Run(() =>
                {
                    i_Params_Edit_Organization_Data_Access.List_To_Edit_Entity_kpi = new List<Entity_kpi>();
                    i_Params_Edit_Organization_Data_Access.List_To_Delete_Entity_kpi = new List<Entity_kpi>();

                    List<Entity> oList_Entity = new List<Entity>();
                    if (District_ID != 0)
                    {
                        oList_Entity = Get_Entity_By_DISTRICT_ID(new Params_Get_Entity_By_DISTRICT_ID() { DISTRICT_ID = District_ID });
                    }
                    if (oList_Entity != null && oList_Entity.Count > 0)
                    {
                        List<Entity_kpi> oList_Entity_kpi = Get_Entity_kpi_By_ENTITY_ID_List(new Params_Get_Entity_kpi_By_ENTITY_ID_List() { ENTITY_ID_LIST = oList_Entity.Select(oEntity => oEntity.ENTITY_ID).ToList() });
                        if (oList_Entity_kpi != null && oList_Entity_kpi.Count > 0)
                        {
                            oList_Entity_kpi = oList_Entity_kpi.Where(oEntity_kpi => List_Organization_data_source_kpi_ID_To_Edit.Any(Organization_data_source_kpi_ID => Organization_data_source_kpi_ID == oEntity_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID) ||
                                                                                     List_Organization_data_source_kpi_ID_To_Delete.Any(Organization_data_source_kpi_ID => Organization_data_source_kpi_ID == oEntity_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID)).ToList();
                        }

                        oList_Entity.ForEach(oEntity =>
                        {
                            List<Entity_kpi> _List_Entity_kpi = new List<Entity_kpi>();
                            if (oList_Entity_kpi != null && oList_Entity_kpi.Count > 0)
                            {
                                _List_Entity_kpi = oList_Entity_kpi.Where(oEntity_kpi => oEntity_kpi.ENTITY_ID == oEntity.ENTITY_ID).ToList();
                            }
                            List_Organization_data_source_kpi_ID_To_Edit.ForEach(Organization_data_source_kpi_ID =>
                            {
                                if (_List_Entity_kpi.Count == 0 || !_List_Entity_kpi.Any(oEntity_kpi => oEntity_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == Organization_data_source_kpi_ID))
                                {
                                    i_Params_Edit_Organization_Data_Access.List_To_Edit_Entity_kpi.Add(new Entity_kpi()
                                    {
                                        ENTITY_KPI_ID = -1,
                                        ENTITY_ID = oEntity.ENTITY_ID,
                                        ORGANIZATION_DATA_SOURCE_KPI_ID = Organization_data_source_kpi_ID
                                    });
                                }
                            });
                            List_Organization_data_source_kpi_ID_To_Delete.ForEach(Organization_data_source_kpi_ID =>
                            {
                                if (_List_Entity_kpi.Count > 0 && _List_Entity_kpi.Any(oEntity_kpi => oEntity_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == Organization_data_source_kpi_ID))
                                {
                                    Entity_kpi oEntity_kpi = _List_Entity_kpi.Find(oEntity_kpi => oEntity_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == Organization_data_source_kpi_ID);
                                    i_Params_Edit_Organization_Data_Access.List_To_Delete_Entity_kpi.Add(oEntity_kpi);
                                }
                            });
                        });

                        List<long?> List_To_Delete = new List<long?>();
                        if (i_Params_Edit_Organization_Data_Access.List_To_Delete_Entity_kpi != null && i_Params_Edit_Organization_Data_Access.List_To_Delete_Entity_kpi.Count > 0)
                        {
                            List_To_Delete = i_Params_Edit_Organization_Data_Access.List_To_Delete_Entity_kpi.Select(oEntity_kpi => oEntity_kpi.ENTITY_KPI_ID).ToList();
                        }
                        Edit_Entity_kpi_List(new Params_Edit_Entity_kpi_List()
                        {
                            List_To_Edit = i_Params_Edit_Organization_Data_Access.List_To_Edit_Entity_kpi,
                            List_To_Delete = List_To_Delete
                        });
                    }
                });

                #endregion

                Task.WaitAll(edit_district, edit_area, edit_site, edit_entity);

                #endregion
            }
            else if (i_Params_Edit_Organization_Data_Access.Selected_Level_Setup.VALUE == "Area")
            {
                #region Edit Area Kpi With Children

                long? Area_ID = 0;
                if (i_Params_Edit_Organization_Data_Access.List_To_Edit_Area_kpi != null && i_Params_Edit_Organization_Data_Access.List_To_Edit_Area_kpi.Count > 0)
                {
                    Area_ID = i_Params_Edit_Organization_Data_Access.List_To_Edit_Area_kpi[0].AREA_ID;
                }
                else if (i_Params_Edit_Organization_Data_Access.List_To_Delete_Area_kpi != null && i_Params_Edit_Organization_Data_Access.List_To_Delete_Area_kpi.Count > 0)
                {
                    Area_ID = i_Params_Edit_Organization_Data_Access.List_To_Delete_Area_kpi[0].AREA_ID;
                }
                List<int?> List_Organization_data_source_kpi_ID_To_Edit = i_Params_Edit_Organization_Data_Access.List_To_Edit_Area_kpi.Select(oArea_kpi => oArea_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();
                List<int?> List_Organization_data_source_kpi_ID_To_Delete = i_Params_Edit_Organization_Data_Access.List_To_Delete_Area_kpi.Select(oArea_kpi => oArea_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();

                #region Edit Area_kpi

                var edit_area = Task.Run(() =>
                {
                    List<long?> List_To_Delete = new List<long?>();
                    if (i_Params_Edit_Organization_Data_Access.List_To_Delete_Area_kpi != null && i_Params_Edit_Organization_Data_Access.List_To_Delete_Area_kpi.Count > 0)
                    {
                        List_To_Delete = i_Params_Edit_Organization_Data_Access.List_To_Delete_Area_kpi.Select(oArea_kpi => oArea_kpi.AREA_KPI_ID).ToList();
                    }
                    Edit_Area_kpi_List(new Params_Edit_Area_kpi_List()
                    {
                        List_To_Edit = i_Params_Edit_Organization_Data_Access.List_To_Edit_Area_kpi,
                        List_To_Delete = List_To_Delete
                    });
                });

                #endregion

                #region Edit Site_kpi

                var edit_site = Task.Run(() =>
                {
                    i_Params_Edit_Organization_Data_Access.List_To_Edit_Site_kpi = new List<Site_kpi>();
                    i_Params_Edit_Organization_Data_Access.List_To_Delete_Site_kpi = new List<Site_kpi>();

                    List<Site> oList_Site = new List<Site>();
                    if (Area_ID != 0)
                    {
                        oList_Site = Get_Site_By_AREA_ID(new Params_Get_Site_By_AREA_ID() { AREA_ID = Area_ID });
                    }
                    if (oList_Site != null && oList_Site.Count > 0)
                    {
                        List<Site_kpi> oList_Site_kpi = Get_Site_kpi_By_SITE_ID_List(new Params_Get_Site_kpi_By_SITE_ID_List() { SITE_ID_LIST = oList_Site.Select(oSite => oSite.SITE_ID).ToList() });
                        if (oList_Site_kpi != null && oList_Site_kpi.Count > 0)
                        {
                            oList_Site_kpi = oList_Site_kpi.Where(oSite_kpi => List_Organization_data_source_kpi_ID_To_Edit.Any(Organization_data_source_kpi_ID => Organization_data_source_kpi_ID == oSite_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID) ||
                                                                               List_Organization_data_source_kpi_ID_To_Delete.Any(Organization_data_source_kpi_ID => Organization_data_source_kpi_ID == oSite_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID)).ToList();
                        }

                        oList_Site.ForEach(oSite =>
                        {
                            List<Site_kpi> _List_Site_kpi = new List<Site_kpi>();
                            if (oList_Site_kpi != null && oList_Site_kpi.Count > 0)
                            {
                                _List_Site_kpi = oList_Site_kpi.Where(oSite_kpi => oSite_kpi.SITE_ID == oSite.SITE_ID).ToList();
                            }
                            List_Organization_data_source_kpi_ID_To_Edit.ForEach(Organization_data_source_kpi_ID =>
                            {
                                if (_List_Site_kpi.Count == 0 || !_List_Site_kpi.Any(oSite_kpi => oSite_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == Organization_data_source_kpi_ID))
                                {
                                    i_Params_Edit_Organization_Data_Access.List_To_Edit_Site_kpi.Add(new Site_kpi()
                                    {
                                        SITE_KPI_ID = -1,
                                        SITE_ID = oSite.SITE_ID,
                                        ORGANIZATION_DATA_SOURCE_KPI_ID = Organization_data_source_kpi_ID
                                    });
                                }
                            });
                            List_Organization_data_source_kpi_ID_To_Delete.ForEach(Organization_data_source_kpi_ID =>
                            {
                                if (_List_Site_kpi.Count > 0 && _List_Site_kpi.Any(oSite_kpi => oSite_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == Organization_data_source_kpi_ID))
                                {
                                    Site_kpi oSite_kpi = _List_Site_kpi.Find(oSite_kpi => oSite_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == Organization_data_source_kpi_ID);
                                    i_Params_Edit_Organization_Data_Access.List_To_Delete_Site_kpi.Add(oSite_kpi);
                                }
                            });
                        });

                        List<long?> List_To_Delete = new List<long?>();
                        if (i_Params_Edit_Organization_Data_Access.List_To_Delete_Site_kpi != null && i_Params_Edit_Organization_Data_Access.List_To_Delete_Site_kpi.Count > 0)
                        {
                            List_To_Delete = i_Params_Edit_Organization_Data_Access.List_To_Delete_Site_kpi.Select(oSite_kpi => oSite_kpi.SITE_KPI_ID).ToList();
                        }
                        Edit_Site_kpi_List(new Params_Edit_Site_kpi_List()
                        {
                            List_To_Edit = i_Params_Edit_Organization_Data_Access.List_To_Edit_Site_kpi,
                            List_To_Delete = List_To_Delete
                        });
                    }
                });

                #endregion

                #region Edit Entity_kpi

                var edit_entity = Task.Run(() =>
                {
                    i_Params_Edit_Organization_Data_Access.List_To_Edit_Entity_kpi = new List<Entity_kpi>();
                    i_Params_Edit_Organization_Data_Access.List_To_Delete_Entity_kpi = new List<Entity_kpi>();

                    List<Entity> oList_Entity = new List<Entity>();
                    if (Area_ID != 0)
                    {
                        oList_Entity = Get_Entity_By_AREA_ID(new Params_Get_Entity_By_AREA_ID() { AREA_ID = Area_ID });
                    }
                    if (oList_Entity != null && oList_Entity.Count > 0)
                    {
                        List<Entity_kpi> oList_Entity_kpi = Get_Entity_kpi_By_ENTITY_ID_List(new Params_Get_Entity_kpi_By_ENTITY_ID_List() { ENTITY_ID_LIST = oList_Entity.Select(oEntity => oEntity.ENTITY_ID).ToList() });
                        if (oList_Entity_kpi != null && oList_Entity_kpi.Count > 0)
                        {
                            oList_Entity_kpi = oList_Entity_kpi.Where(oEntity_kpi => List_Organization_data_source_kpi_ID_To_Edit.Any(Organization_data_source_kpi_ID => Organization_data_source_kpi_ID == oEntity_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID) ||
                                                                                     List_Organization_data_source_kpi_ID_To_Delete.Any(Organization_data_source_kpi_ID => Organization_data_source_kpi_ID == oEntity_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID)).ToList();
                        }

                        oList_Entity.ForEach(oEntity =>
                        {
                            List<Entity_kpi> _List_Entity_kpi = new List<Entity_kpi>();
                            if (oList_Entity_kpi != null && oList_Entity_kpi.Count > 0)
                            {
                                _List_Entity_kpi = oList_Entity_kpi.Where(oEntity_kpi => oEntity_kpi.ENTITY_ID == oEntity.ENTITY_ID).ToList();
                            }
                            List_Organization_data_source_kpi_ID_To_Edit.ForEach(Organization_data_source_kpi_ID =>
                            {
                                if (_List_Entity_kpi.Count == 0 || !_List_Entity_kpi.Any(oEntity_kpi => oEntity_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == Organization_data_source_kpi_ID))
                                {
                                    i_Params_Edit_Organization_Data_Access.List_To_Edit_Entity_kpi.Add(new Entity_kpi()
                                    {
                                        ENTITY_KPI_ID = -1,
                                        ENTITY_ID = oEntity.ENTITY_ID,
                                        ORGANIZATION_DATA_SOURCE_KPI_ID = Organization_data_source_kpi_ID
                                    });
                                }
                            });
                            List_Organization_data_source_kpi_ID_To_Delete.ForEach(Organization_data_source_kpi_ID =>
                            {
                                if (_List_Entity_kpi.Count > 0 && _List_Entity_kpi.Any(oEntity_kpi => oEntity_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == Organization_data_source_kpi_ID))
                                {
                                    Entity_kpi oEntity_kpi = _List_Entity_kpi.Find(oEntity_kpi => oEntity_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == Organization_data_source_kpi_ID);
                                    i_Params_Edit_Organization_Data_Access.List_To_Delete_Entity_kpi.Add(oEntity_kpi);
                                }
                            });
                        });

                        List<long?> List_To_Delete = new List<long?>();
                        if (i_Params_Edit_Organization_Data_Access.List_To_Delete_Entity_kpi != null && i_Params_Edit_Organization_Data_Access.List_To_Delete_Entity_kpi.Count > 0)
                        {
                            List_To_Delete = i_Params_Edit_Organization_Data_Access.List_To_Delete_Entity_kpi.Select(oEntity_kpi => oEntity_kpi.ENTITY_KPI_ID).ToList();
                        }
                        Edit_Entity_kpi_List(new Params_Edit_Entity_kpi_List()
                        {
                            List_To_Edit = i_Params_Edit_Organization_Data_Access.List_To_Edit_Entity_kpi,
                            List_To_Delete = List_To_Delete
                        });
                    }
                });

                #endregion

                Task.WaitAll(edit_area, edit_site, edit_entity);

                #endregion
            }
            else if (i_Params_Edit_Organization_Data_Access.Selected_Level_Setup.VALUE == "Site")
            {
                #region Edit Site Kpi With Children

                long? Site_ID = 0;
                if (i_Params_Edit_Organization_Data_Access.List_To_Edit_Site_kpi != null && i_Params_Edit_Organization_Data_Access.List_To_Edit_Site_kpi.Count > 0)
                {
                    Site_ID = i_Params_Edit_Organization_Data_Access.List_To_Edit_Site_kpi[0].SITE_ID;
                }
                else if (i_Params_Edit_Organization_Data_Access.List_To_Delete_Site_kpi != null && i_Params_Edit_Organization_Data_Access.List_To_Delete_Site_kpi.Count > 0)
                {
                    Site_ID = i_Params_Edit_Organization_Data_Access.List_To_Delete_Site_kpi[0].SITE_ID;
                }
                List<int?> List_Organization_data_source_kpi_ID_To_Edit = i_Params_Edit_Organization_Data_Access.List_To_Edit_Site_kpi.Select(oSite_kpi => oSite_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();
                List<int?> List_Organization_data_source_kpi_ID_To_Delete = i_Params_Edit_Organization_Data_Access.List_To_Delete_Site_kpi.Select(oSite_kpi => oSite_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();

                #region Edit Site_kpi

                var edit_site = Task.Run(() =>
                {
                    List<long?> List_To_Delete = new List<long?>();
                    if (i_Params_Edit_Organization_Data_Access.List_To_Delete_Site_kpi != null && i_Params_Edit_Organization_Data_Access.List_To_Delete_Site_kpi.Count > 0)
                    {
                        List_To_Delete = i_Params_Edit_Organization_Data_Access.List_To_Delete_Site_kpi.Select(oSite_kpi => oSite_kpi.SITE_KPI_ID).ToList();
                    }
                    Edit_Site_kpi_List(new Params_Edit_Site_kpi_List()
                    {
                        List_To_Edit = i_Params_Edit_Organization_Data_Access.List_To_Edit_Site_kpi,
                        List_To_Delete = List_To_Delete
                    });
                });

                #endregion

                #region Edit Entity_kpi

                var edit_entity = Task.Run(() =>
                {
                    i_Params_Edit_Organization_Data_Access.List_To_Edit_Entity_kpi = new List<Entity_kpi>();
                    i_Params_Edit_Organization_Data_Access.List_To_Delete_Entity_kpi = new List<Entity_kpi>();

                    List<Entity> oList_Entity = new List<Entity>();
                    if (Site_ID != 0)
                    {
                        oList_Entity = Get_Entity_By_SITE_ID(new Params_Get_Entity_By_SITE_ID() { SITE_ID = Site_ID });
                    }
                    if (oList_Entity != null && oList_Entity.Count > 0)
                    {
                        List<Entity_kpi> oList_Entity_kpi = Get_Entity_kpi_By_ENTITY_ID_List(new Params_Get_Entity_kpi_By_ENTITY_ID_List() { ENTITY_ID_LIST = oList_Entity.Select(oEntity => oEntity.ENTITY_ID).ToList() });
                        if (oList_Entity_kpi != null && oList_Entity_kpi.Count > 0)
                        {
                            oList_Entity_kpi = oList_Entity_kpi.Where(oEntity_kpi => List_Organization_data_source_kpi_ID_To_Edit.Any(Organization_data_source_kpi_ID => Organization_data_source_kpi_ID == oEntity_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID) ||
                                                                                     List_Organization_data_source_kpi_ID_To_Delete.Any(Organization_data_source_kpi_ID => Organization_data_source_kpi_ID == oEntity_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID)).ToList();
                        }

                        oList_Entity.ForEach(oEntity =>
                        {
                            List<Entity_kpi> _List_Entity_kpi = new List<Entity_kpi>();
                            if (oList_Entity_kpi != null && oList_Entity_kpi.Count > 0)
                            {
                                _List_Entity_kpi = oList_Entity_kpi.Where(oEntity_kpi => oEntity_kpi.ENTITY_ID == oEntity.ENTITY_ID).ToList();
                            }
                            List_Organization_data_source_kpi_ID_To_Edit.ForEach(Organization_data_source_kpi_ID =>
                            {
                                if (_List_Entity_kpi.Count == 0 || !_List_Entity_kpi.Any(oEntity_kpi => oEntity_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == Organization_data_source_kpi_ID))
                                {
                                    i_Params_Edit_Organization_Data_Access.List_To_Edit_Entity_kpi.Add(new Entity_kpi()
                                    {
                                        ENTITY_KPI_ID = -1,
                                        ENTITY_ID = oEntity.ENTITY_ID,
                                        ORGANIZATION_DATA_SOURCE_KPI_ID = Organization_data_source_kpi_ID
                                    });
                                }
                            });
                            List_Organization_data_source_kpi_ID_To_Delete.ForEach(Organization_data_source_kpi_ID =>
                            {
                                if (_List_Entity_kpi.Count > 0 && _List_Entity_kpi.Any(oEntity_kpi => oEntity_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == Organization_data_source_kpi_ID))
                                {
                                    Entity_kpi oEntity_kpi = _List_Entity_kpi.Find(oEntity_kpi => oEntity_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == Organization_data_source_kpi_ID);
                                    i_Params_Edit_Organization_Data_Access.List_To_Delete_Entity_kpi.Add(oEntity_kpi);
                                }
                            });
                        });

                        List<long?> List_To_Delete = new List<long?>();
                        if (i_Params_Edit_Organization_Data_Access.List_To_Delete_Entity_kpi != null && i_Params_Edit_Organization_Data_Access.List_To_Delete_Entity_kpi.Count > 0)
                        {
                            List_To_Delete = i_Params_Edit_Organization_Data_Access.List_To_Delete_Entity_kpi.Select(oEntity_kpi => oEntity_kpi.ENTITY_KPI_ID).ToList();
                        }
                        Edit_Entity_kpi_List(new Params_Edit_Entity_kpi_List()
                        {
                            List_To_Edit = i_Params_Edit_Organization_Data_Access.List_To_Edit_Entity_kpi,
                            List_To_Delete = List_To_Delete
                        });
                    }
                });

                #endregion

                Task.WaitAll(edit_site, edit_entity);

                #endregion
            }
            else if (i_Params_Edit_Organization_Data_Access.Selected_Level_Setup.VALUE == "Entity")
            {
                #region Edit Entity Kpi With Children

                long? Entity_ID = 0;
                if (i_Params_Edit_Organization_Data_Access.List_To_Edit_Entity_kpi != null && i_Params_Edit_Organization_Data_Access.List_To_Edit_Entity_kpi.Count > 0)
                {
                    Entity_ID = i_Params_Edit_Organization_Data_Access.List_To_Edit_Entity_kpi[0].ENTITY_ID;
                }
                else if (i_Params_Edit_Organization_Data_Access.List_To_Delete_Entity_kpi != null && i_Params_Edit_Organization_Data_Access.List_To_Delete_Entity_kpi.Count > 0)
                {
                    Entity_ID = i_Params_Edit_Organization_Data_Access.List_To_Delete_Entity_kpi[0].ENTITY_ID;
                }
                List<int?> List_Organization_data_source_kpi_ID_To_Edit = i_Params_Edit_Organization_Data_Access.List_To_Edit_Entity_kpi.Select(oEntity_kpi => oEntity_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();
                List<int?> List_Organization_data_source_kpi_ID_To_Delete = i_Params_Edit_Organization_Data_Access.List_To_Delete_Entity_kpi.Select(oEntity_kpi => oEntity_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();

                #region Edit Entity_kpi

                var edit_entity = Task.Run(() =>
                {
                    List<long?> List_To_Delete = new List<long?>();
                    if (i_Params_Edit_Organization_Data_Access.List_To_Delete_Entity_kpi != null && i_Params_Edit_Organization_Data_Access.List_To_Delete_Entity_kpi.Count > 0)
                    {
                        List_To_Delete = i_Params_Edit_Organization_Data_Access.List_To_Delete_Entity_kpi.Select(oEntity_kpi => oEntity_kpi.ENTITY_ID).ToList();
                    }
                    Edit_Entity_kpi_List(new Params_Edit_Entity_kpi_List()
                    {
                        List_To_Edit = i_Params_Edit_Organization_Data_Access.List_To_Edit_Entity_kpi,
                        List_To_Delete = List_To_Delete
                    });
                });

                #endregion

                Task.WaitAll(edit_entity);

                #endregion
            }

            return i_Params_Edit_Organization_Data_Access;
        }
        #endregion
        #region Get_User_Data_Access
        public User_Data_Access Get_User_Data_Access(Params_Get_User_Data_Access i_Params_Get_User_Data_Access)
        {
            User_Data_Access oUser_Data_Access = new User_Data_Access();

            if (i_Params_Get_User_Data_Access.ORGANIZATION_ID != null && i_Params_Get_User_Data_Access.USER_ID != null)
            {
                #region Declaration & Initialization

                oUser_Data_Access.LIST_ORGANIZATION_DATA_SOURCE_KPI = new List<Organization_data_source_kpi>();
                oUser_Data_Access.LIST_DISTRICT = new List<District>();
                oUser_Data_Access.LIST_DISTRICT_KPI_USER_ACCESS = new List<District_kpi_user_access>();
                oUser_Data_Access.LIST_AREA = new List<Area>();
                oUser_Data_Access.LIST_AREA_KPI_USER_ACCESS = new List<Area_kpi_user_access>();
                oUser_Data_Access.LIST_SITE = new List<Site>();
                oUser_Data_Access.LIST_SITE_KPI_USER_ACCESS = new List<Site_kpi_user_access>();
                oUser_Data_Access.LIST_ENTITY = new List<Entity>();
                oUser_Data_Access.LIST_ENTITY_KPI_USER_ACCESS = new List<Entity_kpi_user_access>();

                #endregion

                #region Get Orgnization data source kpi

                oUser_Data_Access.LIST_ORGANIZATION_DATA_SOURCE_KPI = Get_Organization_data_source_kpi_By_ORGANIZATION_ID_Adv(new Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID()
                {
                    ORGANIZATION_ID = i_Params_Get_User_Data_Access.ORGANIZATION_ID
                });

                #endregion

                if (oUser_Data_Access.LIST_ORGANIZATION_DATA_SOURCE_KPI != null && oUser_Data_Access.LIST_ORGANIZATION_DATA_SOURCE_KPI.Count > 0)
                {
                    #region Get District Info

                    var get_district_info = Task.Run(() =>
                    {

                        oUser_Data_Access.LIST_DISTRICT_KPI_USER_ACCESS = Get_District_kpi_user_access_By_USER_ID(new Params_Get_District_kpi_user_access_By_USER_ID()
                        {
                            USER_ID = i_Params_Get_User_Data_Access.USER_ID
                        });

                        if (oUser_Data_Access.LIST_DISTRICT_KPI_USER_ACCESS != null && oUser_Data_Access.LIST_DISTRICT_KPI_USER_ACCESS.Count > 0)
                        {
                            List<long?> List_District_ID = oUser_Data_Access.LIST_DISTRICT_KPI_USER_ACCESS.DistinctBy(oDistrict_kpi => oDistrict_kpi.DISTRICT_ID).Select(oDistrict_kpi => oDistrict_kpi.DISTRICT_ID).ToList();
                            oUser_Data_Access.LIST_DISTRICT = Get_District_By_DISTRICT_ID_List(new Params_Get_District_By_DISTRICT_ID_List()
                            {
                                DISTRICT_ID_LIST = List_District_ID
                            });
                        }
                    });

                    #endregion

                    #region Get Area Info

                    var get_area_info = Task.Run(() =>
                    {

                        oUser_Data_Access.LIST_AREA_KPI_USER_ACCESS = Get_Area_kpi_user_access_By_USER_ID(new Params_Get_Area_kpi_user_access_By_USER_ID()
                        {
                            USER_ID = i_Params_Get_User_Data_Access.USER_ID
                        });

                        if (oUser_Data_Access.LIST_AREA_KPI_USER_ACCESS != null && oUser_Data_Access.LIST_AREA_KPI_USER_ACCESS.Count > 0)
                        {
                            List<long?> List_Area_ID = oUser_Data_Access.LIST_AREA_KPI_USER_ACCESS.DistinctBy(oArea_kpi => oArea_kpi.AREA_ID).Select(oArea_kpi => oArea_kpi.AREA_ID).ToList();
                            oUser_Data_Access.LIST_AREA = Get_Area_By_AREA_ID_List(new Params_Get_Area_By_AREA_ID_List()
                            {
                                AREA_ID_LIST = List_Area_ID
                            });
                        }
                    });

                    #endregion

                    #region Get Site Info

                    var get_site_info = Task.Run(() =>
                    {

                        oUser_Data_Access.LIST_SITE_KPI_USER_ACCESS = Get_Site_kpi_user_access_By_USER_ID(new Params_Get_Site_kpi_user_access_By_USER_ID()
                        {
                            USER_ID = i_Params_Get_User_Data_Access.USER_ID
                        });

                        if (oUser_Data_Access.LIST_SITE_KPI_USER_ACCESS != null && oUser_Data_Access.LIST_SITE_KPI_USER_ACCESS.Count > 0)
                        {
                            List<long?> List_Site_ID = oUser_Data_Access.LIST_SITE_KPI_USER_ACCESS.DistinctBy(oSite_kpi => oSite_kpi.SITE_ID).Select(oSite_kpi => oSite_kpi.SITE_ID).ToList();
                            oUser_Data_Access.LIST_SITE = Get_Site_By_SITE_ID_List(new Params_Get_Site_By_SITE_ID_List()
                            {
                                SITE_ID_LIST = List_Site_ID
                            });
                        }
                    });

                    #endregion

                    #region Get Entity Info

                    var get_entity_info = Task.Run(() =>
                    {

                        oUser_Data_Access.LIST_ENTITY_KPI_USER_ACCESS = Get_Entity_kpi_user_access_By_USER_ID(new Params_Get_Entity_kpi_user_access_By_USER_ID()
                        {
                            USER_ID = i_Params_Get_User_Data_Access.USER_ID
                        });

                        if (oUser_Data_Access.LIST_ENTITY_KPI_USER_ACCESS != null && oUser_Data_Access.LIST_ENTITY_KPI_USER_ACCESS.Count > 0)
                        {
                            List<long?> List_Entity_ID = oUser_Data_Access.LIST_ENTITY_KPI_USER_ACCESS.DistinctBy(oEntity_kpi => oEntity_kpi.ENTITY_ID).Select(oEntity_kpi => oEntity_kpi.ENTITY_ID).ToList();
                            oUser_Data_Access.LIST_ENTITY = Get_Entity_By_ENTITY_ID_List(new Params_Get_Entity_By_ENTITY_ID_List()
                            {
                                ENTITY_ID_LIST = List_Entity_ID
                            });
                        }
                    });

                    #endregion

                    Task.WaitAll(get_district_info, get_area_info, get_site_info, get_entity_info);
                }
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }

            return oUser_Data_Access;
        }
        #endregion
        #region Edit_User_Data_Access
        public Params_Edit_User_Data_Access Edit_User_Data_Access(Params_Edit_User_Data_Access i_Params_Edit_User_Data_Access)
        {
            if (i_Params_Edit_User_Data_Access.Selected_Level_Setup.VALUE == "District")
            {
                #region Edit District Kpi With Children

                long? District_ID = 0;
                long? User_ID = 0;
                if (i_Params_Edit_User_Data_Access.List_To_Edit_District_kpi_user_access != null && i_Params_Edit_User_Data_Access.List_To_Edit_District_kpi_user_access.Count > 0)
                {
                    District_ID = i_Params_Edit_User_Data_Access.List_To_Edit_District_kpi_user_access[0].DISTRICT_ID;
                    User_ID = i_Params_Edit_User_Data_Access.List_To_Edit_District_kpi_user_access[0].USER_ID;
                }
                else if (i_Params_Edit_User_Data_Access.List_To_Delete_District_kpi_user_access != null && i_Params_Edit_User_Data_Access.List_To_Delete_District_kpi_user_access.Count > 0)
                {
                    District_ID = i_Params_Edit_User_Data_Access.List_To_Delete_District_kpi_user_access[0].DISTRICT_ID;
                    User_ID = i_Params_Edit_User_Data_Access.List_To_Delete_District_kpi_user_access[0].USER_ID;
                }
                List<int?> List_Organization_data_source_kpi_user_access_ID_To_Edit = i_Params_Edit_User_Data_Access.List_To_Edit_District_kpi_user_access.Select(oDistrict_kpi_user_access => oDistrict_kpi_user_access.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();
                List<int?> List_Organization_data_source_kpi_user_access_ID_To_Delete = i_Params_Edit_User_Data_Access.List_To_Delete_District_kpi_user_access.Select(oDistrict_kpi_user_access => oDistrict_kpi_user_access.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();

                #region Edit District_kpi_user_access

                var edit_district = Task.Run(() =>
                {
                    List<long?> List_To_Delete = new List<long?>();
                    if (i_Params_Edit_User_Data_Access.List_To_Delete_District_kpi_user_access != null && i_Params_Edit_User_Data_Access.List_To_Delete_District_kpi_user_access.Count > 0)
                    {
                        List_To_Delete = i_Params_Edit_User_Data_Access.List_To_Delete_District_kpi_user_access.Select(oDistrict_kpi_user_access => oDistrict_kpi_user_access.DISTRICT_KPI_USER_ACCESS_ID).ToList();
                    }
                    Edit_District_kpi_user_access_List(new Params_Edit_District_kpi_user_access_List()
                    {
                        List_To_Edit = i_Params_Edit_User_Data_Access.List_To_Edit_District_kpi_user_access,
                        List_To_Delete = List_To_Delete
                    });
                });

                #endregion

                #region Edit Area_kpi_user_access

                var edit_area = Task.Run(() =>
                {
                    i_Params_Edit_User_Data_Access.List_To_Edit_Area_kpi_user_access = new List<Area_kpi_user_access>();
                    i_Params_Edit_User_Data_Access.List_To_Delete_Area_kpi_user_access = new List<Area_kpi_user_access>();

                    List<Area> oList_Area = new List<Area>();
                    if (District_ID != 0)
                    {
                        oList_Area = Get_Area_By_DISTRICT_ID(new Params_Get_Area_By_DISTRICT_ID() { DISTRICT_ID = District_ID });
                    }
                    if (oList_Area != null && oList_Area.Count > 0)
                    {
                        List<Area_kpi_user_access> oList_Area_kpi_user_access = Get_Area_kpi_user_access_By_AREA_ID_List(new Params_Get_Area_kpi_user_access_By_AREA_ID_List() { AREA_ID_LIST = oList_Area.Select(oArea => oArea.AREA_ID).ToList() });
                        if (oList_Area_kpi_user_access != null && oList_Area_kpi_user_access.Count > 0)
                        {
                            oList_Area_kpi_user_access = oList_Area_kpi_user_access.Where(oArea_kpi_user_access => List_Organization_data_source_kpi_user_access_ID_To_Edit.Any(Organization_data_source_kpi_user_access_ID => Organization_data_source_kpi_user_access_ID == oArea_kpi_user_access.ORGANIZATION_DATA_SOURCE_KPI_ID) ||
                                                                                List_Organization_data_source_kpi_user_access_ID_To_Delete.Any(Organization_data_source_kpi_user_access_ID => Organization_data_source_kpi_user_access_ID == oArea_kpi_user_access.ORGANIZATION_DATA_SOURCE_KPI_ID)).ToList();
                        }

                        oList_Area.ForEach(oArea =>
                        {
                            List<Area_kpi_user_access> _List_Area_kpi_user_access = new List<Area_kpi_user_access>();
                            if (oList_Area_kpi_user_access != null && oList_Area_kpi_user_access.Count > 0)
                            {
                                _List_Area_kpi_user_access = oList_Area_kpi_user_access.Where(oArea_kpi_user_access => oArea_kpi_user_access.AREA_ID == oArea.AREA_ID).ToList();
                            }
                            List_Organization_data_source_kpi_user_access_ID_To_Edit.ForEach(Organization_data_source_kpi_user_access_ID =>
                            {
                                if (_List_Area_kpi_user_access.Count == 0 || !_List_Area_kpi_user_access.Any(oArea_kpi_user_access => oArea_kpi_user_access.ORGANIZATION_DATA_SOURCE_KPI_ID == Organization_data_source_kpi_user_access_ID))
                                {
                                    i_Params_Edit_User_Data_Access.List_To_Edit_Area_kpi_user_access.Add(new Area_kpi_user_access()
                                    {
                                        AREA_KPI_USER_ACCESS_ID = -1,
                                        USER_ID = User_ID,
                                        AREA_ID = oArea.AREA_ID,
                                        ORGANIZATION_DATA_SOURCE_KPI_ID = Organization_data_source_kpi_user_access_ID
                                    });
                                }
                            });
                            List_Organization_data_source_kpi_user_access_ID_To_Delete.ForEach(Organization_data_source_kpi_user_access_ID =>
                            {
                                if (_List_Area_kpi_user_access.Count > 0 && _List_Area_kpi_user_access.Any(oArea_kpi_user_access => oArea_kpi_user_access.ORGANIZATION_DATA_SOURCE_KPI_ID == Organization_data_source_kpi_user_access_ID))
                                {
                                    Area_kpi_user_access oArea_kpi_user_access = _List_Area_kpi_user_access.Find(oArea_kpi_user_access => oArea_kpi_user_access.ORGANIZATION_DATA_SOURCE_KPI_ID == Organization_data_source_kpi_user_access_ID);
                                    i_Params_Edit_User_Data_Access.List_To_Delete_Area_kpi_user_access.Add(oArea_kpi_user_access);
                                }
                            });
                        });

                        List<long?> List_To_Delete = new List<long?>();
                        if (i_Params_Edit_User_Data_Access.List_To_Delete_Area_kpi_user_access != null && i_Params_Edit_User_Data_Access.List_To_Delete_Area_kpi_user_access.Count > 0)
                        {
                            List_To_Delete = i_Params_Edit_User_Data_Access.List_To_Delete_Area_kpi_user_access.Select(oArea_kpi_user_access => oArea_kpi_user_access.AREA_KPI_USER_ACCESS_ID).ToList();
                        }
                        Edit_Area_kpi_user_access_List(new Params_Edit_Area_kpi_user_access_List()
                        {
                            List_To_Edit = i_Params_Edit_User_Data_Access.List_To_Edit_Area_kpi_user_access,
                            List_To_Delete = List_To_Delete
                        });
                    }
                });

                #endregion

                #region Edit Site_kpi_user_access

                var edit_site = Task.Run(() =>
                {
                    i_Params_Edit_User_Data_Access.List_To_Edit_Site_kpi_user_access = new List<Site_kpi_user_access>();
                    i_Params_Edit_User_Data_Access.List_To_Delete_Site_kpi_user_access = new List<Site_kpi_user_access>();

                    List<Site> oList_Site = new List<Site>();
                    if (District_ID != 0)
                    {
                        oList_Site = Get_Site_By_DISTRICT_ID(new Params_Get_Site_By_DISTRICT_ID() { DISTRICT_ID = District_ID });
                    }
                    if (oList_Site != null && oList_Site.Count > 0)
                    {
                        List<Site_kpi_user_access> oList_Site_kpi_user_access = Get_Site_kpi_user_access_By_SITE_ID_List(new Params_Get_Site_kpi_user_access_By_SITE_ID_List() { SITE_ID_LIST = oList_Site.Select(oSite => oSite.SITE_ID).ToList() });
                        if (oList_Site_kpi_user_access != null && oList_Site_kpi_user_access.Count > 0)
                        {
                            oList_Site_kpi_user_access = oList_Site_kpi_user_access.Where(oSite_kpi_user_access => List_Organization_data_source_kpi_user_access_ID_To_Edit.Any(Organization_data_source_kpi_user_access_ID => Organization_data_source_kpi_user_access_ID == oSite_kpi_user_access.ORGANIZATION_DATA_SOURCE_KPI_ID) ||
                                                                                List_Organization_data_source_kpi_user_access_ID_To_Delete.Any(Organization_data_source_kpi_user_access_ID => Organization_data_source_kpi_user_access_ID == oSite_kpi_user_access.ORGANIZATION_DATA_SOURCE_KPI_ID)).ToList();
                        }

                        oList_Site.ForEach(oSite =>
                        {
                            List<Site_kpi_user_access> _List_Site_kpi_user_access = new List<Site_kpi_user_access>();
                            if (oList_Site_kpi_user_access != null && oList_Site_kpi_user_access.Count > 0)
                            {
                                _List_Site_kpi_user_access = oList_Site_kpi_user_access.Where(oSite_kpi_user_access => oSite_kpi_user_access.SITE_ID == oSite.SITE_ID).ToList();
                            }
                            List_Organization_data_source_kpi_user_access_ID_To_Edit.ForEach(Organization_data_source_kpi_user_access_ID =>
                            {
                                if (_List_Site_kpi_user_access.Count == 0 || !_List_Site_kpi_user_access.Any(oSite_kpi_user_access => oSite_kpi_user_access.ORGANIZATION_DATA_SOURCE_KPI_ID == Organization_data_source_kpi_user_access_ID))
                                {
                                    i_Params_Edit_User_Data_Access.List_To_Edit_Site_kpi_user_access.Add(new Site_kpi_user_access()
                                    {
                                        SITE_KPI_USER_ACCESS_ID = -1,
                                        USER_ID = User_ID,
                                        SITE_ID = oSite.SITE_ID,
                                        ORGANIZATION_DATA_SOURCE_KPI_ID = Organization_data_source_kpi_user_access_ID
                                    });
                                }
                            });
                            List_Organization_data_source_kpi_user_access_ID_To_Delete.ForEach(Organization_data_source_kpi_user_access_ID =>
                            {
                                if (_List_Site_kpi_user_access.Count > 0 && _List_Site_kpi_user_access.Any(oSite_kpi_user_access => oSite_kpi_user_access.ORGANIZATION_DATA_SOURCE_KPI_ID == Organization_data_source_kpi_user_access_ID))
                                {
                                    Site_kpi_user_access oSite_kpi_user_access = _List_Site_kpi_user_access.Find(oSite_kpi_user_access => oSite_kpi_user_access.ORGANIZATION_DATA_SOURCE_KPI_ID == Organization_data_source_kpi_user_access_ID);
                                    i_Params_Edit_User_Data_Access.List_To_Delete_Site_kpi_user_access.Add(oSite_kpi_user_access);
                                }
                            });
                        });

                        List<long?> List_To_Delete = new List<long?>();
                        if (i_Params_Edit_User_Data_Access.List_To_Delete_Site_kpi_user_access != null && i_Params_Edit_User_Data_Access.List_To_Delete_Site_kpi_user_access.Count > 0)
                        {
                            List_To_Delete = i_Params_Edit_User_Data_Access.List_To_Delete_Site_kpi_user_access.Select(oSite_kpi_user_access => oSite_kpi_user_access.SITE_KPI_USER_ACCESS_ID).ToList();
                        }
                        Edit_Site_kpi_user_access_List(new Params_Edit_Site_kpi_user_access_List()
                        {
                            List_To_Edit = i_Params_Edit_User_Data_Access.List_To_Edit_Site_kpi_user_access,
                            List_To_Delete = List_To_Delete
                        });
                    }
                });

                #endregion

                #region Edit Entity_kpi_user_access

                var edit_entity = Task.Run(() =>
                {
                    i_Params_Edit_User_Data_Access.List_To_Edit_Entity_kpi_user_access = new List<Entity_kpi_user_access>();
                    i_Params_Edit_User_Data_Access.List_To_Delete_Entity_kpi_user_access = new List<Entity_kpi_user_access>();

                    List<Entity> oList_Entity = new List<Entity>();
                    if (District_ID != 0)
                    {
                        oList_Entity = Get_Entity_By_DISTRICT_ID(new Params_Get_Entity_By_DISTRICT_ID() { DISTRICT_ID = District_ID });
                    }
                    if (oList_Entity != null && oList_Entity.Count > 0)
                    {
                        List<Entity_kpi_user_access> oList_Entity_kpi_user_access = Get_Entity_kpi_user_access_By_ENTITY_ID_List(new Params_Get_Entity_kpi_user_access_By_ENTITY_ID_List() { ENTITY_ID_LIST = oList_Entity.Select(oEntity => oEntity.ENTITY_ID).ToList() });
                        if (oList_Entity_kpi_user_access != null && oList_Entity_kpi_user_access.Count > 0)
                        {
                            oList_Entity_kpi_user_access = oList_Entity_kpi_user_access.Where(oEntity_kpi_user_access => List_Organization_data_source_kpi_user_access_ID_To_Edit.Any(Organization_data_source_kpi_user_access_ID => Organization_data_source_kpi_user_access_ID == oEntity_kpi_user_access.ORGANIZATION_DATA_SOURCE_KPI_ID) ||
                                                                                     List_Organization_data_source_kpi_user_access_ID_To_Delete.Any(Organization_data_source_kpi_user_access_ID => Organization_data_source_kpi_user_access_ID == oEntity_kpi_user_access.ORGANIZATION_DATA_SOURCE_KPI_ID)).ToList();
                        }

                        oList_Entity.ForEach(oEntity =>
                        {
                            List<Entity_kpi_user_access> _List_Entity_kpi_user_access = new List<Entity_kpi_user_access>();
                            if (oList_Entity_kpi_user_access != null && oList_Entity_kpi_user_access.Count > 0)
                            {
                                _List_Entity_kpi_user_access = oList_Entity_kpi_user_access.Where(oEntity_kpi_user_access => oEntity_kpi_user_access.ENTITY_ID == oEntity.ENTITY_ID).ToList();
                            }
                            List_Organization_data_source_kpi_user_access_ID_To_Edit.ForEach(Organization_data_source_kpi_user_access_ID =>
                            {
                                if (_List_Entity_kpi_user_access.Count == 0 || !_List_Entity_kpi_user_access.Any(oEntity_kpi_user_access => oEntity_kpi_user_access.ORGANIZATION_DATA_SOURCE_KPI_ID == Organization_data_source_kpi_user_access_ID))
                                {
                                    i_Params_Edit_User_Data_Access.List_To_Edit_Entity_kpi_user_access.Add(new Entity_kpi_user_access()
                                    {
                                        ENTITY_KPI_USER_ACCESS_ID = -1,
                                        USER_ID = User_ID,
                                        ENTITY_ID = oEntity.ENTITY_ID,
                                        ORGANIZATION_DATA_SOURCE_KPI_ID = Organization_data_source_kpi_user_access_ID
                                    });
                                }
                            });
                            List_Organization_data_source_kpi_user_access_ID_To_Delete.ForEach(Organization_data_source_kpi_user_access_ID =>
                            {
                                if (_List_Entity_kpi_user_access.Count > 0 && _List_Entity_kpi_user_access.Any(oEntity_kpi_user_access => oEntity_kpi_user_access.ORGANIZATION_DATA_SOURCE_KPI_ID == Organization_data_source_kpi_user_access_ID))
                                {
                                    Entity_kpi_user_access oEntity_kpi_user_access = _List_Entity_kpi_user_access.Find(oEntity_kpi_user_access => oEntity_kpi_user_access.ORGANIZATION_DATA_SOURCE_KPI_ID == Organization_data_source_kpi_user_access_ID);
                                    i_Params_Edit_User_Data_Access.List_To_Delete_Entity_kpi_user_access.Add(oEntity_kpi_user_access);
                                }
                            });
                        });

                        List<long?> List_To_Delete = new List<long?>();
                        if (i_Params_Edit_User_Data_Access.List_To_Delete_Entity_kpi_user_access != null && i_Params_Edit_User_Data_Access.List_To_Delete_Entity_kpi_user_access.Count > 0)
                        {
                            List_To_Delete = i_Params_Edit_User_Data_Access.List_To_Delete_Entity_kpi_user_access.Select(oEntity_kpi_user_access => oEntity_kpi_user_access.ENTITY_KPI_USER_ACCESS_ID).ToList();
                        }
                        Edit_Entity_kpi_user_access_List(new Params_Edit_Entity_kpi_user_access_List()
                        {
                            List_To_Edit = i_Params_Edit_User_Data_Access.List_To_Edit_Entity_kpi_user_access,
                            List_To_Delete = List_To_Delete
                        });
                    }
                });

                #endregion

                Task.WaitAll(edit_district, edit_area, edit_site, edit_entity);

                #endregion
            }
            else if (i_Params_Edit_User_Data_Access.Selected_Level_Setup.VALUE == "Area")
            {
                #region Edit Area Kpi With Children

                long? Area_ID = 0;
                long? User_ID = 0;
                if (i_Params_Edit_User_Data_Access.List_To_Edit_Area_kpi_user_access != null && i_Params_Edit_User_Data_Access.List_To_Edit_Area_kpi_user_access.Count > 0)
                {
                    Area_ID = i_Params_Edit_User_Data_Access.List_To_Edit_Area_kpi_user_access[0].AREA_ID;
                    User_ID = i_Params_Edit_User_Data_Access.List_To_Edit_Area_kpi_user_access[0].USER_ID;
                }
                else if (i_Params_Edit_User_Data_Access.List_To_Delete_Area_kpi_user_access != null && i_Params_Edit_User_Data_Access.List_To_Delete_Area_kpi_user_access.Count > 0)
                {
                    Area_ID = i_Params_Edit_User_Data_Access.List_To_Delete_Area_kpi_user_access[0].AREA_ID;
                    User_ID = i_Params_Edit_User_Data_Access.List_To_Delete_Area_kpi_user_access[0].USER_ID;
                }
                List<int?> List_Organization_data_source_kpi_user_access_ID_To_Edit = i_Params_Edit_User_Data_Access.List_To_Edit_Area_kpi_user_access.Select(oArea_kpi_user_access => oArea_kpi_user_access.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();
                List<int?> List_Organization_data_source_kpi_user_access_ID_To_Delete = i_Params_Edit_User_Data_Access.List_To_Delete_Area_kpi_user_access.Select(oArea_kpi_user_access => oArea_kpi_user_access.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();

                #region Edit Area_kpi_user_access

                var edit_area = Task.Run(() =>
                {
                    List<long?> List_To_Delete = new List<long?>();
                    if (i_Params_Edit_User_Data_Access.List_To_Delete_Area_kpi_user_access != null && i_Params_Edit_User_Data_Access.List_To_Delete_Area_kpi_user_access.Count > 0)
                    {
                        List_To_Delete = i_Params_Edit_User_Data_Access.List_To_Delete_Area_kpi_user_access.Select(oArea_kpi_user_access => oArea_kpi_user_access.AREA_KPI_USER_ACCESS_ID).ToList();
                    }
                    Edit_Area_kpi_user_access_List(new Params_Edit_Area_kpi_user_access_List()
                    {
                        List_To_Edit = i_Params_Edit_User_Data_Access.List_To_Edit_Area_kpi_user_access,
                        List_To_Delete = List_To_Delete
                    });
                });

                #endregion

                #region Edit Site_kpi_user_access

                var edit_site = Task.Run(() =>
                {
                    i_Params_Edit_User_Data_Access.List_To_Edit_Site_kpi_user_access = new List<Site_kpi_user_access>();
                    i_Params_Edit_User_Data_Access.List_To_Delete_Site_kpi_user_access = new List<Site_kpi_user_access>();

                    List<Site> oList_Site = new List<Site>();
                    if (Area_ID != 0)
                    {
                        oList_Site = Get_Site_By_AREA_ID(new Params_Get_Site_By_AREA_ID() { AREA_ID = Area_ID });
                    }
                    if (oList_Site != null && oList_Site.Count > 0)
                    {
                        List<Site_kpi_user_access> oList_Site_kpi_user_access = Get_Site_kpi_user_access_By_SITE_ID_List(new Params_Get_Site_kpi_user_access_By_SITE_ID_List() { SITE_ID_LIST = oList_Site.Select(oSite => oSite.SITE_ID).ToList() });
                        if (oList_Site_kpi_user_access != null && oList_Site_kpi_user_access.Count > 0)
                        {
                            oList_Site_kpi_user_access = oList_Site_kpi_user_access.Where(oSite_kpi_user_access => List_Organization_data_source_kpi_user_access_ID_To_Edit.Any(Organization_data_source_kpi_user_access_ID => Organization_data_source_kpi_user_access_ID == oSite_kpi_user_access.ORGANIZATION_DATA_SOURCE_KPI_ID) ||
                                                                               List_Organization_data_source_kpi_user_access_ID_To_Delete.Any(Organization_data_source_kpi_user_access_ID => Organization_data_source_kpi_user_access_ID == oSite_kpi_user_access.ORGANIZATION_DATA_SOURCE_KPI_ID)).ToList();
                        }

                        oList_Site.ForEach(oSite =>
                        {
                            List<Site_kpi_user_access> _List_Site_kpi_user_access = new List<Site_kpi_user_access>();
                            if (oList_Site_kpi_user_access != null && oList_Site_kpi_user_access.Count > 0)
                            {
                                _List_Site_kpi_user_access = oList_Site_kpi_user_access.Where(oSite_kpi_user_access => oSite_kpi_user_access.SITE_ID == oSite.SITE_ID).ToList();
                            }
                            List_Organization_data_source_kpi_user_access_ID_To_Edit.ForEach(Organization_data_source_kpi_user_access_ID =>
                            {
                                if (_List_Site_kpi_user_access.Count == 0 || !_List_Site_kpi_user_access.Any(oSite_kpi_user_access => oSite_kpi_user_access.ORGANIZATION_DATA_SOURCE_KPI_ID == Organization_data_source_kpi_user_access_ID))
                                {
                                    i_Params_Edit_User_Data_Access.List_To_Edit_Site_kpi_user_access.Add(new Site_kpi_user_access()
                                    {
                                        SITE_KPI_USER_ACCESS_ID = -1,
                                        USER_ID = User_ID,
                                        SITE_ID = oSite.SITE_ID,
                                        ORGANIZATION_DATA_SOURCE_KPI_ID = Organization_data_source_kpi_user_access_ID
                                    });
                                }
                            });
                            List_Organization_data_source_kpi_user_access_ID_To_Delete.ForEach(Organization_data_source_kpi_user_access_ID =>
                            {
                                if (_List_Site_kpi_user_access.Count > 0 && _List_Site_kpi_user_access.Any(oSite_kpi_user_access => oSite_kpi_user_access.ORGANIZATION_DATA_SOURCE_KPI_ID == Organization_data_source_kpi_user_access_ID))
                                {
                                    Site_kpi_user_access oSite_kpi_user_access = _List_Site_kpi_user_access.Find(oSite_kpi_user_access => oSite_kpi_user_access.ORGANIZATION_DATA_SOURCE_KPI_ID == Organization_data_source_kpi_user_access_ID);
                                    i_Params_Edit_User_Data_Access.List_To_Delete_Site_kpi_user_access.Add(oSite_kpi_user_access);
                                }
                            });
                        });

                        List<long?> List_To_Delete = new List<long?>();
                        if (i_Params_Edit_User_Data_Access.List_To_Delete_Site_kpi_user_access != null && i_Params_Edit_User_Data_Access.List_To_Delete_Site_kpi_user_access.Count > 0)
                        {
                            List_To_Delete = i_Params_Edit_User_Data_Access.List_To_Delete_Site_kpi_user_access.Select(oSite_kpi_user_access => oSite_kpi_user_access.SITE_KPI_USER_ACCESS_ID).ToList();
                        }
                        Edit_Site_kpi_user_access_List(new Params_Edit_Site_kpi_user_access_List()
                        {
                            List_To_Edit = i_Params_Edit_User_Data_Access.List_To_Edit_Site_kpi_user_access,
                            List_To_Delete = List_To_Delete
                        });
                    }
                });

                #endregion

                #region Edit Entity_kpi_user_access

                var edit_entity = Task.Run(() =>
                {
                    i_Params_Edit_User_Data_Access.List_To_Edit_Entity_kpi_user_access = new List<Entity_kpi_user_access>();
                    i_Params_Edit_User_Data_Access.List_To_Delete_Entity_kpi_user_access = new List<Entity_kpi_user_access>();

                    List<Entity> oList_Entity = new List<Entity>();
                    if (Area_ID != 0)
                    {
                        oList_Entity = Get_Entity_By_AREA_ID(new Params_Get_Entity_By_AREA_ID() { AREA_ID = Area_ID });
                    }
                    if (oList_Entity != null && oList_Entity.Count > 0)
                    {
                        List<Entity_kpi_user_access> oList_Entity_kpi_user_access = Get_Entity_kpi_user_access_By_ENTITY_ID_List(new Params_Get_Entity_kpi_user_access_By_ENTITY_ID_List() { ENTITY_ID_LIST = oList_Entity.Select(oEntity => oEntity.ENTITY_ID).ToList() });
                        if (oList_Entity_kpi_user_access != null && oList_Entity_kpi_user_access.Count > 0)
                        {
                            oList_Entity_kpi_user_access = oList_Entity_kpi_user_access.Where(oEntity_kpi_user_access => List_Organization_data_source_kpi_user_access_ID_To_Edit.Any(Organization_data_source_kpi_user_access_ID => Organization_data_source_kpi_user_access_ID == oEntity_kpi_user_access.ORGANIZATION_DATA_SOURCE_KPI_ID) ||
                                                                                     List_Organization_data_source_kpi_user_access_ID_To_Delete.Any(Organization_data_source_kpi_user_access_ID => Organization_data_source_kpi_user_access_ID == oEntity_kpi_user_access.ORGANIZATION_DATA_SOURCE_KPI_ID)).ToList();
                        }

                        oList_Entity.ForEach(oEntity =>
                        {
                            List<Entity_kpi_user_access> _List_Entity_kpi_user_access = new List<Entity_kpi_user_access>();
                            if (oList_Entity_kpi_user_access != null && oList_Entity_kpi_user_access.Count > 0)
                            {
                                _List_Entity_kpi_user_access = oList_Entity_kpi_user_access.Where(oEntity_kpi_user_access => oEntity_kpi_user_access.ENTITY_ID == oEntity.ENTITY_ID).ToList();
                            }
                            List_Organization_data_source_kpi_user_access_ID_To_Edit.ForEach(Organization_data_source_kpi_user_access_ID =>
                            {
                                if (_List_Entity_kpi_user_access.Count == 0 || !_List_Entity_kpi_user_access.Any(oEntity_kpi_user_access => oEntity_kpi_user_access.ORGANIZATION_DATA_SOURCE_KPI_ID == Organization_data_source_kpi_user_access_ID))
                                {
                                    i_Params_Edit_User_Data_Access.List_To_Edit_Entity_kpi_user_access.Add(new Entity_kpi_user_access()
                                    {
                                        ENTITY_KPI_USER_ACCESS_ID = -1,
                                        USER_ID = User_ID,
                                        ENTITY_ID = oEntity.ENTITY_ID,
                                        ORGANIZATION_DATA_SOURCE_KPI_ID = Organization_data_source_kpi_user_access_ID
                                    });
                                }
                            });
                            List_Organization_data_source_kpi_user_access_ID_To_Delete.ForEach(Organization_data_source_kpi_user_access_ID =>
                            {
                                if (_List_Entity_kpi_user_access.Count > 0 && _List_Entity_kpi_user_access.Any(oEntity_kpi_user_access => oEntity_kpi_user_access.ORGANIZATION_DATA_SOURCE_KPI_ID == Organization_data_source_kpi_user_access_ID))
                                {
                                    Entity_kpi_user_access oEntity_kpi_user_access = _List_Entity_kpi_user_access.Find(oEntity_kpi_user_access => oEntity_kpi_user_access.ORGANIZATION_DATA_SOURCE_KPI_ID == Organization_data_source_kpi_user_access_ID);
                                    i_Params_Edit_User_Data_Access.List_To_Delete_Entity_kpi_user_access.Add(oEntity_kpi_user_access);
                                }
                            });
                        });

                        List<long?> List_To_Delete = new List<long?>();
                        if (i_Params_Edit_User_Data_Access.List_To_Delete_Entity_kpi_user_access != null && i_Params_Edit_User_Data_Access.List_To_Delete_Entity_kpi_user_access.Count > 0)
                        {
                            List_To_Delete = i_Params_Edit_User_Data_Access.List_To_Delete_Entity_kpi_user_access.Select(oEntity_kpi_user_access => oEntity_kpi_user_access.ENTITY_KPI_USER_ACCESS_ID).ToList();
                        }
                        Edit_Entity_kpi_user_access_List(new Params_Edit_Entity_kpi_user_access_List()
                        {
                            List_To_Edit = i_Params_Edit_User_Data_Access.List_To_Edit_Entity_kpi_user_access,
                            List_To_Delete = List_To_Delete
                        });
                    }
                });

                #endregion

                Task.WaitAll(edit_area, edit_site, edit_entity);

                #endregion
            }
            else if (i_Params_Edit_User_Data_Access.Selected_Level_Setup.VALUE == "Site")
            {
                #region Edit Site Kpi With Children

                long? Site_ID = 0;
                long? User_ID = 0;
                if (i_Params_Edit_User_Data_Access.List_To_Edit_Site_kpi_user_access != null && i_Params_Edit_User_Data_Access.List_To_Edit_Site_kpi_user_access.Count > 0)
                {
                    Site_ID = i_Params_Edit_User_Data_Access.List_To_Edit_Site_kpi_user_access[0].SITE_ID;
                    User_ID = i_Params_Edit_User_Data_Access.List_To_Edit_Site_kpi_user_access[0].USER_ID;
                }
                else if (i_Params_Edit_User_Data_Access.List_To_Delete_Site_kpi_user_access != null && i_Params_Edit_User_Data_Access.List_To_Delete_Site_kpi_user_access.Count > 0)
                {
                    Site_ID = i_Params_Edit_User_Data_Access.List_To_Delete_Site_kpi_user_access[0].SITE_ID;
                    User_ID = i_Params_Edit_User_Data_Access.List_To_Delete_Site_kpi_user_access[0].USER_ID;
                }
                List<int?> List_Organization_data_source_kpi_user_access_ID_To_Edit = i_Params_Edit_User_Data_Access.List_To_Edit_Site_kpi_user_access.Select(oSite_kpi_user_access => oSite_kpi_user_access.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();
                List<int?> List_Organization_data_source_kpi_user_access_ID_To_Delete = i_Params_Edit_User_Data_Access.List_To_Delete_Site_kpi_user_access.Select(oSite_kpi_user_access => oSite_kpi_user_access.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();

                #region Edit Site_kpi_user_access

                var edit_site = Task.Run(() =>
                {
                    List<long?> List_To_Delete = new List<long?>();
                    if (i_Params_Edit_User_Data_Access.List_To_Delete_Site_kpi_user_access != null && i_Params_Edit_User_Data_Access.List_To_Delete_Site_kpi_user_access.Count > 0)
                    {
                        List_To_Delete = i_Params_Edit_User_Data_Access.List_To_Delete_Site_kpi_user_access.Select(oSite_kpi_user_access => oSite_kpi_user_access.SITE_KPI_USER_ACCESS_ID).ToList();
                    }
                    Edit_Site_kpi_user_access_List(new Params_Edit_Site_kpi_user_access_List()
                    {
                        List_To_Edit = i_Params_Edit_User_Data_Access.List_To_Edit_Site_kpi_user_access,
                        List_To_Delete = List_To_Delete
                    });
                });

                #endregion

                #region Edit Entity_kpi_user_access

                var edit_entity = Task.Run(() =>
                {
                    i_Params_Edit_User_Data_Access.List_To_Edit_Entity_kpi_user_access = new List<Entity_kpi_user_access>();
                    i_Params_Edit_User_Data_Access.List_To_Delete_Entity_kpi_user_access = new List<Entity_kpi_user_access>();

                    List<Entity> oList_Entity = new List<Entity>();
                    if (Site_ID != 0)
                    {
                        oList_Entity = Get_Entity_By_SITE_ID(new Params_Get_Entity_By_SITE_ID() { SITE_ID = Site_ID });
                    }
                    if (oList_Entity != null && oList_Entity.Count > 0)
                    {
                        List<Entity_kpi_user_access> oList_Entity_kpi_user_access = Get_Entity_kpi_user_access_By_ENTITY_ID_List(new Params_Get_Entity_kpi_user_access_By_ENTITY_ID_List() { ENTITY_ID_LIST = oList_Entity.Select(oEntity => oEntity.ENTITY_ID).ToList() });
                        if (oList_Entity_kpi_user_access != null && oList_Entity_kpi_user_access.Count > 0)
                        {
                            oList_Entity_kpi_user_access = oList_Entity_kpi_user_access.Where(oEntity_kpi_user_access => List_Organization_data_source_kpi_user_access_ID_To_Edit.Any(Organization_data_source_kpi_user_access_ID => Organization_data_source_kpi_user_access_ID == oEntity_kpi_user_access.ORGANIZATION_DATA_SOURCE_KPI_ID) ||
                                                                                     List_Organization_data_source_kpi_user_access_ID_To_Delete.Any(Organization_data_source_kpi_user_access_ID => Organization_data_source_kpi_user_access_ID == oEntity_kpi_user_access.ORGANIZATION_DATA_SOURCE_KPI_ID)).ToList();
                        }

                        oList_Entity.ForEach(oEntity =>
                        {
                            List<Entity_kpi_user_access> _List_Entity_kpi_user_access = new List<Entity_kpi_user_access>();
                            if (oList_Entity_kpi_user_access != null && oList_Entity_kpi_user_access.Count > 0)
                            {
                                _List_Entity_kpi_user_access = oList_Entity_kpi_user_access.Where(oEntity_kpi_user_access => oEntity_kpi_user_access.ENTITY_ID == oEntity.ENTITY_ID).ToList();
                            }
                            List_Organization_data_source_kpi_user_access_ID_To_Edit.ForEach(Organization_data_source_kpi_user_access_ID =>
                            {
                                if (_List_Entity_kpi_user_access.Count == 0 || !_List_Entity_kpi_user_access.Any(oEntity_kpi_user_access => oEntity_kpi_user_access.ORGANIZATION_DATA_SOURCE_KPI_ID == Organization_data_source_kpi_user_access_ID))
                                {
                                    i_Params_Edit_User_Data_Access.List_To_Edit_Entity_kpi_user_access.Add(new Entity_kpi_user_access()
                                    {
                                        ENTITY_KPI_USER_ACCESS_ID = -1,
                                        USER_ID = User_ID,
                                        ENTITY_ID = oEntity.ENTITY_ID,
                                        ORGANIZATION_DATA_SOURCE_KPI_ID = Organization_data_source_kpi_user_access_ID
                                    });
                                }
                            });
                            List_Organization_data_source_kpi_user_access_ID_To_Delete.ForEach(Organization_data_source_kpi_user_access_ID =>
                            {
                                if (_List_Entity_kpi_user_access.Count > 0 && _List_Entity_kpi_user_access.Any(oEntity_kpi_user_access => oEntity_kpi_user_access.ORGANIZATION_DATA_SOURCE_KPI_ID == Organization_data_source_kpi_user_access_ID))
                                {
                                    Entity_kpi_user_access oEntity_kpi_user_access = _List_Entity_kpi_user_access.Find(oEntity_kpi_user_access => oEntity_kpi_user_access.ORGANIZATION_DATA_SOURCE_KPI_ID == Organization_data_source_kpi_user_access_ID);
                                    i_Params_Edit_User_Data_Access.List_To_Delete_Entity_kpi_user_access.Add(oEntity_kpi_user_access);
                                }
                            });
                        });

                        List<long?> List_To_Delete = new List<long?>();
                        if (i_Params_Edit_User_Data_Access.List_To_Delete_Entity_kpi_user_access != null && i_Params_Edit_User_Data_Access.List_To_Delete_Entity_kpi_user_access.Count > 0)
                        {
                            List_To_Delete = i_Params_Edit_User_Data_Access.List_To_Delete_Entity_kpi_user_access.Select(oEntity_kpi_user_access => oEntity_kpi_user_access.ENTITY_KPI_USER_ACCESS_ID).ToList();
                        }
                        Edit_Entity_kpi_user_access_List(new Params_Edit_Entity_kpi_user_access_List()
                        {
                            List_To_Edit = i_Params_Edit_User_Data_Access.List_To_Edit_Entity_kpi_user_access,
                            List_To_Delete = List_To_Delete
                        });
                    }
                });

                #endregion

                Task.WaitAll(edit_site, edit_entity);

                #endregion
            }
            else if (i_Params_Edit_User_Data_Access.Selected_Level_Setup.VALUE == "Entity")
            {
                #region Edit Entity Kpi With Children

                long? Entity_ID = 0;
                if (i_Params_Edit_User_Data_Access.List_To_Edit_Entity_kpi_user_access != null && i_Params_Edit_User_Data_Access.List_To_Edit_Entity_kpi_user_access.Count > 0)
                {
                    Entity_ID = i_Params_Edit_User_Data_Access.List_To_Edit_Entity_kpi_user_access[0].ENTITY_ID;
                }
                else if (i_Params_Edit_User_Data_Access.List_To_Delete_Entity_kpi_user_access != null && i_Params_Edit_User_Data_Access.List_To_Delete_Entity_kpi_user_access.Count > 0)
                {
                    Entity_ID = i_Params_Edit_User_Data_Access.List_To_Delete_Entity_kpi_user_access[0].ENTITY_ID;
                }
                List<int?> List_Organization_data_source_kpi_user_access_ID_To_Edit = i_Params_Edit_User_Data_Access.List_To_Edit_Entity_kpi_user_access.Select(oEntity_kpi_user_access => oEntity_kpi_user_access.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();
                List<int?> List_Organization_data_source_kpi_user_access_ID_To_Delete = i_Params_Edit_User_Data_Access.List_To_Delete_Entity_kpi_user_access.Select(oEntity_kpi_user_access => oEntity_kpi_user_access.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();

                #region Edit Entity_kpi_user_access

                var edit_entity = Task.Run(() =>
                {
                    List<long?> List_To_Delete = new List<long?>();
                    if (i_Params_Edit_User_Data_Access.List_To_Delete_Entity_kpi_user_access != null && i_Params_Edit_User_Data_Access.List_To_Delete_Entity_kpi_user_access.Count > 0)
                    {
                        List_To_Delete = i_Params_Edit_User_Data_Access.List_To_Delete_Entity_kpi_user_access.Select(oEntity_kpi_user_access => oEntity_kpi_user_access.ENTITY_ID).ToList();
                    }
                    Edit_Entity_kpi_user_access_List(new Params_Edit_Entity_kpi_user_access_List()
                    {
                        List_To_Edit = i_Params_Edit_User_Data_Access.List_To_Edit_Entity_kpi_user_access,
                        List_To_Delete = List_To_Delete
                    });
                });

                #endregion

                Task.WaitAll(edit_entity);

                #endregion
            }

            return i_Params_Edit_User_Data_Access;
        }
        #endregion

        #region Get_Latest_Wifi_signals
        public List<Wifi_signal> Get_Latest_Wifi_signals(Params_Get_Latest_Wifi_signals i_Params_Get_Latest_Wifi_signals)
        {
            try
            {
                return Props.Copy_Prop_Values_From_Api_Response<List<Wifi_signal>>(this._MongoDb.Get_Latest_Wifi_signal
                (
                    FLOOR_ID: i_Params_Get_Latest_Wifi_signals.FLOOR_ID,
                    SPACE_ID_LIST: i_Params_Get_Latest_Wifi_signals.SPACE_ID_LIST,
                    NUMBER_OF_POINTS: i_Params_Get_Latest_Wifi_signals.NUMBER_OF_POINTS,
                    SPACE_ASSET_ID_LIST: i_Params_Get_Latest_Wifi_signals.SPACE_ASSET_ID_LIST
                ));
            }
            catch (Exception)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0052)); // An error has occured, please try again later
            }
        }
        #endregion
        #region Get_Wifi_signals
        public List<Wifi_signal> Get_Wifi_signals(Params_Get_Wifi_signals i_Params_Get_Wifi_signals)
        {
            try
            {
                return Props.Copy_Prop_Values_From_Api_Response<List<Wifi_signal>>(this._MongoDb.Get_Wifi_signal_By_Where
                (
                    START_DATE: i_Params_Get_Wifi_signals.START_DATE,
                    END_DATE: i_Params_Get_Wifi_signals.END_DATE,
                    FLOOR_ID: i_Params_Get_Wifi_signals.FLOOR_ID,
                    SPACE_ID_LIST: i_Params_Get_Wifi_signals.SPACE_ID_LIST,
                    SPACE_ASSET_ID_LIST: i_Params_Get_Wifi_signals.SPACE_ASSET_ID_LIST
                ));
            }
            catch
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0052)); // An error has occured, please try again later
            }
        }
        #endregion
        #region Delete_Wifi_signal
        public void Delete_Wifi_signal(Params_Delete_Wifi_signal i_Params_Delete_Wifi_signal)
        {
            this._MongoDb.Delete_Wifi_signal
            (
                FLOOR_ID: i_Params_Delete_Wifi_signal.FLOOR_ID,
                SPACE_ID_LIST: i_Params_Delete_Wifi_signal.SPACE_ID_LIST,
                SPACE_ASSET_ID_LIST: i_Params_Delete_Wifi_signal.SPACE_ASSET_ID_LIST
            );
        }
        #endregion
        #region Edit_Wifi_signal_List
        public void Edit_Wifi_signal_List(Params_Edit_Wifi_signal_List i_Params_Edit_Wifi_signal_List)
        {
            this._MongoDb.Edit_Wifi_signal_List(i_Params_Edit_Wifi_signal_List.List_Wifi_signal.Select(wifi_signal =>
            {
                return new DALC.Wifi_signal()
                {
                    RECORD_DATE = wifi_signal.RECORD_DATE,
                    VALUE = wifi_signal.VALUE,
                    VALUE_NAME = wifi_signal.VALUE_NAME,
                    WIFI_SIGNAL_METADATA = new DALC.Wifi_signal_Metadata()
                    {
                        SPACE_ID = wifi_signal.WIFI_SIGNAL_METADATA.SPACE_ID,
                        FLOOR_ID = wifi_signal.WIFI_SIGNAL_METADATA.FLOOR_ID,
                        SPACE_ASSET_ID = wifi_signal.WIFI_SIGNAL_METADATA.SPACE_ASSET_ID,
                    },
                };
            }).ToList());
        }
        #endregion
        #region Get_And_Save_Wifi_Signal_From_Api
        public void Get_And_Save_Wifi_Signal_From_Api()
        {
            List<Space_asset> oList_Space_asset = Get_Space_asset_By_IS_MERAKI_WIFI_SIGNAL_Adv(new Params_Get_Space_asset_By_IS_MERAKI_WIFI_SIGNAL()
            {
                IS_MERAKI_WIFI_SIGNAL = true
            });
            List<Wifi_signal> oList_Latest_Wifi_signal = Get_Latest_Wifi_signals(new Params_Get_Latest_Wifi_signals()
            {
                SPACE_ASSET_ID_LIST = oList_Space_asset.Select(space_asset => space_asset.SPACE_ASSET_ID).ToList(),
                NUMBER_OF_POINTS = 1,
            });
            List<Wifi_signal_alert> oList_Wifi_signal_alert = Get_Wifi_signal_alerts(new Params_Get_Wifi_signal_alerts()
            {
                IS_RESOLVED = false,
            });

            List<Wifi_signal> oList_Wifi_signal = new List<Wifi_signal>();
            Parallel.ForEach(oList_Space_asset, space_asset =>
            {
                if (space_asset.EXTERNAL_ID != null)
                {
                    string url = $"https://api.meraki.com/api/v1/networks/L_580401401977380117/wireless/clients/{space_asset.EXTERNAL_ID}/connectivityEvents";
                    var client = new RestClient(url);
                    var request = new RestRequest(url, Method.Get);
                    request.AddHeader("Content-Type", "application/json");
                    request.AddHeader("Accept", "application/json");
                    request.AddHeader("X-Cisco-Meraki-API-Key", "7ec0b07b62ba9ee3f7e3e6fdb18e8951b2a1bead");
                    Wifi_signal oWifi_signal = oList_Latest_Wifi_signal.Find(wifi_signal => wifi_signal.WIFI_SIGNAL_METADATA.SPACE_ASSET_ID == space_asset.SPACE_ASSET_ID);
                    if (oWifi_signal != null)
                    {
                        request.AddQueryParameter("t0", oWifi_signal.RECORD_DATE.Value.AddSeconds(1).ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ss.sssZ"));
                    }
                    request.AddQueryParameter("types[]", "connection");
                    RestResponse response = client.Execute(request);
                    if (response.StatusCode == 0)
                    {
                        throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0034)); // This feature is currently unavailable
                    }
                    List<dynamic> wifi_signals = JsonConvert.DeserializeObject<List<dynamic>>(response.Content).ToList();

                    wifi_signals.ForEach(wifi_signal =>
                    {
                        DateTime oRecord_date = wifi_signal.occurredAt;
                        try
                        {
                            oRecord_date = DateTime.SpecifyKind(oRecord_date, DateTimeKind.Utc);
                        }
                        catch { }
                        Wifi_signal oWifi_signal = new Wifi_signal()
                        {
                            RECORD_DATE = oRecord_date,
                            VALUE_NAME = oRecord_date.ToString(),
                            VALUE = wifi_signal.rssi * -1,
                            WIFI_SIGNAL_METADATA = new Wifi_signal_Metadata()
                            {
                                SPACE_ASSET_ID = space_asset.SPACE_ASSET_ID,
                                SPACE_ID = space_asset.SPACE_ID,
                                FLOOR_ID = space_asset.Space.FLOOR_ID
                            },
                        };
                        oList_Wifi_signal.Add(oWifi_signal);

                        Wifi_signal_alert oWifi_signal_alert = oList_Wifi_signal_alert.FindLast(wifi_signal_alert => wifi_signal_alert != null && wifi_signal_alert.IS_RESOLVED == false && wifi_signal_alert.SPACE_ASSET_ID == oWifi_signal.WIFI_SIGNAL_METADATA.SPACE_ASSET_ID);
                        if (oWifi_signal_alert != null)
                        {
                            if (oWifi_signal.VALUE >= -80)
                            {
                                oWifi_signal_alert.IS_RESOLVED = true;
                                oWifi_signal_alert.END_DATE = oWifi_signal.RECORD_DATE;
                                oWifi_signal_alert.RESOLVE_VALUE = oWifi_signal.VALUE;
                            }
                        }
                        else
                        {
                            if (oWifi_signal.VALUE < -80)
                            {
                                oList_Wifi_signal_alert.Add(new Wifi_signal_alert()
                                {
                                    START_DATE = oWifi_signal.RECORD_DATE,
                                    END_DATE = null,
                                    FLOOR_ID = oWifi_signal.WIFI_SIGNAL_METADATA.FLOOR_ID,
                                    SPACE_ID = oWifi_signal.WIFI_SIGNAL_METADATA.SPACE_ID,
                                    SPACE_ASSET_ID = oWifi_signal.WIFI_SIGNAL_METADATA.SPACE_ASSET_ID,
                                    IS_RESOLVED = false,
                                    ALERT_VALUE = oWifi_signal.VALUE,
                                });
                            }
                        }
                    });
                }
                else
                {
                    DateTime oDateTime_Now = DateTime.UtcNow;
                    Wifi_signal oWifi_signal = new Wifi_signal()
                    {
                        RECORD_DATE = oDateTime_Now,
                        VALUE_NAME = oDateTime_Now.ToString(),
                        VALUE = Tools.Get_Random_Number(-101, -1),
                        WIFI_SIGNAL_METADATA = new Wifi_signal_Metadata()
                        {
                            SPACE_ASSET_ID = space_asset.SPACE_ASSET_ID,
                            SPACE_ID = space_asset.SPACE_ID,
                            FLOOR_ID = space_asset.Space.FLOOR_ID
                        },
                    };
                    oList_Wifi_signal.Add(oWifi_signal);

                    Wifi_signal_alert oWifi_signal_alert = oList_Wifi_signal_alert.FindLast(wifi_signal_alert => wifi_signal_alert != null && wifi_signal_alert.IS_RESOLVED == false && wifi_signal_alert.SPACE_ASSET_ID == oWifi_signal.WIFI_SIGNAL_METADATA.SPACE_ASSET_ID);
                    if (oWifi_signal_alert != null)
                    {
                        if (oWifi_signal.VALUE >= -80)
                        {
                            oWifi_signal_alert.IS_RESOLVED = true;
                            oWifi_signal_alert.END_DATE = oWifi_signal.RECORD_DATE;
                            oWifi_signal_alert.RESOLVE_VALUE = oWifi_signal.VALUE;
                        }
                    }
                    else
                    {
                        if (oWifi_signal.VALUE < -80)
                        {
                            oList_Wifi_signal_alert.Add(new Wifi_signal_alert()
                            {
                                START_DATE = oWifi_signal.RECORD_DATE,
                                END_DATE = null,
                                FLOOR_ID = oWifi_signal.WIFI_SIGNAL_METADATA.FLOOR_ID,
                                SPACE_ID = oWifi_signal.WIFI_SIGNAL_METADATA.SPACE_ID,
                                SPACE_ASSET_ID = oWifi_signal.WIFI_SIGNAL_METADATA.SPACE_ASSET_ID,
                                IS_RESOLVED = false,
                                ALERT_VALUE = oWifi_signal.VALUE,
                            });
                        }
                    }
                }
            });

            Edit_Wifi_signal_List(new Params_Edit_Wifi_signal_List()
            {
                List_Wifi_signal = oList_Wifi_signal
            });
            Edit_Wifi_signal_alert_List(new Params_Edit_Wifi_signal_alert_List()
            {
                List_Wifi_signal_alert = oList_Wifi_signal_alert
            });
        }
        #endregion
        #region Get_Strongest_Wifi_signal
        public Best_And_Worst_Object Get_Strongest_Wifi_signal(Params_Get_Strongest_Wifi_signal i_Params_Get_Strongest_Wifi_signal)
        {
            try
            {
                List<Entity> oList_Entity = Get_Entity_By_TOP_LEVEL_ID(new Params_Get_Entity_By_TOP_LEVEL_ID()
                {
                    TOP_LEVEL_ID = i_Params_Get_Strongest_Wifi_signal.TOP_LEVEL_ID
                });
                List<Wifi_signal> oList_Wifi_signal = Props.Copy_Prop_Values_From_Api_Response<List<Wifi_signal>>(this._MongoDb.Get_Strongest_Wifi_signal
                (
                    START_DATE: i_Params_Get_Strongest_Wifi_signal.START_DATE,
                    END_DATE: i_Params_Get_Strongest_Wifi_signal.END_DATE,
                    FLOOR_ID_LIST: oList_Entity.SelectMany(entity => entity.List_Floor.Select(floor => floor.FLOOR_ID)).ToList(),
                    SPACE_ID_LIST: null,
                    SPACE_ASSET_ID_LIST: null
                )).OrderBy(wifi_signal => wifi_signal.VALUE).ToList();
                Wifi_signal oBest_Performing_wifi_signal = oList_Wifi_signal.FirstOrDefault();
                Floor oBest_Floor = oList_Entity.SelectMany(entity => entity.List_Floor).ToList().Find(floor => floor.FLOOR_ID == oBest_Performing_wifi_signal.WIFI_SIGNAL_METADATA.FLOOR_ID);
                Performance_object oMost_Performance_object = new Performance_object()
                {
                    Entity = oList_Entity.Find(entity => entity.ENTITY_ID == oBest_Floor.ENTITY_ID),
                    Floor = oBest_Floor,
                    value = oBest_Performing_wifi_signal.VALUE,
                    Space = Get_Space_By_SPACE_ID(new Params_Get_Space_By_SPACE_ID()
                    {
                        SPACE_ID = oBest_Performing_wifi_signal.WIFI_SIGNAL_METADATA.SPACE_ID,
                    }),
                    Space_asset = Get_Space_asset_By_SPACE_ASSET_ID(new Params_Get_Space_asset_By_SPACE_ASSET_ID()
                    {
                        SPACE_ASSET_ID = oBest_Performing_wifi_signal.WIFI_SIGNAL_METADATA.SPACE_ASSET_ID,
                    })
                };

                Wifi_signal oWorst_Performing_wifi_signal = oList_Wifi_signal.LastOrDefault();
                Floor oWorst_Floor = oList_Entity.SelectMany(entity => entity.List_Floor).ToList().Find(floor => floor.FLOOR_ID == oWorst_Performing_wifi_signal.WIFI_SIGNAL_METADATA.FLOOR_ID);
                Performance_object oWorst_Performance_object = new Performance_object()
                {
                    Entity = oList_Entity.Find(entity => entity.ENTITY_ID == oWorst_Floor.ENTITY_ID),
                    Floor = oWorst_Floor,
                    value = oWorst_Performing_wifi_signal.VALUE,
                    Space = Get_Space_By_SPACE_ID(new Params_Get_Space_By_SPACE_ID()
                    {
                        SPACE_ID = oWorst_Performing_wifi_signal.WIFI_SIGNAL_METADATA.SPACE_ID,
                    }),
                    Space_asset = Get_Space_asset_By_SPACE_ASSET_ID(new Params_Get_Space_asset_By_SPACE_ASSET_ID()
                    {
                        SPACE_ASSET_ID = oWorst_Performing_wifi_signal.WIFI_SIGNAL_METADATA.SPACE_ASSET_ID,
                    }),
                };

                return new Best_And_Worst_Object()
                {
                    Best_Performance_object = oMost_Performance_object,
                    Worst_Performance_object = oWorst_Performance_object,
                };
            }
            catch
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0052)); // An error has occured, please try again later
            }
        }
        #endregion
        #region Compute_Wifi_Signal_Space_Kpi_Data_Hourly
        public void Compute_Wifi_Signal_Space_Kpi_Data_Hourly(Params_Compute_Wifi_Signal_Space_Kpi_Data_Hourly i_Params_Compute_Wifi_Signal_Space_Kpi_Data_Hourly)
        {
            if (i_Params_Compute_Wifi_Signal_Space_Kpi_Data_Hourly != null)
            {
                if (i_Params_Compute_Wifi_Signal_Space_Kpi_Data_Hourly.LIST_ORGANIZATION_DATA_SOURCE_KPI != null && i_Params_Compute_Wifi_Signal_Space_Kpi_Data_Hourly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Count() > 0)
                {
                    DateTime CurrentDate = new DateTime(i_Params_Compute_Wifi_Signal_Space_Kpi_Data_Hourly.YEAR, i_Params_Compute_Wifi_Signal_Space_Kpi_Data_Hourly.MONTH, i_Params_Compute_Wifi_Signal_Space_Kpi_Data_Hourly.DAY, i_Params_Compute_Wifi_Signal_Space_Kpi_Data_Hourly.HOUR, 0, 0);
                    DateTime StartDate = CurrentDate.AddHours(-1);
                    List<int?> List_Organization_data_source_kpi_ID = i_Params_Compute_Wifi_Signal_Space_Kpi_Data_Hourly.LIST_ORGANIZATION_DATA_SOURCE_KPI.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();
                    int oOrganization_data_source_kpi_ID_Wifi_signal = (int)List_Organization_data_source_kpi_ID.First();

                    List<Wifi_signal> oList_Wifi_signal = Props.Copy_Prop_Values_From_Api_Response<List<Wifi_signal>>(_MongoDb.Get_Wifi_signal_By_Where(
                        START_DATE: StartDate,
                        END_DATE: CurrentDate,
                        SPACE_ID_LIST: null,
                        SPACE_ASSET_ID_LIST: null,
                        FLOOR_ID: null
                    ));
                    if (oList_Wifi_signal != null && oList_Wifi_signal.Count > 0)
                    {
                        List<Space_kpi_data> oList_Space_kpi_data_To_Save = oList_Wifi_signal
                        .GroupBy(oWifi_signal => new
                        {
                            oWifi_signal.WIFI_SIGNAL_METADATA.SPACE_ID,
                            oWifi_signal.WIFI_SIGNAL_METADATA.FLOOR_ID
                        })
                        .Select(oWifi_signal => new Space_kpi_data()
                        {
                            SPACE_METADATA = new Space_metadata()
                            {
                                SPACE_ID = (long)oWifi_signal.Key.SPACE_ID,
                                FLOOR_ID = (long)oWifi_signal.Key.FLOOR_ID,
                                CATEGORY = "Severity Type:0,Incident Category Type:0,EXT_STUDY_ZONE_ID:0",
                                ORGANIZATION_DATA_SOURCE_KPI_ID = oOrganization_data_source_kpi_ID_Wifi_signal,
                            },
                            RECORD_DATE = StartDate,
                            VALUE_PER_SQM = 0,
                            VALUE_NAME = StartDate.ToString(),
                            VALUE = (decimal)oWifi_signal.Average(oWifi_signal => oWifi_signal.VALUE),
                        }).ToList();

                        if (oList_Space_kpi_data_To_Save?.Count > 0)
                        {
                            try
                            {
                                Edit_Space_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN(new Params_Edit_Space_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN()
                                {
                                    LIST_SPACE_KPI_DATA = oList_Space_kpi_data_To_Save,
                                    LIST_ORGANIZATION_DATA_SOURCE_KPI_ID = new List<int?>() { oOrganization_data_source_kpi_ID_Wifi_signal },
                                    RECORD_DATE = CurrentDate,
                                    ENUM_TIMESPAN = Enum_Timespan.X_HOURLY_COLLECTION
                                });
                            }
                            catch (Exception ex)
                            {
                                throw new BLC_Exception(ex.Message);
                            }
                        }
                    }
                }
            }
        }
        #endregion

        #region Get_Latest_Wifi_signal_alerts
        public List<Wifi_signal_alert> Get_Latest_Wifi_signal_alerts(Params_Get_Latest_Wifi_signal_alerts i_Params_Get_Latest_Wifi_signal_alerts)
        {
            try
            {
                return Props.Copy_Prop_Values_From_Api_Response<List<Wifi_signal_alert>>(this._MongoDb.Get_Latest_Wifi_signal_alert
                (
                    FLOOR_ID: i_Params_Get_Latest_Wifi_signal_alerts.FLOOR_ID,
                    SPACE_ID_LIST: i_Params_Get_Latest_Wifi_signal_alerts.SPACE_ID_LIST,
                    NUMBER_OF_POINTS: i_Params_Get_Latest_Wifi_signal_alerts.NUMBER_OF_POINTS,
                    SPACE_ASSET_ID_LIST: i_Params_Get_Latest_Wifi_signal_alerts.SPACE_ASSET_ID_LIST
                ));
            }
            catch (Exception)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0052)); // An error has occured, please try again later
            }
        }
        #endregion
        #region Get_Wifi_signal_alerts
        public List<Wifi_signal_alert> Get_Wifi_signal_alerts(Params_Get_Wifi_signal_alerts i_Params_Get_Wifi_signal_alerts)
        {
            try
            {
                return Props.Copy_Prop_Values_From_Api_Response<List<Wifi_signal_alert>>(this._MongoDb.Get_Wifi_signal_alert_By_Where
                (
                    START_DATE: i_Params_Get_Wifi_signal_alerts.START_DATE,
                    END_DATE: i_Params_Get_Wifi_signal_alerts.END_DATE,
                    FLOOR_ID: i_Params_Get_Wifi_signal_alerts.FLOOR_ID,
                    IS_RESOLVED: i_Params_Get_Wifi_signal_alerts.IS_RESOLVED,
                    SPACE_ID_LIST: i_Params_Get_Wifi_signal_alerts.SPACE_ID_LIST,
                    SPACE_ASSET_ID_LIST: i_Params_Get_Wifi_signal_alerts.SPACE_ASSET_ID_LIST,
                    WIFI_SIGNAL_ALERT_ID_LIST: i_Params_Get_Wifi_signal_alerts.WIFI_SIGNAL_ALERT_ID_LIST
                ));
            }
            catch
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0052)); // An error has occured, please try again later
            }
        }
        #endregion
        #region Delete_Wifi_signal_alert
        public void Delete_Wifi_signal_alert(Params_Delete_Wifi_signal_alert i_Params_Delete_Wifi_signal_alert)
        {
            this._MongoDb.Delete_Wifi_signal_alert
            (
                FLOOR_ID: i_Params_Delete_Wifi_signal_alert.FLOOR_ID,
                IS_RESOLVED: i_Params_Delete_Wifi_signal_alert.IS_RESOLVED,
                SPACE_ID_LIST: i_Params_Delete_Wifi_signal_alert.SPACE_ID_LIST,
                SPACE_ASSET_ID_LIST: i_Params_Delete_Wifi_signal_alert.SPACE_ASSET_ID_LIST,
                WIFI_SIGNAL_ALERT_ID_LIST: i_Params_Delete_Wifi_signal_alert.WIFI_SIGNAL_ALERT_ID_LIST
            );
        }
        #endregion
        #region Edit_Wifi_signal_alert_List
        public void Edit_Wifi_signal_alert_List(Params_Edit_Wifi_signal_alert_List i_Params_Edit_Wifi_signal_alert_List)
        {
            if (i_Params_Edit_Wifi_signal_alert_List.List_Wifi_signal_alert != null && i_Params_Edit_Wifi_signal_alert_List.List_Wifi_signal_alert.Count > 0)
            {
                List<DALC.Wifi_signal_alert> oList_Wifi_signal_alert = new List<DALC.Wifi_signal_alert>();
                foreach (var wifi_signal_alert in i_Params_Edit_Wifi_signal_alert_List.List_Wifi_signal_alert)
                {
                    oList_Wifi_signal_alert.Add(new DALC.Wifi_signal_alert()
                    {
                        START_DATE = wifi_signal_alert.START_DATE == null ? wifi_signal_alert.START_DATE : new DateTime((int)wifi_signal_alert.START_DATE?.Year, (int)wifi_signal_alert.START_DATE?.Month, (int)wifi_signal_alert.START_DATE?.Day, (int)wifi_signal_alert.START_DATE?.Hour, (int)wifi_signal_alert.START_DATE?.Minute, (int)wifi_signal_alert.START_DATE?.Second, DateTimeKind.Utc),
                        END_DATE = wifi_signal_alert.END_DATE == null ? wifi_signal_alert.END_DATE : new DateTime((int)wifi_signal_alert.END_DATE?.Year, (int)wifi_signal_alert.END_DATE?.Month, (int)wifi_signal_alert.END_DATE?.Day, (int)wifi_signal_alert.END_DATE?.Hour, (int)wifi_signal_alert.END_DATE?.Minute, (int)wifi_signal_alert.END_DATE?.Second, DateTimeKind.Utc),
                        FLOOR_ID = wifi_signal_alert.FLOOR_ID,
                        SPACE_ID = wifi_signal_alert.SPACE_ID,
                        IS_RESOLVED = wifi_signal_alert.IS_RESOLVED,
                        ALERT_VALUE = wifi_signal_alert.ALERT_VALUE,
                        RESOLVE_VALUE = wifi_signal_alert.RESOLVE_VALUE,
                        SPACE_ASSET_ID = wifi_signal_alert.SPACE_ASSET_ID,
                        WIFI_SIGNAL_ALERT_ID = wifi_signal_alert.WIFI_SIGNAL_ALERT_ID,
                    });
                }
                this._MongoDb.Edit_Wifi_signal_alert_List(oList_Wifi_signal_alert);
            }
        }
        #endregion
        #region Get_Most_Wifi_signal_Count_Per_Space_asset
        public Best_And_Worst_Object Get_Most_Wifi_signal_Count_Per_Space_asset(Params_Get_Most_Wifi_signal_Count_Per_Space_asset i_Params_Get_Most_Wifi_signal_Count_Per_Space_asset)
        {
            try
            {
                List<Entity> oList_Entity = Get_Entity_By_TOP_LEVEL_ID(new Params_Get_Entity_By_TOP_LEVEL_ID()
                {
                    TOP_LEVEL_ID = i_Params_Get_Most_Wifi_signal_Count_Per_Space_asset.TOP_LEVEL_ID
                });
                List<Space_asset_id_With_Count> oList_Space_asset_id_With_Count = Props.Copy_Prop_Values_From_Api_Response<List<Space_asset_id_With_Count>>(this._MongoDb.Get_Wifi_signal_Count_Per_Space_asset
                (
                    START_DATE: i_Params_Get_Most_Wifi_signal_Count_Per_Space_asset.START_DATE,
                    END_DATE: i_Params_Get_Most_Wifi_signal_Count_Per_Space_asset.END_DATE,
                    FLOOR_ID_LIST: oList_Entity.SelectMany(entity => entity.List_Floor.Select(floor => floor.FLOOR_ID)).ToList(),
                    SPACE_ID_LIST: null,
                    SPACE_ASSET_ID_LIST: null
                )).OrderByDescending(space_asset_id_With_Count => space_asset_id_With_Count.COUNT).ToList();
                Space_asset_id_With_Count oBest_Performing_wifi_signal = oList_Space_asset_id_With_Count.FirstOrDefault();
                Space_asset oBest_Space_asset = Get_Space_asset_By_SPACE_ASSET_ID(new Params_Get_Space_asset_By_SPACE_ASSET_ID()
                {
                    SPACE_ASSET_ID = oBest_Performing_wifi_signal.SPACE_ASSET_ID
                });
                Space oBest_Space = Get_Space_By_SPACE_ID(new Params_Get_Space_By_SPACE_ID()
                {
                    SPACE_ID = oBest_Space_asset.SPACE_ID
                });
                Floor oBest_Floor = oList_Entity.SelectMany(entity => entity.List_Floor).ToList().Find(floor => floor.FLOOR_ID == oBest_Space.FLOOR_ID);
                Performance_object oMost_Performance_object = new Performance_object()
                {
                    Entity = oList_Entity.Find(entity => entity.ENTITY_ID == oBest_Floor.ENTITY_ID),
                    Floor = oBest_Floor,
                    value = oBest_Performing_wifi_signal.COUNT,
                    Space = oBest_Space,
                    Space_asset = oBest_Space_asset,
                };

                Space_asset_id_With_Count oWorst_Performing_wifi_signal = oList_Space_asset_id_With_Count.LastOrDefault();
                Space_asset oWorst_Space_asset = Get_Space_asset_By_SPACE_ASSET_ID(new Params_Get_Space_asset_By_SPACE_ASSET_ID()
                {
                    SPACE_ASSET_ID = oWorst_Performing_wifi_signal.SPACE_ASSET_ID,
                });
                Space oWorst_Space = Get_Space_By_SPACE_ID(new Params_Get_Space_By_SPACE_ID()
                {
                    SPACE_ID = oWorst_Space_asset.SPACE_ID,
                });
                Floor oWorst_Floor = oList_Entity.SelectMany(entity => entity.List_Floor).ToList().Find(floor => floor.FLOOR_ID == oWorst_Space.FLOOR_ID);
                Performance_object oWorst_Performance_object = new Performance_object()
                {
                    Entity = oList_Entity.Find(entity => entity.ENTITY_ID == oWorst_Floor.ENTITY_ID),
                    Floor = oWorst_Floor,
                    value = oWorst_Performing_wifi_signal.COUNT,
                    Space = oWorst_Space,
                    Space_asset = oWorst_Space_asset,
                };

                return new Best_And_Worst_Object()
                {
                    Best_Performance_object = oMost_Performance_object,
                    Worst_Performance_object = oWorst_Performance_object,
                };
            }
            catch (Exception)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0052)); // An error has occured, please try again later
            }
        }
        #endregion

        #region Update_Wifi_signal
        public Wifi_signal_data Update_Wifi_signal(Params_Update_Wifi_signal i_Params_Update_Wifi_signal)
        {
            Wifi_signal_data oWifi_signal_data = new Wifi_signal_data();
            var get_wifi_signals = Task.Run(() =>
            {
                oWifi_signal_data.WIFI_SIGNAL_LIST = Get_Latest_Wifi_signals(new Params_Get_Latest_Wifi_signals()
                {
                    FLOOR_ID = i_Params_Update_Wifi_signal.FLOOR_ID,
                    NUMBER_OF_POINTS = 7,
                });
            });
            var get_wifi_signal_alerts = Task.Run(() =>
            {
                oWifi_signal_data.WIFI_SIGNAL_ALERT_LIST = Get_Latest_Wifi_signal_alerts(new Params_Get_Latest_Wifi_signal_alerts()
                {
                    FLOOR_ID = i_Params_Update_Wifi_signal.FLOOR_ID,
                    NUMBER_OF_POINTS = 1,
                });
            });
            Task.WaitAll(get_wifi_signals, get_wifi_signal_alerts);
            return oWifi_signal_data;
        }
        #endregion
        #region Update_Kpi_Data_Record
        public void Update_Kpi_Data_Record(Params_Update_Kpi_Data_Record i_Params_Update_Kpi_Data_Record)
        {
            if (i_Params_Update_Kpi_Data_Record.ORGANIZATION_DATA_SOURCE_KPI_ID != null && i_Params_Update_Kpi_Data_Record.RECORD_DATE != null)
            {
                DateTime oDateTime = (DateTime)i_Params_Update_Kpi_Data_Record.RECORD_DATE;

                #region Get Kpi

                Kpi oKpi = Get_Kpi_By_KPI_ID_Adv(new Params_Get_Kpi_By_KPI_ID()
                {
                    KPI_ID = i_Params_Update_Kpi_Data_Record.KPI_ID
                });

                #endregion

                #region Fetch Data

                List<District_kpi_data> oList_District_kpi_data = Get_District_Kpi_Data_By_Where(new Params_Get_District_Kpi_Data_By_Where()
                {
                    ENUM_TIMESPAN = Enum_Timespan.X_DAILY_COLLECTION,
                    ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = new List<int?> { i_Params_Update_Kpi_Data_Record.ORGANIZATION_DATA_SOURCE_KPI_ID },
                    END_DATE = oDateTime,
                    START_DATE = oDateTime.AddDays(-3)
                });
                List<Area_kpi_data> oList_Area_kpi_data = Get_Area_Kpi_Data_By_Where(new Params_Get_Area_Kpi_Data_By_Where()
                {
                    ENUM_TIMESPAN = Enum_Timespan.X_DAILY_COLLECTION,
                    ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = new List<int?> { i_Params_Update_Kpi_Data_Record.ORGANIZATION_DATA_SOURCE_KPI_ID },
                    END_DATE = oDateTime,
                    START_DATE = oDateTime.AddDays(-3)
                });
                List<Site_kpi_data> oList_Site_kpi_data = Get_Site_Kpi_Data_By_Where(new Params_Get_Site_Kpi_Data_By_Where()
                {
                    ENUM_TIMESPAN = Enum_Timespan.X_DAILY_COLLECTION,
                    ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = new List<int?> { i_Params_Update_Kpi_Data_Record.ORGANIZATION_DATA_SOURCE_KPI_ID },
                    END_DATE = oDateTime,
                    START_DATE = oDateTime.AddDays(-3)
                });

                #endregion

                #region Remove Unwanted Records

                if (oList_District_kpi_data != null && oList_District_kpi_data.Count > 0)
                {
                    var Recent_Date_District = oList_District_kpi_data.MaxBy(oDistrict_kpi_data => oDistrict_kpi_data.RECORD_DATE).RECORD_DATE;
                    oList_District_kpi_data.RemoveAll(oDistrict_kpi_data => oDistrict_kpi_data.RECORD_DATE != Recent_Date_District);
                }
                if (oList_Area_kpi_data != null && oList_Area_kpi_data.Count > 0)
                {
                    var Recent_Date_Area = oList_Area_kpi_data.MaxBy(oArea_kpi_data => oArea_kpi_data.RECORD_DATE).RECORD_DATE;
                    oList_Area_kpi_data.RemoveAll(oArea_kpi_data => oArea_kpi_data.RECORD_DATE != Recent_Date_Area);
                }
                if (oList_Site_kpi_data != null && oList_Site_kpi_data.Count > 0)
                {
                    var Recent_Date_Site = oList_Site_kpi_data.MaxBy(oSite_kpi_data => oSite_kpi_data.RECORD_DATE).RECORD_DATE;
                    oList_Site_kpi_data.RemoveAll(oSite_kpi_data => oSite_kpi_data.RECORD_DATE != Recent_Date_Site);
                }

                #endregion

                #region Fill Lists

                if (oList_District_kpi_data != null && oList_District_kpi_data.Count > 0)
                {
                    oList_District_kpi_data.ForEach(oDistrict_kpi_data =>
                    {
                        oDistrict_kpi_data.RECORD_DATE = oDateTime;
                        oDistrict_kpi_data.VALUE_NAME = oDateTime.ToShortDateString();
                        if (i_Params_Update_Kpi_Data_Record.IS_RANDOM == true)
                        {
                            decimal randomValue = (decimal)(oKpi.IS_DECIMAL_VALUE ? Tools.Get_Random_Decimal() * (oKpi.MAXIMUM_VALUE - oKpi.MINIMUM_VALUE) + oKpi.MINIMUM_VALUE : Tools.Get_Random_Number((int)oKpi.MINIMUM_VALUE, (int)oKpi.MAXIMUM_VALUE + 1));
                            oDistrict_kpi_data.VALUE = randomValue;
                            oDistrict_kpi_data.VALUE_PER_SQM = randomValue / 3500;
                        }
                    });
                }
                if (oList_Area_kpi_data != null && oList_Area_kpi_data.Count > 0)
                {
                    oList_Area_kpi_data.ForEach(oArea_kpi_data =>
                    {
                        oArea_kpi_data.RECORD_DATE = oDateTime;
                        oArea_kpi_data.VALUE_NAME = oDateTime.ToShortDateString();
                        if (i_Params_Update_Kpi_Data_Record.IS_RANDOM == true)
                        {
                            decimal randomValue = (decimal)(oKpi.IS_DECIMAL_VALUE ? Tools.Get_Random_Decimal() * (oKpi.MAXIMUM_VALUE - oKpi.MINIMUM_VALUE) + oKpi.MINIMUM_VALUE : Tools.Get_Random_Number((int)oKpi.MINIMUM_VALUE, (int)oKpi.MAXIMUM_VALUE + 1));
                            oArea_kpi_data.VALUE = randomValue;
                            oArea_kpi_data.VALUE_PER_SQM = randomValue / 1000;
                        }
                    });
                }
                if (oList_Site_kpi_data != null && oList_Site_kpi_data.Count > 0)
                {
                    oList_Site_kpi_data.ForEach(oSite_kpi_data =>
                    {
                        oSite_kpi_data.RECORD_DATE = oDateTime;
                        oSite_kpi_data.VALUE_NAME = oDateTime.ToShortDateString();
                        if (i_Params_Update_Kpi_Data_Record.IS_RANDOM == true)
                        {
                            decimal randomValue = (decimal)(oKpi.IS_DECIMAL_VALUE ? Tools.Get_Random_Decimal() * (oKpi.MAXIMUM_VALUE - oKpi.MINIMUM_VALUE) + oKpi.MINIMUM_VALUE : Tools.Get_Random_Number((int)oKpi.MINIMUM_VALUE, (int)oKpi.MAXIMUM_VALUE + 1));
                            oSite_kpi_data.VALUE = randomValue;
                            oSite_kpi_data.VALUE_PER_SQM = randomValue / 1000;
                        }
                    });
                }

                #endregion

                #region Send Data
                if (oList_District_kpi_data != null && oList_District_kpi_data.Count > 0)
                {
                    List<District_kpi_data> oList_District_kpi_data_To_Check = Props.Copy_Prop_Values_From_Api_Response<List<District_kpi_data>>(this._MongoDb.Get_District_Kpi_Data_By_Where(
                        START_DATE: oDateTime,
                        END_DATE: oDateTime.AddSeconds(1),
                        ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: new List<int?> { i_Params_Update_Kpi_Data_Record.ORGANIZATION_DATA_SOURCE_KPI_ID },
                        ENUM_TIMESPAN: DALC.Enum_Timespan.X_DAILY_COLLECTION,
                        DISTRICT_ID_LIST: null
                    ));

                    if (oList_District_kpi_data_To_Check?.Count > 0 && i_Params_Update_Kpi_Data_Record.FORCE_INJECT == false)
                    {
                        throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0044).Replace("%1", "District").Replace("%2", oDateTime.ToString())); // Data for %1 on date %2 already exists
                    }

                    Insert_District_Kpi_Data_List(new Params_Insert_District_Kpi_Data_List()
                    {
                        DISTRICT_KPI_DATA_LIST = oList_District_kpi_data,
                        ENUM_TIMESPAN = Enum_Timespan.X_DAILY_COLLECTION
                    });
                }
                if (oList_Area_kpi_data != null && oList_Area_kpi_data.Count > 0)
                {
                    List<Area_kpi_data> oList_Area_kpi_data_To_Check = Props.Copy_Prop_Values_From_Api_Response<List<Area_kpi_data>>(this._MongoDb.Get_Area_Kpi_Data_By_Where(
                        START_DATE: oDateTime,
                        END_DATE: oDateTime.AddSeconds(1),
                        ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: new List<int?> { i_Params_Update_Kpi_Data_Record.ORGANIZATION_DATA_SOURCE_KPI_ID },
                        ENUM_TIMESPAN: DALC.Enum_Timespan.X_DAILY_COLLECTION,
                        AREA_ID_LIST: null
                    ));

                    if (oList_Area_kpi_data_To_Check?.Count > 0 && i_Params_Update_Kpi_Data_Record.FORCE_INJECT == false)
                    {
                        throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0044).Replace("%1", "Area").Replace("%2", oDateTime.ToString())); // Data for %1 on date %2 already exists
                    }

                    Insert_Area_Kpi_Data_List(new Params_Insert_Area_Kpi_Data_List()
                    {
                        AREA_KPI_DATA_LIST = oList_Area_kpi_data,
                        ENUM_TIMESPAN = Enum_Timespan.X_DAILY_COLLECTION
                    });
                }
                if (oList_Site_kpi_data != null && oList_Site_kpi_data.Count > 0)
                {
                    List<Site_kpi_data> oList_Site_kpi_data_To_Check = Props.Copy_Prop_Values_From_Api_Response<List<Site_kpi_data>>(this._MongoDb.Get_Site_Kpi_Data_By_Where(
                        START_DATE: oDateTime,
                        END_DATE: oDateTime.AddSeconds(1),
                        ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: new List<int?> { i_Params_Update_Kpi_Data_Record.ORGANIZATION_DATA_SOURCE_KPI_ID },
                        ENUM_TIMESPAN: DALC.Enum_Timespan.X_DAILY_COLLECTION,
                        SITE_ID_LIST: null
                    ));

                    if (oList_Site_kpi_data_To_Check?.Count > 0 && i_Params_Update_Kpi_Data_Record.FORCE_INJECT == false)
                    {
                        throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0044).Replace("%1", "Site").Replace("%2", oDateTime.ToString())); // Data for %1 on date %2 already exists
                    }

                    Insert_Site_Kpi_Data_List(new Params_Insert_Site_Kpi_Data_List()
                    {
                        SITE_KPI_DATA_LIST = oList_Site_kpi_data,
                        ENUM_TIMESPAN = Enum_Timespan.X_DAILY_COLLECTION
                    });
                }

                #endregion
            }
        }
        #endregion
    }
}
