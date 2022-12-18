using Inspire.Erp.Application.Common;
using Inspire.Erp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inspire.Erp.Application.Account.Interfaces
{
   public interface IPaymentVoucherService
    {
        //public PaymentVoucher InsertPaymentVoucher(PaymentVoucher paymentVoucher,
        //  List<PaymentVoucherDetails> paymentVoucherDetails);

        public PaymentVoucherModel InsertPaymentVoucher(PaymentVoucher paymentVoucher,List<AccountsTransactions> accountsTransactions,List<PaymentVoucherDetails> paymentVoucherDetails);
        public PaymentVoucherModel UpdatePaymentVoucher(PaymentVoucher paymentVoucher, List<AccountsTransactions> accountsTransactions, List<PaymentVoucherDetails> paymentVoucherDetails);
        public int DeletePaymentVoucher(PaymentVoucher paymentVoucher, List<AccountsTransactions> accountsTransactions, List<PaymentVoucherDetails> paymentVoucherDetails);
        public IEnumerable<AccountsTransactions> GetAllTransaction();
        public PaymentVoucherModel GetSavedPaymentDetails(string pvno);
        public IEnumerable<PaymentVoucher> GetPaymentVouchers();
        public VouchersNumbers GenerateVoucherNo(DateTime? VoucherGenDate);

        public VouchersNumbers GetVouchersNumbers(string pvno);

    }
}
