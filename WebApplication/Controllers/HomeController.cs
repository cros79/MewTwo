using System.Web.Mvc;

namespace WebApplication.Controllers {
    using InvativaNet.Core.Utilities;

    public class HomeController : Controller {
        public ActionResult Index() {
            ViewBag.Message = General.JsonSerialize(new {Hejkon = "Bacon"});
            return View();
        }
    }
}