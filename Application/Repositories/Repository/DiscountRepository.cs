using Application.Repositories;
using Domain.Interfaces;
using Shared.Model;

namespace Application.Repositories.Repository
{
    public class DiscountRepository : MainRepository<DiscountModel>, IDiscount
    {
        public DiscountRepository(IDiscount repository) : base(repository)
        {
        }
    }
}
