using System;
using LogisticsCRUD.Domain;
using System.Data;
using LogisticsCRUD.DAL.Factory;

namespace LogisticsCRUD.DAL
{
    public interface IDapperBusinessRepository<TEntity, TKey> : IBusinessRepository<TEntity, TKey>, IDisposable where TEntity : BusinessEntity
    {
        IDbConnection Connection { get; }
        ISqlFactory SqlFactory { get; }
    }
}