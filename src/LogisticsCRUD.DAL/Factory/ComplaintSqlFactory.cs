using PSK.Databases.LogisticsCRUD.Domain.Complaint;

namespace PSK.Databases.LogisticsCRUD.Infrastructure.Factory
{
    public class ComplaintSqlFactory : IComplaintSqlFactory
    {
        public string GetSqlForGet()
        {
            return "SELECT * FROM COMPLAINT WHERE id = :id";
        }

        public string GetSqlForGetAll()
        {
            return "SELECT * FROM COMPLAINT";
        }

        public string GetSqlForInsert()
        {
            return "INSERT INTO COMPLAINT (ID, DESCRIPTION, COURIER_ID, CUSTOMER_ID, CREATION_DATE) VALUES (customer_id_sequence.nextval, :description, :courierid, :customerid, sysdate)";
        }

        public string GetSqlForUpdate()
        {
            return "UPDATE COMPLAINT SET DESCRIPTION = :description, COURIER_ID = :courierid, CUSTOMER_ID = :customerid, where id = :id";
        }

        public string GetSqlForDelete()
        {
            return "DELETE FROM COMPLAINT WHERE id = :id";
        }
    }
}