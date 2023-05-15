using System;
using System.Linq;
using SmartrTools;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Mail;
using System.IO;
using System.Net;
using System.Configuration;

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
        public string Get_Organization_URL_By_Setup_Value(Organization i_Organization, string Setup_Value)
        {
            // get the last image
            var oOrganization_image = i_Organization.List_Organization_image.LastOrDefault(oOrganization_image => oOrganization_image.Image_type_setup.VALUE == Setup_Value);
            if (oOrganization_image != null && oOrganization_image != default)
            {
                return $"{Global.Assets_Endpoint}/{Global.Assets_Org_Image_Path}/{oOrganization_image.IMAGE_NAME}.{oOrganization_image.IMAGE_EXTENSION}";
            }
            return null;
        }
        #endregion
        #region Restore_Organization
        public Organization Restore_Organization(Params_Restore_Organization i_Params_Restore_Organization)
        {
            if (i_Params_Restore_Organization.ORGANIZATION_ID != null &&
                i_Params_Restore_Organization.ORGANIZATION_ID > 0)
            {
                Organization oOrganization = Get_Organization_By_ORGANIZATION_ID(new Params_Get_Organization_By_ORGANIZATION_ID
                {
                    ORGANIZATION_ID = i_Params_Restore_Organization.ORGANIZATION_ID
                });

                if (oOrganization != null)
                {
                    oOrganization.IS_ACTIVE = true;
                    oOrganization.DATE_DELETED = null;
                    Edit_Organization(oOrganization);

                    return oOrganization;
                }
                else
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0021)); // Organization not found.
                }
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }
        }
        #endregion
        #region Modify_Data_Settings
        public Data_Settings Modify_Data_Settings(Params_Modify_Data_Settings i_Params_Modify_Data_Settings)
        {
            if (
                i_Params_Modify_Data_Settings.ORGANIZATION_ID != null &&
                i_Params_Modify_Data_Settings.ORGANIZATION_ID > 0 &&
                i_Params_Modify_Data_Settings.DATA_RETENTION_PERIOD != null &&
                i_Params_Modify_Data_Settings.DATA_RETENTION_PERIOD >= 0 &&
                i_Params_Modify_Data_Settings.Params_Edit_Organization_log_config_List != null &&
                i_Params_Modify_Data_Settings.TICKET_DURATION_IN_MINUTES != null &&
                i_Params_Modify_Data_Settings.TICKET_DURATION_IN_MINUTES >= 0
            )
            {
                Organization oOrganization = Get_Organization_By_ORGANIZATION_ID(new Params_Get_Organization_By_ORGANIZATION_ID
                {
                    ORGANIZATION_ID = i_Params_Modify_Data_Settings.ORGANIZATION_ID
                });

                if (oOrganization != null)
                {
                    oOrganization.DATA_RETENTION_PERIOD = i_Params_Modify_Data_Settings.DATA_RETENTION_PERIOD;
                    oOrganization.TICKET_DURATION_IN_MINUTES = i_Params_Modify_Data_Settings.TICKET_DURATION_IN_MINUTES;
                    Edit_Organization(oOrganization);

                    Edit_Organization_log_config_List(i_Params_Modify_Data_Settings.Params_Edit_Organization_log_config_List);
                }

                Data_Settings oData_Settings = new Data_Settings()
                {
                    DATA_RETENTION_PERIOD = oOrganization.DATA_RETENTION_PERIOD,
                    TICKET_DURATION_IN_MINUTES = oOrganization.TICKET_DURATION_IN_MINUTES,
                    Params_Edit_Organization_log_config_List = i_Params_Modify_Data_Settings.Params_Edit_Organization_log_config_List,
                };


                return oData_Settings;
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }
        }
        #endregion
        #region Modify_Organization_Details
        public Organization Modify_Organization_Details(Params_Modify_Organization_Details i_Params_Modify_Organization_Details)
        {
            if (
                i_Params_Modify_Organization_Details.ORGANZATION_ID != null &&
                i_Params_Modify_Organization_Details.ORGANZATION_ID > 0
            )
            {
                Organization oOrganization = Get_Organization_By_ORGANIZATION_ID(new Params_Get_Organization_By_ORGANIZATION_ID
                {
                    ORGANIZATION_ID = i_Params_Modify_Organization_Details.ORGANZATION_ID
                });
                if (oOrganization != null)
                {
                    #region Check and Assign Name
                    if (i_Params_Modify_Organization_Details.ORGANIZATION_NAME != null &&
                        i_Params_Modify_Organization_Details.ORGANIZATION_NAME.Trim() != "")
                    {
                        oOrganization.ORGANIZATION_NAME = i_Params_Modify_Organization_Details.ORGANIZATION_NAME.Trim();
                    }
                    #endregion
                    #region Check and Assign Email
                    if (i_Params_Modify_Organization_Details.ORGANIZATION_EMAIL != null &&
                            i_Params_Modify_Organization_Details.ORGANIZATION_EMAIL.Trim() != "")
                    {
                        if (Tools.Is_Valid_Email(i_Params_Modify_Organization_Details.ORGANIZATION_EMAIL.Trim()))
                        {
                            oOrganization.ORGANIZATION_EMAIL = i_Params_Modify_Organization_Details.ORGANIZATION_EMAIL.Trim();
                        }
                        else
                        {
                            throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0003)); // Invalid Email
                        }
                    }
                    #endregion
                    #region Check and Assign Phone Number
                    if (i_Params_Modify_Organization_Details.ORGANIZATION_PHONE_NUMBER != null &&
                        i_Params_Modify_Organization_Details.ORGANIZATION_PHONE_NUMBER.Trim() != "")
                    {
                        oOrganization.ORGANIZATION_PHONE_NUMBER = i_Params_Modify_Organization_Details.ORGANIZATION_PHONE_NUMBER.Trim(); ;
                    }
                    #endregion
                    #region Check and Assign Address
                    if (i_Params_Modify_Organization_Details.ORGANIZATION_ADDRESS != null &&
                        i_Params_Modify_Organization_Details.ORGANIZATION_ADDRESS.Trim() != "")
                    {
                        oOrganization.ORGANIZATION_ADDRESS = i_Params_Modify_Organization_Details.ORGANIZATION_ADDRESS.Trim(); ;
                    }
                    #endregion
                    #region Check and Assign Max Number of Admins
                    if (i_Params_Modify_Organization_Details.MAX_NUMBER_OF_ADMINS != null)
                    {
                        oOrganization.MAX_NUMBER_OF_ADMINS = i_Params_Modify_Organization_Details.MAX_NUMBER_OF_ADMINS;
                    }
                    #endregion
                    #region Check and Assign Max Number of Users
                    if (i_Params_Modify_Organization_Details.MAX_NUMBER_OF_USERS != null)
                    {
                        oOrganization.MAX_NUMBER_OF_USERS = i_Params_Modify_Organization_Details.MAX_NUMBER_OF_USERS;
                    }
                    #endregion
                    #region Edit & Return
                    Edit_Organization(oOrganization);
                    return oOrganization;
                    #endregion
                }
                else
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0021)); // Organization not found.
                }
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }
        }
        #endregion
        #region Upload_Organization_Picture
        public string Upload_Organization_Picture(Params_Upload_Organization_Picture i_Params_Upload_Organization_Picture)
        {
            if (
                i_Params_Upload_Organization_Picture.ORGANIZATION_ID != null &&
                i_Params_Upload_Organization_Picture.ORGANIZATION_ID > 0 &&
                i_Params_Upload_Organization_Picture.IMAGE_TYPE_SETUP_ID != null &&
                i_Params_Upload_Organization_Picture.IMAGE_TYPE_SETUP_ID > 0 &&
                i_Params_Upload_Organization_Picture.List_Uploaded_File != null &&
                i_Params_Upload_Organization_Picture.List_Uploaded_File.Count > 0
            )
            {
                Organization oOrganization = Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading(new Params_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading
                {
                    ORGANIZATION_ID = i_Params_Upload_Organization_Picture.ORGANIZATION_ID,
                    LIST_EAGER_LOADED_DATA = new List<string> { "Organization_image" }
                });

                if (oOrganization != null)
                {
                    var formFile = i_Params_Upload_Organization_Picture.List_Uploaded_File.First();
                    var fileName = formFile.FileName;
                    var extension = Path.GetExtension(fileName).Replace(".", "");

                    Organization_image oOrganization_image = new Organization_image
                    {
                        ORGANIZATION_IMAGE_ID = -1,
                        IMAGE_EXTENSION = extension,
                        OWNER_ID = this.oBLC_Initializer.Owner_ID,
                        IMAGE_NAME = Tools.Get_Unique_String(),
                        ORGANIZATION_ID = i_Params_Upload_Organization_Picture.ORGANIZATION_ID,
                        IMAGE_TYPE_SETUP_ID = i_Params_Upload_Organization_Picture.IMAGE_TYPE_SETUP_ID,
                    };

                    string Object_Name = $"{Global.Assets_Org_Image_Path}/{oOrganization_image.IMAGE_NAME}.{oOrganization_image.IMAGE_EXTENSION}";

                    try
                    {
                        byte[] data;

                        using (var oMemoryStream = new MemoryStream())
                        {
                            formFile.CopyTo(oMemoryStream);
                            data = oMemoryStream.ToArray();
                        }
                        this._service_mesh.Upload_Object(new Service_Mesh.Params_Upload_Object()
                        {
                            Data = data,
                            Object_Name = Object_Name,
                        });
                    }
                    catch
                    {
                        throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0026)); // Upload Failed.
                    }

                    if (oOrganization.List_Organization_image != null &&
                        oOrganization.List_Organization_image.Count > 0 &&
                        oOrganization.List_Organization_image.Any(oOrganization_image => oOrganization_image.IMAGE_TYPE_SETUP_ID == i_Params_Upload_Organization_Picture.IMAGE_TYPE_SETUP_ID))
                    {
                        this._service_mesh.Delete_Object_List(new Service_Mesh.Params_Delete_Object_List()
                        {
                            List_Object_Name = oOrganization.List_Organization_image
                                                .Where(oOrganization_image => oOrganization_image.IMAGE_TYPE_SETUP_ID == i_Params_Upload_Organization_Picture.IMAGE_TYPE_SETUP_ID)
                                                .Select(oOrganization_image => $"{Global.Assets_Org_Image_Path}/{oOrganization_image.IMAGE_NAME}.{oOrganization_image.IMAGE_EXTENSION}")
                        });

                        Delete_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID(new Params_Delete_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID
                        {
                            ORGANIZATION_ID = i_Params_Upload_Organization_Picture.ORGANIZATION_ID,
                            IMAGE_TYPE_SETUP_ID = i_Params_Upload_Organization_Picture.IMAGE_TYPE_SETUP_ID
                        });
                    }

                    Edit_Organization_image(oOrganization_image);

                    return $"{Global.Assets_Endpoint}/{Object_Name}";
                }
                else
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0021)); // Organization not found.
                }
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }
        }
        #endregion
        #region Delete_Organization_Picture
        public bool Delete_Organization_Picture(Params_Delete_Organization_Picture i_Params_Delete_Organization_Picture)
        {
            if (i_Params_Delete_Organization_Picture.ORGANIZATION_ID != null &&
                i_Params_Delete_Organization_Picture.ORGANIZATION_ID > 0 &&
                i_Params_Delete_Organization_Picture.IMAGE_TYPE_SETUP_ID != null &&
                i_Params_Delete_Organization_Picture.IMAGE_TYPE_SETUP_ID > 0)
            {
                List<Organization_image> oList_Organization_image = Get_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID_Adv(new Params_Get_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID
                {
                    IMAGE_TYPE_SETUP_ID = i_Params_Delete_Organization_Picture.IMAGE_TYPE_SETUP_ID,
                    ORGANIZATION_ID = i_Params_Delete_Organization_Picture.ORGANIZATION_ID
                });

                if (oList_Organization_image != null && oList_Organization_image.Count > 0)
                {
                    this._service_mesh.Delete_Object_List(new Service_Mesh.Params_Delete_Object_List()
                    {
                        List_Object_Name = oList_Organization_image.Select(oOrganization_image => $"{Global.Assets_Org_Image_Path}/{oOrganization_image.IMAGE_NAME}.{oOrganization_image.IMAGE_EXTENSION}")
                    });

                    Delete_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID(new Params_Delete_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID
                    {
                        ORGANIZATION_ID = i_Params_Delete_Organization_Picture.ORGANIZATION_ID,
                        IMAGE_TYPE_SETUP_ID = i_Params_Delete_Organization_Picture.IMAGE_TYPE_SETUP_ID
                    });
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }
        }
        #endregion
        #region Permanently_Delete_Organization
        public bool Permanently_Delete_Organization(Params_Permanently_Delete_Organization i_Params_Permanently_Delete_Organization)
        {
            if (
                i_Params_Permanently_Delete_Organization.ORGANIZATION_ID != null &&
                i_Params_Permanently_Delete_Organization.ORGANIZATION_ID > 0
            )
            {
                Organization oOrganization = Get_Organization_By_ORGANIZATION_ID(new Params_Get_Organization_By_ORGANIZATION_ID
                {
                    ORGANIZATION_ID = i_Params_Permanently_Delete_Organization.ORGANIZATION_ID
                });

                if (oOrganization != null)
                {
                    oOrganization.IS_ACTIVE = false;
                    oOrganization.IS_DELETED = true;
                    oOrganization.ORGANIZATION_EMAIL = Tools.Generate_Random_String(6) + "_del_" + oOrganization.ORGANIZATION_EMAIL;
                    oOrganization.DATE_DELETED = Tools.GetDateTimeString(DateTime.Now);

                    Delete_Organization_level_access_By_ORGANIZATION_ID(new Params_Delete_Organization_level_access_By_ORGANIZATION_ID()
                    {
                        ORGANIZATION_ID = oOrganization.ORGANIZATION_ID
                    });
                    oOrganization.List_Organization_level_access = null;

                    List<Service_Mesh.User> oList_User = this._service_mesh.Get_User_By_ORGANIZATION_ID(new Service_Mesh.Params_Get_User_By_ORGANIZATION_ID()
                    {
                        ORGANIZATION_ID = oOrganization.ORGANIZATION_ID
                    }).i_Result.Select(user =>
                    {
                        user.IS_ACTIVE = false;
                        user.IS_DELETED = true;
                        user.EMAIL = Tools.Generate_Random_String(6) + "_del_" + user.EMAIL;
                        user.USERNAME = Tools.Generate_Random_String(6) + "_del_" + user.USERNAME;
                        return user;
                    }).ToList();

                    this._service_mesh.Edit_User_List(new Service_Mesh.Params_Edit_User_List()
                    {
                        List_To_Edit = Props.Copy_Prop_Values_From_Api_Response<List<Service_Mesh.User>>(oList_User.Select(user => user))
                    });

                    Edit_Organization(oOrganization);
                    return true;
                }
                else
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0021)); // Organization not found.
                }
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }
        }
        #endregion
        #region Get_Organization_Images_From_GCP
        public List<Organization_image> Get_Organization_Images_From_GCP(Params_Get_Organization_Images_From_GCP i_Params_Get_Organization_Images_From_GCP)
        {
            if (
                i_Params_Get_Organization_Images_From_GCP.ORGANIZATION_ID != null &&
                i_Params_Get_Organization_Images_From_GCP.ORGANIZATION_ID > 0
            )
            {
                List<Organization_image> oList_Organization_image = Get_Organization_image_By_ORGANIZATION_ID_Adv(new Params_Get_Organization_image_By_ORGANIZATION_ID
                {
                    ORGANIZATION_ID = i_Params_Get_Organization_Images_From_GCP.ORGANIZATION_ID
                });

                if (oList_Organization_image != null && oList_Organization_image.Count > 0)
                {
                    return oList_Organization_image.Select(oOrganization_image =>
                    {
                        oOrganization_image.IMAGE_GCP_URL = $"{Global.Assets_Endpoint}/{Global.Assets_Org_Image_Path}/{oOrganization_image.IMAGE_NAME}.{oOrganization_image.IMAGE_EXTENSION}";
                        return oOrganization_image;
                    }).ToList();
                }
                else
                {
                    return new List<Organization_image>();
                }
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }
        }
        #endregion
        #region Schedule_Organization_for_Delete
        public Organization Schedule_Organization_for_Delete(Params_Schedule_Organization_for_Delete i_Params_Schedule_Organization_for_Delete)
        {
            if (
                i_Params_Schedule_Organization_for_Delete.ORGANIZATION_ID != null &&
                i_Params_Schedule_Organization_for_Delete.ORGANIZATION_ID > 0
            )
            {
                Organization oOrganization = Get_Organization_By_ORGANIZATION_ID(new Params_Get_Organization_By_ORGANIZATION_ID()
                {
                    ORGANIZATION_ID = i_Params_Schedule_Organization_for_Delete.ORGANIZATION_ID
                });

                if (oOrganization != null)
                {
                    if (oOrganization.DATA_RETENTION_PERIOD > 0)
                    {
                        oOrganization.IS_ACTIVE = false;
                        oOrganization.DATE_DELETED = Tools.GetDateTimeString(DateTime.Now);
                        Edit_Organization(oOrganization);
                    }
                    else if (oOrganization.DATA_RETENTION_PERIOD == 0)
                    {
                        oOrganization.IS_ACTIVE = false;
                        oOrganization.IS_DELETED = true;
                        oOrganization.DATE_DELETED = Tools.GetDateTimeString(DateTime.Now);
                        Permanently_Delete_Organization(new Params_Permanently_Delete_Organization()
                        {
                            ORGANIZATION_ID = oOrganization.ORGANIZATION_ID
                        });
                    }
                    return oOrganization;
                }
                else
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0021)); // Organization not found.
                }
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }
        }
        #endregion
        #region Check_Organization_Deletion_Status
        public void Check_Organization_Deletion_Status()
        {
            Params_Edit_Organization_List oParams_Edit_Organization_List = new Params_Edit_Organization_List()
            {
                List_To_Edit = new List<Organization>()
            };

            oParams_Edit_Organization_List.List_To_Edit = Get_Organization_By_OWNER_ID(new Params_Get_Organization_By_OWNER_ID()
            {
                OWNER_ID = this.oBLC_Initializer.Owner_ID,
            }).Where(organization => organization.IS_ACTIVE == false && organization.IS_DELETED == false && DateTime.Parse(organization.DATE_DELETED).AddDays(organization.DATA_RETENTION_PERIOD.Value) <= DateTime.Now).ToList();

            oParams_Edit_Organization_List.List_To_Edit = oParams_Edit_Organization_List.List_To_Edit.Select(organization =>
            {
                organization.IS_DELETED = true;
                organization.ORGANIZATION_EMAIL = Tools.Generate_Random_String(6) + "_del_" + organization.ORGANIZATION_EMAIL;
                return organization;
            }).ToList();

            if (oParams_Edit_Organization_List.List_To_Edit != null && oParams_Edit_Organization_List.List_To_Edit.Count > 0)
            {
                List<Organization_level_access> oList_Organization_level_access = Get_Organization_level_access_By_ORGANIZATION_ID_List(new Params_Get_Organization_level_access_By_ORGANIZATION_ID_List()
                {
                    ORGANIZATION_ID_LIST = oParams_Edit_Organization_List.List_To_Edit.Select(organization => organization.ORGANIZATION_ID)
                });

                Edit_Organization_level_access_List(new Params_Edit_Organization_level_access_List()
                {
                    List_To_Delete = oList_Organization_level_access.Select(Organization_level_access => Organization_level_access.ORGANIZATION_LEVEL_ACCESS_ID)
                });
                oParams_Edit_Organization_List.List_To_Edit = oParams_Edit_Organization_List.List_To_Edit.Select(organization =>
                {
                    organization.List_Organization_level_access = null;
                    return organization;
                }).ToList();

                List<Service_Mesh.User> oList_User = this._service_mesh.Get_User_By_ORGANIZATION_ID_List(new Service_Mesh.Params_Get_User_By_ORGANIZATION_ID_List()
                {
                    ORGANIZATION_ID_LIST = oParams_Edit_Organization_List.List_To_Edit.Select(organization => organization.ORGANIZATION_ID)
                }).i_Result.Select(user =>
                {
                    user.IS_ACTIVE = false;
                    user.IS_DELETED = true;
                    user.EMAIL = Tools.Generate_Random_String(6) + "_del_" + user.EMAIL;
                    user.USERNAME = Tools.Generate_Random_String(6) + "_del_" + user.USERNAME;
                    return user;
                }).ToList();

                this._service_mesh.Edit_User_List(new Service_Mesh.Params_Edit_User_List()
                {
                    List_To_Edit = Props.Copy_Prop_Values_From_Api_Response<List<Service_Mesh.User>>(oList_User.Select(user => user))
                });

                Edit_Organization_List(oParams_Edit_Organization_List);

                if (oParams_Edit_Organization_List.List_Failed_Edit != null && oParams_Edit_Organization_List.List_Failed_Edit.Count > 0)
                {
                    Send_Support_Email(new Params_Send_Support_Email()
                    {
                        TITLE = "Organization Deletion Failed",
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
        #region Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading
        public Organization Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading(Params_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading i_Params_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading)
        {
            Organization oOrganization = Get_Organization_By_ORGANIZATION_ID(new Params_Get_Organization_By_ORGANIZATION_ID
            {
                ORGANIZATION_ID = i_Params_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading.ORGANIZATION_ID
            });

            if (oOrganization.IS_DELETED == true)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0010)); // The chosen organization does not exist.
            }

            var get_Organization_level_access = Task.Run(() =>
            {
                if (i_Params_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading.LIST_EAGER_LOADED_DATA.Contains("Organization_level_access"))
                {
                    oOrganization.List_Organization_level_access = Get_Organization_level_access_By_ORGANIZATION_ID(new Params_Get_Organization_level_access_By_ORGANIZATION_ID
                    {
                        ORGANIZATION_ID = i_Params_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading.ORGANIZATION_ID
                    });
                }
            });
            var get_organization_color_scheme = Task.Run(() =>
            {
                if (i_Params_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading.LIST_EAGER_LOADED_DATA.Contains("Organization_color_scheme"))
                {
                    oOrganization.List_Organization_color_scheme = Get_Organization_color_scheme_By_ORGANIZATION_ID(new Params_Get_Organization_color_scheme_By_ORGANIZATION_ID
                    {
                        ORGANIZATION_ID = i_Params_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading.ORGANIZATION_ID
                    });
                }
            });
            var get_organization_districtnex_module = Task.Run(() =>
            {
                if (i_Params_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading.LIST_EAGER_LOADED_DATA.Contains("Organization_districtnex_module"))
                {
                    oOrganization.List_Organization_districtnex_module = Get_Organization_districtnex_module_By_ORGANIZATION_ID(new Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID
                    {
                        ORGANIZATION_ID = i_Params_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading.ORGANIZATION_ID
                    });
                }
            });
            var get_organization_image = Task.Run(() =>
            {
                if (i_Params_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading.LIST_EAGER_LOADED_DATA.Contains("Organization_image"))
                {
                    oOrganization.List_Organization_image = Get_Organization_image_By_ORGANIZATION_ID(new Params_Get_Organization_image_By_ORGANIZATION_ID
                    {
                        ORGANIZATION_ID = i_Params_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading.ORGANIZATION_ID
                    });

                    var Setup_ID_List = oOrganization.List_Organization_image.Select(oOrganization_image => oOrganization_image.IMAGE_TYPE_SETUP_ID);
                    var oList_Setup = Get_Setup_By_SETUP_ID_List(new Params_Get_Setup_By_SETUP_ID_List()
                    {
                        SETUP_ID_LIST = Setup_ID_List
                    });
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
                }
            });
            var get_organization_log_config = Task.Run(() =>
            {
                if (i_Params_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading.LIST_EAGER_LOADED_DATA.Contains("Organization_log_config"))
                {
                    oOrganization.List_Organization_log_config = Get_Organization_log_config_By_ORGANIZATION_ID(new Params_Get_Organization_log_config_By_ORGANIZATION_ID
                    {
                        ORGANIZATION_ID = i_Params_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading.ORGANIZATION_ID
                    });
                }
            });
            var get_user = Task.Run(() =>
            {
                if (i_Params_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading.LIST_EAGER_LOADED_DATA.Contains("User"))
                {
                    List<Service_Mesh.User> oList_User = this._service_mesh.Get_User_By_ORGANIZATION_ID_Adv(new Service_Mesh.Params_Get_User_By_ORGANIZATION_ID()
                    {
                        ORGANIZATION_ID = i_Params_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading.ORGANIZATION_ID
                    }).i_Result;
                    oList_User.RemoveAll(user => user.USER_ID == this.oBLC_Initializer.User_ID);

                    oOrganization.List_User = Props.Copy_Prop_Values_From_Api_Response<List<User>>(oList_User);
                }
            });

            Task.WaitAll(get_Organization_level_access, get_organization_color_scheme, get_organization_districtnex_module, get_organization_image, get_organization_log_config, get_user);
            return oOrganization;
        }
        #endregion
        #region Get_Organization_By_PARENT_ORGANIZATION_ID
        public List<Organization> Get_Organization_By_PARENT_ORGANIZATION_ID(Params_Get_Organization_By_PARENT_ORGANIZATION_ID i_Params_Get_Organization_By_PARENT_ORGANIZATION_ID)
        {
            List<Organization> oList_Organization = new List<Organization>();
            if (i_Params_Get_Organization_By_PARENT_ORGANIZATION_ID.PARENT_ORGANIZATION_ID != null)
            {
                List<Organization_relation> oList_Organization_relation = new List<Organization_relation>();
                oList_Organization_relation = Get_Organization_relation_By_PARENT_ORGANIZATION_ID(new Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID()
                {
                    PARENT_ORGANIZATION_ID = i_Params_Get_Organization_By_PARENT_ORGANIZATION_ID.PARENT_ORGANIZATION_ID
                });
                if (oList_Organization_relation != null && oList_Organization_relation.Count > 0)
                {
                    oList_Organization = Get_Organization_By_ORGANIZATION_ID_List(new Params_Get_Organization_By_ORGANIZATION_ID_List()
                    {
                        ORGANIZATION_ID_LIST = oList_Organization_relation.Select(oOrganization_relation => oOrganization_relation.CHILD_ORGANIZATION_ID).ToList()
                    });
                }
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }
            return oList_Organization;
        }
        #endregion
        #region Edit_Organization_Custom
        public Organization Edit_Organization_Custom(Params_Edit_Organization_Custom i_Params_Edit_Organization_Custom)
        {
            #region Declaration & Initialization

            User oUser = new User();
            Organization oSuper_Organization = new Organization();
            long? Super_Organization_Setup_ID = 0;

            #endregion

            #region General

            var get_user = Task.Run(() =>
            {
                oUser = Props.Copy_Prop_Values_From_Api_Response<User>(this._service_mesh.Get_User_By_USER_ID_Adv(new Service_Mesh.Params_Get_User_By_USER_ID()
                {
                    USER_ID = this.oBLC_Initializer.User_ID
                }).i_Result);

                if (oUser == null || oUser == default)
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0005)); // User Not Found
                }
            });

            var get_super_organization_setup = Task.Run(() =>
            {
                List<Setup> oList_Data_Level_Setup = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
                {
                    SETUP_CATEGORY_NAME = "Organization Type",
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                }).List_Setup;
                if (oList_Data_Level_Setup != null && oList_Data_Level_Setup.Count > 0)
                {
                    Super_Organization_Setup_ID = oList_Data_Level_Setup.FirstOrDefault(setup => setup.VALUE == "Super Organization").SETUP_ID;
                }
                else
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0045).Replace("%1", "Organization Type")); // Organization Type Setup Not Found
                }
            });

            Task.WaitAll(get_user, get_super_organization_setup);

            #endregion

            Edit_Organization(i_Params_Edit_Organization_Custom.ORGANIZATION);

            if (oUser.Organization.ORGANIZATION_TYPE_SETUP_ID == Super_Organization_Setup_ID)
            {
                Organization_relation oOrganization_relation = new Organization_relation()
                {
                    ORGANIZATION_RELATION_ID = -1,
                    USER_ID = this.oBLC_Initializer.User_ID,
                    PARENT_ORGANIZATION_ID = oUser.Organization.ORGANIZATION_ID,
                    CHILD_ORGANIZATION_ID = i_Params_Edit_Organization_Custom.ORGANIZATION.ORGANIZATION_ID
                };
                Edit_Organization_relation(oOrganization_relation);
            }
            else
            {
                var organization_parent_child_relation = Task.Run(() =>
                {
                    Organization_relation oOrganization_relation = new Organization_relation()
                    {
                        ORGANIZATION_RELATION_ID = -1,
                        USER_ID = this.oBLC_Initializer.User_ID,
                        PARENT_ORGANIZATION_ID = oUser.Organization.ORGANIZATION_ID,
                        CHILD_ORGANIZATION_ID = i_Params_Edit_Organization_Custom.ORGANIZATION.ORGANIZATION_ID
                    };
                    Edit_Organization_relation(oOrganization_relation);
                });

                var super_organization_parent_child_relation = Task.Run(() =>
                {
                    List<Organization> oList_Super_Organization = Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID(new Params_Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID()
                    {
                        ORGANIZATION_TYPE_SETUP_ID = Super_Organization_Setup_ID
                    });

                    if (oList_Super_Organization != null && oList_Super_Organization.Count > 0)
                    {
                        oSuper_Organization = oList_Super_Organization.FirstOrDefault();
                        Organization_relation oOrganization_relation = new Organization_relation()
                        {
                            ORGANIZATION_RELATION_ID = -1,
                            USER_ID = this.oBLC_Initializer.User_ID,
                            PARENT_ORGANIZATION_ID = oSuper_Organization.ORGANIZATION_ID,
                            CHILD_ORGANIZATION_ID = i_Params_Edit_Organization_Custom.ORGANIZATION.ORGANIZATION_ID
                        };
                        Edit_Organization_relation(oOrganization_relation);
                    }
                });

                Task.WaitAll(organization_parent_child_relation, super_organization_parent_child_relation);
            }

            return i_Params_Edit_Organization_Custom.ORGANIZATION;
        }
        #endregion
    }
}