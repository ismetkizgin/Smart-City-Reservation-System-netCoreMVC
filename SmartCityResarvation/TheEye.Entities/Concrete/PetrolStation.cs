﻿using System.ComponentModel.DataAnnotations;
using TheEye.Core.Entities;

namespace TheEye.Entities.Concrete
{
    public class PetrolStation:IEntity
    {
        [Key]
        public int PetrolId { get; set; }
        public string PetrolFuelType { get; set; }
        public string PetrolMarkets { get; set; }
        public string PetrolWashing { get; set; }
        public string PetrolTire { get; set; }
        public int? CompanyId { get; set; }

        public virtual Company Company { get; set; }
    }
}