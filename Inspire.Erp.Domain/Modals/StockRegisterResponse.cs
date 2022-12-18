using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Inspire.Erp.Domain.Modals
{
    public partial class StockRegisterResponse
    {
        public long? Item_Id { get; set; }
        public int? Stock_Register_Unit_ID { get; set; }
        public decimal? OpenQty { get; set; }
        public decimal? OpenQtyAmount { get; set; }
        public decimal? StockIn { get; set; }
        public decimal? StockInAmount { get; set; }
        public decimal? StockOut { get; set; }
        public decimal? StockOutAmount { get; set; }
        public decimal? TotalBal { get; set; }
        public decimal? TotalBalAmount { get; set; }
        public string? Item_Name { get; set; }
       
        [NotMapped]
        public string profileUrl { get; set; }
    }
}
