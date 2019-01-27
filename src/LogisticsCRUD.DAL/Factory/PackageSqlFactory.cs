using PSK.Databases.LogisticsCRUD.Domain;

namespace PSK.Databases.LogisticsCRUD.Infrastructure.Factory
{
    public class PackageSqlFactory : IPackageSqlFactory
    {
        public string GetSqlForGet()
        {
            return "SELECT * FROM PACKAGE WHERE id = :id";
        }

        public string GetSqlForGetAll()
        {
            return "SELECT * FROM PACKAGE";
        }

        public string GetSqlForInsert()
        {
            return "INSERT INTO PACKAGE (ID, RECIPIENT_ID, SENDER_ID, DELIVERY_ADDRESS_ID, CREATION_DATE) VALUES (customer_id_sequence.nextval, :recipientid, :senderid, :deliveryaddressid, sysdate, :taxnumber)";
        }

        public string GetSqlForUpdate()
        {
            return "UPDATE PACKAGE SET NAME = :name, SURNAME = :surname, COMPANY = :company, TAX_NUMBER = :taxnumber where id = :id";
        }

        public string GetSqlForDelete()
        {
            return "DELETE FROM PACKAGE WHERE id = :id";
        }
    }
}