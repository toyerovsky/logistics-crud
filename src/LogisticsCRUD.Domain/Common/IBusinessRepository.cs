namespace PSK.Databases.LogisticsCRUD.Domain.Common
{
    public interface IBusinessRepository<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity : BusinessEntity
    {
        
    }
}