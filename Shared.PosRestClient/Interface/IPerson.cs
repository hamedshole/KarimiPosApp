using Shared.Model;

namespace KarimiApp.Interface.Client
{
    public interface IPerson:IMainRepository<PersonModel>
    {
        string Settle(PersonModel person);
    }
}
