using KarimiApp.Client.Repository.Util;
using KarimiApp.Interface.Client;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KarimiApp.Client.Repository.Repository
{
    internal class BaseTransactionRepository<TModel> : IBaseTransaction<TModel> where TModel:class,new()
    {
        private HttpClientAccess httpClient;
        private readonly string _route = "";

        public BaseTransactionRepository(HttpClientAccess httpClient, string route)
        {
            this.httpClient = httpClient;
            _route = route;
        }

        string IBaseTransaction<TModel>.Insert(TModel model)
        {
          string res= Task.Run(async()=>await httpClient.PostReturnString(model, _route + "/post")).Result;
            return res;
        }


        List<TModel> IBaseTransaction<TModel>.Search(string text)
        {
            throw new NotImplementedException();
        }

        string IBaseTransaction<TModel>.Delete(TModel model)
        {
            throw new NotImplementedException();
        }
    }
}
