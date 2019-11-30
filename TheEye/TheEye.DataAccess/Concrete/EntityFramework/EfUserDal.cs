using TheEye.Core.DataAccess.EntityFramework;
using TheEye.DataAccess.Abstract;
using TheEye.Entities.Concrete;

namespace TheEye.DataAccess.Concrete.EntityFramwork
{
    public class EfUserDal : EfEntityRepositoryBase<User,TheEyeContext>,IUserDal
    {
    }
}
