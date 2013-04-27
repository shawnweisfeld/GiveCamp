using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GiveCamp.Models
{
    public class VolunteerRegistration
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public virtual UserProfile User { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TeamName { get; set; }
        public string Email { get; set; }
        public string Twitter { get; set; }
        public string WebsiteUrl { get; set; }
        public string Phone { get; set; }
        public string ShirtSize { get; set; }
        public string Diet { get; set; }
        public bool Student { get; set; }
        public bool Mvp { get; set; }
        public string SkillLevel { get; set; }
        public string Bio { get; set; }
        public string Comments { get; set; }
        public bool IsDeveloper { get; set; }
        public bool IsDesigner { get; set; }
        public bool IsProjectManager { get; set; }
        public bool IsBusinessAnalyst { get; set; }
        public bool IsStaff { get; set; }
    }
}