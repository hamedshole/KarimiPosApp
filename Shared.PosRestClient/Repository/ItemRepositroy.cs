using KarimiApp.Client.Repository.Util;
using KarimiApp.Interface.Client;
using Shared.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KarimiApp.Client.Repository.Repository
{
    internal class ItemRepositroy : MainRepository<ItemModel>, IItem
    {
        HttpClientAccess httpClient;
        private readonly string _route = "item";
        public ItemRepositroy(HttpClientAccess httpClient) : base("item", httpClient)
        {
            this.httpClient = httpClient;
        }

        

       

        private List<ItemModel> FilterByDepartment(string department)
        {
            return Task.Run(async () => await this.httpClient.Post<string, List<ItemModel>>(department, _route + "/filterbydepartment")).Result;
        }

       

        private List<ItemModel> SearchFilterByDepartment(ItemModel item)
        {
          
            return Task.Run(async () => await this.httpClient.Post<ItemModel, List<ItemModel>>(item, _route + "/searchfilterbydepartment")).Result;
        }

        List<ItemModel> IItem.FilterByDepartment(string department)
        {
            return FilterByDepartment(department);
        }

        List<ItemModel> IItem.SearchFilterByDepartment(ItemModel item)
        {
            return SearchFilterByDepartment(item);
        }

        ReceiptEntryModel IItem.GetByBarcode(string barcode)
        {
            return Task.Run(async () => await this.httpClient.Post<string, ReceiptEntryModel>(barcode, _route + "/getbybarcode")).Result;
        }
    }
}
