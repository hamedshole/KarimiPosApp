using Domain.Interfaces;
using Shared.Model;

namespace Application.Repositories.Repository
{
    internal class PaymentMethodRepository : MainRepository<PaymentMethodModel>, IPaymentMethod
    {
        public PaymentMethodRepository(IPaymentMethod repository) : base(repository)
        {
        }
    }
}
