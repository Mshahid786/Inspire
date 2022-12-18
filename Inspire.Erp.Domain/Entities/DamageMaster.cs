using System;
using System.Collections.Generic;

namespace Inspire.Erp.Domain.Entities
{
    public partial class DamageMaster
    {
        public int? DamageMasterId { get; set; }
        public DateTime? DamageMasterVdate { get; set; }
        public string DamageMasterNarration { get; set; }
        public int? DamageMasterLocationId { get; set; }
        public bool? DamageMasterDelStatus { get; set; }
    }
}
