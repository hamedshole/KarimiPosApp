using Shared.Model;

namespace Domain.Interfaces
{
    public interface IAcounting
    {
        List<PayoutTransactionModel> PayoutList(DateTime date);
        List<PersonCreditHeaderModel> PersonCreditList();
    }
}
