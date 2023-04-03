using Shared.Model;
using System.Collections.Generic;

namespace KarimiApp.Interface.Client
{
    public interface IBatch
    {
        string Delete(BatchModel batch);
        List<BatchModel> List();
    }
}
