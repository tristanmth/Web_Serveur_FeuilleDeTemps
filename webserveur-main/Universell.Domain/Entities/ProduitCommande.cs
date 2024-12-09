using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universell.Domain.Entities
{
    public class ProduitCommande: Entity
    {
        public required DateTime DateAjout { get; set; }
        public int ProduitId { get; set; }
        public virtual Produit? Produit { get; set; }
        public int CommandeId { get; set; }
        public virtual Commande? Commande { get; set; }
        public int Nombre { get; set; }
    }

}
