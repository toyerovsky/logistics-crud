using System;

namespace LogisticsCRUD.Domain
{
    public class AddressEntity : BusinessEntity
    {
        public string Street { get; set; }
        public string StreetNumber { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public int CountryId { get; set; }
    }
}