using KarimiApp.Client.Repository.Util;
using KarimiApp.Interface.Client;
using Shared.Model;

namespace KarimiApp.Client.Repository.Repository
{
    internal class WorkstationRepository : MainRepository<WorkstationModel>, IWorkstation
    {
        private HttpClientAccess httpClient;
        private string _route = "workstation";
        public WorkstationRepository(HttpClientAccess httpClient) : base("workstation", httpClient)
        {
            this.httpClient = httpClient;
        }

        long IWorkstation.TotalReceiptAmount(string workstation)
        {
            return 1; //  return Task.Run(async () => await this.httpClient.Post<string, long>(workstation, _route + "/totalreceiptamount")).Result;
        }

        long IWorkstation.TotalReceiptAmountForDate(ReceiptModel receipt)
        {
            return 1;//  return Task.Run(async () => await this.httpClient.Post<ReceiptModel, long>(receipt, _route + "/totalreceiptamountfordate")).Result;
        }

        int IWorkstation.TotalReceiptCount(string workstation)
        {
            return 1;
            // return Task.Run(async () => await this.httpClient.Post<string, int>(workstation, _route + "/totalreceiptcount")).Result;
        }

        int IWorkstation.TotalReceiptCountForDate(ReceiptModel receipt)
        {
            return 1;
           // return Task.Run(async () => await this.httpClient.Post<ReceiptModel, int>(receipt, _route + "/totalreceiptcountfordate")).Result;
        }
    }
}
