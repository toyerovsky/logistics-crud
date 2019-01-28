using PSK.Databases.LogisticsCRUD.Domain.Common;

namespace PSK.Databases.LogisticsCRUD.Domain.Package
{
    public class PackageEntity : BusinessEntity
    {
        public int RecipientId { get; set; }
        public int SenderId { get; set; }
        public int DeliveryAddressId { get; set; }
    }
}