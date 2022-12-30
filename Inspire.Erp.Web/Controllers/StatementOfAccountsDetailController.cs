using Microsoft.AspNetCore.Mvc;
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
    public class StatementOfAccountsDetailController : ControllerBase
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        private IStatementOfAccountsDetail _SAD;

        public StatementOfAccountsDetailController(IStatementOfAccountsDetail sad)
        {
            _SAD = sad;
            
        }
        [HttpPost("GetStatementOfAccountsDetail")]
        public async Task<dynamic> GetStatementOfAccountsDetail(StatementOfAccounts obj)
        {
            try
            {
                               
                DateTime StartDate; 
                DateTime EndDate;
                string AcNo;
                string Description;
                string Particulars;
                string JobNo;

                

                if (obj.StartDate == null)
                {
                    StartDate = System.DateTime.Now.AddMonths(-9);
                }
                else
                {
                    StartDate = obj.StartDate;
                }
                if (obj.EndDate == null)
                {
                    EndDate = System.DateTime.Now;
                }
                else
                {
                    EndDate = obj.EndDate;
                }
                if (obj.Acno == null)
                {
                    AcNo = "All";
                }
                else
                {
                    AcNo = obj.Acno;
                }
                if (obj.Description == null)
                {

                    Description = "All";
                }
                else
                {
                    Description = obj.Description;
                }
                if (obj.Particulars == null)
                {
                    Particulars = "All";
                }
                else
                {
                    Particulars = obj.Particulars;
                }
                if (obj.JobNo == null)
                {
                    JobNo = "All";
                }
                else
                {
                    JobNo = obj.JobNo;
                }

                                
                var response = await _SAD.GetAccountStatementDetails(StartDate, EndDate, AcNo, Description, Particulars, JobNo);
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

