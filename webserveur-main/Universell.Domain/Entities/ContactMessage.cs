using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universell.Domain.Entities
{
    public class ContactMessage
    {
        public int Id { get; set; }
        public string? ReferenceCommande { get; set; }
        public required string Sujet { get; set; }
        public required string Contenu { get; set; }
        public required string AdresseMail { get; set; }
        public required DateTime DateEnvoi { get; set; }
        public bool EstRepondu { get; set; } = false;
    }

}
