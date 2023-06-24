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
    public class RETURN_ST10090631Controller : Controller
    {
        private POE_PART2_Ride_You_Rent_ST10090631Entities db = new POE_PART2_Ride_You_Rent_ST10090631Entities();

        // GET: RETURN_ST10090631
        public ActionResult Index()
        {
            return View(db.RETURN_ST10090631.ToList());
        }

        // GET: RETURN_ST10090631/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RETURN_ST10090631 rETURN_ST10090631 = db.RETURN_ST10090631.Find(id);
            if (rETURN_ST10090631 == null)
            {
                return HttpNotFound();
            }
            return View(rETURN_ST10090631);
        }

        // GET: RETURN_ST10090631/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RETURN_ST10090631/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ReturnId,DriverId,CarNo,InspectorId,ReturnDate,ElapsedDate,Fine")] RETURN_ST10090631 rETURN_ST10090631)
        {
            if (ModelState.IsValid)
            {
                db.RETURN_ST10090631.Add(rETURN_ST10090631);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rETURN_ST10090631);
        }

        // GET: RETURN_ST10090631/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RETURN_ST10090631 rETURN_ST10090631 = db.RETURN_ST10090631.Find(id);
            if (rETURN_ST10090631 == null)
            {
                return HttpNotFound();
            }
            return View(rETURN_ST10090631);
        }

        // POST: RETURN_ST10090631/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ReturnId,DriverId,CarNo,InspectorId,ReturnDate,ElapsedDate,Fine")] RETURN_ST10090631 rETURN_ST10090631)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rETURN_ST10090631).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rETURN_ST10090631);
        }

        // GET: RETURN_ST10090631/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RETURN_ST10090631 rETURN_ST10090631 = db.RETURN_ST10090631.Find(id);
            if (rETURN_ST10090631 == null)
            {
                return HttpNotFound();
            }
            return View(rETURN_ST10090631);
        }

        // POST: RETURN_ST10090631/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RETURN_ST10090631 rETURN_ST10090631 = db.RETURN_ST10090631.Find(id);
            db.RETURN_ST10090631.Remove(rETURN_ST10090631);
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
