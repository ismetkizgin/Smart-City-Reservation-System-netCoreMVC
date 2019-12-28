using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TheEye.Business.Abstract;
using TheEye.Entities.Concrete;
using TheEye.WebUl.Models;

namespace TheEye.WebUl.Controllers
{
    public class AccountController : Controller
    {
        private IUserService _userService;
        public AccountController(IUserService userService)
        {
            _userService = userService;
        }
        public ActionResult Login(LoginViewModel loginViewModel)
        {
            User loginData = _userService.LoginControlGet(loginViewModel.UserName, loginViewModel.Password);
            if (loginData != null)
            {
                string token = Guid.NewGuid().ToString() + "æ" + DateTime.Now;
                HttpContext.Session.Set("token", System.Text.Encoding.UTF8.GetBytes(token));
                ViewBag.Token = token;
                return RedirectToAction("Pharmacy","Pharmacy");
            }
            else
            {
                TempData.Add("Message", "Kullanıcı bilgilerini lütfen konrol ediniz.");
                TempData.Add("stateLogin","false");
                return RedirectToAction("Index", "Home");
            }
        }
    }
}