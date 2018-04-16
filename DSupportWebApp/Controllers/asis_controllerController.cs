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
    public class asis_controllerController : Controller
    {
        private dsupportwebappEntities db = new dsupportwebappEntities();

        // GET: asis_controller
        public ActionResult Index()
        {
            ViewBag.Title = "Index";
            ViewBag.RecordID = "RecordID";
            ViewBag.ControllerName = "Controller";
            ViewBag.Edit = "Edit";
            ViewBag.Details = "Details";
            ViewBag.Delete = "Delete";

            return View(db.asis_controller.ToList());

        }

        // GET: asis_controller/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            asis_controller asis_controller = db.asis_controller.Find(id);
            if (asis_controller == null)
            {
                return HttpNotFound();
            }
            return View(asis_controller);
        }

        // GET: asis_controller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: asis_controller/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDController,ControllerName,IDUserCreated,IDUserModified,DateCreated,DateModified")] asis_controller asis_controller)
        {
            if (ModelState.IsValid)
            {
                db.asis_controller.Add(asis_controller);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(asis_controller);
        }

        // GET: asis_controller/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            asis_controller asis_controller = db.asis_controller.Find(id);
            if (asis_controller == null)
            {
                return HttpNotFound();
            }
            return View(asis_controller);
        }

        // POST: asis_controller/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDController,ControllerName,IDUserCreated,IDUserModified,DateCreated,DateModified")] asis_controller asis_controller)
        {
            if (ModelState.IsValid)
            {
                db.Entry(asis_controller).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(asis_controller);
        }

        // GET: asis_controller/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            asis_controller asis_controller = db.asis_controller.Find(id);
            if (asis_controller == null)
            {
                return HttpNotFound();
            }
            return View(asis_controller);
        }

        // POST: asis_controller/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            asis_controller asis_controller = db.asis_controller.Find(id);
            db.asis_controller.Remove(asis_controller);
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
