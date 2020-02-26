using MustardClinic.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MustardClinic.Models;
using System.Net;
using System.Data.Entity;

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

        // GET: Prescriptions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Prescriptions prescriptions = db.Prescriptions.Find(id);
            if (prescriptions == null)
            {
                return HttpNotFound();
            }
            return View(prescriptions);
        }

        // GET: Prescriptions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Prescriptions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DrugID,DrugName,DrugDose")] Prescriptions prescriptions)
        {
            if (ModelState.IsValid)
            {
                db.Prescriptions.Add(prescriptions);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(prescriptions);
        }

        // GET: Prescriptions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Prescriptions prescriptions = db.Prescriptions.Find(id);
            if (prescriptions == null)
            {
                return HttpNotFound();
            }
            return View(prescriptions);
        }

        // POST: Prescriptions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DrugID,DrugName,DrugDose")] Prescriptions prescriptions)
        {
            if (ModelState.IsValid)
            {
                db.Entry(prescriptions).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(prescriptions);
        }

        // GET: Prescriptions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Prescriptions prescriptions = db.Prescriptions.Find(id);
            if (prescriptions == null)
            {
                return HttpNotFound();
            }
            return View(prescriptions);
        }

        // POST: Prescriptions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Prescriptions prescriptions = db.Prescriptions.Find(id);
            db.Prescriptions.Remove(prescriptions);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}