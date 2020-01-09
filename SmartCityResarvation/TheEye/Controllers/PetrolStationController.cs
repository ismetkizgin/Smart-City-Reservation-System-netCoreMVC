using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheEye.Business.Abstract;
using TheEye.Entities.Concrete;
using TheEye.WebUl.Atributes;
using TheEye.WebUl.Filters;

namespace TheEye.WebUL.Controllers
{
    [ServiceFilter(typeof(LoginFilter))]
    public class PetrolStationController : Controller
    {
        public IPetrolStationService PetrolStationService;
        public PetrolStationController(IPetrolStationService petrolStationService)
        {
            PetrolStationService = petrolStationService;
        }

        [Ignore]
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
            List<PetrolStation> model = PetrolStationService.GetAll();
            return View(model);
        }

        [Route("Admin/PetrolOfisiListesi")]
        public ActionResult PetrolStationGetList()
        {
            int userId = Convert.ToInt32(HttpContext.Session.GetString("UserId"));
            List<PetrolStation> model = PetrolStationService.GetAll().Where(x => x.Company.UserId == userId).ToList();
            return View(model);
        }

        [Route("Admin/PetrolOfisiBilgiGirisi/{companyId}")]
        public ActionResult PetrolStationAdd(int companyId)
        {
            var modal = new PetrolStation
            {
                PetrolMarkets = false,
                PetrolTire = false,
                PetrolWashing = false,
                CompanyId = Convert.ToInt32(HttpContext.Session.GetString("UserId"))
            };
            PetrolStationService.Add(modal);
            return View("PetrolStationOparation", modal);
        }

        [Route("Admin/PetrolOfisiGuncelle/{id}")]
        public ActionResult PetrolStationOparation(int id)
        {
            var modal = PetrolStationService.Get(id);
            return View(modal);
        }

        public ActionResult PetrolStationOparationCrud(PetrolStation petrolStation)
        {
            PetrolStationService.Update(petrolStation);
            return RedirectToAction("PetrolStationGetList");
        }
    }
}