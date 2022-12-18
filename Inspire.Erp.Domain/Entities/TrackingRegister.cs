using System;
using System.Collections.Generic;

namespace Inspire.Erp.Domain.Entities
{
    public partial class TrackingRegister
    {
        public int TrackingRegisterTrackId { get; set; }
        public string TrackingRegisterVoucherNo { get; set; }
        public int? TrackingRegisterDetailsId { get; set; }
        public int? TrackingRegisterSno { get; set; }
        public int? TrackingRegisterMaterialId { get; set; }
        public string TrackingRegisterVoucherType { get; set; }
        public double? TrackingRegisterQty { get; set; }
        public double? TrackingRegisterQtyin { get; set; }
        public double? TrackingRegisterQtyout { get; set; }
        public double? TrackingRegisterRate { get; set; }
        public DateTime? TrackingRegisterTrackDate { get; set; }
        public string TrackingRegisterRefVno { get; set; }
        public int? TrackingRegisterFsno { get; set; }
        public bool? TrackingRegisterDelStatus { get; set; }
    }
}
