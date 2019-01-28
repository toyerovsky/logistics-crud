using PSK.Databases.LogisticsCRUD.Domain.Package;

namespace PSK.Databases.LogisticsCRUD.Infrastructure.Mapping
{
    public class PackageEntityMap : BusinessEntityMap<PackageEntity>
    {
        public PackageEntityMap()
        {
            Map(x => x.DeliveryAddressId).ToColumn("DELIVERY_ADDRESS_ID");
            Map(x => x.RecipientId).ToColumn("RECIPIENT_ID");
            Map(x => x.SenderId).ToColumn("SENDER_ID");
        }
    }
}