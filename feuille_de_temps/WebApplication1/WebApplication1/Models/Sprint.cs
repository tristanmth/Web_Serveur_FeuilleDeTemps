using System;
using System.Collections.Generic;
using WebApplication1.Models;

public class Sprint
{
    public int Id { get; set; }
    public required string Nom { get; set; }
    public DateTime DateDebut { get; set; }
    public DateTime DateFin { get; set; }
    public ICollection<Membre> Membres { get; set; } = new List<Membre>();
}
