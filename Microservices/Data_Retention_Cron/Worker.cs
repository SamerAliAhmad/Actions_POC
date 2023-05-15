using System;
using SmartrCron;
using SmartrTools;
using System.Threading;
using System.Configuration;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Data_Retention_Cron
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

        public void Check_And_Delete_Users_And_Organizations()
        {
            Service_Mesh.Proxy oService_Mesh = new Service_Mesh.Proxy();
            oService_Mesh.BaseURL = ConfigurationManager.AppSettings["API_GATEWAY_URL"];
            oService_Mesh.Ticket = Crypto.Encrypt(string.Format(Tools.Get_Unique_String() + "[~!@]USERNAME:{0}[~!@]" + Tools.Get_Unique_String() + "[~!@]OWNER_ID:{1}[~!@]" + Tools.Get_Unique_String() + "[~!@]USER_ID:{2}[~!@]" + Tools.Get_Unique_String() + "[~!@]START_DATE:{3}[~!@]" + Tools.Get_Unique_String() + "[~!@]SESSION_PERIOD:{4}[~!@]", "jony.daxd@gmail.com", 1, 1, Tools.GetDateTimeString(DateTime.Now), 1440));

            _logger.LogInformation("Worker started at: {time}", DateTimeOffset.Now);
            try
            {
                oService_Mesh.Check_User_Deletion_Status();
            }
            catch (Exception ex)
            {
                _logger.LogInformation("Delete users failed with Exception: {exception} and Stack Trace: {stacktrace}:", ex.Message, ex.StackTrace);
            }
            try
            {
                oService_Mesh.Check_Organization_Deletion_Status();
            }
            catch (Exception ex)
            {
                _logger.LogInformation("Delete organizations failed with Exception: {exception} and Stack Trace: {stacktrace}:", ex.Message, ex.StackTrace);
            }
            _logger.LogInformation("Worker ended at: {time}", DateTimeOffset.Now);
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            if (_schedulingMethod == "CronJob")
            {
                cron_daemon.AddJob(ConfigurationManager.AppSettings["DATA_RETENTION_CRON_TIME"], () => { Check_And_Delete_Users_And_Organizations(); });
                await Task.Run(() => cron_daemon.Start());
            }
            else
            {
                Check_And_Delete_Users_And_Organizations();
            }
        }
        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
