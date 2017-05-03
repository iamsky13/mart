using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using mart.Models;

namespace mart.Controllers
{
    public class CustomizesController : Controller
    {
        private CustomizeContext db = new CustomizeContext();

        // GET: Customizes
        public ActionResult Index()
        {
            return View(db.Customize.ToList());
        }
        public ActionResult customize()
        {
            return View(db.Customize.ToList());
        }
        // GET: Customizes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customize customize = db.Customize.Find(id);
            if (customize == null)
            {
                return HttpNotFound();
            }
            return View(customize);
        }

        // GET: Customizes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customizes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,text,listnumber")] Customize customize)
        {
            if (ModelState.IsValid)
            {
                db.Customize.Add(customize);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(customize);
        }

        // GET: Customizes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customize customize = db.Customize.Find(id);
            if (customize == null)
            {
                return HttpNotFound();
            }
            return View(customize);
        }

        // POST: Customizes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,text,listnumber")] Customize customize)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customize).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customize);
        }

        // GET: Customizes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customize customize = db.Customize.Find(id);
            if (customize == null)
            {
                return HttpNotFound();
            }
            return View(customize);
        }

        // POST: Customizes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Customize customize = db.Customize.Find(id);
            db.Customize.Remove(customize);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
