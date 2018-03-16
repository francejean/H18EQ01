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
Abréviation du type du control (2 lettres min.) + "_" + fonction du control
lowerCamelCase
ex : "bt_home", "dgv_chambresLouees"
```
```
Form : "Form" + fonction
```
### DB

```
CREATE TABLE NOMTABLE
(
    NomChamp        INT     NOT NULL,
    CleEtrangere    INT     NULL
);
```
```
ALTER TABLE <NOM_TABLE>
	ADD CONSTRAINT <NOM_TABLE|_PK_|NOM_KEY> PRIMARY KEY CLUSTERED (<NOM_KEY>)
ALTER TABLE <NOM_TABLE>
	ADD CONSTRAINT <NOM_TABLE|_FK_|NOM_KEY> FOREIGN KEY (<NOM_KEY>) REFERENCES <NOM_FOREIGN_TABLE>(<NOM_KEY>)
```

### Fichiers

**Images** : Nom_Image(Nom_Auteur).png


### Formulaire de base : 
![CommunForm](https://raw.githubusercontent.com/francejean/H18EQ01/master/Standards/Standard%20Interface.png)
