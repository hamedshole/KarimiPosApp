using Infrastructure.Workstation.ModelFactory.Interface;

namespace Infrastructure.Workstation.ModelFactory
{
    public interface IModelFactory
    {
        IHardKeyConverter HardKey { get; }
        IPluConverter Plu { get; }
        IRecieptConverter Reciept { get; }
        IWorkStationConverter WorkStation { get; }
    }
}