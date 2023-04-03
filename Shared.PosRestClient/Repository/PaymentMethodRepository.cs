using KarimiApp.Client.Repository.Util;
using KarimiApp.Interface.Client;
using Shared.Model;

namespace KarimiApp.Client.Repository.Repository
{
    internal class PaymentMethodRepository : MainRepository<PaymentMethodModel>,IPaymentMethod
    {
        public PaymentMethodRepository(HttpClientAccess httpClient) : base("paymentmethod",httpClient)
        {
        }

      
    }
}
