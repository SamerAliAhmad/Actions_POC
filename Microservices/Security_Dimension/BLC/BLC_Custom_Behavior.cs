using System;
using System.Linq;
using SmartrTools;
using System.Collections.Generic;

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
        #region Delete_Incident
        public void Delete_Incident()
        {
            this._MongoDb.Delete_Incident();
        }
        #endregion
        #region Edit_Incident_List
        public void Edit_Incident_List(Params_Edit_Incident_List i_Params_Edit_Incident_List)
        {
            this._MongoDb.Edit_Incident_List(i_Params_Edit_Incident_List.INCIDENT_LIST.Select(incident =>
            {
                DALC.Incident oIncident = Props.Copy_Prop_Values_From_Api_Response<DALC.Incident>(incident);
                if (oIncident.CREATED_TIME != null)
                {
                    DateTime oDateTime = (DateTime)oIncident.CREATED_TIME;
                    oIncident.CREATED_TIME = new DateTime(oDateTime.Year, oDateTime.Month, oDateTime.Day, oDateTime.Hour, oDateTime.Minute, oDateTime.Second, DateTimeKind.Utc);
                }
                if (oIncident.ASSIGNED_TIME != null)
                {
                    DateTime oDateTime = (DateTime)oIncident.ASSIGNED_TIME;
                    oIncident.ASSIGNED_TIME = new DateTime(oDateTime.Year, oDateTime.Month, oDateTime.Day, oDateTime.Hour, oDateTime.Minute, oDateTime.Second, DateTimeKind.Utc);
                }
                if (oIncident.CLOSED_TIME != null)
                {
                    DateTime oDateTime = (DateTime)oIncident.CLOSED_TIME;
                    oIncident.CLOSED_TIME = new DateTime(oDateTime.Year, oDateTime.Month, oDateTime.Day, oDateTime.Hour, oDateTime.Minute, oDateTime.Second, DateTimeKind.Utc);
                }
                return oIncident;
            }).ToList());
        }
        #endregion
        #region Get_Incidents_By_Where
        public List<Incident> Get_Incidents_By_Where(Params_Get_Incidents_By_Where i_Params_Get_Incidents_By_Where)
        {
            return Props.Copy_Prop_Values_From_Api_Response<List<Incident>>(
                this._MongoDb.Get_Incidents_By_Where(
                    SITE_ID_LIST: i_Params_Get_Incidents_By_Where.SITE_ID_LIST,
                    SPACE_ID_LIST: i_Params_Get_Incidents_By_Where.SPACE_ID_LIST,
                    FLOOR_ID_LIST: i_Params_Get_Incidents_By_Where.FLOOR_ID_LIST,
                    ENTITY_ID_LIST: i_Params_Get_Incidents_By_Where.ENTITY_ID_LIST,
                    CLOSED_TIME_END: i_Params_Get_Incidents_By_Where.CLOSED_TIME_END,
                    INCIDENT_ID_LIST: i_Params_Get_Incidents_By_Where.INCIDENT_ID_LIST,
                    CREATED_TIME_END: i_Params_Get_Incidents_By_Where.CREATED_TIME_END,
                    ASSIGNED_TIME_END: i_Params_Get_Incidents_By_Where.ASSIGNED_TIME_END,
                    CLOSED_TIME_START: i_Params_Get_Incidents_By_Where.CLOSED_TIME_START,
                    CREATED_TIME_START: i_Params_Get_Incidents_By_Where.CREATED_TIME_START,
                    ASSIGNED_TIME_START: i_Params_Get_Incidents_By_Where.ASSIGNED_TIME_START,
                    SPACE_ASSET_ID_LIST: i_Params_Get_Incidents_By_Where.SPACE_ASSET_ID_LIST,
                    DIMENSION_ORDER_LIST: i_Params_Get_Incidents_By_Where.DIMENSION_ORDER_LIST,
                    SEVERITY_SETUP_ID_LIST: i_Params_Get_Incidents_By_Where.SEVERITY_SETUP_ID_LIST,
                    INCIDENT_CATEGORY_SETUP_ID_LIST: i_Params_Get_Incidents_By_Where.INCIDENT_CATEGORY_SETUP_ID_LIST
                )
            );
        }
        #endregion
        #region Get_Incidents_By_Where_Count
        public long Get_Incidents_By_Where_Count(Params_Get_Incidents_By_Where_Count i_Params_Get_Incidents_By_Where_Count)
        {
            return this._MongoDb.Get_Incidents_By_Where_Count(
                SITE_ID_LIST: i_Params_Get_Incidents_By_Where_Count.SITE_ID_LIST,
                SPACE_ID_LIST: i_Params_Get_Incidents_By_Where_Count.SPACE_ID_LIST,
                FLOOR_ID_LIST: i_Params_Get_Incidents_By_Where_Count.FLOOR_ID_LIST,
                ENTITY_ID_LIST: i_Params_Get_Incidents_By_Where_Count.ENTITY_ID_LIST,
                CLOSED_TIME_END: i_Params_Get_Incidents_By_Where_Count.CLOSED_TIME_END,
                INCIDENT_ID_LIST: i_Params_Get_Incidents_By_Where_Count.INCIDENT_ID_LIST,
                CREATED_TIME_END: i_Params_Get_Incidents_By_Where_Count.CREATED_TIME_END,
                ASSIGNED_TIME_END: i_Params_Get_Incidents_By_Where_Count.ASSIGNED_TIME_END,
                CLOSED_TIME_START: i_Params_Get_Incidents_By_Where_Count.CLOSED_TIME_START,
                CREATED_TIME_START: i_Params_Get_Incidents_By_Where_Count.CREATED_TIME_START,
                ASSIGNED_TIME_START: i_Params_Get_Incidents_By_Where_Count.ASSIGNED_TIME_START,
                SPACE_ASSET_ID_LIST: i_Params_Get_Incidents_By_Where_Count.SPACE_ASSET_ID_LIST,
                DIMENSION_ORDER_LIST: i_Params_Get_Incidents_By_Where_Count.DIMENSION_ORDER_LIST,
                SEVERITY_SETUP_ID_LIST: i_Params_Get_Incidents_By_Where_Count.SEVERITY_SETUP_ID_LIST,
                INCIDENT_CATEGORY_SETUP_ID_LIST: i_Params_Get_Incidents_By_Where_Count.INCIDENT_CATEGORY_SETUP_ID_LIST
            );
        }
        #endregion
        #region Get_Incidents_By_Where_Sorted_With_Pagination
        public Incident_With_Count Get_Incidents_By_Where_Sorted_With_Pagination(Params_Get_Incidents_By_Where_Sorted_With_Pagination i_Params_Get_Incidents_By_Where_Sorted_With_Pagination)
        {
            return Props.Copy_Prop_Values_From_Api_Response<Incident_With_Count>(
                this._MongoDb.Get_Incidents_By_Where_Sorted_With_Pagination(
                    END_ROW: i_Params_Get_Incidents_By_Where_Sorted_With_Pagination.END_ROW,
                    START_ROW: i_Params_Get_Incidents_By_Where_Sorted_With_Pagination.START_ROW,
                    SITE_ID_LIST: i_Params_Get_Incidents_By_Where_Sorted_With_Pagination.SITE_ID_LIST,
                    FLOOR_ID_LIST: i_Params_Get_Incidents_By_Where_Sorted_With_Pagination.FLOOR_ID_LIST,
                    SPACE_ID_LIST: i_Params_Get_Incidents_By_Where_Sorted_With_Pagination.SPACE_ID_LIST,
                    ENTITY_ID_LIST: i_Params_Get_Incidents_By_Where_Sorted_With_Pagination.ENTITY_ID_LIST,
                    CLOSED_TIME_END: i_Params_Get_Incidents_By_Where_Sorted_With_Pagination.CLOSED_TIME_END,
                    INCIDENT_ID_LIST: i_Params_Get_Incidents_By_Where_Sorted_With_Pagination.INCIDENT_ID_LIST,
                    CREATED_TIME_END: i_Params_Get_Incidents_By_Where_Sorted_With_Pagination.CREATED_TIME_END,
                    ASSIGNED_TIME_END: i_Params_Get_Incidents_By_Where_Sorted_With_Pagination.ASSIGNED_TIME_END,
                    CLOSED_TIME_START: i_Params_Get_Incidents_By_Where_Sorted_With_Pagination.CLOSED_TIME_START,
                    CREATED_TIME_START: i_Params_Get_Incidents_By_Where_Sorted_With_Pagination.CREATED_TIME_START,
                    ASSIGNED_TIME_START: i_Params_Get_Incidents_By_Where_Sorted_With_Pagination.ASSIGNED_TIME_START,
                    SPACE_ASSET_ID_LIST: i_Params_Get_Incidents_By_Where_Sorted_With_Pagination.SPACE_ASSET_ID_LIST,
                    DIMENSION_ORDER_LIST: i_Params_Get_Incidents_By_Where_Sorted_With_Pagination.DIMENSION_ORDER_LIST,
                    INCIDENT_CATEGORY_SETUP_ID_LIST: i_Params_Get_Incidents_By_Where_Sorted_With_Pagination.INCIDENT_CATEGORY_SETUP_ID_LIST
                )
            );
        }
        #endregion
    }
}