using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Odabs.Areas.Doctor.Controllers
{
    public class HomeController : Controller
    {

        [Authorize(Roles = "Doctor")]
        // GET: Doctor/Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: Doctor/Appoinment
        public ActionResult DocAppoinment()
        {
            return View();
        }

        // GET: Doctor/Blog
        public ActionResult DocPostBlogs()
        {
            return View();
        }

        // GET: Doctor/Appoinment
        public ActionResult DocConsoleHistory()
        {
            return View();
        }

        // GET: Doctor/Appoinment
        public ActionResult DocProfile()
        {
            return View();
        }

    }
}