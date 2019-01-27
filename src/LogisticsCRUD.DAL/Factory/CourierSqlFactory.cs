using PSK.Databases.LogisticsCRUD.Domain.Courier;

namespace PSK.Databases.LogisticsCRUD.Infrastructure.Factory
{
    public class CourierSqlFactory : ICourierSqlFactory
    {
        public string GetSqlForGet()
        {
            return "SELECT * FROM COURIER WHERE id = :id";
        }

        public string GetSqlForGetAll()
        {
            return "SELECT * FROM COURIER";
        }

        public string GetSqlForInsert()
        {
            return "INSERT INTO COURIER (ID, NAME, SURNAME, AGE, CREATION_DATE) VALUES (customer_id_sequence.nextval, :name, :surname, :age, sysdate)";
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