using KarimiApp.Client.Repository.Util;
using KarimiApp.Interface.Client;
using Shared.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KarimiApp.Client.Repository.Repository
{
    internal class PayoutTransactionRepository : IPayoutTransaction
    {
        private HttpClientAccess httpClient;
        private string _route = "payouttransaction";
        public PayoutTransactionRepository(HttpClientAccess httpClient)
        {
            this.httpClient = httpClient;
        }

        string IBaseTransaction<PayoutTransactionModel>.Insert(PayoutTransactionModel model)
        {
            string res = Task.Run(async () => await this.httpClient.PostReturnString<PayoutTransactionModel>(model, _route + "/post")).Result;

            return res;
        }

        List<PayoutTransactionModel> IPayoutTransaction.List(PayoutTransactionModel payoutTransaction)
        {
            return ListResult(payoutTransaction);
        }

        private List<PayoutTransactionModel> ListResult(PayoutTransactionModel payoutTransaction)
        {
            return Task.Run(async () => await this.httpClient.Post<PayoutTransactionModel, List<PayoutTransactionModel>>(payoutTransaction, _route + "/getall")).Result;
        }




        private List<PayoutTransactionModel> SearchResult(string text)
        {
            return Task.Run(async () => await this.httpClient.Post<string, List<PayoutTransactionModel>>(text, _route + "/getall")).Result;
        }

        string IBaseTransaction<PayoutTransactionModel>.Delete(PayoutTransactionModel model)
        {
            string res = Task.Run(async () => await this.httpClient.PostReturnString(model, _route + "/delete")).Result;
            return res;
        }

        public List<PayoutTransactionModel> Search(string text)
        {
            return SearchResult(text);
        }
    }
}
