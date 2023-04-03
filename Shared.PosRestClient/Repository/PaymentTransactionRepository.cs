using KarimiApp.Client.Repository.Util;
using KarimiApp.Interface.Client;
using Shared.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KarimiApp.Client.Repository.Repository
{
    internal class PaymentTransactionRepository : IPaymentTransaction
    {
        private HttpClientAccess httpClient;
        private string _route = "paymenttransaction";
        public PaymentTransactionRepository(HttpClientAccess httpClient)
        {
            this.httpClient = httpClient;
        }

        string IBaseTransaction<PaymentTransactionModel>.Delete(PaymentTransactionModel model)
        {
            throw new System.NotImplementedException();
        }

        string IBaseTransaction<PaymentTransactionModel>.Insert(PaymentTransactionModel model)
        {
            string res = Task.Run(async () => await this.httpClient.PostReturnString<PaymentTransactionModel>(model, _route + "/post")).Result;
            return res;
        }

        List<PaymentTransactionModel> IPaymentTransaction.List()
        {
            return this.ListResult();
        }

        private List<PaymentTransactionModel> ListResult()
        {
            return Task.Run(async () => await this.httpClient.Get<List<PaymentTransactionModel>>(_route + "/getall")).Result;
        }



        List<PaymentTransactionModel> IBaseTransaction<PaymentTransactionModel>.Search( string model)
        {
           return SearchResult(model);
        }
        private List<PaymentTransactionModel> SearchResult(string text)
        {
            return Task.Run(async () => await this.httpClient.Post<string, List<PaymentTransactionModel>>(text, _route + "/getall")).Result;
        }
    }
}
