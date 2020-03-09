using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MustardClinic.Context;
using MustardClinic.Models;

namespace MustardClinic.Controllers
{
    public class NarcoticsController : Controller
    {
        private NarcoticDBContext db = new NarcoticDBContext();

        // GET: Narcotics
        public ActionResult Index()
        {
            return View(db.Narcotics.ToList());
        }

        // GET: Narcotics/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Narcotic narcotic = db.Narcotics.Find(id);
            if (narcotic == null)
            {
                return HttpNotFound();
            }
            return View(narcotic);
        }

        // GET: Narcotics/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Narcotics/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DrugID,DrugName,DrugDose")] Narcotic narcotic)
        {
            if (ModelState.IsValid)
            {
                db.Narcotics.Add(narcotic);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(narcotic);
        }

        // GET: Narcotics/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Narcotic narcotic = db.Narcotics.Find(id);
            if (narcotic == null)
            {
                return HttpNotFound();
            }
            return View(narcotic);
        }

        // POST: Narcotics/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DrugID,DrugName,DrugDose")] Narcotic narcotic)
        {
            if (ModelState.IsValid)
            {
                db.Entry(narcotic).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(narcotic);
        }

        // GET: Narcotics/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Narcotic narcotic = db.Narcotics.Find(id);
            if (narcotic == null)
            {
                return HttpNotFound();
            }
            return View(narcotic);
        }

        // POST: Narcotics/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Narcotic narcotic = db.Narcotics.Find(id);
            db.Narcotics.Remove(narcotic);
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
