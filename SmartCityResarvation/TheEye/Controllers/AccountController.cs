using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using TheEye.Business.Abstract;
using TheEye.Entities.Concrete;
using TheEye.WebUl.Atributes;
using TheEye.WebUl.Filters;

namespace TheEye.WebUl.Controllers
{
    [ServiceFilter(typeof(LoginFilter))]
    public class AccountController : Controller
    {
        private IUserService _userService;
        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        [Ignore]
        public ActionResult SignIn(User user)
        {
            User loginData = _userService.LoginControlGet(user.UserName, user.UserPassword);
            if (loginData != null)
            {
                string token = Guid.NewGuid().ToString() + "æ" + DateTime.Now;
                HttpContext.Session.Set("token", System.Text.Encoding.UTF8.GetBytes(token));
                HttpContext.Session.SetString("UserId", loginData.UserId.ToString());
                ViewBag.Token = token;
                return RedirectToAction("Admin");
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [Ignore]
        [Route("GirisYap")]
        public ActionResult Login()
        {
            var session = HttpContext.Session;
            if (session != null)
            {
                HttpContext.Session.TryGetValue("token", out var result);
                if (result != null)
                    return RedirectToAction("Admin");
            }
            return View();
        }

        [Route("Admin")]
        public ActionResult Admin()
        {
            return View();
        }

        [Ignore]
        public ActionResult Register(User user)
        {
            _userService.Add(user);
            return RedirectToAction("Login");
        }

        [Route("Admin/Hesabim")]
        public ActionResult MyAccount()
        {
            int userId = Convert.ToInt32(HttpContext.Session.GetString("UserId"));
            var modal = _userService.Get(userId);
            return View(modal);
        }

        public ActionResult AccountUpdate(User user)
        {
            _userService.Update(user);
            return RedirectToAction("Admin");
        }

        public ActionResult LogOff()
        {
            HttpContext.Session.Remove("token");
            return RedirectToAction("Index", "Home");
        }
    }
}