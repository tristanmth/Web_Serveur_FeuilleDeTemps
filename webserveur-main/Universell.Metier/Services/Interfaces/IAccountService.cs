namespace Universell.Metier.Services
{
    public interface IAccountService
    {
        Task LoginAsync(string username, string password);
    }
}
