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

        #region Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID
        public Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID_Result Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID(Params_Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID i_Params_Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID)
        {
            Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID_Result oGet_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID_Result = null;

            if (i_Params_Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID != null)
            {
                if (i_Params_Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID.ENTITY_ID_LIST != null && i_Params_Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID.ENTITY_ID_LIST.Count() > 0)
                {
                    oGet_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID_Result = new Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID_Result();

                    oGet_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID_Result.LIST_ENTITY = new List<Entity>();
                    oGet_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID_Result.LIST_ENTITY = Get_Entity_By_ENTITY_ID_List(new Params_Get_Entity_By_ENTITY_ID_List() { ENTITY_ID_LIST = i_Params_Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID.ENTITY_ID_LIST });
                    if (oGet_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID_Result.LIST_ENTITY != null && oGet_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID_Result.LIST_ENTITY.Count > 0)
                    {
                        oGet_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID_Result.LIST_ENTITY = oGet_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID_Result.LIST_ENTITY.Where(entity => entity.TOP_LEVEL_ID == i_Params_Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID.TOP_LEVEL_ID).ToList();
                    }
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

            return oGet_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID_Result;
        }
        #endregion
    }
}