using Inspire.Erp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inspire.Erp.Application.Master
{
    public interface IJobMasterService
    {
        public IEnumerable<JobMaster> InsertJob(JobMaster jobMaster);
        public IEnumerable<JobMaster> UpdateJob(JobMaster jobMaster);
        public IEnumerable<JobMaster> DeleteJob(JobMaster jobMaster);
        public IEnumerable<JobMaster> GetAllJob();
        public IEnumerable<JobMaster> GetAllJobById(int id);
    }
}
