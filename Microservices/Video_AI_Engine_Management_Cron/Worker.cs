using System;
using SmartrCron;
using SmartrTools;
using System.Threading;
using System.Configuration;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.SignalR.Client;

namespace Video_AI_Engine_Management_Cron
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

        #region SignalR
        public HubConnection oHubConnection;
        public string Backend_User_Identifier;
        public string Frontend_User_Identifier;
        public void Initialize_SignalR_Hub_Connection(string Hub)
        {
            this.oHubConnection = new HubConnectionBuilder()
                    .WithUrl($"{ConfigurationManager.AppSettings["REALTIME_SERVER_URL"]}/{Hub}")
                    .WithAutomaticReconnect()
                    .Build();
        }
        public void Open_SignalR_Connection()
        {
            this.oHubConnection.StartAsync().ContinueWith(task =>
            {
                if (!task.IsFaulted)
                {
                    this.oHubConnection.InvokeAsync("Connect_User", this.Backend_User_Identifier);
                }
            }).Wait();
        }
        public void Close_SignalR_Connection()
        {
            this.oHubConnection.InvokeAsync("Disconnect_User", this.Backend_User_Identifier);
            this.oHubConnection.StopAsync();
        }
        public void Invoke_SignalR_Server(string method, object body)
        {
            this.oHubConnection.InvokeAsync(method, body);
        }
        #endregion
        public void Update_All_Alerts()
        {
            Service_Mesh.Proxy oService_Mesh = new Service_Mesh.Proxy();
            oService_Mesh.BaseURL = ConfigurationManager.AppSettings["API_GATEWAY_URL"];
            oService_Mesh.Ticket = Crypto.Encrypt(string.Format(Tools.Get_Unique_String() + "[~!@]USERNAME:{0}[~!@]" + Tools.Get_Unique_String() + "[~!@]OWNER_ID:{1}[~!@]" + Tools.Get_Unique_String() + "[~!@]USER_ID:{2}[~!@]" + Tools.Get_Unique_String() + "[~!@]START_DATE:{3}[~!@]" + Tools.Get_Unique_String() + "[~!@]SESSION_PERIOD:{4}[~!@]", "jony.daxd@gmail.com", 1, 1, Tools.GetDateTimeString(DateTime.Now), 1440));

            var update_alerts = Task.Run(() =>
            {
                try
                {
                    oService_Mesh.Update_Alerts();
                }
                catch
                { };
            });
            var update_alerts_custom = Task.Run(() =>
            {
                try
                {
                    oService_Mesh.Update_Alerts_Custom();
                }
                catch { };
            });
            var update_facial_recognition_alerts = Task.Run(() =>
            {
                try
                {
                    oService_Mesh.Update_Facial_Recognition_Alerts();
                }
                catch { };
            });
            var update_license_plate_recognition_alerts = Task.Run(() =>
            {
                try
                {
                    oService_Mesh.Update_License_Plate_Recognition_Alerts();
                }
                catch { };
            });

            Task.WaitAll(update_alerts, update_alerts_custom, update_facial_recognition_alerts, update_license_plate_recognition_alerts);

            Initialize_SignalR_Hub_Connection("datahub");
            Open_SignalR_Connection();

            Invoke_SignalR_Server("Send_Data", new
            {
                Message = "Alerts Updated",
                USER_IDENTIFIER = this.Frontend_User_Identifier,
                Event_Name = "Receive_data"
            });

            Close_SignalR_Connection();
            _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            if (_schedulingMethod == "CronJob")
            {
                cron_daemon.AddJob(ConfigurationManager.AppSettings["VIDEO_AI_ENGINE_MANAGEMENT_CRON_TIME"], () => { Update_All_Alerts(); });
                await Task.Run(() => cron_daemon.Start());
            }
            else
            {
                Update_All_Alerts();
            }
        }
        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
