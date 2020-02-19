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
<<<<<<< HEAD

        //public ActionResult Create()
        //{
        //    var users = new Users();
        //    return View(users);
        //}

        

        [HttpPost]
        public ActionResult Save([Bind( "Name")]Users user)
        {
            if(ModelState.IsValid)
            {
                _Context.Users.Add(user);
                _Context.SaveChanges();
                return RedirectToAction("index");
            }
            return View("Create", user);
        }

   
=======
        //creation of a new user
        public ActionResult Create()
        {
            var users = new Users();
            return View(users);
        }
>>>>>>> b472d91d0d5359b19a5328fad6b6b83874f1a542
    }
}