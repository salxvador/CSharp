using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,QUOTE")] Insuree insuree)
        {
            // declare value for quote since I removed it from view form
            insuree.QUOTE = 50;

            if (ModelState.IsValid)
            {
                // age calculations:
                TimeSpan rawAge = DateTime.Now - insuree.DateOfBirth;
                // divide by 365 to convert rawAge to years.
                int age = rawAge.Days / 365;
                
                // add 100 for being under 18, or add 50 for being under 25:
                if (age <= 18) { insuree.QUOTE += 100; }
                else if (age > 18 && age <= 25) { insuree.QUOTE += 50; }
                //add 25 for being alive
                else { insuree.QUOTE += 25; }

                // Car age evaluations
                if (insuree.CarYear < 2000) { insuree.QUOTE += 25; }
                if (insuree.CarYear > 2015) { insuree.QUOTE += 25; }

                // Evals for porsche and porsche carrera
                if (insuree.CarMake.ToLower() == "porsche") { insuree.QUOTE += 25; }
                if (insuree.CarMake.ToLower() == "porsche" && insuree.CarModel.ToLower() == "carrera")
                {
                    insuree.QUOTE += 25;
                }

                // Add 10 for each speeding ticket
                for (int i=0; i<insuree.SpeedingTickets; i++)
                {
                    insuree.QUOTE += 10;
                }

                // add 25% for DUI
                if (insuree.DUI) { insuree.QUOTE = insuree.QUOTE * 1.25m; }

                // add 50% for full coverage (CoverageType)
                if (insuree.CoverageType) { insuree.QUOTE = insuree.QUOTE * 1.5m; }

                // add object after quote has been calculated, save changes.
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,QUOTE")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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
