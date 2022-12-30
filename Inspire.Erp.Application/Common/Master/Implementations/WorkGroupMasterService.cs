
using Inspire.Erp.Domain.Entities;
using Inspire.Erp.Infrastructure.Database.Repositoy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inspire.Erp.Application.Master
{
    public class WorkGroupMasterService : IWorkGroupMasterService
    {
        private IRepository<WorkGroupMaster> workGrouprepository;
        public WorkGroupMasterService(IRepository<WorkGroupMaster> _workGrouprepository)
        {
            workGrouprepository = _workGrouprepository;
        }
        public IEnumerable<WorkGroupMaster> InsertWorkGroup(WorkGroupMaster workGroupMaster)
        {
            bool valid = false;
            try
            {
                valid = true;
                int mxc = 0;
                mxc = (int)workGrouprepository.GetAsQueryable().Where(k => k.WorkGroupMasterWorkGroupId != null).Select(x => x.WorkGroupMasterWorkGroupId).Max();
                if (mxc == null) { mxc = 1; } else { mxc = mxc + 1; }

                workGroupMaster.WorkGroupMasterWorkGroupId = mxc;
                workGrouprepository.Insert(workGroupMaster);
            }
            catch (Exception ex)
            {
                valid = false;
                throw ex;

            }
            finally
            {
                //workGrouprepository.Dispose();
            }
            return this.GetAllWorkGroup();
        }
        public IEnumerable<WorkGroupMaster> UpdateWorkGroup(WorkGroupMaster workGroupMaster)
        {
            bool valid = false;
            try
            {
                workGrouprepository.Update(workGroupMaster);
                valid = true;

            }
            catch (Exception ex)
            {
                valid = false;
                throw ex;

            }
            finally
            {
                //WorkGrouprepository.Dispose();
            }
            return this.GetAllWorkGroup();
        }
        public IEnumerable<WorkGroupMaster> DeleteWorkGroup(WorkGroupMaster workGroupMaster)
        {
            bool valid = false;
            try
            {
                workGrouprepository.Delete(workGroupMaster);
                valid = true;

            }
            catch (Exception ex)
            {
                valid = false;
                throw ex;

            }
            finally
            {
                //workGrouprepository.Dispose();
            }
            return this.GetAllWorkGroup();
        }

        public IEnumerable<WorkGroupMaster> GetAllWorkGroup()
        {
            IEnumerable<WorkGroupMaster> workGroupMasters;
            try
            {
                workGroupMasters = workGrouprepository.GetAll();

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                //workGrouprepository.Dispose();
            }
            return workGroupMasters;
        }
        public IEnumerable<WorkGroupMaster> GetAllWorkGroupById(int id)
        {
            IEnumerable<WorkGroupMaster> workGroupMasters;
            try
            {
                workGroupMasters = workGrouprepository.GetAsQueryable().Where(k => k.WorkGroupMasterWorkGroupId == id).Select(k => k);

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                //cityrepository.Dispose();
            }
            return workGroupMasters;

        }

    }
}
