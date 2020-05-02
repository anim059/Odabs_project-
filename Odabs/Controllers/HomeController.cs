using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Odabs.Controllers
{
    [Authorize(Roles ="Patient")]
    public class HomeController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult signin()
        {
            return View();
        }


        public ActionResult Doctor()
        {
            return View();
        }

 
        public ActionResult Online_Doctor()
        {
            return View();
        }

  
        public ActionResult Blog()
        {
            return View();
        }

       
        public ActionResult Help_Center()
        {
            return View();
        }

 
        public ActionResult What_we_trea()
        {
            return View();
        }


    }
}