using System.Collections.Generic;
using FeuilleTemps.Domain.Entities;

namespace FeuilleTemps.Web.Models
{
    public class SelectSprintAndMemberViewModel
    {
        public List<Sprint> Sprints { get; set; }
        public List<Utilisateur> Members { get; set; }
    }
}