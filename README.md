Bien sûr! Voici le texte reformaté au format Markdown:

# Les design patterns (patterns de conception)

Les design patterns permettent notamment d'accélérer le processus de développement. Cela aide à gagner du temps sans avoir à réinventer des modèles chaque fois qu'un problème apparaît. Ils sont basés sur les bonnes pratiques de la programmation orientée objet et abstraient la conception d'objet.

## Présentation des design patterns

Les design patterns sont décrits selon les éléments suivants :

- Nom
- Objectif
- Exemple de code sous forme de diagramme UML
- Structure abstraite
- Un exemple de code concret

### Cas concret

Nous allons prendre en exemple le cas d'une société qui vend des véhicules en ligne.

Il est important de sélectionner et d'utiliser un pattern qui peut répondre à la problématique que l'on rencontre.

# Première grande famille de design patterns: Les patterns de construction

Le but des patterns de construction est de simplifier la création d'objet en rendant le processus abstrait et standardisé, peu importe les détails d'implémentation. On favorise l'usage d'interface pour interagir avec les objets, comme le pattern Singleton qui permet d'avoir une classe avec une seule instance. Les clients utilisant cette classe ne sont pas conscients de l'unicité de l'instance, et la création d'objet est masquée au client. Ainsi, le modèle abstrait est identique, mais l'instanciation diffère.

### Le pattern Abstract Factory

Le but est d'avoir des familles d'objets autour d'une classe abstraite, sans besoin de connaître la classe concrète pour créer les objets. Il comprend une classe abstraite générique et des sous-classes concrètes.

![Alt text](<image/template pattern.png>)

Les lignes pointillées représentent une relation où l'un ne peut exister sans l'autre. La classe abstraite n'a pas besoin de savoir ce qui est créé, c'est l'interface qui s'en charge. La classe concrète prend en paramètre une instance qui va implémenter une interface.

### Pattern Builder

Permet d'abstraire la conception d'objets complexes de leur implémentation de sorte qu'un client puisse créer des objets complexes sans avoir à se préoccuper des différences d'implémentation.

![Alt text](<image/diagramme pattern builder.png>)

Pourquoi utiliser ce pattern:
- Le client a besoin de construire des objets sans connaître leur implémentation.
- Le client a besoin de construire des objets complexes ayant plusieurs représentations ou implémentations.

### Le pattern Factory Method

Le but de ce pattern est d'introduire une méthode abstraite de création d'objet en reportant aux sous-classes concrètes la création effective.

![Alt text](<image/Le pattern Factor Method.png>)

### Le pattern Singleton

Il faut s'assurer de deux choses si l'on veut mettre en place ce pattern:
- Une classe ne doit posséder qu'une seule instance.
- Fournir une méthode de classe qui permet de fournir cette instance unique.

### Le pattern prototype

Le but de ce pattern est de créer de nouveaux objets en dupliquant des objets existants appelés "prototype", car ces derniers disposent d'une capacité de clonage.

![Alt text](<image/Pattern prototype.png>)

## Les patterns de structuration

Le but de ce pattern est de rendre indépendante l'interface d'un objet de son implémentation en encapsulant les objets à l'aide d'interfaces. Les patterns de structure correspondent à des manières d'organiser les classes ou les objets de façon à ce qu'ils soient faciles à utiliser.

L'objectif des patterns de structuration est de faciliter l'indépendance de l'interface d'un objet ou d'un ensemble d'objets vis-à-vis de son implantation. Dans le cas d'un ensemble d'objets, il s'agit aussi de rendre cette interface indépendante de la hiérarchie des classes et de la composition des objets. En fournissant les interfaces, les patterns de structuration encapsulent la composition des objets, augmentant le niveau d'abstraction du système à l'image des patterns de création qui encapsulent la création des objets. Les patterns de structuration mettent en avant les interfaces. L'encapsulation de la composition est réalisée non pas en structurant l'objet lui-même, mais en transférant cette structuration à un second objet. Celui-ci est intimement lié au premier objet. Ce transfert de structuration signifie que le premier objet détient l'interface vis-à-vis des clients et gère la relation avec le second objet qui lui gère la composition et n'a aucune interface avec les clients externes.

### Le pattern Adapter

Ce pattern répond au problème qui survient lorsque vous disposez d'un code qui attend une interface (ensemble de méthodes), mais que l'implémentation que vous comptez utiliser en fournit d'autres. Il permet d'adapter l'interface d'une classe existante afin qu'elle puisse interagir avec un client.

### Le pattern Decorator

Un décorateur permet d'attacher dynamiquement de nouvelles responsabilités à un objet sans modifier son interface. Toutes les modifications apportées par ce pattern seront transparentes vis-à-vis des clients. Ce pattern constitue une alternative à la création de sous-classes pour enrichir les fonctionnalités d'un objet. On peut créer plusieurs composants concrets. On peut étendre les fonctionnalités de nos composants grâce au décorateur. Le décorateur est une classe abstraite qui hérite de Composant et qui a un attribut Composant. Chaque DecorateurConcret redéfinit les méthodes de Décorateur.

![Alt text](<image/pattern decorator.png>)

### Le pattern bridge

![Alt text](<image/bridge Pattern1.png>)

Le pont est un patron de conception de la famille structuration, qui permet de découpler l'interface d'une classe et son implémentation.

La partie concrète (implémentation réelle) peut alors varier, indépendamment de celle abstraite (définition virtuelle), tant qu'elle respecte le contrat de réécriture associé qui les lie (obligation de se conformer aux signatures des fonctions/méthodes, et de leur fournir un corps physique d'implémentation).

### Le pattern composite

![Alt text](<image/Composite pattern.png>)

Au sein de notre système de vente de véhicules, nous voulons représenter les sociétés clientes, notamment pour connaître le nombre de véhicules dont elles disposent et leur proposer des offres de maintenance de leur parc. Les sociétés qui possèdent des filiales demandent des offres de maintenance qui prennent en compte le parc de véhicules de leurs filiales. Une solution immédiate consiste à

 traiter différemment les sociétés sans filiale et celles possédant des filiales. Cependant, cette différence de traitement entre les deux types de sociétés rend l'application plus complexe et dépendante de la composition interne des sociétés clientes.

Le pattern composite résout ce problème en unifiant l'interface des deux types de sociétés et en utilisant la composition récursive. Cette composition récursive est nécessaire car une société peut posséder des filiales qui possèdent elles-mêmes d'autres filiales.

## Les patterns comportementaux

Le pattern "Chain of Responsibility" (Chaîne de responsabilité) permet à plusieurs objets de se succéder pour traiter une demande. Chaque objet "handler" vérifie s'il peut gérer la demande, et s'il ne le peut pas, il la transmet au handler suivant dans la chaîne jusqu'à ce qu'elle soit traitée ou que la fin de la chaîne soit atteinte. Cette approche réduit le couplage entre les objets, car chaque handler ne dépend pas directement des autres et n'a pas besoin de connaître l'ensemble de la chaîne de responsabilité. Cela rend le traitement des demandes plus souple et modulaire.
