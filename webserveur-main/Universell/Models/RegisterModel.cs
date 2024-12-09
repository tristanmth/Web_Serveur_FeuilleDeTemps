using System.ComponentModel.DataAnnotations;

namespace Universell.Models
{
    public class RegisterModel
    {

        [Required(ErrorMessage = "Le login est requis")]
        [MaxLength(32, ErrorMessage = "Login trop long (32 caractères)")]
        public string? Login { get; set; }

        [Required(ErrorMessage = "Le mot de passe est requis")]
        [MaxLength(32, ErrorMessage = "Mot de passe trop long (32 caractères)")]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{8,}$\r\n", ErrorMessage = "Veuillez respecter les prérequis pour la création de mot de passe")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "La confirmation du mot de passe est requise")]
        [MaxLength(32)]
        public string? ConfirmPassword { get; set; }
    }
}
