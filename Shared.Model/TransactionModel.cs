using System;
using System.Collections.Generic;

namespace Shared.Model
{

    public class TransactionModel
    {
        public int Id { get; set; }
        public int Batch { get; set; }
        public string BatchUser { get; set; }
        public string BatchRegister { get; set; }
        public bool Io { get; set; }
        public string TransactionType { get; set; }
        public string PaymentMethod { get; set; }
        public DateTime RecordTime { get; set; }
        public string Person { get; set; }
        public string Serial { get; set; }
        public long TotalValue { get; set; }
        public bool Credit { get; set; }
        public long PaidValue { get; set; }
        public string Description { get; set; }
        public List<int> Receipts { get; set; }
        public List<TransactionEntryModel> Entries { get; set; }


        public TransactionModel()
        {

        }

        public void SetEntries(List<TransactionEntryModel> transactionEntries)
        {
            Entries = transactionEntries;
        }
        public TransactionModel(string batchUser, string batchRegister, bool io, string transactionType, string paymentMethod, string person, long totalValue, bool credit, long paidValue, string description)
        {
            BatchUser = batchUser;
            BatchRegister = batchRegister;
            Io = io;
            TransactionType = transactionType;
            PaymentMethod = paymentMethod;
            Person = person;
            TotalValue = totalValue;
            Credit = credit;
            PaidValue = paidValue;
            Description = description;
        }

        public TransactionModel(int id, int batch, string batchUser, string batchRegister, bool io, string transactionType, string paymentMethod, DateTime recordTime, string person, string serial, long totalValue, bool credit, long paidValue, string description)
        {
            Id = id;
            Batch = batch;
            BatchUser = batchUser;
            BatchRegister = batchRegister;
            Io = io;
            TransactionType = transactionType;
            PaymentMethod = paymentMethod;
            RecordTime = recordTime;
            Person = person;
            Serial = serial;
            TotalValue = totalValue;
            Credit = credit;
            PaidValue = paidValue;
            Description = description;
        }

        //public TransactionModel(string transactionType,bool io, string batchRegister, string batchUser, string paymentMethod, string person, long totalValue, bool credit, long paidValue)
        //{
        //    this.TransactionType = transactionType;
        //    BatchRegister = batchRegister;
        //    BatchUser = batchUser;
        //    PaymentMethod = paymentMethod;
        //    Person = person;
        //    TotalValue = totalValue;
        //    Credit = credit;
        //    PaidValue = paidValue;
        //    this.Io = io;
        //}
    }
}
