using System;
using System.Collections.Generic;

namespace Inspire.Erp.Domain.Entities
{
    public partial class PurchaseRequisition
    {
        public int PurchaseRequisitionPurchaseRequesId { get; set; }
        public DateTime? PurchaseRequisitionRequisitionDate { get; set; }
        public int? PurchaseRequisitionStaffCode { get; set; }
        public string PurchaseRequisitionRemarks { get; set; }
        public int? PurchaseRequisitionSupplierCode { get; set; }
        public int? PurchaseRequisitionJobId { get; set; }
        public int? PurchaseRequisitionSubJobId { get; set; }
        public int? PurchaseRequisitionRequestedBy { get; set; }
        public bool? PurchaseRequisitionDelStatus { get; set; }
    }
}
