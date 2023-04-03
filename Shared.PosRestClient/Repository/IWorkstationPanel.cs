using Shared.Model;

namespace KarimiApp.Client.Repository.Interface
{
    public interface IWorkstationPanel
    {
        string SendHardKey(WorkstationHardKeyModel workstationHardKey);
        string SendPlu(WorkstationPluModel workstationPlu);
        string SendMessage(WorkStationMessageModel workStationMessage);
        long TotalReceiptAmount(string workstation);
        int TotalReceiptCount(string workstation);
        long TotalReceiptAmountForDate(ReceiptModel receipt);
        int TotalReceiptCountForDate(ReceiptModel receipt);
    }
}
