Pattern Commande
===============

Définition officielle : le pattern commande encapsule une requête en tant qu'objet, autorisant ainsi le paramétrage des clients par différentes requêtes, files d'attente et récapitulatifs de requêtes, et de plus, permettant la réversibilité des opérations.


Contexte d'application du pattern Commande : 
  * plusieurs éléments effectuent des actions hétérogènes (i.e. n'implémentent pas nécéssairement d'interface commune)
  * on désire réduire ces différentes actions à un ensemble de commandes génériques et paramétrables à la volée

Exemple choisi :
On veut créer une télécommande permettant d'actionner des objets de la maison (lampe du salon, porte du garage, alarme) et d'annuler l'action.
La télécommande devra fournir un moyen de redéfinir l'objet actionné. 

Pour aller plus loin (comme dans le livre d'O'Reilly), on pourrait avoir plusieurs boutons, associés chacun à des objets de la maison (je n'ai pas développé cela car le pattern se comprend mieux avec seulement un Récepteur associé.
