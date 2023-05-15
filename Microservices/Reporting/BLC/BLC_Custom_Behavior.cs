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
        #endregion
        #region Send_Report_Email
        public bool Send_Report_Email(Params_Send_Report_Email i_Params_Send_Report_Email)
        {
            if (
                i_Params_Send_Report_Email.REPORT_ID > 0 &&
                i_Params_Send_Report_Email.TO_EMAIL != null &&
                i_Params_Send_Report_Email.TO_EMAIL.Trim() != ""
            )
            {
                if (Tools.Is_Valid_Email(i_Params_Send_Report_Email.TO_EMAIL))
                {
                    Report oReport = Get_Report_By_REPORT_ID(new Params_Get_Report_By_REPORT_ID()
                    {
                        REPORT_ID = i_Params_Send_Report_Email.REPORT_ID
                    });
                    if (oReport != null)
                    {
                        Task.Run(() =>
                        {
                            Task.Run(() =>
                            {
                                #region Setup Mail & Send
                                #region Get SMTP Credentials
                                User oUser = Props.Copy_Prop_Values_From_Api_Response<User>(
                                    this._service_mesh.Get_User_By_USER_ID_Adv(new Service_Mesh.Params_Get_User_By_USER_ID()
                                    {
                                        USER_ID = this.oBLC_Initializer.User_ID
                                    }).i_Result
                                );
                                string smtp_email = "";
                                string smtp_password = "";
                                Organization oOrganization = new Organization();
                                Default_settings oDefault_settings = new Default_settings();
                                var get_default_settings = Task.Run(() =>
                                {
                                    oDefault_settings = Props.Copy_Prop_Values_From_Api_Response<Default_settings>(
                                        this._service_mesh.Get_Default_settings_By_OWNER_ID(new Service_Mesh.Params_Get_Default_settings_By_OWNER_ID()
                                        {
                                            OWNER_ID = this.oBLC_Initializer.Owner_ID
                                        }).i_Result.FirstOrDefault()
                                    );
                                });
                                var get_organization = Task.Run(() =>
                                {
                                    oOrganization = Props.Copy_Prop_Values_From_Api_Response<Organization>(
                                        this._service_mesh.Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading(new Service_Mesh.Params_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading()
                                        {
                                            ORGANIZATION_ID = oUser.ORGANIZATION_ID,
                                            LIST_EAGER_LOADED_DATA = new List<string>() { "Organization_color_scheme", "Organization_image" },
                                        }).i_Result
                                    );
                                });
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
                                Task.WaitAll(get_smtp_email, get_smtp_password, get_default_settings, get_organization);
                                #endregion
                                #region Create & Send Email
                                #region Properties & Initialization
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
                                string email_title = "Report";
                                string welcome_text_color = "#000000";
                                string highlight_font_color = "#000000";
                                string normal_text = "Click the button to view the report";
                                string reportName = $"{oReport.FILE_NAME}.{oReport.FILE_EXTENSION}";
                                string company_name = oOrganization.ORGANIZATION_NAME + " DistrictNex";
                                string background_color = oOrganization.List_Organization_color_scheme.FirstOrDefault()?.PLATFORM_PRIMARY;
                                string border_bottom_color = oOrganization.List_Organization_color_scheme.FirstOrDefault()?.PLATFORM_BUTTON;
                                string bottom_text = $"Report Shared By {oUser.FIRST_NAME} {oUser.LAST_NAME}";
                                string fine_print_color = isDark(oOrganization.List_Organization_color_scheme.FirstOrDefault()?.PLATFORM_PRIMARY) ? "white" : oOrganization.List_Organization_color_scheme.FirstOrDefault()?.PLATFORM_BUTTON;
                                string dotted_line_color = isDark(oOrganization.List_Organization_color_scheme.FirstOrDefault()?.PLATFORM_PRIMARY) ? "white" : oOrganization.List_Organization_color_scheme.FirstOrDefault()?.PLATFORM_BUTTON;
                                #endregion
                                #region Get HTML Template
                                string body = string.Empty;
                                using (StreamReader reader = new StreamReader(ConfigurationManager.AppSettings["LINK_SHARE_TEMPLATE_PATH"]))
                                {
                                    body = reader.ReadToEnd();
                                }
                                #endregion
                                #region Insert Data
                                body = body.Replace("{LogoLink}", logo_link);
                                body = body.Replace("{EmailTitle}", email_title);
                                body = body.Replace("{NormalText}", normal_text);
                                body = body.Replace("{BottomText}", bottom_text);
                                body = body.Replace("{FinePrintColor}", fine_print_color);
                                body = body.Replace("{BackgroundColor}", background_color);
                                body = body.Replace("{DottedLineColor}", dotted_line_color);
                                body = body.Replace("{WelcomeTextColor}", welcome_text_color);
                                body = body.Replace("{BottomBorderColor}", border_bottom_color);
                                body = body.Replace("{HighlightFontColor}", highlight_font_color);
                                body = body.Replace("{Link}", $"{Global.Assets_Endpoint}/{Global.Assets_Reports_Path}/{reportName}");
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
                                        Priority = MailPriority.Normal,
                                        Subject = "Email Verification Code",
                                        BodyEncoding = System.Text.Encoding.UTF8,
                                        SubjectEncoding = System.Text.Encoding.UTF8,
                                        From = new MailAddress(smtp_email, company_name),
                                        DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure
                                    };
                                    #region Recipients
                                    message.To.Add(i_Params_Send_Report_Email.TO_EMAIL);
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
                                #endregion
                            });
                        });
                        return true;
                    }
                    else
                    {
                        throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0004)); // Report Not Found
                    }
                }
                else
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0003)); // Invalid Email
                }
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }
        }
        #endregion
        #region Get_Report_Details
        public Report_Details Get_Report_Details(Params_Get_Report_Details i_Params_Get_Report_Details)
        {
            Report_Details oReport_Details = new Report_Details()
            {
                LIST_KPI_DIALOG_DATA_BY_DISTRICT = new List<Kpi_Dialog_Data_By_District>(),
                LIST_KPI_DIALOG_DATA_BY_AREA = new List<Kpi_Dialog_Data_By_Area>(),
                LIST_KPI_DIALOG_DATA_BY_SITE = new List<Kpi_Dialog_Data_By_Site>(),
                LIST_KPI_DIALOG_DATA_BY_ENTITY = new List<Kpi_Dialog_Data_By_Entity>(),

            };

            if (i_Params_Get_Report_Details.START_DATE != null && i_Params_Get_Report_Details.END_DATE != null && i_Params_Get_Report_Details.ENUM_TIMESPAN != null)
            {
                #region General

                #region Declaration & Initialization

                Setup_category oKpi_Severity_Type_Setup_category = new Setup_category();
                Setup_category oKpi_Security_Incident_Setup_category = new Setup_category();

                #endregion

                var get_severity_type = Task.Run(() =>
                {
                    oKpi_Severity_Type_Setup_category = Props.Copy_Prop_Values_From_Api_Response<Setup_category>(this._service_mesh.Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Service_Mesh.Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
                    {
                        SETUP_CATEGORY_NAME = "Severity Type",
                        OWNER_ID = this.oBLC_Initializer.Owner_ID
                    }).i_Result);
                });

                var get_security_incident_type = Task.Run(() =>
                {
                    oKpi_Security_Incident_Setup_category = Props.Copy_Prop_Values_From_Api_Response<Setup_category>(this._service_mesh.Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Service_Mesh.Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
                    {
                        SETUP_CATEGORY_NAME = "Security Incident Category Type",
                        OWNER_ID = this.oBLC_Initializer.Owner_ID
                    }).i_Result);
                });

                Task.WaitAll(get_severity_type, get_security_incident_type);

                #endregion

                #region Fill Entity_List

                var fill_entity_list = Task.Run(() =>
                {
                    if (i_Params_Get_Report_Details.LIST_ENTITY_ASSET_DEFINITION != null && i_Params_Get_Report_Details.LIST_ENTITY_ASSET_DEFINITION.Count > 0)
                    {
                        Parallel.ForEach(i_Params_Get_Report_Details.LIST_ENTITY_ASSET_DEFINITION, oEntity_asset_definition =>
                        {
                            Kpi_Dialog_Data_By_Entity oKpi_Dialog_Data_By_Entity = new Kpi_Dialog_Data_By_Entity();
                            oKpi_Dialog_Data_By_Entity.ENTITY_ID = oEntity_asset_definition.LEVEL_ID;
                            oKpi_Dialog_Data_By_Entity.LIST_ENTITY_KPI_DIALOG_DATA = new List<Entity_Kpi_Dialog_Data>();
                            oKpi_Dialog_Data_By_Entity.LIST_ENTITY_KPI_DIALOG_DATA = Props.Copy_Prop_Values_From_Api_Response<List<Entity_Kpi_Dialog_Data>>(this._service_mesh.Get_Entity_Kpi_Dialog_Data(
                                new Service_Mesh.Params_Get_Entity_Kpi_Dialog_Data()
                                {
                                    DIMENSION_ID = null,
                                    START_DATE = i_Params_Get_Report_Details.START_DATE,
                                    END_DATE = i_Params_Get_Report_Details.END_DATE,
                                    ENTITY_ID = oEntity_asset_definition.LEVEL_ID,
                                    ENUM_TIMESPAN = (Service_Mesh.Enum_Timespan?)i_Params_Get_Report_Details.ENUM_TIMESPAN,
                                    LIST_ENTITY_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID = oEntity_asset_definition.LIST_ORGANIZATION_DATA_SOURCE_KPI_ID
                                }
                                ).i_Result);
                            oReport_Details.LIST_KPI_DIALOG_DATA_BY_ENTITY.Add(oKpi_Dialog_Data_By_Entity);
                        });
                    }
                });

                #endregion

                #region Fill Site_List

                var fill_site_list = Task.Run(() =>
                {
                    if (i_Params_Get_Report_Details.LIST_SITE_ASSET_DEFINITION != null && i_Params_Get_Report_Details.LIST_SITE_ASSET_DEFINITION.Count > 0)
                    {
                        Parallel.ForEach(i_Params_Get_Report_Details.LIST_SITE_ASSET_DEFINITION, oSite_asset_definition =>
                        {
                            Kpi_Dialog_Data_By_Site oKpi_Dialog_Data_By_Site = new Kpi_Dialog_Data_By_Site();
                            oKpi_Dialog_Data_By_Site.SITE_ID = oSite_asset_definition.LEVEL_ID;
                            oKpi_Dialog_Data_By_Site.LIST_SITE_KPI_DIALOG_DATA = new List<Site_Kpi_Dialog_Data>();
                            oKpi_Dialog_Data_By_Site.LIST_SITE_KPI_DIALOG_DATA = Props.Copy_Prop_Values_From_Api_Response<List<Site_Kpi_Dialog_Data>>(this._service_mesh.Get_Site_Kpi_Dialog_Data(
                                new Service_Mesh.Params_Get_Site_Kpi_Dialog_Data()
                                {
                                    DIMENSION_ID = null,
                                    START_DATE = i_Params_Get_Report_Details.START_DATE,
                                    END_DATE = i_Params_Get_Report_Details.END_DATE,
                                    SITE_ID = oSite_asset_definition.LEVEL_ID,
                                    ENUM_TIMESPAN = (Service_Mesh.Enum_Timespan?)i_Params_Get_Report_Details.ENUM_TIMESPAN,
                                    LIST_SITE_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID = oSite_asset_definition.LIST_ORGANIZATION_DATA_SOURCE_KPI_ID,
                                    AREA_ID = null,
                                    DISTRICT_ID = null,
                                    LIST_AREA_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID = null,
                                    LIST_DISTRICT_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID = null
                                }
                                ).i_Result);
                            oReport_Details.LIST_KPI_DIALOG_DATA_BY_SITE.Add(oKpi_Dialog_Data_By_Site);
                        });
                    }
                });

                #endregion

                #region Fill Area_List

                var fill_area_list = Task.Run(() =>
                {
                    if (i_Params_Get_Report_Details.LIST_AREA_ASSET_DEFINITION != null && i_Params_Get_Report_Details.LIST_AREA_ASSET_DEFINITION.Count > 0)
                    {
                        Parallel.ForEach(i_Params_Get_Report_Details.LIST_AREA_ASSET_DEFINITION, oArea_asset_definition =>
                        {
                            Kpi_Dialog_Data_By_Area oKpi_Dialog_Data_By_Area = new Kpi_Dialog_Data_By_Area();
                            oKpi_Dialog_Data_By_Area.AREA_ID = oArea_asset_definition.LEVEL_ID;
                            oKpi_Dialog_Data_By_Area.LIST_AREA_KPI_DIALOG_DATA = new List<Area_Kpi_Dialog_Data>();
                            oKpi_Dialog_Data_By_Area.LIST_AREA_KPI_DIALOG_DATA = Props.Copy_Prop_Values_From_Api_Response<List<Area_Kpi_Dialog_Data>>(this._service_mesh.Get_Area_Kpi_Dialog_Data(
                                new Service_Mesh.Params_Get_Area_Kpi_Dialog_Data()
                                {
                                    DIMENSION_ID = null,
                                    START_DATE = i_Params_Get_Report_Details.START_DATE,
                                    END_DATE = i_Params_Get_Report_Details.END_DATE,
                                    AREA_ID = oArea_asset_definition.LEVEL_ID,
                                    ENUM_TIMESPAN = (Service_Mesh.Enum_Timespan?)i_Params_Get_Report_Details.ENUM_TIMESPAN,
                                    LIST_AREA_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID = oArea_asset_definition.LIST_ORGANIZATION_DATA_SOURCE_KPI_ID,
                                    DISTRICT_ID = null,
                                    LIST_DISTRICT_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID = null
                                }
                                ).i_Result);
                            oReport_Details.LIST_KPI_DIALOG_DATA_BY_AREA.Add(oKpi_Dialog_Data_By_Area);
                        });
                    }
                });

                #endregion

                #region Fill District_List

                var fill_district_list = Task.Run(() =>
                {
                    if (i_Params_Get_Report_Details.LIST_DISTRICT_ASSET_DEFINITION != null && i_Params_Get_Report_Details.LIST_DISTRICT_ASSET_DEFINITION.Count > 0)
                    {
                        Parallel.ForEach(i_Params_Get_Report_Details.LIST_DISTRICT_ASSET_DEFINITION, oDistrict_asset_definition =>
                        {
                            Kpi_Dialog_Data_By_District oKpi_Dialog_Data_By_District = new Kpi_Dialog_Data_By_District();
                            oKpi_Dialog_Data_By_District.DISTRICT_ID = oDistrict_asset_definition.LEVEL_ID;
                            oKpi_Dialog_Data_By_District.LIST_DISTRICT_KPI_DIALOG_DATA = new List<District_Kpi_Dialog_Data>();
                            oKpi_Dialog_Data_By_District.LIST_DISTRICT_KPI_DIALOG_DATA = Props.Copy_Prop_Values_From_Api_Response<List<District_Kpi_Dialog_Data>>(this._service_mesh.Get_District_Kpi_Dialog_Data(
                                new Service_Mesh.Params_Get_District_Kpi_Dialog_Data()
                                {
                                    DIMENSION_ID = null,
                                    START_DATE = i_Params_Get_Report_Details.START_DATE,
                                    END_DATE = i_Params_Get_Report_Details.END_DATE,
                                    DISTRICT_ID = oDistrict_asset_definition.LEVEL_ID,
                                    ENUM_TIMESPAN = (Service_Mesh.Enum_Timespan?)i_Params_Get_Report_Details.ENUM_TIMESPAN,
                                    LIST_DISTRICT_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID = oDistrict_asset_definition.LIST_ORGANIZATION_DATA_SOURCE_KPI_ID
                                }
                                ).i_Result);
                            oReport_Details.LIST_KPI_DIALOG_DATA_BY_DISTRICT.Add(oKpi_Dialog_Data_By_District);
                        });
                    }
                });

                #endregion

                Task.WaitAll(fill_district_list, fill_area_list, fill_site_list, fill_entity_list);
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }

            return oReport_Details;
        }
        #endregion
    }
}