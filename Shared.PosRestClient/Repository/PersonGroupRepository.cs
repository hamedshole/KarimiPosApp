using KarimiApp.Client.Repository.Util;
using KarimiApp.Interface.Client;
using Shared.Model;

namespace KarimiApp.Client.Repository.Repository
{
    internal class PersonGroupRepository : MainRepository<PersonGroupModel>, IPersonGroup
    {
        public PersonGroupRepository(HttpClientAccess httpClient) : base("persongroup",httpClient)
        {
        }

      
    }
}
