using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.LoginDto
{
    public class LoginUserDto
    {
        [Required(ErrorMessage ="Kullanıcı Adınızı Giriniz.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Parolanızı Giriniz.")]
        public string Password { get; set; }
    }
}