using Arvin.Net;
using Domain.Interfaces;
using Infrastructure.Workstation.ModelFactory;
using Shared.Model;
using System;
using System.Collections.Generic;
using ArvinWorkstation = Arvin.Net.Workstation;
using Plu = Arvin.Model.netPLU;

namespace Infrastructure.Workstation
{
    internal class WorkstationAccess : IWorkstationAccess
    {
        private List<ArvinWorkstation> _activeWorkstations;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IModelFactory _modelFactory;
        public WorkstationAccess(IModelFactory modelFactory,IUnitOfWork unitOfWork )
        {
            _unitOfWork = unitOfWork;
            _modelFactory = modelFactory;
            List<WorkstationModel> workstations = _unitOfWork.Workstation.List();
            _activeWorkstations = new   List<ArvinWorkstation>();
            workstations.ForEach(x => _activeWorkstations.Add(_modelFactory.WorkStation.Start(x)));
        }
        public string SendHardKey(WorkstationHardKeyModel workstationHardKey)
        {
            try
            {
                ArvinWorkstation tmp = this._activeWorkstations.Find(x => x.IPAddress == workstationHardKey.IpAddress);
                CommandResult cr = new CommandResult();
                tmp.StopReadingInvoice();
                tmp.SendEnableMemoryMap();
                List<int> keys = new List<int>();
                foreach (var item in workstationHardKey.HardKeys)
                {
                    if (item == null)
                    {
                        keys.Add(0);
                    }
                    else
                    {
                        keys.Add(item.Item.Memory);
                    }

                }
                cr = tmp.SendMemoryMap(keys);
                List<int> keysint = new List<int>();
                foreach (var item in workstationHardKey.HardKeys)
                {
                    if (item != null)
                    {
                        keysint.Add(item.Item.Memory);
                    }
                    else
                    {
                        keysint.Add(0);
                    }
                }
                cr = tmp.SendMemoryMap(keysint);
                tmp.StartReadingInvoice();
                if (cr.ToString() == "OK")
                {
                    string s = _unitOfWork.HardWarekey.Delete(new HardwareKeyModel(workstationHardKey.IpAddress));
                    foreach (var hardkey in workstationHardKey.HardKeys)
                    {

                        if (hardkey != null)
                        {
                            _unitOfWork.HardWarekey.Insert(hardkey);
                        }
                        //  index++;
                    }

                }


                return "h";
            }
            catch (Exception e)
            {

                return e.Message;
            }
        }
        public string SendMessage(WorkStationMessageModel workStationMessage)
        {
            try
            {
                ArvinWorkstation tmp = this._activeWorkstations.Find(x => x.IPAddress == workStationMessage.Ip);
                CommandResult cr = new CommandResult();
                if (tmp.WorkstationStatus != WorkstationStatus.Unavailable)
                {
                    tmp.StopReadingInvoice();
                    cr = tmp.SendMessage(workStationMessage.Message, workStationMessage.Title, workStationMessage.Duration, workStationMessage.CloseByKey, workStationMessage.Beep);
                    tmp.StartReadingInvoice();
                }
                return cr.ToString() + " " + tmp.WorkstationStatus + " " + tmp.IPAddress.ToString() + workStationMessage.Ip;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public string SendPlu(WorkstationPluModel workstationPlu)
        {
            try
            {
                ArvinWorkstation tmpws = this._activeWorkstations.Find(x => x.IPAddress == workstationPlu.Ip);
                tmpws.StopReadingInvoice();
                CommandResult cr = new CommandResult();
                int count = 0;
                CommandResult res = new CommandResult();
                if (tmpws.WorkstationStatus != WorkstationStatus.Unavailable)
                {
                    tmpws.StopReadingInvoice();
                    List<ItemModel> items = this._unitOfWork.Item.List();
                    List<Plu> tmpPlus = this._modelFactory.Plu.ItemToArvinPlu(items);
                    res = tmpws.SendPLUAll(tmpPlus, out count);
                }
                tmpws.StartReadingInvoice();
                return res.ToString() + "\n" + cr.ToString() + "\n" + count.ToString();
            }
            catch (Exception e)
            {

                return e.Message;
            }
        }
    }
}
