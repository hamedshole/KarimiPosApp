using Shared.Model;
using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface IItem : IMain<ItemModel>
    {
        List<ItemModel> FilterByDepartment(string department);
        List<ItemModel> SearchFilterByDepartment(ItemModel item);
        ReceiptEntryModel GetByBarcode(string barcode);
    }
}
