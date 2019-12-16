using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TheEye.Business.Abstract;
using TheEye.WebUL.Models;

namespace TheEye.WebUL.Controllers
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
            var users = _userService.GetAll().Where(e => e.UserId == 1).ToList();
            UserListViewModel model = new UserListViewModel
            {
                User = users
            };
            return View(model);
        }
    }
}