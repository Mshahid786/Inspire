using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Inspire.Erp.Application.StatementOfAccounts.Interface
{
    public interface IStatementOfAccountsDetail
    {
        public Task<dynamic> GetAccountStatementDetails(DateTime StartDate, DateTime EndDate,string @AcNo,string Description,string @Particulars,string JobNo);
    }
}
