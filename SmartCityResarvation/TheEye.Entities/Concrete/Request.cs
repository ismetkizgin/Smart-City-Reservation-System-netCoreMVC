using System;

namespace TheEye.Entities.Concrete
{
    public class Request
    {
        public int RequestId { get; set; }
        public DateTime? RequestTime { get; set; }
        public string RequestAmaunt { get; set; }
        public bool? RequestActive { get; set; }
        public int? MedicineId { get; set; }
        public int? UserId { get; set; }

        public virtual Medicine Medicine { get; set; }
        public virtual User User { get; set; }
    }
}
