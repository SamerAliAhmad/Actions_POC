using System;
using SmartrCron;
using SmartrTools;
using System.Linq;
using System.Threading;
using System.Configuration;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Data_Creation_Cron
{
    public class Worker : IHostedService
    {
        private readonly ILogger<Worker> _logger;
        private readonly string _schedulingMethod;
        private readonly string _currentCronSchedule;
        private readonly IHostApplicationLifetime _appLifetime;
        private static readonly CronDaemon cron_daemon = new CronDaemon();

        public Worker(ILogger<Worker> logger, IHostApplicationLifetime appLifetime)
        {
            _logger = logger;
            _appLifetime = appLifetime;
            _schedulingMethod = ConfigurationManager.AppSettings["SCHEDULING_METHOD"];
            _currentCronSchedule = Environment.GetEnvironmentVariable("CURRENT_CRON_SCHEDULE");
        }

        public void Get_Meraki_Api_Data()
        {
            #region Setup

            bool isSendEmailOnCronException = ConfigurationManager.AppSettings["IS_SEND_EMAIL_ON_CRON_EXCEPTION"] == "1";
            Service_Mesh.Proxy oService_Mesh = new Service_Mesh.Proxy();
            oService_Mesh.BaseURL = ConfigurationManager.AppSettings["API_GATEWAY_URL"];
            oService_Mesh.Ticket = Crypto.Encrypt(string.Format(Tools.Get_Unique_String() + "[~!@]USERNAME:{0}[~!@]" + Tools.Get_Unique_String() + "[~!@]OWNER_ID:{1}[~!@]" + Tools.Get_Unique_String() + "[~!@]USER_ID:{2}[~!@]" + Tools.Get_Unique_String() + "[~!@]START_DATE:{3}[~!@]" + Tools.Get_Unique_String() + "[~!@]SESSION_PERIOD:{4}[~!@]", "jony.daxd@gmail.com", 1, 1, Tools.GetDateTimeString(DateTime.Now), 1440));

            List<Service_Mesh.Setup> oList_Level_setup = oService_Mesh.Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Service_Mesh.Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
            {
                SETUP_CATEGORY_NAME = "Data Level",
                OWNER_ID = 1
            }).i_Result.List_Setup;

            List<Service_Mesh.Organization_data_source_kpi> oList_All_Organization_data_source_kpi = oService_Mesh.Get_Organization_data_source_kpi_By_OWNER_ID_Adv(new Service_Mesh.Params_Get_Organization_data_source_kpi_By_OWNER_ID()
            {
                OWNER_ID = 1
            }).i_Result
            .OrderBy(oOrganization_data_source_kpi => DateTime.Parse(oOrganization_data_source_kpi.Kpi.LATEST_DATA_CREATION_DATE))
            .Select(oOrganization_data_source_kpi =>
            {
                oOrganization_data_source_kpi.Kpi.Min_data_level_setup = oList_Level_setup.Find(setup => setup.SETUP_ID == oOrganization_data_source_kpi.Kpi.MIN_DATA_LEVEL_SETUP_ID);
                oOrganization_data_source_kpi.Kpi.Max_data_level_setup = oList_Level_setup.Find(setup => setup.SETUP_ID == oOrganization_data_source_kpi.Kpi.MAX_DATA_LEVEL_SETUP_ID);
                return oOrganization_data_source_kpi;
            }).ToList();
            List<Service_Mesh.Organization_data_source_kpi> oList_Organization_data_source_kpi = oList_All_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.NAME == "Wifi Signal").ToList();

            DateTime now = DateTime.Now;
            DateTime firstDate = DateTime.Parse(oList_Organization_data_source_kpi.FirstOrDefault().Kpi.LATEST_DATA_CREATION_DATE).AddHours(1);
            _logger.LogInformation("Data Creation Worker started at: {time}", DateTimeOffset.Now);

            #endregion

            while (firstDate <= now)
            {
                List<Service_Mesh.Organization_data_source_kpi> oList_Current_Organization_data_source_kpi = oList_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => DateTime.Parse(oOrganization_data_source_kpi.Kpi.LATEST_DATA_CREATION_DATE) < firstDate).ToList();

                #region Generate Hourly Data

                try
                {
                    _logger.LogInformation("Compute_Wifi_Signal_Space_Kpi_Data_Hourly started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                    var space_hourly_indexes = oService_Mesh.Compute_Wifi_Signal_Space_Kpi_Data_Hourly(new Service_Mesh.Params_Compute_Wifi_Signal_Space_Kpi_Data_Hourly()
                    {
                        DAY = firstDate.Day,
                        YEAR = firstDate.Year,
                        MONTH = firstDate.Month,
                        HOUR = firstDate.Hour,
                        LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Current_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.Min_data_level_setup.DISPLAY_ORDER <= 0 && oOrganization_data_source_kpi.Kpi.Max_data_level_setup.DISPLAY_ORDER >= 0).ToList(),

                    });
                    _logger.LogInformation("Compute_Wifi_Signal_Space_Kpi_Data_Hourly Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, space_hourly_indexes.Exception_Message, space_hourly_indexes.Stack_Trace);
                }
                catch (Exception ex)
                {
                    _logger.LogInformation("Compute_Wifi_Signal_Space_Kpi_Data_Hourly exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                    if (isSendEmailOnCronException)
                    {
                        oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                        {
                            TITLE = "Compute_Wifi_Signal_Space_Kpi_Data_Hourly exception: " + ex.Message,
                            MESSAGE = ex.StackTrace
                        });
                    }
                }
                try
                {
                    _logger.LogInformation("Generate_Or_Compute_Floor_Hourly_Data started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                    var floor_hourly_indexes = oService_Mesh.Generate_Or_Compute_Floor_Hourly_Data(new Service_Mesh.Params_Generate_Or_Compute_Floor_Hourly_Data()
                    {
                        DAY = firstDate.Day,
                        HOUR = firstDate.Hour,
                        YEAR = firstDate.Year,
                        MONTH = firstDate.Month,
                        LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Current_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.Min_data_level_setup.DISPLAY_ORDER <= 1 && oOrganization_data_source_kpi.Kpi.Max_data_level_setup.DISPLAY_ORDER >= 1).ToList(),
                    });
                    _logger.LogInformation("Generate_Or_Compute_Floor_Hourly_Data Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, floor_hourly_indexes.Exception_Message, floor_hourly_indexes.Stack_Trace);
                }
                catch (Exception ex)
                {
                    _logger.LogInformation("Generate_Or_Compute_Floor_Hourly_Data exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                    if (isSendEmailOnCronException)
                    {
                        oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                        {
                            TITLE = "Generate_Or_Compute_Floor_Hourly_Data exception: " + ex.Message,
                            MESSAGE = ex.StackTrace
                        });
                    }
                }
                try
                {
                    _logger.LogInformation("Generate_Or_Compute_Entity_Hourly_Data started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                    var entity_hourly_indexes = oService_Mesh.Generate_Or_Compute_Entity_Hourly_Data(new Service_Mesh.Params_Generate_Or_Compute_Entity_Hourly_Data()
                    {
                        DAY = firstDate.Day,
                        HOUR = firstDate.Hour,
                        YEAR = firstDate.Year,
                        MONTH = firstDate.Month,
                        LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Current_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.Min_data_level_setup.DISPLAY_ORDER <= 2 && oOrganization_data_source_kpi.Kpi.Max_data_level_setup.DISPLAY_ORDER >= 2).ToList(),
                    });
                    _logger.LogInformation("Generate_Or_Compute_Entity_Hourly_Data Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, entity_hourly_indexes.Exception_Message, entity_hourly_indexes.Stack_Trace);
                }
                catch (Exception ex)
                {
                    _logger.LogInformation("Generate_Or_Compute_Entity_Hourly_Data exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                    if (isSendEmailOnCronException)
                    {
                        oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                        {
                            TITLE = "Generate_Or_Compute_Entity_Hourly_Data exception: " + ex.Message,
                            MESSAGE = ex.StackTrace
                        });
                    }
                }
                try
                {
                    _logger.LogInformation("Generate_Or_Compute_Site_Hourly_Data started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                    var site_hourly_indexes = oService_Mesh.Generate_Or_Compute_Site_Hourly_Data(new Service_Mesh.Params_Generate_Or_Compute_Site_Hourly_Data()
                    {
                        DAY = firstDate.Day,
                        HOUR = firstDate.Hour,
                        YEAR = firstDate.Year,
                        MONTH = firstDate.Month,
                        LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Current_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.Min_data_level_setup.DISPLAY_ORDER <= 3 && oOrganization_data_source_kpi.Kpi.Max_data_level_setup.DISPLAY_ORDER >= 3).ToList(),
                    });
                    _logger.LogInformation("Generate_Or_Compute_Site_Hourly_Data Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, site_hourly_indexes.Exception_Message, site_hourly_indexes.Stack_Trace);
                }
                catch (Exception ex)
                {
                    _logger.LogInformation("Generate_Or_Compute_Site_Hourly_Data exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                    if (isSendEmailOnCronException)
                    {
                        oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                        {
                            TITLE = "Generate_Or_Compute_Site_Hourly_Data exception: " + ex.Message,
                            MESSAGE = ex.StackTrace
                        });
                    }
                }
                try
                {
                    _logger.LogInformation("Generate_Or_Compute_Area_Hourly_Data started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                    var area_hourly_indexes = oService_Mesh.Generate_Or_Compute_Area_Hourly_Data(new Service_Mesh.Params_Generate_Or_Compute_Area_Hourly_Data()
                    {
                        DAY = firstDate.Day,
                        HOUR = firstDate.Hour,
                        YEAR = firstDate.Year,
                        MONTH = firstDate.Month,
                        LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Current_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.Min_data_level_setup.DISPLAY_ORDER <= 4 && oOrganization_data_source_kpi.Kpi.Max_data_level_setup.DISPLAY_ORDER >= 4).ToList(),
                    });
                    _logger.LogInformation("Generate_Or_Compute_Area_Hourly_Data Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, area_hourly_indexes.Exception_Message, area_hourly_indexes.Stack_Trace);
                }
                catch (Exception ex)
                {
                    _logger.LogInformation("Generate_Or_Compute_Area_Hourly_Data exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                    if (isSendEmailOnCronException)
                    {
                        oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                        {
                            TITLE = "Generate_Or_Compute_Area_Hourly_Data exception: " + ex.Message,
                            MESSAGE = ex.StackTrace
                        });
                    }
                }
                try
                {
                    _logger.LogInformation("Generate_Or_Compute_District_Hourly_Data started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                    var district_hourly_indexes = oService_Mesh.Generate_Or_Compute_District_Hourly_Data(new Service_Mesh.Params_Generate_Or_Compute_District_Hourly_Data()
                    {
                        DAY = firstDate.Day,
                        HOUR = firstDate.Hour,
                        YEAR = firstDate.Year,
                        MONTH = firstDate.Month,
                        LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Current_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.Min_data_level_setup.DISPLAY_ORDER <= 5 && oOrganization_data_source_kpi.Kpi.Max_data_level_setup.DISPLAY_ORDER >= 5).ToList(),
                    });
                    _logger.LogInformation("Generate_Or_Compute_District_Hourly_Data Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, district_hourly_indexes.Exception_Message, district_hourly_indexes.Stack_Trace);
                }
                catch (Exception ex)
                {
                    _logger.LogInformation("Generate_Or_Compute_District_Hourly_Data exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                    if (isSendEmailOnCronException)
                    {
                        oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                        {
                            TITLE = "Generate_Or_Compute_District_Hourly_Data exception: " + ex.Message,
                            MESSAGE = ex.StackTrace
                        });
                    }
                }

                #endregion

                #region Generate Daily Data

                if (firstDate.Hour == 0)
                {

                    try
                    {
                        _logger.LogInformation("Compute_Space_Kpi_Data_Daily started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                        var space_daily_indexes = oService_Mesh.Compute_Space_Kpi_Data_Daily(new Service_Mesh.Params_Compute_Space_Kpi_Data_Daily()
                        {
                            DAY = firstDate.Day,
                            YEAR = firstDate.Year,
                            MONTH = firstDate.Month,
                            LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Current_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.Min_data_level_setup.DISPLAY_ORDER <= 0 && oOrganization_data_source_kpi.Kpi.Max_data_level_setup.DISPLAY_ORDER >= 0).ToList(),

                        });
                        _logger.LogInformation("Compute_Space_Kpi_Data_Daily Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, space_daily_indexes.Exception_Message, space_daily_indexes.Stack_Trace);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogInformation("Compute_Space_Kpi_Data_Daily exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                        if (isSendEmailOnCronException)
                        {
                            oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                            {
                                TITLE = "Compute_Space_Kpi_Data_Daily exception: " + ex.Message,
                                MESSAGE = ex.StackTrace
                            });
                        }
                    }
                    try
                    {
                        _logger.LogInformation("Compute_Floor_Kpi_Data_Daily started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                        var floor_daily_indexes = oService_Mesh.Compute_Floor_Kpi_Data_Daily(new Service_Mesh.Params_Compute_Floor_Kpi_Data_Daily()
                        {
                            DAY = firstDate.Day,
                            YEAR = firstDate.Year,
                            MONTH = firstDate.Month,
                            LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Current_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.Min_data_level_setup.DISPLAY_ORDER <= 1 && oOrganization_data_source_kpi.Kpi.Max_data_level_setup.DISPLAY_ORDER >= 1).ToList(),

                        });
                        _logger.LogInformation("Compute_Floor_Kpi_Data_Daily Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, floor_daily_indexes.Exception_Message, floor_daily_indexes.Stack_Trace);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogInformation("Compute_Floor_Kpi_Data_Daily exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                        if (isSendEmailOnCronException)
                        {
                            oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                            {
                                TITLE = "Compute_Floor_Kpi_Data_Daily exception: " + ex.Message,
                                MESSAGE = ex.StackTrace
                            });
                        }
                    }
                    try
                    {
                        _logger.LogInformation("Compute_Entity_Kpi_Data_Daily started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                        var entity_daily_indexes = oService_Mesh.Compute_Entity_Kpi_Data_Daily(new Service_Mesh.Params_Compute_Entity_Kpi_Data_Daily()
                        {
                            DAY = firstDate.Day,
                            YEAR = firstDate.Year,
                            MONTH = firstDate.Month,
                            LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Current_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.Min_data_level_setup.DISPLAY_ORDER <= 2 && oOrganization_data_source_kpi.Kpi.Max_data_level_setup.DISPLAY_ORDER >= 2).ToList(),

                        });
                        _logger.LogInformation("Compute_Entity_Kpi_Data_Daily Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, entity_daily_indexes.Exception_Message, entity_daily_indexes.Stack_Trace);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogInformation("Compute_Entity_Kpi_Data_Daily exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                        if (isSendEmailOnCronException)
                        {
                            oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                            {
                                TITLE = "Compute_Entity_Kpi_Data_Daily exception: " + ex.Message,
                                MESSAGE = ex.StackTrace
                            });
                        }
                    }
                    try
                    {
                        _logger.LogInformation("Compute_Site_Kpi_Data_Daily started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                        var site_daily_indexes = oService_Mesh.Compute_Site_Kpi_Data_Daily(new Service_Mesh.Params_Compute_Site_Kpi_Data_Daily()
                        {
                            DAY = firstDate.Day,
                            YEAR = firstDate.Year,
                            MONTH = firstDate.Month,
                            LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Current_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.Min_data_level_setup.DISPLAY_ORDER <= 3 && oOrganization_data_source_kpi.Kpi.Max_data_level_setup.DISPLAY_ORDER >= 3).ToList(),

                        });
                        _logger.LogInformation("Compute_Site_Kpi_Data_Daily Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, site_daily_indexes.Exception_Message, site_daily_indexes.Stack_Trace);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogInformation("Compute_Site_Kpi_Data_Daily exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                        if (isSendEmailOnCronException)
                        {
                            oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                            {
                                TITLE = "Compute_Site_Kpi_Data_Daily exception: " + ex.Message,
                                MESSAGE = ex.StackTrace
                            });
                        }
                    }
                    try
                    {
                        _logger.LogInformation("Compute_Area_Kpi_Data_Daily started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                        var area_daily_indexes = oService_Mesh.Compute_Area_Kpi_Data_Daily(new Service_Mesh.Params_Compute_Area_Kpi_Data_Daily()
                        {
                            DAY = firstDate.Day,
                            YEAR = firstDate.Year,
                            MONTH = firstDate.Month,
                            LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Current_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.Min_data_level_setup.DISPLAY_ORDER <= 4 && oOrganization_data_source_kpi.Kpi.Max_data_level_setup.DISPLAY_ORDER >= 4).ToList(),

                        });
                        _logger.LogInformation("Compute_Area_Kpi_Data_Daily Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, area_daily_indexes.Exception_Message, area_daily_indexes.Stack_Trace);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogInformation("Compute_Area_Kpi_Data_Daily exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                        if (isSendEmailOnCronException)
                        {
                            oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                            {
                                TITLE = "Compute_Area_Kpi_Data_Daily exception: " + ex.Message,
                                MESSAGE = ex.StackTrace
                            });
                        }
                    }
                    try
                    {
                        _logger.LogInformation("Compute_District_Kpi_Data_Daily started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                        var district_daily_indexes = oService_Mesh.Compute_District_Kpi_Data_Daily(new Service_Mesh.Params_Compute_District_Kpi_Data_Daily()
                        {
                            DAY = firstDate.Day,
                            YEAR = firstDate.Year,
                            MONTH = firstDate.Month,
                            LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Current_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.Min_data_level_setup.DISPLAY_ORDER <= 5 && oOrganization_data_source_kpi.Kpi.Max_data_level_setup.DISPLAY_ORDER >= 5).ToList(),

                        });
                        _logger.LogInformation("Compute_District_Kpi_Data_Daily Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, district_daily_indexes.Exception_Message, district_daily_indexes.Stack_Trace);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogInformation("Compute_District_Kpi_Data_Daily exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                        if (isSendEmailOnCronException)
                        {
                            oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                            {
                                TITLE = "Compute_District_Kpi_Data_Daily exception: " + ex.Message,
                                MESSAGE = ex.StackTrace
                            });
                        }
                    }
                }

                #endregion

                #region Generate Weekly Data

                if (firstDate.DayOfWeek == DayOfWeek.Monday && firstDate.Hour == 0)
                {
                    try
                    {
                        _logger.LogInformation("Compute_Space_Kpi_Data_Weekly started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                        var space_weekly_indexes = oService_Mesh.Compute_Space_Kpi_Data_Weekly(new Service_Mesh.Params_Compute_Space_Kpi_Data_Weekly()
                        {
                            DAY = firstDate.Day,
                            YEAR = firstDate.Year,
                            MONTH = firstDate.Month,
                            LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Current_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.Min_data_level_setup.DISPLAY_ORDER <= 0 && oOrganization_data_source_kpi.Kpi.Max_data_level_setup.DISPLAY_ORDER >= 0).ToList(),

                        });
                        _logger.LogInformation("Compute_Space_Kpi_Data_Weekly Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, space_weekly_indexes.Exception_Message, space_weekly_indexes.Stack_Trace);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogInformation("Compute_Space_Kpi_Data_Weekly exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                        if (isSendEmailOnCronException)
                        {
                            oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                            {
                                TITLE = "Compute_Space_Kpi_Data_Weekly exception: " + ex.Message,
                                MESSAGE = ex.StackTrace
                            });
                        }
                    }
                    try
                    {
                        _logger.LogInformation("Compute_Floor_Kpi_Data_Weekly started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                        var floor_weekly_indexes = oService_Mesh.Compute_Floor_Kpi_Data_Weekly(new Service_Mesh.Params_Compute_Floor_Kpi_Data_Weekly()
                        {
                            DAY = firstDate.Day,
                            YEAR = firstDate.Year,
                            MONTH = firstDate.Month,
                            LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Current_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.Min_data_level_setup.DISPLAY_ORDER <= 1 && oOrganization_data_source_kpi.Kpi.Max_data_level_setup.DISPLAY_ORDER >= 1).ToList(),

                        });
                        _logger.LogInformation("Compute_Floor_Kpi_Data_Weekly Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, floor_weekly_indexes.Exception_Message, floor_weekly_indexes.Stack_Trace);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogInformation("Compute_Floor_Kpi_Data_Weekly exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                        if (isSendEmailOnCronException)
                        {
                            oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                            {
                                TITLE = "Compute_Floor_Kpi_Data_Weekly exception: " + ex.Message,
                                MESSAGE = ex.StackTrace
                            });
                        }
                    }
                    try
                    {
                        _logger.LogInformation("Compute_Entity_Kpi_Data_Weekly started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                        var entity_weekly_indexes = oService_Mesh.Compute_Entity_Kpi_Data_Weekly(new Service_Mesh.Params_Compute_Entity_Kpi_Data_Weekly()
                        {
                            DAY = firstDate.Day,
                            YEAR = firstDate.Year,
                            MONTH = firstDate.Month,
                            LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Current_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.Min_data_level_setup.DISPLAY_ORDER <= 2 && oOrganization_data_source_kpi.Kpi.Max_data_level_setup.DISPLAY_ORDER >= 2).ToList(),

                        });
                        _logger.LogInformation("Compute_Entity_Kpi_Data_Weekly Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, entity_weekly_indexes.Exception_Message, entity_weekly_indexes.Stack_Trace);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogInformation("Compute_Entity_Kpi_Data_Weekly exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                        if (isSendEmailOnCronException)
                        {
                            oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                            {
                                TITLE = "Compute_Entity_Kpi_Data_Weekly exception: " + ex.Message,
                                MESSAGE = ex.StackTrace
                            });
                        }
                    }
                    try
                    {
                        _logger.LogInformation("Compute_Site_Kpi_Data_Weekly started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                        var site_weekly_indexes = oService_Mesh.Compute_Site_Kpi_Data_Weekly(new Service_Mesh.Params_Compute_Site_Kpi_Data_Weekly()
                        {
                            DAY = firstDate.Day,
                            YEAR = firstDate.Year,
                            MONTH = firstDate.Month,
                            LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Current_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.Min_data_level_setup.DISPLAY_ORDER <= 3 && oOrganization_data_source_kpi.Kpi.Max_data_level_setup.DISPLAY_ORDER >= 3).ToList(),

                        });
                        _logger.LogInformation("Compute_Site_Kpi_Data_Weekly Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, site_weekly_indexes.Exception_Message, site_weekly_indexes.Stack_Trace);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogInformation("Compute_Site_Kpi_Data_Weekly exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                        if (isSendEmailOnCronException)
                        {
                            oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                            {
                                TITLE = "Compute_Site_Kpi_Data_Weekly exception: " + ex.Message,
                                MESSAGE = ex.StackTrace
                            });
                        }
                    }
                    try
                    {
                        _logger.LogInformation("Compute_Area_Kpi_Data_Weekly started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                        var area_weekly_indexes = oService_Mesh.Compute_Area_Kpi_Data_Weekly(new Service_Mesh.Params_Compute_Area_Kpi_Data_Weekly()
                        {
                            DAY = firstDate.Day,
                            YEAR = firstDate.Year,
                            MONTH = firstDate.Month,
                            LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Current_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.Min_data_level_setup.DISPLAY_ORDER <= 4 && oOrganization_data_source_kpi.Kpi.Max_data_level_setup.DISPLAY_ORDER >= 4).ToList(),

                        });
                        _logger.LogInformation("Compute_Area_Kpi_Data_Weekly Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, area_weekly_indexes.Exception_Message, area_weekly_indexes.Stack_Trace);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogInformation("Compute_Area_Kpi_Data_Weekly exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                        if (isSendEmailOnCronException)
                        {
                            oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                            {
                                TITLE = "Compute_Area_Kpi_Data_Weekly exception: " + ex.Message,
                                MESSAGE = ex.StackTrace
                            });
                        }
                    }
                    try
                    {
                        _logger.LogInformation("Compute_District_Kpi_Data_Weekly started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                        var district_weekly_indexes = oService_Mesh.Compute_District_Kpi_Data_Weekly(new Service_Mesh.Params_Compute_District_Kpi_Data_Weekly()
                        {
                            DAY = firstDate.Day,
                            YEAR = firstDate.Year,
                            MONTH = firstDate.Month,
                            LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Current_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.Min_data_level_setup.DISPLAY_ORDER <= 5 && oOrganization_data_source_kpi.Kpi.Max_data_level_setup.DISPLAY_ORDER >= 5).ToList(),

                        });
                        _logger.LogInformation("Compute_District_Kpi_Data_Weekly Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, district_weekly_indexes.Exception_Message, district_weekly_indexes.Stack_Trace);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogInformation("Compute_District_Kpi_Data_Weekly exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                        if (isSendEmailOnCronException)
                        {
                            oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                            {
                                TITLE = "Compute_District_Kpi_Data_Weekly exception: " + ex.Message,
                                MESSAGE = ex.StackTrace
                            });
                        }
                    }
                }

                #endregion

                #region Generate Monthly Data

                if (firstDate.Day == 1 && firstDate.Hour == 0)
                {
                    try
                    {
                        _logger.LogInformation("Compute_Space_Kpi_Data_Monthly started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                        var space_monthly_indexes = oService_Mesh.Compute_Space_Kpi_Data_Monthly(new Service_Mesh.Params_Compute_Space_Kpi_Data_Monthly()
                        {
                            YEAR = firstDate.Year,
                            MONTH = firstDate.Month,
                            LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Current_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.Min_data_level_setup.DISPLAY_ORDER <= 0 && oOrganization_data_source_kpi.Kpi.Max_data_level_setup.DISPLAY_ORDER >= 0).ToList(),

                        });
                        _logger.LogInformation("Compute_Space_Kpi_Data_Monthly Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, space_monthly_indexes.Exception_Message, space_monthly_indexes.Stack_Trace);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogInformation("Compute_Space_Kpi_Data_Monthly exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                        if (isSendEmailOnCronException)
                        {
                            oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                            {
                                TITLE = "Compute_Space_Kpi_Data_Monthly exception: " + ex.Message,
                                MESSAGE = ex.StackTrace
                            });
                        }
                    }
                    try
                    {
                        _logger.LogInformation("Compute_Floor_Kpi_Data_Monthly started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                        var floor_monthly_indexes = oService_Mesh.Compute_Floor_Kpi_Data_Monthly(new Service_Mesh.Params_Compute_Floor_Kpi_Data_Monthly()
                        {
                            YEAR = firstDate.Year,
                            MONTH = firstDate.Month,
                            LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Current_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.Min_data_level_setup.DISPLAY_ORDER <= 1 && oOrganization_data_source_kpi.Kpi.Max_data_level_setup.DISPLAY_ORDER >= 1).ToList(),

                        });
                        _logger.LogInformation("Compute_Floor_Kpi_Data_Monthly Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, floor_monthly_indexes.Exception_Message, floor_monthly_indexes.Stack_Trace);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogInformation("Compute_Floor_Kpi_Data_Monthly exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                        if (isSendEmailOnCronException)
                        {
                            oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                            {
                                TITLE = "Compute_Floor_Kpi_Data_Monthly exception: " + ex.Message,
                                MESSAGE = ex.StackTrace
                            });
                        }
                    }
                    try
                    {
                        _logger.LogInformation("Compute_Entity_Kpi_Data_Monthly started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                        var entity_monthly_indexes = oService_Mesh.Compute_Entity_Kpi_Data_Monthly(new Service_Mesh.Params_Compute_Entity_Kpi_Data_Monthly
                        {
                            YEAR = firstDate.Year,
                            MONTH = firstDate.Month,
                            LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Current_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.Min_data_level_setup.DISPLAY_ORDER <= 2 && oOrganization_data_source_kpi.Kpi.Max_data_level_setup.DISPLAY_ORDER >= 2).ToList(),

                        });
                        _logger.LogInformation("Compute_Entity_Kpi_Data_Monthly Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, entity_monthly_indexes.Exception_Message, entity_monthly_indexes.Stack_Trace);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogInformation("Compute_Entity_Kpi_Data_Monthly exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                        if (isSendEmailOnCronException)
                        {
                            oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                            {
                                TITLE = "Compute_Entity_Kpi_Data_Monthly exception: " + ex.Message,
                                MESSAGE = ex.StackTrace
                            });
                        }
                    }
                    try
                    {
                        _logger.LogInformation("Compute_Site_Kpi_Data_Monthly started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                        var site_monthly_indexes = oService_Mesh.Compute_Site_Kpi_Data_Monthly(new Service_Mesh.Params_Compute_Site_Kpi_Data_Monthly
                        {
                            YEAR = firstDate.Year,
                            MONTH = firstDate.Month,
                            LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Current_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.Min_data_level_setup.DISPLAY_ORDER <= 3 && oOrganization_data_source_kpi.Kpi.Max_data_level_setup.DISPLAY_ORDER >= 3).ToList(),

                        });
                        _logger.LogInformation("Compute_Site_Kpi_Data_Monthly Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, site_monthly_indexes.Exception_Message, site_monthly_indexes.Stack_Trace);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogInformation("Compute_Site_Kpi_Data_Monthly exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                        if (isSendEmailOnCronException)
                        {
                            oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                            {
                                TITLE = "Compute_Site_Kpi_Data_Monthly exception: " + ex.Message,
                                MESSAGE = ex.StackTrace
                            });
                        }
                    }
                    try
                    {
                        _logger.LogInformation("Compute_Area_Kpi_Data_Monthly started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                        var area_monthly_indexes = oService_Mesh.Compute_Area_Kpi_Data_Monthly(new Service_Mesh.Params_Compute_Area_Kpi_Data_Monthly
                        {
                            YEAR = firstDate.Year,
                            MONTH = firstDate.Month,
                            LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Current_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.Min_data_level_setup.DISPLAY_ORDER <= 4 && oOrganization_data_source_kpi.Kpi.Max_data_level_setup.DISPLAY_ORDER >= 4).ToList(),

                        });
                        _logger.LogInformation("Compute_Area_Kpi_Data_Monthly Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, area_monthly_indexes.Exception_Message, area_monthly_indexes.Stack_Trace);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogInformation("Compute_Area_Kpi_Data_Monthly exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                        if (isSendEmailOnCronException)
                        {
                            oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                            {
                                TITLE = "Compute_Area_Kpi_Data_Monthly exception: " + ex.Message,
                                MESSAGE = ex.StackTrace
                            });
                        }
                    }
                    try
                    {
                        _logger.LogInformation("Compute_District_Kpi_Data_Monthly started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                        var district_monthly_indexes = oService_Mesh.Compute_District_Kpi_Data_Monthly(new Service_Mesh.Params_Compute_District_Kpi_Data_Monthly
                        {
                            YEAR = firstDate.Year,
                            MONTH = firstDate.Month,
                            LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Current_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.Min_data_level_setup.DISPLAY_ORDER <= 5 && oOrganization_data_source_kpi.Kpi.Max_data_level_setup.DISPLAY_ORDER >= 5).ToList(),

                        });
                        _logger.LogInformation("Compute_District_Kpi_Data_Monthly Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, district_monthly_indexes.Exception_Message, district_monthly_indexes.Stack_Trace);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogInformation("Compute_District_Kpi_Data_Monthly exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                        if (isSendEmailOnCronException)
                        {
                            oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                            {
                                TITLE = "Compute_District_Kpi_Data_Monthly exception: " + ex.Message,
                                MESSAGE = ex.StackTrace
                            });
                        }
                    }
                }

                #endregion

                #region Update LATEST_DATA_CREATION_DATE For Kpi

                oList_Current_Organization_data_source_kpi = oList_Current_Organization_data_source_kpi.Select(Organization_data_source_kpi =>
                {
                    Organization_data_source_kpi.Kpi.LATEST_DATA_CREATION_DATE = Tools.GetDateTimeString(new DateTime(firstDate.Year, firstDate.Month, firstDate.Day, firstDate.Hour, 0, 0));
                    return Organization_data_source_kpi;
                }).ToList();
                oService_Mesh.Edit_Kpi_List(new Service_Mesh.Params_Edit_Kpi_List()
                {
                    List_To_Edit = oList_Current_Organization_data_source_kpi.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi).ToList(),
                });

                #endregion

                firstDate = firstDate.AddHours(1);
            }
            _logger.LogInformation("Data Creation Worker finished at: {time}", DateTimeOffset.Now);
        }
        public void Get_Telus_Api_Data_1()
        {
            #region Setup

            bool isSendEmailOnCronException = ConfigurationManager.AppSettings["IS_SEND_EMAIL_ON_CRON_EXCEPTION"] == "1";
            Service_Mesh.Proxy oService_Mesh = new Service_Mesh.Proxy();
            oService_Mesh.BaseURL = ConfigurationManager.AppSettings["API_GATEWAY_URL"];
            oService_Mesh.Ticket = Crypto.Encrypt(string.Format(Tools.Get_Unique_String() + "[~!@]USERNAME:{0}[~!@]" + Tools.Get_Unique_String() + "[~!@]OWNER_ID:{1}[~!@]" + Tools.Get_Unique_String() + "[~!@]USER_ID:{2}[~!@]" + Tools.Get_Unique_String() + "[~!@]START_DATE:{3}[~!@]" + Tools.Get_Unique_String() + "[~!@]SESSION_PERIOD:{4}[~!@]", "jony.daxd@gmail.com", 1, 1, Tools.GetDateTimeString(DateTime.Now), 1440));

            #endregion

            bool isSendEmailOnCronjobStart = ConfigurationManager.AppSettings["IS_SEND_EMAIL_ON_CRONJOB_START"] == "1";
            if (isSendEmailOnCronjobStart)
            {
                string Title = "Telus Api Data Gathering 1 Started At GMT: " + DateTimeOffset.Now.ToString() + ", LOCAL: " + DateTime.Now.ToString();
                oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                {
                    TITLE = Title,
                    MESSAGE = Title
                });
            }

            _logger.LogInformation("Telus Api Data Gathering 1 started at: {time}", DateTimeOffset.Now);
            try
            {
                #region Setup

                Service_Mesh.Params_Generate_Site_Visitor_Data_And_Dwell_Time oParams_Generate_Site_Visitor_Data_And_Dwell_Time = new Service_Mesh.Params_Generate_Site_Visitor_Data_And_Dwell_Time();
                oParams_Generate_Site_Visitor_Data_And_Dwell_Time.List_Site = oService_Mesh.Get_Site_By_OWNER_ID(new Service_Mesh.Params_Get_Site_By_OWNER_ID()
                {
                    OWNER_ID = 1
                }).i_Result.Where(site => site.STUDY_ZONE_NAME != null).ToList();

                List<Service_Mesh.Setup> oList_Level_setup = oService_Mesh.Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Service_Mesh.Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
                {
                    SETUP_CATEGORY_NAME = "Data Level",
                    OWNER_ID = 1
                }).i_Result.List_Setup;

                DateTime now = DateTime.UtcNow;
                List<Service_Mesh.Organization_data_source_kpi> oList_Organization_data_source_kpi = oService_Mesh.Get_Organization_data_source_kpi_By_OWNER_ID_Adv(new Service_Mesh.Params_Get_Organization_data_source_kpi_By_OWNER_ID()
                {
                    OWNER_ID = 1,
                }).i_Result;
                oList_Organization_data_source_kpi = oList_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == Service_Mesh.Global.oNumber_of_visitors_ORGANIZATION_DATA_SOURCE_KPI_ID || oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == Service_Mesh.Global.oDwell_time_ORGANIZATION_DATA_SOURCE_KPI_ID)
                                                                                        .OrderBy(oOrganization_data_source_kpi => DateTime.Parse(oOrganization_data_source_kpi.Kpi.LATEST_DATA_CREATION_DATE))
                                                                                        .Select(oOrganization_data_source_kpi =>
                                                                                        {
                                                                                            oOrganization_data_source_kpi.Kpi.Min_data_level_setup = oList_Level_setup.Find(setup => setup.SETUP_ID == oOrganization_data_source_kpi.Kpi.MIN_DATA_LEVEL_SETUP_ID);
                                                                                            oOrganization_data_source_kpi.Kpi.Max_data_level_setup = oList_Level_setup.Find(setup => setup.SETUP_ID == oOrganization_data_source_kpi.Kpi.MAX_DATA_LEVEL_SETUP_ID);
                                                                                            return oOrganization_data_source_kpi;
                                                                                        })
                                                                                        .ToList();
                DateTime firstDate = DateTime.Parse(oList_Organization_data_source_kpi.FirstOrDefault().Kpi.LATEST_DATA_CREATION_DATE);

                #endregion

                while (firstDate.AddDays(1) <= now)
                {
                    #region Get Visitor Data & Dwell Time From API

                    bool Is_All_Data_Ready = true;
                    var visitor_data = Task.Run(() =>
                    {
                        try
                        {
                            oParams_Generate_Site_Visitor_Data_And_Dwell_Time.Visitor_Data = oService_Mesh.Get_Visitor_Data(new Service_Mesh.Params_Get_Visitor_Data()
                            {
                                SITE_LIST = oParams_Generate_Site_Visitor_Data_And_Dwell_Time.List_Site,
                                START_DATE = new DateTime(firstDate.Year, firstDate.Month, firstDate.Day, 0, 0, 0, DateTimeKind.Utc),
                                END_DATE = new DateTime(firstDate.Year, firstDate.Month, firstDate.Day, 0, 0, 0, DateTimeKind.Utc).AddDays(1),
                                ENUM_TIMESPAN = Service_Mesh.Enum_Timespan.X_HOURLY_COLLECTION,
                                DWELL_BUCKET_TIME = 60,
                                IS_EXCLUDE_NON_WORKERS = false,
                            }).i_Result;
                        }
                        catch (Exception ex)
                        {
                            _logger.LogInformation("Telus Api Data Gathering 1 visitor data failed with exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                            Is_All_Data_Ready = false;
                        }
                    });
                    var dwell_time_1 = Task.Run(() =>
                    {
                        try
                        {
                            oParams_Generate_Site_Visitor_Data_And_Dwell_Time.Dwell_Time_1 = oService_Mesh.Get_Visitor_Data(new Service_Mesh.Params_Get_Visitor_Data()
                            {
                                SITE_LIST = oParams_Generate_Site_Visitor_Data_And_Dwell_Time.List_Site,
                                START_DATE = new DateTime(firstDate.Year, firstDate.Month, firstDate.Day, 0, 0, 0, DateTimeKind.Utc),
                                END_DATE = new DateTime(firstDate.Year, firstDate.Month, firstDate.Day, 0, 0, 0, DateTimeKind.Utc).AddDays(1),
                                ENUM_TIMESPAN = Service_Mesh.Enum_Timespan.X_DAILY_COLLECTION,
                                DWELL_BUCKET_TIME = 1440,
                                MIN_DWELL_TIME_IN_MINUTES = 15,
                                MAX_DWELL_TIME_IN_MINUTES = 30,
                                IS_EXCLUDE_NON_WORKERS = false,
                            }).i_Result;
                        }
                        catch (Exception ex)
                        {
                            _logger.LogInformation("Telus Api Data Gathering 1 dwell time 1 failed with exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                            Is_All_Data_Ready = false;
                        }
                    });
                    var dwell_time_2 = Task.Run(() =>
                    {
                        try
                        {
                            oParams_Generate_Site_Visitor_Data_And_Dwell_Time.Dwell_Time_2 = oService_Mesh.Get_Visitor_Data(new Service_Mesh.Params_Get_Visitor_Data()
                            {
                                SITE_LIST = oParams_Generate_Site_Visitor_Data_And_Dwell_Time.List_Site,
                                START_DATE = new DateTime(firstDate.Year, firstDate.Month, firstDate.Day, 0, 0, 0, DateTimeKind.Utc),
                                END_DATE = new DateTime(firstDate.Year, firstDate.Month, firstDate.Day, 0, 0, 0, DateTimeKind.Utc).AddDays(1),
                                ENUM_TIMESPAN = Service_Mesh.Enum_Timespan.X_DAILY_COLLECTION,
                                DWELL_BUCKET_TIME = 1440,
                                MIN_DWELL_TIME_IN_MINUTES = 30,
                                MAX_DWELL_TIME_IN_MINUTES = 60,
                                IS_EXCLUDE_NON_WORKERS = false,
                            }).i_Result;
                        }
                        catch (Exception ex)
                        {
                            _logger.LogInformation("Telus Api Data Gathering 1 dwell time 2 failed with exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                            Is_All_Data_Ready = false;
                        }
                    });
                    var dwell_time_3 = Task.Run(() =>
                    {
                        try
                        {
                            oParams_Generate_Site_Visitor_Data_And_Dwell_Time.Dwell_Time_3 = oService_Mesh.Get_Visitor_Data(new Service_Mesh.Params_Get_Visitor_Data()
                            {
                                SITE_LIST = oParams_Generate_Site_Visitor_Data_And_Dwell_Time.List_Site,
                                START_DATE = new DateTime(firstDate.Year, firstDate.Month, firstDate.Day, 0, 0, 0, DateTimeKind.Utc),
                                END_DATE = new DateTime(firstDate.Year, firstDate.Month, firstDate.Day, 0, 0, 0, DateTimeKind.Utc).AddDays(1),
                                ENUM_TIMESPAN = Service_Mesh.Enum_Timespan.X_DAILY_COLLECTION,
                                DWELL_BUCKET_TIME = 1440,
                                MIN_DWELL_TIME_IN_MINUTES = 60,
                                MAX_DWELL_TIME_IN_MINUTES = 120,
                                IS_EXCLUDE_NON_WORKERS = false,
                            }).i_Result;
                        }
                        catch (Exception ex)
                        {
                            _logger.LogInformation("Telus Api Data Gathering 1 dwell time 3 failed with exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                            Is_All_Data_Ready = false;
                        }
                    });
                    var dwell_time_4 = Task.Run(() =>
                    {
                        try
                        {
                            oParams_Generate_Site_Visitor_Data_And_Dwell_Time.Dwell_Time_4 = oService_Mesh.Get_Visitor_Data(new Service_Mesh.Params_Get_Visitor_Data()
                            {
                                SITE_LIST = oParams_Generate_Site_Visitor_Data_And_Dwell_Time.List_Site,
                                START_DATE = new DateTime(firstDate.Year, firstDate.Month, firstDate.Day, 0, 0, 0, DateTimeKind.Utc),
                                END_DATE = new DateTime(firstDate.Year, firstDate.Month, firstDate.Day, 0, 0, 0, DateTimeKind.Utc).AddDays(1),
                                ENUM_TIMESPAN = Service_Mesh.Enum_Timespan.X_DAILY_COLLECTION,
                                DWELL_BUCKET_TIME = 1440,
                                MIN_DWELL_TIME_IN_MINUTES = 120,
                                MAX_DWELL_TIME_IN_MINUTES = 1440,
                                IS_EXCLUDE_NON_WORKERS = false,
                            }).i_Result;
                        }
                        catch (Exception ex)
                        {
                            _logger.LogInformation("Telus Api Data Gathering 1 dwell time 4 failed with exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                            Is_All_Data_Ready = false;
                        }
                    });

                    Task.WaitAll(visitor_data, dwell_time_1, dwell_time_2, dwell_time_3, dwell_time_4);

                    if (!Is_All_Data_Ready)
                    {
                        _logger.LogInformation("Data is being processed Data Gathering 1... Exiting at: {time}", DateTimeOffset.Now);
                        return;
                    }

                    #endregion

                    #region Generate Site Hourly/Daily Visitor Data & Dwell Time

                    try
                    {
                        _logger.LogInformation("Generate_Site_Visitor_Data_And_Dwell_Time started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                        oParams_Generate_Site_Visitor_Data_And_Dwell_Time.START_TIME = new DateTime(firstDate.Year, firstDate.Month, firstDate.Day, 0, 0, 0, DateTimeKind.Utc);
                        var site_daily_indexes = oService_Mesh.Generate_Site_Visitor_Data_And_Dwell_Time(oParams_Generate_Site_Visitor_Data_And_Dwell_Time);
                        _logger.LogInformation("Generate_Site_Visitor_Data_And_Dwell_Time Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, site_daily_indexes.Exception_Message, site_daily_indexes.Stack_Trace);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogInformation("Generate_Site_Visitor_Data_And_Dwell_Time exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                        if (isSendEmailOnCronException)
                        {
                            oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                            {
                                TITLE = "Generate_Site_Visitor_Data_And_Dwell_Time exception: " + ex.Message,
                                MESSAGE = ex.StackTrace
                            });
                        }
                    }

                    #endregion

                    DateTime currentTime = firstDate;
                    DateTime nextDay = currentTime.AddDays(1);
                    while (currentTime < nextDay)
                    {
                        #region Generate Area Hourly Visitor Data

                        try
                        {
                            _logger.LogInformation("Generate_Or_Compute_Area_Hourly_Data started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, currentTime);
                            var area_hourly_indexes = oService_Mesh.Generate_Or_Compute_Area_Hourly_Data(new Service_Mesh.Params_Generate_Or_Compute_Area_Hourly_Data()
                            {
                                DAY = currentTime.Day,
                                HOUR = currentTime.Hour,
                                YEAR = currentTime.Year,
                                MONTH = currentTime.Month,
                                LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Organization_data_source_kpi.Where(oOrganization_data_source_kp => oOrganization_data_source_kp.ORGANIZATION_DATA_SOURCE_KPI_ID == Service_Mesh.Global.oNumber_of_visitors_ORGANIZATION_DATA_SOURCE_KPI_ID).ToList(),
                            });
                            _logger.LogInformation("Generate_Or_Compute_Area_Hourly_Data Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, area_hourly_indexes.Exception_Message, area_hourly_indexes.Stack_Trace);
                        }
                        catch (Exception ex)
                        {
                            _logger.LogInformation("Generate_Or_Compute_Area_Hourly_Data exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                            if (isSendEmailOnCronException)
                            {
                                oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                                {
                                    TITLE = "Generate_Or_Compute_Area_Hourly_Data exception: " + ex.Message,
                                    MESSAGE = ex.StackTrace
                                });
                            }
                        }
                        try
                        {
                            _logger.LogInformation("Generate_Or_Compute_District_Hourly_Data started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, currentTime);
                            var district_hourly_indexes = oService_Mesh.Generate_Or_Compute_District_Hourly_Data(new Service_Mesh.Params_Generate_Or_Compute_District_Hourly_Data()
                            {
                                DAY = currentTime.Day,
                                HOUR = currentTime.Hour,
                                YEAR = currentTime.Year,
                                MONTH = currentTime.Month,
                                LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Organization_data_source_kpi.Where(oOrganization_data_source_kp => oOrganization_data_source_kp.ORGANIZATION_DATA_SOURCE_KPI_ID == Service_Mesh.Global.oNumber_of_visitors_ORGANIZATION_DATA_SOURCE_KPI_ID).ToList(),
                            });
                            _logger.LogInformation("Generate_Or_Compute_District_Hourly_Data Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, district_hourly_indexes.Exception_Message, district_hourly_indexes.Stack_Trace);
                        }
                        catch (Exception ex)
                        {
                            _logger.LogInformation("Generate_Or_Compute_District_Hourly_Data exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                            if (isSendEmailOnCronException)
                            {
                                oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                                {
                                    TITLE = "Generate_Or_Compute_District_Hourly_Data exception: " + ex.Message,
                                    MESSAGE = ex.StackTrace
                                });
                            }
                        }
                        currentTime = currentTime.AddHours(1);

                        #endregion
                    }

                    #region Compute Site Daily Visitor Data

                    try
                    {
                        _logger.LogInformation("Compute_Site_Kpi_Data_Daily started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                        var site_daily_indexes = oService_Mesh.Compute_Site_Kpi_Data_Daily(new Service_Mesh.Params_Compute_Site_Kpi_Data_Daily()
                        {
                            DAY = firstDate.AddDays(1).Day,
                            YEAR = firstDate.AddDays(1).Year,
                            MONTH = firstDate.AddDays(1).Month,
                            LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Organization_data_source_kpi.Where(oOrganization_data_source_kp => oOrganization_data_source_kp.ORGANIZATION_DATA_SOURCE_KPI_ID == Service_Mesh.Global.oNumber_of_visitors_ORGANIZATION_DATA_SOURCE_KPI_ID).ToList(),
                        });
                        _logger.LogInformation("Compute_Site_Kpi_Data_Daily Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, site_daily_indexes.Exception_Message, site_daily_indexes.Stack_Trace);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogInformation("Compute_Site_Kpi_Data_Daily exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                        if (isSendEmailOnCronException)
                        {
                            oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                            {
                                TITLE = "Compute_Site_Kpi_Data_Daily exception: " + ex.Message,
                                MESSAGE = ex.StackTrace
                            });
                        }
                    }

                    #endregion

                    #region Compute Area Daily Visitor Data

                    try
                    {
                        _logger.LogInformation("Compute_Area_Kpi_Data_Daily started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                        var area_daily_indexes = oService_Mesh.Compute_Area_Kpi_Data_Daily(new Service_Mesh.Params_Compute_Area_Kpi_Data_Daily()
                        {
                            DAY = firstDate.AddDays(1).Day,
                            YEAR = firstDate.AddDays(1).Year,
                            MONTH = firstDate.AddDays(1).Month,
                            LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Organization_data_source_kpi.Where(oOrganization_data_source_kp => oOrganization_data_source_kp.ORGANIZATION_DATA_SOURCE_KPI_ID == Service_Mesh.Global.oNumber_of_visitors_ORGANIZATION_DATA_SOURCE_KPI_ID).ToList(),
                        });
                        _logger.LogInformation("Compute_Area_Kpi_Data_Daily Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, area_daily_indexes.Exception_Message, area_daily_indexes.Stack_Trace);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogInformation("Compute_Area_Kpi_Data_Daily exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                        if (isSendEmailOnCronException)
                        {
                            oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                            {
                                TITLE = "Compute_Area_Kpi_Data_Daily exception: " + ex.Message,
                                MESSAGE = ex.StackTrace
                            });
                        }
                    }

                    #endregion

                    #region Compute District Daily Visitor Data

                    try
                    {
                        _logger.LogInformation("Compute_District_Kpi_Data_Daily started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                        var district_daily_indexes = oService_Mesh.Compute_District_Kpi_Data_Daily(new Service_Mesh.Params_Compute_District_Kpi_Data_Daily()
                        {
                            DAY = firstDate.AddDays(1).Day,
                            YEAR = firstDate.AddDays(1).Year,
                            MONTH = firstDate.AddDays(1).Month,
                            LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Organization_data_source_kpi.Where(oOrganization_data_source_kp => oOrganization_data_source_kp.ORGANIZATION_DATA_SOURCE_KPI_ID == Service_Mesh.Global.oNumber_of_visitors_ORGANIZATION_DATA_SOURCE_KPI_ID).ToList(),
                        });
                        _logger.LogInformation("Compute_District_Kpi_Data_Daily Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, district_daily_indexes.Exception_Message, district_daily_indexes.Stack_Trace);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogInformation("Compute_District_Kpi_Data_Daily exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                        if (isSendEmailOnCronException)
                        {
                            oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                            {
                                TITLE = "Compute_District_Kpi_Data_Daily exception: " + ex.Message,
                                MESSAGE = ex.StackTrace
                            });
                        }
                    }

                    #endregion

                    #region Generate Area Daily Dwell Time

                    try
                    {
                        _logger.LogInformation("Generate_Area_Dwell_Time started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                        var area_dwell_indexes = oService_Mesh.Generate_Area_Dwell_Time(new Service_Mesh.Params_Generate_Area_Dwell_Time()
                        {
                            DAY = firstDate.AddDays(1).Day,
                            YEAR = firstDate.AddDays(1).Year,
                            MONTH = firstDate.AddDays(1).Month,
                        });
                        _logger.LogInformation("Generate_Area_Dwell_Time Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, area_dwell_indexes.Exception_Message, area_dwell_indexes.Stack_Trace);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogInformation("Generate_Area_Dwell_Time exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                        if (isSendEmailOnCronException)
                        {
                            oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                            {
                                TITLE = "Generate_Area_Dwell_Time exception: " + ex.Message,
                                MESSAGE = ex.StackTrace
                            });
                        }
                    }

                    #endregion

                    #region Generate District Daily Dwell Time

                    try
                    {
                        _logger.LogInformation("Generate_District_Dwell_Time started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                        var district_dwell_indexes = oService_Mesh.Generate_District_Dwell_Time(new Service_Mesh.Params_Generate_District_Dwell_Time()
                        {
                            DAY = firstDate.AddDays(1).Day,
                            YEAR = firstDate.AddDays(1).Year,
                            MONTH = firstDate.AddDays(1).Month,
                        });
                        _logger.LogInformation("Generate_District_Dwell_Time Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, district_dwell_indexes.Exception_Message, district_dwell_indexes.Stack_Trace);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogInformation("Generate_District_Dwell_Time exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                        if (isSendEmailOnCronException)
                        {
                            oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                            {
                                TITLE = "Generate_District_Dwell_Time exception: " + ex.Message,
                                MESSAGE = ex.StackTrace
                            });
                        }
                    }

                    #endregion

                    if (firstDate.AddDays(1).DayOfWeek == DayOfWeek.Monday && firstDate.AddDays(1).Hour == 0)
                    {
                        #region Compute Site Weekly Visitor Data

                        try
                        {
                            _logger.LogInformation("Compute_Site_Kpi_Data_Weekly started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                            var site_weekly_indexes = oService_Mesh.Compute_Site_Kpi_Data_Weekly(new Service_Mesh.Params_Compute_Site_Kpi_Data_Weekly()
                            {
                                DAY = firstDate.AddDays(1).Day,
                                YEAR = firstDate.AddDays(1).Year,
                                MONTH = firstDate.AddDays(1).Month,
                                LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Organization_data_source_kpi.Where(oOrganization_data_source_kp => oOrganization_data_source_kp.ORGANIZATION_DATA_SOURCE_KPI_ID == Service_Mesh.Global.oNumber_of_visitors_ORGANIZATION_DATA_SOURCE_KPI_ID || oOrganization_data_source_kp.ORGANIZATION_DATA_SOURCE_KPI_ID == Service_Mesh.Global.oDwell_time_ORGANIZATION_DATA_SOURCE_KPI_ID).ToList(),
                            });
                            _logger.LogInformation("Compute_Site_Kpi_Data_Weekly Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, site_weekly_indexes.Exception_Message, site_weekly_indexes.Stack_Trace);
                        }
                        catch (Exception ex)
                        {
                            _logger.LogInformation("Compute_Site_Kpi_Data_Weekly exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                            if (isSendEmailOnCronException)
                            {
                                oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                                {
                                    TITLE = "Compute_Site_Kpi_Data_Weekly exception: " + ex.Message,
                                    MESSAGE = ex.StackTrace
                                });
                            }
                        }

                        #endregion

                        #region  Compute Area Weekly Visitor Data

                        try
                        {
                            _logger.LogInformation("Compute_Area_Kpi_Data_Weekly started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                            var area_weekly_indexes = oService_Mesh.Compute_Area_Kpi_Data_Weekly(new Service_Mesh.Params_Compute_Area_Kpi_Data_Weekly()
                            {
                                DAY = firstDate.AddDays(1).Day,
                                YEAR = firstDate.AddDays(1).Year,
                                MONTH = firstDate.AddDays(1).Month,
                                LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Organization_data_source_kpi.Where(oOrganization_data_source_kp => oOrganization_data_source_kp.ORGANIZATION_DATA_SOURCE_KPI_ID == Service_Mesh.Global.oNumber_of_visitors_ORGANIZATION_DATA_SOURCE_KPI_ID || oOrganization_data_source_kp.ORGANIZATION_DATA_SOURCE_KPI_ID == Service_Mesh.Global.oDwell_time_ORGANIZATION_DATA_SOURCE_KPI_ID).ToList(),
                            });
                            _logger.LogInformation("Compute_Area_Kpi_Data_Weekly Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, area_weekly_indexes.Exception_Message, area_weekly_indexes.Stack_Trace);
                        }
                        catch (Exception ex)
                        {
                            _logger.LogInformation("Compute_Area_Kpi_Data_Weekly exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                            if (isSendEmailOnCronException)
                            {
                                oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                                {
                                    TITLE = "Compute_Area_Kpi_Data_Weekly exception: " + ex.Message,
                                    MESSAGE = ex.StackTrace
                                });
                            }
                        }

                        #endregion

                        #region  Compute District Weekly Visitor Data

                        try
                        {
                            _logger.LogInformation("Compute_District_Kpi_Data_Weekly started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                            var district_weekly_indexes = oService_Mesh.Compute_District_Kpi_Data_Weekly(new Service_Mesh.Params_Compute_District_Kpi_Data_Weekly()
                            {
                                DAY = firstDate.AddDays(1).Day,
                                YEAR = firstDate.AddDays(1).Year,
                                MONTH = firstDate.AddDays(1).Month,
                                LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Organization_data_source_kpi.Where(oOrganization_data_source_kp => oOrganization_data_source_kp.ORGANIZATION_DATA_SOURCE_KPI_ID == Service_Mesh.Global.oNumber_of_visitors_ORGANIZATION_DATA_SOURCE_KPI_ID || oOrganization_data_source_kp.ORGANIZATION_DATA_SOURCE_KPI_ID == Service_Mesh.Global.oDwell_time_ORGANIZATION_DATA_SOURCE_KPI_ID).ToList(),
                            });
                            _logger.LogInformation("Compute_District_Kpi_Data_Weekly Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, district_weekly_indexes.Exception_Message, district_weekly_indexes.Stack_Trace);
                        }
                        catch (Exception ex)
                        {
                            _logger.LogInformation("Compute_District_Kpi_Data_Weekly exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                            if (isSendEmailOnCronException)
                            {
                                oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                                {
                                    TITLE = "Compute_District_Kpi_Data_Weekly exception: " + ex.Message,
                                    MESSAGE = ex.StackTrace
                                });
                            }
                        }

                        #endregion
                    }
                    if (firstDate.AddDays(1).Day == 1 && firstDate.AddDays(1).Hour == 0)
                    {
                        #region Compute Site Monthly Visitor Data

                        try
                        {
                            _logger.LogInformation("Compute_Site_Kpi_Data_Monthly started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                            var site_monthly_indexes = oService_Mesh.Compute_Site_Kpi_Data_Monthly(new Service_Mesh.Params_Compute_Site_Kpi_Data_Monthly
                            {
                                YEAR = firstDate.AddDays(1).Year,
                                MONTH = firstDate.AddDays(1).Month,
                                LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Organization_data_source_kpi.Where(oOrganization_data_source_kp => oOrganization_data_source_kp.ORGANIZATION_DATA_SOURCE_KPI_ID == Service_Mesh.Global.oNumber_of_visitors_ORGANIZATION_DATA_SOURCE_KPI_ID || oOrganization_data_source_kp.ORGANIZATION_DATA_SOURCE_KPI_ID == Service_Mesh.Global.oDwell_time_ORGANIZATION_DATA_SOURCE_KPI_ID).ToList(),
                            });
                            _logger.LogInformation("Compute_Site_Kpi_Data_Monthly Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, site_monthly_indexes.Exception_Message, site_monthly_indexes.Stack_Trace);
                        }
                        catch (Exception ex)
                        {
                            _logger.LogInformation("Compute_Site_Kpi_Data_Monthly exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                            if (isSendEmailOnCronException)
                            {
                                oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                                {
                                    TITLE = "Compute_Site_Kpi_Data_Monthly exception: " + ex.Message,
                                    MESSAGE = ex.StackTrace
                                });
                            }
                        }

                        #endregion

                        #region Compute Area Monthly Visitor Data

                        try
                        {
                            _logger.LogInformation("Compute_Area_Kpi_Data_Monthly started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                            var area_monthly_indexes = oService_Mesh.Compute_Area_Kpi_Data_Monthly(new Service_Mesh.Params_Compute_Area_Kpi_Data_Monthly
                            {
                                YEAR = firstDate.AddDays(1).Year,
                                MONTH = firstDate.AddDays(1).Month,
                                LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Organization_data_source_kpi.Where(oOrganization_data_source_kp => oOrganization_data_source_kp.ORGANIZATION_DATA_SOURCE_KPI_ID == Service_Mesh.Global.oNumber_of_visitors_ORGANIZATION_DATA_SOURCE_KPI_ID || oOrganization_data_source_kp.ORGANIZATION_DATA_SOURCE_KPI_ID == Service_Mesh.Global.oDwell_time_ORGANIZATION_DATA_SOURCE_KPI_ID).ToList(),
                            });
                            _logger.LogInformation("Compute_Area_Kpi_Data_Monthly Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, area_monthly_indexes.Exception_Message, area_monthly_indexes.Stack_Trace);
                        }
                        catch (Exception ex)
                        {
                            _logger.LogInformation("Compute_Area_Kpi_Data_Monthly exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                            if (isSendEmailOnCronException)
                            {
                                oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                                {
                                    TITLE = "Compute_Area_Kpi_Data_Monthly exception: " + ex.Message,
                                    MESSAGE = ex.StackTrace
                                });
                            }
                        }

                        #endregion

                        #region Compute District Monthly Visitor Data

                        try
                        {
                            _logger.LogInformation("Compute_District_Kpi_Data_Monthly started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                            var district_monthly_indexes = oService_Mesh.Compute_District_Kpi_Data_Monthly(new Service_Mesh.Params_Compute_District_Kpi_Data_Monthly
                            {
                                YEAR = firstDate.AddDays(1).Year,
                                MONTH = firstDate.AddDays(1).Month,
                                LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Organization_data_source_kpi.Where(oOrganization_data_source_kp => oOrganization_data_source_kp.ORGANIZATION_DATA_SOURCE_KPI_ID == Service_Mesh.Global.oNumber_of_visitors_ORGANIZATION_DATA_SOURCE_KPI_ID || oOrganization_data_source_kp.ORGANIZATION_DATA_SOURCE_KPI_ID == Service_Mesh.Global.oDwell_time_ORGANIZATION_DATA_SOURCE_KPI_ID).ToList(),
                            });
                            _logger.LogInformation("Compute_District_Kpi_Data_Monthly Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, district_monthly_indexes.Exception_Message, district_monthly_indexes.Stack_Trace);
                        }
                        catch (Exception ex)
                        {
                            _logger.LogInformation("Compute_District_Kpi_Data_Monthly exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                            if (isSendEmailOnCronException)
                            {
                                oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                                {
                                    TITLE = "Compute_District_Kpi_Data_Monthly exception: " + ex.Message,
                                    MESSAGE = ex.StackTrace
                                });
                            }
                        }

                        #endregion
                    }

                    #region Update LATEST_DATA_CREATION_DATE For Kpi

                    firstDate = firstDate.AddDays(1);
                    oList_Organization_data_source_kpi.ForEach(Organization_data_source_kpi =>
                    {
                        Organization_data_source_kpi.Kpi.LATEST_DATA_CREATION_DATE = Tools.GetDateTimeString(new DateTime(firstDate.Year, firstDate.Month, firstDate.Day, firstDate.Hour, 0, 0));
                    });
                    oService_Mesh.Edit_Kpi_List(new Service_Mesh.Params_Edit_Kpi_List()
                    {
                        List_To_Edit = oList_Organization_data_source_kpi.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi).ToList(),
                    });

                    #endregion
                }
            }
            catch (Exception ex)
            {
                _logger.LogInformation("Telus Api Data Gathering 1 failed with exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                if (isSendEmailOnCronException)
                {
                    oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                    {
                        TITLE = "Telus Api Data Gathering 1 failed with exception: " + ex.Message,
                        MESSAGE = ex.StackTrace
                    });
                }
            }
            _logger.LogInformation("Telus Api Data Gathering 1 finished at: {time}", DateTimeOffset.Now);
        }
        public void Get_Telus_Api_Data_2()
        {
            #region Setup

            bool isSendEmailOnCronException = ConfigurationManager.AppSettings["IS_SEND_EMAIL_ON_CRON_EXCEPTION"] == "1";
            Service_Mesh.Proxy oService_Mesh = new Service_Mesh.Proxy();
            oService_Mesh.BaseURL = ConfigurationManager.AppSettings["API_GATEWAY_URL"];
            oService_Mesh.Ticket = Crypto.Encrypt(string.Format(Tools.Get_Unique_String() + "[~!@]USERNAME:{0}[~!@]" + Tools.Get_Unique_String() + "[~!@]OWNER_ID:{1}[~!@]" + Tools.Get_Unique_String() + "[~!@]USER_ID:{2}[~!@]" + Tools.Get_Unique_String() + "[~!@]START_DATE:{3}[~!@]" + Tools.Get_Unique_String() + "[~!@]SESSION_PERIOD:{4}[~!@]", "jony.daxd@gmail.com", 1, 1, Tools.GetDateTimeString(DateTime.Now), 1440));

            #endregion

            bool isSendEmailOnCronjobStart = ConfigurationManager.AppSettings["IS_SEND_EMAIL_ON_CRONJOB_START"] == "1";
            if (isSendEmailOnCronjobStart)
            {
                string Title = "Telus Api Data Gathering 2 Started At GMT: " + DateTimeOffset.Now.ToString() + ", LOCAL: " + DateTime.Now.ToString();
                oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                {
                    TITLE = Title,
                    MESSAGE = Title
                });
            }

            _logger.LogInformation("Telus Api Data Gathering 2 started at: {time}", DateTimeOffset.Now);
            try
            {
                #region Setup

                Service_Mesh.Params_Generate_Worker_Data oParams_Generate_Worker_Data = new Service_Mesh.Params_Generate_Worker_Data();
                Service_Mesh.Params_Generate_Site_Demographic_Data oParams_Generate_Site_Demographic_Data = new Service_Mesh.Params_Generate_Site_Demographic_Data();
                Service_Mesh.Params_Generate_Visitor_Activity_Data oParams_Generate_Visitor_Activity_Data = new Service_Mesh.Params_Generate_Visitor_Activity_Data();
                oParams_Generate_Site_Demographic_Data.List_Site = oService_Mesh.Get_Site_By_OWNER_ID(new Service_Mesh.Params_Get_Site_By_OWNER_ID()
                {
                    OWNER_ID = 1
                }).i_Result.Where(site => site.STUDY_ZONE_NAME != null).ToList();
                oParams_Generate_Worker_Data.List_Site = oParams_Generate_Site_Demographic_Data.List_Site;
                oParams_Generate_Visitor_Activity_Data.List_Site = oParams_Generate_Site_Demographic_Data.List_Site;

                List<Service_Mesh.Setup> oList_Level_setup = oService_Mesh.Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Service_Mesh.Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
                {
                    SETUP_CATEGORY_NAME = "Data Level",
                    OWNER_ID = 1
                }).i_Result.List_Setup;

                DateTime now = DateTime.UtcNow;
                List<Service_Mesh.Organization_data_source_kpi> oList_Organization_data_source_kpi = oService_Mesh.Get_Organization_data_source_kpi_By_OWNER_ID_Adv(new Service_Mesh.Params_Get_Organization_data_source_kpi_By_OWNER_ID()
                {
                    OWNER_ID = 1,
                }).i_Result;
                oList_Organization_data_source_kpi = oList_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == Service_Mesh.Global.oVisitor_activity_ORGANIZATION_DATA_SOURCE_KPI_ID || oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == Service_Mesh.Global.oNumber_of_workers_ORGANIZATION_DATA_SOURCE_KPI_ID || Service_Mesh.Global.oList_Demographics_ORGANIZATION_DATA_SOURCE_KPI_ID.Contains(oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID))
                                                                                        .OrderBy(oOrganization_data_source_kpi => DateTime.Parse(oOrganization_data_source_kpi.Kpi.LATEST_DATA_CREATION_DATE))
                                                                                        .Select(oOrganization_data_source_kpi =>
                                                                                        {
                                                                                            oOrganization_data_source_kpi.Kpi.Min_data_level_setup = oList_Level_setup.Find(setup => setup.SETUP_ID == oOrganization_data_source_kpi.Kpi.MIN_DATA_LEVEL_SETUP_ID);
                                                                                            oOrganization_data_source_kpi.Kpi.Max_data_level_setup = oList_Level_setup.Find(setup => setup.SETUP_ID == oOrganization_data_source_kpi.Kpi.MAX_DATA_LEVEL_SETUP_ID);
                                                                                            return oOrganization_data_source_kpi;
                                                                                        })
                                                                                        .ToList();
                DateTime firstDate = DateTime.Parse(oList_Organization_data_source_kpi.FirstOrDefault().Kpi.LATEST_DATA_CREATION_DATE);

                #endregion

                while (firstDate.AddDays(1) <= now)
                {
                    #region Get Demographic Data, Visitor Data & Visitor Activity From API

                    bool Is_All_Data_Ready = true;
                    var demographic_data = Task.Run(() =>
                    {
                        try
                        {
                            oParams_Generate_Site_Demographic_Data.Demographic_Data = oService_Mesh.Get_Demographic_Data(new Service_Mesh.Params_Get_Demographic_Data()
                            {
                                SITE_LIST = oParams_Generate_Site_Demographic_Data.List_Site,
                                START_DATE = new DateTime(firstDate.Year, firstDate.Month, firstDate.Day, 0, 0, 0, DateTimeKind.Utc),
                                END_DATE = new DateTime(firstDate.Year, firstDate.Month, firstDate.Day, 0, 0, 0, DateTimeKind.Utc).AddDays(1),
                                ENUM_TIMESPAN = Service_Mesh.Enum_Timespan.X_HOURLY_COLLECTION,
                            }).i_Result;
                        }
                        catch (Exception ex)
                        {
                            _logger.LogInformation("Telus Api Data Gathering 2 Demographic data failed with exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                            Is_All_Data_Ready = false;
                        }
                    });
                    var visitor_data = Task.Run(() =>
                    {
                        try
                        {
                            oParams_Generate_Worker_Data.Visitor_Data = oService_Mesh.Get_Visitor_Data(new Service_Mesh.Params_Get_Visitor_Data()
                            {
                                SITE_LIST = oParams_Generate_Worker_Data.List_Site,
                                START_DATE = new DateTime(firstDate.Year, firstDate.Month, firstDate.Day, 0, 0, 0, DateTimeKind.Utc),
                                END_DATE = new DateTime(firstDate.Year, firstDate.Month, firstDate.Day, 0, 0, 0, DateTimeKind.Utc).AddDays(1),
                                ENUM_TIMESPAN = Service_Mesh.Enum_Timespan.X_HOURLY_COLLECTION,
                                DWELL_BUCKET_TIME = 60,
                                IS_EXCLUDE_NON_WORKERS = true,
                            }).i_Result;
                        }
                        catch (Exception ex)
                        {
                            _logger.LogInformation("Telus Api Data Gathering 2 number of workers failed with exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                            Is_All_Data_Ready = false;
                        }
                    });
                    var visitor_activity = Task.Run(() =>
                    {
                        try
                        {
                            oParams_Generate_Visitor_Activity_Data.Visitor_Activity = oService_Mesh.Get_Visitor_Activity_Data(new Service_Mesh.Params_Get_Visitor_Activity_Data()
                            {
                                SITE_LIST = oParams_Generate_Worker_Data.List_Site,
                                START_DATE = new DateTime(firstDate.Year, firstDate.Month, firstDate.Day, 0, 0, 0, DateTimeKind.Utc),
                                END_DATE = new DateTime(firstDate.Year, firstDate.Month, firstDate.Day, 0, 0, 0, DateTimeKind.Utc).AddDays(1),
                                ENUM_TIMESPAN = Service_Mesh.Enum_Timespan.X_HOURLY_COLLECTION,
                                DWELL_BUCKET_TIME = 1440,
                            }).i_Result;
                        }
                        catch (Exception ex)
                        {
                            _logger.LogInformation("Telus Api Data Gathering 2 Visitor activity failed with exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                            Is_All_Data_Ready = false;
                        }
                    });

                    Task.WaitAll(demographic_data, visitor_data, visitor_activity);

                    if (!Is_All_Data_Ready)
                    {
                        _logger.LogInformation("Data is being processed for Data Gathering 2... Exiting at: {time}", DateTimeOffset.Now);
                        return;
                    }

                    #endregion

                    #region Generate Site/Area/District Demographic Data

                    try
                    {
                        _logger.LogInformation("Generate_Site_Demographic_Data started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                        oParams_Generate_Site_Demographic_Data.START_TIME = new DateTime(firstDate.Year, firstDate.Month, firstDate.Day, 0, 0, 0);
                        var site_daily_indexes = oService_Mesh.Generate_Site_Demographic_Data(oParams_Generate_Site_Demographic_Data);
                        _logger.LogInformation("Generate_Site_Demographic_Data Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, site_daily_indexes.Exception_Message, site_daily_indexes.Stack_Trace);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogInformation("Generate_Site_Demographic_Data exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                        if (isSendEmailOnCronException)
                        {
                            oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                            {
                                TITLE = "Generate_Site_Demographic_Data exception: " + ex.Message,
                                MESSAGE = ex.StackTrace
                            });
                        }
                    }
                    try
                    {
                        _logger.LogInformation("Generate_Area_Demographic_Data started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                        var area_dwell_indexes = oService_Mesh.Generate_Area_Demographic_Data(new Service_Mesh.Params_Generate_Area_Demographic_Data()
                        {
                            DAY = firstDate.Day,
                            YEAR = firstDate.Year,
                            MONTH = firstDate.Month,
                        });
                        _logger.LogInformation("Generate_Area_Demographic_Data Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, area_dwell_indexes.Exception_Message, area_dwell_indexes.Stack_Trace);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogInformation("Generate_Area_Demographic_Data exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                        if (isSendEmailOnCronException)
                        {
                            oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                            {
                                TITLE = "Generate_Area_Demographic_Data exception: " + ex.Message,
                                MESSAGE = ex.StackTrace
                            });
                        }
                    }
                    try
                    {
                        _logger.LogInformation("Generate_District_Demographic_Data started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                        var district_dwell_indexes = oService_Mesh.Generate_District_Demographic_Data(new Service_Mesh.Params_Generate_District_Demographic_Data()
                        {
                            DAY = firstDate.Day,
                            YEAR = firstDate.Year,
                            MONTH = firstDate.Month,
                        });
                        _logger.LogInformation("Generate_District_Demographic_Data Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, district_dwell_indexes.Exception_Message, district_dwell_indexes.Stack_Trace);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogInformation("Generate_District_Demographic_Data exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                        if (isSendEmailOnCronException)
                        {
                            oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                            {
                                TITLE = "Generate_District_Demographic_Data exception: " + ex.Message,
                                MESSAGE = ex.StackTrace
                            });
                        }
                    }

                    #endregion

                    #region Generate Site/Area/District Daily Visitor Activity Data

                    try
                    {
                        _logger.LogInformation("Generate_Visitor_Activity_Data started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                        oParams_Generate_Visitor_Activity_Data.START_TIME = new DateTime(firstDate.Year, firstDate.Month, firstDate.Day, 0, 0, 0);
                        var site_daily_indexes = oService_Mesh.Generate_Visitor_Activity_Data(oParams_Generate_Visitor_Activity_Data);
                        _logger.LogInformation("Generate_Visitor_Activity_Data Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, site_daily_indexes.Exception_Message, site_daily_indexes.Stack_Trace);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogInformation("Generate_Visitor_Activity_Data exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                        if (isSendEmailOnCronException)
                        {
                            oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                            {
                                TITLE = "Generate_Visitor_Activity_Data exception: " + ex.Message,
                                MESSAGE = ex.StackTrace
                            });
                        }
                    }

                    #endregion

                    #region Generate Site Daily Worker Data

                    try
                    {
                        _logger.LogInformation("Generate_Worker_Data started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                        oParams_Generate_Worker_Data.START_TIME = new DateTime(firstDate.Year, firstDate.Month, firstDate.Day, 0, 0, 0);
                        var site_daily_indexes = oService_Mesh.Generate_Worker_Data(oParams_Generate_Worker_Data);
                        _logger.LogInformation("Generate_Worker_Data Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, site_daily_indexes.Exception_Message, site_daily_indexes.Stack_Trace);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogInformation("Generate_Worker_Data exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                        if (isSendEmailOnCronException)
                        {
                            oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                            {
                                TITLE = "Generate_Worker_Data exception: " + ex.Message,
                                MESSAGE = ex.StackTrace
                            });
                        }
                    }

                    #endregion

                    DateTime currentTime = firstDate;
                    DateTime nextDay = currentTime.AddDays(1);
                    while (currentTime < nextDay)
                    {
                        #region Generate/Compute Area Hourly Worker Data

                        try
                        {
                            _logger.LogInformation("Generate_Or_Compute_Area_Hourly_Data started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, currentTime);
                            var area_hourly_indexes = oService_Mesh.Generate_Or_Compute_Area_Hourly_Data(new Service_Mesh.Params_Generate_Or_Compute_Area_Hourly_Data()
                            {
                                DAY = currentTime.Day,
                                HOUR = currentTime.Hour,
                                YEAR = currentTime.Year,
                                MONTH = currentTime.Month,
                                LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == Service_Mesh.Global.oNumber_of_workers_ORGANIZATION_DATA_SOURCE_KPI_ID).ToList(),
                            });
                            _logger.LogInformation("Generate_Or_Compute_Area_Hourly_Data Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, area_hourly_indexes.Exception_Message, area_hourly_indexes.Stack_Trace);
                        }
                        catch (Exception ex)
                        {
                            _logger.LogInformation("Generate_Or_Compute_Area_Hourly_Data exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                            if (isSendEmailOnCronException)
                            {
                                oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                                {
                                    TITLE = "Generate_Or_Compute_Area_Hourly_Data exception: " + ex.Message,
                                    MESSAGE = ex.StackTrace
                                });
                            }
                        }

                        #endregion

                        #region Generate/Compute District Hourly Worker Data

                        try
                        {
                            _logger.LogInformation("Generate_Or_Compute_District_Hourly_Data started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, currentTime);
                            var district_hourly_indexes = oService_Mesh.Generate_Or_Compute_District_Hourly_Data(new Service_Mesh.Params_Generate_Or_Compute_District_Hourly_Data()
                            {
                                DAY = currentTime.Day,
                                HOUR = currentTime.Hour,
                                YEAR = currentTime.Year,
                                MONTH = currentTime.Month,
                                LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == Service_Mesh.Global.oNumber_of_workers_ORGANIZATION_DATA_SOURCE_KPI_ID).ToList(),
                            });
                            _logger.LogInformation("Generate_Or_Compute_District_Hourly_Data Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, district_hourly_indexes.Exception_Message, district_hourly_indexes.Stack_Trace);
                        }
                        catch (Exception ex)
                        {
                            _logger.LogInformation("Generate_Or_Compute_District_Hourly_Data exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                            if (isSendEmailOnCronException)
                            {
                                oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                                {
                                    TITLE = "Generate_Or_Compute_District_Hourly_Data exception: " + ex.Message,
                                    MESSAGE = ex.StackTrace
                                });
                            }
                        }

                        #endregion

                        currentTime = currentTime.AddHours(1);
                    }

                    #region Compute Site Daily Worker Data

                    try
                    {
                        _logger.LogInformation("Compute_Site_Kpi_Data_Daily started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                        var site_daily_indexes = oService_Mesh.Compute_Site_Kpi_Data_Daily(new Service_Mesh.Params_Compute_Site_Kpi_Data_Daily()
                        {
                            DAY = firstDate.AddDays(1).Day,
                            YEAR = firstDate.AddDays(1).Year,
                            MONTH = firstDate.AddDays(1).Month,
                            LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == Service_Mesh.Global.oNumber_of_workers_ORGANIZATION_DATA_SOURCE_KPI_ID).ToList(),
                        });
                        _logger.LogInformation("Compute_Site_Kpi_Data_Daily Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, site_daily_indexes.Exception_Message, site_daily_indexes.Stack_Trace);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogInformation("Compute_Site_Kpi_Data_Daily exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                        if (isSendEmailOnCronException)
                        {
                            oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                            {
                                TITLE = "Compute_Site_Kpi_Data_Daily exception: " + ex.Message,
                                MESSAGE = ex.StackTrace
                            });
                        }
                    }

                    #endregion

                    #region Compute Area Daily Worker Data

                    try
                    {
                        _logger.LogInformation("Compute_Area_Kpi_Data_Daily started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                        var area_daily_indexes = oService_Mesh.Compute_Area_Kpi_Data_Daily(new Service_Mesh.Params_Compute_Area_Kpi_Data_Daily()
                        {
                            DAY = firstDate.AddDays(1).Day,
                            YEAR = firstDate.AddDays(1).Year,
                            MONTH = firstDate.AddDays(1).Month,
                            LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == Service_Mesh.Global.oNumber_of_workers_ORGANIZATION_DATA_SOURCE_KPI_ID).ToList(),
                        });
                        _logger.LogInformation("Compute_Area_Kpi_Data_Daily Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, area_daily_indexes.Exception_Message, area_daily_indexes.Stack_Trace);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogInformation("Compute_Area_Kpi_Data_Daily exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                        if (isSendEmailOnCronException)
                        {
                            oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                            {
                                TITLE = "Compute_Area_Kpi_Data_Daily exception: " + ex.Message,
                                MESSAGE = ex.StackTrace
                            });
                        }
                    }

                    #endregion

                    #region Compute District Daily Worker Data

                    try
                    {
                        _logger.LogInformation("Compute_District_Kpi_Data_Daily started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                        var district_daily_indexes = oService_Mesh.Compute_District_Kpi_Data_Daily(new Service_Mesh.Params_Compute_District_Kpi_Data_Daily()
                        {
                            DAY = firstDate.AddDays(1).Day,
                            YEAR = firstDate.AddDays(1).Year,
                            MONTH = firstDate.AddDays(1).Month,
                            LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == Service_Mesh.Global.oNumber_of_workers_ORGANIZATION_DATA_SOURCE_KPI_ID).ToList(),
                        });
                        _logger.LogInformation("Compute_District_Kpi_Data_Daily Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, district_daily_indexes.Exception_Message, district_daily_indexes.Stack_Trace);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogInformation("Compute_District_Kpi_Data_Daily exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                        if (isSendEmailOnCronException)
                        {
                            oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                            {
                                TITLE = "Compute_District_Kpi_Data_Daily exception: " + ex.Message,
                                MESSAGE = ex.StackTrace
                            });
                        }
                    }

                    #endregion

                    if (firstDate.AddDays(1).DayOfWeek == DayOfWeek.Monday && firstDate.AddDays(1).Hour == 0)
                    {
                        #region Compute Site Weekly

                        try
                        {
                            _logger.LogInformation("Compute_Site_Kpi_Data_Weekly started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                            var site_weekly_indexes = oService_Mesh.Compute_Site_Kpi_Data_Weekly(new Service_Mesh.Params_Compute_Site_Kpi_Data_Weekly()
                            {
                                DAY = firstDate.AddDays(1).Day,
                                YEAR = firstDate.AddDays(1).Year,
                                MONTH = firstDate.AddDays(1).Month,
                                LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == Service_Mesh.Global.oVisitor_activity_ORGANIZATION_DATA_SOURCE_KPI_ID || oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == Service_Mesh.Global.oNumber_of_workers_ORGANIZATION_DATA_SOURCE_KPI_ID || Service_Mesh.Global.oList_Demographics_ORGANIZATION_DATA_SOURCE_KPI_ID.Contains(oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID)).ToList(),
                            });
                            _logger.LogInformation("Compute_Site_Kpi_Data_Weekly Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, site_weekly_indexes.Exception_Message, site_weekly_indexes.Stack_Trace);
                        }
                        catch (Exception ex)
                        {
                            _logger.LogInformation("Compute_Site_Kpi_Data_Weekly exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                            if (isSendEmailOnCronException)
                            {
                                oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                                {
                                    TITLE = "Compute_Site_Kpi_Data_Weekly exception: " + ex.Message,
                                    MESSAGE = ex.StackTrace
                                });
                            }
                        }

                        #endregion

                        #region Compute Area Weekly

                        try
                        {
                            _logger.LogInformation("Compute_Area_Kpi_Data_Weekly started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                            var area_weekly_indexes = oService_Mesh.Compute_Area_Kpi_Data_Weekly(new Service_Mesh.Params_Compute_Area_Kpi_Data_Weekly()
                            {
                                DAY = firstDate.AddDays(1).Day,
                                YEAR = firstDate.AddDays(1).Year,
                                MONTH = firstDate.AddDays(1).Month,
                                LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == Service_Mesh.Global.oVisitor_activity_ORGANIZATION_DATA_SOURCE_KPI_ID || oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == Service_Mesh.Global.oNumber_of_workers_ORGANIZATION_DATA_SOURCE_KPI_ID || Service_Mesh.Global.oList_Demographics_ORGANIZATION_DATA_SOURCE_KPI_ID.Contains(oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID)).ToList(),
                            });
                            _logger.LogInformation("Compute_Area_Kpi_Data_Weekly Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, area_weekly_indexes.Exception_Message, area_weekly_indexes.Stack_Trace);
                        }
                        catch (Exception ex)
                        {
                            _logger.LogInformation("Compute_Area_Kpi_Data_Weekly exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                            if (isSendEmailOnCronException)
                            {
                                oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                                {
                                    TITLE = "Compute_Area_Kpi_Data_Weekly exception: " + ex.Message,
                                    MESSAGE = ex.StackTrace
                                });
                            }
                        }

                        #endregion

                        #region Compute District Weekly

                        try
                        {
                            _logger.LogInformation("Compute_District_Kpi_Data_Weekly started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                            var district_weekly_indexes = oService_Mesh.Compute_District_Kpi_Data_Weekly(new Service_Mesh.Params_Compute_District_Kpi_Data_Weekly()
                            {
                                DAY = firstDate.AddDays(1).Day,
                                YEAR = firstDate.AddDays(1).Year,
                                MONTH = firstDate.AddDays(1).Month,
                                LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == Service_Mesh.Global.oVisitor_activity_ORGANIZATION_DATA_SOURCE_KPI_ID || oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == Service_Mesh.Global.oNumber_of_workers_ORGANIZATION_DATA_SOURCE_KPI_ID || Service_Mesh.Global.oList_Demographics_ORGANIZATION_DATA_SOURCE_KPI_ID.Contains(oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID)).ToList(),
                            });
                            _logger.LogInformation("Compute_District_Kpi_Data_Weekly Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, district_weekly_indexes.Exception_Message, district_weekly_indexes.Stack_Trace);
                        }
                        catch (Exception ex)
                        {
                            _logger.LogInformation("Compute_District_Kpi_Data_Weekly exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                            if (isSendEmailOnCronException)
                            {
                                oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                                {
                                    TITLE = "Compute_District_Kpi_Data_Weekly exception: " + ex.Message,
                                    MESSAGE = ex.StackTrace
                                });
                            }
                        }

                        #endregion
                    }
                    if (firstDate.AddDays(1).Day == 1 && firstDate.AddDays(1).Hour == 0)
                    {
                        #region Compute Site Monthly

                        try
                        {
                            _logger.LogInformation("Compute_Site_Kpi_Data_Monthly started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                            var site_monthly_indexes = oService_Mesh.Compute_Site_Kpi_Data_Monthly(new Service_Mesh.Params_Compute_Site_Kpi_Data_Monthly
                            {
                                YEAR = firstDate.AddDays(1).Year,
                                MONTH = firstDate.AddDays(1).Month,
                                LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == Service_Mesh.Global.oVisitor_activity_ORGANIZATION_DATA_SOURCE_KPI_ID || oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == Service_Mesh.Global.oNumber_of_workers_ORGANIZATION_DATA_SOURCE_KPI_ID || Service_Mesh.Global.oList_Demographics_ORGANIZATION_DATA_SOURCE_KPI_ID.Contains(oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID)).ToList(),
                            });
                            _logger.LogInformation("Compute_Site_Kpi_Data_Monthly Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, site_monthly_indexes.Exception_Message, site_monthly_indexes.Stack_Trace);
                        }
                        catch (Exception ex)
                        {
                            _logger.LogInformation("Compute_Site_Kpi_Data_Monthly exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                            if (isSendEmailOnCronException)
                            {
                                oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                                {
                                    TITLE = "Compute_Site_Kpi_Data_Monthly exception: " + ex.Message,
                                    MESSAGE = ex.StackTrace
                                });
                            }
                        }

                        #endregion

                        #region Compute Area Monthly

                        try
                        {
                            _logger.LogInformation("Compute_Area_Kpi_Data_Monthly started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                            var area_monthly_indexes = oService_Mesh.Compute_Area_Kpi_Data_Monthly(new Service_Mesh.Params_Compute_Area_Kpi_Data_Monthly
                            {
                                YEAR = firstDate.AddDays(1).Year,
                                MONTH = firstDate.AddDays(1).Month,
                                LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == Service_Mesh.Global.oVisitor_activity_ORGANIZATION_DATA_SOURCE_KPI_ID || oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == Service_Mesh.Global.oNumber_of_workers_ORGANIZATION_DATA_SOURCE_KPI_ID || Service_Mesh.Global.oList_Demographics_ORGANIZATION_DATA_SOURCE_KPI_ID.Contains(oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID)).ToList(),
                            });
                            _logger.LogInformation("Compute_Area_Kpi_Data_Monthly Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, area_monthly_indexes.Exception_Message, area_monthly_indexes.Stack_Trace);
                        }
                        catch (Exception ex)
                        {
                            _logger.LogInformation("Compute_Area_Kpi_Data_Monthly exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                            if (isSendEmailOnCronException)
                            {
                                oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                                {
                                    TITLE = "Compute_Area_Kpi_Data_Monthly exception: " + ex.Message,
                                    MESSAGE = ex.StackTrace
                                });
                            }
                        }

                        #endregion

                        #region Compute District Monthly

                        try
                        {
                            _logger.LogInformation("Compute_District_Kpi_Data_Monthly started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                            var district_monthly_indexes = oService_Mesh.Compute_District_Kpi_Data_Monthly(new Service_Mesh.Params_Compute_District_Kpi_Data_Monthly
                            {
                                YEAR = firstDate.AddDays(1).Year,
                                MONTH = firstDate.AddDays(1).Month,
                                LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == Service_Mesh.Global.oVisitor_activity_ORGANIZATION_DATA_SOURCE_KPI_ID || oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == Service_Mesh.Global.oNumber_of_workers_ORGANIZATION_DATA_SOURCE_KPI_ID || Service_Mesh.Global.oList_Demographics_ORGANIZATION_DATA_SOURCE_KPI_ID.Contains(oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID)).ToList(),
                            });
                            _logger.LogInformation("Compute_District_Kpi_Data_Monthly Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, district_monthly_indexes.Exception_Message, district_monthly_indexes.Stack_Trace);
                        }
                        catch (Exception ex)
                        {
                            _logger.LogInformation("Compute_District_Kpi_Data_Monthly exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                            if (isSendEmailOnCronException)
                            {
                                oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                                {
                                    TITLE = "Compute_District_Kpi_Data_Monthly exception: " + ex.Message,
                                    MESSAGE = ex.StackTrace
                                });
                            }
                        }

                        #endregion
                    }

                    #region Update LATEST_DATA_CREATION_DATE For Kpi

                    firstDate = firstDate.AddDays(1);
                    oList_Organization_data_source_kpi.ForEach(oOrganization_data_source_kpi =>
                    {
                        oOrganization_data_source_kpi.Kpi.LATEST_DATA_CREATION_DATE = Tools.GetDateTimeString(new DateTime(firstDate.Year, firstDate.Month, firstDate.Day, firstDate.Hour, 0, 0));
                    });
                    oService_Mesh.Edit_Kpi_List(new Service_Mesh.Params_Edit_Kpi_List()
                    {
                        List_To_Edit = oList_Organization_data_source_kpi.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi).ToList(),
                    });

                    #endregion
                }
            }
            catch (Exception ex)
            {
                _logger.LogInformation("Telus Api Data Gathering 2 failed with exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                if (isSendEmailOnCronException)
                {
                    oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                    {
                        TITLE = "Telus Api Data Gathering 2 failed with exception: " + ex.Message,
                        MESSAGE = ex.StackTrace
                    });
                }
            }
            _logger.LogInformation("Telus Api Data Gathering 2 finished at: {time}", DateTimeOffset.Now);
        }
        public void Get_New_Public_Events()
        {
            #region Setup

            bool isSendEmailOnCronException = ConfigurationManager.AppSettings["IS_SEND_EMAIL_ON_CRON_EXCEPTION"] == "1";
            Service_Mesh.Proxy oService_Mesh = new Service_Mesh.Proxy();
            oService_Mesh.BaseURL = ConfigurationManager.AppSettings["API_GATEWAY_URL"];
            oService_Mesh.Ticket = Crypto.Encrypt(string.Format(Tools.Get_Unique_String() + "[~!@]USERNAME:{0}[~!@]" + Tools.Get_Unique_String() + "[~!@]OWNER_ID:{1}[~!@]" + Tools.Get_Unique_String() + "[~!@]USER_ID:{2}[~!@]" + Tools.Get_Unique_String() + "[~!@]START_DATE:{3}[~!@]" + Tools.Get_Unique_String() + "[~!@]SESSION_PERIOD:{4}[~!@]", "jony.daxd@gmail.com", 1, 1, Tools.GetDateTimeString(DateTime.Now), 1440));

            #endregion

            _logger.LogInformation("Public Events Worker started at: {time}", DateTimeOffset.Now);
            try
            {
                oService_Mesh.Get_And_Fill_Public_events_From_Api(new Service_Mesh.Params_Get_And_Fill_Public_events_From_Api()
                {
                    DATE_CREATED_START_DATE = null
                });
            }
            catch (Exception ex)
            {
                _logger.LogInformation("Public Events Worker failed with exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                if (isSendEmailOnCronException)
                {
                    oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                    {
                        TITLE = "Public Events Worker failed with exception: " + ex.Message,
                        MESSAGE = ex.StackTrace
                    });
                }
            }
            _logger.LogInformation("Public Events Worker finished at: {time}", DateTimeOffset.Now);
        }
        public void Gather_Data_Asset_Data()
        {
            #region Setup

            bool isSendEmailOnCronException = ConfigurationManager.AppSettings["IS_SEND_EMAIL_ON_CRON_EXCEPTION"] == "1";
            Service_Mesh.Proxy oService_Mesh = new Service_Mesh.Proxy();
            oService_Mesh.BaseURL = ConfigurationManager.AppSettings["API_GATEWAY_URL"];
            oService_Mesh.Ticket = Crypto.Encrypt(string.Format(Tools.Get_Unique_String() + "[~!@]USERNAME:{0}[~!@]" + Tools.Get_Unique_String() + "[~!@]OWNER_ID:{1}[~!@]" + Tools.Get_Unique_String() + "[~!@]USER_ID:{2}[~!@]" + Tools.Get_Unique_String() + "[~!@]START_DATE:{3}[~!@]" + Tools.Get_Unique_String() + "[~!@]SESSION_PERIOD:{4}[~!@]", "jony.daxd@gmail.com", 1, 1, Tools.GetDateTimeString(DateTime.Now), 1440));

            List<Service_Mesh.Setup> oList_Level_setup = oService_Mesh.Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Service_Mesh.Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
            {
                SETUP_CATEGORY_NAME = "Data Level",
                OWNER_ID = 1
            }).i_Result.List_Setup;

            List<Service_Mesh.Organization_data_source_kpi> oList_All_Organization_data_source_kpi = oService_Mesh.Get_Organization_data_source_kpi_By_OWNER_ID_Adv(new Service_Mesh.Params_Get_Organization_data_source_kpi_By_OWNER_ID()
            {
                OWNER_ID = 1
            }).i_Result
            .OrderBy(oOrganization_data_source_kpi => DateTime.Parse(oOrganization_data_source_kpi.Kpi.LATEST_DATA_CREATION_DATE))
            .Select(oOrganization_data_source_kpi =>
            {
                oOrganization_data_source_kpi.Kpi.Min_data_level_setup = oList_Level_setup.Find(setup => setup.SETUP_ID == oOrganization_data_source_kpi.Kpi.MIN_DATA_LEVEL_SETUP_ID);
                oOrganization_data_source_kpi.Kpi.Max_data_level_setup = oList_Level_setup.Find(setup => setup.SETUP_ID == oOrganization_data_source_kpi.Kpi.MAX_DATA_LEVEL_SETUP_ID);
                return oOrganization_data_source_kpi;
            }).ToList();
            List<Service_Mesh.Organization_data_source_kpi> oList_Organization_data_source_kpi = oList_All_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.IS_AUTO_GENERATE).ToList();

            DateTime now = DateTime.Now;
            DateTime firstDate = DateTime.Parse(oList_Organization_data_source_kpi.FirstOrDefault().Kpi.LATEST_DATA_CREATION_DATE).AddHours(1);
            _logger.LogInformation("Data Creation Worker started at: {time}", DateTimeOffset.Now);

            #endregion

            while (firstDate <= now)
            {
                List<Service_Mesh.Organization_data_source_kpi> oList_Current_Organization_data_source_kpi = oList_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => DateTime.Parse(oOrganization_data_source_kpi.Kpi.LATEST_DATA_CREATION_DATE) < firstDate).ToList();

                #region Generate Hourly Data

                try
                {
                    _logger.LogInformation("Generate_Space_Hourly_Indexes started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                    var space_hourly_indexes = oService_Mesh.Generate_Space_Hourly_Indexes(new Service_Mesh.Params_Generate_Space_Hourly_Indexes()
                    {
                        DAY = firstDate.Day,
                        HOUR = firstDate.Hour,
                        YEAR = firstDate.Year,
                        MONTH = firstDate.Month,
                        LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Current_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.Min_data_level_setup.DISPLAY_ORDER <= 0 && oOrganization_data_source_kpi.Kpi.Max_data_level_setup.DISPLAY_ORDER >= 0).ToList(),
                    });
                    _logger.LogInformation("Generate_Space_Hourly_Indexes Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, space_hourly_indexes.Exception_Message, space_hourly_indexes.Stack_Trace);
                }
                catch (Exception ex)
                {
                    _logger.LogInformation("Generate_Space_Hourly_Indexes exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                    if (isSendEmailOnCronException)
                    {
                        oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                        {
                            TITLE = "Generate_Space_Hourly_Indexes exception: " + ex.Message,
                            MESSAGE = ex.StackTrace
                        });
                    }
                }
                try
                {
                    _logger.LogInformation("Generate_Or_Compute_Floor_Hourly_Data started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                    var floor_hourly_indexes = oService_Mesh.Generate_Or_Compute_Floor_Hourly_Data(new Service_Mesh.Params_Generate_Or_Compute_Floor_Hourly_Data()
                    {
                        DAY = firstDate.Day,
                        HOUR = firstDate.Hour,
                        YEAR = firstDate.Year,
                        MONTH = firstDate.Month,
                        LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Current_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.Min_data_level_setup.DISPLAY_ORDER <= 1 && oOrganization_data_source_kpi.Kpi.Max_data_level_setup.DISPLAY_ORDER >= 1).ToList(),
                    });
                    _logger.LogInformation("Generate_Or_Compute_Floor_Hourly_Data Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, floor_hourly_indexes.Exception_Message, floor_hourly_indexes.Stack_Trace);
                }
                catch (Exception ex)
                {
                    _logger.LogInformation("Generate_Or_Compute_Floor_Hourly_Data exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                    if (isSendEmailOnCronException)
                    {
                        oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                        {
                            TITLE = "Generate_Or_Compute_Floor_Hourly_Data exception: " + ex.Message,
                            MESSAGE = ex.StackTrace
                        });
                    }
                }
                try
                {
                    _logger.LogInformation("Generate_Or_Compute_Entity_Hourly_Data started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                    var entity_hourly_indexes = oService_Mesh.Generate_Or_Compute_Entity_Hourly_Data(new Service_Mesh.Params_Generate_Or_Compute_Entity_Hourly_Data()
                    {
                        DAY = firstDate.Day,
                        HOUR = firstDate.Hour,
                        YEAR = firstDate.Year,
                        MONTH = firstDate.Month,
                        LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Current_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.Min_data_level_setup.DISPLAY_ORDER <= 2 && oOrganization_data_source_kpi.Kpi.Max_data_level_setup.DISPLAY_ORDER >= 2).ToList(),
                    });
                    _logger.LogInformation("Generate_Or_Compute_Entity_Hourly_Data Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, entity_hourly_indexes.Exception_Message, entity_hourly_indexes.Stack_Trace);
                }
                catch (Exception ex)
                {
                    _logger.LogInformation("Generate_Or_Compute_Entity_Hourly_Data exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                    if (isSendEmailOnCronException)
                    {
                        oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                        {
                            TITLE = "Generate_Or_Compute_Entity_Hourly_Data exception: " + ex.Message,
                            MESSAGE = ex.StackTrace
                        });
                    }
                }
                try
                {
                    _logger.LogInformation("Generate_Or_Compute_Site_Hourly_Data started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                    var site_hourly_indexes = oService_Mesh.Generate_Or_Compute_Site_Hourly_Data(new Service_Mesh.Params_Generate_Or_Compute_Site_Hourly_Data()
                    {
                        DAY = firstDate.Day,
                        HOUR = firstDate.Hour,
                        YEAR = firstDate.Year,
                        MONTH = firstDate.Month,
                        LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Current_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.Min_data_level_setup.DISPLAY_ORDER <= 3 && oOrganization_data_source_kpi.Kpi.Max_data_level_setup.DISPLAY_ORDER >= 3).ToList(),
                    });
                    _logger.LogInformation("Generate_Or_Compute_Site_Hourly_Data Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, site_hourly_indexes.Exception_Message, site_hourly_indexes.Stack_Trace);
                }
                catch (Exception ex)
                {
                    _logger.LogInformation("Generate_Or_Compute_Site_Hourly_Data exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                    if (isSendEmailOnCronException)
                    {
                        oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                        {
                            TITLE = "Generate_Or_Compute_Site_Hourly_Data exception: " + ex.Message,
                            MESSAGE = ex.StackTrace
                        });
                    }
                }
                try
                {
                    _logger.LogInformation("Generate_Or_Compute_Area_Hourly_Data started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                    var area_hourly_indexes = oService_Mesh.Generate_Or_Compute_Area_Hourly_Data(new Service_Mesh.Params_Generate_Or_Compute_Area_Hourly_Data()
                    {
                        DAY = firstDate.Day,
                        HOUR = firstDate.Hour,
                        YEAR = firstDate.Year,
                        MONTH = firstDate.Month,
                        LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Current_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.Min_data_level_setup.DISPLAY_ORDER <= 4 && oOrganization_data_source_kpi.Kpi.Max_data_level_setup.DISPLAY_ORDER >= 4).ToList(),
                    });
                    _logger.LogInformation("Generate_Or_Compute_Area_Hourly_Data Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, area_hourly_indexes.Exception_Message, area_hourly_indexes.Stack_Trace);
                }
                catch (Exception ex)
                {
                    _logger.LogInformation("Generate_Or_Compute_Area_Hourly_Data exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                    if (isSendEmailOnCronException)
                    {
                        oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                        {
                            TITLE = "Generate_Or_Compute_Area_Hourly_Data exception: " + ex.Message,
                            MESSAGE = ex.StackTrace
                        });
                    }
                }
                try
                {
                    _logger.LogInformation("Generate_Or_Compute_District_Hourly_Data started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                    var district_hourly_indexes = oService_Mesh.Generate_Or_Compute_District_Hourly_Data(new Service_Mesh.Params_Generate_Or_Compute_District_Hourly_Data()
                    {
                        DAY = firstDate.Day,
                        HOUR = firstDate.Hour,
                        YEAR = firstDate.Year,
                        MONTH = firstDate.Month,
                        LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Current_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.Min_data_level_setup.DISPLAY_ORDER <= 5 && oOrganization_data_source_kpi.Kpi.Max_data_level_setup.DISPLAY_ORDER >= 5).ToList(),
                    });
                    _logger.LogInformation("Generate_Or_Compute_District_Hourly_Data Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, district_hourly_indexes.Exception_Message, district_hourly_indexes.Stack_Trace);
                }
                catch (Exception ex)
                {
                    _logger.LogInformation("Generate_Or_Compute_District_Hourly_Data exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                    if (isSendEmailOnCronException)
                    {
                        oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                        {
                            TITLE = "Generate_Or_Compute_District_Hourly_Data exception: " + ex.Message,
                            MESSAGE = ex.StackTrace
                        });
                    }
                }

                #endregion

                #region Generate Daily Data

                if (firstDate.Hour == 0)
                {
                    try
                    {
                        _logger.LogInformation("Compute_Space_Kpi_Data_Daily started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                        var space_daily_indexes = oService_Mesh.Compute_Space_Kpi_Data_Daily(new Service_Mesh.Params_Compute_Space_Kpi_Data_Daily()
                        {
                            DAY = firstDate.Day,
                            YEAR = firstDate.Year,
                            MONTH = firstDate.Month,
                            LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Current_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.Min_data_level_setup.DISPLAY_ORDER <= 0 && oOrganization_data_source_kpi.Kpi.Max_data_level_setup.DISPLAY_ORDER >= 0).ToList(),

                        });
                        _logger.LogInformation("Compute_Space_Kpi_Data_Daily Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, space_daily_indexes.Exception_Message, space_daily_indexes.Stack_Trace);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogInformation("Compute_Space_Kpi_Data_Daily exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                        if (isSendEmailOnCronException)
                        {
                            oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                            {
                                TITLE = "Compute_Space_Kpi_Data_Daily exception: " + ex.Message,
                                MESSAGE = ex.StackTrace
                            });
                        }
                    }
                    try
                    {
                        _logger.LogInformation("Compute_Floor_Kpi_Data_Daily started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                        var floor_daily_indexes = oService_Mesh.Compute_Floor_Kpi_Data_Daily(new Service_Mesh.Params_Compute_Floor_Kpi_Data_Daily()
                        {
                            DAY = firstDate.Day,
                            YEAR = firstDate.Year,
                            MONTH = firstDate.Month,
                            LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Current_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.Min_data_level_setup.DISPLAY_ORDER <= 1 && oOrganization_data_source_kpi.Kpi.Max_data_level_setup.DISPLAY_ORDER >= 1).ToList(),

                        });
                        _logger.LogInformation("Compute_Floor_Kpi_Data_Daily Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, floor_daily_indexes.Exception_Message, floor_daily_indexes.Stack_Trace);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogInformation("Compute_Floor_Kpi_Data_Daily exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                        if (isSendEmailOnCronException)
                        {
                            oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                            {
                                TITLE = "Compute_Floor_Kpi_Data_Daily exception: " + ex.Message,
                                MESSAGE = ex.StackTrace
                            });
                        }
                    }
                    try
                    {
                        _logger.LogInformation("Compute_Entity_Kpi_Data_Daily started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                        var entity_daily_indexes = oService_Mesh.Compute_Entity_Kpi_Data_Daily(new Service_Mesh.Params_Compute_Entity_Kpi_Data_Daily()
                        {
                            DAY = firstDate.Day,
                            YEAR = firstDate.Year,
                            MONTH = firstDate.Month,
                            LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Current_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.Min_data_level_setup.DISPLAY_ORDER <= 2 && oOrganization_data_source_kpi.Kpi.Max_data_level_setup.DISPLAY_ORDER >= 2).ToList(),

                        });
                        _logger.LogInformation("Compute_Entity_Kpi_Data_Daily Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, entity_daily_indexes.Exception_Message, entity_daily_indexes.Stack_Trace);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogInformation("Compute_Entity_Kpi_Data_Daily exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                        if (isSendEmailOnCronException)
                        {
                            oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                            {
                                TITLE = "Compute_Entity_Kpi_Data_Daily exception: " + ex.Message,
                                MESSAGE = ex.StackTrace
                            });
                        }
                    }
                    try
                    {
                        _logger.LogInformation("Compute_Site_Kpi_Data_Daily started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                        var site_daily_indexes = oService_Mesh.Compute_Site_Kpi_Data_Daily(new Service_Mesh.Params_Compute_Site_Kpi_Data_Daily()
                        {
                            DAY = firstDate.Day,
                            YEAR = firstDate.Year,
                            MONTH = firstDate.Month,
                            LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Current_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.Min_data_level_setup.DISPLAY_ORDER <= 3 && oOrganization_data_source_kpi.Kpi.Max_data_level_setup.DISPLAY_ORDER >= 3).ToList(),

                        });
                        _logger.LogInformation("Compute_Site_Kpi_Data_Daily Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, site_daily_indexes.Exception_Message, site_daily_indexes.Stack_Trace);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogInformation("Compute_Site_Kpi_Data_Daily exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                        if (isSendEmailOnCronException)
                        {
                            oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                            {
                                TITLE = "Compute_Site_Kpi_Data_Daily exception: " + ex.Message,
                                MESSAGE = ex.StackTrace
                            });
                        }
                    }
                    try
                    {
                        _logger.LogInformation("Compute_Area_Kpi_Data_Daily started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                        var area_daily_indexes = oService_Mesh.Compute_Area_Kpi_Data_Daily(new Service_Mesh.Params_Compute_Area_Kpi_Data_Daily()
                        {
                            DAY = firstDate.Day,
                            YEAR = firstDate.Year,
                            MONTH = firstDate.Month,
                            LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Current_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.Min_data_level_setup.DISPLAY_ORDER <= 4 && oOrganization_data_source_kpi.Kpi.Max_data_level_setup.DISPLAY_ORDER >= 4).ToList(),

                        });
                        _logger.LogInformation("Compute_Area_Kpi_Data_Daily Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, area_daily_indexes.Exception_Message, area_daily_indexes.Stack_Trace);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogInformation("Compute_Area_Kpi_Data_Daily exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                        if (isSendEmailOnCronException)
                        {
                            oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                            {
                                TITLE = "Compute_Area_Kpi_Data_Daily exception: " + ex.Message,
                                MESSAGE = ex.StackTrace
                            });
                        }
                    }
                    try
                    {
                        _logger.LogInformation("Compute_District_Kpi_Data_Daily started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                        var district_daily_indexes = oService_Mesh.Compute_District_Kpi_Data_Daily(new Service_Mesh.Params_Compute_District_Kpi_Data_Daily()
                        {
                            DAY = firstDate.Day,
                            YEAR = firstDate.Year,
                            MONTH = firstDate.Month,
                            LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Current_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.Min_data_level_setup.DISPLAY_ORDER <= 5 && oOrganization_data_source_kpi.Kpi.Max_data_level_setup.DISPLAY_ORDER >= 5).ToList(),

                        });
                        _logger.LogInformation("Compute_District_Kpi_Data_Daily Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, district_daily_indexes.Exception_Message, district_daily_indexes.Stack_Trace);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogInformation("Compute_District_Kpi_Data_Daily exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                        if (isSendEmailOnCronException)
                        {
                            oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                            {
                                TITLE = "Compute_District_Kpi_Data_Daily exception: " + ex.Message,
                                MESSAGE = ex.StackTrace
                            });
                        }
                    }
                }

                #endregion

                #region Generate Weekly Data

                if (firstDate.DayOfWeek == DayOfWeek.Monday && firstDate.Hour == 0)
                {
                    try
                    {
                        _logger.LogInformation("Compute_Space_Kpi_Data_Weekly started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                        var space_weekly_indexes = oService_Mesh.Compute_Space_Kpi_Data_Weekly(new Service_Mesh.Params_Compute_Space_Kpi_Data_Weekly()
                        {
                            DAY = firstDate.Day,
                            YEAR = firstDate.Year,
                            MONTH = firstDate.Month,
                            LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Current_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.Min_data_level_setup.DISPLAY_ORDER <= 0 && oOrganization_data_source_kpi.Kpi.Max_data_level_setup.DISPLAY_ORDER >= 0).ToList(),

                        });
                        _logger.LogInformation("Compute_Space_Kpi_Data_Weekly Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, space_weekly_indexes.Exception_Message, space_weekly_indexes.Stack_Trace);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogInformation("Compute_Space_Kpi_Data_Weekly exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                        if (isSendEmailOnCronException)
                        {
                            oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                            {
                                TITLE = "Compute_Space_Kpi_Data_Weekly exception: " + ex.Message,
                                MESSAGE = ex.StackTrace
                            });
                        }
                    }
                    try
                    {
                        _logger.LogInformation("Compute_Floor_Kpi_Data_Weekly started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                        var floor_weekly_indexes = oService_Mesh.Compute_Floor_Kpi_Data_Weekly(new Service_Mesh.Params_Compute_Floor_Kpi_Data_Weekly()
                        {
                            DAY = firstDate.Day,
                            YEAR = firstDate.Year,
                            MONTH = firstDate.Month,
                            LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Current_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.Min_data_level_setup.DISPLAY_ORDER <= 1 && oOrganization_data_source_kpi.Kpi.Max_data_level_setup.DISPLAY_ORDER >= 1).ToList(),

                        });
                        _logger.LogInformation("Compute_Floor_Kpi_Data_Weekly Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, floor_weekly_indexes.Exception_Message, floor_weekly_indexes.Stack_Trace);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogInformation("Compute_Floor_Kpi_Data_Weekly exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                        if (isSendEmailOnCronException)
                        {
                            oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                            {
                                TITLE = "Compute_Floor_Kpi_Data_Weekly exception: " + ex.Message,
                                MESSAGE = ex.StackTrace
                            });
                        }
                    }
                    try
                    {
                        _logger.LogInformation("Compute_Entity_Kpi_Data_Weekly started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                        var entity_weekly_indexes = oService_Mesh.Compute_Entity_Kpi_Data_Weekly(new Service_Mesh.Params_Compute_Entity_Kpi_Data_Weekly()
                        {
                            DAY = firstDate.Day,
                            YEAR = firstDate.Year,
                            MONTH = firstDate.Month,
                            LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Current_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.Min_data_level_setup.DISPLAY_ORDER <= 2 && oOrganization_data_source_kpi.Kpi.Max_data_level_setup.DISPLAY_ORDER >= 2).ToList(),

                        });
                        _logger.LogInformation("Compute_Entity_Kpi_Data_Weekly Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, entity_weekly_indexes.Exception_Message, entity_weekly_indexes.Stack_Trace);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogInformation("Compute_Entity_Kpi_Data_Weekly exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                        if (isSendEmailOnCronException)
                        {
                            oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                            {
                                TITLE = "Compute_Entity_Kpi_Data_Weekly exception: " + ex.Message,
                                MESSAGE = ex.StackTrace
                            });
                        }
                    }
                    try
                    {
                        _logger.LogInformation("Compute_Site_Kpi_Data_Weekly started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                        var site_weekly_indexes = oService_Mesh.Compute_Site_Kpi_Data_Weekly(new Service_Mesh.Params_Compute_Site_Kpi_Data_Weekly()
                        {
                            DAY = firstDate.Day,
                            YEAR = firstDate.Year,
                            MONTH = firstDate.Month,
                            LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Current_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.Min_data_level_setup.DISPLAY_ORDER <= 3 && oOrganization_data_source_kpi.Kpi.Max_data_level_setup.DISPLAY_ORDER >= 3).ToList(),

                        });
                        _logger.LogInformation("Compute_Site_Kpi_Data_Weekly Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, site_weekly_indexes.Exception_Message, site_weekly_indexes.Stack_Trace);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogInformation("Compute_Site_Kpi_Data_Weekly exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                        if (isSendEmailOnCronException)
                        {
                            oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                            {
                                TITLE = "Compute_Site_Kpi_Data_Weekly exception: " + ex.Message,
                                MESSAGE = ex.StackTrace
                            });
                        }
                    }
                    try
                    {
                        _logger.LogInformation("Compute_Area_Kpi_Data_Weekly started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                        var area_weekly_indexes = oService_Mesh.Compute_Area_Kpi_Data_Weekly(new Service_Mesh.Params_Compute_Area_Kpi_Data_Weekly()
                        {
                            DAY = firstDate.Day,
                            YEAR = firstDate.Year,
                            MONTH = firstDate.Month,
                            LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Current_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.Min_data_level_setup.DISPLAY_ORDER <= 4 && oOrganization_data_source_kpi.Kpi.Max_data_level_setup.DISPLAY_ORDER >= 4).ToList(),

                        });
                        _logger.LogInformation("Compute_Area_Kpi_Data_Weekly Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, area_weekly_indexes.Exception_Message, area_weekly_indexes.Stack_Trace);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogInformation("Compute_Area_Kpi_Data_Weekly exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                        if (isSendEmailOnCronException)
                        {
                            oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                            {
                                TITLE = "Compute_Area_Kpi_Data_Weekly exception: " + ex.Message,
                                MESSAGE = ex.StackTrace
                            });
                        }
                    }
                    try
                    {
                        _logger.LogInformation("Compute_District_Kpi_Data_Weekly started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                        var district_weekly_indexes = oService_Mesh.Compute_District_Kpi_Data_Weekly(new Service_Mesh.Params_Compute_District_Kpi_Data_Weekly()
                        {
                            DAY = firstDate.Day,
                            YEAR = firstDate.Year,
                            MONTH = firstDate.Month,
                            LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Current_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.Min_data_level_setup.DISPLAY_ORDER <= 5 && oOrganization_data_source_kpi.Kpi.Max_data_level_setup.DISPLAY_ORDER >= 5).ToList(),

                        });
                        _logger.LogInformation("Compute_District_Kpi_Data_Weekly Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, district_weekly_indexes.Exception_Message, district_weekly_indexes.Stack_Trace);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogInformation("Compute_District_Kpi_Data_Weekly exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                        if (isSendEmailOnCronException)
                        {
                            oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                            {
                                TITLE = "Compute_District_Kpi_Data_Weekly exception: " + ex.Message,
                                MESSAGE = ex.StackTrace
                            });
                        }
                    }
                }

                #endregion

                #region Generate Monthly Data

                if (firstDate.Day == 1 && firstDate.Hour == 0)
                {
                    try
                    {
                        _logger.LogInformation("Compute_Space_Kpi_Data_Monthly started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                        var space_monthly_indexes = oService_Mesh.Compute_Space_Kpi_Data_Monthly(new Service_Mesh.Params_Compute_Space_Kpi_Data_Monthly()
                        {
                            YEAR = firstDate.Year,
                            MONTH = firstDate.Month,
                            LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Current_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.Min_data_level_setup.DISPLAY_ORDER <= 0 && oOrganization_data_source_kpi.Kpi.Max_data_level_setup.DISPLAY_ORDER >= 0).ToList(),

                        });
                        _logger.LogInformation("Compute_Space_Kpi_Data_Monthly Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, space_monthly_indexes.Exception_Message, space_monthly_indexes.Stack_Trace);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogInformation("Compute_Space_Kpi_Data_Monthly exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                        if (isSendEmailOnCronException)
                        {
                            oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                            {
                                TITLE = "Compute_Space_Kpi_Data_Monthly exception: " + ex.Message,
                                MESSAGE = ex.StackTrace
                            });
                        }
                    }
                    try
                    {
                        _logger.LogInformation("Compute_Floor_Kpi_Data_Monthly started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                        var floor_monthly_indexes = oService_Mesh.Compute_Floor_Kpi_Data_Monthly(new Service_Mesh.Params_Compute_Floor_Kpi_Data_Monthly()
                        {
                            YEAR = firstDate.Year,
                            MONTH = firstDate.Month,
                            LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Current_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.Min_data_level_setup.DISPLAY_ORDER <= 1 && oOrganization_data_source_kpi.Kpi.Max_data_level_setup.DISPLAY_ORDER >= 1).ToList(),

                        });
                        _logger.LogInformation("Compute_Floor_Kpi_Data_Monthly Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, floor_monthly_indexes.Exception_Message, floor_monthly_indexes.Stack_Trace);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogInformation("Compute_Floor_Kpi_Data_Monthly exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                        if (isSendEmailOnCronException)
                        {
                            oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                            {
                                TITLE = "Compute_Floor_Kpi_Data_Monthly exception: " + ex.Message,
                                MESSAGE = ex.StackTrace
                            });
                        }
                    }
                    try
                    {
                        _logger.LogInformation("Compute_Entity_Kpi_Data_Monthly started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                        var entity_monthly_indexes = oService_Mesh.Compute_Entity_Kpi_Data_Monthly(new Service_Mesh.Params_Compute_Entity_Kpi_Data_Monthly
                        {
                            YEAR = firstDate.Year,
                            MONTH = firstDate.Month,
                            LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Current_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.Min_data_level_setup.DISPLAY_ORDER <= 2 && oOrganization_data_source_kpi.Kpi.Max_data_level_setup.DISPLAY_ORDER >= 2).ToList(),

                        });
                        _logger.LogInformation("Compute_Entity_Kpi_Data_Monthly Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, entity_monthly_indexes.Exception_Message, entity_monthly_indexes.Stack_Trace);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogInformation("Compute_Entity_Kpi_Data_Monthly exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                        if (isSendEmailOnCronException)
                        {
                            oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                            {
                                TITLE = "Compute_Entity_Kpi_Data_Monthly exception: " + ex.Message,
                                MESSAGE = ex.StackTrace
                            });
                        }
                    }
                    try
                    {
                        _logger.LogInformation("Compute_Site_Kpi_Data_Monthly started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                        var site_monthly_indexes = oService_Mesh.Compute_Site_Kpi_Data_Monthly(new Service_Mesh.Params_Compute_Site_Kpi_Data_Monthly
                        {
                            YEAR = firstDate.Year,
                            MONTH = firstDate.Month,
                            LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Current_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.Min_data_level_setup.DISPLAY_ORDER <= 3 && oOrganization_data_source_kpi.Kpi.Max_data_level_setup.DISPLAY_ORDER >= 3).ToList(),

                        });
                        _logger.LogInformation("Compute_Site_Kpi_Data_Monthly Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, site_monthly_indexes.Exception_Message, site_monthly_indexes.Stack_Trace);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogInformation("Compute_Site_Kpi_Data_Monthly exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                        if (isSendEmailOnCronException)
                        {
                            oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                            {
                                TITLE = "Compute_Site_Kpi_Data_Monthly exception: " + ex.Message,
                                MESSAGE = ex.StackTrace
                            });
                        }
                    }
                    try
                    {
                        _logger.LogInformation("Compute_Area_Kpi_Data_Monthly started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                        var area_monthly_indexes = oService_Mesh.Compute_Area_Kpi_Data_Monthly(new Service_Mesh.Params_Compute_Area_Kpi_Data_Monthly
                        {
                            YEAR = firstDate.Year,
                            MONTH = firstDate.Month,
                            LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Current_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.Min_data_level_setup.DISPLAY_ORDER <= 4 && oOrganization_data_source_kpi.Kpi.Max_data_level_setup.DISPLAY_ORDER >= 4).ToList(),

                        });
                        _logger.LogInformation("Compute_Area_Kpi_Data_Monthly Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, area_monthly_indexes.Exception_Message, area_monthly_indexes.Stack_Trace);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogInformation("Compute_Area_Kpi_Data_Monthly exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                        if (isSendEmailOnCronException)
                        {
                            oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                            {
                                TITLE = "Compute_Area_Kpi_Data_Monthly exception: " + ex.Message,
                                MESSAGE = ex.StackTrace
                            });
                        }
                    }
                    try
                    {
                        _logger.LogInformation("Compute_District_Kpi_Data_Monthly started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                        var district_monthly_indexes = oService_Mesh.Compute_District_Kpi_Data_Monthly(new Service_Mesh.Params_Compute_District_Kpi_Data_Monthly
                        {
                            YEAR = firstDate.Year,
                            MONTH = firstDate.Month,
                            LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Current_Organization_data_source_kpi.Where(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.Min_data_level_setup.DISPLAY_ORDER <= 5 && oOrganization_data_source_kpi.Kpi.Max_data_level_setup.DISPLAY_ORDER >= 5).ToList(),

                        });
                        _logger.LogInformation("Compute_District_Kpi_Data_Monthly Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, district_monthly_indexes.Exception_Message, district_monthly_indexes.Stack_Trace);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogInformation("Compute_District_Kpi_Data_Monthly exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                        if (isSendEmailOnCronException)
                        {
                            oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                            {
                                TITLE = "Compute_District_Kpi_Data_Monthly exception: " + ex.Message,
                                MESSAGE = ex.StackTrace
                            });
                        }
                    }
                }

                #endregion

                _logger.LogInformation("Created data for time: {time}", firstDate);

                #region Update LATEST_DATA_CREATION_DATE For Kpi

                oList_Current_Organization_data_source_kpi = oList_Current_Organization_data_source_kpi.Select(Organization_data_source_kpi =>
                {
                    Organization_data_source_kpi.Kpi.LATEST_DATA_CREATION_DATE = Tools.GetDateTimeString(new DateTime(firstDate.Year, firstDate.Month, firstDate.Day, firstDate.Hour, 0, 0));
                    return Organization_data_source_kpi;
                }).ToList();
                oService_Mesh.Edit_Kpi_List(new Service_Mesh.Params_Edit_Kpi_List()
                {
                    List_To_Edit = oList_Current_Organization_data_source_kpi.Select(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi).ToList(),
                });

                #endregion

                firstDate = firstDate.AddHours(1);
            }
            _logger.LogInformation("Data Creation Worker finished at: {time}", DateTimeOffset.Now);
        }
        public void Get_New_Bylaw_Complaints()
        {

            #region Setup

            bool isSendEmailOnCronException = ConfigurationManager.AppSettings["IS_SEND_EMAIL_ON_CRON_EXCEPTION"] == "1";
            Service_Mesh.Proxy oService_Mesh = new Service_Mesh.Proxy();
            oService_Mesh.BaseURL = ConfigurationManager.AppSettings["API_GATEWAY_URL"];
            oService_Mesh.Ticket = Crypto.Encrypt(string.Format(Tools.Get_Unique_String() + "[~!@]USERNAME:{0}[~!@]" + Tools.Get_Unique_String() + "[~!@]OWNER_ID:{1}[~!@]" + Tools.Get_Unique_String() + "[~!@]USER_ID:{2}[~!@]" + Tools.Get_Unique_String() + "[~!@]START_DATE:{3}[~!@]" + Tools.Get_Unique_String() + "[~!@]SESSION_PERIOD:{4}[~!@]", "jony.daxd@gmail.com", 1, 1, Tools.GetDateTimeString(DateTime.Now), 1440));

            #endregion

            #region Get Organization_data_source_kpi

            List<Service_Mesh.Organization_data_source_kpi> oList_Organization_data_source_kpi = oService_Mesh.Get_Organization_data_source_kpi_By_OWNER_ID_Adv(new Service_Mesh.Params_Get_Organization_data_source_kpi_By_OWNER_ID()
            {
                OWNER_ID = 1
            }).i_Result;
            Service_Mesh.Organization_data_source_kpi oOrganization_data_source_kpi = oList_Organization_data_source_kpi.Find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.NAME == "Bylaw Complaints");

            #endregion

            _logger.LogInformation("Bylaw Complaints Worker started at: {time}", DateTimeOffset.Now);
            try
            {
                Service_Mesh.GeoData oGeoData = oService_Mesh.Get_Latest_GeoData_By_KPI(new Service_Mesh.Params_Get_Latest_GeoData_By_KPI()
                {
                    ORGANIZATION_DATA_SOURCE_KPI_ID = oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID
                }).i_Result;
                oService_Mesh.Get_And_Fill_Bylaw_complaints_From_Api(new Service_Mesh.Params_Get_And_Fill_Bylaw_complaints_From_Api()
                {
                    DATE_CREATED_START_DATE = oGeoData?.DATE_END?.AddSeconds(1)
                });
            }
            catch (Exception ex)
            {
                _logger.LogInformation("Bylaw Complaints Worker failed with exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                if (isSendEmailOnCronException)
                {
                    oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                    {
                        TITLE = "Bylaw Complaints Worker failed with exception: " + ex.Message,
                        MESSAGE = ex.StackTrace
                    });
                }
            }
            _logger.LogInformation("Bylaw Complaints Worker finished at: {time}", DateTimeOffset.Now);
        }
        public void Get_New_Businesses()
        {

            #region Setup

            bool isSendEmailOnCronException = ConfigurationManager.AppSettings["IS_SEND_EMAIL_ON_CRON_EXCEPTION"] == "1";
            Service_Mesh.Proxy oService_Mesh = new Service_Mesh.Proxy();
            oService_Mesh.BaseURL = ConfigurationManager.AppSettings["API_GATEWAY_URL"];
            oService_Mesh.Ticket = Crypto.Encrypt(string.Format(Tools.Get_Unique_String() + "[~!@]USERNAME:{0}[~!@]" + Tools.Get_Unique_String() + "[~!@]OWNER_ID:{1}[~!@]" + Tools.Get_Unique_String() + "[~!@]USER_ID:{2}[~!@]" + Tools.Get_Unique_String() + "[~!@]START_DATE:{3}[~!@]" + Tools.Get_Unique_String() + "[~!@]SESSION_PERIOD:{4}[~!@]", "jony.daxd@gmail.com", 1, 1, Tools.GetDateTimeString(DateTime.Now), 1440));

            #endregion

            #region Get Organization_data_source_kpi

            List<Service_Mesh.Kpi> oList_Kpi = oService_Mesh.Get_Kpi_By_OWNER_ID_Adv(new Service_Mesh.Params_Get_Kpi_By_OWNER_ID()
            {
                OWNER_ID = 1
            }).i_Result;
            oList_Kpi.RemoveAll(oKpi => oKpi.NAME != "Businesses By Category" && oKpi.NAME != "Businesses Vacancy" && oKpi.NAME != "Business Count" && oKpi.NAME != "Vacant Business Count");

            List<Service_Mesh.Organization_data_source_kpi> oList_Organization_data_source_kpi = oService_Mesh.Get_Organization_data_source_kpi_By_OWNER_ID_Adv(new Service_Mesh.Params_Get_Organization_data_source_kpi_By_OWNER_ID()
            {
                OWNER_ID = 1
            }).i_Result;
            oList_Organization_data_source_kpi.RemoveAll(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.NAME != "Business Count" && oOrganization_data_source_kpi.Kpi.NAME != "Vacant Business Count");

            List<Service_Mesh.Setup> oList_Level_setup = oService_Mesh.Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Service_Mesh.Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
            {
                SETUP_CATEGORY_NAME = "Data Level",
                OWNER_ID = 1
            }).i_Result.List_Setup;

            foreach (var oOrganization_data_source_kpi in oList_Organization_data_source_kpi)
            {
                oOrganization_data_source_kpi.Kpi.Min_data_level_setup = oList_Level_setup.Find(setup => setup.SETUP_ID == oOrganization_data_source_kpi.Kpi.MIN_DATA_LEVEL_SETUP_ID);
                oOrganization_data_source_kpi.Kpi.Max_data_level_setup = oList_Level_setup.Find(setup => setup.SETUP_ID == oOrganization_data_source_kpi.Kpi.MAX_DATA_LEVEL_SETUP_ID);
            }

            #endregion

            DateTime currentDate = DateTime.Now;

            _logger.LogInformation("Business Worker started at: {time}", DateTimeOffset.Now);
            try
            {
                try
                {
                    _logger.LogInformation("Get_And_Fill_Businesses_From_Api started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, currentDate);
                    var businesses = oService_Mesh.Get_And_Fill_Businesses_From_Api();
                    _logger.LogInformation("Get_And_Fill_Businesses_From_Api Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, businesses.Exception_Message, businesses.Stack_Trace);
                }
                catch (Exception ex)
                {
                    _logger.LogInformation("Get_And_Fill_Businesses_From_Api exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                    if (isSendEmailOnCronException)
                    {
                        oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                        {
                            TITLE = "Get_And_Fill_Businesses_From_Api exception: " + ex.Message,
                            MESSAGE = ex.StackTrace
                        });
                    }
                }
                try
                {
                    _logger.LogInformation("Generate_Business_Count_And_Vacant_Business_Count started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, currentDate);
                    var businesses_daily = oService_Mesh.Generate_Business_Count_And_Vacant_Business_Count(new Service_Mesh.Params_Generate_Business_Count_And_Vacant_Business_Count()
                    {
                        DAY = currentDate.Day,
                        MONTH = currentDate.Month,
                        YEAR = currentDate.Year
                    });
                    _logger.LogInformation("Generate_Business_Count_And_Vacant_Business_Count Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, businesses_daily.Exception_Message, businesses_daily.Stack_Trace);
                }
                catch (Exception ex)
                {
                    _logger.LogInformation("Generate_Business_Count_And_Vacant_Business_Count exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                    if (isSendEmailOnCronException)
                    {
                        oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                        {
                            TITLE = "Generate_Business_Count_And_Vacant_Business_Count exception: " + ex.Message,
                            MESSAGE = ex.StackTrace
                        });
                    }
                }


                if (currentDate.DayOfWeek == DayOfWeek.Monday)
                {
                    #region Compute Weekly Businesses Count

                    try
                    {
                        _logger.LogInformation("Compute_Site_Kpi_Data_Weekly started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, currentDate);
                        var site_weekly_indexes = oService_Mesh.Compute_Site_Kpi_Data_Weekly(new Service_Mesh.Params_Compute_Site_Kpi_Data_Weekly()
                        {
                            DAY = currentDate.Day,
                            YEAR = currentDate.Year,
                            MONTH = currentDate.Month,
                            LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Organization_data_source_kpi,
                        });
                        _logger.LogInformation("Compute_Site_Kpi_Data_Weekly Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, site_weekly_indexes.Exception_Message, site_weekly_indexes.Stack_Trace);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogInformation("Compute_Site_Kpi_Data_Weekly exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                        if (isSendEmailOnCronException)
                        {
                            oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                            {
                                TITLE = "Compute_Site_Kpi_Data_Weekly exception: " + ex.Message,
                                MESSAGE = ex.StackTrace
                            });
                        }
                    }

                    try
                    {
                        _logger.LogInformation("Compute_Area_Kpi_Data_Weekly started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, currentDate);
                        var site_weekly_indexes = oService_Mesh.Compute_Area_Kpi_Data_Weekly(new Service_Mesh.Params_Compute_Area_Kpi_Data_Weekly()
                        {
                            DAY = currentDate.Day,
                            YEAR = currentDate.Year,
                            MONTH = currentDate.Month,
                            LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Organization_data_source_kpi,
                        });
                        _logger.LogInformation("Compute_Area_Kpi_Data_Weekly Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, site_weekly_indexes.Exception_Message, site_weekly_indexes.Stack_Trace);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogInformation("Compute_Area_Kpi_Data_Weekly exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                        if (isSendEmailOnCronException)
                        {
                            oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                            {
                                TITLE = "Compute_Area_Kpi_Data_Weekly exception: " + ex.Message,
                                MESSAGE = ex.StackTrace
                            });
                        }
                    }

                    try
                    {
                        _logger.LogInformation("Compute_District_Kpi_Data_Weekly started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, currentDate);
                        var site_weekly_indexes = oService_Mesh.Compute_District_Kpi_Data_Weekly(new Service_Mesh.Params_Compute_District_Kpi_Data_Weekly()
                        {
                            DAY = currentDate.Day,
                            YEAR = currentDate.Year,
                            MONTH = currentDate.Month,
                            LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Organization_data_source_kpi,
                        });
                        _logger.LogInformation("Compute_District_Kpi_Data_Weekly Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, site_weekly_indexes.Exception_Message, site_weekly_indexes.Stack_Trace);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogInformation("Compute_District_Kpi_Data_Weekly exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                        if (isSendEmailOnCronException)
                        {
                            oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                            {
                                TITLE = "Compute_District_Kpi_Data_Weekly exception: " + ex.Message,
                                MESSAGE = ex.StackTrace
                            });
                        }
                    }

                    #endregion
                }

                if (currentDate.Day == 1)
                {
                    #region Monthly Businesses Count

                    try
                    {
                        _logger.LogInformation("Compute_Site_Kpi_Data_Monthly started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, currentDate);
                        var site_monthly_indexes = oService_Mesh.Compute_Site_Kpi_Data_Monthly(new Service_Mesh.Params_Compute_Site_Kpi_Data_Monthly
                        {
                            YEAR = currentDate.Year,
                            MONTH = currentDate.Month,
                            LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Organization_data_source_kpi,
                        });
                        _logger.LogInformation("Compute_Site_Kpi_Data_Monthly Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, site_monthly_indexes.Exception_Message, site_monthly_indexes.Stack_Trace);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogInformation("Compute_Site_Kpi_Data_Monthly exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                        if (isSendEmailOnCronException)
                        {
                            oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                            {
                                TITLE = "Compute_Site_Kpi_Data_Monthly exception: " + ex.Message,
                                MESSAGE = ex.StackTrace
                            });
                        }
                    }

                    try
                    {
                        _logger.LogInformation("Compute_Area_Kpi_Data_Monthly started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, currentDate);
                        var area_monthly_indexes = oService_Mesh.Compute_Area_Kpi_Data_Monthly(new Service_Mesh.Params_Compute_Area_Kpi_Data_Monthly
                        {
                            YEAR = currentDate.Year,
                            MONTH = currentDate.Month,
                            LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Organization_data_source_kpi,
                        });
                        _logger.LogInformation("Compute_Area_Kpi_Data_Monthly Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, area_monthly_indexes.Exception_Message, area_monthly_indexes.Stack_Trace);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogInformation("Compute_Area_Kpi_Data_Monthly exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                        if (isSendEmailOnCronException)
                        {
                            oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                            {
                                TITLE = "Compute_Area_Kpi_Data_Monthly exception: " + ex.Message,
                                MESSAGE = ex.StackTrace
                            });
                        }
                    }

                    try
                    {
                        _logger.LogInformation("Compute_District_Kpi_Data_Monthly started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, currentDate);
                        var district_monthly_indexes = oService_Mesh.Compute_District_Kpi_Data_Monthly(new Service_Mesh.Params_Compute_District_Kpi_Data_Monthly
                        {
                            YEAR = currentDate.Year,
                            MONTH = currentDate.Month,
                            LIST_ORGANIZATION_DATA_SOURCE_KPI = oList_Organization_data_source_kpi,
                        });
                        _logger.LogInformation("Compute_District_Kpi_Data_Monthly Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, district_monthly_indexes.Exception_Message, district_monthly_indexes.Stack_Trace);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogInformation("Compute_District_Kpi_Data_Monthly exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                        if (isSendEmailOnCronException)
                        {
                            oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                            {
                                TITLE = "Compute_District_Kpi_Data_Monthly exception: " + ex.Message,
                                MESSAGE = ex.StackTrace
                            });
                        }
                    }

                    #endregion
                }

                oList_Kpi.ForEach(oKpi =>
                {
                    oKpi.LATEST_DATA_CREATION_DATE = currentDate.ToString();
                });

                oService_Mesh.Edit_Kpi_List(new Service_Mesh.Params_Edit_Kpi_List()
                {
                    List_To_Edit = oList_Kpi
                });
            }
            catch (Exception ex)
            {
                _logger.LogInformation("Business Worker failed with exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                if (isSendEmailOnCronException)
                {
                    oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                    {
                        TITLE = "Business Worker failed with exception: " + ex.Message,
                        MESSAGE = ex.StackTrace
                    });
                }
            }
            _logger.LogInformation("Business Worker finished at: {time}", DateTimeOffset.Now);
        }
        public void Gather_Data_Asset_Dimension()
        {
            #region Setup

            bool isSendEmailOnCronException = ConfigurationManager.AppSettings["IS_SEND_EMAIL_ON_CRON_EXCEPTION"] == "1";
            Service_Mesh.Proxy oService_Mesh = new Service_Mesh.Proxy();
            oService_Mesh.BaseURL = ConfigurationManager.AppSettings["API_GATEWAY_URL"];
            oService_Mesh.Ticket = Crypto.Encrypt(string.Format(Tools.Get_Unique_String() + "[~!@]USERNAME:{0}[~!@]" + Tools.Get_Unique_String() + "[~!@]OWNER_ID:{1}[~!@]" + Tools.Get_Unique_String() + "[~!@]USER_ID:{2}[~!@]" + Tools.Get_Unique_String() + "[~!@]START_DATE:{3}[~!@]" + Tools.Get_Unique_String() + "[~!@]SESSION_PERIOD:{4}[~!@]", "jony.daxd@gmail.com", 1, 1, Tools.GetDateTimeString(DateTime.Now), 1440));

            List<Service_Mesh.Setup> oList_Level_setup = oService_Mesh.Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Service_Mesh.Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
            {
                SETUP_CATEGORY_NAME = "Data Level",
                OWNER_ID = 1
            }).i_Result.List_Setup;

            List<Service_Mesh.Dimension> oList_All_Dimension = oService_Mesh.Get_Dimension_By_OWNER_ID(new Service_Mesh.Params_Get_Dimension_By_OWNER_ID()
            {
                OWNER_ID = 1
            }).i_Result;

            List<Service_Mesh.Dimension> oList_Dimension = oList_All_Dimension.OrderBy(oDimension => DateTime.Parse(oDimension.LATEST_DATA_CREATION_DATE)).ToList();

            DateTime now = DateTime.Now;
            DateTime firstDate = DateTime.Parse(oList_Dimension.FirstOrDefault().LATEST_DATA_CREATION_DATE).AddDays(1);
            _logger.LogInformation("Data Creation Worker started at: {time}", DateTimeOffset.Now);

            #endregion

            while (firstDate <= now)
            {
                List<Service_Mesh.Dimension> oList_Current_Dimension = oList_Dimension.Where(oDimension => DateTime.Parse(oDimension.LATEST_DATA_CREATION_DATE) < firstDate).ToList();

                #region Generate Daily Data

                try
                {
                    _logger.LogInformation("Generate_Dimension_Index_Daily started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                    var space_daily_indexes = oService_Mesh.Generate_Dimension_Index_Daily(new Service_Mesh.Params_Generate_Dimension_Index_Daily()
                    {
                        DAY = firstDate.Day,
                        YEAR = firstDate.Year,
                        MONTH = firstDate.Month,
                        LIST_DIMENSION = oList_Current_Dimension.ToList(),

                    });
                    _logger.LogInformation("Generate_Dimension_Index_Daily Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, space_daily_indexes.Exception_Message, space_daily_indexes.Stack_Trace);
                }
                catch (Exception ex)
                {
                    _logger.LogInformation("Generate_Dimension_Index_Daily exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                    if (isSendEmailOnCronException)
                    {
                        oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                        {
                            TITLE = "Generate_Dimension_Index_Daily exception: " + ex.Message,
                            MESSAGE = ex.StackTrace
                        });
                    }
                }

                #endregion

                #region Generate Weekly Data

                if (firstDate.DayOfWeek == DayOfWeek.Monday)
                {
                    try
                    {
                        _logger.LogInformation("Compute_Dimension_Index_Weekly started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                        var space_weekly_indexes = oService_Mesh.Compute_Dimension_Index_Weekly(new Service_Mesh.Params_Compute_Dimension_Index_Weekly()
                        {
                            DAY = firstDate.Day,
                            YEAR = firstDate.Year,
                            MONTH = firstDate.Month,
                            LIST_DIMENSION = oList_Current_Dimension.ToList(),

                        });
                        _logger.LogInformation("Compute_Dimension_Index_Weekly Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, space_weekly_indexes.Exception_Message, space_weekly_indexes.Stack_Trace);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogInformation("Compute_Dimension_Index_Weekly exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                        if (isSendEmailOnCronException)
                        {
                            oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                            {
                                TITLE = "Compute_Dimension_Index_Weekly exception: " + ex.Message,
                                MESSAGE = ex.StackTrace
                            });
                        }
                    }
                }

                #endregion

                #region Generate Monthly Data

                if (firstDate.Day == 1)
                {
                    try
                    {
                        _logger.LogInformation("Compute_Dimension_Index_Monthly started at: {time}, to create indexes at time: {date}", DateTimeOffset.Now, firstDate);
                        var space_monthly_indexes = oService_Mesh.Compute_Dimension_Index_Monthly(new Service_Mesh.Params_Compute_Dimension_Index_Monthly()
                        {
                            YEAR = firstDate.Year,
                            MONTH = firstDate.Month,
                            DAY = firstDate.Day,
                            LIST_DIMENSION = oList_Current_Dimension.ToList(),

                        });
                        _logger.LogInformation("Compute_Dimension_Index_Monthly Ended at: {time} with Exception: {exception} and Stack Trace: {stacktrace}", DateTimeOffset.Now, space_monthly_indexes.Exception_Message, space_monthly_indexes.Stack_Trace);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogInformation("Compute_Dimension_Index_Monthly exception: {exmessage} and stacktrace: {stacktrace}", ex.Message, ex.StackTrace);
                        if (isSendEmailOnCronException)
                        {
                            oService_Mesh.Send_Support_Email(new Service_Mesh.Params_Send_Support_Email()
                            {
                                TITLE = "Compute_Dimension_Index_Monthly exception: " + ex.Message,
                                MESSAGE = ex.StackTrace
                            });
                        }
                    }
                }

                #endregion

                _logger.LogInformation("Created data for time: {time}", firstDate);

                #region Update LATEST_DATA_CREATION_DATE For Dimension

                oList_Current_Dimension = oList_Current_Dimension.Select(Dimension =>
                {
                    Dimension.LATEST_DATA_CREATION_DATE = Tools.GetDateTimeString(new DateTime(firstDate.Year, firstDate.Month, firstDate.Day, firstDate.Hour, 0, 0));
                    return Dimension;
                }).ToList();
                oService_Mesh.Edit_Dimension_List(new Service_Mesh.Params_Edit_Dimension_List()
                {
                    List_To_Edit = oList_Current_Dimension,
                });

                #endregion

                firstDate = firstDate.AddDays(1);
            }
            _logger.LogInformation("Data Creation Worker finished at: {time}", DateTimeOffset.Now);
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            if (_schedulingMethod == "CronJob")
            {
                cron_daemon.AddJob(ConfigurationManager.AppSettings["DATA_CREATION_CRON_TIME"], () =>
                {
                    Gather_Data_Asset_Data();
                    Gather_Data_Asset_Dimension();
                    Get_Meraki_Api_Data();
                });
                cron_daemon.AddJob(ConfigurationManager.AppSettings["PUBLIC_EVENTS_CRON_TIME"], () =>
                {
                    Get_New_Public_Events();
                });
                cron_daemon.AddJob(ConfigurationManager.AppSettings["TELUS_API_DATA_1_CRON_TIME"], () =>
                {
                    Get_Telus_Api_Data_1();
                });
                cron_daemon.AddJob(ConfigurationManager.AppSettings["TELUS_API_DATA_2_CRON_TIME"], () =>
                {
                    Get_Telus_Api_Data_2();
                });
                cron_daemon.AddJob(ConfigurationManager.AppSettings["BYLAW_COMPLAINTS_CRON_TIME"], () =>
                {
                    Get_New_Bylaw_Complaints();
                });
                cron_daemon.AddJob(ConfigurationManager.AppSettings["BUSINESSES_CRON_TIME"], () =>
                {
                    Get_New_Businesses();
                });

                await Task.Run(() => cron_daemon.Start());
            }
            else
            {
                if (_currentCronSchedule == ConfigurationManager.AppSettings["DATA_CREATION_CRON_TIME"])
                {
                    Gather_Data_Asset_Data();
                    Gather_Data_Asset_Dimension();
                    Get_Meraki_Api_Data();
                }
                if (_currentCronSchedule == ConfigurationManager.AppSettings["BYLAW_COMPLAINTS_CRON_TIME"])
                {
                    Get_New_Bylaw_Complaints();
                }
                if (_currentCronSchedule == ConfigurationManager.AppSettings["TELUS_API_DATA_1_CRON_TIME"])
                {
                    Get_Telus_Api_Data_1();
                }
                if (_currentCronSchedule == ConfigurationManager.AppSettings["TELUS_API_DATA_2_CRON_TIME"])
                {
                    Get_Telus_Api_Data_2();
                }
                if (_currentCronSchedule == ConfigurationManager.AppSettings["PUBLIC_EVENTS_CRON_TIME"])
                {
                    Get_New_Public_Events();
                }
                if (_currentCronSchedule == ConfigurationManager.AppSettings["BUSINESSES_CRON_TIME"])
                {
                    Get_New_Businesses();
                }
            }
        }
        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
