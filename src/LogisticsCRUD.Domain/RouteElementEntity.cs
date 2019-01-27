using PSK.Databases.LogisticsCRUD.Domain.Common;

namespace PSK.Databases.LogisticsCRUD.Domain
{
    public class RouteElementEntity : BusinessEntity
    {
        public int VehicleId { get; set; }
        public int PackageId { get; set; }
        public int CourierId { get; set; }
        public int? PrevRouteElementId { get; set; }
        public int? NextRouteElementId { get; set; }
    }
}