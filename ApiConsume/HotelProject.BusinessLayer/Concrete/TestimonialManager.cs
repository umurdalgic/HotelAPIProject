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
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDal testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            this.testimonialDal = testimonialDal;
        }

        public void TCreate(Testimonial t)
        {
            testimonialDal.Create(t);
        }

        public void TDelete(Testimonial t)
        {
            testimonialDal.Delete(t);
        }

        public Testimonial TGetById(int id)
        {
           return testimonialDal.GetById(id);
        }

        public List<Testimonial> TGetList()
        {
            return testimonialDal.GetList();
        }

        public void TUpdate(Testimonial t)
        {
            testimonialDal.Update(t);
        }
    }
}
