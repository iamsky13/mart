using SendEmail_MVC5.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;

namespace SendEmail_MVC5.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BulkEmail()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<ActionResult> SendEmail(EmailViewModel model)
        {
            var emailTemplate = "WelcomeEmail";
            var emailSubject = "Welcome to our site.";
            var message = await EMailTemplate(emailTemplate);
            message = message.Replace("@ViewBag.Name", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(model.Username));
            await MessageServices.SendEmailAsync(model.Email, emailSubject, message, model.Attachments);
            ModelState.AddModelError("", "Email successfully sent.");
            return View("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<ActionResult> SendBulkEmail(BulkEmailViewModel model)
        {
            var emailTemplate = "WelcomeEmail";
            var emailSubject = "Welcome to our site.";
            var message = await EMailTemplate(emailTemplate);
            message = message.Replace("@ViewBag.Name", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(model.Username));
            await MessageServices.SendBulkEmailAsync(model.Email, emailSubject, message, model.Attachments);
            ModelState.AddModelError("", "Email successfully sent.");
            return View("BulkEmail");
        }



        public static async Task<string> EMailTemplate(string template)
        {
            var templateFilePath = HostingEnvironment.MapPath("~/Content/templates/") + template + ".cshtml";
            StreamReader objstreamreaderfile = new StreamReader(templateFilePath);
            var body = await objstreamreaderfile.ReadToEndAsync();
            objstreamreaderfile.Close();
            return body;
        }
    }
}