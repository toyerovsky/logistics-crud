namespace LogisticsCRUD.DAL.Factory
{
    public class CustomerSqlFactory : ICustomerSqlFactory
    {
        public string GetSqlForGet()
        {
            return "Select * FROM customer WHERE id = @id";
        }

        public string GetSqlForGetAll()
        {
            return string.Empty;
        }

        public string GetSqlForInsert()
        {
            return string.Empty;
        }

        public string GetSqlForUpdate()
        {
            return string.Empty;
        }

        public string GetSqlForDelete()
        {
            return string.Empty;
        }
    }
}