using System.Collections.Generic;
using TheEye.Business.Abstract;
using TheEye.DataAccess.Abstract;
using TheEye.Entities.Concrete;

namespace TheEye.Business.Concrete
{
    public class PetrolStationManager : IPetrolStationService
    {
        private IPetrolStationDal _petrolStationDal;
        public List<PetrolStation> GetAll()
        {
            return _petrolStationDal.GetList();
        }
        public PetrolStation Get(int entityId)
        {
            return _petrolStationDal.Get(x => x.PetrolId == entityId);
        }

        public void Add(PetrolStation entity)
        {
            _petrolStationDal.Add(entity);
        }

        public void Delete(PetrolStation entity)
        {
            _petrolStationDal.Delete(entity);
        }

        public void Update(PetrolStation entity)
        {
            _petrolStationDal.Update(entity);
        }
    }
}
