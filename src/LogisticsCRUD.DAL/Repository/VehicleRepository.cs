using System.Data;
using PSK.Databases.LogisticsCRUD.Domain.Common;
using PSK.Databases.LogisticsCRUD.Domain.Vehicle;

namespace PSK.Databases.LogisticsCRUD.Infrastructure.Repository
{
    public class VehicleRepository : DapperBusinessRepository<VehicleEntity>, IVehicleRepository
    {
        public VehicleRepository(IDbConnection connection, ISqlFactory sqlFactory) : base(connection, sqlFactory)
        {
        }
    }
}