using MustardClinic.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MustardClinic.Controllers
{
    public class DoctorSchedule_Controller : Controller
    {
        private DoctorDBContext db = new DoctorDBContext();
        // GET: Doctor

        public ActionResult Index()
        {
            var doctors = from e in db.Doctors
                            orderby e.ID
                            select e;
            return View(doctors);
        }

        // GET: Doctor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Doctor/Create
        [HttpPost]
        public ActionResult Create(Doctor doc)
        {
            try
            {
                db.Doctors.Add(doc);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Doctor/Edit/5
        public ActionResult Edit(int id)
        {
            var doctor = db.Doctors.Single(m => m.ID == id);
            return View(doctor);
        }

        // POST: Doctor/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                var doctor = db.Doctors.Single(m => m.ID == id);
                if (TryUpdateModel(doctor))
                {
                    //To Do:- database code
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(doctor);
            }
            catch
            {
                return View();
            }
        }
    }
}