using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inspire.Erp.Domain.Entities
{
    public partial class StockRegister
    {
        public decimal StockRegisterStoreId { get; set; }
        public string StockRegisterPurchaseId { get; set; }
        public string StockRegisterRefVoucherNo { get; set; }
        public int? StockRegisterSno { get; set; }
        public string StockRegisterBatchCode { get; set; }
        public DateTime? StockRegisterExpDate { get; set; }
        public int? StockRegisterMaterialId { get; set; }
        public decimal? StockRegisterQuantity { get; set; }
        public decimal? StockRegisterSin { get; set; }
        public decimal? StockRegisterSout { get; set; }
        public decimal? StockRegisterRate { get; set; }
        public decimal? StockRegisterAmount { get; set; }
        public decimal? StockRegisterFcAmount { get; set; }
        public DateTime? StockRegisterAssignedDate { get; set; }
        public string StockRegisterDepCode { get; set; }
        public string StockRegisterStatus { get; set; }
        public string StockRegisterTransType { get; set; }
        public string StockRegisterRemarks { get; set; }
        public int? StockRegisterUnit { get; set; }
        public int? StockRegisterLocationId { get; set; }
        public int? StockRegisterJobId { get; set; }
        public int? StockRegisterFsno { get; set; }
        public decimal? StockRegisterNetStkBal { get; set; }
        public string StockRegisterFoc { get; set; }
        public decimal? StockRegisterUsedQty { get; set; }
        public bool? StockRegisterQueryRun { get; set; }
        public bool? StockRegisterCalcDone { get; set; }
        public decimal? StockRegisterRateTmp { get; set; }
        public decimal? StockRegisterAmountTmp { get; set; }
        public bool? StockRegisterDelStatus { get; set; }
        [NotMapped]
        public string profileUrl { get; set; }
    }
}
