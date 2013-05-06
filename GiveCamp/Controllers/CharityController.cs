using GiveCamp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace GiveCamp.Controllers
{
    public class CharityController : Controller
    {
        private GiveCampContext db = new GiveCampContext();

        public ActionResult RoleInfo()
        {
            return View();
        }

        [Authorize()]
        public ActionResult Details()
        {
            CharityRegistration reg =
                db.CharityRegistrations
                .FirstOrDefault(x => x.User.UserName == User.Identity.Name);

            if (reg == null)
            {
                reg = new CharityRegistration();
                reg.User = db.UserProfiles.First(x => x.UserName == User.Identity.Name);
            }

            return View(reg);
        }



        [HttpPost]
        [Authorize()]
        [ValidateAntiForgeryToken]
        public ActionResult Details(CharityRegistration charityReg)
        {
            if (ModelState.IsValid)
            {
                if (charityReg.Id == 0)
                    db.Entry(charityReg).State = EntityState.Added;
                else
                    db.Entry(charityReg).State = EntityState.Modified;

                db.SaveChanges();
                ViewBag.AlertSuccess = "Changes Saved!";
                return View(db.CharityRegistrations
                    .Include(x => x.User)
                    .FirstOrDefault(x => x.UserID == charityReg.Id));
            }
            return View(charityReg);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
