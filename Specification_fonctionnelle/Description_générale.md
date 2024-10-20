# Introduction
## Objectif de l'application

L'application a pour but de faciliter la saisie et la gestion des temps de travail des membres d'une équipe durant un sprint. Elle permet aux utilisateurs de suivre le temps consacré à différentes tâches, d'assurer une répartition équilibrée des efforts et de respecter les contraintes de temps allouées. Cette solution vise à améliorer la visibilité sur la productivité de l'équipe et à soutenir une gestion agile efficace.

## Contexte du développement

Le projet est réalisé dans un cadre Agile, favorisant des itérations rapides et une collaboration étroite entre les membres de l'équipe. L'équipe de développement est composée de développeurs, de designers et d'un chef de projet. Les feedbacks des utilisateurs finaux sont pris en compte à chaque étape pour s'assurer que l'application répond aux besoins pratiques du quotidien.

# Fonctionnalités principales

## Page d'accueil avec sélection des sprints et membres

- La page d'accueil présente une interface claire où les utilisateurs peuvent sélectionner le sprint en cours et choisir un membre de l'équipe.
- Un affichage dynamique indique les sprints disponibles et leur période, avec un indicateur visuel du sprint courant.
- Les utilisateurs peuvent également choisir un jour spécifique du sprint pour voir et saisir les temps de manière granulaire.

## Formulaire de saisie des temps

- Lorsqu'un membre de l'équipe est sélectionné, un formulaire s'affiche permettant de saisir le temps passé sur chaque catégorie d'élément de travail (ex. bugs, user stories, etc.).
- Le formulaire inclut des champs pour :
    - Sélectionner la catégorie de travail
    - Saisir le temps passé (en fractions de journée)
    - Un bouton pour soumettre la saisie.
- La validation des données est effectuée pour éviter des erreurs (ex. temps négatif ou dépassement du temps maximum autorisé).

## Affichage et modification des temps saisis

- Les temps déjà saisis sont affichés dans une liste claire, regroupés par membre et catégorie de travail.
- Les utilisateurs peuvent modifier leurs saisies jusqu'à la fin du sprint, offrant ainsi une flexibilité pour ajuster les enregistrements de temps en fonction des réalités du projet.
- Un indicateur visuel (par exemple, des barres de progression) montre le temps total saisi par rapport au temps maximum autorisé par membre.

## Gestion des paramètres de l'application

- Une interface dédiée permet de gérer les paramètres de l'application, notamment :
    - L'ajout et la suppression de membres de l'équipe.
    - La définition des catégories d'éléments de travail.
    - La configuration du temps maximum autorisé par membre.
- Ces fonctionnalités garantissent que l'application reste adaptable et personnalisée selon les besoins spécifiques de chaque équipe et projet.