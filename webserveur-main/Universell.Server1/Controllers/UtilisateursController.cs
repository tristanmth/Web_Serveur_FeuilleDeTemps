using Universell.Domain.Entities;
using Universell.Services;
using Microsoft.AspNetCore.Mvc;

namespace Universell.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtilisateursController :ControllerBase
    {
        private readonly IUtilisateurService _utilisateurService;

        public UtilisateursController(IUtilisateurService utilisateurService)
        {
            _utilisateurService = utilisateurService;
        }

        [HttpGet]
         async Task<List<Utilisateur>> GetUtilisateursAsync()
        {
            return await _utilisateurService.GetUtilisateursAsync();
        }

        [HttpGet("{id}")]
         async Task<Utilisateur> GetUtilisateurByIdAsync(int id)
        {
            return await _utilisateurService.GetUtilisateurByIdAsync(id);
        }

        [HttpPost]
        async Task<CreatedAtActionResult> CreateUtilisateur(Utilisateur utilisateur)
        {
            await _utilisateurService.CreateUtilisateurAsync(utilisateur);
            return CreatedAtAction(nameof(GetUtilisateurByIdAsync), new { id = utilisateur.Id }, utilisateur);
        }

        [HttpPut("{id}")]
        async Task<BadRequestResult> UpdateUtilisateur(Utilisateur utilisateur, int id)
        {
            if (id != utilisateur.Id)
            {
                return BadRequest();
            }

            try
            {
                await _utilisateurService.UpdateUtilisateurAsync(utilisateur, id);
            }
            catch (Exception ex)
            {
                StatusCode(500, $"Internal server error: {ex.Message}");
            }

            return null;
        }

        [HttpDelete("{id}")]
        public async Task<NoContentResult> DeleteUtilisateur(int id)
        {
            await _utilisateurService.DeleteUtilisateurAsync(id);
            return NoContent();
        }

    }
}


