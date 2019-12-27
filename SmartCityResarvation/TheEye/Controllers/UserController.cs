using Microsoft.AspNetCore.Mvc;

namespace TheEye.MvcWebUl.Controllers
{
    public class UserController : Controller
    {
        public UserController()
        {
            ViewBag.Layout = true;
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}