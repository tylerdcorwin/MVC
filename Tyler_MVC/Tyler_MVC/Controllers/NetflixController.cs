using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tyler_MVC.Models;
using Tyler_MVC.ViewModels.Home;

namespace Tyler_MVC.Controllers
{    
    public class NetflixController : Controller
    {
        private NetflixFactory Db = new NetflixFactory();
        // GET: Netflix
        public ActionResult NetflixList()
        {
            var factory = new NetflixFactory();
            var viewModel = new NetflixIndexViewModel(factory.Netflix);
            return View(viewModel);
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