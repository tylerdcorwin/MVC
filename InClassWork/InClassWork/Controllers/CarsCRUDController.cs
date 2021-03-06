﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using InClassWork.Models;
using System.Web.Helpers; //added for image funcitonality

namespace InClassWork.Controllers
{
    public class CarsCRUDController : Controller
    {
        private CarFactory db = new CarFactory();

        // GET: CarsCRUD
        public ActionResult Index()
        {
            return View(db.Cars.ToList());
        }

        // GET: CarsCRUD/Details/5
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

        // GET: CarsCRUD/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CarsCRUD/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Car_ID,Model,MaxSpeed")] Car car)
        {
            if (ModelState.IsValid)
            {
                db.Cars.Add(car);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(car);
        }

        // GET: CarsCRUD/Edit/5
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
            return View(car);
        }

        // POST: CarsCRUD/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Car_ID,Model,MaxSpeed")] Car car)
        {
            if (ModelState.IsValid)
            {
                db.Entry(car).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(car);
        }

        // GET: CarsCRUD/Delete/5
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

        // POST: CarsCRUD/Delete/5
        //Acts like a pop-up to confirm the delete (ActionName)
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Car car = db.Cars.Find(id);
            db.Cars.Remove(car);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //When the output is done it will dispose of the temp database created for this session
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public ActionResult Picture(int id)
        {
            //Facroty Instance
            var factory = new CarFactory();

            //find car from DB based on the ID
            var car = factory.Cars.Where(p => p.Car_ID == id).FirstOrDefault();

            //if null get out
            if (car == null)
            {
                return HttpNotFound();
            }

            //Else match found
            var img = new WebImage(string.Format("~/Content/Images/{0}.jpg", car.ImageName));
            img.Resize(100, 100);

            //Return this img for other actions
            return File(img.GetBytes(), "image/jpeg");
        }
    }
}
