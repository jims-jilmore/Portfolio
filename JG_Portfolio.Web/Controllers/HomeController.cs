using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JG_Portfolio.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Projects()
        {
            ViewBag.Message = "Your Projects Page.";

            return View();
        }

        public ActionResult Resume()
        {
            ViewBag.Message = "Your Resume Page";

            return View();
        }
    }
}