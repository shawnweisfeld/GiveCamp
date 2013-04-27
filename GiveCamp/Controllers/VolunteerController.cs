using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GiveCamp.Models;

namespace GiveCamp.Controllers
{
    public class VolunteerController : Controller
    {
        private GiveCampContext db = new GiveCampContext();

        //
        // GET: /Volunteer/
        
        public ActionResult Index()
        {
            return View(db.VolunteerRegistrations.ToList());
        }

        //
        // GET: /Volunteer/Details/5

        public ActionResult Details(int id = 0)
        {
            VolunteerRegistration volunteerregistration = db.VolunteerRegistrations.Find(id);
            if (volunteerregistration == null)
            {
                return HttpNotFound();
            }
            return View(volunteerregistration);
        }

        //
        // GET: /Volunteer/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Volunteer/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(VolunteerRegistration volunteerregistration)
        {
            if (ModelState.IsValid)
            {
                db.VolunteerRegistrations.Add(volunteerregistration);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(volunteerregistration);
        }

        //
        // GET: /Volunteer/Edit/5

        public ActionResult Edit(int id = 0)
        {
            VolunteerRegistration volunteerregistration = db.VolunteerRegistrations.Find(id);
            if (volunteerregistration == null)
            {
                return HttpNotFound();
            }
            return View(volunteerregistration);
        }

        //
        // POST: /Volunteer/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(VolunteerRegistration volunteerregistration)
        {
            if (ModelState.IsValid)
            {
                db.Entry(volunteerregistration).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(volunteerregistration);
        }

        //
        // GET: /Volunteer/Delete/5

        public ActionResult Delete(int id = 0)
        {
            VolunteerRegistration volunteerregistration = db.VolunteerRegistrations.Find(id);
            if (volunteerregistration == null)
            {
                return HttpNotFound();
            }
            return View(volunteerregistration);
        }

        //
        // POST: /Volunteer/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            VolunteerRegistration volunteerregistration = db.VolunteerRegistrations.Find(id);
            db.VolunteerRegistrations.Remove(volunteerregistration);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}