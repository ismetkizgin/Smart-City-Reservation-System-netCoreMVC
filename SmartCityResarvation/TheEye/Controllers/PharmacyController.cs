using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using TheEye.Business.Abstract;
using TheEye.WebUl.Atributes;
using TheEye.WebUl.Filters;

namespace TheEye.WebUL.Controllers
{
    [ServiceFilter(typeof(LoginFilter))]
    public class PharmacyController : Controller
    {
        private ICompanyService _companyService;
        public PharmacyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [Ignore]
        [Route("Eczane")]
        public ActionResult Pharmacy()
        {
            var model = _companyService.GetAll().Where(x => x.CompanyType == 2).ToList();
            return View(model);
        }

        [Route("Admin/EczaneListesi")]
        public ActionResult PharmacyGetList()
        {
            int userId = Convert.ToInt32(HttpContext.Session.GetString("UserId"));
            var model = _companyService.GetAll().Where(x => x.UserId == userId).ToList();
            return View(model);
        }
    }
}