using System;
using System.Collections.Generic;

namespace Inspire.Erp.Domain.Entities
{
    public partial class SalesVoucher
    {
        public decimal SalesVoucherSvId { get; set; }
        public string SalesVoucherVoucherNo { get; set; }
        public long? SalesVoucherShortNo { get; set; }
        public DateTime? SalesVoucherVoucherDate { get; set; }
        public int? SalesVoucherVoucherType { get; set; }
        public string SalesVoucherCustomerName { get; set; }
        public int? SalesVoucherCustomerId { get; set; }
        public int? SalesVoucherLoacationId { get; set; }
        public int? SalesVoucherSalesManId { get; set; }
        public decimal? SalesVoucherDiscount { get; set; }
        public decimal? SalesVoucherGrossAmount { get; set; }
        public decimal? SalesVoucherNetAmount { get; set; }
        public string SalesVoucherRemarks { get; set; }
        public int? SalesVoucherUserId { get; set; }
        public int? SalesVoucherFsno { get; set; }
        public string SalesVoucherDescription { get; set; }
        public string SalesVoucherCono { get; set; }
        public string SalesVoucherDeliveryNote { get; set; }
        public string SalesVoucherCustomerPoNo { get; set; }
        public decimal? SalesVoucherFcRate { get; set; }
        public int? SalesVoucherCompanyId { get; set; }
        public string SalesVoucherReference { get; set; }
        public int? SalesVoucherJobId { get; set; }
        public int? SalesVoucherCurrencyId { get; set; }
        public DateTime? SalesVoucherCustomerPoDate { get; set; }
        public decimal? SalesVoucherNetDiscount { get; set; }
        public string SalesVoucherCashCustomerName { get; set; }
        public decimal? SalesVoucherDiscountPercentage { get; set; }
        public string SalesVoucherShippingAddress { get; set; }
        public string SalesVoucherInvoiceType { get; set; }
        public int? SalesVoucherContractId { get; set; }
        public string SalesVoucherPaymentTermsV { get; set; }
        public string SalesVoucherTermsAndConditionsV { get; set; }
        public string SalesVoucherInvoiceStatus { get; set; }
        public int? SalesVoucherSvQtnIdN { get; set; }
        public int? SalesVoucherCreditCustomerId { get; set; }
        public string SalesVoucherPriceType { get; set; }
        public int? SalesVoucherStationId { get; set; }
        public string SalesVoucherWorkPeriodId { get; set; }
        public string SalesVoucherPaymentMode { get; set; }
        public decimal? SalesVoucherVatAmount { get; set; }
        public decimal? SalesVoucherVatPercentage { get; set; }
        public string SalesVoucherVatRoundSign { get; set; }
        public decimal? SalesVoucherVatRoundAmount { get; set; }
        public string SalesVoucherVatNo { get; set; }
        public string SalesVoucherInvMode { get; set; }
        public bool? SalesVoucherDelStatus { get; set; }
    }
}
