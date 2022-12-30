using Inspire.Erp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inspire.Erp.Application.Master
{
    public interface ICustomerMasterService
    {
        public IEnumerable<CustomerMaster> InsertCustomer(CustomerMaster customerMaster);
        public IEnumerable<CustomerMaster> UpdateCustomer(CustomerMaster customerMaster);
        public IEnumerable<CustomerMaster> DeleteCustomer(CustomerMaster customerMaster);
        public IEnumerable<CustomerMaster> GetAllCustomer();
        public IEnumerable<CustomerMaster> GetAllCustomerById(int id);
    }
}
