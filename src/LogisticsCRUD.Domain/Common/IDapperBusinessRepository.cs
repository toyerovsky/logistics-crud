using System;
using System.Data;

namespace PSK.Databases.LogisticsCRUD.Domain.Common
{
    public interface IDapperBusinessRepository<TEntity, TKey> : IBusinessRepository<TEntity, TKey>, IDisposable where TEntity : BusinessEntity
    {
        IDbConnection Connection { get; }
        ISqlFactory SqlFactory { get; }
    }
}