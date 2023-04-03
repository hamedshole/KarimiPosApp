using Application.Repositories;
using Domain.Interfaces;
using Shared.Model;

namespace Application.Repositories.Repository
{
    internal class UserRepository : MainRepository<UserModel>, IUser
    {
        public UserRepository(IUser repository) : base(repository)
        {
        }
    }
}
