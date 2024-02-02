using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage = "Ad Alanı Gereklidir.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Soyad Alanı Gereklidir.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Kullanı Adı Alanı Gereklidir.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "MAil Alanı Gereklidir.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre Alanı Gereklidir.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifre Tekrar Alanı Gereklidir.")]
        [Compare("Password",ErrorMessage ="Şifreler Uyuşmuyor.")]
        public string ConfirmedPassword { get; set; }
    }
}
