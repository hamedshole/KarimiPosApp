using KarimiApp.Client.Repository.Util;
using KarimiApp.Interface.Client;
using Shared.Model;
using System.Threading.Tasks;

namespace KarimiApp.Client.Repository.Repository
{
    internal class AuthenticationRepository : IAuthentication
    {
        private HttpClientAccess httpClient;
        private string _route = "authentication";

        public AuthenticationRepository(HttpClientAccess httpClient)
        {
            this.httpClient = httpClient;
        }

       async Task<UserModel> IAuthentication.Login(string username, string password)
        {
            return await httpClient.Post<UserModel, UserModel>(new UserModel(username: username, password: password), _route + "/login").ConfigureAwait(false);
        }
    }
}
