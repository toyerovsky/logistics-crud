CREATE OR REPLACE TRIGGER restricted_insert
BEFORE INSERT ON courier
BEGIN
IF (TO_CHAR(SYSDATE, 'HH24:MI') NOT BETWEEN '09:00' AND '18:00') THEN
        RAISE_APPLICATION_ERROR(-20123, 'Mozesz dodawac kolejnych pracownikow tylko od 9:00 do 18:00.');
        END IF;
END
;
/
 
CREATE OR REPLACE TRIGGER restricted_update
BEFORE UPDATE ON courier
BEGIN
IF (TO_CHAR(SYSDATE, 'HH24:MI') NOT BETWEEN '09:00' AND '18:00') THEN
        RAISE_APPLICATION_ERROR(-20123, 'Mozesz edytowac pracownikow tylko od 9:00 do 18:00.');
        END IF;
END
;
/
 
CREATE OR REPLACE TRIGGER restricted_delete
BEFORE DELETE ON courier
BEGIN
IF (TO_CHAR(SYSDATE, 'HH24:MI') NOT BETWEEN '09:00' AND '18:00') THEN
        RAISE_APPLICATION_ERROR(-20123, 'Mozesz usuwac kolejnych pracownikow tylko od 9:00 do 18:00.');
        END IF;
END;
