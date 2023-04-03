using Shared.Model;
using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface ITransactionRepo : ITransaction
    {
        void InsertItem(TransactionEntryModel transactionEntry, int transaction);
        List<TransactionEntryModel> TransactionEntriesRead(int transactionid);
        void UpdateReceiptTransaction(int receipt, int transaction);
    }
}
