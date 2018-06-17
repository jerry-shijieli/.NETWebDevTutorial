using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Shrek!"};

            return View(movie);
        }

        public ActionResult Edit(int id)
        {
            return Content("id = "+id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (sortBy.IsNullOrWhiteSpace())
                sortBy = "Name";
            return Content(String.Format("PageIndex={0}&SortBy={1}", pageIndex, sortBy));
        }
    }
}