using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Racing_car.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            //Get User Info from Session
            var UserInfo = JsonConvert.DeserializeObject<Sessions>(HttpContext.Session.GetString("sessionUser"));
            return View();
        }

        //setting of player credentials
        public ActionResult SetDetails(string username)
        {
            Sessions s = new Sessions
            {
                UserName = username,
                highScore = 0
            };

            return View(s);
        }
    }
}
