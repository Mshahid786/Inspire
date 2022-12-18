using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inspire.Erp.Web.ViewModels
{
    public class JournerlVoucherViewModel
    {
        public int? JournalVoucherSno { get; set; }
        public int? JournalVoucherId { get; set; }
        public string? JournalVoucherVrefNo { get; set; }
        public DateTime? JournalVoucherDate { get; set; }
        public double? JournalVoucherAmount { get; set; }
        public string JournalVoucherNarration { get; set; }
        public int? JournalVoucherFsno { get; set; }
        public string JournalVoucherStatus { get; set; }
        public int? JournalVoucherUserId { get; set; }
        public string JournalVoucherType { get; set; }
        public int? JournalVoucherLocationId { get; set; }
        public string JournalVoucherRefNo { get; set; }
        public int? JournalVoucherJobNo { get; set; }
        public int? JournalVoucherCostCenterId { get; set; }
        public int? JournalVoucherCurrencyId { get; set; }
        public DateTime? JournalVoucherDepreciationFrom { get; set; }
        public DateTime? JournalVoucherDepreciationTo { get; set; }
        public bool? JournalVoucherDelStatus { get; set; }
    }
}
