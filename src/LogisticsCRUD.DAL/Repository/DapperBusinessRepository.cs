using Dapper;
using PSK.Databases.LogisticsCRUD.Domain.Common;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;

namespace PSK.Databases.LogisticsCRUD.Infrastructure.Repository
{
    public class DapperBusinessRepository<T> : IDapperBusinessRepository<T, int> where T : BusinessEntity
    {
        public IDbConnection Connection { get; }
        public ISqlFactory SqlFactory { get; }

        public DapperBusinessRepository(IDbConnection connection, ISqlFactory sqlFactory)
        {
            Connection = connection;
            SqlFactory = sqlFactory;
        }

        public virtual T Get(int id)
        {
            var entity = Connection.QuerySingle<T>(SqlFactory.GetSqlForGet(), new { id });
            return entity;
        }

        public virtual IEnumerable<T> GetAll()
        {
            var query = SqlFactory.GetSqlForGetAll();
            var entities = Connection.Query<T>(query);
            return entities;
        }

        public virtual void Insert(T entity, IDbTransaction transaction = null)
        {
            var dynamicObject = new ExpandoObject() as IDictionary<string, object>;
            foreach (var property in typeof(T).GetProperties())
            {
                dynamicObject.Add(property.Name.ToLower(), property.GetValue(entity));
            }
            var command = new CommandDefinition(SqlFactory.GetSqlForInsert(), dynamicObject, transaction);
            Connection.Execute(command);
        }

        public virtual void Update(T entity)
        {
            var dynamicObject = new ExpandoObject() as IDictionary<string, object>;
            foreach (var property in typeof(T).GetProperties())
            {
                dynamicObject.Add(property.Name, property.GetValue(entity));
            }
            var command = new CommandDefinition(SqlFactory.GetSqlForUpdate(), dynamicObject);
            Connection.Execute(command);
        }

        public virtual void Delete(T entity)
        {
            var command = new CommandDefinition(SqlFactory.GetSqlForDelete(), new { entity.Id });
            Connection.Execute(command);
        }

        public virtual void Dispose()
        {
            Connection?.Dispose();
        }
    }
}