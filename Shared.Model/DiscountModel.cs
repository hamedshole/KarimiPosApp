namespace Shared.Model
{
    public class DiscountModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Percent { get; set; }
        public DiscountModel()
        {

        }

        public DiscountModel(string title, int percent)
        {
            Title = title;
            Percent = percent;
        }

        public DiscountModel(int id, string title, int percent)
        {
            Id = id;
            Title = title;
            Percent = percent;
        }

    }
}