using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SendEmail_MVC5.Models
{
    public class EmailViewModel
    {
        [Required]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Attachment")]
        public List<HttpPostedFileBase> Attachments { get; set; }
    }

    public class BulkEmailViewModel
    {
        [Required]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required]
        [Display(Name = "Email")]
        public string[] Email { get; set; }

        [Display(Name = "Attachment")]
        public List<HttpPostedFileBase> Attachments { get; set; }
    }

}