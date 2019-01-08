using System.Data;
using LogisticsCRUD.DAL.Factory;
using LogisticsCRUD.Domain;

namespace LogisticsCRUD.DAL.Repository
{
    public class CustomerRepository : DapperBusinessRepository<CustomerEntity>, ICustomerRepository
    {
        public CustomerRepository(IDbConnection connection, ISqlFactory sqlFactory) : base(connection, sqlFactory)
        {
        }
    }
}