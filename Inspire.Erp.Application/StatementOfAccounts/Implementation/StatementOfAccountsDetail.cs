using AutoMapper;
using Inspire.Erp.Application.StatementOfAccounts.Interface;
using Inspire.Erp.Application.VoucherPrinting.Interface;
using Inspire.Erp.Domain.Entities;
using Inspire.Erp.Domain.Modals;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Inspire.Erp.Application.StatementOfAccounts.Implementation
{

    public class StatementOFAccountsDetail : IStatementOfAccountsDetail
    {
        public readonly InspireErpDBContext _sr;
        public IMapper _im;
        public StatementOFAccountsDetail(InspireErpDBContext sr, IMapper im)
        {
            _sr = sr;
            _im = im;
        }

        public async Task<dynamic> GetAccountStatementDetails(DateTime StartDate, DateTime EndDate, string AcNo, string Description, string Particulars, string JobNo)
        {
            try
            {
                var response = await _sr.Set<StatementOfAccountsDetailResponse>().FromSqlRaw($"EXEC GetAccountStatementDetails @StartDate,@EndDate,@AcNo,@Description,@Particulars,@JobNo", new SqlParameter("@StartDate", StartDate), new SqlParameter("@EndDate", EndDate), new SqlParameter("@AcNo", AcNo), new SqlParameter("@Description", Description), new SqlParameter("@Particulars", Particulars), new SqlParameter("@JobNo", JobNo)).ToListAsync();
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}



//using AutoMapper;
//using Inspire.Erp.Application.StatementOfAccounts.Interface;
//using Inspire.Erp.Application.VoucherPrinting.Interface;
//using Inspire.Erp.Domain.Entities;
//using Inspire.Erp.Domain.Modals;
//using Microsoft.Data.SqlClient;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Text;
////using System.Threading.Tasks;

//namespace Inspire.Erp.Application.StatementOfAccounts.Implementation
//{

//    public class StatementOFAccountsDetail : IStatementOfAccountsDetail
//    {
//        public readonly InspireErpDBContext _sr;
//        public IMapper _im;
//        public StatementOFAccountsDetail(InspireErpDBContext sr)

//        {
//            _sr = sr;
//        }

//        public async Task<dynamic> getStatementOfAccountDetail(DateTime StartDate, DateTime EndDate, string @AcNo, string Description, string @Particulars, string JobNo)
//        {
//            try
//            {
//                var response = await _sr.Set<StatementOfAccountsDetailResponse>().FromSqlRaw($"EXEC GetAccountStatementDetails @StartDate,@EndDate,@AcNo,@Description,@Particulars,@JobNo", new SqlParameter("@StartDate", StartDate), new SqlParameter("@EndDate",EndDate), new SqlParameter("@AcNo", @AcNo), new SqlParameter("@Description", Description), new SqlParameter("@Particulars", @Particulars), new SqlParameter("@JobNo", JobNo)).ToListAsync();
//                return response;
//            }
//            catch (Exception ex)
//            {
//                throw ex;
//            }
//        }
//    }
//}


