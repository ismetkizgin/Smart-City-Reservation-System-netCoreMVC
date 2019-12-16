using TheEye.Core.Entities;

namespace TheEye.Entities.Concrete
{
    public class Sss:IEntity
    {
        public int SssId { get; set; }
        public string SssQuestion { get; set; }
        public string SssReply { get; set; }
        public int? SsnId { get; set; }

        public virtual Ssn Ssn { get; set; }
    }
}
