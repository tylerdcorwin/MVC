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
    public class Cars2Controller : Controller
    {
        private Lesson8Context db = new Lesson8Context();

        // GET: Cars2
        public ActionResult Index()
        {
            var cars = db.Cars.Include(c => c.Manufactorer);
            return View(cars.ToList());
        }

        // GET: Cars2/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Car car = db.Cars.Find(id);
            if (car == null)
            {
                return HttpNotFound();
            }
            return View(car);
        }

        // GET: Cars2/Create
        public ActionResult Create()
        {
            ViewBag.Manufacturer_ID = new SelectList(db.Manufactorers, "Manufacturer_ID", "make");
            return View();
        }

        // POST: Cars2/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Car_ID,Model,MaxSpeed,ImageName,Manufacturer_ID")] Car car)
        {
            if (ModelState.IsValid)
            {
                db.Cars.Add(car);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Manufacturer_ID = new SelectList(db.Manufactorers, "Manufacturer_ID", "make", car.Manufacturer_ID);
            return View(car);
        }

        // GET: Cars2/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Car car = db.Cars.Find(id);
            if (car == null)
            {
                return HttpNotFound();
            }
            ViewBag.Manufacturer_ID = new SelectList(db.Manufactorers, "Manufacturer_ID", "make", car.Manufacturer_ID);
            return View(car);
        }

        // POST: Cars2/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Car_ID,Model,MaxSpeed,ImageName,Manufacturer_ID")] Car car)
        {
            if (ModelState.IsValid)
            {
                db.Entry(car).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Manufacturer_ID = new SelectList(db.Manufactorers, "Manufacturer_ID", "make", car.Manufacturer_ID);
            return View(car);
        }

        // GET: Cars2/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Car car = db.Cars.Find(id);
            if (car == null)
            {
                return HttpNotFound();
            }
            return View(car);
        }

        // POST: Cars2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Car car = db.Cars.Find(id);
            db.Cars.Remove(car);
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
