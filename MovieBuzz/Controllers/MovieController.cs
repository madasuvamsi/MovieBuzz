using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.MappingViews;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieBuzz.Models;
using MovieBuzz.ViewModel;
using System.Data.Entity;
using System.Security.Cryptography.X509Certificates;

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

        public ActionResult New()
        {
          
            var genre = _context.Genres.ToList();
            var movieViewModel = new MoviesViewModel
            {
                Genres = genre

            };
            return View("MovieForm", movieViewModel);
        }

        [HttpPost]
        public ActionResult SaveMovie(Movies movies)
        {
           if(movies.id==0)
            {
                _context.Movies.Add(movies);
            }
            else
            {
                var movieInDb = _context.Movies.Single(m => m.id == movies.id);
                movieInDb.movieName = movies.movieName;
                movieInDb.ReleaseDate = movies.ReleaseDate;
                movieInDb.AddedDate = movies.AddedDate;
                movieInDb.NumbersInStock = movies.NumbersInStock;
                movieInDb.GenreId = movies.GenreId;
            }

            _context.SaveChanges();
            return RedirectToAction("Index", "Movie");
        }

        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.id == id);
            if(movie==null)
            {
                return HttpNotFound();
            }
            var movieViewModel = new MoviesViewModel
            {
                Movies = movie,
                Genres = _context.Genres.ToList()
            };

            return View("MovieForm", movieViewModel);
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