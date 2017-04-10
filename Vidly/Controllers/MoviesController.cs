using System.Web.Mvc;
using Vidly.Models;
namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!"};
            //return Content("Hello World");

            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
            return View(movie);
        }
        [Route("movies/released/{year}/{month:regex(\\d{4}): range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)

        {
            return Content(year +"/" + month);
        }
    }
}