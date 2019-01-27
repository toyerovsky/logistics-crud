using Autofac;
using Dapper;
using Oracle.ManagedDataAccess.Client;
using PSK.Databases.LogisticsCRUD.Domain.Customer;
using PSK.Databases.LogisticsCRUD.Forms;
using PSK.Databases.LogisticsCRUD.Infrastructure.Factory;
using PSK.Databases.LogisticsCRUD.Infrastructure.Repository;
using System.Configuration;
using System.Data;
using PSK.Databases.LogisticsCRUD.Domain;
using PSK.Databases.LogisticsCRUD.Domain.Courier;

namespace PSK.Databases.LogisticsCRUD.Startup
{
    public class AutofacStartupProcedure : IStartupProcedure
    {
        public void Run()
        {
            var customerSqlFactory = new CustomerSqlFactory();
            var courierSqlFactory = new CourierSqlFactory();
            var packageSqlFactory = new PackageSqlFactory();

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
            containerBuilder.RegisterType<CourierRepository>().As<ICourierRepository>()
                .InstancePerDependency().WithParameter("sqlFactory", courierSqlFactory);
            containerBuilder.RegisterType<PackageRepository>().As<IPackageRepository>()
                .InstancePerDependency().WithParameter("sqlFactory", packageSqlFactory);

            containerBuilder.RegisterType<MainForm>().AsSelf();
            containerBuilder.RegisterType<CustomerListForm>().AsSelf();
            containerBuilder.RegisterType<CourierListForm>().AsSelf();
            containerBuilder.RegisterType<PackageListForm>().AsSelf();

            Program.Container = containerBuilder.Build();
        }
    }
}