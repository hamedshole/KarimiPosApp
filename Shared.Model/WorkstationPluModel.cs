using System.Collections.Generic;

namespace Shared.Model
{
    public class WorkstationPluModel
    {
        public string Ip { get; set; }
        public List<ItemModel> Items { get; set; }
        public string PlusString { get; set; }

        public WorkstationPluModel()
        {
        }

        public WorkstationPluModel(string ip, List<ItemModel> items)
        {
            Ip = ip;
            Items = items;
            //PlusString = JsonConvert.SerializeObject(items);
        }
    }
}
