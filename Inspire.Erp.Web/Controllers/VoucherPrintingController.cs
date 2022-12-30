using Microsoft.AspNetCore.Mvc;
using Inspire.Erp.Application.VoucherPrinting.Interface;
using System.Threading.Tasks;
using static Inspire.Erp.Domain.Modals.GetVoucherPrintResponse;
using Inspire.Erp.Domain.Modals;
using System;

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
        public async Task<dynamic> GetVoucherPrinting(TestGetVoucherNumberResponse obj)
        {
            try
            {
                
                System.DateTime StartDate;
                System.DateTime EndDate;
                string VoucherNoFrom;
                string VoucherNoTo;
                string VoucherTye;
                string VoucherNo_No;
                string ChequeNo;

                if (obj.Vouchers_Numbers_From_Date == null)
                {
                    StartDate = System.DateTime.Now.AddMonths(-9);
                }
                else
                {
                    StartDate = DateTime.Parse(obj.Vouchers_Numbers_From_Date);
                }
                if (obj.Vouchers_Numbers_To_Date == null)
                {
                    EndDate = System.DateTime.Now;
                }
                else
                {
                    EndDate = DateTime.Parse(obj.Vouchers_Numbers_To_Date);
                }
                if (obj.Vouchers_Numbers_from_V_NO == null)
                {
                    VoucherNoFrom = "All";
                }
                else
                {
                    VoucherNoFrom = obj.Vouchers_Numbers_from_V_NO;
                }
                if (obj.Vouchers_Numbers_To_V_NO == null)
                {

                    VoucherNoTo = "All";
                }
                else
                {
                    VoucherNoTo = obj.Vouchers_Numbers_To_V_NO;
                }
                if (obj.Vouchers_Numbers_V_Type == null)
                {
                    VoucherTye = "All";
                }
                else
                {
                    VoucherTye = obj.Vouchers_Numbers_V_Type;
                }
                if (obj.Vouchers_Numbers_Cheque_NO == null)
                {
                    ChequeNo = "All";
                }
                else
                {
                    ChequeNo = obj.Vouchers_Numbers_Cheque_NO;
                }
                if (obj.Vouchers_Numbers_V_NO_NU == "0")
                {
                    VoucherNo_No = "0";
                }
                else
                {
                    VoucherNo_No = obj.Vouchers_Numbers_V_NO_NU.ToString();
                }

                var response = await _vp.getVoucherPrintReport(StartDate, EndDate, VoucherNoFrom, VoucherNoTo, VoucherTye, ChequeNo, VoucherNo_No);
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
