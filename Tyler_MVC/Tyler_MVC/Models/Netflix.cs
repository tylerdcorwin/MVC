using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tyler_MVC.Models
{
    public class Netflix
    {
        //This is where the db logic goes
        //ID, title, img url, rating, movies/show(bit)
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Rating { get; set; }
        public bool Movie { get; set; }  //if move value is 1 : if show value is 0//
    }
}