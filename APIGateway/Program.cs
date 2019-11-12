using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace APIGateway
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration((hostingContext, config) => {
                config.SetBasePath(hostingContext.HostingEnvironment.ContentRootPath)

                             .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)

                             .AddJsonFile($"appsettings.{hostingContext.HostingEnvironment.EnvironmentName}.json", true, true)

                             .AddJsonFile("ocelot.json", optional: false, reloadOnChange: true)

                             .AddEnvironmentVariables();

            })
            //.ConfigureLogging((hostingContext, logging) => {
            //    logging.AddConsole();
            //}) 
                .UseStartup<Startup>();
    }
}
