using AutoMapper;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DtoLayer.Dtos.RoomDto;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Room2Controller : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IRoomService _roomService;

        public Room2Controller(IRoomService roomService, IMapper mapper)
        {
            _roomService = roomService;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult Index()
        {
            var roomList = _roomService.TGetList();
            return Ok(roomList);
        }
        [HttpPost]
        public ActionResult AddRoom(RoomAddDto roomAddDto)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            var value = _mapper.Map<Room>(roomAddDto);
            _roomService.TCreate(value);
            return Ok();
        }
        [HttpPut]
        public ActionResult UpdateRoom(RoomUpdateDto roomDto)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            var value = _mapper.Map<Room>(roomDto);
            _roomService.TUpdate(value);
            return Ok(value);
        }
    }
}
