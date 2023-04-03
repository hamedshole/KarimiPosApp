using Shared.Model;
using System.Collections.Generic;

namespace KarimiApp.Interface.Client
{
    public interface IHardwareKey
    {
        string Create(HardwareKeyModel model);
        string Update(HardwareKeyModel model);
        string Delete(HardwareKeyModel model);
        List<HardwareKeyModel> List(HardwareKeyModel model);
        List<HardwareKeyModel> Search(HardwareKeyModel model);
    }
}
