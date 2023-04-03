using Shared.Model;
using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface IOrder
    {
        string Insert(OrderTransactionModel order);
        string Pay(OrderTransactionModel order);
        List<OrderTransactionModel> List();
    }
}
