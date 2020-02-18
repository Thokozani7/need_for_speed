﻿using System;
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
        // private readonly ILogger<HomeController> _logger;

        // public HomeController(ILogger<HomeController> logger)
        // {
        //     _logger = logger;
        // }

        public IActionResult Index()
        {

            var sessions = new Sessions() { UserName = "", highScore = 0 };

            //Set User Info into Session
            //HttpContext.Session.SetString("sessionUser", JsonConvert.SerializeObject(sessions));
            return View();
        }

        public IActionResult Game()
        {
            return View();
        }

        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        // }
    }
}
