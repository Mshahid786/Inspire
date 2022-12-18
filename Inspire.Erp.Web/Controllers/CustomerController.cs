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
    public class CustomerController : ControllerBase
    {
        private readonly IMapper _mapper;
        private ICustomerMasterService customerMasterService;
        public CustomerController(ICustomerMasterService _customerMasterService, IMapper mapper)
        {
            customerMasterService = _customerMasterService;
            _mapper = mapper;
        }
        [HttpGet]
        [Route("GetAllCustomer")]
        public List<CustomerMasterViewModel> GetAllCustomer()
        {
            return customerMasterService.GetAllCustomer().Select(k => new CustomerMasterViewModel
            {
                CustomerMasterCustomerNo = k.CustomerMasterCustomerNo,
                CustomerMasterCustomerTitle = k.CustomerMasterCustomerTitle,
                CustomerMasterCustomerName = k.CustomerMasterCustomerName,
                CustomerMasterCustomerType = k.CustomerMasterCustomerType,
                CustomerMasterCustomerContactPerson = k.CustomerMasterCustomerContactPerson,
                CustomerMasterCustomerCountryId = k.CustomerMasterCustomerCountryId,
                CustomerMasterCustomerCityId = k.CustomerMasterCustomerCityId,
                CustomerMasterCustomerPoBox = k.CustomerMasterCustomerPoBox,
                CustomerMasterCustomerTel1 = k.CustomerMasterCustomerTel1,
                CustomerMasterCustomerTel2 = k.CustomerMasterCustomerTel2,
                CustomerMasterCustomerMobile = k.CustomerMasterCustomerMobile,
                CustomerMasterCustomerFax = k.CustomerMasterCustomerFax,
                CustomerMasterCustomerEmail = k.CustomerMasterCustomerEmail,
                CustomerMasterCustomerWebSite = k.CustomerMasterCustomerWebSite,
                CustomerMasterCustomerLocation = k.CustomerMasterCustomerLocation,
                CustomerMasterCustomerRemarks = k.CustomerMasterCustomerRemarks,
                CustomerMasterCustomerReffAcNo = k.CustomerMasterCustomerReffAcNo,
                CustomerMasterCustomerUserId = k.CustomerMasterCustomerUserId,
                CustomerMasterCustomerCurrencyId = k.CustomerMasterCustomerCurrencyId,
                CustomerMasterCustomerCreditLimit = k.CustomerMasterCustomerCreditLimit,
                CustomerMasterCustomerCreditDays = k.CustomerMasterCustomerCreditDays,
                CustomerMasterCustomerBlackList = k.CustomerMasterCustomerBlackList,
                CustomerMasterCustomerStatus = k.CustomerMasterCustomerStatus,
                CustomerMasterCustomerDeleteStatus = k.CustomerMasterCustomerDeleteStatus,
                CustomerMasterCustomerJoinDate = k.CustomerMasterCustomerJoinDate,
                CustomerMasterCustomerStatusValue = k.CustomerMasterCustomerStatusValue,
                CustomerMasterCustomerCreateAccount = k.CustomerMasterCustomerCreateAccount,
                CustomerMasterCustomerPriceLevel = k.CustomerMasterCustomerPriceLevel,
                CustomerMasterCustomerPriceLevelId = k.CustomerMasterCustomerPriceLevelId,
                CustomerMasterCustomerCustType = k.CustomerMasterCustomerCustType,
                CustomerMasterCustomerContactPerson2 = k.CustomerMasterCustomerContactPerson2,
                CustomerMasterCustomerContactPerson3 = k.CustomerMasterCustomerContactPerson3,
                CustomerMasterCustomerVatNo = k.CustomerMasterCustomerVatNo,
                CustomerMasterCustomerLoyaltyId = k.CustomerMasterCustomerLoyaltyId,
                CustomerMasterCustomerEarnPoints = k.CustomerMasterCustomerEarnPoints,
                CustomerMasterCustomerTotalPoints = k.CustomerMasterCustomerTotalPoints,
                CustomerMasterCustomerTotalValue = k.CustomerMasterCustomerTotalValue,
                CustomerMasterCustomerRedeemEarnPoints = k.CustomerMasterCustomerRedeemEarnPoints,
                CustomerMasterCustomerArabicName = k.CustomerMasterCustomerArabicName,
                CustomerMasterCustomerGroupAccNo = k.CustomerMasterCustomerGroupAccNo,
                CustomerMasterCustomerCtTypeId = k.CustomerMasterCustomerCtTypeId,
                CustomerMasterCustomerDelStatus = k.CustomerMasterCustomerDelStatus
            }).ToList();
        }


        [HttpGet("{id}", Name = "GetAllCustomerById")]
        [Route("GetAllCustomerById/{id}")]
        public List<CustomerMasterViewModel> GetAllCustomerById(int id)
        {
            return customerMasterService.GetAllCustomerById(id).Select(k => new CustomerMasterViewModel
            {

                CustomerMasterCustomerNo = k.CustomerMasterCustomerNo,
                CustomerMasterCustomerTitle = k.CustomerMasterCustomerTitle,
                CustomerMasterCustomerName = k.CustomerMasterCustomerName,
                CustomerMasterCustomerType = k.CustomerMasterCustomerType,
                CustomerMasterCustomerContactPerson = k.CustomerMasterCustomerContactPerson,
                CustomerMasterCustomerCountryId = k.CustomerMasterCustomerCountryId,
                CustomerMasterCustomerCityId = k.CustomerMasterCustomerCityId,
                CustomerMasterCustomerPoBox = k.CustomerMasterCustomerPoBox,
                CustomerMasterCustomerTel1 = k.CustomerMasterCustomerTel1,
                CustomerMasterCustomerTel2 = k.CustomerMasterCustomerTel2,
                CustomerMasterCustomerMobile = k.CustomerMasterCustomerMobile,
                CustomerMasterCustomerFax = k.CustomerMasterCustomerFax,
                CustomerMasterCustomerEmail = k.CustomerMasterCustomerEmail,
                CustomerMasterCustomerWebSite = k.CustomerMasterCustomerWebSite,
                CustomerMasterCustomerLocation = k.CustomerMasterCustomerLocation,
                CustomerMasterCustomerRemarks = k.CustomerMasterCustomerRemarks,
                CustomerMasterCustomerReffAcNo = k.CustomerMasterCustomerReffAcNo,
                CustomerMasterCustomerUserId = k.CustomerMasterCustomerUserId,
                CustomerMasterCustomerCurrencyId = k.CustomerMasterCustomerCurrencyId,
                CustomerMasterCustomerCreditLimit = k.CustomerMasterCustomerCreditLimit,
                CustomerMasterCustomerCreditDays = k.CustomerMasterCustomerCreditDays,
                CustomerMasterCustomerBlackList = k.CustomerMasterCustomerBlackList,
                CustomerMasterCustomerStatus = k.CustomerMasterCustomerStatus,
                CustomerMasterCustomerDeleteStatus = k.CustomerMasterCustomerDeleteStatus,
                CustomerMasterCustomerJoinDate = k.CustomerMasterCustomerJoinDate,
                CustomerMasterCustomerStatusValue = k.CustomerMasterCustomerStatusValue,
                CustomerMasterCustomerCreateAccount = k.CustomerMasterCustomerCreateAccount,
                CustomerMasterCustomerPriceLevel = k.CustomerMasterCustomerPriceLevel,
                CustomerMasterCustomerPriceLevelId = k.CustomerMasterCustomerPriceLevelId,
                CustomerMasterCustomerCustType = k.CustomerMasterCustomerCustType,
                CustomerMasterCustomerContactPerson2 = k.CustomerMasterCustomerContactPerson2,
                CustomerMasterCustomerContactPerson3 = k.CustomerMasterCustomerContactPerson3,
                CustomerMasterCustomerVatNo = k.CustomerMasterCustomerVatNo,
                CustomerMasterCustomerLoyaltyId = k.CustomerMasterCustomerLoyaltyId,
                CustomerMasterCustomerEarnPoints = k.CustomerMasterCustomerEarnPoints,
                CustomerMasterCustomerTotalPoints = k.CustomerMasterCustomerTotalPoints,
                CustomerMasterCustomerTotalValue = k.CustomerMasterCustomerTotalValue,
                CustomerMasterCustomerRedeemEarnPoints = k.CustomerMasterCustomerRedeemEarnPoints,
                CustomerMasterCustomerArabicName = k.CustomerMasterCustomerArabicName,
                CustomerMasterCustomerGroupAccNo = k.CustomerMasterCustomerGroupAccNo,
                CustomerMasterCustomerCtTypeId = k.CustomerMasterCustomerCtTypeId,
                CustomerMasterCustomerDelStatus = k.CustomerMasterCustomerDelStatus
            }).ToList();
        }



        [HttpPost]
        [Route("InsertCustomer")]
        public List<CustomerMasterViewModel> InsertCustomer([FromBody] CustomerMasterViewModel customerMaster)
        {
            var result = _mapper.Map<CustomerMaster>(customerMaster);
            return customerMasterService.InsertCustomer(result).Select(k => new CustomerMasterViewModel
            {
                CustomerMasterCustomerNo = k.CustomerMasterCustomerNo,
                CustomerMasterCustomerTitle = k.CustomerMasterCustomerTitle,
                CustomerMasterCustomerName = k.CustomerMasterCustomerName,
                CustomerMasterCustomerType = k.CustomerMasterCustomerType,
                CustomerMasterCustomerContactPerson = k.CustomerMasterCustomerContactPerson,
                CustomerMasterCustomerCountryId = k.CustomerMasterCustomerCountryId,
                CustomerMasterCustomerCityId = k.CustomerMasterCustomerCityId,
                CustomerMasterCustomerPoBox = k.CustomerMasterCustomerPoBox,
                CustomerMasterCustomerTel1 = k.CustomerMasterCustomerTel1,
                CustomerMasterCustomerTel2 = k.CustomerMasterCustomerTel2,
                CustomerMasterCustomerMobile = k.CustomerMasterCustomerMobile,
                CustomerMasterCustomerFax = k.CustomerMasterCustomerFax,
                CustomerMasterCustomerEmail = k.CustomerMasterCustomerEmail,
                CustomerMasterCustomerWebSite = k.CustomerMasterCustomerWebSite,
                CustomerMasterCustomerLocation = k.CustomerMasterCustomerLocation,
                CustomerMasterCustomerRemarks = k.CustomerMasterCustomerRemarks,
                CustomerMasterCustomerReffAcNo = k.CustomerMasterCustomerReffAcNo,
                CustomerMasterCustomerUserId = k.CustomerMasterCustomerUserId,
                CustomerMasterCustomerCurrencyId = k.CustomerMasterCustomerCurrencyId,
                CustomerMasterCustomerCreditLimit = k.CustomerMasterCustomerCreditLimit,
                CustomerMasterCustomerCreditDays = k.CustomerMasterCustomerCreditDays,
                CustomerMasterCustomerBlackList = k.CustomerMasterCustomerBlackList,
                CustomerMasterCustomerStatus = k.CustomerMasterCustomerStatus,
                CustomerMasterCustomerDeleteStatus = k.CustomerMasterCustomerDeleteStatus,
                CustomerMasterCustomerJoinDate = k.CustomerMasterCustomerJoinDate,
                CustomerMasterCustomerStatusValue = k.CustomerMasterCustomerStatusValue,
                CustomerMasterCustomerCreateAccount = k.CustomerMasterCustomerCreateAccount,
                CustomerMasterCustomerPriceLevel = k.CustomerMasterCustomerPriceLevel,
                CustomerMasterCustomerPriceLevelId = k.CustomerMasterCustomerPriceLevelId,
                CustomerMasterCustomerCustType = k.CustomerMasterCustomerCustType,
                CustomerMasterCustomerContactPerson2 = k.CustomerMasterCustomerContactPerson2,
                CustomerMasterCustomerContactPerson3 = k.CustomerMasterCustomerContactPerson3,
                CustomerMasterCustomerVatNo = k.CustomerMasterCustomerVatNo,
                CustomerMasterCustomerLoyaltyId = k.CustomerMasterCustomerLoyaltyId,
                CustomerMasterCustomerEarnPoints = k.CustomerMasterCustomerEarnPoints,
                CustomerMasterCustomerTotalPoints = k.CustomerMasterCustomerTotalPoints,
                CustomerMasterCustomerTotalValue = k.CustomerMasterCustomerTotalValue,
                CustomerMasterCustomerRedeemEarnPoints = k.CustomerMasterCustomerRedeemEarnPoints,
                CustomerMasterCustomerArabicName = k.CustomerMasterCustomerArabicName,
                CustomerMasterCustomerGroupAccNo = k.CustomerMasterCustomerGroupAccNo,
                CustomerMasterCustomerCtTypeId = k.CustomerMasterCustomerCtTypeId,
                CustomerMasterCustomerDelStatus = k.CustomerMasterCustomerDelStatus
            }).ToList();
        }

        [HttpPost]
        [Route("UpdateCustomer")]
        public List<CustomerMasterViewModel> UpdateCustomer([FromBody] CustomerMasterViewModel customerMaster)
        {
            var result = _mapper.Map<CustomerMaster>(customerMaster);
            return customerMasterService.UpdateCustomer(result).Select(k => new CustomerMasterViewModel
            {
                CustomerMasterCustomerNo = k.CustomerMasterCustomerNo,
                CustomerMasterCustomerTitle = k.CustomerMasterCustomerTitle,
                CustomerMasterCustomerName = k.CustomerMasterCustomerName,
                CustomerMasterCustomerType = k.CustomerMasterCustomerType,
                CustomerMasterCustomerContactPerson = k.CustomerMasterCustomerContactPerson,
                CustomerMasterCustomerCountryId = k.CustomerMasterCustomerCountryId,
                CustomerMasterCustomerCityId = k.CustomerMasterCustomerCityId,
                CustomerMasterCustomerPoBox = k.CustomerMasterCustomerPoBox,
                CustomerMasterCustomerTel1 = k.CustomerMasterCustomerTel1,
                CustomerMasterCustomerTel2 = k.CustomerMasterCustomerTel2,
                CustomerMasterCustomerMobile = k.CustomerMasterCustomerMobile,
                CustomerMasterCustomerFax = k.CustomerMasterCustomerFax,
                CustomerMasterCustomerEmail = k.CustomerMasterCustomerEmail,
                CustomerMasterCustomerWebSite = k.CustomerMasterCustomerWebSite,
                CustomerMasterCustomerLocation = k.CustomerMasterCustomerLocation,
                CustomerMasterCustomerRemarks = k.CustomerMasterCustomerRemarks,
                CustomerMasterCustomerReffAcNo = k.CustomerMasterCustomerReffAcNo,
                CustomerMasterCustomerUserId = k.CustomerMasterCustomerUserId,
                CustomerMasterCustomerCurrencyId = k.CustomerMasterCustomerCurrencyId,
                CustomerMasterCustomerCreditLimit = k.CustomerMasterCustomerCreditLimit,
                CustomerMasterCustomerCreditDays = k.CustomerMasterCustomerCreditDays,
                CustomerMasterCustomerBlackList = k.CustomerMasterCustomerBlackList,
                CustomerMasterCustomerStatus = k.CustomerMasterCustomerStatus,
                CustomerMasterCustomerDeleteStatus = k.CustomerMasterCustomerDeleteStatus,
                CustomerMasterCustomerJoinDate = k.CustomerMasterCustomerJoinDate,
                CustomerMasterCustomerStatusValue = k.CustomerMasterCustomerStatusValue,
                CustomerMasterCustomerCreateAccount = k.CustomerMasterCustomerCreateAccount,
                CustomerMasterCustomerPriceLevel = k.CustomerMasterCustomerPriceLevel,
                CustomerMasterCustomerPriceLevelId = k.CustomerMasterCustomerPriceLevelId,
                CustomerMasterCustomerCustType = k.CustomerMasterCustomerCustType,
                CustomerMasterCustomerContactPerson2 = k.CustomerMasterCustomerContactPerson2,
                CustomerMasterCustomerContactPerson3 = k.CustomerMasterCustomerContactPerson3,
                CustomerMasterCustomerVatNo = k.CustomerMasterCustomerVatNo,
                CustomerMasterCustomerLoyaltyId = k.CustomerMasterCustomerLoyaltyId,
                CustomerMasterCustomerEarnPoints = k.CustomerMasterCustomerEarnPoints,
                CustomerMasterCustomerTotalPoints = k.CustomerMasterCustomerTotalPoints,
                CustomerMasterCustomerTotalValue = k.CustomerMasterCustomerTotalValue,
                CustomerMasterCustomerRedeemEarnPoints = k.CustomerMasterCustomerRedeemEarnPoints,
                CustomerMasterCustomerArabicName = k.CustomerMasterCustomerArabicName,
                CustomerMasterCustomerGroupAccNo = k.CustomerMasterCustomerGroupAccNo,
                CustomerMasterCustomerCtTypeId = k.CustomerMasterCustomerCtTypeId,
                CustomerMasterCustomerDelStatus = k.CustomerMasterCustomerDelStatus
            }).ToList();
        }

        [HttpPost]
        [Route("DeleteCustomer")]
        public List<CustomerMasterViewModel> DeleteCustomer([FromBody] CustomerMasterViewModel customerMaster)
        {
            var result = _mapper.Map<CustomerMaster>(customerMaster);
            return customerMasterService.DeleteCustomer(result).Select(k => new CustomerMasterViewModel
            {
                CustomerMasterCustomerNo = k.CustomerMasterCustomerNo,
                CustomerMasterCustomerTitle = k.CustomerMasterCustomerTitle,
                CustomerMasterCustomerName = k.CustomerMasterCustomerName,
                CustomerMasterCustomerType = k.CustomerMasterCustomerType,
                CustomerMasterCustomerContactPerson = k.CustomerMasterCustomerContactPerson,
                CustomerMasterCustomerCountryId = k.CustomerMasterCustomerCountryId,
                CustomerMasterCustomerCityId = k.CustomerMasterCustomerCityId,
                CustomerMasterCustomerPoBox = k.CustomerMasterCustomerPoBox,
                CustomerMasterCustomerTel1 = k.CustomerMasterCustomerTel1,
                CustomerMasterCustomerTel2 = k.CustomerMasterCustomerTel2,
                CustomerMasterCustomerMobile = k.CustomerMasterCustomerMobile,
                CustomerMasterCustomerFax = k.CustomerMasterCustomerFax,
                CustomerMasterCustomerEmail = k.CustomerMasterCustomerEmail,
                CustomerMasterCustomerWebSite = k.CustomerMasterCustomerWebSite,
                CustomerMasterCustomerLocation = k.CustomerMasterCustomerLocation,
                CustomerMasterCustomerRemarks = k.CustomerMasterCustomerRemarks,
                CustomerMasterCustomerReffAcNo = k.CustomerMasterCustomerReffAcNo,
                CustomerMasterCustomerUserId = k.CustomerMasterCustomerUserId,
                CustomerMasterCustomerCurrencyId = k.CustomerMasterCustomerCurrencyId,
                CustomerMasterCustomerCreditLimit = k.CustomerMasterCustomerCreditLimit,
                CustomerMasterCustomerCreditDays = k.CustomerMasterCustomerCreditDays,
                CustomerMasterCustomerBlackList = k.CustomerMasterCustomerBlackList,
                CustomerMasterCustomerStatus = k.CustomerMasterCustomerStatus,
                CustomerMasterCustomerDeleteStatus = k.CustomerMasterCustomerDeleteStatus,
                CustomerMasterCustomerJoinDate = k.CustomerMasterCustomerJoinDate,
                CustomerMasterCustomerStatusValue = k.CustomerMasterCustomerStatusValue,
                CustomerMasterCustomerCreateAccount = k.CustomerMasterCustomerCreateAccount,
                CustomerMasterCustomerPriceLevel = k.CustomerMasterCustomerPriceLevel,
                CustomerMasterCustomerPriceLevelId = k.CustomerMasterCustomerPriceLevelId,
                CustomerMasterCustomerCustType = k.CustomerMasterCustomerCustType,
                CustomerMasterCustomerContactPerson2 = k.CustomerMasterCustomerContactPerson2,
                CustomerMasterCustomerContactPerson3 = k.CustomerMasterCustomerContactPerson3,
                CustomerMasterCustomerVatNo = k.CustomerMasterCustomerVatNo,
                CustomerMasterCustomerLoyaltyId = k.CustomerMasterCustomerLoyaltyId,
                CustomerMasterCustomerEarnPoints = k.CustomerMasterCustomerEarnPoints,
                CustomerMasterCustomerTotalPoints = k.CustomerMasterCustomerTotalPoints,
                CustomerMasterCustomerTotalValue = k.CustomerMasterCustomerTotalValue,
                CustomerMasterCustomerRedeemEarnPoints = k.CustomerMasterCustomerRedeemEarnPoints,
                CustomerMasterCustomerArabicName = k.CustomerMasterCustomerArabicName,
                CustomerMasterCustomerGroupAccNo = k.CustomerMasterCustomerGroupAccNo,
                CustomerMasterCustomerCtTypeId = k.CustomerMasterCustomerCtTypeId,
                CustomerMasterCustomerDelStatus = k.CustomerMasterCustomerDelStatus
            }).ToList();

        }  
    }
}
