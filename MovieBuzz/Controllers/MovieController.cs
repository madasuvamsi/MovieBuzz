using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.MappingViews;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieBuzz.Models;
using MovieBuzz.ViewModel;

namespace MovieBuzz.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie/Random
        public ActionResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }

        //Movie/Release
        [Route("Movie/Released/{year:regex(\\d{4})}/{month:regex(\\d{2})}")]

        public ActionResult ReleaseByDate(int year,int month)
        {
            return Content(string.Format("{0}/{1}", year, month));
        }

        private IEnumerable<Movies> GetMovies()
        {
            return new List<Movies>
            {
                new Movies{id=1,movieName="Spider Man"},
                new Movies{id=2,movieName="Wonder Women"},
                new Movies{id=3,movieName="Forzen"},
            };
        }

        
    }
}