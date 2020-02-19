using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Racing_car.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Racing_car.Controllers
{
    public class HomeController : Controller
    {
        //index page method
        public IActionResult Index()
        {
            var sessions = new Sessions() { UserName = "", highScore = 0 };
            return View();
        }

        //game page method
        public IActionResult Game()
        {
            return View();
        }
    }
}
