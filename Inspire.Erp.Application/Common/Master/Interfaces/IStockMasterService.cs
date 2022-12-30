using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Inspire.Erp.Application.Master.Interfaces
{
    public interface IStockMasterService
    {
        public string getStockLedgerReport();
        public string getFilteredStockLedgerRpt();
    }
}
