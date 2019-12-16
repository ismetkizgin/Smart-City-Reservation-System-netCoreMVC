using Microsoft.AspNetCore.Mvc;
using TheEye.Business.Abstract;

namespace TheEye.MvcWebUl.Controllers
{
    public class UserController : Controller
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}