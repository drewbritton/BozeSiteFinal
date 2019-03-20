using System.Web.Mvc;

namespace BozeAspNetFinal.Controllers {

    public class AgenciesController : Controller {

        // GET: /Agencies/
        public ActionResult Index() {
            return View();
        }

        // GET: /Agencies/About
        public ActionResult About() {
            ViewBag.Message = "Starlight Hospital - About";

            return View();
        }

        // GET: /Agencies/Contact
        public ActionResult Contact() {
            ViewBag.Message = "Starlight Hospital - Contact Us";

            return View();
        }

        // GET: /Agencies/Doctor
        public ActionResult Doctor() {
            ViewBag.Message = "Starlight Hospital - Doctors";

            return View();
        }

        // GET: /Agencies/Service
        public ActionResult Service() {
            ViewBag.Message = "Starlight Hospital - Services";

            return View();
        }
    }
}