using System;
using System.Linq;
using System.Xml.Linq;
using System.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLC
{
    #region BLC
    public partial class BLC : IDisposable
    {
        #region Constructor
        public BLC(string i_Ticket)
        {
            Init(Prepare_BLC_Initializer(i_Ticket));
        }
        public BLC(BLC_Initializer i_BLC_Initializer)
        {
            Init(i_BLC_Initializer);
        }
        #endregion
        #region Init
        public void Init(BLC_Initializer i_BLC_Initializer)
        {
            #region Body Section.
            // ---------------------
            this.oBLC_Initializer = i_BLC_Initializer;
            var get_sqlserver_connection_string = Task.Run(() =>
            {
                this.oBLC_Initializer.Connection_String = this._service_mesh.Get_Secret(new Service_Mesh.Params_Get_Secret()
                {
                    Secret_Id = ConfigurationManager.AppSettings["CONN_STR"]
                }).i_Result;
                this._AppContext = new DALC.MSSQL_DALC(this.oBLC_Initializer.Connection_String);
            });
            var get_mongodb_connection_string = Task.Run(() =>
            {
                this._MongoDb = new DALC.DALC_MONGODB(this._service_mesh.Get_Secret(new Service_Mesh.Params_Get_Secret()
                {
                    Secret_Id = ConfigurationManager.AppSettings["MONGODB_CONN_STR"]
                }).i_Result, ConfigurationManager.AppSettings["MONGODB_DATABASE_NAME"]);
            });
            Task.WaitAll(get_sqlserver_connection_string, get_mongodb_connection_string);
            // ---------------------
            Load_Messages();
            // Initialize_Cache_Dropper();
            Initialize_Reset_Mechanism();
            // Initialize_Audit_Mechanism();
            Initialize_Monitoring_Mechanism();
            Initialize_Eager_Loading_Mechanism();
            // Initialize_File_Uploading_Mechanism();
            Subscribe_To_Events();
            #endregion
        }
        #endregion
        #region Subscribe To Events
        public void Subscribe_To_Events()
        {
            #region Body Section.
            OnPostEvent_Edit_Default_settings += new PostEvent_Handler_Edit_Default_settings(BLC_OnPostEvent_Edit_Default_settings);
            OnPostEvent_Get_Default_settings_By_OWNER_ID += new PostEvent_Handler_Get_Default_settings_By_OWNER_ID(BLC_OnPostEvent_Get_Default_settings_By_OWNER_ID);
            #endregion
        }
        #endregion
        #region IDisposable Members
        public void Dispose()
        {
            #region Body Section.
            #endregion
        }
        #endregion
        #region Load_Messages
        public void Load_Messages()
        {
            #region Declaration And Initialization Section.
            XElement oRoot = null;
            XElement oLanguage = null;
            #endregion
            #region Body Section.
            this.oList_Message = new List<Message>();

            if (this.oBLC_Initializer.Messages_File_Path != null)
            {
                oRoot = XElement.Load(this.oBLC_Initializer.Messages_File_Path);
                if (oRoot != null)
                {
                    switch (this.oBLC_Initializer.Language)
                    {
                        case Enum_Language.English:
                            oLanguage = oRoot.Element("ENGLISH");
                            break;
                        case Enum_Language.Arabic:
                            oLanguage = oRoot.Element("ARABIC");
                            break;
                        default:
                            oLanguage = oRoot.Element("ENGLISH");
                            break;
                    }
                    if (oLanguage != null)
                    {
                        foreach (var oMessage in oLanguage.Elements("MESSAGE").Where(oMessage => oMessage.Attribute("CODE") != null && oMessage.Attribute("CONTENT") != null))
                        {
                            this.oList_Message.Add(new Message()
                            {
                                Code = oMessage.Attribute("CODE").Value,
                                Content = oMessage.Attribute("CONTENT").Value
                            });
                        }
                    }
                }
            }
            #endregion
        }
        #endregion
        #region Get_Message_Content
        public string Get_Message_Content(Enum_BR_Codes i_BR_Code)
        {
            if (this.oList_Message == null || this.oList_Message == default || this.oList_Message.Count == 0)
            {
                Load_Messages();
            }
            if (this.oList_Message != null && this.oList_Message != default && this.oList_Message.Count > 0)
            {
                var oMessage = this.oList_Message.FirstOrDefault(oMessage => oMessage.Code == i_BR_Code.ToString());
                if (oMessage != null && oMessage != default && oMessage.Content != default)
                {
                    return oMessage.Content;
                }
                else
                {
                    return "Cannot Load Desired Message";
                }
            }
            else
            {
                return "Cannot Load Desired Message";
            }
        }
        public string Get_Message_Content(Enum_BR_Codes i_BR_Code, Dictionary<string, string> i_PlaceHolders)
        {
            string oReturnValue = string.Empty;
            if (this.oList_Message == null || this.oList_Message == default || this.oList_Message.Count == 0)
            {
                Load_Messages();
            }
            if (this.oList_Message != null && this.oList_Message != default && this.oList_Message.Count > 0)
            {
                var oMessage = this.oList_Message.FirstOrDefault(oMessage => oMessage.Code == i_BR_Code.ToString());
                if (oMessage != null && oMessage != default && oMessage.Content != default)
                {
                    oReturnValue = oMessage.Content;
                    foreach (var oPlaceHolder in i_PlaceHolders)
                    {
                        oReturnValue = oReturnValue.Replace(oPlaceHolder.Key, oPlaceHolder.Value);
                    }
                    return oReturnValue;
                }
                else
                {
                    return "Cannot Load Desired Message";
                }
            }
            else
            {
                return "Cannot Load Desired Message";
            }
        }
        #endregion
        #region Events Implementation
        #region BLC_OnPostEvent_Edit_Default_settings
        public void BLC_OnPostEvent_Edit_Default_settings(Default_settings i_Default_settings, Enum_Edit_Mode i_Enum_Edit_Mode)
        {
            Task.Run(() =>
            {
                Update_Otp_Index(new Params_Update_Otp_Index()
                {
                    OTP_TTL_IN_SECONDS = i_Default_settings.OTP_TTL_IN_SECONDS
                });
            });
        }
        #endregion
        #region BLC_OnPostEvent_Get_Default_settings_By_OWNER_ID
        public void BLC_OnPostEvent_Get_Default_settings_By_OWNER_ID(ref List<Default_settings> i_Result, Params_Get_Default_settings_By_OWNER_ID i_Params_Get_Default_settings_By_OWNER_ID)
        {
            var first = i_Result.FirstOrDefault();
            if (first != null && first != default && first.List_Default_settings_image != null && first.List_Default_settings_image.Count > 0)
            {
                var Setup_ID_List = i_Result[0].List_Default_settings_image.Select(oDefault_settings_image => oDefault_settings_image.IMAGE_TYPE_SETUP_ID);
                var oList_Setup = Get_Setup_By_SETUP_ID_List(new Params_Get_Setup_By_SETUP_ID_List()
                {
                    SETUP_ID_LIST = Setup_ID_List
                });
                i_Result[0].List_Default_settings_image = i_Result[0].List_Default_settings_image.Select(oDefault_settings_image =>
                {
                    oDefault_settings_image.Image_type_setup = oList_Setup.First(oSetup => oSetup.SETUP_ID == oDefault_settings_image.IMAGE_TYPE_SETUP_ID);
                    return oDefault_settings_image;
                }).ToList();

                i_Result[0].ORGANIZATION_FAVICON_URL = Get_Default_Organization_URL_By_Setup_Value(i_Result[0], "Favicon");
                i_Result[0].DARK_SQUARE_LOGO_URL = Get_Default_Organization_URL_By_Setup_Value(i_Result[0], "Dark_Square_Logo");
                i_Result[0].DARK_RECTANGLE_LOGO_URL = Get_Default_Organization_URL_By_Setup_Value(i_Result[0], "Dark_Rect_Logo");
                i_Result[0].LIGHT_SQUARE_LOGO_URL = Get_Default_Organization_URL_By_Setup_Value(i_Result[0], "Light_Square_Logo");
                i_Result[0].LIGHT_RECTANGLE_LOGO_URL = Get_Default_Organization_URL_By_Setup_Value(i_Result[0], "Light_Rect_Logo");

                i_Result[0].List_Default_settings_image = i_Result[0].List_Default_settings_image.Select(oDefault_settings_image =>
                {
                    oDefault_settings_image.Image_type_setup = null;
                    return oDefault_settings_image;
                }).ToList();
            }
        }
        #endregion
        #endregion
    }
    #endregion
}
