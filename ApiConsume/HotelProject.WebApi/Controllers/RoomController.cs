using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;

        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpGet]
        public ActionResult RoomList()
        {
            var roomList = _roomService.TGetList();
            return Ok(roomList);
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteRoom(int id)
        {
            var room = _roomService.TGetById(id);
            _roomService.TDelete(room);
            return Ok();
        }
        [HttpPost]
        public ActionResult AddRoom(Room room)
        {
            _roomService.TCreate(room);
            return Ok(room);
        }
        [HttpPut]
        public ActionResult UpdateRoom(Room room)
        {
            _roomService.TUpdate(room);
            return Ok(room);
        }
        [HttpGet("{id}")]
        public ActionResult GetRoom(int id)
        {
            var value = _roomService.TGetById(id);
            return Ok(value);
        }
    }
}
