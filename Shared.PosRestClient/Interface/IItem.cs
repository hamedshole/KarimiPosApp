using Shared.Model;
using System.Collections.Generic;

namespace KarimiApp.Interface.Client
{
    public interface IItem:IMainRepository<ItemModel>
    {
       
        List<ItemModel> FilterByDepartment(string department);
        
        List<ItemModel> SearchFilterByDepartment(ItemModel item);
        ReceiptEntryModel GetByBarcode(string barcode);
    }
}
