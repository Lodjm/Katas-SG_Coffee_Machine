# Distributeur automatique de boisson chaude

## Enoncé
Features : Pouvoir commander une boisson 

- Input : Sélectionner le nom de la boisson
- Output : Afficher le prix de vente de la boisson

Le code doit être évolutif, afin de pouvoir créer facilement de nouvelles recettes.

Le but n’étant pas d’avoir un projet fini, mais bien fait (prévoir jusqu’à 1h)

## Contraintes techniques 
- Le livrable doit être fournis via un gestionnaire de code de votre choix (exemple GIT, TFS …)
- Langage C# 

## Description
Prix coûtant des recettes : calculé en fonction des doses d’ingrédient qui constituent la recette

Prix de vente : Prix coûtant des recettes + marge de 30%

Ingrédients : 

|**Ingrédient**|**Prix / dose**|
| :- | :- |
|**Café**|1 €|
|**Sucre**|0,1 €|
|**Crème**|0,5€|
|**Thé**|2 €|
|**Eau**|0,2 €|
|**Chocolat**|1 €|
|**Lait**|0,4 €|

Recettes :

|**Nom des recettes**|**Ingrédients**|
| :- | :- |
|**Expresso**|1 dose de café, 1 dose d’eau|
|**Allongé**|1 dose de café, 2 doses d’eau|
|**Capuccino**|1 dose de café, 1 dose de chocolat, 1 dose d’eau, 1 dose de crème|
|**Chocolat**|3 doses de chocolat, 2 doses de lait, 1 dose d’eau, 1 dose de sucre|
|**The**|1 dose de thé, 2 doses d’eau|
