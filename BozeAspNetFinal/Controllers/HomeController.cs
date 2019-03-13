using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BozeAspNetFinal.Controllers {

    public class HomeController : Controller {

        public ActionResult Index() {
            return View();
        }

        public ActionResult About() {
            ViewBag.Message = "Central About section. See content pages for additional information.";

            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "N/A.";

            return View();
        }
    }
}