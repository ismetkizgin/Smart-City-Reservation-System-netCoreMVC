using Microsoft.AspNetCore.Mvc;
using TheEye.Business.Abstract;

namespace TheEye.WebUL.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("iletisim")]
        public ActionResult Content()
        {
            return View();
        }

        [Route("Hakkinda")]
        public ActionResult About()
        {
            return View();
        }
    }
}