using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tyler_MVC.Models;
using Tyler_MVC.ViewModels.Home;

namespace Tyler_MVC.Controllers
{
    public class HuluController : Controller
    {

        private HuluFactory Db = new HuluFactory();
        // GET: Hulu
        //public ActionResult HuluList()
        //{
         
        //}




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