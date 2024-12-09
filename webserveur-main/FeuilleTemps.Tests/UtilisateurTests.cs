using System;
using FeuilleTemps.Domain.Entities;
using Xunit;

public class UtilisateurTests
{
    [Fact]
    public void AjouterTemps_AjouteCorrectementLeTemps()
    {
        // Arrange
        var utilisateur = new Utilisateur { Nom = "Test", Email = "test@example.com" };
        var date = DateTime.Now;
        var categorie = "Développement";
        var duree = 2.5;

        // Act
        utilisateur.AjouterTemps(date, categorie, duree);

        // Assert
        Assert.Equal(duree, utilisateur.GetTotalTemps());
    }
}
