using System;
using System.Collections.Generic;

namespace TheEye.Entities.Concrete
{
    public sealed class Company
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyPhone { get; set; }
        public string CompanyMail { get; set; }
        public string CompanyAdress { get; set; }
        public string CompanyCity { get; set; }
        public string CompanyDistrict { get; set; }
        public DateTime? CompanyTime { get; set; }
        public string CompanyType { get; set; }

        public ICollection<CarPark> CarParks { get; set; }
        public ICollection<Medicine> Medicines { get; set; }
        public ICollection<PetrolStation> PetrolStations { get; set; }
        public ICollection<Ssn> Ssn { get; set; }
    }
}
