namespace Shared.Model
{
    public class ItemModel
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string Barcode { get; set; }
        public string Name { get; set; }
        public int Memory { get; set; }
        public string Department { get; set; }
        public string Category { get; set; }
        public bool Weighed { get; set; }
        public long BuyPrice { get; set; }
        public long SellPrice { get; set; }
        public decimal Stock { get; set; }
        public bool Active { get; set; }
        public ItemModel()
        {

        }
        public ItemModel(int id)
        {
            Id = id;
        }
        public ItemModel(string name)
        {
            Name = name;
        }

        /// <summary>
        /// constructor to create a new item
        /// </summary>
        /// <param name="barcode"></param>
        /// <param name="name"></param>
        /// <param name="department"></param>
        /// <param name="category"></param>
        /// <param name="weighed"></param>
        /// <param name="buyPrice"></param>
        /// <param name="sellPrice"></param>
        /// <param name="stock"></param>
        /// <param name="active"></param>
        public ItemModel(string barcode, string name, string department, string category, bool weighed, long buyPrice, long sellPrice, bool active)
        {
            Barcode = barcode;
            Name = name;
            Department = department;
            Category = category;
            Weighed = weighed;
            BuyPrice = buyPrice;
            SellPrice = sellPrice;
            Active = active;
        }

        /// <summary>
        /// constructor to update item
        /// </summary>
        /// <param name="id"></param>
        /// <param name="barcode"></param>
        /// <param name="name"></param>
        /// <param name="department"></param>
        /// <param name="category"></param>
        /// <param name="weighed"></param>
        /// <param name="buyPrice"></param>
        /// <param name="sellPrice"></param>
        /// <param name="stock"></param>
        /// <param name="active"></param>
        public ItemModel(int id, int code, string barcode, string name, string department, string category, bool weighed, long buyPrice, long sellPrice, bool active, int plumemory, decimal stock = 0)
        {
            Id = id;
            Code = code;
            Barcode = barcode;
            Name = name;
            Department = department;
            Category = category;
            Weighed = weighed;
            BuyPrice = buyPrice;
            SellPrice = sellPrice;
            Stock = stock;
            Active = active;
            Memory = plumemory;
        }




        public ItemModel(string department, string text)
        {
            Department = department;
            Name = text;
        }
    }
}
