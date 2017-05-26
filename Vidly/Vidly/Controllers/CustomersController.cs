using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            return View(GetCustomers());
        }

        public ActionResult Details(int id)
        {
            var selectedCustomer = GetCustomers().FirstOrDefault(c => c.Id == id);

            if (selectedCustomer == null)
                return HttpNotFound();

            return View(selectedCustomer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { Name = "Cherry", Id = 1},
                new Customer { Name = "Francis", Id = 2}
            };
        }
    }
}