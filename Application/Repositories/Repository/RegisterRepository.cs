using Domain.Interfaces;
using Shared.Model;

namespace Application.Repositories.Repository
{
    internal class RegisterRepository : MainRepository<RegisterModel>, IRegister
    {
        public RegisterRepository(IRegister repository) : base(repository)
        {
        }
    }
}
