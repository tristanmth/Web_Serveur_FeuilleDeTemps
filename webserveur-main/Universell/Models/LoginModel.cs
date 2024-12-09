using System.ComponentModel.DataAnnotations;

namespace Universell.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Le login est requis")]
        public string? Login { get; set; }

        [Required(ErrorMessage = "Le mot de passe est requis")]
        public string? Password { get; set; }
    }
}
