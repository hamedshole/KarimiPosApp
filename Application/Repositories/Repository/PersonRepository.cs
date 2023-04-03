using Domain.Interfaces;
using Shared.Model;

namespace Application.Repositories.Repository
{
    internal class PersonRepository : MainRepository<PersonModel>, IPerson
    {
        private IPerson repository;
        public PersonRepository(IPerson repository) : base(repository)
        {
            this.repository = repository;
        }

        string IPerson.Settle(PersonModel person)
        {
            var result = repository.Settle(person);
            return result;
        }
    }
}
