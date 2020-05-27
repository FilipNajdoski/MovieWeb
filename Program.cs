using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MvcMovie.Models;
using NLog.Web;
using System;

namespace MovieWeb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var logger = NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();
            var host = CreateHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                try
                {
                    logger.Debug("init main");
                    SeedData.Initialize(services);
                }
                catch (Exception ex)
                {
                    logger.Error(ex, "An error occurred seeding the DB.");
                    throw;
                }
                finally
                {
                    NLog.LogManager.Shutdown();
                }
            }

            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>()
                    .ConfigureLogging(loggig =>
                    {
                        loggig.ClearProviders();
                        loggig.SetMinimumLevel(LogLevel.Trace);
                    })
                    .UseNLog();
                });
    }
}
