using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TEER.Controllers
{
    public class DisclaimerController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(int id = 0)
        {
            @ViewBag.Message = "Thanks for accepting term and condition.";
            return RedirectToAction("Index","Login");
            
        }
    }
}