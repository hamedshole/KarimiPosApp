using Shared.Model;
using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface IBatch
    {
        string Close(BatchModel model);
        List<BatchModel> Getall();
    }
}
