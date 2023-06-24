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

    public class DRIVER_ST10090631Controller : Controller
    {
        private POE_PART2_Ride_You_Rent_ST10090631Entities db = new POE_PART2_Ride_You_Rent_ST10090631Entities();

        // GET: DRIVER_ST10090631
        public ActionResult Index()
        {
            return View(db.DRIVER_ST10090631.ToList());
        }

        // GET: DRIVER_ST10090631/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DRIVER_ST10090631 dRIVER_ST10090631 = db.DRIVER_ST10090631.Find(id);
            if (dRIVER_ST10090631 == null)
            {
                return HttpNotFound();
            }
            return View(dRIVER_ST10090631);
        }

        // GET: DRIVER_ST10090631/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DRIVER_ST10090631/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DriverId,DriverName,Address,Email,Mobile")] DRIVER_ST10090631 dRIVER_ST10090631)
        {
            if (ModelState.IsValid)
            {
                db.DRIVER_ST10090631.Add(dRIVER_ST10090631);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dRIVER_ST10090631);
        }

        // GET: DRIVER_ST10090631/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DRIVER_ST10090631 dRIVER_ST10090631 = db.DRIVER_ST10090631.Find(id);
            if (dRIVER_ST10090631 == null)
            {
                return HttpNotFound();
            }
            return View(dRIVER_ST10090631);
        }

        // POST: DRIVER_ST10090631/Edit/5     
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DriverId,DriverName,Address,Email,Mobile")] DRIVER_ST10090631 dRIVER_ST10090631)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dRIVER_ST10090631).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dRIVER_ST10090631);
        }

        // GET: DRIVER_ST10090631/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DRIVER_ST10090631 dRIVER_ST10090631 = db.DRIVER_ST10090631.Find(id);
            if (dRIVER_ST10090631 == null)
            {
                return HttpNotFound();
            }
            return View(dRIVER_ST10090631);
        }

        // POST: DRIVER_ST10090631/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            DRIVER_ST10090631 dRIVER_ST10090631 = db.DRIVER_ST10090631.Find(id);
            db.DRIVER_ST10090631.Remove(dRIVER_ST10090631);
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
