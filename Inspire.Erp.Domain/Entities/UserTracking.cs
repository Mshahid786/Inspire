using System;
using System.Collections.Generic;

namespace Inspire.Erp.Domain.Entities
{
    public partial class UserTracking
    {
        public int UserTrackingUserNo { get; set; }
        public string UserTrackingUserVpNo { get; set; }
        public string UserTrackingUserVpType { get; set; }
        public int? UserTrackingUserUserId { get; set; }
        public string UserTrackingUserVpAction { get; set; }
        public int? UserTrackingUserFsno { get; set; }
        public DateTime? UserTrackingUserChangeDt { get; set; }
        public DateTime? UserTrackingUserChangeTime { get; set; }
        public bool? UserTrackingUserDelStatus { get; set; }
    }
}
