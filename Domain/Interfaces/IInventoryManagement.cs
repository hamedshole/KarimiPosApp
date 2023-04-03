using Shared.Model;
using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface IInventoryManagement
    {
        string AddItem(InventoryLogModel item);
        List<InventoryLogModel> GetItemLog(ItemModel item);
        decimal GetItemStock(ItemModel item);
    }
}
