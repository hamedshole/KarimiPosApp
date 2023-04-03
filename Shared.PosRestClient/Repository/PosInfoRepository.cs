using KarimiApp.Client.Repository.Util;
using KarimiApp.Interface.Client;
using Shared.Model;

namespace KarimiApp.Client.Repository.Repository
{
    internal class PosInfoRepository : MainRepository<PosInfoModel>, IPosInfo
    {
        public PosInfoRepository(HttpClientAccess httpClient) : base("posinfo", httpClient)
        {
        }

    }
}
