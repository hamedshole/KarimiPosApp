using Shared.Model;

namespace Domain.Interfaces
{
    public interface IWorkstationAccess
    {
        string SendPlu(WorkstationPluModel workstationPlu);
        string SendHardKey(WorkstationHardKeyModel workstationHardKey);
        string SendMessage(WorkStationMessageModel workStationMessage);
    }
}