using DemoWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoWebAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        [HttpGet]
        public ActionResult Question() {

            ViewBag.Title = "Who are you so we can say Hello World?";

            return View();
        }

        [HttpPost]
        public ActionResult HelloName(string currentName) { 

            User current = new User(currentName);

            return View(current);
        }
    }
}
