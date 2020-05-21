using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using MovieBuzz.Models;
using System.Data.Entity;

namespace MovieBuzz.Controllers
{
    public class CustomerController : Controller
    {

        private ApplicationDbContext _context;

        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Customer
        public ActionResult Index()
        {
            var customers = _context.Customers.Include(c=>c.MembershipType).ToList();

           return View(customers);
        }

        //Customer/Detail/id
        public ActionResult Detail(int id)
        {
            var customer = _context.Customers.Include(c=>c.MembershipType).SingleOrDefault(c => c.Id == id);
            if(customer==null)
            {
                return HttpNotFound();
            }

            return View(customer);
        }


        //private IEnumerable<Customer> GetCustomers()
        //{
        //    return new List<Customer>
        //    {
        //        new Customer { Id = 1, customerName = "John Smith" },
        //        new Customer { Id = 2, customerName = "Mary Williams" },
        //        new Customer { Id = 3, customerName = "John Sena" },
        //        new Customer { Id = 4, customerName = "Tom Cruise" }
        //    };
        //}
    }
}