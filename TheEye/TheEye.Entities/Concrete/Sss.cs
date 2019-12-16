namespace TheEye.Entities.Concrete
{
    public class Sss
    {
        public int SssId { get; set; }
        public string SssQuestion { get; set; }
        public string SssReply { get; set; }
        public int? SsnId { get; set; }

        public virtual Ssn Ssn { get; set; }
    }
}
