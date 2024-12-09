namespace Universell.Domain.Entities
{
    public class Sprint : Entity
    {
        public required string Nom { get; set; }
        public required DateTime DateDebut { get; set; }
        public required DateTime DateFin { get; set; }

        private readonly List<Utilisateur> _membres = new();
        public IReadOnlyCollection<Utilisateur> Membres => _membres.AsReadOnly();

        public void AjouterMembre(Utilisateur utilisateur)
        {
            _membres.Add(utilisateur);
        }

        public TimeSpan GetDureeSprint()
        {
            return DateFin - DateDebut;
        }
    }
}
