using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using MovieBuzz.Models;
using System.Data.Entity;
using MovieBuzz.ViewModel;
using System.Runtime.InteropServices;

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

        public ActionResult New()
        {
            var membershitypes = _context.MembershipTypes.ToList();
            var viewModel = new CustomerViewModel
            {
                customer=new Customer(),
                MembershipTypes = membershitypes
            };
            return View("CustomerForm",viewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Customer customer)
        {
            if(!ModelState.IsValid)
            {
               
                var viewModel = new CustomerViewModel
                {
                    MembershipTypes = _context.MembershipTypes.ToList(),
                    customer = customer
                };
                return View("CustomerForm", viewModel);
            }
            if (customer.Id == 0)
            {
                _context.Customers.Add(customer);
            }
            else
            {
                var customerInDb = _context.Customers.Single(c => c.Id == customer.Id);
                customerInDb.customerName = customer.customerName;
                customerInDb.Birthday = customer.Birthday;
                customerInDb.MembershipTypeId = customer.MembershipTypeId;
                customerInDb.IsSubscribedToNewsLetter = customer.IsSubscribedToNewsLetter;
            }
            
            _context.SaveChanges();

            return RedirectToAction("Index", "Customer");
        }

        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
            {
                return HttpNotFound();
            }

            var customerViewModel = new CustomerViewModel
            {
                customer = customer,
                MembershipTypes = _context.MembershipTypes.ToList()
            };
            return View("CustomerForm", customerViewModel);
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