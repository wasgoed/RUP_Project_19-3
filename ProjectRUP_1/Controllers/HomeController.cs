using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectRUP_1.Controllers
{
    public class ExamController : Controller
    {
        public ActionResult Tentamen()
        {
            ViewBag.Message = "Bekijk je tentamens.";

            return View();
        }
    }
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

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}