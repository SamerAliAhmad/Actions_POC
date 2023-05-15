using System;
using System.IO;
using System.Linq;
using SmartrTools;
using System.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

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
        public string Get_File_Full_Path(string i_File_Name)
        {
            return $@"{ConfigurationManager.AppSettings["ASSETS_LOCATION"]}/{i_File_Name}";
        }
        #endregion
        #region Upload_Share_File
        public string Upload_Share_File(Params_Upload_Share_File i_Params_Upload_Share_File)
        {
            if (i_Params_Upload_Share_File.List_Uploaded_File != null && i_Params_Upload_Share_File.List_Uploaded_File.Count > 0 && i_Params_Upload_Share_File.USER_ID != null)
            {
                var formFile = i_Params_Upload_Share_File.List_Uploaded_File.First();
                var fileName = formFile.FileName;
                var FILE_EXTENSION = Path.GetExtension(fileName).Replace(".", "");
                string FILE_NAME = Path.GetFileNameWithoutExtension(fileName) + "_" + Tools.Get_Unique_String();

                string Object_Name = $"{Global.Shared_Files_Path}/{FILE_NAME}.{FILE_EXTENSION}";

                Share_file oShare_File = new Share_file()
                {
                    SHARE_FILE_ID = -1,
                    USER_ID = i_Params_Upload_Share_File.USER_ID,
                    FILE_NAME = FILE_NAME,
                    FILE_EXTENSION = FILE_EXTENSION
                };

                try
                {
                    byte[] data;

                    using (var oMemoryStream = new MemoryStream())
                    {
                        formFile.CopyTo(oMemoryStream);
                        data = oMemoryStream.ToArray();
                    }
                    this._service_mesh.Upload_Object(new Service_Mesh.Params_Upload_Object
                    {
                        Data = data,
                        Object_Name = Object_Name,
                    });

                    Edit_Share_file(oShare_File);
                }
                catch
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0026)); // Upload Failed.
                }

                return $"{Global.Assets_Endpoint}/{Object_Name}";
            }
            else
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0015)); // Invalid Input
            }
        }
        #endregion
        #region Send_Share_Link_By_Email
        public bool Send_Share_Link_By_Email(Params_Send_Share_Link_By_Email i_Params_Send_Share_Link_By_Email)
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
                        Secret_Version = "latest",
                        Secret_Id = ConfigurationManager.AppSettings["SMTP_EMAIL"]
                    }).i_Result;
                });
                var get_smtp_password = Task.Run(() =>
                {
                    smtp_password = this._service_mesh.Get_Secret(new Service_Mesh.Params_Get_Secret()
                    {
                        Secret_Version = "latest",
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
                string email_title = "Share View";
                string welcome_text_color = "#000000";
                string highlight_font_color = "#000000";
                string normal_text = "Click the button to go to the shared view";
                string company_name = oOrganization.ORGANIZATION_NAME + " DistrictNex";
                string background_color = oOrganization.List_Organization_color_scheme.FirstOrDefault()?.PLATFORM_PRIMARY;
                string border_bottom_color = oOrganization.List_Organization_color_scheme.FirstOrDefault()?.PLATFORM_BUTTON;
                string bottom_text = $"Document Shared By {oUser.FIRST_NAME} {oUser.LAST_NAME}";
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
                body = body.Replace("{Link}", i_Params_Send_Share_Link_By_Email.SHARE_DATA_LINK);
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
                        Subject = "DistrictNex Shared Content",
                        BodyEncoding = System.Text.Encoding.UTF8,
                        SubjectEncoding = System.Text.Encoding.UTF8,
                        From = new MailAddress(smtp_email, company_name),
                        DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure
                    };
                    #region Recipients
                    i_Params_Send_Share_Link_By_Email.List_Email.ForEach(email =>
                    {
                        message.To.Add(email);
                    });
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

            return true;
        }
        #endregion

        #region Entity_share_data
        #region Delete_Entity_share_data
        public void Delete_Entity_share_data(Params_Delete_Entity_share_data i_Params_Delete_Entity_share_data)
        {
            this._MongoDb.Delete_Entity_share_data(
                UNIQUE_STRING: i_Params_Delete_Entity_share_data.UNIQUE_STRING
            );
        }
        #endregion
        #region Edit_Entity_share_data
        public string Edit_Entity_share_data(Params_Edit_Entity_share_data i_Params_Edit_Entity_share_data)
        {
            i_Params_Edit_Entity_share_data.Entity_share_data.UNIQUE_STRING = Tools.Generate_Random_String(20);
            this._MongoDb.Edit_Entity_share_data(Props.Copy_Prop_Values_From_Api_Response<DALC.Entity_share_data>(i_Params_Edit_Entity_share_data.Entity_share_data));
            return ConfigurationManager.AppSettings["ENTITY_SHAREVIEW_ENDPOINT"] + "/" + i_Params_Edit_Entity_share_data.Entity_share_data.UNIQUE_STRING;
        }
        #endregion
        #region Get_Entity_share_data_By_UNIQUE_STRING
        public Entity_share_data Get_Entity_share_data_By_UNIQUE_STRING(Params_Get_Entity_share_data_By_UNIQUE_STRING i_Params_Get_Entity_share_data_By_UNIQUE_STRING)
        {
            return Props.Copy_Prop_Values_From_Api_Response<Entity_share_data>(
                this._MongoDb.Get_Entity_share_data_By_UNIQUE_STRING(
                    UNIQUE_STRING: i_Params_Get_Entity_share_data_By_UNIQUE_STRING.UNIQUE_STRING
                )
            );
        }
        #endregion
        #endregion

        #region Get_Entity_share_view_data
        public Entity_share_view_data Get_Entity_share_view_data(Params_Get_Entity_share_view_data i_Params_Get_Entity_share_view_data)
        {
            this._service_mesh.Ticket = Crypto.Encrypt(string.Format(Tools.Get_Unique_String() + "[~!@]USERNAME:{0}[~!@]" + Tools.Get_Unique_String() + "[~!@]OWNER_ID:{1}[~!@]" + Tools.Get_Unique_String() + "[~!@]USER_ID:{2}[~!@]" + Tools.Get_Unique_String() + "[~!@]START_DATE:{3}[~!@]" + Tools.Get_Unique_String() + "[~!@]SESSION_PERIOD:{4}[~!@]", "Temp", this.oBLC_Initializer.Owner_ID, this.oBLC_Initializer.User_ID, Tools.GetDateTimeString(DateTime.Now), 1440));

            Entity_share_data oEntity_share_data = Get_Entity_share_data_By_UNIQUE_STRING(new Params_Get_Entity_share_data_By_UNIQUE_STRING()
            {
                UNIQUE_STRING = i_Params_Get_Entity_share_view_data.UNIQUE_STRING
            });

            Entity_share_view_data oEntity_share_view_data = new Entity_share_view_data();

            oEntity_share_view_data.SHARING_USER_NAME = oEntity_share_data.SHARING_USER_NAME;
            oEntity_share_view_data.IS_ALERT = oEntity_share_data.IS_ALERT;
            oEntity_share_view_data.IS_CAMERA_ONE_ON = oEntity_share_data.IS_CAMERA_ONE_ON;
            oEntity_share_view_data.IS_CAMERA_TWO_ON = oEntity_share_data.IS_CAMERA_TWO_ON;
            oEntity_share_view_data.IS_CAMERA_THREE_ON = oEntity_share_data.IS_CAMERA_THREE_ON;
            oEntity_share_view_data.INCIDENT_CATEGORY_SETUP_ID = oEntity_share_data.INCIDENT_CATEGORY_SETUP_ID;
            oEntity_share_view_data.FILTER_END_DATE = oEntity_share_data.FILTER_END_DATE;
            oEntity_share_view_data.FILTER_START_DATE = oEntity_share_data.FILTER_START_DATE;
            oEntity_share_view_data.ENUM_TIMESPAN = oEntity_share_data.ENUM_TIMESPAN;
            oEntity_share_view_data.FLOOR_ID = oEntity_share_data.FLOOR_ID;
            oEntity_share_view_data.List_Floor_asset_Wifi_signal = oEntity_share_data.LIST_FLOOR_ASSET_WIFI_SIGNAL;
            oEntity_share_view_data.List_Floor_chart_Wifi_signal = oEntity_share_data.LIST_FLOOR_CHART_WIFI_SIGNAL;
            oEntity_share_view_data.List_Summary_Wifi_signal = oEntity_share_data.LIST_SUMMARY_WIFI_SIGNAL;
            oEntity_share_view_data.DIMENSION_ID = oEntity_share_data.DIMENSION_ID;
            oEntity_share_view_data.List_Floor_Dimension_index = oEntity_share_data.LIST_FLOOR_DIMENSION_INDEX;
            oEntity_share_view_data.Entity_Dimension_index = oEntity_share_data.ENTITY_DIMENSION_INDEX;
            oEntity_share_view_data.List_Entity_Level_Dimension_with_Status = oEntity_share_data.LIST_ENTITY_LEVEL_DIMENSION_WITH_STATUS;
            oEntity_share_view_data.IS_ENTITY_SUMMARY_DRAWER_VISIBLE = oEntity_share_data.IS_ENTITY_SUMMARY_DRAWER_VISIBLE;
            oEntity_share_view_data.List_Summary_Space_asset = new List<Space_asset>();
            oEntity_share_view_data.List_Wifi_signal_alert = new List<Wifi_signal_alert>();

            var get_setup_categories = Task.Run(() =>
            {
                oEntity_share_view_data.List_Setup_category = Props.Copy_Prop_Values_From_Api_Response<List<Setup_category>>(
                    this._service_mesh.Get_Setup_category_By_OWNER_ID(new Service_Mesh.Params_Get_Setup_category_By_OWNER_ID()
                    {
                        OWNER_ID = this.oBLC_Initializer.Owner_ID,
                    }).i_Result
                );
            });

            var get_entity = Task.Run(() =>
            {
                oEntity_share_view_data.Entity = Props.Copy_Prop_Values_From_Api_Response<Entity>(
                    this._service_mesh.Get_Entity_By_ENTITY_ID_Adv(new Service_Mesh.Params_Get_Entity_By_ENTITY_ID()
                    {
                        ENTITY_ID = oEntity_share_data.ENTITY_ID
                    }).i_Result
                );
            });

            var get_kpi_chart_configurations = Task.Run(() =>
            {
                oEntity_share_view_data.List_Kpi_chart_configuration = Props.Copy_Prop_Values_From_Api_Response<List<Kpi_chart_configuration>>(
                   this._service_mesh.Get_Kpi_chart_configuration().i_Result
                );
            });

            Task.WaitAll(get_setup_categories, get_entity, get_kpi_chart_configurations);

            List<Floor> oList_Floor = new List<Floor>();
            var get_floors = Task.Run(() =>
            {
                oList_Floor = Props.Copy_Prop_Values_From_Api_Response<List<Floor>>(
                    this._service_mesh.Get_Floor_By_ENTITY_ID_With_Space_Asset(new Service_Mesh.Params_Get_Floor_By_ENTITY_ID_With_Space_Asset()
                    {
                        ENTITY_ID = oEntity_share_data.ENTITY_ID
                    }).i_Result
                );
            });

            var get_dimension_chart_configurations = Task.Run(() =>
            {
                oEntity_share_view_data.List_Dimension_chart_configuration = Props.Copy_Prop_Values_From_Api_Response<List<Dimension_chart_configuration>>(
                   this._service_mesh.Get_Dimension_chart_configuration().i_Result
                );
            });

            Service_Mesh.User_Accessible_Data_With_Level_List oUser_Accessible_Data_With_Level_List = new Service_Mesh.User_Accessible_Data_With_Level_List();
            var get_user_acceissible_data_with_level_list_and_floor_data = Task.Run(() =>
            {
                oUser_Accessible_Data_With_Level_List = this._service_mesh.Get_User_Accessible_Data_With_Level_List(new Service_Mesh.Params_Get_User_Accessible_Data_With_Level_List()
                {
                    DATA_LEVEL_SETUP_ID = oEntity_share_view_data.List_Setup_category.Find(setup_category => setup_category.SETUP_CATEGORY_NAME == "Data Level").List_Setup.Find(setup => setup.VALUE == "Entity").SETUP_ID,
                    SELECTED_LEVEL_ID = oEntity_share_view_data.Entity.ENTITY_ID,
                    END_DATE = oEntity_share_view_data.FILTER_END_DATE,
                    START_DATE = oEntity_share_view_data.FILTER_START_DATE,
                    TOP_LEVEL_ID = oEntity_share_view_data.Entity.TOP_LEVEL_ID,
                    ENUM_TIMESPAN = (Service_Mesh.Enum_Timespan)oEntity_share_view_data.ENUM_TIMESPAN,
                    CHOSEN_ORGANIZATION_ID = oEntity_share_data.ORGANIZATION_ID
                }).i_Result;

                long? Entity_drawer_Setup_ID = oEntity_share_view_data.List_Setup_category.Find(setup_category => setup_category.SETUP_CATEGORY_NAME == "Frontend Position").List_Setup.Find(setup => setup.VALUE == "Building info").SETUP_ID;
                List<Kpi_chart_configuration> oList_KPI_chart_configuration_Building_Info = oEntity_share_view_data.List_Kpi_chart_configuration.Where(oKpi_chart_configuration => oKpi_chart_configuration.POSITION_SETUP_ID == Entity_drawer_Setup_ID).ToList();
                List<Service_Mesh.Organization_data_source_kpi_Simple> oList_Entity_Organization_data_source_kpi = oUser_Accessible_Data_With_Level_List.USER_ACCESSIBLE_LEVEL_LIST.ORGANIZATION_DATA_SOURCE_KPI_LIST_BY_TOP_LEVEL.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_ENTITY.Find(oOrganization_Data_Source_Kpi_ID => oOrganization_Data_Source_Kpi_ID.LEVEL_ID == oEntity_share_view_data.Entity.ENTITY_ID)?.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE;
                oList_Entity_Organization_data_source_kpi = oList_Entity_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oList_KPI_chart_configuration_Building_Info.Any(oKPI_chart_configuration => oKPI_chart_configuration.KPI_ID == oOrganization_data_source_kpi.KPI_ID)).ToList();

                var get_floor_kpi_data = Task.Run(() =>
                {
                    oEntity_share_view_data.List_Floor_kpi_data = Props.Copy_Prop_Values_From_Api_Response<List<Floor_Kpi_Dialog_Data>>(
                        this._service_mesh.Get_Floor_Kpi_Dialog_Data(new Service_Mesh.Params_Get_Floor_Kpi_Dialog_Data()
                        {
                            DIMENSION_ID = oEntity_share_view_data.DIMENSION_ID,
                            END_DATE = oEntity_share_view_data.FILTER_END_DATE,
                            START_DATE = oEntity_share_view_data.FILTER_START_DATE,
                            ENUM_TIMESPAN = (Service_Mesh.Enum_Timespan)oEntity_share_view_data.ENUM_TIMESPAN,
                            FLOOR_ID = oEntity_share_view_data.FLOOR_ID,
                            LIST_ENTITY_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID = oList_Entity_Organization_data_source_kpi.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList(),
                            SITE_ID = oEntity_share_view_data.Entity.SITE_ID,
                        }).i_Result
                    );
                });

                var get_entity_kpi_data = Task.Run(() =>
                {
                    if (oEntity_share_data.IS_ENTITY_SUMMARY_DRAWER_VISIBLE == true)
                    {
                        oEntity_share_view_data.List_Entity_kpi_data = Props.Copy_Prop_Values_From_Api_Response<List<Entity_Kpi_Dialog_Data>>(
                            this._service_mesh.Get_Entity_Kpi_Dialog_Data(new Service_Mesh.Params_Get_Entity_Kpi_Dialog_Data()
                            {
                                DIMENSION_ID = oEntity_share_view_data.DIMENSION_ID,
                                END_DATE = oEntity_share_view_data.FILTER_END_DATE,
                                START_DATE = oEntity_share_view_data.FILTER_START_DATE,
                                ENUM_TIMESPAN = (Service_Mesh.Enum_Timespan)oEntity_share_view_data.ENUM_TIMESPAN,
                                ENTITY_ID = oEntity_share_view_data.Entity.ENTITY_ID,
                                LIST_ENTITY_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID = oList_Entity_Organization_data_source_kpi.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID).ToList(),
                            }).i_Result
                        );
                    }
                });

                Task.WaitAll(get_floor_kpi_data, get_entity_kpi_data);
            });

            var get_alerts = Task.Run(() =>
            {
                if (oEntity_share_view_data.IS_ALERT)
                {
                    oEntity_share_view_data.List_Incident = Props.Copy_Prop_Values_From_Api_Response<List<Incident>>(
                        this._service_mesh.Get_Incidents_By_Where(new Service_Mesh.Params_Get_Incidents_By_Where()
                        {
                            INCIDENT_ID_LIST = oEntity_share_data.LIST_INCIDENT_ID
                        }).i_Result
                    );
                }
            });

            var get_space_assets = Task.Run(() =>
            {
                if (oEntity_share_data.LIST_SUMMARY_SPACE_ASSET_ID != null && oEntity_share_data.LIST_SUMMARY_SPACE_ASSET_ID.Count > 0)
                {
                    oEntity_share_view_data.List_Summary_Space_asset = Props.Copy_Prop_Values_From_Api_Response<List<Space_asset>>(
                        this._service_mesh.Get_Space_asset_By_SPACE_ASSET_ID_List_Adv(new Service_Mesh.Params_Get_Space_asset_By_SPACE_ASSET_ID_List()
                        {
                            SPACE_ASSET_ID_LIST = oEntity_share_data.LIST_SUMMARY_SPACE_ASSET_ID
                        }).i_Result
                    );
                }
            });

            var get_wifi_signal_alerts = Task.Run(() =>
            {
                if (oEntity_share_data.LIST_WIFI_SIGNAL_ALERT_ID != null && oEntity_share_data.LIST_WIFI_SIGNAL_ALERT_ID.Count > 0)
                {
                    oEntity_share_view_data.List_Wifi_signal_alert = Props.Copy_Prop_Values_From_Api_Response<List<Wifi_signal_alert>>(
                        this._service_mesh.Get_Wifi_signal_alerts(new Service_Mesh.Params_Get_Wifi_signal_alerts()
                        {
                            WIFI_SIGNAL_ALERT_ID_LIST = oEntity_share_data.LIST_WIFI_SIGNAL_ALERT_ID
                        }).i_Result
                    );
                }
            });

            Task.WaitAll(get_alerts, get_dimension_chart_configurations, get_floors, get_user_acceissible_data_with_level_list_and_floor_data, get_space_assets, get_wifi_signal_alerts);

            oEntity_share_view_data.Entity.List_Floor = oList_Floor;

            return oEntity_share_view_data;
        }
        #endregion
    }
}