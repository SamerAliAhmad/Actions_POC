using System.Configuration;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace Smart_Living_Dimension_Cron
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            var schedulingMethod = ConfigurationManager.AppSettings["SCHEDULING_METHOD"];

            if (schedulingMethod == "CronJob")
            {
                host.Run();
            }
            else
            {
                await host.StartAsync();
                await host.StopAsync();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddHostedService<Worker>();
                });
    }
}
