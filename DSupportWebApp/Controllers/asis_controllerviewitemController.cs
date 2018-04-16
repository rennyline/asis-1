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
    public class asis_controllerviewitemController : Controller
    {
        private dsupportwebappEntities db = new dsupportwebappEntities();

        // GET: asis_controllerviewitem
        public ActionResult Index()
        {
            return View(db.asis_controllerviewitem.ToList());
        }

        // GET: asis_controllerviewitem/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            asis_controllerviewitem asis_controllerviewitem = db.asis_controllerviewitem.Find(id);
            if (asis_controllerviewitem == null)
            {
                return HttpNotFound();
            }
            return View(asis_controllerviewitem);
        }

        // GET: asis_controllerviewitem/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: asis_controllerviewitem/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDControllerViewItem,IDControllerView,SortID,NameNL,NameEN,IDUserCreated,IDUserModified,DateCreated,DateModified")] asis_controllerviewitem asis_controllerviewitem)
        {
            if (ModelState.IsValid)
            {
                db.asis_controllerviewitem.Add(asis_controllerviewitem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(asis_controllerviewitem);
        }

        // GET: asis_controllerviewitem/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            asis_controllerviewitem asis_controllerviewitem = db.asis_controllerviewitem.Find(id);
            if (asis_controllerviewitem == null)
            {
                return HttpNotFound();
            }
            return View(asis_controllerviewitem);
        }

        // POST: asis_controllerviewitem/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDControllerViewItem,IDControllerView,SortID,NameNL,NameEN,IDUserCreated,IDUserModified,DateCreated,DateModified")] asis_controllerviewitem asis_controllerviewitem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(asis_controllerviewitem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(asis_controllerviewitem);
        }

        // GET: asis_controllerviewitem/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            asis_controllerviewitem asis_controllerviewitem = db.asis_controllerviewitem.Find(id);
            if (asis_controllerviewitem == null)
            {
                return HttpNotFound();
            }
            return View(asis_controllerviewitem);
        }

        // POST: asis_controllerviewitem/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            asis_controllerviewitem asis_controllerviewitem = db.asis_controllerviewitem.Find(id);
            db.asis_controllerviewitem.Remove(asis_controllerviewitem);
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
