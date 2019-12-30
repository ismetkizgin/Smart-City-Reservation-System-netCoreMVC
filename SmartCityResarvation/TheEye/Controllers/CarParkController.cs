using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using TheEye.Business.Abstract;
using TheEye.Entities.Concrete;
using TheEye.WebUl.Atributes;
using TheEye.WebUl.Filters;

namespace TheEye.WebUL.Controllers
{
    [ServiceFilter(typeof(LoginFilter))]
    public class CarParkController : Controller
    {
        private ICarParkService _carParkService;
        public CarParkController(ICarParkService carkParkService)
        {
            _carParkService = carkParkService;
        }

        [Ignore]
        [Route("Otopark")]
        public ActionResult CarPark()
        {
            var model = _carParkService.GetAll();
            return View(model);
        }

        [Route("Admin/OtoparkBilgiGirisi/{companyId}")]
        public ActionResult CarParkAdd(int companyId)
        {   
            //var session = HttpContext.Session;
            //if (session != null)
            //{
            //    HttpContext.Session.TryGetValue("token", out var result);
            //    if (result != null)
            //        return View();
            //}
            var modal = new CarPark
            {
                CarParkDisabled = false,
                CarParkMarket = false,
                CarParkMax = 0,
                CarParkNull = 0,
                CarParkTire = false,
                CarParkWashing = false,
                CompanyId = companyId
            };
            _carParkService.Add(modal);
            return View("CarParkOparation",modal);
        }

        [Route("Admin/OtoparkGuncelle/{id}")]
        public ActionResult CarParkOparation(int id)
        {
            var modal = _carParkService.Get(id);
            return View(modal);
        }

        public ActionResult CarParkOptionsCrud(CarPark carPark)
        {
            if (carPark.CarParkId == 0)
                _carParkService.Add(carPark);
            else
                _carParkService.Update(carPark);
            return RedirectToAction("CarParkGetList");
        }

        [Route("Admin/OtoparkListesi")]
        public ActionResult CarParkGetList()
        {
            int userId = Convert.ToInt32( HttpContext.Session.GetString("UserId"));
            List<CarPark> model = _carParkService.GetAll().Where(x => x.Company.UserId == userId).ToList();
            //List<CarPark> model = _carParkService.GetAll();
            return View(model);
        }
    }
}   