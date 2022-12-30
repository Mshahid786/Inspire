using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Inspire.Erp.Domain.Entities;
using Inspire.Erp.Domain.Modals;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Inspire.Erp.Application.VoucherPrinting.Interface;
using Inspire.Erp.Application.StoreWareHouse.Interfaces;
using System.Threading.Tasks;
using static Inspire.Erp.Domain.Modals.GetVoucherPrintResponse;
//using static Inspire.Erp.Domain.Entities.StoreWareHouse;




namespace Inspire.Erp.Application.VoucherPrinting.Implementation
{
    public class VoucherPrinting : IvoucherPrinting
    {
        private readonly InspireErpDBContext _sr;
        public IMapper _im;
        public VoucherPrinting(InspireErpDBContext sr)
        {
            _sr = sr;
        }

        public async Task<dynamic> getVoucherPrintReport(DateTime StartDate, DateTime EndDate, string VoucherNoFrom,string VoucherNoTo, string VoucherTye, string ChequeNo, string VoucherNo_No)
        {
            try
            {
                var response = await _sr.Set<GetVoucherPrintResponse>().FromSqlRaw($"EXEC GetVoucherPrinting @voucherNoFrom,@VoucherNOTo,@VoucherType,@StartDate,@EndDate,@chequeNo,@VoucherNo_NU", new SqlParameter("@voucherNoFrom", VoucherNoFrom),new SqlParameter("@VoucherNoTo",VoucherNoTo), new SqlParameter("@VoucherType", VoucherTye), new SqlParameter("@StartDate", StartDate), new SqlParameter("@EndDate", EndDate), new SqlParameter("@chequeNo", ChequeNo), new SqlParameter("@VoucherNo_NU", VoucherNo_No)).ToListAsync();
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}











