using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TheEye.Business.Abstract;
using TheEye.Entities.Concrete;

namespace TheEye.WebUL.Controllers
{
    public class PetrolStationController : Controller
    {
        public IPetrolStationService _petrolStationService;
        public PetrolStationController(IPetrolStationService petrolStationService)
        {
            _petrolStationService = petrolStationService;
        }
        public ActionResult PetrolStation()
        {
            List<PetrolStation> modal = _petrolStationService.GetAll(); 
            return View(modal);
        }
    }
}