using Inspire.Erp.Domain.Entities;
using Inspire.Erp.Infrastructure.Database.Repositoy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inspire.Erp.Application.Master
{
    public class CostCenterMasterService : ICostCenterMasterService
    {
        private IRepository<CostCenterMaster> costcenterrepository;
        public CostCenterMasterService(IRepository<CostCenterMaster> _countryrepository)
        {
            costcenterrepository = _countryrepository;
        }
        public IEnumerable<CostCenterMaster> InsertCostCenter(CostCenterMaster CostCenterMaster)
        {
            bool valid = false;
            try
            {
                valid = true;
                int mxc = 0;
                mxc = (int)costcenterrepository.GetAsQueryable().Where(k => k.CostCenterMasterCostCenterId != null).Select(x => x.CostCenterMasterCostCenterId).Max();
                if (mxc == null) { mxc = 1; } else { mxc = mxc + 1; }

                CostCenterMaster.CostCenterMasterCostCenterId = mxc;

                costcenterrepository.Insert(CostCenterMaster);
            }
            catch (Exception ex)
            {
                valid = false;
                throw ex;

            }
            finally
            {
                //costcenterrepository.Dispose();
            }
            return this.GetAllCostCenter();
        }
        public IEnumerable<CostCenterMaster> UpdateCostCenter(CostCenterMaster CostCenterMaster)
        {
            bool valid = false;
            try
            {
                costcenterrepository.Update(CostCenterMaster);
                valid = true;

            }
            catch (Exception ex)
            {
                valid = false;
                throw ex;

            }
            finally
            {
                //costcenterrepository.Dispose();
            }
            return this.GetAllCostCenter();
        }
        public IEnumerable<CostCenterMaster> DeleteCostCenter(CostCenterMaster CostCenterMaster)
        {
            bool valid = false;
            try
            {
                costcenterrepository.Delete(CostCenterMaster);
                valid = true;

            }
            catch (Exception ex)
            {
                valid = false;
                throw ex;

            }
            finally
            {
                //costcenterrepository.Dispose();
            }
            return this.GetAllCostCenter();
        }

        public IEnumerable<CostCenterMaster> GetAllCostCenter()
        {
            IEnumerable<CostCenterMaster> costcenterMasters;
            try
            {
                costcenterMasters = costcenterrepository.GetAll();

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                //costcenterrepository.Dispose();
            }
            return costcenterMasters;
        }

        public IEnumerable<CostCenterMaster> GetAllCostCenterById(int id)
        {
            IEnumerable<CostCenterMaster> costcenterMasters;
            try
            {
                costcenterMasters = costcenterrepository.GetAsQueryable().Where(k => k.CostCenterMasterCostCenterId == id).Select(k => k);

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                //cityrepository.Dispose();
            }
            return costcenterMasters;

        }

    }
}
