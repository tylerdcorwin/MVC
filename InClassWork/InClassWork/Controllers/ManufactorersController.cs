﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using InClassWork.Models;

namespace InClassWork.Controllers
{
    public class ManufactorersController : Controller
    {
        private Lesson8Context db = new Lesson8Context();

        // GET: Manufactorers
        public ActionResult Index()
        {
            return View(db.Manufactorers.ToList());
        }

        // GET: Manufactorers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Manufactorer manufactorer = db.Manufactorers.Find(id);
            if (manufactorer == null)
            {
                return HttpNotFound();
            }
            return View(manufactorer);
        }

        // GET: Manufactorers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Manufactorers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Manufacturer_ID,make")] Manufactorer manufactorer)
        {
            if (ModelState.IsValid)
            {
                db.Manufactorers.Add(manufactorer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(manufactorer);
        }

        // GET: Manufactorers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Manufactorer manufactorer = db.Manufactorers.Find(id);
            if (manufactorer == null)
            {
                return HttpNotFound();
            }
            return View(manufactorer);
        }

        // POST: Manufactorers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Manufacturer_ID,make")] Manufactorer manufactorer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(manufactorer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(manufactorer);
        }

        // GET: Manufactorers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Manufactorer manufactorer = db.Manufactorers.Find(id);
            if (manufactorer == null)
            {
                return HttpNotFound();
            }
            return View(manufactorer);
        }

        // POST: Manufactorers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Manufactorer manufactorer = db.Manufactorers.Find(id);
            db.Manufactorers.Remove(manufactorer);
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
