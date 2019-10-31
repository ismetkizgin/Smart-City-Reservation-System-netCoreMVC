using Microsoft.AspNetCore.Mvc;

namespace EyeOn.TheEye.MvcWebUI.Controllers
{
    public class PharmacyController:Controller
    {
        public ActionResult Reservation()
        {
            return View();
        }
    }
}
