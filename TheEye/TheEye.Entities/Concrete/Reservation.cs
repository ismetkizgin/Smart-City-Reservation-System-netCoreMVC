using System;

namespace TheEye.Entities.Concrete
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public DateTime? ReservationTime { get; set; }
        public int? CarParkId { get; set; }
        public int? UserId { get; set; }

        public virtual CarPark CarPark { get; set; }
        public virtual User User { get; set; }
    }
}