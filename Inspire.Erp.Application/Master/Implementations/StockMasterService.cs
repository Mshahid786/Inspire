using Inspire.Erp.Application.Master.Interfaces;
using Inspire.Erp.Domain.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Inspire.Erp.Application.Master.Implementations
{
    public class StockMasterService: IStockMasterService
    {
        private readonly InspireErpDBContext context;
        private readonly IConfiguration configuration;
        private static string conn;
        public StockMasterService(InspireErpDBContext context, IConfiguration _configuration)
        {
            configuration = _configuration;
            conn = configuration.GetConnectionString("db_con");
            this.context = context;
        }
        public string getStockLedgerReport()
        {
            try
            {
                SqlConnection con = new SqlConnection(conn);
                string query = "select Item_Id,Stock_Register_Unit_ID,OpenQty=Sum(case when Stock_Register.Stock_Register_Voucher_Date < '11/10/2021' then (Stock_Register.Stock_Register_SIN-Stock_Register.Stock_Register_Sout) " +
                               "else 0 end)," +
                               "OpenQtyAmount = Sum(case when Stock_Register.Stock_Register_Voucher_Date < '11/10/2021' then((Stock_Register.Stock_Register_SIN - Stock_Register.Stock_Register_Sout) * Stock_Register_Rate) " +
                               "else 0 end)," +
                               "StockIn = Sum(case when Stock_Register.Stock_Register_Voucher_Date between '11/10/2021' and '11/11/2022' and Stock_Register.Stock_Register_Trans_Type = 'SalesReturn' then Stock_Register.Stock_Register_SIN " +
                               "else 0 end)," +
                               "StockInAmount = Sum(case when Stock_Register.Stock_Register_Voucher_Date between '11/10/2021' and '11/11/2022' and Stock_Register.Stock_Register_Trans_Type = 'SalesReturn' then(Stock_Register.Stock_Register_SIN * Stock_Register_Rate) " +
                               "else 0 end)," +
                               "StockOut = (Sum(case when Stock_Register.Stock_Register_Voucher_Date between '11/10/2021' and '11/11/2022' then(Stock_Register.Stock_Register_Sout) else 0 end) - " +
                               "Sum(case when Stock_Register_Voucher_Date > '11/10/2021' and Stock_Register_Trans_Type = 'SalesReturn' then(Stock_Register_SIN * Stock_Register_Rate) " +
                               "else 0 end))," +
                               "StockOutAmount = (Sum(case when Stock_Register.Stock_Register_Voucher_Date between '11/10/2021' and '11/11/2022' then(Stock_Register.Stock_Register_Sout * Stock_Register_Rate) " +
                               "else 0 end)-Sum(case when Stock_Register_Voucher_Date > '11/10/2021' and Stock_Register_Trans_Type = 'SalesReturn' then(Stock_Register_SIN * Stock_Register_Rate) " +
                               "else 0 end))," +
                               "TotalBal = Sum(case when Stock_Register_Voucher_Date <= '11/10/2022' then(Stock_Register_SIN - Stock_Register_Sout) " +
                               "else 0 end)," +
                               "TotalBalAmount = Sum(case when Stock_Register_Voucher_Date <= '11/10/2022' then((Stock_Register_SIN - Stock_Register_Sout) * Stock_Register_Rate) " +
                               "else 0 end)," +
                               "ItemMaster.Item_Name from Stock_Register " +
                               "Left join ItemMaster  on Stock_Register.Stock_Register_Material_ID = ItemMaster.Item_ID where Stock_Register.Stock_Register_Voucher_Date < '11/11/2022' and Stock_Register.Stock_Register_Voucher_Date > '11/12/2020' " +
                               "group by Item_Name,Item_Id,Stock_Register_Unit_ID having " + "SUM(Stock_Register.Stock_Register_SIN) >= SUM(Stock_Register.Stock_Register_Sout) ";
                SqlCommand com = new SqlCommand(query, con);
                con.Open();
                SqlDataAdapter customerDA = new SqlDataAdapter();
                customerDA.SelectCommand = com;
                DataSet customerDS = new DataSet();
                customerDA.Fill(customerDS, "Stock_Register");
                con.Close();
                return JsonConvert.SerializeObject(customerDS);
            }
            catch (Exception ex)
            {
                return "Something Went Wrong !!";
                throw;
            }
        }
        public string getFilteredStockLedgerRpt()
        {
            return "Nulllll";
        }
    }
}
