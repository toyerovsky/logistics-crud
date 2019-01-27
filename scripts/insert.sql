INSERT INTO courier
VALUES (courier_id_sequence.nextval, 'Krzysztof', 'Klimek', sysdate, 27);
INSERT INTO courier
VALUES (courier_id_sequence.nextval, 'Zbigniew', 'Rak', sysdate, 34);
INSERT INTO courier
VALUES (courier_id_sequence.nextval, 'Maciek', 'Sobczyk', sysdate, 21);
INSERT INTO courier
VALUES (courier_id_sequence.nextval, 'Patryk', 'Machajek', sysdate, 27);
INSERT INTO courier
VALUES (courier_id_sequence.nextval, 'Damian', 'Malinowski', sysdate, 40);
INSERT INTO courier
VALUES (courier_id_sequence.nextval, 'Leopold', 'Nosacz', sysdate, 36);
INSERT INTO courier
VALUES (courier_id_sequence.nextval, 'Krystian', 'Postrach', sysdate, 28);
INSERT INTO courier
VALUES (courier_id_sequence.nextval, 'Stefan', 'Plaga', sysdate, 32);
INSERT INTO courier
VALUES (courier_id_sequence.nextval, 'Tymon', 'Adamczyk', sysdate, 31);
INSERT INTO courier
VALUES (courier_id_sequence.nextval, 'Wiktor', 'Tomaszewski', sysdate, 29);
INSERT INTO courier
VALUES (courier_id_sequence.nextval, 'Kacper', 'Duda', sysdate, 22);
INSERT INTO courier
VALUES (courier_id_sequence.nextval, 'Aureliusz', 'Jaworski', sysdate, 33);
INSERT INTO courier
VALUES (courier_id_sequence.nextval, 'Konstanty', 'Grabowski', sysdate, 40);
INSERT INTO courier
VALUES (courier_id_sequence.nextval, 'Hipolit', 'Wysocki', sysdate, 27);
INSERT INTO courier
VALUES (courier_id_sequence.nextval, 'Ryszard', 'Grabowski', sysdate, 32);

INSERT INTO vehicle
VALUES (vehicle_id_sequence.nextval, 'TKI 65XV', 'FIAT', 2001, '1GNUCAE07AR261363', sysdate);
INSERT INTO vehicle
VALUES (vehicle_id_sequence.nextval, 'TKI 72YX', 'FIAT', 2001, '1GNFK33079R062321', sysdate);
INSERT INTO vehicle
VALUES (vehicle_id_sequence.nextval, 'TKI 76US', 'FIAT', 2001, '1FDWW36F9YEC65077', sysdate);
INSERT INTO vehicle
VALUES (vehicle_id_sequence.nextval, 'TKI A7B6', 'FIAT', 2001, '1FUPYCYB0CH202916', sysdate);
INSERT INTO vehicle
VALUES (vehicle_id_sequence.nextval, 'TKI 69GH', 'FIAT', 2001, '2CTFLFEY9A6262244', sysdate);
INSERT INTO vehicle
VALUES (vehicle_id_sequence.nextval, 'TKI UB23', 'VOLKSWAGEN', 2005, '1GCEC19V2YE232602', sysdate);
INSERT INTO vehicle
VALUES (vehicle_id_sequence.nextval, 'TKI 89IG', 'VOLKSWAGEN', 2005, '2T1AE93E6KC092578', sysdate);
INSERT INTO vehicle
VALUES (vehicle_id_sequence.nextval, 'TKI SV78', 'VOLKSWAGEN', 2005, '1G3CX53L1N4367520', sysdate);
INSERT INTO vehicle
VALUES (vehicle_id_sequence.nextval, 'TKI U7V8', 'VOLKSWAGEN', 2005, '1G3GS64CX24216417', sysdate);
INSERT INTO vehicle
VALUES (vehicle_id_sequence.nextval, 'TKI 51AC', 'VOLKSWAGEN', 2005, '1XPWDB9XXBD165719', sysdate);
INSERT INTO vehicle
VALUES (vehicle_id_sequence.nextval, 'TKI PO89', 'PEUGOT', 2007, '1FMCU0G90DUB44535', sysdate);
INSERT INTO vehicle
VALUES (vehicle_id_sequence.nextval, 'TKI SC58', 'PEUGOT', 2007, '4VHJCMPE4XN803494', sysdate);
INSERT INTO vehicle
VALUES (vehicle_id_sequence.nextval, 'TKI IA12', 'PEUGOT', 2007, '1M2AN09Y08N083244', sysdate);
INSERT INTO vehicle
VALUES (vehicle_id_sequence.nextval, 'TKI IH64', 'PEUGOT', 2007, '5TFHY5F15BX227011', sysdate);
INSERT INTO vehicle
VALUES (vehicle_id_sequence.nextval, 'TKI YJ12', 'PEUGOT', 2007, '1B7HD14T0DS477958', sysdate);

INSERT INTO address
VALUES (address_id_sequence.nextval, 'Klonowa', 22, '25-026', 'Kielce', 15, sysdate);
INSERT INTO address
VALUES (address_id_sequence.nextval, 'Parkowa', 15, '25-019', 'Kielce', 15, sysdate);
INSERT INTO address
VALUES (address_id_sequence.nextval, 'Ogrodowa', 2, '25-024', 'Kielce', 15, sysdate);
INSERT INTO address
VALUES (address_id_sequence.nextval, 'Osobna', 13, '25-034', 'Kielce', 15, sysdate);
INSERT INTO address
VALUES (address_id_sequence.nextval, 'Klonowa', 60, '25-026', 'Kielce', 15, sysdate);
INSERT INTO address
VALUES (address_id_sequence.nextval, '1 Maja', 34, '10-117', 'Olsztyn', 15, sysdate);
INSERT INTO address
VALUES (address_id_sequence.nextval, 'Agrestowa', 15, '10-327', 'Olsztyn', 15, sysdate);
INSERT INTO address
VALUES (address_id_sequence.nextval, 'Akacjowa', 19, '10-179', 'Olsztyn', 15, sysdate);
INSERT INTO address
VALUES (address_id_sequence.nextval, 'Akacjowa', 29, '10-179', 'Olsztyn', 15, sysdate);
INSERT INTO address
VALUES (address_id_sequence.nextval, 'Pocztowa', 46, '40-002', 'Katowice', 15, sysdate);
INSERT INTO address
VALUES (address_id_sequence.nextval, 'Wodna', 71, '40-008', 'Katowice', 15, sysdate);
INSERT INTO address
VALUES (address_id_sequence.nextval, 'Szkolna', 123, '40-006', 'Katowice', 15, sysdate);
INSERT INTO address
VALUES (address_id_sequence.nextval, 'Bankowa', 61, '40-007', 'Katowice', 15, sysdate);
INSERT INTO address
VALUES (address_id_sequence.nextval, 'Dworcowa', 11, '40-012', 'Katowice', 15, sysdate);
INSERT INTO address
VALUES (address_id_sequence.nextval, 'Dyrekcyjna', 8, '40-013', 'Katowice', 15, sysdate);

INSERT INTO customer
VALUES (customer_id_sequence.nextval, 'Wojciech', 'Duda', 'KOLPORTER', sysdate, 5322822526);
INSERT INTO customer
VALUES (customer_id_sequence.nextval, 'Eugeniusz', 'Pawlak', 'OPONEX', sysdate, 4969445549);
INSERT INTO customer
VALUES (customer_id_sequence.nextval, 'Ksawery', 'Kowalski', 'KOLPORTER', sysdate, 5322822526);
INSERT INTO customer
VALUES (customer_id_sequence.nextval, 'Dobrogost', 'Kowalczyk', 'KOLPORTER', sysdate, 5322822526);
INSERT INTO customer
VALUES (customer_id_sequence.nextval, 'Piotr', 'Piotrowski', '', sysdate, 4969445542);
INSERT INTO customer
VALUES (customer_id_sequence.nextval, 'Serafin', 'Nowakowski', 'OPONEX', sysdate, 4969445549);
INSERT INTO customer
VALUES (customer_id_sequence.nextval, 'Kondrat', 'Zawadzki', '', sysdate, 4969445541);
INSERT INTO customer
VALUES (customer_id_sequence.nextval, 'Amadeusz', 'Olszewski', 'MICROSOFT', sysdate, 9529828645);
INSERT INTO customer
VALUES (customer_id_sequence.nextval, 'Arkadiusz', 'Nowak', 'MICROSOFT', sysdate, 9529828645);
INSERT INTO customer
VALUES (customer_id_sequence.nextval, 'Kazimierz', 'Chmielewski', '', sysdate, 4969445566);
INSERT INTO customer
VALUES (customer_id_sequence.nextval, 'Kazimierz', 'Wieczorek', 'SKARPETEX', sysdate, 5118147893);
INSERT INTO customer
VALUES (customer_id_sequence.nextval, 'Aleksander', 'Zielinski', 'OPONEX', sysdate, 4969445549);
INSERT INTO customer
VALUES (customer_id_sequence.nextval, 'Jarogniew', 'Kowalski', 'OPONEX', sysdate, 4969445549);
INSERT INTO customer
VALUES (customer_id_sequence.nextval, 'Kacper', 'Kaczmarek', '', sysdate, 4169445549);
INSERT INTO customer
VALUES (customer_id_sequence.nextval, 'Zygfryd', 'Rutkowski', 'MICROSOFT', sysdate, 4969425549);

INSERT INTO address_customer
VALUES (address_customer_id_sequence.nextval, 1, 1);
INSERT INTO address_customer
VALUES (address_customer_id_sequence.nextval, 2, 2);
INSERT INTO address_customer
VALUES (address_customer_id_sequence.nextval, 3, 3);
INSERT INTO address_customer
VALUES (address_customer_id_sequence.nextval, 4, 4);
INSERT INTO address_customer
VALUES (address_customer_id_sequence.nextval, 5, 5);
INSERT INTO address_customer
VALUES (address_customer_id_sequence.nextval, 6, 6);
INSERT INTO address_customer
VALUES (address_customer_id_sequence.nextval, 7, 7);
INSERT INTO address_customer
VALUES (address_customer_id_sequence.nextval, 8, 8);
INSERT INTO address_customer
VALUES (address_customer_id_sequence.nextval, 9, 9);
INSERT INTO address_customer
VALUES (address_customer_id_sequence.nextval, 10, 10);
INSERT INTO address_customer
VALUES (address_customer_id_sequence.nextval, 11, 11);
INSERT INTO address_customer
VALUES (address_customer_id_sequence.nextval, 12, 12);
INSERT INTO address_customer
VALUES (address_customer_id_sequence.nextval, 13, 13);
INSERT INTO address_customer
VALUES (address_customer_id_sequence.nextval, 14, 14);
INSERT INTO address_customer
VALUES (address_customer_id_sequence.nextval, 15, 15);

INSERT INTO refund
VALUES (refund_id_sequence.nextval, 1, 27109018255156274502473110, 'ALBPPLPW', 'Wojciech Duda', 30, 'DONE', sysdate);
INSERT INTO refund
VALUES (refund_id_sequence.nextval, 3, 27109018255156274502473110, 'ALBPPLPW', 'Ksawery Kowalski', 120, 'DONE',
        sysdate);
INSERT INTO refund
VALUES (refund_id_sequence.nextval, 7, 27109018255156274502473110, 'PPABPLPK', 'Kondrat Zawadzki', 80, 'IN PROCESS',
        sysdate);
INSERT INTO refund
VALUES (refund_id_sequence.nextval, 4, 27109018255156274502473110, 'PPABPLPK', 'Dobrogost Kowalczyk', 50, 'IN PROCESS',
        sysdate);
INSERT INTO refund
VALUES (refund_id_sequence.nextval, 14, 27109018255156274502473110, 'DEUTPLPK', 'Kacper Kaczmarek', 100, 'IN PROCESS',
        sysdate);
INSERT INTO refund VALUES(refund_id_sequence.nextval,6,PL8249000052062571359447964,'ALBPPLPW','Amadeusz Olszewski',150,'DONE',sysdate);
INSERT INTO refund VALUES(refund_id_sequence.nextval,8,PL39249000052604104333833616,'ALBPPLPW','Kondrat Zawadzki',100,'IN PROCESS',sysdate);
INSERT INTO refund VALUES(refund_id_sequence.nextval,9,PL75249000050435134546884789,'ALBPPLPW','Arkadiusz Nowak',50,'IN PROCESS',sysdate);
INSERT INTO refund VALUES(refund_id_sequence.nextval,10,PL98249000054301586549340394,'ALBPPLPW','Zygfryd Rutkowski',30,'IN PROCESS',sysdate);
INSERT INTO refund VALUES(refund_id_sequence.nextval,11,PL93249000057040897863152569,'ALBPPLPW','Piotr Piotrowski',40,'IN PROCESS',sysdate);
INSERT INTO refund VALUES(refund_id_sequence.nextval,12,PL3249000053930429415082393,'ALBPPLPW','Kazimierz Chmielewski',60,'IN PROCESS',sysdate);
INSERT INTO refund VALUES(refund_id_sequence.nextval,13,PL45249000059253589387218106,'ALBPPLPW','Aleksander Zielinski',250,'IN PROCESS',sysdate);
INSERT INTO refund VALUES(refund_id_sequence.nextval,16,PL45249000055149317741141696,'ALBPPLPW','Kacper Kaczmarek',20,'IN PROCESS',sysdate);
INSERT INTO refund VALUES(refund_id_sequence.nextval,17,PL76249000058486459569737397,'ALBPPLPW','Arkadiusz Nowak',80,'IN PROCESS',sysdate);        

INSERT INTO complaint
VALUES (refund_id_sequence.nextval, 'Kurier jest strasznie wulgarny', 6, 2, sysdate);
INSERT INTO complaint
VALUES (refund_id_sequence.nextval, 'Kurier uzywal obrazliwych slow w moim kierunku', 6, 7, sysdate);
INSERT INTO complaint
VALUES (refund_id_sequence.nextval, 'Zwolnijcie tego prostaka', 6, 5, sysdate);
INSERT INTO complaint
VALUES (refund_id_sequence.nextval, 'Wasz pracownik wstal dzis chyba lewa noga', 6, 10, sysdate);
INSERT INTO complaint
VALUES (refund_id_sequence.nextval, 'Kurier wydal mi nie wystarczajaca ilosc pieniedzy', 2, 5, sysdate);
INSERT INTO complaint
VALUES (refund_id_sequence.nextval, 'Zostalem oszukany na kwote 20zl', 2, 5, sysdate);
INSERT INTO complaint
VALUES (refund_id_sequence.nextval, 'Kurier uszkodzil zawartosc paczki', 6, 10, sysdate);
INSERT INTO complaint
VALUES (refund_id_sequence.nextval, 'wasz pracownik uszkodzil moj samochod', 7, 12, sysdate);
INSERT INTO complaint VALUES(refund_id_sequence.nextval,'Moja paczka zostala uszkodzona',8,12,sysdate);
INSERT INTO complaint VALUES(refund_id_sequence.nextval,'Zostalem obrazony przez waszego pracownika',6,13,sysdate);
INSERT INTO complaint VALUES(refund_id_sequence.nextval,'Kurier uszkodzil moj samochod',8,14,sysdate);
INSERT INTO complaint VALUES(refund_id_sequence.nextval,'Wasz pracownik ukradl mi wycieraczke',9,1,sysdate);
INSERT INTO complaint VALUES(refund_id_sequence.nextval,'Ten typ wybil mi szybe',6,15,sysdate);
INSERT INTO complaint VALUES(refund_id_sequence.nextval,'Wasz pracownik przejechal mi psa',3,7,sysdate);
INSERT INTO complaint VALUES(refund_id_sequence.nextval,'Ten nikczemnik tak szarpal mi klamke ze urwal',10,2,sysdate);


INSERT INTO package
VALUES (package_id_sequence.nextval, 5, 1, 5, sysdate);
INSERT INTO package
VALUES (package_id_sequence.nextval, 7, 2, 7, sysdate);
INSERT INTO package
VALUES (package_id_sequence.nextval, 3, 5, 3, sysdate);
INSERT INTO package
VALUES (package_id_sequence.nextval, 4, 1, 4, sysdate);
INSERT INTO package
VALUES (package_id_sequence.nextval, 11, 2, 11, sysdate);
INSERT INTO package
VALUES (package_id_sequence.nextval, 8, 3, 8, sysdate);
INSERT INTO package
VALUES (package_id_sequence.nextval, 13, 7, 13, sysdate);
INSERT INTO package
VALUES (package_id_sequence.nextval, 7, 10, 7, sysdate);
INSERT INTO package
VALUES (package_id_sequence.nextval, 9, 12, 9, sysdate);
INSERT INTO package
VALUES (package_id_sequence.nextval, 15, 1, 15, sysdate);
INSERT INTO package
VALUES (package_id_sequence.nextval, 5, 4, 5, sysdate);
INSERT INTO package
VALUES (package_id_sequence.nextval, 10, 4, 10, sysdate);
INSERT INTO package
VALUES (package_id_sequence.nextval, 12, 10, 12, sysdate);
INSERT INTO package
VALUES (package_id_sequence.nextval, 14, 4, 14, sysdate);
INSERT INTO package VALUES(package_id_sequence.nextval,14,1,14,sysdate);
INSERT INTO package VALUES(package_id_sequence.nextval,9,15,9,sysdate);
INSERT INTO package VALUES(package_id_sequence.nextval,7,2,7,sysdate);
INSERT INTO package VALUES(package_id_sequence.nextval,13,4,13,sysdate);
INSERT INTO package VALUES(package_id_sequence.nextval,1,4,1,sysdate);

INSERT INTO route_element
VALUES (package_id_sequence.nextval, 1, 1, 1, 15, 2, sysdate);
INSERT INTO route_element
VALUES (package_id_sequence.nextval, 2, 2, 2, 1, 3, sysdate);
INSERT INTO route_element
VALUES (package_id_sequence.nextval, 3, 3, 3, 2, 4, sysdate);
INSERT INTO route_element
VALUES (package_id_sequence.nextval, 4, 4, 4, 3, 5, sysdate);
INSERT INTO route_element
VALUES (package_id_sequence.nextval, 5, 5, 5, 4, 6, sysdate);
INSERT INTO route_element
VALUES (package_id_sequence.nextval, 6, 6, 6, 5, 7, sysdate);
INSERT INTO route_element
VALUES (package_id_sequence.nextval, 7, 7, 7, 6, 8, sysdate);
INSERT INTO route_element
VALUES (package_id_sequence.nextval, 8, 8, 8, 7, 9, sysdate);
INSERT INTO route_element
VALUES (package_id_sequence.nextval, 9, 9, 9, 8, 10, sysdate);
INSERT INTO route_element
VALUES (package_id_sequence.nextval, 10, 10, 10, 9, 11, sysdate);
INSERT INTO route_element
VALUES (package_id_sequence.nextval, 11, 11, 11, 10, 12, sysdate);
INSERT INTO route_element
VALUES (package_id_sequence.nextval, 12, 12, 12, 11, 13, sysdate);
INSERT INTO route_element
VALUES (package_id_sequence.nextval, 13, 13, 13, 12, 14, sysdate);
INSERT INTO route_element
VALUES (package_id_sequence.nextval, 14, 14, 14, 13, 15, sysdate);
INSERT INTO route_element
VALUES (package_id_sequence.nextval, 15, 15, 15, 14, 1, sysdate);

