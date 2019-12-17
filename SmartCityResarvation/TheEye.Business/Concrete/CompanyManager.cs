using System.Collections.Generic;
using TheEye.Business.Abstract;
using TheEye.DataAccess.Abstract;
using TheEye.Entities.Concrete;

namespace TheEye.Business.Concrete
{
    public class CompanyManager : ICompanyService
    {
        private ICompanyDal _companyDal;
        public Company Get(int entityId)
        {
            return _companyDal.Get(x => x.CompanyId == entityId);
        }

        public List<Company> GetAll()
        {
            return _companyDal.GetList();
        }

        public void Add(Company entity)
        {
            _companyDal.Add(entity);
        }

        public void Delete(Company entity)
        {
            _companyDal.Delete(entity);
        }

        public void Update(Company entity)
        {
            _companyDal.Update(entity);
        }
    }
}