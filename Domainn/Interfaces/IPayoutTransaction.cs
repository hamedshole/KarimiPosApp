using Shared.Model;
using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface IPayoutTransaction : IBaseTransaction<PayoutTransactionModel>
    {
        List<PayoutTransactionModel> Read(PayoutTransactionModel payoutTransaction);
    }
}
