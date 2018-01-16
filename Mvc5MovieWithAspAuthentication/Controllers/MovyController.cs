using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc5MovieWithAspAuthentication.Controllers
{
    public class MovyController : Controller
    {
        // GET: Movy
        public ActionResult Index()
        {
            return View();
        }
    }
}