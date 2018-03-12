USE h18equipe1;

/*<TYPECHAM>*/ 
INSERT INTO TYPECHAM (CodTypChan, DescTyp, NbDispo)
VALUES ('1J', '1 LIT JUMEAU', 2);
INSERT INTO TYPECHAM (CodTypChan, DescTyp, NbDispo)
VALUES ('2J', '2 LIT JUMEAU', 1);
INSERT INTO TYPECHAM (CodTypChan, DescTyp, NbDispo)
VALUES ('1D', '1 LIT DOUBLE', 1);
INSERT INTO TYPECHAM (CodTypChan, DescTyp, NbDispo)
VALUES ('2D', '2 LIT DOUBLES', 2);
INSERT INTO TYPECHAM (CodTypChan, DescTyp, NbDispo)
VALUES ('LQ', 'LIT QUEEN', 1);
INSERT INTO TYPECHAM (CodTypChan, DescTyp, NbDispo)
VALUES ('LK', 'LIT KING', 1);
INSERT INTO TYPECHAM (CodTypChan, DescTyp, NbDispo)
VALUES ('ST', 'SUITE', 1);
INSERT INTO TYPECHAM (CodTypChan, DescTyp, NbDispo)
VALUES ('SR', 'SALLE RÉCEPTION', 2);
/*</TYPECHAM>*/


/*<COMMODITE>*/
INSERT INTO COMMODITE (CodCom, DescCom) 
VALUES ('AS', 'STANDARDS');
INSERT INTO COMMODITE (CodCom, DescCom) 
VALUES ('BA', 'AVEC BALCON');
INSERT INTO COMMODITE (CodCom, DescCom) 
VALUES ('BT', 'AVEC BAIN TOURBILLON');
INSERT INTO COMMODITE (CodCom, DescCom) 
VALUES ('CC', 'CHAMBRE COMMUNICANTE');
INSERT INTO COMMODITE (CodCom, DescCom) 
VALUES ('IN', 'INTERNET');
INSERT INTO COMMODITE (CodCom, DescCom) 
VALUES ('MB', 'MINI BAR');
INSERT INTO COMMODITE (CodCom, DescCom) 
VALUES ('HP', 'HANDICAPE');
INSERT INTO COMMODITE (CodCom, DescCom) 
VALUES ('NF', 'NON FUMEUR');
/*</COMMODITE>*/


/*<LOCALISATION>*/
INSERT INTO LOCALISATION (CodLoc, DescLoc) 
VALUES ('AR', 'ARRIERE');
INSERT INTO LOCALISATION (CodLoc, DescLoc) 
VALUES ('AS', 'PRES DE L ASCENSEUR');
INSERT INTO LOCALISATION (CodLoc, DescLoc) 
VALUES ('AV', 'AVANT');
INSERT INTO LOCALISATION (CodLoc, DescLoc) 
VALUES ('VM', 'VUE SUR LA MER');
INSERT INTO LOCALISATION (CodLoc, DescLoc) 
VALUES ('SM', 'PRES DE LA SALLE A MANGER');
/*</LOCALISATION **/


/*<CHAMBRE>*/
INSERT INTO CHAMBRE (NoCham, Etage, Prix, Etat, Memo, CodLoc, CodType) 
VALUES ('15', '1', 90.99, 1, NULL, 'AR', '1J');
INSERT INTO CHAMBRE (NoCham, Etage, Prix, Etat, Memo, CodLoc, CodType) 
VALUES ('3', '2', 99.99, 1, NULL, 'AR', '1J');
INSERT INTO CHAMBRE (NoCham, Etage, Prix, Etat, Memo, CodLoc, CodType) 
VALUES ('7', '1', 95.99, 1, NULL, 'AV', '2J');
INSERT INTO CHAMBRE (NoCham, Etage, Prix, Etat, Memo, CodLoc, CodType) 
VALUES ('10', '2', 100.99, 0, 'toilette non fonctionnel', 'AV', '2J');
INSERT INTO CHAMBRE (NoCham, Etage, Prix, Etat, Memo, CodLoc, CodType) 
VALUES ('9', '1', 110.99, 1, NULL, 'AS', '1D');
INSERT INTO CHAMBRE (NoCham, Etage, Prix, Etat, Memo, CodLoc, CodType) 
VALUES ('4', '2', 110.99, 0, 'tapis tacher', 'AS', '1D');
INSERT INTO CHAMBRE (NoCham, Etage, Prix, Etat, Memo, CodLoc, CodType) 
VALUES ('6', '1', 120.99, 1, NULL, 'SM', '2D');
INSERT INTO CHAMBRE (NoCham, Etage, Prix, Etat, Memo, CodLoc, CodType) 
VALUES ('14', '2', 120.99, 1, NULL, 'VM', '2D');
INSERT INTO CHAMBRE (NoCham, Etage, Prix, Etat, Memo, CodLoc, CodType) 
VALUES ('2', '3', 125.99, 1, NULL, 'AS', 'LQ');
INSERT INTO CHAMBRE (NoCham, Etage, Prix, Etat, Memo, CodLoc, CodType) 
VALUES ('11', '3', 130.99, 1, NULL, 'VM', 'LK');
INSERT INTO CHAMBRE (NoCham, Etage, Prix, Etat, Memo, CodLoc, CodType) 
VALUES ('1', '4', 160.99, 1, NULL, 'VM', 'ST');
INSERT INTO CHAMBRE (NoCham, Etage, Prix, Etat, Memo, CodLoc, CodType) 
VALUES ('5', '4', 100.99, 1, NULL, 'AR', 'SR');
INSERT INTO CHAMBRE (NoCham, Etage, Prix, Etat, Memo, CodLoc, CodType) 
VALUES ('8', '4', 100.99, 1, NULL, 'AS', 'SR');
/*</CHAMBRE>*/


/*<AYANT>*/
INSERT INTO AYANT (NoCham, CodCom) VALUES ('15', 'AS');
INSERT INTO AYANT (NoCham, CodCom) VALUES ('3', 'AS');
INSERT INTO AYANT (NoCham, CodCom) VALUES ('7', 'AS');
INSERT INTO AYANT (NoCham, CodCom) VALUES ('10', 'AS');
INSERT INTO AYANT (NoCham, CodCom) VALUES ('9', 'AS');
INSERT INTO AYANT (NoCham, CodCom) VALUES ('4', 'AS');
INSERT INTO AYANT (NoCham, CodCom) VALUES ('6', 'AS');
INSERT INTO AYANT (NoCham, CodCom) VALUES ('14', 'AS');
INSERT INTO AYANT (NoCham, CodCom) VALUES ('2', 'AS');
INSERT INTO AYANT (NoCham, CodCom) VALUES ('11', 'AS');
INSERT INTO AYANT (NoCham, CodCom) VALUES ('1', 'AS');
INSERT INTO AYANT (NoCham, CodCom) VALUES ('5', 'AS');
INSERT INTO AYANT (NoCham, CodCom) VALUES ('8', 'AS');
/*</AYANT>*/
