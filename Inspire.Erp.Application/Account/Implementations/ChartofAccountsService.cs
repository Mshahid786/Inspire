using Inspire.Erp.Domain.Entities;
using Inspire.Erp.Infrastructure.Database.Repositoy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inspire.Erp.Application.Account
{
    public class ChartofAccountsService: IChartofAccountsService
    {
        private IRepository<MasterAccountsTable> chartofAccountsrepository;
        private IRepository<AccountSettings> accountSettingsrepository;
        public ChartofAccountsService(IRepository<MasterAccountsTable> _chartofAccountsrepository, IRepository<AccountSettings> _accountSettingsrepository)
        {
            chartofAccountsrepository = _chartofAccountsrepository;
            accountSettingsrepository = _accountSettingsrepository;
        }
        public IEnumerable<MasterAccountsTable> InsertAccounts(MasterAccountsTable masterAccountsTable)
        {
            bool valid = false;
            try
            {
                valid = true;
                int mxc = 0;
                mxc = chartofAccountsrepository.GetAsQueryable().Where(k => k.MasterAccountsTableSno != null).Select(x => x.MasterAccountsTableSno).Max();
                if (mxc == null) { mxc = 1; } else { mxc = mxc + 1; }

                masterAccountsTable.MasterAccountsTableSno = mxc;
                chartofAccountsrepository.Insert(masterAccountsTable);
            }
            catch (Exception ex)
            {
                valid = false;
                throw ex;

            }
            finally
            {
                //cityrepository.Dispose();
            }
            return this.GetAllAccounts();
        }
        public IEnumerable<MasterAccountsTable> UpdateAccounts(MasterAccountsTable masterAccountsTable)
        {
            bool valid = false;
            try
            {
                chartofAccountsrepository.Update(masterAccountsTable);
                valid = true;

            }
            catch (Exception ex)
            {
                valid = false;
                throw ex;

            }
            finally
            {
                //cityrepository.Dispose();
            }
            return this.GetAllAccounts();
        }
        public IEnumerable<MasterAccountsTable> DeleteAccounts(MasterAccountsTable masterAccountsTable)
        {
            bool valid = false;
            try
            {
                chartofAccountsrepository.Delete(masterAccountsTable);
                valid = true;

            }
            catch (Exception ex)
            {
                valid = false;
                throw ex;

            }
            finally
            {
                //cityrepository.Dispose();
            }
            return this.GetAllAccounts();
        }

        public IEnumerable<MasterAccountsTable> GetAllAccounts()
        {
            IEnumerable<MasterAccountsTable> masterAccountsTable;
            try
            {
                masterAccountsTable = chartofAccountsrepository.GetAll();

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                //cityrepository.Dispose();
            }
            return masterAccountsTable;
        }
        public IEnumerable<MasterAccountsTable> GetAllAccountsById(int id)
        {
            IEnumerable<MasterAccountsTable> masterAccountsTable;
            try
            {
                masterAccountsTable = chartofAccountsrepository.GetAsQueryable().Where(k => k.MasterAccountsTableSno == id).Select(k => k);

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                //cityrepository.Dispose();
            }
            return masterAccountsTable;

        }

        public IEnumerable<AccountSettings> GetDebitAccounts()
        {
            IEnumerable<AccountSettings> accountSettings = null;
            return accountSettings;
        }

        public IEnumerable<AccountSettings> GetCreditAccounts()
        {
            IEnumerable<AccountSettings> accountSettings = null;
            return accountSettings;
        }

    }
}
