using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universell.Utils.Enums;

namespace Universell.Domain.Entities
{
    public class Commande: Entity
    {
        public required DateTime DateCreation { get; set; }
        public DateTime? DateEnvoi { get; set; }
        public string? Adresse { get; set; }
        public required EtatCommande Etat { get; set; }
        public required string UtilisateurId { get; set; }
        public virtual Utilisateur? Utilisateur { get; set; }
        public string? CodeCommande { get; set; }
        public virtual ICollection<ProduitCommande>? ProduitCommandes { get; set; }

    }

}
