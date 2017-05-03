using mart.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace mart.Controllers
{
    public class ShopController : Controller

    {
        private TemplateContext db = new TemplateContext();
        // GET: Shop
        public ActionResult Index(string id)
        {

            string vendor = id;
            var path = Path.Combine(@"~/Views/",id,"index.cshtml");

            //var uri3 =path;
            return View(path);
        }

        public ActionResult Createshop()
        {
            return View("~/Views/shop/createshop.cshtml");
        }

        public ActionResult createfolder()
        {
            Directory.CreateDirectory(Server.MapPath(@"~/aakash"));
            
            
            return View("~/Views/shop/createshop.cshtml");
        }

        public ActionResult sky(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Template template = db.Template.Find(id);
            if (template == null)
            {
                return HttpNotFound();
            }
            return View(template);
        }
    }
}