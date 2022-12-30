using Inspire.Erp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inspire.Erp.Application.Master
{
    public interface IUnitMasterService
    {
        public IEnumerable<UnitMaster> InsertUnit(UnitMaster unitMaster);
        public IEnumerable<UnitMaster> UpdateUnit(UnitMaster unitMaster);
        public IEnumerable<UnitMaster> DeleteUnit(UnitMaster unitMaster);
        public IEnumerable<UnitMaster> GetAllUnit();
        public IEnumerable<UnitMaster> GetAllUnitById(int id);
    }
}
