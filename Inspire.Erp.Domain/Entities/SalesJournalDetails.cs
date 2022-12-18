using System;
using System.Collections.Generic;

namespace Inspire.Erp.Domain.Entities
{
    public partial class SalesJournalDetails
    {
        public int? SalesJournalDetailsId { get; set; }
        public int? SalesJournalDetailsSno { get; set; }
        public double? SalesJournalDetailsPack { get; set; }
        public double? SalesJournalDetailsAmountDh { get; set; }
        public double? SalesJournalDetailsAmountDollar { get; set; }
        public double? SalesJournalDetailsGrossWt { get; set; }
        public double? SalesJournalDetailsCargoRate { get; set; }
        public double? SalesJournalDetailsCargoValue { get; set; }
        public double? SalesJournalDetailsTotalAmountDh { get; set; }
        public double? SalesJournalDetailsTotalAmountDollar { get; set; }
        public bool? SalesJournalDetailsDelStatus { get; set; }
    }
}
