using Autofac;
using System.Configuration;
using System.Data;
using Dapper;
using Oracle.ManagedDataAccess.Client;
using PSK.Databases.LogisticsCRUD.Domain.Customer;
using PSK.Databases.LogisticsCRUD.Forms;
using PSK.Databases.LogisticsCRUD.Infrastructure.Factory;
using PSK.Databases.LogisticsCRUD.Infrastructure.Repository;

namespace PSK.Databases.LogisticsCRUD.Startup
{
    public class AutofacStartupProcedure : IStartupProcedure
    {
        public void Run()
        {
            var customerSqlFactory = new CustomerSqlFactory();

            var containerBuilder = new ContainerBuilder();
            var connectionString = ConfigurationManager.ConnectionStrings["Oracle"].ConnectionString;
            containerBuilder.RegisterInstance(customerSqlFactory).As<ICustomerSqlFactory>().SingleInstance();
            containerBuilder.Register(ctx =>
            {
                var connection = new OracleConnection(connectionString);
                connection.Open();
                connection.Execute("ALTER SESSION SET CURRENT_SCHEMA = SYSTEM");
                return connection;
            }).As<IDbConnection>().InstancePerDependency();

            containerBuilder.RegisterType<CustomerRepository>().As<ICustomerRepository>()
                .InstancePerDependency().WithParameter("sqlFactory", customerSqlFactory);

            containerBuilder.RegisterType<MainForm>().AsSelf();
            containerBuilder.RegisterType<CustomerListForm>().AsSelf();

            Program.Container = containerBuilder.Build();
        }
    }
}