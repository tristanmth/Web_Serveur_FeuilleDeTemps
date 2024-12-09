using Microsoft.AspNetCore.Identity;

namespace Universell.Domain.Entities
{
    public class Utilisateur : IdentityUser
    {
        public virtual ICollection<Adresse>? Adresses { get; set; }

        public virtual ICollection<Commande>? Commandes { get; set; }
    }
}
