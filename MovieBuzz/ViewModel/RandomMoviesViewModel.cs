using MovieBuzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieBuzz.ViewModel
{
    public class RandomMoviesViewModel
    {
        public Movies Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}