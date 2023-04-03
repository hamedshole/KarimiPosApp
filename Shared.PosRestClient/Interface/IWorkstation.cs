using Shared.Model;

namespace KarimiApp.Interface.Client
{
    public interface IWorkstation:IMainRepository<WorkstationModel>
    {
        long TotalReceiptAmount(string workstation);
        int TotalReceiptCount(string workstation);
        long TotalReceiptAmountForDate(ReceiptModel receipt);
        int TotalReceiptCountForDate(ReceiptModel receipt);
    }
}
