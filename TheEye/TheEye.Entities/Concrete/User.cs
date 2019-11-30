using System;
using TheEye.Core.Entities;

namespace TheEye.Entities.Concrete
{
    public class User:IEntity
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public DateTime UserYears { get; set; }
        public bool UserGender { get; set; }
        public string UserPassword { get; set; }
        public string UserPhone { get; set; }
        public string UserMail { get; set; }
        public int UserCity { get; set; }
        public int UserDistrict { get; set; }
        public string UserAdress { get; set; }
        public int UserType { get; set; }
    }
}
