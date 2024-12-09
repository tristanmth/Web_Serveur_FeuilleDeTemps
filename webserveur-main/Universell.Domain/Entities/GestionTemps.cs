namespace Universell.Domain.Entities
{
    public class GestionTemps
    {
        public void SaisirTemps(Utilisateur utilisateur, DateTime date, string categorie, double temps)
        {
            utilisateur.AjouterTemps(date, categorie, temps);
        }

        public void ModifierTemps(Utilisateur utilisateur, DateTime date, string categorie, double nouveauTemps)
        {
            utilisateur.ModifierTemps(date, categorie, nouveauTemps);
        }
    }
}
