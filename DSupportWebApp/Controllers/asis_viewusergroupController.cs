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
    public class asis_viewusergroupController : Controller
    {
        private dsupportwebappEntities db = new dsupportwebappEntities();

        // GET: asis_viewusergroup
        public ActionResult Index()
        {
            return View(db.asis_viewusergroup.ToList());
        }

        // GET: asis_viewusergroup/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            asis_viewusergroup asis_viewusergroup = db.asis_viewusergroup.Find(id);
            if (asis_viewusergroup == null)
            {
                return HttpNotFound();
            }
            return View(asis_viewusergroup);
        }

        // GET: asis_viewusergroup/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: asis_viewusergroup/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDViewUserGroup,IDView,IDUserGroup,IDUserCreated,IDUserModified,DateCreated,DateModified")] asis_viewusergroup asis_viewusergroup)
        {
            if (ModelState.IsValid)
            {
                db.asis_viewusergroup.Add(asis_viewusergroup);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(asis_viewusergroup);
        }

        // GET: asis_viewusergroup/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            asis_viewusergroup asis_viewusergroup = db.asis_viewusergroup.Find(id);
            if (asis_viewusergroup == null)
            {
                return HttpNotFound();
            }
            return View(asis_viewusergroup);
        }

        // POST: asis_viewusergroup/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDViewUserGroup,IDView,IDUserGroup,IDUserCreated,IDUserModified,DateCreated,DateModified")] asis_viewusergroup asis_viewusergroup)
        {
            if (ModelState.IsValid)
            {
                db.Entry(asis_viewusergroup).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(asis_viewusergroup);
        }

        // GET: asis_viewusergroup/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            asis_viewusergroup asis_viewusergroup = db.asis_viewusergroup.Find(id);
            if (asis_viewusergroup == null)
            {
                return HttpNotFound();
            }
            return View(asis_viewusergroup);
        }

        // POST: asis_viewusergroup/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            asis_viewusergroup asis_viewusergroup = db.asis_viewusergroup.Find(id);
            db.asis_viewusergroup.Remove(asis_viewusergroup);
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
