using System.Collections.Generic;
using TheEye.Business.Abstract;
using TheEye.DataAccess.Abstract;
using TheEye.Entities.Concrete;

namespace TheEye.Business.Concrete
{
    public class MedicineManager : IMedicineService
    {
        private IMedicineDal _medicineDal;
        public MedicineManager(IMedicineDal medicineDal)
        {
            _medicineDal = medicineDal;
        }

        public List<Medicine> GetAll()
        {
            return _medicineDal.GetIncludeList("Company");
        }

        public Medicine Get(int entityId)
        {
            return _medicineDal.Get(x => x.MedicineId == entityId);
        }

        public void Add(Medicine entity)
        {
            _medicineDal.Add(entity);
        }

        public void Delete(Medicine entity)
        {
            _medicineDal.Delete(entity);
        }

        public void Update(Medicine entity)
        {
            _medicineDal.Update(entity);
        }
    }
}