using Domain.Interfaces;

namespace Application.Repositories
{
    public class MainRepository<TModel> : IMain<TModel> where TModel : class
    {
        private readonly IMain<TModel> repository;
        //  private readonly IDb dbaccess;
        public MainRepository(IMain<TModel> repository)
        {
            this.repository = repository;
        }

        string IMain<TModel>.Insert(TModel model)
        {
            var res = repository.Insert(model);
            return res;
        }

        string IMain<TModel>.Update(TModel model)
        {
            var res = repository.Update(model);
            return res;
        }

        string IMain<TModel>.Delete(TModel model)
        {
            var res = repository.Delete(model);
            return res;
        }

        TModel IMain<TModel>.Get(string model)
        {
            var res = repository.Get(model);
            return res;
        }

        List<TModel> IMain<TModel>.Search(string model)
        {
            var res = repository.Search(model);
            return res;
        }

        List<TModel> IMain<TModel>.List(string model)
        {
            var res = repository.List(model);
            return res;
        }


    }
}
