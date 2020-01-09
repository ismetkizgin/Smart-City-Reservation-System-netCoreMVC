using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TheEye.Business.Abstract;
using TheEye.Entities.Concrete;
using TheEye.WebUl.Atributes;
using TheEye.WebUl.Filters;

namespace TheEye.WebUl.Controllers
{
    [ServiceFilter(typeof(LoginFilter))]
    public class MedicineController : Controller
    {
        private IMedicineService _medicineService;

        public MedicineController(IMedicineService medicineService)
        {
            _medicineService = medicineService;
        }

        [Ignore]
        public ActionResult Medicine()
        {
            var modal = _medicineService.GetAll();
            return View(modal);
        }
        [Route("Admin/IlacListesi/{PharmacyId}")]
        public ActionResult MedicineGetList(int pharmacyId)
        {
            var modal = _medicineService.GetAll().Where(x =>x.CompanyId == pharmacyId);
            return View(modal);
        }

        [Route("Admin/IlacEkleme/{PharmacyId}")]
        [Route("Admin/IlacGuncelle/{id}")]
        public ActionResult MedicineOparation(int id = 0, int pharmacyId = 0)
        {
            var modal = new Medicine
            {
                CompanyId = pharmacyId
            };
            if (id == 0)
                return View(modal);
            modal = _medicineService.Get(id);
            return View(modal);
        }

        public ActionResult MedicineOparationCrud(Medicine medicine)
        {
            if (medicine.MedicineId == 0)
                _medicineService.Add(medicine);
            else
                _medicineService.Update(medicine);
            return RedirectToAction("PharmacyGetList","Pharmacy");
        }

        public ActionResult MedicineDelete(int id)
        {
            Medicine medicine = _medicineService.Get(id);
            _medicineService.Delete(medicine);
            TempData.Add("Message", "Silme işleminiz başarılı bir şekilde gerçekleştirirldi.");
            return RedirectToAction("PharmacyGetList","Pharmacy");
        }
    }
}