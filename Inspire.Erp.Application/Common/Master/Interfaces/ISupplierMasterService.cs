using Inspire.Erp.Application.Common;
using Inspire.Erp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inspire.Erp.Application.Master
{
    public interface ISupplierMasterService
    {
        public IEnumerable<SuppliersMaster> InsertSupplier(SuppliersMaster SuppliersMaster);
        public IEnumerable<SuppliersMaster> UpdateSupplier(SuppliersMaster SuppliersMaster);
        public IEnumerable<SuppliersMaster> DeleteSupplier(SuppliersMaster SuppliersMaster);
        public IEnumerable<SuppliersMaster> GetAllSupplier();
        public IEnumerable<SuppliersMaster> GetAllSupplierById(int id);
        public IEnumerable<ItemMasterSupplierDetais> GetUpdatedSupplierDetailsByItem(int itemId);
    }
}
