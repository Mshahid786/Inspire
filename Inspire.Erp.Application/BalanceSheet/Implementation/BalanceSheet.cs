using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Inspire.Erp.Domain.Entities;
using Inspire.Erp.Domain.Modals;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Inspire.Erp.Application.BalanceSheet.Interface;
using System.Threading.Tasks;
using static Inspire.Erp.Domain.Modals.BalanceSheetResponse;
//using static Inspire.Erp.Domain.Entities.StoreWareHouse;


namespace Inspire.Erp.Application.BalanceSheet.Implementation
{
    public class BalanceSheet  : IBalanceSheet
        
    {
        private readonly InspireErpDBContext _sr;
        public IMapper _im;
        public BalanceSheet(InspireErpDBContext sr)
        {
            _sr = sr;
        }

        public async Task<dynamic> getBalanceSheet(DateTime StartDate, DateTime EndDate)
        {
            try
            {
                var response = await _sr.Set<BalanceSheetResponse>().FromSqlRaw($"EXEC GetBalanceSheet @StartDate,@EndDate", new SqlParameter("@StartDate", StartDate), new SqlParameter("@EndDate", EndDate)).ToListAsync();
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}


