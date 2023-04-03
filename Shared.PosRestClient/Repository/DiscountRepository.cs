using KarimiApp.Client.Repository.Util;
using KarimiApp.Interface.Client;
using Shared.Model;

namespace KarimiApp.Client.Repository.Repository
{
    internal class DiscountRepository : MainRepository<DiscountModel>, IDiscount
    {
        public DiscountRepository(HttpClientAccess httpClient) : base("discount", httpClient)
        {
        }
    }
}
