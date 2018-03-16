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
Abbreviation du type du control (2 lettres min.) + "_" + fonction du control
Lower camel case
ex : "bt_home", "dgv_chambresLouees"
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
```
ALTER TABLE <NOM_TABLE>
	ADD CONSTRAINT <NOM_TABLE|_PK_|NOM_KEY> PRIMARY KEY CLUSTERED (<NOM_KEY>)
ALTER TABLE <NOM_TABLE>
	ADD CONSTRAINT <NOM_TABLE|_FK_|NOM_KEY> FOREIGN KEY (<NOM_KEY>) REFERENCES <NOM_FOREIGN_TABLE>(<NOM_KEY>)
```

### Fichiers

**DB_CREATE_** + ( E1, E2, ... )  + **.sql**= "DB_CREATE_E1.sql" 
**DB_INSERT_** + ( E1, E2, ... )  + **.sql**= "DB_INSERT_E1.sql" 
**Images** : Nom_Image(Nom_Auteur).png


### Formulaire de base : 
![CommunForm](https://raw.githubusercontent.com/francejean/H18EQ01/master/Standards/Standard%20Interface.png)
