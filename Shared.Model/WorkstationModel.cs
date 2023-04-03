namespace Shared.Model
{
    public class WorkstationModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Department { get; set; }
        public string IpAddress { get; set; }
        public int PortNumber { get; set; }
        public long LastTotalPrice { get; set; }
        public WorkstationModel()
        {

        }

        public WorkstationModel(string title, string department, string ipAddress, int portNumber)
        {
            Title = title;
            Department = department;
            IpAddress = ipAddress;
            PortNumber = portNumber;
        }
        public WorkstationModel(int id, string title, string department, string ipAddress, int portNumber)
        {
            Id = id;
            Title = title;
            Department = department;
            IpAddress = ipAddress;
            PortNumber = portNumber;
        }

        public WorkstationModel(int id, string title, string department, string ipAddress, int portNumber, long lastTotalPrice)
        {
            Id = id;
            Title = title;
            Department = department;
            IpAddress = ipAddress;
            PortNumber = portNumber;
            LastTotalPrice = lastTotalPrice;
        }
    }
}
