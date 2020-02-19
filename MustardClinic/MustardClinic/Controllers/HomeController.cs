using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MustardClinic.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title="Mustard Clinic";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About...";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact...";

            return View();
        }

        public ActionResult Providers()
        {
            ViewBag.Message = "Providers...";

            return View();
        }

        public ActionResult Accreditation()
        {
            ViewBag.Message = "Accreditation...";

            return View();
        }

    }

}