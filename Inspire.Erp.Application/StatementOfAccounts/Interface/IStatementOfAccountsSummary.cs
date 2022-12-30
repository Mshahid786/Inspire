using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Inspire.Erp.Application.StatementOfAccounts.Interface
{
    public interface IStatementOfAccountsSummary
    {
          public Task<dynamic> GetStatementOfAccountSummary(string AcNo,DateTime StartDate);
    }
}
