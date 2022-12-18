using System;
using System.Collections.Generic;

namespace Inspire.Erp.Domain.Entities
{
    public partial class ContraVoucherDetails
    {
        public int? ContraVoucherDetailsId { get; set; }
        public int? ContraVoucherDetailsAccSno { get; set; }
        public string ContraVoucherDetailsAccno { get; set; }
        public string ContraVoucherDetailsDrCr { get; set; }
        public double? ContraVoucherDetailsFcRate { get; set; }
        public double? ContraVoucherDetailsAmount { get; set; }
        public string ContraVoucherDetailsNarration { get; set; }
        public int? ContraVoucherDetailsLocationId { get; set; }
        public string ContraVoucherDetailsReference { get; set; }
        public int? ContraVoucherDetailsJobId { get; set; }
        public int? ContraVoucherDetailsFsno { get; set; }
        public int? ContraVoucherDetailsSno { get; set; }
        public int? ContraVoucherDetailsCostCenterId { get; set; }
        public bool? ContraVoucherDetailsDelStatus { get; set; }
    }
}
