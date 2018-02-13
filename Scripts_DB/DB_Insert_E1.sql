USE H18EQ01;

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
