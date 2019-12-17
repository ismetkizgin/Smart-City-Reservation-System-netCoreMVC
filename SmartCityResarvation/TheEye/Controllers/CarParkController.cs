using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
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
            List<CarPark> carPark = _carParkService.GetAll();
            return View(carPark);
        }
    }
}