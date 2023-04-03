using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface IMain<TModel> where TModel : class
    {
        string Insert(TModel model);
        string Update(TModel model);
        string Delete(TModel model);
        TModel Get(string title);
        List<TModel> Search(string text);
        List<TModel> List(string text = null);
    }
}
