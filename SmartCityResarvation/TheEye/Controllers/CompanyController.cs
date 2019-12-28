using Microsoft.AspNetCore.Mvc;
using TheEye.Business.Abstract;
using TheEye.Entities.Concrete;

namespace TheEye.WebUl.Controllers
{
    public class CompanyController : Controller
    {
        private ICompanyService _companyService;
        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }
        
        [Route("Admin/FirmaGuncelleme/{id}")]
        [Route("Admin/FirmaKayit")]
        public ActionResult CompanyOparation(int id = 0)
        {
            if (id == 0)
                return View();
            
            var modal = _companyService.Get(id);
            return View(modal);
        }

        public ActionResult CompanyOparationCrud(Company company)
        {
            if(company.CompanyId == 0)
                _companyService.Add(company);
            else
                _companyService.Update(company);
            return RedirectToAction("CompanyOparation");
        }
    }
}