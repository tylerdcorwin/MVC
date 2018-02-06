using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InClassWork.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult ShowLang()
        {
            var viewModel = new ViewModels.Home.ShowLangueagesViewModel(CultureInfo.GetCultures(CultureTypes.SpecificCultures));
            return View(viewModel);
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}