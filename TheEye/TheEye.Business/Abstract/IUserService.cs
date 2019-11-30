using System.Collections.Generic;
using TheEye.Entities.Concrete;

namespace TheEye.Business.Abstract
{
    public interface IUserService
    {
        List<User> GetAll();
        User Get(int userId);
        void Add(User user);
        void Update(User user);
        void Delete(User user);
    }
}
