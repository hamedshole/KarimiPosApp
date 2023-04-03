using System;
using System.Collections.Generic;

namespace Shared.Model
{
    public class ReceiptModel
    {
        public int Id { get; set; }
        public string Workstation { get; set; }
        public string Department { get; set; }
        public string SerialNumber { get; set; }
        public string ReceiptNumber { get; set; }
        public DateTime Time { get; set; }
        public string Barcode { get; set; }
        public bool Scanned { get; set; }
        public long Total { get; set; }
        public int Transaction { get; set; }
        public string Status { get; set; }

        public List<ReceiptEntryModel> Entries { get; set; }

        public ReceiptModel()
        {

        }

        public ReceiptModel(long total, string workstation, string department, string serialNumber, string receiptNumber, DateTime time)
        {
            Total = total;
            Workstation = workstation;
            Department = department;
            SerialNumber = serialNumber;
            ReceiptNumber = receiptNumber;
            Time = time;
        }

        public ReceiptModel(string workstation, string department, string serialNumber, string receiptNumber, DateTime time)
        {
            Workstation = workstation;
            Department = department;
            SerialNumber = serialNumber;
            ReceiptNumber = receiptNumber;
            Time = time;
        }

        public ReceiptModel(int id, string workstation, string department, string serialNumber, string receiptNumber, DateTime time, string barcode, bool scanned, long total)
        {
            Id = id;
            Time = time;
            Workstation = workstation;
            Department = department;
            SerialNumber = serialNumber;
            ReceiptNumber = receiptNumber;
            Barcode = barcode;
            Scanned = scanned;
            Total = total;
        }

        public ReceiptModel(string title, DateTime time)
        {
            Workstation = title;
            Time = time;
        }

        public void SetEntries(List<ReceiptEntryModel> receiptEntries)
        {
            Entries = receiptEntries;
        }

    }
}
