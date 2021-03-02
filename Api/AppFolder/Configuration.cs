
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

//locals
using BlazorDadJokes.Shared.Configuration;

namespace BlazorDadJokes.Api
{
    public static class Configuration
    {
        [FunctionName("GetNotificationApi")]
        public static IActionResult GetNotificationApi(
                    [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req,
                    ILogger log, ExecutionContext context)
        {
            List<ConfigurationItem> result = new List<ConfigurationItem>();

            var config = new ConfigurationBuilder()
                  .SetBasePath(context.FunctionAppDirectory)
                  // This gives you access to your application settings in your local development environment
                  .AddJsonFile("local.settings.json", optional: true, reloadOnChange: true)
                  // This is what actually gets you the application settings in Azure
                  .AddEnvironmentVariables()
                  .Build();

            //API URK
            ConfigurationItem item = new ConfigurationItem()
            {
                Name = "NotificationAPIUrl",
                ConfigValue = config["apiUrl"]
            };
            result.Add(item);

            //API token
            item = new ConfigurationItem()
            {
                Name = "NotificationAPIToken",
                ConfigValue = config["apiKey"]
            };
            result.Add(item);

            //Contact Us Send To
            item = new ConfigurationItem()
            {
                Name = "ContactSendTo",
                ConfigValue = config["ContactSendTo"]
            };
            result.Add(item);

            //Contact Us subject
            item = new ConfigurationItem()
            {
                Name = "ContactUsSubject",
                ConfigValue = config["ContactUsSubject"]
            };
            result.Add(item);

            //Contact Us email template
            item = new ConfigurationItem()
            {
                Name = "ContactUsEmailTemplate",
                ConfigValue = config["ContactUsEmailTemplate"]
            };
            result.Add(item);

            return new OkObjectResult(result);
        }
    }
}
