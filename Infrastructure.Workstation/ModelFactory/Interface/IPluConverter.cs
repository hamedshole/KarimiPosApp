using Arvin.Model;
using Shared.Model;
using System.Collections.Generic;
using WorkStation = Arvin.Net.Workstation;


namespace Infrastructure.Workstation.ModelFactory.Interface
{
    public interface IPluConverter
    {
        List<PluModel> ToDb(List<netPLU> netPLUs, WorkStation workStation);
        List<netPLU> ItemToArvinPlu(List<ItemModel> items);
    }
}
