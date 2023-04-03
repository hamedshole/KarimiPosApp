using KarimiApp.Client.Repository.Util;
using KarimiApp.Interface.Client;
using Shared.Model;

namespace KarimiApp.Client.Repository.Repository
{
    internal class PaymentTypeRepository : MainRepository<PaymentTypeModel>,IPaymentType
    {
        public PaymentTypeRepository(HttpClientAccess httpClient) : base("paymenttype",httpClient)
        {
        }

      
    }
}
