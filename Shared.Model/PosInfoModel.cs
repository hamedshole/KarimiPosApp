namespace Shared.Model
{
    public class PosInfoModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Com { get; set; }
        public PosInfoModel()
        {

        }
        public PosInfoModel(string title)
        {
            Title = title;
        }

        public PosInfoModel(string title, int com)
        {
            Title = title;
            Com = com;
        }

        public PosInfoModel(int id, string title, int com)
        {
            Id = id;
            Title = title;
            Com = com;
        }
    }
}
