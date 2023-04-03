using Domain.Interfaces;
using System.Collections.Generic;

namespace Application.Repositories
{
    internal class BaseTransactionRepository<TModel> : IBaseTransaction<TModel>
    {
        private IBaseTransaction<TModel> baseTransactionRepository;

        public BaseTransactionRepository(IBaseTransaction<TModel> baseTransactionRepository)
        {
            this.baseTransactionRepository = baseTransactionRepository;
        }

        public string Delete(TModel model)
        {
            throw new NotImplementedException();
        }

        string IBaseTransaction<TModel>.Insert(TModel model)
        {
            return baseTransactionRepository.Insert(model);
        }

        //List<TModel> IBaseTransaction<TModel>.Read()
        //{
        //   return this.baseTransactionRepository.Read();
        //}

        List<TModel> IBaseTransaction<TModel>.Search(TModel model)
        {
            return baseTransactionRepository.Search(model);
        }
    }
}
