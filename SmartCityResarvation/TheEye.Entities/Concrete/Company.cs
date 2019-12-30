using System;
using TheEye.Core.Entities;

namespace TheEye.Entities.Concrete
{
    public class Company:IEntity
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
        public int UserId { get; set; }
        public string CompanyImage { get; set; }

        public virtual CarPark CarPark { get; set; }
        public virtual Medicine Medicines { get; set; }
        public virtual PetrolStation PetrolStations { get; set; }
    }
}