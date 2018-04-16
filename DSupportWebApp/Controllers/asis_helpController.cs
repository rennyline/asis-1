using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DSupportWebApp.Models;

namespace DSupportWebApp.Controllers
{
    public class asis_helpController : Controller
    {
        private dsupportwebappEntities db = new dsupportwebappEntities();

        // GET: asis_help
        public ActionResult Index()
        {
            return View(db.asis_help.ToList());
        }

        // GET: asis_help/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            asis_help asis_help = db.asis_help.Find(id);
            if (asis_help == null)
            {
                return HttpNotFound();
            }
            return View(asis_help);
        }

        // GET: asis_help/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: asis_help/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDHelp,NameNL,NameEN,Controller,IDUserCreated,IDUserModified,DateCreated,DateModified")] asis_help asis_help)
        {
            if (ModelState.IsValid)
            {
                db.asis_help.Add(asis_help);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(asis_help);
        }

        // GET: asis_help/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            asis_help asis_help = db.asis_help.Find(id);
            if (asis_help == null)
            {
                return HttpNotFound();
            }
            return View(asis_help);
        }

        // POST: asis_help/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDHelp,NameNL,NameEN,Controller,IDUserCreated,IDUserModified,DateCreated,DateModified")] asis_help asis_help)
        {
            if (ModelState.IsValid)
            {
                db.Entry(asis_help).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(asis_help);
        }

        // GET: asis_help/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            asis_help asis_help = db.asis_help.Find(id);
            if (asis_help == null)
            {
                return HttpNotFound();
            }
            return View(asis_help);
        }

        // POST: asis_help/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            asis_help asis_help = db.asis_help.Find(id);
            db.asis_help.Remove(asis_help);
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
