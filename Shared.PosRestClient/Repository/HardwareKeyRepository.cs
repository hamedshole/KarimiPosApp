using KarimiApp.Client.Repository.Util;
using KarimiApp.Interface.Client;
using Shared.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KarimiApp.Client.Repository.Repository
{
    internal class HardwareKeyRepository : IHardwareKey
    {
        private HttpClientAccess httpClientAccess;
        private readonly string _route = "hardkey";

        public HardwareKeyRepository(HttpClientAccess httpClientAccess)
        {
            this.httpClientAccess = httpClientAccess;
        }

        string IHardwareKey.Create(HardwareKeyModel model)
        {
            var res =Task.Run(async()=>await httpClientAccess.PostReturnString(model, _route + "/post")).Result;
            return res;
        }

        string IHardwareKey.Delete(HardwareKeyModel model)
        {
            var res = Task.Run(async () => await httpClientAccess.PostReturnString(model, _route + "/delete")).Result;
            return res;
        }

        List<HardwareKeyModel> IHardwareKey.List(HardwareKeyModel model)
        {
            return ListMethod(model);
        }

        private List<HardwareKeyModel> ListMethod(HardwareKeyModel model)
        {
            return Task.Run(async () => await httpClientAccess.Post<HardwareKeyModel, List<HardwareKeyModel>>(model, _route + "/get")).Result;
        }
        private List<HardwareKeyModel> SearchMethod(HardwareKeyModel model)
        {
            return Task.Run(async () => await httpClientAccess.Post<HardwareKeyModel, List<HardwareKeyModel>>(model, _route + "/search")).Result;
        }

        List<HardwareKeyModel> IHardwareKey.Search(HardwareKeyModel model)
        {
           return this.SearchMethod(model);
        }


        string IHardwareKey.Update(HardwareKeyModel model)
        {
            var res = Task.Run(async () => await httpClientAccess.PostReturnString<HardwareKeyModel>(model, _route + "/put")).Result;
            return res;
        }
    }
}
