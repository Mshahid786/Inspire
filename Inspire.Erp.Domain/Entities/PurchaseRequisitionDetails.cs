using System;
using System.Collections.Generic;

namespace Inspire.Erp.Domain.Entities
{
    public partial class PurchaseRequisitionDetails
    {
        public int PurchaseRequisitionDetailsPurchaseRequesDetailId { get; set; }
        public int? PurchaseRequisitionDetailsPurchaseRequesId { get; set; }
        public int? PurchaseRequisitionDetailsSlno { get; set; }
        public int? PurchaseRequisitionDetailsItemId { get; set; }
        public string PurchaseRequisitionDetailsItemName { get; set; }
        public int? PurchaseRequisitionDetailsUnitId { get; set; }
        public decimal? PurchaseRequisitionDetailsQty { get; set; }
        public int? PurchaseRequisitionDetailsSrdId { get; set; }
        public int? PurchaseRequisitionDetailsJobIdDetail { get; set; }
        public bool? PurchaseRequisitionDetailsIsEdit { get; set; }
        public string PurchaseRequisitionDetailsRequiredStatus { get; set; }
        public double? PurchaseRequisitionDetailsStock { get; set; }
        public DateTime? PurchaseRequisitionDetailsRequiredDate { get; set; }
        public bool? PurchaseRequisitionDetailsDelStatus { get; set; }
    }
}
