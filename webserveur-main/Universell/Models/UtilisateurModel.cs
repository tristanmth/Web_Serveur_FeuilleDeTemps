using Microsoft.AspNetCore.Mvc.RazorPages;
using Universell.Domain.Entities;
using Universell.Services;

namespace Universell.Server.Models
{
    public class UtilisateurModel : PageModel
    {
        private readonly IUtilisateurService _utilisateurService;
        public UtilisateurModel(IUtilisateurService utilisateurService)
        {
            _utilisateurService = utilisateurService;
        }
        public List<Utilisateur> Utilisateurs { get; set; }
        public async Task OnGetAsync(int id)
        {
            Utilisateurs = await _utilisateurService.GetUtilisateursAsync();
        }
    }
}
