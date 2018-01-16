using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc5MovieWithAspAuthentication.Models;

namespace Mvc5MovieWithAspAuthentication.Controllers
{
    public class CustomerController : Controller
    {

        private  readonly MovieStoreEntities  db = new MovieStoreEntities();
        // GET: Customer

        public ActionResult Index()
        {
            return View();
        }
        [Authorize]
        public ActionResult NewCustomer()
        {

            var listOfCustomers = db.Customers.ToList();

            return View(listOfCustomers);
          
        }
    }
}