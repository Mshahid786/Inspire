using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Inspire.Erp.Application.Master;
using Inspire.Erp.Application.Account.Interfaces;
using Inspire.Erp.Domain.Entities;
using Inspire.Erp.Web.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Inspire.Erp.Application.Account;
using Inspire.Erp.Web.Common;

namespace Inspire.Erp.Web.Controllers
{
    [Route("api/account")]
    [Produces("application/json")]
    [ApiController]
    public class ChartofAccountsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private   IChartofAccountsService  chartofAccountsService;
        public ChartofAccountsController(IChartofAccountsService _chartofAccountsService, IMapper mapper)
        {

            chartofAccountsService = _chartofAccountsService;
            _mapper = mapper;
        }
        [HttpGet]
        [Route("GetAllAccounts")]
        public ApiResponse<List<ChartofAccountsViewModel>> GetAllAccounts()
        {
            IEnumerable<MasterAccountsTable> masterAccountsTables = chartofAccountsService.GetAllAccounts();

            ApiResponse<List<ChartofAccountsViewModel>> apiResponse = new ApiResponse<List<ChartofAccountsViewModel>>
            {
                Valid = true,
                Result = _mapper.Map<List<ChartofAccountsViewModel>>(masterAccountsTables),
                Message = ""
            };
            return apiResponse;
        }


        [HttpGet("{id}", Name = "GetAllAccountsById")]
        [Route("GetAllAccountsById/{id}")]
        public List<ChartofAccountsViewModel> GetAllAccountsById(int id)
        {
            return chartofAccountsService.GetAllAccountsById(id).Select(k => new ChartofAccountsViewModel
            {

                MasterAccountsTableSno = k.MasterAccountsTableSno,
                MasterAccountsTableRelativeNo = k.MasterAccountsTableRelativeNo,
                MasterAccountsTableAccNo = k.MasterAccountsTableAccNo,
                MasterAccountsTableAccName = k.MasterAccountsTableAccName,
                MasterAccountsTableAccType = k.MasterAccountsTableAccType,
                MasterAccountsTableMainHead = k.MasterAccountsTableMainHead,
                MasterAccountsTableSubHead = k.MasterAccountsTableSubHead,
                MasterAccountsTableImageKey = k.MasterAccountsTableImageKey,
                MasterAccountsTableSystemAcc = k.MasterAccountsTableSystemAcc,
                MasterAccountsTableFsno = k.MasterAccountsTableFsno,
                MasterAccountsTableStatus = k.MasterAccountsTableStatus,
                MasterAccountsTableUserId = k.MasterAccountsTableUserId,
                MasterAccountsTableDateCreated = k.MasterAccountsTableDateCreated,
                MasterAccountsTableCurrencyId = k.MasterAccountsTableCurrencyId,
                MasterAccountsTableGpAcc = k.MasterAccountsTableGpAcc,
                MasterAccountsTableAcAcc = k.MasterAccountsTableAcAcc,
                MasterAccountsTableEdAcc = k.MasterAccountsTableEdAcc,
                MasterAccountsTableOpenBalance = k.MasterAccountsTableOpenBalance,
                MasterAccountsTableTotalDebit = k.MasterAccountsTableTotalDebit,
                MasterAccountsTableTotalCredit = k.MasterAccountsTableTotalCredit,
                MasterAccountsTableManualCode = k.MasterAccountsTableManualCode,
                MasterAccountsTableIsAirAcc = k.MasterAccountsTableIsAirAcc,
                MasterAccountsTableIsSeaAcc = k.MasterAccountsTableIsSeaAcc,
                MasterAccountsTableCostCenterId = k.MasterAccountsTableCostCenterId,
                //MasterAccountsTableCostCenterSub = k.MasterAccountsTableCostCenterSub,
                MasterAccountsTableSortNo = k.MasterAccountsTableSortNo,
                MasterAccountsTableShowSuminTb = k.MasterAccountsTableShowSuminTb,
                MasterAccountsTableAssetValue = k.MasterAccountsTableAssetValue,
                MasterAccountsTableAssetDepValue = k.MasterAccountsTableAssetDepValue,
                MasterAccountsTableAssetQty = k.MasterAccountsTableAssetQty,
                MasterAccountsTableLifeInYrs = k.MasterAccountsTableLifeInYrs,
                MasterAccountsTableAssetDepMode = k.MasterAccountsTableAssetDepMode,
                MasterAccountsTableAssetDate = k.MasterAccountsTableAssetDate,
                MasterAccountsTableIsAsset = k.MasterAccountsTableIsAsset,
                //MasterAccountsTableDelStatus = k.MasterAccountsTableDelStatus

            }).ToList();
        }

        [HttpPost]
        [Route("InsertAccounts")]
        public List<ChartofAccountsViewModel> InsertBrand([FromBody] ChartofAccountsViewModel masterAccountsTable)
        {
            var result = _mapper.Map<MasterAccountsTable>(masterAccountsTable);
            return chartofAccountsService.InsertAccounts(result).Select(k => new ChartofAccountsViewModel
            {
                MasterAccountsTableSno = k.MasterAccountsTableSno,
                MasterAccountsTableRelativeNo = k.MasterAccountsTableRelativeNo,
                MasterAccountsTableAccNo = k.MasterAccountsTableAccNo,
                MasterAccountsTableAccName = k.MasterAccountsTableAccName,
                MasterAccountsTableAccType = k.MasterAccountsTableAccType,
                MasterAccountsTableMainHead = k.MasterAccountsTableMainHead,
                MasterAccountsTableSubHead = k.MasterAccountsTableSubHead,
                MasterAccountsTableImageKey = k.MasterAccountsTableImageKey,
                MasterAccountsTableSystemAcc = k.MasterAccountsTableSystemAcc,
                MasterAccountsTableFsno = k.MasterAccountsTableFsno,
                MasterAccountsTableStatus = k.MasterAccountsTableStatus,
                MasterAccountsTableUserId = k.MasterAccountsTableUserId,
                MasterAccountsTableDateCreated = k.MasterAccountsTableDateCreated,
                MasterAccountsTableCurrencyId = k.MasterAccountsTableCurrencyId,
                MasterAccountsTableGpAcc = k.MasterAccountsTableGpAcc,
                MasterAccountsTableAcAcc = k.MasterAccountsTableAcAcc,
                MasterAccountsTableEdAcc = k.MasterAccountsTableEdAcc,
                MasterAccountsTableOpenBalance = k.MasterAccountsTableOpenBalance,
                MasterAccountsTableTotalDebit = k.MasterAccountsTableTotalDebit,
                MasterAccountsTableTotalCredit = k.MasterAccountsTableTotalCredit,
                MasterAccountsTableManualCode = k.MasterAccountsTableManualCode,
                MasterAccountsTableIsAirAcc = k.MasterAccountsTableIsAirAcc,
                MasterAccountsTableIsSeaAcc = k.MasterAccountsTableIsSeaAcc,
                MasterAccountsTableCostCenterId = k.MasterAccountsTableCostCenterId,
                //MasterAccountsTableCostCenterSub = k.MasterAccountsTableCostCenterSub,
                MasterAccountsTableSortNo = k.MasterAccountsTableSortNo,
                MasterAccountsTableShowSuminTb = k.MasterAccountsTableShowSuminTb,
                MasterAccountsTableAssetValue = k.MasterAccountsTableAssetValue,
                MasterAccountsTableAssetDepValue = k.MasterAccountsTableAssetDepValue,
                MasterAccountsTableAssetQty = k.MasterAccountsTableAssetQty,
                MasterAccountsTableLifeInYrs = k.MasterAccountsTableLifeInYrs,
                MasterAccountsTableAssetDepMode = k.MasterAccountsTableAssetDepMode,
                MasterAccountsTableAssetDate = k.MasterAccountsTableAssetDate,
                MasterAccountsTableIsAsset = k.MasterAccountsTableIsAsset,
                //MasterAccountsTableDelStatus = k.MasterAccountsTableDelStatus
            }).ToList();
        }

        [HttpPost]
        [Route("UpdateAccounts")]
        public List<ChartofAccountsViewModel> UpdateAccounts([FromBody] ChartofAccountsViewModel masterAccountsTable)
        {
            var result = _mapper.Map<MasterAccountsTable>(masterAccountsTable);
            return chartofAccountsService.UpdateAccounts(result).Select(k => new ChartofAccountsViewModel
            {
                MasterAccountsTableSno = k.MasterAccountsTableSno,
                MasterAccountsTableRelativeNo = k.MasterAccountsTableRelativeNo,
                MasterAccountsTableAccNo = k.MasterAccountsTableAccNo,
                MasterAccountsTableAccName = k.MasterAccountsTableAccName,
                MasterAccountsTableAccType = k.MasterAccountsTableAccType,
                MasterAccountsTableMainHead = k.MasterAccountsTableMainHead,
                MasterAccountsTableSubHead = k.MasterAccountsTableSubHead,
                MasterAccountsTableImageKey = k.MasterAccountsTableImageKey,
                MasterAccountsTableSystemAcc = k.MasterAccountsTableSystemAcc,
                MasterAccountsTableFsno = k.MasterAccountsTableFsno,
                MasterAccountsTableStatus = k.MasterAccountsTableStatus,
                MasterAccountsTableUserId = k.MasterAccountsTableUserId,
                MasterAccountsTableDateCreated = k.MasterAccountsTableDateCreated,
                MasterAccountsTableCurrencyId = k.MasterAccountsTableCurrencyId,
                MasterAccountsTableGpAcc = k.MasterAccountsTableGpAcc,
                MasterAccountsTableAcAcc = k.MasterAccountsTableAcAcc,
                MasterAccountsTableEdAcc = k.MasterAccountsTableEdAcc,
                MasterAccountsTableOpenBalance = k.MasterAccountsTableOpenBalance,
                MasterAccountsTableTotalDebit = k.MasterAccountsTableTotalDebit,
                MasterAccountsTableTotalCredit = k.MasterAccountsTableTotalCredit,
                MasterAccountsTableManualCode = k.MasterAccountsTableManualCode,
                MasterAccountsTableIsAirAcc = k.MasterAccountsTableIsAirAcc,
                MasterAccountsTableIsSeaAcc = k.MasterAccountsTableIsSeaAcc,
                MasterAccountsTableCostCenterId = k.MasterAccountsTableCostCenterId,
                //MasterAccountsTableCostCenterSub = k.MasterAccountsTableCostCenterSub,
                MasterAccountsTableSortNo = k.MasterAccountsTableSortNo,
                MasterAccountsTableShowSuminTb = k.MasterAccountsTableShowSuminTb,
                MasterAccountsTableAssetValue = k.MasterAccountsTableAssetValue,
                MasterAccountsTableAssetDepValue = k.MasterAccountsTableAssetDepValue,
                MasterAccountsTableAssetQty = k.MasterAccountsTableAssetQty,
                MasterAccountsTableLifeInYrs = k.MasterAccountsTableLifeInYrs,
                MasterAccountsTableAssetDepMode = k.MasterAccountsTableAssetDepMode,
                MasterAccountsTableAssetDate = k.MasterAccountsTableAssetDate,
                MasterAccountsTableIsAsset = k.MasterAccountsTableIsAsset,
                //MasterAccountsTableDelStatus = k.MasterAccountsTableDelStatus
            }).ToList();
        }

        [HttpPost]
        [Route("DeleteAccounts")]
        public List<ChartofAccountsViewModel> DeleteBrand([FromBody] ChartofAccountsViewModel masterAccountsTable)
        {
            var result = _mapper.Map<MasterAccountsTable>(masterAccountsTable);
            return chartofAccountsService.DeleteAccounts(result).Select(k => new ChartofAccountsViewModel
            {
                MasterAccountsTableSno = k.MasterAccountsTableSno,
                MasterAccountsTableRelativeNo = k.MasterAccountsTableRelativeNo,
                MasterAccountsTableAccNo = k.MasterAccountsTableAccNo,
                MasterAccountsTableAccName = k.MasterAccountsTableAccName,
                MasterAccountsTableAccType = k.MasterAccountsTableAccType,
                MasterAccountsTableMainHead = k.MasterAccountsTableMainHead,
                MasterAccountsTableSubHead = k.MasterAccountsTableSubHead,
                MasterAccountsTableImageKey = k.MasterAccountsTableImageKey,
                MasterAccountsTableSystemAcc = k.MasterAccountsTableSystemAcc,
                MasterAccountsTableFsno = k.MasterAccountsTableFsno,
                MasterAccountsTableStatus = k.MasterAccountsTableStatus,
                MasterAccountsTableUserId = k.MasterAccountsTableUserId,
                MasterAccountsTableDateCreated = k.MasterAccountsTableDateCreated,
                MasterAccountsTableCurrencyId = k.MasterAccountsTableCurrencyId,
                MasterAccountsTableGpAcc = k.MasterAccountsTableGpAcc,
                MasterAccountsTableAcAcc = k.MasterAccountsTableAcAcc,
                MasterAccountsTableEdAcc = k.MasterAccountsTableEdAcc,
                MasterAccountsTableOpenBalance = k.MasterAccountsTableOpenBalance,
                MasterAccountsTableTotalDebit = k.MasterAccountsTableTotalDebit,
                MasterAccountsTableTotalCredit = k.MasterAccountsTableTotalCredit,
                MasterAccountsTableManualCode = k.MasterAccountsTableManualCode,
                MasterAccountsTableCostCenterId = k.MasterAccountsTableCostCenterId,
                MasterAccountsTableShowSuminTb = k.MasterAccountsTableShowSuminTb,
                MasterAccountsTableAssetValue = k.MasterAccountsTableAssetValue,
                MasterAccountsTableAssetDepValue = k.MasterAccountsTableAssetDepValue,
                MasterAccountsTableAssetQty = k.MasterAccountsTableAssetQty,
                MasterAccountsTableLifeInYrs = k.MasterAccountsTableLifeInYrs,
                MasterAccountsTableAssetDepMode = k.MasterAccountsTableAssetDepMode,
                MasterAccountsTableAssetDate = k.MasterAccountsTableAssetDate,
                MasterAccountsTableIsAsset = k.MasterAccountsTableIsAsset,
                MasterAccountsTableIsSeaAcc = k.MasterAccountsTableIsSeaAcc,
                MasterAccountsTableIsAirAcc = k.MasterAccountsTableIsAirAcc,
                //MasterAccountsTableDelStatus = k.MasterAccountsTableDelStatus
            }).ToList();
        }
    }
}