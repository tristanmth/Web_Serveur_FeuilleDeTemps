using Microsoft.AspNetCore.Identity;
using Universell.Domain.Entities;

namespace Universell.Metier.Services
{
    public class AccountService : IAccountService
    {

        private readonly SignInManager<Utilisateur> _signInManager;
        private readonly UserManager<Utilisateur> _userManager;

        public AccountService(SignInManager<Utilisateur> signInManager, UserManager<Utilisateur> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public async Task LoginAsync(string username, string password)
        {
            // Trouver l'utilisateur par son login ou email
            var user = await _userManager.FindByNameAsync(username) ??
                       await _userManager.FindByEmailAsync(username);

            if (user == null)
                throw new ArgumentException($"{nameof(LoginAsync)} user inexistant");

            // Tenter de se connecter avec le mot de passe fourni
            var result = await _signInManager.PasswordSignInAsync(user, password, isPersistent: true, lockoutOnFailure: false);
            if (result.Succeeded)
                return;
            if (result.IsLockedOut)
                throw new ApplicationException($"{nameof(LoginAsync)} user locked out");
            else
                throw new ArgumentException($"{nameof(LoginAsync)} mauvais login");

        }
    }
}
