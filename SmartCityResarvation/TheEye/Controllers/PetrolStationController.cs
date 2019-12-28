using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.AspNetCore.Mvc;
using TheEye.Business.Abstract;
using TheEye.Entities.Concrete;
using TheEye.WebUl.Models;

namespace TheEye.WebUL.Controllers
{
    public class PetrolStationController : Controller
    {
        public IPetrolStationService _petrolStationService;
        public PetrolStationController(IPetrolStationService petrolStationService)
        {
            _petrolStationService = petrolStationService;
        }
        [Route("PetrolOfisi")]
        public ActionResult PetrolStation()
        { 
            //var session = HttpContext.Session;
            //if (session != null)
            //{
            //    HttpContext.Session.TryGetValue("token", out var result);
            //    if (result != null)
            //        return View();
            //}
            List<PetrolStation> model = _petrolStationService.GetAll();
            return View(model);
        }

        [Route("Admin/PetrolOfisiListesi")]
        public ActionResult PetrolStationGetList()
        {
            List<PetrolStation> model = _petrolStationService.GetAll();
            return View(model);
        }

        [Route("Admin/PetrolOfisiEkleme")]
        [Route("Admin/PetrolOfisiGuncelle/{id}")]
        public ActionResult PetrolStationOparation(int id = 0)
        {
            if (id == 0)
                return View();
            var modal = _petrolStationService.Get(5);
            return View(modal);
        }

        public ActionResult PetrolStationOparationCrud(PetrolStation petrolStation)
        {
            if(petrolStation.PetrolId == 0)
                _petrolStationService.Add(petrolStation);
            else
                _petrolStationService.Update(petrolStation);
            return RedirectToAction("PetrolStationGetList");
        }

        public ActionResult DeletePetrolStation(int id)
        {
            PetrolStation petrolStation = _petrolStationService.Get(id);
            _petrolStationService.Delete(petrolStation);
            TempData.Add("Message", "Silme işleminiz başarılı bir şekilde gerçekleştirirldi.");
            return RedirectToAction("PetrolStationGetList");
        }
    }
}