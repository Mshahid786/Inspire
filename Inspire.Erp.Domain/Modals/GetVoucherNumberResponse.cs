using System;
using System.Collections.Generic;
using System.Text;

namespace Inspire.Erp.Domain.Modals
{
    public class GetVoucherNumberResponse
    {
        
        public DateTime Vouchers_Numbers_From_Date { get; set; }
        public DateTime Vouchers_Numbers_To_Date { get; set; }
        public string Vouchers_Numbers_Cheque_NO { get; set; }
        public string Vouchers_Numbers_from_V_NO { get; set; }
        public string? Vouchers_Numbers_To_V_NO { get; set; }



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
    public class TestGetVoucherNumberResponse
    {
          //Vouchers_Numbers_from_V_NO : 'All',
          //Vouchers_Numbers_To_V_NO : 'All',
          //Vouchers_Numbers_V_Type : 'All',
          //Vouchers_Numbers_From_Date : '2022/01/01',
          //Vouchers_Numbers_To_Date : '2022/12/31',
          //Vouchers_Numbers_Cheque_NO : 'All',
          //Vouchers_Numbers_V_NO_NU : 'All'
        
        public string Vouchers_Numbers_from_V_NO { get; set; }
        public string? Vouchers_Numbers_To_V_NO { get; set; }
        public string? Vouchers_Numbers_V_Type { get; set; }
        public string? Vouchers_Numbers_From_Date { get; set; }
        public string? Vouchers_Numbers_To_Date { get; set; }
        public string Vouchers_Numbers_Cheque_NO { get; set; }
        public string? Vouchers_Numbers_V_NO_NU { get; set; }



        //public string? Vouchers_Numbers_VSNO { get; set; }
        //public string? Vouchers_Numbers_V_NO { get; set; }
        //public string? Vouchers_Numbers_V_NO_NU { get; set; }
       
        //public string? Vouchers_Numbers_FSNO { get; set; }
        //public string? Vouchers_Numbers_Status { get; set; }
        //public string? Vouchers_Numbers_LocationID { get; set; }
        //public string? Vouchers_Numbers_VoucherDate { get; set; }
        //public string? Vouhers_Numbers_DelStatus { get; set; }


    }
}
