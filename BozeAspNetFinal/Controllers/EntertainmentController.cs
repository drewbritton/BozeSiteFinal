using System.Web.Mvc;

namespace BozeAspNetFinal.Controllers {

    public class EntertainmentController : Controller {

        // GET: /Entertainment/
        public ActionResult Index() {
            return View();
        }

        // GET: /Entertainment/About
        public ActionResult About() {
            ViewBag.Message = "Boze DVDs - About";

            return View();
        }
    }
}