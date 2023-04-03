using KarimiApp.Client.Repository.Util;
using KarimiApp.Interface.Client;
using Shared.Model;

namespace KarimiApp.Client.Repository.Repository
{
    internal class UserRoleRepository : MainRepository<UserRoleModel>,IUserRole
    {
        public UserRoleRepository(HttpClientAccess httpClient) : base("userrole",httpClient)
        {
        }
    }
}
