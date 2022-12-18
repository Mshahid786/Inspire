using Inspire.Erp.Application.Common;
using Inspire.Erp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inspire.Erp.Application.Account.Interfaces
{
    public interface IReceiptVoucherService
    {

        public ReceiptVoucherModel InsertReceiptVoucher(ReceiptVoucherMaster receiptVoucher, List<AccountsTransactions> accountsTransactions, List<ReceiptVoucherDetails> receiptVoucherDetails);
        public ReceiptVoucherModel UpdateReceiptVoucher(ReceiptVoucherMaster receiptVoucher, List<AccountsTransactions> accountsTransactions, List<ReceiptVoucherDetails> receiptVoucherDetails);
        public int DeleteReceiptVoucher(ReceiptVoucherMaster receiptVoucher, List<AccountsTransactions> accountsTransactions, List<ReceiptVoucherDetails> receiptVoucherDetails);
        public IEnumerable<AccountsTransactions> GetAllTransaction();
        public ReceiptVoucherModel GetSavedReceiptDetails(string Rvno);
        public IEnumerable<ReceiptVoucherMaster> GetReceiptVouchers();
        public VouchersNumbers GenerateVoucherNo(DateTime? VoucherGenDate);
        public VouchersNumbers GetVouchersNumbers(string Rvno);

    }
}
