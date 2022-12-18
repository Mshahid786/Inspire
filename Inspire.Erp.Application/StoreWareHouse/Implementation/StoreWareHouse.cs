using AutoMapper;
using Inspire.Erp.Application.StoreWareHouse.Interfaces;
using Inspire.Erp.Domain.Entities;
using Inspire.Erp.Domain.Modals;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using static Inspire.Erp.Domain.Entities.StoreWareHouse;

namespace Inspire.Erp.Application.StoreWareHouse.Implementations
{
    public class StoreWareHouses : IStoreWareHouse
    {
        private readonly InspireErpDBContext _sr;
        public IMapper _im;
        public StoreWareHouses(InspireErpDBContext sr)
        {
            _sr = sr;
        }
        //done
        public async Task<dynamic> getStockLedgerReport() {
            try
            {
                var response = await _sr.Set<StockRegisterResponse>().FromSqlInterpolated($"EXEC getStockLedgerRpt").ToListAsync();
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //done
        public async Task<dynamic> getStockMovementRpt()
        {
            try
            {
                
                var response = await _sr.Set<StockMovementRptResponse>().FromSqlInterpolated($"EXEC getStockMovementRpt").ToListAsync();
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //done
        public async Task<dynamic> getAllItems()
        {
            try
            {
                
                var response = await _sr.Set<GetAllItemResponse>().FromSqlInterpolated($"EXEC getAllItems").ToListAsync();
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<dynamic> getFilteredStockLedgerRpt(StockLedgerReportModel obj)
        {
            try
            {
                
                var response = await _sr.Set<StockMovementRptResponse>().FromSqlInterpolated($"EXEC getStockMovementRpt").ToListAsync();
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<dynamic> getStockMovementDetailsRpt(ItemMasterViewModel obj)
        {
            try
            {
                
                var response = await _sr.Set<StockMovementRptResponse>().FromSqlInterpolated($"EXEC getStockMovementRpt").ToListAsync();
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<dynamic> getItemDetailsById(ItemMasterViewModel obj)
        {
            try
            {
                
                var response = await _sr.Set<StockMovementRptResponse>().FromSqlInterpolated($"EXEC getStockMovementRpt").ToListAsync();
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<dynamic> getDetailsByItem(StockLedgerReportModel obj)
        {
            try
            {
                
                var response = await _sr.Set<StockMovementRptResponse>().FromSqlInterpolated($"EXEC getStockMovementRpt").ToListAsync();
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //done
        public async Task<dynamic> getStockVchDetails(StockLedgerReportModel obj)
        {
            try
            {
                int id = int.Parse(obj.itemGroup);
                var itemId = new SqlParameter("@itemId",id);
                var response = await _sr.Set<GetStockVoucherDetailsResponse>().FromSqlInterpolated($"EXEC getStockVchDetails {itemId}").ToListAsync();
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //done
        public async Task<dynamic> getAllDepartments()
        {
            try
            {
                
                var response = await _sr.Set<GetAllDepartmentResponse>().FromSqlInterpolated($"EXEC getAllDepartments").ToListAsync();
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //done
        public async Task<dynamic> getVoucherNumber()
        {
            try
            {
                
                var response = await _sr.Set<GetVoucherNumberResponse>().FromSqlInterpolated($"EXEC GetVoucherNumber").ToListAsync();
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<dynamic> submitTransferReport(StockTransferRequestModel obj)
        {
            try
            {
                
                var response = await _sr.Set<StockMovementRptResponse>().FromSqlInterpolated($"EXEC getStockMovementRpt").ToListAsync();
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<dynamic> submitDamageEntry(StockTransferRequestModel obj)
        {
            try
            {
                
                var response = await _sr.Set<StockMovementRptResponse>().FromSqlInterpolated($"EXEC getStockMovementRpt").ToListAsync();
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<dynamic> getProfitLossReport()
        {
            try
            {
                var startDate = DateTime.Now.AddMonths(-9);
                var endDate = DateTime.Now;

                var response = await _sr.Set<ProfitLossResponse>().FromSqlRaw($"EXEC GetProfitAndLoss", new SqlParameter ("@StartDate", startDate ), new SqlParameter("@EndDate", startDate)).ToListAsync();
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
