using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Drop3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult DisplayCategories()
        {
            List<SelectListItem> items = new List<SelectListItem>();

            items.Add(new SelectListItem
            {
                Text = "Select Category",
                Value = "0",
                Selected = true
            });

            items.Add(new SelectListItem { Text = "Beverage", Value = "1" });

            items.Add(new SelectListItem { Text = "Condiment", Value = "2" });

            items.Add(new SelectListItem { Text = "Confection", Value = "3" });

            items.Add(new SelectListItem { Text = "Dairy", Value = "4" });

            items.Add(new SelectListItem { Text = "Grains", Value = "5" });

            items.Add(new SelectListItem { Text = "Meat", Value = "6" });

            items.Add(new SelectListItem { Text = "Produce", Value = "7" });

            items.Add(new SelectListItem { Text = "Seafood", Value = "8" });

            ViewBag.CategoryType = items;

            return View();
        }
        public JsonResult GetSubCategories(string id)
        {
            List<SelectListItem> subCategories =
                        new List<SelectListItem>();

            subCategories.Add(new SelectListItem
            {
                Text = "Select",
                Value = "0"
            });

            switch (id)
            {
                case "1":
                    subCategories.Add(new SelectListItem { Text = "Coffee", Value = "1" });
                    subCategories.Add(new SelectListItem { Text = "Energy", Value = "2" });
                    subCategories.Add(new SelectListItem { Text = "Tea", Value = "3" });
                    subCategories.Add(new SelectListItem { Text = "Cold", Value = "4" });
                    break;
                case "2":
                    subCategories.Add(new SelectListItem { Text = "Garlic", Value = "1" });
                    subCategories.Add(new SelectListItem { Text = "Pickles", Value = "2" });
                    subCategories.Add(new SelectListItem { Text = "Raita", Value = "3" });
                    subCategories.Add(new SelectListItem { Text = "Sauce", Value = "4" });
                    break;
                case "3":
                    subCategories.Add(new SelectListItem { Text = "Desserts", Value = "1" });
                    subCategories.Add(new SelectListItem { Text = "Sweet", Value = "2" });
                    break;
                case "4":
                    subCategories.Add(new SelectListItem { Text = "Cheese", Value = "1" });
                    break;
                case "5":
                    subCategories.Add(new SelectListItem { Text = "Crackers", Value = "1" });
                    subCategories.Add(new SelectListItem { Text = "Pasta", Value = "2" });
                    break;
                case "6":
                    subCategories.Add(new SelectListItem { Text = "Prepared", Value = "1" });
                    break;
                case "7":
                    subCategories.Add(new SelectListItem { Text = "Dried Fr", Value = "1" });
                    break;
                case "8":
                    subCategories.Add(new SelectListItem { Text = "Fish", Value = "1" });
                    subCategories.Add(new SelectListItem { Text = "Crab", Value = "2" });
                    break;
                default:
                    subCategories.Add(new SelectListItem { Text = "Coffee", Value = "1" });
                    subCategories.Add(new SelectListItem { Text = "Tea", Value = "3" });
                    subCategories.Add(new SelectListItem { Text = "Colddrinks", Value = "4" });
                    break;
            }

            return Json(new SelectList(subCategories,
                            "Value", "Text"));
        }
    }
}