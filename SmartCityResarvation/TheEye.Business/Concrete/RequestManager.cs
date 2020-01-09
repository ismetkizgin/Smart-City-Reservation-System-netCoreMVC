using System.Collections.Generic;
using TheEye.Business.Abstract;
using TheEye.DataAccess.Abstract;
using TheEye.Entities.Concrete;

namespace TheEye.Business.Concrete
{
    public class RequestManager : IRequestService
    {
        private IRequestDal _requestDal;
        public RequestManager(IRequestDal requestDal)
        {
            _requestDal = requestDal;
        }

        public List<Request> GetAll()
        {
            return _requestDal.GetList();
        }

        public Request Get(int entityId)
        {
            return _requestDal.Get(x => x.RequestId == entityId);
        }

        public void Add(Request entity)
        {
            _requestDal.Add(entity);
        }

        public void Delete(Request entity)
        {
            _requestDal.Delete(entity);
        }

        public void Update(Request entity)
        {
            _requestDal.Update(entity);
        }
    }
}
