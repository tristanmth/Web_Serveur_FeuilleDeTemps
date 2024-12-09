namespace Universell.Domain.Entities
{
    public class Adresse : Entity
    {
        public required string Nom { get; set; }
        public required string CodePostal { get; set; }
        public required string UtilisateurId { get; set; }
        public virtual Utilisateur? Utilisateur { get; set; }
    }

}
