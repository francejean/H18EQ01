USE H18EQ01;

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