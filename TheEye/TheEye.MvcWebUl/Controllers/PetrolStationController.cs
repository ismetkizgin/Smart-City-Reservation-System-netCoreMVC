using Microsoft.AspNetCore.Mvc;

namespace TheEye.WebUL.Controllers
{
    public class PetrolStationController : Controller
    {
        [Route("PetrolOfisi")]
        public ActionResult PetrolStation()
        {
            return View();
        }
    }
}