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
    public class asis_menuController : Controller
    {
        private dsupportwebappEntities db = new dsupportwebappEntities();

        // GET: asis_menu
        public ActionResult Index()
        {
            return View(db.asis_menu.ToList());
        }

        // GET: asis_menu/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            asis_menu asis_menu = db.asis_menu.Find(id);
            if (asis_menu == null)
            {
                return HttpNotFound();
            }
            return View(asis_menu);
        }

        // GET: asis_menu/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: asis_menu/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDAsisMenu,IDUserGroup,NameNL,NameEN,Controller,Action,ImgLevel,IDUserCreated,IDUserModified,DateCreated,DateModified")] asis_menu asis_menu)
        {
            if (ModelState.IsValid)
            {
                db.asis_menu.Add(asis_menu);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(asis_menu);
        }

        // GET: asis_menu/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            asis_menu asis_menu = db.asis_menu.Find(id);
            if (asis_menu == null)
            {
                return HttpNotFound();
            }
            return View(asis_menu);
        }

        // POST: asis_menu/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDAsisMenu,IDUserGroup,NameNL,NameEN,Controller,Action,ImgLevel,IDUserCreated,IDUserModified,DateCreated,DateModified")] asis_menu asis_menu)
        {
            if (ModelState.IsValid)
            {
                db.Entry(asis_menu).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(asis_menu);
        }

        // GET: asis_menu/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            asis_menu asis_menu = db.asis_menu.Find(id);
            if (asis_menu == null)
            {
                return HttpNotFound();
            }
            return View(asis_menu);
        }

        // POST: asis_menu/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            asis_menu asis_menu = db.asis_menu.Find(id);
            db.asis_menu.Remove(asis_menu);
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
