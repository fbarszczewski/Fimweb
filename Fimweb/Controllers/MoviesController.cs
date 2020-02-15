using Fimweb.Models;
using Fimweb.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fimweb.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AllMovies()
        {
            var movies = GetMovies();
            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Jojo Rabbit" },
                new Movie { Id = 2, Name = "Kongres" }
            };
        }

        [Route("movies/released/{y}/{m}")]
        public ActionResult ByReleaseDate(int y,int m)
        {
            return Content($"{y}/{m}");
        }

        public ActionResult Random()
        {
            var movie = new Movie() {Name="Shrek!"};
            var customers = new List<Customer>
            {
                new Customer{Name="Customer1"},
                new Customer{Name="Customer2"},
                new Customer{Name="Customer3"},
            };

            var viewmodel = new RandomModelViewModel
            {
                Movie=movie,
                Customers=customers
            };

            return View(viewmodel);

        }
    }
}