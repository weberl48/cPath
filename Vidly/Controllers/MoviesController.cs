using System.Web.Mvc;
using Vidly.Models;
using System;
namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {

            var movie = new Movie()
            {
                Name = "Sharknado"
            };
            return View(movie);
            //return Content("Hello World");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index","Home", new {page =1 ,sortBy = "name"});

        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            
                pageIndex = 1;

            
            if (String.IsNullOrWhiteSpace(sortBy))
            
                sortBy = "Name";
                return Content(String.Format("pageIdex={0}&sortBy={1}", pageIndex, sortBy));
            
          
        }
    }
}