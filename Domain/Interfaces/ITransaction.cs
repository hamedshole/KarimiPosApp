using Shared.Model;
using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface ITransaction : IBaseTransaction<TransactionModel>
    {
        List<TransactionModel> Read();
        string LastCode();
        long LastValue();
    }
}
