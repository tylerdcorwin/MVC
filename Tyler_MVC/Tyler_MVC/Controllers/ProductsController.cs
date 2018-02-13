using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tyler_MVC.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Languages()
        {
            var languages = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
            ViewBag.LanguagesList = languages;
            return View();
        }

        //create a list of providers in order to see what movies/shows are available on which service provider
        //public ActionResult Providers()
        //{
        //    string[] providers = new string[3] { "Netflix", "Hulu", "Amazon" };
        //    ViewBag.
        //    return View();
        //}
    }
}