using Shared.Model;
using System;
using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface IAcountingRepo
    {
        List<PersonCreditHeaderModel> PersonCreditsList();
        PersonCreditHeaderModel PersonCreditGet(PersonModel person);
        List<PersonCreditLogModel> PersonCreditLogRead(string person);
        List<PayoutTransactionModel> PayoutList(DateTime date);
    }
}
