using Shared.Model;
using System.Collections.Generic;

namespace KarimiApp.Interface.Client
{
    public interface IReceipt
    {
        ReceiptModel Get(string barcode);
        string Insert(ReceiptModel receipt);
        List<ReceiptModel> List(WorkstationReceiptFilterModel workstationReceiptFilter);
        List<ReceiptModel> List();
        TransactionModel GetTransaction(int id);
    }
}
