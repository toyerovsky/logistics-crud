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
using PSK.Databases.LogisticsCRUD.Domain.Complaint;
using PSK.Databases.LogisticsCRUD.Domain.Courier;
using PSK.Databases.LogisticsCRUD.Domain.Package;
using PSK.Databases.LogisticsCRUD.Domain.Vehicle;

namespace PSK.Databases.LogisticsCRUD.Startup
{
    public class AutofacStartupProcedure : IStartupProcedure
    {
        public void Run()
        {
            var customerSqlFactory = new CustomerSqlFactory();
            var courierSqlFactory = new CourierSqlFactory();
            var packageSqlFactory = new PackageSqlFactory();
            var vehicleSqlFactory = new VehicleSqlFactory();
            var complaintSqlFactory = new ComplaintSqlFactory();

            var containerBuilder = new ContainerBuilder();
            var connectionString = ConfigurationManager.ConnectionStrings[Const.OracleConnectionStringKey].ConnectionString;
            containerBuilder.RegisterInstance(customerSqlFactory).As<ICustomerSqlFactory>().SingleInstance();
            containerBuilder.Register(ctx =>
            {
                var connection = new OracleConnection(connectionString);
                connection.Open();
                connection.Execute("ALTER SESSION SET CURRENT_SCHEMA = SYSTEM");
                return connection;
            }).As<IDbConnection>().InstancePerDependency();

            const string sqlFactoryParamName = "sqlFactory";

            containerBuilder.RegisterType<CustomerRepository>().As<ICustomerRepository>()
                .InstancePerDependency().WithParameter(sqlFactoryParamName, customerSqlFactory);
            containerBuilder.RegisterType<CourierRepository>().As<ICourierRepository>()
                .InstancePerDependency().WithParameter(sqlFactoryParamName, courierSqlFactory);
            containerBuilder.RegisterType<PackageRepository>().As<IPackageRepository>()
                .InstancePerDependency().WithParameter(sqlFactoryParamName, packageSqlFactory);
            containerBuilder.RegisterType<VehicleRepository>().As<IVehicleRepository>()
                .InstancePerDependency().WithParameter(sqlFactoryParamName, vehicleSqlFactory);
            containerBuilder.RegisterType<ComplaintRepository>().As<IComplaintRepository>()
                .InstancePerDependency().WithParameter(sqlFactoryParamName, complaintSqlFactory);

            containerBuilder.RegisterType<MainForm>().AsSelf();
            containerBuilder.RegisterType<CustomerListForm>().AsSelf();
            containerBuilder.RegisterType<CourierListForm>().AsSelf();
            containerBuilder.RegisterType<PackageListForm>().AsSelf();
            containerBuilder.RegisterType<VehicleListForm>().AsSelf();
            containerBuilder.RegisterType<ComplaintListForm>().AsSelf();

            Program.Container = containerBuilder.Build();
        }
    }
}