using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GiveCamp.Models
{
    public class VolunteerRegistration
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        public virtual UserProfile User { get; set; }
        public int UserID { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [StringLength(100)]
        [DisplayName("Team Name")]
        public string TeamName { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(250)]
        [DisplayName("Email")]
        public string Email { get; set; }

        [StringLength(100)]
        [DisplayName("Twitter")]
        public string Twitter { get; set; }

        [StringLength(250)]
        [Url]
        [DisplayName("Website / Blog URL")]
        public string WebsiteUrl { get; set; }

        [StringLength(100)]
        [DisplayName("Phone Number")]

        public string Phone { get; set; }

        [StringLength(100)]
        [DisplayName("Shirt Size")]
        public string ShirtSize { get; set; }

        [StringLength(100)]
        [DisplayName("Diet")]
        public string Diet { get; set; }

        [DisplayName("Student")]
        public bool Student { get; set; }

        [DisplayName("MVP")]
        public bool Mvp { get; set; }
        
        [AllowHtml]
        [DisplayName("Bio")]
        public string Bio { get; set; }

        [AllowHtml]
        [DisplayName("Comments")]
        public string Comments { get; set; }
        
        public bool IsDeveloper { get; set; }
        public bool IsDesigner { get; set; }
        public bool IsProjectManager { get; set; }
        public bool IsBusinessAnalyst { get; set; }
        public bool IsStaff { get; set; }
    }
}