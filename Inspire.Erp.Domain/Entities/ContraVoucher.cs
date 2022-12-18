using System;
using System.Collections.Generic;

namespace Inspire.Erp.Domain.Entities
{
    public partial class ContraVoucher
    {
        public int? ContraVoucherSno { get; set; }
        public int? ContraVoucherId { get; set; }
        public string ContraVoucherReference { get; set; }
        public DateTime? ContraVoucherDate { get; set; }
        public double? ContraVoucherAmount { get; set; }
        public string ContraVoucherNarration { get; set; }
        public int? ContraVoucherFsno { get; set; }
        public string ContraVoucherStatus { get; set; }
        public int? ContraVoucherUserId { get; set; }
        public string ContraVoucherType { get; set; }
        public int? ContraVoucherLocationId { get; set; }
        public string ContraVoucherRefNo { get; set; }
        public int? ContraVoucherCurrencyId { get; set; }
        public bool? ContraVoucherDelStatus { get; set; }
    }
}
