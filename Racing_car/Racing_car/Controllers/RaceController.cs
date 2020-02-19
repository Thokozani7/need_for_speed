using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Racing_car.Models;

namespace Racing_car.Controllers
{
    public class RaceController : Controller
    {

        private readonly Db_context _Context;

        //constructor
        public RaceController(Db_context context)
        {
            _Context = context;
        }
        // GET: Race

        //leaderboard 
        public ActionResult Index()
        {
            var leaderboard = _Context.Users.ToList();
            return View(leaderboard);
        }
        //creation of a new user
        public ActionResult Create()
        {
            var users = new Users();
            return View(users);
        }
    }
}