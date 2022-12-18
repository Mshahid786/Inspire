using System;
using System.Collections.Generic;

namespace Inspire.Erp.Domain.Entities
{
    public partial class UserFile
    {
        public long UserId { get; set; }
        public string LogInId { get; set; }
        public string UserName { get; set; }
        public int WorkGroupId { get; set; }
        public string Password { get; set; }
        public bool Deleted { get; set; }
        public bool System { get; set; }
        public bool? Freeze { get; set; }
    }
}
