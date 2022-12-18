using Inspire.Erp.Domain.Entities;
using Inspire.Erp.Infrastructure.Database.Repositoy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inspire.Erp.Application.Master
{
   public class CustomerMasterService: ICustomerMasterService
    {
        private IRepository<CustomerMaster> customerrepository;
        public CustomerMasterService(IRepository<CustomerMaster> _customerrepository)
        {
            customerrepository = _customerrepository;
        }
        public IEnumerable<CustomerMaster> InsertCustomer(CustomerMaster customerMaster)
        {
            bool valid = false;
            try
            {
                valid = true;
                int mxc = 0;
                mxc = customerrepository.GetAsQueryable().Where(k => k.CustomerMasterCustomerNo != null).Select(x => x.CustomerMasterCustomerNo).Max();
                if (mxc == null) { mxc = 1; } else { mxc = mxc + 1; }

                customerMaster.CustomerMasterCustomerNo = mxc;
                customerrepository.Insert(customerMaster);
            }
            catch (Exception ex)
            {
                valid = false;
                throw ex;

            }
            finally
            {
                //customerrepository.Dispose();
            }
            return this.GetAllCustomer();
        }
        public IEnumerable<CustomerMaster> UpdateCustomer(CustomerMaster customerMaster)
        {
            bool valid = false;
            try
            {
                customerrepository.Update(customerMaster);
                valid = true;

            }
            catch (Exception ex)
            {
                valid = false;
                throw ex;

            }
            finally
            {
                //customerrepository.Dispose();
            }
            return this.GetAllCustomer();
        }
        public IEnumerable<CustomerMaster> DeleteCustomer(CustomerMaster customerMaster)
        {
            bool valid = false;
            try
            {
                customerrepository.Delete(customerMaster);
                valid = true;

            }
            catch (Exception ex)
            {
                valid = false;
                throw ex;

            }
            finally
            {
                //customerrepository.Dispose();
            }
            return this.GetAllCustomer();
        }
        public IEnumerable<CustomerMaster> GetAllCustomer()
        {
            IEnumerable<CustomerMaster> customerMasters;
            try
            {
                customerMasters = customerrepository.GetAll();

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                //customerrepository.Dispose();
            }
            return customerMasters;
        }

        public IEnumerable<CustomerMaster> GetAllCustomerById(int id)
        {
            IEnumerable<CustomerMaster> customerMasters;
            try
            {
                customerMasters = customerrepository.GetAsQueryable().Where(k => k.CustomerMasterCustomerNo == id).Select(k => k);

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                //cityrepository.Dispose();
            }
            return customerMasters;

        }
    }
}
