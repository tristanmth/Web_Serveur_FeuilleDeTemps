using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Universell.Domain.Entities;
using Universell.Metier.Services;
using Universell.Models;

namespace Universell.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {

        private readonly IAccountService _accountService;
        private readonly UserManager<Utilisateur> _userManager;
        private readonly SignInManager<Utilisateur> _signInManager;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        public IActionResult Login(string? returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl; // Stocke l'URL d'origine
            return View(new LoginModel());
        }


        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model, string? returnUrl = null)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await _accountService.LoginAsync(model.Login!, model.Password!);
            }
            catch (ArgumentException)
            {
                ModelState.AddModelError(string.Empty, "Identifiants et/ou mot de passe invalide");
                return View(model);
            }
            catch (ApplicationException)
            {
                ModelState.AddModelError(string.Empty, "Votre compte a été bloqué");
            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty, "Erreur innatendue");
            }
            // Rediriger après une connexion réussie
            return Redirect(returnUrl ?? "/");
        }

        public IActionResult Register(string? returnUrl = null)
        {
            return View(new RegisterModel());
        }

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return View();
        }
    }
}
