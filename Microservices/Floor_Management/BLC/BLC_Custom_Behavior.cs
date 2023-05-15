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
        #region Get_Floor_By_ENTITY_ID_With_Space_Asset
        public List<Floor> Get_Floor_By_ENTITY_ID_With_Space_Asset(Params_Get_Floor_By_ENTITY_ID_With_Space_Asset i_Params_Get_Floor_By_ENTITY_ID_With_Space_Asset)
        {
            List<Floor> oList_Floor = new List<Floor>();

            if (i_Params_Get_Floor_By_ENTITY_ID_With_Space_Asset.ENTITY_ID != null)
            {
                oList_Floor = Get_Floor_By_ENTITY_ID(new Params_Get_Floor_By_ENTITY_ID()
                {
                    ENTITY_ID = i_Params_Get_Floor_By_ENTITY_ID_With_Space_Asset.ENTITY_ID
                });

                if (oList_Floor != null && oList_Floor.Count > 0)
                {
                    List<Space> oList_Space = oList_Floor.SelectMany(oFloor => oFloor.List_Space).ToList();
                    if (oList_Space != null && oList_Space.Count > 0)
                    {
                        List<Space_asset> oList_Space_asset = Get_Space_asset_By_SPACE_ID_List_Adv(new Params_Get_Space_asset_By_SPACE_ID_List()
                        {
                            SPACE_ID_LIST = oList_Space.Select(oSpace => oSpace.SPACE_ID).ToList()
                        });

                        if (oList_Space_asset != null && oList_Space_asset.Count > 0)
                        {
                            foreach (Space_asset oSpace_asset in oList_Space_asset)
                            {
                                oSpace_asset.Asset.GLTF_URL = $"{Global.Assets_Endpoint}/{oSpace_asset.Asset.GLTF_URL}";
                            }

                            foreach (Floor oFloor in oList_Floor)
                            {
                                if (oFloor.List_Space != null && oFloor.List_Space.Count > 0)
                                {
                                    foreach (Space oSpace in oFloor.List_Space)
                                    {
                                        oSpace.List_Space_asset = oList_Space_asset.Where(oSpace_asset => oSpace_asset.SPACE_ID == oSpace.SPACE_ID).ToList();
                                    }
                                }
                                else
                                {
                                    oFloor.List_Space = new List<Space>();
                                }
                            }
                        }
                        else
                        {
                            foreach (Floor oFloor in oList_Floor)
                            {
                                if (oFloor.List_Space != null && oFloor.List_Space.Count > 0)
                                {
                                    foreach (Space oSpace in oFloor.List_Space)
                                    {
                                        oSpace.List_Space_asset = new List<Space_asset>();
                                    }
                                }
                                else
                                {
                                    oFloor.List_Space = new List<Space>();
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }

            return oList_Floor;
        }
        #endregion
    }
}