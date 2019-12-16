using System.Collections.Generic;
using TheEye.Core.Entities;

namespace TheEye.Entities.Concrete
{
    public sealed class Ssn : IEntity
    {

        public int SsnId { get; set; }
        public int UserId { get; set; }
        public int CompanyId { get; set; }

        public Company Company { get; set; }
        public User User { get; set; }
        public ICollection<Sss> Sss { get; set; }
    }
}
