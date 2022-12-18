using System;
using System.Collections.Generic;

namespace Inspire.Erp.Domain.Entities
{
    public partial class SalesJournal
    {
        public int? SalesJournalId { get; set; }
        public DateTime? SalesJournalDate { get; set; }
        public int? SalesJournalCustId { get; set; }
        public string SalesJournalReffNo { get; set; }
        public string SalesJournalRemarks { get; set; }
        public int? SalesJournalUserId { get; set; }
        public int? SalesJournalFsno { get; set; }
        public bool? SalesJournalDelStatus { get; set; }
    }
}
