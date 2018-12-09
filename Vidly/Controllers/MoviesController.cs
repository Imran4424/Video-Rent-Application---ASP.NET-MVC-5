using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

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

            var viewModel = new RandomMovieViewModel
            {
                movie = movie,
                customers = customers
                
            };

            return View(viewModel);
        }

        // GET: Movies / Index

        public ActionResult Index()
        {


            return View();
        }
    }
}