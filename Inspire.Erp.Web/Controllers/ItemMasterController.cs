using AutoMapper;
using Inspire.Erp.Application.Master;
using Inspire.Erp.Domain.Entities;
using Inspire.Erp.Domain.Enums;
using Inspire.Erp.Web.Common;
using Inspire.Erp.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Inspire.Erp.Web.Controllers
{
    [Route("api/master")]
    [Produces("application/json")]
    [ApiController]
    public class ItemMasterController : ControllerBase
    {
        private readonly IMapper _mapper;
        private IItemMasterService itemMasterService;
        public ItemMasterController(IItemMasterService _itemMasterService, IMapper mapper)
        {

            itemMasterService = _itemMasterService;
            _mapper = mapper;
        }
        [HttpGet]
        [Route("GetAllItem")]
        public ApiResponse<List<ItemMasterViewModel>> GetAllItem()
        {
            IEnumerable<ItemMaster> listItemnater = itemMasterService.GetAllItem();
            var x = _mapper.Map<List<ItemMasterViewModel>>(listItemnater);
            ApiResponse<List<ItemMasterViewModel>> apiResponse = new ApiResponse<List<ItemMasterViewModel>>
            {
                Valid = true,
                Result = x,
                Message = ""
            };

            return apiResponse;
        }

        [HttpGet]
        [Route("GetAllItemNotGroup")]
        public ApiResponse<List<ItemMasterViewModel>> GetAllItemNotGroup()
        {
            IEnumerable<ItemMaster> listItemnater = itemMasterService.GetAllItemNotGroup();
            var x = _mapper.Map<List<ItemMasterViewModel>>(listItemnater);
            ApiResponse<List<ItemMasterViewModel>> apiResponse = new ApiResponse<List<ItemMasterViewModel>>
            {
                Valid = true,
                Result = x,
                Message = ""
            };

            return apiResponse;
        }

        [HttpGet]
        [Route("GetAllItemStockType")]
        public ApiResponse<List<ItemStockTypeViewModel>> GetAllItemStockType()
        {
            IEnumerable<ItemStockType> listItemnater = itemMasterService.GetAllStockType();
            var x = _mapper.Map<List<ItemStockTypeViewModel>>(listItemnater);
            ApiResponse<List<ItemStockTypeViewModel>> apiResponse = new ApiResponse<List<ItemStockTypeViewModel>>
            {
                Valid = true,
                Result = x,
                Message = ""
            };

            return apiResponse;
        }

        [HttpGet("{id}", Name= "GetAllItemById")]
        [Route("GetAllItemById/{id}")]
        public ApiResponse<List<ItemMasterViewModel>> GetAllItemById(int id)
        {
            IEnumerable<ItemMaster> listItemnater = itemMasterService.GetAllItemById(id);

            var x = _mapper.Map<List<ItemMasterViewModel>>(listItemnater);
            ApiResponse<List<ItemMasterViewModel>> apiResponse = new ApiResponse<List<ItemMasterViewModel>>
            {
                Valid = true,
                Result = x,
                Message = ""
            };

            return apiResponse;

        }


        [HttpGet("{id}", Name = "GetAllItemByName")]
        [Route("GetAllItemByName/{id}")]
        public ApiResponse<List<ItemMasterViewModel>> GetAllItemByName(string id)
        {
            IEnumerable<ItemMaster> listItemnater = itemMasterService.GetItemMastersByName(id);

            var x = _mapper.Map<List<ItemMasterViewModel>>(listItemnater);
            ApiResponse<List<ItemMasterViewModel>> apiResponse = new ApiResponse<List<ItemMasterViewModel>>
            {
                Valid = true,
                Result = x,
                Message = ""
            };

            return apiResponse;

        }

        [HttpPost]
        [Route("InsertItem")]
        public ApiResponse<List<ItemMasterViewModel>> InsertItem([FromBody] ItemMasterViewModel itemMaster)
        {
            var model = _mapper.Map<ItemMaster>(itemMaster);
            var data = itemMasterService.InsertItem(model);
            List<ItemMasterViewModel> result = itemMaster.ItemMasterItemType == null ? null: _mapper.Map<List<ItemMasterViewModel>>(data) ;
            ApiResponse<List<ItemMasterViewModel>> apiResponse = new ApiResponse<List<ItemMasterViewModel>>
            {
                Valid = true,
                Result = result,
                Message = ""
            };
            return apiResponse;
        }

        [HttpPost]
        [Route("UpdateItem")]
        public List<ItemMasterViewModel> UpdateBrand([FromBody] ItemMasterViewModel itemMaster)
        {
            var result = _mapper.Map<ItemMaster>(itemMaster);
            return itemMasterService.UpdateItem(result).Select(k => new ItemMasterViewModel
            {
                ItemMasterItemId = k.ItemMasterItemId,
                ItemMasterMaterialCode = k.ItemMasterMaterialCode,
                ItemMasterAccountNo = k.ItemMasterAccountNo,
                ItemMasterItemName = k.ItemMasterItemName,
                ItemMasterItemType = k.ItemMasterItemType,
                ItemMasterBatchCode = k.ItemMasterBatchCode,
                ItemMasterVenderId = k.ItemMasterVenderId,
                ItemMasterLocationId = k.ItemMasterLocationId,
                ItemMasterReOrderLevel = k.ItemMasterReOrderLevel,
                ItemMasterUnitPrice = k.ItemMasterUnitPrice,
                ItemMasterUnitPrice1 = k.ItemMasterUnitPrice1,
                ItemMasterUnitPrice2 = k.ItemMasterUnitPrice2,
                ItemMasterItemSize = k.ItemMasterItemSize,
                ItemMasterPartNo = k.ItemMasterPartNo,
                ItemMasterColor = k.ItemMasterColor,
                ItemMasterPacking = k.ItemMasterPacking,
                ItemMasterWeight = k.ItemMasterWeight,
                ItemMasterShape = k.ItemMasterShape,
                ItemMasterRef1 = k.ItemMasterRef1,
                ItemMasterRef2 = k.ItemMasterRef2,
                ItemMasterStockType = k.ItemMasterStockType,
                ItemMasterUnitId = k.ItemMasterUnitId,
                ItemMasterAssetAcc = k.ItemMasterAssetAcc,
                ItemMasterExpenseAcc = k.ItemMasterExpenseAcc,
                ItemMasterImage = k.ItemMasterImage,
                ItemMasterActive = k.ItemMasterActive,
                ItemMasterLastPurchasePrice = k.ItemMasterLastPurchasePrice,
                ItemMasterServices = k.ItemMasterServices,
                ItemMasterSuplierCode = k.ItemMasterSuplierCode,
                ItemMasterBarcode = k.ItemMasterBarcode,
                ItemMasterAliasName = k.ItemMasterAliasName,
                ItemMasterUserId = k.ItemMasterUserId,
                ItemMasterGroupDebitAcc = k.ItemMasterGroupDebitAcc,
                ItemMasterGroupCreditAcc = k.ItemMasterGroupCreditAcc,
                ItemMasterLandingCost = k.ItemMasterLandingCost,
                ItemMasterBaseValue = k.ItemMasterBaseValue,
                ItemMasterHeightN = k.ItemMasterHeightN,
                ItemMasterWeightN = k.ItemMasterWeightN,
                ItemMasterRackId = k.ItemMasterRackId,
                ItemMasterCurrentStock = k.ItemMasterCurrentStock,
                ItemMasterStatus = k.ItemMasterStatus,
                ItemMasterAvgCostYel = k.ItemMasterAvgCostYel,
                ItemMasterVat = k.ItemMasterVat,
                ItemMasterTypeId = k.ItemMasterTypeId,
                ItemMasterModelId = k.ItemMasterModelId,
                ItemMasterVatPercentage = k.ItemMasterVatPercentage,
                ItemMasterVatInclues = k.ItemMasterVatInclues,
                ItemMasterReorderCheck = k.ItemMasterReorderCheck,
                ItemMasterDefaultLocationName = k.ItemMasterDefaultLocationName,
                ItemMasterDefaultLocation = k.ItemMasterDefaultLocation,
                ItemMasterCountryId = k.ItemMasterCountryId,
                ItemMasterPackageId = k.ItemMasterPackageId,
                ItemMasterGenericName = k.ItemMasterGenericName,
                ItemMasterSupplierName = k.ItemMasterSupplierName,
                ItemMasterManufactureName = k.ItemMasterManufactureName,
                ItemMasterRedeemRewardPoint = k.ItemMasterRedeemRewardPoint,
                ItemMasterProPurchaseRate = k.ItemMasterProPurchaseRate,
                ItemMasterProSaleRate = k.ItemMasterProSaleRate,
                ItemMasterProMrp = k.ItemMasterProMrp,
                ItemMasterDelStatus = k.ItemMasterDelStatus
            }).ToList();
        }

        [HttpPost]
        [Route("DeleteItem")]
        public List<ItemMasterViewModel> DeleteItem([FromBody] ItemMasterViewModel itemMaster)
        {
            var result = _mapper.Map<ItemMaster>(itemMaster);
            return itemMasterService.DeleteItem(result).Select(k => new ItemMasterViewModel
            {
                ItemMasterItemId = k.ItemMasterItemId,
                ItemMasterMaterialCode = k.ItemMasterMaterialCode,
                ItemMasterAccountNo = k.ItemMasterAccountNo,
                ItemMasterItemName = k.ItemMasterItemName,
                ItemMasterItemType = k.ItemMasterItemType,
                ItemMasterBatchCode = k.ItemMasterBatchCode,
                ItemMasterVenderId = k.ItemMasterVenderId,
                ItemMasterLocationId = k.ItemMasterLocationId,
                ItemMasterReOrderLevel = k.ItemMasterReOrderLevel,
                ItemMasterUnitPrice = k.ItemMasterUnitPrice,
                ItemMasterUnitPrice1 = k.ItemMasterUnitPrice1,
                ItemMasterUnitPrice2 = k.ItemMasterUnitPrice2,
                ItemMasterItemSize = k.ItemMasterItemSize,
                ItemMasterPartNo = k.ItemMasterPartNo,
                ItemMasterColor = k.ItemMasterColor,
                ItemMasterPacking = k.ItemMasterPacking,
                ItemMasterWeight = k.ItemMasterWeight,
                ItemMasterShape = k.ItemMasterShape,
                ItemMasterRef1 = k.ItemMasterRef1,
                ItemMasterRef2 = k.ItemMasterRef2,
                ItemMasterStockType = k.ItemMasterStockType,
                ItemMasterUnitId = k.ItemMasterUnitId,
                ItemMasterAssetAcc = k.ItemMasterAssetAcc,
                ItemMasterExpenseAcc = k.ItemMasterExpenseAcc,
                ItemMasterImage = k.ItemMasterImage,
                ItemMasterActive = k.ItemMasterActive,
                ItemMasterLastPurchasePrice = k.ItemMasterLastPurchasePrice,
                ItemMasterServices = k.ItemMasterServices,
                ItemMasterSuplierCode = k.ItemMasterSuplierCode,
                ItemMasterBarcode = k.ItemMasterBarcode,
                ItemMasterAliasName = k.ItemMasterAliasName,
                ItemMasterUserId = k.ItemMasterUserId,
                ItemMasterGroupDebitAcc = k.ItemMasterGroupDebitAcc,
                ItemMasterGroupCreditAcc = k.ItemMasterGroupCreditAcc,
                ItemMasterLandingCost = k.ItemMasterLandingCost,
                ItemMasterBaseValue = k.ItemMasterBaseValue,
                ItemMasterHeightN = k.ItemMasterHeightN,
                ItemMasterWeightN = k.ItemMasterWeightN,
                ItemMasterRackId = k.ItemMasterRackId,
                ItemMasterCurrentStock = k.ItemMasterCurrentStock,
                ItemMasterStatus = k.ItemMasterStatus,
                ItemMasterAvgCostYel = k.ItemMasterAvgCostYel,
                ItemMasterVat = k.ItemMasterVat,
                ItemMasterTypeId = k.ItemMasterTypeId,
                ItemMasterModelId = k.ItemMasterModelId,
                ItemMasterVatPercentage = k.ItemMasterVatPercentage,
                ItemMasterVatInclues = k.ItemMasterVatInclues,
                ItemMasterReorderCheck = k.ItemMasterReorderCheck,
                ItemMasterDefaultLocationName = k.ItemMasterDefaultLocationName,
                ItemMasterDefaultLocation = k.ItemMasterDefaultLocation,
                ItemMasterCountryId = k.ItemMasterCountryId,
                ItemMasterPackageId = k.ItemMasterPackageId,
                ItemMasterGenericName = k.ItemMasterGenericName,
                ItemMasterSupplierName = k.ItemMasterSupplierName,
                ItemMasterManufactureName = k.ItemMasterManufactureName,
                ItemMasterRedeemRewardPoint = k.ItemMasterRedeemRewardPoint,
                ItemMasterProPurchaseRate = k.ItemMasterProPurchaseRate,
                ItemMasterProSaleRate = k.ItemMasterProSaleRate,
                ItemMasterProMrp = k.ItemMasterProMrp,
                ItemMasterDelStatus = k.ItemMasterDelStatus
            }).ToList();
        }
    }
}