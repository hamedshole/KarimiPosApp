namespace Shared.Model
{
    public class WorkStationMessageModel
    {
        public string Ip { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public int Duration { get; set; }
        public bool CloseByKey { get; set; }
        public bool Beep { get; set; }

        public WorkStationMessageModel()
        {
        }

        public WorkStationMessageModel(string ip, string title, string message, int duration, bool closeByKey, bool beep)
        {
            Ip = ip;
            Title = title;
            Message = message;
            Duration = duration;
            CloseByKey = closeByKey;
            Beep = beep;
        }
    }
}
