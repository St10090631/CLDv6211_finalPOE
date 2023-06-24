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
    [Authorize(Roles ="Inspector")]

    public class CAR_ST10090631Controller : Controller
    {
        

        private POE_PART2_Ride_You_Rent_ST10090631Entities db = new POE_PART2_Ride_You_Rent_ST10090631Entities();

        // GET: CAR_ST10090631
        public ActionResult Index()
        {
            return View(db.CAR_ST10090631.ToList());
        }

        // GET: CAR_ST10090631/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAR_ST10090631 cAR_ST10090631 = db.CAR_ST10090631.Find(id);
            if (cAR_ST10090631 == null)
            {
                return HttpNotFound();
            }
            return View(cAR_ST10090631);
        }

        // GET: CAR_ST10090631/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CAR_ST10090631/Create      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CarNo,Carmake,Model,BodyType,KilometersTravelled,ServicedKilometers,Avalible")] CAR_ST10090631 cAR_ST10090631)
        {
            if (ModelState.IsValid)
            {
                db.CAR_ST10090631.Add(cAR_ST10090631);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cAR_ST10090631);
        }

        // GET: CAR_ST10090631/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAR_ST10090631 cAR_ST10090631 = db.CAR_ST10090631.Find(id);
            if (cAR_ST10090631 == null)
            {
                return HttpNotFound();
            }
            return View(cAR_ST10090631);
        }

        // POST: CAR_ST10090631/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CarNo,Carmake,Model,BodyType,KilometersTravelled,ServicedKilometers,Avalible")] CAR_ST10090631 cAR_ST10090631)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAR_ST10090631).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cAR_ST10090631);
        }

        // GET: CAR_ST10090631/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAR_ST10090631 cAR_ST10090631 = db.CAR_ST10090631.Find(id);
            if (cAR_ST10090631 == null)
            {
                return HttpNotFound();
            }
            return View(cAR_ST10090631);
        }

        // POST: CAR_ST10090631/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            CAR_ST10090631 cAR_ST10090631 = db.CAR_ST10090631.Find(id);
            db.CAR_ST10090631.Remove(cAR_ST10090631);
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
