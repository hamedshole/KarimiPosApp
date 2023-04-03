using Application.Repositories;
using Domain.Interfaces;
using Shared.Model;

namespace Application.Repositories.Repository
{
    internal class ItemCategoryRepository : MainRepository<ItemCategoryModel>, IItemCategory
    {
        public ItemCategoryRepository(IItemCategory repository) : base(repository)
        {
        }
    }
}
