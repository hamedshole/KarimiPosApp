using KarimiApp.Client.Repository.Util;
using KarimiApp.Interface.Client;
using Shared.Model;

namespace KarimiApp.Client.Repository.Repository
{
    internal class ItemCategoryRepository : MainRepository<ItemCategoryModel>,IItemCategory
    {
        public ItemCategoryRepository(HttpClientAccess httpClient) : base("itemcategory",httpClient)
        {
        }

    }
}
