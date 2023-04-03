using Infrastructure.Workstation.ModelFactory.Interface;
using Shared.Model;
using System;
using WorkStation = Arvin.Net.Workstation;

namespace Infrastructure.Workstation.ModelFactory.Mappers
{

    internal class WorkStationConverter : IWorkStationConverter
    {
        WorkStation IWorkStationConverter.Start(WorkstationModel workStation)
        {
            WorkStation result = new WorkStation();
            result.Start(workStation.IpAddress, Convert.ToInt32(workStation.PortNumber));
            result.StartReadingInvoice();
            return result;
        }
    }
}
