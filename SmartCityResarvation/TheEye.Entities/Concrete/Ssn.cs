using System.Collections.Generic;
using TheEye.Core.Entities;

namespace TheEye.Entities.Concrete
{
    public class Ssn : IEntity
    {

        public int SsnId { get; set; }
        public int UserId { get; set; }
        public int CompanyId { get; set; }

        public virtual Company Company { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Sss> Sss { get; set; }
    }
}
