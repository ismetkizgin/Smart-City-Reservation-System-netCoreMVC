using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;
using TheEye.Entities.Concrete;

namespace TheEye.WebUl.Models
{
    public class CompanyViewModal : Company
    {
        public int CompanyTaxNo { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}