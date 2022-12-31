using System;
using System.Collections.Generic;
using System.Text;
using Inspire.Erp.Domain.Entities;
using System.Threading.Tasks;
using static Inspire.Erp.Domain.Modals.BalanceSheetResponse;



namespace Inspire.Erp.Application.BalanceSheet.Interface
{

    public interface IBalanceSheet
    {
        public Task<dynamic> getBalanceSheet(DateTime StartDate, DateTime EndDate);
    }
}



