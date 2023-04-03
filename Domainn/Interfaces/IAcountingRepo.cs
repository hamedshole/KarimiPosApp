using Shared.Model;

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
