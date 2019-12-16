using System.Collections.Generic;
using TheEye.Core.Entities;

namespace TheEye.Entities.Concrete
{
    public sealed class Medicine:IEntity
    {
        public int MedicineId { get; set; }
        public string MedicineName { get; set; }
        public string MedicinePrescription { get; set; }
        public string MedicineType { get; set; }
        public string MedicinePiece { get; set; }
        public int? CompanyId { get; set; }

        public Company Company { get; set; }
        public ICollection<Request> Requests { get; set; }
    }
}
