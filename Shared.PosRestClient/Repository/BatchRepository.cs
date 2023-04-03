using KarimiApp.Client.Repository.Util;
using KarimiApp.Interface.Client;
using Shared.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KarimiApp.Client.Repository.Repository
{

    internal class BatchRepository : IBatch
    {
        private HttpClientAccess httpClient;
        private string _route = "batch";

        public BatchRepository(HttpClientAccess httpClient)
        {
            this.httpClient = httpClient;
        }

        string IBatch.Delete(BatchModel batch)
        {
            var res = Task.Run(async () => await this.httpClient.PostReturnString<BatchModel>(batch, _route + "/Close")).Result;
            return res;
        }

        List<BatchModel> IBatch.List()
        {
            List<BatchModel> batches = new List<BatchModel>();
            batches =  this.ListMethod();
           return batches;
        }

       

        private List<BatchModel> ListMethod()
        {
            return Task.Run(async () => await this.httpClient.Get<List<BatchModel>>(_route + "/getall")).Result;
        }
       
    }
}
