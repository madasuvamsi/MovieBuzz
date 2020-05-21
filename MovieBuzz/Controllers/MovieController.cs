using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.MappingViews;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieBuzz.Models;
using MovieBuzz.ViewModel;
using System.Data.Entity;

namespace MovieBuzz.Controllers
{
    public class MovieController : Controller
    {
        private ApplicationDbContext _context;
        public MovieController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Movie/Random
        public ActionResult Index()
        {
            var movies = _context.Movies.Include(c=>c.Genre).ToList();
            return View(movies);
        }

        public ActionResult Detail(int id)
        {
            var movie = _context.Movies.Include(c=>c.Genre).SingleOrDefault(m => m.id == id);
            return View(movie);
        }



        //Movie/Release
        //[Route("Movie/Released/{year:regex(\\d{4})}/{month:regex(\\d{2})}")]

        //public ActionResult ReleaseByDate(int year,int month)
        //{
        //    return Content(string.Format("{0}/{1}", year, month));
        //}

        //private IEnumerable<Movies> GetMovies()
        //{
        //    return new List<Movies>
        //    {
        //        new Movies{id=1,movieName="Spider Man"},
        //        new Movies{id=2,movieName="Wonder Women"},
        //        new Movies{id=3,movieName="Forzen"},
        //    };
        //}

        
    }
}