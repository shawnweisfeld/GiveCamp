using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GiveCamp.Models
{
    public class GiveCampContext : DbContext
    {
        public GiveCampContext()
        {
            Database.SetInitializer(new GiveCampContextInitializer());
        }

        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<VolunteerRegistration> VolunteerRegistrations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


        }
    }
}