using KarimiApp.Client.Repository.Util;
using KarimiApp.Interface.Client;
using Shared.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KarimiApp.Client.Repository.Repository
{
    internal class OrderTransactionRepository : IOrder
    {
        private HttpClientAccess httpClient;
        private string _route = "ordertransaction";

        public OrderTransactionRepository(HttpClientAccess httpClient)
        {
            this.httpClient = httpClient;
        }


        string IBaseTransaction<OrderTransactionModel>.Delete(OrderTransactionModel model)
        {
            throw new NotImplementedException();
        }

        string IBaseTransaction<OrderTransactionModel>.Insert(OrderTransactionModel model)
        {
            string res = Task.Run(async () => await this.httpClient.PostReturnString<OrderTransactionModel>(model, _route + "/post")).Result;
            return res;
        }

        List<OrderTransactionModel> IBaseTransaction<OrderTransactionModel>.Search(string text)
        {
            throw new NotImplementedException();
        }
    }
}
