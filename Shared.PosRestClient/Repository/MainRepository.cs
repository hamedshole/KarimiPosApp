using KarimiApp.Client.Repository.Util;
using KarimiApp.Interface.Client;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KarimiApp.Client.Repository.Repository
{
    internal class MainRepository<Tmodel> : IMainRepository<Tmodel> where Tmodel : class, new()
    {
        HttpClientAccess httpClientAccess;
        private readonly string _route;

        public MainRepository(string route, HttpClientAccess httpClient)
        {
            httpClientAccess = httpClient;
            this._route = route;
        }

        string IMainRepository<Tmodel>.Create(Tmodel model)
        {
            string result = Task.Run(async () => await this.httpClientAccess.PostReturnString(model, _route + "/post")).Result;
           return result;

        }

        string IMainRepository<Tmodel>.Delete(Tmodel model)
        {
            string result = Task.Run(async () => await this.httpClientAccess.PostReturnString(model, _route + "/delete")).Result;
            return result;
        }

        Tmodel IMainRepository<Tmodel>.Get(string text)
        {
            var result = Task.Run(async () => await this.httpClientAccess.Post<string, Tmodel>(text, _route + "/get")).Result;
            return result;
        }

        List<Tmodel> IMainRepository<Tmodel>.List(string text)
        {
            return this.ListResult();
        }

        protected List<Tmodel> ListResult()
        {
            return Task.Run(async () => await this.httpClientAccess.Get<List<Tmodel>>(_route + "/getall")).Result;
        }
        private List<Tmodel> SearchResult(string text)
        {
            return Task.Run(async () => await this.httpClientAccess.Post<string, List<Tmodel>>(text, _route + "/search")).Result;
        }


        List<Tmodel> IMainRepository<Tmodel>.Search(string text)
        {
            return this.SearchResult(text);
        }

            string IMainRepository<Tmodel>.Update(Tmodel model)
        {
            string result = Task.Run(async () => await this.httpClientAccess.PostReturnString(model, _route + "/put")).Result;
            return result;
        }

    }
}
