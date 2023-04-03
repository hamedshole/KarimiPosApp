namespace Shared.Model
{
    public class Permission
    {
        public string Name { get; set; }
        public bool List { get; set; }
        public bool Create { get; set; }
        public bool Modify { get; set; }
        public bool Remove { get; set; }

        public Permission(string name, bool list, bool create, bool modify, bool remove)
        {
            Name = name;
            List = list;
            Create = create;
            Modify = modify;
            Remove = remove;
        }
        public Permission(string name, bool list)
        {
            Name = name;
            List = list;
        }

        public Permission()
        {
        }

        public override string ToString()
        {
            return List.ToString() + " " + Create.ToString() + " " + Modify.ToString() + " " + Remove.ToString();
        }
    }
}
