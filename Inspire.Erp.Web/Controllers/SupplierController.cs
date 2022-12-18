using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Inspire.Erp.Application.Common;
using Inspire.Erp.Application.Master;
using Inspire.Erp.Domain.Entities;
using Inspire.Erp.Web.Common;
using Inspire.Erp.Web.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Inspire.Erp.Web.Controllers
{
    [Route("api")]
    [Produces("application/json")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private readonly IMapper _mapper;
        private ISupplierMasterService supplierMasterService;
        public SupplierController(ISupplierMasterService _SupplierMasterService, IMapper mapper)
        {

            supplierMasterService = _SupplierMasterService;
            _mapper = mapper;
        }
        [HttpGet]
        [Route("GetAllSupplier")]
        public List<SuppliersMasterViewModel> GetAllSupplier()
        {
            return supplierMasterService.GetAllSupplier().Select(k => new SuppliersMasterViewModel
            {
                SuppliersMasterSupplierId = k.SuppliersMasterSupplierId,
                //SuppliersMasterSupplierCode= k.SuppliersMasterSupplierCode,
                SuppliersMasterSupplierName = k.SuppliersMasterSupplierName,
                SuppliersMasterSupplierContactPerson = k.SuppliersMasterSupplierContactPerson,
                SuppliersMasterSupplierCountryId = k.SuppliersMasterSupplierCountryId,
                SuppliersMasterSupplierCityId = k.SuppliersMasterSupplierCityId,
                SuppliersMasterSupplierPoBox = k.SuppliersMasterSupplierPoBox,
                SuppliersMasterSupplierTel1 = k.SuppliersMasterSupplierTel1,
                SuppliersMasterSupplierTel2 = k.SuppliersMasterSupplierTel2,
                SuppliersMasterSupplierFax = k.SuppliersMasterSupplierFax,
                SuppliersMasterSupplierMobile = k.SuppliersMasterSupplierMobile,
                SuppliersMasterSupplierEmail = k.SuppliersMasterSupplierEmail,
                SuppliersMasterSupplierWebSite = k.SuppliersMasterSupplierWebSite,
                SuppliersMasterSupplierLocation = k.SuppliersMasterSupplierLocation,
                SuppliersMasterSupplierRemarks = k.SuppliersMasterSupplierRemarks,
                SuppliersMasterSupplierReffAcNo = k.SuppliersMasterSupplierReffAcNo,
                SuppliersMasterSupplierType = k.SuppliersMasterSupplierType,
                SuppliersMasterSupplierUserId = k.SuppliersMasterSupplierUserId,
                SuppliersMasterSupplierCurrencyId = k.SuppliersMasterSupplierCurrencyId,
                SuppliersMasterSupplierConsup = k.SuppliersMasterSupplierConsup,
                SuppliersMasterSupplierCrl = k.SuppliersMasterSupplierCrl,
                SuppliersMasterSupplierStatus = k.SuppliersMasterSupplierStatus,
                SuppliersMasterSupplierDeleteStatus = k.SuppliersMasterSupplierDeleteStatus,
                SuppliersMasterSupplierStatusValue = k.SuppliersMasterSupplierStatusValue,
                SuppliersMasterSupplierPaymentTerms = k.SuppliersMasterSupplierPaymentTerms,
                SuppliersMasterSupplierCreditDays = k.SuppliersMasterSupplierCreditDays,
                SuppliersMasterSupplierCreditLimit = k.SuppliersMasterSupplierCreditLimit,
                SuppliersMasterSupplierVatNo = k.SuppliersMasterSupplierVatNo,
                SuppliersMasterSupplierDelStatus=k.SuppliersMasterSupplierDelStatus
            }).ToList();
        }


        [HttpGet("{id}", Name = "GetAllSupplierById")]
        [Route("GetAllSupplierById/{id}")]
        public List<SuppliersMasterViewModel> GetAllSupplierById(int id)
        {
            return supplierMasterService.GetAllSupplierById(id).Select(k => new SuppliersMasterViewModel
            {
                SuppliersMasterSupplierId = k.SuppliersMasterSupplierId,
                //SuppliersMasterSupplierCode = k.SuppliersMasterSupplierCode,
                SuppliersMasterSupplierName = k.SuppliersMasterSupplierName,
                SuppliersMasterSupplierContactPerson = k.SuppliersMasterSupplierContactPerson,
                SuppliersMasterSupplierCountryId = k.SuppliersMasterSupplierCountryId,
                SuppliersMasterSupplierCityId = k.SuppliersMasterSupplierCityId,
                SuppliersMasterSupplierPoBox = k.SuppliersMasterSupplierPoBox,
                SuppliersMasterSupplierTel1 = k.SuppliersMasterSupplierTel1,
                SuppliersMasterSupplierTel2 = k.SuppliersMasterSupplierTel2,
                SuppliersMasterSupplierFax = k.SuppliersMasterSupplierFax,
                SuppliersMasterSupplierMobile = k.SuppliersMasterSupplierMobile,
                SuppliersMasterSupplierEmail = k.SuppliersMasterSupplierEmail,
                SuppliersMasterSupplierWebSite = k.SuppliersMasterSupplierWebSite,
                SuppliersMasterSupplierLocation = k.SuppliersMasterSupplierLocation,
                SuppliersMasterSupplierRemarks = k.SuppliersMasterSupplierRemarks,
                SuppliersMasterSupplierReffAcNo = k.SuppliersMasterSupplierReffAcNo,
                SuppliersMasterSupplierType = k.SuppliersMasterSupplierType,
                SuppliersMasterSupplierUserId = k.SuppliersMasterSupplierUserId,
                SuppliersMasterSupplierCurrencyId = k.SuppliersMasterSupplierCurrencyId,
                SuppliersMasterSupplierConsup = k.SuppliersMasterSupplierConsup,
                SuppliersMasterSupplierCrl = k.SuppliersMasterSupplierCrl,
                SuppliersMasterSupplierStatus = k.SuppliersMasterSupplierStatus,
                SuppliersMasterSupplierDeleteStatus = k.SuppliersMasterSupplierDeleteStatus,
                SuppliersMasterSupplierStatusValue = k.SuppliersMasterSupplierStatusValue,
                SuppliersMasterSupplierPaymentTerms = k.SuppliersMasterSupplierPaymentTerms,
                SuppliersMasterSupplierCreditDays = k.SuppliersMasterSupplierCreditDays,
                SuppliersMasterSupplierCreditLimit = k.SuppliersMasterSupplierCreditLimit,
                SuppliersMasterSupplierVatNo = k.SuppliersMasterSupplierVatNo,
                SuppliersMasterSupplierDelStatus = k.SuppliersMasterSupplierDelStatus
            }).ToList();
        }

        [HttpPost]
        [Route("InsertSupplier")]
        public List<SuppliersMasterViewModel> InsertSupplier([FromBody] SuppliersMasterViewModel suppliersMaster)
        {
            var result = _mapper.Map<SuppliersMaster>(suppliersMaster);
            return supplierMasterService.InsertSupplier(result).Select(k => new SuppliersMasterViewModel
            {
                SuppliersMasterSupplierId = k.SuppliersMasterSupplierId,
                //SuppliersMasterSupplierCode = k.SuppliersMasterSupplierCode,
                SuppliersMasterSupplierName = k.SuppliersMasterSupplierName,
                SuppliersMasterSupplierContactPerson = k.SuppliersMasterSupplierContactPerson,
                SuppliersMasterSupplierCountryId = k.SuppliersMasterSupplierCountryId,
                SuppliersMasterSupplierCityId = k.SuppliersMasterSupplierCityId,
                SuppliersMasterSupplierPoBox = k.SuppliersMasterSupplierPoBox,
                SuppliersMasterSupplierTel1 = k.SuppliersMasterSupplierTel1,
                SuppliersMasterSupplierTel2 = k.SuppliersMasterSupplierTel2,
                SuppliersMasterSupplierFax = k.SuppliersMasterSupplierFax,
                SuppliersMasterSupplierMobile = k.SuppliersMasterSupplierMobile,
                SuppliersMasterSupplierEmail = k.SuppliersMasterSupplierEmail,
                SuppliersMasterSupplierWebSite = k.SuppliersMasterSupplierWebSite,
                SuppliersMasterSupplierLocation = k.SuppliersMasterSupplierLocation,
                SuppliersMasterSupplierRemarks = k.SuppliersMasterSupplierRemarks,
                SuppliersMasterSupplierReffAcNo = k.SuppliersMasterSupplierReffAcNo,
                SuppliersMasterSupplierType = k.SuppliersMasterSupplierType,
                SuppliersMasterSupplierUserId = k.SuppliersMasterSupplierUserId,
                SuppliersMasterSupplierCurrencyId = k.SuppliersMasterSupplierCurrencyId,
                SuppliersMasterSupplierConsup = k.SuppliersMasterSupplierConsup,
                SuppliersMasterSupplierCrl = k.SuppliersMasterSupplierCrl,
                SuppliersMasterSupplierStatus = k.SuppliersMasterSupplierStatus,
                SuppliersMasterSupplierDeleteStatus = k.SuppliersMasterSupplierDeleteStatus,
                SuppliersMasterSupplierStatusValue = k.SuppliersMasterSupplierStatusValue,
                SuppliersMasterSupplierPaymentTerms = k.SuppliersMasterSupplierPaymentTerms,
                SuppliersMasterSupplierCreditDays = k.SuppliersMasterSupplierCreditDays,
                SuppliersMasterSupplierCreditLimit = k.SuppliersMasterSupplierCreditLimit,
                SuppliersMasterSupplierVatNo = k.SuppliersMasterSupplierVatNo,
                SuppliersMasterSupplierDelStatus = k.SuppliersMasterSupplierDelStatus
            }).ToList();
        }

        [HttpPost]
        [Route("UpdateSupplier")]
        public List<SuppliersMasterViewModel> UpdateSupplier([FromBody] SuppliersMasterViewModel SuppliersMaster)
        {
            var result = _mapper.Map<SuppliersMaster>(SuppliersMaster);
            return supplierMasterService.UpdateSupplier(result).Select(k => new SuppliersMasterViewModel
            {
                SuppliersMasterSupplierId = k.SuppliersMasterSupplierId,
                //SuppliersMasterSupplierCode = k.SuppliersMasterSupplierCode,
                SuppliersMasterSupplierName = k.SuppliersMasterSupplierName,
                SuppliersMasterSupplierContactPerson = k.SuppliersMasterSupplierContactPerson,
                SuppliersMasterSupplierCountryId = k.SuppliersMasterSupplierCountryId,
                SuppliersMasterSupplierCityId = k.SuppliersMasterSupplierCityId,
                SuppliersMasterSupplierPoBox = k.SuppliersMasterSupplierPoBox,
                SuppliersMasterSupplierTel1 = k.SuppliersMasterSupplierTel1,
                SuppliersMasterSupplierTel2 = k.SuppliersMasterSupplierTel2,
                SuppliersMasterSupplierFax = k.SuppliersMasterSupplierFax,
                SuppliersMasterSupplierMobile = k.SuppliersMasterSupplierMobile,
                SuppliersMasterSupplierEmail = k.SuppliersMasterSupplierEmail,
                SuppliersMasterSupplierWebSite = k.SuppliersMasterSupplierWebSite,
                SuppliersMasterSupplierLocation = k.SuppliersMasterSupplierLocation,
                SuppliersMasterSupplierRemarks = k.SuppliersMasterSupplierRemarks,
                SuppliersMasterSupplierReffAcNo = k.SuppliersMasterSupplierReffAcNo,
                SuppliersMasterSupplierType = k.SuppliersMasterSupplierType,
                SuppliersMasterSupplierUserId = k.SuppliersMasterSupplierUserId,
                SuppliersMasterSupplierCurrencyId = k.SuppliersMasterSupplierCurrencyId,
                SuppliersMasterSupplierConsup = k.SuppliersMasterSupplierConsup,
                SuppliersMasterSupplierCrl = k.SuppliersMasterSupplierCrl,
                SuppliersMasterSupplierStatus = k.SuppliersMasterSupplierStatus,
                SuppliersMasterSupplierDeleteStatus = k.SuppliersMasterSupplierDeleteStatus,
                SuppliersMasterSupplierStatusValue = k.SuppliersMasterSupplierStatusValue,
                SuppliersMasterSupplierPaymentTerms = k.SuppliersMasterSupplierPaymentTerms,
                SuppliersMasterSupplierCreditDays = k.SuppliersMasterSupplierCreditDays,
                SuppliersMasterSupplierCreditLimit = k.SuppliersMasterSupplierCreditLimit,
                SuppliersMasterSupplierVatNo = k.SuppliersMasterSupplierVatNo,
                SuppliersMasterSupplierDelStatus = k.SuppliersMasterSupplierDelStatus
            }).ToList();
        }

        [HttpPost]
        [Route("DeleteSupplier")]
        public List<SuppliersMasterViewModel> DeleteSupplier([FromBody] SuppliersMasterViewModel SuppliersMaster)
        {
            var result = _mapper.Map<SuppliersMaster>(SuppliersMaster);
            return supplierMasterService.DeleteSupplier(result).Select(k => new SuppliersMasterViewModel
            {
                SuppliersMasterSupplierId = k.SuppliersMasterSupplierId,
                //SuppliersMasterSupplierCode = k.SuppliersMasterSupplierCode,
                SuppliersMasterSupplierName = k.SuppliersMasterSupplierName,
                SuppliersMasterSupplierContactPerson = k.SuppliersMasterSupplierContactPerson,
                SuppliersMasterSupplierCountryId = k.SuppliersMasterSupplierCountryId,
                SuppliersMasterSupplierCityId = k.SuppliersMasterSupplierCityId,
                SuppliersMasterSupplierPoBox = k.SuppliersMasterSupplierPoBox,
                SuppliersMasterSupplierTel1 = k.SuppliersMasterSupplierTel1,
                SuppliersMasterSupplierTel2 = k.SuppliersMasterSupplierTel2,
                SuppliersMasterSupplierFax = k.SuppliersMasterSupplierFax,
                SuppliersMasterSupplierMobile = k.SuppliersMasterSupplierMobile,
                SuppliersMasterSupplierEmail = k.SuppliersMasterSupplierEmail,
                SuppliersMasterSupplierWebSite = k.SuppliersMasterSupplierWebSite,
                SuppliersMasterSupplierLocation = k.SuppliersMasterSupplierLocation,
                SuppliersMasterSupplierRemarks = k.SuppliersMasterSupplierRemarks,
                SuppliersMasterSupplierReffAcNo = k.SuppliersMasterSupplierReffAcNo,
                SuppliersMasterSupplierType = k.SuppliersMasterSupplierType,
                SuppliersMasterSupplierUserId = k.SuppliersMasterSupplierUserId,
                SuppliersMasterSupplierCurrencyId = k.SuppliersMasterSupplierCurrencyId,
                SuppliersMasterSupplierConsup = k.SuppliersMasterSupplierConsup,
                SuppliersMasterSupplierCrl = k.SuppliersMasterSupplierCrl,
                SuppliersMasterSupplierStatus = k.SuppliersMasterSupplierStatus,
                SuppliersMasterSupplierDeleteStatus = k.SuppliersMasterSupplierDeleteStatus,
                SuppliersMasterSupplierStatusValue = k.SuppliersMasterSupplierStatusValue,
                SuppliersMasterSupplierPaymentTerms = k.SuppliersMasterSupplierPaymentTerms,
                SuppliersMasterSupplierCreditDays = k.SuppliersMasterSupplierCreditDays,
                SuppliersMasterSupplierCreditLimit = k.SuppliersMasterSupplierCreditLimit,
                SuppliersMasterSupplierVatNo = k.SuppliersMasterSupplierVatNo,
                SuppliersMasterSupplierDelStatus = k.SuppliersMasterSupplierDelStatus
            }).ToList();
        }


        [HttpGet("{id}", Name = "GetSupplierDetailsByItemId")]
        [Route("GetSupplierDetailsByItemId/{id}")]
        public ApiResponse<List<ItemMasterSupplierDetais>> GetSupplierDetailsByItemId(int id)
        {
            List<ItemMasterSupplierDetais> supplierDetailsViewModels = new List<ItemMasterSupplierDetais>();
            var x = this.supplierMasterService.GetUpdatedSupplierDetailsByItem(id).ToList();
            ApiResponse<List<ItemMasterSupplierDetais>> apiResponse = new ApiResponse<List<ItemMasterSupplierDetais>>
            {
                Valid = true,
                Result = x,
                Message = ""
            };
            return apiResponse;
        }
    }
}
