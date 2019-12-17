using System.Collections.Generic;
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

        public User Get(int userId)
        {
            return _userDal.Get(x => x.UserId == userId);
        }

        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public void Update(User user)
        {
            _userDal.Update(user);
        }

        public void Delete(User user)
        {
            _userDal.Delete(user);
        }
    }
}
