CREATE OR REPLACE VIEW NadawcyPaczek_Daty AS
SELECT package.CREATION_DATE as "Data nadania", sender.NAME as "Imie", sender.SURNAME as "Nazwisko", sender.COMPANY as "Firma" FROM package
LEFT JOIN customer sender ON sender.ID = package.SENDER_ID
ORDER BY package.CREATION_DATE DESC
 
 
CREATE OR REPLACE VIEW Adresy_Klientow AS
SELECT customer.NAME as "Imie", customer.SURNAME as "Nazwisko", address.STREET as "Ulica", address.STREET_NUMBER as "Numer"
FROM address_customer
LEFT JOIN customer ON customer.ID = address_customer.CUSTOMER_ID
LEFT JOIN address ON address.ID = address_customer.ADDRESS_ID
 
 
CREATE OR REPLACE VIEW Reklamacje_Kurierzy AS
SELECT courier.name as "Imie", courier.surname as "Nazwisko", complaint.CREATION_DATE as "Data reklamacji", complaint.DESCRIPTION as "Opis reklamacji"
FROM complaint
LEFT JOIN courier ON courier.ID = complaint.COURIER_ID
 
 
CREATE OR REPLACE VIEW Zwroty_BiezacyMiesiac AS
SELECT iban as "IBAN", amount_of_money as "Kwota" FROM refund
WHERE EXTRACT(month FROM CREATION_DATE) = EXTRACT(month FROM sysdate)
 
 
CREATE OR REPLACE VIEW Auta_Ponad15Lat AS
SELECT numberplate as "Nr rej", vin as "Nr VIN" FROM vehicle
WHERE (PRODUCTION_YEAR+15) <= EXTRACT(year FROM sysdate)
 
 
CREATE OR REPLACE VIEW NajczesciKlienciPoprzedniegoRoku AS
SELECT NAME as "Imie", SURNAME as "Nazwisko", COMPANY as "Firma", TAX_NUMBER as "NIP", "Ilosc" FROM (
SELECT customer.ID, customer.Name, customer.Surname, customer.Company, customer.tax_number, package.CREATION_DATE, COUNT(*) as "Ilosc"
FROM package
LEFT JOIN customer ON customer.ID = package.sender_id
WHERE EXTRACT(year FROM package.creation_date) = EXTRACT(year FROM sysdate)-1
GROUP BY customer.ID, customer.Name, customer.Surname, customer.Company, customer.tax_number, package.CREATION_DATE)
ORDER BY "Ilosc" DESC