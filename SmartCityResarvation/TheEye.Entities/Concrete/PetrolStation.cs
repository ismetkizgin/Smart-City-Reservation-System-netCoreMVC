using System;
using System.ComponentModel.DataAnnotations;
using TheEye.Core.Entities;

namespace TheEye.Entities.Concrete
{
    public class PetrolStation:IEntity
    {
        [Key]
        public int PetrolId { get; set; }
        public string PetrolFuelType { get; set; }
        public Boolean PetrolMarkets { get; set; }
        public Boolean PetrolWashing { get; set; }
        public Boolean PetrolTire { get; set; }
        public int? CompanyId { get; set; }

        public virtual Company Company { get; set; }
    }
}
