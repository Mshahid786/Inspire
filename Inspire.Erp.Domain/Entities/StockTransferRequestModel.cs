using System;
using System.Collections.Generic;
using System.Text;

namespace Inspire.Erp.Domain.Entities
{
    public class StockTransferRequestModel
    {
        public string voucherNo { get; set; }
        public string voucherDate { get; set; }
        public string selectedJob { get; set; }
        public string locationFrom { get; set; }
        public string locationTo { get; set; }
        public string narration { get; set; }
        public string department { get; set; }
        public string partNo { get; set; }
        public string materialId { get; set; }
        public string stockQuantity { get; set; }
        public string stockItemId { get; set; }
        public string stockItemName { get; set; }
        public string stockItemType { get; set; }
        public string stockRate { get; set; }
        public string unitId { get; set; }
    }
}
