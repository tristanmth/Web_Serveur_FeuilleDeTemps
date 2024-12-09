using Microsoft.AspNetCore.Mvc.RazorPages;
using Universell.Domain.Entities;
using Universell.Services;

namespace Universell.Server.Models
{
    public class SprintModel
    {
        private readonly ISprintService _sprintService;
        public SprintModel(ISprintService sprintService)
        {
            _sprintService = sprintService;
        }

        public List<Sprint> Sprint { get; set; }

        public async Task OnGetAsync()
        {
            Sprint = await _sprintService.GetSprintsAsync();
        }

    }
}
