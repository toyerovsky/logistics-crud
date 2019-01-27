using PSK.Databases.LogisticsCRUD.Domain.Customer;

namespace PSK.Databases.LogisticsCRUD.Infrastructure.Factory
{
    public class CustomerSqlFactory : ICustomerSqlFactory
    {
        public string GetSqlForGet()
        {
            return "SELECT * FROM CUSTOMER WHERE id = :id";
        }

        public string GetSqlForGetAll()
        {
            return "SELECT * FROM CUSTOMER";
        }

        public string GetSqlForInsert()
        {
            return "INSERT INTO CUSTOMER (ID, NAME, SURNAME, COMPANY, CREATION_DATE, TAX_NUMBER) VALUES(customer_id_sequence.nextval, :name, :surname, :company, sysdate, :taxnumber)";
        }

        public string GetSqlForUpdate()
        {
            return "UPDATE CUSTOMER SET NAME = :name, SURNAME = :surname, COMPANY = :company, TAX_NUMBER = :taxnumber where id = :id";
        }

        public string GetSqlForDelete()
        {
            return "DELETE FROM CUSTOMER WHERE id = :id";
        }
    }
}