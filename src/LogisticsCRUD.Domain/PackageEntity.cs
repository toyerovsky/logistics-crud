using System;

namespace LogisticsCRUD.Domain
{
    public class PackageEntity : BusinessEntity
    {
        public int RecipientId { get; set; }
        public int SenderId { get; set; }
        public int DeliveryAddressId { get; set; }
    }
}