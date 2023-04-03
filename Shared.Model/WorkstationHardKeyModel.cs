namespace Shared.Model
{
    public class WorkstationHardKeyModel
    {
        public string IpAddress { get; set; }
        public string Workstation { get; set; }
        // public int[] HardKeys { get; set; }
        public HardwareKeyModel[] HardKeys { get; set; }
        public WorkstationHardKeyModel(string ipAddress, HardwareKeyModel[] hardKeys, string workstation)
        {
            Workstation = workstation;
            IpAddress = ipAddress;
            HardKeys = hardKeys;
        }

        public WorkstationHardKeyModel()
        {
        }
    }
}
