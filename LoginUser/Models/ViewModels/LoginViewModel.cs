using System.ComponentModel.DataAnnotations;

namespace LoginUser.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "El nombre de usuario es obligatorio.")]
        public string? UserName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "La contraseña es obligatoria.")]
        public string? Password { get; set; }
    }
}
