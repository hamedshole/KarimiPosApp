using Domain.Interfaces;
using Shared.Model;

namespace Application.Repositories.Repository
{
    internal class InventoryGroupRepository : MainRepository<InventoryGroupModel>, IInventoryGroup
    {
        public InventoryGroupRepository(IInventoryGroup repository) : base(repository)
        {
        }
    }
}
