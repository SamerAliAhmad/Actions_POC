using System.Threading.Tasks;
using System;
using System.Linq;
using SmartrTools;
using System.Collections.Generic;
using System.Collections.Concurrent;

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
        #region Get_Comparison_Data
        public Comparison_Data Get_Comparison_Data(Params_Get_Comparison_Data i_Params_Get_Comparison_Data)
        {
            Comparison_Data oComparison_Data = new Comparison_Data();

            #region Declaration & Initialization

            List<District_kpi_data> oList_District_kpi_data_Dwell_Time = new List<District_kpi_data>();
            List<District_kpi_data> oList_District_kpi_data_Number_of_Visitors = new List<District_kpi_data>();
            List<Business> oList_District_kpi_data_Businesse_Count = new List<Business>();

            List<Area_kpi_data> oList_Area_kpi_data_Dwell_Time = new List<Area_kpi_data>();
            List<Area_kpi_data> oList_Area_kpi_data_Number_of_Visitors = new List<Area_kpi_data>();
            List<Business> oList_Area_kpi_data_Businesse_Count = new List<Business>();

            List<Site_kpi_data> oList_Site_kpi_data_Dwell_Time = new List<Site_kpi_data>();
            List<Site_kpi_data> oList_Site_kpi_data_Number_of_Visitors = new List<Site_kpi_data>();
            List<Business> oList_Site_kpi_data_Businesse_Count = new List<Business>();

            Organization_data_source_kpi oDwell_Time_Organization_data_source_kpi = new Organization_data_source_kpi();
            Organization_data_source_kpi oNumber_of_Visitors_Organization_data_source_kpi = new Organization_data_source_kpi();
            Organization_data_source_kpi oBusinesse_Count_Organization_data_source_kpi = new Organization_data_source_kpi();

            long? District_Setup_ID = 0;
            long? Area_Setup_ID = 0;
            long? Site_Setup_ID = 0;

            #endregion

            #region Get Organization Data Source Kpi

            var get_organization_data_source_kpi = Task.Run(() =>
            {
                List<Organization_data_source_kpi> oList_Organization_data_source_kpi = Props.Copy_Prop_Values_From_Api_Response<List<Organization_data_source_kpi>>(this._service_mesh.Get_Organization_data_source_kpi_By_OWNER_ID_Adv(new Service_Mesh.Params_Get_Organization_data_source_kpi_By_OWNER_ID()
                {
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                }).i_Result);

                oDwell_Time_Organization_data_source_kpi = oList_Organization_data_source_kpi.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.NAME == "Dwell Time");
                oNumber_of_Visitors_Organization_data_source_kpi = oList_Organization_data_source_kpi.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.NAME == "Number of Visitors");
                oBusinesse_Count_Organization_data_source_kpi = oList_Organization_data_source_kpi.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.NAME == "Businesses By Category");
            });

            #endregion

            #region Get Level List Setup

            var get_level_setup = Task.Run(() =>
            {
                List<Setup> oList_Data_Level_Setup = Props.Copy_Prop_Values_From_Api_Response<List<Setup>>(this._service_mesh.Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Service_Mesh.Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
                {
                    SETUP_CATEGORY_NAME = "Data Level",
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                }).i_Result.List_Setup);
                if (oList_Data_Level_Setup != null && oList_Data_Level_Setup.Count > 0)
                {
                    District_Setup_ID = oList_Data_Level_Setup.Find(setup => setup.VALUE == "District").SETUP_ID;
                    Area_Setup_ID = oList_Data_Level_Setup.Find(setup => setup.VALUE == "Area").SETUP_ID;
                    Site_Setup_ID = oList_Data_Level_Setup.Find(setup => setup.VALUE == "Site").SETUP_ID;
                }
                else
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0045).Replace("%1", "Data Level")); // Data Level Setup Not Found
                }
            });


            #endregion

            Task.WaitAll(get_organization_data_source_kpi, get_level_setup);

            #region Get Business & Level Kpi Data

            #region Get Number of Visitors

            var get_district_number_of_visitors = Task.Run(() =>
            {
                oList_District_kpi_data_Number_of_Visitors = Props.Copy_Prop_Values_From_Api_Response<List<District_kpi_data>>(this._service_mesh.Get_District_Kpi_Data_By_Where(new Service_Mesh.Params_Get_District_Kpi_Data_By_Where()
                {
                    DISTRICT_ID_LIST = i_Params_Get_Comparison_Data.DISTRICT_ID_LIST,
                    ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = new List<int?>() { oNumber_of_Visitors_Organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID },
                    ENUM_TIMESPAN = (Service_Mesh.Enum_Timespan)i_Params_Get_Comparison_Data.ENUM_TIMESPAN,
                    START_DATE = i_Params_Get_Comparison_Data.START_DATE,
                    END_DATE = i_Params_Get_Comparison_Data.END_DATE
                }).i_Result);
                oComparison_Data.LIST_DISTRICT_KPI_DATA_NUMBER_OF_VISITORS = oList_District_kpi_data_Number_of_Visitors;
            });

            var get_area_number_of_visitors = Task.Run(() =>
            {
                oList_Area_kpi_data_Number_of_Visitors = Props.Copy_Prop_Values_From_Api_Response<List<Area_kpi_data>>(this._service_mesh.Get_Area_Kpi_Data_By_Where(new Service_Mesh.Params_Get_Area_Kpi_Data_By_Where()
                {
                    AREA_ID_LIST = i_Params_Get_Comparison_Data.AREA_ID_LIST,
                    ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = new List<int?>() { oNumber_of_Visitors_Organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID },
                    ENUM_TIMESPAN = (Service_Mesh.Enum_Timespan)i_Params_Get_Comparison_Data.ENUM_TIMESPAN,
                    START_DATE = i_Params_Get_Comparison_Data.START_DATE,
                    END_DATE = i_Params_Get_Comparison_Data.END_DATE
                }).i_Result);
                oComparison_Data.LIST_AREA_KPI_DATA_NUMBER_OF_VISITORS = oList_Area_kpi_data_Number_of_Visitors;
            });

            var get_site_number_of_visitors = Task.Run(() =>
            {
                oList_Site_kpi_data_Number_of_Visitors = Props.Copy_Prop_Values_From_Api_Response<List<Site_kpi_data>>(this._service_mesh.Get_Site_Kpi_Data_By_Where(new Service_Mesh.Params_Get_Site_Kpi_Data_By_Where()
                {
                    SITE_ID_LIST = i_Params_Get_Comparison_Data.SITE_ID_LIST,
                    ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = new List<int?>() { oNumber_of_Visitors_Organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID },
                    ENUM_TIMESPAN = (Service_Mesh.Enum_Timespan)i_Params_Get_Comparison_Data.ENUM_TIMESPAN,
                    START_DATE = i_Params_Get_Comparison_Data.START_DATE,
                    END_DATE = i_Params_Get_Comparison_Data.END_DATE
                }).i_Result);
                oComparison_Data.LIST_SITE_KPI_DATA_NUMBER_OF_VISITORS = oList_Site_kpi_data_Number_of_Visitors;
            });

            #endregion

            #region Get Dwell Time

            var get_district_dwell_time = Task.Run(() =>
            {
                oList_District_kpi_data_Dwell_Time = Props.Copy_Prop_Values_From_Api_Response<List<District_kpi_data>>(this._service_mesh.Get_District_Kpi_Data_Aggregate_Sum(new Service_Mesh.Params_Get_District_Kpi_Data_Aggregate_Sum()
                {
                    DISTRICT_ID_LIST = i_Params_Get_Comparison_Data.DISTRICT_ID_LIST,
                    ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = new List<int?>() { oDwell_Time_Organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID },
                    ENUM_TIMESPAN = (Service_Mesh.Enum_Timespan)i_Params_Get_Comparison_Data.ENUM_TIMESPAN,
                    START_DATE = i_Params_Get_Comparison_Data.START_DATE,
                    END_DATE = i_Params_Get_Comparison_Data.END_DATE
                }).i_Result);
                oComparison_Data.LIST_DISTRICT_KPI_DATA_DWELL_TIME = oList_District_kpi_data_Dwell_Time;
            });

            var get_area_dwell_time = Task.Run(() =>
            {
                oList_Area_kpi_data_Dwell_Time = Props.Copy_Prop_Values_From_Api_Response<List<Area_kpi_data>>(this._service_mesh.Get_Area_Kpi_Data_Aggregate_Sum(new Service_Mesh.Params_Get_Area_Kpi_Data_Aggregate_Sum()
                {
                    AREA_ID_LIST = i_Params_Get_Comparison_Data.AREA_ID_LIST,
                    ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = new List<int?>() { oDwell_Time_Organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID },
                    ENUM_TIMESPAN = (Service_Mesh.Enum_Timespan)i_Params_Get_Comparison_Data.ENUM_TIMESPAN,
                    START_DATE = i_Params_Get_Comparison_Data.START_DATE,
                    END_DATE = i_Params_Get_Comparison_Data.END_DATE
                }).i_Result);
                oComparison_Data.LIST_AREA_KPI_DATA_DWELL_TIME = oList_Area_kpi_data_Dwell_Time;
            });

            var get_site_dwell_time = Task.Run(() =>
            {
                oList_Site_kpi_data_Dwell_Time = Props.Copy_Prop_Values_From_Api_Response<List<Site_kpi_data>>(this._service_mesh.Get_Site_Kpi_Data_Aggregate_Sum(new Service_Mesh.Params_Get_Site_Kpi_Data_Aggregate_Sum()
                {
                    SITE_ID_LIST = i_Params_Get_Comparison_Data.SITE_ID_LIST,
                    ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = new List<int?>() { oDwell_Time_Organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID },
                    ENUM_TIMESPAN = (Service_Mesh.Enum_Timespan)i_Params_Get_Comparison_Data.ENUM_TIMESPAN,
                    START_DATE = i_Params_Get_Comparison_Data.START_DATE,
                    END_DATE = i_Params_Get_Comparison_Data.END_DATE
                }).i_Result);
                oComparison_Data.LIST_SITE_KPI_DATA_DWELL_TIME = oList_Site_kpi_data_Dwell_Time;
            });

            #endregion

            #region Get Businesses

            var get_district_business_count = Task.Run(() =>
            {
                oList_District_kpi_data_Businesse_Count = Props.Copy_Prop_Values_From_Api_Response<List<Business>>(this._service_mesh.Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID(new Service_Mesh.Params_Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID()
                {
                    LIST_LEVEL_ID = i_Params_Get_Comparison_Data.DISTRICT_ID_LIST,
                    LEVEL_SETUP_ID = District_Setup_ID,
                    ORGANIZATION_DATA_SOURCE_KPI_ID = oBusinesse_Count_Organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID
                }).i_Result);
                oComparison_Data.LIST_DISTRICT_BUSINESS_COUNT = oList_District_kpi_data_Businesse_Count;
            });

            var get_area_business_count = Task.Run(() =>
            {
                oList_Area_kpi_data_Businesse_Count = Props.Copy_Prop_Values_From_Api_Response<List<Business>>(this._service_mesh.Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID(new Service_Mesh.Params_Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID()
                {
                    LIST_LEVEL_ID = i_Params_Get_Comparison_Data.AREA_ID_LIST,
                    LEVEL_SETUP_ID = Area_Setup_ID,
                    ORGANIZATION_DATA_SOURCE_KPI_ID = oBusinesse_Count_Organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID
                }).i_Result);
                oComparison_Data.LIST_AREA_BUSINESS_COUNT = oList_Area_kpi_data_Businesse_Count;
            });

            var get_site_business_count = Task.Run(() =>
            {
                oList_Site_kpi_data_Businesse_Count = Props.Copy_Prop_Values_From_Api_Response<List<Business>>(this._service_mesh.Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID(new Service_Mesh.Params_Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID()
                {
                    LIST_LEVEL_ID = i_Params_Get_Comparison_Data.SITE_ID_LIST,
                    LEVEL_SETUP_ID = Site_Setup_ID,
                    ORGANIZATION_DATA_SOURCE_KPI_ID = oBusinesse_Count_Organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID
                }).i_Result);
                oComparison_Data.LIST_SITE_BUSINESS_COUNT = oList_Site_kpi_data_Businesse_Count;
            });

            #endregion

            Task.WaitAll(get_district_number_of_visitors, get_area_number_of_visitors, get_site_number_of_visitors,
                         get_district_dwell_time, get_area_dwell_time, get_site_dwell_time,
                         get_district_business_count, get_area_business_count, get_site_business_count);

            #endregion

            return oComparison_Data;
        }
        #endregion
        #region Get_Single_kpi_comparison
        public List<Kpi_Value_By_Date> Get_Single_kpi_comparison(Params_Get_Single_kpi_comparison i_Params_Get_Single_kpi_comparison)
        {
            #region Declaration & Initialization

            List<Kpi_Value_By_Date> oList_Kpi_Value_By_Date = new List<Kpi_Value_By_Date>();

            #endregion

            #region Get Data Level Setup

            #region Declaration & Initialization

            long? Site_Level_SETUP_ID = 0;
            long? Area_Level_SETUP_ID = 0;
            long? District_Level_SETUP_ID = 0;
            List<Setup_category> oList_Setup_category = new List<Setup_category>();

            #endregion

            var get_setup = Task.Run(() =>
            {
                oList_Setup_category = Props.Copy_Prop_Values_From_Api_Response<List<Setup_category>>(
                    this._service_mesh.Get_Setup_category_By_OWNER_ID(new Service_Mesh.Params_Get_Setup_category_By_OWNER_ID()
                    {
                        OWNER_ID = this.oBLC_Initializer.Owner_ID,
                    }).i_Result
                );
                Site_Level_SETUP_ID = oList_Setup_category.Find(setup_category => setup_category.SETUP_CATEGORY_NAME == "Data Level").List_Setup.Find(setup => setup.VALUE == "Site").SETUP_ID;
                Area_Level_SETUP_ID = oList_Setup_category.Find(setup_category => setup_category.SETUP_CATEGORY_NAME == "Data Level").List_Setup.Find(setup => setup.VALUE == "Area").SETUP_ID;
                District_Level_SETUP_ID = oList_Setup_category.Find(setup_category => setup_category.SETUP_CATEGORY_NAME == "Data Level").List_Setup.Find(setup => setup.VALUE == "District").SETUP_ID;
            });

            #endregion

            #region Get Organization_data_source_kpi

            #region Declaration & Initialization

            Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();

            #endregion

            var get_organization_data_source_kpi = Task.Run(() =>
            {
                oOrganization_data_source_kpi = Props.Copy_Prop_Values_From_Api_Response<Organization_data_source_kpi>(this._service_mesh.Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv(new Service_Mesh.Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID()
                {
                    ORGANIZATION_DATA_SOURCE_KPI_ID = i_Params_Get_Single_kpi_comparison.ORGANIZATION_DATA_SOURCE_KPI_ID
                }).i_Result);
            });

            #endregion

            Task.WaitAll(get_setup, get_organization_data_source_kpi);

            #region Get oList_Kpi_Value_By_Date_First

            switch (oOrganization_data_source_kpi.Kpi.NAME)
            {
                case "Businesses By Category":
                    oList_Kpi_Value_By_Date = Props.Copy_Prop_Values_From_Api_Response<List<Kpi_Value_By_Date>>(this._service_mesh.Get_Business_Trendline(new Service_Mesh.Params_Get_Business_Trendline()
                    {
                        LIST_LEVEL_ID = new List<long?> { i_Params_Get_Single_kpi_comparison.LEVEL_ID },
                        LEVEL_SETUP_ID = i_Params_Get_Single_kpi_comparison.DATA_LEVEL_SETUP_ID,
                        START_DATE = i_Params_Get_Single_kpi_comparison.START_DATE,
                        END_DATE = i_Params_Get_Single_kpi_comparison.END_DATE,
                        ENUM_TIMESPAN = Service_Mesh.Enum_Timespan.X_DAILY_COLLECTION,
                        ORGANIZATION_ID = i_Params_Get_Single_kpi_comparison.ORGANIZATION_ID
                    }).i_Result);
                    break;
                case "Bylaw Complaints":
                    oList_Kpi_Value_By_Date = Props.Copy_Prop_Values_From_Api_Response<List<Kpi_Value_By_Date>>(this._service_mesh.Get_Bylaw_Complaints_Trendline(new Service_Mesh.Params_Get_Bylaw_Complaints_Trendline()
                    {
                        LIST_LEVEL_ID = new List<long?> { i_Params_Get_Single_kpi_comparison.LEVEL_ID },
                        LEVEL_SETUP_ID = i_Params_Get_Single_kpi_comparison.DATA_LEVEL_SETUP_ID,
                        START_DATE = i_Params_Get_Single_kpi_comparison.START_DATE,
                        END_DATE = i_Params_Get_Single_kpi_comparison.END_DATE,
                        ENUM_TIMESPAN = Service_Mesh.Enum_Timespan.X_DAILY_COLLECTION,
                        ORGANIZATION_ID = i_Params_Get_Single_kpi_comparison.ORGANIZATION_ID
                    }).i_Result);
                    break;
                case "Public Events":
                    oList_Kpi_Value_By_Date = Props.Copy_Prop_Values_From_Api_Response<List<Kpi_Value_By_Date>>(this._service_mesh.Get_Public_Events_Trendline(new Service_Mesh.Params_Get_Public_Events_Trendline()
                    {
                        LIST_LEVEL_ID = new List<long?> { i_Params_Get_Single_kpi_comparison.LEVEL_ID },
                        LEVEL_SETUP_ID = i_Params_Get_Single_kpi_comparison.DATA_LEVEL_SETUP_ID,
                        START_DATE = i_Params_Get_Single_kpi_comparison.START_DATE,
                        END_DATE = i_Params_Get_Single_kpi_comparison.END_DATE,
                        ENUM_TIMESPAN = Service_Mesh.Enum_Timespan.X_DAILY_COLLECTION,
                        ORGANIZATION_ID = i_Params_Get_Single_kpi_comparison.ORGANIZATION_ID
                    }).i_Result);
                    break;
                default:
                    if (i_Params_Get_Single_kpi_comparison.DATA_LEVEL_SETUP_ID == Site_Level_SETUP_ID)
                    {
                        List<Service_Mesh.Site_kpi_data> oList_Site_kpi_data = this._service_mesh.Get_Site_Kpi_Data_By_Where(new Service_Mesh.Params_Get_Site_Kpi_Data_By_Where()
                        {
                            SITE_ID_LIST = new List<long?> { i_Params_Get_Single_kpi_comparison.LEVEL_ID },
                            ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = new List<int?> { i_Params_Get_Single_kpi_comparison.ORGANIZATION_DATA_SOURCE_KPI_ID },
                            START_DATE = i_Params_Get_Single_kpi_comparison.START_DATE,
                            END_DATE = i_Params_Get_Single_kpi_comparison.END_DATE,
                            ENUM_TIMESPAN = Service_Mesh.Enum_Timespan.X_DAILY_COLLECTION
                        }).i_Result;
                        oList_Kpi_Value_By_Date = oList_Site_kpi_data.Select(oSite_kpi_data => new Kpi_Value_By_Date()
                        {
                            RECORD_DATE = oSite_kpi_data.RECORD_DATE,
                            VALUE = oSite_kpi_data.VALUE,
                        }).ToList();
                    }
                    else if (i_Params_Get_Single_kpi_comparison.DATA_LEVEL_SETUP_ID == Area_Level_SETUP_ID)
                    {
                        List<Service_Mesh.Area_kpi_data> oList_Area_kpi_data = this._service_mesh.Get_Area_Kpi_Data_By_Where(new Service_Mesh.Params_Get_Area_Kpi_Data_By_Where()
                        {
                            AREA_ID_LIST = new List<long?> { i_Params_Get_Single_kpi_comparison.LEVEL_ID },
                            ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = new List<int?> { i_Params_Get_Single_kpi_comparison.ORGANIZATION_DATA_SOURCE_KPI_ID },
                            START_DATE = i_Params_Get_Single_kpi_comparison.START_DATE,
                            END_DATE = i_Params_Get_Single_kpi_comparison.END_DATE,
                            ENUM_TIMESPAN = Service_Mesh.Enum_Timespan.X_DAILY_COLLECTION
                        }).i_Result;
                        oList_Kpi_Value_By_Date = oList_Area_kpi_data.Select(oArea_kpi_data => new Kpi_Value_By_Date()
                        {
                            RECORD_DATE = oArea_kpi_data.RECORD_DATE,
                            VALUE = oArea_kpi_data.VALUE,
                        }).ToList();
                    }
                    else if (i_Params_Get_Single_kpi_comparison.DATA_LEVEL_SETUP_ID == District_Level_SETUP_ID)
                    {
                        List<Service_Mesh.District_kpi_data> oList_District_kpi_data = this._service_mesh.Get_District_Kpi_Data_By_Where(new Service_Mesh.Params_Get_District_Kpi_Data_By_Where()
                        {
                            DISTRICT_ID_LIST = new List<long?> { i_Params_Get_Single_kpi_comparison.LEVEL_ID },
                            ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = new List<int?> { i_Params_Get_Single_kpi_comparison.ORGANIZATION_DATA_SOURCE_KPI_ID },
                            START_DATE = i_Params_Get_Single_kpi_comparison.START_DATE,
                            END_DATE = i_Params_Get_Single_kpi_comparison.END_DATE,
                            ENUM_TIMESPAN = Service_Mesh.Enum_Timespan.X_DAILY_COLLECTION
                        }).i_Result;
                        oList_Kpi_Value_By_Date = oList_District_kpi_data.Select(oDistrict_kpi_data => new Kpi_Value_By_Date()
                        {
                            RECORD_DATE = oDistrict_kpi_data.RECORD_DATE,
                            VALUE = oDistrict_kpi_data.VALUE,
                        }).ToList();
                    }
                    break;
            }

            #endregion

            #region Calculate Weekly/Monthly If Needed

            switch (i_Params_Get_Single_kpi_comparison.ENUM_TIMESPAN)
            {
                case Enum_Timespan.X_DAILY_COLLECTION:
                    break;
                case Enum_Timespan.X_WEEKLY_COLLECTION:
                    int startWeek = (int)Math.Floor((i_Params_Get_Single_kpi_comparison.START_DATE.Value - DateTime.MinValue).TotalDays / 7.0);
                    oList_Kpi_Value_By_Date = oList_Kpi_Value_By_Date.GroupBy(x => (int)Math.Floor((x.RECORD_DATE - i_Params_Get_Single_kpi_comparison.START_DATE).Value.TotalDays / 7.0) + startWeek)
                                                                                       .Select(kpi_value_by_date => new Kpi_Value_By_Date()
                                                                                       {
                                                                                           RECORD_DATE = i_Params_Get_Single_kpi_comparison.START_DATE.Value.AddDays((kpi_value_by_date.Key - startWeek) * 7),
                                                                                           VALUE = kpi_value_by_date.Sum(oKpi_value_by_date => oKpi_value_by_date.VALUE),
                                                                                       }).ToList();
                    break;
                case Enum_Timespan.X_MONTHLY_COLLECTION:
                    int startMonth = (int)Math.Floor((i_Params_Get_Single_kpi_comparison.START_DATE.Value - DateTime.MinValue).TotalDays / 30.0);
                    oList_Kpi_Value_By_Date = oList_Kpi_Value_By_Date.GroupBy(x => (int)Math.Floor((x.RECORD_DATE - i_Params_Get_Single_kpi_comparison.START_DATE).Value.TotalDays / 30.0) + startMonth)
                                                                                       .Select(kpi_value_by_date => new Kpi_Value_By_Date()
                                                                                       {
                                                                                           RECORD_DATE = i_Params_Get_Single_kpi_comparison.START_DATE.Value.AddDays((kpi_value_by_date.Key - startMonth) * 30),
                                                                                           VALUE = kpi_value_by_date.Sum(oKpi_value_by_date => oKpi_value_by_date.VALUE),
                                                                                       }).ToList();
                    break;
            }

            #endregion

            return oList_Kpi_Value_By_Date;
        }
        #endregion
        #region Get_Multi_kpi_comparison
        public List<Kpi_Value_By_Direction> Get_Multi_kpi_comparison(Params_Get_Multi_kpi_comparison i_Params_Get_Multi_kpi_comparison)
        {
            #region Declaration & Initialization

            List<Kpi_Value_By_Direction> oList_Kpi_Value_By_Direction = new List<Kpi_Value_By_Direction>();

            #endregion

            #region Get Data Level Setup

            #region Declaration & Initialization

            long? Site_Level_SETUP_ID = 0;
            long? Area_Level_SETUP_ID = 0;
            long? District_Level_SETUP_ID = 0;
            List<Setup_category> oList_Setup_category = new List<Setup_category>();

            #endregion

            var get_setup = Task.Run(() =>
            {
                oList_Setup_category = Props.Copy_Prop_Values_From_Api_Response<List<Setup_category>>(
                    this._service_mesh.Get_Setup_category_By_OWNER_ID(new Service_Mesh.Params_Get_Setup_category_By_OWNER_ID()
                    {
                        OWNER_ID = this.oBLC_Initializer.Owner_ID,
                    }).i_Result
                );
                Site_Level_SETUP_ID = oList_Setup_category.Find(setup_category => setup_category.SETUP_CATEGORY_NAME == "Data Level").List_Setup.Find(setup => setup.VALUE == "Site").SETUP_ID;
                Area_Level_SETUP_ID = oList_Setup_category.Find(setup_category => setup_category.SETUP_CATEGORY_NAME == "Data Level").List_Setup.Find(setup => setup.VALUE == "Area").SETUP_ID;
                District_Level_SETUP_ID = oList_Setup_category.Find(setup_category => setup_category.SETUP_CATEGORY_NAME == "Data Level").List_Setup.Find(setup => setup.VALUE == "District").SETUP_ID;
            });

            #endregion

            #region Get Organization_data_source_kpi

            #region Declaration & Initialization

            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();

            #endregion

            var get_organization_data_source_kpi_list = Task.Run(() =>
            {
                List<int?> List_Organization_data_source_kpi_ID = new List<int?>();
                List_Organization_data_source_kpi_ID = i_Params_Get_Multi_kpi_comparison.LIST_ORGANIZATION_DATA_SOURCE_KPI_BY_LEVEL.Select(oOrganization_data_source_kpi_By_Level => oOrganization_data_source_kpi_By_Level.ORGANIZATION_DATA_SOURCE_KPI_ID).Distinct().ToList();

                oList_Organization_data_source_kpi = Props.Copy_Prop_Values_From_Api_Response<List<Organization_data_source_kpi>>(this._service_mesh.Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv(new Service_Mesh.Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List()
                {
                    ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = List_Organization_data_source_kpi_ID
                }).i_Result);

                oList_Organization_data_source_kpi = oList_Organization_data_source_kpi.OrderBy(oOrganization_data_source_kpi => List_Organization_data_source_kpi_ID.IndexOf(oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID)).ToList();
            });

            #endregion

            Task.WaitAll(get_setup, get_organization_data_source_kpi_list);

            #region Get Levels

            #region Declaration & Initialation

            List<Site> oList_Site = new List<Site>();
            List<Area> oList_Area = new List<Area>();
            List<District> oList_District = new List<District>();

            #endregion

            #region Get_Sites

            var get_sites = Task.Run(() =>
            {
                List<long?> List_Site_ID = i_Params_Get_Multi_kpi_comparison.LIST_ORGANIZATION_DATA_SOURCE_KPI_BY_LEVEL.Where(oOrganizationdata_source_kpi_By_Level => oOrganizationdata_source_kpi_By_Level.DATA_LEVEL_SETUP_ID == Site_Level_SETUP_ID)
                                                                                                                        .Select(oOrganizationdata_source_kpi_By_Level => oOrganizationdata_source_kpi_By_Level.LEVEL_ID)
                                                                                                                        .Distinct()
                                                                                                                        .ToList();
                oList_Site = Props.Copy_Prop_Values_From_Api_Response<List<Site>>(this._service_mesh.Get_Site_By_SITE_ID_List(new Service_Mesh.Params_Get_Site_By_SITE_ID_List()
                {
                    SITE_ID_LIST = List_Site_ID
                }).i_Result);
            });

            #endregion

            #region Get_Areas

            var get_areas = Task.Run(() =>
            {
                List<long?> List_Area_ID = i_Params_Get_Multi_kpi_comparison.LIST_ORGANIZATION_DATA_SOURCE_KPI_BY_LEVEL.Where(oOrganizationdata_source_kpi_By_Level => oOrganizationdata_source_kpi_By_Level.DATA_LEVEL_SETUP_ID == Area_Level_SETUP_ID)
                                                                                                                        .Select(oOrganizationdata_source_kpi_By_Level => oOrganizationdata_source_kpi_By_Level.LEVEL_ID)
                                                                                                                        .Distinct()
                                                                                                                        .ToList();
                oList_Area = Props.Copy_Prop_Values_From_Api_Response<List<Area>>(this._service_mesh.Get_Area_By_AREA_ID_List(new Service_Mesh.Params_Get_Area_By_AREA_ID_List()
                {
                    AREA_ID_LIST = List_Area_ID
                }).i_Result);
            });

            #endregion

            #region Get_Districts

            var get_districts = Task.Run(() =>
            {
                List<long?> List_District_ID = i_Params_Get_Multi_kpi_comparison.LIST_ORGANIZATION_DATA_SOURCE_KPI_BY_LEVEL.Where(oOrganizationdata_source_kpi_By_Level => oOrganizationdata_source_kpi_By_Level.DATA_LEVEL_SETUP_ID == District_Level_SETUP_ID)
                                                                                                                        .Select(oOrganizationdata_source_kpi_By_Level => oOrganizationdata_source_kpi_By_Level.LEVEL_ID)
                                                                                                                        .Distinct()
                                                                                                                        .ToList();
                oList_District = Props.Copy_Prop_Values_From_Api_Response<List<District>>(this._service_mesh.Get_District_By_DISTRICT_ID_List(new Service_Mesh.Params_Get_District_By_DISTRICT_ID_List()
                {
                    DISTRICT_ID_LIST = List_District_ID
                }).i_Result);
            });

            #endregion

            Task.WaitAll(get_sites, get_areas, get_districts);

            #endregion

            #region Get oList_Kpi_Value_By_Direction

            #region Declaration & Initialization

            ConcurrentBag<Kpi_Value_By_Direction> oConcurrentBag_Kpi_Value_By_Direction = new ConcurrentBag<Kpi_Value_By_Direction>();

            #endregion

            string first_unit = oList_Organization_data_source_kpi[0].Kpi.UNIT;

            Parallel.ForEach(i_Params_Get_Multi_kpi_comparison.LIST_ORGANIZATION_DATA_SOURCE_KPI_BY_LEVEL, oOrganization_data_source_kpi_By_Level =>
            {
                #region Declaration & Initialization

                Kpi_Value_By_Direction oKpi_Value_By_Direction = new Kpi_Value_By_Direction();
                oKpi_Value_By_Direction.LIST_KPI_VALUE_BY_DATE = new List<Kpi_Value_By_Date>();

                #endregion

                #region Fill DIRECTION & LABEL

                Organization_data_source_kpi oOrganization_data_source_kpi = oList_Organization_data_source_kpi.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == oOrganization_data_source_kpi_By_Level.ORGANIZATION_DATA_SOURCE_KPI_ID);
                oKpi_Value_By_Direction.DIRECTION = (oOrganization_data_source_kpi.Kpi.UNIT == first_unit) ? "left" : "right";
                oKpi_Value_By_Direction.LABEL = oOrganization_data_source_kpi.Kpi.NAME;
                if (oOrganization_data_source_kpi_By_Level.DATA_LEVEL_SETUP_ID == Site_Level_SETUP_ID)
                {
                    oKpi_Value_By_Direction.LABEL = oKpi_Value_By_Direction.LABEL + " For Site: " + oList_Site.Find(_Site => _Site.SITE_ID == oOrganization_data_source_kpi_By_Level.LEVEL_ID).NAME;

                }
                else if (oOrganization_data_source_kpi_By_Level.DATA_LEVEL_SETUP_ID == Area_Level_SETUP_ID)
                {
                    oKpi_Value_By_Direction.LABEL = oKpi_Value_By_Direction.LABEL + " For Area: " + oList_Area.Find(_Area => _Area.AREA_ID == oOrganization_data_source_kpi_By_Level.LEVEL_ID).NAME;

                }
                else if (oOrganization_data_source_kpi_By_Level.DATA_LEVEL_SETUP_ID == District_Level_SETUP_ID)
                {
                    oKpi_Value_By_Direction.LABEL = oKpi_Value_By_Direction.LABEL + " For District: " + oList_District.Find(_District => _District.DISTRICT_ID == oOrganization_data_source_kpi_By_Level.LEVEL_ID).NAME;

                }

                #endregion

                #region Fill LIST_KPI_VALUE_BY_DATE

                switch (oOrganization_data_source_kpi.Kpi.NAME)
                {
                    case "Businesses By Category":
                        oKpi_Value_By_Direction.LIST_KPI_VALUE_BY_DATE = Props.Copy_Prop_Values_From_Api_Response<List<Kpi_Value_By_Date>>(this._service_mesh.Get_Business_Trendline(new Service_Mesh.Params_Get_Business_Trendline()
                        {
                            LIST_LEVEL_ID = new List<long?> { oOrganization_data_source_kpi_By_Level.LEVEL_ID },
                            LEVEL_SETUP_ID = oOrganization_data_source_kpi_By_Level.DATA_LEVEL_SETUP_ID,
                            START_DATE = i_Params_Get_Multi_kpi_comparison.START_DATE,
                            END_DATE = i_Params_Get_Multi_kpi_comparison.END_DATE,
                            ENUM_TIMESPAN = Service_Mesh.Enum_Timespan.X_DAILY_COLLECTION,
                            ORGANIZATION_ID = i_Params_Get_Multi_kpi_comparison.ORGANIZATION_ID
                        }).i_Result);
                        break;
                    case "Bylaw Complaints":
                        oKpi_Value_By_Direction.LIST_KPI_VALUE_BY_DATE = Props.Copy_Prop_Values_From_Api_Response<List<Kpi_Value_By_Date>>(this._service_mesh.Get_Bylaw_Complaints_Trendline(new Service_Mesh.Params_Get_Bylaw_Complaints_Trendline()
                        {
                            LIST_LEVEL_ID = new List<long?> { oOrganization_data_source_kpi_By_Level.LEVEL_ID },
                            LEVEL_SETUP_ID = oOrganization_data_source_kpi_By_Level.DATA_LEVEL_SETUP_ID,
                            START_DATE = i_Params_Get_Multi_kpi_comparison.START_DATE,
                            END_DATE = i_Params_Get_Multi_kpi_comparison.END_DATE,
                            ENUM_TIMESPAN = Service_Mesh.Enum_Timespan.X_DAILY_COLLECTION,
                            ORGANIZATION_ID = i_Params_Get_Multi_kpi_comparison.ORGANIZATION_ID
                        }).i_Result);
                        break;
                    case "Public Events":
                        oKpi_Value_By_Direction.LIST_KPI_VALUE_BY_DATE = Props.Copy_Prop_Values_From_Api_Response<List<Kpi_Value_By_Date>>(this._service_mesh.Get_Public_Events_Trendline(new Service_Mesh.Params_Get_Public_Events_Trendline()
                        {
                            LIST_LEVEL_ID = new List<long?> { oOrganization_data_source_kpi_By_Level.LEVEL_ID },
                            LEVEL_SETUP_ID = oOrganization_data_source_kpi_By_Level.DATA_LEVEL_SETUP_ID,
                            START_DATE = i_Params_Get_Multi_kpi_comparison.START_DATE,
                            END_DATE = i_Params_Get_Multi_kpi_comparison.END_DATE,
                            ENUM_TIMESPAN = Service_Mesh.Enum_Timespan.X_DAILY_COLLECTION,
                            ORGANIZATION_ID = i_Params_Get_Multi_kpi_comparison.ORGANIZATION_ID
                        }).i_Result);
                        break;
                    default:
                        if (oOrganization_data_source_kpi_By_Level.DATA_LEVEL_SETUP_ID == Site_Level_SETUP_ID)
                        {
                            List<Service_Mesh.Site_kpi_data> oList_Site_kpi_data = this._service_mesh.Get_Site_Kpi_Data_By_Where(new Service_Mesh.Params_Get_Site_Kpi_Data_By_Where()
                            {
                                SITE_ID_LIST = new List<long?> { oOrganization_data_source_kpi_By_Level.LEVEL_ID },
                                ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = new List<int?> { oOrganization_data_source_kpi_By_Level.ORGANIZATION_DATA_SOURCE_KPI_ID },
                                START_DATE = i_Params_Get_Multi_kpi_comparison.START_DATE,
                                END_DATE = i_Params_Get_Multi_kpi_comparison.END_DATE,
                                ENUM_TIMESPAN = Service_Mesh.Enum_Timespan.X_DAILY_COLLECTION
                            }).i_Result;
                            oKpi_Value_By_Direction.LIST_KPI_VALUE_BY_DATE = oList_Site_kpi_data.Select(oSite_kpi_data => new Kpi_Value_By_Date()
                            {
                                RECORD_DATE = oSite_kpi_data.RECORD_DATE,
                                VALUE = oSite_kpi_data.VALUE,
                            }).ToList();
                        }
                        else if (oOrganization_data_source_kpi_By_Level.DATA_LEVEL_SETUP_ID == Area_Level_SETUP_ID)
                        {
                            List<Service_Mesh.Area_kpi_data> oList_Area_kpi_data = this._service_mesh.Get_Area_Kpi_Data_By_Where(new Service_Mesh.Params_Get_Area_Kpi_Data_By_Where()
                            {
                                AREA_ID_LIST = new List<long?> { oOrganization_data_source_kpi_By_Level.LEVEL_ID },
                                ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = new List<int?> { oOrganization_data_source_kpi_By_Level.ORGANIZATION_DATA_SOURCE_KPI_ID },
                                START_DATE = i_Params_Get_Multi_kpi_comparison.START_DATE,
                                END_DATE = i_Params_Get_Multi_kpi_comparison.END_DATE,
                                ENUM_TIMESPAN = Service_Mesh.Enum_Timespan.X_DAILY_COLLECTION
                            }).i_Result;
                            oKpi_Value_By_Direction.LIST_KPI_VALUE_BY_DATE = oList_Area_kpi_data.Select(oArea_kpi_data => new Kpi_Value_By_Date()
                            {
                                RECORD_DATE = oArea_kpi_data.RECORD_DATE,
                                VALUE = oArea_kpi_data.VALUE,
                            }).ToList();
                        }
                        else if (oOrganization_data_source_kpi_By_Level.DATA_LEVEL_SETUP_ID == District_Level_SETUP_ID)
                        {
                            List<Service_Mesh.District_kpi_data> oList_District_kpi_data = this._service_mesh.Get_District_Kpi_Data_By_Where(new Service_Mesh.Params_Get_District_Kpi_Data_By_Where()
                            {
                                DISTRICT_ID_LIST = new List<long?> { oOrganization_data_source_kpi_By_Level.LEVEL_ID },
                                ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = new List<int?> { oOrganization_data_source_kpi_By_Level.ORGANIZATION_DATA_SOURCE_KPI_ID },
                                START_DATE = i_Params_Get_Multi_kpi_comparison.START_DATE,
                                END_DATE = i_Params_Get_Multi_kpi_comparison.END_DATE,
                                ENUM_TIMESPAN = Service_Mesh.Enum_Timespan.X_DAILY_COLLECTION
                            }).i_Result;
                            oKpi_Value_By_Direction.LIST_KPI_VALUE_BY_DATE = oList_District_kpi_data.Select(oDistrict_kpi_data => new Kpi_Value_By_Date()
                            {
                                RECORD_DATE = oDistrict_kpi_data.RECORD_DATE,
                                VALUE = oDistrict_kpi_data.VALUE,
                            }).ToList();
                        }
                        break;
                }

                #endregion

                #region Calculate Weekly/Monthly If Needed

                switch (i_Params_Get_Multi_kpi_comparison.ENUM_TIMESPAN)
                {
                    case Enum_Timespan.X_DAILY_COLLECTION:
                        break;
                    case Enum_Timespan.X_WEEKLY_COLLECTION:
                        int startWeek = (int)Math.Floor((i_Params_Get_Multi_kpi_comparison.START_DATE.Value - DateTime.MinValue).TotalDays / 7.0);
                        oKpi_Value_By_Direction.LIST_KPI_VALUE_BY_DATE = oKpi_Value_By_Direction.LIST_KPI_VALUE_BY_DATE.GroupBy(x => (int)Math.Floor((x.RECORD_DATE - i_Params_Get_Multi_kpi_comparison.START_DATE).Value.TotalDays / 7.0) + startWeek)
                                                                                           .Select(kpi_value_by_date => new Kpi_Value_By_Date()
                                                                                           {
                                                                                               RECORD_DATE = i_Params_Get_Multi_kpi_comparison.START_DATE.Value.AddDays((kpi_value_by_date.Key - startWeek) * 7),
                                                                                               VALUE = kpi_value_by_date.Sum(oKpi_value_by_date => oKpi_value_by_date.VALUE),
                                                                                           }).ToList();
                        break;
                    case Enum_Timespan.X_MONTHLY_COLLECTION:
                        int startMonth = (int)Math.Floor((i_Params_Get_Multi_kpi_comparison.START_DATE.Value - DateTime.MinValue).TotalDays / 30.0);
                        oKpi_Value_By_Direction.LIST_KPI_VALUE_BY_DATE = oKpi_Value_By_Direction.LIST_KPI_VALUE_BY_DATE.GroupBy(x => (int)Math.Floor((x.RECORD_DATE - i_Params_Get_Multi_kpi_comparison.START_DATE).Value.TotalDays / 30.0) + startMonth)
                                                                                           .Select(kpi_value_by_date => new Kpi_Value_By_Date()
                                                                                           {
                                                                                               RECORD_DATE = i_Params_Get_Multi_kpi_comparison.START_DATE.Value.AddDays((kpi_value_by_date.Key - startMonth) * 30),
                                                                                               VALUE = kpi_value_by_date.Sum(oKpi_value_by_date => oKpi_value_by_date.VALUE),
                                                                                           }).ToList();
                        break;
                }

                #endregion

                oConcurrentBag_Kpi_Value_By_Direction.Add(oKpi_Value_By_Direction);
            });

            oList_Kpi_Value_By_Direction = oConcurrentBag_Kpi_Value_By_Direction.ToList();

            #endregion

            return oList_Kpi_Value_By_Direction;
        }
        #endregion
        #region Get_Correlation
        public List<Kpi_Value_By_Date> Get_Correlation(Params_Get_Correlation i_Params_Get_Correlation)
        {
            List<Kpi_Value_By_Date> oList_Kpi_Value_By_Date_Correlation = new List<Kpi_Value_By_Date>();

            #region Declaration & Initialization

            List<Kpi_Value_By_Date> oList_Kpi_Value_By_Date_First = new List<Kpi_Value_By_Date>();
            List<Kpi_Value_By_Date> oList_Kpi_Value_By_Date_Second = new List<Kpi_Value_By_Date>();

            #endregion

            #region Get Correlation_method

            #region Declaration & Initialization

            Correlation_method oCorrelation_method = new Correlation_method();

            #endregion

            var get_correlation_method = Task.Run(() =>
            {
                oCorrelation_method = Get_Correlation_method_By_CORRELATION_METHOD_ID(new Params_Get_Correlation_method_By_CORRELATION_METHOD_ID()
                {
                    CORRELATION_METHOD_ID = i_Params_Get_Correlation.CORRELATION_METHOD_ID,
                });
            });

            #endregion

            #region Get Data Level Setup

            #region Declaration & Initialization

            long? Site_Level_SETUP_ID = 0;
            long? Area_Level_SETUP_ID = 0;
            long? District_Level_SETUP_ID = 0;
            List<Setup_category> oList_Setup_category = new List<Setup_category>();

            #endregion

            var get_setup = Task.Run(() =>
            {
                oList_Setup_category = Props.Copy_Prop_Values_From_Api_Response<List<Setup_category>>(
                    this._service_mesh.Get_Setup_category_By_OWNER_ID(new Service_Mesh.Params_Get_Setup_category_By_OWNER_ID()
                    {
                        OWNER_ID = this.oBLC_Initializer.Owner_ID,
                    }).i_Result
                );
                List<Setup> oList_Data_Level_Setup = oList_Setup_category.Find(setup_category => setup_category.SETUP_CATEGORY_NAME == "Data Level").List_Setup;
                Site_Level_SETUP_ID = oList_Data_Level_Setup.Find(setup => setup.VALUE == "Site").SETUP_ID;
                Area_Level_SETUP_ID = oList_Data_Level_Setup.Find(setup => setup.VALUE == "Area").SETUP_ID;
                District_Level_SETUP_ID = oList_Data_Level_Setup.Find(setup => setup.VALUE == "District").SETUP_ID;
            });

            #endregion

            #region Get Organization_data_source_kpi

            #region Declaration & Initialization

            Organization_data_source_kpi oFirst_Organization_data_source_kpi = new Organization_data_source_kpi();
            Organization_data_source_kpi oSecond_Organization_data_source_kpi = new Organization_data_source_kpi();

            #endregion

            var get_first_organization_data_source_kpi = Task.Run(() =>
            {
                oFirst_Organization_data_source_kpi = Props.Copy_Prop_Values_From_Api_Response<Organization_data_source_kpi>(this._service_mesh.Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv(new Service_Mesh.Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID()
                {
                    ORGANIZATION_DATA_SOURCE_KPI_ID = i_Params_Get_Correlation.First_Organization_data_source_kpi_By_Level.ORGANIZATION_DATA_SOURCE_KPI_ID
                }).i_Result);
            });

            var get_second_organization_data_source_kpi = Task.Run(() =>
            {
                oSecond_Organization_data_source_kpi = Props.Copy_Prop_Values_From_Api_Response<Organization_data_source_kpi>(this._service_mesh.Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv(new Service_Mesh.Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID()
                {
                    ORGANIZATION_DATA_SOURCE_KPI_ID = i_Params_Get_Correlation.Second_Organization_data_source_kpi_By_Level.ORGANIZATION_DATA_SOURCE_KPI_ID
                }).i_Result);
            });

            #endregion

            Task.WaitAll(get_setup, get_first_organization_data_source_kpi, get_second_organization_data_source_kpi, get_correlation_method);

            #region Get oList_Kpi_Value_By_Date_First

            var get_list_kpi_value_by_date_first = Task.Run(() =>
            {
                switch (oFirst_Organization_data_source_kpi.Kpi.NAME)
                {
                    case "Number of Visitors":
                        if (i_Params_Get_Correlation.First_Organization_data_source_kpi_By_Level.DATA_LEVEL_SETUP_ID == Site_Level_SETUP_ID)
                        {
                            List<Service_Mesh.Site_kpi_data> oList_Site_kpi_data = this._service_mesh.Get_Site_Kpi_Data_By_Where(new Service_Mesh.Params_Get_Site_Kpi_Data_By_Where()
                            {
                                SITE_ID_LIST = new List<long?> { i_Params_Get_Correlation.First_Organization_data_source_kpi_By_Level.LEVEL_ID },
                                ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = new List<int?> { i_Params_Get_Correlation.First_Organization_data_source_kpi_By_Level.ORGANIZATION_DATA_SOURCE_KPI_ID },
                                START_DATE = i_Params_Get_Correlation.START_DATE,
                                END_DATE = i_Params_Get_Correlation.END_DATE,
                                ENUM_TIMESPAN = Service_Mesh.Enum_Timespan.X_DAILY_COLLECTION
                            }).i_Result;
                            oList_Kpi_Value_By_Date_First = oList_Site_kpi_data.Select(oSite_kpi_data => new Kpi_Value_By_Date()
                            {
                                RECORD_DATE = oSite_kpi_data.RECORD_DATE,
                                VALUE = oSite_kpi_data.VALUE,
                            }).ToList();
                        }
                        else if (i_Params_Get_Correlation.First_Organization_data_source_kpi_By_Level.DATA_LEVEL_SETUP_ID == Area_Level_SETUP_ID)
                        {
                            List<Service_Mesh.Area_kpi_data> oList_Area_kpi_data = this._service_mesh.Get_Area_Kpi_Data_By_Where(new Service_Mesh.Params_Get_Area_Kpi_Data_By_Where()
                            {
                                AREA_ID_LIST = new List<long?> { i_Params_Get_Correlation.First_Organization_data_source_kpi_By_Level.LEVEL_ID },
                                ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = new List<int?> { i_Params_Get_Correlation.First_Organization_data_source_kpi_By_Level.ORGANIZATION_DATA_SOURCE_KPI_ID },
                                START_DATE = i_Params_Get_Correlation.START_DATE,
                                END_DATE = i_Params_Get_Correlation.END_DATE,
                                ENUM_TIMESPAN = Service_Mesh.Enum_Timespan.X_DAILY_COLLECTION
                            }).i_Result;
                            oList_Kpi_Value_By_Date_First = oList_Area_kpi_data.Select(oArea_kpi_data => new Kpi_Value_By_Date()
                            {
                                RECORD_DATE = oArea_kpi_data.RECORD_DATE,
                                VALUE = oArea_kpi_data.VALUE,
                            }).ToList();
                        }
                        else if (i_Params_Get_Correlation.First_Organization_data_source_kpi_By_Level.DATA_LEVEL_SETUP_ID == District_Level_SETUP_ID)
                        {
                            List<Service_Mesh.District_kpi_data> oList_District_kpi_data = this._service_mesh.Get_District_Kpi_Data_By_Where(new Service_Mesh.Params_Get_District_Kpi_Data_By_Where()
                            {
                                DISTRICT_ID_LIST = new List<long?> { i_Params_Get_Correlation.First_Organization_data_source_kpi_By_Level.LEVEL_ID },
                                ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = new List<int?> { i_Params_Get_Correlation.First_Organization_data_source_kpi_By_Level.ORGANIZATION_DATA_SOURCE_KPI_ID },
                                START_DATE = i_Params_Get_Correlation.START_DATE,
                                END_DATE = i_Params_Get_Correlation.END_DATE,
                                ENUM_TIMESPAN = Service_Mesh.Enum_Timespan.X_DAILY_COLLECTION
                            }).i_Result;
                            oList_Kpi_Value_By_Date_First = oList_District_kpi_data.Select(oDistrict_kpi_data => new Kpi_Value_By_Date()
                            {
                                RECORD_DATE = oDistrict_kpi_data.RECORD_DATE,
                                VALUE = oDistrict_kpi_data.VALUE,
                            }).ToList();
                        }
                        break;
                    case "Businesses By Category":
                        oList_Kpi_Value_By_Date_First = Props.Copy_Prop_Values_From_Api_Response<List<Kpi_Value_By_Date>>(this._service_mesh.Get_Business_Trendline(new Service_Mesh.Params_Get_Business_Trendline()
                        {
                            LIST_LEVEL_ID = new List<long?> { i_Params_Get_Correlation.First_Organization_data_source_kpi_By_Level.LEVEL_ID },
                            LEVEL_SETUP_ID = i_Params_Get_Correlation.First_Organization_data_source_kpi_By_Level.DATA_LEVEL_SETUP_ID,
                            START_DATE = i_Params_Get_Correlation.START_DATE,
                            END_DATE = i_Params_Get_Correlation.END_DATE,
                            ENUM_TIMESPAN = Service_Mesh.Enum_Timespan.X_DAILY_COLLECTION,
                            ORGANIZATION_ID = i_Params_Get_Correlation.ORGANIZATION_ID
                        }).i_Result);
                        break;
                    case "Bylaw Complaints":
                        oList_Kpi_Value_By_Date_First = Props.Copy_Prop_Values_From_Api_Response<List<Kpi_Value_By_Date>>(this._service_mesh.Get_Bylaw_Complaints_Trendline(new Service_Mesh.Params_Get_Bylaw_Complaints_Trendline()
                        {
                            LIST_LEVEL_ID = new List<long?> { i_Params_Get_Correlation.First_Organization_data_source_kpi_By_Level.LEVEL_ID },
                            LEVEL_SETUP_ID = i_Params_Get_Correlation.First_Organization_data_source_kpi_By_Level.DATA_LEVEL_SETUP_ID,
                            START_DATE = i_Params_Get_Correlation.START_DATE,
                            END_DATE = i_Params_Get_Correlation.END_DATE,
                            ENUM_TIMESPAN = Service_Mesh.Enum_Timespan.X_DAILY_COLLECTION,
                            ORGANIZATION_ID = i_Params_Get_Correlation.ORGANIZATION_ID
                        }).i_Result);
                        break;
                    case "Public Events":
                        oList_Kpi_Value_By_Date_First = Props.Copy_Prop_Values_From_Api_Response<List<Kpi_Value_By_Date>>(this._service_mesh.Get_Public_Events_Trendline(new Service_Mesh.Params_Get_Public_Events_Trendline()
                        {
                            LIST_LEVEL_ID = new List<long?> { i_Params_Get_Correlation.First_Organization_data_source_kpi_By_Level.LEVEL_ID },
                            LEVEL_SETUP_ID = i_Params_Get_Correlation.First_Organization_data_source_kpi_By_Level.DATA_LEVEL_SETUP_ID,
                            START_DATE = i_Params_Get_Correlation.START_DATE,
                            END_DATE = i_Params_Get_Correlation.END_DATE,
                            ENUM_TIMESPAN = Service_Mesh.Enum_Timespan.X_DAILY_COLLECTION,
                            ORGANIZATION_ID = i_Params_Get_Correlation.ORGANIZATION_ID
                        }).i_Result);
                        break;
                }
            });

            #endregion

            #region Get oList_Kpi_Value_By_Date_Second

            var get_list_kpi_value_by_date_second = Task.Run(() =>
            {
                switch (oSecond_Organization_data_source_kpi.Kpi.NAME)
                {
                    case "Number of Visitors":
                        if (i_Params_Get_Correlation.Second_Organization_data_source_kpi_By_Level.DATA_LEVEL_SETUP_ID == Site_Level_SETUP_ID)
                        {
                            List<Service_Mesh.Site_kpi_data> oList_Site_kpi_data = this._service_mesh.Get_Site_Kpi_Data_By_Where(new Service_Mesh.Params_Get_Site_Kpi_Data_By_Where()
                            {
                                SITE_ID_LIST = new List<long?> { i_Params_Get_Correlation.Second_Organization_data_source_kpi_By_Level.LEVEL_ID },
                                ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = new List<int?> { i_Params_Get_Correlation.Second_Organization_data_source_kpi_By_Level.ORGANIZATION_DATA_SOURCE_KPI_ID },
                                START_DATE = i_Params_Get_Correlation.START_DATE,
                                END_DATE = i_Params_Get_Correlation.END_DATE,
                                ENUM_TIMESPAN = Service_Mesh.Enum_Timespan.X_DAILY_COLLECTION
                            }).i_Result;
                            oList_Kpi_Value_By_Date_Second = oList_Site_kpi_data.Select(oSite_kpi_data => new Kpi_Value_By_Date()
                            {
                                RECORD_DATE = oSite_kpi_data.RECORD_DATE,
                                VALUE = oSite_kpi_data.VALUE,
                            }).ToList();
                        }
                        else if (i_Params_Get_Correlation.Second_Organization_data_source_kpi_By_Level.DATA_LEVEL_SETUP_ID == Area_Level_SETUP_ID)
                        {
                            List<Service_Mesh.Area_kpi_data> oList_Area_kpi_data = this._service_mesh.Get_Area_Kpi_Data_By_Where(new Service_Mesh.Params_Get_Area_Kpi_Data_By_Where()
                            {
                                AREA_ID_LIST = new List<long?> { i_Params_Get_Correlation.Second_Organization_data_source_kpi_By_Level.LEVEL_ID },
                                ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = new List<int?> { i_Params_Get_Correlation.Second_Organization_data_source_kpi_By_Level.ORGANIZATION_DATA_SOURCE_KPI_ID },
                                START_DATE = i_Params_Get_Correlation.START_DATE,
                                END_DATE = i_Params_Get_Correlation.END_DATE,
                                ENUM_TIMESPAN = Service_Mesh.Enum_Timespan.X_DAILY_COLLECTION
                            }).i_Result;
                            oList_Kpi_Value_By_Date_Second = oList_Area_kpi_data.Select(oArea_kpi_data => new Kpi_Value_By_Date()
                            {
                                RECORD_DATE = oArea_kpi_data.RECORD_DATE,
                                VALUE = oArea_kpi_data.VALUE,
                            }).ToList();
                        }
                        else if (i_Params_Get_Correlation.Second_Organization_data_source_kpi_By_Level.DATA_LEVEL_SETUP_ID == District_Level_SETUP_ID)
                        {
                            List<Service_Mesh.District_kpi_data> oList_District_kpi_data = this._service_mesh.Get_District_Kpi_Data_By_Where(new Service_Mesh.Params_Get_District_Kpi_Data_By_Where()
                            {
                                DISTRICT_ID_LIST = new List<long?> { i_Params_Get_Correlation.Second_Organization_data_source_kpi_By_Level.LEVEL_ID },
                                ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = new List<int?> { i_Params_Get_Correlation.Second_Organization_data_source_kpi_By_Level.ORGANIZATION_DATA_SOURCE_KPI_ID },
                                START_DATE = i_Params_Get_Correlation.START_DATE,
                                END_DATE = i_Params_Get_Correlation.END_DATE,
                                ENUM_TIMESPAN = Service_Mesh.Enum_Timespan.X_DAILY_COLLECTION
                            }).i_Result;
                            oList_Kpi_Value_By_Date_Second = oList_District_kpi_data.Select(oDistrict_kpi_data => new Kpi_Value_By_Date()
                            {
                                RECORD_DATE = oDistrict_kpi_data.RECORD_DATE,
                                VALUE = oDistrict_kpi_data.VALUE,
                            }).ToList();
                        }
                        break;
                    case "Businesses By Category":
                        oList_Kpi_Value_By_Date_Second = Props.Copy_Prop_Values_From_Api_Response<List<Kpi_Value_By_Date>>(this._service_mesh.Get_Business_Trendline(new Service_Mesh.Params_Get_Business_Trendline()
                        {
                            LIST_LEVEL_ID = new List<long?> { i_Params_Get_Correlation.Second_Organization_data_source_kpi_By_Level.LEVEL_ID },
                            LEVEL_SETUP_ID = i_Params_Get_Correlation.Second_Organization_data_source_kpi_By_Level.DATA_LEVEL_SETUP_ID,
                            START_DATE = i_Params_Get_Correlation.START_DATE,
                            END_DATE = i_Params_Get_Correlation.END_DATE,
                            ENUM_TIMESPAN = Service_Mesh.Enum_Timespan.X_DAILY_COLLECTION,
                            ORGANIZATION_ID = i_Params_Get_Correlation.ORGANIZATION_ID
                        }).i_Result);
                        break;
                    case "Bylaw Complaints":
                        oList_Kpi_Value_By_Date_Second = Props.Copy_Prop_Values_From_Api_Response<List<Kpi_Value_By_Date>>(this._service_mesh.Get_Bylaw_Complaints_Trendline(new Service_Mesh.Params_Get_Bylaw_Complaints_Trendline()
                        {
                            LIST_LEVEL_ID = new List<long?> { i_Params_Get_Correlation.Second_Organization_data_source_kpi_By_Level.LEVEL_ID },
                            LEVEL_SETUP_ID = i_Params_Get_Correlation.Second_Organization_data_source_kpi_By_Level.DATA_LEVEL_SETUP_ID,
                            START_DATE = i_Params_Get_Correlation.START_DATE,
                            END_DATE = i_Params_Get_Correlation.END_DATE,
                            ENUM_TIMESPAN = Service_Mesh.Enum_Timespan.X_DAILY_COLLECTION,
                            ORGANIZATION_ID = i_Params_Get_Correlation.ORGANIZATION_ID
                        }).i_Result);
                        break;
                    case "Public Events":
                        oList_Kpi_Value_By_Date_Second = Props.Copy_Prop_Values_From_Api_Response<List<Kpi_Value_By_Date>>(this._service_mesh.Get_Public_Events_Trendline(new Service_Mesh.Params_Get_Public_Events_Trendline()
                        {
                            LIST_LEVEL_ID = new List<long?> { i_Params_Get_Correlation.Second_Organization_data_source_kpi_By_Level.LEVEL_ID },
                            LEVEL_SETUP_ID = i_Params_Get_Correlation.Second_Organization_data_source_kpi_By_Level.DATA_LEVEL_SETUP_ID,
                            START_DATE = i_Params_Get_Correlation.START_DATE,
                            END_DATE = i_Params_Get_Correlation.END_DATE,
                            ENUM_TIMESPAN = Service_Mesh.Enum_Timespan.X_DAILY_COLLECTION,
                            ORGANIZATION_ID = i_Params_Get_Correlation.ORGANIZATION_ID
                        }).i_Result);
                        break;
                }
            });

            #endregion

            Task.WaitAll(get_list_kpi_value_by_date_first, get_list_kpi_value_by_date_second);

            #region Calculate Weekly/Monthly If Needed

            oList_Kpi_Value_By_Date_First = oList_Kpi_Value_By_Date_First.DistinctBy(kpi_value_by_date => kpi_value_by_date.RECORD_DATE.Value.Date).ToList();
            oList_Kpi_Value_By_Date_Second = oList_Kpi_Value_By_Date_Second.DistinctBy(kpi_value_by_date => kpi_value_by_date.RECORD_DATE.Value.Date).ToList();
            switch (i_Params_Get_Correlation.ENUM_TIMESPAN)
            {
                case Enum_Timespan.X_DAILY_COLLECTION:
                    break;
                case Enum_Timespan.X_WEEKLY_COLLECTION:
                    int startWeek = (int)Math.Floor((i_Params_Get_Correlation.START_DATE.Value - DateTime.MinValue).TotalDays / 7.0);
                    oList_Kpi_Value_By_Date_First = oList_Kpi_Value_By_Date_First.GroupBy(x => (int)Math.Floor((x.RECORD_DATE - i_Params_Get_Correlation.START_DATE).Value.TotalDays / 7.0) + startWeek)
                                                                                       .Select(kpi_value_by_date => new Kpi_Value_By_Date()
                                                                                       {
                                                                                           RECORD_DATE = i_Params_Get_Correlation.START_DATE.Value.AddDays((kpi_value_by_date.Key - startWeek) * 7),
                                                                                           VALUE = kpi_value_by_date.Sum(oKpi_value_by_date => oKpi_value_by_date.VALUE),
                                                                                       }).ToList();
                    oList_Kpi_Value_By_Date_Second = oList_Kpi_Value_By_Date_Second.GroupBy(x => (int)Math.Floor((x.RECORD_DATE - i_Params_Get_Correlation.START_DATE).Value.TotalDays / 7.0) + startWeek)
                                                                                       .Select(kpi_value_by_date => new Kpi_Value_By_Date()
                                                                                       {
                                                                                           RECORD_DATE = i_Params_Get_Correlation.START_DATE.Value.AddDays((kpi_value_by_date.Key - startWeek) * 7),
                                                                                           VALUE = kpi_value_by_date.Sum(oKpi_value_by_date => oKpi_value_by_date.VALUE),
                                                                                       }).ToList();
                    break;
                case Enum_Timespan.X_MONTHLY_COLLECTION:
                    int startMonth = (int)Math.Floor((i_Params_Get_Correlation.START_DATE.Value - DateTime.MinValue).TotalDays / 30.0);
                    oList_Kpi_Value_By_Date_First = oList_Kpi_Value_By_Date_First.GroupBy(x => (int)Math.Floor((x.RECORD_DATE - i_Params_Get_Correlation.START_DATE).Value.TotalDays / 30.0) + startMonth)
                                                                                       .Select(kpi_value_by_date => new Kpi_Value_By_Date()
                                                                                       {
                                                                                           RECORD_DATE = i_Params_Get_Correlation.START_DATE.Value.AddDays((kpi_value_by_date.Key - startMonth) * 30),
                                                                                           VALUE = kpi_value_by_date.Sum(oKpi_value_by_date => oKpi_value_by_date.VALUE),
                                                                                       }).ToList();
                    oList_Kpi_Value_By_Date_Second = oList_Kpi_Value_By_Date_Second.GroupBy(x => (int)Math.Floor((x.RECORD_DATE - i_Params_Get_Correlation.START_DATE).Value.TotalDays / 30.0) + startMonth)
                                                                                       .Select(kpi_value_by_date => new Kpi_Value_By_Date()
                                                                                       {
                                                                                           RECORD_DATE = i_Params_Get_Correlation.START_DATE.Value.AddDays((kpi_value_by_date.Key - startMonth) * 30),
                                                                                           VALUE = kpi_value_by_date.Sum(oKpi_value_by_date => oKpi_value_by_date.VALUE),
                                                                                       }).ToList();
                    break;
            }

            #endregion

            #region Check If The Two Lists Are Equal

            var allDates = new HashSet<DateTime>(oList_Kpi_Value_By_Date_First.Select(x => x.RECORD_DATE.Value.Date)
                .Concat(oList_Kpi_Value_By_Date_Second.Select(x => x.RECORD_DATE.Value.Date)).Distinct());

            foreach (var date in allDates)
            {
                if (!oList_Kpi_Value_By_Date_First.Any(x => x.RECORD_DATE.Value.Date == date))
                {
                    oList_Kpi_Value_By_Date_First.Add(new Kpi_Value_By_Date()
                    {
                        RECORD_DATE = date,
                        VALUE = 0,
                    });
                }

                if (!oList_Kpi_Value_By_Date_Second.Any(x => x.RECORD_DATE.Value.Date == date))
                {
                    oList_Kpi_Value_By_Date_Second.Add(new Kpi_Value_By_Date()
                    {
                        RECORD_DATE = date,
                        VALUE = 0,
                    });
                }
            }

            #endregion

            #region Call Python Function

            oList_Kpi_Value_By_Date_First = oList_Kpi_Value_By_Date_First.OrderBy(kpi_value_by_date => kpi_value_by_date.RECORD_DATE).ToList();
            oList_Kpi_Value_By_Date_Second = oList_Kpi_Value_By_Date_Second.OrderBy(kpi_value_by_date => kpi_value_by_date.RECORD_DATE).ToList();
            switch (oCorrelation_method.NAME)
            {
                case "Spearman":
                    oList_Kpi_Value_By_Date_Correlation = this._service_mesh.Process_Spearman_Correlation(new Service_Mesh.Params_Process_Spearman_Correlation()
                    {
                        X = oList_Kpi_Value_By_Date_First.Select(kpi_value_by_date => kpi_value_by_date.VALUE).ToList(),
                        Y = oList_Kpi_Value_By_Date_Second.Select(kpi_value_by_date => kpi_value_by_date.VALUE).ToList(),
                        R = i_Params_Get_Correlation.RESOLUTION,
                    }).i_Result?.Select((correlation_value, i) => new Kpi_Value_By_Date()
                    {
                        RECORD_DATE = oList_Kpi_Value_By_Date_First[i * i_Params_Get_Correlation.RESOLUTION.Value].RECORD_DATE,
                        VALUE = correlation_value,
                    }).ToList();
                    break;
                case "Pearson":
                    oList_Kpi_Value_By_Date_Correlation = this._service_mesh.Process_Pearson_Correlation(new Service_Mesh.Params_Process_Pearson_Correlation()
                    {
                        X = oList_Kpi_Value_By_Date_First.Select(kpi_value_by_date => kpi_value_by_date.VALUE).ToList(),
                        Y = oList_Kpi_Value_By_Date_Second.Select(kpi_value_by_date => kpi_value_by_date.VALUE).ToList(),
                        R = i_Params_Get_Correlation.RESOLUTION,
                    }).i_Result?.Select((correlation_value, i) => new Kpi_Value_By_Date()
                    {
                        RECORD_DATE = oList_Kpi_Value_By_Date_First[i * i_Params_Get_Correlation.RESOLUTION.Value].RECORD_DATE,
                        VALUE = correlation_value,
                    }).ToList();
                    break;
                case "Kendall":
                    oList_Kpi_Value_By_Date_Correlation = this._service_mesh.Process_Kendall_Correlation(new Service_Mesh.Params_Process_Kendall_Correlation()
                    {
                        X = oList_Kpi_Value_By_Date_First.Select(kpi_value_by_date => kpi_value_by_date.VALUE).ToList(),
                        Y = oList_Kpi_Value_By_Date_Second.Select(kpi_value_by_date => kpi_value_by_date.VALUE).ToList(),
                        R = i_Params_Get_Correlation.RESOLUTION,
                    }).i_Result?.Select((correlation_value, i) => new Kpi_Value_By_Date()
                    {
                        RECORD_DATE = oList_Kpi_Value_By_Date_First[i * i_Params_Get_Correlation.RESOLUTION.Value].RECORD_DATE,
                        VALUE = correlation_value,
                    }).ToList();
                    break;
            }

            #endregion
            return oList_Kpi_Value_By_Date_Correlation;
        }
        #endregion
    }
}