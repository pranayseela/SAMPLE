using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TEER.Controllers
{
    public class ReportsController : Controller
    {
        // GET: Reports
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DailyReport()
        {
            ViewBag.Message = "Your Daily Reports Page.";
            return View();
        }

        public ActionResult WeeklyReport()
        {
            ViewBag.Message = "Your Weekly Reports Page.";
            return View();
        }

        public ActionResult LocationWiseReport()
        {
            ViewBag.Message = "Your Location Wise Reports Page.";
            return View();
        }

        public ActionResult EmployeeWiseReport()
        {
            ViewBag.Message = "Your Employee Wise Reports Page.";
            return View();
        }

        public ActionResult CustomReport()
        {
            ViewBag.Message = "Your Custom Reports Page.";
            return View();
        }
    }
}