namespace Shared.Model
{
    public class SupplierCompanyModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public SupplierCompanyModel()
        {

        }

        public SupplierCompanyModel(string name, bool active)
        {
            Name = name;
            Active = active;
        }

        public SupplierCompanyModel(int id, string name, bool active)
        {
            Id = id;
            Name = name;
            Active = active;
        }
    }
}
