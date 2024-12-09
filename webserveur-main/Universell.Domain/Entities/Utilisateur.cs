namespace Universell.Domain.Entities
{
    public class Utilisateur : Entity
    {
        public required string Nom { get; set; }
        public required string Email { get; set; }
        private readonly List<Sprint> _sprints = new();

        public IReadOnlyCollection<Sprint> Sprints => _sprints.AsReadOnly();


        private readonly List<Temps> _temps = new();
        public IReadOnlyCollection<Temps> Temps => _temps.AsReadOnly();

        public void AjouterTemps(DateTime date, string categorie, double temps)
        {
            _temps.Add(new Temps { Date = date, Categorie = categorie, Duree = temps });
        }

        public void ModifierTemps(DateTime date, string categorie, double nouveauTemps)
        {
            var temps = _temps.FirstOrDefault(t => t.Date == date && t.Categorie == categorie);
            if (temps != null)
            {
                temps.Duree = nouveauTemps;
            }
        }

        public double GetTotalTemps()
        {
            return _temps.Sum(t => t.Duree);
        }
    }
}

