using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;

        public TestimonialController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        [HttpGet]
        public ActionResult TestimonialList()
        {
            var TestimonialList = _testimonialService.TGetList();
            return Ok(TestimonialList);
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteTestimonial(int id)
        {
            var Testimonial = _testimonialService.TGetById(id);
            _testimonialService.TDelete(Testimonial);
            return Ok();
        }
        [HttpPost]
        public ActionResult AddTestimonial(Testimonial testimonial)
        {
            _testimonialService.TCreate(testimonial);
            return Ok(testimonial);
        }
        [HttpPut]
        public ActionResult UpdateTestimonial(Testimonial testimonial)
        {
            _testimonialService.TUpdate(testimonial);
            return Ok();
        }
        [HttpGet("{id}")]
        public ActionResult GetTestimonial(int id)
        {
            var value = _testimonialService.TGetById(id);
            return Ok(value);
        }
    }
}
