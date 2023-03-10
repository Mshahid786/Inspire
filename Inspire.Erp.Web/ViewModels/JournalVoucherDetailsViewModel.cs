using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inspire.Erp.Web.ViewModels
{
    public class JournalVoucherDetailsViewModel
    {
        public int? JournalVoucherDetailsId { get; set; }
        public int? JournalVoucherDetailsAccSno { get; set; }
        public string? JournalVoucherDetailsAccNo { get; set; }
        public string JournalVoucherDetailsDrCr { get; set; }
        public double? JournalVoucherDetailsFcRate { get; set; }
        public double? JournalVoucherDetailsFcAmount { get; set; }
        public double? JournalVoucherDetailsAmount { get; set; }
        public string JournalVoucherDetailsNarration { get; set; }
        public int? JournalVoucherDetailsLocationId { get; set; }
        public string JournalVoucherDetailsReference { get; set; }
        public int? JournalVoucherDetailsJobId { get; set; }
        public int? JournalVoucherDetailsFsno { get; set; }
        public int? JournalVoucherDetailsSno { get; set; }
        public int? JournalVoucherDetailsCostCenterId { get; set; }
        public bool? JournalVoucherDetailsDelStatus { get; set; }
    }
}
