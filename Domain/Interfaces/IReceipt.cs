using Shared.Model;
using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface IReceipt
    {
        string Insert(ReceiptModel receipt);
        List<ReceiptModel> List(WorkstationReceiptFilterModel workstationReceiptFilterModel);
        ReceiptModel Get(string barcode);
        List<ReceiptModel> CashierList();
        TransactionModel GetTransaction(int id);
    }
}
