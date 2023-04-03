using Shared.Model;
using System;
using System.Collections.Generic;

namespace KarimiApp.Interface.Client
{

    public interface IAcounting 
    {
        List<PayoutTransactionModel> PayoutList(DateTime date);
        List<PersonCreditHeaderModel> PersonCreditList();
    }

}