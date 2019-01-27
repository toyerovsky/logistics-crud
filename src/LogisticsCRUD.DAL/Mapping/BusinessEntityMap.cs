using Dapper.FluentMap.Mapping;
using PSK.Databases.LogisticsCRUD.Domain.Common;

namespace PSK.Databases.LogisticsCRUD.Infrastructure.Mapping
{
    public class BusinessEntityMap<T> : EntityMap<T> where T : BusinessEntity
    {
        public BusinessEntityMap()
        {
            Map(x => x.CreationDate).ToColumn("CREATION_DATE");
        }
    }
}