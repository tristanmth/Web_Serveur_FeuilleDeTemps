using Microsoft.EntityFrameworkCore;
using Universell.Domain;
using Universell.Domain.Entities;

namespace Universell.Services
{
    public class UtilisateurService : IUtilisateurService
    {
        private readonly UniversellDbContext _context;

        public UtilisateurService(UniversellDbContext context)
        {
            _context = context;
        }

        public async Task<List<Utilisateur>> GetUtilisateursAsync()
        {
            return await _context.Utilisateurs.Include(u => u.Temps).ToListAsync();
        }

        public async Task<Utilisateur> GetUtilisateurByIdAsync(int id)
        {
            return await _context.Utilisateurs.Include(u => u.Temps).FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task CreateUtilisateurAsync(Utilisateur utilisateur)
        {
            _context.Utilisateurs.Add(utilisateur);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateUtilisateurAsync(Utilisateur utilisateur, int id)
        {
            _context.Entry(utilisateur).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteUtilisateurAsync(int id)
        {
            var utilisateur = await _context.Utilisateurs.FindAsync(id);
            if (utilisateur != null)
            {
                _context.Utilisateurs.Remove(utilisateur);
                await _context.SaveChangesAsync();
            }
        }
    }
}


