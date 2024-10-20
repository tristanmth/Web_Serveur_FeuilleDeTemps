# Maquette de la page d'accueil
## Description de l'interface

- La page d'accueil est la première interface que les utilisateurs voient. Elle doit être intuitive et facile à naviguer.
- En haut de la page, un header affiche la période du sprint courant (date de début et date de fin).

## Sections principales

### Sélection du sprint :
- Un menu déroulant permet de choisir le sprint actif. Par défaut, le sprint courant est sélectionné.
### Sélection du jour :
- Un autre menu déroulant permet de choisir le jour du sprint. La date par défaut est le jour actuel.
### Liste des membres de l'équipe :
- Une section présente tous les membres de l'équipe sous forme de liste. Chaque membre a un bouton "Saisir Temps" à côté de son nom.

## Actions disponibles

- Un bouton "Visualiser Temps" permet de voir les temps déjà saisis pour le membre sélectionné.
- Les filtres de sprint et de jour doivent être facilement accessibles et bien visibles.

# Maquette du formulaire de saisie des temps
## Description de l'interface

- Ce formulaire s'ouvre lorsque l'utilisateur clique sur "Saisir Temps" à côté du nom d'un membre de l'équipe.
- L'interface doit être simple et claire, avec un design cohérent avec le reste de l'application.

## Champs du formulaire

### Catégorie de travail :
- Un menu déroulant permet de sélectionner la catégorie (ex. bug, user story, conteneur).
### Temps saisi :
- Un champ de saisie pour entrer le temps passé.
### Boutons :
- Un bouton "Soumettre" pour valider la saisie.
- Un bouton "Annuler" pour revenir à la page précédente sans enregistrer.

## Validation des saisies

- Des messages d'erreur s'affichent sous les champs en cas de saisie invalide (ex. temps négatif, catégorie non sélectionnée).
- Confirmation visuelle de la soumission réussie.

# Maquette de l'affichage des temps saisis
## Description de l'interface

- Cette page affiche les temps saisis pour le membre sélectionné.
- Elle doit être accessible depuis la page d'accueil via le bouton "Visualiser Temps".

## Sections principales

### Liste des saisies :
- Une table avec des colonnes pour la catégorie de travail, le temps saisi et des actions (modifier, supprimer).
### Temps total :
- Une indication du temps total saisi par le membre, avec une alerte si le temps maximum est atteint.

## Actions disponibles

- Bouton "Modifier" à côté de chaque saisie pour permettre l'édition.
- Bouton "Supprimer" pour enlever une saisie (avec confirmation).
