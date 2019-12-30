using System;

namespace TheEye.WebUl.Models
{
    public class CompanyViewModal
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyPhone { get; set; }
        public string CompanyMail { get; set; }
        public string CompanyAdress { get; set; }
        public string CompanyCity { get; set; }
        public string CompanyDistrict { get; set; }
        public DateTime? CompanyTime { get; set; }
        public int CompanyType { get; set; }
        public int CompanyTaxNo { get; set; }
    }
}