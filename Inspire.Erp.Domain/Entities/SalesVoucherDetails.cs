using System;
using System.Collections.Generic;

namespace Inspire.Erp.Domain.Entities
{
    public partial class SalesVoucherDetails
    {
        public int SalesVoucherDetailsSalesDetailsId { get; set; }
        public string SalesVoucherDetailsVoucherNo { get; set; }
        public long? SalesVoucherDetailsItemId { get; set; }
        public string SalesVoucherDetailsDescription { get; set; }
        public string SalesVoucherDetailsBatchCode { get; set; }
        public long? SalesVoucherDetailsUnitId { get; set; }
        public decimal? SalesVoucherDetailsSoldQty { get; set; }
        public decimal? SalesVoucherDetailsUnitPrice { get; set; }
        public decimal? SalesVoucherDetailsCostPrice { get; set; }
        public decimal? SalesVoucherDetailsGrossAmount { get; set; }
        public decimal? SalesVoucherDetailsDiscount { get; set; }
        public decimal? SalesVoucherDetailsNetAmount { get; set; }
        public int? SalesVoucherDetailsFsno { get; set; }
        public int? SalesVoucherDetailsSno { get; set; }
        public int? SalesVoucherDetailsDeliveryNote { get; set; }
        public int? SalesVoucherDetailsLocationId { get; set; }
        public int? SalesVoucherDetailsCompanyId { get; set; }
        public int? SalesVoucherDetailsPodId { get; set; }
        public int? SalesVoucherDetailsDeliveryId { get; set; }
        public DateTime? SalesVoucherDetailsExpDate { get; set; }
        public decimal? SalesVoucherDetailsFocqty { get; set; }
        public decimal? SalesVoucherDetailsVatPercentage { get; set; }
        public decimal? SalesVoucherDetailsVatAmount { get; set; }
        public int? SalesVoucherDetailsStationId { get; set; }
        public int? SalesVoucherDetailsWorkPeriodId { get; set; }
        public string SalesVoucherDetailsPaymentMode { get; set; }
        public decimal? SalesVoucherDetailsCostPriceBk { get; set; }
        public bool? SalesVoucherDetailsDelStatus { get; set; }
    }
}
