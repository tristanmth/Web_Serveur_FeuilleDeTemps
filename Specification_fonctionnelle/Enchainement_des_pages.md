# Page d'accueil
## Description :

C'est la première page accessible après la connexion à l'application. Elle affiche la période du sprint courant et permet de sélectionner le sprint et le jour.

## Actions possibles :

- Choisir un sprint dans le menu déroulant.
- Sélectionner un jour du sprint.
- Cliquer sur "Saisir Temps" à côté du nom d'un membre.

# Formulaire de saisie des temps
## Transition :

Lorsque l'utilisateur clique sur "Saisir Temps", il est redirigé vers le formulaire de saisie.

## Description :

Ce formulaire permet de saisir le temps passé par le membre sur une catégorie d'élément de travail.

## Actions possibles :

- Sélectionner une catégorie de travail.
- Saisir le temps (en fractions de journée).
- Soumettre le formulaire ou annuler pour revenir à la page d'accueil.

# Retour à la page d'accueil
## Transition :

Après avoir soumis le formulaire avec succès, l'utilisateur est redirigé vers la page d'accueil avec un message de confirmation de la saisie.

## Actions possibles :

- Continuer à saisir des temps pour d'autres membres.
- Visualiser les temps saisis.

# Affichage des temps saisis
## Transition :

L'utilisateur clique sur "Visualiser Temps" à côté d'un membre.

## Description :

Une liste des temps saisis pour le membre sélectionné s'affiche, incluant les catégories et les temps associés.

## Actions possibles :

- Modifier ou supprimer une saisie existante.
- Retourner à la page d'accueil.

# Modification d'une saisie
## Transition :

L'utilisateur clique sur "Modifier" à côté d'une saisie.

## Description :

Le formulaire s'ouvre prérempli avec les informations de la saisie sélectionnée.

## Actions possibles :

Modifier le temps ou la catégorie.
Soumettre les modifications ou annuler pour revenir à la page d'affichage des temps saisis.

# Suppression d'une saisie
## Transition :

L'utilisateur clique sur "Supprimer" à côté d'une saisie.

## Description :

Une confirmation de suppression s'affiche pour éviter les erreurs.

## Actions possibles :

- Confirmer la suppression, ce qui renvoie l'utilisateur à la page d'affichage des temps saisis.
- Annuler la suppression pour revenir à la page d'affichage.
