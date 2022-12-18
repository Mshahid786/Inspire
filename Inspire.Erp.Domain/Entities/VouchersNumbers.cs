using System;
using System.Collections.Generic;

namespace Inspire.Erp.Domain.Entities
{
    public partial class VouchersNumbers
    {
        public VouchersNumbers()
        {
            AccountsTransactions = new HashSet<AccountsTransactions>();
            PaymentVoucherDetails = new HashSet<PaymentVoucherDetails>();
            ReceiptVoucherDetails = new HashSet<ReceiptVoucherDetails>();
        }

        public decimal VouchersNumbersVsno { get; set; }
        public string VouchersNumbersVNo { get; set; }
        public decimal VouchersNumbersVNoNu { get; set; }
        public string VouchersNumbersVType { get; set; }
        public decimal? VouchersNumbersFsno { get; set; }
        public string VouchersNumbersStatus { get; set; }
        public decimal? VouchersNumbersLocationId { get; set; }
        public DateTime? VouchersNumbersVoucherDate { get; set; }
        public bool? VouhersNumbersDelStatus { get; set; }

        public virtual PaymentVoucher PaymentVoucher { get; set; }
        public virtual ICollection<AccountsTransactions> AccountsTransactions { get; set; }
        public virtual ICollection<PaymentVoucherDetails> PaymentVoucherDetails { get; set; }
        public virtual ICollection<ReceiptVoucherDetails> ReceiptVoucherDetails { get; set; }
    }
}
