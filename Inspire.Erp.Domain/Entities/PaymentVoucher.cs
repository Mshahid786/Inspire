using System;
using System.Collections.Generic;

namespace Inspire.Erp.Domain.Entities
{
    public partial class PaymentVoucher
    {
        public int PaymentVoucherSno { get; set; }
        public string PaymentVoucherVoucherNo { get; set; }
        public DateTime? PaymentVoucherDate { get; set; }
        public string PaymentVoucherVoucherRef { get; set; }
        public string PaymentVoucherCrAcNo { get; set; }
        public double? PaymentVoucherCrAmount { get; set; }
        public double? PaymentVoucherFcCrAmount { get; set; }
        public double? PaymentVoucherDbAmount { get; set; }
        public double? PaymentVoucherFcDbAmount { get; set; }
        public string PaymentVoucherNarration { get; set; }
        public int? PaymentVoucherFsno { get; set; }
        public int? PaymentVoucherUserId { get; set; }
        public int? PaymentVoucherCurrencyId { get; set; }
        public int? PaymentVoucherLocationId { get; set; }
        public int? PaymentVoucherAllocationId { get; set; }
        public bool? PaymentVoucherDelStatus { get; set; }

        public virtual VouchersNumbers PaymentVoucherVoucherNoNavigation { get; set; }
    }
}
