using System;

public class TempsTravail
{
    public int Id { get; set; }
    public int SprintId { get; set; }
    public required Sprint Sprint { get; set; }
    public int MembreId { get; set; }
    public required Membre Membre { get; set; }
    public required string Categorie { get; set; }
    public double TempsPasse { get; set; }
    public DateTime Date { get; set; }
}
