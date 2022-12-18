using Inspire.Erp.Application.Account.Interfaces;
using Inspire.Erp.Application.Common;
using Inspire.Erp.Domain.Entities;
using Inspire.Erp.Domain.Enums;
using Inspire.Erp.Infrastructure.Database.Repositoy;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Inspire.Erp.Application.Account.Implementations
{
   public class PaymentVoucherService: IPaymentVoucherService
    {
        private IRepository<AccountsTransactions> _accountTransactionRepository;
        private IRepository<PaymentVoucher> _paymentVoucherRepository;
        private IRepository<PaymentVoucherDetails> _paymentVoucherDetailsRepository;
        private IRepository<ProgramSettings> _programsettingsRepository;
        private IRepository<VouchersNumbers> _voucherNumbersRepository;
        private readonly ILogger<PaymentVoucherService> _logger;

        public PaymentVoucherService(IRepository<AccountsTransactions> accountTransactionRepository, IRepository<ProgramSettings> programsettingsRepository,
            IRepository<VouchersNumbers> voucherNumbers, ILogger<PaymentVoucherService> logger,
            IRepository<PaymentVoucher> paymentVoucherRepository, IRepository<PaymentVoucherDetails> paymentVoucherDetailsRepository)
        {
            this._accountTransactionRepository = accountTransactionRepository;
            this._paymentVoucherRepository = paymentVoucherRepository;
            this._paymentVoucherDetailsRepository = paymentVoucherDetailsRepository;
            _programsettingsRepository = programsettingsRepository;
            _voucherNumbersRepository = voucherNumbers;
            _logger = logger;

        }
        //public PaymentVoucher InsertPaymentVoucher(PaymentVoucher paymentVoucher,
        //  List<PaymentVoucherDetails> paymentVoucherDetails)
        //{
        //    List<AccountsTransactions> accountsTransactions = new List<AccountsTransactions>();
        //    try {
        //        _accountTransactionRepository.BeginTransaction();

        //        _paymentVoucherRepository.Insert(paymentVoucher);
        //        _paymentVoucherDetailsRepository.InsertList(paymentVoucherDetails.Select(k => 
        //        {
        //            k.PaymentVoucherDetailsVoucherNo = paymentVoucher.PaymentVoucherVoucherNo;
        //            return k;
        //        }).ToList()) ;
        //        //int acctTransMaxVal = Convert.ToInt32(_accountTransactionRepository.GetAsQueryable()
        //        //                                        .Where(x => x.AccountsTransactionsTransSno > 0)
        //        //                                        .DefaultIfEmpty()
        //        //                                        .Max(o => o == null ? 0 : o.AccountsTransactionsTransSno))  + 1;

        //        AccountsTransactions creditData = new AccountsTransactions();
        //        creditData.AccountsTransactionsAccNo = paymentVoucher.PaymentVoucherCrAcNo;
        //        creditData.AccountsTransactionsTransDate = (DateTime) paymentVoucher.PaymentVoucherDate.Value.Date;
        //        creditData.AccountsTransactionsParticulars = paymentVoucher.PaymentVoucherNarration;
        //        creditData.AccountsTransactionsCredit = Convert.ToDecimal(paymentVoucher.PaymentVoucherDbAmount);
        //        creditData.AccountsTransactionsFcCredit = Convert.ToDecimal(paymentVoucher.PaymentVoucherDbAmount);
        //        creditData.AccountsTransactionsVoucherType = VoucherType.Payment;
        //        creditData.AccountsTransactionsTstamp = DateTime.Now;
        //        creditData.AccountsTransactionsVoucherNo = paymentVoucher.PaymentVoucherVoucherNo;
        //        creditData.AccountsTransactionsDescription = paymentVoucher.PaymentVoucherNarration;
        //        creditData.AccountsTransactionsStatus = AccountStatus.Approved;
        //        accountsTransactions.Add(creditData);
        //        //int transactionIntialCount = Convert.ToInt32(creditData.AccountsTransactionsTransSno + 1);
        //        foreach (var debit in paymentVoucherDetails)
        //        {
        //            //transactionIntialCount = transactionIntialCount + 1;
        //            AccountsTransactions debitData = new AccountsTransactions();
        //            debitData.AccountsTransactionsAccNo = debit.PaymentVoucherDetailsAcNo;
        //            debitData.AccountsTransactionsTransDate = (DateTime) creditData.AccountsTransactionsTransDate;
        //            debitData.AccountsTransactionsParticulars = debit.PaymentVoucherDetailsNarration;
        //            debitData.AccountsTransactionsDebit = Convert.ToDecimal(debit.PaymentVoucherDetailsDbAmount);
        //            debitData.AccountsTransactionsFcDebit = Convert.ToDecimal(debit.PaymentVoucherDetailsDbAmount);
        //            debitData.AccountsTransactionsVoucherType = VoucherType.Payment;
        //            debitData.AccountsTransactionsTstamp = DateTime.Now;
        //            debitData.AccountsTransactionsVoucherNo = paymentVoucher.PaymentVoucherVoucherNo;
        //            debitData.AccountsTransactionsDescription = debit.PaymentVoucherDetailsNarration;
        //            debitData.AccountsTransactionsStatus = AccountStatus.Approved;
        //            accountsTransactions.Add(debitData);

        //        }
        //        _accountTransactionRepository.InsertList(accountsTransactions);
        //        _accountTransactionRepository.TransactionCommit();
        //    }
        //    catch(Exception ex) {
        //        _accountTransactionRepository.TransactionRollback();
        //        throw ex;
        //    }

        //    return this.GetSavedPaymentDetails(paymentVoucher.PaymentVoucherVoucherNo);

        //}

        public PaymentVoucherModel UpdatePaymentVoucher(PaymentVoucher paymentVoucher, List<AccountsTransactions> accountsTransactions, 
                                                        List<PaymentVoucherDetails> paymentVoucherDetails)
        {
           
            try
            {
                _paymentVoucherRepository.BeginTransaction();

                _paymentVoucherRepository.Update(paymentVoucher);
                accountsTransactions = accountsTransactions.Select((k) =>
                {
                    if (k.AccountsTransactionsTransSno == 0)
                    {
                        k.AccountsTransactionsVoucherType = VoucherType.Payment;
                        k.AccountsTransactionsStatus = AccountStatus.Approved;
                    }

                    return k;
                }).ToList();
                _accountTransactionRepository.UpdateList(accountsTransactions);
                _paymentVoucherDetailsRepository.UpdateList(paymentVoucherDetails);
                _paymentVoucherRepository.TransactionCommit();

            }
            catch (Exception ex)
            {
                _paymentVoucherRepository.TransactionRollback();
                throw ex;
            }

            return this.GetSavedPaymentDetails(paymentVoucher.PaymentVoucherVoucherNo);
        }

        public int DeletePaymentVoucher(PaymentVoucher paymentVoucher, List<AccountsTransactions> accountsTransactions, List<PaymentVoucherDetails> paymentVoucherDetails)
        {
            int i = 0;
            try {
                _paymentVoucherRepository.BeginTransaction();
         
                paymentVoucher.PaymentVoucherDelStatus = true;

                paymentVoucherDetails = paymentVoucherDetails.Select((k) => {
                k.PaymentVocherDetailsDelStatus = true;
                return k; }).ToList();

                _paymentVoucherDetailsRepository.UpdateList(paymentVoucherDetails);

                accountsTransactions = accountsTransactions.Select((k) => {
                k.AccountstransactionsDelStatus = true;
                return k; }).ToList();
                _accountTransactionRepository.UpdateList(accountsTransactions);

               _paymentVoucherRepository.Update(paymentVoucher);

                var vchrnumer = _voucherNumbersRepository.GetAsQueryable().Where(k => k.VouchersNumbersVNo == paymentVoucher.PaymentVoucherVoucherNo).FirstOrDefault();

                _voucherNumbersRepository.Update(vchrnumer);

                _paymentVoucherRepository.TransactionCommit();
                i = 1;
            }
            catch(Exception ex)
            {
                _paymentVoucherRepository.TransactionRollback();
                i = 0;
                throw ex;
            }
         
            
            return i;

        }
        public PaymentVoucherModel InsertPaymentVoucher(PaymentVoucher paymentVoucher, List<AccountsTransactions> accountsTransactions, 
                                                        List<PaymentVoucherDetails> paymentVoucherDetails)
        {
            try
            {
                _paymentVoucherRepository.BeginTransaction();
                string paymentVoucherNumber = (paymentVoucher.PaymentVoucherVoucherNo == null || paymentVoucher.PaymentVoucherVoucherNo.Trim() == "")?
                                              this.GenerateVoucherNo(paymentVoucher.PaymentVoucherDate.Value).VouchersNumbersVNo: paymentVoucher.PaymentVoucherVoucherNo;
                paymentVoucher.PaymentVoucherVoucherNo = paymentVoucherNumber;

                paymentVoucherDetails = paymentVoucherDetails.Select((x) => {
                    x.PaymentVoucherDetailsSno = null;
                    x.PaymentVoucherDetailsVoucherNo = paymentVoucherNumber;
                    return x;
                }).ToList();
                _paymentVoucherDetailsRepository.InsertList(paymentVoucherDetails);

                accountsTransactions = accountsTransactions.Select((k) => {
                    k.AccountsTransactionsVoucherNo = paymentVoucherNumber;
                    k.AccountsTransactionsVoucherType = VoucherType.Payment;
                    k.AccountsTransactionsStatus = AccountStatus.Approved;
                    return k;
                }).ToList();
                _accountTransactionRepository.InsertList(accountsTransactions);
                _paymentVoucherRepository.Insert(paymentVoucher);
                _paymentVoucherRepository.TransactionCommit();
                return this.GetSavedPaymentDetails(paymentVoucher.PaymentVoucherVoucherNo);

            }
            catch (Exception ex)
            {
                _paymentVoucherRepository.TransactionRollback();
                throw ex;
            }



        }
        public IEnumerable<AccountsTransactions> GetAllTransaction()
        {
            return _accountTransactionRepository.GetAll();
        }
        public IEnumerable<PaymentVoucher> GetPaymentVouchers()
        {
            IEnumerable<PaymentVoucher> paymentVouchers = _paymentVoucherRepository.GetAll().Where(k=>k.PaymentVoucherDelStatus == false || k.PaymentVoucherDelStatus == null);
                return paymentVouchers;
        }
        public PaymentVoucherModel GetSavedPaymentDetails(string pvno)
        {
            if(_voucherNumbersRepository.GetAsQueryable().Any(x => x.VouchersNumbersVNo == pvno))
            {
                PaymentVoucherModel voucherdata = _voucherNumbersRepository.GetAsQueryable().Where(x => x.VouchersNumbersVNo == pvno)
                                                .Include(k => k.AccountsTransactions)
                                                .Include(k => k.PaymentVoucherDetails).AsEnumerable()
                                                .Select((k) => new PaymentVoucherModel
                                                {
                                                    accountsTransactions = k.AccountsTransactions.Where(x => x.AccountstransactionsDelStatus == false).ToList(),
                                                    paymentsVoucherDetails = k.PaymentVoucherDetails.Where(x => x.PaymentVocherDetailsDelStatus == false).ToList()
                                                })
                                                .SingleOrDefault();
                voucherdata.paymentVoucher = _paymentVoucherRepository.GetAsQueryable().Where(k => k.PaymentVoucherVoucherNo == pvno).FirstOrDefault();
                return voucherdata;

            }
            return null;

        }

        public VouchersNumbers GenerateVoucherNo(DateTime? VoucherGenDate)
        {
            try
            {
                ////var vno=  this._paymentVoucherRepository.GetAsQueryable().Where(k => k.PaymentVoucherVoucherNo == null).FirstOrDefault();

                var prefix = this._programsettingsRepository.GetAsQueryable().Where(k => k.ProgramSettingsKeyValue == Prefix.PV_Prefix).FirstOrDefault().ProgramSettingsTextValue;
                int vnoMaxVal = Convert.ToInt32(_voucherNumbersRepository.GetAsQueryable()
                                                        .Where(x => x.VouchersNumbersVNoNu > 0 && x.VouchersNumbersVType == VoucherType.Payment)
                                                        .DefaultIfEmpty()
                                                        .Max(o => o == null ? 0 : o.VouchersNumbersVNoNu)) + 1;
                VouchersNumbers vouchersNumbers = new VouchersNumbers
                {
                    VouchersNumbersVNo = prefix + vnoMaxVal,
                    VouchersNumbersVNoNu = vnoMaxVal,
                    VouchersNumbersVType = VoucherType.Payment,
                    VouchersNumbersFsno = 1,
                    VouchersNumbersStatus = AccountStatus.Pending,
                    VouchersNumbersVoucherDate = VoucherGenDate

                };
                _voucherNumbersRepository.Insert(vouchersNumbers);
                return vouchersNumbers;
            } 
            catch(Exception ex)
            {
                throw ex;
            }
         
        }

         public VouchersNumbers GetVouchersNumbers(string pvno)
        {
            try
            {
                VouchersNumbers vouchersNumbers = _voucherNumbersRepository.GetAsQueryable().Where(k => k.VouchersNumbersVNo == pvno).SingleOrDefault();
                return vouchersNumbers;
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message);
                throw ex;
            }
          
        }
    }
}
