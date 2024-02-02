using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribeController : ControllerBase
    {
        private readonly ISubscribeService _subscribeService;

        public SubscribeController(ISubscribeService subscribeService)
        {
            _subscribeService = subscribeService;
        }

        [HttpGet]
        public ActionResult SubscribeList()
        {
            var subscribeList = _subscribeService.TGetList();
            return Ok(subscribeList);
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteSubscribe(int id)
        {
            var subscribe = _subscribeService.TGetById(id);
            _subscribeService.TDelete(subscribe);
            return Ok();
        }
        [HttpPost]
        public ActionResult AddSubscribe(Subscribe subscribe)
        {
            _subscribeService.TCreate(subscribe);
            return Ok(subscribe);
        }
        [HttpPut]
        public ActionResult UpdateSubscribe(Subscribe subscribe)
        {
            _subscribeService.TUpdate(subscribe);
            return Ok();
        }
        [HttpGet("{id}")]
        public ActionResult GetSubscribe(int id)
        {
            var value = _subscribeService.TGetById(id);
            return Ok(value);
        }
    }
}
