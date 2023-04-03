using Infrastructure.Workstation.ModelFactory.Interface;
using Infrastructure.Workstation.ModelFactory.Mappers;

namespace Infrastructure.Workstation.ModelFactory
{
    public class ModelUnit : IModelFactory
    {
        private IWorkStationConverter _WorkStation;
        private IRecieptConverter _Reciept;
        private IPluConverter _Plu;
        private IHardKeyConverter _HardKey;

        public IWorkStationConverter WorkStation
        {
            get
            {
                if (_WorkStation == null)
                {
                    _WorkStation = new WorkStationConverter();
                }
                return _WorkStation;
            }
        }

        public IRecieptConverter Reciept
        {
            get
            {
                if (_Reciept == null)
                {
                    _Reciept = new RecieptConverter();
                }
                return _Reciept;
            }
        }

        public IPluConverter Plu
        {
            get
            {
                if (_Plu == null)
                {
                    _Plu = new PluConverter();
                }
                return _Plu;
            }
        }
        public IHardKeyConverter HardKey
        {
            get
            {
                if (_HardKey == null)
                {
                    _HardKey = new HardKeyConverter();
                }
                return _HardKey;
            }
        }
    }
}
