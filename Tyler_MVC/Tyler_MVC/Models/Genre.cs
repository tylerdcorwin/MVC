using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tyler_MVC.Models
{
    public class Genre
    {
        public string GenreType { get; set; }
    }

    public enum Genres
    {
        All,
        Horror,
        Comedy,
        Drama,
        Action,
        Animation,
        Family,
        Western,
        Thriller
    }
}