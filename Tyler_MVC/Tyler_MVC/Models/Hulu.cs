using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using System.ComponentModel.DataAnnotations;

namespace Tyler_MVC.Models
{
    public class Hulu
    {
        //db logic
        //ID, title, genre, img url, rating, description, movies/show(bit)
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Image { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public bool Movie { get; set; }  //if move value is 1 : if show value is 0//

    }
}