using Microsoft.AspNetCore.Mvc;
using Inspire.Erp.Application.BalanceSheet.Interface;
using System.Threading.Tasks;
using static Inspire.Erp.Domain.Modals.BalanceSheetResponse;
using Inspire.Erp.Domain.Modals;
using System;
using Inspire.Erp.Application.VoucherPrinting.Interface;

namespace Inspire.Erp.Web.Controllers
{
    public class BalanceSheetController : ControllerBase
    {
        private IBalanceSheet _vp;

        public BalanceSheetController(IBalanceSheet vp)
        {
            _vp = vp;
        }
        [HttpPost("GetBalanceSheet")]
        public async Task<dynamic> GetBalanceSheet(StatementOfAccounts obj)
        {
            try
            {
                System.DateTime StartDate;
                System.DateTime EndDate;
                if (obj.StartDate == null)
                {
                    StartDate = System.DateTime.Now.AddMonths(-9);
                }
                else
                {
                    StartDate = obj.StartDate.Date;
                }
                if (obj.EndDate == null)
                {
                    EndDate = System.DateTime.Now;
                }
                else
                {
                    EndDate = obj.EndDate.Date;
                }

                var response = await _vp.getBalanceSheet(StartDate, EndDate);
                //return true;

                return response;
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}
