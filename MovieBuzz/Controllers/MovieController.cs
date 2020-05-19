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
        public ActionResult Random()
        {
            var movie = new Movies { movieName = "Avengers" };

            var customers = new List<Customer>()
            {
                new Customer{customerName="Customer 1"},
                new Customer{customerName="Customer 2"}
            };

            var viewModel = new RandomMoviesViewModel 
            {
                Movie=movie,
                Customers=customers
            };
            
            return View(viewModel);
        }

        //Movie/Release
        [Route("Movie/Released/{year:regex(\\d{4})}/{month:regex(\\d{2})}")]

        public ActionResult ReleaseByDate(int year,int month)
        {
            return Content(string.Format("{0}/{1}", year, month));
        }

        
    }
}