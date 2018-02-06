using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web.Mvc;


namespace InClassWork.ViewModels.Home
{
    public class ShowLangueagesViewModel
    {
        public ShowLangueagesViewModel(CultureInfo[] cultures)
        {
            CulturesList = cultures.Select(c => new SelectListItem() { Text = c.EnglishName });
        }
        public IEnumerable<System.Web.Mvc.SelectListItem> CulturesList { get; private set; }
    }
}
