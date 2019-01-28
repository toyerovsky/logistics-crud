using Dapper.FluentMap;
using PSK.Databases.LogisticsCRUD.Infrastructure.Mapping;

namespace PSK.Databases.LogisticsCRUD.Startup
{
    public class EntityMappingStartupProcedure : IStartupProcedure
    {
        public void Run()
        {
            FluentMapper.Initialize(config =>
            {
                config.AddMap(new CustomerMap());
                config.AddMap(new CourierMap());
                config.AddMap(new PackageEntityMap());
                config.AddMap(new VehicleEntityMap());
                config.AddMap(new ComplaintEntityMap());
            });
        }
    }
}