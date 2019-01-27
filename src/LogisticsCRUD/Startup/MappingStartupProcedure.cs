using Dapper.FluentMap;
using PSK.Databases.LogisticsCRUD.Infrastructure.Mapping;

namespace PSK.Databases.LogisticsCRUD.Startup
{
    public class MappingStartupProcedure : IStartupProcedure
    {
        public void Run()
        {
            FluentMapper.Initialize(config =>
            {
                config.AddMap(new CustomerMap());
                config.AddMap(new CourierMap());
            });
        }
    }
}