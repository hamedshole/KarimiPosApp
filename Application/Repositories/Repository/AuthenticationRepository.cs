using Domain.Interfaces;
using Shared.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories.Repository
{
    internal class AuthenticationRepository : IAuthentication
    {
        IAuthentication repository;

        public AuthenticationRepository(IAuthentication repository)
        {
            this.repository = repository;
        }

        UserSettingsModel IAuthentication.GetUserSettings(UserRoleModel userRole)
        {
            return repository.GetUserSettings(userRole);
        }


        UserModel IAuthentication.Login(UserModel user)
        {
            return repository.Login(user);
        }
    }
}
