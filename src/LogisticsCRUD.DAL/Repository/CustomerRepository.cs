using System.Data;
using PSK.Databases.LogisticsCRUD.Domain.Common;
using PSK.Databases.LogisticsCRUD.Domain.Customer;

namespace PSK.Databases.LogisticsCRUD.Infrastructure.Repository
{
    public class CustomerRepository : DapperBusinessRepository<CustomerEntity>, ICustomerRepository
    {
        public CustomerRepository(IDbConnection connection, ISqlFactory sqlFactory) : base(connection, sqlFactory)
        {
        }
    }
}