using Inspire.Erp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inspire.Erp.Domain.Modals
{
    public class StatementOfAccountsDetailResponse
    {
        public string AccountsTransactions_AccNo { get; set; }
        public DateTime AccountsTransactions_TransDate { get; set; }  
        public string AccountsTransactions_Particulars  { get; set; }
        public double AccountsTransactions_Debit { get; set; }
        public double AccountsTransactions_Credit { get; set; }
        public string AccountsTransactions_VoucherType { get; set; }
        public string AccountsTransactions_VoucherNo { get; set; }
        public string AccountsTransactions_Description { get; set; }    
        public string AccountsTransactions_FSNo { get; set; }
        public string CostCenter { get; set; }
    }
}
