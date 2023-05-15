using System;
using System.Linq;
using System.Xml.Linq;
using System.Configuration;
using System.Threading.Tasks;
using System.Collections.Generic;

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
            OnPreEvent_Edit_Site += new PreEvent_Handler_Edit_Site(BLC_OnPreEvent_Edit_Site);
            OnPostEvent_Edit_Site += new PostEvent_Handler_Edit_Site(BLC_OnPostEvent_Edit_Site);
            OnPostEvent_Get_Site_By_SITE_ID += new PostEvent_Handler_Get_Site_By_SITE_ID(BLC_OnPostEvent_Get_Site_By_SITE_ID);
            OnPostEvent_Get_Site_By_OWNER_ID += new PostEvent_Handler_Get_Site_By_OWNER_ID(BLC_OnPostEvent_Get_Site_By_OWNER_ID);
            OnPostEvent_Get_Site_By_SITE_ID_List += new PostEvent_Handler_Get_Site_By_SITE_ID_List(BLC_OnPostEvent_Get_Site_By_SITE_ID_List);
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
        #region BLC_OnPostEvent_Get_Site_By_SITE_ID
        public void BLC_OnPostEvent_Get_Site_By_SITE_ID(ref Site i_Result, Params_Get_Site_By_SITE_ID i_Params_Get_Site_By_SITE_ID)
        {
            if (i_Result.LOGO_URL != null && !i_Result.LOGO_URL.StartsWith(Global.Assets_Endpoint))
            {
                i_Result.LOGO_URL = $"{Global.Assets_Endpoint}/{i_Result.LOGO_URL}";
            }
            if (i_Result.IMAGE_URL != null && !i_Result.IMAGE_URL.StartsWith(Global.Assets_Endpoint))
            {
                i_Result.IMAGE_URL = $"{Global.Assets_Endpoint}/{i_Result.IMAGE_URL}";
            }
            if (i_Result.SOLID_GLTF_URL != null && !i_Result.SOLID_GLTF_URL.StartsWith(Global.Assets_Endpoint))
            {
                i_Result.SOLID_GLTF_URL = $"{Global.Assets_Endpoint}/{i_Result.SOLID_GLTF_URL}";
            }
        }
        #endregion
        #region BLC_OnPostEvent_Get_Site_By_OWNER_ID
        public void BLC_OnPostEvent_Get_Site_By_OWNER_ID(List<Site> i_Result, Params_Get_Site_By_OWNER_ID i_Params_Get_Site_By_OWNER_ID)
        {
            if (i_Result != null && i_Result.Count > 0)
            {
                i_Result = i_Result.Select(site =>
                {
                    if (site.LOGO_URL != null && !site.LOGO_URL.StartsWith(Global.Assets_Endpoint))
                    {
                        site.LOGO_URL = $"{Global.Assets_Endpoint}/{site.LOGO_URL}";
                    }
                    if (site.IMAGE_URL != null && !site.IMAGE_URL.StartsWith(Global.Assets_Endpoint))
                    {
                        site.IMAGE_URL = $"{Global.Assets_Endpoint}/{site.IMAGE_URL}";
                    }
                    if (site.SOLID_GLTF_URL != null && !site.SOLID_GLTF_URL.StartsWith(Global.Assets_Endpoint))
                    {
                        site.SOLID_GLTF_URL = $"{Global.Assets_Endpoint}/{site.SOLID_GLTF_URL}";
                    }
                    return site;
                }).ToList();
            }
        }
        #endregion
        #region BLC_OnPostEvent_Get_Site_By_SITE_ID_List
        public void BLC_OnPostEvent_Get_Site_By_SITE_ID_List(ref List<Site> i_Result, Params_Get_Site_By_SITE_ID_List i_Params_Get_Site_By_SITE_ID_List)
        {
            if (i_Result != null && i_Result.Count > 0)
            {
                i_Result = i_Result.Select(site =>
                {
                    if (site.LOGO_URL != null && !site.LOGO_URL.StartsWith(Global.Assets_Endpoint))
                    {
                        site.LOGO_URL = $"{Global.Assets_Endpoint}/{site.LOGO_URL}";
                    }
                    if (site.IMAGE_URL != null && !site.IMAGE_URL.StartsWith(Global.Assets_Endpoint))
                    {
                        site.IMAGE_URL = $"{Global.Assets_Endpoint}/{site.IMAGE_URL}";
                    }
                    if (site.SOLID_GLTF_URL != null && !site.SOLID_GLTF_URL.StartsWith(Global.Assets_Endpoint))
                    {
                        site.SOLID_GLTF_URL = $"{Global.Assets_Endpoint}/{site.SOLID_GLTF_URL}";
                    }
                    return site;
                }).ToList();
            }
        }
        #endregion
        #region BLC_OnPreEvent_Edit_Site
        public void BLC_OnPreEvent_Edit_Site(Site i_Site, Enum_Edit_Mode i_Enum_Edit_Mode)
        {
            if (i_Site.LOGO_URL != null && i_Site.LOGO_URL.StartsWith(Global.Assets_Endpoint))
            {
                i_Site.LOGO_URL = i_Site.LOGO_URL.Remove(0, Global.Assets_Endpoint.Length + 1);
            }
            if (i_Site.IMAGE_URL != null && i_Site.IMAGE_URL.StartsWith(Global.Assets_Endpoint))
            {
                i_Site.IMAGE_URL = i_Site.IMAGE_URL.Remove(0, Global.Assets_Endpoint.Length + 1);
            }
            if (i_Site.SOLID_GLTF_URL != null && i_Site.SOLID_GLTF_URL.StartsWith(Global.Assets_Endpoint))
            {
                i_Site.SOLID_GLTF_URL = i_Site.SOLID_GLTF_URL.Remove(0, Global.Assets_Endpoint.Length + 1);
            }
        }
        #endregion
        #region BLC_OnPostEvent_Edit_Site
        public void BLC_OnPostEvent_Edit_Site(Site i_Site, Enum_Edit_Mode i_Enum_Edit_Mode)
        {
            if (i_Site.LOGO_URL != null && !i_Site.LOGO_URL.StartsWith(Global.Assets_Endpoint))
            {
                i_Site.LOGO_URL = $"{Global.Assets_Endpoint}/{i_Site.LOGO_URL}";
            }
            if (i_Site.IMAGE_URL != null && !i_Site.IMAGE_URL.StartsWith(Global.Assets_Endpoint))
            {
                i_Site.IMAGE_URL = $"{Global.Assets_Endpoint}/{i_Site.IMAGE_URL}";
            }
            if (i_Site.SOLID_GLTF_URL != null && !i_Site.SOLID_GLTF_URL.StartsWith(Global.Assets_Endpoint))
            {
                i_Site.SOLID_GLTF_URL = $"{Global.Assets_Endpoint}/{i_Site.SOLID_GLTF_URL}";
            }
        }
        #endregion
        #endregion
    }
    #endregion
}
