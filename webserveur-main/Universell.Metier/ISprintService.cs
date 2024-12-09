using Universell.Domain.Entities;

namespace Universell.Services
{
    public interface ISprintService
    {   
        Task<List<Sprint>> GetSprintsAsync();
        Task<Sprint> GetSprintByIdAsync(int id);
    }
}
