using System;
using System.Collections.Generic;

namespace Inspire.Erp.Domain.Entities
{
    public partial class PurchaseOrder
    {
        public int PurchaseOrderPoId { get; set; }
        public string PurchaseOrderPoNo { get; set; }
        public int? PurchaseOrderSupplierId { get; set; }
        public DateTime? PurchaseOrderPoDate { get; set; }
        public string PurchaseOrderDescription { get; set; }
        public string PurchaseOrderLpoNo { get; set; }
        public DateTime? PurchaseOrderLpoDate { get; set; }
        public double? PurchaseOrderTotalAmount { get; set; }
        public int? PurchaseOrderPoStatus { get; set; }
        public double? PurchaseOrderDiscountPercentage { get; set; }
        public int? PurchaseOrderLoacationId { get; set; }
        public int? PurchaseOrderCurrencyId { get; set; }
        public double? PurchaseOrderNetAmount { get; set; }
        public int? PurchaseOrderFsno { get; set; }
        public int? PurchaseOrderUserId { get; set; }
        public string PurchaseOrderTermsAndCondition { get; set; }
        public int? PurchaseOrderJobId { get; set; }
        public DateTime? PurchaseOrderApprovedDate { get; set; }
        public string PurchaseOrderApprovedStatus { get; set; }
        public int? PurchaseOrderApprovedBy { get; set; }
        public string PurchaseOrderHeader { get; set; }
        public string PurchaseOrderFooter { get; set; }
        public string PurchaseOrderTerms { get; set; }
        public string PurchaseOrderPaymentTerms { get; set; }
        public string PurchaseOrderDelivery { get; set; }
        public string PurchaseOrderIndentNo { get; set; }
        public string PurchaseOrderContactPersonV { get; set; }
        public string PurchaseOrderRfqIdN { get; set; }
        public string PurchaseOrderCustomerEnquiryIdN { get; set; }
        public string PurchaseOrderSupplierQuatationIdN { get; set; }
        public bool? PurchaseOrderDelStatus { get; set; }
    }
}
