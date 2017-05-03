using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mart.Models
{
    public class Menu
    {   
       
        public int MenuID { get; set; }
        public string MenuText { get; set; }
        public int order { get; set; }
        public string Glyph { get; set; }
        
    }
}