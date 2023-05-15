using System;
using SmartrCron;
using System.Threading;
using System.Configuration;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Security_Dimension_Cron
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

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            if (_schedulingMethod == "CronJob")
            {
                await Task.Run(() => cron_daemon.Start());
            }
            else
            {
                // Some_Action();
            }
        }
        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
