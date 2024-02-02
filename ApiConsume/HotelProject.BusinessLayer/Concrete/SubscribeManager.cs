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
    public class SubscribeManager : ISubscribeService
    {
        private readonly ISubscribeDal subscribeDal;

        public SubscribeManager(ISubscribeDal subscribeDal)
        {
            this.subscribeDal = subscribeDal;
        }

        public void TCreate(Subscribe t)
        {
            subscribeDal.Create(t);
        }

        public void TDelete(Subscribe t)
        {
            subscribeDal.Delete(t);
        }

        public Subscribe TGetById(int id)
        {
            return subscribeDal.GetById(id);
        }

        public List<Subscribe> TGetList()
        {
            return subscribeDal.GetList();
        }

        public void TUpdate(Subscribe t)
        {
            subscribeDal.Update(t);
        }
    }
}
