using Shared.Model;
using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface IBatchRepo : IBatch

    {
        string BankValueInsert(BankValueModel bankValue, string register, string user);
        List<BankValueModel> GetBankValues(int batchid);
    }
}
