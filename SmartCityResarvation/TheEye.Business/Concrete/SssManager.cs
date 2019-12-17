using System.Collections.Generic;
using TheEye.Business.Abstract;
using TheEye.DataAccess.Abstract;
using TheEye.Entities.Concrete;

namespace TheEye.Business.Concrete
{
    public class SssManager : ISssService
    {
        private ISssDal _ıSssDal;
        public List<Sss> GetAll()
        {
            return _ıSssDal.GetList();
        }

        public Sss Get(int entityId)
        {
            return _ıSssDal.Get(x => x.SssId == entityId);
        }

        public void Add(Sss entity)
        {
            _ıSssDal.Add(entity);
        }

        public void Delete(Sss entity)
        {
            _ıSssDal.Delete(entity);
        }
        public void Update(Sss entity)
        {
            _ıSssDal.Update(entity);
        }
    }
}
