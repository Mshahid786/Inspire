using Inspire.Erp.Domain.Entities;
using Inspire.Erp.Infrastructure.Database.Repositoy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inspire.Erp.Application.Master
{
    public class PriceLevelMasterService : IPriceLevelMasterService
    {
        private IRepository<PriceLevelMaster> priceLevelrepository;
        public PriceLevelMasterService(IRepository<PriceLevelMaster> _priceLevelrepository)
        {
            priceLevelrepository = _priceLevelrepository;
        }
        public IEnumerable<PriceLevelMaster> InsertPriceLevel(PriceLevelMaster priceLevelMaster)
        {
            bool valid = false;
            try
            {
                valid = true;
                int mxc = 0;
                mxc = (int)priceLevelrepository.GetAsQueryable().Where(k => k.PriceLevelMasterPriceLevelId != null).Select(x => x.PriceLevelMasterPriceLevelId).Max();
                if (mxc == null) { mxc = 1; } else { mxc = mxc + 1; }

                priceLevelMaster.PriceLevelMasterPriceLevelId = mxc;
                priceLevelrepository.Insert(priceLevelMaster);
            }
            catch (Exception ex)
            {
                valid = false;
                throw ex;

            }
            finally
            {
                //priceLevelrepository.Dispose();
            }
            return this.GetAllPriceLevel();
        }
        public IEnumerable<PriceLevelMaster> UpdatePriceLevel(PriceLevelMaster priceLevelMaster)
        {
            bool valid = false;
            try
            {
                priceLevelrepository.Update(priceLevelMaster);
                valid = true;

            }
            catch (Exception ex)
            {
                valid = false;
                throw ex;

            }
            finally
            {
                //priceLevelrepository.Dispose();
            }
            return this.GetAllPriceLevel();
        }
        public IEnumerable<PriceLevelMaster> DeletePriceLevel(PriceLevelMaster priceLevelMaster)
        {
            bool valid = false;
            try
            {
                priceLevelrepository.Delete(priceLevelMaster);
                valid = true;

            }
            catch (Exception ex)
            {
                valid = false;
                throw ex;

            }
            finally
            {
                //priceLevelrepository.Dispose();
            }
            return this.GetAllPriceLevel();
        }

        public IEnumerable<PriceLevelMaster> GetAllPriceLevel()
        {
            IEnumerable<PriceLevelMaster> priceLevelMasters;
            try
            {
                priceLevelMasters = priceLevelrepository.GetAll();

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                //priceLevelrepository.Dispose();
            }
            return priceLevelMasters;
        }
        public IEnumerable<PriceLevelMaster> GetAllPriceLevelById(int id)
        {
            IEnumerable<PriceLevelMaster> priceLevelMasters;
            try
            {
                priceLevelMasters = priceLevelrepository.GetAsQueryable().Where(k => k.PriceLevelMasterPriceLevelId == id).Select(k => k);

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                //cityrepository.Dispose();
            }
            return priceLevelMasters;

        }

    }
}
