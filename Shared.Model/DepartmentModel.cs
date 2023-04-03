namespace Shared.Model
{
    public class DepartmentModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string DefaultInventory { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public DepartmentModel()
        {

        }
        public DepartmentModel(string title)
        {
            Title = title;
        }

        /// <summary>
        /// for create a new department
        /// </summary>
        /// <param name="title"></param>
        /// <param name="defaultInventory"></param>
        /// <param name="description"></param>
        /// <param name="active"></param>
        public DepartmentModel(string title, string defaultInventory, string description, bool active)
        {
            Title = title;
            DefaultInventory = defaultInventory;
            Description = description;
            Active = active;
        }

        /// <summary>
        /// for update and read all data
        /// </summary>
        /// <param name="id"></param>
        /// <param name="title"></param>
        /// <param name="defaultInventory"></param>
        /// <param name="description"></param>
        /// <param name="active"></param>
        public DepartmentModel(int id, string title, string defaultInventory, string description, bool active)
        {
            Id = id;
            Title = title;
            DefaultInventory = defaultInventory;
            Description = description;
            Active = active;
        }
    }
}
