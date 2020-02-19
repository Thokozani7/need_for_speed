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
<<<<<<< HEAD
        // private readonly ILogger<HomeController> _logger;

        // public HomeController(ILogger<HomeController> logger)
        // {
        //     _logger = logger;
        // }
        private readonly Db_context _Context;

        public HomeController(Db_context context)
        {
            _Context = context;
        }

=======
        //index page method
>>>>>>> b472d91d0d5359b19a5328fad6b6b83874f1a542
        public IActionResult Index()
        {
            var sessions = new Sessions() { UserName = "", highScore = 0 };
            return View();
        }

<<<<<<< HEAD
        public IActionResult leaderboard()
        {
            var leaderboard = _Context.Users.ToList();
            return View(leaderboard);
        }

        public IActionResult game()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Game([Bind("Name")]Users user)
        {
               
            if (ModelState.IsValid)
            {
                _Context.Users.Add(user);
                _Context.SaveChanges();
                return RedirectToAction("game");
            }
            return View("index", user);
            //return View("Game", user);
        }

=======
        //game page method
        public IActionResult Game()
        {
            return View();
        }
>>>>>>> b472d91d0d5359b19a5328fad6b6b83874f1a542
    }
}
