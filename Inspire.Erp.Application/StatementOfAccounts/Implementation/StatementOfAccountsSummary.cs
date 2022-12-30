using AutoMapper;
using Inspire.Erp.Application.StatementOfAccounts.Interface;
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
    public class StatementOfAccountsSummary : IStatementOfAccountsSummary
    {
        private readonly InspireErpDBContext _sr;
        public IMapper _im;

        public StatementOfAccountsSummary(InspireErpDBContext sr, IMapper im)
        {
            _sr = sr;
            _im = im;
        }

        public async Task<dynamic> GetStatementOfAccountSummary(string AcNo, DateTime StartDate)
        {
            try
            {
                var response = await _sr.Set<StatementOfAccountSummaryResponse>().FromSqlRaw($"EXEC GetStatementOfAccountSummary @AcNo,@StartDate", new SqlParameter("@AcNo", AcNo), new SqlParameter("@StartDate", StartDate)).ToListAsync();
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
//using Inspire.Erp.Domain.Entities;
//using Inspire.Erp.Domain.Modals;
//using Microsoft.Data.SqlClient;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Threading.Tasks;

//namespace Inspire.Erp.Application.StatementOfAccounts.Implementation
//{
//    public class StatementOfAccountsSummary : IStatementOfAccountsSummary
//    {
//        private readonly InspireErpDBContext _sr;
//        public IMapper _im;

//        public StatementOfAccountsSummary(InspireErpDBContext sr)
//        {
//            _sr = sr;
//        }

//        public async Task<dynamic> getStatementOfAccountsSummary(string AcNo, DateTime StartDate)
//        {
//            try
//            {
//                var response = await _sr.Set<StatementOfAccountsSummary>().FromSqlRaw($"EXEC GetStatementOfAccountSummary @AcNo,@StartDate", new SqlParameter("@AcNo", AcNo), new SqlParameter("@StartDate", StartDate)).ToListAsync();
//                return response;
//            }
//            catch (Exception ex)
//            {
//                throw ex;
//            }
//        }
//    }
//}


