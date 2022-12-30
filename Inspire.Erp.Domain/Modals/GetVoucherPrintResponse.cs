using System;
using System.Collections.Generic;
using System.Text;

namespace Inspire.Erp.Domain.Modals
{
    public class GetVoucherPrintResponse
    {
        public string AccountsTransactions_VoucherType { get; set; }
        public string AccountsTransactions_VoucherNo { get; set; }
       // public string AccountsTransactions_AccNo { get; set; }
        public string MA_AccName { get; set; }
        public string AccountsTransactions_Particulars { get; set; }
        public decimal AccountsTransactions_Debit { get; set; }
        public decimal Accountstransactions_Credit { get; set; }
    }
}
