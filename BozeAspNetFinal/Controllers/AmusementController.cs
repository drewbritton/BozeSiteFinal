using System.Web.Mvc;

namespace BozeAspNetFinal.Controllers {

    public class AmusementController : Controller {

        // GET: /Amusement/
        public ActionResult Index() {
            return View();
        }

        // GET: /Amusement/Contact
        public ActionResult Contact() {
            ViewBag.Message = "Wolly World - Contact Us";

            return View();
        }
    }
}