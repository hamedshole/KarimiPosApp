using System;

namespace Shared.Model
{
    public class PaymentTransactionModel
    {
        public int Id { get; set; }
        public int Batch { get; set; }
        public string BatchUser { get; set; }
        public string BatchRegister { get; set; }
        public bool Io { get; set; }
        public string PaymentMethod { get; set; }
        public DateTime RecordTime { get; set; }
        public string Person { get; set; }
        public string Serial { get; set; }
        public long Value { get; set; }
        public string Description { get; set; }

        public PaymentTransactionModel()
        {

        }

        public PaymentTransactionModel(string batchUser, string batchRegister, bool io, string paymentMethod, string person, long value, string description)
        {
            BatchUser = batchUser;
            BatchRegister = batchRegister;
            Io = io;
            PaymentMethod = paymentMethod;
            Person = person;
            Value = value;
            Description = description;
        }

        public PaymentTransactionModel(int batch, int id, string batchUser, string batchRegister, bool io, string paymentMethod, DateTime recordTime, string person, string serial, long value, string description)
        {
            Batch = batch;
            Id = id;
            BatchUser = batchUser;
            BatchRegister = batchRegister;
            Io = io;
            PaymentMethod = paymentMethod;
            RecordTime = recordTime;
            Person = person;
            Serial = serial;
            Value = value;
            Description = description;
        }
    }
}
