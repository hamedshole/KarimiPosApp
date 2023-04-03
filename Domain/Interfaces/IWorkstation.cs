using Shared.Model;
using System;
using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface IWorkstation : IMain<WorkstationModel>
    {
        long TotalReceiptAmount(string workstation);
        int TotalReceiptCount(string workstation);
        long TotalReceiptAmountForDate(ReceiptModel receipt);
        int TotalReceiptCountForDate(ReceiptModel receipt);
    }
}
