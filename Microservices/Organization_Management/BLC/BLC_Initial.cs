using System;
using System.Linq;
using SmartrTools;
using System.Xml.Linq;
using System.Configuration;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BLC
{
    #region BLC
    public partial class BLC : IDisposable
    {
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
            Task.WaitAll(get_sqlserver_connection_string);
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
        #region Subscribe To Events
        public void Subscribe_To_Events()
        {
            #region Body Section.
            OnPreEvent_Edit_Organization_level_access_List += new PreEvent_Handler_Edit_Organization_level_access_List(BLC_OnPreEvent_Edit_Organization_level_access_List);
            OnPostEvent_Get_Organization_By_OWNER_ID += new PostEvent_Handler_Get_Organization_By_OWNER_ID(BLC_OnPostEvent_Get_Organization_By_OWNER_ID);
            OnPostEvent_Delete_Organization_districtnex_module += new PostEvent_Handler_Delete_Organization_districtnex_module(BLC_OnPostEvent_Delete_Organization_districtnex_module);
            OnPostEvent_Get_Organization_By_ORGANIZATION_ID_List += new PostEvent_Handler_Get_Organization_By_ORGANIZATION_ID_List(BLC_OnPostEvent_Get_Organization_By_ORGANIZATION_ID_List);
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
        #region BLC_OnPreEvent_Edit_Organization_level_access_List
        public void BLC_OnPreEvent_Edit_Organization_level_access_List(Params_Edit_Organization_level_access_List i_Params_Edit_Organization_level_access_List)
        {
            if (i_Params_Edit_Organization_level_access_List.List_To_Delete.Count() > 0)
            {
                List<Service_Mesh.User_level_access> oList_User_access = this._service_mesh.Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List(new Service_Mesh.Params_Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List()
                {
                    ORGANIZATION_LEVEL_ACCESS_ID_LIST = i_Params_Edit_Organization_level_access_List.List_To_Delete
                }).i_Result;
                if (oList_User_access.Count > 0)
                {
                    this._service_mesh.Edit_User_level_access_List(new Service_Mesh.Params_Edit_User_level_access_List()
                    {
                        List_To_Delete = oList_User_access.Select(user_access => user_access.USER_LEVEL_ACCESS_ID)
                    });
                }
            }
        }
        #endregion

        #region BLC_OnPostEvent_Get_Organization_By_OWNER_ID
        public void BLC_OnPostEvent_Get_Organization_By_OWNER_ID(ref List<Organization> i_Result, Params_Get_Organization_By_OWNER_ID i_Params_Get_Organization_By_OWNER_ID)
        {
            if (i_Result != null && i_Result.Count > 0)
            {
                IEnumerable<int?> oList_ORGANIAZTION_ID = i_Result.Select(organization => organization.ORGANIZATION_ID);
                i_Result.RemoveAll(oOrganization => oOrganization.IS_DELETED == true);
                i_Result.RemoveAll(oOrganization => oOrganization.List_User.Any(oUser => oUser.USER_ID == this.oBLC_Initializer.User_ID));

                List<long?> Organization_Image_Setup_ID_List = i_Result.Where(oOrganization => oOrganization.List_Organization_image.Count > 0)
                                                                 .SelectMany(oOrganization => oOrganization.List_Organization_image
                                                                 .Select(organization_image => organization_image.IMAGE_TYPE_SETUP_ID)).ToList();

                var oList_Organization_Image_Setup = Get_Setup_By_SETUP_ID_List(new Params_Get_Setup_By_SETUP_ID_List()
                {
                    SETUP_ID_LIST = Organization_Image_Setup_ID_List
                });

                this.oUser = this._service_mesh.Get_User_By_USER_ID_Adv(new Service_Mesh.Params_Get_User_By_USER_ID()
                {
                    USER_ID = this.oBLC_Initializer.User_ID
                }).i_Result;

                Setup_category oOrganization_Type_Setup_category = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
                {
                    OWNER_ID = oBLC_Initializer.Owner_ID,
                    SETUP_CATEGORY_NAME = "Organization Type"
                });

                List<Setup> oList_Setup_Organization_Type = Get_Setup_By_SETUP_CATEGORY_ID(new Params_Get_Setup_By_SETUP_CATEGORY_ID()
                {
                    SETUP_CATEGORY_ID = oOrganization_Type_Setup_category.SETUP_CATEGORY_ID
                });

                long? organization_Setup_ID = oList_Setup_Organization_Type.Find(setup => setup.VALUE == "Organization").SETUP_ID;
                long? super_organization_Setup_ID = oList_Setup_Organization_Type.Find(setup => setup.VALUE == "Super Organization").SETUP_ID;

                // remove all super organizations if the user belongs to a regular organization
                if (this.oUser.Organization.ORGANIZATION_TYPE_SETUP_ID == organization_Setup_ID)
                {
                    i_Result.RemoveAll(organization => organization.ORGANIZATION_TYPE_SETUP_ID == super_organization_Setup_ID);
                }

                // Nested Select :)
                i_Result = i_Result.Select(oOrganization =>
                {
                    oOrganization.List_Organization_image = oOrganization.List_Organization_image.Select(oOrganization_image =>
                    {
                        oOrganization_image.Image_type_setup = oList_Organization_Image_Setup.First(oSetup => oSetup.SETUP_ID == oOrganization_image.IMAGE_TYPE_SETUP_ID);
                        return oOrganization_image;
                    }).ToList();

                    oOrganization.ORGANIZATION_FAVICON_URL = Get_Organization_URL_By_Setup_Value(oOrganization, "Favicon");
                    oOrganization.DARK_SQUARE_LOGO_URL = Get_Organization_URL_By_Setup_Value(oOrganization, "Dark_Square_Logo");
                    oOrganization.DARK_RECTANGLE_LOGO_URL = Get_Organization_URL_By_Setup_Value(oOrganization, "Dark_Rect_Logo");
                    oOrganization.LIGHT_SQUARE_LOGO_URL = Get_Organization_URL_By_Setup_Value(oOrganization, "Light_Square_Logo");
                    oOrganization.LIGHT_RECTANGLE_LOGO_URL = Get_Organization_URL_By_Setup_Value(oOrganization, "Light_Rect_Logo");

                    oOrganization.List_Organization_image = oOrganization.List_Organization_image.Select(oOrganization_image =>
                    {
                        oOrganization_image.Image_type_setup = null;
                        return oOrganization_image;
                    }).ToList();

                    if (!(this.oUser.User_type_setup.VALUE == "Super Admin" && oOrganization.List_User.Any(user => user.USER_ID == oUser.USER_ID)) &&
                        !(this.oUser.User_type_setup.VALUE == "Super Admin" && this.oUser.Organization.ORGANIZATION_TYPE_SETUP_ID == super_organization_Setup_ID))
                    {
                        Setup Super_admin_Setup = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
                        {
                            SETUP_CATEGORY_NAME = "User Type",
                            OWNER_ID = oBLC_Initializer.Owner_ID
                        }).List_Setup.Find(setup => setup.VALUE == "Super Admin");
                        oOrganization.List_User.RemoveAll(user => user.USER_TYPE_SETUP_ID == Super_admin_Setup.SETUP_ID);
                        oOrganization.List_User = oOrganization.List_User.Select(user =>
                        {
                            user.Organization = null;
                            user = null;
                            return user;
                        }).ToList();
                    }

                    return oOrganization;
                }).ToList();
            }
        }
        #endregion
        #region BLC_OnPostEvent_Delete_Organization_districtnex_module
        public void BLC_OnPostEvent_Delete_Organization_districtnex_module(Params_Delete_Organization_districtnex_module i_Params_Delete_Organization_districtnex_module)
        {
            List<Service_Mesh.User> oList_User = this._service_mesh.Get_User_By_ORGANIZATION_ID(new Service_Mesh.Params_Get_User_By_ORGANIZATION_ID()
            {
                ORGANIZATION_ID = _Organization_districtnex_module.ORGANIZATION_ID
            }).i_Result;
            if (oList_User.Count > 0)
            {
                List<User_districtnex_module> oList_User_districtnex_module = Props.Copy_Prop_Values_From_Api_Response<List<User_districtnex_module>>(
                    this._service_mesh.Get_User_districtnex_module_By_USER_ID_List(new Service_Mesh.Params_Get_User_districtnex_module_By_USER_ID_List()
                    {
                        USER_ID_LIST = oList_User.Select(user => user.USER_ID)
                    }).i_Result
                );

                this._service_mesh.Edit_User_districtnex_module_List(new Service_Mesh.Params_Edit_User_districtnex_module_List()
                {
                    List_To_Delete = oList_User_districtnex_module.Where(user_districtnex_module => user_districtnex_module.DISTRICTNEX_MODULE_ID == _Organization_districtnex_module.DISTRICTNEX_MODULE_ID).Select(user_districtnex_module => user_districtnex_module.USER_DISTRICTNEX_MODULE_ID),
                });
            }
        }
        #endregion
        #region BLC_OnPostEvent_Get_Organization_By_ORGANIZATION_ID_List
        public void BLC_OnPostEvent_Get_Organization_By_ORGANIZATION_ID_List(List<Organization> i_Result, Params_Get_Organization_By_ORGANIZATION_ID_List i_Params_Get_Organization_By_ORGANIZATION_ID_List)
        {
            if (i_Result != null && i_Result.Count > 0)
            {
                i_Result.RemoveAll(oOrganization => oOrganization.IS_DELETED == true);
                var Setup_ID_List = i_Result.Where(oOrganization => oOrganization.List_Organization_image.Count > 0).SelectMany(oOrganization => oOrganization.List_Organization_image.Select(organization_image => organization_image.IMAGE_TYPE_SETUP_ID));
                var oList_Setup = Get_Setup_By_SETUP_ID_List(new Params_Get_Setup_By_SETUP_ID_List()
                {
                    SETUP_ID_LIST = Setup_ID_List
                });

                i_Result = i_Result.Select(oOrganization =>
                {
                    oOrganization.List_Organization_image = oOrganization.List_Organization_image.Select(oOrganization_image =>
                    {
                        oOrganization_image.Image_type_setup = oList_Setup.First(oSetup => oSetup.SETUP_ID == oOrganization_image.IMAGE_TYPE_SETUP_ID);
                        return oOrganization_image;
                    }).ToList();
                    oOrganization.ORGANIZATION_FAVICON_URL = Get_Organization_URL_By_Setup_Value(oOrganization, "Favicon");
                    oOrganization.DARK_SQUARE_LOGO_URL = Get_Organization_URL_By_Setup_Value(oOrganization, "Dark_Square_Logo");
                    oOrganization.DARK_RECTANGLE_LOGO_URL = Get_Organization_URL_By_Setup_Value(oOrganization, "Dark_Rect_Logo");
                    oOrganization.LIGHT_SQUARE_LOGO_URL = Get_Organization_URL_By_Setup_Value(oOrganization, "Light_Square_Logo");
                    oOrganization.LIGHT_RECTANGLE_LOGO_URL = Get_Organization_URL_By_Setup_Value(oOrganization, "Light_Rect_Logo");
                    oOrganization.List_Organization_image = oOrganization.List_Organization_image.Select(oOrganization_image =>
                    {
                        oOrganization_image.Image_type_setup = null;
                        return oOrganization_image;
                    }).ToList();

                    return oOrganization;
                }).ToList();
            }
        }
        #endregion
        #endregion
    }
    #endregion
}
