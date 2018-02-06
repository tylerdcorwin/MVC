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
    }
}