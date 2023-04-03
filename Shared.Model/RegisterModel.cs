namespace Shared.Model
{
    public class RegisterModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ComputerName { get; set; }
        public string IpAddress { get; set; }
        public string MacAddress { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public RegisterModel()
        {

        }
        public RegisterModel(string title)
        {
            Title = title;
        }

        public RegisterModel(string title, string computerName, string ipAddress, string macAddress, string description, bool active)
        {
            Title = title;
            ComputerName = computerName;
            IpAddress = ipAddress;
            MacAddress = macAddress;
            Description = description;
            Active = active;
        }

        public RegisterModel(int id, string title, string computerName, string ipAddress, string macAddress, string description, bool active)
        {
            Id = id;
            Title = title;
            ComputerName = computerName;
            IpAddress = ipAddress;
            MacAddress = macAddress;
            Description = description;
            Active = active;
        }
    }
}
