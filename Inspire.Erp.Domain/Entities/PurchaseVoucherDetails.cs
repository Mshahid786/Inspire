using System;
using System.Collections.Generic;

namespace Inspire.Erp.Domain.Entities
{
    public partial class PurchaseVoucherDetails
    {
        public int PurchaseVoucherDetailsPurcahseDetailsId { get; set; }
        public string PurchaseVoucherDetailsPurchaseId { get; set; }
        public string PurchaseVoucherDetailsBatchCode { get; set; }
        public int? PurchaseVoucherDetailsSno { get; set; }
        public int? PurchaseVoucherDetailsMaterialId { get; set; }
        public double? PurchaseVoucherDetailsRate { get; set; }
        public decimal? PurchaseVoucherDetailsQuantity { get; set; }
        public double? PurchaseVoucherDetailsAmount { get; set; }
        public double? PurchaseVoucherDetailsFcAmount { get; set; }
        public string PurchaseVoucherDetailsRemarks { get; set; }
        public string PurchaseVoucherDetailsUnit { get; set; }
        public int? PurchaseVoucherDetailsUnitId { get; set; }
        public DateTime? PurchaseVoucherDetailsManufactureDate { get; set; }
        public DateTime? PurchaseVoucherDetailsExpiryDate { get; set; }
        public string PurchaseVoucherDetailsAssetAcc { get; set; }
        public int? PurchaseVoucherDetailsFsno { get; set; }
        public int? PurchaseVoucherDetailsLoacationId { get; set; }
        public double? PurchaseVoucherDetailsSalesPrice1 { get; set; }
        public double? PurchaseVoucherDetailsSalesPrice2 { get; set; }
        public double? PurchaseVoucherDetailsSalesPrice3 { get; set; }
        public int? PurchaseVoucherDetailsCompanyId { get; set; }
        public int? PurchaseVoucherDetailsLpoId { get; set; }
        public string PurchaseVoucherDetailsGrnNo { get; set; }
        public int? PurchaseVoucherDetailsPodId { get; set; }
        public bool? PurchaseVoucherDetailsIsEdit { get; set; }
        public double? PurchaseVoucherDetailsLandingCost { get; set; }
        public double? PurchaseVoucherDetailsLandingCostLocalCurrency { get; set; }
        public double? PurchaseVoucherDetailsFoc { get; set; }
        public double? PurchaseVoucherDetailsVatAmount { get; set; }
        public double? PurchaseVoucherDetailsFcSmRate { get; set; }
        public double? PurchaseVoucherDetailsFcSmAmount { get; set; }
        public double? PurchaseVoucherDetailsDiscountAmoutPurchase { get; set; }
        public bool? PurchaseVoucherDetailsDelStatus { get; set; }

        public virtual PurchaseVoucher PurchaseVoucherDetailsPurchase { get; set; }
    }
}
