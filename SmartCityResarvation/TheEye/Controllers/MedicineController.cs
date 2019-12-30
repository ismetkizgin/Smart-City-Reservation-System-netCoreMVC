using Microsoft.AspNetCore.Mvc;
using TheEye.Business.Abstract;
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
        //[Route("Eczane")]
        //public ActionResult Pharmacy()
        //{

        //    var model = _medicineService.GetAll();
        //    return View(model);
        //}

        //[Route("Admin/IlacListesi")]
        //public ActionResult PharmacyGetList()
        //{
        //    int userId = Convert.ToInt32(HttpContext.Session.GetString("UserId"));
        //    var model = _medicineService.GetAll().Where(x => x.Company.UserId == userId).ToList();
        //    return View(model);
        //}

        //[Route("Admin/IlacEkleme")]
        //[Route("Admin/IlacGuncelle/{id}")]
        //public ActionResult PharmacyOparation(int id = 0)
        //{
        //    if (id == 0)
        //        return View();
        //    var modal = _medicineService.Get(id);
        //    return View(modal);
        //}

        //public ActionResult PharmacyOparationCrud(Medicine medicine)
        //{
        //    if (medicine.MedicineId == 0)
        //        _medicineService.Add(medicine);
        //    else
        //        _medicineService.Update(medicine);
        //    return RedirectToAction("PharmacyGetList");
        //}

        //public ActionResult DeletePharmacy(int id)
        //{
        //    Medicine medicine = _medicineService.Get(id);
        //    _medicineService.Delete(medicine);
        //    TempData.Add("Message", "Silme işleminiz başarılı bir şekilde gerçekleştirirldi.");
        //    return RedirectToAction("PharmacyGetList");
        //}
    }
}