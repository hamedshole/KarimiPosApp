namespace Shared.Model
{
    public class TransactionTypeModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public TransactionTypeModel()
        {

        }

        public TransactionTypeModel(string title, string description, bool active)
        {
            Title = title;
            Description = description;
            Active = active;
        }

        public TransactionTypeModel(int id, string title, string description, bool active)
        {
            Id = id;
            Title = title;
            Description = description;
            Active = active;
        }
    }
}
