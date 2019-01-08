using LogisticsCRUD.Domain;

namespace LogisticsCRUD.DAL.Factory
{
    public interface ISqlFactory
    {
        string GetSqlForGet();
        string GetSqlForGetAll();
        string GetSqlForInsert();
        string GetSqlForUpdate();
        string GetSqlForDelete();
    }
}