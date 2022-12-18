using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Inspire.Erp.Application.Master;
using Inspire.Erp.Domain.Entities;
using Inspire.Erp.Web.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Inspire.Erp.Web.Controllers
{
    [Route("api")]
    [Produces("application/json")]
    [ApiController]
    public class JobController : ControllerBase
    {
        private readonly IMapper _mapper;
        private IJobMasterService jobMasterService;
        public JobController(IJobMasterService _jobMasterService, IMapper mapper)
        {
            jobMasterService = _jobMasterService;
            _mapper = mapper;
        }
        [HttpGet]
        [Route("GetAllJob")]
        public List<JobMasterViewModel> GetAllJob()
        {
            return jobMasterService.GetAllJob().Select(k => new JobMasterViewModel
            {

                JobMasterJobId = k.JobMasterJobId,
                JobMasterJobName = k.JobMasterJobName,
                JobMasterJobDate = k.JobMasterJobDate,
                JobMasterJobValue = k.JobMasterJobValue,
                JobMasterJobRetention = k.JobMasterJobRetention,
                JobMasterJobBalance = k.JobMasterJobBalance,
                JobMasterJobStatus = k.JobMasterJobStatus,
                JobMasterJobConsultant = k.JobMasterJobConsultant,
                JobMasterJobRemarks = k.JobMasterJobRemarks,
                JobMasterJobCustomerId = k.JobMasterJobCustomerId,
                JobMasterJobCurrencyId = k.JobMasterJobCurrencyId,
                JobMasterJobCurVal = k.JobMasterJobCurVal,
                JobMasterJobOpenInv = k.JobMasterJobOpenInv,
                JobMasterJobPerInv = k.JobMasterJobPerInv,
                JobMasterJobConsultantReff = k.JobMasterJobConsultantReff,
                JobMasterJobStatusVal = k.JobMasterJobStatusVal,
                JobMasterJobType = k.JobMasterJobType,
                JobMasterJobRelativeNo = k.JobMasterJobRelativeNo,
                JobMasterJobCode = k.JobMasterJobCode,
                JobMasterJobSupplierId = k.JobMasterJobSupplierId,
                JobMasterJobSalesManId = k.JobMasterJobSalesManId,
                JobMasterJobNumber = k.JobMasterJobNumber,
                JobMasterJobIsSubJob = k.JobMasterJobIsSubJob,
                JobMasterJobRetentionPercentage = k.JobMasterJobRetentionPercentage,
                JobMasterJobSalesMan = k.JobMasterJobSalesMan,
                JobMasterJobBudgetMaterialCost = k.JobMasterJobBudgetMaterialCost,
                JobMasterJobMaterialCost = k.JobMasterJobMaterialCost,
                JobMasterJobMaterialCostVar = k.JobMasterJobMaterialCostVar,
                JobMasterJobBugetLabourCost = k.JobMasterJobBugetLabourCost,
                JobMasterJobLabourCost = k.JobMasterJobLabourCost,
                JobMasterJobLabourCostVar = k.JobMasterJobLabourCostVar,
                JobMasterJobBudgetOverHeadCost = k.JobMasterJobBudgetOverHeadCost,
                JobMasterJobOverHeadCost = k.JobMasterJobOverHeadCost,
                JobMasterJobOverHeadCostVar = k.JobMasterJobOverHeadCostVar,
                JobMasterJobMiscCost = k.JobMasterJobMiscCost,
                JobMasterJobTotalCost = k.JobMasterJobTotalCost,
                JobMasterJobProfit = k.JobMasterJobProfit,
                JobMasterJobTotalInvValue = k.JobMasterJobTotalInvValue,
                JobMasterJobTotalPayValue = k.JobMasterJobTotalPayValue,
                JobMasterJobTotalRecValue = k.JobMasterJobTotalRecValue,
                JobMasterJobTotalExpValue = k.JobMasterJobTotalExpValue,
                JobMasterJobContractorName = k.JobMasterJobContractorName,
                JobMasterJobContractType = k.JobMasterJobContractType,
                JobMasterJobCommenceDate = k.JobMasterJobCommenceDate,
                JobMasterJobWorkingDays = k.JobMasterJobWorkingDays,
                JobMasterJobOrgCompleteDate = k.JobMasterJobOrgCompleteDate,
                JobMasterJobPayTermDays = k.JobMasterJobPayTermDays,
                JobMasterJobAdvanceAmount = k.JobMasterJobAdvanceAmount,
                JobMasterJobDelStatus = k.JobMasterJobDelStatus


            }).ToList();
        }


        [HttpGet("{id}", Name = "GetAllJobById")]
        [Route("GetAllJobById/{id}")]
        public List<JobMasterViewModel> GetAllJobById(int id)
        {
            return jobMasterService.GetAllJobById(id).Select(k => new JobMasterViewModel
            {

                JobMasterJobId = k.JobMasterJobId,
                JobMasterJobName = k.JobMasterJobName,
                JobMasterJobDate = k.JobMasterJobDate,
                JobMasterJobValue = k.JobMasterJobValue,
                JobMasterJobRetention = k.JobMasterJobRetention,
                JobMasterJobBalance = k.JobMasterJobBalance,
                JobMasterJobStatus = k.JobMasterJobStatus,
                JobMasterJobConsultant = k.JobMasterJobConsultant,
                JobMasterJobRemarks = k.JobMasterJobRemarks,
                JobMasterJobCustomerId = k.JobMasterJobCustomerId,
                JobMasterJobCurrencyId = k.JobMasterJobCurrencyId,
                JobMasterJobCurVal = k.JobMasterJobCurVal,
                JobMasterJobOpenInv = k.JobMasterJobOpenInv,
                JobMasterJobPerInv = k.JobMasterJobPerInv,
                JobMasterJobConsultantReff = k.JobMasterJobConsultantReff,
                JobMasterJobStatusVal = k.JobMasterJobStatusVal,
                JobMasterJobType = k.JobMasterJobType,
                JobMasterJobRelativeNo = k.JobMasterJobRelativeNo,
                JobMasterJobCode = k.JobMasterJobCode,
                JobMasterJobSupplierId = k.JobMasterJobSupplierId,
                JobMasterJobSalesManId = k.JobMasterJobSalesManId,
                JobMasterJobNumber = k.JobMasterJobNumber,
                JobMasterJobIsSubJob = k.JobMasterJobIsSubJob,
                JobMasterJobRetentionPercentage = k.JobMasterJobRetentionPercentage,
                JobMasterJobSalesMan = k.JobMasterJobSalesMan,
                JobMasterJobBudgetMaterialCost = k.JobMasterJobBudgetMaterialCost,
                JobMasterJobMaterialCost = k.JobMasterJobMaterialCost,
                JobMasterJobMaterialCostVar = k.JobMasterJobMaterialCostVar,
                JobMasterJobBugetLabourCost = k.JobMasterJobBugetLabourCost,
                JobMasterJobLabourCost = k.JobMasterJobLabourCost,
                JobMasterJobLabourCostVar = k.JobMasterJobLabourCostVar,
                JobMasterJobBudgetOverHeadCost = k.JobMasterJobBudgetOverHeadCost,
                JobMasterJobOverHeadCost = k.JobMasterJobOverHeadCost,
                JobMasterJobOverHeadCostVar = k.JobMasterJobOverHeadCostVar,
                JobMasterJobMiscCost = k.JobMasterJobMiscCost,
                JobMasterJobTotalCost = k.JobMasterJobTotalCost,
                JobMasterJobProfit = k.JobMasterJobProfit,
                JobMasterJobTotalInvValue = k.JobMasterJobTotalInvValue,
                JobMasterJobTotalPayValue = k.JobMasterJobTotalPayValue,
                JobMasterJobTotalRecValue = k.JobMasterJobTotalRecValue,
                JobMasterJobTotalExpValue = k.JobMasterJobTotalExpValue,
                JobMasterJobContractorName = k.JobMasterJobContractorName,
                JobMasterJobContractType = k.JobMasterJobContractType,
                JobMasterJobCommenceDate = k.JobMasterJobCommenceDate,
                JobMasterJobWorkingDays = k.JobMasterJobWorkingDays,
                JobMasterJobOrgCompleteDate = k.JobMasterJobOrgCompleteDate,
                JobMasterJobPayTermDays = k.JobMasterJobPayTermDays,
                JobMasterJobAdvanceAmount = k.JobMasterJobAdvanceAmount,
                JobMasterJobDelStatus = k.JobMasterJobDelStatus


            }).ToList();
        }

        [HttpPost]
        [Route("InsertJob")]
        public List<JobMasterViewModel> InsertJob([FromBody] JobMasterViewModel jobMaster)
        {
            var result = _mapper.Map<JobMaster>(jobMaster);
            return jobMasterService.InsertJob(result).Select(k => new JobMasterViewModel
            {
                JobMasterJobId = k.JobMasterJobId,
                JobMasterJobName = k.JobMasterJobName,
                JobMasterJobDate = k.JobMasterJobDate,
                JobMasterJobValue = k.JobMasterJobValue,
                JobMasterJobRetention = k.JobMasterJobRetention,
                JobMasterJobBalance = k.JobMasterJobBalance,
                JobMasterJobStatus = k.JobMasterJobStatus,
                JobMasterJobConsultant = k.JobMasterJobConsultant,
                JobMasterJobRemarks = k.JobMasterJobRemarks,
                JobMasterJobCustomerId = k.JobMasterJobCustomerId,
                JobMasterJobCurrencyId = k.JobMasterJobCurrencyId,
                JobMasterJobCurVal = k.JobMasterJobCurVal,
                JobMasterJobOpenInv = k.JobMasterJobOpenInv,
                JobMasterJobPerInv = k.JobMasterJobPerInv,
                JobMasterJobConsultantReff = k.JobMasterJobConsultantReff,
                JobMasterJobStatusVal = k.JobMasterJobStatusVal,
                JobMasterJobType = k.JobMasterJobType,
                JobMasterJobRelativeNo = k.JobMasterJobRelativeNo,
                JobMasterJobCode = k.JobMasterJobCode,
                JobMasterJobSupplierId = k.JobMasterJobSupplierId,
                JobMasterJobSalesManId = k.JobMasterJobSalesManId,
                JobMasterJobNumber = k.JobMasterJobNumber,
                JobMasterJobIsSubJob = k.JobMasterJobIsSubJob,
                JobMasterJobRetentionPercentage = k.JobMasterJobRetentionPercentage,
                JobMasterJobSalesMan = k.JobMasterJobSalesMan,
                JobMasterJobBudgetMaterialCost = k.JobMasterJobBudgetMaterialCost,
                JobMasterJobMaterialCost = k.JobMasterJobMaterialCost,
                JobMasterJobMaterialCostVar = k.JobMasterJobMaterialCostVar,
                JobMasterJobBugetLabourCost = k.JobMasterJobBugetLabourCost,
                JobMasterJobLabourCost = k.JobMasterJobLabourCost,
                JobMasterJobLabourCostVar = k.JobMasterJobLabourCostVar,
                JobMasterJobBudgetOverHeadCost = k.JobMasterJobBudgetOverHeadCost,
                JobMasterJobOverHeadCost = k.JobMasterJobOverHeadCost,
                JobMasterJobOverHeadCostVar = k.JobMasterJobOverHeadCostVar,
                JobMasterJobMiscCost = k.JobMasterJobMiscCost,
                JobMasterJobTotalCost = k.JobMasterJobTotalCost,
                JobMasterJobProfit = k.JobMasterJobProfit,
                JobMasterJobTotalInvValue = k.JobMasterJobTotalInvValue,
                JobMasterJobTotalPayValue = k.JobMasterJobTotalPayValue,
                JobMasterJobTotalRecValue = k.JobMasterJobTotalRecValue,
                JobMasterJobTotalExpValue = k.JobMasterJobTotalExpValue,
                JobMasterJobContractorName = k.JobMasterJobContractorName,
                JobMasterJobContractType = k.JobMasterJobContractType,
                JobMasterJobCommenceDate = k.JobMasterJobCommenceDate,
                JobMasterJobWorkingDays = k.JobMasterJobWorkingDays,
                JobMasterJobOrgCompleteDate = k.JobMasterJobOrgCompleteDate,
                JobMasterJobPayTermDays = k.JobMasterJobPayTermDays,
                JobMasterJobAdvanceAmount = k.JobMasterJobAdvanceAmount,
                JobMasterJobDelStatus = k.JobMasterJobDelStatus


            }).ToList();
        }
        [HttpPost]
        [Route("UpdateJob")]
        public List<JobMasterViewModel> UpdateJob([FromBody] JobMasterViewModel jobMaster)
        {
            var result = _mapper.Map<JobMaster>(jobMaster);
            return jobMasterService.UpdateJob(result).Select(k => new JobMasterViewModel
            {
                JobMasterJobId = k.JobMasterJobId,
                JobMasterJobName = k.JobMasterJobName,
                JobMasterJobDate = k.JobMasterJobDate,
                JobMasterJobValue = k.JobMasterJobValue,
                JobMasterJobRetention = k.JobMasterJobRetention,
                JobMasterJobBalance = k.JobMasterJobBalance,
                JobMasterJobStatus = k.JobMasterJobStatus,
                JobMasterJobConsultant = k.JobMasterJobConsultant,
                JobMasterJobRemarks = k.JobMasterJobRemarks,
                JobMasterJobCustomerId = k.JobMasterJobCustomerId,
                JobMasterJobCurrencyId = k.JobMasterJobCurrencyId,
                JobMasterJobCurVal = k.JobMasterJobCurVal,
                JobMasterJobOpenInv = k.JobMasterJobOpenInv,
                JobMasterJobPerInv = k.JobMasterJobPerInv,
                JobMasterJobConsultantReff = k.JobMasterJobConsultantReff,
                JobMasterJobStatusVal = k.JobMasterJobStatusVal,
                JobMasterJobType = k.JobMasterJobType,
                JobMasterJobRelativeNo = k.JobMasterJobRelativeNo,
                JobMasterJobCode = k.JobMasterJobCode,
                JobMasterJobSupplierId = k.JobMasterJobSupplierId,
                JobMasterJobSalesManId = k.JobMasterJobSalesManId,
                JobMasterJobNumber = k.JobMasterJobNumber,
                JobMasterJobIsSubJob = k.JobMasterJobIsSubJob,
                JobMasterJobRetentionPercentage = k.JobMasterJobRetentionPercentage,
                JobMasterJobSalesMan = k.JobMasterJobSalesMan,
                JobMasterJobBudgetMaterialCost = k.JobMasterJobBudgetMaterialCost,
                JobMasterJobMaterialCost = k.JobMasterJobMaterialCost,
                JobMasterJobMaterialCostVar = k.JobMasterJobMaterialCostVar,
                JobMasterJobBugetLabourCost = k.JobMasterJobBugetLabourCost,
                JobMasterJobLabourCost = k.JobMasterJobLabourCost,
                JobMasterJobLabourCostVar = k.JobMasterJobLabourCostVar,
                JobMasterJobBudgetOverHeadCost = k.JobMasterJobBudgetOverHeadCost,
                JobMasterJobOverHeadCost = k.JobMasterJobOverHeadCost,
                JobMasterJobOverHeadCostVar = k.JobMasterJobOverHeadCostVar,
                JobMasterJobMiscCost = k.JobMasterJobMiscCost,
                JobMasterJobTotalCost = k.JobMasterJobTotalCost,
                JobMasterJobProfit = k.JobMasterJobProfit,
                JobMasterJobTotalInvValue = k.JobMasterJobTotalInvValue,
                JobMasterJobTotalPayValue = k.JobMasterJobTotalPayValue,
                JobMasterJobTotalRecValue = k.JobMasterJobTotalRecValue,
                JobMasterJobTotalExpValue = k.JobMasterJobTotalExpValue,
                JobMasterJobContractorName = k.JobMasterJobContractorName,
                JobMasterJobContractType = k.JobMasterJobContractType,
                JobMasterJobCommenceDate = k.JobMasterJobCommenceDate,
                JobMasterJobWorkingDays = k.JobMasterJobWorkingDays,
                JobMasterJobOrgCompleteDate = k.JobMasterJobOrgCompleteDate,
                JobMasterJobPayTermDays = k.JobMasterJobPayTermDays,
                JobMasterJobAdvanceAmount = k.JobMasterJobAdvanceAmount,
                JobMasterJobDelStatus = k.JobMasterJobDelStatus


            }).ToList();
        }
        [HttpPost]
        [Route("DeleteJob")]
        public List<JobMasterViewModel> DeleteJob([FromBody] JobMasterViewModel jobMaster)
        {
            var result = _mapper.Map<JobMaster>(jobMaster);
            return jobMasterService.DeleteJob(result).Select(k => new JobMasterViewModel
            {
                JobMasterJobId = k.JobMasterJobId,
                JobMasterJobName = k.JobMasterJobName,
                JobMasterJobDate = k.JobMasterJobDate,
                JobMasterJobValue = k.JobMasterJobValue,
                JobMasterJobRetention = k.JobMasterJobRetention,
                JobMasterJobBalance = k.JobMasterJobBalance,
                JobMasterJobStatus = k.JobMasterJobStatus,
                JobMasterJobConsultant = k.JobMasterJobConsultant,
                JobMasterJobRemarks = k.JobMasterJobRemarks,
                JobMasterJobCustomerId = k.JobMasterJobCustomerId,
                JobMasterJobCurrencyId = k.JobMasterJobCurrencyId,
                JobMasterJobCurVal = k.JobMasterJobCurVal,
                JobMasterJobOpenInv = k.JobMasterJobOpenInv,
                JobMasterJobPerInv = k.JobMasterJobPerInv,
                JobMasterJobConsultantReff = k.JobMasterJobConsultantReff,
                JobMasterJobStatusVal = k.JobMasterJobStatusVal,
                JobMasterJobType = k.JobMasterJobType,
                JobMasterJobRelativeNo = k.JobMasterJobRelativeNo,
                JobMasterJobCode = k.JobMasterJobCode,
                JobMasterJobSupplierId = k.JobMasterJobSupplierId,
                JobMasterJobSalesManId = k.JobMasterJobSalesManId,
                JobMasterJobNumber = k.JobMasterJobNumber,
                JobMasterJobIsSubJob = k.JobMasterJobIsSubJob,
                JobMasterJobRetentionPercentage = k.JobMasterJobRetentionPercentage,
                JobMasterJobSalesMan = k.JobMasterJobSalesMan,
                JobMasterJobBudgetMaterialCost = k.JobMasterJobBudgetMaterialCost,
                JobMasterJobMaterialCost = k.JobMasterJobMaterialCost,
                JobMasterJobMaterialCostVar = k.JobMasterJobMaterialCostVar,
                JobMasterJobBugetLabourCost = k.JobMasterJobBugetLabourCost,
                JobMasterJobLabourCost = k.JobMasterJobLabourCost,
                JobMasterJobLabourCostVar = k.JobMasterJobLabourCostVar,
                JobMasterJobBudgetOverHeadCost = k.JobMasterJobBudgetOverHeadCost,
                JobMasterJobOverHeadCost = k.JobMasterJobOverHeadCost,
                JobMasterJobOverHeadCostVar = k.JobMasterJobOverHeadCostVar,
                JobMasterJobMiscCost = k.JobMasterJobMiscCost,
                JobMasterJobTotalCost = k.JobMasterJobTotalCost,
                JobMasterJobProfit = k.JobMasterJobProfit,
                JobMasterJobTotalInvValue = k.JobMasterJobTotalInvValue,
                JobMasterJobTotalPayValue = k.JobMasterJobTotalPayValue,
                JobMasterJobTotalRecValue = k.JobMasterJobTotalRecValue,
                JobMasterJobTotalExpValue = k.JobMasterJobTotalExpValue,
                JobMasterJobContractorName = k.JobMasterJobContractorName,
                JobMasterJobContractType = k.JobMasterJobContractType,
                JobMasterJobCommenceDate = k.JobMasterJobCommenceDate,
                JobMasterJobWorkingDays = k.JobMasterJobWorkingDays,
                JobMasterJobOrgCompleteDate = k.JobMasterJobOrgCompleteDate,
                JobMasterJobPayTermDays = k.JobMasterJobPayTermDays,
                JobMasterJobAdvanceAmount = k.JobMasterJobAdvanceAmount,
                JobMasterJobDelStatus = k.JobMasterJobDelStatus


            }).ToList();
        }

    }
}
