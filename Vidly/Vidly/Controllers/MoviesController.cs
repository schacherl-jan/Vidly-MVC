using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
	public class MoviesController : Controller
	{
		//// GET: Movies
		//public ActionResult Random()
		//{
		//	var movie = new Movie() { Name = "Shrek" };
		//	var customers = new List<Customer>()
		//	{
		//		new Customer() {Name = "Customer1"},
		//		new Customer() {Name = "Customer2"}
		//	};

		//	var viewModel = new RandomMovieViewMoel()
		//	{
		//		Movie = movie,
		//		Customers = customers
		//	};
		//	//return View(movie);
		//	//return Content("Hello Word dgdgg");			
		//	//return HttpNotFound();
		//	//return new EmptyResult();
		//	//return RedirectToAction("Index", "Home", new {page = 1, sortby = "name"});

		//	// nepouzivat, varianty pres string
		//	//ViewData["Movie"] = movie;
		//	// ViewBag.Movie = movie;


		//	return View(viewModel);
		//}



		public ActionResult Index()
		{
			return View(GetMovies());
		}


		public List<Movie> GetMovies()
		{
			var movies = new List<Movie>()
			{
				new Movie() {Name = "Terminator 1"},
				new Movie() {Name = "Rocky 2"}
			};
			return movies;
		}


		//public ActionResult Edit(int id)
		//{
		//	return Content("id=" + id);
		//}

		//[Route("movies/released/{year}/{month}")]
		//public ActionResult ByReleaseDate(int year, int month)
		//{
		//	return Content($"{year}/{month}");
		//}


	}
}