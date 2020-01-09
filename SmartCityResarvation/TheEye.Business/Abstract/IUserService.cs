using TheEye.Entities.Concrete;

namespace TheEye.Business.Abstract
{
    public interface IUserService : IServices<User>
    {
        User LoginControlGet(string userName, string password);
    }
}