using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        [HttpGet]
        public ActionResult ServiceList()
        {
            var serviceList = _serviceService.TGetList();
            return Ok(serviceList);
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteService(int id)
        {
            var service = _serviceService.TGetById(id);
            _serviceService.TDelete(service);
            return Ok();
        }
        [HttpPost]
        public ActionResult AddService(Service service)
        {
            _serviceService.TCreate(service);
            return Ok(service);
        }
        [HttpPut]
        public ActionResult UpdateService(Service service)
        {
            _serviceService.TUpdate(service);
            return Ok();
        }
        [HttpGet("{id}")]
        public ActionResult GetService(int id)
        {
            var value = _serviceService.TGetById(id);
            return Ok(value);
        }
    }
}
