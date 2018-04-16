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
    public class asis_viewitemController : Controller
    {
        private dsupportwebappEntities db = new dsupportwebappEntities();

        // GET: asis_viewitem
        public ActionResult Index()
        {
            return View(db.asis_viewitem.ToList());
        }

        // GET: asis_viewitem/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            asis_viewitem asis_viewitem = db.asis_viewitem.Find(id);
            if (asis_viewitem == null)
            {
                return HttpNotFound();
            }
            return View(asis_viewitem);
        }

        // GET: asis_viewitem/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: asis_viewitem/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDViewItem,IDView,SortID,Words,IDUserCreated,IDUserModified,DateCreated,DateModified")] asis_viewitem asis_viewitem)
        {
            if (ModelState.IsValid)
            {
                db.asis_viewitem.Add(asis_viewitem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(asis_viewitem);
        }

        // GET: asis_viewitem/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            asis_viewitem asis_viewitem = db.asis_viewitem.Find(id);
            if (asis_viewitem == null)
            {
                return HttpNotFound();
            }
            return View(asis_viewitem);
        }

        // POST: asis_viewitem/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDViewItem,IDView,SortID,Words,IDUserCreated,IDUserModified,DateCreated,DateModified")] asis_viewitem asis_viewitem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(asis_viewitem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(asis_viewitem);
        }

        // GET: asis_viewitem/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            asis_viewitem asis_viewitem = db.asis_viewitem.Find(id);
            if (asis_viewitem == null)
            {
                return HttpNotFound();
            }
            return View(asis_viewitem);
        }

        // POST: asis_viewitem/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            asis_viewitem asis_viewitem = db.asis_viewitem.Find(id);
            db.asis_viewitem.Remove(asis_viewitem);
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
