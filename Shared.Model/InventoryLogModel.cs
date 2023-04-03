using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Model
{
    public class InventoryLogModel
    {
        public int Id { get; set; }
        public string Inventory { get; set; }
        public string Item { get; set; }
        public string Io { get; set; }
        public DateTime RecordTime { get; set; }
        public long BuyPrice { get; set; }
        public long SellPrice { get; set; }
        public decimal Amount { get; set; }

        public InventoryLogModel()
        {

        }
        public InventoryLogModel(int id, string inventory, string item, string io, DateTime recordTime, long buyPrice, long sellPrice, decimal amount)
        {
            Id = id;
            Inventory = inventory;
            Item = item;
            Io = io;
            RecordTime = recordTime;
            BuyPrice = buyPrice;
            SellPrice = sellPrice;
            Amount = amount;
        }
    }
}
