using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using TheEye.Business.Abstract;
using TheEye.DataAccess.Abstract;
using TheEye.Entities.Concrete;

namespace TheEye.Business.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public List<User> GetAll()
        {
            return _userDal.GetList();
        }

        public User Get(int entityId)
        {
            return _userDal.Get(x => x.UserId == entityId);
        }

        public void Add(User entity)
        {
            _userDal.Add(entity);
        }

        public void Update(User entity)
        {
            _userDal.Update(entity);
        }

        public void Delete(User entity)
        {
            _userDal.Delete(entity);
        }

        public User LoginControlGet(string userName, string password)
        {
            var user = _userDal.Get(x => x.UserName == userName && x.UserPassword == password);
            //if (user == null)
            //    return null;

            //// Authentication(Yetkilendirme) başarılı ise JWT token üretilir.
            //var tokenHandler = new JwtSecurityTokenHandler();
            //var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            //var tokenDescriptor = new SecurityTokenDescriptor
            //{
            //    Subject = new ClaimsIdentity(new Claim[]
            //    {
            //        new Claim(ClaimTypes.Name, user.UserId.ToString())
            //    }),
            //    Expires = DateTime.UtcNow.AddDays(7),
            //    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            //};
            //var token = tokenHandler.CreateToken(tokenDescriptor);
            //user.Token = tokenHandler.WriteToken(token);

            //// Sifre null olarak gonderilir.
            //user.UserPassword = null;

            return user;
        }
    }
}
