namespace Universell.Domain.Entities
{
    public class Produit : Entity
    {
        public required string Nom { get; set; }
        public required int UniversId { get; set; }
        public virtual Univers? Univers { get; set; }
        public required float Prix { get; set; }
        public required int Stock { get; set; }
        public string? Description { get; set; }
        public string? Visuel { get; set; }

        public virtual ICollection<ProduitCategorie>? ProduitCategories { get; set; }
        public virtual ICollection<ProduitCommande>? ProduitCommandes { get; set; }


    }
}
