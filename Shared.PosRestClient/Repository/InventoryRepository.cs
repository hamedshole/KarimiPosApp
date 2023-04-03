using KarimiApp.Client.Repository.Util;
using KarimiApp.Interface.Client;
using Shared.Model;

namespace KarimiApp.Client.Repository.Repository
{
    internal class InventoryRepository : MainRepository<InventoryModel>,IInventory
    {
        public InventoryRepository(HttpClientAccess httpClient) : base("inventory",httpClient)
        {

        }

     
    }
}
