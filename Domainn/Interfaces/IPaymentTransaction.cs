using Shared.Model;
using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface IPaymentTransaction : IBaseTransaction<PaymentTransactionModel>
    {
        List<PaymentTransactionModel> Read();
    }
}
