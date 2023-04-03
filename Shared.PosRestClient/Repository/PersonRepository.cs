using KarimiApp.Client.Repository.Util;
using KarimiApp.Interface.Client;
using Shared.Model;
using System.Threading.Tasks;

namespace KarimiApp.Client.Repository.Repository
{
    internal class PersonRepository : MainRepository<PersonModel>,IPerson
    {
      private  HttpClientAccess httpClient;
        private string _route = "person";
        public PersonRepository(HttpClientAccess httpClient) : base("person",httpClient)
        {
            this.httpClient = httpClient;
        }

      

        string IPerson.Settle(PersonModel person)
        {
            string result = Task.Run(async () => await this.httpClient.PostReturnString(person, _route + "/settle")).Result;
            return result;
        }
    }
}
