CREATE TABLE TYPECHAM
(
	CodTypCham	VARCHAR(2) 	NOT NULL PRIMARY KEY,
	DescTyp 	VARCHAR(25)	NULL,
	NbDispo 	int(3)		NULL
);

CREATE TABLE LOCALISATION
(
	CodLoc 		VARCHAR(2)	NOT NULL PRIMARY KEY,
	DescLoc 	VARCHAR(25)	NULL,
);

CREATE TABLE CHAMBRE
(
	NoCham 		VARCHAR(3) 	NOT NULL PRIMARY KEY,
	Etage 		VARCHAR(2)	NULL,
	Prix 		DECIMAL(5,2)	NULL,
	Etat 		TINYINT		NULL,
	Memo 		VARCHAR(MAX)	NULL,
	CodLoc 		VARCHAR(2)	NULL, 	
	CodTypCham 	VARCHAR(2)	NULL,
	FOREIGN KEY (CodLoc)		REFERENCES LOCALISATION(CodLoc), 	
	FOREIGN KEY (CodTypCham)	REFERENCES TYPECHAM(CodTypChan)
);

CREATE TABLE COMMODITE
(
	CodCom	VARCHAR(2)		NOT NULL PRIMARY KEY,
	DescCom VARCHAR(25)		NULL,
);

CREATE TABLE AYANT
(
	NoCham 	VARCHAR(3) 		NULL,
	CodCom 	VARCHAR(2)		NULL,
	FOREIGN KEY (NoCham)		REFERENCES CHAMBRE(NoCham),	
	FOREIGN KEY (CodCom)		REFERENCES COMMODITE(CodCom)
);
