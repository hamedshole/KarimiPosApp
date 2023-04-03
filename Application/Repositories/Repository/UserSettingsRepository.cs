using Domain.Interfaces;
using Shared.Model;

namespace Application.Repositories.Repository
{
    internal class UserSettingsRepository : IUserSettings
    {
        private readonly IUserSettings repository;

        public UserSettingsRepository(IUserSettings repository)
        {
            this.repository = repository;
        }

        UserSettingsModel IUserSettings.Get(UserSettingsModel model)
        {
            var res = repository.Get(model);
            return res;
        }

        string IUserSettings.Insert(UserSettingsModel model)
        {
            var res = repository.Insert(model);
            return res;
        }
    }
}
