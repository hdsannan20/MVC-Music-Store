using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Music_Store.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            return View();
        }

        // GET: Store/Details?genre=[value]
        public ActionResult Details(string genre)
        {
            // check for an empty genre
            if (genre == null)
            {
                //return View("Error");
                return RedirectToAction("Index");

            }
            ViewBag.Genre = genre;
            return View();
        }
    }
}