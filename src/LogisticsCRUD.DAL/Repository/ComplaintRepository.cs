using System.Data;
using PSK.Databases.LogisticsCRUD.Domain.Common;
using PSK.Databases.LogisticsCRUD.Domain.Complaint;

namespace PSK.Databases.LogisticsCRUD.Infrastructure.Repository
{
    public class ComplaintRepository : DapperBusinessRepository<ComplaintEntity>, IComplaintRepository
    {
        public ComplaintRepository(IDbConnection connection, ISqlFactory sqlFactory) : base(connection, sqlFactory)
        {
        }
    }
}