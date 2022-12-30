using System;
using System.Collections.Generic;
using System.Text;
using Inspire.Erp.Domain.Entities;
using System.Threading.Tasks;
using static Inspire.Erp.Domain.Modals.GetVoucherPrintResponse;


namespace Inspire.Erp.Application.VoucherPrinting.Interface
{
    public interface IvoucherPrinting
    {
        public Task<dynamic> getVoucherPrintReport(DateTime StartDate,DateTime EndDate,string VoucherNoFrom,string VoucherNoTo,string VoucherTye,string ChequeNo,string VoucherNo_No);
    }
}
