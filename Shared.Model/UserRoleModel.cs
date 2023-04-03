namespace Shared.Model
{
    public class UserRoleModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string CashierRibbon { get; set; }
        public string Info { get; set; }
        public bool Active { get; set; }
        public UserRoleModel()
        {

        }
        public UserRoleModel(string title)
        {
            Title = title;
        }
        /// <summary>
        /// constructor to create new userrole
        /// </summary>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="info"></param>
        /// <param name="active"></param>
        public UserRoleModel(string title, string info, string cashierRibbon, bool active = true, string description = "")
        {
            Title = title;
            CashierRibbon = cashierRibbon;
            Description = description;
            Info = info;
            Active = active;
        }


        /// <summary>
        /// constructor to update userrole and read all data
        /// </summary>
        /// <param name="id"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="info"></param>
        /// <param name="active"></param>
        public UserRoleModel(int id, string title, string info, string cashierRibbon, bool active = true, string description = "")
        {
            Id = id;
            CashierRibbon = cashierRibbon;
            Title = title;
            Info = info;
            Description = description;
            Active = active;
        }
    }

}
