using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mart.Models
{
    public class Template
    {
        public int TemplateID { get; set; }
        public double PhoneNumber { get; set; }
        public string Email { get; set; }
        public string FacebookLink { get; set; }
        public string TemplateName { get; set; }
        public virtual IEnumerable<Menu> Menu { get; set; }
        public virtual IEnumerable<Vendor> Vendor { get; set; }
    }
}