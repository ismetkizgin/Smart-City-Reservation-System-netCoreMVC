using System;
using System.Collections.Generic;
using TheEye.Core.Entities;

namespace TheEye.Entities.Concrete
{
    public sealed class Company:IEntity
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

        public CarPark CarPark { get; set; }
        public Medicine Medicines { get; set; }
        public PetrolStation PetrolStations { get; set; }
        public ICollection<Ssn> Ssn { get; set; }
    }
}
