using PSK.Databases.LogisticsCRUD.Domain.Common;

namespace PSK.Databases.LogisticsCRUD.Domain
{
    public class AddressEntity_CustomerEntity : Entity
    {
        public int CustomerId { get; set; }
        public int AddressId { get; set; }
    }
}