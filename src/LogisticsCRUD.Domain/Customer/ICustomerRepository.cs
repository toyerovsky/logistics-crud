using PSK.Databases.LogisticsCRUD.Domain.Common;

namespace PSK.Databases.LogisticsCRUD.Domain.Customer
{
    public interface ICustomerRepository : IDapperBusinessRepository<CustomerEntity, int>
    {
        
    }
}