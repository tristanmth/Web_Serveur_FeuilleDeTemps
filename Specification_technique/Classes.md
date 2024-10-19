# Documentation du Système de Gestion des Temps

## Classe Utilisateur

### Description
Représente un membre de l'équipe qui saisit ses temps de travail.

### Attributs
- **Id (int)** : Identifiant unique de l'utilisateur.
- **Nom (string)** : Nom complet de l'utilisateur.
- **Email (string)** : Adresse email de l'utilisateur.

### Méthodes
- **AjouterTemps(DateTime date, string categorie, double temps)** : Ajoute le temps saisi.
- **ModifierTemps(DateTime date, string categorie, double nouveauTemps)** : Modifie le temps saisi.
- **GetTotalTemps()** : Retourne le temps total saisi.

## Classe Sprint

### Description
Représente une période de travail définie pour l'équipe.

### Attributs
- **Id (int)** : Identifiant unique du sprint.
- **Nom (string)** : Nom du sprint.
- **DateDebut (DateTime)** : Date de début du sprint.
- **DateFin (DateTime)** : Date de fin du sprint.
- **Membres (List<Utilisateur>)** : Liste des utilisateurs participant au sprint.

### Méthodes
- **AjouterMembre(Utilisateur utilisateur)** : Ajoute un membre au sprint.
- **GetDuréeSprint()** : Calcule la durée totale du sprint.


## Classe Categorie

### Description
Représente une catégorie d'éléments de travail.

### Attributs
- **Id (int)** : Identifiant unique de la catégorie.
- **Nom (string)** : Nom de la catégorie.

### Méthodes
- **GetNom()** : Retourne le nom de la catégorie.

## Classe GestionTemps

### Description
Gère la logique de saisie et de modification des temps.

### Méthodes
- **SaisirTemps(Utilisateur utilisateur, DateTime date, string categorie, double temps)** : Saisit le temps pour un utilisateur.
- **ModifierTemps(Utilisateur utilisateur, DateTime date, string categorie, double nouveauTemps)** : Modifie le temps saisi pour un utilisateur.