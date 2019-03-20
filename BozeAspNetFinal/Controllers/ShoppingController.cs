using System.Web.Mvc;

namespace BozeAspNetFinal.Controllers {

    public class ShoppingController : Controller {

        // GET: /Shopping/
        public ActionResult Index() {
            return View();
        }

        // GET: /Shopping/About
        public ActionResult About() {
            ViewBag.Message = "VoidCo - About Us";

            return View();
        }
    }
}