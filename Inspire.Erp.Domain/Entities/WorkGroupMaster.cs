using System;
using System.Collections.Generic;

namespace Inspire.Erp.Domain.Entities
{
    public partial class WorkGroupMaster
    {
        public int? WorkGroupMasterWorkGroupId { get; set; }
        public string WorkGroupMasterWorkGroupName { get; set; }
        public bool? WorkGroupMasterWorkGroupDelStatus { get; set; }
    }
}
