using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TheEye.Business.Abstract;

namespace TheEye.WebUL.Controllers
{
    public class PharmacyController:Controller
    {
        private IMedicineService _medicineService;
        public PharmacyController(IMedicineService medicineService)
        {
            _medicineService = medicineService;
        }
        public ActionResult Pharmacy()
        {
            //var session = HttpContext.Session;
            //if (session != null)
            //{
            //    HttpContext.Session.TryGetValue("token", out var result);
            //    if (result != null)
            //        return View();
            //}
            var modal = _medicineService.GetAll();
            return View(modal);
        }
    }
}