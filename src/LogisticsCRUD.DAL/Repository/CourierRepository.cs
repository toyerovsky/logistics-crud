using System.Data;
using PSK.Databases.LogisticsCRUD.Domain.Common;
using PSK.Databases.LogisticsCRUD.Domain.Courier;

namespace PSK.Databases.LogisticsCRUD.Infrastructure.Repository
{
    public class CourierRepository : DapperBusinessRepository<CourierEntity>, ICourierRepository
    {
        public CourierRepository(IDbConnection connection, ISqlFactory sqlFactory) : base(connection, sqlFactory)
        {
        }
    }
}