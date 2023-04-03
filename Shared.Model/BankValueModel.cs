namespace Shared.Model
{
    public class BankValueModel
    {
        public int Id { get; set; }
        public string PaymentMethod { get; set; }
        public long OpenValue { get; set; }
        public long CloseValue { get; set; }
        public long TotalSell { get; set; }
        public long Variant { get; set; }
        public BankValueModel()
        {

        }

        public BankValueModel(string paymentMethod, long openValue, long closeValue)
        {
            PaymentMethod = paymentMethod;
            OpenValue = openValue;
            CloseValue = closeValue;
        }

        public BankValueModel(int id, string paymentMethod, long openValue, long closeValue, long total, long variant)
        {
            Id = id;
            PaymentMethod = paymentMethod;
            OpenValue = openValue;
            CloseValue = closeValue;
            TotalSell = total;
            Variant = variant;
        }
    }
}
