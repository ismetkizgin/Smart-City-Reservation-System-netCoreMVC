using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using TheEye.Business.Abstract;
using TheEye.Entities.Concrete;
using TheEye.WebUl.Filters;
using TheEye.WebUl.Models;

namespace TheEye.WebUl.Controllers
{
    [ServiceFilter(typeof(LoginFilter))]
    public class CompanyController : Controller
    {
        private ICompanyService _companyService;
        private IHostingEnvironment _environment;
        public CompanyController(ICompanyService companyService, IHostingEnvironment enviroment)
        {
            _companyService = companyService;
            _environment = enviroment ?? throw new ArgumentNullException(nameof(enviroment));
        }

        [Route("Admin/FirmaKayit")]
        public ActionResult CompanyAdd()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CompanyControlAdd(CompanyViewModal companyViewModal)
        {
            string filenameadd = DateTime.Now.ToString(CultureInfo.InvariantCulture).Replace(" ", "_").Replace(":", "_").Replace(".", "_").Replace(" ", "_").Replace("/", "_").Replace("\\", "_");
            string images = Path.Combine(_environment.WebRootPath, "images/CompanyImages");
            string imagesPath = filenameadd + companyViewModal.ImageFile.FileName;

            if (companyViewModal.ImageFile.Length > 0)
            {
                await using (var fileStream = new FileStream(Path.Combine(images,
                    imagesPath), FileMode.Create))
                {
                    await companyViewModal.ImageFile.CopyToAsync(fileStream);
                }
            }
            companyViewModal.CompanyImage = imagesPath;
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(string.Format("http://192.168.1.3:5000/CompanyControlTax?TaxNo={0}&Name={1}", companyViewModal.CompanyTaxNo, companyViewModal.CompanyName));
                var model = JsonConvert.DeserializeObject<IEnumerable<ServiceCompanyControl>>(
                    response.Content.ReadAsStringAsync().Result);
                int companyType = 0;
                if (model != null)
                    foreach (var item in model)
                    {
                        companyType = item.CompanyType;
                    }
                Company company = new Company
                {
                    CompanyName = companyViewModal.CompanyName,
                    CompanyAdress = companyViewModal.CompanyAdress,
                    CompanyCity = companyViewModal.CompanyCity,
                    CompanyDistrict = companyViewModal.CompanyDistrict,
                    CompanyMail = companyViewModal.CompanyMail,
                    CompanyPhone = companyViewModal.CompanyPhone,
                    CompanyType = companyType,
                    UserId = Convert.ToInt32(HttpContext.Session.GetString("UserId"))
                };
                _companyService.Add(company);
                company = _companyService.GetAll().OrderByDescending(x => x.CompanyId).FirstOrDefault();

                if (companyType == 0)
                    return RedirectToAction("CarParkAdd", "CarPark", new { companyId = company?.CompanyId });
                else if (companyType == 1)
                    return RedirectToAction("PetrolStationAdd", "PetrolStation", new { companyId = company?.CompanyId });
                else
                    return RedirectToAction("PharmacyGetList", "Pharmacy");
            }
        }

        [Route("Admin/FirmaGuncelleme/{id}")]
        public ActionResult CompanyUpdate(int id)
        {
            var modal = _companyService.Get(id);
            return View(modal);
        }

        public ActionResult CompanyDelete(int id)
        {
            var modal = _companyService.Get(id);
            _companyService.Delete(modal);
            TempData.Add("Message", "Silme işleminiz başarılı bir şekilde gerçekleştirirldi.");
            return RedirectToAction("Admin", "Account");
        }
    }
}