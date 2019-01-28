using PSK.Databases.LogisticsCRUD.Domain.Common;

namespace PSK.Databases.LogisticsCRUD.Domain.Vehicle
{
    public class VehicleEntity : BusinessEntity
    {
        public string Numberplate { get; set; }
        public string Brand { get; set; }
        public int ProductionYear { get; set; }
        public string Vin { get; set; }
    }
}