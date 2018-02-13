using InClassWork.Models;           //Use our CarFactory Class
using InClassWork.ViewModels.Home;  // Use our viewmodel
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InClassWork.Controllers
{
    public class CarsController : Controller
    {
        // GET: Cars
        public ActionResult CarsList() //this acts as the URL
        {
            //factory -> a new instance of the CarFactory Model
            var factory = new CarFactory();
            //view model -> the viewmodel filled with the cars list
            var viewModel = new CarListViewModel(factory.Cars);

            return View(viewModel);
        }

        public ActionResult ListOfCars(string searchCriteria)
        {
            var factory = new CarFactory();
            IQueryable<Car> cars = factory.Cars.OrderBy(p => p.Model);

            if (searchCriteria != null)
            {
                cars = cars.Where(p => p.Model.Contains(searchCriteria));
            }

            var carlist = cars.Take(10).ToList();
            //var cars = new CarFactory().Cars.ToList();
            return View(carlist);
        }

        public ActionResult Details(int id)
        {
            var factory = new CarFactory();
            Car found = factory.Cars.Where(p => p.Car_ID == id).FirstOrDefault();

            return View(found);
        }
    }

}