using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Odabs.Areas.Admin.Controllers
{

    [Authorize(Roles ="Admin")]
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AdminDocList()
        {
            return View();
        }
        public ActionResult AdminUserList()
        {
            return View();
        }
        public ActionResult AdminDocpost()
        {
            return View();
        }
        public ActionResult TodaysAppointment()
        {
            return View();
        }
        public ActionResult PreAppointment()
        {
            return View();
        }
        public ActionResult Payment()
        {
            return View();

        }

        public ActionResult SeeAllPatient()
        {
            return View();

        }
    }
}