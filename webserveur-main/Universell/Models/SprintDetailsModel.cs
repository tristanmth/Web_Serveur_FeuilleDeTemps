using Microsoft.AspNetCore.Mvc.RazorPages;
using Universell.Domain.Entities;
using Universell.Services;

namespace Universell.Server.Models
{
    public class SprintDetailsModel : PageModel
    {
        public readonly ISprintService _sprintService;

        public SprintDetailsModel(ISprintService sprintService)
        {
            _sprintService = sprintService;
        }

        public Sprint Sprint { get; set; }

        public async Task OnGetAsync(int id)
        {
            Sprint = await _sprintService.GetSprintByIdAsync(id);
        }   
    }
}
