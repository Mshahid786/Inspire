using Inspire.Erp.Application.StoreWareHouse.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using static Inspire.Erp.Domain.Entities.StoreWareHouse;

namespace Inspire.Erp.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private IStoreWareHouse _sw;

        public StockController(IStoreWareHouse sw)
        {
            _sw = sw;
        }
        [HttpPost("getProfitLossReport")]
        public async Task<dynamic> getProfitLossReport()
        {
            try
            {
                var response=await _sw.getProfitLossReport();
                return response;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        [HttpPost("getStockLedgerReport")]
        public async Task<dynamic> getStockLedgerReport()
        {
            try
            {
                var response=await _sw.getStockLedgerReport();
                return response;
            }
            catch (System.Exception)
            {
                throw;
            }
        }
        [HttpGet("getStockMovementRpt")]
        public async Task<dynamic> getStockMovementRpt()
        {
            try
            {
                var response = await _sw.getStockMovementRpt();
                return response;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        //[HttpPost("getFilteredStockLedgerRpt")]
        //public async Task<dynamic> getFilteredStockLedgerRpt([FromBody] StockLedgerReportModel obj)
        //{
        //    try
        //    {
        //        var response = await _sw.getFilteredStockLedgerRpt(obj);
        //        return response;
        //    }
        //    catch (System.Exception)
        //    {
        //        throw;
        //    }
        //}

        //[HttpPost("getStockMovementDetailsRpt")]
        //public async Task<dynamic> getStockMovementDetailsRpt([FromBody] ItemMasterViewModel id)
        //{
        //    try
        //    {
        //        var response = await _sw.getStockMovementDetailsRpt(id);
        //        return response;
        //    }
        //    catch (System.Exception)
        //    {
        //        throw;
        //    }
        //}

        //[HttpPost("getItemDetailsById")]
        //public async Task<dynamic> getItemDetailsById([FromBody] ItemMasterViewModel id)
        //{
        //    try
        //    {
        //        var response = await _sw.getItemDetailsById(id);
        //        return response;
        //    }
        //    catch (System.Exception)
        //    {
        //        throw;
        //    }
        //}

        //[HttpPost("getDetailsByItem")]
        //public async Task<dynamic> getDetailsByItem([FromBody] StockLedgerReportModel obj)
        //{
        //    try
        //    {
        //        var response = await _sw.getDetailsByItem(obj);
        //        return response;
        //    }
        //    catch (System.Exception)
        //    {
        //        throw;
        //    }
        //}

        [HttpPost("getStockVchDetails")]
        public async Task<dynamic> getStockVchDetails([FromBody] StockLedgerReportModel obj)
        {
            try
            {
                var response = await _sw.getStockVchDetails(obj);
                return response;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        [HttpGet("getAllItems")]
        public async Task<dynamic> getAllItems()
        {
            try
            {
                var response = await _sw.getAllItems();
                return response;
            }
            catch (System.Exception ex)
            {
                return ex.Message.ToString();
                throw;
            }
        }

        //[HttpGet("getAllBrands")]
        //public async Task<dynamic> getAllBrands()
        //{
        //    try
        //    {
        //        var response = await _sw.getAllBrands();
        //        return response;
        //    }
        //    catch (System.Exception ex)
        //    {
        //        return ex.Message.ToString();
        //        throw;
        //    }
        //}

        [HttpGet("getAllDepartments")]
        public async Task<dynamic> getAllDepartments()
        {
            try
            {
                var response = await _sw.getAllDepartments();
                return response;
            }
            catch (System.Exception ex)
            {
                return ex.Message.ToString();
                throw;
            }
        }

        [HttpGet("getVoucherNumber")]
        public async Task<dynamic> getVoucherNumber()
        {
            try
            {
                var response = await _sw.getVoucherNumber();
                return response;
            }
            catch (System.Exception ex)
            {
                return ex.Message.ToString();
                throw;
            }
        }

        //[HttpPost("submitTransferReport")]
        //public async Task<dynamic> submitTransferReport(StockTransferRequestModel obj)
        //{
        //    try
        //    {
        //        _sw.submitTransferReport(obj);
        //        return "success 200 Ok";
        //    }
        //    catch (Exception)
        //    {
        //        return "Error";
        //        throw;
        //    }
        //}

        //[HttpPost("submitDamageEntry")]
        //public async Task<dynamic> submitDamageEntry(StockTransferRequestModel obj)
        //{
        //    try
        //    {
        //        _sw.submitDamageEntry(obj);
        //        return "success 200 Ok";
        //    }
        //    catch (Exception)
        //    {
        //        return "Error";
        //        throw;
        //    }
        //}

    }
}
