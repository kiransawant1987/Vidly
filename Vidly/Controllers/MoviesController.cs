using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Movies
        public ActionResult random()
        {
            var movies = new Movie() { Name = "Shrek!" };
            return View(movies);
        }

        public ActionResult New()
        {
            var viewModel = new MovieFormViewModel
            {
                Title = "New Movie",
                Genres = _context.Genres.ToList()
            };

            return View(viewModel);
        }

        public ActionResult Save(Movie movie)
        {
            if (movie.Id == 0)
            {
                movie.DateAdded = DateTime.Now;
                _context.Movies.Add(movie);
            }
            else
            {
                var movieInDb = _context.Movies.Single(m => m.Id == movie.Id);

                movieInDb.Name = movie.Name;
                movieInDb.DateAdded = DateTime.Now;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.NumberInStock = movie.NumberInStock;
            }
            _context.SaveChanges();

            return RedirectToAction("Index", "Movies");
        }

        public ActionResult Index()
        {
            var movies = _context.Movies
                .Include(g => g.Genre)
                .ToList();

            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies
                .Include(g => g.Genre)
                .FirstOrDefault(m => m.Id == id);

            return View(movie);
        }

        public IEnumerable<Movie> GetMovies()
        {
            var movies = new List<Movie>
            {
                new Movie{ Id=1, Name="Shrek!"},
                new Movie{ Id=2, Name="Mission Impossible"},
                new Movie{ Id=3, Name ="Hangover" }
            };
            return movies;
        }
    }
}