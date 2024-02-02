using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly IStaffService _staffService;

        public StaffController(IStaffService staffService)
        {
            _staffService = staffService;
        }

        [HttpGet]
        public ActionResult StaffList() 
        {
            var staffList=_staffService.TGetList();
            return Ok(staffList);
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteStaff(int id) 
        {
            var staff= _staffService.TGetById(id);
            _staffService.TDelete(staff);
            return Ok();
        }
        [HttpPost]
        public ActionResult AddStaff(Staff staff) 
        {
            _staffService.TCreate(staff);
            return Ok(staff);
        }
        [HttpPut]
        public ActionResult UpdateStaff(Staff staff) 
        {
            _staffService.TUpdate(staff);
            return Ok();
        }
        [HttpGet("{id}")]
        public ActionResult GetStaff(int id) 
        {
            var value= _staffService.TGetById(id);
            return Ok(value);
        }
    }
}
