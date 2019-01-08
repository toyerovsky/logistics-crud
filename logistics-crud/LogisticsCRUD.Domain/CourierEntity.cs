using System;

namespace LogisticsCRUD.Domain
{
    public class CourierEntity : BusinessEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
    }
}