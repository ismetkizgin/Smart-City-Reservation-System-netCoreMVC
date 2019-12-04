using System;
using System.Collections.Generic;
using TheEye.Core.Entities;

namespace TheEye.Entities.Concrete
{
    public class User : IEntity
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public DateTime UserYears { get; set; }
        public Boolean UserGender { get; set; }
        public string UserPassword { get; set; }
        public string UserPhone { get; set; }
        public string UserMail { get; set; }
        public string UserCity { get; set; }
        public string UserDistrict { get; set; }
        public string UserAdress { get; set; }
        public int UserType { get; set; }
        public List<Ssn> Ssns =new List<Ssn>();
    }
}
