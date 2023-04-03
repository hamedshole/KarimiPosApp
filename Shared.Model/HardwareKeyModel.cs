using System;

namespace Shared.Model
{
    public class HardwareKeyModel
    {
        public int Id { set; get; }
        public string Workstation { set; get; }
        public int Key { get; set; }
        public int ItemMemory { get; set; }
        public ItemModel Item { set; get; }
        public HardwareKeyModel()
        {

        }
        public HardwareKeyModel(int key, int memory)
        {
            Key = 0;
            Item = new ItemModel { Memory = memory };
        }
        public HardwareKeyModel(string workstation)
        {
            Workstation = workstation;
        }
        public HardwareKeyModel(string workstation, int key, ItemModel item)
        {
            Workstation = workstation;
            Key = key;
            Item = item;
        }

        public HardwareKeyModel(int id, string workstation, int key, ItemModel item)
        {
            Id = id;
            Workstation = workstation;
            Key = key;
            Item = item;
        }

        public HardwareKeyModel(int pluid, ItemModel item, string key, string workstation)
        {
            Item = item;
            Key = Convert.ToInt32(key);
            Workstation = workstation;
        }

        public HardwareKeyModel(int id, string workstation, int key)
        {
            Id = id;
            Workstation = workstation;
            Key = key;
        }
    }
}
