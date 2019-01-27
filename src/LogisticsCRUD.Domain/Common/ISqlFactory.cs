namespace PSK.Databases.LogisticsCRUD.Domain.Common
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