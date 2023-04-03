using KarimiApp.Client.Repository.Util;
using KarimiApp.Interface.Client;
using Shared.Model;

namespace KarimiApp.Client.Repository.Repository
{
    internal class RegisterRepository : MainRepository<RegisterModel>, IRegister
    {
        public RegisterRepository( HttpClientAccess httpClient) : base("register", httpClient)
        {
        }

    }
}
