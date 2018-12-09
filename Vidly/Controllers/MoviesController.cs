using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies / Random
        public ActionResult Random()
        {
            var movie = new Movie() { name = "Shrek!"};

            var customers = new List<Customer>
            {
                new Customer{ name = "Customer 1"},
                new Customer{ name = "Customer 2"}
            };

            return View(movie);
        }
    }
}