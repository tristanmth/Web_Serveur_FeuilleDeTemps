namespace Universell.Domain.Entities
{
    public class Categorie : Entity
    {
        public required string Nom { get; set; }

        public string GetNom()
        {
            return Nom;
        }
    }
}
