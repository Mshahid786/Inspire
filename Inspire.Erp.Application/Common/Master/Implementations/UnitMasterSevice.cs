using Inspire.Erp.Domain.Entities;
using Inspire.Erp.Infrastructure.Database.Repositoy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inspire.Erp.Application.Master
{
    public class UnitMasterSevice: IUnitMasterService
    {
        private IRepository<UnitMaster> unitrepository;
        public UnitMasterSevice(IRepository<UnitMaster> _unitrepository)
        {
            unitrepository = _unitrepository;
        }
        public IEnumerable<UnitMaster> InsertUnit(UnitMaster unitMaster)
        {
            bool valid = false;
            try
            {
                valid = true;
                int mxc = 0;
                mxc = (int)unitrepository.GetAsQueryable().Where(k => k.UnitMasterUnitId != null).Select(x => x.UnitMasterUnitId).Max();
                if (mxc == null) { mxc = 1; } else { mxc = mxc + 1; }

                unitMaster.UnitMasterUnitId = mxc;
                unitrepository.Insert(unitMaster);
            }
            catch (Exception ex)
            {
                valid = false;
                throw ex;

            }
            finally
            {
                //unitrepository.Dispose();
            }
            return this.GetAllUnit();
        }
        public IEnumerable<UnitMaster> UpdateUnit(UnitMaster unitMaster)
        {
            bool valid = false;
            try
            {
                unitrepository.Update(unitMaster);
                valid = true;

            }
            catch (Exception ex)
            {
                valid = false;
                throw ex;

            }
            finally
            {
                //unitrepository.Dispose();
            }
            return this.GetAllUnit();
        }
        public IEnumerable<UnitMaster> DeleteUnit(UnitMaster unitMaster)
        {
            bool valid = false;
            try
            {
                unitrepository.Delete(unitMaster);
                valid = true;

            }
            catch (Exception ex)
            {
                valid = false;
                throw ex;

            }
            finally
            {
                //unitrepository.Dispose();
            }
            return this.GetAllUnit();
        }
        public IEnumerable<UnitMaster> GetAllUnit()
        {
            IEnumerable<UnitMaster> unitMasters;
            try
            {
                unitMasters = unitrepository.GetAll();

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                //unitrepository.Dispose();
            }
            return unitMasters;
        }
        public IEnumerable<UnitMaster> GetAllUnitById(int id)
        {
            IEnumerable<UnitMaster> unitMasters;
            try
            {
                unitMasters = unitrepository.GetAsQueryable().Where(k => k.UnitMasterUnitId == id).Select(k => k);

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                //cityrepository.Dispose();
            }
            return unitMasters;

        }
    }
}
