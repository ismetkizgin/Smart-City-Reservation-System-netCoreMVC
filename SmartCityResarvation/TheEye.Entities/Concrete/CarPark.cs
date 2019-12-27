using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata;
using TheEye.Core.Entities;

namespace TheEye.Entities.Concrete
{
    public class CarPark : IEntity
    {
        public int CarParkId { get; set; }
        public int? CarParkMax { get; set; }
        public bool? CarParkDisabled { get; set; }
        public bool? CarParkWashing { get; set; }
        public string CarParkTire { get; set; }
        public int? CarParkFloor { get; set; }
        public int? CompanyId { get; set; }

        public Company Company { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
    }
}
