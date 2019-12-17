using System.Collections.Generic;
using TheEye.Business.Abstract;
using TheEye.DataAccess.Abstract;
using TheEye.Entities.Concrete;

namespace TheEye.Business.Concrete
{
    public class CarParkManager : ICarParkService
    {
        private ICarParkDal _carParkDal;
        public CarPark Get(int entityId)
        {
            return _carParkDal.Get(x => x.CarParkId == entityId);
        }

        public List<CarPark> GetAll()
        {
            return _carParkDal.GetList();
        }

        public void Add(CarPark entity)
        {
            _carParkDal.Add(entity);
        }

        public void Delete(CarPark entity)
        {
            _carParkDal.Delete(entity);
        }

        public void Update(CarPark entity)
        {
            _carParkDal.Update(entity);
        }
    }
}