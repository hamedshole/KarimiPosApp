using KarimiApp.Client.Repository.Interface;
using KarimiApp.Client.Repository.Util;
using Shared.Model;
using System.Threading.Tasks;

namespace KarimiApp.Client.Repository.Repository
{
    public class WorkstationPanelRepository : IWorkstationPanel
    {
        private HttpClientAccess httpClient;
        private string _route = "workstationserver";

        public WorkstationPanelRepository()
        {
            this.httpClient = new HttpClientAccess();
        }

        string IWorkstationPanel.SendHardKey(WorkstationHardKeyModel workstationHardKey)
        {
            string message = Task.Run(async () => await this.httpClient.PostReturnString(workstationHardKey, "/sendhardkey")).Result;
            return  message;
        }

        string IWorkstationPanel.SendMessage(WorkStationMessageModel workStationMessage)
        {
            string message = Task.Run(async () => await this.httpClient.PostReturnString(workStationMessage, "/sendmessage")).Result;
            return message;
        }

        string IWorkstationPanel.SendPlu(WorkstationPluModel workstationPlu)
        {
            string message = Task.Run(async () => await this.httpClient.PostReturnString(workstationPlu, "/sendplu")).Result;
            return message;
        }

        long IWorkstationPanel.TotalReceiptAmount(string workstation)
        {
            return Task.Run(async () => await this.httpClient.Post<WorkstationModel, long>(new WorkstationModel { Title=workstation}, "/totalreceiptamount")).Result;

        }

        long IWorkstationPanel.TotalReceiptAmountForDate(ReceiptModel receipt)
        {
            return Task.Run(async () => await this.httpClient.Post<ReceiptModel, long>(receipt, "/totalreceiptamountfordate")).Result;
        }

        int IWorkstationPanel.TotalReceiptCount(string workstation)
        {
            return Task.Run(async () => await this.httpClient.Post<WorkstationModel, int>(new WorkstationModel { Title=workstation}, "/totalreceiptcount")).Result;
        }

        int IWorkstationPanel.TotalReceiptCountForDate(ReceiptModel receipt)
        {
            return Task.Run(async () => await this.httpClient.Post<ReceiptModel, int>(receipt, "/totalreceiptcountfordate")).Result;
        }
    }
}
