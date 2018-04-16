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
    public class asis_viewController : Controller
    {
        private dsupportwebappEntities db = new dsupportwebappEntities();

        // GET: asis_view
        public ActionResult Index()
        {
            return View(db.asis_view.ToList());
        }

        // GET: asis_view/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            asis_view asis_view = db.asis_view.Find(id);
            if (asis_view == null)
            {
                return HttpNotFound();
            }
            return View(asis_view);
        }

        // GET: asis_view/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: asis_view/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDView,ViewName,IDUserCreated,IDUserModified,DateCreated,DateModified")] asis_view asis_view)
        {
            if (ModelState.IsValid)
            {
                db.asis_view.Add(asis_view);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(asis_view);
        }

        // GET: asis_view/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            asis_view asis_view = db.asis_view.Find(id);
            if (asis_view == null)
            {
                return HttpNotFound();
            }
            return View(asis_view);
        }

        // POST: asis_view/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDView,ViewName,IDUserCreated,IDUserModified,DateCreated,DateModified")] asis_view asis_view)
        {
            if (ModelState.IsValid)
            {
                db.Entry(asis_view).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(asis_view);
        }

        // GET: asis_view/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            asis_view asis_view = db.asis_view.Find(id);
            if (asis_view == null)
            {
                return HttpNotFound();
            }
            return View(asis_view);
        }

        // POST: asis_view/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            asis_view asis_view = db.asis_view.Find(id);
            db.asis_view.Remove(asis_view);
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
