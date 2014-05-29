using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Future.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "This is the ViewBag.Message of the Index Page.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This is the ViewBag.Message of the Index Page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "This is the ViewBag.Message of the Index Page.";

            return View();
        }

        public ActionResult TestingDB()
        {
            ViewBag.Message = "This is the ViewBag.Message of the Index Page.";
            ViewBag.MainPhone = "Number in DB";
            ViewBag.AfterHourPhone = "Number in DB";
            ViewBag.SupportEmail = "Email in DB";
            ViewBag.MarketingEmail = "Email in DB";
            ViewBag.GeneralEmail = "Email in DB";

            return View();
        }
    }
}
