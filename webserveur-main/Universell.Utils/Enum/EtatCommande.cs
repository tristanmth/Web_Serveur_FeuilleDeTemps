using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universell.Utils.Enums
{
    public enum EtatCommande
    {
        /// <summary>
        /// Etat panier, l'utilisateur navigue et ajoute des produits
        /// </summary>
        EnCours = 1,
        /// <summary>
        /// Commande passée, l'administrateur va valider ou non la commande
        /// </summary>
        AValider = 2,
        /// <summary>
        /// Commande validée, l'administrateur la prépare
        /// </summary>
        EnCoursDePreparation = 3,
        /// <summary>
        /// Livraison en cours d'acheminement
        /// </summary>
        EnLivraison = 4,
        /// <summary>
        /// Commande livrée
        /// </summary>
        Livre = 5,
        /// <summary>
        /// Problème lors de la commande
        /// </summary>
        Litige = 6,
        /// <summary>
        /// Commande refusée par l'administrateur
        /// </summary>
        Refusee = 7,
    }
}
