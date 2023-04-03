using Domain.Interfaces;
using Shared.Model;
using System.Collections.Generic;

namespace Application.Repositories.Repository
{
    internal class PaymentTransactionRepository : IPaymentTransaction
    {
        IPaymentTransaction repository;

        public PaymentTransactionRepository(IPaymentTransaction repository)
        {
            this.repository = repository;
        }

        string IBaseTransaction<PaymentTransactionModel>.Delete(PaymentTransactionModel model)
        {
            throw new NotImplementedException();
        }

        string IBaseTransaction<PaymentTransactionModel>.Insert(PaymentTransactionModel model)
        {
            return repository.Insert(model);
        }

        List<PaymentTransactionModel> IPaymentTransaction.Read()
        {
            return repository.Read();
        }

        List<PaymentTransactionModel> IBaseTransaction<PaymentTransactionModel>.Search(PaymentTransactionModel model)
        {
            return repository.Search(model);
        }
    }
}
