using FeuilleTemps.Domain.Entities;
using FeuilleTemps.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using FeuilleTemps.Web.Models;

namespace FeuilleTemps.Web.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View();
        }

        // Nouvelle méthode pour la sélection des sprints et des membres
        public IActionResult SelectSprintAndMember()
        {
            var sprints = GetSprints();
            var members = GetTeamMembers();

            var model = new SelectSprintAndMemberViewModel
            {
                Sprints = sprints,
                Members = members
            };

            return View(model);
        }

        private List<Sprint> GetSprints()
        {
            // Logique pour récupérer les sprints disponibles
            return new List<Sprint>
            {
                new Sprint { Id = 1, Nom = "Sprint 1", DateDebut = DateTime.Now.AddDays(-10), DateFin = DateTime.Now.AddDays(4) },
                new Sprint { Id = 2, Nom = "Sprint 2", DateDebut = DateTime.Now.AddDays(5), DateFin = DateTime.Now.AddDays(19) }
            };
        }

        private List<Utilisateur> GetTeamMembers()
        {
            // Logique pour récupérer les membres de l'équipe
            return new List<Utilisateur>
            {
                new Utilisateur { Id = 1, Nom = "Alice", Email = "alice@example.com" },
                new Utilisateur { Id = 2, Nom = "Bob", Email = "bob@example.com" }
            };
        }
    }
}