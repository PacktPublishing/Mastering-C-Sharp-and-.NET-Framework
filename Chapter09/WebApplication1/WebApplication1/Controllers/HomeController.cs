using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About PACKT Publishing";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "for more info, visit our site";

            return View();
        }
    }
}