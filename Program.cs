using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace ServerApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
             // use this to allow command line parameters in the config
            // var configuration = new ConfigurationBuilder()
            // .AddCommandLine(args)
            // .Build();

            // var hostUrl = configuration["hosturl"];
            // if (string.IsNullOrEmpty(hostUrl))
            //     hostUrl = "http://192.168.1.3:8080";

            // var host = new WebHostBuilder()
            // .UseKestrel()     
            // .UseUrls(hostUrl)   // <!-- this 
            // .UseContentRoot(Directory.GetCurrentDirectory())
            // .UseIISIntegration()
            // .UseStartup<Startup>()
            // .UseConfiguration(configuration)
            // .Build();

            // host.Run();
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    var configuration = new ConfigurationBuilder()
                        .AddCommandLine(args)
                        .Build();

                    var hostUrl = configuration["hosturl"];
                    if (string.IsNullOrEmpty(hostUrl))
                        hostUrl = "http://192.168.43.188:8080";

                    webBuilder.UseStartup<Startup>()
                    .UseUrls(hostUrl)
                    .UseConfiguration(configuration);
                });
    }
}
