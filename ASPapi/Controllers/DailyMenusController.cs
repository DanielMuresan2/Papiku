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
    public class DailyMenusController : Controller
    {
        private MigratingMenuDBContext db = new MigratingMenuDBContext();

        // GET: DailyMenus
        public ActionResult Index()
        {
            return View(db.DailyMenus.ToList());
        }

        // GET: DailyMenus/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DailyMenu dailyMenu = db.DailyMenus.Find(id);
            if (dailyMenu == null)
            {
                return HttpNotFound();
            }
            return View(dailyMenu);
        }

        // GET: DailyMenus/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DailyMenus/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,DayName,CurrentMenu")] DailyMenu dailyMenu)
        {
            //if (string.IsNullOrEmpty(dailyMenu.DayName)) //how to correctly validate?
            //{
            //   ModelState.AddModelError(dailyMenu.DayName, "Empty Day name!");
            //}

            if (ModelState.IsValid)
            {
                db.DailyMenus.Add(dailyMenu);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dailyMenu);
        }

        // GET: DailyMenus/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DailyMenu dailyMenu = db.DailyMenus.Find(id);
            if (dailyMenu == null)
            {
                return HttpNotFound();
            }
            return View(dailyMenu);
        }

        // POST: DailyMenus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,DayName")] DailyMenu dailyMenu)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dailyMenu).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dailyMenu);
        }

        // GET: DailyMenus/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DailyMenu dailyMenu = db.DailyMenus.Find(id);
            if (dailyMenu == null)
            {
                return HttpNotFound();
            }
            return View(dailyMenu);
        }

        // POST: DailyMenus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DailyMenu dailyMenu = db.DailyMenus.Find(id);
            db.DailyMenus.Remove(dailyMenu);
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