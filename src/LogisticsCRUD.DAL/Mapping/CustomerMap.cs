using PSK.Databases.LogisticsCRUD.Domain.Customer;

namespace PSK.Databases.LogisticsCRUD.Infrastructure.Mapping
{
    public class CustomerMap : BusinessEntityMap<CustomerEntity>
    {
        public CustomerMap()
        {
            Map(x => x.TaxNumber).ToColumn("TAX_NUMBER");
        }
    }
}