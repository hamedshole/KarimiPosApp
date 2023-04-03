using KarimiApp.Client.Repository.Util;
using KarimiApp.Interface.Client;
using Shared.Model;

namespace KarimiApp.Client.Repository.Repository
{
    internal class SupplierRepository : MainRepository<SupplierAgentModel>, ISupplier
    {
        public SupplierRepository(HttpClientAccess httpClient) : base("supplier", httpClient)
        {
        }
    }
}
