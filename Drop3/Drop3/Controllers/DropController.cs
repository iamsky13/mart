using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Drop3.Controllers
{
   
public class DropController : Controller
    {
        // GET: Drop
        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult DisplayCategories()
        {
            
            List<SelectListItem> items = new List<SelectListItem>();
            //List<SelectListItem> items1 = new List<SelectListItem>();

            items.Add(new SelectListItem
            {
                Text = "--Select One--",
                Value = "0",
                Selected = true
            });

            items.Add(new SelectListItem { Text = "I'am just playing around", Value = "1" });

            items.Add(new SelectListItem { Text = "Selling but with different service", Value = "2" });

            items.Add(new SelectListItem { Text = "I'm selling but not online", Value = "3" });

            items.Add(new SelectListItem { Text = "I'm not selling product yet", Value = "4" });

            //aa
           
            //aa

            //ViewBag.CategoryType1 = items1;
            ViewBag.CategoryType = items;

            return View();
        }
        public JsonResult GetSubCategories(string id)
        {
            List<SelectListItem> subCategories =
                        new List<SelectListItem>();
            //sky
            

            subCategories.Add(new SelectListItem
            {
                Text = "Please Select",
                Value = "0"
            });
            //sky
            
            
            
            switch (id)
            {
                case "1":
                   
                    subCategories.Add(new SelectListItem { Text = "Help Me With This Site", Value = "1" });
                    
                    break;
                case "2":
                    
                    subCategories.Add(new SelectListItem { Text = "Magento", Value = "1" });
                    subCategories.Add(new SelectListItem { Text = "Wix", Value = "2" });
                    subCategories.Add(new SelectListItem { Text = "GoDaddy", Value = "3" });
                    subCategories.Add(new SelectListItem { Text = "BigCommerce", Value = "5" });
                    subCategories.Add(new SelectListItem { Text = "KickStarter", Value = "6" });
                    subCategories.Add(new SelectListItem { Text = "Indiegogo", Value = "7" });
                    subCategories.Add(new SelectListItem { Text = "Other", Value = "4" });
                    
                   
                    break;
                case "3":
                    ViewBag.Message = "WHEN WOULD YOU LIKE TO LAUNCH YOUR STORE?";
                    subCategories.Add(new SelectListItem { Text = "I'm playing around this site", Value = "1" });
                    subCategories.Add(new SelectListItem { Text = "I'm learning and need more time", Value = "2" });
                    subCategories.Add(new SelectListItem { Text = "I'll be ready in a few weeks", Value = "3" });
                    subCategories.Add(new SelectListItem { Text = "I'm ready to go", Value = "4" });
                   
                    break;
                case "4":
                   // string a = "DO YOU HAVE SOMETHING TO SELL?";
                    subCategories.Add(new SelectListItem { Text = "I'm still brainstorming ideas", Value = "1" });
                    subCategories.Add(new SelectListItem { Text = "No. I'm just playing around with shopify", Value = "2" });
                    subCategories.Add(new SelectListItem { Text = "Yes I've product and be ready to launch in few weeks  ", Value = "3" }) ;
                    
                    break;
               
                default:
                    subCategories.Add(new SelectListItem { Text = "Coffee", Value = "1" });
                    subCategories.Add(new SelectListItem { Text = "Tea", Value = "3" });
                    subCategories.Add(new SelectListItem { Text = "Colddrinks", Value = "4" });
                    
                    break;
            }
           
            
            return Json(new SelectList(subCategories, "Value", "Text"));
            
        }
    }
}