using Shared.Model;
using System.Collections.Generic;

namespace KarimiApp.Interface.Client
{
    public interface ITransaction:IBaseTransaction<TransactionModel>
    {
        List<TransactionModel> List();
        string LastCode();
        long LastValue();
    }
}
