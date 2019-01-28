using PSK.Databases.LogisticsCRUD.Domain.Common;

namespace PSK.Databases.LogisticsCRUD.Domain.Refund
{
    public class RefundEntity : BusinessEntity
    {
        public int PackageId { get; set; }
        public string Iban { get; set; }
        public string SwiftCode { get; set; }
        public string BankAccountOwner { get; set; }
        public decimal AmountOfMoney { get; set; }
        public string Status { get; set; }
    }
}