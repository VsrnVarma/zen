using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ass1.Models;

namespace Ass1.Controllers
{
    public class CustomerController : Controller
    {
        NorthwindEntities ne = new NorthwindEntities();
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GermanCustomer()
        {
            List<Customer> cust = (from c in ne.Customers
                                 where c.Country == "Germany"
                                 select c).ToList();
            return View(cust);
        }

        public ActionResult CustomerDetails()
        {
            dynamic custorder = (ne.Orders.Where(cust => cust.OrderID == 10248).Select(cust => cust)).ToList();
            return View(custorder);
        }
    }
}