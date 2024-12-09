using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universell.Domain.Entities
{
    public class Categorie: Entity
    {
        public required string Nom { get; set; }
        public int? ParentId { get; set; }
        public virtual Categorie? Parent { get; set; }
        public virtual ICollection<Categorie>? SubCategories { get; set; }

        public virtual ICollection<ProduitCategorie>? ProduitCategories { get; set; }
    }

}
