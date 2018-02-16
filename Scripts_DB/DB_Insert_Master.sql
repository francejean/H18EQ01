USE h18equipe1;

/*<RESERVATION>*/
INSERT INTO RESERVATION (IdCli, DateReser, DateDebut, DateFin)
VALUES (1, CURRENT_TIMESTAMP, DATEADD(day, 2, CURRENT_TIMESTAMP), DATEADD(day, 5, CURRENT_TIMESTAMP));
INSERT INTO RESERVATION (IdCli, DateReser, DateDebut, DateFin)
VALUES (2, CURRENT_TIMESTAMP, DATEADD(day, 3, CURRENT_TIMESTAMP), DATEADD(day, 7, CURRENT_TIMESTAMP));
INSERT INTO RESERVATION (IdCli, DateReser, DateDebut, DateFin)
VALUES (3, DATEADD(day, -6, CURRENT_TIMESTAMP), DATEADD(day, -3, CURRENT_TIMESTAMP), DATEADD(day, 1, CURRENT_TIMESTAMP));
INSERT INTO RESERVATION (IdCli, DateReser, DateDebut, DateFin)
VALUES (4, DATEADD(day, -8, CURRENT_TIMESTAMP), DATEADD(day, -2, CURRENT_TIMESTAMP), CURRENT_TIMESTAMP);
INSERT INTO RESERVATION (IdCli, DateReser, DateDebut, DateFin)
VALUES (5, DATEADD(day, -10, CURRENT_TIMESTAMP), DATEADD(day, -3, CURRENT_TIMESTAMP), DATEADD(day, -1, CURRENT_TIMESTAMP));
/*</RESERVATION>*/

/*<DE>*/
INSERT INTO DE VALUES (false, 1, '???');
INSERT INTO DE VALUES (false, 2, '???');
INSERT INTO DE VALUES (true,  3, '???');
INSERT INTO DE VALUES (true,  4, '???');
INSERT INTO DE VALUES (false, 5, '???');
/*</DE>*/

/*<DEPART>*/
INSERT INTO DEPART (DateDepart, ConfirmerPar, IdReser, NoCham, IdCli)
VALUES (DATEADD(day, -1, CURRENT_TIMESTAMP), "O.L.P.", 5, '???', 5);
/*</DEPART>*/

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

/*<CLIENT>*/
INSERT INTO CLIENT (Nom,Adresse,Telephone,NoCarte,TypeCarte,DatExp,SoldeDu) 
VALUES/*1*/('Guy Tare','818 Rue Jean-Chretien','8195394567','450067891234786','MASTERCARD','20201123',1350);
INSERT INTO CLIENT (Nom,Adresse,Telephone,NoCarte,TypeCarte,DatExp,SoldeDu) 
VALUES/*2*/('Helene Beaupre','12 Boulevard Marie','8194490745','8900765835294027','MASTERCARD','20220102',213);
INSERT INTO CLIENT (Nom,Adresse,Telephone,NoCarte,TypeCarte,DatExp,SoldeDu) 
VALUES/*3*/('Maxime Lavoie','900 Rang 4','8198574367','3456903294626469','AMERICAN EXPRESS','20250725',2457);
INSERT INTO CLIENT (Nom,Adresse,Telephone,NoCarte,TypeCarte,DatExp,SoldeDu) 
VALUES/*4*/('Claude Perche','34 Avenue Des Cures','8192215630','6987345621935428','VISA','20190117',90);
INSERT INTO CLIENT (Nom,Adresse,Telephone,NoCarte,TypeCarte,DatExp,SoldeDu) 
VALUES/*5*/('Christophe Roche','5607 Rue Ouest','8194907321','7812336522145658','VISA','20231226',876);
INSERT INTO CLIENT (Nom,Adresse,Telephone,NoCarte,TypeCarte,DatExp,SoldeDu) 
VALUES/*6*/('Laurie Poisson','990 Carrefour Jalon','8190437920','3561426562148523','MASTERCARD','20181123',520);
INSERT INTO CLIENT (Nom,Adresse,Telephone,NoCarte,TypeCarte,DatExp,SoldeDu) 
VALUES/*7*/('Karl Coral','3462 Port-au-prince','8198430245','5425564525425651','VISA','20210218',164);
INSERT INTO CLIENT (Nom,Adresse,Telephone,NoCarte,TypeCarte,DatExp,SoldeDu) 
VALUES/*8*/('Jane Stephans','49 Main Street','8198558701','6521331456255682','AMERICAN EXPRESS','20220509',391);
INSERT INTO CLIENT (Nom,Adresse,Telephone,NoCarte,TypeCarte,DatExp,SoldeDu) 
VALUES/*9*/('Luc Gionno','123 Boulevard des Hetres','8190914833','2215666647235698','MASTERCARD','20241031',765);
INSERT INTO CLIENT (Nom,Adresse,Telephone,NoCarte,TypeCarte,DatExp,SoldeDu) 
VALUES/*10*/('Valerie Bontemps','77 Rue des Ecoliers','8199433554','5621146655522333','VISA','20190912',3700);
/*</CLIENT>*/

/*<ARRIVE>*/
INSERT INTO ARRIVE (DateArrive,IdCli,IdReser,NoCham) 
VALUES (DATEADD(day, -3, CURRENT_TIMESTAMP),3,3,'???');
INSERT INTO ARRIVE (DateArrive,IdCli,IdReser,NoCham) 
VALUES (DATEADD(day, -2, CURRENT_TIMESTAMP),4,4,'???');
INSERT INTO ARRIVE (DateArrive,IdCli,IdReser,NoCham) 
VALUES (DATEADD(day, -3, CURRENT_TIMESTAMP),5,5,'???');
/*</ARRIVE>*/

/*<TYPETRX>*/
INSERT INTO TYPETRX (CodTypTrx,DescTrx,Nature) 
VALUES ('01','PRIX DE LA CHAMBRE','DB');
INSERT INTO TYPETRX (CodTypTrx,DescTrx,Nature) 
VALUES ('02','LIT ADDITIONNEL','DB');
INSERT INTO TYPETRX (CodTypTrx,DescTrx,Nature) 
VALUES ('10','TELEPHONE INTERURBAIN','DB');
INSERT INTO TYPETRX (CodTypTrx,DescTrx,Nature) 
VALUES ('21','PHOTOCOPIE','DB');
INSERT INTO TYPETRX (CodTypTrx,DescTrx,Nature) 
VALUES ('22','INTERNET','DB');
INSERT INTO TYPETRX (CodTypTrx,DescTrx,Nature) 
VALUES ('30','RESTAURANT','DB');
INSERT INTO TYPETRX (CodTypTrx,DescTrx,Nature) 
VALUES ('31','BAR TERRASSE','DB');
INSERT INTO TYPETRX (CodTypTrx,DescTrx,Nature) 
VALUES ('50','DEPOT ARGENT','CR');
INSERT INTO TYPETRX (CodTypTrx,DescTrx,Nature) 
VALUES ('60','PAIEMENT','CR');
/*</TYPETRX>*/

/*<TRX>*/
INSERT INTO TRX (DateTrx,MontantTrx,Reportee,CodTypTrx,IdReser,NoCham,IdCli)
VALUES (DATEADD(day, -1, CURRENT_TIMESTAMP),234.56,1,'01',5,'???',5);
INSERT INTO TRX (DateTrx,MontantTrx,Reportee,CodTypTrx,IdReser,NoCham,IdCli)
VALUES (CURRENT_TIMESTAMP,52.99,0,'60',2,'???',2);
/*</TRX>*/
