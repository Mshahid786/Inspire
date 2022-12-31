using System;
using System.Collections.Generic;
using System.Text;

namespace Inspire.Erp.Domain.Modals
{
    public class StatementOfAccounts
    {
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public string Acno { get; set; }
        public string Description { get; set; }
        public string Particulars { get; set; }
        public string JobNo { get; set; }
    }
}
