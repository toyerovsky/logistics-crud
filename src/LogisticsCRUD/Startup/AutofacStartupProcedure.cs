using Autofac;
using LogisticsCRUD.DAL.Factory;
using LogisticsCRUD.DAL.Repository;
using LogisticsCRUD.Domain;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace PSK.Databases.LogisticsCRUD.Startup
{
    public class AutofacStartupProcedure : IStartupProcedure
    {
        public void Run()
        {
            var customerSqlFactory = new CustomerSqlFactory();

            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterInstance(customerSqlFactory).As<ICustomerSqlFactory>().SingleInstance();
            containerBuilder.RegisterType<OracleConnection>().As<IDbConnection>().InstancePerDependency();

            containerBuilder.RegisterType<CustomerRepository>().As<ICustomerRepository>()
                .InstancePerDependency().WithParameter("sqlFactory", customerSqlFactory);

            Program.Container = containerBuilder.Build();
        }
    }
}