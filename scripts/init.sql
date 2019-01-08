CREATE SEQUENCE package_id_sequence START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE customer_id_sequence START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE address_id_sequence START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE courier_id_sequence START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE vehicle_id_sequence START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE address_customer_id_sequence START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE refund_id_sequence START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE route_element_id_sequence START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE complaint_id_sequence START WITH 1 INCREMENT BY 1;

CREATE TABLE country
(
  id   NUMBER,
  code VARCHAR2(2)
);

INSERT INTO country (id, code)
VALUES (1, 'BE');
INSERT INTO country (id, code)
VALUES (2, 'GR');
INSERT INTO country (id, code)
VALUES (3, 'MT');
INSERT INTO country (id, code)
VALUES (4, 'SK');
INSERT INTO country (id, code)
VALUES (5, 'BG');
INSERT INTO country (id, code)
VALUES (6, 'IE');
INSERT INTO country (id, code)
VALUES (7, 'NL');
INSERT INTO country (id, code)
VALUES (8, 'SI');
INSERT INTO country (id, code)
VALUES (9, 'DK');
INSERT INTO country (id, code)
VALUES (10, 'IT');
INSERT INTO country (id, code)
VALUES (11, 'AT');
INSERT INTO country (id, code)
VALUES (12, 'ES');
INSERT INTO country (id, code)
VALUES (13, 'DE');
INSERT INTO country (id, code)
VALUES (14, 'HR');
INSERT INTO country (id, code)
VALUES (15, 'PL');
INSERT INTO country (id, code)
VALUES (16, 'CZ');
INSERT INTO country (id, code)
VALUES (17, 'EE');
INSERT INTO country (id, code)
VALUES (18, 'LV');
INSERT INTO country (id, code)
VALUES (19, 'PT');
INSERT INTO country (id, code)
VALUES (20, 'HU');
INSERT INTO country (id, code)
VALUES (21, 'FI');
INSERT INTO country (id, code)
VALUES (22, 'LT');
INSERT INTO country (id, code)
VALUES (23, 'RO');
INSERT INTO country (id, code)
VALUES (24, 'GB');
INSERT INTO country (id, code)
VALUES (25, 'FR');
INSERT INTO country (id, code)
VALUES (26, 'LU');
INSERT INTO country (id, code)
VALUES (27, 'SE');
INSERT INTO country (id, code)
VALUES (28, 'CY');
INSERT INTO country (id, code)
VALUES (29, 'IS');
INSERT INTO country (id, code)
VALUES (30, 'LI');
INSERT INTO country (id, code)
VALUES (31, 'MC');
INSERT INTO country (id, code)
VALUES (32, 'NO');
INSERT INTO country (id, code)
VALUES (33, 'SM');
INSERT INTO country (id, code)
VALUES (34, 'CH');

CREATE TABLE courier
(
  id            NUMBER DEFAULT courier_id_sequence.nextval PRIMARY KEY,
  name          VARCHAR2(40) NOT NULL,
  surname       VARCHAR2(50) NOT NULL,
  creation_date DATE   DEFAULT (sysdate),
  age           NUMBER CHECK (age < 120 AND age > 1)
);

CREATE TABLE vehicle
(
  id              NUMBER DEFAULT vehicle_id_sequence.nextval PRIMARY KEY,
  numberplate     VARCHAR2(10),
  brand           VARCHAR2(40),
  production_year NUMBER,
  vin             VARCHAR2(15),
  creation_date   DATE   DEFAULT (sysdate)
);

CREATE TABLE address
(
  id            NUMBER DEFAULT address_id_sequence.nextval PRIMARY KEY,
  street        VARCHAR2(50),
  street_number NUMBER,
  postal_code   VARCHAR2(8),
  city          VARCHAR2(40),
  country_id REFERENCES country (id),
  creation_date DATE   DEFAULT (sysdate)
);

CREATE TABLE address_customer
(
  id          NUMBER DEFAULT address_customer_id_sequence.nextval PRIMARY KEY,
  customer_id NUMBER NOT NULL REFERENCES customer (id),
  address_id  NUMBER NOT NULL REFERENCES address (id)
);

CREATE TABLE customer
(
  id            NUMBER DEFAULT customer_id_sequence.nextval PRIMARY KEY,
  name          VARCHAR2(40),
  surname       VARCHAR2(50),
  company       VARCHAR2(40),
  creation_date DATE   DEFAULT (sysdate),
  tax_number    VARCHAR2(40)
);

CREATE TABLE package
(
  id                  NUMBER DEFAULT package_id_sequence.nextval PRIMARY KEY,
  recipient_id        NUMBER NOT NULL REFERENCES customer (id),
  sender_id           NUMBER NOT NULL REFERENCES customer (id),
  delivery_address_id NUMBER NOT NULL REFERENCES address (id),
  creation_date       DATE   DEFAULT (sysdate)
);

CREATE TABLE route_element
(
  id                 NUMBER DEFAULT package_id_sequence.nextval PRIMARY KEY,
  vehicle_id         NUMBER references vehicle (id),
  package_id         NUMBER references package (id),
  courier_id         NUMBER references courier (id),
  prev_route_element NUMBER references route_element (id),
  next_route_element NUMBER references route_element (id),
  creation_date      DATE   DEFAULT (sysdate)
);

CREATE TABLE refund
(
  id                 NUMBER DEFAULT refund_id_sequence.nextval PRIMARY KEY,
  package_id         NUMBER NOT NULL REFERENCES customer (id),
  iban               VARCHAR2(50),
  swift_code         VARCHAR2(10),
  bank_account_owner VARCHAR2(100),
  amount_of_money    NUMERIC,
  status             VARCHAR2(20),
  creation_date      DATE   DEFAULT (sysdate)
);

CREATE TABLE complaint
(
  id            NUMBER DEFAULT refund_id_sequence.nextval PRIMARY KEY,
  description   VARCHAR2(250),
  courier_id    NUMBER REFERENCES courier (id),
  customer_id   NUMBER REFERENCES customer (id),
  creation_date DATE   DEFAULT (sysdate)
);