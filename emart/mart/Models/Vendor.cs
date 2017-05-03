using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mart.Models
{
    public class Vendor
    {
        public int VendorID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public int TemplateID { get; set; }
        public virtual Template Template { get; set; }
    }
}