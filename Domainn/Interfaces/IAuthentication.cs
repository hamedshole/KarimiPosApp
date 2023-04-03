using Shared.Model;

namespace Domain.Interfaces
{
    public interface IAuthentication
    {
        UserModel Login(UserModel user);
        UserSettingsModel GetUserSettings(UserRoleModel userRole);
    }
}
