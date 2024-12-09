using System;

namespace FeuilleTemps.Domain.Entities
{
    public class Temps : Entity
    {
        public DateTime Date { get; set; }
        public string Categorie { get; set; }
        public double Duree { get; set; }
        public int UtilisateurId { get; set; }
        public Utilisateur Utilisateur { get; set; }
    }
}