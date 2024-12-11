using System.Collections.Generic;
using WebApplication1.Models;

public class Membre
{
    public int Id { get; set; }
    public required string Nom { get; set; }
    public string? Role { get; set; }
    public ICollection<TempsTravail> TempsTravails { get; set; } = new List<TempsTravail>();
}
