using Application.Repositories;
using Domain.Interfaces;
using Infrastructure.Workstation.ModelFactory;
using Shared.Model;




namespace Application.Repositories.Repository
{
    public class WorkstationServerRepository : IWorkstationServer
    {

        private IModelFactory _factory;
        private IUnitOfWork _unitOfWork;
        private readonly IWorkstationAccess _access;

        public WorkstationServerRepository(IModelFactory modelFactory, IUnitOfWork unitOfWork, IWorkstationAccess workstationAccess)
        {
            _access = workstationAccess;
            _factory = modelFactory;
            _unitOfWork = unitOfWork;
        }

        string IWorkstationServer.InsertReceipt(ReceiptModel receipt)
        {

            return _unitOfWork.Receipt.Insert(receipt);
        }

        string IWorkstationServer.SendHardKey(WorkstationHardKeyModel workstationHardKey)
        {
            return _access.SendHardKey(workstationHardKey);
        }

        string IWorkstationServer.SendMessage(WorkStationMessageModel workStationMessage)
        {
            return _access.SendMessage(workStationMessage);
        }

        string IWorkstationServer.SendPlu(WorkstationPluModel workstationPlu)
        {
            return _access.SendPlu(workstationPlu);
        }
        private async Task InsertPlus(List<PluModel> plus)
        {
            _unitOfWork.Plu.Delete(new PluModel(workstation: plus[0].Workstation));
            foreach (var item in plus)
            {
                await Task.Run(() => { _unitOfWork.Plu.Insert(item); }).ConfigureAwait(false);
            }
            // plus.ForEach(x =>await Task.Run(async()=> unitOfWork.Plu.Insert(x)));
        }
        long IWorkstationServer.TotalReceiptAmount(string workstation)
        {
            return _unitOfWork.Workstation.TotalReceiptAmount(workstation);
        }

        long IWorkstationServer.TotalReceiptAmountForDate(ReceiptModel receipt)
        {
            return _unitOfWork.Workstation.TotalReceiptAmountForDate(receipt);
        }

        int IWorkstationServer.TotalReceiptCount(string workstation)
        {
            return _unitOfWork.Workstation.TotalReceiptCount(workstation);
        }

        int IWorkstationServer.TotalReceiptCountForDate(ReceiptModel receipt)
        {
            return _unitOfWork.Workstation.TotalReceiptCountForDate(receipt);
        }

        List<WorkstationModel> IWorkstationServer.WorkstationList()
        {
            var list = _unitOfWork.Workstation.List();
            return list;
        }
    }
}
