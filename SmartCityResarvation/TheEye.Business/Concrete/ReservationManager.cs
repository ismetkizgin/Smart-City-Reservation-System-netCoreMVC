using System.Collections.Generic;
using TheEye.Business.Abstract;
using TheEye.DataAccess.Abstract;
using TheEye.Entities.Concrete;

namespace TheEye.Business.Concrete
{
    public class ReservationManager : IReservationService
    {
        private IReservationDal _reservationDal;
        public List<Reservation> GetAll()
        {
            return _reservationDal.GetList();
        }
        public Reservation Get(int entityId)
        {
            return _reservationDal.Get();
        }

        public void Add(Reservation entity)
        {
            _reservationDal.Add(entity);
        }

        public void Delete(Reservation entity)
        {
            _reservationDal.Delete(entity);
        }

        public void Update(Reservation entity)
        {
            _reservationDal.Update(entity);
        }
    }
}