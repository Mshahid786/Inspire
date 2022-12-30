using Inspire.Erp.Application.Common;
using Inspire.Erp.Domain.Entities;
using Inspire.Erp.Infrastructure.Database.Repositoy;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inspire.Erp.Application.Master

{
    public class SupplierMasterService : ISupplierMasterService
    {
        private readonly IRepository<SuppliersMaster> supplierrepository;
        private readonly IRepository<PurchaseVoucherDetails> pVoucherDetailsrepo;
        private readonly IRepository<PurchaseVoucher> pVoucherrepo;

        public SupplierMasterService(IRepository<SuppliersMaster> _supplierrepository, IRepository<PurchaseVoucher> _pVoucherrepo,
                                     IRepository<PurchaseVoucherDetails> _pVoucherDetailsrepo)
        {
            supplierrepository = _supplierrepository;
            pVoucherDetailsrepo = _pVoucherDetailsrepo;
            pVoucherrepo = _pVoucherrepo;
        }
        public IEnumerable<SuppliersMaster> InsertSupplier(SuppliersMaster SuppliersMaster)
        {
            bool valid = false;
            try
            {
                valid = true;
                int mxc = 0;
                mxc = (int)supplierrepository.GetAsQueryable().Where(k => k.SuppliersMasterSupplierId != null).Select(x => x.SuppliersMasterSupplierId).Max();
                if (mxc == null) { mxc = 1; } else { mxc = mxc + 1; }

                SuppliersMaster.SuppliersMasterSupplierId = mxc;
                supplierrepository.Insert(SuppliersMaster);
            }
            catch (Exception ex)
            {
                valid = false;
                throw ex;

            }
            finally
            {
                //currencyrepository.Dispose();
            }
            return this.GetAllSupplier();
        }
        public IEnumerable<SuppliersMaster> UpdateSupplier(SuppliersMaster SuppliersMaster)
        {
            bool valid = false;
            try
            {
                supplierrepository.Update(SuppliersMaster);
                valid = true;

            }
            catch (Exception ex)
            {
                valid = false;
                throw ex;

            }
            finally
            {
                //currencyrepository.Dispose();
            }
            return this.GetAllSupplier();
        }
        public IEnumerable<SuppliersMaster> DeleteSupplier(SuppliersMaster SuppliersMaster)
        {
            bool valid = false;
            try
            {
                supplierrepository.Delete(SuppliersMaster);
                valid = true;

            }
            catch (Exception ex)
            {
                valid = false;
                throw ex;

            }
            finally
            {
                //currencyrepository.Dispose();
            }
            return this.GetAllSupplier();
        }

        public IEnumerable<SuppliersMaster> GetAllSupplier()
        {
            IEnumerable<SuppliersMaster> SuppliersMaster;
            try
            {
                SuppliersMaster = supplierrepository.GetAll();

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                //currencyrepository.Dispose();
            }
            return SuppliersMaster;
        }
        public IEnumerable<SuppliersMaster> GetAllSupplierById(int id)
        {
            IEnumerable<SuppliersMaster> SuppliersMaster;
            try
            {
                SuppliersMaster = supplierrepository.GetAsQueryable().Where(k => k.SuppliersMasterSupplierId == id).Select(k => k);

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                //cityrepository.Dispose();
            }
            return SuppliersMaster;

        }

        public IEnumerable<ItemMasterSupplierDetais> GetUpdatedSupplierDetailsByItem(int itemId)
        {
            //Select max(Pur_dt),MAX(PD.rate) as Rate,(isnull(S.INS_Code, '') + ' :: ' + S.INS_Name) as INS_Name from Purchase_Voucher_Details PD INNER JOIN
            //Purchase_Voucher P ON P.purchaseid = PD.purchaseid INNER JOIN Suppliers S ON P.Sp_Id = S.INS_ID Where mat_id = (Selectiing Items ItemID)

            IEnumerable<ItemMasterSupplierDetais> supplierDetails = (from PD in pVoucherDetailsrepo.GetAsQueryable()
                    join P in pVoucherrepo.GetAsQueryable()
                    on PD.PurchaseVoucherDetailsPurchaseId equals P.PurchaseVoucherPurchaseId
                    join S in supplierrepository.GetAsQueryable()
                    on P.PurchaseVoucherSpId equals S.SuppliersMasterSupplierId
                    where PD.PurchaseVoucherDetailsMaterialId == itemId
                    select new
                    {
                        Supplier = S.SuppliersMasterSupplierName,
                        SupplierId = S.SuppliersMasterSupplierId,
                        PurchaseDate = P.PurchaseVoucherPurchaseDate,
                        Rate = PD.PurchaseVoucherDetailsRate
                    }).GroupBy(arg => new
                    {
                        arg.Supplier,
                        arg.SupplierId
                    }).Select(grouping => new ItemMasterSupplierDetais
                    {
                        Supplier = grouping.Key.Supplier,
                        SupplierId=  (int) grouping.Key.SupplierId,
                        PurchaseDate = Convert.ToDateTime(grouping.Max(arg => arg.PurchaseDate)),
                        Rate = (float)grouping.Max(arg => arg.Rate)
                    });

     
            return supplierDetails;
        }


    }
}
