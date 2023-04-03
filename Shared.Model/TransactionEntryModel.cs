using System;

namespace Shared.Model
{
    public class TransactionEntryModel
    {


        public int Id { get; set; }
        public string TransactionType { get; set; }
        public string Item { get; set; }
        public int ItemId { get; set; }
        public long BuyPrice { get; set; }
        public long SellPrice { get; set; }
        public decimal Amount { get; set; }

        public string Description { get; set; }

        public TransactionEntryModel()
        {

        }

        public TransactionEntryModel(decimal amount, string transactionType, string item, long buyPrice)
        {
            Amount = amount;
            TransactionType = transactionType;
            Item = item;
            BuyPrice = buyPrice;
        }

        public void ChangeTransactionType(string transactionType)
        {
            TransactionType = transactionType;
        }
        public void AddAmount()
        {
            Amount++;
        }
        public TransactionEntryModel(int id, int itemId, string transactionType, string item, long buyprice, long sellprice, decimal amount, string description)
        {
            Id = id;
            ItemId = itemId;
            TransactionType = transactionType;
            Item = item;
            BuyPrice = buyprice;
            sellprice = buyprice;
            Amount = amount;
            Description = description;
        }

        public TransactionEntryModel(decimal amount, long sellprice, string item, int itemId)
        {
            ItemId = itemId;
            Amount = amount;
            SellPrice = sellprice;
            Item = item;
        }

        public TransactionEntryModel(string item, int itemId, string transactionType, long sellprice, int amount)
        {
            Item = item;
            ItemId = itemId;
            TransactionType = transactionType;
            SellPrice = sellprice;
            Amount = amount;
        }
    }
}
