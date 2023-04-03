namespace Shared.Model
{
    public class InventoryGroupModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public InventoryGroupModel()
        {

        }
        public InventoryGroupModel(string title)
        {
            Title = title;
        }
        /// <summary>
        /// constructor for create new inventorygroup
        /// </summary>
        /// <param name="title"></param>
        /// <param name="dscription"></param>
        /// <param name="active"></param>
        public InventoryGroupModel(string title, string description, bool active)
        {
            Title = title;
            Description = description;
            Active = active;
        }

        /// <summary>
        /// constructor for update inventorygroup or read all data
        /// </summary>
        /// <param name="id"></param>
        /// <param name="title"></param>
        /// <param name="dscription"></param>
        /// <param name="active"></param>
        public InventoryGroupModel(int id, string title, string description, bool active)
        {
            Id = id;
            Title = title;
            Description = description;
            Active = active;
        }
    }
}
