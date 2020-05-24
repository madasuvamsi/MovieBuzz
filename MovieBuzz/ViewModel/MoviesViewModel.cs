using MovieBuzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieBuzz.ViewModel
{
    public class MoviesViewModel
    {
        public IEnumerable<Genre>  Genres { get; set; }

        public Movies Movies { get; set; }

        public string Title
        {
            get
            {
                if (Movies != null && Movies.id != 0)
                    return "Edit Movie";

                return "New Movie";
            }
        }
    }
}