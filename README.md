# H18EQ01

## Standards

### Code

**Nom de Classes**   : UpperCamelCase
**Nom de Méthodes**  : UpperCamelCase
**Nom de variables** : lowerCamelCase

Le code doit être bien indenté.
Les parenthèses "{}" doivent être come ceci : 
```
void NomMethode()
{
    
}
```

### Répertoires

**Ressources**
```
    ----> Images
    |--> Icônes
    |--> Autres
```
```
"PrjEq01_" + NOM
             |-> UpperCamelCase
```
```
Type du control + "_" + fonction du control
ex : "Button_Home"
```
```
Form : "From" + fonction
```
### DB

```
CREATE TABLE NOMTABLE
(
    NomChamp        INT     NOT NULL,
    CleEtrangere    INT     NULL
    FOREIGN KEY (IdReser),
    FOREIGN KEY (NoCham)    REFERENCES CHAMBRE(NoCham)
);
```

### Fichiers

**DB_CREATE_** + ( E1, E2, ... )  + **.sql**= "DB_CREATE_E1.sql" 
**DB_INSERT_** + ( E1, E2, ... )  + **.sql**= "DB_INSERT_E1.sql" 
**Images** : Nom_Image(Nom_Auteur).png


### Formulaire de base : 
![CommunForm](https://raw.githubusercontent.com/francejean/H18EQ01/master/Standards/Standard%20Interface.png)
