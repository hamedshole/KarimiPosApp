using Domain.Interfaces;
using Shared.Model;
using System;
using System.Collections.Generic;

namespace Application.Repositories.Repository
{

    public class AcountingRepository : IAcounting
    {
        IAcountingRepo repository;

        public AcountingRepository(IAcountingRepo repository)
        {
            this.repository = repository;
        }

        List<PayoutTransactionModel> IAcounting.PayoutList(DateTime date)
        {
            var res = repository.PayoutList(date);
            return res;
        }

        List<PersonCreditHeaderModel> IAcounting.PersonCreditList()
        {
            List<PersonCreditHeaderModel> personCredits = new List<PersonCreditHeaderModel>();
            personCredits = repository.PersonCreditsList();
            personCredits.ForEach(x => x.Log = repository.PersonCreditLogRead(x.Name));
            return personCredits;
        }


    }
}
