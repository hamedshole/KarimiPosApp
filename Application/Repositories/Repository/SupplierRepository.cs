using Domain.Interfaces;
using Shared.Model;

namespace Application.Repositories.Repository
{
    internal class SupplierRepository : MainRepository<SupplierAgentModel>, ISupplier
    {
        public SupplierRepository(ISupplier repository) : base(repository)
        {
        }
    }
}
