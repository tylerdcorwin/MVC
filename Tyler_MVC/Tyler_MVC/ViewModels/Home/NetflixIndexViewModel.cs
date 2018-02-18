using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Tyler_MVC.Models;

namespace Tyler_MVC.ViewModels.Home
{
    public class NetflixIndexViewModel
    {
        public IEnumerable<SelectListItem> NetflixList { get; private set; }
        public Netflix allList { get; set; }
        public NetflixIndexViewModel(IEnumerable<Models.Netflix> listAll)
        {
            NetflixList = listAll.Select(n => new SelectListItem() { Text = n.Title });
            allList = listAll.OrderByDescending(la => la.Title).FirstOrDefault();
        }
    }
}