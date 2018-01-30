using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tyler_MVC.ViewModels.Home
{
    public class ShowLanguagesViewModel
    {
        public ShowLanguagesViewModel( CultureInfo[] cultures)
        {
            CulturesList = cultures.Select(c => new SelectListItem() { Text = c.EnglishName });
        }
        public IEnumerable<SelectListItem>CulturesList { get; private set; }
    }
}