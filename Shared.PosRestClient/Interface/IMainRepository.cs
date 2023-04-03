using System.Collections.Generic;

namespace KarimiApp.Interface.Client
{
    public interface IMainRepository<TModel>
    {
        string Create(TModel model);
        string Update(TModel model);
        string Delete(TModel model);
        List<TModel> List(string text="");
      
        List<TModel> Search(string model);
        TModel Get(string text);
    }
}
