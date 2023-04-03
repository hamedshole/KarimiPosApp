using Shared.Model;
using System.Collections.Generic;

namespace Infrastructure.Workstation.ModelFactory.Interface
{
    public interface IHardKeyConverter
    {
        List<int> HardKeyToNet(List<HardwareKeyModel> hardwareKeys);
    }
}
