using System.Collections.Generic;

namespace KarimiApp.Interface.Client
{
    public  interface IBaseTransaction<TModel>
    {
        string Insert(TModel model);
        List<TModel> Search(string text);
        string Delete(TModel model);
    }
}
