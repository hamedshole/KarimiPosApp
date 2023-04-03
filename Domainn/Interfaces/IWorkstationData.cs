using Shared.Model;
using System;

namespace Domain.Interfaces
{
    public interface IWorkstationData
    {
        long TotalReceiptAmount(string workstation);
        int TotalReceiptCount(string workstation);
        long TotalReceiptAmountForDate(ReceiptModel receipt);
        int TotalReceiptCountForDate(ReceiptModel receipt);
    }
}
