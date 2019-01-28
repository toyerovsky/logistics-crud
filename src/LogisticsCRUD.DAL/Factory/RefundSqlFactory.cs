using PSK.Databases.LogisticsCRUD.Domain.Refund;

namespace PSK.Databases.LogisticsCRUD.Infrastructure.Factory
{
    public class RefundSqlFactory : IRefundSqlFactory
{
    public string GetSqlForGet()
    {
        return "SELECT * FROM REFUND WHERE id = :id";
    }

    public string GetSqlForGetAll()
    {
        return "SELECT * FROM REFUND";
    }

    public string GetSqlForInsert()
    {
        return "INSERT INTO REFUND (ID, NAME, SURNAME, AGE, CREATION_DATE) VALUES (customer_id_sequence.nextval, :name, :surname, :age, sysdate)";
    }

    public string GetSqlForUpdate()
    {
        return "UPDATE COURIER SET NAME = :name, SURNAME = :surname, AGE = :age, where id = :id";
    }

    public string GetSqlForDelete()
    {
        return "DELETE FROM COURIER WHERE id = :id";
    }
    }
}