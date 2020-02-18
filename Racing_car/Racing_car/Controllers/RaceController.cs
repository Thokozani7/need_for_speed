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

        public RaceController(Db_context context)
        {
            _Context = context;
        }
        // GET: Race
        public ActionResult Index()
        {
            var leaderboard = _Context.Users.ToList();
            return View(leaderboard);
        }

        public ActionResult Create()
        {
            var users = new Users();
            return View(users);
        }

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

        //[HttpPost]
        //public ActionResult User ([Bind("Name")]Users user)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _Context.Users.Add(user);
        //        _Context.SaveChanges();
        //        return RedirectToAction("game");
        //    }
        //    return View("Create", user);
        //}
    }
}