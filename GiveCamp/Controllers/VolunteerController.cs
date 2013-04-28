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

        public ActionResult RoleInfo()
        {
            return View();
        }

        [Authorize()]
        public ActionResult Details()
        {
            VolunteerRegistration reg = 
                db.VolunteerRegistrations
                .FirstOrDefault(x => x.User.UserName == User.Identity.Name);

            if (reg == null)
            { 
                reg = new VolunteerRegistration();
                reg.User = db.UserProfiles.First(x => x.UserName == User.Identity.Name);
            }

            ViewBag.ShirtSizeList = GetShirtSizeList(reg);

            return View(reg);
        }

        private IEnumerable<SelectListItem> GetShirtSizeList(VolunteerRegistration reg)
        {
            var items = new string[] { "Small", "Medium", "Large", "X-Large", "2X-Large", "3X-Large" };

            foreach (var item in items)
            {
                yield return new SelectListItem() 
                {
                    Text = item,
                    Value = item,
                    Selected = (reg != null && reg.ShirtSize == item)
                };
            }
        }

        [HttpPost]
        [Authorize()]
        [ValidateAntiForgeryToken]
        public ActionResult Details(VolunteerRegistration volunteerregistration)
        {
            ViewBag.ShirtSizeList = GetShirtSizeList(volunteerregistration);

            if (ModelState.IsValid)
            {
                if (volunteerregistration.Id == 0)
                    db.Entry(volunteerregistration).State = EntityState.Added;
                else
                    db.Entry(volunteerregistration).State = EntityState.Modified;

                db.SaveChanges();
                ViewBag.AlertSuccess = "Changes Saved!";
                return View(db.VolunteerRegistrations
                    .Include(x => x.User)
                    .FirstOrDefault(x => x.UserID == volunteerregistration.Id));
            }
            return View(volunteerregistration);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}