using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieBuzz.Models;

namespace MovieBuzz.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie/Random
        public ActionResult Random()
        {
            var movie = new Movies { movieName = "Avengers" };
            return View(movie);
        }
    }
}