using Domain.Interfaces;
using Shared.Model;

namespace Application.Repositories.Repository
{
    internal class SupplierCompanyRepository : MainRepository<SupplierCompanyModel>, ISupplierCompany
    {
        public SupplierCompanyRepository(ISupplierCompany repository) : base(repository)
        {
        }
    }
}
