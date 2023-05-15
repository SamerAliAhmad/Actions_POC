using System;
using System.IO;
using System.Linq;
using SmartrTools;
using System.Configuration;
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

        #region Utils
        public string Get_File_Full_Path(string i_File_Name)
        {
            return $@"{ConfigurationManager.AppSettings["ASSETS_LOCATION"]}/{i_File_Name}";
        }
        #endregion
        #region Delete_Object
        public void Delete_Object(Params_Delete_Object i_Params_Delete_Object)
        {
            try
            {
                string oFull_Path = Get_File_Full_Path(i_Params_Delete_Object.Object_Name);
                File.Delete(oFull_Path);
            }
            catch
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0027)); // Delete Failed.
            }
        }
        public void Delete_Object_List(Params_Delete_Object_List i_Params_Delete_Object_List)
        {
            foreach (var oObject_Name in i_Params_Delete_Object_List.List_Object_Name)
            {
                Delete_Object(new Params_Delete_Object()
                {
                    Object_Name = oObject_Name,
                });
            }
        }
        #endregion
        #region Upload_Object
        public void Upload_Object(Params_Upload_Object i_Params_Upload_Object)
        {
            try
            {
                string file_Full_Path = Get_File_Full_Path(i_Params_Upload_Object.Object_Name);
                if (!Directory.Exists(Path.GetDirectoryName(file_Full_Path)))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(file_Full_Path));
                }
                if (File.Exists(file_Full_Path))
                {
                    File.Delete(file_Full_Path);
                }
                FileStream objFileStrm = File.Create(file_Full_Path);
                objFileStrm.Close();
                File.WriteAllBytes(file_Full_Path, i_Params_Upload_Object.Data);
            }
            catch
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0026)); // Upload Failed.
            }
        }
        #endregion
        #region Upload_Asset
        public List<string> Upload_Asset(Params_Upload_Asset i_Params_Upload_Asset)
        {
            if (i_Params_Upload_Asset.List_Uploaded_File != null && i_Params_Upload_Asset.List_Uploaded_File.Count > 0)
            {
                List<string> oList_File_URLs = new List<string>();
                foreach (var formFile in i_Params_Upload_Asset.List_Uploaded_File)
                {
                    var fileName = formFile.FileName;
                    if (formFile.Length <= 0)
                    {
                        continue;
                    }

                    string Object_Name = $"{i_Params_Upload_Asset.Asset_Relative_Path}/{fileName}";

                    try
                    {
                        byte[] data;

                        using (var oMemoryStream = new MemoryStream())
                        {
                            formFile.CopyTo(oMemoryStream);
                            data = oMemoryStream.ToArray();
                        }
                        Upload_Object(new Params_Upload_Object()
                        {
                            Data = data,
                            Object_Name = Object_Name,
                        });
                        oList_File_URLs.Add($"{oList_File_URLs}/{Object_Name}");
                    }
                    catch
                    {
                        throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0026)); // Upload Failed.
                    }
                }
                return oList_File_URLs;
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }
        }
        #endregion
    }
}