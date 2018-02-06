using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InClassWork.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            CultureInfo[] languagues = CultureInfo.GetCultures(CultureTypes.SpecificCultures);

            return View(languagues);
        }
    }
}