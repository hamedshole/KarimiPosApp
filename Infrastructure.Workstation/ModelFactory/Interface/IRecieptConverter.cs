using Arvin.Model;
using Shared.Model;
using System.Collections.Generic;

namespace Infrastructure.Workstation.ModelFactory.Interface
{
    public interface IRecieptConverter
    {
        ReceiptModel ToDb(netReceiptHeader receiptHeader, IList<netReceiptDetail> receiptDetails);


    }
}
