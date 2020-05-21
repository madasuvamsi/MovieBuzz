using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using MovieBuzz.Models;

namespace MovieBuzz.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            var customers = GetCustomers();

           return View(customers);
        }

        //Customer/Detail/id
        public ActionResult Detail(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);
            if(customer==null)
            {
                return HttpNotFound();
            }

            return View(customer);
        }


        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { Id = 1, customerName = "John Smith" },
                new Customer { Id = 2, customerName = "Mary Williams" },
                new Customer { Id = 3, customerName = "John Sena" },
                new Customer { Id = 4, customerName = "Tom Cruise" }
            };
        }
    }
}