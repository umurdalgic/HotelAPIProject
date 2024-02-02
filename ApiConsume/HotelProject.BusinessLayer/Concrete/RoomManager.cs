using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class RoomManager : IRoomService
    {
        private readonly IRoomDal roomDal;

        public RoomManager(IRoomDal roomDal)
        {
            this.roomDal = roomDal;
        }

        public void TCreate(Room t)
        {
            roomDal.Create(t);
        }

        public void TDelete(Room t)
        {
            roomDal.Delete(t);
        }

        public Room TGetById(int id)
        {
           return roomDal.GetById(id);
        }

        public List<Room> TGetList()
        {
           return roomDal.GetList();
        }

        public void TUpdate(Room t)
        {
            roomDal.Update(t);
        }
    }
}
