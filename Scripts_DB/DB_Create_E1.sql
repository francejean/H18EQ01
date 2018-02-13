USE h18equipe1;

CREATE TABLE RESERVATION
(
	IdReser     INT         NOT NULL    IDENTITY(1,1),
    IdCli       INT         NULL,
    DateReser   DATE        NULL,
    DateDebut   DATE        NULL,
    DateFin     DATE        NULL,
    PRIMARY KEY (IdReser),
    FOREIGN KEY (IdCli)     REFERENCES CLIENT(IdCli)
);

CREATE TABLE DE
(
    Attribuee	BIT			NULL,
    IdReser     INT         NULL,
    NoCham      VARCHAR(6)  NULL,
    FOREIGN KEY (IdReser)   REFERENCES RESERVATION(IdReser),
    FOREIGN KEY (NoCham)    REFERENCES CHAMBRE(NoCham)
);

CREATE TABLE DEPART
(
    IdDepart     INT        NOT NULL    IDENTITY(1,1),
    DateDepart   DATE       NULL,
    ConfirmerPar VARCHAR(6) NULL,
    IdReser      INT        NULL,
    NoCham       VARCHAR(6) NULL,
    IdCli        INT        NULL,
    PRIMARY KEY (IdDepart),
    FOREIGN KEY (IdReser)   REFERENCES RESERVATION(IdReser),
    FOREIGN KEY (NoCham)    REFERENCES CHAMBRE(NoCham),
    FOREIGN KEY (IdCli)     REFERENCES CLIENT(IdCli)
);
