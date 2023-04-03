namespace Shared.Model
{
    public class InventoryModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Keeper { get; set; }
        public string Group { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public InventoryModel()
        {

        }
        public InventoryModel(string title)
        {
            Title = title;
        }

        /// <summary>
        /// constructor for create new inventory
        /// </summary>
        /// <param name="title"></param>
        /// <param name="keeper"></param>
        /// <param name="group"></param>
        /// <param name="description"></param>
        /// <param name="active"></param>
        public InventoryModel(string title, string keeper, string group, string description, bool active)
        {
            Title = title;
            Keeper = keeper;
            Group = group;
            Description = description;
            Active = active;
        }

        /// <summary>
        /// constructor to update inventory or get all data
        /// </summary>
        /// <param name="id"></param>
        /// <param name="title"></param>
        /// <param name="keeper"></param>
        /// <param name="group"></param>
        /// <param name="description"></param>
        /// <param name="active"></param>
        public InventoryModel(int id, string title, string keeper, string group, string description, bool active)
        {
            Id = id;
            Title = title;
            Keeper = keeper;
            Group = group;
            Description = description;
            Active = active;
        }
    }
}
