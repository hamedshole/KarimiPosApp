using System;

namespace Shared.Model
{
    public class OrderTransactionModel
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string BatchUser { get; set; }
        public string BatchRegister { get; set; }
        public string PaymentMethod { get; set; }
        public string Person { get; set; }
        public long Total { get; set; }
        public bool Checkout { get; set; }
        public DateTime Time { get; set; }
        public string Description { get; set; }

    }
}
