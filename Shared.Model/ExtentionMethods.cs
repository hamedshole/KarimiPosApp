using System;
using System.Collections.Generic;
using System.Globalization;

namespace Shared.Model
{
    public static class ExtentionMethods
    {
        public static string ToShamsi(this DateTime value)
        {
            PersianCalendar pc = new PersianCalendar();
            return pc.GetYear(value) + "/" + pc.GetMonth(value).ToString("00") + "/" +
                   pc.GetDayOfMonth(value).ToString("00");

        }
        public static List<TransactionEntryModel> ToTransaction(this List<ReceiptEntryModel> entries)
        {
            List<TransactionEntryModel> transactionEntries = new List<TransactionEntryModel>();
            entries.ForEach(x => transactionEntries.Add(convertToTransaction(x)));
            TransactionEntryModel convertToTransaction(ReceiptEntryModel receiptEntry)
            {
                return new TransactionEntryModel(amount: receiptEntry.Amount, sellprice: receiptEntry.UnitPrice, item: receiptEntry.Item.Name, itemId: receiptEntry.Item.Id);
            }
            return transactionEntries;
        }
        public static TransactionEntryModel ToTransaction(this ReceiptEntryModel entries)
        {
            TransactionEntryModel transactionEntry = new TransactionEntryModel();
            if (entries.Item != null)
            {
                transactionEntry = new TransactionEntryModel(amount: entries.Amount, sellprice: entries.UnitPrice, item: entries.Item.Name, itemId: entries.Item.Id);
                return transactionEntry;
            }
            else
            {
                return null;
            }
        }
        public static long Round(this decimal i)
        {

            return Convert.ToInt64(Math.Floor(i.ToLong() / 500.0) * 500.0);


        }
        public static long ToLong(this decimal i)
        {
            return Convert.ToInt64(i);
        }
        public static int ToInt(this object str)
        {
            return Convert.ToInt32(str);
        }
    }
}
