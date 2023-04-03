namespace Shared.Model
{
    public class PaymentTypeModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Active { get; set; }
        public PaymentTypeModel()
        {

        }
        public PaymentTypeModel(string title)
        {
            Title = title;
        }

        public PaymentTypeModel(string title, bool active)
        {
            Title = title;
            Active = active;
        }

        public PaymentTypeModel(int id, string title, bool active)
        {
            Id = id;
            Title = title;
            Active = active;
        }
    }
}
