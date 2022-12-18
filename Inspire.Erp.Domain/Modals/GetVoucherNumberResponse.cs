using System;
using System.Collections.Generic;
using System.Text;

namespace Inspire.Erp.Domain.Modals
{
    public class GetVoucherNumberResponse
    {
        public decimal Vouchers_Numbers_VSNO { get; set; }
        public string Vouchers_Numbers_V_NO { get; set; }
        public decimal Vouchers_Numbers_V_NO_NU { get; set; }
        public string Vouchers_Numbers_V_Type { get; set; }
        public decimal Vouchers_Numbers_FSNO { get; set; }
        public string Vouchers_Numbers_Status { get; set; }
        public decimal? Vouchers_Numbers_LocationID { get; set; }
        public DateTime? Vouchers_Numbers_VoucherDate { get; set; }
        public bool? Vouhers_Numbers_DelStatus { get; set; }
    }
}
