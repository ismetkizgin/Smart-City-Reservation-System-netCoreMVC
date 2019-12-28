using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TheEye.Business.Abstract;
using TheEye.Entities.Concrete;

namespace TheEye.WebUL.Controllers
{
    public class CarParkController : Controller
    {
        private ICarParkService _carParkService;
        public CarParkController(ICarParkService carkParkService)
        {
            _carParkService = carkParkService;
        }

        [Route("Otopark")]
        public ActionResult CarPark()
        {
            //var session = HttpContext.Session;
            //if (session != null)
            //{
            //    HttpContext.Session.TryGetValue("token", out var result);
            //    if (result != null)
            //        return View();
            //}
            var model = _carParkService.GetAll();
            return View(model);
        }

        [Route("Admin/OtoparkEkleme")]
        [Route("Admin/OtoparkGuncelle/{id}")]
        public ActionResult CarParkOparation(int id = 0)
        {
            if (id == 0)
                return View();
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
            List<CarPark> model = _carParkService.GetAll();
            return View(model);
        }

        public ActionResult DeleteCarPark(int id)
        {
            CarPark carPark = _carParkService.Get(id);
            _carParkService.Delete(carPark);
            TempData.Add("Message", "Silme işleminiz başarılı bir şekilde gerçekleştirirldi.");
            return RedirectToAction("CarParkGetList");
        }
    }
}