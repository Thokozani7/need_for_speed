using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using static Microsoft.AspNetCore.Mvc.IActionResult;
using System.Web;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Racing_car
{
    public class Program
    {

        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });


        public interface IActionResult { }
        
        /*public IActionResult Index()
        {
            const string sessionKey = "FirstSeen";
            DateTime dateFirstSeen;
            var value = HttpContext.Session.GetString(sessionKey);
            if (string.IsNullOrEmpty(value))
            {
                dateFirstSeen = DateTime.Now;
                var serialisedDate = JsonConvert.SerializeObject(dateFirstSeen);
                HttpContext.Session.SetString(sessionKey, serialisedDate);
            }
            else
            {
                dateFirstSeen = JsonConvert.DeserializeObject<DateTime>(value);
            }

            var model = new SessionStateViewModel
            {
                DateSessionStarted = dateFirstSeen,
                Now = DateTime.Now
            };

            return View(model);
        }*/
    }
}
