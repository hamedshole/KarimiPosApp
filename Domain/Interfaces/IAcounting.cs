using Shared.Model;
using System;
using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface IAcounting
    {
        List<PayoutTransactionModel> PayoutList(DateTime date);
        List<PersonCreditHeaderModel> PersonCreditList();
    }
}
