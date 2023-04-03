using System;
using System.Collections.Generic;

namespace Shared.Model
{
    //public class BatchModel
    //{
    //    public int Id { get; set; }
    //    public string User { get; set; }
    //    public string Register { get; set; }
    //    public DateTime OpenTime { get; set; }
    //    public DateTime CloseTime { get; set; }
    //    public bool Status { get; set; }
    //    public long PayoutSum { get; set; }
    //    public long TotalSell { get; set; }
    //    public long TotalVariant { get; set; }
    //    public long AccountingIn { get; set; }
    //    public long AccountingOut { get; set; }
    //    public List<BankValueModel> BankValues { get; set; }
    //    public BatchModel()
    //    {

    //    }

    //    public BatchModel(string user, string register, DateTime closeTime)
    //    {
    //        User = user;
    //        Register = register;
    //        CloseTime = closeTime;
    //    }

    //    public BatchModel(int id, string user, string register, DateTime openTime, DateTime closeTime, long payoutSum, long totalSell, long totalVariant, long accountingIn, long accountingOut, bool status)
    //    {
    //        Status = status;
    //        Id = id;
    //        User = user;
    //        Register = register;
    //        OpenTime = openTime;
    //        CloseTime = closeTime;
    //        PayoutSum = payoutSum;
    //        TotalSell = totalSell;
    //        TotalVariant = totalVariant;
    //        AccountingIn = accountingIn;
    //        AccountingOut = accountingOut;
    //    }
    //}

    public class BatchModel
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        public DateTime OpenTime { get; set; }
        public DateTime CloseTime { get; set; }
        public string BatchUser { get; set; }
        public string BatchRegister { get; set; }
        public long TotalSell { get; set; }
        public long TotalSellWithoutCredit { get; set; }
        public long Income { get; set; }
        public long SystemSum { get; set; }
        public long StorePayouts { get; set; }
        public long TotalAccountsValue { get; set; }
        public long Credit { get; set; }
        public long CashierSum { get; set; }
        public long SystemCashierVariant { get; set; }
        public List<BankValueModel> BankValues { get; set; }

        public BatchModel()
        {
        }

        public BatchModel(int id, bool status, DateTime openTime, DateTime closeTime, string batchUser, string batchRegister, long totalSell, long totalSellWithoutCredit, long income, long systemSum, long storePayouts, long totalAccountsValue, long credit, long cashierSum, long systemCashierVariant)
        {
            Id = id;
            Status = status;
            OpenTime = openTime;
            CloseTime = closeTime;
            BatchUser = batchUser;
            BatchRegister = batchRegister;
            TotalSell = totalSell;
            TotalSellWithoutCredit = totalSellWithoutCredit;
            Income = income;
            SystemSum = systemSum;
            StorePayouts = storePayouts;
            TotalAccountsValue = totalAccountsValue;
            Credit = credit;
            CashierSum = cashierSum;
            SystemCashierVariant = systemCashierVariant;
        }

        public BatchModel(string batchUser, string batchRegister, DateTime closeTime)
        {
            BatchUser = batchUser;
            BatchRegister = batchRegister;
            CloseTime = closeTime;
        }
    }
}
