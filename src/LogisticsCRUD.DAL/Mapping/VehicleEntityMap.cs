using PSK.Databases.LogisticsCRUD.Domain.Vehicle;

namespace PSK.Databases.LogisticsCRUD.Infrastructure.Mapping
{
    public class VehicleEntityMap : BusinessEntityMap<VehicleEntity>
    {
        public VehicleEntityMap()
        {
            Map(x => x.ProductionYear).ToColumn("PRODUCTION_YEAR");
        }
    }
}
