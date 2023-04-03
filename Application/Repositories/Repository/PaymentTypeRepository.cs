using Domain.Interfaces;
using Shared.Model;

namespace Application.Repositories.Repository
{
    internal class PaymentTypeRepository : MainRepository<PaymentTypeModel>, IPaymentType
    {
        public PaymentTypeRepository(IPaymentType repository) : base(repository)
        {
        }
    }
}
