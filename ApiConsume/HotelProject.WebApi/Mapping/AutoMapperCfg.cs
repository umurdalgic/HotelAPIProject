using AutoMapper;
using HotelProject.DtoLayer.Dtos.RoomDto;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.WebApi.Mapping
{
    public class AutoMapperCfg:Profile
    {
        public AutoMapperCfg()
        {
            CreateMap<RoomAddDto, Room>();
            CreateMap<Room, RoomAddDto>();

            CreateMap<RoomUpdateDto, Room>().ReverseMap(); // reverse map metodunu kullandığımızda bir daha tam tersini maplememize gerek kalmıyor.
        }
    }
}
