using System;
using System.Collections.Generic;

namespace Inspire.Erp.Domain.Entities
{
    public partial class CustomerOrderRegister
    {
        public int? CustomerOrderRegisterId { get; set; }
        public int? CustomerOrderRegisterRefVoucherNo { get; set; }
        public int? CustomerOrderRegisterOrderNo { get; set; }
        public int? CustomerOrderRegisterMaterialId { get; set; }
        public int? CustomerOrderRegisterUnitId { get; set; }
        public double? CustomerOrderRegisterQtyOrder { get; set; }
        public double? CustomerOrderRegisterQtyIssued { get; set; }
        public double? CustomerOrderRegisterRate { get; set; }
        public double? CustomerOrderRegisterAmount { get; set; }
        public double? CustomerOrderRegisterFcAmount { get; set; }
        public double? CustomerOrderRegisterAssignedDate { get; set; }
        public int? CustomerOrderRegisterLocationId { get; set; }
        public string CustomerOrderRegisterStatus { get; set; }
        public int? CustomerOrderRegisterTransType { get; set; }
        public int? CustomerOrderRegisterCustomerId { get; set; }
        public int? CustomerOrderRegisterFsno { get; set; }
        public bool? CustomerOrderRegisterDelStatus { get; set; }
    }
}
