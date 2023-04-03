using KarimiApp.Client.Repository.Util;
using KarimiApp.Interface.Client;
using Shared.Model;

namespace KarimiApp.Client.Repository.Repository
{
    internal class SupplierCompanyRepository : MainRepository<SupplierCompanyModel>, ISupplierCompany
    {
        public SupplierCompanyRepository(HttpClientAccess httpClient) : base("suppliercompany", httpClient)
        {
        }

    
    }
}
