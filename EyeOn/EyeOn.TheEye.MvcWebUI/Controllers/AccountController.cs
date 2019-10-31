using Microsoft.AspNetCore.Mvc;

namespace EyeOn.TheEye.MvcWebUI.Controllers
{
    public class AccountController:Controller
    {
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
    }
}
