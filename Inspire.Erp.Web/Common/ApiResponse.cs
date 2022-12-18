using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inspire.Erp.Web.Common
{
    public class ApiResponse<T>
    {
        public  T Result {get;set;}
        public  bool? Valid { get; set; }

        public bool? Error { get; set; }
        public  string Message { get; set; }
        public string Exception { get; set; }
    }
}
