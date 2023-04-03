using Domain.Interfaces;
using Shared.Model;
using System.Collections.Generic;

namespace Application.Repositories.Repository
{
    internal class OrderTransactionRepository : IOrder
    {
        IOrder repository;

        public OrderTransactionRepository(IOrder repository)
        {
            this.repository = repository;
        }

        string IOrder.Insert(OrderTransactionModel order)
        {
            return repository.Insert(order);
        }

        List<OrderTransactionModel> IOrder.List()
        {
            return repository.List();
        }

        string IOrder.Pay(OrderTransactionModel order)
        {
            return repository.Pay(order);
        }
    }
}
