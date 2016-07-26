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
	        var customers = GetCustomers();
            return View(customers);
        }

		public ActionResult Details(int id)
		{
			var customer = GetCustomers().FirstOrDefault(x => x.Id == id);

			if (customer == null)
			{
				return HttpNotFound();
			}

			return View(customer);
		}

	    private List<Customer> GetCustomers()
	    {
		    return new List<Customer>()
		    {
			    new Customer() {Id = 1, Name = "Jan Schacherl"},
				new Customer() {Id = 2, Name = "Jakub Vostry"}
			};
	    }
    }
}