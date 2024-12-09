using Microsoft.EntityFrameworkCore;
using Universell.Domain;
using Universell.Domain.Entities;

namespace Universell.Services
{
    public class SprintService : ISprintService
    {
        private readonly UniversellDbContext _context;
        public SprintService(UniversellDbContext context)
        {
            _context = context;
        }
        public async Task<List<Sprint>> GetSprintsAsync()
        {
            return await _context.Sprints.ToListAsync();
        }
        public async Task<Sprint> GetSprintByIdAsync(int id)
        {
            return await _context.Sprints.FirstOrDefaultAsync(s => s.Id == id);
        }

     
    }
}
