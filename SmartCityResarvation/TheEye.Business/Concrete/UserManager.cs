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
    }
}
