using System.Collections.Generic;
using TheEye.Business.Abstract;
using TheEye.DataAccess.Abstract;
using TheEye.Entities.Concrete;

namespace TheEye.Business.Concrete
{
    public class SsnManager : ISsnService
    {
        private ISsnDal _ssnDal;
        public List<Ssn> GetAll()
        {
            return _ssnDal.GetList();
        }
        public Ssn Get(int entityId)
        {
            return _ssnDal.Get(x => x.SsnId == entityId);
        }

        public void Add(Ssn entity)
        {
            _ssnDal.Add(entity);
        }

        public void Delete(Ssn entity)
        {
            _ssnDal.Delete(entity);
        }

        public void Update(Ssn entity)
        {
            _ssnDal.Update(entity);
        }
    }
}