using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using newsBackEnd.Models;

namespace newsBackEnd.Controllers
{
    public class HomeController : Controller
    {
        private newsEntities db = new newsEntities();
        public ActionResult Index()
        {
            return View(db.cats.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}