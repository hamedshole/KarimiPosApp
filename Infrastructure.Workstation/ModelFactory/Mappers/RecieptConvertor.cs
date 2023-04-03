using Arvin.Model;
using Infrastructure.Workstation.ModelFactory.Interface;
using Shared.Model;
using System.Collections.Generic;

namespace Infrastructure.Workstation.ModelFactory.Mappers
{
    internal class RecieptConverter : IRecieptConverter
    {
        ReceiptModel IRecieptConverter.ToDb(netReceiptHeader receiptHeader, IList<netReceiptDetail> receiptDetails)
        {
            // System.IO.File.WriteAllText("d://h.txt", JsonConvert.SerializeObject(receiptDetails[0]));
            ReceiptModel receipt = new ReceiptModel(
                total: receiptHeader.Total_amounts,
                department: receiptHeader.Gorfeh_name,
                time: receiptHeader.Receipt_time,
                receiptNumber: receiptHeader.Receipt_no.ToString(),
                serialNumber: receiptHeader.Serial_no.ToString(),
                workstation: receiptHeader.Workstation_number.ToString()
                );
            List<ReceiptEntryModel> items = RecieptDetailToDb(receiptDetails);
            receipt.SetEntries(items);
            return receipt;
        }

        private static List<ReceiptEntryModel> RecieptDetailToDb(IList<netReceiptDetail> receiptDetails)
        {
            List<ReceiptEntryModel> items = new List<ReceiptEntryModel>();
            foreach (var item in receiptDetails)
            {
                if (item.Product_id == -1 && item.Unit == 81)
                {
                    ReceiptEntryModel tmpitemCount = new ReceiptEntryModel(amount: item.Weight_quantity,
                        unitPrice: item.Price,
                        item: new ItemModel(2));
                    items.Add(tmpitemCount);
                }
                else if (item.Product_id == -1 && item.Unit == 87)
                {
                    ReceiptEntryModel receiptEntry = new ReceiptEntryModel(amount: item.Weight_quantity,
                        unitPrice: item.Price,
                        item: new ItemModel(1));
                    items.Add(receiptEntry);
                }
                else
                {
                    ReceiptEntryModel receiptEntry = new ReceiptEntryModel(amount: item.Weight_quantity,
                        unitPrice: item.Price,
                        item: new ItemModel(item.Product_id));
                    items.Add(receiptEntry);
                }

            }

            return items;
        }
    }
}
