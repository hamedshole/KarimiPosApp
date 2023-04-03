using Domain.Interfaces;
using Shared.Model;

namespace Application.Repositories.Repository
{
    internal class ItemRepository : MainRepository<ItemModel>, IItem
    {
        IItem repository;
        public ItemRepository(IItem repository) : base(repository)
        {
            this.repository = repository;
        }

        List<ItemModel> IItem.FilterByDepartment(string department)
        {
            return repository.FilterByDepartment(department);
        }

        ReceiptEntryModel IItem.GetByBarcode(string barcode)
        {
            return repository.GetByBarcode(barcode);
        }

        List<ItemModel> IItem.SearchFilterByDepartment(ItemModel item)
        {
            return repository.SearchFilterByDepartment(item);
        }
    }
}
