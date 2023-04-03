using Domain.Interfaces;
using Shared.Model;

namespace Application.Repositories.Repository
{
    internal class UserRoleRepository : MainRepository<UserRoleModel>, IUserRole
    {
        public UserRoleRepository(IUserRole repository) : base(repository)
        {
        }
    }
}
