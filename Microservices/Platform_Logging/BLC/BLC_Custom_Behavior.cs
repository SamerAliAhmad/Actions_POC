using System.Threading.Tasks;
using System;
using System.Linq;
using SmartrTools;
using OfficeOpenXml;
using System.Drawing;
using OfficeOpenXml.Style;
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
        #region Create_Log
        public void Create_Log(Params_Create_Log i_Params_Create_Log)
        {
            Service_Mesh.User oUser = this._service_mesh.Get_User_By_USER_ID(new Service_Mesh.Params_Get_User_By_USER_ID
            {
                USER_ID = this.oBLC_Initializer.User_ID
            }).i_Result;

            if (oUser != null)
            {
                List<Service_Mesh.Organization_log_config> oList_Organization_log_config = this._service_mesh.Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID(new Service_Mesh.Params_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID()
                {
                    LOG_TYPE_SETUP_ID = Get_Setup_By_SETUP_ID(new Params_Get_Setup_By_SETUP_ID()
                    {
                        SETUP_ID = i_Params_Create_Log.LOG_TYPE_SETUP_ID
                    }).SETUP_ID,
                    ORGANIZATION_ID = oUser.ORGANIZATION_ID
                }).i_Result;

                if (oList_Organization_log_config != null && oList_Organization_log_config.Count > 0)
                {
                    Edit_Log_List(new Params_Edit_Log_List()
                    {
                        LOG_LIST = new List<Log>()
                        {
                            new Log()
                            {
                                LOG_ID = null,
                                ENTRY_DATE = DateTime.Now,
                                SITE_ID = i_Params_Create_Log.SITE_ID,
                                MESSAGE = i_Params_Create_Log.MESSAGE,
                                USER_ID = this.oBLC_Initializer.User_ID,
                                ENTITY_ID = i_Params_Create_Log.ENTITY_ID,
                                ORGANIZATION_ID = oUser.ORGANIZATION_ID,
                                VIDEO_AI_ASSET_ID = i_Params_Create_Log.VIDEO_AI_ASSET_ID,
                                LOG_TYPE_SETUP_ID = i_Params_Create_Log.LOG_TYPE_SETUP_ID,
                                ACCESS_TYPE_SETUP_ID = i_Params_Create_Log.ACCESS_TYPE_SETUP_ID
                            }
                        }
                    });
                }
            }
        }
        #endregion
        #region Delete_Log
        public void Delete_Log()
        {
            this._MongoDb.Delete_Log();
        }
        #endregion
        #region Edit_Log_List
        public void Edit_Log_List(Params_Edit_Log_List i_Params_Edit_Log_List)
        {
            this._MongoDb.Edit_Log_List(i_Params_Edit_Log_List.LOG_LIST.Select(incident =>
            {
                DALC.Log oLog = Props.Copy_Prop_Values_From_Api_Response<DALC.Log>(incident);
                if (oLog.ENTRY_DATE != null)
                {
                    DateTime oDateTime = (DateTime)oLog.ENTRY_DATE;
                    oLog.ENTRY_DATE = new DateTime(oDateTime.Year, oDateTime.Month, oDateTime.Day, oDateTime.Hour, oDateTime.Minute, oDateTime.Second, DateTimeKind.Utc);
                }
                return oLog;
            }).ToList());
        }
        #endregion
        #region Get_Logs_By_Where
        public List<Log> Get_Logs_By_Where(Params_Get_Logs_By_Where i_Params_Get_Logs_By_Where)
        {
            return Props.Copy_Prop_Values_From_Api_Response<List<Log>>
            (
                this._MongoDb.Get_Logs_By_Where
                (
                    LOG_ID_LIST: i_Params_Get_Logs_By_Where.LOG_ID_LIST,
                    USER_ID_LIST: i_Params_Get_Logs_By_Where.USER_ID_LIST,
                    SITE_ID_LIST: i_Params_Get_Logs_By_Where.SITE_ID_LIST,
                    MESSAGE_LIST: i_Params_Get_Logs_By_Where.MESSAGE_LIST,
                    ENTRY_DATE_END: i_Params_Get_Logs_By_Where.ENTRY_DATE_END,
                    ENTITY_ID_LIST: i_Params_Get_Logs_By_Where.ENTITY_ID_LIST,
                    ENTRY_DATE_START: i_Params_Get_Logs_By_Where.ENTRY_DATE_START,
                    ORGANIZATION_ID_LIST: i_Params_Get_Logs_By_Where.ORGANIZATION_ID_LIST,
                    VIDEO_AI_ASSET_ID_LIST: i_Params_Get_Logs_By_Where.VIDEO_AI_ASSET_ID_LIST,
                    LOG_TYPE_SETUP_ID_LIST: i_Params_Get_Logs_By_Where.LOG_TYPE_SETUP_ID_LIST,
                    ACCESS_TYPE_SETUP_ID_LIST: i_Params_Get_Logs_By_Where.ACCESS_TYPE_SETUP_ID_LIST
                )
            );
        }
        #endregion
        #region Generate_Logs_Excel
        public Generate_Logs_Excel_Response Generate_Logs_Excel(Params_Generate_Logs_Excel i_Params_Generate_Logs_Excel)
        {
            List<User> oList_User = new List<User>();
            List<Site> oList_Site = new List<Site>();
            List<Entity> oList_Entity = new List<Entity>();
            List<Video_ai_asset> oList_Video_ai_asset = new List<Video_ai_asset>();

            Log_With_Count oLog_With_Count = Get_Logs_With_Filters(new Params_Get_Logs_With_Filters()
            {
                START_ROW = 0,
                END_ROW = 1000000,
                END_DATE = i_Params_Generate_Logs_Excel.END_DATE,
                START_DATE = i_Params_Generate_Logs_Excel.START_DATE,
                USER_ID_LIST = i_Params_Generate_Logs_Excel.USER_ID_LIST,
                SITE_ID_LIST = i_Params_Generate_Logs_Excel.SITE_ID_LIST,
                ENTITY_ID_LIST = i_Params_Generate_Logs_Excel.ENTITY_ID_LIST,
                ORGANIZATION_ID_LIST = i_Params_Generate_Logs_Excel.ORGANIZATION_ID_LIST,
                VIDEO_AI_ASSET_ID_LIST = i_Params_Generate_Logs_Excel.VIDEO_AI_ASSET_ID_LIST,
                LOG_TYPE_SETUP_ID_LIST = i_Params_Generate_Logs_Excel.LOG_TYPE_SETUP_ID_LIST,
                ACCESS_TYPE_SETUP_ID_LIST = i_Params_Generate_Logs_Excel.ACCESS_TYPE_SETUP_ID_LIST
            });

            var get_users = Task.Run(() =>
            {
                oList_User = Props.Copy_Prop_Values_From_Api_Response<List<User>>(
                    this._service_mesh.Get_User_By_USER_ID_List(new Service_Mesh.Params_Get_User_By_USER_ID_List()
                    {
                        USER_ID_LIST = oLog_With_Count.List_Log.Select(log => log.USER_ID).Distinct().ToList()
                    }).i_Result
                );
            });
            List<long?> oList_Site_ID = oLog_With_Count.List_Log.Where(log => log.SITE_ID != null).Select(log => log.SITE_ID).Distinct().ToList();
            var get_sites = Task.Run(() =>
            {
                if (oList_Site_ID != null && oList_Site_ID.Count > 0)
                {
                    oList_Site = Props.Copy_Prop_Values_From_Api_Response<List<Site>>(
                        this._service_mesh.Get_Site_By_SITE_ID_List(new Service_Mesh.Params_Get_Site_By_SITE_ID_List()
                        {
                            SITE_ID_LIST = oList_Site_ID
                        }).i_Result
                    );
                }
            });
            List<long?> oList_Entity_ID = oLog_With_Count.List_Log.Where(log => log.ENTITY_ID != null).Select(log => log.ENTITY_ID).Distinct().ToList();
            var get_entities = Task.Run(() =>
            {
                if (oList_Entity_ID != null && oList_Entity_ID.Count > 0)
                {
                    oList_Entity = Props.Copy_Prop_Values_From_Api_Response<List<Entity>>(
                        this._service_mesh.Get_Entity_By_ENTITY_ID_List(new Service_Mesh.Params_Get_Entity_By_ENTITY_ID_List()
                        {
                            ENTITY_ID_LIST = oList_Entity_ID
                        }).i_Result
                    );
                }
            });
            var get_video_ai_assets = Task.Run(() =>
            {
                oList_Video_ai_asset = Props.Copy_Prop_Values_From_Api_Response<List<Video_ai_asset>>(
                    this._service_mesh.Get_Video_ai_asset_By_OWNER_ID(new Service_Mesh.Params_Get_Video_ai_asset_By_OWNER_ID()
                    {
                        OWNER_ID = this.oBLC_Initializer.Owner_ID
                    }).i_Result
                );
            });

            Task.WaitAll(get_users, get_sites, get_video_ai_assets);

            List<Setup> oList_Access_Type_Setup = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
            {
                SETUP_CATEGORY_NAME = "Access Type",
            }).List_Setup;

            List<Setup> oList_Log_Type_Setup = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
            {
                SETUP_CATEGORY_NAME = "Log Type",
            }).List_Setup;

            string timeNow = DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss");
            string Object_Name = $"{Global.Assets_Excel_Report_Path}/Log_Report_{timeNow}.xlsx";

            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            using (var excel = new ExcelPackage())
            {
                var workbook = excel.Workbook;
                var worksheet = workbook.Worksheets.Add("Logs");

                int currentRow = 1;
                worksheet.Cells[currentRow, 1].Value = "Log Time";
                worksheet.Cells[currentRow, 2].Value = "Log Date";
                worksheet.Cells[currentRow, 3].Value = "User Name";
                worksheet.Cells[currentRow, 4].Value = "Message";
                worksheet.Cells[currentRow, 5].Value = "Site";
                worksheet.Cells[currentRow, 6].Value = "Entity";
                worksheet.Cells[currentRow, 7].Value = "Video AI Asset";
                worksheet.Cells[currentRow, 8].Value = "Log Type";
                worksheet.Cells[currentRow, 9].Value = "Access Type";
                worksheet.Row(currentRow).Style.Font.Bold = true;
                worksheet.Cells[1, 1, 1, 9].Style.Fill.PatternType = ExcelFillStyle.Solid;
                worksheet.Cells[1, 1, 1, 9].Style.Fill.BackgroundColor.SetColor(Color.LightGray);

                foreach (Log iLog in oLog_With_Count.List_Log)
                {
                    iLog.User = oList_User.FirstOrDefault(user => user.USER_ID == iLog.USER_ID);
                    iLog.Site = oList_Site.FirstOrDefault(site => site.SITE_ID == iLog.SITE_ID);
                    iLog.Entity = oList_Entity.FirstOrDefault(entity => entity.ENTITY_ID == iLog.ENTITY_ID);
                    iLog.Video_ai_asset = oList_Video_ai_asset.FirstOrDefault(video_ai_asset => video_ai_asset.VIDEO_AI_ASSET_ID == iLog.VIDEO_AI_ASSET_ID);

                    currentRow++;
                    worksheet.Cells[currentRow, 1].Value = Tools.GetDateTimeString((DateTime)iLog.ENTRY_DATE).Split('T')[1];
                    worksheet.Cells[currentRow, 2].Value = Tools.GetDateTimeString((DateTime)iLog.ENTRY_DATE).Split('T')[0];
                    if (iLog.User != null && iLog.User != default)
                    {
                        worksheet.Cells[currentRow, 3].Value = iLog.User.FIRST_NAME + " " + iLog.User.LAST_NAME;
                        worksheet.Cells[currentRow, 3].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    }
                    else
                    {
                        worksheet.Cells[currentRow, 3].Value = "-";
                    }
                    worksheet.Cells[currentRow, 4].Value = iLog.MESSAGE;
                    if (iLog.Site != null && iLog.Site != default)
                    {
                        worksheet.Cells[currentRow, 5].Value = iLog.Site.NAME;
                    }
                    else
                    {
                        worksheet.Cells[currentRow, 5].Value = "-";
                        worksheet.Cells[currentRow, 5].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    }
                    if (iLog.Entity != null && iLog.Entity != default)
                    {
                        worksheet.Cells[currentRow, 6].Value = iLog.Entity.NAME;
                    }
                    else
                    {
                        worksheet.Cells[currentRow, 6].Value = "-";
                        worksheet.Cells[currentRow, 6].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    }
                    if (iLog.Video_ai_asset != null && iLog.Video_ai_asset != default)
                    {
                        worksheet.Cells[currentRow, 7].Value = iLog.Video_ai_asset.FRIENDLY_NAME;
                    }
                    else
                    {
                        worksheet.Cells[currentRow, 7].Value = "-";
                        worksheet.Cells[currentRow, 7].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    }
                    worksheet.Cells[currentRow, 8].Value = oList_Log_Type_Setup.Find(logType => logType.SETUP_ID == iLog.LOG_TYPE_SETUP_ID)?.VALUE;
                    worksheet.Cells[currentRow, 9].Value = oList_Access_Type_Setup.Find(accessType => accessType.SETUP_ID == iLog.ACCESS_TYPE_SETUP_ID)?.VALUE;
                    switch (oList_Access_Type_Setup.Find(accessType => accessType.SETUP_ID == iLog.ACCESS_TYPE_SETUP_ID)?.VALUE)
                    {
                        case "Access":
                            worksheet.Cells[currentRow, 9].Style.Font.Color.SetColor(Color.Green);
                            break;
                        case "Exit":
                            worksheet.Cells[currentRow, 9].Style.Font.Color.SetColor(Color.Red);
                            break;
                    }
                }
                currentRow += 2;
                worksheet.Cells[currentRow, 1].Value = "Total Number of Logs";
                worksheet.Cells[currentRow, 2].Value = oLog_With_Count.COUNT;
                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                try
                {
                    var byteArray = excel.GetAsByteArray();
                    //this._service_mesh.Upload_Object(new Service_Mesh.Params_Upload_Object()
                    //{
                    //    Data = byteArray,
                    //    Object_Name = Object_Name,
                    //});
                }
                catch
                {
                    throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0026)); // Upload Failed.
                }

                excel.Dispose();

            }

            return new Generate_Logs_Excel_Response()
            {
                REPORT_NAME = $"Log_Report_{timeNow}.xlsx",
                EXCEL_URL = $"{Global.Assets_Endpoint}/{Object_Name}"
            };
        }
        #endregion
        #region Get_Logs_With_Filters
        public Log_With_Count Get_Logs_With_Filters(Params_Get_Logs_With_Filters i_Params_Get_Logs_With_Filters)
        {
            return Get_Logs_By_Where_Sorted_With_Pagination(new Params_Get_Logs_By_Where_Sorted_With_Pagination()
            {
                END_ROW = i_Params_Get_Logs_With_Filters.END_ROW,
                START_ROW = i_Params_Get_Logs_With_Filters.START_ROW,
                ENTRY_DATE_END = i_Params_Get_Logs_With_Filters.END_DATE,
                USER_ID_LIST = i_Params_Get_Logs_With_Filters.USER_ID_LIST,
                SITE_ID_LIST = i_Params_Get_Logs_With_Filters.SITE_ID_LIST,
                ENTRY_DATE_START = i_Params_Get_Logs_With_Filters.START_DATE,
                ENTITY_ID_LIST = i_Params_Get_Logs_With_Filters.ENTITY_ID_LIST,
                ORGANIZATION_ID_LIST = i_Params_Get_Logs_With_Filters.ORGANIZATION_ID_LIST,
                VIDEO_AI_ASSET_ID_LIST = i_Params_Get_Logs_With_Filters.VIDEO_AI_ASSET_ID_LIST,
                LOG_TYPE_SETUP_ID_LIST = i_Params_Get_Logs_With_Filters.LOG_TYPE_SETUP_ID_LIST,
                ACCESS_TYPE_SETUP_ID_LIST = i_Params_Get_Logs_With_Filters.ACCESS_TYPE_SETUP_ID_LIST
            });
        }
        #endregion
        #region Get_Logs_By_Where_Sorted_With_Pagination
        public Log_With_Count Get_Logs_By_Where_Sorted_With_Pagination(Params_Get_Logs_By_Where_Sorted_With_Pagination i_Params_Get_Logs_By_Where_Sorted_With_Pagination)
        {
            return Props.Copy_Prop_Values_From_Api_Response<Log_With_Count>
            (
                this._MongoDb.Get_Logs_By_Where_Sorted_With_Pagination
                (
                    END_ROW: i_Params_Get_Logs_By_Where_Sorted_With_Pagination.END_ROW,
                    START_ROW: i_Params_Get_Logs_By_Where_Sorted_With_Pagination.START_ROW,
                    LOG_ID_LIST: i_Params_Get_Logs_By_Where_Sorted_With_Pagination.LOG_ID_LIST,
                    SITE_ID_LIST: i_Params_Get_Logs_By_Where_Sorted_With_Pagination.SITE_ID_LIST,
                    MESSAGE_LIST: i_Params_Get_Logs_By_Where_Sorted_With_Pagination.MESSAGE_LIST,
                    USER_ID_LIST: i_Params_Get_Logs_By_Where_Sorted_With_Pagination.USER_ID_LIST,
                    ENTITY_ID_LIST: i_Params_Get_Logs_By_Where_Sorted_With_Pagination.ENTITY_ID_LIST,
                    ENTRY_DATE_END: i_Params_Get_Logs_By_Where_Sorted_With_Pagination.ENTRY_DATE_END,
                    ENTRY_DATE_START: i_Params_Get_Logs_By_Where_Sorted_With_Pagination.ENTRY_DATE_START,
                    ORGANIZATION_ID_LIST: i_Params_Get_Logs_By_Where_Sorted_With_Pagination.ORGANIZATION_ID_LIST,
                    VIDEO_AI_ASSET_ID_LIST: i_Params_Get_Logs_By_Where_Sorted_With_Pagination.VIDEO_AI_ASSET_ID_LIST,
                    LOG_TYPE_SETUP_ID_LIST: i_Params_Get_Logs_By_Where_Sorted_With_Pagination.LOG_TYPE_SETUP_ID_LIST,
                    ACCESS_TYPE_SETUP_ID_LIST: i_Params_Get_Logs_By_Where_Sorted_With_Pagination.ACCESS_TYPE_SETUP_ID_LIST
                )
            );
        }
        #endregion
    }
}