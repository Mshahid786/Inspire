using Inspire.Erp.Domain.Entities;
using Inspire.Erp.Infrastructure.Database.Repositoy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inspire.Erp.Application.Master
{
   public class JobMasterService: IJobMasterService
    {
        private IRepository<JobMaster> jobrepository;
        public JobMasterService(IRepository<JobMaster> _jobrepository)
        {
            jobrepository = _jobrepository;
        }
        public IEnumerable<JobMaster> InsertJob(JobMaster jobMaster)
        {
            bool valid = false;
            try
            {
                valid = true;
                int mxc = 0;
                mxc = (int)jobrepository.GetAsQueryable().Where(k => k.JobMasterJobId != null).Select(x => x.JobMasterJobId).Max();
                if (mxc == null) { mxc = 1; } else { mxc = mxc + 1; }

                jobMaster.JobMasterJobId = mxc;
                jobrepository.Insert(jobMaster);
            }
            catch (Exception ex)
            {
                valid = false;
                throw ex;
            }
            finally
            {
                //jobrepository.Dispose();
            }
            return this.GetAllJob();
        }
        public IEnumerable<JobMaster> UpdateJob(JobMaster jobMaster)
        {
            bool valid = false;
            try
            {
               jobrepository.Update(jobMaster);
                valid = true;

            }
            catch (Exception ex)
            {
                valid = false;
                throw ex;

            }
            finally
            {
                //jobrepository.Dispose();
            }
            return this.GetAllJob();
        }
        public IEnumerable<JobMaster> DeleteJob(JobMaster jobMaster)
        {
            bool valid = false;
            try
            {
                jobrepository.Delete(jobMaster);
                valid = true;

            }
            catch (Exception ex)
            {
                valid = false;
                throw ex;

            }
            finally
            {
                //jobrepository.Dispose();
            }
            return this.GetAllJob();
        }
        public IEnumerable<JobMaster> GetAllJob()
        {
            IEnumerable<JobMaster> jobMasters;
            try
            {
                jobMasters = jobrepository.GetAll();

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                //jobrepository.Dispose();
            }
            return jobMasters;
        }

        public IEnumerable<JobMaster> GetAllJobById(int id)
        {
            IEnumerable<JobMaster> jobMasters;
            try
            {
                jobMasters = jobrepository.GetAsQueryable().Where(k => k.JobMasterJobId == id).Select(k => k);

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                //cityrepository.Dispose();
            }
            return jobMasters;

        }

    }
}
