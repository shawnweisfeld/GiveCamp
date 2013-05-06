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
    public class CharityRegistration
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public virtual UserProfile User { get; set; }
        public int UserID { get; set; }

        [Required]
        [StringLength(250)]
        [DisplayName("Charity Name")]
        public string CharityName { get; set; }

        [StringLength(250)]
        [Url]
        [DisplayName("Current Website")]
        public string WebsiteUrl { get; set; }
        
        [Required]
        [StringLength(100)]
        [DisplayName("Business Contact")]
        public string BusinessContact { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(250)]
        [DisplayName("Business Contact Email")]
        public string BusinessContactEmail { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Business Contact Phone Number")]
        public string BusinessContactPhone { get; set; }

        [StringLength(100)]
        [DisplayName("Alternate Business Contact")]
        public string AltBusinessContact { get; set; }

        [EmailAddress]
        [StringLength(250)]
        [DisplayName("Alternate Business Contact Email")]
        public string AltBusinessContactEmail { get; set; }

        [StringLength(100)]
        [DisplayName("Alternate Business Contact Phone Number")]
        public string AltBusinessContactPhone { get; set; }

        [StringLength(100)]
        [DisplayName("Technical Contact")]
        public string TechnicalContact { get; set; }

        [EmailAddress]
        [StringLength(250)]
        [DisplayName("Technical Contact Email")]
        public string TechnicalContactEmail { get; set; }

        [StringLength(100)]
        [DisplayName("Technical Contact Phone Number")]
        public string TechnicalContactPhone { get; set; }

        [StringLength(50)]
        [DisplayName("Best Time To Call")]
        public string CallTime { get; set; }

        [StringLength(50)]
        [DisplayName("Best Way to Contact")]
        public string ContactMethod { get; set; }

        [StringLength(50)]
        [DisplayName("Application Type")]
        public string ApplicationType { get; set; }

        [AllowHtml]
        [DisplayName("Work Requested")]
        public string WorkRequested { get; set; }

    }
}