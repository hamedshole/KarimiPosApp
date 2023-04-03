using Shared.Model;
using System.Collections.Generic;

namespace KarimiApp.Interface.Client
{
    public interface IPayoutTransaction:IBaseTransaction<PayoutTransactionModel>
    {
        List<PayoutTransactionModel> List(PayoutTransactionModel payoutTransaction);
       
    }
}
