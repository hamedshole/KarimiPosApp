using Domain.Interfaces;
using Shared.Model;

namespace Application.Repositories.Repository
{
    internal class TransactionRepostory : BaseTransactionRepository<TransactionModel>, ITransaction
    {
        public TransactionRepostory(IBaseTransaction<TransactionModel> baseTransactionRepository) : base(baseTransactionRepository)
        {
        }

        public string LastCode()
        {
            throw new NotImplementedException();
        }

        public long LastValue()
        {
            throw new NotImplementedException();
        }

        public List<TransactionModel> Read()
        {
            throw new NotImplementedException();
        }
    }
}
