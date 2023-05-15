using System;
using System.IO;
using System.Net;
using System.Linq;
using SmartrTools;
using System.Net.Mail;
using System.Configuration;
using System.Threading.Tasks;
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
        public bool isDark(string color)
        {
            try
            {
                var c = color.Remove(0, 1);      // strip #
                var rgb = int.Parse(c, System.Globalization.NumberStyles.HexNumber);   // convert rrggbb to decimal
                var r = (rgb >> 16) & 0xff;  // extract red
                var g = (rgb >> 8) & 0xff;  // extract green
                var b = (rgb >> 0) & 0xff;  // extract blue

                var luma = 0.2126 * r + 0.7152 * g + 0.0722 * b; // per ITU-R BT.709

                if (luma < 138)
                {
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
        #endregion
        #region Primary_Authentication
        public Primary_Authentication_Response Primary_Authentication(Params_Primary_Authentication i_Params_Primary_Authentication)
        {
            if (i_Params_Primary_Authentication.USERNAME != null &&
                i_Params_Primary_Authentication.USERNAME.Trim() != "" &&
                i_Params_Primary_Authentication.PASSWORD != null &&
                i_Params_Primary_Authentication.PASSWORD.Trim() != ""
            )
            {
                this._service_mesh.Ticket = Crypto.Encrypt(string.Format(Tools.Get_Unique_String() + "[~!@]USERNAME:{0}[~!@]" + Tools.Get_Unique_String() + "[~!@]OWNER_ID:{1}[~!@]" + Tools.Get_Unique_String() + "[~!@]USER_ID:{2}[~!@]" + Tools.Get_Unique_String() + "[~!@]START_DATE:{3}[~!@]" + Tools.Get_Unique_String() + "[~!@]SESSION_PERIOD:{4}[~!@]", "Temp", this.oBLC_Initializer.Owner_ID, this.oBLC_Initializer.User_ID, Tools.GetDateTimeString(DateTime.Now), 1440));

                User oUser = Get_User_By_USERNAME_OWNER_ID_Adv(new Params_Get_User_By_USERNAME_OWNER_ID()
                {
                    USERNAME = i_Params_Primary_Authentication.USERNAME,
                    OWNER_ID = oBLC_Initializer.Owner_ID
                });

                if (oUser == null && oUser == default)
                {
                    oUser = Get_User_By_EMAIL_OWNER_ID_Adv(new Params_Get_User_By_EMAIL_OWNER_ID()
                    {
                        EMAIL = i_Params_Primary_Authentication.USERNAME,
                        OWNER_ID = oBLC_Initializer.Owner_ID
                    });
                }

                if (oUser != null && oUser != default)
                {
                    if (oUser.Organization != null && oUser.Organization.IS_ACTIVE == true)
                    {
                        if (oUser.IS_ACTIVE == true)
                        {
                            if (oUser.User_type_setup.VALUE == "Organization User" && i_Params_Primary_Authentication.IS_ADMIN == true)
                            {
                                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0033)); // Only Admins Can Log In.
                            }
                            string salt = Crypto.Encrypt(string.Format(Global.Salt, oUser.USER_ID, oUser.OWNER_ID));
                            string entered_password = Crypto.EncryptPassword(i_Params_Primary_Authentication.PASSWORD, salt);

                            if (entered_password.Equals(oUser.PASSWORD))
                            {
                                Send_Otp_Response oSend_Otp_Response = Send_Otp(new Params_Send_Otp()
                                {
                                    USERNAME = i_Params_Primary_Authentication.USERNAME,
                                    USER = oUser

                                });
                                return new Primary_Authentication_Response()
                                {
                                    EMAIL = oSend_Otp_Response.EMAIL,
                                    USER_ID = oSend_Otp_Response.USER_ID,
                                    TTL_IN_SECONDS = oSend_Otp_Response.TTL_IN_SECONDS,
                                };
                            }
                            else
                            {
                                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0006)); // Invalid Password! Re-enter and Try Again
                            }
                        }
                        else
                        {
                            throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0007)); // User Inactive. Please contact support
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
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }
        }
        #endregion
        #region OTP_Verification
        public User_Details OTP_Verification(Params_OTP_Verification i_Params_OTP_Verification)
        {
            if (
                i_Params_OTP_Verification.OTP != "" &&
                i_Params_OTP_Verification.OTP != null &&
                i_Params_OTP_Verification.USERNAME != "" &&
                i_Params_OTP_Verification.USERNAME != null
            )
            {
                this._service_mesh.Ticket = Crypto.Encrypt(string.Format(Tools.Get_Unique_String() + "[~!@]USERNAME:{0}[~!@]" + Tools.Get_Unique_String() + "[~!@]OWNER_ID:{1}[~!@]" + Tools.Get_Unique_String() + "[~!@]USER_ID:{2}[~!@]" + Tools.Get_Unique_String() + "[~!@]START_DATE:{3}[~!@]" + Tools.Get_Unique_String() + "[~!@]SESSION_PERIOD:{4}[~!@]", "Temp", this.oBLC_Initializer.Owner_ID, this.oBLC_Initializer.User_ID, Tools.GetDateTimeString(DateTime.Now), 1440));

                Otp oOtp = Get_Otp_By_USER_ID(new Params_Get_Otp_By_USER_ID
                {
                    USER_ID = i_Params_OTP_Verification.USER_ID,
                });

                if (oOtp != null && oOtp != default)
                {
                    if (Verify_Otp(new Params_Verify_Otp()
                    {
                        OTP = i_Params_OTP_Verification.OTP,
                        USER_ID = i_Params_OTP_Verification.USER_ID
                    }))
                    {
                        User oUser = Get_User_By_USERNAME_OWNER_ID_Adv(new Params_Get_User_By_USERNAME_OWNER_ID()
                        {
                            USERNAME = i_Params_OTP_Verification.USERNAME,
                            OWNER_ID = oBLC_Initializer.Owner_ID
                        });

                        if (oUser == null && oUser == default)
                        {
                            oUser = Get_User_By_EMAIL_OWNER_ID_Adv(new Params_Get_User_By_EMAIL_OWNER_ID()
                            {
                                EMAIL = i_Params_OTP_Verification.USERNAME,
                                OWNER_ID = oBLC_Initializer.Owner_ID
                            });
                        }
                        if (oUser != null && oUser != default)
                        {
                            #region Get ORGANIZATION_TYPE_SETUP

                            List<Setup> oList_Setup = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
                            {
                                SETUP_CATEGORY_NAME = "Organization Type",
                                OWNER_ID = this.oBLC_Initializer.Owner_ID
                            }).List_Setup;
                            if (oList_Setup != null && oList_Setup.Count > 0)
                            {
                                oUser.Organization.Organization_type_setup = oList_Setup.Find(oSetup => oSetup.SETUP_ID == oUser.Organization.ORGANIZATION_TYPE_SETUP_ID);
                            }

                            #endregion

                            User_Details oUser_Details = new User_Details
                            {
                                USER_ID = oUser.USER_ID,
                                ORGANIZATION_ID = oUser.ORGANIZATION_ID,
                                USER_TYPE_SETUP_ID = oUser.USER_TYPE_SETUP_ID,
                                OWNER_ID = oUser.OWNER_ID,
                                FIRST_NAME = oUser.FIRST_NAME,
                                LAST_NAME = oUser.LAST_NAME,
                                USERNAME = oUser.USERNAME,
                                EMAIL = oUser.EMAIL,
                                PHONE_NUMBER = oUser.PHONE_NUMBER,
                                IMAGE_URL = oUser.IMAGE_URL,
                                USER_DISTRICTNEX_WALKTHROUGH = oUser.USER_DISTRICTNEX_WALKTHROUGH,
                                USER_ADMIN_WALKTHROUGH = oUser.USER_ADMIN_WALKTHROUGH,
                                IS_RECEIVE_EMAIL = oUser.IS_RECEIVE_EMAIL,
                                Organization = oUser.Organization,
                                User_type_setup = oUser.User_type_setup,
                                TICKET = Crypto.Encrypt(string.Format(Tools.Get_Unique_String() + "[~!@]USERNAME:{0}[~!@]" + Tools.Get_Unique_String() + "[~!@]OWNER_ID:{1}[~!@]" + Tools.Get_Unique_String() + "[~!@]USER_ID:{2}[~!@]" + Tools.Get_Unique_String() + "[~!@]START_DATE:{3}[~!@]" + Tools.Get_Unique_String() + "[~!@]SESSION_PERIOD:{4}[~!@]", oUser.USERNAME, oUser.OWNER_ID, oUser.USER_ID, Tools.GetDateTimeString(DateTime.Now), oUser.Organization.TICKET_DURATION_IN_MINUTES ?? 1440))
                            };
                            Task.Run(() =>
                            {
                                Delete_Otp_By_OTP_ID(new Params_Delete_Otp_By_OTP_ID()
                                {
                                    OTP_ID = oOtp.OTP_ID,
                                });
                            });
                            return oUser_Details;
                        }
                        else
                        {
                            throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0005)); // User Not Found
                        }
                    }
                    else
                    {
                        throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0032)); // Codes do not match! Try Again.
                    }
                }
                else
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0031)); // No OTP exists for this username. Try again.
                }
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }
        }
        #endregion
        #region Change_User_Forgotten_Password
        public bool Change_User_Forgotten_Password(Params_Change_User_Forgotten_Password i_Params_Change_User_Forgotten_Password)
        {
            if (i_Params_Change_User_Forgotten_Password.OTP != null &&
                i_Params_Change_User_Forgotten_Password.OTP != "" &&
                i_Params_Change_User_Forgotten_Password.USERNAME != null &&
                i_Params_Change_User_Forgotten_Password.USERNAME != "" &&
                i_Params_Change_User_Forgotten_Password.NEW_PASSWORD != null &&
                i_Params_Change_User_Forgotten_Password.NEW_PASSWORD != "")
            {
                this._service_mesh.Ticket = Crypto.Encrypt(string.Format(Tools.Get_Unique_String() + "[~!@]USERNAME:{0}[~!@]" + Tools.Get_Unique_String() + "[~!@]OWNER_ID:{1}[~!@]" + Tools.Get_Unique_String() + "[~!@]USER_ID:{2}[~!@]" + Tools.Get_Unique_String() + "[~!@]START_DATE:{3}[~!@]" + Tools.Get_Unique_String() + "[~!@]SESSION_PERIOD:{4}[~!@]", "Temp", this.oBLC_Initializer.Owner_ID, this.oBLC_Initializer.User_ID, Tools.GetDateTimeString(DateTime.Now), 1440));

                User oUser = Get_User_By_USERNAME_OWNER_ID(new Params_Get_User_By_USERNAME_OWNER_ID()
                {
                    USERNAME = i_Params_Change_User_Forgotten_Password.USERNAME,
                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                });
                if (oUser == null && oUser == default)
                {
                    oUser = Get_User_By_EMAIL_OWNER_ID_Adv(new Params_Get_User_By_EMAIL_OWNER_ID()
                    {
                        EMAIL = i_Params_Change_User_Forgotten_Password.USERNAME,
                        OWNER_ID = this.oBLC_Initializer.Owner_ID
                    });
                }
                if (oUser == null || oUser == default)
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0005)); // User Not Found
                }

                bool isOtpVerified = Verify_Otp(new Params_Verify_Otp()
                {
                    OTP = i_Params_Change_User_Forgotten_Password.OTP,
                    USER_ID = oUser.USER_ID,
                });

                if (!isOtpVerified)
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0011)); // OTP is not verified.
                }

                string salt = Crypto.Encrypt(string.Format(Global.Salt, oUser.USER_ID, oUser.OWNER_ID));
                string new_password = Crypto.EncryptPassword(i_Params_Change_User_Forgotten_Password.NEW_PASSWORD, salt);

                oUser.PASSWORD = new_password;
                Edit_User(oUser);
                return true;
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }
        }
        #endregion
        #region Verify_Otp
        public bool Verify_Otp(Params_Verify_Otp i_Params_Verify_Otp)
        {
            if (i_Params_Verify_Otp.OTP != "" &&
                i_Params_Verify_Otp.OTP != null
            )
            {
                this._service_mesh.Ticket = Crypto.Encrypt(string.Format(Tools.Get_Unique_String() + "[~!@]USERNAME:{0}[~!@]" + Tools.Get_Unique_String() + "[~!@]OWNER_ID:{1}[~!@]" + Tools.Get_Unique_String() + "[~!@]USER_ID:{2}[~!@]" + Tools.Get_Unique_String() + "[~!@]START_DATE:{3}[~!@]" + Tools.Get_Unique_String() + "[~!@]SESSION_PERIOD:{4}[~!@]", "Temp", this.oBLC_Initializer.Owner_ID, this.oBLC_Initializer.User_ID, Tools.GetDateTimeString(DateTime.Now), 1440));

                Otp oOtp = Get_Otp_By_USER_ID(new Params_Get_Otp_By_USER_ID
                {
                    USER_ID = i_Params_Verify_Otp.USER_ID,
                });

                if (oOtp != null && oOtp != default)
                {
                    if (oOtp.OTP.ToUpper().Equals(i_Params_Verify_Otp.OTP.Trim().ToUpper()))
                    {
                        return true;
                    }
                    else
                    {
                        throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0032)); // Codes do not match! Try Again.
                    }
                }
                else
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0031)); // No OTP exists for this username. Try again.
                }
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }
        }
        #endregion
        #region Send_Otp
        public Send_Otp_Response Send_Otp(Params_Send_Otp i_Params_Send_Otp)
        {
            if (i_Params_Send_Otp.USERNAME != null &&
                i_Params_Send_Otp.USERNAME.Trim() != "")
            {
                User oUser = i_Params_Send_Otp.USER;
                if (oUser == null && oUser == default)
                {
                    this._service_mesh.Ticket = Crypto.Encrypt(string.Format(Tools.Get_Unique_String() + "[~!@]USERNAME:{0}[~!@]" + Tools.Get_Unique_String() + "[~!@]OWNER_ID:{1}[~!@]" + Tools.Get_Unique_String() + "[~!@]USER_ID:{2}[~!@]" + Tools.Get_Unique_String() + "[~!@]START_DATE:{3}[~!@]" + Tools.Get_Unique_String() + "[~!@]SESSION_PERIOD:{4}[~!@]", "Temp", this.oBLC_Initializer.Owner_ID, this.oBLC_Initializer.User_ID, Tools.GetDateTimeString(DateTime.Now), 1440));

                    oUser = Get_User_By_USERNAME_OWNER_ID_Adv(new Params_Get_User_By_USERNAME_OWNER_ID()
                    {
                        USERNAME = i_Params_Send_Otp.USERNAME,
                        OWNER_ID = oBLC_Initializer.Owner_ID,
                    });
                    if (oUser == null && oUser == default)
                    {
                        oUser = Get_User_By_EMAIL_OWNER_ID_Adv(new Params_Get_User_By_EMAIL_OWNER_ID()
                        {
                            EMAIL = i_Params_Send_Otp.USERNAME,
                            OWNER_ID = oBLC_Initializer.Owner_ID,
                        });
                    }
                }
                if (oUser != null && oUser != default)
                {
                    if (oUser.Organization != null && oUser.Organization.IS_ACTIVE == true)
                    {
                        if (oUser.IS_ACTIVE == true)
                        {
                            #region Get Default Settings
                            Default_settings oDefault_settings = Props.Copy_Prop_Values_From_Api_Response<Default_settings>(
                                this._service_mesh.Get_Default_settings_By_OWNER_ID(new Service_Mesh.Params_Get_Default_settings_By_OWNER_ID()
                                {
                                    OWNER_ID = this.oBLC_Initializer.Owner_ID
                                }).i_Result.FirstOrDefault()
                            );
                            #endregion
                            #region Create OTP Verification Object
                            Otp oOtp = new Otp
                            {
                                USER_ID = oUser.USER_ID,
                                ENTRY_DATE = DateTime.Now,
                                OTP = Tools.Generate_Random_String(6).ToUpper(),
                            };
                            #endregion
                            #region Delete and Recreate OTP in MongoDB
                            try
                            {
                                Delete_Otp_By_USER_ID(new Params_Delete_Otp_By_USER_ID
                                {
                                    USER_ID = oUser.USER_ID
                                });
                                Edit_Otp_List(new Params_Edit_Otp_List()
                                {
                                    OTP_LIST = new List<Otp>() { oOtp }
                                });
                            }
                            catch (Exception)
                            {
                                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0057)); // Unable to send OTP. Please contact support.
                            }
                            #endregion
                            #region Setup Mail & Send
                            Task.Run(() =>
                            {
                                #region Get SMTP Credentials
                                string smtp_email = "";
                                string smtp_password = "";
                                var get_smtp_email = Task.Run(() =>
                                {
                                    smtp_email = this._service_mesh.Get_Secret(new Service_Mesh.Params_Get_Secret()
                                    {
                                        Secret_Id = ConfigurationManager.AppSettings["SMTP_EMAIL"]
                                    }).i_Result;
                                });
                                var get_smtp_password = Task.Run(() =>
                                {
                                    smtp_password = this._service_mesh.Get_Secret(new Service_Mesh.Params_Get_Secret()
                                    {
                                        Secret_Id = ConfigurationManager.AppSettings["SMTP_PASSWORD"]
                                    }).i_Result;
                                });
                                Task.WaitAll(get_smtp_email, get_smtp_password);
                                #endregion
                                #region Create & Send Email
                                #region Properties & Initialization
                                Organization oOrganization = Props.Copy_Prop_Values_From_Api_Response<Organization>(
                                   this._service_mesh.Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading(new Service_Mesh.Params_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading
                                   {
                                       ORGANIZATION_ID = oUser.ORGANIZATION_ID,
                                       LIST_EAGER_LOADED_DATA = new List<string>() { "Organization_color_scheme", "Organization_image" }
                                   }).i_Result
                                );
                                string logo_link;
                                if (isDark(oOrganization.List_Organization_color_scheme.FirstOrDefault()?.PLATFORM_PRIMARY))
                                {
                                    logo_link = oOrganization.LIGHT_RECTANGLE_LOGO_URL;
                                }
                                else
                                {
                                    logo_link = oOrganization.DARK_RECTANGLE_LOGO_URL;
                                }
                                if (logo_link == null)
                                {
                                    logo_link = isDark(oOrganization.List_Organization_color_scheme.FirstOrDefault()?.PLATFORM_PRIMARY) ? oDefault_settings.LIGHT_RECTANGLE_LOGO_URL : oDefault_settings.DARK_SQUARE_LOGO_URL;
                                }
                                string customerName = oUser.FIRST_NAME;
                                string welcome_text_color = "#000000";
                                string highlight_font_color = "#000000";
                                string small_title = "EMAIL VERIFICATION";
                                string company_name = oOrganization.ORGANIZATION_NAME + " DistrictNex";
                                string welcome_text = "Please use this code to verify your sign in attempt.";
                                string background_color = oOrganization.List_Organization_color_scheme.FirstOrDefault()?.PLATFORM_PRIMARY;
                                string customerNamePossessive = oUser.FIRST_NAME.EndsWith('s') ? oUser.FIRST_NAME : oUser.FIRST_NAME + "'s";
                                string border_bottom_color = oOrganization.List_Organization_color_scheme.FirstOrDefault()?.PLATFORM_BUTTON;
                                string fine_print_color = isDark(oOrganization.List_Organization_color_scheme.FirstOrDefault()?.PLATFORM_PRIMARY) ? "white" : oOrganization.List_Organization_color_scheme.FirstOrDefault()?.PLATFORM_BUTTON;
                                string dotted_line_color = isDark(oOrganization.List_Organization_color_scheme.FirstOrDefault()?.PLATFORM_PRIMARY) ? "white" : oOrganization.List_Organization_color_scheme.FirstOrDefault()?.PLATFORM_BUTTON;
                                string subject = "Sign In Email Verification OTP";
                                if (i_Params_Send_Otp.IS_FORGOT_PASSWORD == true)
                                {
                                    welcome_text = "Please use this code to reset your password.";
                                    subject = "Reset Password OTP";
                                }
                                #endregion
                                #region Get HTML Template
                                string body = string.Empty;
                                using (StreamReader reader = new StreamReader(ConfigurationManager.AppSettings["OTP_TEMPLATE_PATH"]))
                                {
                                    body = reader.ReadToEnd();
                                }
                                #endregion
                                #region Insert Data
                                body = body.Replace("{LogoLink}", logo_link);
                                body = body.Replace("{SmallTitle}", small_title);
                                body = body.Replace("{OTPCode}", oOtp.OTP.Trim());
                                body = body.Replace("{CompanyName}", company_name);
                                body = body.Replace("{WelcomeText}", welcome_text);
                                body = body.Replace("{CustomerName}", customerName);
                                body = body.Replace("{FinePrintColor}", fine_print_color);
                                body = body.Replace("{BackgroundColor}", background_color);
                                body = body.Replace("{DottedLineColor}", dotted_line_color);
                                body = body.Replace("{WelcomeTextColor}", welcome_text_color);
                                body = body.Replace("{BottomBorderColor}", border_bottom_color);
                                body = body.Replace("{HighlightFontColor}", highlight_font_color);
                                body = body.Replace("{CustomerNamePossessive}", customerNamePossessive);
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
                                        Body = body,
                                        IsBodyHtml = true,
                                        Subject = subject,
                                        Priority = MailPriority.Normal,
                                        BodyEncoding = System.Text.Encoding.UTF8,
                                        SubjectEncoding = System.Text.Encoding.UTF8,
                                        From = new MailAddress(smtp_email, company_name),
                                        DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure
                                    };
                                    #region Recipients
                                    message.To.Add(oUser.EMAIL);
                                    #endregion
                                    try
                                    {
                                        client.Send(message);
                                    }
                                    catch (Exception)
                                    {
                                        throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0030)); // An Error has Occured! Contact Support.
                                    }
                                }
                                #endregion
                            });
                            #endregion
                            string emailPart1 = oUser.EMAIL.Split("@").FirstOrDefault();
                            string emailPart2 = oUser.EMAIL.Split("@").LastOrDefault()?.Split('.').FirstOrDefault();
                            string emailPart3 = oUser.EMAIL.Split("@").LastOrDefault()?.Split('.').LastOrDefault();
                            return new Send_Otp_Response()
                            {
                                EMAIL = $"{emailPart1[0]}****@{emailPart2[0]}****{emailPart3}",
                                USER_ID = oUser.USER_ID,
                                TTL_IN_SECONDS = oDefault_settings.OTP_TTL_IN_SECONDS,
                            };
                        }
                        else
                        {
                            throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0007)); // User Inactive. Please contact support
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
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }
        }
        #endregion
        #region Edit_Otp_List
        public void Edit_Otp_List(Params_Edit_Otp_List i_Params_Edit_Otp_List)
        {
            this._MongoDb.Edit_Otp_List(i_Params_Edit_Otp_List.OTP_LIST.Select(otp =>
            {
                DALC.Otp oOtp = Props.Copy_Prop_Values_From_Api_Response<DALC.Otp>(otp);
                if (oOtp.ENTRY_DATE != null)
                {
                    DateTime oDateTime = (DateTime)oOtp.ENTRY_DATE;
                    oOtp.ENTRY_DATE = new DateTime(oDateTime.Year, oDateTime.Month, oDateTime.Day, oDateTime.Hour, oDateTime.Minute, oDateTime.Second, DateTimeKind.Utc);
                }
                return oOtp;
            }).ToList());
        }
        #endregion
        #region Get_Otp_By_USER_ID
        public Otp Get_Otp_By_USER_ID(Params_Get_Otp_By_USER_ID i_Params_Get_Otp_By_USER_ID)
        {
            return Props.Copy_Prop_Values_From_Api_Response<Otp>(
                this._MongoDb.Get_Otp_By_USER_ID(
                    USER_ID: i_Params_Get_Otp_By_USER_ID.USER_ID
                )
            );
        }
        #endregion
        #region Delete_Otp_By_USER_ID
        public void Delete_Otp_By_USER_ID(Params_Delete_Otp_By_USER_ID i_Params_Delete_Otp_By_USER_ID)
        {
            this._MongoDb.Delete_Otp_By_USER_ID(
                USER_ID: i_Params_Delete_Otp_By_USER_ID.USER_ID
            );
        }
        #endregion
        #region Delete_Otp_By_OTP_ID
        public void Delete_Otp_By_OTP_ID(Params_Delete_Otp_By_OTP_ID i_Params_Delete_Otp_By_OTP_ID)
        {
            this._MongoDb.Delete_Otp_By_OTP_ID(
                OTP_ID: i_Params_Delete_Otp_By_OTP_ID.OTP_ID
            );
        }
        #endregion
    }
}
