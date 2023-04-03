using Domain.Interfaces;
using Shared.Model;

namespace Application.Repositories.Repository
{
    internal class TransactionTypeRepository : MainRepository<TransactionTypeModel>, ITransactionType
    {
        public TransactionTypeRepository(ITransactionType repository) : base(repository)
        {
        }
    }
}
