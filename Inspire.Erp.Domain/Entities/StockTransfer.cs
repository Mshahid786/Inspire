using System;
using System.Collections.Generic;

namespace Inspire.Erp.Domain.Entities
{
    public partial class StockTransfer
    {
        public int? StockTransferStid { get; set; }
        public string StockTransferStvno { get; set; }
        public DateTime? StockTransferStDate { get; set; }
        public int? StockTransferLocationIdFrom { get; set; }
        public int? StockTransferLocationIdTo { get; set; }
        public int? StockTransferFsno { get; set; }
        public string StockTransferStatus { get; set; }
        public int? StockTransferUserId { get; set; }
        public string StockTransferNarration { get; set; }
        public int? StockTransferJobId { get; set; }
        public bool? StockTransferApproved { get; set; }
        public string StockTransferApprovedBy { get; set; }
        public DateTime? StockTransferApprovedDate { get; set; }
        public bool? StockTransferDelStatus { get; set; }
    }
}
