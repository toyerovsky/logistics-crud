using System;

namespace LogisticsCRUD.Domain
{
    public class CustomerEntity : BusinessEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Company { get; set; }
        public string TaxNumber { get; set; }
    }
}