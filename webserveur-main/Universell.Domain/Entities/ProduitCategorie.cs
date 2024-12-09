namespace Universell.Domain.Entities
{
    public class ProduitCategorie : Entity
    {
        public required int ProduitId { get; set; }
        public virtual Produit? Produit { get; set; }
        public required int CategorieId { get; set; }
        public virtual Categorie? Categorie { get; set; }
    }

}
