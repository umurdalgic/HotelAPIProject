using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Migrations;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        [HttpGet]
        public ActionResult AboutList()
        {
            var aboutList = _aboutService.TGetList();
            return Ok(aboutList);
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteAbout(int id)
        {
            var about = _aboutService.TGetById(id);
            _aboutService.TDelete(about);
            return Ok();
        }
        [HttpPost]
        public ActionResult AddAbout(About about)
        {
            _aboutService.TCreate(about);
            return Ok(about);
        }
        [HttpPut]
        public ActionResult UpdateAbout(About about)
        {
            _aboutService.TUpdate(about);
            return Ok(about);
        }
        [HttpGet("{id}")]
        public ActionResult GetAbout(int id)
        {
            var value = _aboutService.TGetById(id);
            return Ok(value);
        }
    }
}
