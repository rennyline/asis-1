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
    public class asis_controllerviewusergroupController : Controller
    {
        private dsupportwebappEntities db = new dsupportwebappEntities();

        // GET: asis_controllerviewusergroup
        public ActionResult Index()
        {
            return View(db.asis_controllerviewusergroup.ToList());
        }

        // GET: asis_controllerviewusergroup/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            asis_controllerviewusergroup asis_controllerviewusergroup = db.asis_controllerviewusergroup.Find(id);
            if (asis_controllerviewusergroup == null)
            {
                return HttpNotFound();
            }
            return View(asis_controllerviewusergroup);
        }

        // GET: asis_controllerviewusergroup/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: asis_controllerviewusergroup/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDControllerViewUser,IDControllerView,IDUserGroup,IDUserCreated,IDUserModified,DateCreated,DateModified")] asis_controllerviewusergroup asis_controllerviewusergroup)
        {
            if (ModelState.IsValid)
            {
                db.asis_controllerviewusergroup.Add(asis_controllerviewusergroup);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(asis_controllerviewusergroup);
        }

        // GET: asis_controllerviewusergroup/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            asis_controllerviewusergroup asis_controllerviewusergroup = db.asis_controllerviewusergroup.Find(id);
            if (asis_controllerviewusergroup == null)
            {
                return HttpNotFound();
            }
            return View(asis_controllerviewusergroup);
        }

        // POST: asis_controllerviewusergroup/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDControllerViewUser,IDControllerView,IDUserGroup,IDUserCreated,IDUserModified,DateCreated,DateModified")] asis_controllerviewusergroup asis_controllerviewusergroup)
        {
            if (ModelState.IsValid)
            {
                db.Entry(asis_controllerviewusergroup).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(asis_controllerviewusergroup);
        }

        // GET: asis_controllerviewusergroup/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            asis_controllerviewusergroup asis_controllerviewusergroup = db.asis_controllerviewusergroup.Find(id);
            if (asis_controllerviewusergroup == null)
            {
                return HttpNotFound();
            }
            return View(asis_controllerviewusergroup);
        }

        // POST: asis_controllerviewusergroup/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            asis_controllerviewusergroup asis_controllerviewusergroup = db.asis_controllerviewusergroup.Find(id);
            db.asis_controllerviewusergroup.Remove(asis_controllerviewusergroup);
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
