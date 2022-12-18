using System;
using System.Collections.Generic;

namespace Inspire.Erp.Domain.Entities
{
    public partial class JobMaster
    {
        public int? JobMasterJobId { get; set; }
        public string JobMasterJobName { get; set; }
        public DateTime? JobMasterJobDate { get; set; }
        public double? JobMasterJobValue { get; set; }
        public double? JobMasterJobRetention { get; set; }
        public double? JobMasterJobBalance { get; set; }
        public int? JobMasterJobStatus { get; set; }
        public string JobMasterJobConsultant { get; set; }
        public string JobMasterJobRemarks { get; set; }
        public int? JobMasterJobCustomerId { get; set; }
        public int? JobMasterJobCurrencyId { get; set; }
        public double? JobMasterJobCurVal { get; set; }
        public double? JobMasterJobOpenInv { get; set; }
        public double? JobMasterJobPerInv { get; set; }
        public string JobMasterJobConsultantReff { get; set; }
        public bool? JobMasterJobStatusVal { get; set; }
        public string JobMasterJobType { get; set; }
        public int? JobMasterJobRelativeNo { get; set; }
        public string JobMasterJobCode { get; set; }
        public int? JobMasterJobSupplierId { get; set; }
        public int? JobMasterJobSalesManId { get; set; }
        public string JobMasterJobNumber { get; set; }
        public bool? JobMasterJobIsSubJob { get; set; }
        public double? JobMasterJobRetentionPercentage { get; set; }
        public int? JobMasterJobSalesMan { get; set; }
        public double? JobMasterJobBudgetMaterialCost { get; set; }
        public double? JobMasterJobMaterialCost { get; set; }
        public double? JobMasterJobMaterialCostVar { get; set; }
        public double? JobMasterJobBugetLabourCost { get; set; }
        public double? JobMasterJobLabourCost { get; set; }
        public double? JobMasterJobLabourCostVar { get; set; }
        public double? JobMasterJobBudgetOverHeadCost { get; set; }
        public double? JobMasterJobOverHeadCost { get; set; }
        public double? JobMasterJobOverHeadCostVar { get; set; }
        public double? JobMasterJobMiscCost { get; set; }
        public double? JobMasterJobTotalCost { get; set; }
        public double? JobMasterJobProfit { get; set; }
        public double? JobMasterJobTotalInvValue { get; set; }
        public double? JobMasterJobTotalPayValue { get; set; }
        public double? JobMasterJobTotalRecValue { get; set; }
        public double? JobMasterJobTotalExpValue { get; set; }
        public string JobMasterJobContractorName { get; set; }
        public string JobMasterJobContractType { get; set; }
        public DateTime? JobMasterJobCommenceDate { get; set; }
        public int? JobMasterJobWorkingDays { get; set; }
        public DateTime? JobMasterJobOrgCompleteDate { get; set; }
        public int? JobMasterJobPayTermDays { get; set; }
        public double? JobMasterJobAdvanceAmount { get; set; }
        public bool? JobMasterJobDelStatus { get; set; }
    }
}
