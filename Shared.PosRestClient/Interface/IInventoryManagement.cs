using Shared.Model;
using System.Collections.Generic;

namespace KarimiApp.Interface.Client
{
    public interface IInventoryManagement
    {
        string AddItem(InventoryLogModel itemlog);
        List<InventoryLogModel> GetItemLog(ItemModel item);
        decimal GetItemStock(ItemModel item);
    }
}
