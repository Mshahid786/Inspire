using Microsoft.AspNetCore.Mvc;
using Inspire.Erp.Application.VoucherPrinting.Interface;
using System.Threading.Tasks;
using static Inspire.Erp.Domain.Modals.GetVoucherPrintResponse;
using Inspire.Erp.Domain.Modals;
using System;
using Inspire.Erp.Application.StatementOfAccounts.Interface;
using Inspire.Erp.Application.StatementOfAccounts.Implementation;




namespace Inspire.Erp.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatementOfAccountsSummaryController : ControllerBase
    {
       private IStatementOfAccountsSummary _SAD;

        public StatementOfAccountsSummaryController(IStatementOfAccountsSummary sad)
        {
            _SAD = sad;
            
        }
        [HttpPost("GetStatementOfAccountsSummary")]
        public async Task<dynamic> GetStatementOfAccountsSummary(StatementOfAccounts obj)
        {
            try
            {
                DateTime StartDate;
                string AcNo;

                if (obj.StartDate == null)
                {
                    StartDate = System.DateTime.Now.AddMonths(-9);
                }
                else
                {
                    StartDate = obj.StartDate;
                }
                if (obj.Acno == null)
                {
                    AcNo = "All";
                }
                else
                {
                    AcNo = obj.Acno;
                }
                var response = await _SAD.GetStatementOfAccountSummary(AcNo, StartDate);
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
