using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GiveCamp.ViewModels.Home
{
    public class ContactViewModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
        public string Subject { get; set; }

        [StringLength(100), Required]
        [UIHint("LimitedTextArea")]
        public string Message { get; set; }
    }
}