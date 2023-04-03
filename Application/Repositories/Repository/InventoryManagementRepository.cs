using Domain.Interfaces;
using Shared.Model;
using System.Collections.Generic;

namespace Application.Repositories.Repository
{
    public class InventoryManagementRepository : IInventoryManagement
    {
        IInventoryManagement dbAccess;

        public InventoryManagementRepository(IInventoryManagement dbAccess)
        {
            this.dbAccess = dbAccess;
        }

        List<InventoryLogModel> IInventoryManagement.GetItemLog(ItemModel item)
        {
            return dbAccess.GetItemLog(item);
        }

        decimal IInventoryManagement.GetItemStock(ItemModel item)
        {
            return dbAccess.GetItemStock(item);
        }

        string IInventoryManagement.AddItem(InventoryLogModel item)
        {
            return dbAccess.AddItem(item);
        }
    }
}
