﻿namespace LogisticsCRUD.Domain
{
    public class VehicleEntity : BusinessEntity
    {
        public string Numberplate { get; set; }
        public string Brand { get; set; }
        public int ProductionYear { get; set; }
        public string Vin { get; set; }
    }
}