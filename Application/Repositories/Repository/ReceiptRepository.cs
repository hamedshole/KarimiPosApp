using Domain.Interfaces;
using Shared.Model;
using System;
using System.Collections.Generic;

namespace Application.Repositories.Repository
{
    internal class ReceiptRepository : IReceipt
    {
        IReceiptRepo repository;

        public ReceiptRepository(IReceiptRepo repository)
        {
            this.repository = repository;
        }

        List<ReceiptModel> IReceipt.CashierList()
        {
            return repository.CashierList();
        }

        ReceiptModel IReceipt.Get(string barcode)
        {
            try
            {
                ReceiptModel receipt = new ReceiptModel();


                receipt = repository.Get(barcode);

                if (receipt == null)
                {
                    List<ReceiptEntryModel> receiptEntries = new List<ReceiptEntryModel>();
                    var item = repository.ItemByBarcode(barcode);
                    if (item == null)
                    {
                        throw new Exception("چنین فیش یا کالایی در سیستم ثبت نشده است");
                    }
                    receiptEntries.Add(item);
                    receipt = new ReceiptModel();
                    receipt.Entries = receiptEntries;
                }
                else
                {
                    receipt.Entries = repository.ReceiptItemsRead(receipt.Id);
                }

                return receipt;
            }
            catch (Exception)
            {
                throw;
            }

        }

        string IReceipt.Insert(ReceiptModel receipt)
        {
            string msg = repository.Insert(receipt);
            receipt.Entries.ForEach(x => repository.InsertItem(x));
            return msg;
        }



        List<ReceiptModel> IReceipt.List(WorkstationReceiptFilterModel workstationReceiptFilter)
        {
            List<ReceiptModel> receipt = repository.List(workstationReceiptFilter);
            // receipt.ForEach(x => { x.SetEntries(repository.ReceiptItemsRead(x.Id));x.Transaction = this.GetTransactions(x.Id); }) ;
            return receipt;
        }
        private TransactionModel GetTransactions(int receipt)
        {
            TransactionModel transactionResult = repository.GetTransaction(receipt);
            transactionResult.Entries = repository.GetTransactionItems(transactionResult.Id);
            return transactionResult;
        }

        TransactionModel IReceipt.GetTransaction(int id)
        {
            TransactionModel transaction = repository.GetTransaction(id);
            transaction.Entries = repository.GetTransactionItems(id);
            return transaction;
        }
    }
}
