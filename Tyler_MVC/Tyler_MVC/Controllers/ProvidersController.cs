using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tyler_MVC.Controllers
{
    public class ProvidersController : Controller
    {
        // GET: Providers
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Netflix()
        {
            return View();
        }
    }
}