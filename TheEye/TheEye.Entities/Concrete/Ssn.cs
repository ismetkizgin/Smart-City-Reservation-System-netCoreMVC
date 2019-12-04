using TheEye.Core.Entities;

namespace TheEye.Entities.Concrete
{
    public class Ssn : IEntity
    {
        public int SsnId { get; set; }
        public int UserId { get; set; }
        public int CompanyId { get; set; }
    }
}
