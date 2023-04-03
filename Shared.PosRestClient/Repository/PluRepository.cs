using KarimiApp.Client.Repository.Util;
using KarimiApp.Interface.Client;
using Shared.Model;

namespace KarimiApp.Client.Repository.Repository
{
    internal class PluRepository : MainRepository<PluModel>, IPlu
    {
        public PluRepository(HttpClientAccess httpClient) : base("plu", httpClient)
        {
        }

    }
}
