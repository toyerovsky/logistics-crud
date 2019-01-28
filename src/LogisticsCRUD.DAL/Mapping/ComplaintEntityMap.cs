using PSK.Databases.LogisticsCRUD.Domain;
using PSK.Databases.LogisticsCRUD.Domain.Complaint;

namespace PSK.Databases.LogisticsCRUD.Infrastructure.Mapping
{
    public class ComplaintEntityMap : BusinessEntityMap<ComplaintEntity>
    {
        public ComplaintEntityMap()
        {
            Map(x => x.Description).ToColumn("DESCRIPTION");
            Map(x => x.CourierId).ToColumn("COURIER_ID");
            Map(x => x.CustomerId).ToColumn("CUSTOMER_ID");
        }
    }
}