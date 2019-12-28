using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using TheEye.Business.Abstract;
using TheEye.Entities.Concrete;
using TheEye.WebUl.Models;

namespace TheEye.WebUl.Companents
{
    public class AccountViewCompanent : ViewComponent
    {
        private IUserService _userService;
        public AccountViewCompanent(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public ViewViewComponentResult Invoke()
        {
            return View();
        }

        //[HttpPost]
        //public ViewViewComponentResult Invoke(LoginViewModel loginViewModel)
        //{
        //    User loginData = _userService.LoginControlGet(loginViewModel.UserName, loginViewModel.Password);
        //    if (loginData != null)
        //    {
        //        string token = Guid.NewGuid().ToString() + "æ" + DateTime.Now;
        //        HttpContext.Session.Set("token", System.Text.Encoding.UTF8.GetBytes(token));
        //        ViewBag.Token = token;
        //        return View();
        //    }
        //    else
        //    {
        //        TempData.Add("Message", "Kullanıcı bilgilerini lütfen konrol ediniz.");
        //        TempData.Add("stateLogin", "false");
        //        return View();
        //    }
        //}
    }
}