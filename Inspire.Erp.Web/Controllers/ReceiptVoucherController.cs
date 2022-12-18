using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Inspire.Erp.Application.Account.Interfaces;
using Inspire.Erp.Application.Common;
using Inspire.Erp.Domain.Entities;
using Inspire.Erp.Domain.Enums;
using Inspire.Erp.Web.Common;
using Inspire.Erp.Web.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Inspire.Erp.Web.Controllers
{
    [Route("api/receipt")]
    [Produces("application/json")]
    [ApiController]
    public class ReceiptVoucherController : ControllerBase
    {
        private IReceiptVoucherService _receiptVoucherService;
        private readonly IMapper _mapper;
        public ReceiptVoucherController(IReceiptVoucherService receiptVoucherService, IMapper mapper)
        {
            _receiptVoucherService = receiptVoucherService;
            _mapper = mapper;
        }


        [HttpPost]
        [Route("InsertReceiptVoucher")]
        ////public ReceiptVoucherMasterViewModel InsertReceiptVoucher([FromBody] ReceiptVoucherMasterViewModel voucherCompositeView)
        ////{
        ////    var param1 = _mapper.Map<ReceiptVoucherMaster>(voucherCompositeView);
        ////    var param2 = _mapper.Map<List<ReceiptVoucherDetails>>(voucherCompositeView.ReceiptVoucherDetails);
        ////    var param3 = _mapper.Map<List<AccountsTransactions>>(voucherCompositeView.AccountsTransactions);
        ////    var xs = _receiptVoucherService.InsertReceiptVoucher(param1, param3, param2);
        ////    ReceiptVoucherMasterViewModel receiptVoucherViewModel = new ReceiptVoucherMasterViewModel
        ////    {
        ////        ReceiptVoucherMasterVoucherNo = xs.receiptVoucher.ReceiptVoucherMasterVoucherNo,
        ////        ReceiptVoucherMasterDrAmount = xs.receiptVoucher.ReceiptVoucherMasterDrAmount,
        ////        ReceiptVoucherMasterDrAcNo = xs.receiptVoucher.ReceiptVoucherMasterDrAcNo,
        ////        ReceiptVoucherMasterVoucherDate = xs.receiptVoucher.ReceiptVoucherMasterVoucherDate,
        ////        ReceiptVoucherMasterNarration = xs.receiptVoucher.ReceiptVoucherMasterNarration,
        ////        ReceiptVoucherMasterCurrencyId = xs.receiptVoucher.ReceiptVoucherMasterCurrencyId,
        ////        ReceiptVoucherMasterRefNo = xs.receiptVoucher.ReceiptVoucherMasterRefNo
        ////    };

        ////    receiptVoucherViewModel.ReceiptVoucherDetails = _mapper.Map<List<ReceiptVoucherDetailsViewModel>>(xs.receiptVoucherDetails);
        ////    receiptVoucherViewModel.AccountsTransactions = _mapper.Map<List<AccountTransactionsViewModel>>(xs.accountsTransactions);
        ////    return _mapper.Map<ReceiptVoucherMasterViewModel>(receiptVoucherViewModel);

        ////}

        public ApiResponse<ReceiptVoucherMasterViewModel> InsertReceiptVoucher([FromBody] ReceiptVoucherMasterViewModel voucherCompositeView)
        {
            ApiResponse<ReceiptVoucherMasterViewModel> apiResponse = new ApiResponse<ReceiptVoucherMasterViewModel>();
            if (_receiptVoucherService.GetVouchersNumbers(voucherCompositeView.ReceiptVoucherMasterVoucherNo) == null)
            {
                var param1 = _mapper.Map<ReceiptVoucherMaster>(voucherCompositeView);
                var param2 = _mapper.Map<List<ReceiptVoucherDetails>>(voucherCompositeView.ReceiptVoucherDetails);
                var param3 = _mapper.Map<List<AccountsTransactions>>(voucherCompositeView.AccountsTransactions);
                var xs = _receiptVoucherService.InsertReceiptVoucher(param1, param3, param2);
                ReceiptVoucherMasterViewModel receiptVoucherViewModel = new ReceiptVoucherMasterViewModel
                {

                    ReceiptVoucherMasterVoucherNo = xs.receiptVoucher.ReceiptVoucherMasterVoucherNo,
                    ReceiptVoucherMasterDrAmount = xs.receiptVoucher.ReceiptVoucherMasterDrAmount,
                    ReceiptVoucherMasterDrAcNo = xs.receiptVoucher.ReceiptVoucherMasterDrAcNo,
                    ReceiptVoucherMasterVoucherDate = xs.receiptVoucher.ReceiptVoucherMasterVoucherDate,
                    ReceiptVoucherMasterNarration = xs.receiptVoucher.ReceiptVoucherMasterNarration,
                    ReceiptVoucherMasterCurrencyId = xs.receiptVoucher.ReceiptVoucherMasterCurrencyId,
                    ReceiptVoucherMasterRefNo = xs.receiptVoucher.ReceiptVoucherMasterRefNo
                };

                receiptVoucherViewModel.ReceiptVoucherDetails = _mapper.Map<List<ReceiptVoucherDetailsViewModel>>(xs.receiptVoucherDetails);
                receiptVoucherViewModel.AccountsTransactions = _mapper.Map<List<AccountTransactionsViewModel>>(xs.accountsTransactions);
                apiResponse = new ApiResponse<ReceiptVoucherMasterViewModel>
                {
                    Valid = true,
                    Result = _mapper.Map<ReceiptVoucherMasterViewModel>(receiptVoucherViewModel),
                    Message = ReceiptVoucherMessage.SaveReceiptVoucher
                };
            }
            else
            {
                apiResponse = new ApiResponse<ReceiptVoucherMasterViewModel>
                {
                    Valid = false,
                    Error = true,
                    Exception = null,
                    Message = ReceiptVoucherMessage.ReceiptVoucherAlreadyExist
                };

            }


            return apiResponse;

        }

        [HttpPost]
        [Route("UpdateReceiptVoucher")]
        ////public ReceiptVoucherMasterViewModel UpdateReceiptVoucher([FromBody] ReceiptVoucherMasterViewModel voucherCompositeView)
        ////{
        ////    var param1 = _mapper.Map<ReceiptVoucherMaster>(voucherCompositeView);
        ////    var param2 = _mapper.Map<List<ReceiptVoucherDetails>>(voucherCompositeView.ReceiptVoucherDetails);
        ////    var param3 = _mapper.Map<List<AccountsTransactions>>(voucherCompositeView.AccountsTransactions);
        ////    var xs = _receiptVoucherService.UpdateReceiptVoucher(param1, param3, param2);

        ////    ReceiptVoucherMasterViewModel receiptVoucherViewModel = new ReceiptVoucherMasterViewModel
        ////    {

        ////        ReceiptVoucherMasterVoucherNo = xs.receiptVoucher.ReceiptVoucherMasterVoucherNo,
        ////        ReceiptVoucherMasterDrAmount = xs.receiptVoucher.ReceiptVoucherMasterDrAmount,
        ////        ReceiptVoucherMasterDrAcNo = xs.receiptVoucher.ReceiptVoucherMasterDrAcNo,
        ////        ReceiptVoucherMasterVoucherDate = xs.receiptVoucher.ReceiptVoucherMasterVoucherDate,
        ////        ReceiptVoucherMasterNarration = xs.receiptVoucher.ReceiptVoucherMasterNarration,
        ////        ReceiptVoucherMasterCurrencyId = xs.receiptVoucher.ReceiptVoucherMasterCurrencyId,
        ////        ReceiptVoucherMasterRefNo = xs.receiptVoucher.ReceiptVoucherMasterRefNo,
        ////    };

        ////    receiptVoucherViewModel.ReceiptVoucherDetails = _mapper.Map<List<ReceiptVoucherDetailsViewModel>>(xs.receiptVoucherDetails);
        ////    receiptVoucherViewModel.AccountsTransactions = _mapper.Map<List<AccountTransactionsViewModel>>(xs.accountsTransactions);

        ////    return _mapper.Map<ReceiptVoucherMasterViewModel>(receiptVoucherViewModel);

        ////}
        ///
        public ApiResponse<ReceiptVoucherMasterViewModel> UpdateReceiptVoucher([FromBody] ReceiptVoucherMasterViewModel voucherCompositeView)
        {
            var param1 = _mapper.Map<ReceiptVoucherMaster>(voucherCompositeView);
            var param2 = _mapper.Map<List<ReceiptVoucherDetails>>(voucherCompositeView.ReceiptVoucherDetails);
            var param3 = _mapper.Map<List<AccountsTransactions>>(voucherCompositeView.AccountsTransactions);
            var xs = _receiptVoucherService.UpdateReceiptVoucher(param1, param3, param2);

            ReceiptVoucherMasterViewModel receiptVoucherViewModel = new ReceiptVoucherMasterViewModel
            {

                ReceiptVoucherMasterVoucherNo = xs.receiptVoucher.ReceiptVoucherMasterVoucherNo,
                ReceiptVoucherMasterDrAmount = xs.receiptVoucher.ReceiptVoucherMasterDrAmount,
                ReceiptVoucherMasterDrAcNo = xs.receiptVoucher.ReceiptVoucherMasterDrAcNo,
                ReceiptVoucherMasterVoucherDate = xs.receiptVoucher.ReceiptVoucherMasterVoucherDate,
                ReceiptVoucherMasterNarration = xs.receiptVoucher.ReceiptVoucherMasterNarration,
                ReceiptVoucherMasterCurrencyId = xs.receiptVoucher.ReceiptVoucherMasterCurrencyId,
                ReceiptVoucherMasterRefNo = xs.receiptVoucher.ReceiptVoucherMasterRefNo,
            };

            receiptVoucherViewModel.ReceiptVoucherDetails = _mapper.Map<List<ReceiptVoucherDetailsViewModel>>(xs.receiptVoucherDetails);
            receiptVoucherViewModel.AccountsTransactions = _mapper.Map<List<AccountTransactionsViewModel>>(xs.accountsTransactions);
            ApiResponse<ReceiptVoucherMasterViewModel> apiResponse = new ApiResponse<ReceiptVoucherMasterViewModel>
            {
                Valid = true,
                Result = _mapper.Map<ReceiptVoucherMasterViewModel>(receiptVoucherViewModel),
                Message = ReceiptVoucherMessage.UpdateReceiptVoucher
            };

            return apiResponse;
        }


        [HttpPost]
        [Route("DeleteReceiptVoucher")]
        public ApiResponse<int> DeleteReceiptVoucher([FromBody] ReceiptVoucherMasterViewModel voucherCompositeView)
        {
            var param1 = _mapper.Map<ReceiptVoucherMaster>(voucherCompositeView);
            var param2 = _mapper.Map<List<ReceiptVoucherDetails>>(voucherCompositeView.ReceiptVoucherDetails);
            var param3 = _mapper.Map<List<AccountsTransactions>>(voucherCompositeView.AccountsTransactions);
            var xs = _receiptVoucherService.DeleteReceiptVoucher(param1, param3, param2);
            
            ApiResponse<int> apiResponse = new ApiResponse<int>
            {
                Valid = true,
                Result = 0,
                Message = ReceiptVoucherMessage.DeleteReceiptVoucher
            };

            return apiResponse;

        }

        [HttpGet]
        [Route("GetAllAccountTransaction")]
        public ApiResponse<List<AccountsTransactions>> GetAllAccountTransaction()
        {
            ApiResponse<List<AccountsTransactions>> apiResponse = new ApiResponse<List<AccountsTransactions>>
            {
                Valid = true,
                Result = _mapper.Map<List<AccountsTransactions>>(_receiptVoucherService.GetAllTransaction()),
                Message = ""
            };
            return apiResponse;
        }

        [HttpGet]
        [Route("GetReceiptVouchers")]
    
        public ApiResponse<List<ReceiptVoucherMaster>> GetAllReceipts()
        {
            ApiResponse<List<ReceiptVoucherMaster>> apiResponse = new ApiResponse<List<ReceiptVoucherMaster>>
            {
                Valid = true,
                Result = _mapper.Map<List<ReceiptVoucherMaster>>(_receiptVoucherService.GetReceiptVouchers()),
                Message = ""
            };
            return apiResponse;
        }


        [HttpGet]
        [Route("GetSavedReceiptDetails/{id}")]  

        public ApiResponse<ReceiptVoucherMasterViewModel> GetSavedReceiptDetails(string id)
        {
            ReceiptVoucherModel receiptVoucher = _receiptVoucherService.GetSavedReceiptDetails(id);
            if (receiptVoucher != null)
            {
                ReceiptVoucherMasterViewModel receiptVoucherViewModel = new ReceiptVoucherMasterViewModel
                { 

                    ReceiptVoucherMasterVoucherNo = receiptVoucher.receiptVoucher.ReceiptVoucherMasterVoucherNo,
                    ReceiptVoucherMasterDrAmount = receiptVoucher.receiptVoucher.ReceiptVoucherMasterDrAmount,
                    ReceiptVoucherMasterDrAcNo = receiptVoucher.receiptVoucher.ReceiptVoucherMasterDrAcNo,
                    ReceiptVoucherMasterVoucherDate = receiptVoucher.receiptVoucher.ReceiptVoucherMasterVoucherDate,
                    ReceiptVoucherMasterNarration = receiptVoucher.receiptVoucher.ReceiptVoucherMasterNarration,
                    ReceiptVoucherMasterCurrencyId = receiptVoucher.receiptVoucher.ReceiptVoucherMasterCurrencyId,
                    ReceiptVoucherMasterRefNo = receiptVoucher.receiptVoucher.ReceiptVoucherMasterRefNo

                };
                receiptVoucherViewModel.ReceiptVoucherDetails = _mapper.Map<List<ReceiptVoucherDetailsViewModel>>(receiptVoucher.receiptVoucherDetails);
                receiptVoucherViewModel.AccountsTransactions = _mapper.Map<List<AccountTransactionsViewModel>>(receiptVoucher.accountsTransactions);
                ApiResponse<ReceiptVoucherMasterViewModel> apiResponse = new ApiResponse<ReceiptVoucherMasterViewModel>
                {
                    Valid = true,
                    Result = receiptVoucherViewModel,
                    Message = ""
                };
                return apiResponse;
            }
            return null;

        }
    }
}
