using System;
using System.Collections.Generic;
using System.Text;

namespace Inspire.Erp.Domain.Enums
{
        public static class PaymentVoucherMessage
        {
//<<<<<<< HEAD
            public static String SaveVoucher { get { return "Payment Voucher saved successfully"; } }
            public static string UpdateVoucher { get { return "Payment Voucher updated successfully"; } }
            public static string DeleteVoucher { get { return "Payment Voucher updated successfully"; } }
            public static string VoucherAlreadyExist { get { return "Payment Voucher is already exist"; } }
////=======
////            public static String SaveVoucher { get { return "Pyment Voucher saved successfully"; } }
////            public static string UpdateVoucher { get { return "Pyment Voucher updated successfully"; } }
////            public static string DeleteVoucher { get { return "Pyment Voucher updated successfully"; } }
////            public static string VoucherAlreadyExist { get { return "Pyment Voucher is already exist"; } }

////            public static string VoucherNumberExist { get { return "Voucher Number is exist"; } }
////>>>>>>> f963c27bf491c4af5dfbcf1d96e17e2521337192
    }

    public static class ReceiptVoucherMessage
    {
        public static String SaveReceiptVoucher { get { return "Receipt Voucher saved successfully"; } }
        public static string UpdateReceiptVoucher { get { return "Receipt Voucher updated successfully"; } }
        public static string DeleteReceiptVoucher { get { return "Receipt Voucher updated successfully"; } }
        public static string ReceiptVoucherAlreadyExist { get { return "Receipt Voucher is already exist"; } }
    }

}
