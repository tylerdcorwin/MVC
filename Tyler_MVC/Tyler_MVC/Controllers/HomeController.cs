using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tyler_MVC.Controllers
{
    public class HomeController : Controller
    {
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

        public ActionResult MovieLibrary()
        {
            ViewBag.Message = "Your Movie Library";

            return View();
        }

        public ActionResult ShowLibrary()
        {
            ViewBag.Message = "Your Show Library";

            return View();
        }

        public ActionResult Languages()
        {
            //var languages = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
            //ViewBag.LanguagesList = languages;

            return View();
        }
    }
}