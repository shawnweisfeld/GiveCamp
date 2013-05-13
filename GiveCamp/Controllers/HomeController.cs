using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GiveCamp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult News()
        {
            return View();
        }

        public ActionResult Schedule()
        {
            return View();
        }

        public ActionResult Location()
        {
            return View();
        }

        public ActionResult Sponsors()
        {
            return View();
        }

        public ActionResult SponsorInfo()
        {
            return View();
        }

        public ActionResult History()
        {
            return View();
        }
    }
}
