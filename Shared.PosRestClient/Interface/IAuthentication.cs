using Shared.Model;
using System.Threading.Tasks;

namespace KarimiApp.Interface.Client
{
    public interface IAuthentication
    {
        Task<UserModel> Login(string username, string password);
    }
}
