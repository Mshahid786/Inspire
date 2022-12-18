using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace Inspire.Erp.Domain.Enums
{
    public enum PriorityLevel
    {
        None,
        Low,
        Medium,
        High
    }
    public enum DbStatus
    {
        inserted,
        updated,
        deleted,
        alreadyexist,
        failed,
        successfull
    }
    public static class VoucherType
    {
        public static String Payment { get { return "PAYMENT"; } }
        public static string Receipt { get { return "RECEIPT"; } }
    }

    public static class AccountStatus
    {
        public static String Approved { get { return "A"; } }
        public static String Pending { get { return "P"; } }

        public static String StockAccountNumber { get { return "STOCK_AC_NO"; } }
        public static String ExpenseAccountNo { get { return "EXPENSES_AC_NO"; } }
    }

    public static class Prefix
    {
        public static String PV_Prefix { get { return "PV_PREFIX"; } }
        public static String RV_Prefix { get { return "RV_PREFIX"; } }
    }

    public static class ItemMasterStatus {
        public static String Group { get { return "G"; } }
        public static String Item { get { return "I"; } }
    }

}
