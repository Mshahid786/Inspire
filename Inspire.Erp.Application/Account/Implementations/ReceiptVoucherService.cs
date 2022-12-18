using Inspire.Erp.Application.Account.Interfaces;
using Inspire.Erp.Application.Common;
using Inspire.Erp.Domain.Entities;
using Inspire.Erp.Domain.Enums;
using Inspire.Erp.Infrastructure.Database.Repositoy;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Inspire.Erp.Application.Account.Implementations
{
    public class ReceiptVoucherService : IReceiptVoucherService
    {
        private IRepository<AccountsTransactions> _accountTransactionRepository;
        private IRepository<ReceiptVoucherMaster> _receiptVoucherRepository;
        private IRepository<ReceiptVoucherDetails> _receiptVoucherDetailsRepository;
        private IRepository<ProgramSettings> _programsettingsRepository;
        private IRepository<VouchersNumbers> _voucherNumbersRepository;


        public ReceiptVoucherService(IRepository<AccountsTransactions> accountTransactionRepository, IRepository<ProgramSettings> programsettingsRepository,
            IRepository<VouchersNumbers> voucherNumbers,
            IRepository<ReceiptVoucherMaster> receiptVoucherRepository, IRepository<ReceiptVoucherDetails> receiptVoucherDetailsRepository)
        {
            this._accountTransactionRepository = accountTransactionRepository;
            this._receiptVoucherRepository = receiptVoucherRepository;
            this._receiptVoucherDetailsRepository = receiptVoucherDetailsRepository;
            _programsettingsRepository = programsettingsRepository;
            _voucherNumbersRepository = voucherNumbers;

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

        public ReceiptVoucherModel UpdateReceiptVoucher(ReceiptVoucherMaster receiptVoucher, List<AccountsTransactions> accountsTransactions, List<ReceiptVoucherDetails> receiptVoucherDetails)
        {

            try
            {
                _receiptVoucherRepository.BeginTransaction();

                _receiptVoucherRepository.Update(receiptVoucher);
                accountsTransactions = accountsTransactions.Select((k) =>
                {
                    if (k.AccountsTransactionsTransSno == 0)
                    {
                        k.AccountsTransactionsVoucherType = VoucherType.Receipt;
                        k.AccountsTransactionsStatus = AccountStatus.Approved;
                    }

                    return k;
                }).ToList();
                _accountTransactionRepository.UpdateList(accountsTransactions);
                _receiptVoucherDetailsRepository.UpdateList(receiptVoucherDetails);
                _receiptVoucherRepository.TransactionCommit();

            }
            catch (Exception ex)
            {
                _receiptVoucherRepository.TransactionRollback();
                throw ex;
            }

            return this.GetSavedReceiptDetails(receiptVoucher.ReceiptVoucherMasterVoucherNo);
        }

        public int DeleteReceiptVoucher(ReceiptVoucherMaster receiptVoucher, List<AccountsTransactions> accountsTransactions, List<ReceiptVoucherDetails> receiptVoucherDetails)
        {
            int i = 0;
            try
            {
                _receiptVoucherRepository.BeginTransaction();

                receiptVoucher.ReceiptVoucherMasterDelStatus = true;

                receiptVoucherDetails = receiptVoucherDetails.Select((k) => {
                    k.ReceiptVoucherDetailsDelStatus = true;
                    return k;
                }).ToList();

                _receiptVoucherDetailsRepository.UpdateList(receiptVoucherDetails);

                accountsTransactions = accountsTransactions.Select((k) => {
                    k.AccountstransactionsDelStatus = true;
                    return k;
                }).ToList();
                _accountTransactionRepository.UpdateList(accountsTransactions);

                _receiptVoucherRepository.Update(receiptVoucher);

                var vchrnumer = _voucherNumbersRepository.GetAsQueryable().Where(k => k.VouchersNumbersVNo == receiptVoucher.ReceiptVoucherMasterVoucherNo).FirstOrDefault();

                _voucherNumbersRepository.Update(vchrnumer);

                _receiptVoucherRepository.TransactionCommit();
                i = 1;
            }
            catch (Exception ex)
            {
                _receiptVoucherRepository.TransactionRollback();
                i = 0;
                throw ex;
            }


            return i;

        }

        public ReceiptVoucherModel InsertReceiptVoucher(ReceiptVoucherMaster receiptVoucher, List<AccountsTransactions> accountsTransactions,
                                                       List<ReceiptVoucherDetails> receiptVoucherDetails)
        {
            try
            {
                _receiptVoucherRepository.BeginTransaction();
                string receiptVoucherNumber = (receiptVoucher.ReceiptVoucherMasterVoucherNo == null || receiptVoucher.ReceiptVoucherMasterVoucherNo.Trim() == "") ?
                                              this.GenerateVoucherNo(receiptVoucher.ReceiptVoucherMasterVoucherDate.Value).VouchersNumbersVNo : receiptVoucher.ReceiptVoucherMasterVoucherNo;
                receiptVoucher.ReceiptVoucherMasterVoucherNo = receiptVoucherNumber;

                receiptVoucherDetails = receiptVoucherDetails.Select((x) => {
                    x.ReceiptVoucherDetailsSlNo = null;
                    x.ReceiptVoucherDetailsVoucherNo = receiptVoucherNumber;
                    return x;
                }).ToList();
                _receiptVoucherDetailsRepository.InsertList(receiptVoucherDetails);

                accountsTransactions = accountsTransactions.Select((k) => {
                    k.AccountsTransactionsVoucherNo = receiptVoucherNumber;
                    k.AccountsTransactionsVoucherType = VoucherType.Receipt;
                    k.AccountsTransactionsStatus = AccountStatus.Approved;
                    return k;
                }).ToList();
                _accountTransactionRepository.InsertList(accountsTransactions);
                _receiptVoucherRepository.Insert(receiptVoucher);
                _receiptVoucherRepository.TransactionCommit();
                return this.GetSavedReceiptDetails(receiptVoucher.ReceiptVoucherMasterVoucherNo);

            }
            catch (Exception ex)
            {
                _receiptVoucherRepository.TransactionRollback();
                throw ex;
            }



        }


        ////public ReceiptVoucherModel InsertReceiptVoucher(ReceiptVoucherMaster receiptVoucher, List<AccountsTransactions> accountsTransactions, List<ReceiptVoucherDetails> receiptVoucherDetails)
        ////{
        ////    try
        ////    {
        ////        _receiptVoucherRepository.BeginTransaction();
        ////        string receiptVoucherNumber;


        ////        var vno = receiptVoucher.ReceiptVoucherMasterVoucherNo;


        ////        if (vno == null)
        ////        {

        ////            receiptVoucherNumber = this.GenerateVoucherNo(receiptVoucher.ReceiptVoucherMasterVoucherDate.Value).VouchersNumbersVNo;
        ////            receiptVoucher.ReceiptVoucherMasterVoucherNo = receiptVoucherNumber;

        ////        }
        ////        else
        ////        {
        ////            receiptVoucherNumber = receiptVoucher.ReceiptVoucherMasterVoucherNo;
        ////        }



        ////        receiptVoucherDetails = receiptVoucherDetails.Select((x) => {
        ////            x.ReceiptVoucherDetailsSlNo = null;
        ////            x.ReceiptVoucherDetailsVoucherNo = receiptVoucherNumber;
        ////            return x;
        ////        }).ToList();
        ////        _receiptVoucherDetailsRepository.InsertList(receiptVoucherDetails);

        ////        accountsTransactions = accountsTransactions.Select((k) => {
        ////            k.AccountsTransactionsVoucherNo = receiptVoucherNumber;
        ////            k.AccountsTransactionsVoucherType = VoucherType.Receipt;
        ////            k.AccountsTransactionsStatus = AccountStatus.Approved;
        ////            return k;
        ////        }).ToList();
        ////        _accountTransactionRepository.InsertList(accountsTransactions);
        ////        _receiptVoucherRepository.Insert(receiptVoucher);
        ////        _receiptVoucherRepository.TransactionCommit();
        ////        return this.GetSavedReceiptDetails(receiptVoucher.ReceiptVoucherMasterVoucherNo);

        ////    }
        ////    catch (Exception ex)
        ////    {
        ////        _receiptVoucherRepository.TransactionRollback();
        ////        throw ex;
        ////    }



        ////}
        public IEnumerable<AccountsTransactions> GetAllTransaction()
        {
            return _accountTransactionRepository.GetAll();
        }
        public IEnumerable<ReceiptVoucherMaster> GetReceiptVouchers()
        {
            IEnumerable<ReceiptVoucherMaster> receiptVouchers = _receiptVoucherRepository.GetAll().Where(k => k.ReceiptVoucherMasterDelStatus == false || k.ReceiptVoucherMasterDelStatus == null);
            return receiptVouchers;
        }
        public ReceiptVoucherModel GetSavedReceiptDetails(string Rvno)
        {
            if (_voucherNumbersRepository.GetAsQueryable().Any(x => x.VouchersNumbersVNo == Rvno))
            {
                ReceiptVoucherModel voucherdata = _voucherNumbersRepository.GetAsQueryable().Where(x => x.VouchersNumbersVNo == Rvno)
                                                .Include(k => k.AccountsTransactions)
                                                .Include(k => k.ReceiptVoucherDetails).AsEnumerable()
                                                .Select((k) => new ReceiptVoucherModel
                                                {
                                                    accountsTransactions = k.AccountsTransactions.Where(x => x.AccountstransactionsDelStatus == false).ToList(),
                                                    receiptVoucherDetails = k.ReceiptVoucherDetails.Where(x => x.ReceiptVoucherDetailsDelStatus == false).ToList()
                                                })
                                                .SingleOrDefault();
                voucherdata.receiptVoucher = _receiptVoucherRepository.GetAsQueryable().Where(k => k.ReceiptVoucherMasterVoucherNo == Rvno).FirstOrDefault();
                return voucherdata;

            }
            return null;

        }

        public VouchersNumbers GenerateVoucherNo(DateTime? VoucherGenDate)
        {
            try
            {
                ////var vno=  this._paymentVoucherRepository.GetAsQueryable().Where(k => k.PaymentVoucherVoucherNo == null).FirstOrDefault();

                var prefix = this._programsettingsRepository.GetAsQueryable().Where(k => k.ProgramSettingsKeyValue == Prefix.RV_Prefix).FirstOrDefault().ProgramSettingsTextValue;
                int vnoMaxVal = Convert.ToInt32(_voucherNumbersRepository.GetAsQueryable()
                                                        .Where(x => x.VouchersNumbersVNoNu > 0 && x.VouchersNumbersVType == VoucherType.Receipt)
                                                        .DefaultIfEmpty()
                                                        .Max(o => o == null ? 0 : o.VouchersNumbersVNoNu)) + 1;
                VouchersNumbers vouchersNumbers = new VouchersNumbers
                {
                    VouchersNumbersVNo = prefix + vnoMaxVal,
                    VouchersNumbersVNoNu = vnoMaxVal,
                    VouchersNumbersVType = VoucherType.Receipt,
                    VouchersNumbersFsno = 1,
                    VouchersNumbersStatus = AccountStatus.Pending,
                    VouchersNumbersVoucherDate = VoucherGenDate

                };
                _voucherNumbersRepository.Insert(vouchersNumbers);
                return vouchersNumbers;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public VouchersNumbers GetVouchersNumbers(string Rvno)
        {
            VouchersNumbers vouchersNumbers = _voucherNumbersRepository.GetAsQueryable().Where(k => k.VouchersNumbersVNo == Rvno).SingleOrDefault();
            return vouchersNumbers;
        }
    }
}




////using Inspire.Erp.Application.Account.Interfaces;
////using Inspire.Erp.Domain.Entities;
////using Inspire.Erp.Domain.Enums;
////using Inspire.Erp.Infrastructure.Database.Repositoy;
////using Microsoft.EntityFrameworkCore.Metadata.Internal;
////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Security.Cryptography.X509Certificates;
////using System.Text;

////namespace Inspire.Erp.Application.Account.Implementations
////{
////    public class ReceiptVoucherService : IReceiptVoucherService
////    {
////        private IRepository<AccountsTransactions> _accountTransactionRepository;
////        private IRepository<ReceiptVoucherMaster> _receiptVoucherRepository;
////        private IRepository<ReceiptVoucherDetails> _receiptVoucherDetailsRepository;
////        private IRepository<ProgramSettings> _programsettingRepository;
////        private IRepository<VouchersNumbers> _vouchernumbersRepository;

////        public ReceiptVoucherService(IRepository<AccountsTransactions> accountTransactionRepository,
////            IRepository<ReceiptVoucherMaster> receiptVoucherRepository, IRepository<ReceiptVoucherDetails> receiptVoucherDetailsRepository,
////            IRepository<ProgramSettings> programsettingsRepository,IRepository<VouchersNumbers> vouchernumbersRepository)
////        {
////            this._accountTransactionRepository = accountTransactionRepository;
////            this._receiptVoucherRepository = receiptVoucherRepository;
////            this._receiptVoucherDetailsRepository = receiptVoucherDetailsRepository;
////            this._programsettingRepository = programsettingsRepository;
////            this._vouchernumbersRepository = vouchernumbersRepository;
////        }
////        public IEnumerable<AccountsTransactions> InsertReceiptVoucher(ReceiptVoucherMaster receiptVoucherMaster,
////          List<ReceiptVoucherDetails> receiptVoucherDetails)
////        {
////            try
////            {
////                _accountTransactionRepository.BeginTransaction();

////                _receiptVoucherRepository.Insert(receiptVoucherMaster);
////                //int acctTransMaxVal = Convert.ToInt32(_accountTransactionRepository.GetAsQueryable()
////                //                                        .Where(x => x.AccountsTransactionsTransSno > 0)
////                //                                        .DefaultIfEmpty()
////                //                                        .Max(o => o == null ? 0 : o.AccountsTransactionsTransSno)) + 1;
////                _receiptVoucherDetailsRepository.InsertList(receiptVoucherDetails.Select(k =>
////                {
////                    k.ReceiptVoucherDetailsVoucherNo = receiptVoucherMaster.ReceiptVoucherMasterVoucherNo;
////                    return k;
////                }).ToList());
////                List<AccountsTransactions> accountsTransactions = new List<AccountsTransactions>();
////                AccountsTransactions debitData = new AccountsTransactions();
////                ////debitData.AccountsTransactionsAccNo = receiptVoucherMaster.ReceiptVoucherMasterDrAcNo;
////                //////creditData.AccountsTransactionsTransSno = acctTransMaxVal;
////                ////debitData.AccountsTransactionsTransDate = (DateTime)receiptVoucherMaster.ReceiptVoucherMasterVoucherDate.Value.Date;
////                ////debitData.AccountsTransactionsParticulars = receiptVoucherMaster.ReceiptVoucherMasterNarration;
////                ////debitData.AccountsTransactionsDebit = Convert.ToDecimal(receiptVoucherMaster.ReceiptVoucherMasterDrAmount);
////                ////debitData.AccountsTransactionsFcDebit = Convert.ToDecimal(receiptVoucherMaster.ReceiptVoucherMasterDrAmount);
////                ////debitData.AccountsTransactionsVoucherType = VoucherType.Receipt;
////                ////debitData.AccountsTransactionsTstamp = DateTime.Now;
////                debitData.AccountsTransactionsVoucherNo = receiptVoucherMaster.ReceiptVoucherMasterVoucherNo;
////                debitData.AccountsTransactionsDescription = receiptVoucherMaster.ReceiptVoucherMasterNarration;
////                debitData.AccountsTransactionsStatus = AccountStatus.Approved;
////                accountsTransactions.Add(debitData);

////                //int transactionIntialCount = Convert.ToInt32(creditData.AccountsTransactionsTransSno + 1);
////                foreach (var credit in receiptVoucherDetails)
////                {
////                    //transactionIntialCount = transactionIntialCount + 1;
////                    AccountsTransactions creditData = new AccountsTransactions();
////                    ////creditData.AccountsTransactionsAccNo = credit.ReceiptVoucherDetailsCrAcNo;
////                    //////debitData.AccountsTransactionsTransSno = transactionIntialCount;
////                    ////creditData.AccountsTransactionsTransDate = (DateTime)debitData.AccountsTransactionsTransDate;
////                    ////creditData.AccountsTransactionsParticulars = credit.ReceiptVoucherDetailsNarration; 
////                    ////creditData.AccountsTransactionsCredit = Convert.ToDecimal(credit.ReceiptVoucherDetailsCrAmount);
////                    ////creditData.AccountsTransactionsFcCredit = Convert.ToDecimal(credit.ReceiptVoucherDetailsCrAmount);
////                    ////creditData.AccountsTransactionsVoucherType = VoucherType.Receipt;
////                    creditData.AccountsTransactionsTstamp = DateTime.Now;
////                    creditData.AccountsTransactionsVoucherNo = receiptVoucherMaster.ReceiptVoucherMasterVoucherNo;
////                    creditData.AccountsTransactionsDescription = credit.ReceiptVoucherDetailsNarration;
////                    creditData.AccountsTransactionsStatus = AccountStatus.Approved;
////                    accountsTransactions.Add(creditData);

////                }
////                _accountTransactionRepository.InsertList(accountsTransactions);
////                _accountTransactionRepository.TransactionCommit();
////            }
////            catch (Exception ex)
////            {
////                _accountTransactionRepository.TransactionRollback();
////            }
////            return this.GetAllTransaction();

////        }

////        public IEnumerable<AccountsTransactions> GetAllTransaction()
////        {
////            return _accountTransactionRepository.GetAll();
////        }
////    }
////}
