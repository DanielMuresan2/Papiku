using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ASPapi.Models;

namespace ASPapi.Controllers
{
    public class CurrentMenusController : Controller
    {
        private MigratingMenuDBContext db = new MigratingMenuDBContext();

        // GET: CurrentMenus
        public ActionResult Index()
        {
            return View(db.CurrentMenus.ToList());
        }

        // GET: CurrentMenus/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CurrentMenu currentMenu = db.CurrentMenus.Find(id);
            if (currentMenu == null)
            {
                return HttpNotFound();
            }
            return View(currentMenu);
        }

        // GET: CurrentMenus/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CurrentMenus/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Dessert,MainDish,SecondDish")] CurrentMenu currentMenu)
        {
            if (ModelState.IsValid)
            {
                db.CurrentMenus.Add(currentMenu);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(currentMenu);
        }

        // GET: CurrentMenus/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CurrentMenu currentMenu = db.CurrentMenus.Find(id);
            if (currentMenu == null)
            {
                return HttpNotFound();
            }
            return View(currentMenu);
        }

        // POST: CurrentMenus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Dessert,MainDish,SecondDish")] CurrentMenu currentMenu)
        {
            if (ModelState.IsValid)
            {
                db.Entry(currentMenu).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(currentMenu);
        }

        // GET: CurrentMenus/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CurrentMenu currentMenu = db.CurrentMenus.Find(id);
            if (currentMenu == null)
            {
                return HttpNotFound();
            }
            return View(currentMenu);
        }

        // POST: CurrentMenus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CurrentMenu currentMenu = db.CurrentMenus.Find(id);
            db.CurrentMenus.Remove(currentMenu);
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
