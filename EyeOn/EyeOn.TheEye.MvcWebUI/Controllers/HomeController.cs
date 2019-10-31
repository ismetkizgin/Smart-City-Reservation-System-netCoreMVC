using Microsoft.AspNetCore.Mvc;

namespace EyeOn.TheEye.MvcWebUI.Controllers
{
    public class HomeController:Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
