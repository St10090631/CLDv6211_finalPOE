using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    [Authorize(Roles = "Inspector")]
    public class RENTAL_ST10090631Controller : Controller
    {
        private POE_PART2_Ride_You_Rent_ST10090631Entities db = new POE_PART2_Ride_You_Rent_ST10090631Entities();

        // GET: RENTAL_ST10090631
        public ActionResult Index()
        {
            return View(db.RENTAL_ST10090631.ToList());
        }

        // GET: RENTAL_ST10090631/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RENTAL_ST10090631 rENTAL_ST10090631 = db.RENTAL_ST10090631.Find(id);
            if (rENTAL_ST10090631 == null)
            {
                return HttpNotFound();
            }
            return View(rENTAL_ST10090631);
        }

        // GET: RENTAL_ST10090631/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RENTAL_ST10090631/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RentalId,DriverId,CarNo,InspectorId,RentalFee,StartDate,EndDate")] RENTAL_ST10090631 rENTAL_ST10090631)
        {
            if (ModelState.IsValid)
            {
                db.RENTAL_ST10090631.Add(rENTAL_ST10090631);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rENTAL_ST10090631);
        }

        // GET: RENTAL_ST10090631/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RENTAL_ST10090631 rENTAL_ST10090631 = db.RENTAL_ST10090631.Find(id);
            if (rENTAL_ST10090631 == null)
            {
                return HttpNotFound();
            }
            return View(rENTAL_ST10090631);
        }

        // POST: RENTAL_ST10090631/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RentalId,DriverId,CarNo,InspectorId,RentalFee,StartDate,EndDate")] RENTAL_ST10090631 rENTAL_ST10090631)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rENTAL_ST10090631).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rENTAL_ST10090631);
        }

        // GET: RENTAL_ST10090631/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RENTAL_ST10090631 rENTAL_ST10090631 = db.RENTAL_ST10090631.Find(id);
            if (rENTAL_ST10090631 == null)
            {
                return HttpNotFound();
            }
            return View(rENTAL_ST10090631);
        }

        // POST: RENTAL_ST10090631/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            RENTAL_ST10090631 rENTAL_ST10090631 = db.RENTAL_ST10090631.Find(id);
            _ = db.RENTAL_ST10090631.Remove(rENTAL_ST10090631);
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
