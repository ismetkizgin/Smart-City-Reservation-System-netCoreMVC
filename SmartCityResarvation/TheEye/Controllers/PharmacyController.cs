using Microsoft.AspNetCore.Mvc;
using TheEye.Business.Abstract;
using TheEye.Entities.Concrete;

namespace TheEye.WebUL.Controllers
{
    public class PharmacyController : Controller
    {
        private IMedicineService _medicineService;
        public PharmacyController(IMedicineService medicineService)
        {
            _medicineService = medicineService;
        }
        
        [Route("Eczane")]
        public ActionResult Pharmacy()
        {
            //var session = HttpContext.Session;
            //if (session != null)
            //{
            //    HttpContext.Session.TryGetValue("token", out var result);
            //    if (result != null)
            //        return View();
            //}
            var model = _medicineService.GetAll();
            return View(model);
        }

        [Route("Admin/IlacListesi")]
        public ActionResult PharmacyGetList()
        {
            var model = _medicineService.GetAll();
            return View(model);
        }

        [Route("Admin/IlacEkleme")]
        [Route("Admin/IlacGuncelle/{id}")]
        public ActionResult PharmacyOparation(int id = 0)
        {
            if(id == 0)
                return View();

            var modal = _medicineService.Get(id);
            return View(modal);
        }

        public ActionResult PharmacyOparationCrud(Medicine medicine)
        {
            if(medicine.MedicineId == 0)
                _medicineService.Add(medicine);
            else
                _medicineService.Update(medicine);
            return RedirectToAction("PharmacyGetList");
        }

        public ActionResult DeletePharmacy(int id)
        {
            Medicine medicine = _medicineService.Get(id);
            _medicineService.Delete(medicine);
            TempData.Add("Message", "Silme işleminiz başarılı bir şekilde gerçekleştirirldi.");
            return RedirectToAction("PharmacyGetList");
        }
    }
}