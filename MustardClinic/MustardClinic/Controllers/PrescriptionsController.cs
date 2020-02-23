using MustardClinic.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MustardClinic.Controllers
{
    public class PrescriptionsController : Controller
    {
        private PrescriptionsDBContext db = new PrescriptionsDBContext();

        // GET: Prescriptions
        public ActionResult Index()
        {
            return View(db.Prescriptions.ToList());
        }

    }
}