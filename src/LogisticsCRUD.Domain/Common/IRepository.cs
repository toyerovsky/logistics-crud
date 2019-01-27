using System.Collections.Generic;
using System.Data;

namespace PSK.Databases.LogisticsCRUD.Domain.Common
{
    public interface IRepository<TEntity, TKey> where TEntity : Entity
    {
        TEntity Get(TKey id);
        IEnumerable<TEntity> GetAll();
        void Insert(TEntity entity, IDbTransaction transaction = null);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}