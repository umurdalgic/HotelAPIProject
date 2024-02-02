using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.LoginDto;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            this.signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(LoginUserDto dto)
        {
            if(ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(dto.UserName, dto.Password, false, false);
                if(result.Succeeded) 
                {
                    return RedirectToAction("Index", "Staff");
                }
            }
            return View(dto);
        }
    }
}
