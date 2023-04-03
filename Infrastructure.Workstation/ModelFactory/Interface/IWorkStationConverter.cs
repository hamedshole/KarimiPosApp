using Shared.Model;
using WorkStation = Arvin.Net.Workstation;

namespace Infrastructure.Workstation.ModelFactory.Interface
{
    public interface IWorkStationConverter
    {
        WorkStation Start(WorkstationModel workStation);
    }
}
