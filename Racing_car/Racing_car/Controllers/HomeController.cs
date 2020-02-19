using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Racing_car.Models;

namespace Racing_car.Controllers
{
    public class HomeController : Controller
    {
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

        public IActionResult Index()
        {
            return View();
        }

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

    }
}
