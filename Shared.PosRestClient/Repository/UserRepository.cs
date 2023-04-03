using KarimiApp.Client.Repository.Util;
using KarimiApp.Interface.Client;
using Shared.Model;

namespace KarimiApp.Client.Repository.Repository
{
    internal class UserRepository : MainRepository<UserModel>,IUser
    {
        public UserRepository(HttpClientAccess httpClient) : base("user",httpClient)
        {
        }

      

    }
}
