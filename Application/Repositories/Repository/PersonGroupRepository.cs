using Domain.Interfaces;
using Shared.Model;

namespace Application.Repositories.Repository
{
    internal class PersonGroupRepository : MainRepository<PersonGroupModel>, IPersonGroup
    {
        public PersonGroupRepository(IPersonGroup repository) : base(repository)
        {
        }
    }
}
