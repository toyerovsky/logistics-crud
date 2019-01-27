CREATE OR REPLACE FUNCTION SumOfRefundsOfLastYear
RETURN NUMBER
IS
sumOfRefunds NUMBER;
  CURSOR CoursorSum_C IS
    SELECT amount_of_money FROM refund WHERE EXTRACT(YEAR FROM creation_date) = (EXTRACT(YEAR FROM SYSDATE)-1);
    v_a refund.amount_of_money%TYPE;
BEGIN
  sumOfRefunds := 0;
  OPEN CoursorSum_C;
  LOOP
    FETCH CoursorSum_C INTO v_a;
    EXIT WHEN CoursorSum_C%notfound;
    sumOfRefunds := sumOfRefunds + v_a;
  END LOOP;
  CLOSE CoursorSum_C;
  RETURN sumOfRefunds;
END;
/
 
 
CREATE OR REPLACE FUNCTION CountCouriers
RETURN NUMBER
IS
counter NUMBER;
CURSOR Couriers_c IS
    SELECT ID FROM courier;
    v_a courier.ID%TYPE;
BEGIN
  counter := 0;
  OPEN Couriers_c;
  LOOP
    FETCH Couriers_c INTO v_a;
    EXIT WHEN Couriers_c%notfound;
    counter := counter + 1;
  END LOOP;
  CLOSE Couriers_c;
  RETURN counter;
END;
/
 
 
 
 
CREATE OR REPLACE PROCEDURE ReduceCosts AS
  CURSOR RichRefund_c IS
    SELECT amount_of_money FROM refund WHERE amount_of_money >= 10 FOR UPDATE;
    v_a refund.amount_of_money%TYPE;
BEGIN
  OPEN RichRefund_c;
  LOOP
    FETCH RichRefund_c INTO v_a;
    EXIT WHEN RichRefund_c%notfound;
    UPDATE refund SET amount_of_money=(v_a*0.9) WHERE CURRENT OF RichRefund_c;
  END LOOP;
 
  CLOSE RichRefund_c;
END;
/