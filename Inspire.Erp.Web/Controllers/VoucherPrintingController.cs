using Microsoft.AspNetCore.Mvc;
using Inspire.Erp.Application.VoucherPrinting.Interface;
using System.Threading.Tasks;
using static Inspire.Erp.Domain.Modals.GetVoucherPrintResponse;


namespace Inspire.Erp.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoucherPrintingController : ControllerBase
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        private IvoucherPrinting _vp;

        public VoucherPrintingController(IvoucherPrinting vp)
        {
            _vp = vp;
        }
        [HttpPost("GetVoucherPrinting")]
        public async Task<dynamic> GetVoucherPrinting()
        {
            try
            {

                System.DateTime StartDate = System.DateTime.Now.AddMonths(-9);
                System.DateTime EndDate = System.DateTime.Now;
                string VoucherNo = "All";
                string VoucherTye = "All";
                string ChequeNo = "All";
                string VoucherNo_No = "All";

                var response = await _vp.getVoucherPrintReport(StartDate, EndDate, VoucherNo, VoucherTye, ChequeNo, VoucherNo_No);
                return response;

            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}
