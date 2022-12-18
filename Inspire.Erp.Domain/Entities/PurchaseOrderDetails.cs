using System;
using System.Collections.Generic;

namespace Inspire.Erp.Domain.Entities
{
    public partial class PurchaseOrderDetails
    {
        public int? PurchaseOrderDetailsPoId { get; set; }
        public int? PurchaseOrderDetailsSno { get; set; }
        public string PurchaseOrderDetailsDescription { get; set; }
        public string PurchaseOrderDetailsMaterialDescription { get; set; }
        public double? PurchaseOrderDetailsQuantity { get; set; }
        public double? PurchaseOrderDetailsRate { get; set; }
        public double? PurchaseOrderDetailsAmount { get; set; }
        public double? PurchaseOrderDetailsFcAmount { get; set; }
        public int? PurchaseOrderDetailsUnitId { get; set; }
        public int? PurchaseOrderDetailsMaterialId { get; set; }
        public int? PurchaseOrderDetailsPreqId { get; set; }
        public bool? PurchaseOrderDetailsIsEdit { get; set; }
        public string PurchaseOrderDetailsPoStatus { get; set; }
        public int? PurchaseOrderDetailsPodId { get; set; }
        public int? PurchaseOrderDetailsSrdId { get; set; }
        public int? PurchaseOrderDetailsSupplierQatationDetailsId { get; set; }
        public bool? PurchaseOrderDetailsDelStatus { get; set; }
    }
}
