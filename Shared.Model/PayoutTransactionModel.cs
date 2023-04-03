using System;

namespace Shared.Model
{
    public class PayoutTransactionModel
    {
        public int Id { get; set; }
        public int Batch { get; set; }
        public string BatchUser { get; set; }
        public string BatchRegister { get; set; }
        public DateTime RecordTime { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Person { get; set; }
        public string Serial { get; set; }
        public long Value { get; set; }

        public string Description { get; set; }
        public PayoutTransactionModel()
        {

        }

        public PayoutTransactionModel(string batchUser, string batchRegister, long value, string description, string person = "")
        {
            BatchUser = batchUser;
            BatchRegister = batchRegister;
            Person = person;
            Value = value;
            Description = description;
        }

        public PayoutTransactionModel(int batch, int id, string batchUser, string batchRegister, DateTime recordTime, string person, string serial, long value, string description)
        {
            Batch = batch;
            Id = id;
            BatchUser = batchUser;
            BatchRegister = batchRegister;
            RecordTime = recordTime;
            Person = person;
            Serial = serial;
            Value = value;
            Description = description;
        }
    }
}
