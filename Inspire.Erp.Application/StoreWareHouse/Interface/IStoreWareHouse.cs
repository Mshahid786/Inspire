using Inspire.Erp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static Inspire.Erp.Domain.Entities.StoreWareHouse;

namespace Inspire.Erp.Application.StoreWareHouse.Interfaces
{
    public interface IStoreWareHouse
    {
        public Task<dynamic> getStockLedgerReport();
        public Task<dynamic> getProfitLossReport();
        public Task<dynamic> getStockMovementRpt();
        public Task<dynamic> getAllItems();
      //  public Task<dynamic> getAllBrands();
        public Task<dynamic> getFilteredStockLedgerRpt(StockLedgerReportModel obj);
        public Task<dynamic> getStockMovementDetailsRpt(ItemMasterViewModel id);
        public Task<dynamic> getItemDetailsById(ItemMasterViewModel id);
        public Task<dynamic> getDetailsByItem(StockLedgerReportModel obj);
        public Task<dynamic> getStockVchDetails(StockLedgerReportModel obj);
        public Task<dynamic> getAllDepartments();
        public Task<dynamic> getVoucherNumber();
        public Task<dynamic> submitTransferReport(StockTransferRequestModel obj);
        public Task<dynamic> submitDamageEntry(StockTransferRequestModel obj);
    }
}
