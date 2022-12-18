using System;
using System.Collections.Generic;

namespace Inspire.Erp.Domain.Entities
{
    public partial class StockTransferDetails
    {
        public int? StockTransferDetailsStid { get; set; }
        public int? StockTransferDetailsSno { get; set; }
        public int? StockTransferDetailsMaterialId { get; set; }
        public int? StockTransferDetailsUnitId { get; set; }
        public double? StockTransferDetailsQty { get; set; }
        public double? StockTransferDetailsRate { get; set; }
        public string StockTransferDetailsRemarks { get; set; }
        public string StockTransferDetailsBatchCode { get; set; }
        public DateTime? StockTransferDetailsExpDate { get; set; }
        public bool? StockTransferDetailsDelStatus { get; set; }
    }
}
