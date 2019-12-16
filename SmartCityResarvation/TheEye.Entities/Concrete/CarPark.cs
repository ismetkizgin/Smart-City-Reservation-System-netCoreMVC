using System.Collections.Generic;
using TheEye.Core.Entities;

namespace TheEye.Entities.Concrete
{
    public class CarPark : IEntity
    {
        public int CarParkId { get; set; }
        public int? CarParkMax { get; set; }
        public bool? CarParkDisabled { get; set; }
        public string CarParkWashing { get; set; }
        public string CarParkTire { get; set; }
        public byte? CarParkFloor { get; set; }
        public int? CompanyId { get; set; }

        public Company Company { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
    }
}
