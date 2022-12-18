using System;
using System.Collections.Generic;

namespace Inspire.Erp.Domain.Entities
{
    public partial class SalesReturnDetails
    {
        public string SalesReturnDetailsSrNo { get; set; }
        public string SalesReturnDetailsRefSvno { get; set; }
        public string SalesReturnDetailsBatchCode { get; set; }
        public int? SalesReturnDetailsSno { get; set; }
        public int? SalesReturnDetailsMaterialId { get; set; }
        public int? SalesReturnDetailsUnitId { get; set; }
        public double? SalesReturnDetailsRate { get; set; }
        public double? SalesReturnDetailsQty { get; set; }
        public double? SalesReturnDetailsGrossAmt { get; set; }
        public double? SalesReturnDetailsDiscount { get; set; }
        public double? SalesReturnDetailsNetAmount { get; set; }
        public double? SalesReturnDetailsFcAmount { get; set; }
        public int? SalesReturnDetailsFsno { get; set; }
        public double? SalesReturnDetailsVat { get; set; }
        public string SalesReturnDetailsBatch { get; set; }
        public DateTime? SalesReturnDetailsExpDate { get; set; }
        public double? SalesReturnDetailsFocQty { get; set; }
        public double? SalesReturnDetailsCostPrice { get; set; }
        public bool? SalesReturnDetailsDelStatus { get; set; }
    }
}
