using PSK.Databases.LogisticsCRUD.Domain.Common;

namespace PSK.Databases.LogisticsCRUD.Domain
{
    public class ComplaintEntity : BusinessEntity
    {
        public string Description { get; set; }
        public int? CourierId { get; set; }
        public int CustomerId { get; set; }
    }
}