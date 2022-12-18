using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inspire.Erp.Web.ViewModels
{
    public class UnitDetailsViewModel
    {
        public int? UnitDetailsId { get; set; }
        public long? UnitDetailsItemId { get; set; }
        public int? UnitDetailsUnitId { get; set; }
        public double? UnitDetailsConversionType { get; set; }
        public double? UnitDetailsRate { get; set; }
        public double? UnitDetailsWrate { get; set; }
        public bool? UnitDetailsDefUnit { get; set; }
        public bool? UnitDetailsDefWunit { get; set; }
        public decimal? UnitDetailsHeight { get; set; }
        public decimal? UnitDetailsWidth { get; set; }
        public decimal? UnitDetailsReorder { get; set; }
        public bool? UnitDetailsDelStatus { get; set; }
    }
}
