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
VALUES ('102', '1', 90.99, 1, NULL, 'AR', '1J'); 
INSERT INTO CHAMBRE (NoCham, Etage, Prix, Etat, Memo, CodLoc, CodType)  
VALUES ('202', '2', 99.99, 1, NULL, 'AR', '1J'); 
INSERT INTO CHAMBRE (NoCham, Etage, Prix, Etat, Memo, CodLoc, CodType)  
VALUES ('104', '1', 95.99, 1, NULL, 'AV', '2J'); 
INSERT INTO CHAMBRE (NoCham, Etage, Prix, Etat, Memo, CodLoc, CodType)  
VALUES ('201', '2', 100.99, 0, 'toilette non fonctionnel', 'AV', '2J'); 
INSERT INTO CHAMBRE (NoCham, Etage, Prix, Etat, Memo, CodLoc, CodType)  
VALUES ('101', '1', 110.99, 1, NULL, 'AS', '1D'); 
INSERT INTO CHAMBRE (NoCham, Etage, Prix, Etat, Memo, CodLoc, CodType)  
VALUES ('207', '2', 110.99, 0, 'tapis tacher', 'AS', '1D'); 
INSERT INTO CHAMBRE (NoCham, Etage, Prix, Etat, Memo, CodLoc, CodType)  
VALUES ('105', '1', 120.99, 1, NULL, 'SM', '2D'); 
INSERT INTO CHAMBRE (NoCham, Etage, Prix, Etat, Memo, CodLoc, CodType)  
VALUES ('203', '2', 120.99, 1, NULL, 'VM', '2D'); 
INSERT INTO CHAMBRE (NoCham, Etage, Prix, Etat, Memo, CodLoc, CodType)  
VALUES ('308', '3', 125.99, 1, NULL, 'AS', 'LQ'); 
INSERT INTO CHAMBRE (NoCham, Etage, Prix, Etat, Memo, CodLoc, CodType)  
VALUES ('310', '3', 130.99, 1, NULL, 'VM', 'LK'); 
INSERT INTO CHAMBRE (NoCham, Etage, Prix, Etat, Memo, CodLoc, CodType)  
VALUES ('401', '4', 160.99, 1, NULL, 'VM', 'ST'); 
INSERT INTO CHAMBRE (NoCham, Etage, Prix, Etat, Memo, CodLoc, CodType)  
VALUES ('402', '4', 100.99, 1, NULL, 'AR', 'SR'); 
INSERT INTO CHAMBRE (NoCham, Etage, Prix, Etat, Memo, CodLoc, CodType)  
VALUES ('403', '4', 100.99, 1, NULL, 'AS', 'SR');
/*</CHAMBRE>*/


/*<AYANT>*/
INSERT INTO AYANT (NoCham, CodCom) VALUES ('102', 'AS');
INSERT INTO AYANT (NoCham, CodCom) VALUES ('202', 'AS');
INSERT INTO AYANT (NoCham, CodCom) VALUES ('104', 'HP');
INSERT INTO AYANT (NoCham, CodCom) VALUES ('104', 'IN');
INSERT INTO AYANT (NoCham, CodCom) VALUES ('201', 'HP');
INSERT INTO AYANT (NoCham, CodCom) VALUES ('201', 'NF');
INSERT INTO AYANT (NoCham, CodCom) VALUES ('201', 'IN');
INSERT INTO AYANT (NoCham, CodCom) VALUES ('101', 'AS');
INSERT INTO AYANT (NoCham, CodCom) VALUES ('101', 'IN');
INSERT INTO AYANT (NoCham, CodCom) VALUES ('207', 'AS');
INSERT INTO AYANT (NoCham, CodCom) VALUES ('207', 'IN');
INSERT INTO AYANT (NoCham, CodCom) VALUES ('207', 'NF');
INSERT INTO AYANT (NoCham, CodCom) VALUES ('105', 'AS');
INSERT INTO AYANT (NoCham, CodCom) VALUES ('105', 'IN');
INSERT INTO AYANT (NoCham, CodCom) VALUES ('105', 'NF');
INSERT INTO AYANT (NoCham, CodCom) VALUES ('203', 'AS');
INSERT INTO AYANT (NoCham, CodCom) VALUES ('203', 'IN');
INSERT INTO AYANT (NoCham, CodCom) VALUES ('308', 'AS');
INSERT INTO AYANT (NoCham, CodCom) VALUES ('308', 'IN');
INSERT INTO AYANT (NoCham, CodCom) VALUES ('308', 'BA');
INSERT INTO AYANT (NoCham, CodCom) VALUES ('310', 'AS');
INSERT INTO AYANT (NoCham, CodCom) VALUES ('310', 'IN');
INSERT INTO AYANT (NoCham, CodCom) VALUES ('310', 'NF');
INSERT INTO AYANT (NoCham, CodCom) VALUES ('310', 'BA');
INSERT INTO AYANT (NoCham, CodCom) VALUES ('401', 'IN');
INSERT INTO AYANT (NoCham, CodCom) VALUES ('401', 'BA');
INSERT INTO AYANT (NoCham, CodCom) VALUES ('401', 'BT');
INSERT INTO AYANT (NoCham, CodCom) VALUES ('401', 'MB');
INSERT INTO AYANT (NoCham, CodCom) VALUES ('402', 'AS');
INSERT INTO AYANT (NoCham, CodCom) VALUES ('402', 'IN');
INSERT INTO AYANT (NoCham, CodCom) VALUES ('403', 'AS');
INSERT INTO AYANT (NoCham, CodCom) VALUES ('403', 'IN');
INSERT INTO AYANT (NoCham, CodCom) VALUES ('403', 'NF');
/*</AYANT>*/
