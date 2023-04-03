using KarimiApp.Client.Repository.Util;
using KarimiApp.Interface.Client;
using Shared.Model;

namespace KarimiApp.Client.Repository.Repository
{
    internal class InventoryGroupRepository : MainRepository<InventoryGroupModel>, IInventoryGroup
    {
        public InventoryGroupRepository( HttpClientAccess httpClient) : base("inventorygroup", httpClient)
        {
        }

    }
}
