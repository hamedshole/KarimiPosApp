namespace Shared.Model
{
    public class PersonGroupModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public PersonGroupModel()
        {

        }
        /// <summary>
        /// constructor to create new persongroup
        /// </summary>
        /// <param name="code"></param>
        /// <param name="description"></param>
        /// <param name="active"></param>
        public PersonGroupModel(string title, string description, bool active)
        {
            Title = title;
            Description = description;
            Active = active;
        }

        /// <summary>
        /// constructor to update persongroup and read all data
        /// </summary>
        /// <param name="id"></param>
        /// <param name="code"></param>
        /// <param name="description"></param>
        /// <param name="active"></param>
        public PersonGroupModel(int id, string title, string description, bool active)
        {
            Id = id;
            Title = title;
            Description = description;
            Active = active;
        }
    }
}
