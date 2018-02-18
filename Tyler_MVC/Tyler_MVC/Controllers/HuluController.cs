using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tyler_MVC.Controllers
{
    public class HuluController : Controller
    {
        // GET: Hulu
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Movies()
        {
            return View();
        }

        public ActionResult Shows()
        {
            return View();
        }
    }
}