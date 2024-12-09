using Universell.Domain.Entities;

namespace Universell.Services
{
    public interface IUtilisateurService
    {
        Task<List<Utilisateur>> GetUtilisateursAsync();
        Task<Utilisateur> GetUtilisateurByIdAsync(int id);
        Task CreateUtilisateurAsync(Utilisateur utilisateur);
        Task UpdateUtilisateurAsync(Utilisateur utilisateur,int id);
        Task DeleteUtilisateurAsync(int id);
    }
}
