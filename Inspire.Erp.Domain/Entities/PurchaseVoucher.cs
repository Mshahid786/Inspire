using System;
using System.Collections.Generic;

namespace Inspire.Erp.Domain.Entities
{
    public partial class PurchaseVoucher
    {
        public PurchaseVoucher()
        {
            PurchaseVoucherDetails = new HashSet<PurchaseVoucherDetails>();
        }

        public int PurchaseVoucherPurId { get; set; }
        public string PurchaseVoucherPurchaseId { get; set; }
        public int? PurchaseVoucherPurchaseIdNum { get; set; }
        public string PurchaseVoucherPurchaseRef { get; set; }
        public string PurchaseVoucherPurchaseType { get; set; }
        public string PurchaseVoucherGrNo { get; set; }
        public DateTime? PurchaseVoucherGrDate { get; set; }
        public int? PurchaseVoucherSpId { get; set; }
        public string PurchaseVoucherSpAccNo { get; set; }
        public double? PurchaseVoucherSpAmount { get; set; }
        public double? PurchaseVoucherFcSpAmount { get; set; }
        public DateTime? PurchaseVoucherPurchaseDate { get; set; }
        public string PurchaseVoucherLpoNo { get; set; }
        public DateTime? PurchaseVoucherLpoDate { get; set; }
        public string PurchaseVoucherQuatationNo { get; set; }
        public DateTime? PurchaseVoucherQuatationDate { get; set; }
        public double? PurchaseVoucherActualAmount { get; set; }
        public double? PurchaseVoucherNetAmount { get; set; }
        public double? PurchaseVoucherTransportCost { get; set; }
        public double? PurchaseVoucherHandlingCharges { get; set; }
        public double? PurchaseVoucherFcActualAmount { get; set; }
        public double? PurchaseVoucherFcNetAmount { get; set; }
        public string PurchaseVoucherDescription { get; set; }
        public double? PurchaseVoucherDrAccNo { get; set; }
        public double? PurchaseVoucherDrAmount { get; set; }
        public double? PurchaseVoucherFcDrAmount { get; set; }
        public string PurchaseVoucherDisYn { get; set; }
        public string PurchaseVoucherDisAcNo { get; set; }
        public double? PurchaseVoucherDisAmount { get; set; }
        public double? PurchaseVoucherFcDisAmount { get; set; }
        public string PurchaseVoucherStatus { get; set; }
        public int? PurchaseVoucherFsno { get; set; }
        public int? PurchaseVoucherUserId { get; set; }
        public double? PurchaseVoucherFcRate { get; set; }
        public int? PurchaseVoucherLocationId { get; set; }
        public string PurchaseVoucherSupplyInvoiceNo { get; set; }
        public decimal? PurchaseVoucherDiscountPercentage { get; set; }
        public int? PurchaseVoucherPoNo { get; set; }
        public int? PurchaseVoucherCurrencyId { get; set; }
        public int? PurchaseVoucherCompanyId { get; set; }
        public int? PurchaseVoucherJobId { get; set; }
        public string PurchaseVoucherBatchCode { get; set; }
        public string PurchaseVoucherCashSupplierName { get; set; }
        public string PurchaseVoucherDayBookNo { get; set; }
        public double? PurchaseVoucherVatAmount { get; set; }
        public double? PurchaseVoucherVatPercentage { get; set; }
        public string PurchaseVoucherVatRoundSign { get; set; }
        public double? PurchaseVoucherVatRoundAmount { get; set; }
        public string PurchaseVoucherVatNo { get; set; }
        public bool? PurchaseVoucherExcludeVat { get; set; }
        public int? PurchaseVoucherIssedId { get; set; }
        public bool? PurchaseVoucherJobDirectPurchase { get; set; }
        public string PurchaseVoucherGrnoTmp { get; set; }
        public bool? PurchaseVoucherDelStatus { get; set; }

        public virtual Suppliers PurchaseVoucherSp { get; set; }
        public virtual ICollection<PurchaseVoucherDetails> PurchaseVoucherDetails { get; set; }
    }
}
