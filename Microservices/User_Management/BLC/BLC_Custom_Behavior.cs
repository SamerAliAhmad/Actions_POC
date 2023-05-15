using System;
using System.Linq;
using SmartrTools;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Configuration;
using System.Net;
using MongoDB.Driver;
using MongoDB.Bson;

namespace BLC
{
    public partial class BLC
    {
        #region Utils
        public string Get_Organization_URL_By_Setup_Value(Organization i_Organization, string Setup_Value)
        {
            var oOrganization_image = i_Organization.List_Organization_image.LastOrDefault(oOrganization_image => oOrganization_image.Image_type_setup.VALUE == Setup_Value);
            if (oOrganization_image != null && oOrganization_image != default)
            {
                return $"{Global.Assets_Endpoint}/{Global.Assets_Org_Image_Path}/{oOrganization_image.IMAGE_NAME}.{oOrganization_image.IMAGE_EXTENSION}";
            }
            return null;
        }
        public long? Get_Setup_ID_By_Value(string setup_category_Name, string setup_value, List<Setup_category> i_List_Setup_category)
        {
            return i_List_Setup_category
                    .First(setup_category => setup_category.SETUP_CATEGORY_NAME == setup_category_Name)
                    .List_Setup
                    .First(setup => setup.VALUE.Equals(setup_value, StringComparison.OrdinalIgnoreCase))
                    .SETUP_ID;
        }
        public Setup Get_Setup_By_Setup_ID_From_Setup_Category_List(long? Setup_ID, List<Setup_category> i_List_Setup_category)
        {
            return i_List_Setup_category.SelectMany(setup_category => setup_category.List_Setup).First(oSetup => oSetup.SETUP_ID == Setup_ID);
        }
        #endregion
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
        #region Create_User
        public User Create_User(Params_Create_User i_Params_Create_User)
        {
            if (i_Params_Create_User.USER == null || i_Params_Create_User.ORGANIZATION_ID == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }

            i_Params_Create_User.USER.User_type_setup = Get_Setup_By_SETUP_ID(new Params_Get_Setup_By_SETUP_ID
            {
                SETUP_ID = i_Params_Create_User.USER.USER_TYPE_SETUP_ID
            });

            i_Params_Create_User.USER.USER_ID = -1;
            i_Params_Create_User.USER.IS_ACTIVE = true;
            i_Params_Create_User.USER.FIRST_NAME = i_Params_Create_User.USER.FIRST_NAME.ToTitleCase();
            i_Params_Create_User.USER.LAST_NAME = i_Params_Create_User.USER.LAST_NAME.ToTitleCase();
            Edit_User(i_Params_Create_User.USER);

            i_Params_Create_User.USER.PASSWORD = "";

            return Props.Copy_Prop_Values_From_Api_Response<User>(i_Params_Create_User.USER);
        }
        #endregion
        #region Restore_User
        public User Restore_User(Params_Restore_User i_Params_Restore_User)
        {
            if (i_Params_Restore_User.USER_ID != null && i_Params_Restore_User.USER_ID > 0)
            {
                User oUser = Get_User_By_USER_ID_Adv(new Params_Get_User_By_USER_ID
                {
                    USER_ID = i_Params_Restore_User.USER_ID
                });
                if (oUser != null)
                {
                    oUser.IS_ACTIVE = true;
                    oUser.DATE_DELETED = null;
                    oUser.DATA_RETENTION_PERIOD = null;
                    Edit_User(oUser);

                    Task.Run(() =>
                    {
                        Setup_category oLog_Type_Setup_category = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
                        {
                            SETUP_CATEGORY_NAME = "Log Type"
                        });
                        Setup_category oAccess_Type_Setup_category = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
                        {
                            SETUP_CATEGORY_NAME = "Access Type"
                        });
                        this._service_mesh.Create_Log(new Service_Mesh.Params_Create_Log()
                        {
                            MESSAGE = $"{oUser.FIRST_NAME} {oUser.LAST_NAME} Has Been Restored",
                            LOG_TYPE_SETUP_ID = oLog_Type_Setup_category.List_Setup.First(setup => setup.VALUE == "User Activation-Deactivation").SETUP_ID,
                            ACCESS_TYPE_SETUP_ID = oAccess_Type_Setup_category.List_Setup.First(setup => setup.VALUE == "Change").SETUP_ID,
                            USER_ID = oUser.USER_ID,
                        });
                    });

                    oUser.PASSWORD = "";
                    return oUser;
                }
                else
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0005)); // User Not Found
                }
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }
        }
        #endregion
        #region Get_Admin_Data
        public Admin_Data Get_Admin_Data(Params_Get_Admin_Data i_Params_Get_Admin_Data)
        {
            User oUser = Props.Copy_Prop_Values_From_Api_Response<User>(
                this._service_mesh.Get_User_By_USER_ID_Adv(new Service_Mesh.Params_Get_User_By_USER_ID()
                {
                    USER_ID = i_Params_Get_Admin_Data.USER_ID
                }).i_Result
            );
            if (oUser.IS_ACTIVE == false || oUser.Organization.IS_ACTIVE == false)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0041)); // Your account is deactivated. Please contact support.
            }
            if (oUser != null && oUser != default)
            {
                Admin_Data oAdmin_Data = new Admin_Data();
                var get_setup_categories = Task.Run(() =>
                {
                    oAdmin_Data.List_Setup_category = Get_Setup_category_By_OWNER_ID(new Params_Get_Setup_category_By_OWNER_ID()
                    {
                        OWNER_ID = this.oBLC_Initializer.Owner_ID
                    });
                });
                var get_sites = Task.Run(() =>
                {
                    oAdmin_Data.List_Site = Props.Copy_Prop_Values_From_Api_Response<List<Site>>(
                        this._service_mesh.Get_Site_By_OWNER_ID(new Service_Mesh.Params_Get_Site_By_OWNER_ID()
                        {
                            OWNER_ID = this.oBLC_Initializer.Owner_ID
                        }).i_Result
                    );
                });
                var get_entities = Task.Run(() =>
                {
                    oAdmin_Data.List_Entity = Props.Copy_Prop_Values_From_Api_Response<List<Entity>>(
                        this._service_mesh.Get_Entity_By_OWNER_ID(new Service_Mesh.Params_Get_Entity_By_OWNER_ID()
                        {
                            OWNER_ID = this.oBLC_Initializer.Owner_ID
                        }).i_Result
                    );
                });
                var get_dimensions = Task.Run(() =>
                {
                    oAdmin_Data.List_Dimension = Props.Copy_Prop_Values_From_Api_Response<List<Dimension>>(
                        this._service_mesh.Get_Dimension_By_OWNER_ID(new Service_Mesh.Params_Get_Dimension_By_OWNER_ID()
                        {
                            OWNER_ID = this.oBLC_Initializer.Owner_ID
                        }).i_Result
                    );
                });
                var get_organization = Task.Run(() =>
                {
                    oAdmin_Data.Organization = Props.Copy_Prop_Values_From_Api_Response<Organization>(
                        this._service_mesh.Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading(new Service_Mesh.Params_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading
                        {
                            ORGANIZATION_ID = oUser.ORGANIZATION_ID,
                            LIST_EAGER_LOADED_DATA = new List<string> { "Organization_color_scheme", "Organization_image", "User", "Organization_quota", "Organization_log_config", "Organization_districtnex_module", "Organization_level_access" }
                        }).i_Result
                    );
                });
                var get_districtnex_modules = Task.Run(() =>
                {
                    oAdmin_Data.List_Districtnex_module = Props.Copy_Prop_Values_From_Api_Response<List<Districtnex_module>>(
                        this._service_mesh.Get_Districtnex_module_By_OWNER_ID(new Service_Mesh.Params_Get_Districtnex_module_By_OWNER_ID()
                        {
                            OWNER_ID = this.oBLC_Initializer.Owner_ID
                        }).i_Result
                    );
                });
                Task.WaitAll(get_setup_categories, get_sites, get_entities, get_dimensions, get_organization, get_districtnex_modules);

                oUser.User_type_setup = Get_Setup_By_Setup_ID_From_Setup_Category_List(oUser.USER_TYPE_SETUP_ID, oAdmin_Data.List_Setup_category);
                Setup_category oSetup_category = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID() { OWNER_ID = oBLC_Initializer.Owner_ID, SETUP_CATEGORY_NAME = "Organization Type" });
                List<Setup> oList_Setup_Organization_Type = Get_Setup_By_SETUP_CATEGORY_ID(new Params_Get_Setup_By_SETUP_CATEGORY_ID() { SETUP_CATEGORY_ID = oSetup_category.SETUP_CATEGORY_ID });
                long? organization_Setup_ID = oList_Setup_Organization_Type.Find(setup => setup.VALUE == "Organization").SETUP_ID;

                if (oUser.USER_TYPE_SETUP_ID == Get_Setup_ID_By_Value("User Type", "Super Admin", oAdmin_Data.List_Setup_category))
                {
                    oAdmin_Data.NUMBER_OF_USERS = Get_User_By_OWNER_ID(new Params_Get_User_By_OWNER_ID
                    {
                        OWNER_ID = this.oBLC_Initializer.Owner_ID
                    }).Count;
                }
                else if (oUser.USER_TYPE_SETUP_ID == Get_Setup_ID_By_Value("User Type", "Organization Admin", oAdmin_Data.List_Setup_category) && oUser.Organization.ORGANIZATION_TYPE_SETUP_ID == organization_Setup_ID)
                {
                    List<Setup> oList_Data_level_setup = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
                    {
                        SETUP_CATEGORY_NAME = "Data Level"
                    }).List_Setup;
                    oAdmin_Data.List_Site.RemoveAll(site => !oAdmin_Data.Organization.List_Organization_level_access.Any(Organization_level_access => Organization_level_access.DATA_LEVEL_SETUP_ID == oList_Data_level_setup.Find(setup => setup.VALUE == "Site").SETUP_ID && Organization_level_access.LEVEL_ID == site.SITE_ID));
                    oAdmin_Data.List_Entity.RemoveAll(entity => !oAdmin_Data.Organization.List_Organization_level_access.Any(Organization_level_access => Organization_level_access.DATA_LEVEL_SETUP_ID == oList_Data_level_setup.Find(setup => setup.VALUE == "Entity").SETUP_ID && Organization_level_access.LEVEL_ID == entity.ENTITY_ID));
                    oAdmin_Data.List_Districtnex_module.RemoveAll(districtnex_module => !oAdmin_Data.Organization.List_Organization_districtnex_module.Any(organization_districtnex_module => organization_districtnex_module.DISTRICTNEX_MODULE_ID == districtnex_module.DISTRICTNEX_MODULE_ID));
                }

                return oAdmin_Data;
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0023)); // You do not belong to an active organization. Please contact support.
            }
        }
        #endregion
        #region Change_Password
        public bool Change_Password(Params_Change_Password i_Params_Change_Password)
        {
            if (i_Params_Change_Password.USER_ID > 0 &&
                i_Params_Change_Password.NEW_PASSWORD != null &&
                i_Params_Change_Password.NEW_PASSWORD.Trim() != "" &&
                i_Params_Change_Password.OLD_PASSWORD != null &&
                i_Params_Change_Password.OLD_PASSWORD.Trim() != ""
            )
            {
                User oUser = Get_User_By_USER_ID(new Params_Get_User_By_USER_ID()
                {
                    USER_ID = i_Params_Change_Password.USER_ID
                });
                if (oUser != null)
                {
                    string salt = Crypto.Encrypt(string.Format(Global.Salt, oUser.USER_ID, oUser.OWNER_ID));
                    string old_password = Crypto.EncryptPassword(i_Params_Change_Password.OLD_PASSWORD, salt);

                    if (old_password.Equals(oUser.PASSWORD))
                    {
                        oUser.PASSWORD = Crypto.EncryptPassword(i_Params_Change_Password.NEW_PASSWORD, salt);
                        Edit_User(oUser);
                        Task.Run(() =>
                        {
                            Setup_category oLog_Type_Setup_category = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
                            {
                                SETUP_CATEGORY_NAME = "Log Type"
                            });
                            Setup_category oAccess_Type_Setup_category = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
                            {
                                SETUP_CATEGORY_NAME = "Access Type"
                            });
                            this._service_mesh.Create_Log(new Service_Mesh.Params_Create_Log()
                            {
                                MESSAGE = $"{oUser.FIRST_NAME} {oUser.LAST_NAME} Has Changed His Password",
                                LOG_TYPE_SETUP_ID = oLog_Type_Setup_category.List_Setup.First(setup => setup.VALUE == "Password").SETUP_ID,
                                ACCESS_TYPE_SETUP_ID = oAccess_Type_Setup_category.List_Setup.First(setup => setup.VALUE == "Change").SETUP_ID,
                                USER_ID = oUser.USER_ID,
                            });
                        });
                        return true;
                    }
                    else
                    {
                        throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0006)); // Invalid Password! Re-enter and Try Again
                    }
                }
                else
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0005)); // User Not Found
                }
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }
        }
        #endregion
        #region Modify_User_Details
        public User Modify_User_Details(Params_Modify_User_Details i_Params_Modify_User_Details)
        {
            if (
                i_Params_Modify_User_Details.User.USER_ID != null &&
                i_Params_Modify_User_Details.User.USER_ID > 0 &&
                i_Params_Modify_User_Details.User.FIRST_NAME != null &&
                i_Params_Modify_User_Details.User.FIRST_NAME.Trim() != "" &&
                i_Params_Modify_User_Details.User.LAST_NAME != null &&
                i_Params_Modify_User_Details.User.LAST_NAME.Trim() != "" &&
                i_Params_Modify_User_Details.User.PHONE_NUMBER != null &&
                i_Params_Modify_User_Details.User.PHONE_NUMBER.Trim() != "" &&
                i_Params_Modify_User_Details.User.EMAIL != null &&
                i_Params_Modify_User_Details.User.EMAIL.Trim() != "0" &&
                i_Params_Modify_User_Details.User.USER_TYPE_SETUP_ID != null &&
                i_Params_Modify_User_Details.User.USER_TYPE_SETUP_ID > 0
            )
            {
                User oUser = Get_User_By_USER_ID_Adv(new Params_Get_User_By_USER_ID
                {
                    USER_ID = i_Params_Modify_User_Details.User.USER_ID
                });
                if (oUser != null)
                {
                    i_Params_Modify_User_Details.User.FIRST_NAME = i_Params_Modify_User_Details.User.FIRST_NAME.ToTitleCase();
                    i_Params_Modify_User_Details.User.LAST_NAME = i_Params_Modify_User_Details.User.LAST_NAME.ToTitleCase();
                    i_Params_Modify_User_Details.User.PASSWORD = oUser.PASSWORD;
                    Edit_User(i_Params_Modify_User_Details.User);
                    i_Params_Modify_User_Details.User.PASSWORD = "";
                    return i_Params_Modify_User_Details.User;
                }
                else
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0005)); // User Not Found
                }
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }
        }
        #endregion
        #region Permanently_Delete_User
        public bool Permanently_Delete_User(Params_Permanently_Delete_User i_Params_Permanently_Delete_User)
        {
            if (
                i_Params_Permanently_Delete_User.USER_ID > 0 &&
                i_Params_Permanently_Delete_User.USER_ID != null
            )
            {
                User oUser = Get_User_By_USER_ID(new Params_Get_User_By_USER_ID
                {
                    USER_ID = i_Params_Permanently_Delete_User.USER_ID
                });

                if (oUser != null && oUser != default)
                {
                    oUser.IS_ACTIVE = false;
                    oUser.IS_DELETED = true;
                    oUser.DATE_DELETED = Tools.GetDateTimeString(DateTime.Now);
                    oUser.EMAIL = Tools.Generate_Random_String(6) + "_del_" + oUser.EMAIL;
                    oUser.USERNAME = Tools.Generate_Random_String(6) + "_del_" + oUser.USERNAME;
                    Edit_User(oUser);
                    return true;
                }
                else
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0005)); // User Not Found
                }
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }
        }
        #endregion
        #region Schedule_User_for_Delete
        public User Schedule_User_for_Delete(Params_Schedule_User_for_Delete i_Params_Schedule_User_for_Delete)
        {
            if (i_Params_Schedule_User_for_Delete.USER_ID != null && i_Params_Schedule_User_for_Delete.USER_ID > 0)
            {
                User oUser = Props.Copy_Prop_Values_From_Api_Response<User>(
                    this._service_mesh.Get_User_By_USER_ID_Adv(new Service_Mesh.Params_Get_User_By_USER_ID()
                    {
                        USER_ID = i_Params_Schedule_User_for_Delete.USER_ID
                    }).i_Result
                );

                if (oUser != null && oUser != default && oUser != null && oUser.Organization != null)
                {
                    oUser.User_type_setup = Get_Setup_By_SETUP_ID(new Params_Get_Setup_By_SETUP_ID
                    {
                        SETUP_ID = oUser.USER_TYPE_SETUP_ID
                    });

                    if (oUser.User_type_setup != null && oUser.User_type_setup.VALUE == "Super Admin")
                    {
                        throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0025)); // Super Admins can't be deleted.
                    }

                    if (oUser.Organization.DATA_RETENTION_PERIOD > 0)
                    {
                        oUser.IS_ACTIVE = false;
                        oUser.DATE_DELETED = Tools.GetDateTimeString(DateTime.Now);
                        oUser.DATA_RETENTION_PERIOD = oUser.Organization.DATA_RETENTION_PERIOD;
                        Edit_User(oUser);

                        Task.Run(() =>
                        {
                            Setup_category oLog_Type_Setup_category = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
                            {
                                SETUP_CATEGORY_NAME = "Log Type"
                            });
                            Setup_category oAccess_Type_Setup_category = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
                            {
                                SETUP_CATEGORY_NAME = "Access Type"
                            });
                            this._service_mesh.Create_Log(new Service_Mesh.Params_Create_Log()
                            {
                                MESSAGE = $"{oUser.FIRST_NAME} {oUser.LAST_NAME} Has Been Scheduled For Delete",
                                LOG_TYPE_SETUP_ID = oLog_Type_Setup_category.List_Setup.First(setup => setup.VALUE == "User Activation-Deactivation").SETUP_ID,
                                ACCESS_TYPE_SETUP_ID = oAccess_Type_Setup_category.List_Setup.First(setup => setup.VALUE == "Change").SETUP_ID,
                                USER_ID = oUser.USER_ID,
                            });
                        });
                    }
                    else if (oUser.Organization.DATA_RETENTION_PERIOD == 0)
                    {
                        oUser.IS_ACTIVE = false;
                        oUser.IS_DELETED = true;
                        oUser.DATE_DELETED = Tools.GetDateTimeString(DateTime.Now);
                        oUser.DATA_RETENTION_PERIOD = oUser.Organization.DATA_RETENTION_PERIOD;
                        Permanently_Delete_User(new Params_Permanently_Delete_User
                        {
                            USER_ID = oUser.USER_ID
                        });

                        Task.Run(() =>
                        {
                            Setup_category oLog_Type_Setup_category = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
                            {
                                SETUP_CATEGORY_NAME = "Log Type"
                            });
                            Setup_category oAccess_Type_Setup_category = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
                            {
                                SETUP_CATEGORY_NAME = "Access Type"
                            });
                            this._service_mesh.Create_Log(new Service_Mesh.Params_Create_Log()
                            {
                                MESSAGE = $"{oUser.FIRST_NAME} {oUser.LAST_NAME} Has Been Deleted Permanently",
                                LOG_TYPE_SETUP_ID = oLog_Type_Setup_category.List_Setup.First(setup => setup.VALUE == "User Activation-Deactivation").SETUP_ID,
                                ACCESS_TYPE_SETUP_ID = oAccess_Type_Setup_category.List_Setup.First(setup => setup.VALUE == "Change").SETUP_ID,
                                USER_ID = oUser.USER_ID,
                            });
                        });
                    }
                    oUser.PASSWORD = "";

                    return oUser;
                }
                else
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0005)); // User Not Found
                }
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }
        }
        #endregion
        #region Edit_User_Profile_Details
        public bool Edit_User_Details(Params_Edit_User_Details i_Params_Edit_User_Details)
        {
            if (i_Params_Edit_User_Details.USER_ID != null &&
                i_Params_Edit_User_Details.USER_ID > 0 &&
                i_Params_Edit_User_Details.PHONE_NUMBER != null &&
                i_Params_Edit_User_Details.PHONE_NUMBER.Trim() != ""
            )
            {
                User oUser = Get_User_By_USER_ID(new Params_Get_User_By_USER_ID()
                {
                    USER_ID = i_Params_Edit_User_Details.USER_ID
                });
                if (oUser != null)
                {
                    oUser.PHONE_NUMBER = i_Params_Edit_User_Details.PHONE_NUMBER;
                    oUser.IS_RECEIVE_EMAIL = i_Params_Edit_User_Details.IS_RECEIVE_EMAIL;

                    Edit_User(oUser);
                    Task.Run(() =>
                    {
                        Setup_category oLog_Type_Setup_category = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
                        {
                            SETUP_CATEGORY_NAME = "Log Type"
                        });
                        Setup_category oAccess_Type_Setup_category = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
                        {
                            SETUP_CATEGORY_NAME = "Access Type"
                        });
                        this._service_mesh.Create_Log(new Service_Mesh.Params_Create_Log()
                        {
                            MESSAGE = $"{oUser.FIRST_NAME} {oUser.LAST_NAME} Has Changed His Details",
                            LOG_TYPE_SETUP_ID = oLog_Type_Setup_category.List_Setup.First(setup => setup.VALUE == "User Profile").SETUP_ID,
                            ACCESS_TYPE_SETUP_ID = oAccess_Type_Setup_category.List_Setup.First(setup => setup.VALUE == "Change").SETUP_ID,
                            USER_ID = oUser.USER_ID,
                        });
                    });
                    return true;
                }
                else
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0005)); // User Not Found
                }
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }
        }
        #endregion
        #region Change_User_Password
        public bool Change_User_Password(Params_Change_User_Password i_Params_Change_User_Password)
        {
            if (
                i_Params_Change_User_Password.USER_ID > 0 &&
                i_Params_Change_User_Password.USER_ID != null &&
                i_Params_Change_User_Password.NEW_PASSWORD != null &&
                i_Params_Change_User_Password.NEW_PASSWORD.Trim() != ""
            )
            {
                User oUser = Get_User_By_USER_ID(new Params_Get_User_By_USER_ID
                {
                    USER_ID = i_Params_Change_User_Password.USER_ID
                });

                User oCurrent_User = Get_User_By_USER_ID(new Params_Get_User_By_USER_ID()
                {
                    USER_ID = this.oBLC_Initializer.User_ID
                });

                if (oUser != null)
                {
                    string salt = Crypto.Encrypt(string.Format(Global.Salt, oUser.USER_ID, oUser.OWNER_ID));
                    string new_password = Crypto.EncryptPassword(i_Params_Change_User_Password.NEW_PASSWORD.Trim(), salt);

                    oUser.PASSWORD = new_password;
                    Edit_User(oUser);

                    Task.Run(() =>
                    {
                        Setup_category oLog_Type_Setup_category = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
                        {
                            SETUP_CATEGORY_NAME = "Log Type"
                        });
                        Setup_category oAccess_Type_Setup_category = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
                        {
                            SETUP_CATEGORY_NAME = "Access Type"
                        });
                        this._service_mesh.Create_Log(new Service_Mesh.Params_Create_Log()
                        {
                            MESSAGE = $"{oCurrent_User.FIRST_NAME} {oCurrent_User.LAST_NAME} Has Changed The Password Of {oUser.FIRST_NAME} {oUser.LAST_NAME}",
                            LOG_TYPE_SETUP_ID = oLog_Type_Setup_category.List_Setup.First(setup => setup.VALUE == "Password").SETUP_ID,
                            ACCESS_TYPE_SETUP_ID = oAccess_Type_Setup_category.List_Setup.First(setup => setup.VALUE == "Change").SETUP_ID,
                            USER_ID = oUser.USER_ID,
                        });
                    });
                    return true;
                }
                else
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0005)); // User Not Found
                }
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }
        }
        #endregion
        #region Get_User_Accessible_Data
        public User_Accessible_Data Get_User_Accessible_Data(Params_Get_User_Accessible_Data i_Params_Get_User_Accessible_Data)
        {
            User oUser = Get_User_By_USER_ID_Adv(new Params_Get_User_By_USER_ID()
            {
                USER_ID = oBLC_Initializer.User_ID
            });

            if (oUser != null && oUser != default)
            {
                if (oUser.Organization.IS_ACTIVE)
                {
                    if (!oUser.IS_ACTIVE)
                    {
                        throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0041)); // Your account is deactivated. Please contact support.
                    }
                    else
                    {
                        #region Declaration & Initialization

                        long? Area_Setup_ID = 0;
                        long? Site_Setup_ID = 0;
                        long? Entity_Setup_ID = 0;
                        long? District_Setup_ID = 0;
                        long? Top_Level_Setup_ID = 0;
                        long? Area_View_Setup_ID = 0;
                        long? Site_View_Setup_ID = 0;
                        long? Entity_View_Setup_ID = 0;
                        long? District_View_Setup_ID = 0;
                        User_Accessible_Data oUser_Accessible_Data = new User_Accessible_Data();
                        List<Organization_relation> oList_Organization_relation = new List<Organization_relation>();
                        List<User_level_access> oList_User_level_access = new List<User_level_access>();
                        List<Organization_level_access> oList_Organization_level_access = new List<Organization_level_access>();
                        oUser_Accessible_Data.ORGANIZATION = oUser.Organization;

                        #endregion

                        #region Get General Data

                        oUser.User_type_setup = Get_Setup_By_SETUP_ID(new Params_Get_Setup_By_SETUP_ID
                        {
                            SETUP_ID = oUser.USER_TYPE_SETUP_ID
                        });


                        var get_user_districtnex_module_list = Task.Run(() =>
                        {
                            oUser_Accessible_Data.LIST_USER_DISTRICTNEX_MODULE = Get_User_districtnex_module_By_USER_ID_Adv(new Params_Get_User_districtnex_module_By_USER_ID()
                            {
                                USER_ID = oBLC_Initializer.User_ID
                            });
                        });
                        var get_data_level_setup_list = Task.Run(() =>
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
                                Entity_Setup_ID = oList_Data_Level_Setup.FirstOrDefault(setup => setup.VALUE == "Entity").SETUP_ID;
                                District_Setup_ID = oList_Data_Level_Setup.FirstOrDefault(setup => setup.VALUE == "District").SETUP_ID;
                                Top_Level_Setup_ID = oList_Data_Level_Setup.FirstOrDefault(setup => setup.VALUE == "Top-Level").SETUP_ID;
                            }
                            else
                            {
                                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0045).Replace("%1", "Data Level")); // Data Level Setup Not Found
                            }
                        });
                        var get_map_level_view_setup_list = Task.Run(() =>
                        {
                            List<Setup> oList_Data_Level_Setup = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
                            {
                                SETUP_CATEGORY_NAME = "Map Level View",
                                OWNER_ID = this.oBLC_Initializer.Owner_ID
                            }).List_Setup;
                            if (oList_Data_Level_Setup != null && oList_Data_Level_Setup.Count > 0)
                            {
                                Area_View_Setup_ID = oList_Data_Level_Setup.FirstOrDefault(setup => setup.VALUE == "Area View").SETUP_ID;
                                Site_View_Setup_ID = oList_Data_Level_Setup.FirstOrDefault(setup => setup.VALUE == "Site View").SETUP_ID;
                                Entity_View_Setup_ID = oList_Data_Level_Setup.FirstOrDefault(setup => setup.VALUE == "Entity View").SETUP_ID;
                                District_View_Setup_ID = oList_Data_Level_Setup.FirstOrDefault(setup => setup.VALUE == "District View").SETUP_ID;
                            }
                            else
                            {
                                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0045).Replace("%1", "Data Level")); // Data Level Setup Not Found
                            }
                        });
                        var check_chosen_organzation = Task.Run(() =>
                        {
                            if (oUser.User_type_setup.VALUE == "Super Admin" && oUser.ORGANIZATION_ID != i_Params_Get_User_Accessible_Data.CHOSEN_ORGANIZATION_ID)
                            {
                                oList_Organization_relation = Props.Copy_Prop_Values_From_Api_Response<List<Organization_relation>>(
                                    this._service_mesh.Get_Organization_relation_By_PARENT_ORGANIZATION_ID(new Service_Mesh.Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID()
                                    {
                                        PARENT_ORGANIZATION_ID = oUser.ORGANIZATION_ID
                                    }).i_Result
                                );
                                if (oList_Organization_relation == null || oList_Organization_relation.Count == 0 ||
                                    !oList_Organization_relation.Select(organization_relation => organization_relation.CHILD_ORGANIZATION_ID).Contains(i_Params_Get_User_Accessible_Data.CHOSEN_ORGANIZATION_ID))
                                {
                                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.ER_0001)); // ACCESS DENIED
                                }
                            }
                        });
                        Task.WaitAll(get_user_districtnex_module_list, get_data_level_setup_list, get_map_level_view_setup_list, check_chosen_organzation);

                        #endregion

                        #region Level Access

                        #region Declaration & Initialization

                        oUser_Accessible_Data.LIST_USER_TOP_LEVEL_ID = new List<long?>();
                        oUser_Accessible_Data.LIST_USER_REGION_ID = new List<long?>();
                        oUser_Accessible_Data.LIST_USER_DISTRICT_ID = new List<long?>();
                        oUser_Accessible_Data.LIST_USER_AREA_ID = new List<long?>();
                        oUser_Accessible_Data.LIST_USER_SITE_ID = new List<long?>();
                        oUser_Accessible_Data.LIST_USER_ENTITY_ID = new List<long?>();
                        oUser_Accessible_Data.LIST_ORGANIZATION_TOP_LEVEL_ID = new List<long?>();
                        oUser_Accessible_Data.LIST_ORGANIZATION_REGION_ID = new List<long?>();
                        oUser_Accessible_Data.LIST_ORGANIZATION_DISTRICT_ID = new List<long?>();
                        oUser_Accessible_Data.LIST_ORGANIZATION_AREA_ID = new List<long?>();
                        oUser_Accessible_Data.LIST_ORGANIZATION_SITE_ID = new List<long?>();
                        oUser_Accessible_Data.LIST_ORGANIZATION_ENTITY_ID = new List<long?>();
                        List<LEVEL_ID_with_DATA_LEVEL_SETUP_ID> oList_Organization_LEVEL_ID_with_DATA_LEVEL_SETUP_ID = new List<LEVEL_ID_with_DATA_LEVEL_SETUP_ID>();
                        List<LEVEL_ID_with_DATA_LEVEL_SETUP_ID> oList_LEVEL_ID_with_DATA_LEVEL_SETUP_ID = new List<LEVEL_ID_with_DATA_LEVEL_SETUP_ID>();

                        #endregion

                        #region Get User Level Access

                        var get_organization_levels = Task.Run(() =>
                        {
                            oList_Organization_level_access = Props.Copy_Prop_Values_From_Api_Response<List<Organization_level_access>>(
                               this._service_mesh.Get_Organization_level_access_By_ORGANIZATION_ID(new Service_Mesh.Params_Get_Organization_level_access_By_ORGANIZATION_ID()
                               {
                                   ORGANIZATION_ID = i_Params_Get_User_Accessible_Data.CHOSEN_ORGANIZATION_ID
                               }).i_Result
                           );
                            if (oList_Organization_level_access != null && oList_Organization_level_access.Count > 0)
                            {
                                oList_Organization_LEVEL_ID_with_DATA_LEVEL_SETUP_ID = oList_Organization_level_access.Select(Organization_level_access =>
                                {
                                    return new LEVEL_ID_with_DATA_LEVEL_SETUP_ID
                                    {
                                        LEVEL_ID = Organization_level_access.LEVEL_ID,
                                        DATA_LEVEL_SETUP_ID = Organization_level_access.DATA_LEVEL_SETUP_ID
                                    };
                                }).ToList();
                            }
                        });

                        var get_accessible_levels = Task.Run(() =>
                        {
                            oList_User_level_access = Get_User_level_access_By_USER_ID(new Params_Get_User_level_access_By_USER_ID()
                            {
                                USER_ID = oUser.USER_ID
                            });
                            if (oList_User_level_access != null && oList_User_level_access.Count > 0)
                            {
                                oList_LEVEL_ID_with_DATA_LEVEL_SETUP_ID = oList_User_level_access.Select(User_level_access =>
                                {
                                    return new LEVEL_ID_with_DATA_LEVEL_SETUP_ID
                                    {
                                        LEVEL_ID = User_level_access.LEVEL_ID,
                                        DATA_LEVEL_SETUP_ID = User_level_access.DATA_LEVEL_SETUP_ID
                                    };
                                }).ToList();
                            }
                        });

                        Task.WaitAll(get_organization_levels, get_accessible_levels);

                        #endregion

                        #region Group & Assign User Level Access By Level

                        var group_accessible_levels = Task.Run(() =>
                        {
                            if (oList_LEVEL_ID_with_DATA_LEVEL_SETUP_ID != null && oList_LEVEL_ID_with_DATA_LEVEL_SETUP_ID.Count > 0)
                            {
                                var oList_Grouped_level_access = oList_LEVEL_ID_with_DATA_LEVEL_SETUP_ID.GroupBy(level_access => level_access.DATA_LEVEL_SETUP_ID);
                                foreach (var group in oList_Grouped_level_access)
                                {
                                    if (group.Key == Top_Level_Setup_ID)
                                    {
                                        oUser_Accessible_Data.LIST_USER_TOP_LEVEL_ID = group.Select(LEVEL_ID_with_DATA_LEVEL_SETUP_ID => LEVEL_ID_with_DATA_LEVEL_SETUP_ID.LEVEL_ID).ToList();
                                    }
                                    else if (group.Key == District_Setup_ID)
                                    {
                                        oUser_Accessible_Data.LIST_USER_DISTRICT_ID = group.Select(LEVEL_ID_with_DATA_LEVEL_SETUP_ID => LEVEL_ID_with_DATA_LEVEL_SETUP_ID.LEVEL_ID).ToList();
                                    }
                                    else if (group.Key == Area_Setup_ID)
                                    {
                                        oUser_Accessible_Data.LIST_USER_AREA_ID = group.Select(LEVEL_ID_with_DATA_LEVEL_SETUP_ID => LEVEL_ID_with_DATA_LEVEL_SETUP_ID.LEVEL_ID).ToList();
                                    }
                                    else if (group.Key == Site_Setup_ID)
                                    {
                                        oUser_Accessible_Data.LIST_USER_SITE_ID = group.Select(LEVEL_ID_with_DATA_LEVEL_SETUP_ID => LEVEL_ID_with_DATA_LEVEL_SETUP_ID.LEVEL_ID).ToList();
                                    }
                                    else if (group.Key == Entity_Setup_ID)
                                    {
                                        oUser_Accessible_Data.LIST_USER_ENTITY_ID = group.Select(LEVEL_ID_with_DATA_LEVEL_SETUP_ID => LEVEL_ID_with_DATA_LEVEL_SETUP_ID.LEVEL_ID).ToList();
                                    }
                                }
                            }
                        });

                        var group_organization_levels = Task.Run(() =>
                        {
                            if (oList_Organization_LEVEL_ID_with_DATA_LEVEL_SETUP_ID != null && oList_Organization_LEVEL_ID_with_DATA_LEVEL_SETUP_ID.Count > 0)
                            {
                                var oList_Grouped_level_access = oList_Organization_LEVEL_ID_with_DATA_LEVEL_SETUP_ID.GroupBy(level_access => level_access.DATA_LEVEL_SETUP_ID);
                                foreach (var group in oList_Grouped_level_access)
                                {
                                    if (group.Key == Top_Level_Setup_ID)
                                    {
                                        oUser_Accessible_Data.LIST_ORGANIZATION_TOP_LEVEL_ID = group.Select(LEVEL_ID_with_DATA_LEVEL_SETUP_ID => LEVEL_ID_with_DATA_LEVEL_SETUP_ID.LEVEL_ID).ToList();
                                    }
                                    else if (group.Key == District_Setup_ID)
                                    {
                                        oUser_Accessible_Data.LIST_ORGANIZATION_DISTRICT_ID = group.Select(LEVEL_ID_with_DATA_LEVEL_SETUP_ID => LEVEL_ID_with_DATA_LEVEL_SETUP_ID.LEVEL_ID).ToList();
                                    }
                                    else if (group.Key == Area_Setup_ID)
                                    {
                                        oUser_Accessible_Data.LIST_ORGANIZATION_AREA_ID = group.Select(LEVEL_ID_with_DATA_LEVEL_SETUP_ID => LEVEL_ID_with_DATA_LEVEL_SETUP_ID.LEVEL_ID).ToList();
                                    }
                                    else if (group.Key == Site_Setup_ID)
                                    {
                                        oUser_Accessible_Data.LIST_ORGANIZATION_SITE_ID = group.Select(LEVEL_ID_with_DATA_LEVEL_SETUP_ID => LEVEL_ID_with_DATA_LEVEL_SETUP_ID.LEVEL_ID).ToList();
                                    }
                                    else if (group.Key == Entity_Setup_ID)
                                    {
                                        oUser_Accessible_Data.LIST_ORGANIZATION_ENTITY_ID = group.Select(LEVEL_ID_with_DATA_LEVEL_SETUP_ID => LEVEL_ID_with_DATA_LEVEL_SETUP_ID.LEVEL_ID).ToList();
                                    }
                                }
                            }
                        });

                        Task.WaitAll(group_accessible_levels, group_organization_levels);

                        #endregion

                        #endregion

                        #region Removed_Extrusion

                        #region Declaration & Initialization
                        List<Removed_extrusion> oList_District_Removed_Extrusion_List = new List<Removed_extrusion>();
                        List<Removed_extrusion> oList_Area_Removed_Extrusion_List = new List<Removed_extrusion>();
                        List<Removed_extrusion> oList_Site_Removed_Extrusion_List = new List<Removed_extrusion>();
                        List<Removed_extrusion> oList_Entity_Removed_Extrusion_List = new List<Removed_extrusion>();
                        List<Removed_extrusion> oList_Removed_Extrusion = new List<Removed_extrusion>();
                        #endregion

                        #region Get Removed_Extrusion By Accessed Levels
                        var get_district_Removed_Extrusion_List = Task.Run(() =>
                        {
                            if (oUser.User_type_setup.VALUE == "Organization User")
                            {
                                if (oUser_Accessible_Data.LIST_USER_DISTRICT_ID != null && oUser_Accessible_Data.LIST_USER_DISTRICT_ID.Count > 0)
                                {
                                    oList_District_Removed_Extrusion_List = Get_Removed_extrusion_By_LEVEL_ID_List_Adv(new Params_Get_Removed_extrusion_By_LEVEL_ID_List()
                                    {
                                        LEVEL_ID_LIST = oUser_Accessible_Data.LIST_USER_DISTRICT_ID
                                    }).ToList();
                                    oList_District_Removed_Extrusion_List = oList_District_Removed_Extrusion_List.Where(oDistrict_Removed_Extrusion_List => oDistrict_Removed_Extrusion_List.DATA_LEVEL_SETUP_ID == District_View_Setup_ID).ToList();
                                }
                            }
                            else
                            {
                                if (oUser_Accessible_Data.LIST_ORGANIZATION_DISTRICT_ID != null && oUser_Accessible_Data.LIST_ORGANIZATION_DISTRICT_ID.Count > 0)
                                {
                                    oList_District_Removed_Extrusion_List = Get_Removed_extrusion_By_LEVEL_ID_List_Adv(new Params_Get_Removed_extrusion_By_LEVEL_ID_List()
                                    {
                                        LEVEL_ID_LIST = oUser_Accessible_Data.LIST_ORGANIZATION_DISTRICT_ID
                                    }).ToList();
                                    oList_District_Removed_Extrusion_List = oList_District_Removed_Extrusion_List.Where(oDistrict_Removed_Extrusion_List => oDistrict_Removed_Extrusion_List.DATA_LEVEL_SETUP_ID == District_View_Setup_ID).ToList();
                                }
                            }

                        });
                        var get_area_Removed_Extrusion_List = Task.Run(() =>
                        {
                            if (oUser.User_type_setup.VALUE == "Organization User")
                            {
                                if (oUser_Accessible_Data.LIST_USER_AREA_ID != null && oUser_Accessible_Data.LIST_USER_AREA_ID.Count > 0)
                                {
                                    oList_Area_Removed_Extrusion_List = Get_Removed_extrusion_By_LEVEL_ID_List_Adv(new Params_Get_Removed_extrusion_By_LEVEL_ID_List()
                                    {
                                        LEVEL_ID_LIST = oUser_Accessible_Data.LIST_USER_AREA_ID
                                    }).ToList();
                                    oList_Area_Removed_Extrusion_List = oList_Area_Removed_Extrusion_List.Where(oArea_Removed_Extrusion_List => oArea_Removed_Extrusion_List.DATA_LEVEL_SETUP_ID == Area_View_Setup_ID).ToList();
                                }
                            }
                            else
                            {
                                if (oUser_Accessible_Data.LIST_ORGANIZATION_AREA_ID != null && oUser_Accessible_Data.LIST_ORGANIZATION_AREA_ID.Count > 0)
                                {
                                    oList_Area_Removed_Extrusion_List = Get_Removed_extrusion_By_LEVEL_ID_List_Adv(new Params_Get_Removed_extrusion_By_LEVEL_ID_List()
                                    {
                                        LEVEL_ID_LIST = oUser_Accessible_Data.LIST_ORGANIZATION_AREA_ID
                                    }).ToList();
                                    oList_Area_Removed_Extrusion_List = oList_Area_Removed_Extrusion_List.Where(oArea_Removed_Extrusion_List => oArea_Removed_Extrusion_List.DATA_LEVEL_SETUP_ID == Area_View_Setup_ID).ToList();
                                }
                            }
                        });
                        var get_site_Removed_Extrusion_List = Task.Run(() =>
                        {
                            if (oUser.User_type_setup.VALUE == "Organization User")
                            {
                                if (oUser_Accessible_Data.LIST_USER_SITE_ID != null && oUser_Accessible_Data.LIST_USER_SITE_ID.Count > 0)
                                {
                                    oList_Site_Removed_Extrusion_List = Get_Removed_extrusion_By_LEVEL_ID_List_Adv(new Params_Get_Removed_extrusion_By_LEVEL_ID_List()
                                    {
                                        LEVEL_ID_LIST = oUser_Accessible_Data.LIST_USER_SITE_ID
                                    }).ToList();
                                    oList_Site_Removed_Extrusion_List = oList_Site_Removed_Extrusion_List.Where(oSite_Removed_Extrusion_List => oSite_Removed_Extrusion_List.DATA_LEVEL_SETUP_ID == Site_View_Setup_ID).ToList();
                                }
                            }
                            else
                            {
                                if (oUser_Accessible_Data.LIST_ORGANIZATION_SITE_ID != null && oUser_Accessible_Data.LIST_ORGANIZATION_SITE_ID.Count > 0)
                                {
                                    oList_Site_Removed_Extrusion_List = Get_Removed_extrusion_By_LEVEL_ID_List_Adv(new Params_Get_Removed_extrusion_By_LEVEL_ID_List()
                                    {
                                        LEVEL_ID_LIST = oUser_Accessible_Data.LIST_ORGANIZATION_SITE_ID
                                    }).ToList();
                                    oList_Site_Removed_Extrusion_List = oList_Site_Removed_Extrusion_List.Where(oSite_Removed_Extrusion_List => oSite_Removed_Extrusion_List.DATA_LEVEL_SETUP_ID == Site_View_Setup_ID).ToList();
                                }
                            }
                        });
                        var get_entity_Removed_Extrusion_List = Task.Run(() =>
                        {
                            if (oUser.User_type_setup.VALUE == "Organization User")
                            {
                                if (oUser_Accessible_Data.LIST_USER_ENTITY_ID != null && oUser_Accessible_Data.LIST_USER_ENTITY_ID.Count > 0)
                                {
                                    oList_Entity_Removed_Extrusion_List = Get_Removed_extrusion_By_LEVEL_ID_List_Adv(new Params_Get_Removed_extrusion_By_LEVEL_ID_List()
                                    {
                                        LEVEL_ID_LIST = oUser_Accessible_Data.LIST_USER_ENTITY_ID
                                    }).ToList();
                                    oList_Entity_Removed_Extrusion_List = oList_Entity_Removed_Extrusion_List.Where(oEntity_Removed_Extrusion_List => oEntity_Removed_Extrusion_List.DATA_LEVEL_SETUP_ID == Entity_View_Setup_ID).ToList();
                                }
                            }
                            else
                            {
                                if (oUser_Accessible_Data.LIST_ORGANIZATION_ENTITY_ID != null && oUser_Accessible_Data.LIST_ORGANIZATION_ENTITY_ID.Count > 0)
                                {
                                    oList_Entity_Removed_Extrusion_List = Get_Removed_extrusion_By_LEVEL_ID_List_Adv(new Params_Get_Removed_extrusion_By_LEVEL_ID_List()
                                    {
                                        LEVEL_ID_LIST = oUser_Accessible_Data.LIST_ORGANIZATION_ENTITY_ID
                                    }).ToList();
                                    oList_Entity_Removed_Extrusion_List = oList_Entity_Removed_Extrusion_List.Where(oEntity_Removed_Extrusion_List => oEntity_Removed_Extrusion_List.DATA_LEVEL_SETUP_ID == Entity_View_Setup_ID).ToList();
                                }
                            }
                        });

                        Task.WaitAll(get_district_Removed_Extrusion_List, get_area_Removed_Extrusion_List, get_site_Removed_Extrusion_List, get_site_Removed_Extrusion_List);
                        #endregion

                        #region Fill LIST_REMOVED_EXTRUSIONS
                        if (oList_District_Removed_Extrusion_List != null && oList_District_Removed_Extrusion_List.Count > 0)
                        {
                            foreach (Removed_extrusion removed_extrusion in oList_District_Removed_Extrusion_List)
                            {
                                oList_Removed_Extrusion.Add(removed_extrusion);
                            }
                        }
                        if (oList_Area_Removed_Extrusion_List != null && oList_Area_Removed_Extrusion_List.Count > 0)
                        {
                            foreach (Removed_extrusion removed_extrusion in oList_Area_Removed_Extrusion_List)
                            {
                                oList_Removed_Extrusion.Add(removed_extrusion);
                            }
                        }
                        if (oList_Site_Removed_Extrusion_List != null && oList_Site_Removed_Extrusion_List.Count > 0)
                        {
                            foreach (Removed_extrusion removed_extrusion in oList_Site_Removed_Extrusion_List)
                            {
                                oList_Removed_Extrusion.Add(removed_extrusion);
                            }
                        }
                        if (oList_Entity_Removed_Extrusion_List != null && oList_Entity_Removed_Extrusion_List.Count > 0)
                        {
                            foreach (Removed_extrusion removed_extrusion in oList_Entity_Removed_Extrusion_List)
                            {
                                oList_Removed_Extrusion.Add(removed_extrusion);
                            }
                        }
                        oUser_Accessible_Data.LIST_REMOVED_EXTRUSIONS = oList_Removed_Extrusion;
                        #endregion

                        #endregion

                        return oUser_Accessible_Data;
                    }
                }
                else
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0023)); // You do not belong to an active organization. Please contact support.
                }
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0005)); // User Not Found
            }
        }
        #endregion
        #region Get_User_Accessible_Level_List
        public User_Accessible_Level_List Get_User_Accessible_Level_List(Params_Get_User_Accessible_Level_List i_Params_Get_User_Accessible_Level_List)
        {
            if (i_Params_Get_User_Accessible_Level_List.ENUM_TIMESPAN == Enum_Timespan.X_HOURLY_COLLECTION)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }

            User_Accessible_Level_List oUser_Accessible_Level_List = new User_Accessible_Level_List();

            #region Declaration & Initialization

            long? Top_Level_Setup_ID = 0;
            long? District_Setup_ID = 0;
            long? Area_Setup_ID = 0;
            long? Site_Setup_ID = 0;
            long? Entity_Setup_ID = 0;
            long? Building_Setup_ID = 0;
            User oUser = new User();
            Setup oSetup_Data_Level = new Setup();
            Top_level oTop_Level = new Top_level();
            List<Area> oList_Organization_Area = new List<Area>();
            List<Site> oList_Organization_Site = new List<Site>();
            List<Entity> oList_Organization_Entity = new List<Entity>();
            List<District> oList_Organization_District = new List<District>();
            List<Area> oList_Accessible_Area = new List<Area>();
            List<Site> oList_Accessible_Site = new List<Site>();
            List<Entity> oList_Accessible_Entity = new List<Entity>();
            List<District> oList_Accessible_District = new List<District>();
            List<Setup> oList_Data_Level_Setup = new List<Setup>();
            List<Dimension> oList_Dimension = new List<Dimension>();
            List<Dimension_index> oList_Dimension_index = new List<Dimension_index>();

            #endregion

            #region Get User

            oUser = Get_User_By_USER_ID_Adv(new Params_Get_User_By_USER_ID()
            {
                USER_ID = oBLC_Initializer.User_ID
            });

            #endregion

            #region General Info

            var get_district_list = Task.Run(() =>
            {
                if (i_Params_Get_User_Accessible_Level_List.LIST_ORGANIZATION_DISTRICT_ID.Count > 0)
                {
                    oList_Organization_District = Get_District_By_DISTRICT_ID_List(new Params_Get_District_By_DISTRICT_ID_List()
                    {
                        DISTRICT_ID_LIST = i_Params_Get_User_Accessible_Level_List.LIST_ORGANIZATION_DISTRICT_ID
                    }).ToList();
                    if (oUser.User_type_setup.VALUE == "Organization User")
                    {
                        oList_Accessible_District = oList_Organization_District.Where(oDistrict => i_Params_Get_User_Accessible_Level_List.LIST_USER_DISTRICT_ID.Contains(oDistrict.DISTRICT_ID)).ToList();
                    }
                    else
                    {
                        oList_Accessible_District = oList_Organization_District;
                    }
                }
            });
            var get_area_list = Task.Run(() =>
            {
                if (i_Params_Get_User_Accessible_Level_List.LIST_ORGANIZATION_AREA_ID.Count > 0)
                {
                    oList_Organization_Area = Get_Area_By_AREA_ID_List(new Params_Get_Area_By_AREA_ID_List()
                    {
                        AREA_ID_LIST = i_Params_Get_User_Accessible_Level_List.LIST_ORGANIZATION_AREA_ID
                    }).ToList();
                    if (oUser.User_type_setup.VALUE == "Organization User")
                    {
                        oList_Accessible_Area = oList_Organization_Area.Where(oArea => i_Params_Get_User_Accessible_Level_List.LIST_USER_AREA_ID.Contains(oArea.AREA_ID)).ToList();
                    }
                    else
                    {
                        oList_Accessible_Area = oList_Organization_Area;
                    }
                }
            });
            var get_site_list = Task.Run(() =>
            {
                if (i_Params_Get_User_Accessible_Level_List.LIST_ORGANIZATION_SITE_ID.Count > 0)
                {
                    oList_Organization_Site = Get_Site_By_SITE_ID_List(new Params_Get_Site_By_SITE_ID_List()
                    {
                        SITE_ID_LIST = i_Params_Get_User_Accessible_Level_List.LIST_ORGANIZATION_SITE_ID
                    }).ToList();
                    if (oUser.User_type_setup.VALUE == "Organization User")
                    {
                        oList_Accessible_Site = oList_Organization_Site.Where(oSite => i_Params_Get_User_Accessible_Level_List.LIST_USER_SITE_ID.Contains(oSite.SITE_ID)).ToList();
                    }
                    else
                    {
                        oList_Accessible_Site = oList_Organization_Site;
                    }
                }
            });
            var get_entity_list = Task.Run(() =>
            {
                if (i_Params_Get_User_Accessible_Level_List.LIST_ORGANIZATION_ENTITY_ID.Count > 0)
                {
                    oList_Organization_Entity = Get_Entity_By_ENTITY_ID_List(new Params_Get_Entity_By_ENTITY_ID_List()
                    {
                        ENTITY_ID_LIST = i_Params_Get_User_Accessible_Level_List.LIST_ORGANIZATION_ENTITY_ID
                    }).ToList();
                    if (oUser.User_type_setup.VALUE == "Organization User")
                    {
                        oList_Accessible_Entity = oList_Organization_Entity.Where(oEntity => i_Params_Get_User_Accessible_Level_List.LIST_USER_ENTITY_ID.Contains(oEntity.ENTITY_ID)).ToList();
                    }
                    else
                    {
                        oList_Accessible_Entity = oList_Organization_Entity;
                    }
                }
            });
            var get_dimensions = Task.Run(() =>
            {
                oList_Dimension = Props.Copy_Prop_Values_From_Api_Response<List<Dimension>>(
                   this._service_mesh.Get_Dimension_By_OWNER_ID(new Service_Mesh.Params_Get_Dimension_By_OWNER_ID()
                   {
                       OWNER_ID = this.oBLC_Initializer.Owner_ID
                   }).i_Result
               );
            });

            var get_data_level_setup_list = Task.Run(() =>
            {
                oList_Data_Level_Setup = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
                {
                    SETUP_CATEGORY_NAME = "Data Level",
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                }).List_Setup;
                if (oList_Data_Level_Setup != null && oList_Data_Level_Setup.Count > 0)
                {
                    Area_Setup_ID = oList_Data_Level_Setup.FirstOrDefault(setup => setup.VALUE == "Area").SETUP_ID;
                    Site_Setup_ID = oList_Data_Level_Setup.FirstOrDefault(setup => setup.VALUE == "Site").SETUP_ID;
                    Entity_Setup_ID = oList_Data_Level_Setup.FirstOrDefault(setup => setup.VALUE == "Entity").SETUP_ID;
                    District_Setup_ID = oList_Data_Level_Setup.FirstOrDefault(setup => setup.VALUE == "District").SETUP_ID;
                    Top_Level_Setup_ID = oList_Data_Level_Setup.FirstOrDefault(setup => setup.VALUE == "Top-Level").SETUP_ID;
                }
                else
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0045).Replace("%1", "Data Level")); // Data Level Setup Not Found
                }
            });

            var get_entity_setup_type = Task.Run(() =>
            {
                List<Setup> oList_Entity_Type_Setup = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
                {
                    SETUP_CATEGORY_NAME = "Entity Type",
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                }).List_Setup;
                if (oList_Entity_Type_Setup != null && oList_Entity_Type_Setup.Count > 0)
                {
                    Building_Setup_ID = oList_Entity_Type_Setup.FirstOrDefault(setup => setup.VALUE == "Building").SETUP_ID;
                }
                else
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0045).Replace("%1", "Entity Type")); // Entity Type Setup Not Found
                }
            });

            Task.WaitAll(get_district_list, get_area_list, get_site_list, get_entity_list, get_dimensions, get_data_level_setup_list, get_entity_setup_type);

            #endregion

            #region Group Levels by Top Level

            #region Group Level_IDs by Top Levels

            List<Accessible_Level_ID_List_By_Top_Level> oList_Accessible_Level_ID_List_By_Top_Level = new List<Accessible_Level_ID_List_By_Top_Level>();
            Accessible_Level_ID_List_By_Top_Level oAccessible_Level_ID_List_By_Top_Level;

            var List_District_Grouped = oList_Accessible_District.GroupBy(oDistrict_Grouped => oDistrict_Grouped.TOP_LEVEL_ID);
            var List_Area_Grouped = oList_Accessible_Area.GroupBy(oArea_Grouped => oArea_Grouped.TOP_LEVEL_ID);
            var List_Site_Grouped = oList_Accessible_Site.GroupBy(oSite_Grouped => oSite_Grouped.TOP_LEVEL_ID);
            var List_Entity_Grouped = oList_Accessible_Entity.GroupBy(oEntity_Grouped => oEntity_Grouped.TOP_LEVEL_ID);
            List<long?> List_Top_Level_ID = (oUser.User_type_setup.VALUE == "Organization User") ? i_Params_Get_User_Accessible_Level_List.LIST_USER_TOP_LEVEL_ID : i_Params_Get_User_Accessible_Level_List.LIST_ORGANIZATION_TOP_LEVEL_ID;

            foreach (long? top_level_id in List_Top_Level_ID)
            {
                oAccessible_Level_ID_List_By_Top_Level = new Accessible_Level_ID_List_By_Top_Level();
                oAccessible_Level_ID_List_By_Top_Level.TOP_LEVEL_ID = top_level_id;

                #region Fill DISTRICT_ID_LIST

                var fill_list_accessible_district_id = Task.Run(() =>
                {
                    if (oList_Accessible_District.Count > 0)
                    {
                        var oList_District_by_Top_Level_Group = List_District_Grouped.FirstOrDefault(oDistrict_Grouped => oDistrict_Grouped.Key == top_level_id);
                        if (oList_District_by_Top_Level_Group != null)
                        {
                            oAccessible_Level_ID_List_By_Top_Level.DISTRICT_ID_LIST = oList_District_by_Top_Level_Group.Select(oDistrict_by_Top_Level_Group => oDistrict_by_Top_Level_Group.DISTRICT_ID).ToList();
                        }
                        else
                        {
                            oAccessible_Level_ID_List_By_Top_Level.DISTRICT_ID_LIST = new List<long?>();
                        }
                    }
                    else
                    {
                        oAccessible_Level_ID_List_By_Top_Level.DISTRICT_ID_LIST = new List<long?>();
                    }
                });

                #endregion

                #region Fill AREA_ID_LIST

                var fill_list_accessible_area_id = Task.Run(() =>
                {
                    if (oList_Accessible_Area.Count > 0)
                    {
                        var oList_Area_by_Top_Level_Group = List_Area_Grouped.FirstOrDefault(oArea_Grouped => oArea_Grouped.Key == top_level_id);
                        if (oList_Area_by_Top_Level_Group != null)
                        {
                            oAccessible_Level_ID_List_By_Top_Level.AREA_ID_LIST = oList_Area_by_Top_Level_Group.Select(oArea_by_Top_Level_Group => oArea_by_Top_Level_Group.AREA_ID).ToList();
                        }
                        else
                        {
                            oAccessible_Level_ID_List_By_Top_Level.AREA_ID_LIST = new List<long?>();
                        }
                    }
                    else
                    {
                        oAccessible_Level_ID_List_By_Top_Level.AREA_ID_LIST = new List<long?>();
                    }
                });

                #endregion

                #region Fill SITE_ID_LIST

                var fill_list_accessible_site_id = Task.Run(() =>
                {
                    if (oList_Accessible_Site.Count > 0)
                    {
                        var oList_Site_by_Top_Level_Group = List_Site_Grouped.FirstOrDefault(oSite_Grouped => oSite_Grouped.Key == top_level_id);
                        if (oList_Site_by_Top_Level_Group != null)
                        {
                            oAccessible_Level_ID_List_By_Top_Level.SITE_ID_LIST = oList_Site_by_Top_Level_Group.Select(oArea_by_Top_Level_Group => oArea_by_Top_Level_Group.SITE_ID).ToList();
                        }
                        else
                        {
                            oAccessible_Level_ID_List_By_Top_Level.SITE_ID_LIST = new List<long?>();
                        }
                    }
                    else
                    {
                        oAccessible_Level_ID_List_By_Top_Level.SITE_ID_LIST = new List<long?>();
                    }
                });

                #endregion

                #region Fill ENTITY_ID_LIST

                var fill_list_accessible_entity_id = Task.Run(() =>
                {
                    if (oList_Accessible_Entity.Count > 0)
                    {
                        var oList_Entity_by_Top_Level_Group = List_Entity_Grouped.FirstOrDefault(oEntity_Grouped => oEntity_Grouped.Key == top_level_id);
                        if (oList_Entity_by_Top_Level_Group != null)
                        {
                            oAccessible_Level_ID_List_By_Top_Level.ENTITY_ID_LIST = oList_Entity_by_Top_Level_Group.Select(oArea_by_Top_Level_Group => oArea_by_Top_Level_Group.ENTITY_ID).ToList();
                        }
                        else
                        {
                            oAccessible_Level_ID_List_By_Top_Level.ENTITY_ID_LIST = new List<long?>();
                        }
                    }
                    else
                    {
                        oAccessible_Level_ID_List_By_Top_Level.ENTITY_ID_LIST = new List<long?>();
                    }
                });

                #endregion

                Task.WaitAll(fill_list_accessible_district_id, fill_list_accessible_area_id, fill_list_accessible_site_id, fill_list_accessible_entity_id);

                oList_Accessible_Level_ID_List_By_Top_Level.Add(oAccessible_Level_ID_List_By_Top_Level);
            }
            oUser_Accessible_Level_List.LIST_ACCESSIBLE_LEVEL_ID_LIST_BY_TOP_LEVEL = oList_Accessible_Level_ID_List_By_Top_Level;

            #endregion

            #region Check TOP_LEVEL_ID

            long? Top_Level_ID = 0;

            if (List_Top_Level_ID != null && List_Top_Level_ID.Count > 0)
            {
                if (List_Top_Level_ID.Contains(i_Params_Get_User_Accessible_Level_List.TOP_LEVEL_ID))
                {
                    Top_Level_ID = i_Params_Get_User_Accessible_Level_List.TOP_LEVEL_ID;
                }
                else
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.ER_0001)); // ACCESS DENIED
                }
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0047)); // The user does not have access to any level.
            }

            oTop_Level = Get_Top_level_By_TOP_LEVEL_ID_List(new Params_Get_Top_level_By_TOP_LEVEL_ID_List()
            {
                TOP_LEVEL_ID_LIST = new List<long?>() { Top_Level_ID }
            }).FirstOrDefault();

            #endregion

            #region Get Levels by Selected Top Level

            Accessible_Level_List_By_Top_Level oAccessible_Level_List_By_Top_Level = new Accessible_Level_List_By_Top_Level();
            oAccessible_Level_List_By_Top_Level.TOP_LEVEL = oTop_Level;
            oAccessible_Level_List_By_Top_Level.DISTRICT_LIST = oList_Accessible_District.Where(district => district.TOP_LEVEL_ID == oTop_Level.TOP_LEVEL_ID).ToList();
            oAccessible_Level_List_By_Top_Level.AREA_LIST = oList_Accessible_Area.Where(area => area.TOP_LEVEL_ID == oTop_Level.TOP_LEVEL_ID).ToList();
            oAccessible_Level_List_By_Top_Level.SITE_LIST = oList_Accessible_Site.Where(site => site.TOP_LEVEL_ID == oTop_Level.TOP_LEVEL_ID).ToList();
            oAccessible_Level_List_By_Top_Level.ENTITY_LIST = oList_Accessible_Entity.Where(entity => entity.TOP_LEVEL_ID == oTop_Level.TOP_LEVEL_ID).ToList();
            oUser_Accessible_Level_List.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL = oAccessible_Level_List_By_Top_Level;

            #endregion

            #endregion

            #region Data Access

            #region Declaration & Initialization

            List<Level_Kpi> oList_Organization_District_Kpi_ID = new List<Level_Kpi>();
            List<Level_Kpi> oList_Organization_Area_Kpi_ID = new List<Level_Kpi>();
            List<Level_Kpi> oList_Organization_Site_Kpi_ID = new List<Level_Kpi>();
            List<Level_Kpi> oList_Organization_Entity_Kpi_ID = new List<Level_Kpi>();
            List<Level_Kpi> oList_Accessible_District_Kpi_ID = new List<Level_Kpi>();
            List<Level_Kpi> oList_Accessible_Area_Kpi_ID = new List<Level_Kpi>();
            List<Level_Kpi> oList_Accessible_Site_Kpi_ID = new List<Level_Kpi>();
            List<Level_Kpi> oList_Accessible_Entity_Kpi_ID = new List<Level_Kpi>();
            List<int?> District_Organization_data_source_kpi_ID_List = new List<int?>();
            List<int?> Area_Organization_data_source_kpi_ID_List = new List<int?>();
            List<int?> Site_Organization_data_source_kpi_ID_List = new List<int?>();
            List<int?> Entity_Organization_data_source_kpi_ID_List = new List<int?>();
            oUser_Accessible_Level_List.ORGANIZATION_DATA_SOURCE_KPI_LIST_BY_TOP_LEVEL = new Organization_data_source_kpi_List_By_Top_Level();

            #endregion

            var get_organization_kpi_id = Task.Run(() =>
            {
                #region Get KPI IDs for Levels

                var get_district_KPI_IDs = Task.Run(() =>
                {
                    List<District> oList_Organization_District_By_TOP_LEVEL_ID = oList_Organization_District.Where(oDistrict => oDistrict.TOP_LEVEL_ID == Top_Level_ID).ToList();
                    if (oList_Organization_District_By_TOP_LEVEL_ID.Count > 0)
                    {
                        List<District_kpi> oList_District_kpi = Get_District_kpi_By_DISTRICT_ID_List_Adv(new Params_Get_District_kpi_By_DISTRICT_ID_List()
                        {
                            DISTRICT_ID_LIST = oList_Organization_District_By_TOP_LEVEL_ID.Select(district => district.DISTRICT_ID).ToList()
                        });
                        if (oList_District_kpi != null)
                        {
                            #region Fill District_Organization_data_source_kpi_ID_List

                            if (oUser.User_type_setup.VALUE != "Organization User")
                            {
                                District_Organization_data_source_kpi_ID_List = oList_District_kpi.DistinctBy(oDistrict_kpi => oDistrict_kpi.Organization_data_source_kpi.KPI_ID).Select(oDistrict_kpi => oDistrict_kpi.Organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();
                                oUser_Accessible_Level_List.ORGANIZATION_DATA_SOURCE_KPI_LIST_BY_TOP_LEVEL.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_DISTRICT = new List<Organization_data_source_kpi_ID_By_Level_ID>();
                            }

                            #endregion


                            foreach (District oDistrict in oList_Organization_District_By_TOP_LEVEL_ID)
                            {
                                Level_Kpi oLevel_Kpi = new Level_Kpi();
                                oLevel_Kpi.LEVEL_KPI_LIST = new List<int?>();

                                List<District_kpi> oList_District_kpi_Filtered = oList_District_kpi.Where(oDistrict_kpi => oDistrict_kpi.DISTRICT_ID == oDistrict.DISTRICT_ID).ToList();

                                oLevel_Kpi.LEVEL_ID = oDistrict.DISTRICT_ID;
                                oLevel_Kpi.LEVEL_SETUP_ID = District_Setup_ID;
                                oLevel_Kpi.LEVEL_KPI_LIST = oList_District_kpi_Filtered.DistinctBy(oDistrict_kpi => oDistrict_kpi.Organization_data_source_kpi.KPI_ID).Select(oDistrict_kpi => oDistrict_kpi.Organization_data_source_kpi.KPI_ID).ToList();

                                oList_Organization_District_Kpi_ID.Add(oLevel_Kpi);

                                #region Assign LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_DISTRICT

                                if (oUser.User_type_setup.VALUE != "Organization User")
                                {
                                    Organization_data_source_kpi_ID_By_Level_ID oOrganization_data_source_kpi_ID_By_Level_ID = new Organization_data_source_kpi_ID_By_Level_ID();
                                    oOrganization_data_source_kpi_ID_By_Level_ID.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE = new List<Organization_data_source_kpi_Simple>();
                                    oOrganization_data_source_kpi_ID_By_Level_ID.LEVEL_ID = oDistrict.DISTRICT_ID;
                                    oOrganization_data_source_kpi_ID_By_Level_ID.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE = oList_District_kpi_Filtered.DistinctBy(oDistrict_kpi => oDistrict_kpi.Organization_data_source_kpi.KPI_ID).Select(oDistrict_kpi =>
                                    {
                                        return new Organization_data_source_kpi_Simple()
                                        {
                                            ORGANIZATION_DATA_SOURCE_KPI_ID = oDistrict_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                            KPI_ID = oDistrict_kpi.Organization_data_source_kpi.KPI_ID
                                        };
                                    }).ToList();
                                    oUser_Accessible_Level_List.ORGANIZATION_DATA_SOURCE_KPI_LIST_BY_TOP_LEVEL.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_DISTRICT.Add(oOrganization_data_source_kpi_ID_By_Level_ID);
                                }

                                #endregion
                            }
                        }
                    }
                    else
                    {
                        oUser_Accessible_Level_List.ORGANIZATION_DATA_SOURCE_KPI_LIST_BY_TOP_LEVEL.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_DISTRICT = new List<Organization_data_source_kpi_ID_By_Level_ID>();
                    }
                });
                var get_area_KPI_IDs = Task.Run(() =>
                {
                    List<Area> oList_Organization_Area_By_TOP_LEVEL_ID = oList_Organization_Area.Where(oArea => oArea.TOP_LEVEL_ID == Top_Level_ID).ToList();
                    if (oList_Organization_Area_By_TOP_LEVEL_ID.Count > 0)
                    {
                        List<Area_kpi> oList_Area_kpi = Get_Area_kpi_By_AREA_ID_List_Adv(new Params_Get_Area_kpi_By_AREA_ID_List()
                        {
                            AREA_ID_LIST = oList_Organization_Area_By_TOP_LEVEL_ID.Select(oArea => oArea.AREA_ID).ToList()
                        });
                        if (oList_Area_kpi != null)
                        {
                            #region Fill Area_Organization_data_source_kpi_ID_List

                            if (oUser.User_type_setup.VALUE != "Organization User")
                            {
                                Area_Organization_data_source_kpi_ID_List = oList_Area_kpi.DistinctBy(oArea_kpi => oArea_kpi.Organization_data_source_kpi.KPI_ID).Select(oArea_kpi => oArea_kpi.Organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();
                                oUser_Accessible_Level_List.ORGANIZATION_DATA_SOURCE_KPI_LIST_BY_TOP_LEVEL.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_AREA = new List<Organization_data_source_kpi_ID_By_Level_ID>();
                            }

                            #endregion


                            foreach (Area oArea in oList_Organization_Area_By_TOP_LEVEL_ID)
                            {
                                List<Area_kpi> oList_Area_kpi_Filtered = oList_Area_kpi.Where(oArea_kpi => oArea_kpi.AREA_ID == oArea.AREA_ID).ToList();

                                Level_Kpi oLevel_Kpi = new Level_Kpi();
                                oLevel_Kpi.LEVEL_KPI_LIST = new List<int?>();

                                oLevel_Kpi.LEVEL_ID = oArea.AREA_ID;
                                oLevel_Kpi.LEVEL_SETUP_ID = Area_Setup_ID;
                                oLevel_Kpi.LEVEL_KPI_LIST = oList_Area_kpi_Filtered.DistinctBy(oArea_kpi => oArea_kpi.Organization_data_source_kpi.KPI_ID).Select(oArea_kpi => oArea_kpi.Organization_data_source_kpi.KPI_ID).ToList();

                                oList_Organization_Area_Kpi_ID.Add(oLevel_Kpi);

                                #region Assign LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_AREA

                                if (oUser.User_type_setup.VALUE != "Organization User")
                                {
                                    Organization_data_source_kpi_ID_By_Level_ID oOrganization_data_source_kpi_ID_By_Level_ID = new Organization_data_source_kpi_ID_By_Level_ID();
                                    oOrganization_data_source_kpi_ID_By_Level_ID.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE = new List<Organization_data_source_kpi_Simple>();
                                    oOrganization_data_source_kpi_ID_By_Level_ID.LEVEL_ID = oArea.AREA_ID;
                                    oOrganization_data_source_kpi_ID_By_Level_ID.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE = oList_Area_kpi_Filtered.DistinctBy(oArea_kpi => oArea_kpi.Organization_data_source_kpi.KPI_ID).Select(oArea_kpi =>
                                    {
                                        return new Organization_data_source_kpi_Simple()
                                        {
                                            ORGANIZATION_DATA_SOURCE_KPI_ID = oArea_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                            KPI_ID = oArea_kpi.Organization_data_source_kpi.KPI_ID
                                        };
                                    }).ToList();
                                    oUser_Accessible_Level_List.ORGANIZATION_DATA_SOURCE_KPI_LIST_BY_TOP_LEVEL.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_AREA.Add(oOrganization_data_source_kpi_ID_By_Level_ID);
                                }

                                #endregion
                            }
                        }
                    }
                    else
                    {
                        oUser_Accessible_Level_List.ORGANIZATION_DATA_SOURCE_KPI_LIST_BY_TOP_LEVEL.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_AREA = new List<Organization_data_source_kpi_ID_By_Level_ID>();
                    }
                });
                var get_site_KPI_IDs = Task.Run(() =>
                {
                    List<Site> oList_Organization_Site_By_TOP_LEVEL_ID = oList_Organization_Site.Where(oSite => oSite.TOP_LEVEL_ID == Top_Level_ID).ToList();
                    if (oList_Organization_Site_By_TOP_LEVEL_ID.Count > 0)
                    {
                        List<Site_kpi> oList_Site_kpi = Get_Site_kpi_By_SITE_ID_List_Adv(new Params_Get_Site_kpi_By_SITE_ID_List()
                        {
                            SITE_ID_LIST = oList_Organization_Site_By_TOP_LEVEL_ID.Select(site => site.SITE_ID).ToList()
                        });
                        if (oList_Site_kpi != null)
                        {
                            #region Fill Site_Organization_data_source_kpi_ID_List

                            if (oUser.User_type_setup.VALUE != "Organization User")
                            {
                                Site_Organization_data_source_kpi_ID_List = oList_Site_kpi.DistinctBy(oSite_kpi => oSite_kpi.Organization_data_source_kpi.KPI_ID).Select(oSite_kpi => oSite_kpi.Organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();
                                oUser_Accessible_Level_List.ORGANIZATION_DATA_SOURCE_KPI_LIST_BY_TOP_LEVEL.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_SITE = new List<Organization_data_source_kpi_ID_By_Level_ID>();
                            }

                            #endregion


                            foreach (Site oSite in oList_Organization_Site_By_TOP_LEVEL_ID)
                            {
                                List<Site_kpi> oList_Site_kpi_Filtered = oList_Site_kpi.Where(oSite_kpi => oSite_kpi.SITE_ID == oSite.SITE_ID).ToList();

                                Level_Kpi oLevel_Kpi = new Level_Kpi();
                                oLevel_Kpi.LEVEL_KPI_LIST = new List<int?>();

                                oLevel_Kpi.LEVEL_ID = oSite.SITE_ID;
                                oLevel_Kpi.LEVEL_SETUP_ID = Site_Setup_ID;
                                oLevel_Kpi.LEVEL_KPI_LIST = oList_Site_kpi_Filtered.DistinctBy(oSite_kpi => oSite_kpi.Organization_data_source_kpi.KPI_ID).Select(oSite_kpi => oSite_kpi.Organization_data_source_kpi.KPI_ID).ToList();

                                oList_Organization_Site_Kpi_ID.Add(oLevel_Kpi);

                                #region LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_SITE

                                if (oUser.User_type_setup.VALUE != "Organization User")
                                {
                                    Organization_data_source_kpi_ID_By_Level_ID oOrganization_data_source_kpi_ID_By_Level_ID = new Organization_data_source_kpi_ID_By_Level_ID();
                                    oOrganization_data_source_kpi_ID_By_Level_ID.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE = new List<Organization_data_source_kpi_Simple>();
                                    oOrganization_data_source_kpi_ID_By_Level_ID.LEVEL_ID = oSite.SITE_ID;
                                    oOrganization_data_source_kpi_ID_By_Level_ID.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE = oList_Site_kpi_Filtered.DistinctBy(oSite_kpi => oSite_kpi.Organization_data_source_kpi.KPI_ID).Select(oSite_kpi =>
                                    {
                                        return new Organization_data_source_kpi_Simple()
                                        {
                                            ORGANIZATION_DATA_SOURCE_KPI_ID = oSite_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                            KPI_ID = oSite_kpi.Organization_data_source_kpi.KPI_ID
                                        };
                                    }).ToList();
                                    oUser_Accessible_Level_List.ORGANIZATION_DATA_SOURCE_KPI_LIST_BY_TOP_LEVEL.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_SITE.Add(oOrganization_data_source_kpi_ID_By_Level_ID);
                                }

                                #endregion
                            }
                        }
                    }
                    else
                    {
                        oUser_Accessible_Level_List.ORGANIZATION_DATA_SOURCE_KPI_LIST_BY_TOP_LEVEL.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_SITE = new List<Organization_data_source_kpi_ID_By_Level_ID>();
                    }
                });
                var get_entity_KPI_IDs = Task.Run(() =>
                {
                    List<Entity> oList_Organization_Entity_By_TOP_LEVEL_ID = oList_Organization_Entity.Where(oEntity => oEntity.TOP_LEVEL_ID == Top_Level_ID).ToList();
                    if (oList_Organization_Entity_By_TOP_LEVEL_ID.Count > 0)
                    {
                        List<Entity_kpi> oList_Entity_kpi = Get_Entity_kpi_By_ENTITY_ID_List_Adv(new Params_Get_Entity_kpi_By_ENTITY_ID_List()
                        {
                            ENTITY_ID_LIST = oList_Organization_Entity_By_TOP_LEVEL_ID.Select(entity => entity.ENTITY_ID).ToList()
                        });
                        if (oList_Entity_kpi != null)
                        {
                            #region Fill Entity_Organization_data_source_kpi_ID_List

                            if (oUser.User_type_setup.VALUE != "Organization User")
                            {
                                Entity_Organization_data_source_kpi_ID_List = oList_Entity_kpi.DistinctBy(oEntity_kpi => oEntity_kpi.Organization_data_source_kpi.KPI_ID).Select(oEntity_kpi => oEntity_kpi.Organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();
                                oUser_Accessible_Level_List.ORGANIZATION_DATA_SOURCE_KPI_LIST_BY_TOP_LEVEL.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_ENTITY = new List<Organization_data_source_kpi_ID_By_Level_ID>();
                            }

                            #endregion


                            foreach (Entity oEntity in oList_Organization_Entity_By_TOP_LEVEL_ID)
                            {
                                List<Entity_kpi> oList_Entity_kpi_Filtered = oList_Entity_kpi.Where(oEntity_kpi => oEntity_kpi.ENTITY_ID == oEntity.ENTITY_ID).ToList();

                                Level_Kpi oLevel_Kpi = new Level_Kpi();
                                oLevel_Kpi.LEVEL_KPI_LIST = new List<int?>();

                                oLevel_Kpi.LEVEL_ID = oEntity.ENTITY_ID;
                                oLevel_Kpi.LEVEL_SETUP_ID = Entity_Setup_ID;
                                oLevel_Kpi.LEVEL_KPI_LIST = oList_Entity_kpi_Filtered.DistinctBy(oEntity_kpi => oEntity_kpi.Organization_data_source_kpi.KPI_ID).Select(oEntity_kpi => oEntity_kpi.Organization_data_source_kpi.KPI_ID).ToList();

                                oList_Organization_Entity_Kpi_ID.Add(oLevel_Kpi);

                                #region Assign LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_ENTITY

                                if (oUser.User_type_setup.VALUE != "Organization User")
                                {
                                    Organization_data_source_kpi_ID_By_Level_ID oOrganization_data_source_kpi_ID_By_Level_ID = new Organization_data_source_kpi_ID_By_Level_ID();
                                    oOrganization_data_source_kpi_ID_By_Level_ID.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE = new List<Organization_data_source_kpi_Simple>();
                                    oOrganization_data_source_kpi_ID_By_Level_ID.LEVEL_ID = oEntity.ENTITY_ID;
                                    oOrganization_data_source_kpi_ID_By_Level_ID.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE = oList_Entity_kpi_Filtered.DistinctBy(oEntity_kpi => oEntity_kpi.Organization_data_source_kpi.KPI_ID).Select(oEntity_kpi =>
                                    {
                                        return new Organization_data_source_kpi_Simple()
                                        {
                                            ORGANIZATION_DATA_SOURCE_KPI_ID = oEntity_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                            KPI_ID = oEntity_kpi.Organization_data_source_kpi.KPI_ID
                                        };
                                    }).ToList();
                                    oUser_Accessible_Level_List.ORGANIZATION_DATA_SOURCE_KPI_LIST_BY_TOP_LEVEL.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_ENTITY.Add(oOrganization_data_source_kpi_ID_By_Level_ID);
                                }

                                #endregion
                            }
                        }
                    }
                    else
                    {
                        oUser_Accessible_Level_List.ORGANIZATION_DATA_SOURCE_KPI_LIST_BY_TOP_LEVEL.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_ENTITY = new List<Organization_data_source_kpi_ID_By_Level_ID>();
                    }
                });

                Task.WaitAll(get_district_KPI_IDs, get_area_KPI_IDs, get_site_KPI_IDs, get_entity_KPI_IDs);

                #endregion
            });

            var get_accessible_kpi_id = Task.Run(() =>
            {
                if (oUser.User_type_setup.VALUE == "Organization User")
                {
                    #region Get KPI IDs for User Accessible Levels

                    var get_district_KPI_User_Access_IDs = Task.Run(() =>
                    {
                        if (oAccessible_Level_List_By_Top_Level.DISTRICT_LIST.Count > 0)
                        {
                            List<District_kpi_user_access> oList_District_kpi_user_access = Get_District_kpi_user_access_By_DISTRICT_ID_List_Adv(new Params_Get_District_kpi_user_access_By_DISTRICT_ID_List()
                            {
                                DISTRICT_ID_LIST = oAccessible_Level_List_By_Top_Level.DISTRICT_LIST.Select(district => district.DISTRICT_ID).ToList()
                            });

                            oList_District_kpi_user_access = oList_District_kpi_user_access.Where(oDistrict_kpi_user_access => oDistrict_kpi_user_access.USER_ID == oUser.USER_ID).ToList();


                            if (oList_District_kpi_user_access != null)
                            {
                                #region Fill District_Organization_data_source_kpi_ID_List

                                if (oUser.User_type_setup.VALUE == "Organization User")
                                {
                                    District_Organization_data_source_kpi_ID_List = oList_District_kpi_user_access.DistinctBy(oDistrict_kpi_user_access => oDistrict_kpi_user_access.Organization_data_source_kpi.KPI_ID).Select(oDistrict_kpi_user_access => oDistrict_kpi_user_access.Organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();
                                    oUser_Accessible_Level_List.ORGANIZATION_DATA_SOURCE_KPI_LIST_BY_TOP_LEVEL.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_DISTRICT = new List<Organization_data_source_kpi_ID_By_Level_ID>();
                                }

                                #endregion


                                foreach (District oDistrict in oAccessible_Level_List_By_Top_Level.DISTRICT_LIST)
                                {
                                    List<District_kpi_user_access> oList_District_kpi_user_access_Filtered = oList_District_kpi_user_access.Where(oDistrict_kpi_user_access => oDistrict_kpi_user_access.DISTRICT_ID == oDistrict.DISTRICT_ID).ToList();

                                    Level_Kpi oLevel_Kpi = new Level_Kpi();
                                    oLevel_Kpi.LEVEL_KPI_LIST = new List<int?>();

                                    oLevel_Kpi.LEVEL_ID = oDistrict.DISTRICT_ID;
                                    oLevel_Kpi.LEVEL_SETUP_ID = District_Setup_ID;
                                    oLevel_Kpi.LEVEL_KPI_LIST = oList_District_kpi_user_access_Filtered.DistinctBy(oDistrict_kpi => oDistrict_kpi.Organization_data_source_kpi.KPI_ID).Select(oDistrict_kpi => oDistrict_kpi.Organization_data_source_kpi.KPI_ID).ToList();

                                    oList_Accessible_District_Kpi_ID.Add(oLevel_Kpi);

                                    #region Assign LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_DISTRICT

                                    if (oUser.User_type_setup.VALUE == "Organization User")
                                    {
                                        Organization_data_source_kpi_ID_By_Level_ID oOrganization_data_source_kpi_ID_By_Level_ID = new Organization_data_source_kpi_ID_By_Level_ID();
                                        oOrganization_data_source_kpi_ID_By_Level_ID.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE = new List<Organization_data_source_kpi_Simple>();
                                        oOrganization_data_source_kpi_ID_By_Level_ID.LEVEL_ID = oDistrict.DISTRICT_ID;
                                        oOrganization_data_source_kpi_ID_By_Level_ID.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE = oList_District_kpi_user_access_Filtered.DistinctBy(oDistrict_kpi => oDistrict_kpi.Organization_data_source_kpi.KPI_ID).Select(oDistrict_kpi =>
                                        {
                                            return new Organization_data_source_kpi_Simple()
                                            {
                                                ORGANIZATION_DATA_SOURCE_KPI_ID = oDistrict_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                KPI_ID = oDistrict_kpi.Organization_data_source_kpi.KPI_ID
                                            };
                                        }).ToList();
                                        oUser_Accessible_Level_List.ORGANIZATION_DATA_SOURCE_KPI_LIST_BY_TOP_LEVEL.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_DISTRICT.Add(oOrganization_data_source_kpi_ID_By_Level_ID);
                                    }

                                    #endregion
                                }
                            }
                        }
                        else
                        {
                            oUser_Accessible_Level_List.ORGANIZATION_DATA_SOURCE_KPI_LIST_BY_TOP_LEVEL.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_DISTRICT = new List<Organization_data_source_kpi_ID_By_Level_ID>();
                        }
                    });
                    var get_area_KPI_User_Access_IDs = Task.Run(() =>
                    {
                        if (oAccessible_Level_List_By_Top_Level.AREA_LIST.Count > 0)
                        {
                            List<Area_kpi_user_access> oList_Area_kpi_user_access = Get_Area_kpi_user_access_By_AREA_ID_List_Adv(new Params_Get_Area_kpi_user_access_By_AREA_ID_List()
                            {
                                AREA_ID_LIST = oAccessible_Level_List_By_Top_Level.AREA_LIST.Select(area => area.AREA_ID).ToList()
                            });

                            oList_Area_kpi_user_access = oList_Area_kpi_user_access.Where(oArea_kpi_user_access => oArea_kpi_user_access.USER_ID == oUser.USER_ID).ToList();

                            if (oList_Area_kpi_user_access != null)
                            {
                                #region Fill Area_Organization_data_source_kpi_ID_List

                                if (oUser.User_type_setup.VALUE == "Organization User")
                                {
                                    Area_Organization_data_source_kpi_ID_List = oList_Area_kpi_user_access.DistinctBy(oArea_kpi_user_access => oArea_kpi_user_access.Organization_data_source_kpi.KPI_ID).Select(oArea_kpi_user_access => oArea_kpi_user_access.Organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();
                                    oUser_Accessible_Level_List.ORGANIZATION_DATA_SOURCE_KPI_LIST_BY_TOP_LEVEL.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_AREA = new List<Organization_data_source_kpi_ID_By_Level_ID>();
                                }

                                #endregion


                                foreach (Area oArea in oAccessible_Level_List_By_Top_Level.AREA_LIST)
                                {
                                    List<Area_kpi_user_access> oList_Area_kpi_user_access_Filtered = oList_Area_kpi_user_access.Where(oArea_kpi_user_access => oArea_kpi_user_access.AREA_ID == oArea.AREA_ID).ToList();

                                    Level_Kpi oLevel_Kpi = new Level_Kpi();
                                    oLevel_Kpi.LEVEL_KPI_LIST = new List<int?>();

                                    oLevel_Kpi.LEVEL_ID = oArea.AREA_ID;
                                    oLevel_Kpi.LEVEL_SETUP_ID = Area_Setup_ID;
                                    oLevel_Kpi.LEVEL_KPI_LIST = oList_Area_kpi_user_access_Filtered.DistinctBy(oArea_kpi => oArea_kpi.Organization_data_source_kpi.KPI_ID).Select(oArea_kpi => oArea_kpi.Organization_data_source_kpi.KPI_ID).ToList();

                                    oList_Accessible_Area_Kpi_ID.Add(oLevel_Kpi);

                                    #region LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_AREA

                                    if (oUser.User_type_setup.VALUE == "Organization User")
                                    {
                                        Organization_data_source_kpi_ID_By_Level_ID oOrganization_data_source_kpi_ID_By_Level_ID = new Organization_data_source_kpi_ID_By_Level_ID();
                                        oOrganization_data_source_kpi_ID_By_Level_ID.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE = new List<Organization_data_source_kpi_Simple>();
                                        oOrganization_data_source_kpi_ID_By_Level_ID.LEVEL_ID = oArea.AREA_ID;
                                        oOrganization_data_source_kpi_ID_By_Level_ID.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE = oList_Area_kpi_user_access_Filtered.DistinctBy(oArea_kpi => oArea_kpi.Organization_data_source_kpi.KPI_ID).Select(oArea_kpi =>
                                        {
                                            return new Organization_data_source_kpi_Simple()
                                            {
                                                ORGANIZATION_DATA_SOURCE_KPI_ID = oArea_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                KPI_ID = oArea_kpi.Organization_data_source_kpi.KPI_ID
                                            };
                                        }).ToList();
                                        oUser_Accessible_Level_List.ORGANIZATION_DATA_SOURCE_KPI_LIST_BY_TOP_LEVEL.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_AREA.Add(oOrganization_data_source_kpi_ID_By_Level_ID);
                                    }

                                    #endregion
                                }
                            }
                        }
                        else
                        {
                            oUser_Accessible_Level_List.ORGANIZATION_DATA_SOURCE_KPI_LIST_BY_TOP_LEVEL.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_AREA = new List<Organization_data_source_kpi_ID_By_Level_ID>();
                        }
                    });
                    var get_site_KPI_User_Access_IDs = Task.Run(() =>
                    {
                        if (oAccessible_Level_List_By_Top_Level.SITE_LIST.Count > 0)
                        {
                            List<Site_kpi_user_access> oList_Site_kpi_user_access = Get_Site_kpi_user_access_By_SITE_ID_List_Adv(new Params_Get_Site_kpi_user_access_By_SITE_ID_List()
                            {
                                SITE_ID_LIST = oAccessible_Level_List_By_Top_Level.SITE_LIST.Select(site => site.SITE_ID).ToList()
                            });
                            if (oList_Site_kpi_user_access != null)
                            {

                                oList_Site_kpi_user_access = oList_Site_kpi_user_access.Where(oSite_kpi_user_access => oSite_kpi_user_access.USER_ID == oUser.USER_ID).ToList();
                                #region Fill Site_Organization_data_source_kpi_ID_List

                                if (oUser.User_type_setup.VALUE == "Organization User")
                                {
                                    Site_Organization_data_source_kpi_ID_List = oList_Site_kpi_user_access.DistinctBy(oSite_kpi_user_access => oSite_kpi_user_access.Organization_data_source_kpi.KPI_ID).Select(oSite_kpi_user_access => oSite_kpi_user_access.Organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();
                                    oUser_Accessible_Level_List.ORGANIZATION_DATA_SOURCE_KPI_LIST_BY_TOP_LEVEL.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_SITE = new List<Organization_data_source_kpi_ID_By_Level_ID>();
                                }

                                #endregion


                                foreach (Site oSite in oAccessible_Level_List_By_Top_Level.SITE_LIST)
                                {
                                    List<Site_kpi_user_access> oList_Site_kpi_user_access_Filtered = oList_Site_kpi_user_access.Where(oSite_kpi_user_access => oSite_kpi_user_access.SITE_ID == oSite.SITE_ID).ToList();

                                    Level_Kpi oLevel_Kpi = new Level_Kpi();
                                    oLevel_Kpi.LEVEL_KPI_LIST = new List<int?>();

                                    oLevel_Kpi.LEVEL_ID = oSite.SITE_ID;
                                    oLevel_Kpi.LEVEL_SETUP_ID = Site_Setup_ID;
                                    oLevel_Kpi.LEVEL_KPI_LIST = oList_Site_kpi_user_access_Filtered.DistinctBy(oSite_kpi => oSite_kpi.Organization_data_source_kpi.KPI_ID).Select(oSite_kpi => oSite_kpi.Organization_data_source_kpi.KPI_ID).ToList();

                                    oList_Accessible_Site_Kpi_ID.Add(oLevel_Kpi);

                                    #region LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_SITE

                                    if (oUser.User_type_setup.VALUE == "Organization User")
                                    {
                                        Organization_data_source_kpi_ID_By_Level_ID oOrganization_data_source_kpi_ID_By_Level_ID = new Organization_data_source_kpi_ID_By_Level_ID();
                                        oOrganization_data_source_kpi_ID_By_Level_ID.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE = new List<Organization_data_source_kpi_Simple>();
                                        oOrganization_data_source_kpi_ID_By_Level_ID.LEVEL_ID = oSite.SITE_ID;
                                        oOrganization_data_source_kpi_ID_By_Level_ID.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE = oList_Site_kpi_user_access_Filtered.DistinctBy(oSite_kpi => oSite_kpi.Organization_data_source_kpi.KPI_ID).Select(oSite_kpi =>
                                        {
                                            return new Organization_data_source_kpi_Simple()
                                            {
                                                ORGANIZATION_DATA_SOURCE_KPI_ID = oSite_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                KPI_ID = oSite_kpi.Organization_data_source_kpi.KPI_ID
                                            };
                                        }).ToList();
                                        oUser_Accessible_Level_List.ORGANIZATION_DATA_SOURCE_KPI_LIST_BY_TOP_LEVEL.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_SITE.Add(oOrganization_data_source_kpi_ID_By_Level_ID);
                                    }

                                    #endregion
                                }
                            }
                        }
                        else
                        {
                            oUser_Accessible_Level_List.ORGANIZATION_DATA_SOURCE_KPI_LIST_BY_TOP_LEVEL.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_SITE = new List<Organization_data_source_kpi_ID_By_Level_ID>();
                        }
                    });
                    var get_entity_KPI_User_Access_IDs = Task.Run(() =>
                    {
                        if (oAccessible_Level_List_By_Top_Level.ENTITY_LIST.Count > 0)
                        {
                            List<Entity_kpi_user_access> oList_Entity_kpi_user_access = Get_Entity_kpi_user_access_By_ENTITY_ID_List_Adv(new Params_Get_Entity_kpi_user_access_By_ENTITY_ID_List()
                            {
                                ENTITY_ID_LIST = oAccessible_Level_List_By_Top_Level.ENTITY_LIST.Select(entity => entity.ENTITY_ID).ToList()
                            });

                            oList_Entity_kpi_user_access = oList_Entity_kpi_user_access.Where(oEntity_kpi_user_access => oEntity_kpi_user_access.USER_ID == oUser.USER_ID).ToList();


                            if (oList_Entity_kpi_user_access != null)
                            {
                                #region Fill Entity_Organization_data_source_kpi_ID_List

                                if (oUser.User_type_setup.VALUE == "Organization User")
                                {
                                    Entity_Organization_data_source_kpi_ID_List = oList_Entity_kpi_user_access.DistinctBy(oEntity_kpi_user_access => oEntity_kpi_user_access.Organization_data_source_kpi.KPI_ID).Select(oEntity_kpi_user_access => oEntity_kpi_user_access.Organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList();
                                    oUser_Accessible_Level_List.ORGANIZATION_DATA_SOURCE_KPI_LIST_BY_TOP_LEVEL.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_ENTITY = new List<Organization_data_source_kpi_ID_By_Level_ID>();
                                }

                                #endregion


                                foreach (Entity oEntity in oAccessible_Level_List_By_Top_Level.ENTITY_LIST)
                                {
                                    List<Entity_kpi_user_access> oList_Entity_kpi_user_access_Filtered = oList_Entity_kpi_user_access.Where(oEntity_kpi_user_access => oEntity_kpi_user_access.ENTITY_ID == oEntity.ENTITY_ID).ToList();

                                    Level_Kpi oLevel_Kpi = new Level_Kpi();
                                    oLevel_Kpi.LEVEL_KPI_LIST = new List<int?>();

                                    oLevel_Kpi.LEVEL_ID = oEntity.ENTITY_ID;
                                    oLevel_Kpi.LEVEL_SETUP_ID = Entity_Setup_ID;
                                    oLevel_Kpi.LEVEL_KPI_LIST = oList_Entity_kpi_user_access_Filtered.DistinctBy(oEntity_kpi => oEntity_kpi.Organization_data_source_kpi.KPI_ID).Select(oEntity_kpi => oEntity_kpi.Organization_data_source_kpi.KPI_ID).ToList();

                                    oList_Accessible_Entity_Kpi_ID.Add(oLevel_Kpi);

                                    #region LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_ENTITY

                                    if (oUser.User_type_setup.VALUE == "Organization User")
                                    {
                                        Organization_data_source_kpi_ID_By_Level_ID oOrganization_data_source_kpi_ID_By_Level_ID = new Organization_data_source_kpi_ID_By_Level_ID();
                                        oOrganization_data_source_kpi_ID_By_Level_ID.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE = new List<Organization_data_source_kpi_Simple>();
                                        oOrganization_data_source_kpi_ID_By_Level_ID.LEVEL_ID = oEntity.ENTITY_ID;
                                        oOrganization_data_source_kpi_ID_By_Level_ID.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE = oList_Entity_kpi_user_access_Filtered.DistinctBy(oEntity_kpi => oEntity_kpi.Organization_data_source_kpi.KPI_ID).Select(oEntity_kpi =>
                                        {
                                            return new Organization_data_source_kpi_Simple()
                                            {
                                                ORGANIZATION_DATA_SOURCE_KPI_ID = oEntity_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                                                KPI_ID = oEntity_kpi.Organization_data_source_kpi.KPI_ID
                                            };
                                        }).ToList();
                                        oUser_Accessible_Level_List.ORGANIZATION_DATA_SOURCE_KPI_LIST_BY_TOP_LEVEL.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_ENTITY.Add(oOrganization_data_source_kpi_ID_By_Level_ID);
                                    }

                                    #endregion
                                }
                            }
                        }
                        else
                        {
                            oUser_Accessible_Level_List.ORGANIZATION_DATA_SOURCE_KPI_LIST_BY_TOP_LEVEL.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_ENTITY = new List<Organization_data_source_kpi_ID_By_Level_ID>();
                        }
                    });

                    Task.WaitAll(get_district_KPI_User_Access_IDs, get_area_KPI_User_Access_IDs, get_site_KPI_User_Access_IDs, get_entity_KPI_User_Access_IDs);

                    #endregion
                }
            });

            Task.WaitAll(get_organization_kpi_id, get_accessible_kpi_id);

            #endregion

            #region Create Level_Dimension_with_Status List

            List<int?> oList_Dimension_Kpi_ID = new List<int?>();
            List<Level_Dimension_with_Status> oList_District_Dimension_with_Status = new List<Level_Dimension_with_Status>();
            List<Level_Dimension_with_Status> oList_Area_Dimension_with_Status = new List<Level_Dimension_with_Status>();
            List<Level_Dimension_with_Status> oList_Site_Dimension_with_Status = new List<Level_Dimension_with_Status>();
            List<Level_Dimension_with_Status> oList_Entity_Dimension_with_Status = new List<Level_Dimension_with_Status>();
            foreach (Dimension oDimension in oList_Dimension)
            {
                if (oDimension.List_Kpi != null && oDimension.List_Kpi.Count > 0)
                {
                    oList_Dimension_Kpi_ID = oDimension.List_Kpi.Select(KPI => KPI.KPI_ID).ToList();
                }

                var fill_district_dimension_with_status = Task.Run(() =>
                {
                    #region Declaration & Initialization

                    List<long?> List_District_ID_Dimension_Enabled = new List<long?>();
                    List<long?> List_District_ID_Dimension_Disabled = new List<long?>();
                    List<long?> List_District_ID_Dimension_Hidden = new List<long?>();
                    Level_Dimension_with_Status oLevel_Dimension_with_Status_ENABLED = new Level_Dimension_with_Status()
                    {
                        DATA_LEVEL_SETUP_ID = District_Setup_ID,
                        DIMENSION = oDimension,
                        ENUM_DIMENSION_STATUS = Enum_Dimension_Status.ENABLED,
                        LEVEL_ID_LIST = new List<long?>()
                    };
                    Level_Dimension_with_Status oLevel_Dimension_with_Status_DISABLED = new Level_Dimension_with_Status()
                    {
                        DATA_LEVEL_SETUP_ID = District_Setup_ID,
                        DIMENSION = oDimension,
                        ENUM_DIMENSION_STATUS = Enum_Dimension_Status.DISABLED,
                        LEVEL_ID_LIST = new List<long?>()
                    };
                    Level_Dimension_with_Status oLevel_Dimension_with_Status_HIDDEN = new Level_Dimension_with_Status()
                    {
                        DATA_LEVEL_SETUP_ID = District_Setup_ID,
                        DIMENSION = oDimension,
                        ENUM_DIMENSION_STATUS = Enum_Dimension_Status.HIDDEN,
                        LEVEL_ID_LIST = new List<long?>()
                    };

                    #endregion

                    #region Loop Over District

                    foreach (Level_Kpi oLevel_Kpi in oList_Organization_District_Kpi_ID)
                    {
                        if (oLevel_Kpi.LEVEL_KPI_LIST.Count > 0 && oList_Dimension_Kpi_ID.Intersect(oLevel_Kpi.LEVEL_KPI_LIST).Any())
                        {
                            Level_Kpi oUser_District_Kpi = oList_Accessible_District_Kpi_ID.Find(_Level_Kpi => _Level_Kpi.LEVEL_ID == oLevel_Kpi.LEVEL_ID);

                            if (oUser.User_type_setup.VALUE == "Organization User" && oUser_District_Kpi == null)
                            {
                                List_District_ID_Dimension_Disabled.Add(oLevel_Kpi.LEVEL_ID);
                            }
                            else if (oUser.User_type_setup.VALUE == "Organization User" && !oList_Dimension_Kpi_ID.Intersect(oUser_District_Kpi.LEVEL_KPI_LIST).Any())
                            {
                                List_District_ID_Dimension_Disabled.Add(oLevel_Kpi.LEVEL_ID);
                            }
                            else
                            {
                                List_District_ID_Dimension_Enabled.Add(oLevel_Kpi.LEVEL_ID);
                            }
                        }
                        else
                        {
                            List_District_ID_Dimension_Hidden.Add(oLevel_Kpi.LEVEL_ID);
                        }
                    }

                    #endregion

                    #region Fill List

                    oLevel_Dimension_with_Status_ENABLED.LEVEL_ID_LIST = List_District_ID_Dimension_Enabled;
                    oLevel_Dimension_with_Status_HIDDEN.LEVEL_ID_LIST = List_District_ID_Dimension_Hidden;
                    oLevel_Dimension_with_Status_DISABLED.LEVEL_ID_LIST = List_District_ID_Dimension_Disabled;

                    oList_District_Dimension_with_Status.Add(oLevel_Dimension_with_Status_ENABLED);
                    oList_District_Dimension_with_Status.Add(oLevel_Dimension_with_Status_HIDDEN);
                    oList_District_Dimension_with_Status.Add(oLevel_Dimension_with_Status_DISABLED);

                    #endregion
                });

                var fill_area_dimension_with_status = Task.Run(() =>
                {
                    #region Declaration & Initialization

                    List<long?> List_Area_ID_Dimension_Enabled = new List<long?>();
                    List<long?> List_Area_ID_Dimension_Disabled = new List<long?>();
                    List<long?> List_Area_ID_Dimension_Hidden = new List<long?>();
                    Level_Dimension_with_Status oLevel_Dimension_with_Status_ENABLED = new Level_Dimension_with_Status()
                    {
                        DATA_LEVEL_SETUP_ID = Area_Setup_ID,
                        DIMENSION = oDimension,
                        ENUM_DIMENSION_STATUS = Enum_Dimension_Status.ENABLED,
                        LEVEL_ID_LIST = new List<long?>()
                    };
                    Level_Dimension_with_Status oLevel_Dimension_with_Status_DISABLED = new Level_Dimension_with_Status()
                    {
                        DATA_LEVEL_SETUP_ID = Area_Setup_ID,
                        DIMENSION = oDimension,
                        ENUM_DIMENSION_STATUS = Enum_Dimension_Status.DISABLED,
                        LEVEL_ID_LIST = new List<long?>()
                    };
                    Level_Dimension_with_Status oLevel_Dimension_with_Status_HIDDEN = new Level_Dimension_with_Status()
                    {
                        DATA_LEVEL_SETUP_ID = Area_Setup_ID,
                        DIMENSION = oDimension,
                        ENUM_DIMENSION_STATUS = Enum_Dimension_Status.HIDDEN,
                        LEVEL_ID_LIST = new List<long?>()
                    };

                    #endregion

                    #region Loop Over Area

                    foreach (Level_Kpi oLevel_Kpi in oList_Organization_Area_Kpi_ID)
                    {
                        if (oLevel_Kpi.LEVEL_KPI_LIST.Count > 0 && oList_Dimension_Kpi_ID.Intersect(oLevel_Kpi.LEVEL_KPI_LIST).Any())
                        {
                            Level_Kpi oUser_Area_Kpi = oList_Accessible_Area_Kpi_ID.Find(_Level_Kpi => _Level_Kpi.LEVEL_ID == oLevel_Kpi.LEVEL_ID);

                            if (oUser.User_type_setup.VALUE == "Organization User" && oUser_Area_Kpi == null)
                            {
                                List_Area_ID_Dimension_Disabled.Add(oLevel_Kpi.LEVEL_ID);
                            }
                            else if (oUser.User_type_setup.VALUE == "Organization User" && !oList_Dimension_Kpi_ID.Intersect(oUser_Area_Kpi.LEVEL_KPI_LIST).Any())
                            {
                                List_Area_ID_Dimension_Disabled.Add(oLevel_Kpi.LEVEL_ID);
                            }
                            else
                            {
                                List_Area_ID_Dimension_Enabled.Add(oLevel_Kpi.LEVEL_ID);
                            }
                        }
                        else
                        {
                            List_Area_ID_Dimension_Hidden.Add(oLevel_Kpi.LEVEL_ID);
                        }
                    }

                    #endregion

                    #region Fill List

                    oLevel_Dimension_with_Status_ENABLED.LEVEL_ID_LIST = List_Area_ID_Dimension_Enabled;
                    oLevel_Dimension_with_Status_HIDDEN.LEVEL_ID_LIST = List_Area_ID_Dimension_Hidden;
                    oLevel_Dimension_with_Status_DISABLED.LEVEL_ID_LIST = List_Area_ID_Dimension_Disabled;

                    oList_Area_Dimension_with_Status.Add(oLevel_Dimension_with_Status_ENABLED);
                    oList_Area_Dimension_with_Status.Add(oLevel_Dimension_with_Status_HIDDEN);
                    oList_Area_Dimension_with_Status.Add(oLevel_Dimension_with_Status_DISABLED);

                    #endregion
                });

                var fill_site_dimension_with_status = Task.Run(() =>
                {
                    #region Declaration & Initialization

                    List<long?> List_Site_ID_Dimension_Enabled = new List<long?>();
                    List<long?> List_Site_ID_Dimension_Disabled = new List<long?>();
                    List<long?> List_Site_ID_Dimension_Hidden = new List<long?>();
                    Level_Dimension_with_Status oLevel_Dimension_with_Status_ENABLED = new Level_Dimension_with_Status()
                    {
                        DATA_LEVEL_SETUP_ID = Site_Setup_ID,
                        DIMENSION = oDimension,
                        ENUM_DIMENSION_STATUS = Enum_Dimension_Status.ENABLED,
                        LEVEL_ID_LIST = new List<long?>()
                    };
                    Level_Dimension_with_Status oLevel_Dimension_with_Status_DISABLED = new Level_Dimension_with_Status()
                    {
                        DATA_LEVEL_SETUP_ID = Site_Setup_ID,
                        DIMENSION = oDimension,
                        ENUM_DIMENSION_STATUS = Enum_Dimension_Status.DISABLED,
                        LEVEL_ID_LIST = new List<long?>()
                    };
                    Level_Dimension_with_Status oLevel_Dimension_with_Status_HIDDEN = new Level_Dimension_with_Status()
                    {
                        DATA_LEVEL_SETUP_ID = Site_Setup_ID,
                        DIMENSION = oDimension,
                        ENUM_DIMENSION_STATUS = Enum_Dimension_Status.HIDDEN,
                        LEVEL_ID_LIST = new List<long?>()
                    };

                    #endregion

                    #region Loop Over Site

                    foreach (Level_Kpi oLevel_Kpi in oList_Organization_Site_Kpi_ID)
                    {
                        if (oLevel_Kpi.LEVEL_KPI_LIST.Count > 0 && oList_Dimension_Kpi_ID.Intersect(oLevel_Kpi.LEVEL_KPI_LIST).Any())
                        {
                            Level_Kpi oUser_Site_Kpi = oList_Accessible_Site_Kpi_ID.Find(_Level_Kpi => _Level_Kpi.LEVEL_ID == oLevel_Kpi.LEVEL_ID);

                            if (oUser.User_type_setup.VALUE == "Organization User" && oUser_Site_Kpi == null)
                            {
                                List_Site_ID_Dimension_Disabled.Add(oLevel_Kpi.LEVEL_ID);
                            }
                            else if (oUser.User_type_setup.VALUE == "Organization User" && !oList_Dimension_Kpi_ID.Intersect(oUser_Site_Kpi.LEVEL_KPI_LIST).Any())
                            {
                                List_Site_ID_Dimension_Disabled.Add(oLevel_Kpi.LEVEL_ID);
                            }
                            else
                            {
                                List_Site_ID_Dimension_Enabled.Add(oLevel_Kpi.LEVEL_ID);
                            }
                        }
                        else
                        {
                            List_Site_ID_Dimension_Hidden.Add(oLevel_Kpi.LEVEL_ID);
                        }
                    }

                    #endregion

                    #region Fill List

                    oLevel_Dimension_with_Status_ENABLED.LEVEL_ID_LIST = List_Site_ID_Dimension_Enabled;
                    oLevel_Dimension_with_Status_HIDDEN.LEVEL_ID_LIST = List_Site_ID_Dimension_Hidden;
                    oLevel_Dimension_with_Status_DISABLED.LEVEL_ID_LIST = List_Site_ID_Dimension_Disabled;

                    oList_Site_Dimension_with_Status.Add(oLevel_Dimension_with_Status_ENABLED);
                    oList_Site_Dimension_with_Status.Add(oLevel_Dimension_with_Status_HIDDEN);
                    oList_Site_Dimension_with_Status.Add(oLevel_Dimension_with_Status_DISABLED);

                    #endregion
                });

                var fill_entity_dimension_with_status = Task.Run(() =>
                {
                    #region Declaration & Initialization

                    List<long?> List_Entity_ID_Dimension_Enabled = new List<long?>();
                    List<long?> List_Entity_ID_Dimension_Disabled = new List<long?>();
                    List<long?> List_Entity_ID_Dimension_Hidden = new List<long?>();
                    Level_Dimension_with_Status oLevel_Dimension_with_Status_ENABLED = new Level_Dimension_with_Status()
                    {
                        DATA_LEVEL_SETUP_ID = Entity_Setup_ID,
                        DIMENSION = oDimension,
                        ENUM_DIMENSION_STATUS = Enum_Dimension_Status.ENABLED,
                        LEVEL_ID_LIST = new List<long?>()
                    };
                    Level_Dimension_with_Status oLevel_Dimension_with_Status_DISABLED = new Level_Dimension_with_Status()
                    {
                        DATA_LEVEL_SETUP_ID = Entity_Setup_ID,
                        DIMENSION = oDimension,
                        ENUM_DIMENSION_STATUS = Enum_Dimension_Status.DISABLED,
                        LEVEL_ID_LIST = new List<long?>()
                    };
                    Level_Dimension_with_Status oLevel_Dimension_with_Status_HIDDEN = new Level_Dimension_with_Status()
                    {
                        DATA_LEVEL_SETUP_ID = Entity_Setup_ID,
                        DIMENSION = oDimension,
                        ENUM_DIMENSION_STATUS = Enum_Dimension_Status.HIDDEN,
                        LEVEL_ID_LIST = new List<long?>()
                    };

                    #endregion

                    #region Loop Over Entity

                    foreach (Level_Kpi oLevel_Kpi in oList_Organization_Entity_Kpi_ID)
                    {
                        if (oLevel_Kpi.LEVEL_KPI_LIST.Count > 0 && oList_Dimension_Kpi_ID.Intersect(oLevel_Kpi.LEVEL_KPI_LIST).Any())
                        {
                            Level_Kpi oUser_Entity_Kpi = oList_Accessible_Entity_Kpi_ID.Find(_Level_Kpi => _Level_Kpi.LEVEL_ID == oLevel_Kpi.LEVEL_ID);

                            if (oUser.User_type_setup.VALUE == "Organization User" && oUser_Entity_Kpi == null)
                            {
                                List_Entity_ID_Dimension_Disabled.Add(oLevel_Kpi.LEVEL_ID);
                            }
                            else if (oUser.User_type_setup.VALUE == "Organization User" && !oList_Dimension_Kpi_ID.Intersect(oUser_Entity_Kpi.LEVEL_KPI_LIST).Any())
                            {
                                List_Entity_ID_Dimension_Disabled.Add(oLevel_Kpi.LEVEL_ID);
                            }
                            else
                            {
                                List_Entity_ID_Dimension_Enabled.Add(oLevel_Kpi.LEVEL_ID);
                            }
                        }
                        else
                        {
                            List_Entity_ID_Dimension_Hidden.Add(oLevel_Kpi.LEVEL_ID);
                        }
                    }

                    #endregion

                    #region Fill List

                    oLevel_Dimension_with_Status_ENABLED.LEVEL_ID_LIST = List_Entity_ID_Dimension_Enabled;
                    oLevel_Dimension_with_Status_HIDDEN.LEVEL_ID_LIST = List_Entity_ID_Dimension_Hidden;
                    oLevel_Dimension_with_Status_DISABLED.LEVEL_ID_LIST = List_Entity_ID_Dimension_Disabled;

                    oList_Entity_Dimension_with_Status.Add(oLevel_Dimension_with_Status_ENABLED);
                    oList_Entity_Dimension_with_Status.Add(oLevel_Dimension_with_Status_HIDDEN);
                    oList_Entity_Dimension_with_Status.Add(oLevel_Dimension_with_Status_DISABLED);

                    #endregion
                });

                Task.WaitAll(fill_district_dimension_with_status, fill_area_dimension_with_status, fill_site_dimension_with_status, fill_entity_dimension_with_status);

                #region Fill List

                oUser_Accessible_Level_List.LIST_LEVEL_DIMENSION_WITH_STATUS = new List<Level_Dimension_with_Status>();
                oUser_Accessible_Level_List.LIST_LEVEL_DIMENSION_WITH_STATUS = oUser_Accessible_Level_List.LIST_LEVEL_DIMENSION_WITH_STATUS.Concat(oList_District_Dimension_with_Status)
                                                                                                                                            .Concat(oList_Area_Dimension_with_Status)
                                                                                                                                            .Concat(oList_Site_Dimension_with_Status)
                                                                                                                                            .Concat(oList_Entity_Dimension_with_Status)
                                                                                                                                            .ToList();

                #endregion

            }

            #endregion

            #region Assign Organization_data_source_kpi_List

            var assign_Organization_data_source_kpi_List = Task.Run(() =>
            {
                List<int?> Organization_data_source_kpi_ID_List = new List<int?>();
                Organization_data_source_kpi_ID_List = Organization_data_source_kpi_ID_List.Concat(District_Organization_data_source_kpi_ID_List)
                                                                                            .Concat(Area_Organization_data_source_kpi_ID_List)
                                                                                            .Concat(Site_Organization_data_source_kpi_ID_List)
                                                                                            .Concat(Entity_Organization_data_source_kpi_ID_List)
                                                                                            .Distinct()
                                                                                            .ToList();
                oUser_Accessible_Level_List.ORGANIZATION_DATA_SOURCE_KPI_LIST = new List<Organization_data_source_kpi>();

                if (Organization_data_source_kpi_ID_List != null && Organization_data_source_kpi_ID_List.Count > 0)
                {
                    oUser_Accessible_Level_List.ORGANIZATION_DATA_SOURCE_KPI_LIST = Props.Copy_Prop_Values_From_Api_Response<List<Organization_data_source_kpi>>(
                        this._service_mesh.Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv(
                            new Service_Mesh.Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List()
                            {
                                ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = Organization_data_source_kpi_ID_List
                            }).i_Result
                        );
                }
            });

            #endregion

            #region Get GeoJson, Dimension_index & Upper Level

            var get_geojson_and_dimension_index_and_upper_level = Task.Run(() =>
            {
                #region Check Data_LeveL_Setup_ID

                string DataLevel = "";
                if (i_Params_Get_User_Accessible_Level_List.DATA_LEVEL_SETUP_ID != null &&
                    oList_Data_Level_Setup.Any(oData_Level_Setup => oData_Level_Setup.SETUP_ID == i_Params_Get_User_Accessible_Level_List.DATA_LEVEL_SETUP_ID))
                {
                    oSetup_Data_Level = oList_Data_Level_Setup.FirstOrDefault(setup => setup.SETUP_ID == i_Params_Get_User_Accessible_Level_List.DATA_LEVEL_SETUP_ID);
                    DataLevel = oSetup_Data_Level.VALUE;
                }
                else
                {
                    if (oAccessible_Level_List_By_Top_Level.DISTRICT_LIST != null && oAccessible_Level_List_By_Top_Level.DISTRICT_LIST.Count > 0)
                    {
                        DataLevel = "District";
                    }
                    else if (oAccessible_Level_List_By_Top_Level.AREA_LIST != null && oAccessible_Level_List_By_Top_Level.AREA_LIST.Count > 0)
                    {
                        DataLevel = "Area";
                    }
                    else if (oAccessible_Level_List_By_Top_Level.SITE_LIST != null && oAccessible_Level_List_By_Top_Level.SITE_LIST.Count > 0)
                    {
                        DataLevel = "Site";
                    }
                    else if (oAccessible_Level_List_By_Top_Level.ENTITY_LIST != null && oAccessible_Level_List_By_Top_Level.ENTITY_LIST.Count > 0)
                    {
                        DataLevel = "Entity";
                    }
                    else
                    {
                        throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0047)); // The user does not have access to any level.
                    }
                    oSetup_Data_Level = oList_Data_Level_Setup.FirstOrDefault(setup => setup.VALUE == DataLevel);
                }

                #endregion

                switch (DataLevel)
                {
                    case ("District"):
                        #region Get Dimension_index and GeoJson

                        var get_districts_geojson = Task.Run(() =>
                        {
                            oUser_Accessible_Level_List.GEOJSON_SRC = this._service_mesh.Get_District_geojson_By_DISTRICT_ID_List(new Service_Mesh.Params_Get_District_geojson_By_DISTRICT_ID_List()
                            {
                                DISTRICT_ID_LIST = oList_Accessible_Level_ID_List_By_Top_Level.FirstOrDefault(oAccessible_Level_ID_List_By_Top_Level => oAccessible_Level_ID_List_By_Top_Level.TOP_LEVEL_ID == Top_Level_ID).DISTRICT_ID_LIST
                            }).i_Result;
                        });

                        var get_dimension_index = Task.Run(() =>
                        {
                            long? District_ID = 0;
                            if (i_Params_Get_User_Accessible_Level_List.SELECTED_LEVEL_ID != null && oList_Accessible_Level_ID_List_By_Top_Level.FirstOrDefault(oAccessible_Level_ID_List_By_Top_Level => oAccessible_Level_ID_List_By_Top_Level.TOP_LEVEL_ID == Top_Level_ID).DISTRICT_ID_LIST.Contains(i_Params_Get_User_Accessible_Level_List.SELECTED_LEVEL_ID))
                            {
                                District_ID = i_Params_Get_User_Accessible_Level_List.SELECTED_LEVEL_ID;
                            }
                            else
                            {
                                District_ID = oAccessible_Level_List_By_Top_Level.DISTRICT_LIST.FirstOrDefault().DISTRICT_ID;
                            }
                            District oDistrict = oList_Accessible_District.FirstOrDefault(oDistrict => oDistrict.DISTRICT_ID == District_ID);
                            if (oDistrict != null)
                            {
                                oUser_Accessible_Level_List.UPPER_LEVEL = new Upper_Level()
                                {
                                    LEVEL_ID = oDistrict.DISTRICT_ID,
                                    NAME = oDistrict.NAME,
                                    LOCATION = oDistrict.LOCATION,
                                    LOGO_URL = oDistrict.LOGO_URL,
                                    IMAGE_URL = oDistrict.IMAGE_URL,
                                    LONGITUDE = oDistrict.GLTF_LONGITUDE,
                                    LATITUDE = oDistrict.GLTF_LATITUDE
                                };
                                oUser_Accessible_Level_List.DATA_LEVEL_SETUP_ID = District_Setup_ID;
                            }

                            List<int?> List_Dimension_ID = oList_District_Dimension_with_Status.Where(oLevel_Dimension_with_Status => oLevel_Dimension_with_Status.LEVEL_ID_LIST.Contains(District_ID) && oLevel_Dimension_with_Status.ENUM_DIMENSION_STATUS != Enum_Dimension_Status.HIDDEN)
                                                                                                .Select(oLevel_Dimension_with_Status => oLevel_Dimension_with_Status.DIMENSION.DIMENSION_ID)
                                                                                                .ToList();

                            oUser_Accessible_Level_List.LIST_DIMENSION_INDEX = Props.Copy_Prop_Values_From_Api_Response<List<Dimension_index>>(
                               this._service_mesh.Get_Dimension_index_By_Where(new Service_Mesh.Params_Get_Dimension_index_By_Where()
                               {
                                   LIST_LEVEL_ID = new List<long?>() { District_ID },
                                   LIST_DIMENSION_ID = List_Dimension_ID,
                                   LEVEL_SETUP_ID = District_Setup_ID,
                                   START_DATE = (DateTime)i_Params_Get_User_Accessible_Level_List.START_DATE,
                                   END_DATE = (DateTime)i_Params_Get_User_Accessible_Level_List.END_DATE,
                                   ENUM_TIMESPAN = (Service_Mesh.Enum_Timespan)i_Params_Get_User_Accessible_Level_List.ENUM_TIMESPAN
                               }).i_Result
                            );
                        });

                        Task.WaitAll(get_districts_geojson, get_dimension_index);

                        #endregion
                        break;
                    case ("Area"):
                        #region Get Dimension_index and GeoJson

                        var get_areas_geojson = Task.Run(() =>
                        {
                            oUser_Accessible_Level_List.GEOJSON_SRC = this._service_mesh.Get_Area_geojson_By_AREA_ID_List(new Service_Mesh.Params_Get_Area_geojson_By_AREA_ID_List()
                            {
                                AREA_ID_LIST = oList_Accessible_Level_ID_List_By_Top_Level.FirstOrDefault(oAccessible_Level_ID_List_By_Top_Level => oAccessible_Level_ID_List_By_Top_Level.TOP_LEVEL_ID == Top_Level_ID).AREA_ID_LIST
                            }).i_Result;
                        });

                        var get_district_dimension_index = Task.Run(() =>
                        {
                            long? District_ID = 0;
                            if (i_Params_Get_User_Accessible_Level_List.SELECTED_LEVEL_ID != null && oList_Accessible_Level_ID_List_By_Top_Level.FirstOrDefault(oAccessible_Level_ID_List_By_Top_Level => oAccessible_Level_ID_List_By_Top_Level.TOP_LEVEL_ID == Top_Level_ID).AREA_ID_LIST.Contains(i_Params_Get_User_Accessible_Level_List.SELECTED_LEVEL_ID))
                            {
                                District_ID = oAccessible_Level_List_By_Top_Level.AREA_LIST.Find(oArea => oArea.AREA_ID == i_Params_Get_User_Accessible_Level_List.SELECTED_LEVEL_ID).DISTRICT_ID;
                            }
                            else
                            {
                                District_ID = oAccessible_Level_List_By_Top_Level.AREA_LIST.FirstOrDefault().DISTRICT_ID;
                            }

                            var get_district_by_district_id = Task.Run(() =>
                            {
                                District oDistrict = Get_District_By_DISTRICT_ID(new Params_Get_District_By_DISTRICT_ID
                                {
                                    DISTRICT_ID = District_ID
                                });
                                if (oDistrict != null)
                                {
                                    oUser_Accessible_Level_List.UPPER_LEVEL = new Upper_Level()
                                    {
                                        LEVEL_ID = oDistrict.DISTRICT_ID,
                                        NAME = oDistrict.NAME,
                                        LOCATION = oDistrict.LOCATION,
                                        LOGO_URL = oDistrict.LOGO_URL,
                                        IMAGE_URL = oDistrict.IMAGE_URL,
                                        LONGITUDE = oDistrict.GLTF_LONGITUDE,
                                        LATITUDE = oDistrict.GLTF_LATITUDE
                                    };
                                    oUser_Accessible_Level_List.DATA_LEVEL_SETUP_ID = District_Setup_ID;
                                }
                            });
                            var get_dimension_index_by_where = Task.Run(() =>
                            {
                                List<int?> List_Dimension_ID = oList_District_Dimension_with_Status.Where(oLevel_Dimension_with_Status => oLevel_Dimension_with_Status.LEVEL_ID_LIST.Contains(District_ID) && oLevel_Dimension_with_Status.ENUM_DIMENSION_STATUS != Enum_Dimension_Status.HIDDEN)
                                                                                                .Select(oLevel_Dimension_with_Status => oLevel_Dimension_with_Status.DIMENSION.DIMENSION_ID)
                                                                                                .ToList();

                                oList_Dimension_index = Props.Copy_Prop_Values_From_Api_Response<List<Dimension_index>>(
                                   this._service_mesh.Get_Dimension_index_By_Where(new Service_Mesh.Params_Get_Dimension_index_By_Where()
                                   {
                                       LIST_LEVEL_ID = new List<long?>() { District_ID },
                                       LIST_DIMENSION_ID = List_Dimension_ID,
                                       LEVEL_SETUP_ID = District_Setup_ID,
                                       START_DATE = (DateTime)i_Params_Get_User_Accessible_Level_List.START_DATE,
                                       END_DATE = (DateTime)i_Params_Get_User_Accessible_Level_List.END_DATE,
                                       ENUM_TIMESPAN = (Service_Mesh.Enum_Timespan)i_Params_Get_User_Accessible_Level_List.ENUM_TIMESPAN
                                   }).i_Result
                               );
                                oUser_Accessible_Level_List.LIST_DIMENSION_INDEX = oList_Dimension_index;
                            });

                            Task.WaitAll(get_district_by_district_id, get_dimension_index_by_where);
                        });

                        Task.WaitAll(get_areas_geojson, get_district_dimension_index);

                        #endregion
                        break;
                    case ("Site"):
                        #region Get Dimension_index and GeoJson

                        var get_sites_geojson = Task.Run(() =>
                        {
                            oUser_Accessible_Level_List.GEOJSON_SRC = this._service_mesh.Get_Site_geojson_By_SITE_ID_List(new Service_Mesh.Params_Get_Site_geojson_By_SITE_ID_List()
                            {
                                SITE_ID_LIST = oList_Accessible_Level_ID_List_By_Top_Level.FirstOrDefault(oAccessible_Level_ID_List_By_Top_Level => oAccessible_Level_ID_List_By_Top_Level.TOP_LEVEL_ID == Top_Level_ID).SITE_ID_LIST
                            }).i_Result;
                        });

                        var get_area_dimension_index = Task.Run(() =>
                        {
                            long? Area_ID = 0;
                            if (i_Params_Get_User_Accessible_Level_List.SELECTED_LEVEL_ID != null && oList_Accessible_Level_ID_List_By_Top_Level.FirstOrDefault(oAccessible_Level_ID_List_By_Top_Level => oAccessible_Level_ID_List_By_Top_Level.TOP_LEVEL_ID == Top_Level_ID).SITE_ID_LIST.Contains(i_Params_Get_User_Accessible_Level_List.SELECTED_LEVEL_ID))
                            {
                                Area_ID = oAccessible_Level_List_By_Top_Level.SITE_LIST.Find(oSite => oSite.SITE_ID == i_Params_Get_User_Accessible_Level_List.SELECTED_LEVEL_ID).AREA_ID;
                            }
                            else
                            {
                                Area_ID = oAccessible_Level_List_By_Top_Level.SITE_LIST.FirstOrDefault().AREA_ID;
                            }

                            var get_area_by_area_id = Task.Run(() =>
                            {
                                Area oArea = Get_Area_By_AREA_ID(new Params_Get_Area_By_AREA_ID
                                {
                                    AREA_ID = Area_ID
                                });
                                if (oArea != null)
                                {
                                    oUser_Accessible_Level_List.UPPER_LEVEL = new Upper_Level()
                                    {
                                        LEVEL_ID = oArea.AREA_ID,
                                        NAME = oArea.NAME,
                                        LOCATION = oArea.LOCATION,
                                        LOGO_URL = oArea.LOGO_URL,
                                        IMAGE_URL = oArea.IMAGE_URL,
                                        LONGITUDE = oArea.GLTF_LONGITUDE,
                                        LATITUDE = oArea.GLTF_LATITUDE
                                    };
                                    oUser_Accessible_Level_List.DATA_LEVEL_SETUP_ID = Area_Setup_ID;
                                }
                            });
                            var get_dimension_index_by_where = Task.Run(() =>
                            {
                                List<int?> List_Dimension_ID = oList_Area_Dimension_with_Status.Where(oLevel_Dimension_with_Status => oLevel_Dimension_with_Status.LEVEL_ID_LIST.Contains(Area_ID) && oLevel_Dimension_with_Status.ENUM_DIMENSION_STATUS != Enum_Dimension_Status.HIDDEN)
                                                                                                .Select(oLevel_Dimension_with_Status => oLevel_Dimension_with_Status.DIMENSION.DIMENSION_ID)
                                                                                                .ToList();

                                oList_Dimension_index = Props.Copy_Prop_Values_From_Api_Response<List<Dimension_index>>(
                                   this._service_mesh.Get_Dimension_index_By_Where(new Service_Mesh.Params_Get_Dimension_index_By_Where()
                                   {
                                       LIST_LEVEL_ID = new List<long?>() { Area_ID },
                                       LIST_DIMENSION_ID = List_Dimension_ID,
                                       LEVEL_SETUP_ID = Area_Setup_ID,
                                       START_DATE = (DateTime)i_Params_Get_User_Accessible_Level_List.START_DATE,
                                       END_DATE = (DateTime)i_Params_Get_User_Accessible_Level_List.END_DATE,
                                       ENUM_TIMESPAN = (Service_Mesh.Enum_Timespan)i_Params_Get_User_Accessible_Level_List.ENUM_TIMESPAN
                                   }).i_Result
                                );
                                oUser_Accessible_Level_List.LIST_DIMENSION_INDEX = oList_Dimension_index;
                            });

                            Task.WaitAll(get_area_by_area_id, get_dimension_index_by_where);
                        });

                        Task.WaitAll(get_sites_geojson, get_area_dimension_index);

                        #endregion
                        break;
                    case ("Entity"):
                        #region Get Dimension_index and GeoJson

                        long? Site_ID = 0;
                        if (i_Params_Get_User_Accessible_Level_List.SELECTED_LEVEL_ID != null && oList_Accessible_Level_ID_List_By_Top_Level.FirstOrDefault(oAccessible_Level_ID_List_By_Top_Level => oAccessible_Level_ID_List_By_Top_Level.TOP_LEVEL_ID == Top_Level_ID).ENTITY_ID_LIST.Contains(i_Params_Get_User_Accessible_Level_List.SELECTED_LEVEL_ID))
                        {
                            Site_ID = oAccessible_Level_List_By_Top_Level.ENTITY_LIST.Find(oEntity => oEntity.ENTITY_ID == i_Params_Get_User_Accessible_Level_List.SELECTED_LEVEL_ID).SITE_ID;
                        }
                        else
                        {
                            Site_ID = oAccessible_Level_List_By_Top_Level.ENTITY_LIST.FirstOrDefault().SITE_ID;
                        }

                        var get_site_by_site_id = Task.Run(() =>
                        {
                            Site oSite = Get_Site_By_SITE_ID(new Params_Get_Site_By_SITE_ID
                            {
                                SITE_ID = Site_ID
                            });
                            if (oSite != null)
                            {
                                oUser_Accessible_Level_List.UPPER_LEVEL = new Upper_Level()
                                {
                                    LEVEL_ID = oSite.SITE_ID,
                                    NAME = oSite.NAME,
                                    LOCATION = oSite.LOCATION,
                                    LOGO_URL = oSite.LOGO_URL,
                                    IMAGE_URL = oSite.IMAGE_URL,
                                    LONGITUDE = oSite.GLTF_LONGITUDE,
                                    LATITUDE = oSite.GLTF_LATITUDE
                                };
                                oUser_Accessible_Level_List.DATA_LEVEL_SETUP_ID = Site_Setup_ID;
                            }
                        });
                        var get_dimension_index_by_where = Task.Run(() =>
                        {
                            List<int?> List_Dimension_ID = oList_Site_Dimension_with_Status.Where(oLevel_Dimension_with_Status => oLevel_Dimension_with_Status.LEVEL_ID_LIST.Contains(Site_ID) && oLevel_Dimension_with_Status.ENUM_DIMENSION_STATUS != Enum_Dimension_Status.HIDDEN)
                                                                                                .Select(oLevel_Dimension_with_Status => oLevel_Dimension_with_Status.DIMENSION.DIMENSION_ID)
                                                                                                .ToList();

                            oList_Dimension_index = Props.Copy_Prop_Values_From_Api_Response<List<Dimension_index>>(
                                this._service_mesh.Get_Dimension_index_By_Where(new Service_Mesh.Params_Get_Dimension_index_By_Where()
                                {
                                    LIST_LEVEL_ID = new List<long?>() { Site_ID },
                                    LIST_DIMENSION_ID = List_Dimension_ID,
                                    LEVEL_SETUP_ID = Site_Setup_ID,
                                    START_DATE = (DateTime)i_Params_Get_User_Accessible_Level_List.START_DATE,
                                    END_DATE = (DateTime)i_Params_Get_User_Accessible_Level_List.END_DATE,
                                    ENUM_TIMESPAN = (Service_Mesh.Enum_Timespan)i_Params_Get_User_Accessible_Level_List.ENUM_TIMESPAN
                                }).i_Result
                            );
                            oUser_Accessible_Level_List.LIST_DIMENSION_INDEX = oList_Dimension_index;
                        });
                        var get_site_geojson_by_site_id_list = Task.Run(() =>
                        {
                            List<long?> List_Site_ID_From_Site = new List<long?>();
                            List<long?> List_Site_ID_From_Entity = new List<long?>();
                            if (oAccessible_Level_List_By_Top_Level.SITE_LIST != null && oAccessible_Level_List_By_Top_Level.SITE_LIST.Count > 0)
                            {
                                List_Site_ID_From_Site = oAccessible_Level_List_By_Top_Level.SITE_LIST.Select(oSite => oSite.SITE_ID).ToList();
                            }
                            if (oAccessible_Level_List_By_Top_Level.ENTITY_LIST != null && oAccessible_Level_List_By_Top_Level.ENTITY_LIST.Count > 0)
                            {
                                List_Site_ID_From_Entity = oAccessible_Level_List_By_Top_Level.ENTITY_LIST.Select(oEntity => oEntity.SITE_ID).ToList();
                            }
                            List<long?> List_Site_ID = List_Site_ID_From_Site.Concat(List_Site_ID_From_Entity).ToList();
                            List_Site_ID = List_Site_ID.Distinct().ToList();
                            oUser_Accessible_Level_List.GEOJSON_SRC = this._service_mesh.Get_Site_geojson_By_SITE_ID_List(new Service_Mesh.Params_Get_Site_geojson_By_SITE_ID_List()
                            {
                                SITE_ID_LIST = List_Site_ID
                            }).i_Result;
                        });

                        Task.WaitAll(get_site_by_site_id, get_dimension_index_by_where, get_site_geojson_by_site_id_list);

                        #endregion
                        break;
                }
            });

            #endregion

            #region Separate Intersections From Buildings

            var separate_intersections_from_buildings = Task.Run(() =>
            {
                oUser_Accessible_Level_List.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.INTERSECTION_LIST = oUser_Accessible_Level_List.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.ENTITY_LIST.Where(oEntity => oEntity.ENTITY_TYPE_SETUP_ID != Building_Setup_ID).ToList();
                oUser_Accessible_Level_List.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.ENTITY_LIST = oUser_Accessible_Level_List.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.ENTITY_LIST.Where(oEntity => oEntity.ENTITY_TYPE_SETUP_ID == Building_Setup_ID).ToList();
            });

            #endregion

            Task.WaitAll(separate_intersections_from_buildings, get_geojson_and_dimension_index_and_upper_level, assign_Organization_data_source_kpi_List);

            return oUser_Accessible_Level_List;
        }
        #endregion
        #region Get_User_Accessible_Data_with_Levels
        public User_Accessible_Data_With_Level_List Get_User_Accessible_Data_With_Level_List(Params_Get_User_Accessible_Data_With_Level_List i_Params_Get_User_Accessible_Data_With_Level_List)
        {
            if (i_Params_Get_User_Accessible_Data_With_Level_List.ENUM_TIMESPAN == Enum_Timespan.X_HOURLY_COLLECTION)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }

            User_Accessible_Data_With_Level_List oUser_Accessible_Data_With_Level_List = new User_Accessible_Data_With_Level_List();

            oUser_Accessible_Data_With_Level_List.USER_ACCESSIBLE_DATA = Get_User_Accessible_Data(new Params_Get_User_Accessible_Data()
            {
                CHOSEN_ORGANIZATION_ID = i_Params_Get_User_Accessible_Data_With_Level_List.CHOSEN_ORGANIZATION_ID
            });

            oUser_Accessible_Data_With_Level_List.USER_ACCESSIBLE_LEVEL_LIST = Get_User_Accessible_Level_List(new Params_Get_User_Accessible_Level_List()
            {
                LIST_ORGANIZATION_TOP_LEVEL_ID = oUser_Accessible_Data_With_Level_List.USER_ACCESSIBLE_DATA.LIST_ORGANIZATION_TOP_LEVEL_ID,
                LIST_ORGANIZATION_DISTRICT_ID = oUser_Accessible_Data_With_Level_List.USER_ACCESSIBLE_DATA.LIST_ORGANIZATION_DISTRICT_ID,
                LIST_ORGANIZATION_AREA_ID = oUser_Accessible_Data_With_Level_List.USER_ACCESSIBLE_DATA.LIST_ORGANIZATION_AREA_ID,
                LIST_ORGANIZATION_SITE_ID = oUser_Accessible_Data_With_Level_List.USER_ACCESSIBLE_DATA.LIST_ORGANIZATION_SITE_ID,
                LIST_ORGANIZATION_ENTITY_ID = oUser_Accessible_Data_With_Level_List.USER_ACCESSIBLE_DATA.LIST_ORGANIZATION_ENTITY_ID,
                LIST_USER_TOP_LEVEL_ID = oUser_Accessible_Data_With_Level_List.USER_ACCESSIBLE_DATA.LIST_USER_TOP_LEVEL_ID,
                LIST_USER_DISTRICT_ID = oUser_Accessible_Data_With_Level_List.USER_ACCESSIBLE_DATA.LIST_USER_DISTRICT_ID,
                LIST_USER_AREA_ID = oUser_Accessible_Data_With_Level_List.USER_ACCESSIBLE_DATA.LIST_USER_AREA_ID,
                LIST_USER_SITE_ID = oUser_Accessible_Data_With_Level_List.USER_ACCESSIBLE_DATA.LIST_USER_SITE_ID,
                LIST_USER_ENTITY_ID = oUser_Accessible_Data_With_Level_List.USER_ACCESSIBLE_DATA.LIST_USER_ENTITY_ID,
                DATA_LEVEL_SETUP_ID = i_Params_Get_User_Accessible_Data_With_Level_List.DATA_LEVEL_SETUP_ID,
                TOP_LEVEL_ID = i_Params_Get_User_Accessible_Data_With_Level_List.TOP_LEVEL_ID,
                SELECTED_LEVEL_ID = i_Params_Get_User_Accessible_Data_With_Level_List.SELECTED_LEVEL_ID,
                START_DATE = i_Params_Get_User_Accessible_Data_With_Level_List.START_DATE,
                END_DATE = i_Params_Get_User_Accessible_Data_With_Level_List.END_DATE,
                ENUM_TIMESPAN = i_Params_Get_User_Accessible_Data_With_Level_List.ENUM_TIMESPAN,
            });

            return oUser_Accessible_Data_With_Level_List;
        }
        #endregion
        #region Get_Level_Data
        public Level_Data Get_Level_Data(Params_Get_Level_Data i_Params_Get_Level_Data)
        {
            Level_Data oLevel_Data = new Level_Data();
            if (i_Params_Get_Level_Data.LIST_SELECTED_LEVEL_ID != null && i_Params_Get_Level_Data.LIST_SELECTED_LEVEL_ID.Count > 0 &&
                i_Params_Get_Level_Data.SELECTED_DATA_LEVEL_SETUP_ID != null && i_Params_Get_Level_Data.UPPER_LEVEL_ID != null &&
                i_Params_Get_Level_Data.START_DATE != null && i_Params_Get_Level_Data.END_DATE != null && i_Params_Get_Level_Data.ENUM_TIMESPAN != null)
            {
                if (i_Params_Get_Level_Data.ENUM_TIMESPAN == Enum_Timespan.X_HOURLY_COLLECTION)
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
                }

                #region Declaration & Initialization

                long? Top_Level_Setup_ID = 0;
                long? District_Setup_ID = 0;
                long? Area_Setup_ID = 0;
                long? Site_Setup_ID = 0;
                long? Entity_Setup_ID = 0;
                List<Setup> oList_Data_Level_Setup = new List<Setup>();
                long? Selected_Data_Level_Setup_ID = i_Params_Get_Level_Data.SELECTED_DATA_LEVEL_SETUP_ID;

                #endregion

                #region Get List_Data_Level_Setup_ID

                oList_Data_Level_Setup = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
                {
                    SETUP_CATEGORY_NAME = "Data Level",
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                }).List_Setup;
                if (oList_Data_Level_Setup != null && oList_Data_Level_Setup.Count > 0)
                {
                    Area_Setup_ID = oList_Data_Level_Setup.FirstOrDefault(setup => setup.VALUE == "Area").SETUP_ID;
                    Site_Setup_ID = oList_Data_Level_Setup.FirstOrDefault(setup => setup.VALUE == "Site").SETUP_ID;
                    Entity_Setup_ID = oList_Data_Level_Setup.FirstOrDefault(setup => setup.VALUE == "Entity").SETUP_ID;
                    District_Setup_ID = oList_Data_Level_Setup.FirstOrDefault(setup => setup.VALUE == "District").SETUP_ID;
                    Top_Level_Setup_ID = oList_Data_Level_Setup.FirstOrDefault(setup => setup.VALUE == "Top-Level").SETUP_ID;
                }
                else
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0045).Replace("%1", "Data Level")); // Data Level Setup Not Found
                }

                #endregion

                #region Get Upper_Level

                var get_upper_level = Task.Run(() =>
                {
                    if (Selected_Data_Level_Setup_ID == District_Setup_ID)
                    {
                        District oDistrict = Get_District_By_DISTRICT_ID(new Params_Get_District_By_DISTRICT_ID()
                        {
                            DISTRICT_ID = i_Params_Get_Level_Data.UPPER_LEVEL_ID
                        });
                        if (oDistrict != null)
                        {
                            oLevel_Data.UPPER_LEVEL = new Upper_Level()
                            {
                                NAME = oDistrict.NAME,
                                LOCATION = oDistrict.LOCATION,
                                LOGO_URL = oDistrict.LOGO_URL,
                                IMAGE_URL = oDistrict.IMAGE_URL,
                                LONGITUDE = oDistrict.GLTF_LONGITUDE,
                                LATITUDE = oDistrict.GLTF_LATITUDE
                            };
                        }
                        else
                        {
                            throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "District"));
                            ;
                        }
                    }
                    else if (Selected_Data_Level_Setup_ID == Area_Setup_ID)
                    {
                        District oDistrict = Get_District_By_DISTRICT_ID(new Params_Get_District_By_DISTRICT_ID()
                        {
                            DISTRICT_ID = i_Params_Get_Level_Data.UPPER_LEVEL_ID
                        });
                        if (oDistrict != null)
                        {
                            oLevel_Data.UPPER_LEVEL = new Upper_Level()
                            {
                                NAME = oDistrict.NAME,
                                LOCATION = oDistrict.LOCATION,
                                LOGO_URL = oDistrict.LOGO_URL,
                                IMAGE_URL = oDistrict.IMAGE_URL,
                                LONGITUDE = oDistrict.GLTF_LONGITUDE,
                                LATITUDE = oDistrict.GLTF_LATITUDE
                            };
                        }
                        else
                        {
                            throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "District")); ; // %1 Does not Exist
                        }
                    }
                    else if (Selected_Data_Level_Setup_ID == Site_Setup_ID)
                    {
                        Area oArea = Get_Area_By_AREA_ID(new Params_Get_Area_By_AREA_ID()
                        {
                            AREA_ID = i_Params_Get_Level_Data.UPPER_LEVEL_ID
                        });
                        if (oArea != null)
                        {
                            oLevel_Data.UPPER_LEVEL = new Upper_Level()
                            {
                                NAME = oArea.NAME,
                                LOCATION = oArea.LOCATION,
                                LOGO_URL = oArea.LOGO_URL,
                                IMAGE_URL = oArea.IMAGE_URL,
                                LONGITUDE = oArea.GLTF_LONGITUDE,
                                LATITUDE = oArea.GLTF_LATITUDE
                            };
                        }
                        else
                        {
                            throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Area")); ; // %1 Does not Exist
                        }
                    }
                    else if (Selected_Data_Level_Setup_ID == Entity_Setup_ID)
                    {
                        Site oSite = Get_Site_By_SITE_ID(new Params_Get_Site_By_SITE_ID()
                        {
                            SITE_ID = i_Params_Get_Level_Data.UPPER_LEVEL_ID
                        });
                        if (oSite != null)
                        {
                            oLevel_Data.UPPER_LEVEL = new Upper_Level()
                            {
                                NAME = oSite.NAME,
                                LOCATION = oSite.LOCATION,
                                LOGO_URL = oSite.LOGO_URL,
                                IMAGE_URL = oSite.IMAGE_URL,
                                LONGITUDE = oSite.GLTF_LONGITUDE,
                                LATITUDE = oSite.GLTF_LATITUDE
                            };
                        }
                        else
                        {
                            throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Site")); ; // %1 Does not Exist
                        }
                    }
                });

                #endregion

                #region Get_GeoJson

                var get_geojson = Task.Run(() =>
                {
                    if (Selected_Data_Level_Setup_ID == District_Setup_ID)
                    {
                        oLevel_Data.GEOJSON_SRC = Get_District_geojson_By_DISTRICT_ID_List(new Params_Get_District_geojson_By_DISTRICT_ID_List()
                        {
                            DISTRICT_ID_LIST = i_Params_Get_Level_Data.LIST_SELECTED_LEVEL_ID
                        });
                    }
                    else if (Selected_Data_Level_Setup_ID == Area_Setup_ID)
                    {
                        oLevel_Data.GEOJSON_SRC = Get_Area_geojson_By_AREA_ID_List(new Params_Get_Area_geojson_By_AREA_ID_List()
                        {
                            AREA_ID_LIST = i_Params_Get_Level_Data.LIST_SELECTED_LEVEL_ID
                        });
                    }
                    else if (Selected_Data_Level_Setup_ID == Site_Setup_ID || Selected_Data_Level_Setup_ID == Entity_Setup_ID)
                    {
                        oLevel_Data.GEOJSON_SRC = Get_Site_geojson_By_SITE_ID_List(new Params_Get_Site_geojson_By_SITE_ID_List()
                        {
                            SITE_ID_LIST = i_Params_Get_Level_Data.LIST_SELECTED_LEVEL_ID
                        });
                    }
                });

                #endregion

                #region Get_Dimension_Index

                var get_dimension_index = Task.Run(() =>
                {
                    long? Upper_Data_Level_Setup_ID = 0;
                    if (Selected_Data_Level_Setup_ID == District_Setup_ID || Selected_Data_Level_Setup_ID == Area_Setup_ID)
                    {
                        Upper_Data_Level_Setup_ID = District_Setup_ID;
                    }
                    else if (Selected_Data_Level_Setup_ID == Site_Setup_ID)
                    {
                        Upper_Data_Level_Setup_ID = Area_Setup_ID;
                    }
                    else if (Selected_Data_Level_Setup_ID == Entity_Setup_ID)
                    {
                        Upper_Data_Level_Setup_ID = Site_Setup_ID;
                    }
                    else
                    {
                        throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0045).Replace("%1", "Level")); ; // %1 Setup Not Found
                    }
                    if (i_Params_Get_Level_Data.LIST_DIMENSION_ID != null && i_Params_Get_Level_Data.LIST_DIMENSION_ID.Count > 0)
                    {
                        oLevel_Data.LIST_DIMENSION_INDEX = Get_Dimension_index_By_Where(new Params_Get_Dimension_index_By_Where()
                        {
                            LIST_LEVEL_ID = new List<long?>() { i_Params_Get_Level_Data.UPPER_LEVEL_ID },
                            LIST_DIMENSION_ID = i_Params_Get_Level_Data.LIST_DIMENSION_ID,
                            LEVEL_SETUP_ID = Upper_Data_Level_Setup_ID,
                            START_DATE = i_Params_Get_Level_Data.START_DATE,
                            END_DATE = i_Params_Get_Level_Data.END_DATE,
                            ENUM_TIMESPAN = (Enum_Timespan)i_Params_Get_Level_Data.ENUM_TIMESPAN
                        });
                    }
                    else
                    {
                        oLevel_Data.LIST_DIMENSION_INDEX = new List<Dimension_index>();
                    }

                    oLevel_Data.DATA_LEVEL_SETUP_ID = Upper_Data_Level_Setup_ID;
                });

                #endregion

                Task.WaitAll(get_upper_level, get_geojson, get_dimension_index);
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }

            return oLevel_Data;
        }
        #endregion
        #region Get_Dimension_Index_With_Simple_Upper_Level
        public Dimension_Index_With_Simple_Upper_Level Get_Dimension_Index_With_Simple_Upper_Level(Params_Get_Dimension_Index_With_Simple_Upper_Level i_Params_Get_Dimension_Index_With_Simple_Upper_Level)
        {
            Dimension_Index_With_Simple_Upper_Level oDimension_Index_With_Simple_Upper_Level = new Dimension_Index_With_Simple_Upper_Level();

            if (i_Params_Get_Dimension_Index_With_Simple_Upper_Level.SELECTED_LEVEL_ID != null && i_Params_Get_Dimension_Index_With_Simple_Upper_Level.SELECTED_DATA_LEVEL_SETUP_ID != null &&
                i_Params_Get_Dimension_Index_With_Simple_Upper_Level.START_DATE != null && i_Params_Get_Dimension_Index_With_Simple_Upper_Level.END_DATE != null && i_Params_Get_Dimension_Index_With_Simple_Upper_Level.ENUM_TIMESPAN != null)
            {
                if (i_Params_Get_Dimension_Index_With_Simple_Upper_Level.ENUM_TIMESPAN == Enum_Timespan.X_HOURLY_COLLECTION)
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
                }

                #region Declaration & Initialization

                long? Top_Level_Setup_ID = 0;
                long? District_Setup_ID = 0;
                long? Area_Setup_ID = 0;
                long? Site_Setup_ID = 0;
                long? Entity_Setup_ID = 0;
                List<Setup> oList_Data_Level_Setup = new List<Setup>();

                #endregion

                #region Get List_Data_Level_Setup_ID

                oList_Data_Level_Setup = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
                {
                    SETUP_CATEGORY_NAME = "Data Level",
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                }).List_Setup;
                if (oList_Data_Level_Setup != null && oList_Data_Level_Setup.Count > 0)
                {
                    Area_Setup_ID = oList_Data_Level_Setup.FirstOrDefault(setup => setup.VALUE == "Area").SETUP_ID;
                    Site_Setup_ID = oList_Data_Level_Setup.FirstOrDefault(setup => setup.VALUE == "Site").SETUP_ID;
                    Entity_Setup_ID = oList_Data_Level_Setup.FirstOrDefault(setup => setup.VALUE == "Entity").SETUP_ID;
                    District_Setup_ID = oList_Data_Level_Setup.FirstOrDefault(setup => setup.VALUE == "District").SETUP_ID;
                    Top_Level_Setup_ID = oList_Data_Level_Setup.FirstOrDefault(setup => setup.VALUE == "Top-Level").SETUP_ID;
                }
                else
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0045).Replace("%1", "Data Level")); // Data Level Setup Not Found
                }

                #endregion

                #region Get Father_Upper_Level

                var get_upper_level = Task.Run(() =>
                {
                    if (i_Params_Get_Dimension_Index_With_Simple_Upper_Level.UPPER_LEVEL_ID != null)
                    {
                        if (i_Params_Get_Dimension_Index_With_Simple_Upper_Level.SELECTED_DATA_LEVEL_SETUP_ID == District_Setup_ID)
                        {
                            District oDistrict = Get_District_By_DISTRICT_ID(new Params_Get_District_By_DISTRICT_ID()
                            {
                                DISTRICT_ID = i_Params_Get_Dimension_Index_With_Simple_Upper_Level.UPPER_LEVEL_ID
                            });
                            if (oDistrict != null)
                            {
                                oDimension_Index_With_Simple_Upper_Level.FATHER_UPPER_LEVEL = new Upper_Level()
                                {
                                    LEVEL_ID = oDistrict.DISTRICT_ID,
                                    NAME = oDistrict.NAME,
                                    LOCATION = oDistrict.LOCATION,
                                    LOGO_URL = oDistrict.LOGO_URL,
                                    IMAGE_URL = oDistrict.IMAGE_URL,
                                    LONGITUDE = oDistrict.GLTF_LONGITUDE,
                                    LATITUDE = oDistrict.GLTF_LATITUDE
                                };

                                oDimension_Index_With_Simple_Upper_Level.GRANDFATHER_UPPER_LEVEL = new Upper_Level()
                                {
                                    LEVEL_ID = oDistrict.DISTRICT_ID,
                                    NAME = oDistrict.NAME,
                                    LOCATION = oDistrict.LOCATION,
                                    LOGO_URL = oDistrict.LOGO_URL,
                                    IMAGE_URL = oDistrict.IMAGE_URL,
                                    LONGITUDE = oDistrict.GLTF_LONGITUDE,
                                    LATITUDE = oDistrict.GLTF_LATITUDE
                                };
                            }
                            else
                            {
                                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "District")); ; // %1 Does not Exist
                            }
                        }
                        else if (i_Params_Get_Dimension_Index_With_Simple_Upper_Level.SELECTED_DATA_LEVEL_SETUP_ID == Area_Setup_ID)
                        {
                            District oDistrict = Get_District_By_DISTRICT_ID(new Params_Get_District_By_DISTRICT_ID()
                            {
                                DISTRICT_ID = i_Params_Get_Dimension_Index_With_Simple_Upper_Level.UPPER_LEVEL_ID
                            });
                            if (oDistrict != null)
                            {
                                oDimension_Index_With_Simple_Upper_Level.FATHER_UPPER_LEVEL = new Upper_Level()
                                {
                                    LEVEL_ID = oDistrict.DISTRICT_ID,
                                    NAME = oDistrict.NAME,
                                    LOCATION = oDistrict.LOCATION,
                                    LOGO_URL = oDistrict.LOGO_URL,
                                    IMAGE_URL = oDistrict.IMAGE_URL,
                                    LONGITUDE = oDistrict.GLTF_LONGITUDE,
                                    LATITUDE = oDistrict.GLTF_LATITUDE
                                };

                                oDimension_Index_With_Simple_Upper_Level.GRANDFATHER_UPPER_LEVEL = new Upper_Level()
                                {
                                    LEVEL_ID = oDistrict.DISTRICT_ID,
                                    NAME = oDistrict.NAME,
                                    LOCATION = oDistrict.LOCATION,
                                    LOGO_URL = oDistrict.LOGO_URL,
                                    IMAGE_URL = oDistrict.IMAGE_URL,
                                    LONGITUDE = oDistrict.GLTF_LONGITUDE,
                                    LATITUDE = oDistrict.GLTF_LATITUDE
                                };
                            }
                            else
                            {
                                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "District")); ; // %1 Does not Exist
                            }
                        }
                        else if (i_Params_Get_Dimension_Index_With_Simple_Upper_Level.SELECTED_DATA_LEVEL_SETUP_ID == Site_Setup_ID)
                        {
                            Area oArea = Get_Area_By_AREA_ID(new Params_Get_Area_By_AREA_ID()
                            {
                                AREA_ID = i_Params_Get_Dimension_Index_With_Simple_Upper_Level.UPPER_LEVEL_ID
                            });
                            if (oArea != null)
                            {

                                oDimension_Index_With_Simple_Upper_Level.FATHER_UPPER_LEVEL = new Upper_Level()
                                {
                                    LEVEL_ID = oArea.AREA_ID,
                                    NAME = oArea.NAME,
                                    LOCATION = oArea.LOCATION,
                                    LOGO_URL = oArea.LOGO_URL,
                                    IMAGE_URL = oArea.IMAGE_URL,
                                    LONGITUDE = oArea.GLTF_LONGITUDE,
                                    LATITUDE = oArea.GLTF_LATITUDE
                                };

                                District oDistrict = Get_District_By_DISTRICT_ID(new Params_Get_District_By_DISTRICT_ID()
                                {
                                    DISTRICT_ID = oArea.DISTRICT_ID
                                });

                                if (oDistrict != null)
                                {
                                    oDimension_Index_With_Simple_Upper_Level.GRANDFATHER_UPPER_LEVEL = new Upper_Level()
                                    {
                                        LEVEL_ID = oDistrict.DISTRICT_ID,
                                        NAME = oDistrict.NAME,
                                        LOCATION = oDistrict.LOCATION,
                                        LOGO_URL = oDistrict.LOGO_URL,
                                        IMAGE_URL = oDistrict.IMAGE_URL,
                                        LONGITUDE = oDistrict.GLTF_LONGITUDE,
                                        LATITUDE = oDistrict.GLTF_LATITUDE
                                    };
                                }
                                else
                                {
                                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "District")); ; // %1 Does not Exist
                                }

                            }
                            else
                            {
                                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Area")); ; // %1 Does not Exist
                            }
                        }
                        else if (i_Params_Get_Dimension_Index_With_Simple_Upper_Level.SELECTED_DATA_LEVEL_SETUP_ID == Entity_Setup_ID)
                        {
                            Site oSite = Get_Site_By_SITE_ID(new Params_Get_Site_By_SITE_ID()
                            {
                                SITE_ID = i_Params_Get_Dimension_Index_With_Simple_Upper_Level.UPPER_LEVEL_ID
                            });
                            if (oSite != null)
                            {
                                oDimension_Index_With_Simple_Upper_Level.FATHER_UPPER_LEVEL = new Upper_Level()
                                {
                                    LEVEL_ID = oSite.SITE_ID,
                                    NAME = oSite.NAME,
                                    LOCATION = oSite.LOCATION,
                                    LOGO_URL = oSite.LOGO_URL,
                                    IMAGE_URL = oSite.IMAGE_URL,
                                    LONGITUDE = oSite.GLTF_LONGITUDE,
                                    LATITUDE = oSite.GLTF_LATITUDE
                                };

                                Area oArea = Get_Area_By_AREA_ID(new Params_Get_Area_By_AREA_ID()
                                {
                                    AREA_ID = oSite.AREA_ID
                                });

                                if (oArea != null)
                                {
                                    oDimension_Index_With_Simple_Upper_Level.GRANDFATHER_UPPER_LEVEL = new Upper_Level()
                                    {
                                        LEVEL_ID = oArea.AREA_ID,
                                        NAME = oArea.NAME,
                                        LOCATION = oArea.LOCATION,
                                        LOGO_URL = oArea.LOGO_URL,
                                        IMAGE_URL = oArea.IMAGE_URL,
                                        LONGITUDE = oArea.GLTF_LONGITUDE,
                                        LATITUDE = oArea.GLTF_LATITUDE
                                    };
                                }
                                else
                                {
                                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Area")); ; // %1 Does not Exist
                                }
                            }
                            else
                            {
                                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0046).Replace("%1", "Site")); ; // %1 Does not Exist
                            }
                        }
                    }
                });

                #endregion

                #region Get_Dimension_Index_Upper_Level

                var get_dimension_index_upper_level = Task.Run(() =>
                {
                    oDimension_Index_With_Simple_Upper_Level.LIST_UPPER_LEVEL_DIMENSION_INDEX = new List<Dimension_index>();

                    if (i_Params_Get_Dimension_Index_With_Simple_Upper_Level.LIST_UPPER_DIMENSION_ID != null && i_Params_Get_Dimension_Index_With_Simple_Upper_Level.LIST_UPPER_DIMENSION_ID.Count > 0)
                    {
                        if (i_Params_Get_Dimension_Index_With_Simple_Upper_Level.UPPER_LEVEL_ID != null)
                        {
                            long? Upper_Data_Level_Setup_ID = 0;
                            if (i_Params_Get_Dimension_Index_With_Simple_Upper_Level.SELECTED_DATA_LEVEL_SETUP_ID == District_Setup_ID || i_Params_Get_Dimension_Index_With_Simple_Upper_Level.SELECTED_DATA_LEVEL_SETUP_ID == Area_Setup_ID)
                            {
                                Upper_Data_Level_Setup_ID = District_Setup_ID;
                            }
                            else if (i_Params_Get_Dimension_Index_With_Simple_Upper_Level.SELECTED_DATA_LEVEL_SETUP_ID == Site_Setup_ID)
                            {
                                Upper_Data_Level_Setup_ID = Area_Setup_ID;
                            }
                            else if (i_Params_Get_Dimension_Index_With_Simple_Upper_Level.SELECTED_DATA_LEVEL_SETUP_ID == Entity_Setup_ID)
                            {
                                Upper_Data_Level_Setup_ID = Site_Setup_ID;
                            }

                            oDimension_Index_With_Simple_Upper_Level.LIST_UPPER_LEVEL_DIMENSION_INDEX = Get_Dimension_index_By_Where(new Params_Get_Dimension_index_By_Where()
                            {
                                LIST_LEVEL_ID = new List<long?>() { i_Params_Get_Dimension_Index_With_Simple_Upper_Level.UPPER_LEVEL_ID },
                                LIST_DIMENSION_ID = i_Params_Get_Dimension_Index_With_Simple_Upper_Level.LIST_UPPER_DIMENSION_ID,
                                LEVEL_SETUP_ID = Upper_Data_Level_Setup_ID,
                                START_DATE = i_Params_Get_Dimension_Index_With_Simple_Upper_Level.START_DATE,
                                END_DATE = i_Params_Get_Dimension_Index_With_Simple_Upper_Level.END_DATE,
                                ENUM_TIMESPAN = (Enum_Timespan)i_Params_Get_Dimension_Index_With_Simple_Upper_Level.ENUM_TIMESPAN
                            });
                        }
                    }
                    else
                    {
                        oDimension_Index_With_Simple_Upper_Level.LIST_SELECTED_LEVEL_DIMENSION_INDEX = new List<Dimension_index>();
                    }
                });

                #endregion

                #region Get_Dimension_Index_Selected_Level

                var get_dimension_index_selected_level = Task.Run(() =>
                {
                    oDimension_Index_With_Simple_Upper_Level.LIST_SELECTED_LEVEL_DIMENSION_INDEX = new List<Dimension_index>();

                    if (i_Params_Get_Dimension_Index_With_Simple_Upper_Level.LIST_SELECTED_DIMENSION_ID != null && i_Params_Get_Dimension_Index_With_Simple_Upper_Level.LIST_SELECTED_DIMENSION_ID.Count > 0)
                    {
                        long? Selected_Data_Level_Setup_ID = 0;

                        if (i_Params_Get_Dimension_Index_With_Simple_Upper_Level.SELECTED_DATA_LEVEL_SETUP_ID == District_Setup_ID)
                        {
                            Selected_Data_Level_Setup_ID = District_Setup_ID;
                        }
                        else if (i_Params_Get_Dimension_Index_With_Simple_Upper_Level.SELECTED_DATA_LEVEL_SETUP_ID == Area_Setup_ID)
                        {
                            Selected_Data_Level_Setup_ID = Area_Setup_ID;
                        }
                        else if (i_Params_Get_Dimension_Index_With_Simple_Upper_Level.SELECTED_DATA_LEVEL_SETUP_ID == Site_Setup_ID)
                        {
                            Selected_Data_Level_Setup_ID = Site_Setup_ID;
                        }
                        else if (i_Params_Get_Dimension_Index_With_Simple_Upper_Level.SELECTED_DATA_LEVEL_SETUP_ID == Entity_Setup_ID)
                        {
                            Selected_Data_Level_Setup_ID = Entity_Setup_ID;
                        }
                        else
                        {
                            throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0045).Replace("%1", "Level")); ; // %1 Setup Not Found
                        }

                        oDimension_Index_With_Simple_Upper_Level.LIST_SELECTED_LEVEL_DIMENSION_INDEX = Get_Dimension_index_By_Where(new Params_Get_Dimension_index_By_Where()
                        {
                            LIST_LEVEL_ID = new List<long?>() { i_Params_Get_Dimension_Index_With_Simple_Upper_Level.SELECTED_LEVEL_ID },
                            LIST_DIMENSION_ID = i_Params_Get_Dimension_Index_With_Simple_Upper_Level.LIST_SELECTED_DIMENSION_ID,
                            LEVEL_SETUP_ID = Selected_Data_Level_Setup_ID,
                            START_DATE = i_Params_Get_Dimension_Index_With_Simple_Upper_Level.START_DATE,
                            END_DATE = i_Params_Get_Dimension_Index_With_Simple_Upper_Level.END_DATE,
                            ENUM_TIMESPAN = (Enum_Timespan)i_Params_Get_Dimension_Index_With_Simple_Upper_Level.ENUM_TIMESPAN
                        });
                    }
                    else
                    {
                        oDimension_Index_With_Simple_Upper_Level.LIST_UPPER_LEVEL_DIMENSION_INDEX = new List<Dimension_index>();
                    }
                });


                #endregion

                Task.WaitAll(get_upper_level, get_dimension_index_selected_level, get_dimension_index_upper_level);
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }

            return oDimension_Index_With_Simple_Upper_Level;
        }
        #endregion
        #region Edit_User_Walkthrough
        public void Edit_User_Walkthrough(Params_Edit_User_Walkthrough i_Params_Edit_User_Walkthrough)
        {
            User oUser = Get_User_By_USER_ID(new Params_Get_User_By_USER_ID()
            {
                USER_ID = this.oBLC_Initializer.User_ID
            });
            if (i_Params_Edit_User_Walkthrough.IS_ADMIN_UI)
            {
                oUser.USER_ADMIN_WALKTHROUGH = i_Params_Edit_User_Walkthrough.USER_WALKTHROUGH;
            }
            else
            {
                oUser.USER_DISTRICTNEX_WALKTHROUGH = i_Params_Edit_User_Walkthrough.USER_WALKTHROUGH;
            }
            Edit_User(oUser);
        }
        #endregion
        #region Check_User_Deletion_Status
        public void Check_User_Deletion_Status()
        {
            Params_Edit_User_List oParams_Edit_User_List = new Params_Edit_User_List()
            {
                List_To_Edit = new List<User>()
            };

            oParams_Edit_User_List.List_To_Edit = Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED(new Params_Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED()
            {
                OWNER_ID = this.oBLC_Initializer.Owner_ID,
                IS_ACTIVE = false,
                IS_DELETED = false,
            }).Where(user => DateTime.Parse(user.DATE_DELETED).AddDays(user.DATA_RETENTION_PERIOD.Value) <= DateTime.Now)
            .Select(user =>
            {
                user.IS_DELETED = true;
                user.EMAIL = Tools.Generate_Random_String(6) + "_del_" + user.EMAIL;
                user.USERNAME = Tools.Generate_Random_String(6) + "_del_" + user.USERNAME;
                return user;
            }).ToList();

            if (oParams_Edit_User_List.List_To_Edit != null && oParams_Edit_User_List.List_To_Edit.Count > 0)
            {
                List<User_level_access> oList_User_level_access = Get_User_level_access_By_USER_ID_List(new Params_Get_User_level_access_By_USER_ID_List()
                {
                    USER_ID_LIST = oParams_Edit_User_List.List_To_Edit.Select(user => user.USER_ID)
                });

                Edit_User_level_access_List(new Params_Edit_User_level_access_List()
                {
                    List_To_Delete = oList_User_level_access.Select(User_level_access => User_level_access.USER_LEVEL_ACCESS_ID)
                });

                Edit_User_List(oParams_Edit_User_List);

                Task.Run(() =>
                {
                    Setup_category oLog_Type_Setup_category = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
                    {
                        SETUP_CATEGORY_NAME = "Log Type"
                    });
                    Setup_category oAccess_Type_Setup_category = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
                    {
                        SETUP_CATEGORY_NAME = "Access Type"
                    });
                    oParams_Edit_User_List.List_To_Edit.ForEach(user =>
                    {
                        this._service_mesh.Create_Log(new Service_Mesh.Params_Create_Log()
                        {
                            USER_ID = user.USER_ID,
                            MESSAGE = $"{user.FIRST_NAME} {user.LAST_NAME} Has Been Deleted Permanently",
                            ACCESS_TYPE_SETUP_ID = oAccess_Type_Setup_category.List_Setup.First(setup => setup.VALUE == "Change").SETUP_ID,
                            LOG_TYPE_SETUP_ID = oLog_Type_Setup_category.List_Setup.First(setup => setup.VALUE == "User Activation-Deactivation").SETUP_ID,
                        });
                    });
                });

                if (oParams_Edit_User_List.List_Failed_Edit != null && oParams_Edit_User_List.List_Failed_Edit.Count > 0)
                {
                    Send_Support_Email(new Params_Send_Support_Email()
                    {
                        TITLE = "User Deletion Failed",
                        MESSAGE = "The Cron task failed to delete one or more users"
                    });
                }
            }
        }
        #endregion
        #region Send_Support_Email
        public void Send_Support_Email(Params_Send_Support_Email i_Params_Send_Support_Email)
        {
            #region Get SMTP Credentials
            string smtp_email = "";
            string smtp_password = "";
            var get_smtp_email = Task.Run(() =>
            {
                smtp_email = this._service_mesh.Get_Secret(new Service_Mesh.Params_Get_Secret()
                {
                    Secret_Id = ConfigurationManager.AppSettings["SUPPORT_SMTP_EMAIL"]
                }).i_Result;
            });
            var get_smtp_password = Task.Run(() =>
            {
                smtp_password = this._service_mesh.Get_Secret(new Service_Mesh.Params_Get_Secret()
                {
                    Secret_Id = ConfigurationManager.AppSettings["SUPPORT_SMTP_PASSWORD"]
                }).i_Result;
            });
            Task.WaitAll(get_smtp_email, get_smtp_password);
            #endregion
            using (SmtpClient client = new SmtpClient()
            {
                Port = 587,
                EnableSsl = true, // Set to avoid secure connection exception
                Host = "smtp.office365.com",
                UseDefaultCredentials = false, // This is required before setting the credentials property
                TargetName = "STARTTLS/smtp.office365.com", // Set to avoid MustIssueStartTlsFirst exception
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential(smtp_email, smtp_password)
            })
            {
                MailMessage message = new MailMessage()
                {
                    IsBodyHtml = true,
                    From = new MailAddress(smtp_email),
                    BodyEncoding = System.Text.Encoding.UTF8,
                    SubjectEncoding = System.Text.Encoding.UTF8,
                    Subject = i_Params_Send_Support_Email.TITLE,
                    Body = "<p>" + i_Params_Send_Support_Email.MESSAGE + "</p>",

                };
                message.Priority = MailPriority.High;
                message.To.Add("rodolphkhlat@outlook.com");
                try
                {
                    client.Send(message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        #endregion
        #region Get_Entity_Intersection_List
        public List<Entity> Get_Entity_Intersection_List(Params_Get_Entity_Intersection_List i_Params_Get_Entity_Intersection_List)
        {
            List<Entity> oList_Entity = new List<Entity>();

            if (i_Params_Get_Entity_Intersection_List.ORGANIZATION_ID != null)
            {
                #region Declaration & Initialization

                long? Entity_Setup_ID = 0;
                long? Intersection_Setup_ID = 0;
                User oUser = new User();

                #endregion

                #region Get Entity Setup ID

                var get_data_level_setup_list = Task.Run(() =>
                {
                    List<Setup> oList_Data_Level_Setup = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
                    {
                        SETUP_CATEGORY_NAME = "Data Level",
                        OWNER_ID = this.oBLC_Initializer.Owner_ID
                    }).List_Setup;
                    if (oList_Data_Level_Setup != null && oList_Data_Level_Setup.Count > 0)
                    {
                        Entity_Setup_ID = oList_Data_Level_Setup.FirstOrDefault(setup => setup.VALUE == "Entity").SETUP_ID;
                    }
                    else
                    {
                        throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0045).Replace("%1", "Data Level")); // Data Level Setup Not Found
                    }
                });

                #endregion

                #region Get Entity Type Setup ID

                var get_entity_type_setup_id = Task.Run(() =>
                {
                    List<Setup> oList_Entity_Type_Setup = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
                    {
                        SETUP_CATEGORY_NAME = "Entity Type",
                        OWNER_ID = this.oBLC_Initializer.Owner_ID
                    }).List_Setup;
                    if (oList_Entity_Type_Setup != null && oList_Entity_Type_Setup.Count > 0)
                    {
                        Intersection_Setup_ID = oList_Entity_Type_Setup.FirstOrDefault(setup => setup.VALUE == "Intersection").SETUP_ID;
                    }
                    else
                    {
                        throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0045).Replace("%1", "Entity Type")); // Data Level Setup Not Found
                    }
                });

                #endregion

                #region Get User

                var get_user = Task.Run(() =>
                {
                    oUser = Get_User_By_USER_ID_Adv(new Params_Get_User_By_USER_ID()
                    {
                        USER_ID = this.oBLC_Initializer.User_ID
                    });

                    if (oUser == null)
                    {
                        throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0005)); // User Not Found
                    }
                });

                #endregion

                Task.WaitAll(get_data_level_setup_list, get_user, get_entity_type_setup_id);

                if (oUser.User_type_setup.VALUE == "Organization User")
                {
                    #region Get Intersection Entity List For User

                    List<User_level_access> oList_User_level_access = Get_User_level_access_By_USER_ID(new Params_Get_User_level_access_By_USER_ID()
                    {
                        USER_ID = oUser.USER_ID
                    });

                    if (oList_User_level_access != null && oList_User_level_access.Count > 0)
                    {
                        oList_User_level_access.RemoveAll(oUser_level_access => oUser_level_access.DATA_LEVEL_SETUP_ID != Entity_Setup_ID);

                        if (oList_User_level_access != null && oList_User_level_access.Count > 0)
                        {
                            oList_Entity = Get_Entity_By_ENTITY_ID_List(new Params_Get_Entity_By_ENTITY_ID_List()
                            {
                                ENTITY_ID_LIST = oList_User_level_access.Select(oUser_level_access => oUser_level_access.LEVEL_ID).ToList()
                            });

                            if (oList_Entity != null && oList_Entity.Count > 0)
                            {
                                oList_Entity.RemoveAll(oEntity => oEntity.ENTITY_TYPE_SETUP_ID != Intersection_Setup_ID);
                            }
                        }
                    }

                    #endregion
                }
                else
                {
                    #region Get Intersection Entity List For Organization

                    List<Organization_level_access> oList_Organization_level_access = Props.Copy_Prop_Values_From_Api_Response<List<Organization_level_access>>(this._service_mesh.Get_Organization_level_access_By_ORGANIZATION_ID(new Service_Mesh.Params_Get_Organization_level_access_By_ORGANIZATION_ID()
                    {
                        ORGANIZATION_ID = i_Params_Get_Entity_Intersection_List.ORGANIZATION_ID
                    }).i_Result);

                    if (oList_Organization_level_access != null && oList_Organization_level_access.Count > 0)
                    {
                        oList_Organization_level_access.RemoveAll(oOrganization_level_access => oOrganization_level_access.DATA_LEVEL_SETUP_ID != Entity_Setup_ID);

                        if (oList_Organization_level_access != null && oList_Organization_level_access.Count > 0)
                        {
                            oList_Entity = Get_Entity_By_ENTITY_ID_List(new Params_Get_Entity_By_ENTITY_ID_List()
                            {
                                ENTITY_ID_LIST = oList_Organization_level_access.Select(oOrganization_level_access => oOrganization_level_access.LEVEL_ID).ToList()
                            });

                            if (oList_Entity != null && oList_Entity.Count > 0)
                            {
                                oList_Entity.RemoveAll(oEntity => oEntity.ENTITY_TYPE_SETUP_ID != Intersection_Setup_ID);
                            }
                        }
                    }

                    #endregion
                }
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }

            return oList_Entity;
        }
        #endregion
        #region Get_Initial_Data
        public Initial_Data Get_Initial_Data(Params_Get_Initial_Data i_Params_Get_Initial_Data)
        {
            Initial_Data oInitial_Data = new Initial_Data();

            User oUser = Get_User_By_USER_ID_Adv(new Params_Get_User_By_USER_ID()
            {
                USER_ID = this.oBLC_Initializer.User_ID
            });

            oUser.Organization.Organization_type_setup = Get_Setup_By_SETUP_ID(new Params_Get_Setup_By_SETUP_ID()
            {
                SETUP_ID = oUser.Organization.ORGANIZATION_TYPE_SETUP_ID,
            });

            var get_dimension_chart_configuration = Task.Run(() =>
            {
                oInitial_Data.LIST_DIMENSION_CHART_CONFIGURATION = Props.Copy_Prop_Values_From_Api_Response<List<Dimension_chart_configuration>>(this._service_mesh.Get_Dimension_chart_configuration().i_Result);
            });

            var get_kpi_chart_configuration = Task.Run(() =>
            {
                oInitial_Data.LIST_KPI_CHART_CONFIGURATION = Props.Copy_Prop_Values_From_Api_Response<List<Kpi_chart_configuration>>(this._service_mesh.Get_Kpi_chart_configuration().i_Result);
            });

            var get_specialized_chart_configuration = Task.Run(() =>
            {
                oInitial_Data.LIST_SPECIALIZED_CHART_CONFIGURATION = Props.Copy_Prop_Values_From_Api_Response<List<Specialized_chart_configuration>>(this._service_mesh.Get_Specialized_chart_configuration().i_Result);
            });

            var get_setup_category = Task.Run(() =>
            {
                oInitial_Data.LIST_SETUP_CATEGORY = Get_Setup_category_By_OWNER_ID(new Params_Get_Setup_category_By_OWNER_ID()
                {
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                });
                if (oInitial_Data.LIST_SETUP_CATEGORY != null && oInitial_Data.LIST_SETUP_CATEGORY.Count > 0)
                {
                    foreach (Setup_category oSetup_category in oInitial_Data.LIST_SETUP_CATEGORY)
                    {
                        if (oSetup_category.List_Setup != null && oSetup_category.List_Setup.Count > 0)
                        {
                            oSetup_category.List_Setup = oSetup_category.List_Setup.OrderBy(setup => setup.DISPLAY_ORDER).ToList();
                        }
                    }
                }
            });

            var get_user_districtnex_module = Task.Run(() =>
            {
                if (oUser.User_type_setup.VALUE != "Organization User")
                {
                    oInitial_Data.LIST_USER_DISTRICT_NEX_MODULE = this._service_mesh.Get_Organization_districtnex_module_By_ORGANIZATION_ID_Adv(new Service_Mesh.Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID()
                    {
                        ORGANIZATION_ID = i_Params_Get_Initial_Data.ORGANIZATION_ID,
                    }).i_Result?.Select(oOrganization_districtnex_module => new User_districtnex_module()
                    {
                        DISTRICTNEX_MODULE_ID = oOrganization_districtnex_module.DISTRICTNEX_MODULE_ID,
                        Districtnex_module = Props.Copy_Prop_Values_From_Api_Response<Districtnex_module>(oOrganization_districtnex_module.Districtnex_module),
                    }).ToList();
                }
                else
                {
                    oInitial_Data.LIST_USER_DISTRICT_NEX_MODULE = Get_User_districtnex_module_By_USER_ID_Adv(new Params_Get_User_districtnex_module_By_USER_ID()
                    {
                        USER_ID = i_Params_Get_Initial_Data.USER_ID
                    });
                }
            });

            var get_organization_color_scheme = Task.Run(() =>
            {
                oInitial_Data.LIST_ORGANIZATION_COLOR_SCHEME = Props.Copy_Prop_Values_From_Api_Response<List<Organization_color_scheme>>(this._service_mesh.Get_Organization_color_scheme_By_ORGANIZATION_ID(new Service_Mesh.Params_Get_Organization_color_scheme_By_ORGANIZATION_ID()
                {
                    ORGANIZATION_ID = i_Params_Get_Initial_Data.ORGANIZATION_ID
                }).i_Result);
            });

            var get_niche_categories = Task.Run(() =>
            {
                oInitial_Data.LIST_NICHE_CATEGORIES = Props.Copy_Prop_Values_From_Api_Response<List<Niche_categories>>(this._service_mesh.Get_Niche_categories_By_Where(new Service_Mesh.Params_Get_Niche_categories_By_Where()).i_Result);
            });

            var get_organization_data = Task.Run(() =>
            {
                oInitial_Data.LIST_ORGANIZATION_DATA_WITH_ACCESSIBLE_TOP_LEVEL_DATA = Get_List_Organization_with_Accessible_Top_Levels(new Params_Get_List_Organization_with_Accessible_Top_Levels()
                {
                    USER = oUser
                });
            });

            var get_user_theme = Task.Run(() =>
            {
                oInitial_Data.USER_THEME = Props.Copy_Prop_Values_From_Api_Response<User_theme>(this._service_mesh.Get_User_theme_By_USER_ID(new Service_Mesh.Params_Get_User_theme_By_USER_ID()
                {
                    USER_ID = i_Params_Get_Initial_Data.USER_ID
                }).i_Result.FirstOrDefault());
            });

            Task.WaitAll(get_dimension_chart_configuration, get_kpi_chart_configuration, get_specialized_chart_configuration, get_setup_category, get_user_districtnex_module, get_organization_color_scheme, get_niche_categories, get_organization_data);

            return oInitial_Data;
        }
        #endregion
        #region Get_List_Organization_with_Accessible_Top_Levels
        public List<Organization_Data_with_Accessible_Top_Level_Data> Get_List_Organization_with_Accessible_Top_Levels(Params_Get_List_Organization_with_Accessible_Top_Levels i_Params_Get_List_Organization_with_Accessible_Top_Levels)
        {
            List<Organization_Data_with_Accessible_Top_Level_Data> oList_Organization_Data_with_Accessible_Top_Level_Data = null;

            #region Get Setup_Top_Level
            Setup oSetup_Top_Level = new Setup();
            oSetup_Top_Level = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
            {
                OWNER_ID = oBLC_Initializer.Owner_ID,
                SETUP_CATEGORY_NAME = "Data Level",
            }).List_Setup.Find(setup => setup.VALUE == "Top-Level");
            #endregion

            if (i_Params_Get_List_Organization_with_Accessible_Top_Levels.USER.User_type_setup.VALUE == "Super Admin")
            {
                #region Get List_Organization_relation
                oList_Organization_Data_with_Accessible_Top_Level_Data = new List<Organization_Data_with_Accessible_Top_Level_Data>();

                List<Organization_relation> oList_Organization_relation = Get_Organization_relation_By_PARENT_ORGANIZATION_ID(new Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID()
                {
                    PARENT_ORGANIZATION_ID = i_Params_Get_List_Organization_with_Accessible_Top_Levels.USER.ORGANIZATION_ID
                });
                #endregion

                #region Get and Fill List_Child_Organization

                #region Declaration & Initialization

                List<int?> List_Child_Organization_ID = new List<int?>();
                List<Organization> oList_Organization = new List<Organization>();
                List<Organization_level_access> oList_Organization_level_access = new List<Organization_level_access>();

                #endregion

                List_Child_Organization_ID = oList_Organization_relation.Select(child_organization => child_organization.CHILD_ORGANIZATION_ID).ToList();
                if (i_Params_Get_List_Organization_with_Accessible_Top_Levels.USER.Organization.Organization_type_setup.VALUE != "Super Organization")
                {
                    List_Child_Organization_ID.Add(i_Params_Get_List_Organization_with_Accessible_Top_Levels.USER.ORGANIZATION_ID);
                }

                var get_organization_color_scheme = Task.Run(() =>
                {
                    oList_Organization = Props.Copy_Prop_Values_From_Api_Response<List<Organization>>(
                    this._service_mesh.Get_Organization_By_ORGANIZATION_ID_List(new Service_Mesh.Params_Get_Organization_By_ORGANIZATION_ID_List
                    {
                        ORGANIZATION_ID_LIST = List_Child_Organization_ID
                    }).i_Result);
                });

                var get_organization_level_access = Task.Run(() =>
                {
                    oList_Organization_level_access = Props.Copy_Prop_Values_From_Api_Response<List<Organization_level_access>>(
                    this._service_mesh.Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID(new Service_Mesh.Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID
                    {
                        DATA_LEVEL_SETUP_ID = oSetup_Top_Level.SETUP_ID
                    }).i_Result);
                    oList_Organization_level_access = oList_Organization_level_access.Where(organization_level_access => List_Child_Organization_ID.Contains(organization_level_access.ORGANIZATION_ID)).ToList();
                });

                Task.WaitAll(get_organization_color_scheme, get_organization_level_access);

                oList_Organization_level_access.ForEach(oOrganization_level_access =>
                {
                    oOrganization_level_access.Organization = new Organization();
                    oOrganization_level_access.Organization = oList_Organization.Find(oOrganization => oOrganization.ORGANIZATION_ID == oOrganization_level_access.ORGANIZATION_ID);
                });

                List<Organization_Data> oList_Child_Organization_Data = oList_Organization_level_access.Select(organization_level_access => new Organization_Data()
                {
                    ORGANIZATION_ID = organization_level_access.Organization.ORGANIZATION_ID,
                    ORGANIZATION_NAME = organization_level_access.Organization.ORGANIZATION_NAME,
                    DARK_RECTANGLE_LOGO_URL = organization_level_access.Organization.DARK_RECTANGLE_LOGO_URL,
                    DARK_SQUARE_LOGO_URL = organization_level_access.Organization.DARK_SQUARE_LOGO_URL,
                    LIGHT_RECTANGLE_LOGO_URL = organization_level_access.Organization.LIGHT_RECTANGLE_LOGO_URL,
                    LIGHT_SQUARE_LOGO_URL = organization_level_access.Organization.LIGHT_SQUARE_LOGO_URL,
                    ORGANIZATION_FAVICON_URL = organization_level_access.Organization.ORGANIZATION_FAVICON_URL,
                    LIST_ORGANIZATION_COLOR_SCHEME = organization_level_access.Organization.List_Organization_color_scheme,
                    LIST_ORGANIZATION_THEME = organization_level_access.Organization.List_Organization_theme
                }).DistinctBy(organization_level_access => organization_level_access.ORGANIZATION_ID).ToList();

                #endregion

                #region Get List_Top_level
                List<Top_level> oList_Top_level = Props.Copy_Prop_Values_From_Api_Response<List<Top_level>>(
                    this._service_mesh.Get_Top_level_By_TOP_LEVEL_ID_List(new Service_Mesh.Params_Get_Top_level_By_TOP_LEVEL_ID_List()
                    {
                        TOP_LEVEL_ID_LIST = oList_Organization_level_access.Select(organization_level_access => organization_level_access.LEVEL_ID).Distinct().ToList()
                    }).i_Result
                );
                #endregion

                #region Fill List_Organization_with_Accessible_Top_Levels
                foreach (Organization_Data organization_data in oList_Child_Organization_Data)
                {
                    List<long?> list_organization_top_level_ID = oList_Organization_level_access.Where(organization_level_access => organization_level_access.ORGANIZATION_ID == organization_data.ORGANIZATION_ID)
                                                                                                .Select(organization_level_access => organization_level_access.LEVEL_ID)
                                                                                                .ToList();
                    List<Top_Level_Data> List_Organization_Top_Level_Data = oList_Top_level.Where(top_level => list_organization_top_level_ID.Contains(top_level.TOP_LEVEL_ID))
                                                                                            .Select(top_level => new Top_Level_Data()
                                                                                            {
                                                                                                TOP_LEVEL_ID = top_level.TOP_LEVEL_ID,
                                                                                                TOP_LEVEL_NAME = top_level.NAME,
                                                                                                IMAGE_URL = top_level.IMAGE_URL,
                                                                                                LOGO_URL = top_level.LOGO_URL
                                                                                            })
                                                                                            .ToList();
                    Organization_Data_with_Accessible_Top_Level_Data oOrganization_Data_with_Accessible_Top_Level_Data = new Organization_Data_with_Accessible_Top_Level_Data()
                    {
                        ORGANIZATION_DATA = organization_data,
                        LIST_TOP_LEVEL_DATA = List_Organization_Top_Level_Data
                    };
                    oList_Organization_Data_with_Accessible_Top_Level_Data.Add(oOrganization_Data_with_Accessible_Top_Level_Data);
                }
                #endregion
            }
            else
            {
                #region Get Organization

                oList_Organization_Data_with_Accessible_Top_Level_Data = new List<Organization_Data_with_Accessible_Top_Level_Data>();

                Organization oOrganization = Props.Copy_Prop_Values_From_Api_Response<Organization>(this._service_mesh.Get_Organization_By_ORGANIZATION_ID(new Service_Mesh.Params_Get_Organization_By_ORGANIZATION_ID()
                {
                    ORGANIZATION_ID = i_Params_Get_List_Organization_with_Accessible_Top_Levels.USER.ORGANIZATION_ID
                }).i_Result);

                #endregion

                if (oOrganization != null)
                {
                    #region Get and Fill Organization_Data

                    #region Declaration & Initialization

                    oOrganization.List_Organization_color_scheme = new List<Organization_color_scheme>();
                    List<Organization_level_access> oList_Organization_level_access = new List<Organization_level_access>();

                    #endregion

                    var get_organization_color_scheme = Task.Run(() =>
                    {
                        oOrganization.List_Organization_color_scheme = Props.Copy_Prop_Values_From_Api_Response<List<Organization_color_scheme>>(this._service_mesh.Get_Organization_color_scheme_By_ORGANIZATION_ID(new Service_Mesh.Params_Get_Organization_color_scheme_By_ORGANIZATION_ID()
                        {
                            ORGANIZATION_ID = oOrganization.ORGANIZATION_ID
                        }).i_Result);
                    });

                    var get_organization_level_access = Task.Run(() =>
                    {
                        oList_Organization_level_access = Props.Copy_Prop_Values_From_Api_Response<List<Organization_level_access>>(
                        this._service_mesh.Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_Adv(new Service_Mesh.Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID
                        {
                            DATA_LEVEL_SETUP_ID = oSetup_Top_Level.SETUP_ID
                        }).i_Result);

                        oList_Organization_level_access = oList_Organization_level_access.Where(organization_level_access => organization_level_access.ORGANIZATION_ID == oOrganization.ORGANIZATION_ID).ToList();

                        if (oList_Organization_level_access.Count == 0)
                        {
                            throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0022)); // You do not have access to this content.
                        }
                    });

                    Task.WaitAll(get_organization_color_scheme, get_organization_level_access);

                    List<Organization_Data> oList_Organization_Data = new List<Organization_Data>
                    {
                        new Organization_Data()
                        {
                            ORGANIZATION_ID = oOrganization.ORGANIZATION_ID,
                            ORGANIZATION_NAME = oOrganization.ORGANIZATION_NAME,
                            DARK_RECTANGLE_LOGO_URL = oOrganization.DARK_RECTANGLE_LOGO_URL,
                            DARK_SQUARE_LOGO_URL = oOrganization.DARK_SQUARE_LOGO_URL,
                            LIGHT_RECTANGLE_LOGO_URL = oOrganization.LIGHT_RECTANGLE_LOGO_URL,
                            LIGHT_SQUARE_LOGO_URL = oOrganization.LIGHT_SQUARE_LOGO_URL,
                            ORGANIZATION_FAVICON_URL = oOrganization.ORGANIZATION_FAVICON_URL,
                            LIST_ORGANIZATION_COLOR_SCHEME = oOrganization.List_Organization_color_scheme,
                            LIST_ORGANIZATION_THEME = oOrganization.List_Organization_theme
                        }
                    };

                    #endregion

                    #region Get List_Top_level
                    List<Top_level> oList_Top_level = Props.Copy_Prop_Values_From_Api_Response<List<Top_level>>(
                        this._service_mesh.Get_Top_level_By_TOP_LEVEL_ID_List(new Service_Mesh.Params_Get_Top_level_By_TOP_LEVEL_ID_List()
                        {
                            TOP_LEVEL_ID_LIST = oList_Organization_level_access.Select(organization_level_access => organization_level_access.LEVEL_ID).Distinct().ToList()
                        }).i_Result
                    );
                    #endregion

                    #region Fill List_Organization_with_Accessible_Top_Levels
                    foreach (Organization_Data organization_data in oList_Organization_Data)
                    {
                        List<long?> list_organization_top_level_ID = oList_Organization_level_access.Where(organization_level_access => organization_level_access.ORGANIZATION_ID == organization_data.ORGANIZATION_ID)
                                                                                                    .Select(organization_level_access => organization_level_access.LEVEL_ID)
                                                                                                    .ToList();
                        List<Top_Level_Data> List_Organization_Top_Level_Data = oList_Top_level.Where(top_level => list_organization_top_level_ID.Contains(top_level.TOP_LEVEL_ID))
                                                                                                .Select(top_level => new Top_Level_Data()
                                                                                                {
                                                                                                    TOP_LEVEL_ID = top_level.TOP_LEVEL_ID,
                                                                                                    TOP_LEVEL_NAME = top_level.NAME,
                                                                                                    IMAGE_URL = top_level.IMAGE_URL,
                                                                                                    LOGO_URL = top_level.LOGO_URL
                                                                                                })
                                                                                                .ToList();
                        Organization_Data_with_Accessible_Top_Level_Data oOrganization_Data_with_Accessible_Top_Level_Data = new Organization_Data_with_Accessible_Top_Level_Data()
                        {
                            ORGANIZATION_DATA = organization_data,
                            LIST_TOP_LEVEL_DATA = List_Organization_Top_Level_Data
                        };
                        oList_Organization_Data_with_Accessible_Top_Level_Data.Add(oOrganization_Data_with_Accessible_Top_Level_Data);
                    }
                    #endregion
                }
            }

            return oList_Organization_Data_with_Accessible_Top_Level_Data;
        }

        #endregion
        #region Dimension Management
        #region Get_Dimension_index_By_Where
        public List<Dimension_index> Get_Dimension_index_By_Where(Params_Get_Dimension_index_By_Where i_Params_Get_Dimension_index_By_Where)
        {
            if (i_Params_Get_Dimension_index_By_Where.ENUM_TIMESPAN == Enum_Timespan.X_HOURLY_COLLECTION)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }

            List<Dimension_index> oList_Dimension_index = null;

            List<DALC.Dimension_index> oList_DBEntry = _MongoDb.Get_Dimension_index_By_Where(
                    START_DATE: i_Params_Get_Dimension_index_By_Where.START_DATE,
                    END_DATE: i_Params_Get_Dimension_index_By_Where.END_DATE,
                    LIST_DIMENSION_ID: i_Params_Get_Dimension_index_By_Where.LIST_DIMENSION_ID,
                    LIST_LEVEL_ID: i_Params_Get_Dimension_index_By_Where.LIST_LEVEL_ID,
                    LEVEL_SETUP_ID: i_Params_Get_Dimension_index_By_Where.LEVEL_SETUP_ID,
                    ENUM_TIMESPAN: (DALC.Enum_Timespan)i_Params_Get_Dimension_index_By_Where.ENUM_TIMESPAN
                );
            if (oList_DBEntry != null)
            {
                oList_Dimension_index = new List<Dimension_index>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Dimension_index oDimension_index = new Dimension_index();
                        Dimension_metadata oDimension_metadata = new Dimension_metadata();
                        Props.Copy_Prop_Values(oDBEntry, oDimension_index);
                        Props.Copy_Prop_Values(oDBEntry.DIMENSION_METADATA, oDimension_metadata);
                        oDimension_index.DIMENSION_METADATA = oDimension_metadata;
                        oList_Dimension_index.Add(oDimension_index);
                    }
                }
            }
            return oList_Dimension_index;
        }
        #endregion
        #endregion
        #region GeoJson

        #region Get_District_geojson_By_DISTRICT_ID_List
        public string Get_District_geojson_By_DISTRICT_ID_List(Params_Get_District_geojson_By_DISTRICT_ID_List i_Params_Get_District_geojson_By_DISTRICT_ID_List)
        {
            string GEOJSON_SRC = "";

            if (i_Params_Get_District_geojson_By_DISTRICT_ID_List != null && i_Params_Get_District_geojson_By_DISTRICT_ID_List.DISTRICT_ID_LIST != null && i_Params_Get_District_geojson_By_DISTRICT_ID_List.DISTRICT_ID_LIST.Count() > 0)
            {
                List<BsonDocument> oList_BsonDocument = _MongoDb.Get_District_geojson_By_DISTRICT_ID_List(i_Params_Get_District_geojson_By_DISTRICT_ID_List.DISTRICT_ID_LIST);
                if (oList_BsonDocument != null && oList_BsonDocument.Count > 0)
                {
                    GEOJSON_SRC = string.Join(",", oList_BsonDocument);
                }
                GEOJSON_SRC = "{\"type\": \"FeatureCollection\",\"features\": [" + GEOJSON_SRC + "]}";
            }

            return GEOJSON_SRC;
        }
        #endregion
        #region Get_Area_geojson_By_AREA_ID_List
        public string Get_Area_geojson_By_AREA_ID_List(Params_Get_Area_geojson_By_AREA_ID_List i_Params_Get_Area_geojson_By_AREA_ID_List)
        {
            string GEOJSON_SRC = "";

            if (i_Params_Get_Area_geojson_By_AREA_ID_List != null && i_Params_Get_Area_geojson_By_AREA_ID_List.AREA_ID_LIST != null && i_Params_Get_Area_geojson_By_AREA_ID_List.AREA_ID_LIST.Count() > 0)
            {
                List<BsonDocument> oList_BsonDocument = _MongoDb.Get_Area_geojson_By_AREA_ID_List(i_Params_Get_Area_geojson_By_AREA_ID_List.AREA_ID_LIST);
                if (oList_BsonDocument != null && oList_BsonDocument.Count > 0)
                {
                    GEOJSON_SRC = string.Join(",", oList_BsonDocument);
                }
                GEOJSON_SRC = "{\"type\": \"FeatureCollection\",\"features\": [" + GEOJSON_SRC + "]}";
            }

            return GEOJSON_SRC;
        }
        #endregion
        #region Get_Site_geojson_By_SITE_ID_List
        public string Get_Site_geojson_By_SITE_ID_List(Params_Get_Site_geojson_By_SITE_ID_List i_Params_Get_Site_geojson_By_SITE_ID_List)
        {
            string GEOJSON_SRC = "";

            if (i_Params_Get_Site_geojson_By_SITE_ID_List != null && i_Params_Get_Site_geojson_By_SITE_ID_List.SITE_ID_LIST != null && i_Params_Get_Site_geojson_By_SITE_ID_List.SITE_ID_LIST.Count() > 0)
            {
                List<BsonDocument> oList_BsonDocument = _MongoDb.Get_Site_geojson_By_SITE_ID_List(i_Params_Get_Site_geojson_By_SITE_ID_List.SITE_ID_LIST);
                if (oList_BsonDocument != null && oList_BsonDocument.Count > 0)
                {
                    GEOJSON_SRC = string.Join(",", oList_BsonDocument);
                }
                GEOJSON_SRC = "{\"type\": \"FeatureCollection\",\"features\": [" + GEOJSON_SRC + "]}";
            }

            return GEOJSON_SRC;
        }
        #endregion

        #endregion
    }
}