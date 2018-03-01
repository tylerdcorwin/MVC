using InClassWork.Models;
using System.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InClassWork.ViewModels.Home
{
    //View Model to help create list-driven information
    public class CarListViewModel
    {
        //list of cars
        public IEnumerable<SelectListItem> CarsList { get; private set; }
        //Car Instance of the fastest Car
        public Car FastestCar { get; set; }
        //Constructor (Recieveing a list of cars)
        public CarListViewModel(IEnumerable<Car> cars)
        {
            //generate list of car Models
            CarsList = cars.Select(c => new SelectListItem() { Text = c.Model });
            //pointer to the fastest car
            FastestCar = cars.OrderByDescending(c => c.MaxSpeed).FirstOrDefault();
        }
    }
}