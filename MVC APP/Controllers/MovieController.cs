using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_APP.Models;

namespace MVC_APP.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Random()
        {
            var movie = new Movie() { Name="NAME" };
            return View(movie);
        }

        public ActionResult Edit(int id)
        {
            return Content("id= " + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if(string.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }
            if(!pageIndex.HasValue)
            {
                pageIndex = 1;
            }
            return Content(string.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

        public ActionResult DateReleased(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}