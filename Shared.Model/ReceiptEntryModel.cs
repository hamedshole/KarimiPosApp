namespace Shared.Model
{
    public class ReceiptEntryModel
    {
        public int Id { get; set; }
        public ItemModel Item { get; set; }
        public long UnitPrice { get; set; }
        public decimal Amount { get; set; }
        public ReceiptEntryModel()
        {

        }

        public ReceiptEntryModel(ItemModel item, long unitPrice, decimal amount)
        {
            Item = item;
            UnitPrice = unitPrice;
            Amount = amount;
        }

        public ReceiptEntryModel(int id, ItemModel item, long unitPrice, decimal amount)
        {
            Id = id;
            Item = item;
            UnitPrice = unitPrice;
            Amount = amount;
        }
    }
}
