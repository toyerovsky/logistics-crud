using System.Collections.Generic;
using LogisticsCRUD.Domain;

namespace LogisticsCRUD.DAL
{
    public interface IBusinessRepository<TEntity, TKey> where TEntity : BusinessEntity
    {
        TEntity Get(TKey id);
        IEnumerable<TEntity> GetAll();
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}