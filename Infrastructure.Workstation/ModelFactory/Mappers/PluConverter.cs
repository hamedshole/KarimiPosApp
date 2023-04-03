using Arvin.Model;
using Infrastructure.Workstation.ModelFactory.Interface;
using Shared.Model;
using System;
using System.Collections.Generic;
using WorkStation = Arvin.Net.Workstation;

namespace Infrastructure.Workstation.ModelFactory.Mappers
{
    internal class PluConverter : IPluConverter
    {
        List<PluModel> IPluConverter.ToDb(List<netPLU> netPLUs, WorkStation workStation)
        {
            List<PluModel> plus = new List<PluModel>();
            foreach (var item in netPLUs)
            {
                plus.Add(NetToModel(item, workStation));
            }
            return plus;
        }
        private PluModel NetToModel(netPLU netPLU, WorkStation workStation)
        {
            return new PluModel(id: netPLU.plu_index,
                workstation: workStation.IPAddress,
                item: new ItemModel(netPLU.prod_id));
        }

        List<netPLU> IPluConverter.ItemToArvinPlu(List<ItemModel> plus)
        {
            List<netPLU> netPLUs = new List<netPLU>();
            foreach (var item in plus)
            {
                netPLUs.Add(ModelToNet(item));
            }
            return netPLUs;
        }

        private netPLU ModelToNet(ItemModel item)
        {

            netPLU net = new netPLU
            {
                prod_id = item.Id,
                barcode = item.Barcode,
                name = item.Name,
                price = Convert.ToInt32(item.SellPrice),
                purchase_price = Convert.ToInt32(item.BuyPrice),
                memory = item.Memory,

            };
            if (item.Weighed == true)
            {
                net.unit = 87;
            }
            else if (item.Weighed == false)
            {
                net.unit = 81;
            }
            return net;
        }
    }
}
