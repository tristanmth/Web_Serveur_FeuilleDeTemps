using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universell.Domain.Entities
{
    public class Univers: Entity
    {
        public required string Nom {  get; set; }
        public string? Description { get; set; }
        public string? NomMonnaie { get; set; }
        public virtual ICollection<Produit>? Produits { get; set; }
    }
}
