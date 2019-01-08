using Dapper;
using LogisticsCRUD.DAL.Factory;
using LogisticsCRUD.Domain;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;

namespace LogisticsCRUD.DAL.Repository
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
            var entities = Connection.Query<T>(SqlFactory.GetSqlForGetAll());
            return entities;
        }

        public virtual void Insert(T entity)
        {
            var dynamicObject = new ExpandoObject() as IDictionary<string, object>;
            foreach (var property in typeof(T).GetProperties())
            {
                dynamicObject.Add(property.Name, property.GetValue(entity));
            }
            var command = new CommandDefinition(SqlFactory.GetSqlForInsert(), dynamicObject);
            Connection.Execute(command);
        }

        public virtual void Update(T entity)
        {
            var dynamicObject = new ExpandoObject() as IDictionary<string, object>;
            foreach (var property in typeof(T).GetProperties())
            {
                if (property.Name != nameof(entity.Id))
                {
                    dynamicObject.Add(property.Name, property.GetValue(entity));
                }
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