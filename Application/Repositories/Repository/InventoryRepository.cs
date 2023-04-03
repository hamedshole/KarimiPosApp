using Domain.Interfaces;
using Shared.Model;


namespace Application.Repositories.Repository
{
    internal class InventoryRepository : MainRepository<InventoryModel>, IInventory
    {
        public InventoryRepository(IInventory repository) : base(repository)
        {
        }
    }
}
