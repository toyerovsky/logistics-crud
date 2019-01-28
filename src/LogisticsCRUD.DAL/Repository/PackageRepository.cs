using System.Data;
using PSK.Databases.LogisticsCRUD.Domain;
using PSK.Databases.LogisticsCRUD.Domain.Common;
using PSK.Databases.LogisticsCRUD.Domain.Package;

namespace PSK.Databases.LogisticsCRUD.Infrastructure.Repository
{
    public class PackageRepository : DapperBusinessRepository<PackageEntity>, IPackageRepository
    {
        public PackageRepository(IDbConnection connection, ISqlFactory sqlFactory) : base(connection, sqlFactory)
        {
        }
    }
}