using Domain.Interfaces;
using Shared.Model;

namespace Application.Repositories.Repository
{
    internal class PluRepository : MainRepository<PluModel>, IPlu
    {
        public PluRepository(IPlu repository) : base(repository)
        {
        }
    }
}
