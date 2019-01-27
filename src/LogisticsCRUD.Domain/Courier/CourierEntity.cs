using PSK.Databases.LogisticsCRUD.Domain.Common;

namespace PSK.Databases.LogisticsCRUD.Domain.Courier
{
    public class CourierEntity : BusinessEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
    }
}