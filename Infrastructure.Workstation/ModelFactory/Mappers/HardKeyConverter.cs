using Infrastructure.Workstation.ModelFactory.Interface;
using Shared.Model;
using System.Collections.Generic;

namespace Infrastructure.Workstation.ModelFactory.Mappers
{
    public class HardKeyConverter : IHardKeyConverter
    {
        List<int> IHardKeyConverter.HardKeyToNet(List<HardwareKeyModel> hardwareKeys)
        {
            List<int> result = new List<int>(70);
            foreach (var item in hardwareKeys)
            {
                result.Add(item.Item.Memory);
            }
            return result;
        }
    }
}
