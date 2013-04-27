using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GiveCamp.Models;
using WebMatrix.WebData;

namespace GiveCamp.Controllers
{
    public class VolunteerController : Controller
    {
        private GiveCampContext db = new GiveCampContext();

        //
        // GET: /Volunteer/
        [Authorize(Roles="Admin")]
        public ActionResult Index()
        {
            return View(db.VolunteerRegistrations.ToList());
        }

        public ActionResult RoleInfo()
        {
            return View();
        }

        //
        // GET: /Volunteer/Details/5

        //public ActionResult Details(int id = 0)
        //{
        //    VolunteerRegistration volunteerregistration = db.VolunteerRegistrations.Find(id);
        //    if (volunteerregistration == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(volunteerregistration);
        //}

        //
        // GET: /Volunteer/Create
        [Authorize()]
        public ActionResult Create()
        {
            VolunteerRegistration reg = 
                db.VolunteerRegistrations
                .FirstOrDefault(x => x.User.UserName == User.Identity.Name);

            if (reg == null)
            { 
                reg = new VolunteerRegistration();
                reg.User = db.UserProfiles.First(x => x.UserName == User.Identity.Name);
                db.VolunteerRegistrations.Add(reg);
                db.SaveChanges();
            }

            return RedirectToAction("Edit", new { id = reg.Id });
        }

        //
        // POST: /Volunteer/Create

        //[HttpPost]
        //[Authorize()]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(VolunteerRegistration volunteerregistration)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.VolunteerRegistrations.Add(volunteerregistration);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(volunteerregistration);
        //}

        //
        // GET: /Volunteer/Edit/5
        [Authorize()]
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
        [Authorize()]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(VolunteerRegistration volunteerregistration)
        {
            if (ModelState.IsValid)
            {
                db.Entry(volunteerregistration).State = EntityState.Modified;
                db.SaveChanges();
                ViewBag.Saved = true;
                return View(volunteerregistration);
            }
            return View(volunteerregistration);
        }

        //
        // GET: /Volunteer/Delete/5
        [Authorize(Roles = "Admin")]
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
        [Authorize(Roles = "Admin")]
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